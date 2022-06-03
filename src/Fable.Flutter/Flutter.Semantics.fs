namespace rec Flutter.Semantics

open System.Collections.Generic
open System.Runtime.InteropServices
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
type AttributedString [<NamedParams(fromIndex=1)>] (string: string, [<Optional>] attributes: StringAttribute[]) =
  class end

/// https://api.flutter.dev/flutter/semantics/AttributedStringProperty-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type AttributedStringProperty [<NamedParams(fromIndex=2)>] (name: string, value: DartNullable<AttributedString>, [<Optional>] showName: bool, [<Optional>] showWhenEmpty: bool, [<Optional>] defaultValue: obj, [<Optional>] level: DiagnosticLevel, [<Optional>] description: string) =
  class end

/// https://api.flutter.dev/flutter/semantics/SemanticsData-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsData [<NamedParams>] (flags: int, actions: int, attributedLabel: AttributedString, attributedValue: AttributedString, attributedIncreasedValue: AttributedString, attributedDecreasedValue: AttributedString, attributedHint: AttributedString, textDirection: DartNullable<TextDirection>, rect: Rect, elevation: float, thickness: float, textSelection: DartNullable<TextSelection>, scrollIndex: DartNullable<int>, scrollChildCount: DartNullable<int>, scrollPosition: DartNullable<float>, scrollExtentMax: DartNullable<float>, scrollExtentMin: DartNullable<float>, platformViewId: DartNullable<int>, maxValueLength: DartNullable<int>, currentValueLength: DartNullable<int>, [<Optional>] tags: HashSet<SemanticsTag>, [<Optional>] transform: Matrix4, [<Optional>] customSemanticsActionIds: int[]) =
  class end

/// https://api.flutter.dev/flutter/semantics/SemanticsHintOverrides-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsHintOverrides [<IsConst; NamedParams>] ([<Optional>] onTapHint: string, [<Optional>] onLongPressHint: string) =
  class end

/// https://api.flutter.dev/flutter/semantics/SemanticsProperties-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsProperties [<IsConst; NamedParams>] ([<Optional>] enabled: bool, [<Optional>] ``checked``: bool, [<Optional>] selected: bool, [<Optional>] toggled: bool, [<Optional>] button: bool, [<Optional>] link: bool, [<Optional>] header: bool, [<Optional>] textField: bool, [<Optional>] slider: bool, [<Optional>] keyboardKey: bool, [<Optional>] readOnly: bool, [<Optional>] focusable: bool, [<Optional>] focused: bool, [<Optional>] inMutuallyExclusiveGroup: bool, [<Optional>] hidden: bool, [<Optional>] obscured: bool, [<Optional>] multiline: bool, [<Optional>] scopesRoute: bool, [<Optional>] namesRoute: bool, [<Optional>] image: bool, [<Optional>] liveRegion: bool, [<Optional>] maxValueLength: int, [<Optional>] currentValueLength: int, [<Optional>] label: string, [<Optional>] attributedLabel: AttributedString, [<Optional>] value: string, [<Optional>] attributedValue: AttributedString, [<Optional>] increasedValue: string, [<Optional>] attributedIncreasedValue: AttributedString, [<Optional>] decreasedValue: string, [<Optional>] attributedDecreasedValue: AttributedString, [<Optional>] hint: string, [<Optional>] attributedHint: AttributedString, [<Optional>] hintOverrides: SemanticsHintOverrides, [<Optional>] textDirection: TextDirection, [<Optional>] sortKey: SemanticsSortKey, [<Optional>] tagForChildren: SemanticsTag, [<Optional>] onTap: (unit -> unit), [<Optional>] onLongPress: (unit -> unit), [<Optional>] onScrollLeft: (unit -> unit), [<Optional>] onScrollRight: (unit -> unit), [<Optional>] onScrollUp: (unit -> unit), [<Optional>] onScrollDown: (unit -> unit), [<Optional>] onIncrease: (unit -> unit), [<Optional>] onDecrease: (unit -> unit), [<Optional>] onCopy: (unit -> unit), [<Optional>] onCut: (unit -> unit), [<Optional>] onPaste: (unit -> unit), [<Optional>] onMoveCursorForwardByCharacter: (bool -> unit), [<Optional>] onMoveCursorBackwardByCharacter: (bool -> unit), [<Optional>] onMoveCursorForwardByWord: (bool -> unit), [<Optional>] onMoveCursorBackwardByWord: (bool -> unit), [<Optional>] onSetSelection: (TextSelection -> unit), [<Optional>] onSetText: (string -> unit), [<Optional>] onDidGainAccessibilityFocus: (unit -> unit), [<Optional>] onDidLoseAccessibilityFocus: (unit -> unit), [<Optional>] onDismiss: (unit -> unit), [<Optional>] customSemanticsActions: Dictionary<CustomSemanticsAction, (unit -> unit)>) =
  class end

/// https://api.flutter.dev/flutter/semantics/SemanticsNode-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type SemanticsNode [<NamedParams>] ([<Optional>] key: Key, [<Optional>] showOnScreen: (unit -> unit)) =
  [<NamedParams>] static member root(owner: SemanticsOwner, [<Optional>] key: Key, [<Optional>] showOnScreen: (unit -> unit)): SemanticsNode = nativeOnly

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
type SemanticsSortKey [<IsConst; NamedParams>] ([<Optional>] name: string) =
  class end

/// https://api.flutter.dev/flutter/semantics/OrdinalSortKey-class.html
[<ImportMember("package:flutter/semantics.dart")>]
type OrdinalSortKey [<IsConst; NamedParams(fromIndex=1)>] (order: float, [<Optional>] name: string) =
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

