namespace rec Flutter.Gestures

open System
open System.Collections.Generic
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
type FlutterErrorDetailsForPointerEventDispatcher [<IsConst; NamedParams>] (``exception``: obj, ?stack: StackTrace, ?library: string, ?context: DiagnosticsNode, ?event: PointerEvent, ?hitTestEntry: HitTestEntry<HitTestTarget>, ?informationCollector: (unit -> DiagnosticsNode seq), ?silent: bool) =
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
type DragDownDetails [<NamedParams>] (?globalPosition: Offset, ?localPosition: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/DragStartDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DragStartDetails [<NamedParams>] (?sourceTimeStamp: TimeSpan, ?globalPosition: Offset, ?localPosition: Offset, ?kind: PointerDeviceKind) =
  class end

/// https://api.flutter.dev/flutter/gestures/DragUpdateDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DragUpdateDetails [<NamedParams>] (globalPosition: Offset, ?sourceTimeStamp: TimeSpan, ?delta: Offset, ?primaryDelta: float, ?localPosition: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/DragEndDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DragEndDetails [<NamedParams>] (?velocity: Velocity, ?primaryVelocity: float) =
  class end

/// https://api.flutter.dev/flutter/gestures/EagerGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type EagerGestureRecognizer [<NamedParams>] (?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerEvent [<IsConst; NamedParams>] (?embedderId: int, ?timeStamp: TimeSpan, ?pointer: int, ?kind: PointerDeviceKind, ?device: int, ?position: Offset, ?delta: Offset, ?buttons: int, ?down: bool, ?obscured: bool, ?pressure: float, ?pressureMin: float, ?pressureMax: float, ?distance: float, ?distanceMax: float, ?size: float, ?radiusMajor: float, ?radiusMinor: float, ?radiusMin: float, ?radiusMax: float, ?orientation: float, ?tilt: float, ?platformData: int, ?synthesized: bool, ?transform: Matrix4, ?original: PointerEvent) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerAddedEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerAddedEvent [<IsConst; NamedParams>] (?timeStamp: TimeSpan, ?pointer: int, ?kind: PointerDeviceKind, ?device: int, ?position: Offset, ?obscured: bool, ?pressureMin: float, ?pressureMax: float, ?distance: float, ?distanceMax: float, ?radiusMin: float, ?radiusMax: float, ?orientation: float, ?tilt: float, ?embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerRemovedEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerRemovedEvent [<IsConst; NamedParams>] (?timeStamp: TimeSpan, ?pointer: int, ?kind: PointerDeviceKind, ?device: int, ?position: Offset, ?obscured: bool, ?pressureMin: float, ?pressureMax: float, ?distanceMax: float, ?radiusMin: float, ?radiusMax: float, ?original: PointerRemovedEvent, ?embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerHoverEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerHoverEvent [<IsConst; NamedParams>] (?timeStamp: TimeSpan, ?kind: PointerDeviceKind, ?pointer: int, ?device: int, ?position: Offset, ?delta: Offset, ?buttons: int, ?obscured: bool, ?pressureMin: float, ?pressureMax: float, ?distance: float, ?distanceMax: float, ?size: float, ?radiusMajor: float, ?radiusMinor: float, ?radiusMin: float, ?radiusMax: float, ?orientation: float, ?tilt: float, ?synthesized: bool, ?embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerEnterEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerEnterEvent [<IsConst; NamedParams>] (?timeStamp: TimeSpan, ?pointer: int, ?kind: PointerDeviceKind, ?device: int, ?position: Offset, ?delta: Offset, ?buttons: int, ?obscured: bool, ?pressureMin: float, ?pressureMax: float, ?distance: float, ?distanceMax: float, ?size: float, ?radiusMajor: float, ?radiusMinor: float, ?radiusMin: float, ?radiusMax: float, ?orientation: float, ?tilt: float, ?down: bool, ?synthesized: bool, ?embedderId: int) =
  static member fromMouseEvent(event: PointerEvent): PointerEnterEvent = nativeOnly

/// https://api.flutter.dev/flutter/gestures/PointerExitEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerExitEvent [<IsConst; NamedParams>] (?timeStamp: TimeSpan, ?kind: PointerDeviceKind, ?pointer: int, ?device: int, ?position: Offset, ?delta: Offset, ?buttons: int, ?obscured: bool, ?pressureMin: float, ?pressureMax: float, ?distance: float, ?distanceMax: float, ?size: float, ?radiusMajor: float, ?radiusMinor: float, ?radiusMin: float, ?radiusMax: float, ?orientation: float, ?tilt: float, ?down: bool, ?synthesized: bool, ?embedderId: int) =
  static member fromMouseEvent(event: PointerEvent): PointerExitEvent = nativeOnly

/// https://api.flutter.dev/flutter/gestures/PointerDownEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerDownEvent [<IsConst; NamedParams>] (?timeStamp: TimeSpan, ?pointer: int, ?kind: PointerDeviceKind, ?device: int, ?position: Offset, ?buttons: int, ?obscured: bool, ?pressure: float, ?pressureMin: float, ?pressureMax: float, ?distanceMax: float, ?size: float, ?radiusMajor: float, ?radiusMinor: float, ?radiusMin: float, ?radiusMax: float, ?orientation: float, ?tilt: float, ?embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerMoveEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerMoveEvent [<IsConst; NamedParams>] (?timeStamp: TimeSpan, ?pointer: int, ?kind: PointerDeviceKind, ?device: int, ?position: Offset, ?delta: Offset, ?buttons: int, ?obscured: bool, ?pressure: float, ?pressureMin: float, ?pressureMax: float, ?distanceMax: float, ?size: float, ?radiusMajor: float, ?radiusMinor: float, ?radiusMin: float, ?radiusMax: float, ?orientation: float, ?tilt: float, ?platformData: int, ?synthesized: bool, ?embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerUpEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerUpEvent [<IsConst; NamedParams>] (?timeStamp: TimeSpan, ?pointer: int, ?kind: PointerDeviceKind, ?device: int, ?position: Offset, ?buttons: int, ?obscured: bool, ?pressure: float, ?pressureMin: float, ?pressureMax: float, ?distance: float, ?distanceMax: float, ?size: float, ?radiusMajor: float, ?radiusMinor: float, ?radiusMin: float, ?radiusMax: float, ?orientation: float, ?tilt: float, ?embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerSignalEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerSignalEvent [<IsConst; NamedParams>] (?timeStamp: TimeSpan, ?pointer: int, ?kind: PointerDeviceKind, ?device: int, ?position: Offset, ?embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerScrollEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerScrollEvent [<IsConst; NamedParams>] (?timeStamp: TimeSpan, ?kind: PointerDeviceKind, ?device: int, ?position: Offset, ?scrollDelta: Offset, ?embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/PointerCancelEvent-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PointerCancelEvent [<IsConst; NamedParams>] (?timeStamp: TimeSpan, ?pointer: int, ?kind: PointerDeviceKind, ?device: int, ?position: Offset, ?buttons: int, ?obscured: bool, ?pressureMin: float, ?pressureMax: float, ?distance: float, ?distanceMax: float, ?size: float, ?radiusMajor: float, ?radiusMinor: float, ?radiusMin: float, ?radiusMax: float, ?orientation: float, ?tilt: float, ?embedderId: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/ForcePressDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type ForcePressDetails [<NamedParams>] (globalPosition: Offset, pressure: float, ?localPosition: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/ForcePressGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type ForcePressGestureRecognizer [<NamedParams>] (?startPressure: float, ?peakPressure: float, ?interpolation: (float -> float -> float -> float), ?debugOwner: obj, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/DeviceGestureSettings-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DeviceGestureSettings [<IsConst; NamedParams>] (?touchSlop: float) =
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
type LongPressDownDetails [<IsConst; NamedParams>] (?globalPosition: Offset, ?localPosition: Offset, ?kind: PointerDeviceKind) =
  class end

/// https://api.flutter.dev/flutter/gestures/LongPressStartDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type LongPressStartDetails [<IsConst; NamedParams>] (?globalPosition: Offset, ?localPosition: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/LongPressMoveUpdateDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type LongPressMoveUpdateDetails [<IsConst; NamedParams>] (?globalPosition: Offset, ?localPosition: Offset, ?offsetFromOrigin: Offset, ?localOffsetFromOrigin: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/LongPressEndDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type LongPressEndDetails [<IsConst; NamedParams>] (?globalPosition: Offset, ?localPosition: Offset, ?velocity: Velocity) =
  class end

/// https://api.flutter.dev/flutter/gestures/LongPressGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type LongPressGestureRecognizer [<NamedParams>] (?duration: TimeSpan, ?postAcceptSlopTolerance: float, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>, ?debugOwner: obj) =
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
type DragGestureRecognizer [<NamedParams>] (?debugOwner: obj, ?kind: PointerDeviceKind, ?dragStartBehavior: DragStartBehavior, ?velocityTrackerBuilder: (PointerEvent -> VelocityTracker), ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/VerticalDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type VerticalDragGestureRecognizer [<NamedParams>] (?debugOwner: obj, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/HorizontalDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type HorizontalDragGestureRecognizer [<NamedParams>] (?debugOwner: obj, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/PanGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PanGestureRecognizer [<NamedParams>] (?debugOwner: obj, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/MultiDragPointerState-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type MultiDragPointerState (initialPosition: Offset, kind: PointerDeviceKind, gestureSettings: DeviceGestureSettings option) =
  class end

/// https://api.flutter.dev/flutter/gestures/MultiDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type MultiDragGestureRecognizer [<NamedParams>] (debugOwner: obj option, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/ImmediateMultiDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type ImmediateMultiDragGestureRecognizer [<NamedParams>] (?debugOwner: obj, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/HorizontalMultiDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type HorizontalMultiDragGestureRecognizer [<NamedParams>] (?debugOwner: obj, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/VerticalMultiDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type VerticalMultiDragGestureRecognizer [<NamedParams>] (?debugOwner: obj, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/DelayedMultiDragGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DelayedMultiDragGestureRecognizer [<NamedParams>] (?delay: TimeSpan, ?debugOwner: obj, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/DoubleTapGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type DoubleTapGestureRecognizer [<NamedParams>] (?debugOwner: obj, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/MultiTapGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type MultiTapGestureRecognizer [<NamedParams>] (?longTapDelay: TimeSpan, ?debugOwner: obj, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/SerialTapDownDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type SerialTapDownDetails [<NamedParams>] (kind: PointerDeviceKind, ?globalPosition: Offset, ?localPosition: Offset, ?buttons: int, ?count: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/SerialTapCancelDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type SerialTapCancelDetails [<NamedParams>] (?count: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/SerialTapUpDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type SerialTapUpDetails [<NamedParams>] (?globalPosition: Offset, ?localPosition: Offset, ?kind: PointerDeviceKind, ?count: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/SerialTapGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type SerialTapGestureRecognizer [<NamedParams>] (?debugOwner: obj, ?supportedDevices: HashSet<PointerDeviceKind>) =
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
type GestureRecognizer [<NamedParams>] (?debugOwner: obj, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/OneSequenceGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type OneSequenceGestureRecognizer [<NamedParams>] (?debugOwner: obj, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/PrimaryPointerGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type PrimaryPointerGestureRecognizer [<NamedParams>] (?deadline: TimeSpan, ?preAcceptSlopTolerance: float, ?postAcceptSlopTolerance: float, ?debugOwner: obj, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>) =
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
type ScaleStartDetails [<NamedParams>] (?focalPoint: Offset, ?localFocalPoint: Offset, ?pointerCount: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/ScaleUpdateDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type ScaleUpdateDetails [<NamedParams>] (?focalPoint: Offset, ?localFocalPoint: Offset, ?scale: float, ?horizontalScale: float, ?verticalScale: float, ?rotation: float, ?pointerCount: int, ?focalPointDelta: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/ScaleEndDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type ScaleEndDetails [<NamedParams>] (?velocity: Velocity, ?pointerCount: int) =
  class end

/// https://api.flutter.dev/flutter/gestures/ScaleGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type ScaleGestureRecognizer [<NamedParams>] (?debugOwner: obj, ?kind: PointerDeviceKind, ?supportedDevices: HashSet<PointerDeviceKind>, ?dragStartBehavior: DragStartBehavior) =
  class end

/// https://api.flutter.dev/flutter/gestures/TapDownDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type TapDownDetails [<NamedParams>] (?globalPosition: Offset, ?localPosition: Offset, ?kind: PointerDeviceKind) =
  class end

/// https://api.flutter.dev/flutter/gestures/TapUpDetails-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type TapUpDetails [<NamedParams>] (kind: PointerDeviceKind, ?globalPosition: Offset, ?localPosition: Offset) =
  class end

/// https://api.flutter.dev/flutter/gestures/BaseTapGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type BaseTapGestureRecognizer [<NamedParams>] (?debugOwner: obj, ?supportedDevices: HashSet<PointerDeviceKind>) =
  class end

/// https://api.flutter.dev/flutter/gestures/TapGestureRecognizer-class.html
[<ImportMember("package:flutter/gestures.dart")>]
type TapGestureRecognizer [<NamedParams>] (?debugOwner: obj, ?supportedDevices: HashSet<PointerDeviceKind>) =
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
