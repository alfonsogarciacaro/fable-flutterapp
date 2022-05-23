namespace Elmish.Flutter

open Elmish
open Flutter.Material

type Dispatch<'Msg> = 'Msg -> unit
type Init<'Arg, 'Model, 'Msg> = 'Arg -> 'Model * Cmd<'Msg>
type Update<'Model, 'Msg> = 'Msg -> 'Model -> 'Model * Cmd<'Msg>
type View<'Model, 'Msg> = 'Model -> Dispatch<'Msg> -> (BuildContext -> Widget)

type ElmishState<'Arg, 'Model, 'Msg>() =
    inherit State<ElmishWidget<'Arg, 'Model, 'Msg>>()
    let mutable _state: ('Model * Dispatch<'Msg>) option = None

    override this.build(context) =
        let program = this.widget.Program

        match _state with
        | Some(model, dispatch) ->
            (Program.view program) model dispatch context
        | None ->
            let model, cmd = Program.init program this.widget.Arg

            program
            |> Program.map (fun _ () -> model, cmd) id id id id id
            |> Program.withSetState (fun model dispatch ->
                this.setState(fun () -> _state <- Some(model, dispatch))
            )
            |> Program.run

            let dispatch = snd _state.Value
            (Program.view program) model dispatch context

and ElmishWidget<'Arg, 'Model, 'Msg> (program: Program<'Arg, 'Model, 'Msg, (BuildContext -> Widget)>, arg: 'Arg, ?key) =
    inherit StatefulWidget(?key=key)

    member _.Program: Program<'Arg, 'Model, 'Msg, (BuildContext -> Widget)> = program
    member _.Arg: 'Arg = arg

    override _.createState() =
        ElmishState<'Arg, 'Model, 'Msg>() :> State

type ElmishWidget =
    static member From(init: Init<'Arg, 'Model, 'Msg>, update: Update<'Model, 'Msg>, view: View<'Model, 'Msg>, arg: 'Arg) =
        ElmishWidget<'Arg, 'Model, 'Msg>(Program.mkProgram init update view, arg)

    static member From(init: (unit -> 'Model * Cmd<'Msg>), update: Update<'Model, 'Msg>, view: View<'Model, 'Msg>) =
        // TODO: we need to wrap 0-arity functions when casted to generic ones
        let init _ = init()
        ElmishWidget<unit, 'Model, 'Msg>(Program.mkProgram init update view, ())
