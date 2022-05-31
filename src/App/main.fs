module Main

open Flutter.Foundation
open Flutter.Widgets
open Flutter.Material
open Flutter.Services

open Elmish
open Elmish.Flutter

// Simple Todo app based on https://www.section.io/engineering-education/how-to-build-a-flutter-todo-app/
module App =
    type Todo = {
        id: int
        title: string
    }

    type Model = {
        todos: Todo list
    }

    type Msg =
        | AddTodo of title: string
        | DeleteTodo of id: int
        | EditTodo of id: int * text: string

    let init(): Model * Cmd<Msg> =
        { todos = [] }, Cmd.none

    let update msg model: Model * Cmd<Msg> =
        match msg with
        | AddTodo title ->
            let id =
                if List.isEmpty model.todos
                then 0
                else model.todos |> List.maxBy (fun t -> t.id) |> fun t -> t.id + 1
            { model with todos = { id = id; title = title }::model.todos }, Cmd.none

        | DeleteTodo id ->
            let todos = model.todos |> List.filter (fun t -> t.id <> id)
            { model with todos = todos }, Cmd.none

        | EditTodo(id, title) ->
            let todos = model.todos |> List.map (fun t ->
                if t.id = id then { t with title = title } else t)
            { model with todos = todos }, Cmd.none

    let displayDialog text dispatch (context: BuildContext) =
        Material.showDialog(
            context = context,
            builder = (fun context ->
                AlertDialog(
                    title = Text("Add a task to your list"),
                    content = TextFormField(
                        initialValue = text,
                        autofocus = true,
                        textInputAction = TextInputAction.``done``,
                        onFieldSubmitted = (fun text ->
                            Navigator.``of``(context).pop()
                            text |> dispatch
                        ),
                        decoration = InputDecoration(
                            hintText = "Enter task here"
                        )
                    ),
                    actions = [|
                        MaterialButton(
                            child = Text("CANCEL"),
                            onPressed = fun () ->
                                Navigator.``of``(context).pop()
                        )
                    |]
                )
            )
        )

    let buildTodos (model: Model) dispatch context =
        let todos =
            model.todos
            |> List.map (fun t ->
                ListTile(title = Row [|
                    Expanded(Text(t.title))
                    IconButton(
                        icon = Icon(Icons.edit),
                        onPressed = fun () ->
                            let dispatch text = EditTodo(t.id, text) |> dispatch
                            displayDialog t.title dispatch context |> ignore
                    )
                    IconButton(
                        icon = Icon(Icons.delete),
                        onPressed = fun () -> DeleteTodo t.id |> dispatch
                    )
                |]) :> Widget
            )
            |> List.toArray
        ListView(children=todos)

    let view (model: Model) (dispatch: Msg -> unit) context: Widget =
        Scaffold(
            appBar = AppBar(title = Text("F# loves Flutter")),
            body = Row [|
                Expanded(flex=1, child=SizedBox.shrink())
                Expanded(flex=2, child=buildTodos model dispatch context)
                Expanded(flex=1, child=SizedBox.shrink())
            |],
            floatingActionButton = FloatingActionButton(
                child = Icon(Icons.task),
                tooltip = "Add Item",
                onPressed = fun () ->
                    displayDialog "" (AddTodo >> dispatch) context |> ignore
            )
        )

open App
open Fable.Core.Dart

type MyApp [<IsConst>] (?key: Key) =
    inherit StatelessWidget(?key=key)
    override _.build(context) =
        MaterialApp(
            title = "Welcome to Flutter",
            home = ElmishWidget.From(init, update, view)
        )

let main() =
    MyApp() |> Widgets.runApp
