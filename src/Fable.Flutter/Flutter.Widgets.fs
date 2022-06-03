namespace rec Flutter.Widgets

open System
open System.Collections.Generic
open System.Runtime.InteropServices
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
type ActionListener [<IsConst; NamedParams>] (listener: (Action<Intent> -> unit), action: Action<Intent>, child: Widget, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ContextAction-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ContextAction<'T> () =
  inherit Action<'T>()

/// https://api.flutter.dev/flutter/widgets/CallbackAction-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CallbackAction<'T> [<NamedParams>] (onInvoke: ('T -> DartNullable<obj>)) =
  inherit Action<'T>()

/// https://api.flutter.dev/flutter/widgets/ActionDispatcher-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ActionDispatcher [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/Actions-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Actions [<IsConst; NamedParams>] (actions: Dictionary<Type, Action<Intent>>, child: Widget, [<Optional>] key: Key, [<Optional>] dispatcher: ActionDispatcher) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/FocusableActionDetector-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusableActionDetector [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] enabled: bool, [<Optional>] focusNode: FocusNode, [<Optional>] autofocus: bool, [<Optional>] descendantsAreFocusable: bool, [<Optional>] descendantsAreTraversable: bool, [<Optional>] shortcuts: Dictionary<ShortcutActivator, Intent>, [<Optional>] actions: Dictionary<Type, Action<Intent>>, [<Optional>] onShowFocusHighlight: (bool -> unit), [<Optional>] onShowHoverHighlight: (bool -> unit), [<Optional>] onFocusChange: (bool -> unit), [<Optional>] mouseCursor: MouseCursor) =
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
type DoNothingAction [<NamedParams>] ([<Optional>] consumesKey: bool) =
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
type AnimatedCrossFade [<IsConst; NamedParams>] (firstChild: Widget, secondChild: Widget, crossFadeState: CrossFadeState, duration: TimeSpan, [<Optional>] key: Key, [<Optional>] firstCurve: Curve, [<Optional>] secondCurve: Curve, [<Optional>] sizeCurve: Curve, [<Optional>] alignment: AlignmentGeometry, [<Optional>] reverseDuration: TimeSpan, [<Optional>] layoutBuilder: (Widget -> Key -> Widget -> Key -> Widget), [<Optional>] excludeBottomFocus: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AnimatedList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedList [<IsConst; NamedParams>] (itemBuilder: (BuildContext -> int -> Animation<float> -> Widget), [<Optional>] key: Key, [<Optional>] initialItemCount: int, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] shrinkWrap: bool, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AnimatedListState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedListState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/SliverAnimatedList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverAnimatedList [<IsConst; NamedParams>] (itemBuilder: (BuildContext -> int -> Animation<float> -> Widget), [<Optional>] key: Key, [<Optional>] findChildIndexCallback: (Key -> DartNullable<int>), [<Optional>] initialItemCount: int) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverAnimatedListState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverAnimatedListState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/AnimatedSize-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedSize [<IsConst; NamedParams>] (duration: TimeSpan, [<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] alignment: AlignmentGeometry, [<Optional>] curve: Curve, [<Optional>] reverseDuration: TimeSpan, [<Optional>] vsync: TickerProvider, [<Optional>] clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AnimatedSwitcher-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedSwitcher [<IsConst; NamedParams>] (duration: TimeSpan, [<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] reverseDuration: TimeSpan, [<Optional>] switchInCurve: Curve, [<Optional>] switchOutCurve: Curve, [<Optional>] transitionBuilder: (Widget -> Animation<float> -> Widget), [<Optional>] layoutBuilder: (DartNullable<Widget> -> Widget[] -> Widget)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AnnotatedRegion-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnnotatedRegion<'T> [<IsConst; NamedParams>] (child: Widget, value: 'T, [<Optional>] key: Key, [<Optional>] sized: bool) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/WidgetsApp-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type WidgetsApp [<NamedParams>] (color: Color, [<Optional>] key: Key, [<Optional>] navigatorKey: GlobalKey<NavigatorState>, [<Optional>] onGenerateRoute: (RouteSettings -> DartNullable<Route<obj>>), [<Optional>] onGenerateInitialRoutes: (string -> Route<obj>[]), [<Optional>] onUnknownRoute: (RouteSettings -> DartNullable<Route<obj>>), [<Optional>] navigatorObservers: NavigatorObserver[], [<Optional>] initialRoute: string, [<Optional>] pageRouteBuilder: (RouteSettings -> (BuildContext -> Widget) -> PageRoute<obj>), [<Optional>] home: Widget, [<Optional>] routes: Dictionary<string, (BuildContext -> Widget)>, [<Optional>] builder: (BuildContext -> DartNullable<Widget> -> Widget), [<Optional>] title: string, [<Optional>] onGenerateTitle: (BuildContext -> string), [<Optional>] textStyle: TextStyle, [<Optional>] locale: Locale, [<Optional>] localizationsDelegates: LocalizationsDelegate<obj> seq, [<Optional>] localeListResolutionCallback: (DartNullable<Locale[]> -> Locale seq -> DartNullable<Locale>), [<Optional>] localeResolutionCallback: (DartNullable<Locale> -> Locale seq -> DartNullable<Locale>), [<Optional>] supportedLocales: Locale seq, [<Optional>] showPerformanceOverlay: bool, [<Optional>] checkerboardRasterCacheImages: bool, [<Optional>] checkerboardOffscreenLayers: bool, [<Optional>] showSemanticsDebugger: bool, [<Optional>] debugShowWidgetInspector: bool, [<Optional>] debugShowCheckedModeBanner: bool, [<Optional>] inspectorSelectButtonBuilder: (BuildContext -> (unit -> unit) -> Widget), [<Optional>] shortcuts: Dictionary<ShortcutActivator, Intent>, [<Optional>] actions: Dictionary<Type, Action<Intent>>, [<Optional>] restorationScopeId: string, [<Optional>] useInheritedMediaQuery: bool) =
  inherit Widget()
  [<NamedParams>] static member router(routeInformationParser: RouteInformationParser<obj>, routerDelegate: RouterDelegate<obj>, color: Color, [<Optional>] key: Key, [<Optional>] routeInformationProvider: RouteInformationProvider, [<Optional>] backButtonDispatcher: BackButtonDispatcher, [<Optional>] builder: (BuildContext -> DartNullable<Widget> -> Widget), [<Optional>] title: string, [<Optional>] onGenerateTitle: (BuildContext -> string), [<Optional>] textStyle: TextStyle, [<Optional>] locale: Locale, [<Optional>] localizationsDelegates: LocalizationsDelegate<obj> seq, [<Optional>] localeListResolutionCallback: (DartNullable<Locale[]> -> Locale seq -> DartNullable<Locale>), [<Optional>] localeResolutionCallback: (DartNullable<Locale> -> Locale seq -> DartNullable<Locale>), [<Optional>] supportedLocales: Locale seq, [<Optional>] showPerformanceOverlay: bool, [<Optional>] checkerboardRasterCacheImages: bool, [<Optional>] checkerboardOffscreenLayers: bool, [<Optional>] showSemanticsDebugger: bool, [<Optional>] debugShowWidgetInspector: bool, [<Optional>] debugShowCheckedModeBanner: bool, [<Optional>] inspectorSelectButtonBuilder: (BuildContext -> (unit -> unit) -> Widget), [<Optional>] shortcuts: Dictionary<ShortcutActivator, Intent>, [<Optional>] actions: Dictionary<Type, Action<Intent>>, [<Optional>] restorationScopeId: string, [<Optional>] useInheritedMediaQuery: bool): WidgetsApp = nativeOnly

/// https://api.flutter.dev/flutter/widgets/StreamBuilderBase-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type StreamBuilderBase<'T, 'S> [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] stream: Stream<'T>) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AsyncSnapshot-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AsyncSnapshot<'T> =
  [<IsConst>] static member nothing(): AsyncSnapshot<'T> = nativeOnly
  [<IsConst>] static member waiting(): AsyncSnapshot<'T> = nativeOnly
  [<IsConst>] static member withData(state: ConnectionState, data: 'T): AsyncSnapshot<'T> = nativeOnly
  [<IsConst>] static member withError(state: ConnectionState, error: obj, [<Optional>] stackTrace: StackTrace): AsyncSnapshot<'T> = nativeOnly

/// https://api.flutter.dev/flutter/widgets/StreamBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type StreamBuilder<'T> [<IsConst; NamedParams>] (builder: (BuildContext -> AsyncSnapshot<'T> -> Widget), [<Optional>] key: Key, [<Optional>] initialData: 'T, [<Optional>] stream: Stream<'T>) =
  inherit StreamBuilderBase<'T, AsyncSnapshot<'T>>()

/// https://api.flutter.dev/flutter/widgets/FutureBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FutureBuilder<'T> [<IsConst; NamedParams>] (builder: (BuildContext -> AsyncSnapshot<'T> -> Widget), [<Optional>] key: Key, [<Optional>] future: Future<'T>, [<Optional>] initialData: 'T) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/RawAutocomplete-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawAutocomplete<'T> [<IsConst; NamedParams>] (optionsViewBuilder: (BuildContext -> ('T -> unit) -> 'T seq -> Widget), optionsBuilder: (TextEditingValue -> FutureOr<'T seq>), [<Optional>] key: Key, [<Optional>] displayStringForOption: ('T -> string), [<Optional>] fieldViewBuilder: (BuildContext -> TextEditingController -> FocusNode -> (unit -> unit) -> Widget), [<Optional>] focusNode: FocusNode, [<Optional>] onSelected: ('T -> unit), [<Optional>] textEditingController: TextEditingController, [<Optional>] initialValue: TextEditingValue) =
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
type AutocompleteHighlightedOption [<IsConst; NamedParams>] (highlightIndexNotifier: ValueNotifier<int>, child: Widget, [<Optional>] key: Key) =
  inherit InheritedNotifier<ValueNotifier<int>>(child)

/// https://api.flutter.dev/flutter/widgets/AutofillGroup-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AutofillGroup [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] onDisposeAction: AutofillContextAction) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AutofillGroupState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AutofillGroupState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/AutomaticKeepAlive-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AutomaticKeepAlive [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] child: Widget) =
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
type BannerPainter [<NamedParams>] (message: string, textDirection: TextDirection, location: BannerLocation, layoutDirection: TextDirection, [<Optional>] color: Color, [<Optional>] textStyle: TextStyle) =
  inherit CustomPainter()

/// https://api.flutter.dev/flutter/widgets/Banner-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Banner [<IsConst; NamedParams>] (message: string, location: BannerLocation, [<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] textDirection: TextDirection, [<Optional>] layoutDirection: TextDirection, [<Optional>] color: Color, [<Optional>] textStyle: TextStyle) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/CheckedModeBanner-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CheckedModeBanner [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Directionality-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Directionality [<IsConst; NamedParams>] (textDirection: TextDirection, child: Widget, [<Optional>] key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/Opacity-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Opacity [<IsConst; NamedParams>] (opacity: float, [<Optional>] key: Key, [<Optional>] alwaysIncludeSemantics: bool, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ShaderMask-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ShaderMask [<IsConst; NamedParams>] (shaderCallback: (Rect -> Shader), [<Optional>] key: Key, [<Optional>] blendMode: BlendMode, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/BackdropFilter-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BackdropFilter [<IsConst; NamedParams>] (filter: ImageFilter, [<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] blendMode: BlendMode) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/CustomPaint-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CustomPaint [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] painter: CustomPainter, [<Optional>] foregroundPainter: CustomPainter, [<Optional>] size: Size, [<Optional>] isComplex: bool, [<Optional>] willChange: bool, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ClipRect-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ClipRect [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] clipper: CustomClipper<Rect>, [<Optional>] clipBehavior: Clip, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ClipRRect-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ClipRRect [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] borderRadius: BorderRadius, [<Optional>] clipper: CustomClipper<RRect>, [<Optional>] clipBehavior: Clip, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ClipOval-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ClipOval [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] clipper: CustomClipper<Rect>, [<Optional>] clipBehavior: Clip, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ClipPath-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ClipPath [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] clipper: CustomClipper<Path>, [<Optional>] clipBehavior: Clip, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/PhysicalModel-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PhysicalModel [<IsConst; NamedParams>] (color: Color, [<Optional>] key: Key, [<Optional>] shape: BoxShape, [<Optional>] clipBehavior: Clip, [<Optional>] borderRadius: BorderRadius, [<Optional>] elevation: float, [<Optional>] shadowColor: Color, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/PhysicalShape-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PhysicalShape [<IsConst; NamedParams>] (clipper: CustomClipper<Path>, color: Color, [<Optional>] key: Key, [<Optional>] clipBehavior: Clip, [<Optional>] elevation: float, [<Optional>] shadowColor: Color, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Transform-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Transform [<IsConst; NamedParams>] (transform: Matrix4, [<Optional>] key: Key, [<Optional>] origin: Offset, [<Optional>] alignment: AlignmentGeometry, [<Optional>] transformHitTests: bool, [<Optional>] filterQuality: FilterQuality, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()
  [<NamedParams>] static member rotate(angle: float, [<Optional>] key: Key, [<Optional>] origin: Offset, [<Optional>] alignment: AlignmentGeometry, [<Optional>] transformHitTests: bool, [<Optional>] filterQuality: FilterQuality, [<Optional>] child: Widget): Transform = nativeOnly
  [<NamedParams>] static member translate(offset: Offset, [<Optional>] key: Key, [<Optional>] transformHitTests: bool, [<Optional>] filterQuality: FilterQuality, [<Optional>] child: Widget): Transform = nativeOnly
  [<NamedParams>] static member scale([<Optional>] key: Key, [<Optional>] scale: float, [<Optional>] scaleX: float, [<Optional>] scaleY: float, [<Optional>] origin: Offset, [<Optional>] alignment: AlignmentGeometry, [<Optional>] transformHitTests: bool, [<Optional>] filterQuality: FilterQuality, [<Optional>] child: Widget): Transform = nativeOnly

/// https://api.flutter.dev/flutter/widgets/CompositedTransformTarget-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CompositedTransformTarget [<IsConst; NamedParams>] (link: LayerLink, [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/CompositedTransformFollower-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CompositedTransformFollower [<IsConst; NamedParams>] (link: LayerLink, [<Optional>] key: Key, [<Optional>] showWhenUnlinked: bool, [<Optional>] offset: Offset, [<Optional>] targetAnchor: Alignment, [<Optional>] followerAnchor: Alignment, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/FittedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FittedBox [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] fit: BoxFit, [<Optional>] alignment: AlignmentGeometry, [<Optional>] clipBehavior: Clip, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/FractionalTranslation-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FractionalTranslation [<IsConst; NamedParams>] (translation: Offset, [<Optional>] key: Key, [<Optional>] transformHitTests: bool, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/RotatedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RotatedBox [<IsConst; NamedParams>] (quarterTurns: int, [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Padding-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Padding [<IsConst; NamedParams>] (padding: EdgeInsetsGeometry, [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Align-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Align [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] alignment: AlignmentGeometry, [<Optional>] widthFactor: float, [<Optional>] heightFactor: float, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Center-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Center [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] widthFactor: float, [<Optional>] heightFactor: float, [<Optional>] child: Widget) =
  inherit Align()

/// https://api.flutter.dev/flutter/widgets/CustomSingleChildLayout-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CustomSingleChildLayout [<IsConst; NamedParams>] (``delegate``: SingleChildLayoutDelegate, [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/LayoutId-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LayoutId [<NamedParams>] (id: obj, child: Widget, [<Optional>] key: Key) =
  inherit ParentDataWidget<MultiChildLayoutParentData>(child)

/// https://api.flutter.dev/flutter/widgets/CustomMultiChildLayout-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CustomMultiChildLayout [<NamedParams>] (``delegate``: MultiChildLayoutDelegate, [<Optional>] key: Key, [<Optional>] children: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SizedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SizedBox [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()
  [<IsConst; NamedParams>] static member expand([<Optional>] key: Key, [<Optional>] child: Widget): SizedBox = nativeOnly
  [<IsConst; NamedParams>] static member shrink([<Optional>] key: Key, [<Optional>] child: Widget): SizedBox = nativeOnly
  [<NamedParams>] static member fromSize([<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] size: Size): SizedBox = nativeOnly
  [<IsConst; NamedParams>] static member square([<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] dimension: float): SizedBox = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ConstrainedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ConstrainedBox [<NamedParams>] (constraints: BoxConstraints, [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ConstraintsTransformBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ConstraintsTransformBox [<IsConst; NamedParams>] (constraintsTransform: (BoxConstraints -> BoxConstraints), [<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] textDirection: TextDirection, [<Optional>] alignment: AlignmentGeometry, [<Optional>] clipBehavior: Clip, [<Optional>] debugTransformType: string) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/UnconstrainedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type UnconstrainedBox [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] textDirection: TextDirection, [<Optional>] alignment: AlignmentGeometry, [<Optional>] constrainedAxis: Axis, [<Optional>] clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/FractionallySizedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FractionallySizedBox [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] alignment: AlignmentGeometry, [<Optional>] widthFactor: float, [<Optional>] heightFactor: float, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/LimitedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LimitedBox [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] maxWidth: float, [<Optional>] maxHeight: float, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/OverflowBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OverflowBox [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] alignment: AlignmentGeometry, [<Optional>] minWidth: float, [<Optional>] maxWidth: float, [<Optional>] minHeight: float, [<Optional>] maxHeight: float, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SizedOverflowBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SizedOverflowBox [<IsConst; NamedParams>] (size: Size, [<Optional>] key: Key, [<Optional>] alignment: AlignmentGeometry, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Offstage-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Offstage [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] offstage: bool, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/AspectRatio-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AspectRatio [<IsConst; NamedParams>] (aspectRatio: float, [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/IntrinsicWidth-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IntrinsicWidth [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] stepWidth: float, [<Optional>] stepHeight: float, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/IntrinsicHeight-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IntrinsicHeight [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Baseline-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Baseline [<IsConst; NamedParams>] (baseline: float, baselineType: TextBaseline, [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverToBoxAdapter-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverToBoxAdapter [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverPadding-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverPadding [<IsConst; NamedParams>] (padding: EdgeInsetsGeometry, [<Optional>] key: Key, [<Optional>] sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ListBody-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ListBody [<NamedParams>] ([<Optional>] key: Key, [<Optional>] mainAxis: Axis, [<Optional>] reverse: bool, [<Optional>] children: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Stack-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Stack [<NamedParams>] ([<Optional>] key: Key, [<Optional>] alignment: AlignmentGeometry, [<Optional>] textDirection: TextDirection, [<Optional>] fit: StackFit, [<Optional>] clipBehavior: Clip, [<Optional>] children: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/IndexedStack-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IndexedStack [<NamedParams>] ([<Optional>] key: Key, [<Optional>] alignment: AlignmentGeometry, [<Optional>] textDirection: TextDirection, [<Optional>] sizing: StackFit, [<Optional>] index: int, [<Optional>] children: Widget[]) =
  inherit Stack()

/// https://api.flutter.dev/flutter/widgets/Positioned-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Positioned [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] left: float, [<Optional>] top: float, [<Optional>] right: float, [<Optional>] bottom: float, [<Optional>] width: float, [<Optional>] height: float) =
  inherit ParentDataWidget<StackParentData>(child)
  [<NamedParams>] static member fromRect(rect: Rect, child: Widget, [<Optional>] key: Key): Positioned = nativeOnly
  [<NamedParams>] static member fromRelativeRect(rect: RelativeRect, child: Widget, [<Optional>] key: Key): Positioned = nativeOnly
  [<IsConst; NamedParams>] static member fill(child: Widget, [<Optional>] key: Key, [<Optional>] left: float, [<Optional>] top: float, [<Optional>] right: float, [<Optional>] bottom: float): Positioned = nativeOnly
  [<NamedParams>] static member directional(textDirection: TextDirection, child: Widget, [<Optional>] key: Key, [<Optional>] start: float, [<Optional>] top: float, [<Optional>] ``end``: float, [<Optional>] bottom: float, [<Optional>] width: float, [<Optional>] height: float): Positioned = nativeOnly

/// https://api.flutter.dev/flutter/widgets/PositionedDirectional-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PositionedDirectional [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] start: float, [<Optional>] top: float, [<Optional>] ``end``: float, [<Optional>] bottom: float, [<Optional>] width: float, [<Optional>] height: float) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Flex-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Flex [<NamedParams>] (direction: Axis, [<Optional>] key: Key, [<Optional>] mainAxisAlignment: MainAxisAlignment, [<Optional>] mainAxisSize: MainAxisSize, [<Optional>] crossAxisAlignment: CrossAxisAlignment, [<Optional>] textDirection: TextDirection, [<Optional>] verticalDirection: VerticalDirection, [<Optional>] textBaseline: TextBaseline, [<Optional>] clipBehavior: Clip, [<Optional>] children: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Row-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Row [<NamedParams>] ([<Optional>] children: Widget[], [<Optional>] key: Key, [<Optional>] mainAxisAlignment: MainAxisAlignment, [<Optional>] mainAxisSize: MainAxisSize, [<Optional>] crossAxisAlignment: CrossAxisAlignment, [<Optional>] textDirection: TextDirection, [<Optional>] verticalDirection: VerticalDirection, [<Optional>] textBaseline: TextBaseline) =
  inherit Flex(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/Column-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Column [<NamedParams>] ([<Optional>] children: Widget[], [<Optional>] key: Key, [<Optional>] mainAxisAlignment: MainAxisAlignment, [<Optional>] mainAxisSize: MainAxisSize, [<Optional>] crossAxisAlignment: CrossAxisAlignment, [<Optional>] textDirection: TextDirection, [<Optional>] verticalDirection: VerticalDirection, [<Optional>] textBaseline: TextBaseline) =
  inherit Flex(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/Flexible-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Flexible [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] flex: int, [<Optional>] fit: FlexFit) =
  inherit ParentDataWidget<FlexParentData>(child)

/// https://api.flutter.dev/flutter/widgets/Expanded-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Expanded [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] flex: int) =
  inherit Flexible(child)

/// https://api.flutter.dev/flutter/widgets/Wrap-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Wrap [<NamedParams>] ([<Optional>] children: Widget[], [<Optional>] key: Key, [<Optional>] direction: Axis, [<Optional>] alignment: WrapAlignment, [<Optional>] spacing: float, [<Optional>] runAlignment: WrapAlignment, [<Optional>] runSpacing: float, [<Optional>] crossAxisAlignment: WrapCrossAlignment, [<Optional>] textDirection: TextDirection, [<Optional>] verticalDirection: VerticalDirection, [<Optional>] clipBehavior: Clip) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Flow-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Flow [<NamedParams>] (``delegate``: FlowDelegate, [<Optional>] key: Key, [<Optional>] children: Widget[], [<Optional>] clipBehavior: Clip) =
  inherit MultiChildRenderObjectWidget()
  [<NamedParams>] static member unwrapped(``delegate``: FlowDelegate, [<Optional>] key: Key, [<Optional>] children: Widget[], [<Optional>] clipBehavior: Clip): Flow = nativeOnly

/// https://api.flutter.dev/flutter/widgets/RichText-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RichText [<NamedParams>] (text: InlineSpan, [<Optional>] key: Key, [<Optional>] textAlign: TextAlign, [<Optional>] textDirection: TextDirection, [<Optional>] softWrap: bool, [<Optional>] overflow: TextOverflow, [<Optional>] textScaleFactor: float, [<Optional>] maxLines: int, [<Optional>] locale: Locale, [<Optional>] strutStyle: StrutStyle, [<Optional>] textWidthBasis: TextWidthBasis, [<Optional>] textHeightBehavior: TextHeightBehavior) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/RawImage-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawImage [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] image: Image, [<Optional>] debugImageLabel: string, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] scale: float, [<Optional>] color: Color, [<Optional>] opacity: Animation<float>, [<Optional>] colorBlendMode: BlendMode, [<Optional>] fit: BoxFit, [<Optional>] alignment: AlignmentGeometry, [<Optional>] repeat: ImageRepeat, [<Optional>] centerSlice: Rect, [<Optional>] matchTextDirection: bool, [<Optional>] invertColors: bool, [<Optional>] filterQuality: FilterQuality, [<Optional>] isAntiAlias: bool) =
  inherit LeafRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/DefaultAssetBundle-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DefaultAssetBundle [<IsConst; NamedParams>] (bundle: AssetBundle, child: Widget, [<Optional>] key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/WidgetToRenderBoxAdapter-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type WidgetToRenderBoxAdapter [<NamedParams>] (renderBox: RenderBox, [<Optional>] onBuild: (unit -> unit), [<Optional>] onUnmount: (unit -> unit)) =
  inherit LeafRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Listener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Listener [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] onPointerDown: (PointerDownEvent -> unit), [<Optional>] onPointerMove: (PointerMoveEvent -> unit), [<Optional>] onPointerUp: (PointerUpEvent -> unit), [<Optional>] onPointerHover: (PointerHoverEvent -> unit), [<Optional>] onPointerCancel: (PointerCancelEvent -> unit), [<Optional>] onPointerSignal: (PointerSignalEvent -> unit), [<Optional>] behavior: HitTestBehavior, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/MouseRegion-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type MouseRegion [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] onEnter: (PointerEnterEvent -> unit), [<Optional>] onExit: (PointerExitEvent -> unit), [<Optional>] onHover: (PointerHoverEvent -> unit), [<Optional>] cursor: MouseCursor, [<Optional>] opaque: bool, [<Optional>] hitTestBehavior: HitTestBehavior, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/RepaintBoundary-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RepaintBoundary [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()
  static member wrap(child: Widget, childIndex: int): RepaintBoundary = nativeOnly

/// https://api.flutter.dev/flutter/widgets/IgnorePointer-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IgnorePointer [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] ignoring: bool, [<Optional>] ignoringSemantics: bool, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/AbsorbPointer-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AbsorbPointer [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] absorbing: bool, [<Optional>] child: Widget, [<Optional>] ignoringSemantics: bool) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/MetaData-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type MetaData [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] metaData: obj, [<Optional>] behavior: HitTestBehavior, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Semantics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Semantics [<NamedParams>] ([<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] container: bool, [<Optional>] explicitChildNodes: bool, [<Optional>] excludeSemantics: bool, [<Optional>] enabled: bool, [<Optional>] ``checked``: bool, [<Optional>] selected: bool, [<Optional>] toggled: bool, [<Optional>] button: bool, [<Optional>] slider: bool, [<Optional>] keyboardKey: bool, [<Optional>] link: bool, [<Optional>] header: bool, [<Optional>] textField: bool, [<Optional>] readOnly: bool, [<Optional>] focusable: bool, [<Optional>] focused: bool, [<Optional>] inMutuallyExclusiveGroup: bool, [<Optional>] obscured: bool, [<Optional>] multiline: bool, [<Optional>] scopesRoute: bool, [<Optional>] namesRoute: bool, [<Optional>] hidden: bool, [<Optional>] image: bool, [<Optional>] liveRegion: bool, [<Optional>] maxValueLength: int, [<Optional>] currentValueLength: int, [<Optional>] label: string, [<Optional>] attributedLabel: AttributedString, [<Optional>] value: string, [<Optional>] attributedValue: AttributedString, [<Optional>] increasedValue: string, [<Optional>] attributedIncreasedValue: AttributedString, [<Optional>] decreasedValue: string, [<Optional>] attributedDecreasedValue: AttributedString, [<Optional>] hint: string, [<Optional>] attributedHint: AttributedString, [<Optional>] onTapHint: string, [<Optional>] onLongPressHint: string, [<Optional>] textDirection: TextDirection, [<Optional>] sortKey: SemanticsSortKey, [<Optional>] tagForChildren: SemanticsTag, [<Optional>] onTap: (unit -> unit), [<Optional>] onLongPress: (unit -> unit), [<Optional>] onScrollLeft: (unit -> unit), [<Optional>] onScrollRight: (unit -> unit), [<Optional>] onScrollUp: (unit -> unit), [<Optional>] onScrollDown: (unit -> unit), [<Optional>] onIncrease: (unit -> unit), [<Optional>] onDecrease: (unit -> unit), [<Optional>] onCopy: (unit -> unit), [<Optional>] onCut: (unit -> unit), [<Optional>] onPaste: (unit -> unit), [<Optional>] onDismiss: (unit -> unit), [<Optional>] onMoveCursorForwardByCharacter: (bool -> unit), [<Optional>] onMoveCursorBackwardByCharacter: (bool -> unit), [<Optional>] onSetSelection: (TextSelection -> unit), [<Optional>] onSetText: (string -> unit), [<Optional>] onDidGainAccessibilityFocus: (unit -> unit), [<Optional>] onDidLoseAccessibilityFocus: (unit -> unit), [<Optional>] customSemanticsActions: Dictionary<CustomSemanticsAction, (unit -> unit)>) =
  inherit SingleChildRenderObjectWidget()
  [<IsConst; NamedParams>] static member fromProperties(properties: SemanticsProperties, [<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] container: bool, [<Optional>] explicitChildNodes: bool, [<Optional>] excludeSemantics: bool): Semantics = nativeOnly

/// https://api.flutter.dev/flutter/widgets/MergeSemantics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type MergeSemantics [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/BlockSemantics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BlockSemantics [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] blocking: bool, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ExcludeSemantics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExcludeSemantics [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] excluding: bool, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/IndexedSemantics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IndexedSemantics [<IsConst; NamedParams>] (index: int, [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/KeyedSubtree-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type KeyedSubtree [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key) =
  inherit Widget()
  static member wrap(child: Widget, childIndex: int): KeyedSubtree = nativeOnly

/// https://api.flutter.dev/flutter/widgets/Builder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Builder [<IsConst; NamedParams>] (builder: (BuildContext -> Widget), [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/StatefulBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type StatefulBuilder [<IsConst; NamedParams>] (builder: (BuildContext -> ((unit -> unit) -> unit) -> Widget), [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ColoredBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ColoredBox [<IsConst; NamedParams>] (color: Color, [<Optional>] child: Widget, [<Optional>] key: Key) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/WidgetsBindingObserver-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type WidgetsBindingObserver () =
  class end

// /// https://api.flutter.dev/flutter/widgets/RenderObjectToWidgetAdapter-class.html
// [<ImportMember("package:flutter/widgets.dart")>]
// type RenderObjectToWidgetAdapter<'T> [<NamedParams>] (container: RenderObjectWithChildMixin<'T>, [<Optional>] child: Widget, [<Optional>] debugShortDescription: string) =
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
type BottomNavigationBarItem [<IsConst; NamedParams>] (icon: Widget, [<Optional>] label: string, [<Optional>] activeIcon: Widget, [<Optional>] backgroundColor: Color, [<Optional>] tooltip: string) =
  class end

/// https://api.flutter.dev/flutter/widgets/ColorFiltered-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ColorFiltered [<IsConst; NamedParams>] (colorFilter: ColorFilter, [<Optional>] child: Widget, [<Optional>] key: Key) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/DecoratedBox-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DecoratedBox [<IsConst; NamedParams>] (decoration: Decoration, [<Optional>] key: Key, [<Optional>] position: DecorationPosition, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Container-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Container [<NamedParams>] ([<Optional>] key: Key, [<Optional>] alignment: AlignmentGeometry, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] color: Color, [<Optional>] decoration: Decoration, [<Optional>] foregroundDecoration: Decoration, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] constraints: BoxConstraints, [<Optional>] margin: EdgeInsetsGeometry, [<Optional>] transform: Matrix4, [<Optional>] transformAlignment: AlignmentGeometry, [<Optional>] child: Widget, [<Optional>] clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/DefaultTextEditingShortcuts-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DefaultTextEditingShortcuts [<NamedParams>] (child: Widget, [<Optional>] key: Key) =
  inherit Shortcuts(nativeOnly, child)

/// https://api.flutter.dev/flutter/widgets/DesktopTextSelectionToolbarLayoutDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DesktopTextSelectionToolbarLayoutDelegate [<NamedParams>] (anchor: Offset) =
  inherit SingleChildLayoutDelegate()

/// https://api.flutter.dev/flutter/widgets/Dismissible-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Dismissible [<IsConst; NamedParams>] (key: Key, child: Widget, [<Optional>] background: Widget, [<Optional>] secondaryBackground: Widget, [<Optional>] confirmDismiss: (DismissDirection -> Future<DartNullable<bool>>), [<Optional>] onResize: (unit -> unit), [<Optional>] onUpdate: (DismissUpdateDetails -> unit), [<Optional>] onDismissed: (DismissDirection -> unit), [<Optional>] direction: DismissDirection, [<Optional>] resizeDuration: TimeSpan, [<Optional>] dismissThresholds: Dictionary<DismissDirection, float>, [<Optional>] movementDuration: TimeSpan, [<Optional>] crossAxisEndOffset: float, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] behavior: HitTestBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/DismissUpdateDetails-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DismissUpdateDetails [<NamedParams>] ([<Optional>] direction: DismissDirection, [<Optional>] reached: bool, [<Optional>] previousReached: bool, [<Optional>] progress: float) =
  class end

/// https://api.flutter.dev/flutter/widgets/DisplayFeatureSubScreen-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DisplayFeatureSubScreen [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] anchorPoint: Offset) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/DisposableBuildContext-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DisposableBuildContext<'T> (_state: 'T) =
  class end

/// https://api.flutter.dev/flutter/widgets/Draggable-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Draggable<'T> [<IsConst; NamedParams>] (child: Widget, feedback: Widget, [<Optional>] key: Key, [<Optional>] data: 'T, [<Optional>] axis: Axis, [<Optional>] childWhenDragging: Widget, [<Optional>] feedbackOffset: Offset, [<Optional>] dragAnchor: DragAnchor, [<Optional>] dragAnchorStrategy: (Draggable<obj> -> BuildContext -> Offset -> Offset), [<Optional>] affinity: Axis, [<Optional>] maxSimultaneousDrags: int, [<Optional>] onDragStarted: (unit -> unit), [<Optional>] onDragUpdate: (DragUpdateDetails -> unit), [<Optional>] onDraggableCanceled: (Velocity -> Offset -> unit), [<Optional>] onDragEnd: (DraggableDetails -> unit), [<Optional>] onDragCompleted: (unit -> unit), [<Optional>] ignoringFeedbackSemantics: bool, [<Optional>] rootOverlay: bool, [<Optional>] hitTestBehavior: HitTestBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/LongPressDraggable-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LongPressDraggable<'T> [<IsConst; NamedParams>] (child: Widget, feedback: Widget, [<Optional>] key: Key, [<Optional>] data: 'T, [<Optional>] axis: Axis, [<Optional>] childWhenDragging: Widget, [<Optional>] feedbackOffset: Offset, [<Optional>] dragAnchor: DragAnchor, [<Optional>] dragAnchorStrategy: (Draggable<obj> -> BuildContext -> Offset -> Offset), [<Optional>] maxSimultaneousDrags: int, [<Optional>] onDragStarted: (unit -> unit), [<Optional>] onDragUpdate: (DragUpdateDetails -> unit), [<Optional>] onDraggableCanceled: (Velocity -> Offset -> unit), [<Optional>] onDragEnd: (DraggableDetails -> unit), [<Optional>] onDragCompleted: (unit -> unit), [<Optional>] hapticFeedbackOnStart: bool, [<Optional>] ignoringFeedbackSemantics: bool, [<Optional>] delay: TimeSpan) =
  inherit Draggable<'T>(child, feedback)

/// https://api.flutter.dev/flutter/widgets/DraggableDetails-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DraggableDetails [<NamedParams>] (velocity: Velocity, offset: Offset, [<Optional>] wasAccepted: bool) =
  class end

/// https://api.flutter.dev/flutter/widgets/DragTargetDetails-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DragTargetDetails<'T> [<NamedParams>] (data: 'T, offset: Offset) =
  class end

/// https://api.flutter.dev/flutter/widgets/DragTarget-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DragTarget<'T> [<IsConst; NamedParams>] (builder: (BuildContext -> DartNullable<'T>[] -> obj[] -> Widget), [<Optional>] key: Key, [<Optional>] onWillAccept: (DartNullable<'T> -> bool), [<Optional>] onAccept: ('T -> unit), [<Optional>] onAcceptWithDetails: (DragTargetDetails<'T> -> unit), [<Optional>] onLeave: (DartNullable<'T> -> unit), [<Optional>] onMove: (DragTargetDetails<'T> -> unit), [<Optional>] hitTestBehavior: HitTestBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/DraggableScrollableController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DraggableScrollableController () =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/widgets/DraggableScrollableSheet-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DraggableScrollableSheet [<IsConst; NamedParams>] (builder: (BuildContext -> ScrollController -> Widget), [<Optional>] key: Key, [<Optional>] initialChildSize: float, [<Optional>] minChildSize: float, [<Optional>] maxChildSize: float, [<Optional>] expand: bool, [<Optional>] snap: bool, [<Optional>] snapSizes: float[], [<Optional>] controller: DraggableScrollableController) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/DraggableScrollableNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DraggableScrollableNotification [<NamedParams>] (extent: float, minExtent: float, maxExtent: float, initialExtent: float, context: BuildContext) =
  inherit Notification()

/// https://api.flutter.dev/flutter/widgets/DraggableScrollableActuator-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DraggableScrollableActuator [<NamedParams>] (child: Widget, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/DualTransitionBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DualTransitionBuilder [<IsConst; NamedParams>] (animation: Animation<float>, forwardBuilder: (BuildContext -> Animation<float> -> DartNullable<Widget> -> Widget), reverseBuilder: (BuildContext -> Animation<float> -> DartNullable<Widget> -> Widget), [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/TextEditingController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TextEditingController [<NamedParams>] ([<Optional>] text: string) =
  inherit ValueNotifier<TextEditingValue>(nativeOnly)
  static member fromValue(value: DartNullable<TextEditingValue>): TextEditingController = nativeOnly
  member _.text with get(): string = nativeOnly and set(_: string): unit = nativeOnly
  member _.clear(): unit = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ToolbarOptions-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ToolbarOptions [<IsConst; NamedParams>] ([<Optional>] copy: bool, [<Optional>] cut: bool, [<Optional>] paste: bool, [<Optional>] selectAll: bool) =
  class end

/// https://api.flutter.dev/flutter/widgets/EditableText-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type EditableText [<NamedParams>] (controller: TextEditingController, focusNode: FocusNode, style: TextStyle, cursorColor: Color, backgroundCursorColor: Color, [<Optional>] key: Key, [<Optional>] readOnly: bool, [<Optional>] obscuringCharacter: string, [<Optional>] obscureText: bool, [<Optional>] autocorrect: bool, [<Optional>] smartDashesType: SmartDashesType, [<Optional>] smartQuotesType: SmartQuotesType, [<Optional>] enableSuggestions: bool, [<Optional>] strutStyle: StrutStyle, [<Optional>] textAlign: TextAlign, [<Optional>] textDirection: TextDirection, [<Optional>] locale: Locale, [<Optional>] textScaleFactor: float, [<Optional>] maxLines: int, [<Optional>] minLines: int, [<Optional>] expands: bool, [<Optional>] forceLine: bool, [<Optional>] textHeightBehavior: TextHeightBehavior, [<Optional>] textWidthBasis: TextWidthBasis, [<Optional>] autofocus: bool, [<Optional>] showCursor: bool, [<Optional>] showSelectionHandles: bool, [<Optional>] selectionColor: Color, [<Optional>] selectionControls: TextSelectionControls, [<Optional>] keyboardType: TextInputType, [<Optional>] textInputAction: TextInputAction, [<Optional>] textCapitalization: TextCapitalization, [<Optional>] onChanged: (string -> unit), [<Optional>] onEditingComplete: (unit -> unit), [<Optional>] onSubmitted: (string -> unit), [<Optional>] onAppPrivateCommand: (string -> Dictionary<string, obj> -> unit), [<Optional>] onSelectionChanged: (TextSelection -> DartNullable<SelectionChangedCause> -> unit), [<Optional>] onSelectionHandleTapped: (unit -> unit), [<Optional>] inputFormatters: TextInputFormatter[], [<Optional>] mouseCursor: MouseCursor, [<Optional>] rendererIgnoresPointer: bool, [<Optional>] cursorWidth: float, [<Optional>] cursorHeight: float, [<Optional>] cursorRadius: Radius, [<Optional>] cursorOpacityAnimates: bool, [<Optional>] cursorOffset: Offset, [<Optional>] paintCursorAboveText: bool, [<Optional>] selectionHeightStyle: BoxHeightStyle, [<Optional>] selectionWidthStyle: BoxWidthStyle, [<Optional>] scrollPadding: EdgeInsets, [<Optional>] keyboardAppearance: Brightness, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] enableInteractiveSelection: bool, [<Optional>] scrollController: ScrollController, [<Optional>] scrollPhysics: ScrollPhysics, [<Optional>] autocorrectionTextRectColor: Color, [<Optional>] toolbarOptions: ToolbarOptions, [<Optional>] autofillHints: string seq, [<Optional>] autofillClient: AutofillClient, [<Optional>] clipBehavior: Clip, [<Optional>] restorationId: string, [<Optional>] scrollBehavior: ScrollBehavior, [<Optional>] scribbleEnabled: bool, [<Optional>] enableIMEPersonalizedLearning: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/EditableTextState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type EditableTextState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/FadeInImage-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FadeInImage [<IsConst; NamedParams>] (placeholder: ImageProvider<obj>, image: ImageProvider<obj>, [<Optional>] key: Key, [<Optional>] placeholderErrorBuilder: (BuildContext -> obj -> DartNullable<StackTrace> -> Widget), [<Optional>] imageErrorBuilder: (BuildContext -> obj -> DartNullable<StackTrace> -> Widget), [<Optional>] excludeFromSemantics: bool, [<Optional>] imageSemanticLabel: string, [<Optional>] fadeOutDuration: TimeSpan, [<Optional>] fadeOutCurve: Curve, [<Optional>] fadeInDuration: TimeSpan, [<Optional>] fadeInCurve: Curve, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] fit: BoxFit, [<Optional>] placeholderFit: BoxFit, [<Optional>] alignment: AlignmentGeometry, [<Optional>] repeat: ImageRepeat, [<Optional>] matchTextDirection: bool) =
  inherit Widget()
  [<NamedParams>] static member memoryNetwork(placeholder: byte[], image: string, [<Optional>] key: Key, [<Optional>] placeholderErrorBuilder: (BuildContext -> obj -> DartNullable<StackTrace> -> Widget), [<Optional>] imageErrorBuilder: (BuildContext -> obj -> DartNullable<StackTrace> -> Widget), [<Optional>] placeholderScale: float, [<Optional>] imageScale: float, [<Optional>] excludeFromSemantics: bool, [<Optional>] imageSemanticLabel: string, [<Optional>] fadeOutDuration: TimeSpan, [<Optional>] fadeOutCurve: Curve, [<Optional>] fadeInDuration: TimeSpan, [<Optional>] fadeInCurve: Curve, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] fit: BoxFit, [<Optional>] placeholderFit: BoxFit, [<Optional>] alignment: AlignmentGeometry, [<Optional>] repeat: ImageRepeat, [<Optional>] matchTextDirection: bool, [<Optional>] placeholderCacheWidth: int, [<Optional>] placeholderCacheHeight: int, [<Optional>] imageCacheWidth: int, [<Optional>] imageCacheHeight: int): FadeInImage = nativeOnly
  [<NamedParams>] static member assetNetwork(placeholder: string, image: string, [<Optional>] key: Key, [<Optional>] placeholderErrorBuilder: (BuildContext -> obj -> DartNullable<StackTrace> -> Widget), [<Optional>] imageErrorBuilder: (BuildContext -> obj -> DartNullable<StackTrace> -> Widget), [<Optional>] bundle: AssetBundle, [<Optional>] placeholderScale: float, [<Optional>] imageScale: float, [<Optional>] excludeFromSemantics: bool, [<Optional>] imageSemanticLabel: string, [<Optional>] fadeOutDuration: TimeSpan, [<Optional>] fadeOutCurve: Curve, [<Optional>] fadeInDuration: TimeSpan, [<Optional>] fadeInCurve: Curve, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] fit: BoxFit, [<Optional>] placeholderFit: BoxFit, [<Optional>] alignment: AlignmentGeometry, [<Optional>] repeat: ImageRepeat, [<Optional>] matchTextDirection: bool, [<Optional>] placeholderCacheWidth: int, [<Optional>] placeholderCacheHeight: int, [<Optional>] imageCacheWidth: int, [<Optional>] imageCacheHeight: int): FadeInImage = nativeOnly

/// https://api.flutter.dev/flutter/widgets/FocusAttachment-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusAttachment =
  class end

/// https://api.flutter.dev/flutter/widgets/FocusNode-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusNode [<NamedParams>] ([<Optional>] debugLabel: string, [<Optional>] onKey: (FocusNode -> RawKeyEvent -> KeyEventResult), [<Optional>] onKeyEvent: (FocusNode -> KeyEvent -> KeyEventResult), [<Optional>] skipTraversal: bool, [<Optional>] canRequestFocus: bool, [<Optional>] descendantsAreFocusable: bool, [<Optional>] descendantsAreTraversable: bool) =
  class end

/// https://api.flutter.dev/flutter/widgets/FocusScopeNode-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusScopeNode [<NamedParams>] ([<Optional>] debugLabel: string, [<Optional>] onKeyEvent: (FocusNode -> KeyEvent -> KeyEventResult), [<Optional>] onKey: (FocusNode -> RawKeyEvent -> KeyEventResult), [<Optional>] skipTraversal: bool, [<Optional>] canRequestFocus: bool) =
  inherit FocusNode()

/// https://api.flutter.dev/flutter/widgets/FocusManager-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusManager () =
  class end

/// https://api.flutter.dev/flutter/widgets/Focus-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Focus [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] focusNode: FocusNode, [<Optional>] autofocus: bool, [<Optional>] onFocusChange: (bool -> unit), [<Optional>] onKeyEvent: (FocusNode -> KeyEvent -> KeyEventResult), [<Optional>] onKey: (FocusNode -> RawKeyEvent -> KeyEventResult), [<Optional>] canRequestFocus: bool, [<Optional>] skipTraversal: bool, [<Optional>] descendantsAreFocusable: bool, [<Optional>] descendantsAreTraversable: bool, [<Optional>] includeSemantics: bool, [<Optional>] debugLabel: string) =
  inherit Widget()
  [<IsConst; NamedParams>] static member withExternalFocusNode(child: Widget, focusNode: FocusNode, [<Optional>] key: Key, [<Optional>] autofocus: bool, [<Optional>] onFocusChange: (bool -> unit), [<Optional>] includeSemantics: bool): Focus = nativeOnly

/// https://api.flutter.dev/flutter/widgets/FocusScope-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusScope [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] node: FocusScopeNode, [<Optional>] autofocus: bool, [<Optional>] onFocusChange: (bool -> unit), [<Optional>] canRequestFocus: bool, [<Optional>] skipTraversal: bool, [<Optional>] onKeyEvent: (FocusNode -> KeyEvent -> KeyEventResult), [<Optional>] onKey: (FocusNode -> RawKeyEvent -> KeyEventResult), [<Optional>] debugLabel: string) =
  inherit Focus(child)
  [<IsConst; NamedParams>] static member withExternalFocusNode(child: Widget, focusScopeNode: FocusScopeNode, [<Optional>] key: Key, [<Optional>] autofocus: bool, [<Optional>] onFocusChange: (bool -> unit)): FocusScope = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ExcludeFocus-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExcludeFocus [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] excluding: bool) =
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
type OrderedTraversalPolicy [<NamedParams>] ([<Optional>] secondary: FocusTraversalPolicy) =
  inherit FocusTraversalPolicy()

/// https://api.flutter.dev/flutter/widgets/FocusTraversalOrder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusTraversalOrder [<IsConst; NamedParams>] (order: FocusOrder, child: Widget, [<Optional>] key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/FocusTraversalGroup-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusTraversalGroup [<NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] policy: FocusTraversalPolicy, [<Optional>] descendantsAreFocusable: bool, [<Optional>] descendantsAreTraversable: bool) =
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
type DirectionalFocusIntent [<IsConst; NamedParams(fromIndex=1)>] (direction: TraversalDirection, [<Optional>] ignoreTextFields: bool) =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/DirectionalFocusAction-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DirectionalFocusAction () =
  inherit Action<DirectionalFocusIntent>()
  static member forTextField(): DirectionalFocusAction = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ExcludeFocusTraversal-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ExcludeFocusTraversal [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] excluding: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Form-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Form [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] onWillPop: (unit -> Future<bool>), [<Optional>] onChanged: (unit -> unit), [<Optional>] autovalidateMode: AutovalidateMode) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/FormState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FormState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/FormField-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FormField<'T> [<IsConst; NamedParams>] (builder: (FormFieldState<'T> -> Widget), [<Optional>] key: Key, [<Optional>] onSaved: (DartNullable<'T> -> unit), [<Optional>] validator: (DartNullable<'T> -> DartNullable<string>), [<Optional>] initialValue: 'T, [<Optional>] enabled: bool, [<Optional>] autovalidateMode: AutovalidateMode, [<Optional>] restorationId: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/FormFieldState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FormFieldState<'T> () =
  interface State

/// https://api.flutter.dev/flutter/widgets/ObjectKey-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ObjectKey [<IsConst>] (value: DartNullable<obj>) =
  inherit LocalKey()

/// https://api.flutter.dev/flutter/widgets/GlobalKey-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type GlobalKey<'T> [<NamedParams>] ([<Optional>] debugLabel: string) =
  inherit Key("")
  [<IsConst>] static member constructor(): GlobalKey<'T> = nativeOnly

/// https://api.flutter.dev/flutter/widgets/LabeledGlobalKey-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LabeledGlobalKey<'T> (_debugLabel: DartNullable<string>) =
  inherit GlobalKey<'T>()

/// https://api.flutter.dev/flutter/widgets/GlobalObjectKey-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type GlobalObjectKey<'T> [<IsConst>] (value: obj) =
  inherit GlobalKey<'T>()

/// https://api.flutter.dev/flutter/widgets/Widget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type Widget [<IsConst; NamedParams>] ([<Optional>] key: Key) =
  inherit DiagnosticableTree()

/// https://api.flutter.dev/flutter/widgets/StatelessWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type StatelessWidget [<IsConst; NamedParams>] ([<Optional>] key: Key) =
  inherit Widget()
  abstract build: BuildContext -> Widget

/// https://api.flutter.dev/flutter/widgets/StatefulWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type StatefulWidget [<IsConst; NamedParams>] ([<Optional>] key: Key) =
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
type ProxyWidget [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ParentDataWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ParentDataWidget<'T> [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key) =
  inherit ProxyWidget(child)

/// https://api.flutter.dev/flutter/widgets/InheritedWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type InheritedWidget [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key) =
  inherit ProxyWidget(child)

/// https://api.flutter.dev/flutter/widgets/RenderObjectWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type RenderObjectWidget [<IsConst; NamedParams>] ([<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/LeafRenderObjectWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type LeafRenderObjectWidget [<IsConst; NamedParams>] ([<Optional>] key: Key) =
  inherit RenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SingleChildRenderObjectWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type SingleChildRenderObjectWidget [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit RenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/MultiChildRenderObjectWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type MultiChildRenderObjectWidget [<NamedParams>] ([<Optional>] key: Key, [<Optional>] children: Widget[]) =
  inherit RenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/BuildContext-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type BuildContext () =
  class end

/// https://api.flutter.dev/flutter/widgets/BuildOwner-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BuildOwner [<NamedParams>] ([<Optional>] onBuildScheduled: (unit -> unit), [<Optional>] focusManager: FocusManager) =
  class end

/// https://api.flutter.dev/flutter/widgets/Element-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type Element (widget: Widget) =
  inherit DiagnosticableTree()

/// https://api.flutter.dev/flutter/widgets/ErrorWidget-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ErrorWidget (``exception``: obj) =
  inherit LeafRenderObjectWidget()
  [<NamedParams>] static member withDetails([<Optional>] message: string, [<Optional>] error: FlutterError): ErrorWidget = nativeOnly

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
type GestureDetector [<NamedParams>] ([<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] onTapDown: (TapDownDetails -> unit), [<Optional>] onTapUp: (TapUpDetails -> unit), [<Optional>] onTap: (unit -> unit), [<Optional>] onTapCancel: (unit -> unit), [<Optional>] onSecondaryTap: (unit -> unit), [<Optional>] onSecondaryTapDown: (TapDownDetails -> unit), [<Optional>] onSecondaryTapUp: (TapUpDetails -> unit), [<Optional>] onSecondaryTapCancel: (unit -> unit), [<Optional>] onTertiaryTapDown: (TapDownDetails -> unit), [<Optional>] onTertiaryTapUp: (TapUpDetails -> unit), [<Optional>] onTertiaryTapCancel: (unit -> unit), [<Optional>] onDoubleTapDown: (TapDownDetails -> unit), [<Optional>] onDoubleTap: (unit -> unit), [<Optional>] onDoubleTapCancel: (unit -> unit), [<Optional>] onLongPressDown: (LongPressDownDetails -> unit), [<Optional>] onLongPressCancel: (unit -> unit), [<Optional>] onLongPress: (unit -> unit), [<Optional>] onLongPressStart: (LongPressStartDetails -> unit), [<Optional>] onLongPressMoveUpdate: (LongPressMoveUpdateDetails -> unit), [<Optional>] onLongPressUp: (unit -> unit), [<Optional>] onLongPressEnd: (LongPressEndDetails -> unit), [<Optional>] onSecondaryLongPressDown: (LongPressDownDetails -> unit), [<Optional>] onSecondaryLongPressCancel: (unit -> unit), [<Optional>] onSecondaryLongPress: (unit -> unit), [<Optional>] onSecondaryLongPressStart: (LongPressStartDetails -> unit), [<Optional>] onSecondaryLongPressMoveUpdate: (LongPressMoveUpdateDetails -> unit), [<Optional>] onSecondaryLongPressUp: (unit -> unit), [<Optional>] onSecondaryLongPressEnd: (LongPressEndDetails -> unit), [<Optional>] onTertiaryLongPressDown: (LongPressDownDetails -> unit), [<Optional>] onTertiaryLongPressCancel: (unit -> unit), [<Optional>] onTertiaryLongPress: (unit -> unit), [<Optional>] onTertiaryLongPressStart: (LongPressStartDetails -> unit), [<Optional>] onTertiaryLongPressMoveUpdate: (LongPressMoveUpdateDetails -> unit), [<Optional>] onTertiaryLongPressUp: (unit -> unit), [<Optional>] onTertiaryLongPressEnd: (LongPressEndDetails -> unit), [<Optional>] onVerticalDragDown: (DragDownDetails -> unit), [<Optional>] onVerticalDragStart: (DragStartDetails -> unit), [<Optional>] onVerticalDragUpdate: (DragUpdateDetails -> unit), [<Optional>] onVerticalDragEnd: (DragEndDetails -> unit), [<Optional>] onVerticalDragCancel: (unit -> unit), [<Optional>] onHorizontalDragDown: (DragDownDetails -> unit), [<Optional>] onHorizontalDragStart: (DragStartDetails -> unit), [<Optional>] onHorizontalDragUpdate: (DragUpdateDetails -> unit), [<Optional>] onHorizontalDragEnd: (DragEndDetails -> unit), [<Optional>] onHorizontalDragCancel: (unit -> unit), [<Optional>] onForcePressStart: (ForcePressDetails -> unit), [<Optional>] onForcePressPeak: (ForcePressDetails -> unit), [<Optional>] onForcePressUpdate: (ForcePressDetails -> unit), [<Optional>] onForcePressEnd: (ForcePressDetails -> unit), [<Optional>] onPanDown: (DragDownDetails -> unit), [<Optional>] onPanStart: (DragStartDetails -> unit), [<Optional>] onPanUpdate: (DragUpdateDetails -> unit), [<Optional>] onPanEnd: (DragEndDetails -> unit), [<Optional>] onPanCancel: (unit -> unit), [<Optional>] onScaleStart: (ScaleStartDetails -> unit), [<Optional>] onScaleUpdate: (ScaleUpdateDetails -> unit), [<Optional>] onScaleEnd: (ScaleEndDetails -> unit), [<Optional>] behavior: HitTestBehavior, [<Optional>] excludeFromSemantics: bool, [<Optional>] dragStartBehavior: DragStartBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/RawGestureDetector-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawGestureDetector [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] gestures: Dictionary<Type, GestureRecognizerFactory<GestureRecognizer>>, [<Optional>] behavior: HitTestBehavior, [<Optional>] excludeFromSemantics: bool, [<Optional>] semantics: SemanticsGestureDelegate) =
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
type GridPaper [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] color: Color, [<Optional>] interval: float, [<Optional>] divisions: int, [<Optional>] subdivisions: int, [<Optional>] child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Hero-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Hero [<IsConst; NamedParams>] (tag: obj, child: Widget, [<Optional>] key: Key, [<Optional>] createRectTween: (DartNullable<Rect> -> DartNullable<Rect> -> Tween<DartNullable<Rect>>), [<Optional>] flightShuttleBuilder: (BuildContext -> Animation<float> -> HeroFlightDirection -> BuildContext -> BuildContext -> Widget), [<Optional>] placeholderBuilder: (BuildContext -> Size -> Widget -> Widget), [<Optional>] transitionOnUserGestures: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/HeroController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type HeroController [<NamedParams>] ([<Optional>] createRectTween: (DartNullable<Rect> -> DartNullable<Rect> -> Tween<DartNullable<Rect>>)) =
  inherit NavigatorObserver()

/// https://api.flutter.dev/flutter/widgets/HeroMode-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type HeroMode [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] enabled: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Icon-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Icon [<IsConst; NamedParams(fromIndex=1)>] (icon: IconData, [<Optional>] key: Key, [<Optional>] size: float, [<Optional>] color: Color, [<Optional>] semanticLabel: string, [<Optional>] textDirection: TextDirection, [<Optional>] shadows: Shadow[]) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/IconData-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IconData [<IsConst; NamedParams(fromIndex=1)>] (codePoint: int, [<Optional>] fontFamily: string, [<Optional>] fontPackage: string, [<Optional>] matchTextDirection: bool) =
  class end

/// https://api.flutter.dev/flutter/widgets/IconDataProperty-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IconDataProperty [<NamedParams(fromIndex=2)>] (name: string, value: DartNullable<IconData>, [<Optional>] ifNull: string, [<Optional>] showName: bool, [<Optional>] style: DiagnosticsTreeStyle, [<Optional>] level: DiagnosticLevel) =
  inherit DiagnosticsProperty<IconData>(DartNullable name, value)

/// https://api.flutter.dev/flutter/widgets/IconTheme-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IconTheme [<IsConst; NamedParams>] (data: IconThemeData, child: Widget, [<Optional>] key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/widgets/IconThemeData-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type IconThemeData [<IsConst; NamedParams>] ([<Optional>] color: Color, [<Optional>] opacity: float, [<Optional>] size: float, [<Optional>] shadows: Shadow[]) =
  [<IsConst>] static member fallback(): IconThemeData = nativeOnly

/// https://api.flutter.dev/flutter/widgets/Image-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Image [<IsConst; NamedParams>] (image: ImageProvider<obj>, [<Optional>] key: Key, [<Optional>] frameBuilder: (BuildContext -> Widget -> DartNullable<int> -> bool -> Widget), [<Optional>] loadingBuilder: (BuildContext -> Widget -> DartNullable<ImageChunkEvent> -> Widget), [<Optional>] errorBuilder: (BuildContext -> obj -> DartNullable<StackTrace> -> Widget), [<Optional>] semanticLabel: string, [<Optional>] excludeFromSemantics: bool, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] color: Color, [<Optional>] opacity: Animation<float>, [<Optional>] colorBlendMode: BlendMode, [<Optional>] fit: BoxFit, [<Optional>] alignment: AlignmentGeometry, [<Optional>] repeat: ImageRepeat, [<Optional>] centerSlice: Rect, [<Optional>] matchTextDirection: bool, [<Optional>] gaplessPlayback: bool, [<Optional>] isAntiAlias: bool, [<Optional>] filterQuality: FilterQuality) =
  inherit Widget()
  [<NamedParams(fromIndex=1)>] static member network(src: string, [<Optional>] key: Key, [<Optional>] scale: float, [<Optional>] frameBuilder: (BuildContext -> Widget -> DartNullable<int> -> bool -> Widget), [<Optional>] loadingBuilder: (BuildContext -> Widget -> DartNullable<ImageChunkEvent> -> Widget), [<Optional>] errorBuilder: (BuildContext -> obj -> DartNullable<StackTrace> -> Widget), [<Optional>] semanticLabel: string, [<Optional>] excludeFromSemantics: bool, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] color: Color, [<Optional>] opacity: Animation<float>, [<Optional>] colorBlendMode: BlendMode, [<Optional>] fit: BoxFit, [<Optional>] alignment: AlignmentGeometry, [<Optional>] repeat: ImageRepeat, [<Optional>] centerSlice: Rect, [<Optional>] matchTextDirection: bool, [<Optional>] gaplessPlayback: bool, [<Optional>] filterQuality: FilterQuality, [<Optional>] isAntiAlias: bool, [<Optional>] headers: Dictionary<string, string>, [<Optional>] cacheWidth: int, [<Optional>] cacheHeight: int): Image = nativeOnly
  // [<NamedParams(fromIndex=1)>] static member file(file: File, [<Optional>] key: Key, [<Optional>] scale: float, [<Optional>] frameBuilder: (BuildContext -> Widget -> DartNullable<int> -> bool -> Widget), [<Optional>] errorBuilder: (BuildContext -> obj -> DartNullable<StackTrace> -> Widget), [<Optional>] semanticLabel: string, [<Optional>] excludeFromSemantics: bool, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] color: Color, [<Optional>] opacity: Animation<float>, [<Optional>] colorBlendMode: BlendMode, [<Optional>] fit: BoxFit, [<Optional>] alignment: AlignmentGeometry, [<Optional>] repeat: ImageRepeat, [<Optional>] centerSlice: Rect, [<Optional>] matchTextDirection: bool, [<Optional>] gaplessPlayback: bool, [<Optional>] isAntiAlias: bool, [<Optional>] filterQuality: FilterQuality, [<Optional>] cacheWidth: int, [<Optional>] cacheHeight: int): Image = nativeOnly
  [<NamedParams(fromIndex=1)>] static member asset(name: string, [<Optional>] key: Key, [<Optional>] bundle: AssetBundle, [<Optional>] frameBuilder: (BuildContext -> Widget -> DartNullable<int> -> bool -> Widget), [<Optional>] errorBuilder: (BuildContext -> obj -> DartNullable<StackTrace> -> Widget), [<Optional>] semanticLabel: string, [<Optional>] excludeFromSemantics: bool, [<Optional>] scale: float, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] color: Color, [<Optional>] opacity: Animation<float>, [<Optional>] colorBlendMode: BlendMode, [<Optional>] fit: BoxFit, [<Optional>] alignment: AlignmentGeometry, [<Optional>] repeat: ImageRepeat, [<Optional>] centerSlice: Rect, [<Optional>] matchTextDirection: bool, [<Optional>] gaplessPlayback: bool, [<Optional>] isAntiAlias: bool, [<Optional>] package: string, [<Optional>] filterQuality: FilterQuality, [<Optional>] cacheWidth: int, [<Optional>] cacheHeight: int): Image = nativeOnly
  [<NamedParams(fromIndex=1)>] static member memory(bytes: byte[], [<Optional>] key: Key, [<Optional>] scale: float, [<Optional>] frameBuilder: (BuildContext -> Widget -> DartNullable<int> -> bool -> Widget), [<Optional>] errorBuilder: (BuildContext -> obj -> DartNullable<StackTrace> -> Widget), [<Optional>] semanticLabel: string, [<Optional>] excludeFromSemantics: bool, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] color: Color, [<Optional>] opacity: Animation<float>, [<Optional>] colorBlendMode: BlendMode, [<Optional>] fit: BoxFit, [<Optional>] alignment: AlignmentGeometry, [<Optional>] repeat: ImageRepeat, [<Optional>] centerSlice: Rect, [<Optional>] matchTextDirection: bool, [<Optional>] gaplessPlayback: bool, [<Optional>] isAntiAlias: bool, [<Optional>] filterQuality: FilterQuality, [<Optional>] cacheWidth: int, [<Optional>] cacheHeight: int): Image = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ImageFiltered-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ImageFiltered [<IsConst; NamedParams>] (imageFilter: ImageFilter, [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ImageIcon-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ImageIcon [<IsConst; NamedParams(fromIndex=1)>] (image: DartNullable<ImageProvider<obj>>, [<Optional>] key: Key, [<Optional>] size: float, [<Optional>] color: Color, [<Optional>] semanticLabel: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/BoxConstraintsTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BoxConstraintsTween [<NamedParams>] ([<Optional>] ``begin``: BoxConstraints, [<Optional>] ``end``: BoxConstraints) =
  inherit Tween<BoxConstraints>()

/// https://api.flutter.dev/flutter/widgets/DecorationTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DecorationTween [<NamedParams>] ([<Optional>] ``begin``: Decoration, [<Optional>] ``end``: Decoration) =
  inherit Tween<Decoration>()

/// https://api.flutter.dev/flutter/widgets/EdgeInsetsTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type EdgeInsetsTween [<NamedParams>] ([<Optional>] ``begin``: EdgeInsets, [<Optional>] ``end``: EdgeInsets) =
  inherit Tween<EdgeInsets>()

/// https://api.flutter.dev/flutter/widgets/EdgeInsetsGeometryTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type EdgeInsetsGeometryTween [<NamedParams>] ([<Optional>] ``begin``: EdgeInsetsGeometry, [<Optional>] ``end``: EdgeInsetsGeometry) =
  inherit Tween<EdgeInsetsGeometry>()

/// https://api.flutter.dev/flutter/widgets/BorderRadiusTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BorderRadiusTween [<NamedParams>] ([<Optional>] ``begin``: BorderRadius, [<Optional>] ``end``: BorderRadius) =
  inherit Tween<DartNullable<BorderRadius>>()

/// https://api.flutter.dev/flutter/widgets/BorderTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BorderTween [<NamedParams>] ([<Optional>] ``begin``: Border, [<Optional>] ``end``: Border) =
  inherit Tween<DartNullable<Border>>()

/// https://api.flutter.dev/flutter/widgets/Matrix4Tween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Matrix4Tween [<NamedParams>] ([<Optional>] ``begin``: Matrix4, [<Optional>] ``end``: Matrix4) =
  inherit Tween<Matrix4>()

/// https://api.flutter.dev/flutter/widgets/TextStyleTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TextStyleTween [<NamedParams>] ([<Optional>] ``begin``: TextStyle, [<Optional>] ``end``: TextStyle) =
  inherit Tween<TextStyle>()

/// https://api.flutter.dev/flutter/widgets/ImplicitlyAnimatedWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ImplicitlyAnimatedWidget [<IsConst; NamedParams>] (duration: TimeSpan, [<Optional>] key: Key, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit)) =
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
type AnimatedContainer [<NamedParams>] (duration: TimeSpan, [<Optional>] key: Key, [<Optional>] alignment: AlignmentGeometry, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] color: Color, [<Optional>] decoration: Decoration, [<Optional>] foregroundDecoration: Decoration, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] constraints: BoxConstraints, [<Optional>] margin: EdgeInsetsGeometry, [<Optional>] transform: Matrix4, [<Optional>] transformAlignment: AlignmentGeometry, [<Optional>] child: Widget, [<Optional>] clipBehavior: Clip, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedPadding-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedPadding [<NamedParams>] (padding: EdgeInsetsGeometry, duration: TimeSpan, [<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedAlign-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedAlign [<IsConst; NamedParams>] (alignment: AlignmentGeometry, duration: TimeSpan, [<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] heightFactor: float, [<Optional>] widthFactor: float, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedPositioned-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedPositioned [<IsConst; NamedParams>] (child: Widget, duration: TimeSpan, [<Optional>] key: Key, [<Optional>] left: float, [<Optional>] top: float, [<Optional>] right: float, [<Optional>] bottom: float, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)
  [<NamedParams>] static member fromRect(child: Widget, rect: Rect, duration: TimeSpan, [<Optional>] key: Key, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit)): AnimatedPositioned = nativeOnly

/// https://api.flutter.dev/flutter/widgets/AnimatedPositionedDirectional-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedPositionedDirectional [<IsConst; NamedParams>] (child: Widget, duration: TimeSpan, [<Optional>] key: Key, [<Optional>] start: float, [<Optional>] top: float, [<Optional>] ``end``: float, [<Optional>] bottom: float, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedScale-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedScale [<IsConst; NamedParams>] (scale: float, duration: TimeSpan, [<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] alignment: Alignment, [<Optional>] filterQuality: FilterQuality, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedRotation-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedRotation [<IsConst; NamedParams>] (turns: float, duration: TimeSpan, [<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] alignment: Alignment, [<Optional>] filterQuality: FilterQuality, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedSlide-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedSlide [<IsConst; NamedParams>] (offset: Offset, duration: TimeSpan, [<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedOpacity-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedOpacity [<IsConst; NamedParams>] (opacity: float, duration: TimeSpan, [<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit), [<Optional>] alwaysIncludeSemantics: bool) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/SliverAnimatedOpacity-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverAnimatedOpacity [<IsConst; NamedParams>] (opacity: float, duration: TimeSpan, [<Optional>] key: Key, [<Optional>] sliver: Widget, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit), [<Optional>] alwaysIncludeSemantics: bool) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedDefaultTextStyle-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedDefaultTextStyle [<IsConst; NamedParams>] (child: Widget, style: TextStyle, duration: TimeSpan, [<Optional>] key: Key, [<Optional>] textAlign: TextAlign, [<Optional>] softWrap: bool, [<Optional>] overflow: TextOverflow, [<Optional>] maxLines: int, [<Optional>] textWidthBasis: TextWidthBasis, [<Optional>] textHeightBehavior: TextHeightBehavior, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/AnimatedPhysicalModel-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedPhysicalModel [<IsConst; NamedParams>] (child: Widget, shape: BoxShape, elevation: float, color: Color, shadowColor: Color, duration: TimeSpan, [<Optional>] key: Key, [<Optional>] clipBehavior: Clip, [<Optional>] borderRadius: BorderRadius, [<Optional>] animateColor: bool, [<Optional>] animateShadowColor: bool, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/InheritedModel-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type InheritedModel<'T> [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/InheritedModelElement-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type InheritedModelElement<'T> (widget: InheritedModel<'T>) =
  inherit InheritedElement(widget)

/// https://api.flutter.dev/flutter/widgets/InheritedNotifier-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type InheritedNotifier<'T> [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] notifier: 'T) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/InheritedTheme-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type InheritedTheme [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/CapturedThemes-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CapturedThemes =
  class end

/// https://api.flutter.dev/flutter/widgets/InteractiveViewer-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type InteractiveViewer [<NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] clipBehavior: Clip, [<Optional>] alignPanAxis: bool, [<Optional>] boundaryMargin: EdgeInsets, [<Optional>] constrained: bool, [<Optional>] maxScale: float, [<Optional>] minScale: float, [<Optional>] onInteractionEnd: (ScaleEndDetails -> unit), [<Optional>] onInteractionStart: (ScaleStartDetails -> unit), [<Optional>] onInteractionUpdate: (ScaleUpdateDetails -> unit), [<Optional>] panEnabled: bool, [<Optional>] scaleEnabled: bool, [<Optional>] scaleFactor: float, [<Optional>] transformationController: TransformationController) =
  inherit Widget()
  [<NamedParams>] static member builder(builder: (BuildContext -> Quad -> Widget), [<Optional>] key: Key, [<Optional>] clipBehavior: Clip, [<Optional>] alignPanAxis: bool, [<Optional>] boundaryMargin: EdgeInsets, [<Optional>] maxScale: float, [<Optional>] minScale: float, [<Optional>] onInteractionEnd: (ScaleEndDetails -> unit), [<Optional>] onInteractionStart: (ScaleStartDetails -> unit), [<Optional>] onInteractionUpdate: (ScaleUpdateDetails -> unit), [<Optional>] panEnabled: bool, [<Optional>] scaleEnabled: bool, [<Optional>] scaleFactor: float, [<Optional>] transformationController: TransformationController): InteractiveViewer = nativeOnly

/// https://api.flutter.dev/flutter/widgets/TransformationController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TransformationController ([<Optional>] value: Matrix4) =
  inherit ValueNotifier<Matrix4>(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/KeyboardListener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type KeyboardListener [<IsConst; NamedParams>] (focusNode: FocusNode, child: Widget, [<Optional>] key: Key, [<Optional>] autofocus: bool, [<Optional>] includeSemantics: bool, [<Optional>] onKeyEvent: (KeyEvent -> unit)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ConstrainedLayoutBuilder-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ConstrainedLayoutBuilder<'ConstraintType> [<IsConst; NamedParams>] (builder: (BuildContext -> 'ConstraintType -> Widget), [<Optional>] key: Key) =
  inherit RenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/LayoutBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LayoutBuilder [<IsConst; NamedParams>] (builder: (BuildContext -> BoxConstraints -> Widget), [<Optional>] key: Key) =
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
type ListWheelChildBuilderDelegate [<NamedParams>] (builder: (BuildContext -> int -> DartNullable<Widget>), [<Optional>] childCount: int) =
  inherit ListWheelChildDelegate()

/// https://api.flutter.dev/flutter/widgets/FixedExtentScrollController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FixedExtentScrollController [<NamedParams>] ([<Optional>] initialItem: int) =
  inherit ScrollController()

/// https://api.flutter.dev/flutter/widgets/FixedExtentMetrics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FixedExtentMetrics [<NamedParams>] (minScrollExtent: DartNullable<float>, maxScrollExtent: DartNullable<float>, pixels: DartNullable<float>, viewportDimension: DartNullable<float>, axisDirection: AxisDirection, itemIndex: int) =
  inherit FixedScrollMetrics(minScrollExtent, maxScrollExtent, pixels, viewportDimension, axisDirection)

/// https://api.flutter.dev/flutter/widgets/FixedExtentScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FixedExtentScrollPhysics [<IsConst; NamedParams>] ([<Optional>] parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/ListWheelScrollView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ListWheelScrollView [<NamedParams>] (itemExtent: float, children: Widget[], [<Optional>] key: Key, [<Optional>] controller: ScrollController, [<Optional>] physics: ScrollPhysics, [<Optional>] diameterRatio: float, [<Optional>] perspective: float, [<Optional>] offAxisFraction: float, [<Optional>] useMagnifier: bool, [<Optional>] magnification: float, [<Optional>] overAndUnderCenterOpacity: float, [<Optional>] squeeze: float, [<Optional>] onSelectedItemChanged: (int -> unit), [<Optional>] renderChildrenOutsideViewport: bool, [<Optional>] clipBehavior: Clip, [<Optional>] restorationId: string, [<Optional>] scrollBehavior: ScrollBehavior) =
  inherit Widget()
  [<IsConst; NamedParams>] static member useDelegate(itemExtent: float, childDelegate: ListWheelChildDelegate, [<Optional>] key: Key, [<Optional>] controller: ScrollController, [<Optional>] physics: ScrollPhysics, [<Optional>] diameterRatio: float, [<Optional>] perspective: float, [<Optional>] offAxisFraction: float, [<Optional>] useMagnifier: bool, [<Optional>] magnification: float, [<Optional>] overAndUnderCenterOpacity: float, [<Optional>] squeeze: float, [<Optional>] onSelectedItemChanged: (int -> unit), [<Optional>] renderChildrenOutsideViewport: bool, [<Optional>] clipBehavior: Clip, [<Optional>] restorationId: string, [<Optional>] scrollBehavior: ScrollBehavior): ListWheelScrollView = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ListWheelElement-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ListWheelElement (widget: ListWheelViewport) =
  inherit RenderObjectElement(widget)

/// https://api.flutter.dev/flutter/widgets/ListWheelViewport-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ListWheelViewport [<IsConst; NamedParams>] (itemExtent: float, offset: ViewportOffset, childDelegate: ListWheelChildDelegate, [<Optional>] key: Key, [<Optional>] diameterRatio: float, [<Optional>] perspective: float, [<Optional>] offAxisFraction: float, [<Optional>] useMagnifier: bool, [<Optional>] magnification: float, [<Optional>] overAndUnderCenterOpacity: float, [<Optional>] squeeze: float, [<Optional>] renderChildrenOutsideViewport: bool, [<Optional>] clipBehavior: Clip) =
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
type Localizations [<NamedParams>] (locale: Locale, delegates: LocalizationsDelegate<obj>[], [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit Widget()
  [<NamedParams>] static member ``override``(context: BuildContext, [<Optional>] key: Key, [<Optional>] locale: Locale, [<Optional>] delegates: LocalizationsDelegate<obj>[], [<Optional>] child: Widget): Localizations = nativeOnly

/// https://api.flutter.dev/flutter/widgets/MediaQueryData-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type MediaQueryData [<IsConst; NamedParams>] ([<Optional>] size: Size, [<Optional>] devicePixelRatio: float, [<Optional>] textScaleFactor: float, [<Optional>] platformBrightness: Brightness, [<Optional>] padding: EdgeInsets, [<Optional>] viewInsets: EdgeInsets, [<Optional>] systemGestureInsets: EdgeInsets, [<Optional>] viewPadding: EdgeInsets, [<Optional>] alwaysUse24HourFormat: bool, [<Optional>] accessibleNavigation: bool, [<Optional>] invertColors: bool, [<Optional>] highContrast: bool, [<Optional>] disableAnimations: bool, [<Optional>] boldText: bool, [<Optional>] navigationMode: NavigationMode, [<Optional>] gestureSettings: DeviceGestureSettings, [<Optional>] displayFeatures: DisplayFeature[]) =
  static member fromWindow(window: FlutterView): MediaQueryData = nativeOnly

/// https://api.flutter.dev/flutter/widgets/MediaQuery-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type MediaQuery [<IsConst; NamedParams>] (data: MediaQueryData, child: Widget, [<Optional>] key: Key) =
  inherit InheritedWidget(child)
  [<NamedParams>] static member removePadding(context: BuildContext, child: Widget, [<Optional>] key: Key, [<Optional>] removeLeft: bool, [<Optional>] removeTop: bool, [<Optional>] removeRight: bool, [<Optional>] removeBottom: bool): MediaQuery = nativeOnly
  [<NamedParams>] static member removeViewInsets(context: BuildContext, child: Widget, [<Optional>] key: Key, [<Optional>] removeLeft: bool, [<Optional>] removeTop: bool, [<Optional>] removeRight: bool, [<Optional>] removeBottom: bool): MediaQuery = nativeOnly
  [<NamedParams>] static member removeViewPadding(context: BuildContext, child: Widget, [<Optional>] key: Key, [<Optional>] removeLeft: bool, [<Optional>] removeTop: bool, [<Optional>] removeRight: bool, [<Optional>] removeBottom: bool): MediaQuery = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ModalBarrier-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ModalBarrier [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] color: Color, [<Optional>] dismissible: bool, [<Optional>] onDismiss: (unit -> unit), [<Optional>] semanticsLabel: string, [<Optional>] barrierSemanticsDismissible: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AnimatedModalBarrier-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedModalBarrier [<IsConst; NamedParams>] (color: Animation<DartNullable<Color>>, [<Optional>] key: Key, [<Optional>] dismissible: bool, [<Optional>] semanticsLabel: string, [<Optional>] barrierSemanticsDismissible: bool) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/NavigationToolbar-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NavigationToolbar [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] leading: Widget, [<Optional>] middle: Widget, [<Optional>] trailing: Widget, [<Optional>] centerMiddle: bool, [<Optional>] middleSpacing: float) =
  inherit Widget()
  [<IsConst>] static member kMiddleSpacing: float = nativeOnly

/// https://api.flutter.dev/flutter/widgets/Route-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type Route<'T> [<NamedParams>] ([<Optional>] settings: RouteSettings) =
  class end

/// https://api.flutter.dev/flutter/widgets/RouteSettings-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RouteSettings [<IsConst; NamedParams>] ([<Optional>] name: string, [<Optional>] arguments: obj) =
  class end

/// https://api.flutter.dev/flutter/widgets/Page-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type Page<'T> [<IsConst; NamedParams>] ([<Optional>] key: LocalKey, [<Optional>] name: string, [<Optional>] arguments: obj, [<Optional>] restorationId: string) =
  inherit RouteSettings()

/// https://api.flutter.dev/flutter/widgets/NavigatorObserver-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NavigatorObserver () =
  class end

/// https://api.flutter.dev/flutter/widgets/HeroControllerScope-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type HeroControllerScope [<IsConst; NamedParams>] (controller: HeroController, child: Widget, [<Optional>] key: Key) =
  inherit InheritedWidget(child)
  [<IsConst; NamedParams>] static member none(child: Widget, [<Optional>] key: Key): HeroControllerScope = nativeOnly

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
type Navigator [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] pages: Page<obj>[], [<Optional>] onPopPage: (Route<obj> -> obj -> bool), [<Optional>] initialRoute: string, [<Optional>] onGenerateInitialRoutes: (NavigatorState -> string -> Route<obj>[]), [<Optional>] onGenerateRoute: (RouteSettings -> DartNullable<Route<obj>>), [<Optional>] onUnknownRoute: (RouteSettings -> DartNullable<Route<obj>>), [<Optional>] transitionDelegate: TransitionDelegate<obj>, [<Optional>] reportsRouteUpdateToEngine: bool, [<Optional>] observers: NavigatorObserver[], [<Optional>] requestFocus: bool, [<Optional>] restorationScopeId: string) =
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
type RestorableRouteFuture<'T> [<NamedParams>] (onPresent: (NavigatorState -> DartNullable<obj> -> string), [<Optional>] navigatorFinder: (BuildContext -> NavigatorState), [<Optional>] onComplete: ('T -> unit)) =
  inherit RestorableProperty<DartNullable<string>>()

/// https://api.flutter.dev/flutter/widgets/NestedScrollView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NestedScrollView [<IsConst; NamedParams>] (headerSliverBuilder: (BuildContext -> bool -> Widget[]), body: Widget, [<Optional>] key: Key, [<Optional>] controller: ScrollController, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] floatHeaderSlivers: bool, [<Optional>] clipBehavior: Clip, [<Optional>] restorationId: string, [<Optional>] scrollBehavior: ScrollBehavior) =
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
type SliverOverlapAbsorber [<IsConst; NamedParams>] (handle: SliverOverlapAbsorberHandle, [<Optional>] key: Key, [<Optional>] sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/RenderSliverOverlapAbsorber-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RenderSliverOverlapAbsorber [<NamedParams>] (handle: SliverOverlapAbsorberHandle, [<Optional>] sliver: RenderSliver) =
  inherit RenderSliver()

/// https://api.flutter.dev/flutter/widgets/SliverOverlapInjector-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverOverlapInjector [<IsConst; NamedParams>] (handle: SliverOverlapAbsorberHandle, [<Optional>] key: Key, [<Optional>] sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/RenderSliverOverlapInjector-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RenderSliverOverlapInjector [<NamedParams>] (handle: SliverOverlapAbsorberHandle) =
  inherit RenderSliver()

/// https://api.flutter.dev/flutter/widgets/NestedScrollViewViewport-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NestedScrollViewViewport [<NamedParams>] (offset: ViewportOffset, handle: SliverOverlapAbsorberHandle, [<Optional>] key: Key, [<Optional>] axisDirection: AxisDirection, [<Optional>] crossAxisDirection: AxisDirection, [<Optional>] anchor: float, [<Optional>] center: Key, [<Optional>] slivers: Widget[], [<Optional>] clipBehavior: Clip) =
  inherit Viewport(offset)

/// https://api.flutter.dev/flutter/widgets/RenderNestedScrollViewViewport-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RenderNestedScrollViewViewport [<NamedParams>] (crossAxisDirection: AxisDirection, offset: ViewportOffset, handle: SliverOverlapAbsorberHandle, [<Optional>] axisDirection: AxisDirection, [<Optional>] anchor: float, [<Optional>] children: RenderSliver[], [<Optional>] center: RenderSliver, [<Optional>] clipBehavior: Clip) =
  inherit RenderViewport(crossAxisDirection, offset)

/// https://api.flutter.dev/flutter/widgets/Notification-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type Notification [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/NotificationListener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NotificationListener<'T> [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] onNotification: ('T -> bool)) =
  inherit ProxyWidget(child)

/// https://api.flutter.dev/flutter/widgets/LayoutChangedNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LayoutChangedNotification [<IsConst>] () =
  inherit Notification()

/// https://api.flutter.dev/flutter/widgets/OrientationBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OrientationBuilder [<IsConst; NamedParams>] (builder: (BuildContext -> Orientation -> Widget), [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/OverflowBar-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OverflowBar [<NamedParams>] ([<Optional>] key: Key, [<Optional>] spacing: float, [<Optional>] alignment: MainAxisAlignment, [<Optional>] overflowSpacing: float, [<Optional>] overflowAlignment: OverflowBarAlignment, [<Optional>] overflowDirection: VerticalDirection, [<Optional>] textDirection: TextDirection, [<Optional>] clipBehavior: Clip, [<Optional>] children: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/OverlayEntry-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OverlayEntry [<NamedParams>] (builder: (BuildContext -> Widget), [<Optional>] opaque: bool, [<Optional>] maintainState: bool) =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/widgets/Overlay-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Overlay [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] initialEntries: OverlayEntry[], [<Optional>] clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/OverlayState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OverlayState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/GlowingOverscrollIndicator-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type GlowingOverscrollIndicator [<IsConst; NamedParams>] (axisDirection: AxisDirection, color: Color, [<Optional>] key: Key, [<Optional>] showLeading: bool, [<Optional>] showTrailing: bool, [<Optional>] notificationPredicate: (ScrollNotification -> bool), [<Optional>] child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/StretchingOverscrollIndicator-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type StretchingOverscrollIndicator [<IsConst; NamedParams>] (axisDirection: AxisDirection, [<Optional>] key: Key, [<Optional>] notificationPredicate: (ScrollNotification -> bool), [<Optional>] child: Widget) =
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
type PageStorage [<IsConst; NamedParams>] (bucket: PageStorageBucket, child: Widget, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/PageController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PageController [<NamedParams>] ([<Optional>] initialPage: int, [<Optional>] keepPage: bool, [<Optional>] viewportFraction: float) =
  inherit ScrollController()

/// https://api.flutter.dev/flutter/widgets/PageMetrics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PageMetrics [<NamedParams>] (minScrollExtent: DartNullable<float>, maxScrollExtent: DartNullable<float>, pixels: DartNullable<float>, viewportDimension: DartNullable<float>, axisDirection: AxisDirection, viewportFraction: float) =
  inherit FixedScrollMetrics(minScrollExtent, maxScrollExtent, pixels, viewportDimension, axisDirection)

/// https://api.flutter.dev/flutter/widgets/PageScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PageScrollPhysics [<IsConst; NamedParams>] ([<Optional>] parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/PageView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PageView [<NamedParams>] ([<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: PageController, [<Optional>] physics: ScrollPhysics, [<Optional>] pageSnapping: bool, [<Optional>] onPageChanged: (int -> unit), [<Optional>] children: Widget[], [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] allowImplicitScrolling: bool, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip, [<Optional>] scrollBehavior: ScrollBehavior, [<Optional>] padEnds: bool) =
  inherit Widget()
  [<NamedParams>] static member builder(itemBuilder: (BuildContext -> int -> Widget), [<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: PageController, [<Optional>] physics: ScrollPhysics, [<Optional>] pageSnapping: bool, [<Optional>] onPageChanged: (int -> unit), [<Optional>] findChildIndexCallback: (Key -> DartNullable<int>), [<Optional>] itemCount: int, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] allowImplicitScrolling: bool, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip, [<Optional>] scrollBehavior: ScrollBehavior, [<Optional>] padEnds: bool): PageView = nativeOnly
  [<NamedParams>] static member custom(childrenDelegate: SliverChildDelegate, [<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: PageController, [<Optional>] physics: ScrollPhysics, [<Optional>] pageSnapping: bool, [<Optional>] onPageChanged: (int -> unit), [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] allowImplicitScrolling: bool, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip, [<Optional>] scrollBehavior: ScrollBehavior, [<Optional>] padEnds: bool): PageView = nativeOnly

/// https://api.flutter.dev/flutter/widgets/PageRoute-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type PageRoute<'T> [<NamedParams>] ([<Optional>] settings: RouteSettings, [<Optional>] fullscreenDialog: bool) =
  inherit ModalRoute<'T>()

/// https://api.flutter.dev/flutter/widgets/PageRouteBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PageRouteBuilder<'T> [<NamedParams>] (pageBuilder: (BuildContext -> Animation<float> -> Animation<float> -> Widget), [<Optional>] settings: RouteSettings, [<Optional>] transitionsBuilder: (BuildContext -> Animation<float> -> Animation<float> -> Widget -> Widget), [<Optional>] transitionDuration: TimeSpan, [<Optional>] reverseTransitionDuration: TimeSpan, [<Optional>] opaque: bool, [<Optional>] barrierDismissible: bool, [<Optional>] barrierColor: Color, [<Optional>] barrierLabel: string, [<Optional>] maintainState: bool, [<Optional>] fullscreenDialog: bool) =
  inherit PageRoute<'T>()

/// https://api.flutter.dev/flutter/widgets/PerformanceOverlay-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PerformanceOverlay [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] optionsMask: int, [<Optional>] rasterizerThreshold: int, [<Optional>] checkerboardRasterCacheImages: bool, [<Optional>] checkerboardOffscreenLayers: bool) =
  inherit LeafRenderObjectWidget()
  [<NamedParams>] static member allEnabled([<Optional>] key: Key, [<Optional>] rasterizerThreshold: int, [<Optional>] checkerboardRasterCacheImages: bool, [<Optional>] checkerboardOffscreenLayers: bool): PerformanceOverlay = nativeOnly

/// https://api.flutter.dev/flutter/widgets/Placeholder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Placeholder [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] color: Color, [<Optional>] strokeWidth: float, [<Optional>] fallbackWidth: float, [<Optional>] fallbackHeight: float, [<Optional>] child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ShortcutSerialization-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ShortcutSerialization =
  static member character(character: string): ShortcutSerialization = nativeOnly
  [<NamedParams(fromIndex=1)>] static member modifier(trigger: LogicalKeyboardKey, [<Optional>] control: bool, [<Optional>] shift: bool, [<Optional>] alt: bool, [<Optional>] meta: bool): ShortcutSerialization = nativeOnly

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
type DefaultPlatformMenuDelegate [<NamedParams>] ([<Optional>] channel: MethodChannel) =
  inherit PlatformMenuDelegate()

/// https://api.flutter.dev/flutter/widgets/PlatformMenuBar-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformMenuBar [<IsConst; NamedParams>] (body: Widget, menus: MenuItem[], [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/PlatformMenu-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformMenu [<IsConst; NamedParams>] (label: string, menus: MenuItem[], [<Optional>] onOpen: (unit -> unit), [<Optional>] onClose: (unit -> unit)) =
  inherit MenuItem()

/// https://api.flutter.dev/flutter/widgets/PlatformMenuItemGroup-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformMenuItemGroup [<IsConst; NamedParams>] (members: MenuItem[]) =
  inherit MenuItem()

/// https://api.flutter.dev/flutter/widgets/PlatformMenuItem-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformMenuItem [<IsConst; NamedParams>] (label: string, [<Optional>] shortcut: MenuSerializableShortcut, [<Optional>] onSelected: (unit -> unit)) =
  inherit MenuItem()

/// https://api.flutter.dev/flutter/widgets/PlatformProvidedMenuItem-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformProvidedMenuItem [<IsConst; NamedParams>] (``type``: PlatformProvidedMenuItemType, [<Optional>] enabled: bool) =
  inherit PlatformMenuItem(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/AndroidView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AndroidView [<IsConst; NamedParams>] (viewType: string, [<Optional>] key: Key, [<Optional>] onPlatformViewCreated: (int -> unit), [<Optional>] hitTestBehavior: PlatformViewHitTestBehavior, [<Optional>] layoutDirection: TextDirection, [<Optional>] gestureRecognizers: HashSet<Factory<OneSequenceGestureRecognizer>>, [<Optional>] creationParams: obj, [<Optional>] creationParamsCodec: MessageCodec<obj>, [<Optional>] clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/UiKitView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type UiKitView [<IsConst; NamedParams>] (viewType: string, [<Optional>] key: Key, [<Optional>] onPlatformViewCreated: (int -> unit), [<Optional>] hitTestBehavior: PlatformViewHitTestBehavior, [<Optional>] layoutDirection: TextDirection, [<Optional>] creationParams: obj, [<Optional>] creationParamsCodec: MessageCodec<obj>, [<Optional>] gestureRecognizers: HashSet<Factory<OneSequenceGestureRecognizer>>) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/HtmlElementView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type HtmlElementView [<IsConst; NamedParams>] (viewType: string, [<Optional>] key: Key, [<Optional>] onPlatformViewCreated: (int -> unit)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/PlatformViewCreationParams-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformViewCreationParams =
  class end

/// https://api.flutter.dev/flutter/widgets/PlatformViewLink-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformViewLink [<IsConst; NamedParams>] (surfaceFactory: (BuildContext -> PlatformViewController -> Widget), onCreatePlatformView: (PlatformViewCreationParams -> PlatformViewController), viewType: string, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/PlatformViewSurface-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PlatformViewSurface [<IsConst; NamedParams>] (controller: PlatformViewController, hitTestBehavior: PlatformViewHitTestBehavior, gestureRecognizers: HashSet<Factory<OneSequenceGestureRecognizer>>, [<Optional>] key: Key) =
  inherit LeafRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/AndroidViewSurface-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AndroidViewSurface [<IsConst; NamedParams>] (controller: AndroidViewController, hitTestBehavior: PlatformViewHitTestBehavior, gestureRecognizers: HashSet<Factory<OneSequenceGestureRecognizer>>, [<Optional>] key: Key) =
  inherit PlatformViewSurface(nativeOnly, hitTestBehavior, gestureRecognizers)

/// https://api.flutter.dev/flutter/widgets/PreferredSizeWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type PreferredSizeWidget () =
  class end

/// https://api.flutter.dev/flutter/widgets/PreferredSize-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PreferredSize [<IsConst; NamedParams>] (child: Widget, preferredSize: Size, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/PrimaryScrollController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PrimaryScrollController [<IsConst; NamedParams>] (controller: ScrollController, child: Widget, [<Optional>] key: Key) =
  inherit InheritedWidget(child)
  [<IsConst; NamedParams>] static member none(child: Widget, [<Optional>] key: Key): PrimaryScrollController = nativeOnly

/// https://api.flutter.dev/flutter/widgets/RawKeyboardListener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawKeyboardListener [<IsConst; NamedParams>] (focusNode: FocusNode, child: Widget, [<Optional>] key: Key, [<Optional>] autofocus: bool, [<Optional>] includeSemantics: bool, [<Optional>] onKey: (RawKeyEvent -> unit)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ReorderableList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ReorderableList [<IsConst; NamedParams>] (itemBuilder: (BuildContext -> int -> Widget), itemCount: int, onReorder: (int -> int -> unit), [<Optional>] key: Key, [<Optional>] onReorderStart: (int -> unit), [<Optional>] onReorderEnd: (int -> unit), [<Optional>] itemExtent: float, [<Optional>] prototypeItem: Widget, [<Optional>] proxyDecorator: (Widget -> int -> Animation<float> -> Widget), [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] shrinkWrap: bool, [<Optional>] anchor: float, [<Optional>] cacheExtent: float, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ReorderableListState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ReorderableListState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/SliverReorderableList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverReorderableList [<IsConst; NamedParams>] (itemBuilder: (BuildContext -> int -> Widget), itemCount: int, onReorder: (int -> int -> unit), [<Optional>] key: Key, [<Optional>] findChildIndexCallback: (Key -> DartNullable<int>), [<Optional>] onReorderStart: (int -> unit), [<Optional>] onReorderEnd: (int -> unit), [<Optional>] itemExtent: float, [<Optional>] prototypeItem: Widget, [<Optional>] proxyDecorator: (Widget -> int -> Animation<float> -> Widget)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverReorderableListState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverReorderableListState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/ReorderableDragStartListener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ReorderableDragStartListener [<IsConst; NamedParams>] (child: Widget, index: int, [<Optional>] key: Key, [<Optional>] enabled: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ReorderableDelayedDragStartListener-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ReorderableDelayedDragStartListener [<IsConst; NamedParams>] (child: Widget, index: int, [<Optional>] key: Key, [<Optional>] enabled: bool) =
  inherit ReorderableDragStartListener(child, index)

/// https://api.flutter.dev/flutter/widgets/RestorationScope-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorationScope [<IsConst; NamedParams>] (restorationId: DartNullable<string>, child: Widget, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/UnmanagedRestorationScope-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type UnmanagedRestorationScope [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] bucket: RestorationBucket) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/RootRestorationScope-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RootRestorationScope [<IsConst; NamedParams>] (restorationId: DartNullable<string>, child: Widget, [<Optional>] key: Key) =
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
type RestorableBoolN (defaultValue: DartNullable<bool>) =
  class end

/// https://api.flutter.dev/flutter/widgets/RestorableNumN-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableNumN<'T> (defaultValue: 'T) =
  class end

/// https://api.flutter.dev/flutter/widgets/RestorableDoubleN-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableDoubleN (defaultValue: DartNullable<float>) =
  inherit RestorableNumN<DartNullable<float>>(defaultValue)

/// https://api.flutter.dev/flutter/widgets/RestorableIntN-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableIntN (defaultValue: DartNullable<int>) =
  inherit RestorableNumN<DartNullable<int>>(defaultValue)

/// https://api.flutter.dev/flutter/widgets/RestorableStringN-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableStringN (defaultValue: DartNullable<string>) =
  class end

/// https://api.flutter.dev/flutter/widgets/RestorableDateTime-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableDateTime (defaultValue: DateTime) =
  inherit RestorableValue<DateTime>()

/// https://api.flutter.dev/flutter/widgets/RestorableDateTimeN-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RestorableDateTimeN (defaultValue: DartNullable<DateTime>) =
  inherit RestorableValue<DartNullable<DateTime>>()

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
type RestorableTextEditingController [<NamedParams>] ([<Optional>] text: string) =
  inherit RestorableChangeNotifier<TextEditingController>()
  static member fromValue(value: TextEditingValue): RestorableTextEditingController = nativeOnly

/// https://api.flutter.dev/flutter/widgets/RouteInformation-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RouteInformation [<IsConst; NamedParams>] ([<Optional>] location: string, [<Optional>] state: obj) =
  class end

/// https://api.flutter.dev/flutter/widgets/Router-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Router<'T> [<IsConst; NamedParams>] (routerDelegate: RouterDelegate<'T>, [<Optional>] key: Key, [<Optional>] routeInformationProvider: RouteInformationProvider, [<Optional>] routeInformationParser: RouteInformationParser<'T>, [<Optional>] backButtonDispatcher: BackButtonDispatcher, [<Optional>] restorationScopeId: string) =
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
type BackButtonListener [<IsConst; NamedParams>] (child: Widget, onBackButtonPressed: (unit -> Future<bool>), [<Optional>] key: Key) =
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
type OverlayRoute<'T> [<NamedParams>] ([<Optional>] settings: RouteSettings) =
  inherit Route<'T>()

/// https://api.flutter.dev/flutter/widgets/TransitionRoute-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type TransitionRoute<'T> [<NamedParams>] ([<Optional>] settings: RouteSettings) =
  inherit OverlayRoute<'T>()

/// https://api.flutter.dev/flutter/widgets/LocalHistoryEntry-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LocalHistoryEntry [<NamedParams>] ([<Optional>] onRemove: (unit -> unit)) =
  class end

/// https://api.flutter.dev/flutter/widgets/ModalRoute-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ModalRoute<'T> [<NamedParams>] ([<Optional>] settings: RouteSettings, [<Optional>] filter: ImageFilter) =
  inherit TransitionRoute<'T>()

/// https://api.flutter.dev/flutter/widgets/PopupRoute-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type PopupRoute<'T> [<NamedParams>] ([<Optional>] settings: RouteSettings, [<Optional>] filter: ImageFilter) =
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
type RawDialogRoute<'T> [<NamedParams>] (pageBuilder: (BuildContext -> Animation<float> -> Animation<float> -> Widget), [<Optional>] barrierDismissible: bool, [<Optional>] barrierColor: Color, [<Optional>] barrierLabel: string, [<Optional>] transitionDuration: TimeSpan, [<Optional>] transitionBuilder: (BuildContext -> Animation<float> -> Animation<float> -> Widget -> Widget), [<Optional>] settings: RouteSettings, [<Optional>] anchorPoint: Offset) =
  inherit PopupRoute<'T>()

/// https://api.flutter.dev/flutter/widgets/FocusTrap-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusTrap [<IsConst; NamedParams>] (focusScopeNode: FocusScopeNode, child: Widget, [<Optional>] key: Key) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/FocusTrapArea-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FocusTrapArea [<IsConst; NamedParams>] (focusNode: FocusNode, [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SafeArea-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SafeArea [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] left: bool, [<Optional>] top: bool, [<Optional>] right: bool, [<Optional>] bottom: bool, [<Optional>] minimum: EdgeInsets, [<Optional>] maintainBottomViewPadding: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverSafeArea-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverSafeArea [<IsConst; NamedParams>] (sliver: Widget, [<Optional>] key: Key, [<Optional>] left: bool, [<Optional>] top: bool, [<Optional>] right: bool, [<Optional>] bottom: bool, [<Optional>] minimum: EdgeInsets) =
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
type HoldScrollActivity [<NamedParams>] (``delegate``: ScrollActivityDelegate, [<Optional>] onHoldCanceled: (unit -> unit)) =
  inherit ScrollActivity(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/ScrollDragController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollDragController [<NamedParams>] (``delegate``: ScrollActivityDelegate, details: DragStartDetails, [<Optional>] onDragCanceled: (unit -> unit), [<Optional>] carriedVelocity: float, [<Optional>] motionStartDistanceThreshold: float) =
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
type ScrollBehavior [<IsConst; NamedParams>] ([<Optional>] androidOverscrollIndicator: AndroidOverscrollIndicator) =
  class end

/// https://api.flutter.dev/flutter/widgets/ScrollConfiguration-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollConfiguration [<IsConst; NamedParams>] (behavior: ScrollBehavior, child: Widget, [<Optional>] key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/widgets/ScrollContext-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ScrollContext () =
  class end

/// https://api.flutter.dev/flutter/widgets/ScrollController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollController [<NamedParams>] ([<Optional>] initialScrollOffset: float, [<Optional>] keepScrollOffset: bool, [<Optional>] debugLabel: string) =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/widgets/TrackingScrollController-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TrackingScrollController [<NamedParams>] ([<Optional>] initialScrollOffset: float, [<Optional>] keepScrollOffset: bool, [<Optional>] debugLabel: string) =
  inherit ScrollController()

/// https://api.flutter.dev/flutter/widgets/FixedScrollMetrics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FixedScrollMetrics [<NamedParams>] (minScrollExtent: DartNullable<float>, maxScrollExtent: DartNullable<float>, pixels: DartNullable<float>, viewportDimension: DartNullable<float>, axisDirection: AxisDirection) =
  class end

/// https://api.flutter.dev/flutter/widgets/ScrollNotification-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ScrollNotification [<NamedParams>] (metrics: ScrollMetrics, context: DartNullable<BuildContext>) =
  inherit LayoutChangedNotification()

/// https://api.flutter.dev/flutter/widgets/ScrollStartNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollStartNotification [<NamedParams>] (metrics: ScrollMetrics, context: DartNullable<BuildContext>, [<Optional>] dragDetails: DragStartDetails) =
  inherit ScrollNotification(metrics, context)

/// https://api.flutter.dev/flutter/widgets/ScrollUpdateNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollUpdateNotification [<NamedParams>] (metrics: ScrollMetrics, context: BuildContext, [<Optional>] dragDetails: DragUpdateDetails, [<Optional>] scrollDelta: float, [<Optional>] depth: int) =
  inherit ScrollNotification(metrics, DartNullable context)

/// https://api.flutter.dev/flutter/widgets/OverscrollNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type OverscrollNotification [<NamedParams>] (metrics: ScrollMetrics, context: BuildContext, overscroll: float, [<Optional>] dragDetails: DragUpdateDetails, [<Optional>] velocity: float) =
  inherit ScrollNotification(metrics, DartNullable context)

/// https://api.flutter.dev/flutter/widgets/ScrollEndNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollEndNotification [<NamedParams>] (metrics: ScrollMetrics, context: BuildContext, [<Optional>] dragDetails: DragEndDetails) =
  inherit ScrollNotification(metrics, DartNullable context)

/// https://api.flutter.dev/flutter/widgets/UserScrollNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type UserScrollNotification [<NamedParams>] (metrics: ScrollMetrics, context: BuildContext, direction: ScrollDirection) =
  inherit ScrollNotification(metrics, DartNullable context)

/// https://api.flutter.dev/flutter/widgets/ScrollNotificationObserver-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollNotificationObserver [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ScrollNotificationObserverState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollNotificationObserverState () =
  interface State

/// https://api.flutter.dev/flutter/widgets/ScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollPhysics [<IsConst; NamedParams>] ([<Optional>] parent: ScrollPhysics) =
  class end

/// https://api.flutter.dev/flutter/widgets/RangeMaintainingScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RangeMaintainingScrollPhysics [<IsConst; NamedParams>] ([<Optional>] parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/BouncingScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type BouncingScrollPhysics [<IsConst; NamedParams>] ([<Optional>] parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/ClampingScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ClampingScrollPhysics [<IsConst; NamedParams>] ([<Optional>] parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/AlwaysScrollableScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AlwaysScrollableScrollPhysics [<IsConst; NamedParams>] ([<Optional>] parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/NeverScrollableScrollPhysics-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type NeverScrollableScrollPhysics [<IsConst; NamedParams>] ([<Optional>] parent: ScrollPhysics) =
  inherit ScrollPhysics()

/// https://api.flutter.dev/flutter/widgets/ScrollPosition-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ScrollPosition [<NamedParams>] (physics: ScrollPhysics, context: ScrollContext, [<Optional>] keepScrollOffset: bool, [<Optional>] oldPosition: ScrollPosition, [<Optional>] debugLabel: string) =
  inherit ViewportOffset()

/// https://api.flutter.dev/flutter/widgets/ScrollMetricsNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollMetricsNotification [<NamedParams>] (metrics: ScrollMetrics, context: BuildContext) =
  inherit Notification()

/// https://api.flutter.dev/flutter/widgets/ScrollPositionWithSingleContext-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollPositionWithSingleContext [<NamedParams>] (physics: ScrollPhysics, context: ScrollContext, [<Optional>] initialPixels: float, [<Optional>] keepScrollOffset: bool, [<Optional>] oldPosition: ScrollPosition, [<Optional>] debugLabel: string) =
  inherit ScrollPosition(physics, context)

// /// https://api.flutter.dev/flutter/widgets/BouncingScrollSimulation-class.html
// [<ImportMember("package:flutter/widgets.dart")>]
// type BouncingScrollSimulation [<NamedParams>] (position: float, velocity: float, leadingExtent: float, trailingExtent: float, spring: SpringDescription, [<Optional>] tolerance: Tolerance) =
//   inherit Simulation()
//   [<IsConst>] static member maxSpringTransferVelocity: float = nativeOnly

// /// https://api.flutter.dev/flutter/widgets/ClampingScrollSimulation-class.html
// [<ImportMember("package:flutter/widgets.dart")>]
// type ClampingScrollSimulation [<NamedParams>] (position: float, velocity: float, [<Optional>] friction: float, [<Optional>] tolerance: Tolerance) =
//   inherit Simulation()

/// https://api.flutter.dev/flutter/widgets/ScrollView-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ScrollView [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] scrollBehavior: ScrollBehavior, [<Optional>] shrinkWrap: bool, [<Optional>] center: Key, [<Optional>] anchor: float, [<Optional>] cacheExtent: float, [<Optional>] semanticChildCount: int, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/CustomScrollView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CustomScrollView [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] scrollBehavior: ScrollBehavior, [<Optional>] shrinkWrap: bool, [<Optional>] center: Key, [<Optional>] anchor: float, [<Optional>] cacheExtent: float, [<Optional>] slivers: Widget[], [<Optional>] semanticChildCount: int, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip) =
  inherit ScrollView()

/// https://api.flutter.dev/flutter/widgets/BoxScrollView-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type BoxScrollView [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] shrinkWrap: bool, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] cacheExtent: float, [<Optional>] semanticChildCount: int, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip) =
  inherit ScrollView()

/// https://api.flutter.dev/flutter/widgets/ListView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ListView [<NamedParams>] ([<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] shrinkWrap: bool, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] itemExtent: float, [<Optional>] prototypeItem: Widget, [<Optional>] addAutomaticKeepAlives: bool, [<Optional>] addRepaintBoundaries: bool, [<Optional>] addSemanticIndexes: bool, [<Optional>] cacheExtent: float, [<Optional>] children: Widget[], [<Optional>] semanticChildCount: int, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip) =
  inherit BoxScrollView()
  [<NamedParams>] static member builder(itemBuilder: (BuildContext -> int -> Widget), [<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] shrinkWrap: bool, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] itemExtent: float, [<Optional>] prototypeItem: Widget, [<Optional>] findChildIndexCallback: (Key -> DartNullable<int>), [<Optional>] itemCount: int, [<Optional>] addAutomaticKeepAlives: bool, [<Optional>] addRepaintBoundaries: bool, [<Optional>] addSemanticIndexes: bool, [<Optional>] cacheExtent: float, [<Optional>] semanticChildCount: int, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip): ListView = nativeOnly
  [<NamedParams>] static member separated(itemBuilder: (BuildContext -> int -> Widget), separatorBuilder: (BuildContext -> int -> Widget), itemCount: int, [<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] shrinkWrap: bool, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] findChildIndexCallback: (Key -> DartNullable<int>), [<Optional>] addAutomaticKeepAlives: bool, [<Optional>] addRepaintBoundaries: bool, [<Optional>] addSemanticIndexes: bool, [<Optional>] cacheExtent: float, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip): ListView = nativeOnly
  [<IsConst; NamedParams>] static member custom(childrenDelegate: SliverChildDelegate, [<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] shrinkWrap: bool, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] itemExtent: float, [<Optional>] prototypeItem: Widget, [<Optional>] cacheExtent: float, [<Optional>] semanticChildCount: int, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip): ListView = nativeOnly

/// https://api.flutter.dev/flutter/widgets/GridView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type GridView [<NamedParams>] (gridDelegate: SliverGridDelegate, [<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] shrinkWrap: bool, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] addAutomaticKeepAlives: bool, [<Optional>] addRepaintBoundaries: bool, [<Optional>] addSemanticIndexes: bool, [<Optional>] cacheExtent: float, [<Optional>] children: Widget[], [<Optional>] semanticChildCount: int, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] clipBehavior: Clip, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, [<Optional>] restorationId: string) =
  inherit BoxScrollView()
  [<NamedParams>] static member builder(gridDelegate: SliverGridDelegate, itemBuilder: (BuildContext -> int -> Widget), [<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] shrinkWrap: bool, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] findChildIndexCallback: (Key -> DartNullable<int>), [<Optional>] itemCount: int, [<Optional>] addAutomaticKeepAlives: bool, [<Optional>] addRepaintBoundaries: bool, [<Optional>] addSemanticIndexes: bool, [<Optional>] cacheExtent: float, [<Optional>] semanticChildCount: int, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip): GridView = nativeOnly
  [<IsConst; NamedParams>] static member custom(gridDelegate: SliverGridDelegate, childrenDelegate: SliverChildDelegate, [<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] shrinkWrap: bool, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] cacheExtent: float, [<Optional>] semanticChildCount: int, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip): GridView = nativeOnly
  [<NamedParams>] static member count(crossAxisCount: int, [<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] shrinkWrap: bool, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] mainAxisSpacing: float, [<Optional>] crossAxisSpacing: float, [<Optional>] childAspectRatio: float, [<Optional>] addAutomaticKeepAlives: bool, [<Optional>] addRepaintBoundaries: bool, [<Optional>] addSemanticIndexes: bool, [<Optional>] cacheExtent: float, [<Optional>] children: Widget[], [<Optional>] semanticChildCount: int, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip): GridView = nativeOnly
  [<NamedParams>] static member extent(maxCrossAxisExtent: float, [<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] controller: ScrollController, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] shrinkWrap: bool, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] mainAxisSpacing: float, [<Optional>] crossAxisSpacing: float, [<Optional>] childAspectRatio: float, [<Optional>] addAutomaticKeepAlives: bool, [<Optional>] addRepaintBoundaries: bool, [<Optional>] addSemanticIndexes: bool, [<Optional>] cacheExtent: float, [<Optional>] children: Widget[], [<Optional>] semanticChildCount: int, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, [<Optional>] restorationId: string, [<Optional>] clipBehavior: Clip): GridView = nativeOnly

/// https://api.flutter.dev/flutter/widgets/Scrollable-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Scrollable [<IsConst; NamedParams>] (viewportBuilder: (BuildContext -> ViewportOffset -> Widget), [<Optional>] key: Key, [<Optional>] axisDirection: AxisDirection, [<Optional>] controller: ScrollController, [<Optional>] physics: ScrollPhysics, [<Optional>] incrementCalculator: (ScrollIncrementDetails -> float), [<Optional>] excludeFromSemantics: bool, [<Optional>] semanticChildCount: int, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] restorationId: string, [<Optional>] scrollBehavior: ScrollBehavior) =
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
type ScrollIntent [<IsConst; NamedParams>] (direction: AxisDirection, [<Optional>] ``type``: ScrollIncrementType) =
  inherit Intent()

/// https://api.flutter.dev/flutter/widgets/ScrollAction-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollAction () =
  inherit Action<ScrollIntent>()

/// https://api.flutter.dev/flutter/widgets/ScrollbarPainter-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScrollbarPainter [<NamedParams>] (color: Color, fadeoutOpacityAnimation: Animation<float>, [<Optional>] trackColor: Color, [<Optional>] trackBorderColor: Color, [<Optional>] textDirection: TextDirection, [<Optional>] thickness: float, [<Optional>] padding: EdgeInsets, [<Optional>] mainAxisMargin: float, [<Optional>] crossAxisMargin: float, [<Optional>] radius: Radius, [<Optional>] trackRadius: Radius, [<Optional>] shape: OutlinedBorder, [<Optional>] minLength: float, [<Optional>] minOverscrollLength: float, [<Optional>] scrollbarOrientation: ScrollbarOrientation, [<Optional>] ignorePointer: bool) =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/widgets/RawScrollbar-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawScrollbar [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] controller: ScrollController, [<Optional>] thumbVisibility: bool, [<Optional>] shape: OutlinedBorder, [<Optional>] radius: Radius, [<Optional>] thickness: float, [<Optional>] thumbColor: Color, [<Optional>] minThumbLength: float, [<Optional>] minOverscrollLength: float, [<Optional>] trackVisibility: bool, [<Optional>] trackRadius: Radius, [<Optional>] trackColor: Color, [<Optional>] trackBorderColor: Color, [<Optional>] fadeDuration: TimeSpan, [<Optional>] timeToFade: TimeSpan, [<Optional>] pressDuration: TimeSpan, [<Optional>] notificationPredicate: (ScrollNotification -> bool), [<Optional>] interactive: bool, [<Optional>] scrollbarOrientation: ScrollbarOrientation, [<Optional>] mainAxisMargin: float, [<Optional>] crossAxisMargin: float, [<Optional>] isAlwaysShown: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/RawScrollbarState-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RawScrollbarState<'T> () =
  interface State

/// https://api.flutter.dev/flutter/widgets/SemanticsDebugger-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SemanticsDebugger [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] labelStyle: TextStyle) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SharedAppData-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SharedAppData [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/KeySet-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type KeySet<'T> (key1: 'T, [<Optional>] key2: 'T, [<Optional>] key3: 'T, [<Optional>] key4: 'T) =
  static member fromSet(keys: HashSet<'T>): KeySet<'T> = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ShortcutActivator-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type ShortcutActivator [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/LogicalKeySet-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type LogicalKeySet (key1: LogicalKeyboardKey, [<Optional>] key2: LogicalKeyboardKey, [<Optional>] key3: LogicalKeyboardKey, [<Optional>] key4: LogicalKeyboardKey) =
  inherit KeySet<LogicalKeyboardKey>(key1)
  static member fromSet(keys: HashSet<LogicalKeyboardKey>): LogicalKeySet = nativeOnly

/// https://api.flutter.dev/flutter/widgets/ShortcutMapProperty-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ShortcutMapProperty [<NamedParams(fromIndex=2)>] (name: string, value: Dictionary<ShortcutActivator, Intent>, [<Optional>] showName: bool, [<Optional>] defaultValue: obj, [<Optional>] level: DiagnosticLevel, [<Optional>] description: string) =
  inherit DiagnosticsProperty<Dictionary<ShortcutActivator, Intent>>(DartNullable name, nativeOnly)

/// https://api.flutter.dev/flutter/widgets/SingleActivator-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SingleActivator [<IsConst; NamedParams(fromIndex=1)>] (trigger: LogicalKeyboardKey, [<Optional>] control: bool, [<Optional>] shift: bool, [<Optional>] alt: bool, [<Optional>] meta: bool, [<Optional>] includeRepeats: bool) =
  class end

/// https://api.flutter.dev/flutter/widgets/CharacterActivator-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CharacterActivator [<IsConst>] (character: string) =
  class end

/// https://api.flutter.dev/flutter/widgets/ShortcutManager-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ShortcutManager [<NamedParams>] ([<Optional>] shortcuts: Dictionary<ShortcutActivator, Intent>, [<Optional>] modal: bool) =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/widgets/Shortcuts-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Shortcuts [<IsConst; NamedParams>] (shortcuts: Dictionary<ShortcutActivator, Intent>, child: Widget, [<Optional>] key: Key, [<Optional>] manager: ShortcutManager, [<Optional>] debugLabel: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/CallbackShortcuts-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type CallbackShortcuts [<IsConst; NamedParams>] (bindings: Dictionary<ShortcutActivator, (unit -> unit)>, child: Widget, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SingleChildScrollView-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SingleChildScrollView [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] scrollDirection: Axis, [<Optional>] reverse: bool, [<Optional>] padding: EdgeInsetsGeometry, [<Optional>] primary: bool, [<Optional>] physics: ScrollPhysics, [<Optional>] controller: ScrollController, [<Optional>] child: Widget, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] clipBehavior: Clip, [<Optional>] restorationId: string, [<Optional>] keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SizeChangedLayoutNotification-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SizeChangedLayoutNotification [<IsConst>] () =
  inherit LayoutChangedNotification()

/// https://api.flutter.dev/flutter/widgets/SizeChangedLayoutNotifier-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SizeChangedLayoutNotifier [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverChildDelegate-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type SliverChildDelegate [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/SliverChildBuilderDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverChildBuilderDelegate [<IsConst; NamedParams(fromIndex=1)>] (builder: (BuildContext -> int -> DartNullable<Widget>), [<Optional>] findChildIndexCallback: (Key -> DartNullable<int>), [<Optional>] childCount: int, [<Optional>] addAutomaticKeepAlives: bool, [<Optional>] addRepaintBoundaries: bool, [<Optional>] addSemanticIndexes: bool, [<Optional>] semanticIndexCallback: (Widget -> int -> DartNullable<int>), [<Optional>] semanticIndexOffset: int) =
  inherit SliverChildDelegate()

/// https://api.flutter.dev/flutter/widgets/SliverChildListDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverChildListDelegate [<NamedParams(fromIndex=1)>] (children: Widget[], [<Optional>] addAutomaticKeepAlives: bool, [<Optional>] addRepaintBoundaries: bool, [<Optional>] addSemanticIndexes: bool, [<Optional>] semanticIndexCallback: (Widget -> int -> DartNullable<int>), [<Optional>] semanticIndexOffset: int) =
  inherit SliverChildDelegate()
  [<IsConst; NamedParams(fromIndex=1)>] static member ``fixed``(children: Widget[], [<Optional>] addAutomaticKeepAlives: bool, [<Optional>] addRepaintBoundaries: bool, [<Optional>] addSemanticIndexes: bool, [<Optional>] semanticIndexCallback: (Widget -> int -> DartNullable<int>), [<Optional>] semanticIndexOffset: int): SliverChildListDelegate = nativeOnly

/// https://api.flutter.dev/flutter/widgets/SliverWithKeepAliveWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type SliverWithKeepAliveWidget [<IsConst; NamedParams>] ([<Optional>] key: Key) =
  inherit RenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverMultiBoxAdaptorWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type SliverMultiBoxAdaptorWidget [<IsConst; NamedParams>] (``delegate``: SliverChildDelegate, [<Optional>] key: Key) =
  inherit SliverWithKeepAliveWidget()

/// https://api.flutter.dev/flutter/widgets/SliverList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverList [<IsConst; NamedParams>] (``delegate``: SliverChildDelegate, [<Optional>] key: Key) =
  inherit SliverMultiBoxAdaptorWidget(``delegate``)

/// https://api.flutter.dev/flutter/widgets/SliverFixedExtentList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverFixedExtentList [<IsConst; NamedParams>] (``delegate``: SliverChildDelegate, itemExtent: float, [<Optional>] key: Key) =
  inherit SliverMultiBoxAdaptorWidget(``delegate``)

/// https://api.flutter.dev/flutter/widgets/SliverGrid-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverGrid [<IsConst; NamedParams>] (``delegate``: SliverChildDelegate, gridDelegate: SliverGridDelegate, [<Optional>] key: Key) =
  inherit SliverMultiBoxAdaptorWidget(``delegate``)
  [<NamedParams>] static member count(crossAxisCount: int, [<Optional>] key: Key, [<Optional>] mainAxisSpacing: float, [<Optional>] crossAxisSpacing: float, [<Optional>] childAspectRatio: float, [<Optional>] children: Widget[]): SliverGrid = nativeOnly
  [<NamedParams>] static member extent(maxCrossAxisExtent: float, [<Optional>] key: Key, [<Optional>] mainAxisSpacing: float, [<Optional>] crossAxisSpacing: float, [<Optional>] childAspectRatio: float, [<Optional>] children: Widget[]): SliverGrid = nativeOnly

/// https://api.flutter.dev/flutter/widgets/SliverMultiBoxAdaptorElement-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverMultiBoxAdaptorElement [<NamedParams(fromIndex=1)>] (widget: SliverMultiBoxAdaptorWidget, [<Optional>] replaceMovedChildren: bool) =
  inherit RenderObjectElement(widget)

/// https://api.flutter.dev/flutter/widgets/SliverOpacity-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverOpacity [<IsConst; NamedParams>] (opacity: float, [<Optional>] key: Key, [<Optional>] alwaysIncludeSemantics: bool, [<Optional>] sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverIgnorePointer-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverIgnorePointer [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] ignoring: bool, [<Optional>] ignoringSemantics: bool, [<Optional>] sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverOffstage-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverOffstage [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] offstage: bool, [<Optional>] sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/KeepAlive-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type KeepAlive [<IsConst; NamedParams>] (keepAlive: bool, child: Widget, [<Optional>] key: Key) =
  inherit ParentDataWidget<KeepAliveParentDataMixin>(child)

/// https://api.flutter.dev/flutter/widgets/SliverFillViewport-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverFillViewport [<IsConst; NamedParams>] (``delegate``: SliverChildDelegate, [<Optional>] key: Key, [<Optional>] viewportFraction: float, [<Optional>] padEnds: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverFillRemaining-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverFillRemaining [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] child: Widget, [<Optional>] hasScrollBody: bool, [<Optional>] fillOverscroll: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverLayoutBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverLayoutBuilder [<IsConst; NamedParams>] (builder: (BuildContext -> SliverConstraints -> Widget), [<Optional>] key: Key) =
  inherit ConstrainedLayoutBuilder<SliverConstraints>(builder)

/// https://api.flutter.dev/flutter/widgets/SliverPersistentHeaderDelegate-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type SliverPersistentHeaderDelegate [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/widgets/SliverPersistentHeader-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverPersistentHeader [<IsConst; NamedParams>] (``delegate``: SliverPersistentHeaderDelegate, [<Optional>] key: Key, [<Optional>] pinned: bool, [<Optional>] floating: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverPrototypeExtentList-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverPrototypeExtentList [<IsConst; NamedParams>] (``delegate``: SliverChildDelegate, prototypeItem: Widget, [<Optional>] key: Key) =
  inherit SliverMultiBoxAdaptorWidget(``delegate``)

// /// https://api.flutter.dev/flutter/widgets/SlottedRenderObjectElement-class.html
// [<ImportMember("package:flutter/widgets.dart")>]
// type SlottedRenderObjectElement<'S> (widget: SlottedMultiChildRenderObjectWidgetMixin<'S>) =
//   inherit RenderObjectElement(widget)

/// https://api.flutter.dev/flutter/widgets/Spacer-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Spacer [<IsConst; NamedParams>] ([<Optional>] key: Key, [<Optional>] flex: int) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/StatusTransitionWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type StatusTransitionWidget [<IsConst; NamedParams>] (animation: Animation<float>, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/TableRow-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TableRow [<IsConst; NamedParams>] ([<Optional>] key: LocalKey, [<Optional>] decoration: Decoration, [<Optional>] children: Widget[]) =
  class end

/// https://api.flutter.dev/flutter/widgets/Table-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Table [<NamedParams>] ([<Optional>] key: Key, [<Optional>] children: TableRow[], [<Optional>] columnWidths: Dictionary<int, TableColumnWidth>, [<Optional>] defaultColumnWidth: TableColumnWidth, [<Optional>] textDirection: TextDirection, [<Optional>] border: TableBorder, [<Optional>] defaultVerticalAlignment: TableCellVerticalAlignment, [<Optional>] textBaseline: TextBaseline) =
  inherit RenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/TableCell-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TableCell [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] verticalAlignment: TableCellVerticalAlignment) =
  inherit ParentDataWidget<TableCellParentData>(child)

/// https://api.flutter.dev/flutter/widgets/DefaultTextStyle-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DefaultTextStyle [<IsConst; NamedParams>] (style: TextStyle, child: Widget, [<Optional>] key: Key, [<Optional>] textAlign: TextAlign, [<Optional>] softWrap: bool, [<Optional>] overflow: TextOverflow, [<Optional>] maxLines: int, [<Optional>] textWidthBasis: TextWidthBasis, [<Optional>] textHeightBehavior: TextHeightBehavior) =
  inherit InheritedTheme(child)
  [<IsConst; NamedParams>] static member fallback([<Optional>] key: Key): DefaultTextStyle = nativeOnly

/// https://api.flutter.dev/flutter/widgets/DefaultTextHeightBehavior-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DefaultTextHeightBehavior [<IsConst; NamedParams>] (textHeightBehavior: TextHeightBehavior, child: Widget, [<Optional>] key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/widgets/Text-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Text [<IsConst; NamedParams(fromIndex=1)>] (data: string, [<Optional>] key: Key, [<Optional>] style: TextStyle, [<Optional>] strutStyle: StrutStyle, [<Optional>] textAlign: TextAlign, [<Optional>] textDirection: TextDirection, [<Optional>] locale: Locale, [<Optional>] softWrap: bool, [<Optional>] overflow: TextOverflow, [<Optional>] textScaleFactor: float, [<Optional>] maxLines: int, [<Optional>] semanticsLabel: string, [<Optional>] textWidthBasis: TextWidthBasis, [<Optional>] textHeightBehavior: TextHeightBehavior) =
  inherit Widget()
  [<IsConst; NamedParams(fromIndex=1)>] static member rich(textSpan: InlineSpan, [<Optional>] key: Key, [<Optional>] style: TextStyle, [<Optional>] strutStyle: StrutStyle, [<Optional>] textAlign: TextAlign, [<Optional>] textDirection: TextDirection, [<Optional>] locale: Locale, [<Optional>] softWrap: bool, [<Optional>] overflow: TextOverflow, [<Optional>] textScaleFactor: float, [<Optional>] maxLines: int, [<Optional>] semanticsLabel: string, [<Optional>] textWidthBasis: TextWidthBasis, [<Optional>] textHeightBehavior: TextHeightBehavior): Text = nativeOnly

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
type DirectionalCaretMovementIntent [<IsConst>] (forward: bool, collapseSelection: bool, [<Optional>] collapseAtReversal: bool, [<Optional>] continuesAtWrap: bool) =
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
type ExtendSelectionToLineBreakIntent [<IsConst; NamedParams>] (forward: bool, collapseSelection: bool, [<Optional>] collapseAtReversal: bool, [<Optional>] continuesAtWrap: bool) =
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
type TextSelectionOverlay [<NamedParams>] (value: TextEditingValue, context: BuildContext, toolbarLayerLink: LayerLink, startHandleLayerLink: LayerLink, endHandleLayerLink: LayerLink, renderObject: RenderEditable, selectionDelegate: TextSelectionDelegate, [<Optional>] debugRequiredFor: Widget, [<Optional>] selectionControls: TextSelectionControls, [<Optional>] handlesVisible: bool, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] onSelectionHandleTapped: (unit -> unit), [<Optional>] clipboardStatus: ClipboardStatusNotifier) =
  [<IsConst>] static member fadeDuration: TimeSpan = nativeOnly

/// https://api.flutter.dev/flutter/widgets/SelectionOverlay-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SelectionOverlay [<NamedParams>] (context: BuildContext, startHandleType: TextSelectionHandleType, lineHeightAtStart: float, endHandleType: TextSelectionHandleType, lineHeightAtEnd: float, selectionEndPoints: TextSelectionPoint[], selectionControls: DartNullable<TextSelectionControls>, selectionDelegate: TextSelectionDelegate, clipboardStatus: DartNullable<ClipboardStatusNotifier>, startHandleLayerLink: LayerLink, endHandleLayerLink: LayerLink, toolbarLayerLink: LayerLink, [<Optional>] debugRequiredFor: Widget, [<Optional>] startHandlesVisible: ValueListenable<bool>, [<Optional>] onStartHandleDragStart: (DragStartDetails -> unit), [<Optional>] onStartHandleDragUpdate: (DragUpdateDetails -> unit), [<Optional>] onStartHandleDragEnd: (DragEndDetails -> unit), [<Optional>] endHandlesVisible: ValueListenable<bool>, [<Optional>] onEndHandleDragStart: (DragStartDetails -> unit), [<Optional>] onEndHandleDragUpdate: (DragUpdateDetails -> unit), [<Optional>] onEndHandleDragEnd: (DragEndDetails -> unit), [<Optional>] toolbarVisible: ValueListenable<bool>, [<Optional>] dragStartBehavior: DragStartBehavior, [<Optional>] onSelectionHandleTapped: (unit -> unit), [<Optional>] toolbarLocation: Offset) =
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
type TextSelectionGestureDetector [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] onTapDown: (TapDownDetails -> unit), [<Optional>] onForcePressStart: (ForcePressDetails -> unit), [<Optional>] onForcePressEnd: (ForcePressDetails -> unit), [<Optional>] onSecondaryTap: (unit -> unit), [<Optional>] onSecondaryTapDown: (TapDownDetails -> unit), [<Optional>] onSingleTapUp: (TapUpDetails -> unit), [<Optional>] onSingleTapCancel: (unit -> unit), [<Optional>] onSingleLongTapStart: (LongPressStartDetails -> unit), [<Optional>] onSingleLongTapMoveUpdate: (LongPressMoveUpdateDetails -> unit), [<Optional>] onSingleLongTapEnd: (LongPressEndDetails -> unit), [<Optional>] onDoubleTapDown: (TapDownDetails -> unit), [<Optional>] onDragSelectionStart: (DragStartDetails -> unit), [<Optional>] onDragSelectionUpdate: (DragStartDetails -> DragUpdateDetails -> unit), [<Optional>] onDragSelectionEnd: (DragEndDetails -> unit), [<Optional>] behavior: HitTestBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ClipboardStatusNotifier-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ClipboardStatusNotifier [<NamedParams>] ([<Optional>] value: ClipboardStatus) =
  inherit ValueNotifier<ClipboardStatus>(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/TextSelectionToolbarLayoutDelegate-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TextSelectionToolbarLayoutDelegate [<NamedParams>] (anchorAbove: Offset, anchorBelow: Offset, [<Optional>] fitsAbove: bool) =
  inherit SingleChildLayoutDelegate()

/// https://api.flutter.dev/flutter/widgets/Texture-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Texture [<IsConst; NamedParams>] (textureId: int, [<Optional>] key: Key, [<Optional>] freeze: bool, [<Optional>] filterQuality: FilterQuality) =
  inherit LeafRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/TickerMode-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TickerMode [<IsConst; NamedParams>] (enabled: bool, child: Widget, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Title-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Title [<NamedParams>] (color: Color, child: Widget, [<Optional>] key: Key, [<Optional>] title: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/AnimatedWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type AnimatedWidget [<IsConst; NamedParams>] (listenable: Listenable, [<Optional>] key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SlideTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SlideTransition [<IsConst; NamedParams>] (position: Animation<Offset>, [<Optional>] key: Key, [<Optional>] transformHitTests: bool, [<Optional>] textDirection: TextDirection, [<Optional>] child: Widget) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/ScaleTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ScaleTransition [<IsConst; NamedParams>] (scale: Animation<float>, [<Optional>] key: Key, [<Optional>] alignment: Alignment, [<Optional>] filterQuality: FilterQuality, [<Optional>] child: Widget) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/RotationTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RotationTransition [<IsConst; NamedParams>] (turns: Animation<float>, [<Optional>] key: Key, [<Optional>] alignment: Alignment, [<Optional>] filterQuality: FilterQuality, [<Optional>] child: Widget) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/SizeTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SizeTransition [<IsConst; NamedParams>] (sizeFactor: Animation<float>, [<Optional>] key: Key, [<Optional>] axis: Axis, [<Optional>] axisAlignment: float, [<Optional>] child: Widget) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/FadeTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type FadeTransition [<IsConst; NamedParams>] (opacity: Animation<float>, [<Optional>] key: Key, [<Optional>] alwaysIncludeSemantics: bool, [<Optional>] child: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/SliverFadeTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverFadeTransition [<IsConst; NamedParams>] (opacity: Animation<float>, [<Optional>] key: Key, [<Optional>] alwaysIncludeSemantics: bool, [<Optional>] sliver: Widget) =
  inherit SingleChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/RelativeRectTween-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RelativeRectTween [<NamedParams>] ([<Optional>] ``begin``: RelativeRect, [<Optional>] ``end``: RelativeRect) =
  inherit Tween<RelativeRect>()

/// https://api.flutter.dev/flutter/widgets/PositionedTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type PositionedTransition [<IsConst; NamedParams>] (rect: Animation<RelativeRect>, child: Widget, [<Optional>] key: Key) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/RelativePositionedTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type RelativePositionedTransition [<IsConst; NamedParams>] (rect: Animation<DartNullable<Rect>>, size: Size, child: Widget, [<Optional>] key: Key) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/DecoratedBoxTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DecoratedBoxTransition [<IsConst; NamedParams>] (decoration: Animation<Decoration>, child: Widget, [<Optional>] key: Key, [<Optional>] position: DecorationPosition) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/AlignTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AlignTransition [<IsConst; NamedParams>] (alignment: Animation<AlignmentGeometry>, child: Widget, [<Optional>] key: Key, [<Optional>] widthFactor: float, [<Optional>] heightFactor: float) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/DefaultTextStyleTransition-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type DefaultTextStyleTransition [<IsConst; NamedParams>] (style: Animation<TextStyle>, child: Widget, [<Optional>] key: Key, [<Optional>] textAlign: TextAlign, [<Optional>] softWrap: bool, [<Optional>] overflow: TextOverflow, [<Optional>] maxLines: int) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/AnimatedBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type AnimatedBuilder [<IsConst; NamedParams>] (animation: Listenable, builder: (BuildContext -> DartNullable<Widget> -> Widget), [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit AnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/widgets/TweenAnimationBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type TweenAnimationBuilder<'T> [<IsConst; NamedParams>] (tween: Tween<'T>, duration: TimeSpan, builder: (BuildContext -> 'T -> DartNullable<Widget> -> Widget), [<Optional>] key: Key, [<Optional>] curve: Curve, [<Optional>] onEnd: (unit -> unit), [<Optional>] child: Widget) =
  inherit ImplicitlyAnimatedWidget(duration)

/// https://api.flutter.dev/flutter/widgets/UniqueWidget-class.html
[<ImportMember("package:flutter/widgets.dart"); AbstractClass>]
type UniqueWidget<'T> [<IsConst; NamedParams>] (key: GlobalKey<'T>) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/ValueListenableBuilder-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ValueListenableBuilder<'T> [<IsConst; NamedParams>] (valueListenable: ValueListenable<'T>, builder: (BuildContext -> 'T -> DartNullable<Widget> -> Widget), [<Optional>] key: Key, [<Optional>] child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/Viewport-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Viewport [<NamedParams>] (offset: ViewportOffset, [<Optional>] key: Key, [<Optional>] axisDirection: AxisDirection, [<Optional>] crossAxisDirection: AxisDirection, [<Optional>] anchor: float, [<Optional>] center: Key, [<Optional>] cacheExtent: float, [<Optional>] cacheExtentStyle: CacheExtentStyle, [<Optional>] clipBehavior: Clip, [<Optional>] slivers: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/ShrinkWrappingViewport-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type ShrinkWrappingViewport [<NamedParams>] (offset: ViewportOffset, [<Optional>] key: Key, [<Optional>] axisDirection: AxisDirection, [<Optional>] crossAxisDirection: AxisDirection, [<Optional>] clipBehavior: Clip, [<Optional>] slivers: Widget[]) =
  inherit MultiChildRenderObjectWidget()

/// https://api.flutter.dev/flutter/widgets/Visibility-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type Visibility [<IsConst; NamedParams>] (child: Widget, [<Optional>] key: Key, [<Optional>] replacement: Widget, [<Optional>] visible: bool, [<Optional>] maintainState: bool, [<Optional>] maintainAnimation: bool, [<Optional>] maintainSize: bool, [<Optional>] maintainSemantics: bool, [<Optional>] maintainInteractivity: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/SliverVisibility-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type SliverVisibility [<IsConst; NamedParams>] (sliver: Widget, [<Optional>] key: Key, [<Optional>] replacementSliver: Widget, [<Optional>] visible: bool, [<Optional>] maintainState: bool, [<Optional>] maintainAnimation: bool, [<Optional>] maintainSize: bool, [<Optional>] maintainSemantics: bool, [<Optional>] maintainInteractivity: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/widgets/WidgetInspector-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type WidgetInspector [<IsConst; NamedParams>] (child: Widget, selectButtonBuilder: (BuildContext -> (unit -> unit) -> Widget), [<Optional>] key: Key) =
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
type InspectorSerializationDelegate [<NamedParams>] (service: WidgetInspectorService, [<Optional>] groupName: string, [<Optional>] summaryTree: bool, [<Optional>] maxDescendentsTruncatableNode: int, [<Optional>] expandPropertyValues: bool, [<Optional>] subtreeDepth: int, [<Optional>] includeProperties: bool, [<Optional>] addAdditionalPropertiesCallback: (DiagnosticsNode -> InspectorSerializationDelegate -> DartNullable<Dictionary<string, obj>>)) =
  class end

/// https://api.flutter.dev/flutter/widgets/WidgetSpan-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type WidgetSpan [<IsConst; NamedParams>] (child: Widget, [<Optional>] alignment: PlaceholderAlignment, [<Optional>] baseline: TextBaseline, [<Optional>] style: TextStyle) =
  inherit PlaceholderSpan()

/// https://api.flutter.dev/flutter/widgets/WillPopScope-class.html
[<ImportMember("package:flutter/widgets.dart")>]
type WillPopScope [<IsConst; NamedParams>] (child: Widget, onWillPop: (unit -> Future<bool>), [<Optional>] key: Key) =
  inherit Widget()

[<ImportAll("package:flutter/widgets.dart")>]
type Widgets =
  /// https://api.flutter.dev/flutter/widgets/basicLocaleListResolution.html
  static member basicLocaleListResolution(preferredLocales: DartNullable<Locale[]>, supportedLocales: Locale seq): Locale = nativeOnly
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
  [<NamedParams(fromIndex=1)>] static member debugCheckHasDirectionality(context: BuildContext, [<Optional>] why: string, [<Optional>] hint: string, [<Optional>] alternative: string): bool = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugWidgetBuilderValue.html
  static member debugWidgetBuilderValue(widget: Widget, built: DartNullable<Widget>): unit = nativeOnly
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
  [<NamedParams(fromIndex=1)>] static member createLocalImageConfiguration(context: BuildContext, [<Optional>] size: Size): ImageConfiguration = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/precacheImage.html
  [<NamedParams(fromIndex=2)>] static member precacheImage(provider: ImageProvider<obj>, context: BuildContext, [<Optional>] size: Size, [<Optional>] onError: (obj -> DartNullable<StackTrace> -> unit)): Future<unit> = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/showGeneralDialog.html
  [<NamedParams>] static member showGeneralDialog<'T>(context: BuildContext, pageBuilder: (BuildContext -> Animation<float> -> Animation<float> -> Widget), [<Optional>] barrierDismissible: bool, [<Optional>] barrierLabel: string, [<Optional>] barrierColor: Color, [<Optional>] transitionDuration: TimeSpan, [<Optional>] transitionBuilder: (BuildContext -> Animation<float> -> Animation<float> -> Widget -> Widget), [<Optional>] useRootNavigator: bool, [<Optional>] routeSettings: RouteSettings, [<Optional>] anchorPoint: Offset): Future<DartNullable<'T>> = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/defaultScrollNotificationPredicate.html
  static member defaultScrollNotificationPredicate(notification: ScrollNotification): bool = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugTransformDebugCreator.html
  static member debugTransformDebugCreator(properties: DiagnosticsNode seq): DiagnosticsNode seq = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugIsLocalCreationLocation.html
  static member debugIsLocalCreationLocation(object: obj): bool = nativeOnly
  /// https://api.flutter.dev/flutter/widgets/debugIsWidgetLocalCreation.html
  static member debugIsWidgetLocalCreation(widget: Widget): bool = nativeOnly
