namespace rec Flutter.Widgets

open System
open System.Collections.Generic
open Fable.Core
open Fable.Core.Dart
open Dart
open Flutter.Foundation
open Flutter.Gestures
open Flutter.Services
open Flutter.Painting
open Flutter.Rendering
open Flutter.Animation
open Flutter.Scheduler
open Flutter.Semantics

type FlutterError = exn

/// https://api.flutter.dev/flutter/widgets/CrossFadeState.html
[<ImportMember("package:flutter/widgets.dart")>]
type CrossFadeState =
  [<IsConst>] static member showFirst: CrossFadeState = nativeOnly
  [<IsConst>] static member showSecond: CrossFadeState = nativeOnly
  [<IsConst>] static member values: CrossFadeState = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ConnectionState.html
[<ImportMember("package:flutter/widgets.dart")>]
type ConnectionState =
  [<IsConst>] static member none: ConnectionState = nativeOnly
  [<IsConst>] static member waiting: ConnectionState = nativeOnly
  [<IsConst>] static member active: ConnectionState = nativeOnly
  [<IsConst>] static member ``done``: ConnectionState = nativeOnly
  [<IsConst>] static member values: ConnectionState = nativeOnly

/// https://api.flutter.dev/flutter/widgets/AutofillContextAction.html
[<ImportMember("package:flutter/widgets.dart")>]
type AutofillContextAction =
  [<IsConst>] static member commit: AutofillContextAction = nativeOnly
  [<IsConst>] static member cancel: AutofillContextAction = nativeOnly
  [<IsConst>] static member values: AutofillContextAction = nativeOnly

/// https://api.flutter.dev/flutter/widgets/BannerLocation.html
[<ImportMember("package:flutter/widgets.dart")>]
type BannerLocation =
  [<IsConst>] static member topStart: BannerLocation = nativeOnly
  [<IsConst>] static member topEnd: BannerLocation = nativeOnly
  [<IsConst>] static member bottomStart: BannerLocation = nativeOnly
  [<IsConst>] static member bottomEnd: BannerLocation = nativeOnly
  [<IsConst>] static member values: BannerLocation = nativeOnly

/// https://api.flutter.dev/flutter/widgets/DismissDirection.html
[<ImportMember("package:flutter/widgets.dart")>]
type DismissDirection =
  [<IsConst>] static member vertical: DismissDirection = nativeOnly
  [<IsConst>] static member horizontal: DismissDirection = nativeOnly
  [<IsConst>] static member endToStart: DismissDirection = nativeOnly
  [<IsConst>] static member startToEnd: DismissDirection = nativeOnly
  [<IsConst>] static member up: DismissDirection = nativeOnly
  [<IsConst>] static member down: DismissDirection = nativeOnly
  [<IsConst>] static member none: DismissDirection = nativeOnly
  [<IsConst>] static member values: DismissDirection = nativeOnly

/// https://api.flutter.dev/flutter/widgets/DragAnchor.html
[<ImportMember("package:flutter/widgets.dart")>]
type DragAnchor =
  [<IsConst>] static member child: DragAnchor = nativeOnly
  [<IsConst>] static member pointer: DragAnchor = nativeOnly
  [<IsConst>] static member values: DragAnchor = nativeOnly

/// https://api.flutter.dev/flutter/widgets/KeyEventResult.html
[<ImportMember("package:flutter/widgets.dart")>]
type KeyEventResult =
  [<IsConst>] static member handled: KeyEventResult = nativeOnly
  [<IsConst>] static member ignored: KeyEventResult = nativeOnly
  [<IsConst>] static member skipRemainingHandlers: KeyEventResult = nativeOnly
  [<IsConst>] static member values: KeyEventResult = nativeOnly

/// https://api.flutter.dev/flutter/widgets/UnfocusDisposition.html
[<ImportMember("package:flutter/widgets.dart")>]
type UnfocusDisposition =
  [<IsConst>] static member scope: UnfocusDisposition = nativeOnly
  [<IsConst>] static member previouslyFocusedChild: UnfocusDisposition = nativeOnly
  [<IsConst>] static member values: UnfocusDisposition = nativeOnly

/// https://api.flutter.dev/flutter/widgets/FocusHighlightMode.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusHighlightMode =
  [<IsConst>] static member touch: FocusHighlightMode = nativeOnly
  [<IsConst>] static member traditional: FocusHighlightMode = nativeOnly
  [<IsConst>] static member values: FocusHighlightMode = nativeOnly

/// https://api.flutter.dev/flutter/widgets/FocusHighlightStrategy.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusHighlightStrategy =
  [<IsConst>] static member automatic: FocusHighlightStrategy = nativeOnly
  [<IsConst>] static member alwaysTouch: FocusHighlightStrategy = nativeOnly
  [<IsConst>] static member alwaysTraditional: FocusHighlightStrategy = nativeOnly
  [<IsConst>] static member values: FocusHighlightStrategy = nativeOnly

/// https://api.flutter.dev/flutter/widgets/TraversalDirection.html
[<ImportMember("package:flutter/widgets.dart")>]
type TraversalDirection =
  [<IsConst>] static member up: TraversalDirection = nativeOnly
  [<IsConst>] static member right: TraversalDirection = nativeOnly
  [<IsConst>] static member down: TraversalDirection = nativeOnly
  [<IsConst>] static member left: TraversalDirection = nativeOnly
  [<IsConst>] static member values: TraversalDirection = nativeOnly

/// https://api.flutter.dev/flutter/widgets/AutovalidateMode.html
[<ImportMember("package:flutter/widgets.dart")>]
type AutovalidateMode =
  [<IsConst>] static member disabled: AutovalidateMode = nativeOnly
  [<IsConst>] static member always: AutovalidateMode = nativeOnly
  [<IsConst>] static member onUserInteraction: AutovalidateMode = nativeOnly
  [<IsConst>] static member values: AutovalidateMode = nativeOnly

/// https://api.flutter.dev/flutter/widgets/HeroFlightDirection.html
[<ImportMember("package:flutter/widgets.dart")>]
type HeroFlightDirection =
  [<IsConst>] static member push: HeroFlightDirection = nativeOnly
  [<IsConst>] static member pop: HeroFlightDirection = nativeOnly
  [<IsConst>] static member values: HeroFlightDirection = nativeOnly

/// https://api.flutter.dev/flutter/widgets/Orientation.html
[<ImportMember("package:flutter/widgets.dart")>]
type Orientation =
  [<IsConst>] static member portrait: Orientation = nativeOnly
  [<IsConst>] static member landscape: Orientation = nativeOnly
  [<IsConst>] static member values: Orientation = nativeOnly

/// https://api.flutter.dev/flutter/widgets/NavigationMode.html
[<ImportMember("package:flutter/widgets.dart")>]
type NavigationMode =
  [<IsConst>] static member traditional: NavigationMode = nativeOnly
  [<IsConst>] static member directional: NavigationMode = nativeOnly
  [<IsConst>] static member values: NavigationMode = nativeOnly

/// https://api.flutter.dev/flutter/widgets/RoutePopDisposition.html
[<ImportMember("package:flutter/widgets.dart")>]
type RoutePopDisposition =
  [<IsConst>] static member pop: RoutePopDisposition = nativeOnly
  [<IsConst>] static member doNotPop: RoutePopDisposition = nativeOnly
  [<IsConst>] static member bubble: RoutePopDisposition = nativeOnly
  [<IsConst>] static member values: RoutePopDisposition = nativeOnly

/// https://api.flutter.dev/flutter/widgets/OverflowBarAlignment.html
[<ImportMember("package:flutter/widgets.dart")>]
type OverflowBarAlignment =
  [<IsConst>] static member start: OverflowBarAlignment = nativeOnly
  [<IsConst>] static member ``end``: OverflowBarAlignment = nativeOnly
  [<IsConst>] static member center: OverflowBarAlignment = nativeOnly
  [<IsConst>] static member values: OverflowBarAlignment = nativeOnly

/// https://api.flutter.dev/flutter/widgets/PlatformProvidedMenuItemType.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformProvidedMenuItemType =
  [<IsConst>] static member about: PlatformProvidedMenuItemType = nativeOnly
  [<IsConst>] static member quit: PlatformProvidedMenuItemType = nativeOnly
  [<IsConst>] static member servicesSubmenu: PlatformProvidedMenuItemType = nativeOnly
  [<IsConst>] static member hide: PlatformProvidedMenuItemType = nativeOnly
  [<IsConst>] static member hideOtherApplications: PlatformProvidedMenuItemType = nativeOnly
  [<IsConst>] static member showAllApplications: PlatformProvidedMenuItemType = nativeOnly
  [<IsConst>] static member startSpeaking: PlatformProvidedMenuItemType = nativeOnly
  [<IsConst>] static member stopSpeaking: PlatformProvidedMenuItemType = nativeOnly
  [<IsConst>] static member toggleFullScreen: PlatformProvidedMenuItemType = nativeOnly
  [<IsConst>] static member minimizeWindow: PlatformProvidedMenuItemType = nativeOnly
  [<IsConst>] static member zoomWindow: PlatformProvidedMenuItemType = nativeOnly
  [<IsConst>] static member arrangeWindowsInFront: PlatformProvidedMenuItemType = nativeOnly
  [<IsConst>] static member values: PlatformProvidedMenuItemType = nativeOnly

/// https://api.flutter.dev/flutter/widgets/RouteInformationReportingType.html
[<ImportMember("package:flutter/widgets.dart")>]
type RouteInformationReportingType =
  [<IsConst>] static member none: RouteInformationReportingType = nativeOnly
  [<IsConst>] static member neglect: RouteInformationReportingType = nativeOnly
  [<IsConst>] static member navigate: RouteInformationReportingType = nativeOnly
  [<IsConst>] static member values: RouteInformationReportingType = nativeOnly

/// https://api.flutter.dev/flutter/widgets/AndroidOverscrollIndicator.html
[<ImportMember("package:flutter/widgets.dart")>]
type AndroidOverscrollIndicator =
  [<IsConst>] static member stretch: AndroidOverscrollIndicator = nativeOnly
  [<IsConst>] static member glow: AndroidOverscrollIndicator = nativeOnly
  [<IsConst>] static member values: AndroidOverscrollIndicator = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ScrollPositionAlignmentPolicy.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollPositionAlignmentPolicy =
  [<IsConst>] static member explicit: ScrollPositionAlignmentPolicy = nativeOnly
  [<IsConst>] static member keepVisibleAtEnd: ScrollPositionAlignmentPolicy = nativeOnly
  [<IsConst>] static member keepVisibleAtStart: ScrollPositionAlignmentPolicy = nativeOnly
  [<IsConst>] static member values: ScrollPositionAlignmentPolicy = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ScrollViewKeyboardDismissBehavior.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollViewKeyboardDismissBehavior =
  [<IsConst>] static member manual: ScrollViewKeyboardDismissBehavior = nativeOnly
  [<IsConst>] static member onDrag: ScrollViewKeyboardDismissBehavior = nativeOnly
  [<IsConst>] static member values: ScrollViewKeyboardDismissBehavior = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ScrollIncrementType.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollIncrementType =
  [<IsConst>] static member line: ScrollIncrementType = nativeOnly
  [<IsConst>] static member page: ScrollIncrementType = nativeOnly
  [<IsConst>] static member values: ScrollIncrementType = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ScrollbarOrientation.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollbarOrientation =
  [<IsConst>] static member left: ScrollbarOrientation = nativeOnly
  [<IsConst>] static member right: ScrollbarOrientation = nativeOnly
  [<IsConst>] static member top: ScrollbarOrientation = nativeOnly
  [<IsConst>] static member bottom: ScrollbarOrientation = nativeOnly
  [<IsConst>] static member values: ScrollbarOrientation = nativeOnly

/// https://api.flutter.dev/flutter/widgets/TextSelectionHandleType.html
[<ImportMember("package:flutter/widgets.dart")>]
type TextSelectionHandleType =
  [<IsConst>] static member left: TextSelectionHandleType = nativeOnly
  [<IsConst>] static member right: TextSelectionHandleType = nativeOnly
  [<IsConst>] static member collapsed: TextSelectionHandleType = nativeOnly
  [<IsConst>] static member values: TextSelectionHandleType = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ClipboardStatus.html
[<ImportMember("package:flutter/widgets.dart")>]
type ClipboardStatus =
  [<IsConst>] static member pasteable: ClipboardStatus = nativeOnly
  [<IsConst>] static member unknown: ClipboardStatus = nativeOnly
  [<IsConst>] static member notPasteable: ClipboardStatus = nativeOnly
  [<IsConst>] static member values: ClipboardStatus = nativeOnly

/// https://api.flutter.dev/flutter/widgets/AutomaticKeepAliveClientMixin-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type AutomaticKeepAliveClientMixin =
  interface end

/// https://api.flutter.dev/flutter/widgets/WidgetsBinding-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type WidgetsBinding =
  interface end

/// https://api.flutter.dev/flutter/widgets/DirectionalFocusTraversalPolicyMixin-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type DirectionalFocusTraversalPolicyMixin =
  interface end

/// https://api.flutter.dev/flutter/widgets/NotifiableElementMixin-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type NotifiableElementMixin =
  interface end

/// https://api.flutter.dev/flutter/widgets/RenderConstrainedLayoutBuilder-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type RenderConstrainedLayoutBuilder =
  interface end

/// https://api.flutter.dev/flutter/widgets/MenuSerializableShortcut-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type MenuSerializableShortcut =
  interface end

/// https://api.flutter.dev/flutter/widgets/RestorationMixin-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorationMixin =
  interface end

/// https://api.flutter.dev/flutter/widgets/PopNavigatorRouterDelegateMixin-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type PopNavigatorRouterDelegateMixin =
  interface end

/// https://api.flutter.dev/flutter/widgets/LocalHistoryRoute-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type LocalHistoryRoute =
  interface end

/// https://api.flutter.dev/flutter/widgets/ScrollMetrics-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollMetrics =
  interface end

/// https://api.flutter.dev/flutter/widgets/ViewportNotificationMixin-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type ViewportNotificationMixin =
  interface end

/// https://api.flutter.dev/flutter/widgets/ViewportElementMixin-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type ViewportElementMixin =
  interface end

/// https://api.flutter.dev/flutter/widgets/SlottedMultiChildRenderObjectWidgetMixin-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type SlottedMultiChildRenderObjectWidgetMixin =
  interface end

/// https://api.flutter.dev/flutter/widgets/SlottedContainerRenderObjectMixin-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type SlottedContainerRenderObjectMixin =
  interface end

/// https://api.flutter.dev/flutter/widgets/SingleTickerProviderStateMixin-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type SingleTickerProviderStateMixin =
  interface end

/// https://api.flutter.dev/flutter/widgets/TickerProviderStateMixin-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type TickerProviderStateMixin =
  interface end

/// https://api.flutter.dev/flutter/widgets/WidgetInspectorService-mixin.html
[<ImportMember("package:flutter/widgets.dart")>]
type WidgetInspectorService =
  interface end

/// https://api.flutter.dev/flutter/widgets/Intent-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type Intent [<IsConst>] () =
  [<IsConst>] static member doNothing: DoNothingIntent = nativeOnly

/// https://api.flutter.dev/flutter/widgets/Action-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type Action<'T> () =
  [<NamedParams>] static member overridable(defaultAction: Action<'T>, context: BuildContext): Action<'T> = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ActionListener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ActionListener [<IsConst; NamedParams>] (listener: (Action<Intent> -> unit), action: Action<Intent>, child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ContextAction-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ContextAction<'T> () =
  inherit Action<'T>()

/// https://api.flutter.dev/flutter/widgets/CallbackAction-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CallbackAction<'T> [<NamedParams>] (onInvoke: ('T -> obj option)) =
  inherit Action<'T>()

/// https://api.flutter.dev/flutter/widgets/ActionDispatcher-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ActionDispatcher [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/Actions-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Actions [<IsConst; NamedParams>] (actions: Dictionary<Type, Action<Intent>>, child: Widget, ?key: Key, ?dispatcher: ActionDispatcher) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/FocusableActionDetector-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusableActionDetector [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?enabled: bool, ?focusNode: FocusNode, ?autofocus: bool, ?descendantsAreFocusable: bool, ?descendantsAreTraversable: bool, ?shortcuts: Dictionary<ShortcutActivator, Intent>, ?actions: Dictionary<Type, Action<Intent>>, ?onShowFocusHighlight: (bool -> unit), ?onShowHoverHighlight: (bool -> unit), ?onFocusChange: (bool -> unit), ?mouseCursor: MouseCursor) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/DoNothingIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DoNothingIntent () =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/DoNothingAndStopPropagationIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DoNothingAndStopPropagationIntent () =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/DoNothingAction-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DoNothingAction [<NamedParams>] (?consumesKey: bool) =
  inherit Action<Intent>()

/// https://api.flutter.dev/flutter/widgets/ActivateIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ActivateIntent [<IsConst>] () =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/ButtonActivateIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ButtonActivateIntent [<IsConst>] () =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/ActivateAction-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ActivateAction () =
  inherit Action<ActivateIntent>()

/// https://api.flutter.dev/flutter/widgets/SelectIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SelectIntent () =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/SelectAction-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type SelectAction () =
  inherit Action<SelectIntent>()

/// https://api.flutter.dev/flutter/widgets/DismissIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DismissIntent [<IsConst>] () =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/DismissAction-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type DismissAction () =
  inherit Action<DismissIntent>()

/// https://api.flutter.dev/flutter/widgets/PrioritizedIntents-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PrioritizedIntents [<IsConst; NamedParams>] (orderedIntents: Intent[]) =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/PrioritizedAction-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PrioritizedAction () =
  inherit Action<PrioritizedIntents>()

/// https://api.flutter.dev/flutter/widgets/AnimatedCrossFade-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedCrossFade [<IsConst; NamedParams>] (firstChild: Widget, secondChild: Widget, crossFadeState: CrossFadeState, duration: TimeSpan, ?key: Key, ?firstCurve: Curve, ?secondCurve: Curve, ?sizeCurve: Curve, ?alignment: AlignmentGeometry, ?reverseDuration: TimeSpan, ?layoutBuilder: (Widget -> Key -> Widget -> Key -> Widget), ?excludeBottomFocus: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AnimatedList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedList [<IsConst; NamedParams>] (itemBuilder: (BuildContext -> int -> Animation<float> -> Widget), ?key: Key, ?initialItemCount: int, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?padding: EdgeInsetsGeometry, ?clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AnimatedListState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedListState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/SliverAnimatedList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverAnimatedList [<IsConst; NamedParams>] (itemBuilder: (BuildContext -> int -> Animation<float> -> Widget), ?key: Key, ?findChildIndexCallback: (Key -> int option), ?initialItemCount: int) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverAnimatedListState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverAnimatedListState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/AnimatedSize-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedSize [<IsConst; NamedParams>] (duration: TimeSpan, ?key: Key, ?child: Widget, ?alignment: AlignmentGeometry, ?curve: Curve, ?reverseDuration: TimeSpan, ?vsync: TickerProvider, ?clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AnimatedSwitcher-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedSwitcher [<IsConst; NamedParams>] (duration: TimeSpan, ?key: Key, ?child: Widget, ?reverseDuration: TimeSpan, ?switchInCurve: Curve, ?switchOutCurve: Curve, ?transitionBuilder: (Widget -> Animation<float> -> Widget), ?layoutBuilder: (Widget option -> Widget[] -> Widget)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AnnotatedRegion-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnnotatedRegion<'T> [<IsConst; NamedParams>] (child: Widget, value: 'T, ?key: Key, ?sized: bool) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/WidgetsApp-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type WidgetsApp [<NamedParams>] (color: Color, ?key: Key, ?navigatorKey: GlobalKey<NavigatorState>, ?onGenerateRoute: (RouteSettings -> Route<obj> option), ?onGenerateInitialRoutes: (string -> Route<obj>[]), ?onUnknownRoute: (RouteSettings -> Route<obj> option), ?navigatorObservers: NavigatorObserver[], ?initialRoute: string, ?pageRouteBuilder: (RouteSettings -> (BuildContext -> Widget) -> PageRoute<obj>), ?home: Widget, ?routes: Dictionary<string, (BuildContext -> Widget)>, ?builder: (BuildContext -> Widget option -> Widget), ?title: string, ?onGenerateTitle: (BuildContext -> string), ?textStyle: TextStyle, ?locale: Locale, ?localizationsDelegates: LocalizationsDelegate<obj> seq, ?localeListResolutionCallback: (Locale[] option -> Locale seq -> Locale option), ?localeResolutionCallback: (Locale option -> Locale seq -> Locale option), ?supportedLocales: Locale seq, ?showPerformanceOverlay: bool, ?checkerboardRasterCacheImages: bool, ?checkerboardOffscreenLayers: bool, ?showSemanticsDebugger: bool, ?debugShowWidgetInspector: bool, ?debugShowCheckedModeBanner: bool, ?inspectorSelectButtonBuilder: (BuildContext -> (unit -> unit) -> Widget), ?shortcuts: Dictionary<ShortcutActivator, Intent>, ?actions: Dictionary<Type, Action<Intent>>, ?restorationScopeId: string, ?useInheritedMediaQuery: bool) =
  inherit Widget()
  [<NamedParams>] static member router(routeInformationParser: RouteInformationParser<obj>, routerDelegate: RouterDelegate<obj>, color: Color, ?key: Key, ?routeInformationProvider: RouteInformationProvider, ?backButtonDispatcher: BackButtonDispatcher, ?builder: (BuildContext -> Widget option -> Widget), ?title: string, ?onGenerateTitle: (BuildContext -> string), ?textStyle: TextStyle, ?locale: Locale, ?localizationsDelegates: LocalizationsDelegate<obj> seq, ?localeListResolutionCallback: (Locale[] option -> Locale seq -> Locale option), ?localeResolutionCallback: (Locale option -> Locale seq -> Locale option), ?supportedLocales: Locale seq, ?showPerformanceOverlay: bool, ?checkerboardRasterCacheImages: bool, ?checkerboardOffscreenLayers: bool, ?showSemanticsDebugger: bool, ?debugShowWidgetInspector: bool, ?debugShowCheckedModeBanner: bool, ?inspectorSelectButtonBuilder: (BuildContext -> (unit -> unit) -> Widget), ?shortcuts: Dictionary<ShortcutActivator, Intent>, ?actions: Dictionary<Type, Action<Intent>>, ?restorationScopeId: string, ?useInheritedMediaQuery: bool): WidgetsApp = nativeOnly

/// https://api.flutter.dev/flutter/widgets/StreamBuilderBase-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type StreamBuilderBase<'T, 'S> [<IsConst; NamedParams>] (?key: Key, ?stream: Stream<'T>) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AsyncSnapshot-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AsyncSnapshot<'T> =
  [<IsConst>] static member nothing(): AsyncSnapshot<'T> = nativeOnly
  [<IsConst>] static member waiting(): AsyncSnapshot<'T> = nativeOnly
  [<IsConst>] static member withData(state: ConnectionState, data: 'T): AsyncSnapshot<'T> = nativeOnly
  [<IsConst>] static member withError(state: ConnectionState, error: obj, ?stackTrace: StackTrace): AsyncSnapshot<'T> = nativeOnly

/// https://api.flutter.dev/flutter/widgets/StreamBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type StreamBuilder<'T> [<IsConst; NamedParams>] (builder: (BuildContext -> AsyncSnapshot<'T> -> Widget), ?key: Key, ?initialData: 'T, ?stream: Stream<'T>) =
  inherit StreamBuilderBase<'T, AsyncSnapshot<'T>>()

/// https://api.flutter.dev/flutter/widgets/FutureBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FutureBuilder<'T> [<IsConst; NamedParams>] (builder: (BuildContext -> AsyncSnapshot<'T> -> Widget), ?key: Key, ?future: Future<'T>, ?initialData: 'T) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/RawAutocomplete-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawAutocomplete<'T> [<IsConst; NamedParams>] (optionsViewBuilder: (BuildContext -> ('T -> unit) -> 'T seq -> Widget), optionsBuilder: (TextEditingValue -> FutureOr<'T seq>), ?key: Key, ?displayStringForOption: ('T -> string), ?fieldViewBuilder: (BuildContext -> TextEditingController -> FocusNode -> (unit -> unit) -> Widget), ?focusNode: FocusNode, ?onSelected: ('T -> unit), ?textEditingController: TextEditingController, ?initialValue: TextEditingValue) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AutocompletePreviousOptionIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AutocompletePreviousOptionIntent [<IsConst>] () =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/AutocompleteNextOptionIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AutocompleteNextOptionIntent [<IsConst>] () =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/AutocompleteHighlightedOption-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AutocompleteHighlightedOption [<IsConst; NamedParams>] (highlightIndexNotifier: ValueNotifier<int>, child: Widget, ?key: Key) =
  inherit InheritedNotifier<ValueNotifier<int>>(child)

/// https://api.flutter.dev/flutter/widgets/AutofillGroup-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AutofillGroup [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?onDisposeAction: AutofillContextAction) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AutofillGroupState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AutofillGroupState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/AutomaticKeepAlive-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AutomaticKeepAlive [<IsConst; NamedParams>] (?key: Key, ?child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/KeepAliveNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type KeepAliveNotification [<IsConst>] (handle: Listenable) =
  inherit Notification()

/// https://api.flutter.dev/flutter/widgets/KeepAliveHandle-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type KeepAliveHandle () =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/widgets/BannerPainter-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BannerPainter [<NamedParams>] (message: string, textDirection: TextDirection, location: BannerLocation, layoutDirection: TextDirection, ?color: Color, ?textStyle: TextStyle) =
  inherit CustomPainter()

/// https://api.flutter.dev/flutter/widgets/Banner-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Banner [<IsConst; NamedParams>] (message: string, location: BannerLocation, ?key: Key, ?child: Widget, ?textDirection: TextDirection, ?layoutDirection: TextDirection, ?color: Color, ?textStyle: TextStyle) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/CheckedModeBanner-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CheckedModeBanner [<IsConst; NamedParams>] (child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Directionality-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Directionality [<IsConst; NamedParams>] (textDirection: TextDirection, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/Opacity-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Opacity [<IsConst; NamedParams>] (opacity: float, ?key: Key, ?alwaysIncludeSemantics: bool, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ShaderMask-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ShaderMask [<IsConst; NamedParams>] (shaderCallback: (Rect -> Shader), ?key: Key, ?blendMode: BlendMode, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/BackdropFilter-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BackdropFilter [<IsConst; NamedParams>] (filter: ImageFilter, ?key: Key, ?child: Widget, ?blendMode: BlendMode) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/CustomPaint-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CustomPaint [<IsConst; NamedParams>] (?key: Key, ?painter: CustomPainter, ?foregroundPainter: CustomPainter, ?size: Size, ?isComplex: bool, ?willChange: bool, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ClipRect-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ClipRect [<IsConst; NamedParams>] (?key: Key, ?clipper: CustomClipper<Rect>, ?clipBehavior: Clip, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ClipRRect-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ClipRRect [<IsConst; NamedParams>] (?key: Key, ?borderRadius: BorderRadius, ?clipper: CustomClipper<RRect>, ?clipBehavior: Clip, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ClipOval-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ClipOval [<IsConst; NamedParams>] (?key: Key, ?clipper: CustomClipper<Rect>, ?clipBehavior: Clip, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ClipPath-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ClipPath [<IsConst; NamedParams>] (?key: Key, ?clipper: CustomClipper<Path>, ?clipBehavior: Clip, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/PhysicalModel-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PhysicalModel [<IsConst; NamedParams>] (color: Color, ?key: Key, ?shape: BoxShape, ?clipBehavior: Clip, ?borderRadius: BorderRadius, ?elevation: float, ?shadowColor: Color, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/PhysicalShape-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PhysicalShape [<IsConst; NamedParams>] (clipper: CustomClipper<Path>, color: Color, ?key: Key, ?clipBehavior: Clip, ?elevation: float, ?shadowColor: Color, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Transform-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Transform [<IsConst; NamedParams>] (transform: Matrix4, ?key: Key, ?origin: Offset, ?alignment: AlignmentGeometry, ?transformHitTests: bool, ?filterQuality: FilterQuality, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()
  [<NamedParams>] static member rotate(angle: float, ?key: Key, ?origin: Offset, ?alignment: AlignmentGeometry, ?transformHitTests: bool, ?filterQuality: FilterQuality, ?child: Widget): Transform = nativeOnly
  [<NamedParams>] static member translate(offset: Offset, ?key: Key, ?transformHitTests: bool, ?filterQuality: FilterQuality, ?child: Widget): Transform = nativeOnly
  [<NamedParams>] static member scale(?key: Key, ?scale: float, ?scaleX: float, ?scaleY: float, ?origin: Offset, ?alignment: AlignmentGeometry, ?transformHitTests: bool, ?filterQuality: FilterQuality, ?child: Widget): Transform = nativeOnly

/// https://api.flutter.dev/flutter/widgets/CompositedTransformTarget-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CompositedTransformTarget [<IsConst; NamedParams>] (link: LayerLink, ?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/CompositedTransformFollower-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CompositedTransformFollower [<IsConst; NamedParams>] (link: LayerLink, ?key: Key, ?showWhenUnlinked: bool, ?offset: Offset, ?targetAnchor: Alignment, ?followerAnchor: Alignment, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/FittedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FittedBox [<IsConst; NamedParams>] (?key: Key, ?fit: BoxFit, ?alignment: AlignmentGeometry, ?clipBehavior: Clip, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/FractionalTranslation-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FractionalTranslation [<IsConst; NamedParams>] (translation: Offset, ?key: Key, ?transformHitTests: bool, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/RotatedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RotatedBox [<IsConst; NamedParams>] (quarterTurns: int, ?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Padding-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Padding [<IsConst; NamedParams>] (padding: EdgeInsetsGeometry, ?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Align-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Align [<IsConst; NamedParams>] (?key: Key, ?alignment: AlignmentGeometry, ?widthFactor: float, ?heightFactor: float, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Center-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Center [<IsConst; NamedParams>] (?key: Key, ?widthFactor: float, ?heightFactor: float, ?child: Widget) =
  inherit Align()

/// https://api.flutter.dev/flutter/widgets/CustomSingleChildLayout-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CustomSingleChildLayout [<IsConst; NamedParams>] (``delegate``: SingleChildLayoutDelegate, ?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/LayoutId-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LayoutId [<NamedParams>] (id: obj, child: Widget, ?key: Key) =
  inherit ParentDataWidget<MultiChildLayoutParentData>(child)

/// https://api.flutter.dev/flutter/widgets/CustomMultiChildLayout-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CustomMultiChildLayout [<NamedParams>] (``delegate``: MultiChildLayoutDelegate, ?key: Key, ?children: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SizedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SizedBox [<IsConst; NamedParams>] (?key: Key, ?width: float, ?height: float, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()
  [<IsConst; NamedParams>] static member expand(?key: Key, ?child: Widget): SizedBox = nativeOnly
  [<IsConst; NamedParams>] static member shrink(?key: Key, ?child: Widget): SizedBox = nativeOnly
  [<NamedParams>] static member fromSize(?key: Key, ?child: Widget, ?size: Size): SizedBox = nativeOnly
  [<IsConst; NamedParams>] static member square(?key: Key, ?child: Widget, ?dimension: float): SizedBox = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ConstrainedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ConstrainedBox [<NamedParams>] (constraints: BoxConstraints, ?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ConstraintsTransformBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ConstraintsTransformBox [<IsConst; NamedParams>] (constraintsTransform: (BoxConstraints -> BoxConstraints), ?key: Key, ?child: Widget, ?textDirection: TextDirection, ?alignment: AlignmentGeometry, ?clipBehavior: Clip, ?debugTransformType: string) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/UnconstrainedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type UnconstrainedBox [<IsConst; NamedParams>] (?key: Key, ?child: Widget, ?textDirection: TextDirection, ?alignment: AlignmentGeometry, ?constrainedAxis: Axis, ?clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/FractionallySizedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FractionallySizedBox [<IsConst; NamedParams>] (?key: Key, ?alignment: AlignmentGeometry, ?widthFactor: float, ?heightFactor: float, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/LimitedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LimitedBox [<IsConst; NamedParams>] (?key: Key, ?maxWidth: float, ?maxHeight: float, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/OverflowBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OverflowBox [<IsConst; NamedParams>] (?key: Key, ?alignment: AlignmentGeometry, ?minWidth: float, ?maxWidth: float, ?minHeight: float, ?maxHeight: float, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SizedOverflowBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SizedOverflowBox [<IsConst; NamedParams>] (size: Size, ?key: Key, ?alignment: AlignmentGeometry, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Offstage-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Offstage [<IsConst; NamedParams>] (?key: Key, ?offstage: bool, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/AspectRatio-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AspectRatio [<IsConst; NamedParams>] (aspectRatio: float, ?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/IntrinsicWidth-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IntrinsicWidth [<IsConst; NamedParams>] (?key: Key, ?stepWidth: float, ?stepHeight: float, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/IntrinsicHeight-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IntrinsicHeight [<IsConst; NamedParams>] (?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Baseline-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Baseline [<IsConst; NamedParams>] (baseline: float, baselineType: TextBaseline, ?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverToBoxAdapter-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverToBoxAdapter [<IsConst; NamedParams>] (?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverPadding-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverPadding [<IsConst; NamedParams>] (padding: EdgeInsetsGeometry, ?key: Key, ?sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ListBody-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ListBody [<NamedParams>] (?key: Key, ?mainAxis: Axis, ?reverse: bool, ?children: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Stack-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Stack [<NamedParams>] (?key: Key, ?alignment: AlignmentGeometry, ?textDirection: TextDirection, ?fit: StackFit, ?clipBehavior: Clip, ?children: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/IndexedStack-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IndexedStack [<NamedParams>] (?key: Key, ?alignment: AlignmentGeometry, ?textDirection: TextDirection, ?sizing: StackFit, ?index: int, ?children: Widget[]) =
  inherit Stack()

/// https://api.flutter.dev/flutter/widgets/Positioned-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Positioned [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?left: float, ?top: float, ?right: float, ?bottom: float, ?width: float, ?height: float) =
  inherit ParentDataWidget<StackParentData>(child)
  [<NamedParams>] static member fromRect(rect: Rect, child: Widget, ?key: Key): Positioned = nativeOnly
  [<NamedParams>] static member fromRelativeRect(rect: RelativeRect, child: Widget, ?key: Key): Positioned = nativeOnly
  [<IsConst; NamedParams>] static member fill(child: Widget, ?key: Key, ?left: float, ?top: float, ?right: float, ?bottom: float): Positioned = nativeOnly
  [<NamedParams>] static member directional(textDirection: TextDirection, child: Widget, ?key: Key, ?start: float, ?top: float, ?``end``: float, ?bottom: float, ?width: float, ?height: float): Positioned = nativeOnly

/// https://api.flutter.dev/flutter/widgets/PositionedDirectional-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PositionedDirectional [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?start: float, ?top: float, ?``end``: float, ?bottom: float, ?width: float, ?height: float) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Flex-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Flex [<NamedParams>] (direction: Axis, ?key: Key, ?mainAxisAlignment: MainAxisAlignment, ?mainAxisSize: MainAxisSize, ?crossAxisAlignment: CrossAxisAlignment, ?textDirection: TextDirection, ?verticalDirection: VerticalDirection, ?textBaseline: TextBaseline, ?clipBehavior: Clip, ?children: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Row-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Row [<NamedParams>] (?children: Widget[], ?key: Key, ?mainAxisAlignment: MainAxisAlignment, ?mainAxisSize: MainAxisSize, ?crossAxisAlignment: CrossAxisAlignment, ?textDirection: TextDirection, ?verticalDirection: VerticalDirection, ?textBaseline: TextBaseline) =
  inherit Flex(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/Column-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Column [<NamedParams>] (?children: Widget[], ?key: Key, ?mainAxisAlignment: MainAxisAlignment, ?mainAxisSize: MainAxisSize, ?crossAxisAlignment: CrossAxisAlignment, ?textDirection: TextDirection, ?verticalDirection: VerticalDirection, ?textBaseline: TextBaseline) =
  inherit Flex(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/Flexible-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Flexible [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?flex: int, ?fit: FlexFit) =
  inherit ParentDataWidget<FlexParentData>(child)

/// https://api.flutter.dev/flutter/widgets/Expanded-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Expanded [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?flex: int) =
  inherit Flexible(child)

/// https://api.flutter.dev/flutter/widgets/Wrap-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Wrap [<NamedParams>] (?children: Widget[], ?key: Key, ?direction: Axis, ?alignment: WrapAlignment, ?spacing: float, ?runAlignment: WrapAlignment, ?runSpacing: float, ?crossAxisAlignment: WrapCrossAlignment, ?textDirection: TextDirection, ?verticalDirection: VerticalDirection, ?clipBehavior: Clip) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Flow-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Flow [<NamedParams>] (``delegate``: FlowDelegate, ?key: Key, ?children: Widget[], ?clipBehavior: Clip) =
  inherit MultiChildRenderObjectWidget()
  [<NamedParams>] static member unwrapped(``delegate``: FlowDelegate, ?key: Key, ?children: Widget[], ?clipBehavior: Clip): Flow = nativeOnly

/// https://api.flutter.dev/flutter/widgets/RichText-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RichText [<NamedParams>] (text: InlineSpan, ?key: Key, ?textAlign: TextAlign, ?textDirection: TextDirection, ?softWrap: bool, ?overflow: TextOverflow, ?textScaleFactor: float, ?maxLines: int, ?locale: Locale, ?strutStyle: StrutStyle, ?textWidthBasis: TextWidthBasis, ?textHeightBehavior: TextHeightBehavior) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/RawImage-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawImage [<IsConst; NamedParams>] (?key: Key, ?image: Image, ?debugImageLabel: string, ?width: float, ?height: float, ?scale: float, ?color: Color, ?opacity: Animation<float>, ?colorBlendMode: BlendMode, ?fit: BoxFit, ?alignment: AlignmentGeometry, ?repeat: ImageRepeat, ?centerSlice: Rect, ?matchTextDirection: bool, ?invertColors: bool, ?filterQuality: FilterQuality, ?isAntiAlias: bool) =
  inherit LeafRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/DefaultAssetBundle-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DefaultAssetBundle [<IsConst; NamedParams>] (bundle: AssetBundle, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/WidgetToRenderBoxAdapter-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type WidgetToRenderBoxAdapter [<NamedParams>] (renderBox: RenderBox, ?onBuild: (unit -> unit), ?onUnmount: (unit -> unit)) =
  inherit LeafRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Listener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Listener [<IsConst; NamedParams>] (?key: Key, ?onPointerDown: (PointerDownEvent -> unit), ?onPointerMove: (PointerMoveEvent -> unit), ?onPointerUp: (PointerUpEvent -> unit), ?onPointerHover: (PointerHoverEvent -> unit), ?onPointerCancel: (PointerCancelEvent -> unit), ?onPointerSignal: (PointerSignalEvent -> unit), ?behavior: HitTestBehavior, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/MouseRegion-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type MouseRegion [<IsConst; NamedParams>] (?key: Key, ?onEnter: (PointerEnterEvent -> unit), ?onExit: (PointerExitEvent -> unit), ?onHover: (PointerHoverEvent -> unit), ?cursor: MouseCursor, ?opaque: bool, ?hitTestBehavior: HitTestBehavior, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/RepaintBoundary-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RepaintBoundary [<IsConst; NamedParams>] (?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()
  static member wrap(child: Widget, childIndex: int): RepaintBoundary = nativeOnly

/// https://api.flutter.dev/flutter/widgets/IgnorePointer-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IgnorePointer [<IsConst; NamedParams>] (?key: Key, ?ignoring: bool, ?ignoringSemantics: bool, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/AbsorbPointer-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AbsorbPointer [<IsConst; NamedParams>] (?key: Key, ?absorbing: bool, ?child: Widget, ?ignoringSemantics: bool) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/MetaData-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type MetaData [<IsConst; NamedParams>] (?key: Key, ?metaData: obj, ?behavior: HitTestBehavior, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Semantics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Semantics [<NamedParams>] (?key: Key, ?child: Widget, ?container: bool, ?explicitChildNodes: bool, ?excludeSemantics: bool, ?enabled: bool, ?``checked``: bool, ?selected: bool, ?toggled: bool, ?button: bool, ?slider: bool, ?keyboardKey: bool, ?link: bool, ?header: bool, ?textField: bool, ?readOnly: bool, ?focusable: bool, ?focused: bool, ?inMutuallyExclusiveGroup: bool, ?obscured: bool, ?multiline: bool, ?scopesRoute: bool, ?namesRoute: bool, ?hidden: bool, ?image: bool, ?liveRegion: bool, ?maxValueLength: int, ?currentValueLength: int, ?label: string, ?attributedLabel: AttributedString, ?value: string, ?attributedValue: AttributedString, ?increasedValue: string, ?attributedIncreasedValue: AttributedString, ?decreasedValue: string, ?attributedDecreasedValue: AttributedString, ?hint: string, ?attributedHint: AttributedString, ?onTapHint: string, ?onLongPressHint: string, ?textDirection: TextDirection, ?sortKey: SemanticsSortKey, ?tagForChildren: SemanticsTag, ?onTap: (unit -> unit), ?onLongPress: (unit -> unit), ?onScrollLeft: (unit -> unit), ?onScrollRight: (unit -> unit), ?onScrollUp: (unit -> unit), ?onScrollDown: (unit -> unit), ?onIncrease: (unit -> unit), ?onDecrease: (unit -> unit), ?onCopy: (unit -> unit), ?onCut: (unit -> unit), ?onPaste: (unit -> unit), ?onDismiss: (unit -> unit), ?onMoveCursorForwardByCharacter: (bool -> unit), ?onMoveCursorBackwardByCharacter: (bool -> unit), ?onSetSelection: (TextSelection -> unit), ?onSetText: (string -> unit), ?onDidGainAccessibilityFocus: (unit -> unit), ?onDidLoseAccessibilityFocus: (unit -> unit), ?customSemanticsActions: Dictionary<CustomSemanticsAction, (unit -> unit)>) =
  inherit SingleChildRenderObjectWidget()
  [<IsConst; NamedParams>] static member fromProperties(properties: SemanticsProperties, ?key: Key, ?child: Widget, ?container: bool, ?explicitChildNodes: bool, ?excludeSemantics: bool): Semantics = nativeOnly

/// https://api.flutter.dev/flutter/widgets/MergeSemantics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type MergeSemantics [<IsConst; NamedParams>] (?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/BlockSemantics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BlockSemantics [<IsConst; NamedParams>] (?key: Key, ?blocking: bool, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ExcludeSemantics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExcludeSemantics [<IsConst; NamedParams>] (?key: Key, ?excluding: bool, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/IndexedSemantics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IndexedSemantics [<IsConst; NamedParams>] (index: int, ?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/KeyedSubtree-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type KeyedSubtree [<IsConst; NamedParams>] (child: Widget, ?key: Key) =
  inherit Widget()
  static member wrap(child: Widget, childIndex: int): KeyedSubtree = nativeOnly

/// https://api.flutter.dev/flutter/widgets/Builder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Builder [<IsConst; NamedParams>] (builder: (BuildContext -> Widget), ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/StatefulBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type StatefulBuilder [<IsConst; NamedParams>] (builder: (BuildContext -> ((unit -> unit) -> unit) -> Widget), ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ColoredBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ColoredBox [<IsConst; NamedParams>] (color: Color, ?child: Widget, ?key: Key) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/WidgetsBindingObserver-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type WidgetsBindingObserver () =
  class end

// /// https://api.flutter.dev/flutter/widgets/RenderObjectToWidgetAdapter-class.html
// [<ImportMember("package:flutter/widgets.dart")>]
// type RenderObjectToWidgetAdapter<'T> [<NamedParams>] (container: RenderObjectWithChildMixin<'T>, ?child: Widget, ?debugShortDescription: string) =
//   inherit RenderObjectWidget()

// /// https://api.flutter.dev/flutter/widgets/RenderObjectToWidgetElement-class.html
// [<ImportMember("package:flutter/widgets.dart")>]
// type RenderObjectToWidgetElement<'T> (widget: RenderObjectToWidgetAdapter<'T>) =
//   inherit RootRenderObjectElement(widget)

/// https://api.flutter.dev/flutter/widgets/WidgetsFlutterBinding-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type WidgetsFlutterBinding () =
  inherit BindingBase()

/// https://api.flutter.dev/flutter/widgets/BottomNavigationBarItem-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BottomNavigationBarItem [<IsConst; NamedParams>] (icon: Widget, ?label: string, ?activeIcon: Widget, ?backgroundColor: Color, ?tooltip: string) =
  class end

/// https://api.flutter.dev/flutter/widgets/ColorFiltered-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ColorFiltered [<IsConst; NamedParams>] (colorFilter: ColorFilter, ?child: Widget, ?key: Key) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/DecoratedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DecoratedBox [<IsConst; NamedParams>] (decoration: Decoration, ?key: Key, ?position: DecorationPosition, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Container-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Container [<NamedParams>] (?key: Key, ?alignment: AlignmentGeometry, ?padding: EdgeInsetsGeometry, ?color: Color, ?decoration: Decoration, ?foregroundDecoration: Decoration, ?width: float, ?height: float, ?constraints: BoxConstraints, ?margin: EdgeInsetsGeometry, ?transform: Matrix4, ?transformAlignment: AlignmentGeometry, ?child: Widget, ?clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/DefaultTextEditingShortcuts-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DefaultTextEditingShortcuts [<NamedParams>] (child: Widget, ?key: Key) =
  inherit Shortcuts(nativeOnly, child)

/// https://api.flutter.dev/flutter/widgets/DesktopTextSelectionToolbarLayoutDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DesktopTextSelectionToolbarLayoutDelegate [<NamedParams>] (anchor: Offset) =
  inherit SingleChildLayoutDelegate()

/// https://api.flutter.dev/flutter/widgets/Dismissible-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Dismissible [<IsConst; NamedParams>] (key: Key, child: Widget, ?background: Widget, ?secondaryBackground: Widget, ?confirmDismiss: (DismissDirection -> Future<bool option>), ?onResize: (unit -> unit), ?onUpdate: (DismissUpdateDetails -> unit), ?onDismissed: (DismissDirection -> unit), ?direction: DismissDirection, ?resizeDuration: TimeSpan, ?dismissThresholds: Dictionary<DismissDirection, float>, ?movementDuration: TimeSpan, ?crossAxisEndOffset: float, ?dragStartBehavior: DragStartBehavior, ?behavior: HitTestBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/DismissUpdateDetails-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DismissUpdateDetails [<NamedParams>] (?direction: DismissDirection, ?reached: bool, ?previousReached: bool, ?progress: float) =
  class end

/// https://api.flutter.dev/flutter/widgets/DisplayFeatureSubScreen-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DisplayFeatureSubScreen [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?anchorPoint: Offset) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/DisposableBuildContext-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DisposableBuildContext<'T> (_state: 'T) =
  class end

/// https://api.flutter.dev/flutter/widgets/Draggable-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Draggable<'T> [<IsConst; NamedParams>] (child: Widget, feedback: Widget, ?key: Key, ?data: 'T, ?axis: Axis, ?childWhenDragging: Widget, ?feedbackOffset: Offset, ?dragAnchor: DragAnchor, ?dragAnchorStrategy: (Draggable<obj> -> BuildContext -> Offset -> Offset), ?affinity: Axis, ?maxSimultaneousDrags: int, ?onDragStarted: (unit -> unit), ?onDragUpdate: (DragUpdateDetails -> unit), ?onDraggableCanceled: (Velocity -> Offset -> unit), ?onDragEnd: (DraggableDetails -> unit), ?onDragCompleted: (unit -> unit), ?ignoringFeedbackSemantics: bool, ?rootOverlay: bool, ?hitTestBehavior: HitTestBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/LongPressDraggable-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LongPressDraggable<'T> [<IsConst; NamedParams>] (child: Widget, feedback: Widget, ?key: Key, ?data: 'T, ?axis: Axis, ?childWhenDragging: Widget, ?feedbackOffset: Offset, ?dragAnchor: DragAnchor, ?dragAnchorStrategy: (Draggable<obj> -> BuildContext -> Offset -> Offset), ?maxSimultaneousDrags: int, ?onDragStarted: (unit -> unit), ?onDragUpdate: (DragUpdateDetails -> unit), ?onDraggableCanceled: (Velocity -> Offset -> unit), ?onDragEnd: (DraggableDetails -> unit), ?onDragCompleted: (unit -> unit), ?hapticFeedbackOnStart: bool, ?ignoringFeedbackSemantics: bool, ?delay: TimeSpan) =
  inherit Draggable<'T>(child, feedback)

/// https://api.flutter.dev/flutter/widgets/DraggableDetails-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DraggableDetails [<NamedParams>] (velocity: Velocity, offset: Offset, ?wasAccepted: bool) =
  class end

/// https://api.flutter.dev/flutter/widgets/DragTargetDetails-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DragTargetDetails<'T> [<NamedParams>] (data: 'T, offset: Offset) =
  class end

/// https://api.flutter.dev/flutter/widgets/DragTarget-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DragTarget<'T> [<IsConst; NamedParams>] (builder: (BuildContext -> 'T option[] -> obj[] -> Widget), ?key: Key, ?onWillAccept: ('T option -> bool), ?onAccept: ('T -> unit), ?onAcceptWithDetails: (DragTargetDetails<'T> -> unit), ?onLeave: ('T option -> unit), ?onMove: (DragTargetDetails<'T> -> unit), ?hitTestBehavior: HitTestBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/DraggableScrollableController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DraggableScrollableController () =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/widgets/DraggableScrollableSheet-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DraggableScrollableSheet [<IsConst; NamedParams>] (builder: (BuildContext -> ScrollController -> Widget), ?key: Key, ?initialChildSize: float, ?minChildSize: float, ?maxChildSize: float, ?expand: bool, ?snap: bool, ?snapSizes: float[], ?controller: DraggableScrollableController) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/DraggableScrollableNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DraggableScrollableNotification [<NamedParams>] (extent: float, minExtent: float, maxExtent: float, initialExtent: float, context: BuildContext) =
  inherit Notification()

/// https://api.flutter.dev/flutter/widgets/DraggableScrollableActuator-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DraggableScrollableActuator [<NamedParams>] (child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/DualTransitionBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DualTransitionBuilder [<IsConst; NamedParams>] (animation: Animation<float>, forwardBuilder: (BuildContext -> Animation<float> -> Widget option -> Widget), reverseBuilder: (BuildContext -> Animation<float> -> Widget option -> Widget), ?key: Key, ?child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/TextEditingController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TextEditingController [<NamedParams>] (?text: string) =
  inherit ValueNotifier<TextEditingValue>(nativeOnly)
  static member fromValue(value: TextEditingValue option): TextEditingController = nativeOnly
  member _.text with get(): string = nativeOnly and set(_: string): unit = nativeOnly
  member _.clear(): unit = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ToolbarOptions-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ToolbarOptions [<IsConst; NamedParams>] (?copy: bool, ?cut: bool, ?paste: bool, ?selectAll: bool) =
  class end

/// https://api.flutter.dev/flutter/widgets/EditableText-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type EditableText [<NamedParams>] (controller: TextEditingController, focusNode: FocusNode, style: TextStyle, cursorColor: Color, backgroundCursorColor: Color, ?key: Key, ?readOnly: bool, ?obscuringCharacter: string, ?obscureText: bool, ?autocorrect: bool, ?smartDashesType: SmartDashesType, ?smartQuotesType: SmartQuotesType, ?enableSuggestions: bool, ?strutStyle: StrutStyle, ?textAlign: TextAlign, ?textDirection: TextDirection, ?locale: Locale, ?textScaleFactor: float, ?maxLines: int, ?minLines: int, ?expands: bool, ?forceLine: bool, ?textHeightBehavior: TextHeightBehavior, ?textWidthBasis: TextWidthBasis, ?autofocus: bool, ?showCursor: bool, ?showSelectionHandles: bool, ?selectionColor: Color, ?selectionControls: TextSelectionControls, ?keyboardType: TextInputType, ?textInputAction: TextInputAction, ?textCapitalization: TextCapitalization, ?onChanged: (string -> unit), ?onEditingComplete: (unit -> unit), ?onSubmitted: (string -> unit), ?onAppPrivateCommand: (string -> Dictionary<string, obj> -> unit), ?onSelectionChanged: (TextSelection -> SelectionChangedCause option -> unit), ?onSelectionHandleTapped: (unit -> unit), ?inputFormatters: TextInputFormatter[], ?mouseCursor: MouseCursor, ?rendererIgnoresPointer: bool, ?cursorWidth: float, ?cursorHeight: float, ?cursorRadius: Radius, ?cursorOpacityAnimates: bool, ?cursorOffset: Offset, ?paintCursorAboveText: bool, ?selectionHeightStyle: BoxHeightStyle, ?selectionWidthStyle: BoxWidthStyle, ?scrollPadding: EdgeInsets, ?keyboardAppearance: Brightness, ?dragStartBehavior: DragStartBehavior, ?enableInteractiveSelection: bool, ?scrollController: ScrollController, ?scrollPhysics: ScrollPhysics, ?autocorrectionTextRectColor: Color, ?toolbarOptions: ToolbarOptions, ?autofillHints: string seq, ?autofillClient: AutofillClient, ?clipBehavior: Clip, ?restorationId: string, ?scrollBehavior: ScrollBehavior, ?scribbleEnabled: bool, ?enableIMEPersonalizedLearning: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/EditableTextState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type EditableTextState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/FadeInImage-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FadeInImage [<IsConst; NamedParams>] (placeholder: ImageProvider<obj>, image: ImageProvider<obj>, ?key: Key, ?placeholderErrorBuilder: (BuildContext -> obj -> StackTrace option -> Widget), ?imageErrorBuilder: (BuildContext -> obj -> StackTrace option -> Widget), ?excludeFromSemantics: bool, ?imageSemanticLabel: string, ?fadeOutDuration: TimeSpan, ?fadeOutCurve: Curve, ?fadeInDuration: TimeSpan, ?fadeInCurve: Curve, ?width: float, ?height: float, ?fit: BoxFit, ?placeholderFit: BoxFit, ?alignment: AlignmentGeometry, ?repeat: ImageRepeat, ?matchTextDirection: bool) =
  inherit Widget()
  [<NamedParams>] static member memoryNetwork(placeholder: byte[], image: string, ?key: Key, ?placeholderErrorBuilder: (BuildContext -> obj -> StackTrace option -> Widget), ?imageErrorBuilder: (BuildContext -> obj -> StackTrace option -> Widget), ?placeholderScale: float, ?imageScale: float, ?excludeFromSemantics: bool, ?imageSemanticLabel: string, ?fadeOutDuration: TimeSpan, ?fadeOutCurve: Curve, ?fadeInDuration: TimeSpan, ?fadeInCurve: Curve, ?width: float, ?height: float, ?fit: BoxFit, ?placeholderFit: BoxFit, ?alignment: AlignmentGeometry, ?repeat: ImageRepeat, ?matchTextDirection: bool, ?placeholderCacheWidth: int, ?placeholderCacheHeight: int, ?imageCacheWidth: int, ?imageCacheHeight: int): FadeInImage = nativeOnly
  [<NamedParams>] static member assetNetwork(placeholder: string, image: string, ?key: Key, ?placeholderErrorBuilder: (BuildContext -> obj -> StackTrace option -> Widget), ?imageErrorBuilder: (BuildContext -> obj -> StackTrace option -> Widget), ?bundle: AssetBundle, ?placeholderScale: float, ?imageScale: float, ?excludeFromSemantics: bool, ?imageSemanticLabel: string, ?fadeOutDuration: TimeSpan, ?fadeOutCurve: Curve, ?fadeInDuration: TimeSpan, ?fadeInCurve: Curve, ?width: float, ?height: float, ?fit: BoxFit, ?placeholderFit: BoxFit, ?alignment: AlignmentGeometry, ?repeat: ImageRepeat, ?matchTextDirection: bool, ?placeholderCacheWidth: int, ?placeholderCacheHeight: int, ?imageCacheWidth: int, ?imageCacheHeight: int): FadeInImage = nativeOnly

/// https://api.flutter.dev/flutter/widgets/FocusAttachment-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusAttachment =
  class end

/// https://api.flutter.dev/flutter/widgets/FocusNode-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusNode [<NamedParams>] (?debugLabel: string, ?onKey: (FocusNode -> RawKeyEvent -> KeyEventResult), ?onKeyEvent: (FocusNode -> KeyEvent -> KeyEventResult), ?skipTraversal: bool, ?canRequestFocus: bool, ?descendantsAreFocusable: bool, ?descendantsAreTraversable: bool) =
  class end

/// https://api.flutter.dev/flutter/widgets/FocusScopeNode-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusScopeNode [<NamedParams>] (?debugLabel: string, ?onKeyEvent: (FocusNode -> KeyEvent -> KeyEventResult), ?onKey: (FocusNode -> RawKeyEvent -> KeyEventResult), ?skipTraversal: bool, ?canRequestFocus: bool) =
  inherit FocusNode()

/// https://api.flutter.dev/flutter/widgets/FocusManager-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusManager () =
  class end

/// https://api.flutter.dev/flutter/widgets/Focus-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Focus [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?focusNode: FocusNode, ?autofocus: bool, ?onFocusChange: (bool -> unit), ?onKeyEvent: (FocusNode -> KeyEvent -> KeyEventResult), ?onKey: (FocusNode -> RawKeyEvent -> KeyEventResult), ?canRequestFocus: bool, ?skipTraversal: bool, ?descendantsAreFocusable: bool, ?descendantsAreTraversable: bool, ?includeSemantics: bool, ?debugLabel: string) =
  inherit Widget()
  [<IsConst; NamedParams>] static member withExternalFocusNode(child: Widget, focusNode: FocusNode, ?key: Key, ?autofocus: bool, ?onFocusChange: (bool -> unit), ?includeSemantics: bool): Focus = nativeOnly

/// https://api.flutter.dev/flutter/widgets/FocusScope-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusScope [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?node: FocusScopeNode, ?autofocus: bool, ?onFocusChange: (bool -> unit), ?canRequestFocus: bool, ?skipTraversal: bool, ?onKeyEvent: (FocusNode -> KeyEvent -> KeyEventResult), ?onKey: (FocusNode -> RawKeyEvent -> KeyEventResult), ?debugLabel: string) =
  inherit Focus(child)
  [<IsConst; NamedParams>] static member withExternalFocusNode(child: Widget, focusScopeNode: FocusScopeNode, ?key: Key, ?autofocus: bool, ?onFocusChange: (bool -> unit)): FocusScope = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ExcludeFocus-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExcludeFocus [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?excluding: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/FocusTraversalPolicy-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type FocusTraversalPolicy [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/WidgetOrderTraversalPolicy-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type WidgetOrderTraversalPolicy () =
  inherit FocusTraversalPolicy()

/// https://api.flutter.dev/flutter/widgets/ReadingOrderTraversalPolicy-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ReadingOrderTraversalPolicy () =
  inherit FocusTraversalPolicy()

/// https://api.flutter.dev/flutter/widgets/FocusOrder-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type FocusOrder [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/NumericFocusOrder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NumericFocusOrder [<IsConst>] (order: float) =
  inherit FocusOrder()

/// https://api.flutter.dev/flutter/widgets/LexicalFocusOrder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LexicalFocusOrder [<IsConst>] (order: string) =
  inherit FocusOrder()

/// https://api.flutter.dev/flutter/widgets/OrderedTraversalPolicy-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OrderedTraversalPolicy [<NamedParams>] (?secondary: FocusTraversalPolicy) =
  inherit FocusTraversalPolicy()

/// https://api.flutter.dev/flutter/widgets/FocusTraversalOrder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusTraversalOrder [<IsConst; NamedParams>] (order: FocusOrder, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/FocusTraversalGroup-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusTraversalGroup [<NamedParams>] (child: Widget, ?key: Key, ?policy: FocusTraversalPolicy, ?descendantsAreFocusable: bool, ?descendantsAreTraversable: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/RequestFocusIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RequestFocusIntent [<IsConst>] (focusNode: FocusNode) =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/RequestFocusAction-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RequestFocusAction () =
  inherit Action<RequestFocusIntent>()

/// https://api.flutter.dev/flutter/widgets/NextFocusIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NextFocusIntent [<IsConst>] () =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/NextFocusAction-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NextFocusAction () =
  inherit Action<NextFocusIntent>()

/// https://api.flutter.dev/flutter/widgets/PreviousFocusIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PreviousFocusIntent [<IsConst>] () =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/PreviousFocusAction-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PreviousFocusAction () =
  inherit Action<PreviousFocusIntent>()

/// https://api.flutter.dev/flutter/widgets/DirectionalFocusIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DirectionalFocusIntent [<IsConst; NamedParams(fromIndex=1)>] (direction: TraversalDirection, ?ignoreTextFields: bool) =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/DirectionalFocusAction-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DirectionalFocusAction () =
  inherit Action<DirectionalFocusIntent>()
  static member forTextField(): DirectionalFocusAction = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ExcludeFocusTraversal-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExcludeFocusTraversal [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?excluding: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Form-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Form [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?onWillPop: (unit -> Future<bool>), ?onChanged: (unit -> unit), ?autovalidateMode: AutovalidateMode) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/FormState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FormState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/FormField-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FormField<'T> [<IsConst; NamedParams>] (builder: (FormFieldState<'T> -> Widget), ?key: Key, ?onSaved: ('T option -> unit), ?validator: ('T option -> string option), ?initialValue: 'T, ?enabled: bool, ?autovalidateMode: AutovalidateMode, ?restorationId: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/FormFieldState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FormFieldState<'T> () =
  interface State

/// https://api.flutter.dev/flutter/widgets/ObjectKey-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ObjectKey [<IsConst>] (value: obj option) =
  inherit LocalKey()

/// https://api.flutter.dev/flutter/widgets/GlobalKey-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type GlobalKey<'T> [<NamedParams>] (?debugLabel: string) =
  inherit Key("")
  [<IsConst>] static member constructor(): GlobalKey<'T> = nativeOnly

/// https://api.flutter.dev/flutter/widgets/LabeledGlobalKey-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LabeledGlobalKey<'T> (_debugLabel: string option) =
  inherit GlobalKey<'T>()

/// https://api.flutter.dev/flutter/widgets/GlobalObjectKey-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type GlobalObjectKey<'T> [<IsConst>] (value: obj) =
  inherit GlobalKey<'T>()

/// https://api.flutter.dev/flutter/widgets/Widget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type Widget [<IsConst; NamedParams>] (?key: Key) =
  inherit DiagnosticableTree()

/// https://api.flutter.dev/flutter/widgets/StatelessWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type StatelessWidget [<IsConst; NamedParams>] (?key: Key) =
  inherit Widget()
  abstract build: BuildContext -> Widget

/// https://api.flutter.dev/flutter/widgets/StatefulWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type StatefulWidget [<IsConst; NamedParams>] (?key: Key) =
  inherit Widget()
  abstract createState: unit -> State

[<ImportMember("package:flutter/widgets.dart")>]
type State =
  interface end

/// https://api.flutter.dev/flutter/widgets/State-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type State<'Widget> () =
  abstract build: BuildContext -> Widget
  member _.setState(f: unit -> unit): unit = nativeOnly
  member _.widget: 'Widget = nativeOnly
  interface State

/// https://api.flutter.dev/flutter/widgets/ProxyWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ProxyWidget [<IsConst; NamedParams>] (child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ParentDataWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ParentDataWidget<'T> [<IsConst; NamedParams>] (child: Widget, ?key: Key) =
  inherit ProxyWidget(child)

/// https://api.flutter.dev/flutter/widgets/InheritedWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type InheritedWidget [<IsConst; NamedParams>] (child: Widget, ?key: Key) =
  inherit ProxyWidget(child)

/// https://api.flutter.dev/flutter/widgets/RenderObjectWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type RenderObjectWidget [<IsConst; NamedParams>] (?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/LeafRenderObjectWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type LeafRenderObjectWidget [<IsConst; NamedParams>] (?key: Key) =
  inherit RenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SingleChildRenderObjectWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type SingleChildRenderObjectWidget [<IsConst; NamedParams>] (?key: Key, ?child: Widget) =
  inherit RenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/MultiChildRenderObjectWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type MultiChildRenderObjectWidget [<NamedParams>] (?key: Key, ?children: Widget[]) =
  inherit RenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/BuildContext-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type BuildContext () =
  class end

/// https://api.flutter.dev/flutter/widgets/BuildOwner-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BuildOwner [<NamedParams>] (?onBuildScheduled: (unit -> unit), ?focusManager: FocusManager) =
  class end

/// https://api.flutter.dev/flutter/widgets/Element-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type Element (widget: Widget) =
  inherit DiagnosticableTree()

/// https://api.flutter.dev/flutter/widgets/ErrorWidget-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ErrorWidget (``exception``: obj) =
  inherit LeafRenderObjectWidget()
  [<NamedParams>] static member withDetails(?message: string, ?error: FlutterError): ErrorWidget = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ComponentElement-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ComponentElement (widget: Widget) =
  inherit Element(widget)

/// https://api.flutter.dev/flutter/widgets/StatelessElement-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type StatelessElement (widget: StatelessWidget) =
  inherit ComponentElement(widget)

/// https://api.flutter.dev/flutter/widgets/StatefulElement-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type StatefulElement (widget: StatefulWidget) =
  inherit ComponentElement(widget)

/// https://api.flutter.dev/flutter/widgets/ProxyElement-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ProxyElement (widget: ProxyWidget) =
  inherit ComponentElement(widget)

/// https://api.flutter.dev/flutter/widgets/ParentDataElement-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ParentDataElement<'T> (widget: ParentDataWidget<'T>) =
  inherit ProxyElement(widget)

/// https://api.flutter.dev/flutter/widgets/InheritedElement-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type InheritedElement (widget: InheritedWidget) =
  inherit ProxyElement(widget)

/// https://api.flutter.dev/flutter/widgets/RenderObjectElement-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type RenderObjectElement (widget: RenderObjectWidget) =
  inherit Element(widget)

/// https://api.flutter.dev/flutter/widgets/RootRenderObjectElement-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type RootRenderObjectElement (widget: RenderObjectWidget) =
  inherit RenderObjectElement(widget)

/// https://api.flutter.dev/flutter/widgets/LeafRenderObjectElement-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LeafRenderObjectElement (widget: LeafRenderObjectWidget) =
  inherit RenderObjectElement(widget)

/// https://api.flutter.dev/flutter/widgets/SingleChildRenderObjectElement-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SingleChildRenderObjectElement (widget: SingleChildRenderObjectWidget) =
  inherit RenderObjectElement(widget)

/// https://api.flutter.dev/flutter/widgets/MultiChildRenderObjectElement-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type MultiChildRenderObjectElement (widget: MultiChildRenderObjectWidget) =
  inherit RenderObjectElement(widget)

/// https://api.flutter.dev/flutter/widgets/DebugCreator-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DebugCreator (element: Element) =
  class end

/// https://api.flutter.dev/flutter/widgets/IndexedSlot-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IndexedSlot<'T> [<IsConst>] (index: int, value: 'T) =
  class end

/// https://api.flutter.dev/flutter/widgets/GestureRecognizerFactory-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type GestureRecognizerFactory<'T> [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/GestureRecognizerFactoryWithHandlers-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type GestureRecognizerFactoryWithHandlers<'T> [<IsConst>] (_constructor: (unit -> 'T), _initializer: ('T -> unit)) =
  inherit GestureRecognizerFactory<'T>()

/// https://api.flutter.dev/flutter/widgets/GestureDetector-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type GestureDetector [<NamedParams>] (?key: Key, ?child: Widget, ?onTapDown: (TapDownDetails -> unit), ?onTapUp: (TapUpDetails -> unit), ?onTap: (unit -> unit), ?onTapCancel: (unit -> unit), ?onSecondaryTap: (unit -> unit), ?onSecondaryTapDown: (TapDownDetails -> unit), ?onSecondaryTapUp: (TapUpDetails -> unit), ?onSecondaryTapCancel: (unit -> unit), ?onTertiaryTapDown: (TapDownDetails -> unit), ?onTertiaryTapUp: (TapUpDetails -> unit), ?onTertiaryTapCancel: (unit -> unit), ?onDoubleTapDown: (TapDownDetails -> unit), ?onDoubleTap: (unit -> unit), ?onDoubleTapCancel: (unit -> unit), ?onLongPressDown: (LongPressDownDetails -> unit), ?onLongPressCancel: (unit -> unit), ?onLongPress: (unit -> unit), ?onLongPressStart: (LongPressStartDetails -> unit), ?onLongPressMoveUpdate: (LongPressMoveUpdateDetails -> unit), ?onLongPressUp: (unit -> unit), ?onLongPressEnd: (LongPressEndDetails -> unit), ?onSecondaryLongPressDown: (LongPressDownDetails -> unit), ?onSecondaryLongPressCancel: (unit -> unit), ?onSecondaryLongPress: (unit -> unit), ?onSecondaryLongPressStart: (LongPressStartDetails -> unit), ?onSecondaryLongPressMoveUpdate: (LongPressMoveUpdateDetails -> unit), ?onSecondaryLongPressUp: (unit -> unit), ?onSecondaryLongPressEnd: (LongPressEndDetails -> unit), ?onTertiaryLongPressDown: (LongPressDownDetails -> unit), ?onTertiaryLongPressCancel: (unit -> unit), ?onTertiaryLongPress: (unit -> unit), ?onTertiaryLongPressStart: (LongPressStartDetails -> unit), ?onTertiaryLongPressMoveUpdate: (LongPressMoveUpdateDetails -> unit), ?onTertiaryLongPressUp: (unit -> unit), ?onTertiaryLongPressEnd: (LongPressEndDetails -> unit), ?onVerticalDragDown: (DragDownDetails -> unit), ?onVerticalDragStart: (DragStartDetails -> unit), ?onVerticalDragUpdate: (DragUpdateDetails -> unit), ?onVerticalDragEnd: (DragEndDetails -> unit), ?onVerticalDragCancel: (unit -> unit), ?onHorizontalDragDown: (DragDownDetails -> unit), ?onHorizontalDragStart: (DragStartDetails -> unit), ?onHorizontalDragUpdate: (DragUpdateDetails -> unit), ?onHorizontalDragEnd: (DragEndDetails -> unit), ?onHorizontalDragCancel: (unit -> unit), ?onForcePressStart: (ForcePressDetails -> unit), ?onForcePressPeak: (ForcePressDetails -> unit), ?onForcePressUpdate: (ForcePressDetails -> unit), ?onForcePressEnd: (ForcePressDetails -> unit), ?onPanDown: (DragDownDetails -> unit), ?onPanStart: (DragStartDetails -> unit), ?onPanUpdate: (DragUpdateDetails -> unit), ?onPanEnd: (DragEndDetails -> unit), ?onPanCancel: (unit -> unit), ?onScaleStart: (ScaleStartDetails -> unit), ?onScaleUpdate: (ScaleUpdateDetails -> unit), ?onScaleEnd: (ScaleEndDetails -> unit), ?behavior: HitTestBehavior, ?excludeFromSemantics: bool, ?dragStartBehavior: DragStartBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/RawGestureDetector-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawGestureDetector [<IsConst; NamedParams>] (?key: Key, ?child: Widget, ?gestures: Dictionary<Type, GestureRecognizerFactory<GestureRecognizer>>, ?behavior: HitTestBehavior, ?excludeFromSemantics: bool, ?semantics: SemanticsGestureDelegate) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/RawGestureDetectorState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawGestureDetectorState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/SemanticsGestureDelegate-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type SemanticsGestureDelegate [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/GridPaper-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type GridPaper [<IsConst; NamedParams>] (?key: Key, ?color: Color, ?interval: float, ?divisions: int, ?subdivisions: int, ?child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Hero-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Hero [<IsConst; NamedParams>] (tag: obj, child: Widget, ?key: Key, ?createRectTween: (Rect option -> Rect option -> Tween<Rect option>), ?flightShuttleBuilder: (BuildContext -> Animation<float> -> HeroFlightDirection -> BuildContext -> BuildContext -> Widget), ?placeholderBuilder: (BuildContext -> Size -> Widget -> Widget), ?transitionOnUserGestures: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/HeroController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type HeroController [<NamedParams>] (?createRectTween: (Rect option -> Rect option -> Tween<Rect option>)) =
  inherit NavigatorObserver()

/// https://api.flutter.dev/flutter/widgets/HeroMode-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type HeroMode [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?enabled: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Icon-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Icon [<IsConst; NamedParams(fromIndex=1)>] (icon: IconData, ?key: Key, ?size: float, ?color: Color, ?semanticLabel: string, ?textDirection: TextDirection, ?shadows: Shadow[]) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/IconData-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IconData [<IsConst; NamedParams(fromIndex=1)>] (codePoint: int, ?fontFamily: string, ?fontPackage: string, ?matchTextDirection: bool) =
  class end

/// https://api.flutter.dev/flutter/widgets/IconDataProperty-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IconDataProperty [<NamedParams(fromIndex=2)>] (name: string, value: IconData option, ?ifNull: string, ?showName: bool, ?style: DiagnosticsTreeStyle, ?level: DiagnosticLevel) =
  inherit DiagnosticsProperty<IconData>(Some name, value)

/// https://api.flutter.dev/flutter/widgets/IconTheme-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IconTheme [<IsConst; NamedParams>] (data: IconThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/widgets/IconThemeData-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IconThemeData [<IsConst; NamedParams>] (?color: Color, ?opacity: float, ?size: float, ?shadows: Shadow[]) =
  [<IsConst>] static member fallback(): IconThemeData = nativeOnly

/// https://api.flutter.dev/flutter/widgets/Image-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Image [<IsConst; NamedParams>] (image: ImageProvider<obj>, ?key: Key, ?frameBuilder: (BuildContext -> Widget -> int option -> bool -> Widget), ?loadingBuilder: (BuildContext -> Widget -> ImageChunkEvent option -> Widget), ?errorBuilder: (BuildContext -> obj -> StackTrace option -> Widget), ?semanticLabel: string, ?excludeFromSemantics: bool, ?width: float, ?height: float, ?color: Color, ?opacity: Animation<float>, ?colorBlendMode: BlendMode, ?fit: BoxFit, ?alignment: AlignmentGeometry, ?repeat: ImageRepeat, ?centerSlice: Rect, ?matchTextDirection: bool, ?gaplessPlayback: bool, ?isAntiAlias: bool, ?filterQuality: FilterQuality) =
  inherit Widget()
  [<NamedParams(fromIndex=1)>] static member network(src: string, ?key: Key, ?scale: float, ?frameBuilder: (BuildContext -> Widget -> int option -> bool -> Widget), ?loadingBuilder: (BuildContext -> Widget -> ImageChunkEvent option -> Widget), ?errorBuilder: (BuildContext -> obj -> StackTrace option -> Widget), ?semanticLabel: string, ?excludeFromSemantics: bool, ?width: float, ?height: float, ?color: Color, ?opacity: Animation<float>, ?colorBlendMode: BlendMode, ?fit: BoxFit, ?alignment: AlignmentGeometry, ?repeat: ImageRepeat, ?centerSlice: Rect, ?matchTextDirection: bool, ?gaplessPlayback: bool, ?filterQuality: FilterQuality, ?isAntiAlias: bool, ?headers: Dictionary<string, string>, ?cacheWidth: int, ?cacheHeight: int): Image = nativeOnly
  // [<NamedParams(fromIndex=1)>] static member file(file: File, ?key: Key, ?scale: float, ?frameBuilder: (BuildContext -> Widget -> int option -> bool -> Widget), ?errorBuilder: (BuildContext -> obj -> StackTrace option -> Widget), ?semanticLabel: string, ?excludeFromSemantics: bool, ?width: float, ?height: float, ?color: Color, ?opacity: Animation<float>, ?colorBlendMode: BlendMode, ?fit: BoxFit, ?alignment: AlignmentGeometry, ?repeat: ImageRepeat, ?centerSlice: Rect, ?matchTextDirection: bool, ?gaplessPlayback: bool, ?isAntiAlias: bool, ?filterQuality: FilterQuality, ?cacheWidth: int, ?cacheHeight: int): Image = nativeOnly
  [<NamedParams(fromIndex=1)>] static member asset(name: string, ?key: Key, ?bundle: AssetBundle, ?frameBuilder: (BuildContext -> Widget -> int option -> bool -> Widget), ?errorBuilder: (BuildContext -> obj -> StackTrace option -> Widget), ?semanticLabel: string, ?excludeFromSemantics: bool, ?scale: float, ?width: float, ?height: float, ?color: Color, ?opacity: Animation<float>, ?colorBlendMode: BlendMode, ?fit: BoxFit, ?alignment: AlignmentGeometry, ?repeat: ImageRepeat, ?centerSlice: Rect, ?matchTextDirection: bool, ?gaplessPlayback: bool, ?isAntiAlias: bool, ?package: string, ?filterQuality: FilterQuality, ?cacheWidth: int, ?cacheHeight: int): Image = nativeOnly
  [<NamedParams(fromIndex=1)>] static member memory(bytes: byte[], ?key: Key, ?scale: float, ?frameBuilder: (BuildContext -> Widget -> int option -> bool -> Widget), ?errorBuilder: (BuildContext -> obj -> StackTrace option -> Widget), ?semanticLabel: string, ?excludeFromSemantics: bool, ?width: float, ?height: float, ?color: Color, ?opacity: Animation<float>, ?colorBlendMode: BlendMode, ?fit: BoxFit, ?alignment: AlignmentGeometry, ?repeat: ImageRepeat, ?centerSlice: Rect, ?matchTextDirection: bool, ?gaplessPlayback: bool, ?isAntiAlias: bool, ?filterQuality: FilterQuality, ?cacheWidth: int, ?cacheHeight: int): Image = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ImageFiltered-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ImageFiltered [<IsConst; NamedParams>] (imageFilter: ImageFilter, ?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ImageIcon-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ImageIcon [<IsConst; NamedParams(fromIndex=1)>] (image: ImageProvider<obj> option, ?key: Key, ?size: float, ?color: Color, ?semanticLabel: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/BoxConstraintsTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BoxConstraintsTween [<NamedParams>] (?``begin``: BoxConstraints, ?``end``: BoxConstraints) =
  inherit Tween<BoxConstraints>()

/// https://api.flutter.dev/flutter/widgets/DecorationTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DecorationTween [<NamedParams>] (?``begin``: Decoration, ?``end``: Decoration) =
  inherit Tween<Decoration>()

/// https://api.flutter.dev/flutter/widgets/EdgeInsetsTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type EdgeInsetsTween [<NamedParams>] (?``begin``: EdgeInsets, ?``end``: EdgeInsets) =
  inherit Tween<EdgeInsets>()

/// https://api.flutter.dev/flutter/widgets/EdgeInsetsGeometryTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type EdgeInsetsGeometryTween [<NamedParams>] (?``begin``: EdgeInsetsGeometry, ?``end``: EdgeInsetsGeometry) =
  inherit Tween<EdgeInsetsGeometry>()

/// https://api.flutter.dev/flutter/widgets/BorderRadiusTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BorderRadiusTween [<NamedParams>] (?``begin``: BorderRadius, ?``end``: BorderRadius) =
  inherit Tween<BorderRadius option>()

/// https://api.flutter.dev/flutter/widgets/BorderTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BorderTween [<NamedParams>] (?``begin``: Border, ?``end``: Border) =
  inherit Tween<Border option>()

/// https://api.flutter.dev/flutter/widgets/Matrix4Tween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Matrix4Tween [<NamedParams>] (?``begin``: Matrix4, ?``end``: Matrix4) =
  inherit Tween<Matrix4>()

/// https://api.flutter.dev/flutter/widgets/TextStyleTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TextStyleTween [<NamedParams>] (?``begin``: TextStyle, ?``end``: TextStyle) =
  inherit Tween<TextStyle>()

/// https://api.flutter.dev/flutter/widgets/ImplicitlyAnimatedWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ImplicitlyAnimatedWidget [<IsConst; NamedParams>] (duration: TimeSpan, ?key: Key, ?curve: Curve, ?onEnd: (unit -> unit)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ImplicitlyAnimatedWidgetState-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ImplicitlyAnimatedWidgetState<'T> () =
  interface State

/// https://api.flutter.dev/flutter/widgets/AnimatedWidgetBaseState-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type AnimatedWidgetBaseState<'T> () =
  inherit ImplicitlyAnimatedWidgetState<'T>()

/// https://api.flutter.dev/flutter/widgets/AnimatedContainer-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedContainer [<NamedParams>] (duration: TimeSpan, ?key: Key, ?alignment: AlignmentGeometry, ?padding: EdgeInsetsGeometry, ?color: Color, ?decoration: Decoration, ?foregroundDecoration: Decoration, ?width: float, ?height: float, ?constraints: BoxConstraints, ?margin: EdgeInsetsGeometry, ?transform: Matrix4, ?transformAlignment: AlignmentGeometry, ?child: Widget, ?clipBehavior: Clip, ?curve: Curve, ?onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedPadding-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedPadding [<NamedParams>] (padding: EdgeInsetsGeometry, duration: TimeSpan, ?key: Key, ?child: Widget, ?curve: Curve, ?onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedAlign-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedAlign [<IsConst; NamedParams>] (alignment: AlignmentGeometry, duration: TimeSpan, ?key: Key, ?child: Widget, ?heightFactor: float, ?widthFactor: float, ?curve: Curve, ?onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedPositioned-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedPositioned [<IsConst; NamedParams>] (child: Widget, duration: TimeSpan, ?key: Key, ?left: float, ?top: float, ?right: float, ?bottom: float, ?width: float, ?height: float, ?curve: Curve, ?onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)
  [<NamedParams>] static member fromRect(child: Widget, rect: Rect, duration: TimeSpan, ?key: Key, ?curve: Curve, ?onEnd: (unit -> unit)): AnimatedPositioned = nativeOnly

/// https://api.flutter.dev/flutter/widgets/AnimatedPositionedDirectional-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedPositionedDirectional [<IsConst; NamedParams>] (child: Widget, duration: TimeSpan, ?key: Key, ?start: float, ?top: float, ?``end``: float, ?bottom: float, ?width: float, ?height: float, ?curve: Curve, ?onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedScale-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedScale [<IsConst; NamedParams>] (scale: float, duration: TimeSpan, ?key: Key, ?child: Widget, ?alignment: Alignment, ?filterQuality: FilterQuality, ?curve: Curve, ?onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedRotation-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedRotation [<IsConst; NamedParams>] (turns: float, duration: TimeSpan, ?key: Key, ?child: Widget, ?alignment: Alignment, ?filterQuality: FilterQuality, ?curve: Curve, ?onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedSlide-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedSlide [<IsConst; NamedParams>] (offset: Offset, duration: TimeSpan, ?key: Key, ?child: Widget, ?curve: Curve, ?onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedOpacity-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedOpacity [<IsConst; NamedParams>] (opacity: float, duration: TimeSpan, ?key: Key, ?child: Widget, ?curve: Curve, ?onEnd: (unit -> unit), ?alwaysIncludeSemantics: bool) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/SliverAnimatedOpacity-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverAnimatedOpacity [<IsConst; NamedParams>] (opacity: float, duration: TimeSpan, ?key: Key, ?sliver: Widget, ?curve: Curve, ?onEnd: (unit -> unit), ?alwaysIncludeSemantics: bool) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedDefaultTextStyle-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedDefaultTextStyle [<IsConst; NamedParams>] (child: Widget, style: TextStyle, duration: TimeSpan, ?key: Key, ?textAlign: TextAlign, ?softWrap: bool, ?overflow: TextOverflow, ?maxLines: int, ?textWidthBasis: TextWidthBasis, ?textHeightBehavior: TextHeightBehavior, ?curve: Curve, ?onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedPhysicalModel-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedPhysicalModel [<IsConst; NamedParams>] (child: Widget, shape: BoxShape, elevation: float, color: Color, shadowColor: Color, duration: TimeSpan, ?key: Key, ?clipBehavior: Clip, ?borderRadius: BorderRadius, ?animateColor: bool, ?animateShadowColor: bool, ?curve: Curve, ?onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/InheritedModel-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type InheritedModel<'T> [<IsConst; NamedParams>] (child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/InheritedModelElement-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type InheritedModelElement<'T> (widget: InheritedModel<'T>) =
  inherit InheritedElement(widget)

/// https://api.flutter.dev/flutter/widgets/InheritedNotifier-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type InheritedNotifier<'T> [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?notifier: 'T) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/InheritedTheme-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type InheritedTheme [<IsConst; NamedParams>] (child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/CapturedThemes-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CapturedThemes =
  class end

/// https://api.flutter.dev/flutter/widgets/InteractiveViewer-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type InteractiveViewer [<NamedParams>] (child: Widget, ?key: Key, ?clipBehavior: Clip, ?alignPanAxis: bool, ?boundaryMargin: EdgeInsets, ?constrained: bool, ?maxScale: float, ?minScale: float, ?onInteractionEnd: (ScaleEndDetails -> unit), ?onInteractionStart: (ScaleStartDetails -> unit), ?onInteractionUpdate: (ScaleUpdateDetails -> unit), ?panEnabled: bool, ?scaleEnabled: bool, ?scaleFactor: float, ?transformationController: TransformationController) =
  inherit Widget()
  [<NamedParams>] static member builder(builder: (BuildContext -> Quad -> Widget), ?key: Key, ?clipBehavior: Clip, ?alignPanAxis: bool, ?boundaryMargin: EdgeInsets, ?maxScale: float, ?minScale: float, ?onInteractionEnd: (ScaleEndDetails -> unit), ?onInteractionStart: (ScaleStartDetails -> unit), ?onInteractionUpdate: (ScaleUpdateDetails -> unit), ?panEnabled: bool, ?scaleEnabled: bool, ?scaleFactor: float, ?transformationController: TransformationController): InteractiveViewer = nativeOnly

/// https://api.flutter.dev/flutter/widgets/TransformationController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TransformationController (?value: Matrix4) =
  inherit ValueNotifier<Matrix4>(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/KeyboardListener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type KeyboardListener [<IsConst; NamedParams>] (focusNode: FocusNode, child: Widget, ?key: Key, ?autofocus: bool, ?includeSemantics: bool, ?onKeyEvent: (KeyEvent -> unit)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ConstrainedLayoutBuilder-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ConstrainedLayoutBuilder<'ConstraintType> [<IsConst; NamedParams>] (builder: (BuildContext -> 'ConstraintType -> Widget), ?key: Key) =
  inherit RenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/LayoutBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LayoutBuilder [<IsConst; NamedParams>] (builder: (BuildContext -> BoxConstraints -> Widget), ?key: Key) =
  inherit ConstrainedLayoutBuilder<BoxConstraints>(builder)

/// https://api.flutter.dev/flutter/widgets/ListWheelChildDelegate-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ListWheelChildDelegate () =
  class end

/// https://api.flutter.dev/flutter/widgets/ListWheelChildListDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ListWheelChildListDelegate [<NamedParams>] (children: Widget[]) =
  inherit ListWheelChildDelegate()

/// https://api.flutter.dev/flutter/widgets/ListWheelChildLoopingListDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ListWheelChildLoopingListDelegate [<NamedParams>] (children: Widget[]) =
  inherit ListWheelChildDelegate()

/// https://api.flutter.dev/flutter/widgets/ListWheelChildBuilderDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ListWheelChildBuilderDelegate [<NamedParams>] (builder: (BuildContext -> int -> Widget option), ?childCount: int) =
  inherit ListWheelChildDelegate()

/// https://api.flutter.dev/flutter/widgets/FixedExtentScrollController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FixedExtentScrollController [<NamedParams>] (?initialItem: int) =
  inherit ScrollController()

/// https://api.flutter.dev/flutter/widgets/FixedExtentMetrics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FixedExtentMetrics [<NamedParams>] (minScrollExtent: float option, maxScrollExtent: float option, pixels: float option, viewportDimension: float option, axisDirection: AxisDirection, itemIndex: int) =
  inherit FixedScrollMetrics(minScrollExtent, maxScrollExtent, pixels, viewportDimension, axisDirection)

/// https://api.flutter.dev/flutter/widgets/FixedExtentScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FixedExtentScrollPhysics [<IsConst; NamedParams>] (?parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/ListWheelScrollView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ListWheelScrollView [<NamedParams>] (itemExtent: float, children: Widget[], ?key: Key, ?controller: ScrollController, ?physics: ScrollPhysics, ?diameterRatio: float, ?perspective: float, ?offAxisFraction: float, ?useMagnifier: bool, ?magnification: float, ?overAndUnderCenterOpacity: float, ?squeeze: float, ?onSelectedItemChanged: (int -> unit), ?renderChildrenOutsideViewport: bool, ?clipBehavior: Clip, ?restorationId: string, ?scrollBehavior: ScrollBehavior) =
  inherit Widget()
  [<IsConst; NamedParams>] static member useDelegate(itemExtent: float, childDelegate: ListWheelChildDelegate, ?key: Key, ?controller: ScrollController, ?physics: ScrollPhysics, ?diameterRatio: float, ?perspective: float, ?offAxisFraction: float, ?useMagnifier: bool, ?magnification: float, ?overAndUnderCenterOpacity: float, ?squeeze: float, ?onSelectedItemChanged: (int -> unit), ?renderChildrenOutsideViewport: bool, ?clipBehavior: Clip, ?restorationId: string, ?scrollBehavior: ScrollBehavior): ListWheelScrollView = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ListWheelElement-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ListWheelElement (widget: ListWheelViewport) =
  inherit RenderObjectElement(widget)

/// https://api.flutter.dev/flutter/widgets/ListWheelViewport-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ListWheelViewport [<IsConst; NamedParams>] (itemExtent: float, offset: ViewportOffset, childDelegate: ListWheelChildDelegate, ?key: Key, ?diameterRatio: float, ?perspective: float, ?offAxisFraction: float, ?useMagnifier: bool, ?magnification: float, ?overAndUnderCenterOpacity: float, ?squeeze: float, ?renderChildrenOutsideViewport: bool, ?clipBehavior: Clip) =
  inherit RenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/LocalizationsDelegate-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type LocalizationsDelegate<'T> [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/WidgetsLocalizations-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type WidgetsLocalizations () =
  class end

/// https://api.flutter.dev/flutter/widgets/DefaultWidgetsLocalizations-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DefaultWidgetsLocalizations [<IsConst>] () =
  [<IsConst>] static member ``delegate``: LocalizationsDelegate<WidgetsLocalizations> = nativeOnly

/// https://api.flutter.dev/flutter/widgets/Localizations-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Localizations [<NamedParams>] (locale: Locale, delegates: LocalizationsDelegate<obj>[], ?key: Key, ?child: Widget) =
  inherit Widget()
  [<NamedParams>] static member ``override``(context: BuildContext, ?key: Key, ?locale: Locale, ?delegates: LocalizationsDelegate<obj>[], ?child: Widget): Localizations = nativeOnly

/// https://api.flutter.dev/flutter/widgets/MediaQueryData-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type MediaQueryData [<IsConst; NamedParams>] (?size: Size, ?devicePixelRatio: float, ?textScaleFactor: float, ?platformBrightness: Brightness, ?padding: EdgeInsets, ?viewInsets: EdgeInsets, ?systemGestureInsets: EdgeInsets, ?viewPadding: EdgeInsets, ?alwaysUse24HourFormat: bool, ?accessibleNavigation: bool, ?invertColors: bool, ?highContrast: bool, ?disableAnimations: bool, ?boldText: bool, ?navigationMode: NavigationMode, ?gestureSettings: DeviceGestureSettings, ?displayFeatures: DisplayFeature[]) =
  static member fromWindow(window: FlutterView): MediaQueryData = nativeOnly

/// https://api.flutter.dev/flutter/widgets/MediaQuery-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type MediaQuery [<IsConst; NamedParams>] (data: MediaQueryData, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)
  [<NamedParams>] static member removePadding(context: BuildContext, child: Widget, ?key: Key, ?removeLeft: bool, ?removeTop: bool, ?removeRight: bool, ?removeBottom: bool): MediaQuery = nativeOnly
  [<NamedParams>] static member removeViewInsets(context: BuildContext, child: Widget, ?key: Key, ?removeLeft: bool, ?removeTop: bool, ?removeRight: bool, ?removeBottom: bool): MediaQuery = nativeOnly
  [<NamedParams>] static member removeViewPadding(context: BuildContext, child: Widget, ?key: Key, ?removeLeft: bool, ?removeTop: bool, ?removeRight: bool, ?removeBottom: bool): MediaQuery = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ModalBarrier-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ModalBarrier [<IsConst; NamedParams>] (?key: Key, ?color: Color, ?dismissible: bool, ?onDismiss: (unit -> unit), ?semanticsLabel: string, ?barrierSemanticsDismissible: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AnimatedModalBarrier-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedModalBarrier [<IsConst; NamedParams>] (color: Animation<Color option>, ?key: Key, ?dismissible: bool, ?semanticsLabel: string, ?barrierSemanticsDismissible: bool) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/NavigationToolbar-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NavigationToolbar [<IsConst; NamedParams>] (?key: Key, ?leading: Widget, ?middle: Widget, ?trailing: Widget, ?centerMiddle: bool, ?middleSpacing: float) =
  inherit Widget()
  [<IsConst>] static member kMiddleSpacing: float = nativeOnly

/// https://api.flutter.dev/flutter/widgets/Route-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type Route<'T> [<NamedParams>] (?settings: RouteSettings) =
  class end

/// https://api.flutter.dev/flutter/widgets/RouteSettings-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RouteSettings [<IsConst; NamedParams>] (?name: string, ?arguments: obj) =
  class end

/// https://api.flutter.dev/flutter/widgets/Page-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type Page<'T> [<IsConst; NamedParams>] (?key: LocalKey, ?name: string, ?arguments: obj, ?restorationId: string) =
  inherit RouteSettings()

/// https://api.flutter.dev/flutter/widgets/NavigatorObserver-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NavigatorObserver () =
  class end

/// https://api.flutter.dev/flutter/widgets/HeroControllerScope-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type HeroControllerScope [<IsConst; NamedParams>] (controller: HeroController, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)
  [<IsConst; NamedParams>] static member none(child: Widget, ?key: Key): HeroControllerScope = nativeOnly

/// https://api.flutter.dev/flutter/widgets/RouteTransitionRecord-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type RouteTransitionRecord () =
  class end

/// https://api.flutter.dev/flutter/widgets/TransitionDelegate-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type TransitionDelegate<'T> [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/DefaultTransitionDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DefaultTransitionDelegate<'T> [<IsConst>] () =
  inherit TransitionDelegate<'T>()

/// https://api.flutter.dev/flutter/widgets/Navigator-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Navigator [<IsConst; NamedParams>] (?key: Key, ?pages: Page<obj>[], ?onPopPage: (Route<obj> -> obj -> bool), ?initialRoute: string, ?onGenerateInitialRoutes: (NavigatorState -> string -> Route<obj>[]), ?onGenerateRoute: (RouteSettings -> Route<obj> option), ?onUnknownRoute: (RouteSettings -> Route<obj> option), ?transitionDelegate: TransitionDelegate<obj>, ?reportsRouteUpdateToEngine: bool, ?observers: NavigatorObserver[], ?requestFocus: bool, ?restorationScopeId: string) =
  inherit Widget()
  [<IsConst>] static member defaultRouteName: string = nativeOnly
  member _.pop(): unit = nativeOnly
  static member ``of``(context: BuildContext): Navigator = nativeOnly

/// https://api.flutter.dev/flutter/widgets/NavigatorState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NavigatorState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/RestorableRouteFuture-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableRouteFuture<'T> [<NamedParams>] (onPresent: (NavigatorState -> obj option -> string), ?navigatorFinder: (BuildContext -> NavigatorState), ?onComplete: ('T -> unit)) =
  inherit RestorableProperty<string option>()

/// https://api.flutter.dev/flutter/widgets/NestedScrollView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NestedScrollView [<IsConst; NamedParams>] (headerSliverBuilder: (BuildContext -> bool -> Widget[]), body: Widget, ?key: Key, ?controller: ScrollController, ?scrollDirection: Axis, ?reverse: bool, ?physics: ScrollPhysics, ?dragStartBehavior: DragStartBehavior, ?floatHeaderSlivers: bool, ?clipBehavior: Clip, ?restorationId: string, ?scrollBehavior: ScrollBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/NestedScrollViewState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NestedScrollViewState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/SliverOverlapAbsorberHandle-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverOverlapAbsorberHandle () =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/widgets/SliverOverlapAbsorber-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverOverlapAbsorber [<IsConst; NamedParams>] (handle: SliverOverlapAbsorberHandle, ?key: Key, ?sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/RenderSliverOverlapAbsorber-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RenderSliverOverlapAbsorber [<NamedParams>] (handle: SliverOverlapAbsorberHandle, ?sliver: RenderSliver) =
  inherit RenderSliver()

/// https://api.flutter.dev/flutter/widgets/SliverOverlapInjector-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverOverlapInjector [<IsConst; NamedParams>] (handle: SliverOverlapAbsorberHandle, ?key: Key, ?sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/RenderSliverOverlapInjector-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RenderSliverOverlapInjector [<NamedParams>] (handle: SliverOverlapAbsorberHandle) =
  inherit RenderSliver()

/// https://api.flutter.dev/flutter/widgets/NestedScrollViewViewport-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NestedScrollViewViewport [<NamedParams>] (offset: ViewportOffset, handle: SliverOverlapAbsorberHandle, ?key: Key, ?axisDirection: AxisDirection, ?crossAxisDirection: AxisDirection, ?anchor: float, ?center: Key, ?slivers: Widget[], ?clipBehavior: Clip) =
  inherit Viewport(offset)

/// https://api.flutter.dev/flutter/widgets/RenderNestedScrollViewViewport-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RenderNestedScrollViewViewport [<NamedParams>] (crossAxisDirection: AxisDirection, offset: ViewportOffset, handle: SliverOverlapAbsorberHandle, ?axisDirection: AxisDirection, ?anchor: float, ?children: RenderSliver[], ?center: RenderSliver, ?clipBehavior: Clip) =
  inherit RenderViewport(crossAxisDirection, offset)

/// https://api.flutter.dev/flutter/widgets/Notification-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type Notification [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/NotificationListener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NotificationListener<'T> [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?onNotification: ('T -> bool)) =
  inherit ProxyWidget(child)

/// https://api.flutter.dev/flutter/widgets/LayoutChangedNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LayoutChangedNotification [<IsConst>] () =
  inherit Notification()

/// https://api.flutter.dev/flutter/widgets/OrientationBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OrientationBuilder [<IsConst; NamedParams>] (builder: (BuildContext -> Orientation -> Widget), ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/OverflowBar-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OverflowBar [<NamedParams>] (?key: Key, ?spacing: float, ?alignment: MainAxisAlignment, ?overflowSpacing: float, ?overflowAlignment: OverflowBarAlignment, ?overflowDirection: VerticalDirection, ?textDirection: TextDirection, ?clipBehavior: Clip, ?children: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/OverlayEntry-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OverlayEntry [<NamedParams>] (builder: (BuildContext -> Widget), ?opaque: bool, ?maintainState: bool) =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/widgets/Overlay-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Overlay [<IsConst; NamedParams>] (?key: Key, ?initialEntries: OverlayEntry[], ?clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/OverlayState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OverlayState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/GlowingOverscrollIndicator-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type GlowingOverscrollIndicator [<IsConst; NamedParams>] (axisDirection: AxisDirection, color: Color, ?key: Key, ?showLeading: bool, ?showTrailing: bool, ?notificationPredicate: (ScrollNotification -> bool), ?child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/StretchingOverscrollIndicator-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type StretchingOverscrollIndicator [<IsConst; NamedParams>] (axisDirection: AxisDirection, ?key: Key, ?notificationPredicate: (ScrollNotification -> bool), ?child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/OverscrollIndicatorNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OverscrollIndicatorNotification [<NamedParams>] (leading: bool) =
  inherit Notification()

/// https://api.flutter.dev/flutter/widgets/PageStorageKey-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PageStorageKey<'T> [<IsConst>] (value: 'T) =
  inherit ValueKey<'T>(value)

/// https://api.flutter.dev/flutter/widgets/PageStorageBucket-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PageStorageBucket () =
  class end

/// https://api.flutter.dev/flutter/widgets/PageStorage-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PageStorage [<IsConst; NamedParams>] (bucket: PageStorageBucket, child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/PageController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PageController [<NamedParams>] (?initialPage: int, ?keepPage: bool, ?viewportFraction: float) =
  inherit ScrollController()

/// https://api.flutter.dev/flutter/widgets/PageMetrics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PageMetrics [<NamedParams>] (minScrollExtent: float option, maxScrollExtent: float option, pixels: float option, viewportDimension: float option, axisDirection: AxisDirection, viewportFraction: float) =
  inherit FixedScrollMetrics(minScrollExtent, maxScrollExtent, pixels, viewportDimension, axisDirection)

/// https://api.flutter.dev/flutter/widgets/PageScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PageScrollPhysics [<IsConst; NamedParams>] (?parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/PageView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PageView [<NamedParams>] (?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: PageController, ?physics: ScrollPhysics, ?pageSnapping: bool, ?onPageChanged: (int -> unit), ?children: Widget[], ?dragStartBehavior: DragStartBehavior, ?allowImplicitScrolling: bool, ?restorationId: string, ?clipBehavior: Clip, ?scrollBehavior: ScrollBehavior, ?padEnds: bool) =
  inherit Widget()
  [<NamedParams>] static member builder(itemBuilder: (BuildContext -> int -> Widget), ?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: PageController, ?physics: ScrollPhysics, ?pageSnapping: bool, ?onPageChanged: (int -> unit), ?findChildIndexCallback: (Key -> int option), ?itemCount: int, ?dragStartBehavior: DragStartBehavior, ?allowImplicitScrolling: bool, ?restorationId: string, ?clipBehavior: Clip, ?scrollBehavior: ScrollBehavior, ?padEnds: bool): PageView = nativeOnly
  [<NamedParams>] static member custom(childrenDelegate: SliverChildDelegate, ?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: PageController, ?physics: ScrollPhysics, ?pageSnapping: bool, ?onPageChanged: (int -> unit), ?dragStartBehavior: DragStartBehavior, ?allowImplicitScrolling: bool, ?restorationId: string, ?clipBehavior: Clip, ?scrollBehavior: ScrollBehavior, ?padEnds: bool): PageView = nativeOnly

/// https://api.flutter.dev/flutter/widgets/PageRoute-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type PageRoute<'T> [<NamedParams>] (?settings: RouteSettings, ?fullscreenDialog: bool) =
  inherit ModalRoute<'T>()

/// https://api.flutter.dev/flutter/widgets/PageRouteBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PageRouteBuilder<'T> [<NamedParams>] (pageBuilder: (BuildContext -> Animation<float> -> Animation<float> -> Widget), ?settings: RouteSettings, ?transitionsBuilder: (BuildContext -> Animation<float> -> Animation<float> -> Widget -> Widget), ?transitionDuration: TimeSpan, ?reverseTransitionDuration: TimeSpan, ?opaque: bool, ?barrierDismissible: bool, ?barrierColor: Color, ?barrierLabel: string, ?maintainState: bool, ?fullscreenDialog: bool) =
  inherit PageRoute<'T>()

/// https://api.flutter.dev/flutter/widgets/PerformanceOverlay-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PerformanceOverlay [<IsConst; NamedParams>] (?key: Key, ?optionsMask: int, ?rasterizerThreshold: int, ?checkerboardRasterCacheImages: bool, ?checkerboardOffscreenLayers: bool) =
  inherit LeafRenderObjectWidget()
  [<NamedParams>] static member allEnabled(?key: Key, ?rasterizerThreshold: int, ?checkerboardRasterCacheImages: bool, ?checkerboardOffscreenLayers: bool): PerformanceOverlay = nativeOnly

/// https://api.flutter.dev/flutter/widgets/Placeholder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Placeholder [<IsConst; NamedParams>] (?key: Key, ?color: Color, ?strokeWidth: float, ?fallbackWidth: float, ?fallbackHeight: float, ?child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ShortcutSerialization-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ShortcutSerialization =
  static member character(character: string): ShortcutSerialization = nativeOnly
  [<NamedParams(fromIndex=1)>] static member modifier(trigger: LogicalKeyboardKey, ?control: bool, ?shift: bool, ?alt: bool, ?meta: bool): ShortcutSerialization = nativeOnly

/// https://api.flutter.dev/flutter/widgets/MenuItem-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type MenuItem [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/PlatformMenuDelegate-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type PlatformMenuDelegate [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/DefaultPlatformMenuDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DefaultPlatformMenuDelegate [<NamedParams>] (?channel: MethodChannel) =
  inherit PlatformMenuDelegate()

/// https://api.flutter.dev/flutter/widgets/PlatformMenuBar-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformMenuBar [<IsConst; NamedParams>] (body: Widget, menus: MenuItem[], ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/PlatformMenu-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformMenu [<IsConst; NamedParams>] (label: string, menus: MenuItem[], ?onOpen: (unit -> unit), ?onClose: (unit -> unit)) =
  inherit MenuItem()

/// https://api.flutter.dev/flutter/widgets/PlatformMenuItemGroup-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformMenuItemGroup [<IsConst; NamedParams>] (members: MenuItem[]) =
  inherit MenuItem()

/// https://api.flutter.dev/flutter/widgets/PlatformMenuItem-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformMenuItem [<IsConst; NamedParams>] (label: string, ?shortcut: MenuSerializableShortcut, ?onSelected: (unit -> unit)) =
  inherit MenuItem()

/// https://api.flutter.dev/flutter/widgets/PlatformProvidedMenuItem-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformProvidedMenuItem [<IsConst; NamedParams>] (``type``: PlatformProvidedMenuItemType, ?enabled: bool) =
  inherit PlatformMenuItem(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/AndroidView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AndroidView [<IsConst; NamedParams>] (viewType: string, ?key: Key, ?onPlatformViewCreated: (int -> unit), ?hitTestBehavior: PlatformViewHitTestBehavior, ?layoutDirection: TextDirection, ?gestureRecognizers: HashSet<Factory<OneSequenceGestureRecognizer>>, ?creationParams: obj, ?creationParamsCodec: MessageCodec<obj>, ?clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/UiKitView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type UiKitView [<IsConst; NamedParams>] (viewType: string, ?key: Key, ?onPlatformViewCreated: (int -> unit), ?hitTestBehavior: PlatformViewHitTestBehavior, ?layoutDirection: TextDirection, ?creationParams: obj, ?creationParamsCodec: MessageCodec<obj>, ?gestureRecognizers: HashSet<Factory<OneSequenceGestureRecognizer>>) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/HtmlElementView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type HtmlElementView [<IsConst; NamedParams>] (viewType: string, ?key: Key, ?onPlatformViewCreated: (int -> unit)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/PlatformViewCreationParams-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformViewCreationParams =
  class end

/// https://api.flutter.dev/flutter/widgets/PlatformViewLink-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformViewLink [<IsConst; NamedParams>] (surfaceFactory: (BuildContext -> PlatformViewController -> Widget), onCreatePlatformView: (PlatformViewCreationParams -> PlatformViewController), viewType: string, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/PlatformViewSurface-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformViewSurface [<IsConst; NamedParams>] (controller: PlatformViewController, hitTestBehavior: PlatformViewHitTestBehavior, gestureRecognizers: HashSet<Factory<OneSequenceGestureRecognizer>>, ?key: Key) =
  inherit LeafRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/AndroidViewSurface-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AndroidViewSurface [<IsConst; NamedParams>] (controller: AndroidViewController, hitTestBehavior: PlatformViewHitTestBehavior, gestureRecognizers: HashSet<Factory<OneSequenceGestureRecognizer>>, ?key: Key) =
  inherit PlatformViewSurface(nativeOnly, hitTestBehavior, gestureRecognizers)

/// https://api.flutter.dev/flutter/widgets/PreferredSizeWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type PreferredSizeWidget () =
  class end

/// https://api.flutter.dev/flutter/widgets/PreferredSize-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PreferredSize [<IsConst; NamedParams>] (child: Widget, preferredSize: Size, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/PrimaryScrollController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PrimaryScrollController [<IsConst; NamedParams>] (controller: ScrollController, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)
  [<IsConst; NamedParams>] static member none(child: Widget, ?key: Key): PrimaryScrollController = nativeOnly

/// https://api.flutter.dev/flutter/widgets/RawKeyboardListener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawKeyboardListener [<IsConst; NamedParams>] (focusNode: FocusNode, child: Widget, ?key: Key, ?autofocus: bool, ?includeSemantics: bool, ?onKey: (RawKeyEvent -> unit)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ReorderableList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ReorderableList [<IsConst; NamedParams>] (itemBuilder: (BuildContext -> int -> Widget), itemCount: int, onReorder: (int -> int -> unit), ?key: Key, ?onReorderStart: (int -> unit), ?onReorderEnd: (int -> unit), ?itemExtent: float, ?prototypeItem: Widget, ?proxyDecorator: (Widget -> int -> Animation<float> -> Widget), ?padding: EdgeInsetsGeometry, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?anchor: float, ?cacheExtent: float, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ReorderableListState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ReorderableListState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/SliverReorderableList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverReorderableList [<IsConst; NamedParams>] (itemBuilder: (BuildContext -> int -> Widget), itemCount: int, onReorder: (int -> int -> unit), ?key: Key, ?findChildIndexCallback: (Key -> int option), ?onReorderStart: (int -> unit), ?onReorderEnd: (int -> unit), ?itemExtent: float, ?prototypeItem: Widget, ?proxyDecorator: (Widget -> int -> Animation<float> -> Widget)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverReorderableListState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverReorderableListState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/ReorderableDragStartListener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ReorderableDragStartListener [<IsConst; NamedParams>] (child: Widget, index: int, ?key: Key, ?enabled: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ReorderableDelayedDragStartListener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ReorderableDelayedDragStartListener [<IsConst; NamedParams>] (child: Widget, index: int, ?key: Key, ?enabled: bool) =
  inherit ReorderableDragStartListener(child, index)

/// https://api.flutter.dev/flutter/widgets/RestorationScope-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorationScope [<IsConst; NamedParams>] (restorationId: string option, child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/UnmanagedRestorationScope-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type UnmanagedRestorationScope [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?bucket: RestorationBucket) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/RootRestorationScope-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RootRestorationScope [<IsConst; NamedParams>] (restorationId: string option, child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/RestorableProperty-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type RestorableProperty<'T> () =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/widgets/RestorableValue-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type RestorableValue<'T> () =
  inherit RestorableProperty<'T>()

/// https://api.flutter.dev/flutter/widgets/RestorableNum-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableNum<'T> (defaultValue: 'T) =
  class end

/// https://api.flutter.dev/flutter/widgets/RestorableDouble-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableDouble (defaultValue: float) =
  inherit RestorableNum<float>(defaultValue)

/// https://api.flutter.dev/flutter/widgets/RestorableInt-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableInt (defaultValue: int) =
  inherit RestorableNum<int>(defaultValue)

/// https://api.flutter.dev/flutter/widgets/RestorableString-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableString (defaultValue: string) =
  class end

/// https://api.flutter.dev/flutter/widgets/RestorableBool-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableBool (defaultValue: bool) =
  class end

/// https://api.flutter.dev/flutter/widgets/RestorableBoolN-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableBoolN (defaultValue: bool option) =
  class end

/// https://api.flutter.dev/flutter/widgets/RestorableNumN-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableNumN<'T> (defaultValue: 'T) =
  class end

/// https://api.flutter.dev/flutter/widgets/RestorableDoubleN-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableDoubleN (defaultValue: float option) =
  inherit RestorableNumN<float option>(defaultValue)

/// https://api.flutter.dev/flutter/widgets/RestorableIntN-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableIntN (defaultValue: int option) =
  inherit RestorableNumN<int option>(defaultValue)

/// https://api.flutter.dev/flutter/widgets/RestorableStringN-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableStringN (defaultValue: string option) =
  class end

/// https://api.flutter.dev/flutter/widgets/RestorableDateTime-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableDateTime (defaultValue: DateTime) =
  inherit RestorableValue<DateTime>()

/// https://api.flutter.dev/flutter/widgets/RestorableDateTimeN-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableDateTimeN (defaultValue: DateTime option) =
  inherit RestorableValue<DateTime option>()

/// https://api.flutter.dev/flutter/widgets/RestorableListenable-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type RestorableListenable<'T> () =
  inherit RestorableProperty<'T>()

/// https://api.flutter.dev/flutter/widgets/RestorableChangeNotifier-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type RestorableChangeNotifier<'T> () =
  inherit RestorableListenable<'T>()

/// https://api.flutter.dev/flutter/widgets/RestorableTextEditingController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableTextEditingController [<NamedParams>] (?text: string) =
  inherit RestorableChangeNotifier<TextEditingController>()
  static member fromValue(value: TextEditingValue): RestorableTextEditingController = nativeOnly

/// https://api.flutter.dev/flutter/widgets/RouteInformation-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RouteInformation [<IsConst; NamedParams>] (?location: string, ?state: obj) =
  class end

/// https://api.flutter.dev/flutter/widgets/Router-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Router<'T> [<IsConst; NamedParams>] (routerDelegate: RouterDelegate<'T>, ?key: Key, ?routeInformationProvider: RouteInformationProvider, ?routeInformationParser: RouteInformationParser<'T>, ?backButtonDispatcher: BackButtonDispatcher, ?restorationScopeId: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/BackButtonDispatcher-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type BackButtonDispatcher () =
  class end

/// https://api.flutter.dev/flutter/widgets/RootBackButtonDispatcher-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RootBackButtonDispatcher () =
  inherit BackButtonDispatcher()

/// https://api.flutter.dev/flutter/widgets/ChildBackButtonDispatcher-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ChildBackButtonDispatcher (parent: BackButtonDispatcher) =
  inherit BackButtonDispatcher()

/// https://api.flutter.dev/flutter/widgets/BackButtonListener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BackButtonListener [<IsConst; NamedParams>] (child: Widget, onBackButtonPressed: (unit -> Future<bool>), ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/RouteInformationParser-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type RouteInformationParser<'T> [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/RouterDelegate-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type RouterDelegate<'T> () =
  inherit Listenable()

/// https://api.flutter.dev/flutter/widgets/RouteInformationProvider-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type RouteInformationProvider () =
  inherit ValueListenable<RouteInformation>()

/// https://api.flutter.dev/flutter/widgets/PlatformRouteInformationProvider-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformRouteInformationProvider [<NamedParams>] (initialRouteInformation: RouteInformation) =
  inherit RouteInformationProvider()

/// https://api.flutter.dev/flutter/widgets/OverlayRoute-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type OverlayRoute<'T> [<NamedParams>] (?settings: RouteSettings) =
  inherit Route<'T>()

/// https://api.flutter.dev/flutter/widgets/TransitionRoute-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type TransitionRoute<'T> [<NamedParams>] (?settings: RouteSettings) =
  inherit OverlayRoute<'T>()

/// https://api.flutter.dev/flutter/widgets/LocalHistoryEntry-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LocalHistoryEntry [<NamedParams>] (?onRemove: (unit -> unit)) =
  class end

/// https://api.flutter.dev/flutter/widgets/ModalRoute-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ModalRoute<'T> [<NamedParams>] (?settings: RouteSettings, ?filter: ImageFilter) =
  inherit TransitionRoute<'T>()

/// https://api.flutter.dev/flutter/widgets/PopupRoute-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type PopupRoute<'T> [<NamedParams>] (?settings: RouteSettings, ?filter: ImageFilter) =
  inherit ModalRoute<'T>()

/// https://api.flutter.dev/flutter/widgets/RouteObserver-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RouteObserver<'R> () =
  inherit NavigatorObserver()

/// https://api.flutter.dev/flutter/widgets/RouteAware-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type RouteAware () =
  class end

/// https://api.flutter.dev/flutter/widgets/RawDialogRoute-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawDialogRoute<'T> [<NamedParams>] (pageBuilder: (BuildContext -> Animation<float> -> Animation<float> -> Widget), ?barrierDismissible: bool, ?barrierColor: Color, ?barrierLabel: string, ?transitionDuration: TimeSpan, ?transitionBuilder: (BuildContext -> Animation<float> -> Animation<float> -> Widget -> Widget), ?settings: RouteSettings, ?anchorPoint: Offset) =
  inherit PopupRoute<'T>()

/// https://api.flutter.dev/flutter/widgets/FocusTrap-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusTrap [<IsConst; NamedParams>] (focusScopeNode: FocusScopeNode, child: Widget, ?key: Key) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/FocusTrapArea-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusTrapArea [<IsConst; NamedParams>] (focusNode: FocusNode, ?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SafeArea-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SafeArea [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?left: bool, ?top: bool, ?right: bool, ?bottom: bool, ?minimum: EdgeInsets, ?maintainBottomViewPadding: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverSafeArea-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverSafeArea [<IsConst; NamedParams>] (sliver: Widget, ?key: Key, ?left: bool, ?top: bool, ?right: bool, ?bottom: bool, ?minimum: EdgeInsets) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ScrollActivityDelegate-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ScrollActivityDelegate () =
  class end

/// https://api.flutter.dev/flutter/widgets/ScrollActivity-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ScrollActivity (_delegate: ScrollActivityDelegate) =
  class end

/// https://api.flutter.dev/flutter/widgets/IdleScrollActivity-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IdleScrollActivity (``delegate``: ScrollActivityDelegate) =
  inherit ScrollActivity(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/ScrollHoldController-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ScrollHoldController () =
  class end

/// https://api.flutter.dev/flutter/widgets/HoldScrollActivity-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type HoldScrollActivity [<NamedParams>] (``delegate``: ScrollActivityDelegate, ?onHoldCanceled: (unit -> unit)) =
  inherit ScrollActivity(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/ScrollDragController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollDragController [<NamedParams>] (``delegate``: ScrollActivityDelegate, details: DragStartDetails, ?onDragCanceled: (unit -> unit), ?carriedVelocity: float, ?motionStartDistanceThreshold: float) =
  [<IsConst>] static member momentumRetainStationaryDurationThreshold: TimeSpan = nativeOnly
  [<IsConst>] static member momentumRetainVelocityThresholdFactor: float = nativeOnly
  [<IsConst>] static member motionStoppedDurationThreshold: TimeSpan = nativeOnly

/// https://api.flutter.dev/flutter/widgets/DragScrollActivity-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DragScrollActivity (``delegate``: ScrollActivityDelegate, controller: ScrollDragController) =
  inherit ScrollActivity(nativeOnly)

// /// https://api.flutter.dev/flutter/widgets/BallisticScrollActivity-class.html
// [<ImportMember("package:flutter/widgets.dart")>]
// type BallisticScrollActivity (``delegate``: ScrollActivityDelegate, simulation: Simulation, vsync: TickerProvider) =
//   inherit ScrollActivity(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/DrivenScrollActivity-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DrivenScrollActivity [<NamedParams(fromIndex=1)>] (``delegate``: ScrollActivityDelegate, from: float, ``to``: float, duration: TimeSpan, curve: Curve, vsync: TickerProvider) =
  inherit ScrollActivity(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/ScrollAwareImageProvider-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollAwareImageProvider<'T> [<IsConst; NamedParams>] (context: DisposableBuildContext<State<StatefulWidget>>, imageProvider: ImageProvider<'T>) =
  inherit ImageProvider<'T>()

/// https://api.flutter.dev/flutter/widgets/ScrollBehavior-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollBehavior [<IsConst; NamedParams>] (?androidOverscrollIndicator: AndroidOverscrollIndicator) =
  class end

/// https://api.flutter.dev/flutter/widgets/ScrollConfiguration-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollConfiguration [<IsConst; NamedParams>] (behavior: ScrollBehavior, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/ScrollContext-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ScrollContext () =
  class end

/// https://api.flutter.dev/flutter/widgets/ScrollController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollController [<NamedParams>] (?initialScrollOffset: float, ?keepScrollOffset: bool, ?debugLabel: string) =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/widgets/TrackingScrollController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TrackingScrollController [<NamedParams>] (?initialScrollOffset: float, ?keepScrollOffset: bool, ?debugLabel: string) =
  inherit ScrollController()

/// https://api.flutter.dev/flutter/widgets/FixedScrollMetrics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FixedScrollMetrics [<NamedParams>] (minScrollExtent: float option, maxScrollExtent: float option, pixels: float option, viewportDimension: float option, axisDirection: AxisDirection) =
  class end

/// https://api.flutter.dev/flutter/widgets/ScrollNotification-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ScrollNotification [<NamedParams>] (metrics: ScrollMetrics, context: BuildContext option) =
  inherit LayoutChangedNotification()

/// https://api.flutter.dev/flutter/widgets/ScrollStartNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollStartNotification [<NamedParams>] (metrics: ScrollMetrics, context: BuildContext option, ?dragDetails: DragStartDetails) =
  inherit ScrollNotification(metrics, context)

/// https://api.flutter.dev/flutter/widgets/ScrollUpdateNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollUpdateNotification [<NamedParams>] (metrics: ScrollMetrics, context: BuildContext, ?dragDetails: DragUpdateDetails, ?scrollDelta: float, ?depth: int) =
  inherit ScrollNotification(metrics, Some context)

/// https://api.flutter.dev/flutter/widgets/OverscrollNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OverscrollNotification [<NamedParams>] (metrics: ScrollMetrics, context: BuildContext, overscroll: float, ?dragDetails: DragUpdateDetails, ?velocity: float) =
  inherit ScrollNotification(metrics, Some context)

/// https://api.flutter.dev/flutter/widgets/ScrollEndNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollEndNotification [<NamedParams>] (metrics: ScrollMetrics, context: BuildContext, ?dragDetails: DragEndDetails) =
  inherit ScrollNotification(metrics, Some context)

/// https://api.flutter.dev/flutter/widgets/UserScrollNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type UserScrollNotification [<NamedParams>] (metrics: ScrollMetrics, context: BuildContext, direction: ScrollDirection) =
  inherit ScrollNotification(metrics, Some context)

/// https://api.flutter.dev/flutter/widgets/ScrollNotificationObserver-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollNotificationObserver [<IsConst; NamedParams>] (child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ScrollNotificationObserverState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollNotificationObserverState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/ScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollPhysics [<IsConst; NamedParams>] (?parent: ScrollPhysics) =
  class end

/// https://api.flutter.dev/flutter/widgets/RangeMaintainingScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RangeMaintainingScrollPhysics [<IsConst; NamedParams>] (?parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/BouncingScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BouncingScrollPhysics [<IsConst; NamedParams>] (?parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/ClampingScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ClampingScrollPhysics [<IsConst; NamedParams>] (?parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/AlwaysScrollableScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AlwaysScrollableScrollPhysics [<IsConst; NamedParams>] (?parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/NeverScrollableScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NeverScrollableScrollPhysics [<IsConst; NamedParams>] (?parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/ScrollPosition-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ScrollPosition [<NamedParams>] (physics: ScrollPhysics, context: ScrollContext, ?keepScrollOffset: bool, ?oldPosition: ScrollPosition, ?debugLabel: string) =
  inherit ViewportOffset()

/// https://api.flutter.dev/flutter/widgets/ScrollMetricsNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollMetricsNotification [<NamedParams>] (metrics: ScrollMetrics, context: BuildContext) =
  inherit Notification()

/// https://api.flutter.dev/flutter/widgets/ScrollPositionWithSingleContext-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollPositionWithSingleContext [<NamedParams>] (physics: ScrollPhysics, context: ScrollContext, ?initialPixels: float, ?keepScrollOffset: bool, ?oldPosition: ScrollPosition, ?debugLabel: string) =
  inherit ScrollPosition(physics, context)

// /// https://api.flutter.dev/flutter/widgets/BouncingScrollSimulation-class.html
// [<ImportMember("package:flutter/widgets.dart")>]
// type BouncingScrollSimulation [<NamedParams>] (position: float, velocity: float, leadingExtent: float, trailingExtent: float, spring: SpringDescription, ?tolerance: Tolerance) =
//   inherit Simulation()
//   [<IsConst>] static member maxSpringTransferVelocity: float = nativeOnly

// /// https://api.flutter.dev/flutter/widgets/ClampingScrollSimulation-class.html
// [<ImportMember("package:flutter/widgets.dart")>]
// type ClampingScrollSimulation [<NamedParams>] (position: float, velocity: float, ?friction: float, ?tolerance: Tolerance) =
//   inherit Simulation()

/// https://api.flutter.dev/flutter/widgets/ScrollView-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ScrollView [<IsConst; NamedParams>] (?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?scrollBehavior: ScrollBehavior, ?shrinkWrap: bool, ?center: Key, ?anchor: float, ?cacheExtent: float, ?semanticChildCount: int, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/CustomScrollView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CustomScrollView [<IsConst; NamedParams>] (?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?scrollBehavior: ScrollBehavior, ?shrinkWrap: bool, ?center: Key, ?anchor: float, ?cacheExtent: float, ?slivers: Widget[], ?semanticChildCount: int, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip) =
  inherit ScrollView()

/// https://api.flutter.dev/flutter/widgets/BoxScrollView-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type BoxScrollView [<IsConst; NamedParams>] (?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?padding: EdgeInsetsGeometry, ?cacheExtent: float, ?semanticChildCount: int, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip) =
  inherit ScrollView()

/// https://api.flutter.dev/flutter/widgets/ListView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ListView [<NamedParams>] (?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?padding: EdgeInsetsGeometry, ?itemExtent: float, ?prototypeItem: Widget, ?addAutomaticKeepAlives: bool, ?addRepaintBoundaries: bool, ?addSemanticIndexes: bool, ?cacheExtent: float, ?children: Widget[], ?semanticChildCount: int, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip) =
  inherit BoxScrollView()
  [<NamedParams>] static member builder(itemBuilder: (BuildContext -> int -> Widget), ?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?padding: EdgeInsetsGeometry, ?itemExtent: float, ?prototypeItem: Widget, ?findChildIndexCallback: (Key -> int option), ?itemCount: int, ?addAutomaticKeepAlives: bool, ?addRepaintBoundaries: bool, ?addSemanticIndexes: bool, ?cacheExtent: float, ?semanticChildCount: int, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip): ListView = nativeOnly
  [<NamedParams>] static member separated(itemBuilder: (BuildContext -> int -> Widget), separatorBuilder: (BuildContext -> int -> Widget), itemCount: int, ?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?padding: EdgeInsetsGeometry, ?findChildIndexCallback: (Key -> int option), ?addAutomaticKeepAlives: bool, ?addRepaintBoundaries: bool, ?addSemanticIndexes: bool, ?cacheExtent: float, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip): ListView = nativeOnly
  [<IsConst; NamedParams>] static member custom(childrenDelegate: SliverChildDelegate, ?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?padding: EdgeInsetsGeometry, ?itemExtent: float, ?prototypeItem: Widget, ?cacheExtent: float, ?semanticChildCount: int, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip): ListView = nativeOnly

/// https://api.flutter.dev/flutter/widgets/GridView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type GridView [<NamedParams>] (gridDelegate: SliverGridDelegate, ?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?padding: EdgeInsetsGeometry, ?addAutomaticKeepAlives: bool, ?addRepaintBoundaries: bool, ?addSemanticIndexes: bool, ?cacheExtent: float, ?children: Widget[], ?semanticChildCount: int, ?dragStartBehavior: DragStartBehavior, ?clipBehavior: Clip, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string) =
  inherit BoxScrollView()
  [<NamedParams>] static member builder(gridDelegate: SliverGridDelegate, itemBuilder: (BuildContext -> int -> Widget), ?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?padding: EdgeInsetsGeometry, ?findChildIndexCallback: (Key -> int option), ?itemCount: int, ?addAutomaticKeepAlives: bool, ?addRepaintBoundaries: bool, ?addSemanticIndexes: bool, ?cacheExtent: float, ?semanticChildCount: int, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip): GridView = nativeOnly
  [<IsConst; NamedParams>] static member custom(gridDelegate: SliverGridDelegate, childrenDelegate: SliverChildDelegate, ?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?padding: EdgeInsetsGeometry, ?cacheExtent: float, ?semanticChildCount: int, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip): GridView = nativeOnly
  [<NamedParams>] static member count(crossAxisCount: int, ?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?padding: EdgeInsetsGeometry, ?mainAxisSpacing: float, ?crossAxisSpacing: float, ?childAspectRatio: float, ?addAutomaticKeepAlives: bool, ?addRepaintBoundaries: bool, ?addSemanticIndexes: bool, ?cacheExtent: float, ?children: Widget[], ?semanticChildCount: int, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip): GridView = nativeOnly
  [<NamedParams>] static member extent(maxCrossAxisExtent: float, ?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?controller: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?padding: EdgeInsetsGeometry, ?mainAxisSpacing: float, ?crossAxisSpacing: float, ?childAspectRatio: float, ?addAutomaticKeepAlives: bool, ?addRepaintBoundaries: bool, ?addSemanticIndexes: bool, ?cacheExtent: float, ?children: Widget[], ?semanticChildCount: int, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip): GridView = nativeOnly

/// https://api.flutter.dev/flutter/widgets/Scrollable-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Scrollable [<IsConst; NamedParams>] (viewportBuilder: (BuildContext -> ViewportOffset -> Widget), ?key: Key, ?axisDirection: AxisDirection, ?controller: ScrollController, ?physics: ScrollPhysics, ?incrementCalculator: (ScrollIncrementDetails -> float), ?excludeFromSemantics: bool, ?semanticChildCount: int, ?dragStartBehavior: DragStartBehavior, ?restorationId: string, ?scrollBehavior: ScrollBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ScrollableState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollableState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/ScrollableDetails-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollableDetails [<IsConst; NamedParams>] (direction: AxisDirection, controller: ScrollController) =
  class end

/// https://api.flutter.dev/flutter/widgets/ScrollIncrementDetails-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollIncrementDetails [<IsConst; NamedParams>] (``type``: ScrollIncrementType, metrics: ScrollMetrics) =
  class end

/// https://api.flutter.dev/flutter/widgets/ScrollIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollIntent [<IsConst; NamedParams>] (direction: AxisDirection, ?``type``: ScrollIncrementType) =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/ScrollAction-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollAction () =
  inherit Action<ScrollIntent>()

/// https://api.flutter.dev/flutter/widgets/ScrollbarPainter-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollbarPainter [<NamedParams>] (color: Color, fadeoutOpacityAnimation: Animation<float>, ?trackColor: Color, ?trackBorderColor: Color, ?textDirection: TextDirection, ?thickness: float, ?padding: EdgeInsets, ?mainAxisMargin: float, ?crossAxisMargin: float, ?radius: Radius, ?trackRadius: Radius, ?shape: OutlinedBorder, ?minLength: float, ?minOverscrollLength: float, ?scrollbarOrientation: ScrollbarOrientation, ?ignorePointer: bool) =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/widgets/RawScrollbar-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawScrollbar [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?controller: ScrollController, ?thumbVisibility: bool, ?shape: OutlinedBorder, ?radius: Radius, ?thickness: float, ?thumbColor: Color, ?minThumbLength: float, ?minOverscrollLength: float, ?trackVisibility: bool, ?trackRadius: Radius, ?trackColor: Color, ?trackBorderColor: Color, ?fadeDuration: TimeSpan, ?timeToFade: TimeSpan, ?pressDuration: TimeSpan, ?notificationPredicate: (ScrollNotification -> bool), ?interactive: bool, ?scrollbarOrientation: ScrollbarOrientation, ?mainAxisMargin: float, ?crossAxisMargin: float, ?isAlwaysShown: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/RawScrollbarState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawScrollbarState<'T> () =
  interface State

/// https://api.flutter.dev/flutter/widgets/SemanticsDebugger-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SemanticsDebugger [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?labelStyle: TextStyle) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SharedAppData-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SharedAppData [<IsConst; NamedParams>] (child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/KeySet-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type KeySet<'T> (key1: 'T, ?key2: 'T, ?key3: 'T, ?key4: 'T) =
  static member fromSet(keys: HashSet<'T>): KeySet<'T> = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ShortcutActivator-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ShortcutActivator [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/LogicalKeySet-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LogicalKeySet (key1: LogicalKeyboardKey, ?key2: LogicalKeyboardKey, ?key3: LogicalKeyboardKey, ?key4: LogicalKeyboardKey) =
  inherit KeySet<LogicalKeyboardKey>(key1)
  static member fromSet(keys: HashSet<LogicalKeyboardKey>): LogicalKeySet = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ShortcutMapProperty-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ShortcutMapProperty [<NamedParams(fromIndex=2)>] (name: string, value: Dictionary<ShortcutActivator, Intent>, ?showName: bool, ?defaultValue: obj, ?level: DiagnosticLevel, ?description: string) =
  inherit DiagnosticsProperty<Dictionary<ShortcutActivator, Intent>>(Some name, nativeOnly)

/// https://api.flutter.dev/flutter/widgets/SingleActivator-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SingleActivator [<IsConst; NamedParams(fromIndex=1)>] (trigger: LogicalKeyboardKey, ?control: bool, ?shift: bool, ?alt: bool, ?meta: bool, ?includeRepeats: bool) =
  class end

/// https://api.flutter.dev/flutter/widgets/CharacterActivator-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CharacterActivator [<IsConst>] (character: string) =
  class end

/// https://api.flutter.dev/flutter/widgets/ShortcutManager-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ShortcutManager [<NamedParams>] (?shortcuts: Dictionary<ShortcutActivator, Intent>, ?modal: bool) =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/widgets/Shortcuts-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Shortcuts [<IsConst; NamedParams>] (shortcuts: Dictionary<ShortcutActivator, Intent>, child: Widget, ?key: Key, ?manager: ShortcutManager, ?debugLabel: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/CallbackShortcuts-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CallbackShortcuts [<IsConst; NamedParams>] (bindings: Dictionary<ShortcutActivator, (unit -> unit)>, child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SingleChildScrollView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SingleChildScrollView [<IsConst; NamedParams>] (?key: Key, ?scrollDirection: Axis, ?reverse: bool, ?padding: EdgeInsetsGeometry, ?primary: bool, ?physics: ScrollPhysics, ?controller: ScrollController, ?child: Widget, ?dragStartBehavior: DragStartBehavior, ?clipBehavior: Clip, ?restorationId: string, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SizeChangedLayoutNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SizeChangedLayoutNotification [<IsConst>] () =
  inherit LayoutChangedNotification()

/// https://api.flutter.dev/flutter/widgets/SizeChangedLayoutNotifier-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SizeChangedLayoutNotifier [<IsConst; NamedParams>] (?key: Key, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverChildDelegate-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type SliverChildDelegate [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/SliverChildBuilderDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverChildBuilderDelegate [<IsConst; NamedParams(fromIndex=1)>] (builder: (BuildContext -> int -> Widget option), ?findChildIndexCallback: (Key -> int option), ?childCount: int, ?addAutomaticKeepAlives: bool, ?addRepaintBoundaries: bool, ?addSemanticIndexes: bool, ?semanticIndexCallback: (Widget -> int -> int option), ?semanticIndexOffset: int) =
  inherit SliverChildDelegate()

/// https://api.flutter.dev/flutter/widgets/SliverChildListDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverChildListDelegate [<NamedParams(fromIndex=1)>] (children: Widget[], ?addAutomaticKeepAlives: bool, ?addRepaintBoundaries: bool, ?addSemanticIndexes: bool, ?semanticIndexCallback: (Widget -> int -> int option), ?semanticIndexOffset: int) =
  inherit SliverChildDelegate()
  [<IsConst; NamedParams(fromIndex=1)>] static member ``fixed``(children: Widget[], ?addAutomaticKeepAlives: bool, ?addRepaintBoundaries: bool, ?addSemanticIndexes: bool, ?semanticIndexCallback: (Widget -> int -> int option), ?semanticIndexOffset: int): SliverChildListDelegate = nativeOnly

/// https://api.flutter.dev/flutter/widgets/SliverWithKeepAliveWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type SliverWithKeepAliveWidget [<IsConst; NamedParams>] (?key: Key) =
  inherit RenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverMultiBoxAdaptorWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type SliverMultiBoxAdaptorWidget [<IsConst; NamedParams>] (``delegate``: SliverChildDelegate, ?key: Key) =
  inherit SliverWithKeepAliveWidget()

/// https://api.flutter.dev/flutter/widgets/SliverList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverList [<IsConst; NamedParams>] (``delegate``: SliverChildDelegate, ?key: Key) =
  inherit SliverMultiBoxAdaptorWidget(``delegate``)

/// https://api.flutter.dev/flutter/widgets/SliverFixedExtentList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverFixedExtentList [<IsConst; NamedParams>] (``delegate``: SliverChildDelegate, itemExtent: float, ?key: Key) =
  inherit SliverMultiBoxAdaptorWidget(``delegate``)

/// https://api.flutter.dev/flutter/widgets/SliverGrid-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverGrid [<IsConst; NamedParams>] (``delegate``: SliverChildDelegate, gridDelegate: SliverGridDelegate, ?key: Key) =
  inherit SliverMultiBoxAdaptorWidget(``delegate``)
  [<NamedParams>] static member count(crossAxisCount: int, ?key: Key, ?mainAxisSpacing: float, ?crossAxisSpacing: float, ?childAspectRatio: float, ?children: Widget[]): SliverGrid = nativeOnly
  [<NamedParams>] static member extent(maxCrossAxisExtent: float, ?key: Key, ?mainAxisSpacing: float, ?crossAxisSpacing: float, ?childAspectRatio: float, ?children: Widget[]): SliverGrid = nativeOnly

/// https://api.flutter.dev/flutter/widgets/SliverMultiBoxAdaptorElement-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverMultiBoxAdaptorElement [<NamedParams(fromIndex=1)>] (widget: SliverMultiBoxAdaptorWidget, ?replaceMovedChildren: bool) =
  inherit RenderObjectElement(widget)

/// https://api.flutter.dev/flutter/widgets/SliverOpacity-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverOpacity [<IsConst; NamedParams>] (opacity: float, ?key: Key, ?alwaysIncludeSemantics: bool, ?sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverIgnorePointer-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverIgnorePointer [<IsConst; NamedParams>] (?key: Key, ?ignoring: bool, ?ignoringSemantics: bool, ?sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverOffstage-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverOffstage [<IsConst; NamedParams>] (?key: Key, ?offstage: bool, ?sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/KeepAlive-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type KeepAlive [<IsConst; NamedParams>] (keepAlive: bool, child: Widget, ?key: Key) =
  inherit ParentDataWidget<KeepAliveParentDataMixin>(child)

/// https://api.flutter.dev/flutter/widgets/SliverFillViewport-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverFillViewport [<IsConst; NamedParams>] (``delegate``: SliverChildDelegate, ?key: Key, ?viewportFraction: float, ?padEnds: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverFillRemaining-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverFillRemaining [<IsConst; NamedParams>] (?key: Key, ?child: Widget, ?hasScrollBody: bool, ?fillOverscroll: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverLayoutBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverLayoutBuilder [<IsConst; NamedParams>] (builder: (BuildContext -> SliverConstraints -> Widget), ?key: Key) =
  inherit ConstrainedLayoutBuilder<SliverConstraints>(builder)

/// https://api.flutter.dev/flutter/widgets/SliverPersistentHeaderDelegate-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type SliverPersistentHeaderDelegate [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/SliverPersistentHeader-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverPersistentHeader [<IsConst; NamedParams>] (``delegate``: SliverPersistentHeaderDelegate, ?key: Key, ?pinned: bool, ?floating: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverPrototypeExtentList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverPrototypeExtentList [<IsConst; NamedParams>] (``delegate``: SliverChildDelegate, prototypeItem: Widget, ?key: Key) =
  inherit SliverMultiBoxAdaptorWidget(``delegate``)

// /// https://api.flutter.dev/flutter/widgets/SlottedRenderObjectElement-class.html
// [<ImportMember("package:flutter/widgets.dart")>]
// type SlottedRenderObjectElement<'S> (widget: SlottedMultiChildRenderObjectWidgetMixin<'S>) =
//   inherit RenderObjectElement(widget)

/// https://api.flutter.dev/flutter/widgets/Spacer-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Spacer [<IsConst; NamedParams>] (?key: Key, ?flex: int) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/StatusTransitionWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type StatusTransitionWidget [<IsConst; NamedParams>] (animation: Animation<float>, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/TableRow-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TableRow [<IsConst; NamedParams>] (?key: LocalKey, ?decoration: Decoration, ?children: Widget[]) =
  class end

/// https://api.flutter.dev/flutter/widgets/Table-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Table [<NamedParams>] (?key: Key, ?children: TableRow[], ?columnWidths: Dictionary<int, TableColumnWidth>, ?defaultColumnWidth: TableColumnWidth, ?textDirection: TextDirection, ?border: TableBorder, ?defaultVerticalAlignment: TableCellVerticalAlignment, ?textBaseline: TextBaseline) =
  inherit RenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/TableCell-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TableCell [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?verticalAlignment: TableCellVerticalAlignment) =
  inherit ParentDataWidget<TableCellParentData>(child)

/// https://api.flutter.dev/flutter/widgets/DefaultTextStyle-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DefaultTextStyle [<IsConst; NamedParams>] (style: TextStyle, child: Widget, ?key: Key, ?textAlign: TextAlign, ?softWrap: bool, ?overflow: TextOverflow, ?maxLines: int, ?textWidthBasis: TextWidthBasis, ?textHeightBehavior: TextHeightBehavior) =
  inherit InheritedTheme(child)
  [<IsConst; NamedParams>] static member fallback(?key: Key): DefaultTextStyle = nativeOnly

/// https://api.flutter.dev/flutter/widgets/DefaultTextHeightBehavior-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DefaultTextHeightBehavior [<IsConst; NamedParams>] (textHeightBehavior: TextHeightBehavior, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/widgets/Text-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Text [<IsConst; NamedParams(fromIndex=1)>] (data: string, ?key: Key, ?style: TextStyle, ?strutStyle: StrutStyle, ?textAlign: TextAlign, ?textDirection: TextDirection, ?locale: Locale, ?softWrap: bool, ?overflow: TextOverflow, ?textScaleFactor: float, ?maxLines: int, ?semanticsLabel: string, ?textWidthBasis: TextWidthBasis, ?textHeightBehavior: TextHeightBehavior) =
  inherit Widget()
  [<IsConst; NamedParams(fromIndex=1)>] static member rich(textSpan: InlineSpan, ?key: Key, ?style: TextStyle, ?strutStyle: StrutStyle, ?textAlign: TextAlign, ?textDirection: TextDirection, ?locale: Locale, ?softWrap: bool, ?overflow: TextOverflow, ?textScaleFactor: float, ?maxLines: int, ?semanticsLabel: string, ?textWidthBasis: TextWidthBasis, ?textHeightBehavior: TextHeightBehavior): Text = nativeOnly

/// https://api.flutter.dev/flutter/widgets/DoNothingAndStopPropagationTextIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DoNothingAndStopPropagationTextIntent [<IsConst>] () =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/DirectionalTextEditingIntent-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type DirectionalTextEditingIntent [<IsConst>] (forward: bool) =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/DeleteCharacterIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DeleteCharacterIntent [<IsConst; NamedParams>] (forward: bool) =
  inherit DirectionalTextEditingIntent(forward)

/// https://api.flutter.dev/flutter/widgets/DeleteToNextWordBoundaryIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DeleteToNextWordBoundaryIntent [<IsConst; NamedParams>] (forward: bool) =
  inherit DirectionalTextEditingIntent(forward)

/// https://api.flutter.dev/flutter/widgets/DeleteToLineBreakIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DeleteToLineBreakIntent [<IsConst; NamedParams>] (forward: bool) =
  inherit DirectionalTextEditingIntent(forward)

/// https://api.flutter.dev/flutter/widgets/DirectionalCaretMovementIntent-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type DirectionalCaretMovementIntent [<IsConst>] (forward: bool, collapseSelection: bool, ?collapseAtReversal: bool, ?continuesAtWrap: bool) =
  inherit DirectionalTextEditingIntent(forward)

/// https://api.flutter.dev/flutter/widgets/ExtendSelectionByCharacterIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExtendSelectionByCharacterIntent [<IsConst; NamedParams>] (forward: bool, collapseSelection: bool) =
  inherit DirectionalCaretMovementIntent(forward, collapseSelection)

/// https://api.flutter.dev/flutter/widgets/ExtendSelectionToNextWordBoundaryIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExtendSelectionToNextWordBoundaryIntent [<IsConst; NamedParams>] (forward: bool, collapseSelection: bool) =
  inherit DirectionalCaretMovementIntent(forward, collapseSelection)

/// https://api.flutter.dev/flutter/widgets/ExtendSelectionToNextWordBoundaryOrCaretLocationIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExtendSelectionToNextWordBoundaryOrCaretLocationIntent [<IsConst; NamedParams>] (forward: bool) =
  inherit DirectionalTextEditingIntent(forward)

/// https://api.flutter.dev/flutter/widgets/ExpandSelectionToDocumentBoundaryIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExpandSelectionToDocumentBoundaryIntent [<IsConst; NamedParams>] (forward: bool) =
  inherit DirectionalTextEditingIntent(forward)

/// https://api.flutter.dev/flutter/widgets/ExpandSelectionToLineBreakIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExpandSelectionToLineBreakIntent [<IsConst; NamedParams>] (forward: bool) =
  inherit DirectionalTextEditingIntent(forward)

/// https://api.flutter.dev/flutter/widgets/ExtendSelectionToLineBreakIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExtendSelectionToLineBreakIntent [<IsConst; NamedParams>] (forward: bool, collapseSelection: bool, ?collapseAtReversal: bool, ?continuesAtWrap: bool) =
  inherit DirectionalCaretMovementIntent(forward, collapseSelection)

/// https://api.flutter.dev/flutter/widgets/ExtendSelectionVerticallyToAdjacentLineIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExtendSelectionVerticallyToAdjacentLineIntent [<IsConst; NamedParams>] (forward: bool, collapseSelection: bool) =
  inherit DirectionalCaretMovementIntent(forward, collapseSelection)

/// https://api.flutter.dev/flutter/widgets/ExtendSelectionToDocumentBoundaryIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExtendSelectionToDocumentBoundaryIntent [<IsConst; NamedParams>] (forward: bool, collapseSelection: bool) =
  inherit DirectionalCaretMovementIntent(forward, collapseSelection)

/// https://api.flutter.dev/flutter/widgets/ScrollToDocumentBoundaryIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollToDocumentBoundaryIntent [<IsConst; NamedParams>] (forward: bool) =
  inherit DirectionalTextEditingIntent(forward)

/// https://api.flutter.dev/flutter/widgets/SelectAllTextIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SelectAllTextIntent [<IsConst>] (cause: SelectionChangedCause) =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/CopySelectionTextIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CopySelectionTextIntent =
  [<IsConst>] static member cut(cause: SelectionChangedCause): CopySelectionTextIntent = nativeOnly
  [<IsConst>] static member copy: CopySelectionTextIntent = nativeOnly

/// https://api.flutter.dev/flutter/widgets/PasteTextIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PasteTextIntent [<IsConst>] (cause: SelectionChangedCause) =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/RedoTextIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RedoTextIntent [<IsConst>] (cause: SelectionChangedCause) =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/ReplaceTextIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ReplaceTextIntent [<IsConst>] (currentTextEditingValue: TextEditingValue, replacementText: string, replacementRange: TextRange, cause: SelectionChangedCause) =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/UndoTextIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type UndoTextIntent [<IsConst>] (cause: SelectionChangedCause) =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/UpdateSelectionIntent-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type UpdateSelectionIntent [<IsConst>] (currentTextEditingValue: TextEditingValue, newSelection: TextSelection, cause: SelectionChangedCause) =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/ToolbarItemsParentData-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ToolbarItemsParentData () =
  inherit ContainerBoxParentData<RenderBox>()

/// https://api.flutter.dev/flutter/widgets/TextSelectionControls-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type TextSelectionControls () =
  class end

/// https://api.flutter.dev/flutter/widgets/TextSelectionOverlay-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TextSelectionOverlay [<NamedParams>] (value: TextEditingValue, context: BuildContext, toolbarLayerLink: LayerLink, startHandleLayerLink: LayerLink, endHandleLayerLink: LayerLink, renderObject: RenderEditable, selectionDelegate: TextSelectionDelegate, ?debugRequiredFor: Widget, ?selectionControls: TextSelectionControls, ?handlesVisible: bool, ?dragStartBehavior: DragStartBehavior, ?onSelectionHandleTapped: (unit -> unit), ?clipboardStatus: ClipboardStatusNotifier) =
  [<IsConst>] static member fadeDuration: TimeSpan = nativeOnly

/// https://api.flutter.dev/flutter/widgets/SelectionOverlay-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SelectionOverlay [<NamedParams>] (context: BuildContext, startHandleType: TextSelectionHandleType, lineHeightAtStart: float, endHandleType: TextSelectionHandleType, lineHeightAtEnd: float, selectionEndPoints: TextSelectionPoint[], selectionControls: TextSelectionControls option, selectionDelegate: TextSelectionDelegate, clipboardStatus: ClipboardStatusNotifier option, startHandleLayerLink: LayerLink, endHandleLayerLink: LayerLink, toolbarLayerLink: LayerLink, ?debugRequiredFor: Widget, ?startHandlesVisible: ValueListenable<bool>, ?onStartHandleDragStart: (DragStartDetails -> unit), ?onStartHandleDragUpdate: (DragUpdateDetails -> unit), ?onStartHandleDragEnd: (DragEndDetails -> unit), ?endHandlesVisible: ValueListenable<bool>, ?onEndHandleDragStart: (DragStartDetails -> unit), ?onEndHandleDragUpdate: (DragUpdateDetails -> unit), ?onEndHandleDragEnd: (DragEndDetails -> unit), ?toolbarVisible: ValueListenable<bool>, ?dragStartBehavior: DragStartBehavior, ?onSelectionHandleTapped: (unit -> unit), ?toolbarLocation: Offset) =
  [<IsConst>] static member fadeDuration: TimeSpan = nativeOnly

/// https://api.flutter.dev/flutter/widgets/TextSelectionGestureDetectorBuilderDelegate-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type TextSelectionGestureDetectorBuilderDelegate () =
  class end

/// https://api.flutter.dev/flutter/widgets/TextSelectionGestureDetectorBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TextSelectionGestureDetectorBuilder [<NamedParams>] (``delegate``: TextSelectionGestureDetectorBuilderDelegate) =
  class end

/// https://api.flutter.dev/flutter/widgets/TextSelectionGestureDetector-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TextSelectionGestureDetector [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?onTapDown: (TapDownDetails -> unit), ?onForcePressStart: (ForcePressDetails -> unit), ?onForcePressEnd: (ForcePressDetails -> unit), ?onSecondaryTap: (unit -> unit), ?onSecondaryTapDown: (TapDownDetails -> unit), ?onSingleTapUp: (TapUpDetails -> unit), ?onSingleTapCancel: (unit -> unit), ?onSingleLongTapStart: (LongPressStartDetails -> unit), ?onSingleLongTapMoveUpdate: (LongPressMoveUpdateDetails -> unit), ?onSingleLongTapEnd: (LongPressEndDetails -> unit), ?onDoubleTapDown: (TapDownDetails -> unit), ?onDragSelectionStart: (DragStartDetails -> unit), ?onDragSelectionUpdate: (DragStartDetails -> DragUpdateDetails -> unit), ?onDragSelectionEnd: (DragEndDetails -> unit), ?behavior: HitTestBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ClipboardStatusNotifier-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ClipboardStatusNotifier [<NamedParams>] (?value: ClipboardStatus) =
  inherit ValueNotifier<ClipboardStatus>(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/TextSelectionToolbarLayoutDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TextSelectionToolbarLayoutDelegate [<NamedParams>] (anchorAbove: Offset, anchorBelow: Offset, ?fitsAbove: bool) =
  inherit SingleChildLayoutDelegate()

/// https://api.flutter.dev/flutter/widgets/Texture-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Texture [<IsConst; NamedParams>] (textureId: int, ?key: Key, ?freeze: bool, ?filterQuality: FilterQuality) =
  inherit LeafRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/TickerMode-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TickerMode [<IsConst; NamedParams>] (enabled: bool, child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Title-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Title [<NamedParams>] (color: Color, child: Widget, ?key: Key, ?title: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AnimatedWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type AnimatedWidget [<IsConst; NamedParams>] (listenable: Listenable, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SlideTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SlideTransition [<IsConst; NamedParams>] (position: Animation<Offset>, ?key: Key, ?transformHitTests: bool, ?textDirection: TextDirection, ?child: Widget) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/ScaleTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScaleTransition [<IsConst; NamedParams>] (scale: Animation<float>, ?key: Key, ?alignment: Alignment, ?filterQuality: FilterQuality, ?child: Widget) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/RotationTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RotationTransition [<IsConst; NamedParams>] (turns: Animation<float>, ?key: Key, ?alignment: Alignment, ?filterQuality: FilterQuality, ?child: Widget) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/SizeTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SizeTransition [<IsConst; NamedParams>] (sizeFactor: Animation<float>, ?key: Key, ?axis: Axis, ?axisAlignment: float, ?child: Widget) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/FadeTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FadeTransition [<IsConst; NamedParams>] (opacity: Animation<float>, ?key: Key, ?alwaysIncludeSemantics: bool, ?child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverFadeTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverFadeTransition [<IsConst; NamedParams>] (opacity: Animation<float>, ?key: Key, ?alwaysIncludeSemantics: bool, ?sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/RelativeRectTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RelativeRectTween [<NamedParams>] (?``begin``: RelativeRect, ?``end``: RelativeRect) =
  inherit Tween<RelativeRect>()

/// https://api.flutter.dev/flutter/widgets/PositionedTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PositionedTransition [<IsConst; NamedParams>] (rect: Animation<RelativeRect>, child: Widget, ?key: Key) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/RelativePositionedTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RelativePositionedTransition [<IsConst; NamedParams>] (rect: Animation<Rect option>, size: Size, child: Widget, ?key: Key) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/DecoratedBoxTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DecoratedBoxTransition [<IsConst; NamedParams>] (decoration: Animation<Decoration>, child: Widget, ?key: Key, ?position: DecorationPosition) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/AlignTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AlignTransition [<IsConst; NamedParams>] (alignment: Animation<AlignmentGeometry>, child: Widget, ?key: Key, ?widthFactor: float, ?heightFactor: float) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/DefaultTextStyleTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DefaultTextStyleTransition [<IsConst; NamedParams>] (style: Animation<TextStyle>, child: Widget, ?key: Key, ?textAlign: TextAlign, ?softWrap: bool, ?overflow: TextOverflow, ?maxLines: int) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/AnimatedBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedBuilder [<IsConst; NamedParams>] (animation: Listenable, builder: (BuildContext -> Widget option -> Widget), ?key: Key, ?child: Widget) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/TweenAnimationBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TweenAnimationBuilder<'T> [<IsConst; NamedParams>] (tween: Tween<'T>, duration: TimeSpan, builder: (BuildContext -> 'T -> Widget option -> Widget), ?key: Key, ?curve: Curve, ?onEnd: (unit -> unit), ?child: Widget) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/UniqueWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type UniqueWidget<'T> [<IsConst; NamedParams>] (key: GlobalKey<'T>) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ValueListenableBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ValueListenableBuilder<'T> [<IsConst; NamedParams>] (valueListenable: ValueListenable<'T>, builder: (BuildContext -> 'T -> Widget option -> Widget), ?key: Key, ?child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Viewport-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Viewport [<NamedParams>] (offset: ViewportOffset, ?key: Key, ?axisDirection: AxisDirection, ?crossAxisDirection: AxisDirection, ?anchor: float, ?center: Key, ?cacheExtent: float, ?cacheExtentStyle: CacheExtentStyle, ?clipBehavior: Clip, ?slivers: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ShrinkWrappingViewport-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ShrinkWrappingViewport [<NamedParams>] (offset: ViewportOffset, ?key: Key, ?axisDirection: AxisDirection, ?crossAxisDirection: AxisDirection, ?clipBehavior: Clip, ?slivers: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Visibility-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Visibility [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?replacement: Widget, ?visible: bool, ?maintainState: bool, ?maintainAnimation: bool, ?maintainSize: bool, ?maintainSemantics: bool, ?maintainInteractivity: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverVisibility-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverVisibility [<IsConst; NamedParams>] (sliver: Widget, ?key: Key, ?replacementSliver: Widget, ?visible: bool, ?maintainState: bool, ?maintainAnimation: bool, ?maintainSize: bool, ?maintainSemantics: bool, ?maintainInteractivity: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/WidgetInspector-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type WidgetInspector [<IsConst; NamedParams>] (child: Widget, selectButtonBuilder: (BuildContext -> (unit -> unit) -> Widget), ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/InspectorSelection-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type InspectorSelection () =
  class end

/// https://api.flutter.dev/flutter/widgets/DevToolsDeepLinkProperty-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DevToolsDeepLinkProperty (description: string, url: string) =
  inherit DiagnosticsProperty<string>(nativeOnly, nativeOnly)

/// https://api.flutter.dev/flutter/widgets/InspectorSerializationDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type InspectorSerializationDelegate [<NamedParams>] (service: WidgetInspectorService, ?groupName: string, ?summaryTree: bool, ?maxDescendentsTruncatableNode: int, ?expandPropertyValues: bool, ?subtreeDepth: int, ?includeProperties: bool, ?addAdditionalPropertiesCallback: (DiagnosticsNode -> InspectorSerializationDelegate -> Dictionary<string, obj> option)) =
  class end

/// https://api.flutter.dev/flutter/widgets/WidgetSpan-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type WidgetSpan [<IsConst; NamedParams>] (child: Widget, ?alignment: PlaceholderAlignment, ?baseline: TextBaseline, ?style: TextStyle) =
  inherit PlaceholderSpan()

/// https://api.flutter.dev/flutter/widgets/WillPopScope-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type WillPopScope [<IsConst; NamedParams>] (child: Widget, onWillPop: (unit -> Future<bool>), ?key: Key) =
  inherit Widget()

[<ImportAll("package:flutter/widgets.dart")>]
type Widgets =
  /// https://api.flutter.dev/flutter/widgets/basicLocaleListResolution.html
  static member basicLocaleListResolution(preferredLocales: Locale[] option, supportedLocales: Locale seq): Locale = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/getAxisDirectionFromAxisReverseAndDirectionality.html
  static member getAxisDirectionFromAxisReverseAndDirectionality(context: BuildContext, axis: Axis, reverse: bool): AxisDirection = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/runApp.html
  static member runApp(app: Widget): unit = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugDumpApp.html
  static member debugDumpApp(): unit = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugChildrenHaveDuplicateKeys.html
  static member debugChildrenHaveDuplicateKeys(parent: Widget, children: Widget seq): bool = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugItemsHaveDuplicateKeys.html
  static member debugItemsHaveDuplicateKeys(items: Widget seq): bool = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugCheckHasTable.html
  static member debugCheckHasTable(context: BuildContext): bool = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugCheckHasMediaQuery.html
  static member debugCheckHasMediaQuery(context: BuildContext): bool = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugCheckHasDirectionality.html
  [<NamedParams(fromIndex=1)>] static member debugCheckHasDirectionality(context: BuildContext, ?why: string, ?hint: string, ?alternative: string): bool = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugWidgetBuilderValue.html
  static member debugWidgetBuilderValue(widget: Widget, built: Widget option): unit = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugCheckHasWidgetsLocalizations.html
  static member debugCheckHasWidgetsLocalizations(context: BuildContext): bool = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugCheckHasOverlay.html
  static member debugCheckHasOverlay(context: BuildContext): bool = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugAssertAllWidgetVarsUnset.html
  static member debugAssertAllWidgetVarsUnset(reason: string): bool = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/childDragAnchorStrategy.html
  static member childDragAnchorStrategy(draggable: Draggable<obj>, context: BuildContext, position: Offset): Offset = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/pointerDragAnchorStrategy.html
  static member pointerDragAnchorStrategy(draggable: Draggable<obj>, context: BuildContext, position: Offset): Offset = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/combineKeyEventResults.html
  static member combineKeyEventResults(results: KeyEventResult seq): KeyEventResult = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugDescribeFocusTree.html
  static member debugDescribeFocusTree(): string = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugDumpFocusTree.html
  static member debugDumpFocusTree(): unit = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/createLocalImageConfiguration.html
  [<NamedParams(fromIndex=1)>] static member createLocalImageConfiguration(context: BuildContext, ?size: Size): ImageConfiguration = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/precacheImage.html
  [<NamedParams(fromIndex=2)>] static member precacheImage(provider: ImageProvider<obj>, context: BuildContext, ?size: Size, ?onError: (obj -> StackTrace option -> unit)): Future<unit> = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/showGeneralDialog.html
  [<NamedParams>] static member showGeneralDialog<'T>(context: BuildContext, pageBuilder: (BuildContext -> Animation<float> -> Animation<float> -> Widget), ?barrierDismissible: bool, ?barrierLabel: string, ?barrierColor: Color, ?transitionDuration: TimeSpan, ?transitionBuilder: (BuildContext -> Animation<float> -> Animation<float> -> Widget -> Widget), ?useRootNavigator: bool, ?routeSettings: RouteSettings, ?anchorPoint: Offset): Future<'T option> = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/defaultScrollNotificationPredicate.html
  static member defaultScrollNotificationPredicate(notification: ScrollNotification): bool = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugTransformDebugCreator.html
  static member debugTransformDebugCreator(properties: DiagnosticsNode seq): DiagnosticsNode seq = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugIsLocalCreationLocation.html
  static member debugIsLocalCreationLocation(object: obj): bool = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugIsWidgetLocalCreation.html
  static member debugIsWidgetLocalCreation(widget: Widget): bool = nativeOnly
