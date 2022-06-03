namespace rec Flutter.Animation

open System
open System.Runtime.InteropServices
open Fable.Core
open Fable.Core.Dart
open Dart
open Flutter.Scheduler

/// https://api.flutter.dev/flutter/animation/AnimationStatus.html
[<ImportMember("package:flutter/animation.dart")>]
type AnimationStatus =
  [<IsConst>] static member dismissed: AnimationStatus = nativeOnly
  [<IsConst>] static member forward: AnimationStatus = nativeOnly
  [<IsConst>] static member reverse: AnimationStatus = nativeOnly
  [<IsConst>] static member completed: AnimationStatus = nativeOnly
  [<IsConst>] static member values: AnimationStatus = nativeOnly

/// https://api.flutter.dev/flutter/animation/AnimationBehavior.html
[<ImportMember("package:flutter/animation.dart")>]
type AnimationBehavior =
  [<IsConst>] static member normal: AnimationBehavior = nativeOnly
  [<IsConst>] static member preserve: AnimationBehavior = nativeOnly
  [<IsConst>] static member values: AnimationBehavior = nativeOnly

/// https://api.flutter.dev/flutter/animation/Animation-class.html
[<ImportMember("package:flutter/animation.dart")>]
type Animation<'T> [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/animation/AnimationController-class.html
[<ImportMember("package:flutter/animation.dart")>]
type AnimationController [<NamedParams>] (vsync: TickerProvider, [<Optional>] value: float, [<Optional>] duration: TimeSpan, [<Optional>] reverseDuration: TimeSpan, [<Optional>] debugLabel: string, [<Optional>] lowerBound: float, [<Optional>] upperBound: float, [<Optional>] animationBehavior: AnimationBehavior) =
  [<NamedParams>] static member unbounded(vsync: TickerProvider, [<Optional>] value: float, [<Optional>] duration: TimeSpan, [<Optional>] reverseDuration: TimeSpan, [<Optional>] debugLabel: string, [<Optional>] animationBehavior: AnimationBehavior): AnimationController = nativeOnly

/// https://api.flutter.dev/flutter/animation/AlwaysStoppedAnimation-class.html
[<ImportMember("package:flutter/animation.dart")>]
type AlwaysStoppedAnimation<'T> [<IsConst>] (value: 'T) =
  class end

/// https://api.flutter.dev/flutter/animation/ProxyAnimation-class.html
[<ImportMember("package:flutter/animation.dart")>]
type ProxyAnimation ([<Optional>] animation: Animation<float>) =
  class end

/// https://api.flutter.dev/flutter/animation/ReverseAnimation-class.html
[<ImportMember("package:flutter/animation.dart")>]
type ReverseAnimation (parent: Animation<float>) =
  class end

/// https://api.flutter.dev/flutter/animation/CurvedAnimation-class.html
[<ImportMember("package:flutter/animation.dart")>]
type CurvedAnimation [<NamedParams>] (parent: Animation<float>, curve: Curve, [<Optional>] reverseCurve: Curve) =
  class end

/// https://api.flutter.dev/flutter/animation/TrainHoppingAnimation-class.html
[<ImportMember("package:flutter/animation.dart")>]
type TrainHoppingAnimation [<NamedParams(fromIndex=2)>] (_currentTrain: Animation<float>, _nextTrain: DartNullable<Animation<float>>, [<Optional>] onSwitchedTrain: (unit -> unit)) =
  class end

/// https://api.flutter.dev/flutter/animation/CompoundAnimation-class.html
[<ImportMember("package:flutter/animation.dart")>]
type CompoundAnimation<'T> [<NamedParams>] (first: Animation<'T>, next: Animation<'T>) =
  class end

/// https://api.flutter.dev/flutter/animation/AnimationMean-class.html
[<ImportMember("package:flutter/animation.dart")>]
type AnimationMean [<NamedParams>] (left: Animation<float>, right: Animation<float>) =
  class end

/// https://api.flutter.dev/flutter/animation/AnimationMax-class.html
[<ImportMember("package:flutter/animation.dart")>]
type AnimationMax<'T> (first: Animation<'T>, next: Animation<'T>) =
  class end

/// https://api.flutter.dev/flutter/animation/AnimationMin-class.html
[<ImportMember("package:flutter/animation.dart")>]
type AnimationMin<'T> (first: Animation<'T>, next: Animation<'T>) =
  class end

/// https://api.flutter.dev/flutter/animation/ParametricCurve-class.html
[<ImportMember("package:flutter/animation.dart")>]
type ParametricCurve<'T> [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/animation/Curve-class.html
[<ImportMember("package:flutter/animation.dart")>]
type Curve [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/animation/SawTooth-class.html
[<ImportMember("package:flutter/animation.dart")>]
type SawTooth [<IsConst>] (count: int) =
  class end

/// https://api.flutter.dev/flutter/animation/Interval-class.html
[<ImportMember("package:flutter/animation.dart")>]
type Interval [<IsConst; NamedParams(fromIndex=2)>] (``begin``: float, ``end``: float, [<Optional>] curve: Curve) =
  class end

/// https://api.flutter.dev/flutter/animation/Threshold-class.html
[<ImportMember("package:flutter/animation.dart")>]
type Threshold [<IsConst>] (threshold: float) =
  class end

/// https://api.flutter.dev/flutter/animation/Cubic-class.html
[<ImportMember("package:flutter/animation.dart")>]
type Cubic [<IsConst>] (a: float, b: float, c: float, d: float) =
  class end

/// https://api.flutter.dev/flutter/animation/ThreePointCubic-class.html
[<ImportMember("package:flutter/animation.dart")>]
type ThreePointCubic [<IsConst>] (a1: Offset, b1: Offset, midpoint: Offset, a2: Offset, b2: Offset) =
  class end

/// https://api.flutter.dev/flutter/animation/Curve2D-class.html
[<ImportMember("package:flutter/animation.dart")>]
type Curve2D [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/animation/Curve2DSample-class.html
[<ImportMember("package:flutter/animation.dart")>]
type Curve2DSample [<IsConst>] (t: float, value: Offset) =
  class end

/// https://api.flutter.dev/flutter/animation/CatmullRomSpline-class.html
[<ImportMember("package:flutter/animation.dart")>]
type CatmullRomSpline [<NamedParams(fromIndex=1)>] (controlPoints: Offset[], [<Optional>] tension: float, [<Optional>] startHandle: Offset, [<Optional>] endHandle: Offset) =
  [<NamedParams(fromIndex=1)>] static member precompute(controlPoints: Offset[], [<Optional>] tension: float, [<Optional>] startHandle: Offset, [<Optional>] endHandle: Offset): CatmullRomSpline = nativeOnly

/// https://api.flutter.dev/flutter/animation/CatmullRomCurve-class.html
[<ImportMember("package:flutter/animation.dart")>]
type CatmullRomCurve [<NamedParams(fromIndex=1)>] (controlPoints: Offset[], [<Optional>] tension: float) =
  [<NamedParams(fromIndex=1)>] static member precompute(controlPoints: Offset[], [<Optional>] tension: float): CatmullRomCurve = nativeOnly

/// https://api.flutter.dev/flutter/animation/FlippedCurve-class.html
[<ImportMember("package:flutter/animation.dart")>]
type FlippedCurve [<IsConst>] (curve: Curve) =
  class end

/// https://api.flutter.dev/flutter/animation/ElasticInCurve-class.html
[<ImportMember("package:flutter/animation.dart")>]
type ElasticInCurve [<IsConst>] ([<Optional>] period: float) =
  class end

/// https://api.flutter.dev/flutter/animation/ElasticOutCurve-class.html
[<ImportMember("package:flutter/animation.dart")>]
type ElasticOutCurve [<IsConst>] ([<Optional>] period: float) =
  class end

/// https://api.flutter.dev/flutter/animation/ElasticInOutCurve-class.html
[<ImportMember("package:flutter/animation.dart")>]
type ElasticInOutCurve [<IsConst>] ([<Optional>] period: float) =
  class end

/// https://api.flutter.dev/flutter/animation/Curves-class.html
[<ImportMember("package:flutter/animation.dart")>]
type Curves =
  [<IsConst>] static member linear: Curve = nativeOnly
  [<IsConst>] static member decelerate: Curve = nativeOnly
  [<IsConst>] static member fastLinearToSlowEaseIn: Cubic = nativeOnly
  [<IsConst>] static member ease: Cubic = nativeOnly
  [<IsConst>] static member easeIn: Cubic = nativeOnly
  [<IsConst>] static member easeInToLinear: Cubic = nativeOnly
  [<IsConst>] static member easeInSine: Cubic = nativeOnly
  [<IsConst>] static member easeInQuad: Cubic = nativeOnly
  [<IsConst>] static member easeInCubic: Cubic = nativeOnly
  [<IsConst>] static member easeInQuart: Cubic = nativeOnly
  [<IsConst>] static member easeInQuint: Cubic = nativeOnly
  [<IsConst>] static member easeInExpo: Cubic = nativeOnly
  [<IsConst>] static member easeInCirc: Cubic = nativeOnly
  [<IsConst>] static member easeInBack: Cubic = nativeOnly
  [<IsConst>] static member easeOut: Cubic = nativeOnly
  [<IsConst>] static member linearToEaseOut: Cubic = nativeOnly
  [<IsConst>] static member easeOutSine: Cubic = nativeOnly
  [<IsConst>] static member easeOutQuad: Cubic = nativeOnly
  [<IsConst>] static member easeOutCubic: Cubic = nativeOnly
  [<IsConst>] static member easeOutQuart: Cubic = nativeOnly
  [<IsConst>] static member easeOutQuint: Cubic = nativeOnly
  [<IsConst>] static member easeOutExpo: Cubic = nativeOnly
  [<IsConst>] static member easeOutCirc: Cubic = nativeOnly
  [<IsConst>] static member easeOutBack: Cubic = nativeOnly
  [<IsConst>] static member easeInOut: Cubic = nativeOnly
  [<IsConst>] static member easeInOutSine: Cubic = nativeOnly
  [<IsConst>] static member easeInOutQuad: Cubic = nativeOnly
  [<IsConst>] static member easeInOutCubic: Cubic = nativeOnly
  [<IsConst>] static member easeInOutCubicEmphasized: ThreePointCubic = nativeOnly
  [<IsConst>] static member easeInOutQuart: Cubic = nativeOnly
  [<IsConst>] static member easeInOutQuint: Cubic = nativeOnly
  [<IsConst>] static member easeInOutExpo: Cubic = nativeOnly
  [<IsConst>] static member easeInOutCirc: Cubic = nativeOnly
  [<IsConst>] static member easeInOutBack: Cubic = nativeOnly
  [<IsConst>] static member fastOutSlowIn: Cubic = nativeOnly
  [<IsConst>] static member slowMiddle: Cubic = nativeOnly
  [<IsConst>] static member bounceIn: Curve = nativeOnly
  [<IsConst>] static member bounceOut: Curve = nativeOnly
  [<IsConst>] static member bounceInOut: Curve = nativeOnly
  [<IsConst>] static member elasticIn: ElasticInCurve = nativeOnly
  [<IsConst>] static member elasticOut: ElasticOutCurve = nativeOnly
  [<IsConst>] static member elasticInOut: ElasticInOutCurve = nativeOnly

/// https://api.flutter.dev/flutter/animation/Animatable-class.html
[<ImportMember("package:flutter/animation.dart")>]
type Animatable<'T> [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/animation/Tween-class.html
[<ImportMember("package:flutter/animation.dart")>]
type Tween<'T> [<NamedParams>] ([<Optional>] ``begin``: 'T, [<Optional>] ``end``: 'T) =
  class end

/// https://api.flutter.dev/flutter/animation/ReverseTween-class.html
[<ImportMember("package:flutter/animation.dart")>]
type ReverseTween<'T> (parent: Tween<'T>) =
  class end

/// https://api.flutter.dev/flutter/animation/ColorTween-class.html
[<ImportMember("package:flutter/animation.dart")>]
type ColorTween [<NamedParams>] ([<Optional>] ``begin``: Color, [<Optional>] ``end``: Color) =
  class end

/// https://api.flutter.dev/flutter/animation/SizeTween-class.html
[<ImportMember("package:flutter/animation.dart")>]
type SizeTween [<NamedParams>] ([<Optional>] ``begin``: Size, [<Optional>] ``end``: Size) =
  class end

/// https://api.flutter.dev/flutter/animation/RectTween-class.html
[<ImportMember("package:flutter/animation.dart")>]
type RectTween [<NamedParams>] ([<Optional>] ``begin``: Rect, [<Optional>] ``end``: Rect) =
  class end

/// https://api.flutter.dev/flutter/animation/IntTween-class.html
[<ImportMember("package:flutter/animation.dart")>]
type IntTween [<NamedParams>] ([<Optional>] ``begin``: int, [<Optional>] ``end``: int) =
  class end

/// https://api.flutter.dev/flutter/animation/StepTween-class.html
[<ImportMember("package:flutter/animation.dart")>]
type StepTween [<NamedParams>] ([<Optional>] ``begin``: int, [<Optional>] ``end``: int) =
  class end

/// https://api.flutter.dev/flutter/animation/ConstantTween-class.html
[<ImportMember("package:flutter/animation.dart")>]
type ConstantTween<'T> (value: 'T) =
  class end

/// https://api.flutter.dev/flutter/animation/CurveTween-class.html
[<ImportMember("package:flutter/animation.dart")>]
type CurveTween [<NamedParams>] (curve: Curve) =
  class end

/// https://api.flutter.dev/flutter/animation/TweenSequence-class.html
[<ImportMember("package:flutter/animation.dart")>]
type TweenSequence<'T> (items: TweenSequenceItem<'T>[]) =
  class end

/// https://api.flutter.dev/flutter/animation/FlippedTweenSequence-class.html
[<ImportMember("package:flutter/animation.dart")>]
type FlippedTweenSequence (items: TweenSequenceItem<float>[]) =
  class end

/// https://api.flutter.dev/flutter/animation/TweenSequenceItem-class.html
[<ImportMember("package:flutter/animation.dart")>]
type TweenSequenceItem<'T> [<IsConst; NamedParams>] (tween: Animatable<'T>, weight: float) =
  class end

