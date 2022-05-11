module Main

open Fable.Core
open Flutter.Material

module Elmish =
    type Dispatch<'Msg> = 'Msg -> unit
    type Cmd<'Msg> = (Dispatch<'Msg> -> unit) list
    type Init<'Model, 'Msg> = unit -> 'Model * Cmd<'Msg>
    type Update<'Model, 'Msg> = delegate of 'Msg * 'Model -> 'Model * Cmd<'Msg>
    type View<'Model, 'Msg> = delegate of 'Model * Dispatch<'Msg> -> Widget

    type ElmishState<'Model, 'Msg> (init: Init<'Model, 'Msg>, update: Update<'Model, 'Msg>, view: View<'Model, 'Msg>) =
        inherit State<ElmishWidget<'Model, 'Msg>>()
        // Ignore async commands for now
        let mutable _state = init() |> fst
        override this.build(context) =
            let dispatch (msg: 'Msg) =
                this.setState(fun () ->
                    // Ignore async commands for now
                    _state <- update.Invoke(msg, _state) |> fst)            
            view.Invoke(_state, dispatch)

    and ElmishWidget<'Model, 'Msg> (init: Init<'Model, 'Msg>, update: Update<'Model, 'Msg>, view: View<'Model, 'Msg>, ?key) =
        inherit StatefulWidget(?key=key)
        override _.createState() =
            ElmishState(init, update, view) :> StatefulElement

open Elmish

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

type MyApp(?key: Key) =
    inherit StatelessWidget(?key=key)
    override _.build(context) =
        MaterialApp( 
            title = "Welcome to Flutter",
            home = ElmishWidget(init, update, view)
        )

let main() =
    MyApp() |> runApp
