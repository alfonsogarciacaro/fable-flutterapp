namespace Flutter

open Fable.Core
open Fable.Core.Dart

module Material =
    let [<Literal>] PATH = "package:flutter/material.dart"

    [<ImportMember(PATH)>]
    type Key = interface end

    [<ImportMember(PATH)>]
    type BuildContext = interface end

    [<ImportMember(PATH)>]
    type Widget = interface end

    type WidgetBuilder = BuildContext -> Widget

    [<ImportMember(PATH)>]
    type Decoration = interface end

    [<ImportMember(PATH); AbstractClass>]
    type StatelessWidget [<NamedParams>] (?key: Key) =
        abstract build: BuildContext -> Widget
        interface Widget

    // This is an abstract class but I declare it as an interface
    // because we only need to inherit from State<'T>
    [<ImportMember(PATH)>]
    type State =
        interface end

    [<ImportMember(PATH); AbstractClass>]
    type State<'Widget> () =
        abstract build: BuildContext -> Widget
        member _.setState(f: unit -> unit): unit = nativeOnly
        member _.widget: 'Widget = nativeOnly
        interface State

    [<ImportMember(PATH); AbstractClass>]
    type StatefulWidget [<NamedParams>] (?key: Key) =
        abstract createState: unit -> State
        interface Widget

    [<ImportMember(PATH)>]
    type MaterialApp [<NamedParams>] (
            ?title: string,
            ?home: Widget
        ) =
        interface Widget

    [<ImportMember(PATH)>]
    type Navigator =
        member _.pop(): unit = nativeOnly
        static member ``of``(context: BuildContext): Navigator = nativeOnly

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

    [<ImportMember(PATH)>]
    type TextEditingController  (?text : string) =
        member _.text: string = nativeOnly
        member _.clear(): unit = nativeOnly
        // inherit ValueNotifier<TextEditingValue>(jsNative)
        // static member fromValue(value : TextEditingValue) : TextEditingController = jsNative

    [<ImportMember(PATH); IsConst>]
    type TextField [<NamedParams>] (
        controller: TextEditingController,
        decoration: Decoration
    ) =
        interface Widget

    [<ImportMember(PATH); IsConst>]
    type InputDecoration [<NamedParams>] (
        hintText: string
    ) = interface Decoration

    [<ImportMember(PATH); IsConst>]
    type FloatingActionButton [<NamedParams>] (child: Widget, ?onPressed: unit->unit, ?tooltip: string) =
        interface Widget

    [<ImportMember(PATH); IsConst>]
    type MaterialButton [<NamedParams>] (child: Widget, ?onPressed: unit->unit, ?tooltip: string) =
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

    [<ImportMember(PATH)>]
    type ListTile [<NamedParams>] (title : Widget) =
        interface Widget

    [<ImportMember(PATH)>]
    type ListView [<NamedParams>] (children : Widget[]) =
        interface Widget

    [<ImportMember(PATH)>]
    type AlertDialog [<NamedParams>] (title : Widget, content: Widget, actions: Widget[]) =
        interface Widget


open Material

[<ImportAll(Material.PATH)>]
type Material =
    static member runApp(w: Widget): unit = jsNative

    [<NamedParams>]
    static member showDialog<'Widget when 'Widget :> Widget>(
        context: BuildContext,
        builder: BuildContext -> 'Widget
    ): Future<'Widget option> = jsNative
