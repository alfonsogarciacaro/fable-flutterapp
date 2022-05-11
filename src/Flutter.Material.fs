module Flutter.Material

open Fable.Core
open Fable.Core.Dart
type NamedParamsAttribute = ParamObjectAttribute

let [<Literal>] PATH = "package:flutter/material.dart"

[<ImportMember(PATH)>]
type Key = interface end

[<ImportMember(PATH)>]
type BuildContext = interface end

[<ImportMember(PATH)>]
type Widget = interface end

[<ImportMember(PATH)>]
type MaterialApp [<NamedParams>] (
        ?title: string,
        ?home: Widget
    ) =
    interface Widget

[<ImportMember(PATH)>]
type Scaffold [<NamedParams>] (
        ?appBar: Widget,
        ?body: Widget,
        ?floatingActionButton: Widget
    ) =
    interface Widget

[<ImportMember(PATH)>]
type AppBar [<NamedParams>] (?title: Widget) =
    interface Widget

[<ImportMember(PATH); IsConst>]
type Center [<NamedParams>] (?child: Widget) =
    interface Widget

[<ImportMember(PATH)>]
type MainAxisAlignment =
    static member start: MainAxisAlignment = jsNative
    static member center: MainAxisAlignment = jsNative
    static member ``end``: MainAxisAlignment = jsNative

[<ImportMember(PATH); IsConst>]
type Column [<NamedParams>] (children: Widget[], ?mainAxisAlignment: MainAxisAlignment) =
    interface Widget

[<ImportMember(PATH); IsConst>]
type Text(text: string) =
    interface Widget

[<ImportMember(PATH); IsConst>]
type FloatingActionButton [<NamedParams>] (child: Widget, ?onPressed: unit->unit, ?tooltip: string) =
    interface Widget

[<ImportMember(PATH)>]
type IconData =
    interface end

[<ImportMember(PATH)>]
type Icons =
    [<IsConst>] static member add: IconData = jsNative
    [<IsConst>] static member remove: IconData = jsNative

[<ImportMember(PATH); IsConst>]
type Icon(icon: IconData) =
    interface Widget

[<ImportMember(PATH); AbstractClass>]
type StatelessWidget [<NamedParams>] (?key: Key) =
    abstract build: BuildContext -> Widget
    interface Widget

// // This is actually an abstract class but I declare it as an interface
// // because we actually inherit from State<'T>
// [<ImportMember(PATH)>]
// type StatefulElement =
//     interface end

// [<ImportMember(PATH); AbstractClass>]
// type State<'T> () =
//     abstract build: BuildContext -> Widget
//     member _.setState(f: unit -> unit) = ()
//     interface StatefulElement

// [<ImportMember(PATH); AbstractClass>]
// type StatefulWidget [<NamedParams>] (?key: Key) =
//     abstract createState: unit -> StatefulElement
//     interface Widget

[<ImportMember(PATH)>]
let runApp(w: Widget): unit = jsNative

type Dispatch<'Msg> = 'Msg -> unit
type Cmd<'Msg> = (Dispatch<'Msg> -> unit) list
type Init<'Model, 'Msg> = unit -> 'Model * Cmd<'Msg>
type Update<'Model, 'Msg> = 'Msg -> 'Model -> 'Model * Cmd<'Msg>
type View<'Model, 'Msg> = 'Model -> Dispatch<'Msg> -> Widget

[<ImportMember("util/elmish.dart")>]
type ElmishWidget<'Model, 'Msg> (init: Init<'Model, 'Msg>, update: Update<'Model, 'Msg>, view: View<'Model, 'Msg>) =
    interface Widget
