namespace rec Flutter.Services

open System
open System.Collections.Generic
open System.Runtime.InteropServices
open Fable.Core
open Fable.Core.Dart
open Dart
open Flutter.Gestures

/// https://api.flutter.dev/flutter/services/TextSelectionDelegate-mixin.html
[<ImportMember("package:flutter/services.dart")>]
type TextSelectionDelegate =
  interface end

/// https://api.flutter.dev/flutter/services/KeyDataTransitMode.html
[<ImportMember("package:flutter/services.dart")>]
type KeyDataTransitMode =
  [<IsConst>] static member rawKeyData: KeyDataTransitMode = nativeOnly
  [<IsConst>] static member keyDataThenRawKeyData: KeyDataTransitMode = nativeOnly
  [<IsConst>] static member values: KeyDataTransitMode = nativeOnly

/// https://api.flutter.dev/flutter/services/KeyboardSide.html
[<ImportMember("package:flutter/services.dart")>]
type KeyboardSide =
  [<IsConst>] static member any: KeyboardSide = nativeOnly
  [<IsConst>] static member left: KeyboardSide = nativeOnly
  [<IsConst>] static member right: KeyboardSide = nativeOnly
  [<IsConst>] static member all: KeyboardSide = nativeOnly
  [<IsConst>] static member values: KeyboardSide = nativeOnly

/// https://api.flutter.dev/flutter/services/ModifierKey.html
[<ImportMember("package:flutter/services.dart")>]
type ModifierKey =
  [<IsConst>] static member controlModifier: ModifierKey = nativeOnly
  [<IsConst>] static member shiftModifier: ModifierKey = nativeOnly
  [<IsConst>] static member altModifier: ModifierKey = nativeOnly
  [<IsConst>] static member metaModifier: ModifierKey = nativeOnly
  [<IsConst>] static member capsLockModifier: ModifierKey = nativeOnly
  [<IsConst>] static member numLockModifier: ModifierKey = nativeOnly
  [<IsConst>] static member scrollLockModifier: ModifierKey = nativeOnly
  [<IsConst>] static member functionModifier: ModifierKey = nativeOnly
  [<IsConst>] static member symbolModifier: ModifierKey = nativeOnly
  [<IsConst>] static member values: ModifierKey = nativeOnly

/// https://api.flutter.dev/flutter/services/DeviceOrientation.html
[<ImportMember("package:flutter/services.dart")>]
type DeviceOrientation =
  [<IsConst>] static member portraitUp: DeviceOrientation = nativeOnly
  [<IsConst>] static member landscapeLeft: DeviceOrientation = nativeOnly
  [<IsConst>] static member portraitDown: DeviceOrientation = nativeOnly
  [<IsConst>] static member landscapeRight: DeviceOrientation = nativeOnly
  [<IsConst>] static member values: DeviceOrientation = nativeOnly

/// https://api.flutter.dev/flutter/services/SystemUiOverlay.html
[<ImportMember("package:flutter/services.dart")>]
type SystemUiOverlay =
  [<IsConst>] static member top: SystemUiOverlay = nativeOnly
  [<IsConst>] static member bottom: SystemUiOverlay = nativeOnly
  [<IsConst>] static member values: SystemUiOverlay = nativeOnly

/// https://api.flutter.dev/flutter/services/SystemUiMode.html
[<ImportMember("package:flutter/services.dart")>]
type SystemUiMode =
  [<IsConst>] static member leanBack: SystemUiMode = nativeOnly
  [<IsConst>] static member immersive: SystemUiMode = nativeOnly
  [<IsConst>] static member immersiveSticky: SystemUiMode = nativeOnly
  [<IsConst>] static member edgeToEdge: SystemUiMode = nativeOnly
  [<IsConst>] static member manual: SystemUiMode = nativeOnly
  [<IsConst>] static member values: SystemUiMode = nativeOnly

/// https://api.flutter.dev/flutter/services/SystemSoundType.html
[<ImportMember("package:flutter/services.dart")>]
type SystemSoundType =
  [<IsConst>] static member click: SystemSoundType = nativeOnly
  [<IsConst>] static member alert: SystemSoundType = nativeOnly
  [<IsConst>] static member values: SystemSoundType = nativeOnly

/// https://api.flutter.dev/flutter/services/MaxLengthEnforcement.html
[<ImportMember("package:flutter/services.dart")>]
type MaxLengthEnforcement =
  [<IsConst>] static member none: MaxLengthEnforcement = nativeOnly
  [<IsConst>] static member enforced: MaxLengthEnforcement = nativeOnly
  [<IsConst>] static member truncateAfterCompositionEnds: MaxLengthEnforcement = nativeOnly
  [<IsConst>] static member values: MaxLengthEnforcement = nativeOnly

/// https://api.flutter.dev/flutter/services/SmartDashesType.html
[<ImportMember("package:flutter/services.dart")>]
type SmartDashesType =
  [<IsConst>] static member disabled: SmartDashesType = nativeOnly
  [<IsConst>] static member enabled: SmartDashesType = nativeOnly
  [<IsConst>] static member values: SmartDashesType = nativeOnly

/// https://api.flutter.dev/flutter/services/SmartQuotesType.html
[<ImportMember("package:flutter/services.dart")>]
type SmartQuotesType =
  [<IsConst>] static member disabled: SmartQuotesType = nativeOnly
  [<IsConst>] static member enabled: SmartQuotesType = nativeOnly
  [<IsConst>] static member values: SmartQuotesType = nativeOnly

/// https://api.flutter.dev/flutter/services/TextInputAction.html
[<ImportMember("package:flutter/services.dart")>]
type TextInputAction =
  [<IsConst>] static member none: TextInputAction = nativeOnly
  [<IsConst>] static member unspecified: TextInputAction = nativeOnly
  [<IsConst>] static member ``done``: TextInputAction = nativeOnly
  [<IsConst>] static member go: TextInputAction = nativeOnly
  [<IsConst>] static member search: TextInputAction = nativeOnly
  [<IsConst>] static member send: TextInputAction = nativeOnly
  [<IsConst>] static member next: TextInputAction = nativeOnly
  [<IsConst>] static member previous: TextInputAction = nativeOnly
  [<IsConst>] static member continueAction: TextInputAction = nativeOnly
  [<IsConst>] static member join: TextInputAction = nativeOnly
  [<IsConst>] static member route: TextInputAction = nativeOnly
  [<IsConst>] static member emergencyCall: TextInputAction = nativeOnly
  [<IsConst>] static member newline: TextInputAction = nativeOnly
  [<IsConst>] static member values: TextInputAction = nativeOnly

/// https://api.flutter.dev/flutter/services/TextCapitalization.html
[<ImportMember("package:flutter/services.dart")>]
type TextCapitalization =
  [<IsConst>] static member words: TextCapitalization = nativeOnly
  [<IsConst>] static member sentences: TextCapitalization = nativeOnly
  [<IsConst>] static member characters: TextCapitalization = nativeOnly
  [<IsConst>] static member none: TextCapitalization = nativeOnly
  [<IsConst>] static member values: TextCapitalization = nativeOnly

/// https://api.flutter.dev/flutter/services/FloatingCursorDragState.html
[<ImportMember("package:flutter/services.dart")>]
type FloatingCursorDragState =
  [<IsConst>] static member Start: FloatingCursorDragState = nativeOnly
  [<IsConst>] static member Update: FloatingCursorDragState = nativeOnly
  [<IsConst>] static member End: FloatingCursorDragState = nativeOnly
  [<IsConst>] static member values: FloatingCursorDragState = nativeOnly

/// https://api.flutter.dev/flutter/services/SelectionChangedCause.html
[<ImportMember("package:flutter/services.dart")>]
type SelectionChangedCause =
  [<IsConst>] static member tap: SelectionChangedCause = nativeOnly
  [<IsConst>] static member doubleTap: SelectionChangedCause = nativeOnly
  [<IsConst>] static member longPress: SelectionChangedCause = nativeOnly
  [<IsConst>] static member forcePress: SelectionChangedCause = nativeOnly
  [<IsConst>] static member keyboard: SelectionChangedCause = nativeOnly
  [<IsConst>] static member toolbar: SelectionChangedCause = nativeOnly
  [<IsConst>] static member drag: SelectionChangedCause = nativeOnly
  [<IsConst>] static member scribble: SelectionChangedCause = nativeOnly
  [<IsConst>] static member values: SelectionChangedCause = nativeOnly

/// https://api.flutter.dev/flutter/services/AssetBundle-class.html
[<ImportMember("package:flutter/services.dart")>]
type AssetBundle () =
  class end

/// https://api.flutter.dev/flutter/services/NetworkAssetBundle-class.html
[<ImportMember("package:flutter/services.dart")>]
type NetworkAssetBundle (baseUrl: Uri) =
  class end

/// https://api.flutter.dev/flutter/services/CachingAssetBundle-class.html
[<ImportMember("package:flutter/services.dart")>]
type CachingAssetBundle () =
  class end

/// https://api.flutter.dev/flutter/services/PlatformAssetBundle-class.html
[<ImportMember("package:flutter/services.dart")>]
type PlatformAssetBundle () =
  class end

/// https://api.flutter.dev/flutter/services/BinaryMessenger-class.html
[<ImportMember("package:flutter/services.dart")>]
type BinaryMessenger [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/services/ClipboardData-class.html
[<ImportMember("package:flutter/services.dart")>]
type ClipboardData [<IsConst; NamedParams>] ([<Optional>] text: string) =
  class end

/// https://api.flutter.dev/flutter/services/Clipboard-class.html
[<ImportMember("package:flutter/services.dart")>]
type Clipboard =
  [<IsConst>] static member kTextPlain: string = nativeOnly

/// https://api.flutter.dev/flutter/services/DeferredComponent-class.html
[<ImportMember("package:flutter/services.dart")>]
type DeferredComponent =
  class end

/// https://api.flutter.dev/flutter/services/FontLoader-class.html
[<ImportMember("package:flutter/services.dart")>]
type FontLoader (family: string) =
  class end

/// https://api.flutter.dev/flutter/services/HapticFeedback-class.html
[<ImportMember("package:flutter/services.dart")>]
type HapticFeedback =
  class end

/// https://api.flutter.dev/flutter/services/KeyboardLockMode-class.html
[<ImportMember("package:flutter/services.dart")>]
type KeyboardLockMode =
  [<IsConst>] static member numLock: KeyboardLockMode = nativeOnly
  [<IsConst>] static member scrollLock: KeyboardLockMode = nativeOnly
  [<IsConst>] static member capsLock: KeyboardLockMode = nativeOnly

/// https://api.flutter.dev/flutter/services/KeyEvent-class.html
[<ImportMember("package:flutter/services.dart")>]
type KeyEvent [<IsConst; NamedParams>] (physicalKey: PhysicalKeyboardKey, logicalKey: LogicalKeyboardKey, timeStamp: TimeSpan, [<Optional>] character: string, [<Optional>] synthesized: bool) =
  class end

/// https://api.flutter.dev/flutter/services/KeyDownEvent-class.html
[<ImportMember("package:flutter/services.dart")>]
type KeyDownEvent [<IsConst; NamedParams>] (physicalKey: PhysicalKeyboardKey, logicalKey: LogicalKeyboardKey, timeStamp: TimeSpan, [<Optional>] character: string, [<Optional>] synthesized: bool) =
  class end

/// https://api.flutter.dev/flutter/services/KeyUpEvent-class.html
[<ImportMember("package:flutter/services.dart")>]
type KeyUpEvent [<IsConst; NamedParams>] (physicalKey: PhysicalKeyboardKey, logicalKey: LogicalKeyboardKey, timeStamp: TimeSpan, [<Optional>] synthesized: bool) =
  class end

/// https://api.flutter.dev/flutter/services/KeyRepeatEvent-class.html
[<ImportMember("package:flutter/services.dart")>]
type KeyRepeatEvent [<IsConst; NamedParams>] (physicalKey: PhysicalKeyboardKey, logicalKey: LogicalKeyboardKey, timeStamp: TimeSpan, [<Optional>] character: string) =
  class end

/// https://api.flutter.dev/flutter/services/HardwareKeyboard-class.html
[<ImportMember("package:flutter/services.dart")>]
type HardwareKeyboard () =
  class end

/// https://api.flutter.dev/flutter/services/KeyMessage-class.html
[<ImportMember("package:flutter/services.dart")>]
type KeyMessage [<IsConst>] (events: KeyEvent[], rawEvent: DartNullable<RawKeyEvent>) =
  class end

/// https://api.flutter.dev/flutter/services/KeyEventManager-class.html
[<ImportMember("package:flutter/services.dart")>]
type KeyEventManager (_hardwareKeyboard: HardwareKeyboard, _rawKeyboard: RawKeyboard) =
  class end

/// https://api.flutter.dev/flutter/services/KeyboardKey-class.html
[<ImportMember("package:flutter/services.dart")>]
type KeyboardKey [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/services/LogicalKeyboardKey-class.html
[<ImportMember("package:flutter/services.dart")>]
type LogicalKeyboardKey [<IsConst>] (keyId: int) =
  [<IsConst>] static member valueMask: int = nativeOnly
  [<IsConst>] static member planeMask: int = nativeOnly
  [<IsConst>] static member unicodePlane: int = nativeOnly
  [<IsConst>] static member unprintablePlane: int = nativeOnly
  [<IsConst>] static member flutterPlane: int = nativeOnly
  [<IsConst>] static member startOfPlatformPlanes: int = nativeOnly
  [<IsConst>] static member androidPlane: int = nativeOnly
  [<IsConst>] static member fuchsiaPlane: int = nativeOnly
  [<IsConst>] static member iosPlane: int = nativeOnly
  [<IsConst>] static member macosPlane: int = nativeOnly
  [<IsConst>] static member gtkPlane: int = nativeOnly
  [<IsConst>] static member windowsPlane: int = nativeOnly
  [<IsConst>] static member webPlane: int = nativeOnly
  [<IsConst>] static member glfwPlane: int = nativeOnly
  [<IsConst>] static member space: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member exclamation: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member quote: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numberSign: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member dollar: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member percent: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member ampersand: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member quoteSingle: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member parenthesisLeft: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member parenthesisRight: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member asterisk: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member add: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member comma: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member minus: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member period: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member slash: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit0: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit3: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit4: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit5: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit6: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit7: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit8: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit9: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member colon: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member semicolon: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member less: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member equal: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member greater: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member question: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member at: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member bracketLeft: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member backslash: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member bracketRight: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member caret: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member underscore: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member backquote: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyA: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyB: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyC: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyD: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyE: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyF: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyG: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyH: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyI: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyJ: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyK: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyL: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyM: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyN: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyO: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyP: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyQ: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyR: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyS: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyT: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyU: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyV: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyW: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyX: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyY: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyZ: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member braceLeft: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member bar: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member braceRight: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tilde: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member unidentified: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member backspace: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tab: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member enter: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member escape: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member delete: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member accel: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member altGraph: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member capsLock: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member fn: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member fnLock: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member hyper: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numLock: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member scrollLock: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member superKey: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member symbol: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member symbolLock: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member shiftLevel5: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member arrowDown: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member arrowLeft: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member arrowRight: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member arrowUp: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member ``end``: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member home: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member pageDown: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member pageUp: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member clear: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member copy: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member crSel: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member cut: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member eraseEof: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member exSel: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member insert: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member paste: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member redo: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member undo: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member accept: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member again: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member attn: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member cancel: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member contextMenu: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member execute: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member find: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member help: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member pause: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member play: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member props: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member select: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member zoomIn: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member zoomOut: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member brightnessDown: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member brightnessUp: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member camera: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member eject: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member logOff: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member power: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member powerOff: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member printScreen: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member hibernate: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member standby: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member wakeUp: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member allCandidates: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member alphanumeric: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member codeInput: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member compose: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member convert: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member finalMode: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member groupFirst: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member groupLast: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member groupNext: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member groupPrevious: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member modeChange: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member nextCandidate: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member nonConvert: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member previousCandidate: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member ``process``: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member singleCandidate: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member hangulMode: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member hanjaMode: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member junjaMode: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member eisu: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member hankaku: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member hiragana: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member hiraganaKatakana: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member kanaMode: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member kanjiMode: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member katakana: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member romaji: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member zenkaku: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member zenkakuHankaku: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f3: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f4: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f5: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f6: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f7: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f8: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f9: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f10: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f11: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f12: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f13: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f14: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f15: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f16: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f17: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f18: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f19: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f20: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f21: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f22: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f23: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member f24: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member soft1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member soft2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member soft3: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member soft4: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member soft5: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member soft6: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member soft7: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member soft8: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member close: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mailForward: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mailReply: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mailSend: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaPlayPause: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaStop: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaTrackNext: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaTrackPrevious: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member newKey: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member ``open``: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member print: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member save: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member spellCheck: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioVolumeDown: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioVolumeUp: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioVolumeMute: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchApplication2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchCalendar: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchMail: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchMediaPlayer: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchMusicPlayer: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchApplication1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchScreenSaver: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchSpreadsheet: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchWebBrowser: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchWebCam: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchWordProcessor: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchContacts: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchPhone: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchAssistant: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchControlPanel: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserBack: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserFavorites: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserForward: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserHome: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserRefresh: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserSearch: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserStop: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioBalanceLeft: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioBalanceRight: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioBassBoostDown: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioBassBoostUp: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioFaderFront: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioFaderRear: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioSurroundModeNext: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member avrInput: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member avrPower: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member channelDown: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member channelUp: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member colorF0Red: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member colorF1Green: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member colorF2Yellow: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member colorF3Blue: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member colorF4Grey: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member colorF5Brown: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member closedCaptionToggle: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member dimmer: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member displaySwap: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member exit: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member favoriteClear0: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member favoriteClear1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member favoriteClear2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member favoriteClear3: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member favoriteRecall0: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member favoriteRecall1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member favoriteRecall2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member favoriteRecall3: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member favoriteStore0: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member favoriteStore1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member favoriteStore2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member favoriteStore3: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member guide: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member guideNextDay: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member guidePreviousDay: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member info: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member instantReplay: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member link: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member listProgram: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member liveContent: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member lock: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaApps: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaFastForward: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaLast: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaPause: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaPlay: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaRecord: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaRewind: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaSkip: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member nextFavoriteChannel: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member nextUserProfile: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member onDemand: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member pInPDown: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member pInPMove: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member pInPToggle: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member pInPUp: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member playSpeedDown: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member playSpeedReset: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member playSpeedUp: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member randomToggle: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member rcLowBattery: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member recordSpeedNext: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member rfBypass: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member scanChannelsToggle: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member screenModeNext: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member settings: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member splitScreenToggle: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member stbInput: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member stbPower: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member subtitle: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member teletext: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tv: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvInput: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvPower: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member videoModeNext: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member wink: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member zoomToggle: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member dvr: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaAudioTrack: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaSkipBackward: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaSkipForward: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaStepBackward: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaStepForward: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaTopMenu: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member navigateIn: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member navigateNext: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member navigateOut: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member navigatePrevious: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member pairing: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaClose: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioBassBoostToggle: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioTrebleDown: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioTrebleUp: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member microphoneToggle: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member microphoneVolumeDown: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member microphoneVolumeUp: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member microphoneVolumeMute: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member speechCorrectionList: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member speechInputToggle: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member appSwitch: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member call: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member cameraFocus: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member endCall: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member goBack: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member goHome: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member headsetHook: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member lastNumberRedial: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member notification: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member mannerMode: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member voiceDial: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tv3DMode: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvAntennaCable: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvAudioDescription: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvAudioDescriptionMixDown: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvAudioDescriptionMixUp: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvContentsMenu: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvDataService: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvInputComponent1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvInputComponent2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvInputComposite1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvInputComposite2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvInputHDMI1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvInputHDMI2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvInputHDMI3: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvInputHDMI4: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvInputVGA1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvMediaContext: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvNetwork: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvNumberEntry: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvRadioService: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvSatellite: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvSatelliteBS: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvSatelliteCS: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvSatelliteToggle: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvTerrestrialAnalog: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvTerrestrialDigital: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member tvTimer: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member key11: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member key12: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member suspend: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member resume: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member sleep: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member abort: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member lang1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member lang2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member lang3: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member lang4: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member lang5: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member intlBackslash: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member intlRo: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member intlYen: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member controlLeft: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member controlRight: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member shiftLeft: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member shiftRight: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member altLeft: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member altRight: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member metaLeft: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member metaRight: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member control: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member shift: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member alt: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member meta: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadEnter: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadParenLeft: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadParenRight: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadMultiply: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadAdd: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadComma: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadSubtract: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadDecimal: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadDivide: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad0: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad3: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad4: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad5: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad6: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad7: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad8: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad9: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadEqual: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton3: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton4: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton5: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton6: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton7: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton8: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton9: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton10: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton11: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton12: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton13: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton14: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton15: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton16: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonA: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonB: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonC: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonLeft1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonLeft2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonMode: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonRight1: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonRight2: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonSelect: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonStart: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonThumbLeft: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonThumbRight: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonX: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonY: LogicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonZ: LogicalKeyboardKey = nativeOnly

/// https://api.flutter.dev/flutter/services/PhysicalKeyboardKey-class.html
[<ImportMember("package:flutter/services.dart")>]
type PhysicalKeyboardKey [<IsConst>] (usbHidUsage: int) =
  [<IsConst>] static member hyper: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member superKey: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member fn: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member fnLock: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member suspend: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member resume: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member turbo: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member privacyScreenToggle: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member microphoneMuteToggle: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member sleep: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member wakeUp: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member displayToggleIntExt: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton1: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton2: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton3: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton4: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton5: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton6: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton7: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton8: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton9: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton10: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton11: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton12: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton13: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton14: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton15: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButton16: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonA: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonB: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonC: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonLeft1: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonLeft2: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonMode: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonRight1: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonRight2: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonSelect: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonStart: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonThumbLeft: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonThumbRight: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonX: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonY: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member gameButtonZ: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member usbReserved: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member usbErrorRollOver: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member usbPostFail: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member usbErrorUndefined: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyA: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyB: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyC: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyD: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyE: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyF: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyG: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyH: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyI: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyJ: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyK: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyL: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyM: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyN: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyO: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyP: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyQ: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyR: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyS: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyT: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyU: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyV: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyW: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyX: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyY: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyZ: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit1: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit2: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit3: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit4: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit5: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit6: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit7: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit8: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit9: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member digit0: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member enter: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member escape: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member backspace: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member tab: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member space: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member minus: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member equal: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member bracketLeft: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member bracketRight: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member backslash: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member semicolon: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member quote: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member backquote: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member comma: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member period: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member slash: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member capsLock: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f1: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f2: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f3: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f4: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f5: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f6: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f7: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f8: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f9: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f10: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f11: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f12: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member printScreen: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member scrollLock: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member pause: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member insert: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member home: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member pageUp: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member delete: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member ``end``: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member pageDown: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member arrowRight: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member arrowLeft: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member arrowDown: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member arrowUp: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numLock: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadDivide: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadMultiply: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadSubtract: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadAdd: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadEnter: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad1: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad2: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad3: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad4: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad5: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad6: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad7: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad8: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad9: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpad0: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadDecimal: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member intlBackslash: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member contextMenu: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member power: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadEqual: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f13: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f14: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f15: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f16: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f17: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f18: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f19: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f20: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f21: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f22: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f23: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member f24: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member ``open``: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member help: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member select: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member again: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member undo: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member cut: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member copy: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member paste: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member find: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioVolumeMute: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioVolumeUp: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member audioVolumeDown: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadComma: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member intlRo: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member kanaMode: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member intlYen: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member convert: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member nonConvert: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member lang1: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member lang2: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member lang3: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member lang4: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member lang5: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member abort: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member props: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadParenLeft: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadParenRight: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadBackspace: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadMemoryStore: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadMemoryRecall: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadMemoryClear: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadMemoryAdd: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadMemorySubtract: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadSignChange: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadClear: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member numpadClearEntry: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member controlLeft: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member shiftLeft: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member altLeft: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member metaLeft: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member controlRight: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member shiftRight: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member altRight: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member metaRight: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member info: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member closedCaptionToggle: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member brightnessUp: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member brightnessDown: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member brightnessToggle: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member brightnessMinimum: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member brightnessMaximum: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member brightnessAuto: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member kbdIllumUp: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member kbdIllumDown: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaLast: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchPhone: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member programGuide: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member exit: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member channelUp: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member channelDown: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaPlay: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaPause: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaRecord: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaFastForward: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaRewind: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaTrackNext: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaTrackPrevious: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaStop: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member eject: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaPlayPause: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member speechInputToggle: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member bassBoost: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mediaSelect: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchWordProcessor: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchSpreadsheet: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchMail: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchContacts: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchCalendar: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchApp2: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchApp1: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchInternetBrowser: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member logOff: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member lockScreen: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchControlPanel: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member selectTask: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchDocuments: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member spellCheck: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchKeyboardLayout: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchScreenSaver: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchAudioBrowser: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member launchAssistant: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member newKey: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member close: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member save: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member print: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserSearch: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserHome: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserBack: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserForward: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserStop: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserRefresh: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member browserFavorites: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member zoomIn: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member zoomOut: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member zoomToggle: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member redo: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mailReply: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mailForward: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member mailSend: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member keyboardLayoutSelect: PhysicalKeyboardKey = nativeOnly
  [<IsConst>] static member showAllWindows: PhysicalKeyboardKey = nativeOnly

/// https://api.flutter.dev/flutter/services/MessageCodec-class.html
[<ImportMember("package:flutter/services.dart")>]
type MessageCodec<'T> () =
  class end

/// https://api.flutter.dev/flutter/services/MethodCall-class.html
[<ImportMember("package:flutter/services.dart")>]
type MethodCall [<IsConst>] (method: string, [<Optional>] arguments: obj) =
  class end

/// https://api.flutter.dev/flutter/services/MethodCodec-class.html
[<ImportMember("package:flutter/services.dart")>]
type MethodCodec () =
  class end

/// https://api.flutter.dev/flutter/services/BinaryCodec-class.html
[<ImportMember("package:flutter/services.dart")>]
type BinaryCodec [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/services/StringCodec-class.html
[<ImportMember("package:flutter/services.dart")>]
type StringCodec [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/services/JSONMessageCodec-class.html
[<ImportMember("package:flutter/services.dart")>]
type JSONMessageCodec [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/services/JSONMethodCodec-class.html
[<ImportMember("package:flutter/services.dart")>]
type JSONMethodCodec [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/services/StandardMessageCodec-class.html
[<ImportMember("package:flutter/services.dart")>]
type StandardMessageCodec [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/services/StandardMethodCodec-class.html
[<ImportMember("package:flutter/services.dart")>]
type StandardMethodCodec [<IsConst>] ([<Optional>] messageCodec: StandardMessageCodec) =
  class end

/// https://api.flutter.dev/flutter/services/MouseCursorManager-class.html
[<ImportMember("package:flutter/services.dart")>]
type MouseCursorManager (fallbackMouseCursor: MouseCursor) =
  class end

/// https://api.flutter.dev/flutter/services/MouseCursorSession-class.html
[<ImportMember("package:flutter/services.dart")>]
type MouseCursorSession (cursor: MouseCursor, device: int) =
  class end

/// https://api.flutter.dev/flutter/services/MouseCursor-class.html
[<ImportMember("package:flutter/services.dart")>]
type MouseCursor [<IsConst>] () =
  [<IsConst>] static member defer: MouseCursor = nativeOnly
  [<IsConst>] static member uncontrolled: MouseCursor = nativeOnly

/// https://api.flutter.dev/flutter/services/SystemMouseCursor-class.html
[<ImportMember("package:flutter/services.dart")>]
type SystemMouseCursor =
  class end

/// https://api.flutter.dev/flutter/services/SystemMouseCursors-class.html
[<ImportMember("package:flutter/services.dart")>]
type SystemMouseCursors =
  [<IsConst>] static member none: SystemMouseCursor = nativeOnly
  [<IsConst>] static member basic: SystemMouseCursor = nativeOnly
  [<IsConst>] static member click: SystemMouseCursor = nativeOnly
  [<IsConst>] static member forbidden: SystemMouseCursor = nativeOnly
  [<IsConst>] static member wait: SystemMouseCursor = nativeOnly
  [<IsConst>] static member progress: SystemMouseCursor = nativeOnly
  [<IsConst>] static member contextMenu: SystemMouseCursor = nativeOnly
  [<IsConst>] static member help: SystemMouseCursor = nativeOnly
  [<IsConst>] static member text: SystemMouseCursor = nativeOnly
  [<IsConst>] static member verticalText: SystemMouseCursor = nativeOnly
  [<IsConst>] static member cell: SystemMouseCursor = nativeOnly
  [<IsConst>] static member precise: SystemMouseCursor = nativeOnly
  [<IsConst>] static member move: SystemMouseCursor = nativeOnly
  [<IsConst>] static member grab: SystemMouseCursor = nativeOnly
  [<IsConst>] static member grabbing: SystemMouseCursor = nativeOnly
  [<IsConst>] static member noDrop: SystemMouseCursor = nativeOnly
  [<IsConst>] static member alias: SystemMouseCursor = nativeOnly
  [<IsConst>] static member copy: SystemMouseCursor = nativeOnly
  [<IsConst>] static member disappearing: SystemMouseCursor = nativeOnly
  [<IsConst>] static member allScroll: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeLeftRight: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeUpDown: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeUpLeftDownRight: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeUpRightDownLeft: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeUp: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeDown: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeLeft: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeRight: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeUpLeft: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeUpRight: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeDownLeft: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeDownRight: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeColumn: SystemMouseCursor = nativeOnly
  [<IsConst>] static member resizeRow: SystemMouseCursor = nativeOnly
  [<IsConst>] static member zoomIn: SystemMouseCursor = nativeOnly
  [<IsConst>] static member zoomOut: SystemMouseCursor = nativeOnly

/// https://api.flutter.dev/flutter/services/MouseTrackerAnnotation-class.html
[<ImportMember("package:flutter/services.dart")>]
type MouseTrackerAnnotation [<IsConst; NamedParams>] ([<Optional>] onEnter: (PointerEnterEvent -> unit), [<Optional>] onExit: (PointerExitEvent -> unit), [<Optional>] cursor: MouseCursor, [<Optional>] validForMouseTracker: bool) =
  class end

/// https://api.flutter.dev/flutter/services/BasicMessageChannel-class.html
[<ImportMember("package:flutter/services.dart")>]
type BasicMessageChannel<'T> [<IsConst; NamedParams(fromIndex=2)>] (name: string, codec: MessageCodec<'T>, [<Optional>] binaryMessenger: BinaryMessenger) =
  class end

/// https://api.flutter.dev/flutter/services/MethodChannel-class.html
[<ImportMember("package:flutter/services.dart")>]
type MethodChannel [<IsConst>] (name: string, [<Optional>] codec: MethodCodec, [<Optional>] binaryMessenger: BinaryMessenger) =
  class end

/// https://api.flutter.dev/flutter/services/OptionalMethodChannel-class.html
[<ImportMember("package:flutter/services.dart")>]
type OptionalMethodChannel [<IsConst>] (name: string, [<Optional>] codec: MethodCodec, [<Optional>] binaryMessenger: BinaryMessenger) =
  class end

/// https://api.flutter.dev/flutter/services/EventChannel-class.html
[<ImportMember("package:flutter/services.dart")>]
type EventChannel [<IsConst>] (name: string, [<Optional>] codec: MethodCodec, [<Optional>] binaryMessenger: BinaryMessenger) =
  class end

/// https://api.flutter.dev/flutter/services/PlatformViewsRegistry-class.html
[<ImportMember("package:flutter/services.dart")>]
type PlatformViewsRegistry =
  class end

/// https://api.flutter.dev/flutter/services/PlatformViewsService-class.html
[<ImportMember("package:flutter/services.dart")>]
type PlatformViewsService =
  class end

/// https://api.flutter.dev/flutter/services/AndroidPointerProperties-class.html
[<ImportMember("package:flutter/services.dart")>]
type AndroidPointerProperties [<IsConst; NamedParams>] (id: int, toolType: int) =
  [<IsConst>] static member kToolTypeUnknown: int = nativeOnly
  [<IsConst>] static member kToolTypeFinger: int = nativeOnly
  [<IsConst>] static member kToolTypeStylus: int = nativeOnly
  [<IsConst>] static member kToolTypeMouse: int = nativeOnly
  [<IsConst>] static member kToolTypeEraser: int = nativeOnly

/// https://api.flutter.dev/flutter/services/AndroidPointerCoords-class.html
[<ImportMember("package:flutter/services.dart")>]
type AndroidPointerCoords [<IsConst; NamedParams>] (orientation: float, pressure: float, size: float, toolMajor: float, toolMinor: float, touchMajor: float, touchMinor: float, x: float, y: float) =
  class end

/// https://api.flutter.dev/flutter/services/AndroidMotionEvent-class.html
[<ImportMember("package:flutter/services.dart")>]
type AndroidMotionEvent [<NamedParams>] (downTime: int, eventTime: int, action: int, pointerCount: int, pointerProperties: AndroidPointerProperties[], pointerCoords: AndroidPointerCoords[], metaState: int, buttonState: int, xPrecision: float, yPrecision: float, deviceId: int, edgeFlags: int, source: int, flags: int, motionEventId: int) =
  class end

/// https://api.flutter.dev/flutter/services/AndroidViewController-class.html
[<ImportMember("package:flutter/services.dart")>]
type AndroidViewController =
  [<IsConst>] static member kActionDown: int = nativeOnly
  [<IsConst>] static member kActionUp: int = nativeOnly
  [<IsConst>] static member kActionMove: int = nativeOnly
  [<IsConst>] static member kActionCancel: int = nativeOnly
  [<IsConst>] static member kActionPointerDown: int = nativeOnly
  [<IsConst>] static member kActionPointerUp: int = nativeOnly
  [<IsConst>] static member kAndroidLayoutDirectionLtr: int = nativeOnly
  [<IsConst>] static member kAndroidLayoutDirectionRtl: int = nativeOnly

/// https://api.flutter.dev/flutter/services/SurfaceAndroidViewController-class.html
[<ImportMember("package:flutter/services.dart")>]
type SurfaceAndroidViewController =
  class end

/// https://api.flutter.dev/flutter/services/ExpensiveAndroidViewController-class.html
[<ImportMember("package:flutter/services.dart")>]
type ExpensiveAndroidViewController =
  class end

/// https://api.flutter.dev/flutter/services/TextureAndroidViewController-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextureAndroidViewController =
  class end

/// https://api.flutter.dev/flutter/services/UiKitViewController-class.html
[<ImportMember("package:flutter/services.dart")>]
type UiKitViewController =
  class end

/// https://api.flutter.dev/flutter/services/PlatformViewController-class.html
[<ImportMember("package:flutter/services.dart")>]
type PlatformViewController () =
  class end

/// https://api.flutter.dev/flutter/services/RawKeyEventData-class.html
[<ImportMember("package:flutter/services.dart")>]
type RawKeyEventData [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/services/RawKeyEvent-class.html
[<ImportMember("package:flutter/services.dart")>]
type RawKeyEvent [<IsConst; NamedParams>] (data: RawKeyEventData, [<Optional>] character: string, [<Optional>] repeat: bool) =
  static member fromMessage(message: Dictionary<string, DartNullable<obj>>): RawKeyEvent = nativeOnly

/// https://api.flutter.dev/flutter/services/RawKeyDownEvent-class.html
[<ImportMember("package:flutter/services.dart")>]
type RawKeyDownEvent [<IsConst; NamedParams>] (data: RawKeyEventData, [<Optional>] character: string, [<Optional>] repeat: bool) =
  class end

/// https://api.flutter.dev/flutter/services/RawKeyUpEvent-class.html
[<ImportMember("package:flutter/services.dart")>]
type RawKeyUpEvent [<IsConst; NamedParams>] (data: RawKeyEventData, [<Optional>] character: string) =
  class end

/// https://api.flutter.dev/flutter/services/RawKeyboard-class.html
[<ImportMember("package:flutter/services.dart")>]
type RawKeyboard =
  class end

/// https://api.flutter.dev/flutter/services/RawKeyEventDataAndroid-class.html
[<ImportMember("package:flutter/services.dart")>]
type RawKeyEventDataAndroid [<IsConst; NamedParams>] ([<Optional>] flags: int, [<Optional>] codePoint: int, [<Optional>] plainCodePoint: int, [<Optional>] keyCode: int, [<Optional>] scanCode: int, [<Optional>] metaState: int, [<Optional>] eventSource: int, [<Optional>] vendorId: int, [<Optional>] productId: int, [<Optional>] deviceId: int, [<Optional>] repeatCount: int) =
  [<IsConst>] static member modifierNone: int = nativeOnly
  [<IsConst>] static member modifierAlt: int = nativeOnly
  [<IsConst>] static member modifierLeftAlt: int = nativeOnly
  [<IsConst>] static member modifierRightAlt: int = nativeOnly
  [<IsConst>] static member modifierShift: int = nativeOnly
  [<IsConst>] static member modifierLeftShift: int = nativeOnly
  [<IsConst>] static member modifierRightShift: int = nativeOnly
  [<IsConst>] static member modifierSym: int = nativeOnly
  [<IsConst>] static member modifierFunction: int = nativeOnly
  [<IsConst>] static member modifierControl: int = nativeOnly
  [<IsConst>] static member modifierLeftControl: int = nativeOnly
  [<IsConst>] static member modifierRightControl: int = nativeOnly
  [<IsConst>] static member modifierMeta: int = nativeOnly
  [<IsConst>] static member modifierLeftMeta: int = nativeOnly
  [<IsConst>] static member modifierRightMeta: int = nativeOnly
  [<IsConst>] static member modifierCapsLock: int = nativeOnly
  [<IsConst>] static member modifierNumLock: int = nativeOnly
  [<IsConst>] static member modifierScrollLock: int = nativeOnly

/// https://api.flutter.dev/flutter/services/RawKeyEventDataFuchsia-class.html
[<ImportMember("package:flutter/services.dart")>]
type RawKeyEventDataFuchsia [<IsConst; NamedParams>] ([<Optional>] hidUsage: int, [<Optional>] codePoint: int, [<Optional>] modifiers: int) =
  [<IsConst>] static member modifierNone: int = nativeOnly
  [<IsConst>] static member modifierCapsLock: int = nativeOnly
  [<IsConst>] static member modifierLeftShift: int = nativeOnly
  [<IsConst>] static member modifierRightShift: int = nativeOnly
  [<IsConst>] static member modifierShift: int = nativeOnly
  [<IsConst>] static member modifierLeftControl: int = nativeOnly
  [<IsConst>] static member modifierRightControl: int = nativeOnly
  [<IsConst>] static member modifierControl: int = nativeOnly
  [<IsConst>] static member modifierLeftAlt: int = nativeOnly
  [<IsConst>] static member modifierRightAlt: int = nativeOnly
  [<IsConst>] static member modifierAlt: int = nativeOnly
  [<IsConst>] static member modifierLeftMeta: int = nativeOnly
  [<IsConst>] static member modifierRightMeta: int = nativeOnly
  [<IsConst>] static member modifierMeta: int = nativeOnly

/// https://api.flutter.dev/flutter/services/RawKeyEventDataIos-class.html
[<ImportMember("package:flutter/services.dart")>]
type RawKeyEventDataIos [<IsConst; NamedParams>] ([<Optional>] characters: string, [<Optional>] charactersIgnoringModifiers: string, [<Optional>] keyCode: int, [<Optional>] modifiers: int) =
  [<IsConst>] static member modifierCapsLock: int = nativeOnly
  [<IsConst>] static member modifierShift: int = nativeOnly
  [<IsConst>] static member modifierLeftShift: int = nativeOnly
  [<IsConst>] static member modifierRightShift: int = nativeOnly
  [<IsConst>] static member modifierControl: int = nativeOnly
  [<IsConst>] static member modifierLeftControl: int = nativeOnly
  [<IsConst>] static member modifierRightControl: int = nativeOnly
  [<IsConst>] static member modifierOption: int = nativeOnly
  [<IsConst>] static member modifierLeftOption: int = nativeOnly
  [<IsConst>] static member modifierRightOption: int = nativeOnly
  [<IsConst>] static member modifierCommand: int = nativeOnly
  [<IsConst>] static member modifierLeftCommand: int = nativeOnly
  [<IsConst>] static member modifierRightCommand: int = nativeOnly
  [<IsConst>] static member modifierNumericPad: int = nativeOnly
  [<IsConst>] static member modifierHelp: int = nativeOnly
  [<IsConst>] static member modifierFunction: int = nativeOnly
  [<IsConst>] static member deviceIndependentMask: int = nativeOnly

/// https://api.flutter.dev/flutter/services/RawKeyEventDataLinux-class.html
[<ImportMember("package:flutter/services.dart")>]
type RawKeyEventDataLinux [<IsConst; NamedParams>] (keyHelper: KeyHelper, isDown: bool, [<Optional>] unicodeScalarValues: int, [<Optional>] scanCode: int, [<Optional>] keyCode: int, [<Optional>] modifiers: int) =
  class end

/// https://api.flutter.dev/flutter/services/KeyHelper-class.html
[<ImportMember("package:flutter/services.dart")>]
type KeyHelper (toolkit: string) =
  class end

/// https://api.flutter.dev/flutter/services/GLFWKeyHelper-class.html
[<ImportMember("package:flutter/services.dart")>]
type GLFWKeyHelper () =
  [<IsConst>] static member modifierCapsLock: int = nativeOnly
  [<IsConst>] static member modifierShift: int = nativeOnly
  [<IsConst>] static member modifierControl: int = nativeOnly
  [<IsConst>] static member modifierAlt: int = nativeOnly
  [<IsConst>] static member modifierMeta: int = nativeOnly
  [<IsConst>] static member modifierNumericPad: int = nativeOnly

/// https://api.flutter.dev/flutter/services/GtkKeyHelper-class.html
[<ImportMember("package:flutter/services.dart")>]
type GtkKeyHelper () =
  [<IsConst>] static member modifierShift: int = nativeOnly
  [<IsConst>] static member modifierCapsLock: int = nativeOnly
  [<IsConst>] static member modifierControl: int = nativeOnly
  [<IsConst>] static member modifierMod1: int = nativeOnly
  [<IsConst>] static member modifierMod2: int = nativeOnly
  [<IsConst>] static member modifierMeta: int = nativeOnly

/// https://api.flutter.dev/flutter/services/RawKeyEventDataMacOs-class.html
[<ImportMember("package:flutter/services.dart")>]
type RawKeyEventDataMacOs [<IsConst; NamedParams>] ([<Optional>] characters: string, [<Optional>] charactersIgnoringModifiers: string, [<Optional>] keyCode: int, [<Optional>] modifiers: int) =
  [<IsConst>] static member modifierCapsLock: int = nativeOnly
  [<IsConst>] static member modifierShift: int = nativeOnly
  [<IsConst>] static member modifierLeftShift: int = nativeOnly
  [<IsConst>] static member modifierRightShift: int = nativeOnly
  [<IsConst>] static member modifierControl: int = nativeOnly
  [<IsConst>] static member modifierLeftControl: int = nativeOnly
  [<IsConst>] static member modifierRightControl: int = nativeOnly
  [<IsConst>] static member modifierOption: int = nativeOnly
  [<IsConst>] static member modifierLeftOption: int = nativeOnly
  [<IsConst>] static member modifierRightOption: int = nativeOnly
  [<IsConst>] static member modifierCommand: int = nativeOnly
  [<IsConst>] static member modifierLeftCommand: int = nativeOnly
  [<IsConst>] static member modifierRightCommand: int = nativeOnly
  [<IsConst>] static member modifierNumericPad: int = nativeOnly
  [<IsConst>] static member modifierHelp: int = nativeOnly
  [<IsConst>] static member modifierFunction: int = nativeOnly
  [<IsConst>] static member deviceIndependentMask: int = nativeOnly

/// https://api.flutter.dev/flutter/services/RawKeyEventDataWeb-class.html
[<ImportMember("package:flutter/services.dart")>]
type RawKeyEventDataWeb [<IsConst; NamedParams>] (code: string, key: string, [<Optional>] location: int, [<Optional>] metaState: int, [<Optional>] keyCode: int) =
  [<IsConst>] static member modifierNone: int = nativeOnly
  [<IsConst>] static member modifierShift: int = nativeOnly
  [<IsConst>] static member modifierAlt: int = nativeOnly
  [<IsConst>] static member modifierControl: int = nativeOnly
  [<IsConst>] static member modifierMeta: int = nativeOnly
  [<IsConst>] static member modifierNumLock: int = nativeOnly
  [<IsConst>] static member modifierCapsLock: int = nativeOnly
  [<IsConst>] static member modifierScrollLock: int = nativeOnly

/// https://api.flutter.dev/flutter/services/RawKeyEventDataWindows-class.html
[<ImportMember("package:flutter/services.dart")>]
type RawKeyEventDataWindows [<IsConst; NamedParams>] ([<Optional>] keyCode: int, [<Optional>] scanCode: int, [<Optional>] characterCodePoint: int, [<Optional>] modifiers: int) =
  [<IsConst>] static member modifierShift: int = nativeOnly
  [<IsConst>] static member modifierLeftShift: int = nativeOnly
  [<IsConst>] static member modifierRightShift: int = nativeOnly
  [<IsConst>] static member modifierControl: int = nativeOnly
  [<IsConst>] static member modifierLeftControl: int = nativeOnly
  [<IsConst>] static member modifierRightControl: int = nativeOnly
  [<IsConst>] static member modifierAlt: int = nativeOnly
  [<IsConst>] static member modifierLeftAlt: int = nativeOnly
  [<IsConst>] static member modifierRightAlt: int = nativeOnly
  [<IsConst>] static member modifierLeftMeta: int = nativeOnly
  [<IsConst>] static member modifierRightMeta: int = nativeOnly
  [<IsConst>] static member modifierCaps: int = nativeOnly
  [<IsConst>] static member modifierNumLock: int = nativeOnly
  [<IsConst>] static member modifierScrollLock: int = nativeOnly

/// https://api.flutter.dev/flutter/services/RestorationManager-class.html
[<ImportMember("package:flutter/services.dart")>]
type RestorationManager () =
  class end

/// https://api.flutter.dev/flutter/services/RestorationBucket-class.html
[<ImportMember("package:flutter/services.dart")>]
type RestorationBucket =
  [<NamedParams>] static member empty(restorationId: string, debugOwner: DartNullable<obj>): RestorationBucket = nativeOnly
  [<NamedParams>] static member root(manager: RestorationManager, rawData: DartNullable<Dictionary<DartNullable<obj>, DartNullable<obj>>>): RestorationBucket = nativeOnly
  [<NamedParams>] static member child(restorationId: string, parent: RestorationBucket, debugOwner: DartNullable<obj>): RestorationBucket = nativeOnly

/// https://api.flutter.dev/flutter/services/SystemChannels-class.html
[<ImportMember("package:flutter/services.dart")>]
type SystemChannels =
  [<IsConst>] static member navigation: MethodChannel = nativeOnly
  [<IsConst>] static member platform: MethodChannel = nativeOnly
  [<IsConst>] static member textInput: MethodChannel = nativeOnly
  [<IsConst>] static member keyEvent: BasicMessageChannel<DartNullable<obj>> = nativeOnly
  [<IsConst>] static member lifecycle: BasicMessageChannel<DartNullable<string>> = nativeOnly
  [<IsConst>] static member system: BasicMessageChannel<DartNullable<obj>> = nativeOnly
  [<IsConst>] static member accessibility: BasicMessageChannel<DartNullable<obj>> = nativeOnly
  [<IsConst>] static member platform_views: MethodChannel = nativeOnly
  [<IsConst>] static member skia: MethodChannel = nativeOnly
  [<IsConst>] static member mouseCursor: MethodChannel = nativeOnly
  [<IsConst>] static member restoration: MethodChannel = nativeOnly
  [<IsConst>] static member deferredComponent: MethodChannel = nativeOnly
  [<IsConst>] static member localization: MethodChannel = nativeOnly
  [<IsConst>] static member menu: MethodChannel = nativeOnly

/// https://api.flutter.dev/flutter/services/ApplicationSwitcherDescription-class.html
[<ImportMember("package:flutter/services.dart")>]
type ApplicationSwitcherDescription [<IsConst; NamedParams>] ([<Optional>] label: string, [<Optional>] primaryColor: int) =
  class end

/// https://api.flutter.dev/flutter/services/SystemUiOverlayStyle-class.html
[<ImportMember("package:flutter/services.dart")>]
type SystemUiOverlayStyle [<IsConst; NamedParams>] ([<Optional>] systemNavigationBarColor: Color, [<Optional>] systemNavigationBarDividerColor: Color, [<Optional>] systemNavigationBarIconBrightness: Brightness, [<Optional>] systemNavigationBarContrastEnforced: bool, [<Optional>] statusBarColor: Color, [<Optional>] statusBarBrightness: Brightness, [<Optional>] statusBarIconBrightness: Brightness, [<Optional>] systemStatusBarContrastEnforced: bool) =
  [<IsConst>] static member light: SystemUiOverlayStyle = nativeOnly
  [<IsConst>] static member dark: SystemUiOverlayStyle = nativeOnly

/// https://api.flutter.dev/flutter/services/SystemChrome-class.html
[<ImportMember("package:flutter/services.dart")>]
type SystemChrome =
  class end

/// https://api.flutter.dev/flutter/services/SystemNavigator-class.html
[<ImportMember("package:flutter/services.dart")>]
type SystemNavigator =
  class end

/// https://api.flutter.dev/flutter/services/SystemSound-class.html
[<ImportMember("package:flutter/services.dart")>]
type SystemSound =
  class end

/// https://api.flutter.dev/flutter/services/TextSelection-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextSelection [<IsConst; NamedParams>] (baseOffset: int, extentOffset: int, [<Optional>] affinity: TextAffinity, [<Optional>] isDirectional: bool) =
  inherit TextRange(0, 0)
  [<IsConst; NamedParams>] static member collapsed(offset: int, [<Optional>] affinity: TextAffinity): TextSelection = nativeOnly
  static member fromPosition(position: TextPosition): TextSelection = nativeOnly

/// https://api.flutter.dev/flutter/services/TextLayoutMetrics-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextLayoutMetrics () =
  class end

/// https://api.flutter.dev/flutter/services/AutofillHints-class.html
[<ImportMember("package:flutter/services.dart")>]
type AutofillHints =
  [<IsConst>] static member addressCity: string = nativeOnly
  [<IsConst>] static member addressCityAndState: string = nativeOnly
  [<IsConst>] static member addressState: string = nativeOnly
  [<IsConst>] static member birthday: string = nativeOnly
  [<IsConst>] static member birthdayDay: string = nativeOnly
  [<IsConst>] static member birthdayMonth: string = nativeOnly
  [<IsConst>] static member birthdayYear: string = nativeOnly
  [<IsConst>] static member countryCode: string = nativeOnly
  [<IsConst>] static member countryName: string = nativeOnly
  [<IsConst>] static member creditCardExpirationDate: string = nativeOnly
  [<IsConst>] static member creditCardExpirationDay: string = nativeOnly
  [<IsConst>] static member creditCardExpirationMonth: string = nativeOnly
  [<IsConst>] static member creditCardExpirationYear: string = nativeOnly
  [<IsConst>] static member creditCardFamilyName: string = nativeOnly
  [<IsConst>] static member creditCardGivenName: string = nativeOnly
  [<IsConst>] static member creditCardMiddleName: string = nativeOnly
  [<IsConst>] static member creditCardName: string = nativeOnly
  [<IsConst>] static member creditCardNumber: string = nativeOnly
  [<IsConst>] static member creditCardSecurityCode: string = nativeOnly
  [<IsConst>] static member creditCardType: string = nativeOnly
  [<IsConst>] static member email: string = nativeOnly
  [<IsConst>] static member familyName: string = nativeOnly
  [<IsConst>] static member fullStreetAddress: string = nativeOnly
  [<IsConst>] static member gender: string = nativeOnly
  [<IsConst>] static member givenName: string = nativeOnly
  [<IsConst>] static member impp: string = nativeOnly
  [<IsConst>] static member jobTitle: string = nativeOnly
  [<IsConst>] static member language: string = nativeOnly
  [<IsConst>] static member location: string = nativeOnly
  [<IsConst>] static member middleInitial: string = nativeOnly
  [<IsConst>] static member middleName: string = nativeOnly
  [<IsConst>] static member name: string = nativeOnly
  [<IsConst>] static member namePrefix: string = nativeOnly
  [<IsConst>] static member nameSuffix: string = nativeOnly
  [<IsConst>] static member newPassword: string = nativeOnly
  [<IsConst>] static member newUsername: string = nativeOnly
  [<IsConst>] static member nickname: string = nativeOnly
  [<IsConst>] static member oneTimeCode: string = nativeOnly
  [<IsConst>] static member organizationName: string = nativeOnly
  [<IsConst>] static member password: string = nativeOnly
  [<IsConst>] static member photo: string = nativeOnly
  [<IsConst>] static member postalAddress: string = nativeOnly
  [<IsConst>] static member postalAddressExtended: string = nativeOnly
  [<IsConst>] static member postalAddressExtendedPostalCode: string = nativeOnly
  [<IsConst>] static member postalCode: string = nativeOnly
  [<IsConst>] static member streetAddressLevel1: string = nativeOnly
  [<IsConst>] static member streetAddressLevel2: string = nativeOnly
  [<IsConst>] static member streetAddressLevel3: string = nativeOnly
  [<IsConst>] static member streetAddressLevel4: string = nativeOnly
  [<IsConst>] static member streetAddressLine1: string = nativeOnly
  [<IsConst>] static member streetAddressLine2: string = nativeOnly
  [<IsConst>] static member streetAddressLine3: string = nativeOnly
  [<IsConst>] static member sublocality: string = nativeOnly
  [<IsConst>] static member telephoneNumber: string = nativeOnly
  [<IsConst>] static member telephoneNumberAreaCode: string = nativeOnly
  [<IsConst>] static member telephoneNumberCountryCode: string = nativeOnly
  [<IsConst>] static member telephoneNumberDevice: string = nativeOnly
  [<IsConst>] static member telephoneNumberExtension: string = nativeOnly
  [<IsConst>] static member telephoneNumberLocal: string = nativeOnly
  [<IsConst>] static member telephoneNumberLocalPrefix: string = nativeOnly
  [<IsConst>] static member telephoneNumberLocalSuffix: string = nativeOnly
  [<IsConst>] static member telephoneNumberNational: string = nativeOnly
  [<IsConst>] static member transactionAmount: string = nativeOnly
  [<IsConst>] static member transactionCurrency: string = nativeOnly
  [<IsConst>] static member url: string = nativeOnly
  [<IsConst>] static member username: string = nativeOnly

/// https://api.flutter.dev/flutter/services/AutofillConfiguration-class.html
[<ImportMember("package:flutter/services.dart")>]
type AutofillConfiguration [<IsConst; NamedParams>] (uniqueIdentifier: string, autofillHints: string[], currentEditingValue: TextEditingValue, [<Optional>] hintText: string) =
  [<IsConst>] static member disabled: AutofillConfiguration = nativeOnly

/// https://api.flutter.dev/flutter/services/AutofillClient-class.html
[<ImportMember("package:flutter/services.dart")>]
type AutofillClient () =
  class end

/// https://api.flutter.dev/flutter/services/AutofillScope-class.html
[<ImportMember("package:flutter/services.dart")>]
type AutofillScope () =
  class end

/// https://api.flutter.dev/flutter/services/TextEditingDelta-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextEditingDelta [<IsConst; NamedParams>] (oldText: string, selection: TextSelection, composing: TextRange) =
  static member fromJSON(encoded: Dictionary<string, obj>): TextEditingDelta = nativeOnly

/// https://api.flutter.dev/flutter/services/TextEditingDeltaInsertion-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextEditingDeltaInsertion [<IsConst; NamedParams>] (oldText: string, textInserted: string, insertionOffset: int, selection: TextSelection, composing: TextRange) =
  class end

/// https://api.flutter.dev/flutter/services/TextEditingDeltaDeletion-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextEditingDeltaDeletion [<IsConst; NamedParams>] (oldText: string, deletedRange: TextRange, selection: TextSelection, composing: TextRange) =
  class end

/// https://api.flutter.dev/flutter/services/TextEditingDeltaReplacement-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextEditingDeltaReplacement [<IsConst; NamedParams>] (oldText: string, replacementText: string, replacedRange: TextRange, selection: TextSelection, composing: TextRange) =
  class end

/// https://api.flutter.dev/flutter/services/TextEditingDeltaNonTextUpdate-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextEditingDeltaNonTextUpdate [<IsConst; NamedParams>] (oldText: string, selection: TextSelection, composing: TextRange) =
  class end

/// https://api.flutter.dev/flutter/services/TextInputFormatter-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextInputFormatter () =
  class end

/// https://api.flutter.dev/flutter/services/FilteringTextInputFormatter-class.html
[<ImportMember("package:flutter/services.dart")>]
type FilteringTextInputFormatter [<NamedParams(fromIndex=1)>] (filterPattern: Pattern, allow: bool, [<Optional>] replacementString: string) =
  [<NamedParams(fromIndex=1)>] static member allow(filterPattern: Pattern, [<Optional>] replacementString: string): FilteringTextInputFormatter = nativeOnly
  [<NamedParams(fromIndex=1)>] static member deny(filterPattern: Pattern, [<Optional>] replacementString: string): FilteringTextInputFormatter = nativeOnly

/// https://api.flutter.dev/flutter/services/LengthLimitingTextInputFormatter-class.html
[<ImportMember("package:flutter/services.dart")>]
type LengthLimitingTextInputFormatter [<NamedParams(fromIndex=1)>] (maxLength: DartNullable<int>, [<Optional>] maxLengthEnforcement: MaxLengthEnforcement) =
  class end

/// https://api.flutter.dev/flutter/services/TextInputType-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextInputType =
  [<IsConst; NamedParams>] static member numberWithOptions([<Optional>] signed: bool, [<Optional>] decimal: bool): TextInputType = nativeOnly
  [<IsConst>] static member text: TextInputType = nativeOnly
  [<IsConst>] static member multiline: TextInputType = nativeOnly
  [<IsConst>] static member number: TextInputType = nativeOnly
  [<IsConst>] static member phone: TextInputType = nativeOnly
  [<IsConst>] static member datetime: TextInputType = nativeOnly
  [<IsConst>] static member emailAddress: TextInputType = nativeOnly
  [<IsConst>] static member url: TextInputType = nativeOnly
  [<IsConst>] static member visiblePassword: TextInputType = nativeOnly
  [<IsConst>] static member name: TextInputType = nativeOnly
  [<IsConst>] static member streetAddress: TextInputType = nativeOnly
  [<IsConst>] static member none: TextInputType = nativeOnly
  [<IsConst>] static member values: TextInputType[] = nativeOnly

/// https://api.flutter.dev/flutter/services/TextInputConfiguration-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextInputConfiguration [<IsConst; NamedParams>] ([<Optional>] inputType: TextInputType, [<Optional>] readOnly: bool, [<Optional>] obscureText: bool, [<Optional>] autocorrect: bool, [<Optional>] smartDashesType: SmartDashesType, [<Optional>] smartQuotesType: SmartQuotesType, [<Optional>] enableSuggestions: bool, [<Optional>] enableInteractiveSelection: bool, [<Optional>] actionLabel: string, [<Optional>] inputAction: TextInputAction, [<Optional>] keyboardAppearance: Brightness, [<Optional>] textCapitalization: TextCapitalization, [<Optional>] autofillConfiguration: AutofillConfiguration, [<Optional>] enableIMEPersonalizedLearning: bool, [<Optional>] enableDeltaModel: bool) =
  class end

/// https://api.flutter.dev/flutter/services/RawFloatingCursorPoint-class.html
[<ImportMember("package:flutter/services.dart")>]
type RawFloatingCursorPoint [<NamedParams>] (state: FloatingCursorDragState, [<Optional>] offset: Offset) =
  class end

/// https://api.flutter.dev/flutter/services/TextEditingValue-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextEditingValue [<IsConst; NamedParams>] ([<Optional>] text: string, [<Optional>] selection: TextSelection, [<Optional>] composing: TextRange) =
  static member fromJSON(encoded: Dictionary<string, obj>): TextEditingValue = nativeOnly
  [<IsConst>] static member empty: TextEditingValue = nativeOnly

/// https://api.flutter.dev/flutter/services/TextInputClient-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextInputClient [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/services/ScribbleClient-class.html
[<ImportMember("package:flutter/services.dart")>]
type ScribbleClient () =
  class end

/// https://api.flutter.dev/flutter/services/SelectionRect-class.html
[<ImportMember("package:flutter/services.dart")>]
type SelectionRect [<IsConst; NamedParams>] (position: int, bounds: Rect) =
  class end

/// https://api.flutter.dev/flutter/services/DeltaTextInputClient-class.html
[<ImportMember("package:flutter/services.dart")>]
type DeltaTextInputClient () =
  class end

/// https://api.flutter.dev/flutter/services/TextInputConnection-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextInputConnection =
  class end

/// https://api.flutter.dev/flutter/services/TextInput-class.html
[<ImportMember("package:flutter/services.dart")>]
type TextInput =
  class end

