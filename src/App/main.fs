module Main

open Flutter
open Flutter.Material
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

    // Where should this be? In the model?
    // In "standard" Dart it would likely be a private field of the widget class
    let _textController = TextEditingController()

    let displayDialog text dispatch (context: BuildContext) =
        _textController.text <- text
        Material.showDialog(
            context = context,
            builder = (fun context ->
                AlertDialog(
                    title = Text("Add a task to your list"),
                    content = TextField(
                        controller = _textController,
                        decoration = InputDecoration(
                            hintText = "Enter task here"
                        )
                    ),
                    actions = [|
                        MaterialButton(
                            child = Text("ADD"),
                            onPressed = fun () ->
                                Navigator.``of``(context).pop()
                                let text = _textController.text
                                _textController.clear()
                                text |> dispatch
                        )
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
        model.todos
        |> List.map (fun t ->
            ListTile(
                Row [|
                    Expanded(Text(t.title))
                    IconButton(Icon(Icons.edit), onPressed = fun () ->
                        let dispatch text = EditTodo(t.id, text) |> dispatch
                        displayDialog t.title dispatch context |> ignore
                    )
                    IconButton(Icon(Icons.delete), onPressed = fun () ->
                        DeleteTodo t.id |> dispatch)
                |]
            ) :> Widget
        )
        |> List.toArray
        |> ListView

    let view (model: Model) (dispatch: Msg -> unit) context: Widget =
        Scaffold(
            appBar = AppBar(Text("F# loves Flutter")),
            body = buildTodos model dispatch context,
            floatingActionButton = FloatingActionButton(
                Icon(Icons.add),
                tooltip = "Add Item",
                onPressed = fun () ->
                    displayDialog "" (AddTodo >> dispatch) context |> ignore
            )
        )

open App
open Fable.Core.Dart

[<IsConst>]
type MyApp(?key: Key) =
    inherit StatelessWidget(?key=key)
    override _.build(context) =
        MaterialApp(
            title = "Welcome to Flutter",
            home = ElmishWidget.From(init, update, view)
        )

let main() =
    MyApp() |> Material.runApp
