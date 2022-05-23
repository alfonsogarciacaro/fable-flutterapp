module Main

open Flutter
open Flutter.Material
open Elmish
open Elmish.Flutter

// Simple Todo app based on https://www.section.io/engineering-education/how-to-build-a-flutter-todo-app/
module App =
    type Todo = {
        title: string
    }

    type Model = {
        todos: Todo list
    }

    type Msg =
        | AddTodo of title: string

    let init(): Model * Cmd<Msg> =
        { todos = [] }, Cmd.none

    let update msg model: Model * Cmd<Msg> =
        match msg with
        | AddTodo title -> { todos = { title = title }::model.todos }, Cmd.none

    let displayDialog textController dispatch (context: BuildContext) =
        Material.showDialog(
            context = context,
            builder = (fun context ->
                AlertDialog(
                    title = Text("Add a task to your list"),
                    content = TextField(
                        controller = textController,
                        decoration = InputDecoration(
                            hintText = "Enter task here"
                        )
                    ),
                    actions = [|
                        MaterialButton(
                            child = Text("ADD"),
                            onPressed = fun () ->
                                Navigator.``of``(context).pop()
                                let text = textController.text
                                textController.clear()
                                text |> AddTodo |> dispatch
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

    let _textController = TextEditingController()

    let buildTodos (model: Model): Widget[] =
        model.todos
        |> List.map (fun t -> ListTile(Text(t.title)) :> Widget)
        |> List.toArray

    let view (model: Model) (dispatch: Msg -> unit) context: Widget =
        Scaffold(
            appBar = AppBar(Text("F# loves Flutter")),
            body = ListView(buildTodos model),
            floatingActionButton = FloatingActionButton(
                Icon(Icons.add),
                tooltip = "Add Item",
                onPressed = fun () ->
                    displayDialog _textController dispatch context |> ignore
            )
        )

open App

type MyApp(?key: Key) =
    inherit StatelessWidget(?key=key)
    override _.build(context) =
        MaterialApp(
            title = "Welcome to Flutter",
            home = ElmishWidget.From(init, update, view)
        )

let main() =
    MyApp() |> Material.runApp
