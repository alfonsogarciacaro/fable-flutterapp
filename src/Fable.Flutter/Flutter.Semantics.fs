namespace rec Flutter.Semantics

open System.Collections.Generic
open Fable.Core
open Fable.Core.Dart
open Dart
open Flutter.Foundation
open Flutter.Services

/// https://api.flutter.dev/flutter/semantics/DebugSemanticsDumpOrder.html
[<ImportMember("package:flutter/semantics.dart")>]
type DebugSemanticsDumpOrder =
  [<IsConst>] static member inverseHitTest: DebugSemanticsDumpOrder = nativeOnly
  [<IsConst>] static member traversalOrder: DebugSemanticsDumpOrder = nativeOnly
  [<IsConst>] static member values: DebugSemanticsDumpOrder = nativeOnly

/// https://api.flutter.dev/flutter/semantics/SemanticsTag-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsTag [<IsConst>] (name: string) =
  class end

/// https://api.flutter.dev/flutter/semantics/CustomSemanticsAction-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type CustomSemanticsAction [<IsConst; NamedParams>] (label: string) =
  [<IsConst; NamedParams>] static member overridingAction(hint: string, action: SemanticsAction): CustomSemanticsAction = nativeOnly

/// https://api.flutter.dev/flutter/semantics/AttributedString-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type AttributedString [<NamedParams(fromIndex=1)>] (string: string, ?attributes: StringAttribute[]) =
  class end

/// https://api.flutter.dev/flutter/semantics/AttributedStringProperty-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type AttributedStringProperty [<NamedParams(fromIndex=2)>] (name: string, value: AttributedString option, ?showName: bool, ?showWhenEmpty: bool, ?defaultValue: obj, ?level: DiagnosticLevel, ?description: string) =
  class end

/// https://api.flutter.dev/flutter/semantics/SemanticsData-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsData [<NamedParams>] (flags: int, actions: int, attributedLabel: AttributedString, attributedValue: AttributedString, attributedIncreasedValue: AttributedString, attributedDecreasedValue: AttributedString, attributedHint: AttributedString, textDirection: TextDirection option, rect: Rect, elevation: float, thickness: float, textSelection: TextSelection option, scrollIndex: int option, scrollChildCount: int option, scrollPosition: float option, scrollExtentMax: float option, scrollExtentMin: float option, platformViewId: int option, maxValueLength: int option, currentValueLength: int option, ?tags: HashSet<SemanticsTag>, ?transform: Matrix4, ?customSemanticsActionIds: int[]) =
  class end

/// https://api.flutter.dev/flutter/semantics/SemanticsHintOverrides-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsHintOverrides [<IsConst; NamedParams>] (?onTapHint: string, ?onLongPressHint: string) =
  class end

/// https://api.flutter.dev/flutter/semantics/SemanticsProperties-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsProperties [<IsConst; NamedParams>] (?enabled: bool, ?``checked``: bool, ?selected: bool, ?toggled: bool, ?button: bool, ?link: bool, ?header: bool, ?textField: bool, ?slider: bool, ?keyboardKey: bool, ?readOnly: bool, ?focusable: bool, ?focused: bool, ?inMutuallyExclusiveGroup: bool, ?hidden: bool, ?obscured: bool, ?multiline: bool, ?scopesRoute: bool, ?namesRoute: bool, ?image: bool, ?liveRegion: bool, ?maxValueLength: int, ?currentValueLength: int, ?label: string, ?attributedLabel: AttributedString, ?value: string, ?attributedValue: AttributedString, ?increasedValue: string, ?attributedIncreasedValue: AttributedString, ?decreasedValue: string, ?attributedDecreasedValue: AttributedString, ?hint: string, ?attributedHint: AttributedString, ?hintOverrides: SemanticsHintOverrides, ?textDirection: TextDirection, ?sortKey: SemanticsSortKey, ?tagForChildren: SemanticsTag, ?onTap: (unit -> unit), ?onLongPress: (unit -> unit), ?onScrollLeft: (unit -> unit), ?onScrollRight: (unit -> unit), ?onScrollUp: (unit -> unit), ?onScrollDown: (unit -> unit), ?onIncrease: (unit -> unit), ?onDecrease: (unit -> unit), ?onCopy: (unit -> unit), ?onCut: (unit -> unit), ?onPaste: (unit -> unit), ?onMoveCursorForwardByCharacter: (bool -> unit), ?onMoveCursorBackwardByCharacter: (bool -> unit), ?onMoveCursorForwardByWord: (bool -> unit), ?onMoveCursorBackwardByWord: (bool -> unit), ?onSetSelection: (TextSelection -> unit), ?onSetText: (string -> unit), ?onDidGainAccessibilityFocus: (unit -> unit), ?onDidLoseAccessibilityFocus: (unit -> unit), ?onDismiss: (unit -> unit), ?customSemanticsActions: Dictionary<CustomSemanticsAction, (unit -> unit)>) =
  class end

/// https://api.flutter.dev/flutter/semantics/SemanticsNode-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsNode [<NamedParams>] (?key: Key, ?showOnScreen: (unit -> unit)) =
  [<NamedParams>] static member root(owner: SemanticsOwner, ?key: Key, ?showOnScreen: (unit -> unit)): SemanticsNode = nativeOnly

/// https://api.flutter.dev/flutter/semantics/SemanticsOwner-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsOwner () =
  class end

/// https://api.flutter.dev/flutter/semantics/SemanticsConfiguration-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsConfiguration () =
  class end

/// https://api.flutter.dev/flutter/semantics/SemanticsSortKey-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsSortKey [<IsConst; NamedParams>] (?name: string) =
  class end

/// https://api.flutter.dev/flutter/semantics/OrdinalSortKey-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type OrdinalSortKey [<IsConst; NamedParams(fromIndex=1)>] (order: float, ?name: string) =
  class end

/// https://api.flutter.dev/flutter/semantics/SemanticsEvent-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsEvent [<IsConst>] (``type``: string) =
  class end

/// https://api.flutter.dev/flutter/semantics/AnnounceSemanticsEvent-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type AnnounceSemanticsEvent [<IsConst>] (message: string, textDirection: TextDirection) =
  class end

/// https://api.flutter.dev/flutter/semantics/TooltipSemanticsEvent-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type TooltipSemanticsEvent [<IsConst>] (message: string) =
  class end

/// https://api.flutter.dev/flutter/semantics/LongPressSemanticsEvent-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type LongPressSemanticsEvent [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/semantics/TapSemanticEvent-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type TapSemanticEvent [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/semantics/SemanticsService-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsService =
  class end

