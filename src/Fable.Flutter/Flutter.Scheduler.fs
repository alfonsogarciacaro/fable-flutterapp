namespace rec Flutter.Scheduler

open System
open System.Runtime.InteropServices
open Fable.Core
open Fable.Core.Dart

/// https://api.flutter.dev/flutter/scheduler/SchedulerPhase.html
[<ImportMember("package:flutter/scheduler.dart")>]
type SchedulerPhase =
  [<IsConst>] static member idle: SchedulerPhase = nativeOnly
  [<IsConst>] static member transientCallbacks: SchedulerPhase = nativeOnly
  [<IsConst>] static member midFrameMicrotasks: SchedulerPhase = nativeOnly
  [<IsConst>] static member persistentCallbacks: SchedulerPhase = nativeOnly
  [<IsConst>] static member postFrameCallbacks: SchedulerPhase = nativeOnly
  [<IsConst>] static member values: SchedulerPhase = nativeOnly

/// https://api.flutter.dev/flutter/scheduler/Priority-class.html
[<ImportMember("package:flutter/scheduler.dart")>]
type Priority =
  [<IsConst>] static member idle: Priority = nativeOnly
  [<IsConst>] static member animation: Priority = nativeOnly
  [<IsConst>] static member touch: Priority = nativeOnly
  [<IsConst>] static member kMaxOffset: int = nativeOnly

/// https://api.flutter.dev/flutter/scheduler/TickerProvider-class.html
[<ImportMember("package:flutter/scheduler.dart")>]
type TickerProvider [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/scheduler/Ticker-class.html
[<ImportMember("package:flutter/scheduler.dart")>]
type Ticker [<NamedParams(fromIndex=1)>] (_onTick: (TimeSpan -> unit), [<Optional>] debugLabel: string) =
  class end

/// https://api.flutter.dev/flutter/scheduler/TickerFuture-class.html
[<ImportMember("package:flutter/scheduler.dart")>]
type TickerFuture =
  static member complete(): TickerFuture = nativeOnly

