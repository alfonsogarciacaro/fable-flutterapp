namespace Flutter.Elmish

open Flutter.Material

type Dispatch<'Msg> = 'Msg -> unit
type Cmd<'Msg> = (Dispatch<'Msg> -> unit) list
type Init<'Model, 'Msg> = unit -> 'Model * Cmd<'Msg>
type Update<'Model, 'Msg> = 'Msg -> 'Model -> 'Model * Cmd<'Msg>
type View<'Model, 'Msg> = 'Model -> Dispatch<'Msg> -> Widget

type ElmishState<'Model, 'Msg>() =
    inherit State<ElmishWidget<'Model, 'Msg>>()
    let mutable _state: 'Model option = None

    override this.build(context) =
        let dispatch msg = 
            this.setState(fun () ->
                // TODO: Handle commands
                _state <- this.widget.update(msg, _state.Value) |> fst |> Some)

        let model =
            match _state with
            | Some m -> m
            | None ->
                // TODO: Handle commands
                let m = this.widget.init() |> fst
                _state <- Some m
                m
        
        this.widget.view(model, dispatch)


and ElmishWidget<'Model, 'Msg> (_init: Init<'Model, 'Msg>, _update: Update<'Model, 'Msg>, _view: View<'Model, 'Msg>, ?key) =
    inherit StatefulWidget(?key=key)

    member _.init(): 'Model * Cmd<'Msg> = _init()
    member _.update(msg: 'Msg, model: 'Model): 'Model * Cmd<'Msg> = _update msg model
    member _.view(model: 'Model, dispatch: Dispatch<'Msg>): Widget = _view model dispatch

    override _.createState() =
        ElmishState<'Model, 'Msg>() :> State