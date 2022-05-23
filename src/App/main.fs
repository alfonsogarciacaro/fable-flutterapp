module Main

open Fable.Core
open Flutter.Material
open Elmish
open Elmish.Flutter

module App =
    type Model = int
    type Msg = Increment | Decrement

    let init(): Model * Cmd<Msg> = 0, []

    let update msg model: Model * Cmd<Msg> =
        match msg with
        | Increment -> model + 1, []
        | Decrement -> model - 1, []

    let view (model: Model) (dispatch: Msg -> unit): Widget =
        Scaffold(
            appBar = AppBar(Text("F# loves Flutter")),
            body = Center(
                Column(
                    mainAxisAlignment = MainAxisAlignment.center,
                    children = [|
                        Text("You have pushed the button this many times:")
                        Text(string model)
                    |]
                )),
            floatingActionButton = FloatingActionButton(
                Icon(Icons.add),
                onPressed = (fun () -> dispatch Increment)
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
    MyApp() |> runApp
