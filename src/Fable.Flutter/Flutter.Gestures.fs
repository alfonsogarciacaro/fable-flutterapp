namespace rec Flutter.Gestures

open System
open System.Collections.Generic
open System.Runtime.InteropServices
open Fable.Core
open Fable.Core.Dart
open Dart
open Flutter.Foundation

/// https://api.flutter.dev/flutter/gestures/GestureDisposition.html
[<ImportMember("package:flutter/gestures.dart")>]
type GestureDisposition =
  [<IsConst>] static member accepted: GestureDisposition = nativeOnly
  [<IsConst>] static member rejected: GestureDisposition = nativeOnly
  [<IsConst>] static member values: GestureDisposition = nativeOnly

/// https://api.flutter.dev/flutter/gestures/DragStartBehavior.html
[<ImportMember("package:flutter/gestures.dart")>]
type DragStartBehavior =
  [<IsConst>] static member down: DragStartBehavior = nativeOnly
  [<IsConst>] static member start: DragStartBehavior = nativeOnly
  [<IsConst>] static member values: DragStartBehavior = nativeOnly

/// https://api.flutter.dev/flutter/gestures/GestureRecognizerState.html
[<ImportMember("package:flutter/gestures.dart")>]
type GestureRecognizerState =
  [<IsConst>] static member ready: GestureRecognizerState = nativeOnly
  [<IsConst>] static member possible: GestureRecognizerState = nativeOnly
  [<IsConst>] static member defunct: GestureRecognizerState = nativeOnly
  [<IsConst>] static member values: GestureRecognizerState = nativeOnly

/// https://api.flutter.dev/flutter/gestures/GestureArenaMember-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type GestureArenaMember () =
  class end

/// https://api.flutter.dev/flutter/gestures/GestureArenaEntry-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type GestureArenaEntry =
  class end

/// https://api.flutter.dev/flutter/gestures/GestureArenaManager-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type GestureArenaManager () =
  class end

/// https://api.flutter.dev/flutter/gestures/SamplingClock-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type SamplingClock () =
  class end

/// https://api.flutter.dev/flutter/gestures/FlutterErrorDetailsForPointerEventDispatcher-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type FlutterErrorDetailsForPointerEventDispatcher [<IsConst; NamedParams>] (``exception``: obj, [<Optional>] stack: StackTrace, [<Optional>] library: string, [<Optional>] context: DiagnosticsNode, [<Optional>] event: PointerEvent, [<Optional>] hitTestEntry: HitTestEntry<HitTestTarget>, [<Optional>] informationCollector: (unit -> DiagnosticsNode seq), [<Optional>] silent: bool) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerEventConverter-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerEventConverter =
  class end

/// https://api.flutter.dev/flutter/gestures/Drag-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type Drag () =
  class end

/// https://api.flutter.dev/flutter/gestures/DragDownDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DragDownDetails [<NamedParams>] ([<Optional>] globalPosition: Offset, [<Optional>] localPosition: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/DragStartDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DragStartDetails [<NamedParams>] ([<Optional>] sourceTimeStamp: TimeSpan, [<Optional>] globalPosition: Offset, [<Optional>] localPosition: Offset, [<Optional>] kind: PointerDeviceKind) =
  class end

/// https://api.flutter.dev/flutter/gestures/DragUpdateDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DragUpdateDetails [<NamedParams>] (globalPosition: Offset, [<Optional>] sourceTimeStamp: TimeSpan, [<Optional>] delta: Offset, [<Optional>] primaryDelta: float, [<Optional>] localPosition: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/DragEndDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DragEndDetails [<NamedParams>] ([<Optional>] velocity: Velocity, [<Optional>] primaryVelocity: float) =
  class end

/// https://api.flutter.dev/flutter/gestures/EagerGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type EagerGestureRecognizer [<NamedParams>] ([<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerEvent [<IsConst; NamedParams>] ([<Optional>] embedderId: int, [<Optional>] timeStamp: TimeSpan, [<Optional>] pointer: int, [<Optional>] kind: PointerDeviceKind, [<Optional>] device: int, [<Optional>] position: Offset, [<Optional>] delta: Offset, [<Optional>] buttons: int, [<Optional>] down: bool, [<Optional>] obscured: bool, [<Optional>] pressure: float, [<Optional>] pressureMin: float, [<Optional>] pressureMax: float, [<Optional>] distance: float, [<Optional>] distanceMax: float, [<Optional>] size: float, [<Optional>] radiusMajor: float, [<Optional>] radiusMinor: float, [<Optional>] radiusMin: float, [<Optional>] radiusMax: float, [<Optional>] orientation: float, [<Optional>] tilt: float, [<Optional>] platformData: int, [<Optional>] synthesized: bool, [<Optional>] transform: Matrix4, [<Optional>] original: PointerEvent) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerAddedEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerAddedEvent [<IsConst; NamedParams>] ([<Optional>] timeStamp: TimeSpan, [<Optional>] pointer: int, [<Optional>] kind: PointerDeviceKind, [<Optional>] device: int, [<Optional>] position: Offset, [<Optional>] obscured: bool, [<Optional>] pressureMin: float, [<Optional>] pressureMax: float, [<Optional>] distance: float, [<Optional>] distanceMax: float, [<Optional>] radiusMin: float, [<Optional>] radiusMax: float, [<Optional>] orientation: float, [<Optional>] tilt: float, [<Optional>] embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerRemovedEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerRemovedEvent [<IsConst; NamedParams>] ([<Optional>] timeStamp: TimeSpan, [<Optional>] pointer: int, [<Optional>] kind: PointerDeviceKind, [<Optional>] device: int, [<Optional>] position: Offset, [<Optional>] obscured: bool, [<Optional>] pressureMin: float, [<Optional>] pressureMax: float, [<Optional>] distanceMax: float, [<Optional>] radiusMin: float, [<Optional>] radiusMax: float, [<Optional>] original: PointerRemovedEvent, [<Optional>] embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerHoverEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerHoverEvent [<IsConst; NamedParams>] ([<Optional>] timeStamp: TimeSpan, [<Optional>] kind: PointerDeviceKind, [<Optional>] pointer: int, [<Optional>] device: int, [<Optional>] position: Offset, [<Optional>] delta: Offset, [<Optional>] buttons: int, [<Optional>] obscured: bool, [<Optional>] pressureMin: float, [<Optional>] pressureMax: float, [<Optional>] distance: float, [<Optional>] distanceMax: float, [<Optional>] size: float, [<Optional>] radiusMajor: float, [<Optional>] radiusMinor: float, [<Optional>] radiusMin: float, [<Optional>] radiusMax: float, [<Optional>] orientation: float, [<Optional>] tilt: float, [<Optional>] synthesized: bool, [<Optional>] embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerEnterEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerEnterEvent [<IsConst; NamedParams>] ([<Optional>] timeStamp: TimeSpan, [<Optional>] pointer: int, [<Optional>] kind: PointerDeviceKind, [<Optional>] device: int, [<Optional>] position: Offset, [<Optional>] delta: Offset, [<Optional>] buttons: int, [<Optional>] obscured: bool, [<Optional>] pressureMin: float, [<Optional>] pressureMax: float, [<Optional>] distance: float, [<Optional>] distanceMax: float, [<Optional>] size: float, [<Optional>] radiusMajor: float, [<Optional>] radiusMinor: float, [<Optional>] radiusMin: float, [<Optional>] radiusMax: float, [<Optional>] orientation: float, [<Optional>] tilt: float, [<Optional>] down: bool, [<Optional>] synthesized: bool, [<Optional>] embedderId: int) =
  static member fromMouseEvent(event: PointerEvent): PointerEnterEvent = nativeOnly

/// https://api.flutter.dev/flutter/gestures/PointerExitEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerExitEvent [<IsConst; NamedParams>] ([<Optional>] timeStamp: TimeSpan, [<Optional>] kind: PointerDeviceKind, [<Optional>] pointer: int, [<Optional>] device: int, [<Optional>] position: Offset, [<Optional>] delta: Offset, [<Optional>] buttons: int, [<Optional>] obscured: bool, [<Optional>] pressureMin: float, [<Optional>] pressureMax: float, [<Optional>] distance: float, [<Optional>] distanceMax: float, [<Optional>] size: float, [<Optional>] radiusMajor: float, [<Optional>] radiusMinor: float, [<Optional>] radiusMin: float, [<Optional>] radiusMax: float, [<Optional>] orientation: float, [<Optional>] tilt: float, [<Optional>] down: bool, [<Optional>] synthesized: bool, [<Optional>] embedderId: int) =
  static member fromMouseEvent(event: PointerEvent): PointerExitEvent = nativeOnly

/// https://api.flutter.dev/flutter/gestures/PointerDownEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerDownEvent [<IsConst; NamedParams>] ([<Optional>] timeStamp: TimeSpan, [<Optional>] pointer: int, [<Optional>] kind: PointerDeviceKind, [<Optional>] device: int, [<Optional>] position: Offset, [<Optional>] buttons: int, [<Optional>] obscured: bool, [<Optional>] pressure: float, [<Optional>] pressureMin: float, [<Optional>] pressureMax: float, [<Optional>] distanceMax: float, [<Optional>] size: float, [<Optional>] radiusMajor: float, [<Optional>] radiusMinor: float, [<Optional>] radiusMin: float, [<Optional>] radiusMax: float, [<Optional>] orientation: float, [<Optional>] tilt: float, [<Optional>] embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerMoveEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerMoveEvent [<IsConst; NamedParams>] ([<Optional>] timeStamp: TimeSpan, [<Optional>] pointer: int, [<Optional>] kind: PointerDeviceKind, [<Optional>] device: int, [<Optional>] position: Offset, [<Optional>] delta: Offset, [<Optional>] buttons: int, [<Optional>] obscured: bool, [<Optional>] pressure: float, [<Optional>] pressureMin: float, [<Optional>] pressureMax: float, [<Optional>] distanceMax: float, [<Optional>] size: float, [<Optional>] radiusMajor: float, [<Optional>] radiusMinor: float, [<Optional>] radiusMin: float, [<Optional>] radiusMax: float, [<Optional>] orientation: float, [<Optional>] tilt: float, [<Optional>] platformData: int, [<Optional>] synthesized: bool, [<Optional>] embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerUpEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerUpEvent [<IsConst; NamedParams>] ([<Optional>] timeStamp: TimeSpan, [<Optional>] pointer: int, [<Optional>] kind: PointerDeviceKind, [<Optional>] device: int, [<Optional>] position: Offset, [<Optional>] buttons: int, [<Optional>] obscured: bool, [<Optional>] pressure: float, [<Optional>] pressureMin: float, [<Optional>] pressureMax: float, [<Optional>] distance: float, [<Optional>] distanceMax: float, [<Optional>] size: float, [<Optional>] radiusMajor: float, [<Optional>] radiusMinor: float, [<Optional>] radiusMin: float, [<Optional>] radiusMax: float, [<Optional>] orientation: float, [<Optional>] tilt: float, [<Optional>] embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerSignalEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerSignalEvent [<IsConst; NamedParams>] ([<Optional>] timeStamp: TimeSpan, [<Optional>] pointer: int, [<Optional>] kind: PointerDeviceKind, [<Optional>] device: int, [<Optional>] position: Offset, [<Optional>] embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerScrollEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerScrollEvent [<IsConst; NamedParams>] ([<Optional>] timeStamp: TimeSpan, [<Optional>] kind: PointerDeviceKind, [<Optional>] device: int, [<Optional>] position: Offset, [<Optional>] scrollDelta: Offset, [<Optional>] embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerCancelEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerCancelEvent [<IsConst; NamedParams>] ([<Optional>] timeStamp: TimeSpan, [<Optional>] pointer: int, [<Optional>] kind: PointerDeviceKind, [<Optional>] device: int, [<Optional>] position: Offset, [<Optional>] buttons: int, [<Optional>] obscured: bool, [<Optional>] pressureMin: float, [<Optional>] pressureMax: float, [<Optional>] distance: float, [<Optional>] distanceMax: float, [<Optional>] size: float, [<Optional>] radiusMajor: float, [<Optional>] radiusMinor: float, [<Optional>] radiusMin: float, [<Optional>] radiusMax: float, [<Optional>] orientation: float, [<Optional>] tilt: float, [<Optional>] embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/ForcePressDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type ForcePressDetails [<NamedParams>] (globalPosition: Offset, pressure: float, [<Optional>] localPosition: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/ForcePressGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type ForcePressGestureRecognizer [<NamedParams>] ([<Optional>] startPressure: float, [<Optional>] peakPressure: float, [<Optional>] interpolation: (float -> float -> float -> float), [<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/DeviceGestureSettings-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DeviceGestureSettings [<IsConst; NamedParams>] ([<Optional>] touchSlop: float) =
  static member fromWindow(window: FlutterView): DeviceGestureSettings = nativeOnly

/// https://api.flutter.dev/flutter/gestures/HitTestable-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type HitTestable =
  class end

/// https://api.flutter.dev/flutter/gestures/HitTestDispatcher-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type HitTestDispatcher =
  class end

/// https://api.flutter.dev/flutter/gestures/HitTestTarget-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type HitTestTarget =
  class end

/// https://api.flutter.dev/flutter/gestures/HitTestEntry-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type HitTestEntry<'T> (target: 'T) =
  class end

/// https://api.flutter.dev/flutter/gestures/HitTestResult-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type HitTestResult () =
  static member wrap(result: HitTestResult): HitTestResult = nativeOnly

/// https://api.flutter.dev/flutter/gestures/LongPressDownDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type LongPressDownDetails [<IsConst; NamedParams>] ([<Optional>] globalPosition: Offset, [<Optional>] localPosition: Offset, [<Optional>] kind: PointerDeviceKind) =
  class end

/// https://api.flutter.dev/flutter/gestures/LongPressStartDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type LongPressStartDetails [<IsConst; NamedParams>] ([<Optional>] globalPosition: Offset, [<Optional>] localPosition: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/LongPressMoveUpdateDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type LongPressMoveUpdateDetails [<IsConst; NamedParams>] ([<Optional>] globalPosition: Offset, [<Optional>] localPosition: Offset, [<Optional>] offsetFromOrigin: Offset, [<Optional>] localOffsetFromOrigin: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/LongPressEndDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type LongPressEndDetails [<IsConst; NamedParams>] ([<Optional>] globalPosition: Offset, [<Optional>] localPosition: Offset, [<Optional>] velocity: Velocity) =
  class end

/// https://api.flutter.dev/flutter/gestures/LongPressGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type LongPressGestureRecognizer [<NamedParams>] ([<Optional>] duration: TimeSpan, [<Optional>] postAcceptSlopTolerance: float, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>, [<Optional>] debugOwner: obj) =
  class end

/// https://api.flutter.dev/flutter/gestures/PolynomialFit-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PolynomialFit (degree: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/LeastSquaresSolver-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type LeastSquaresSolver (x: float[], y: float[], w: float[]) =
  class end

/// https://api.flutter.dev/flutter/gestures/DragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DragGestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] velocityTrackerBuilder: (PointerEvent -> VelocityTracker), [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/VerticalDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type VerticalDragGestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/HorizontalDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type HorizontalDragGestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/PanGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PanGestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/MultiDragPointerState-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type MultiDragPointerState (initialPosition: Offset, kind: PointerDeviceKind, gestureSettings: DartNullable<DeviceGestureSettings>) =
  class end

/// https://api.flutter.dev/flutter/gestures/MultiDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type MultiDragGestureRecognizer [<NamedParams>] (debugOwner: DartNullable<obj>, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/ImmediateMultiDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type ImmediateMultiDragGestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/HorizontalMultiDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type HorizontalMultiDragGestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/VerticalMultiDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type VerticalMultiDragGestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/DelayedMultiDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DelayedMultiDragGestureRecognizer [<NamedParams>] ([<Optional>] delay: TimeSpan, [<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/DoubleTapGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DoubleTapGestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/MultiTapGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type MultiTapGestureRecognizer [<NamedParams>] ([<Optional>] longTapDelay: TimeSpan, [<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/SerialTapDownDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type SerialTapDownDetails [<NamedParams>] (kind: PointerDeviceKind, [<Optional>] globalPosition: Offset, [<Optional>] localPosition: Offset, [<Optional>] buttons: int, [<Optional>] count: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/SerialTapCancelDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type SerialTapCancelDetails [<NamedParams>] ([<Optional>] count: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/SerialTapUpDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type SerialTapUpDetails [<NamedParams>] ([<Optional>] globalPosition: Offset, [<Optional>] localPosition: Offset, [<Optional>] kind: PointerDeviceKind, [<Optional>] count: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/SerialTapGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type SerialTapGestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerRouter-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerRouter () =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerSignalResolver-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerSignalResolver () =
  class end

/// https://api.flutter.dev/flutter/gestures/GestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type GestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/OneSequenceGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type OneSequenceGestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/PrimaryPointerGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PrimaryPointerGestureRecognizer [<NamedParams>] ([<Optional>] deadline: TimeSpan, [<Optional>] preAcceptSlopTolerance: float, [<Optional>] postAcceptSlopTolerance: float, [<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/OffsetPair-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type OffsetPair [<IsConst; NamedParams>] (local: Offset, ``global``: Offset) =
  static member fromEventPosition(event: PointerEvent): OffsetPair = nativeOnly
  static member fromEventDelta(event: PointerEvent): OffsetPair = nativeOnly
  [<IsConst>] static member zero: OffsetPair = nativeOnly

/// https://api.flutter.dev/flutter/gestures/PointerEventResampler-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerEventResampler () =
  class end

/// https://api.flutter.dev/flutter/gestures/ScaleStartDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type ScaleStartDetails [<NamedParams>] ([<Optional>] focalPoint: Offset, [<Optional>] localFocalPoint: Offset, [<Optional>] pointerCount: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/ScaleUpdateDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type ScaleUpdateDetails [<NamedParams>] ([<Optional>] focalPoint: Offset, [<Optional>] localFocalPoint: Offset, [<Optional>] scale: float, [<Optional>] horizontalScale: float, [<Optional>] verticalScale: float, [<Optional>] rotation: float, [<Optional>] pointerCount: int, [<Optional>] focalPointDelta: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/ScaleEndDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type ScaleEndDetails [<NamedParams>] ([<Optional>] velocity: Velocity, [<Optional>] pointerCount: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/ScaleGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type ScaleGestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] kind: PointerDeviceKind, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>, [<Optional>] dragStartBehavior: DragStartBehavior) =
  class end

/// https://api.flutter.dev/flutter/gestures/TapDownDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type TapDownDetails [<NamedParams>] ([<Optional>] globalPosition: Offset, [<Optional>] localPosition: Offset, [<Optional>] kind: PointerDeviceKind) =
  class end

/// https://api.flutter.dev/flutter/gestures/TapUpDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type TapUpDetails [<NamedParams>] (kind: PointerDeviceKind, [<Optional>] globalPosition: Offset, [<Optional>] localPosition: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/BaseTapGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type BaseTapGestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/TapGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type TapGestureRecognizer [<NamedParams>] ([<Optional>] debugOwner: obj, [<Optional>] supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/GestureArenaTeam-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type GestureArenaTeam () =
  class end

/// https://api.flutter.dev/flutter/gestures/Velocity-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type Velocity [<IsConst; NamedParams>] (pixelsPerSecond: Offset) =
  [<IsConst>] static member zero: Velocity = nativeOnly

/// https://api.flutter.dev/flutter/gestures/VelocityEstimate-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type VelocityEstimate [<IsConst; NamedParams>] (pixelsPerSecond: Offset, confidence: float, duration: TimeSpan, offset: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/VelocityTracker-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type VelocityTracker =
  static member withKind(kind: PointerDeviceKind): VelocityTracker = nativeOnly

/// https://api.flutter.dev/flutter/gestures/IOSScrollViewFlingVelocityTracker-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type IOSScrollViewFlingVelocityTracker (kind: PointerDeviceKind) =
  class end
