namespace rec Flutter.Material

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
open Flutter.Widgets

/// https://api.flutter.dev/flutter/material/ThemeMode.html
[<ImportMember("package:flutter/material.dart")>]
type ThemeMode =
  [<IsConst>] static member system: ThemeMode = nativeOnly
  [<IsConst>] static member light: ThemeMode = nativeOnly
  [<IsConst>] static member dark: ThemeMode = nativeOnly
  [<IsConst>] static member values: ThemeMode = nativeOnly

/// https://api.flutter.dev/flutter/material/MaterialBannerClosedReason.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialBannerClosedReason =
  [<IsConst>] static member dismiss: MaterialBannerClosedReason = nativeOnly
  [<IsConst>] static member swipe: MaterialBannerClosedReason = nativeOnly
  [<IsConst>] static member hide: MaterialBannerClosedReason = nativeOnly
  [<IsConst>] static member remove: MaterialBannerClosedReason = nativeOnly
  [<IsConst>] static member values: MaterialBannerClosedReason = nativeOnly

/// https://api.flutter.dev/flutter/material/BottomNavigationBarType.html
[<ImportMember("package:flutter/material.dart")>]
type BottomNavigationBarType =
  [<IsConst>] static member ``fixed``: BottomNavigationBarType = nativeOnly
  [<IsConst>] static member shifting: BottomNavigationBarType = nativeOnly
  [<IsConst>] static member values: BottomNavigationBarType = nativeOnly

/// https://api.flutter.dev/flutter/material/BottomNavigationBarLandscapeLayout.html
[<ImportMember("package:flutter/material.dart")>]
type BottomNavigationBarLandscapeLayout =
  [<IsConst>] static member spread: BottomNavigationBarLandscapeLayout = nativeOnly
  [<IsConst>] static member centered: BottomNavigationBarLandscapeLayout = nativeOnly
  [<IsConst>] static member linear: BottomNavigationBarLandscapeLayout = nativeOnly
  [<IsConst>] static member values: BottomNavigationBarLandscapeLayout = nativeOnly

/// https://api.flutter.dev/flutter/material/ButtonTextTheme.html
[<ImportMember("package:flutter/material.dart")>]
type ButtonTextTheme =
  [<IsConst>] static member normal: ButtonTextTheme = nativeOnly
  [<IsConst>] static member accent: ButtonTextTheme = nativeOnly
  [<IsConst>] static member primary: ButtonTextTheme = nativeOnly
  [<IsConst>] static member values: ButtonTextTheme = nativeOnly

/// https://api.flutter.dev/flutter/material/ButtonBarLayoutBehavior.html
[<ImportMember("package:flutter/material.dart")>]
type ButtonBarLayoutBehavior =
  [<IsConst>] static member constrained: ButtonBarLayoutBehavior = nativeOnly
  [<IsConst>] static member padded: ButtonBarLayoutBehavior = nativeOnly
  [<IsConst>] static member values: ButtonBarLayoutBehavior = nativeOnly

/// https://api.flutter.dev/flutter/material/DatePickerEntryMode.html
[<ImportMember("package:flutter/material.dart")>]
type DatePickerEntryMode =
  [<IsConst>] static member calendar: DatePickerEntryMode = nativeOnly
  [<IsConst>] static member input: DatePickerEntryMode = nativeOnly
  [<IsConst>] static member calendarOnly: DatePickerEntryMode = nativeOnly
  [<IsConst>] static member inputOnly: DatePickerEntryMode = nativeOnly
  [<IsConst>] static member values: DatePickerEntryMode = nativeOnly

/// https://api.flutter.dev/flutter/material/DatePickerMode.html
[<ImportMember("package:flutter/material.dart")>]
type DatePickerMode =
  [<IsConst>] static member day: DatePickerMode = nativeOnly
  [<IsConst>] static member year: DatePickerMode = nativeOnly
  [<IsConst>] static member values: DatePickerMode = nativeOnly

/// https://api.flutter.dev/flutter/material/DrawerAlignment.html
[<ImportMember("package:flutter/material.dart")>]
type DrawerAlignment =
  [<IsConst>] static member start: DrawerAlignment = nativeOnly
  [<IsConst>] static member ``end``: DrawerAlignment = nativeOnly
  [<IsConst>] static member values: DrawerAlignment = nativeOnly

/// https://api.flutter.dev/flutter/material/CollapseMode.html
[<ImportMember("package:flutter/material.dart")>]
type CollapseMode =
  [<IsConst>] static member parallax: CollapseMode = nativeOnly
  [<IsConst>] static member pin: CollapseMode = nativeOnly
  [<IsConst>] static member none: CollapseMode = nativeOnly
  [<IsConst>] static member values: CollapseMode = nativeOnly

/// https://api.flutter.dev/flutter/material/StretchMode.html
[<ImportMember("package:flutter/material.dart")>]
type StretchMode =
  [<IsConst>] static member zoomBackground: StretchMode = nativeOnly
  [<IsConst>] static member blurBackground: StretchMode = nativeOnly
  [<IsConst>] static member fadeTitle: StretchMode = nativeOnly
  [<IsConst>] static member values: StretchMode = nativeOnly

/// https://api.flutter.dev/flutter/material/FloatingLabelBehavior.html
[<ImportMember("package:flutter/material.dart")>]
type FloatingLabelBehavior =
  [<IsConst>] static member never: FloatingLabelBehavior = nativeOnly
  [<IsConst>] static member auto: FloatingLabelBehavior = nativeOnly
  [<IsConst>] static member always: FloatingLabelBehavior = nativeOnly
  [<IsConst>] static member values: FloatingLabelBehavior = nativeOnly

/// https://api.flutter.dev/flutter/material/ListTileStyle.html
[<ImportMember("package:flutter/material.dart")>]
type ListTileStyle =
  [<IsConst>] static member list: ListTileStyle = nativeOnly
  [<IsConst>] static member drawer: ListTileStyle = nativeOnly
  [<IsConst>] static member values: ListTileStyle = nativeOnly

/// https://api.flutter.dev/flutter/material/ListTileControlAffinity.html
[<ImportMember("package:flutter/material.dart")>]
type ListTileControlAffinity =
  [<IsConst>] static member leading: ListTileControlAffinity = nativeOnly
  [<IsConst>] static member trailing: ListTileControlAffinity = nativeOnly
  [<IsConst>] static member platform: ListTileControlAffinity = nativeOnly
  [<IsConst>] static member values: ListTileControlAffinity = nativeOnly

/// https://api.flutter.dev/flutter/material/MaterialType.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialType =
  [<IsConst>] static member canvas: MaterialType = nativeOnly
  [<IsConst>] static member card: MaterialType = nativeOnly
  [<IsConst>] static member circle: MaterialType = nativeOnly
  [<IsConst>] static member button: MaterialType = nativeOnly
  [<IsConst>] static member transparency: MaterialType = nativeOnly
  [<IsConst>] static member values: MaterialType = nativeOnly

/// https://api.flutter.dev/flutter/material/MaterialState.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialState =
  [<IsConst>] static member hovered: MaterialState = nativeOnly
  [<IsConst>] static member focused: MaterialState = nativeOnly
  [<IsConst>] static member pressed: MaterialState = nativeOnly
  [<IsConst>] static member dragged: MaterialState = nativeOnly
  [<IsConst>] static member selected: MaterialState = nativeOnly
  [<IsConst>] static member scrolledUnder: MaterialState = nativeOnly
  [<IsConst>] static member disabled: MaterialState = nativeOnly
  [<IsConst>] static member error: MaterialState = nativeOnly
  [<IsConst>] static member values: MaterialState = nativeOnly

/// https://api.flutter.dev/flutter/material/NavigationDestinationLabelBehavior.html
[<ImportMember("package:flutter/material.dart")>]
type NavigationDestinationLabelBehavior =
  [<IsConst>] static member alwaysShow: NavigationDestinationLabelBehavior = nativeOnly
  [<IsConst>] static member alwaysHide: NavigationDestinationLabelBehavior = nativeOnly
  [<IsConst>] static member onlyShowSelected: NavigationDestinationLabelBehavior = nativeOnly
  [<IsConst>] static member values: NavigationDestinationLabelBehavior = nativeOnly

/// https://api.flutter.dev/flutter/material/NavigationRailLabelType.html
[<ImportMember("package:flutter/material.dart")>]
type NavigationRailLabelType =
  [<IsConst>] static member none: NavigationRailLabelType = nativeOnly
  [<IsConst>] static member selected: NavigationRailLabelType = nativeOnly
  [<IsConst>] static member all: NavigationRailLabelType = nativeOnly
  [<IsConst>] static member values: NavigationRailLabelType = nativeOnly

/// https://api.flutter.dev/flutter/material/PopupMenuPosition.html
[<ImportMember("package:flutter/material.dart")>]
type PopupMenuPosition =
  [<IsConst>] static member over: PopupMenuPosition = nativeOnly
  [<IsConst>] static member under: PopupMenuPosition = nativeOnly
  [<IsConst>] static member values: PopupMenuPosition = nativeOnly

/// https://api.flutter.dev/flutter/material/RefreshIndicatorTriggerMode.html
[<ImportMember("package:flutter/material.dart")>]
type RefreshIndicatorTriggerMode =
  [<IsConst>] static member anywhere: RefreshIndicatorTriggerMode = nativeOnly
  [<IsConst>] static member onEdge: RefreshIndicatorTriggerMode = nativeOnly
  [<IsConst>] static member values: RefreshIndicatorTriggerMode = nativeOnly

/// https://api.flutter.dev/flutter/material/ShowValueIndicator.html
[<ImportMember("package:flutter/material.dart")>]
type ShowValueIndicator =
  [<IsConst>] static member onlyForDiscrete: ShowValueIndicator = nativeOnly
  [<IsConst>] static member onlyForContinuous: ShowValueIndicator = nativeOnly
  [<IsConst>] static member always: ShowValueIndicator = nativeOnly
  [<IsConst>] static member never: ShowValueIndicator = nativeOnly
  [<IsConst>] static member values: ShowValueIndicator = nativeOnly

/// https://api.flutter.dev/flutter/material/Thumb.html
[<ImportMember("package:flutter/material.dart")>]
type Thumb =
  [<IsConst>] static member start: Thumb = nativeOnly
  [<IsConst>] static member ``end``: Thumb = nativeOnly
  [<IsConst>] static member values: Thumb = nativeOnly

/// https://api.flutter.dev/flutter/material/SnackBarClosedReason.html
[<ImportMember("package:flutter/material.dart")>]
type SnackBarClosedReason =
  [<IsConst>] static member action: SnackBarClosedReason = nativeOnly
  [<IsConst>] static member dismiss: SnackBarClosedReason = nativeOnly
  [<IsConst>] static member swipe: SnackBarClosedReason = nativeOnly
  [<IsConst>] static member hide: SnackBarClosedReason = nativeOnly
  [<IsConst>] static member remove: SnackBarClosedReason = nativeOnly
  [<IsConst>] static member timeout: SnackBarClosedReason = nativeOnly
  [<IsConst>] static member values: SnackBarClosedReason = nativeOnly

/// https://api.flutter.dev/flutter/material/SnackBarBehavior.html
[<ImportMember("package:flutter/material.dart")>]
type SnackBarBehavior =
  [<IsConst>] static member ``fixed``: SnackBarBehavior = nativeOnly
  [<IsConst>] static member floating: SnackBarBehavior = nativeOnly
  [<IsConst>] static member values: SnackBarBehavior = nativeOnly

/// https://api.flutter.dev/flutter/material/StepState.html
[<ImportMember("package:flutter/material.dart")>]
type StepState =
  [<IsConst>] static member indexed: StepState = nativeOnly
  [<IsConst>] static member editing: StepState = nativeOnly
  [<IsConst>] static member complete: StepState = nativeOnly
  [<IsConst>] static member disabled: StepState = nativeOnly
  [<IsConst>] static member error: StepState = nativeOnly
  [<IsConst>] static member values: StepState = nativeOnly

/// https://api.flutter.dev/flutter/material/StepperType.html
[<ImportMember("package:flutter/material.dart")>]
type StepperType =
  [<IsConst>] static member vertical: StepperType = nativeOnly
  [<IsConst>] static member horizontal: StepperType = nativeOnly
  [<IsConst>] static member values: StepperType = nativeOnly

/// https://api.flutter.dev/flutter/material/TabBarIndicatorSize.html
[<ImportMember("package:flutter/material.dart")>]
type TabBarIndicatorSize =
  [<IsConst>] static member tab: TabBarIndicatorSize = nativeOnly
  [<IsConst>] static member label: TabBarIndicatorSize = nativeOnly
  [<IsConst>] static member values: TabBarIndicatorSize = nativeOnly

/// https://api.flutter.dev/flutter/material/MaterialTapTargetSize.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialTapTargetSize =
  [<IsConst>] static member padded: MaterialTapTargetSize = nativeOnly
  [<IsConst>] static member shrinkWrap: MaterialTapTargetSize = nativeOnly
  [<IsConst>] static member values: MaterialTapTargetSize = nativeOnly

/// https://api.flutter.dev/flutter/material/DayPeriod.html
[<ImportMember("package:flutter/material.dart")>]
type DayPeriod =
  [<IsConst>] static member am: DayPeriod = nativeOnly
  [<IsConst>] static member pm: DayPeriod = nativeOnly
  [<IsConst>] static member values: DayPeriod = nativeOnly

/// https://api.flutter.dev/flutter/material/TimeOfDayFormat.html
[<ImportMember("package:flutter/material.dart")>]
type TimeOfDayFormat =
  [<IsConst>] static member HH_colon_mm: TimeOfDayFormat = nativeOnly
  [<IsConst>] static member HH_dot_mm: TimeOfDayFormat = nativeOnly
  [<IsConst>] static member frenchCanadian: TimeOfDayFormat = nativeOnly
  [<IsConst>] static member H_colon_mm: TimeOfDayFormat = nativeOnly
  [<IsConst>] static member h_colon_mm_space_a: TimeOfDayFormat = nativeOnly
  [<IsConst>] static member a_space_h_colon_mm: TimeOfDayFormat = nativeOnly
  [<IsConst>] static member values: TimeOfDayFormat = nativeOnly

/// https://api.flutter.dev/flutter/material/HourFormat.html
[<ImportMember("package:flutter/material.dart")>]
type HourFormat =
  [<IsConst>] static member HH: HourFormat = nativeOnly
  [<IsConst>] static member H: HourFormat = nativeOnly
  [<IsConst>] static member h: HourFormat = nativeOnly
  [<IsConst>] static member values: HourFormat = nativeOnly

/// https://api.flutter.dev/flutter/material/TimePickerEntryMode.html
[<ImportMember("package:flutter/material.dart")>]
type TimePickerEntryMode =
  [<IsConst>] static member dial: TimePickerEntryMode = nativeOnly
  [<IsConst>] static member input: TimePickerEntryMode = nativeOnly
  [<IsConst>] static member values: TimePickerEntryMode = nativeOnly

/// https://api.flutter.dev/flutter/material/TooltipTriggerMode.html
[<ImportMember("package:flutter/material.dart")>]
type TooltipTriggerMode =
  [<IsConst>] static member manual: TooltipTriggerMode = nativeOnly
  [<IsConst>] static member longPress: TooltipTriggerMode = nativeOnly
  [<IsConst>] static member tap: TooltipTriggerMode = nativeOnly
  [<IsConst>] static member values: TooltipTriggerMode = nativeOnly

/// https://api.flutter.dev/flutter/material/ScriptCategory.html
[<ImportMember("package:flutter/material.dart")>]
type ScriptCategory =
  [<IsConst>] static member englishLike: ScriptCategory = nativeOnly
  [<IsConst>] static member dense: ScriptCategory = nativeOnly
  [<IsConst>] static member tall: ScriptCategory = nativeOnly
  [<IsConst>] static member values: ScriptCategory = nativeOnly

/// https://api.flutter.dev/flutter/material/FabTopOffsetY-mixin.html
[<ImportMember("package:flutter/material.dart")>]
type FabTopOffsetY =
  interface end

/// https://api.flutter.dev/flutter/material/FabFloatOffsetY-mixin.html
[<ImportMember("package:flutter/material.dart")>]
type FabFloatOffsetY =
  interface end

/// https://api.flutter.dev/flutter/material/FabDockedOffsetY-mixin.html
[<ImportMember("package:flutter/material.dart")>]
type FabDockedOffsetY =
  interface end

/// https://api.flutter.dev/flutter/material/FabStartOffsetX-mixin.html
[<ImportMember("package:flutter/material.dart")>]
type FabStartOffsetX =
  interface end

/// https://api.flutter.dev/flutter/material/FabCenterOffsetX-mixin.html
[<ImportMember("package:flutter/material.dart")>]
type FabCenterOffsetX =
  interface end

/// https://api.flutter.dev/flutter/material/FabEndOffsetX-mixin.html
[<ImportMember("package:flutter/material.dart")>]
type FabEndOffsetX =
  interface end

/// https://api.flutter.dev/flutter/material/FabMiniOffsetAdjustment-mixin.html
[<ImportMember("package:flutter/material.dart")>]
type FabMiniOffsetAdjustment =
  interface end

/// https://api.flutter.dev/flutter/material/MaterialButtonWithIconMixin-mixin.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialButtonWithIconMixin =
  interface end

/// https://api.flutter.dev/flutter/material/MaterialStateMixin-mixin.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialStateMixin =
  interface end

/// https://api.flutter.dev/flutter/material/MaterialRouteTransitionMixin-mixin.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialRouteTransitionMixin =
  interface end

/// https://api.flutter.dev/flutter/material/BaseSliderTrackShape-mixin.html
[<ImportMember("package:flutter/material.dart")>]
type BaseSliderTrackShape =
  interface end

/// https://api.flutter.dev/flutter/material/ToggleableStateMixin-mixin.html
[<ImportMember("package:flutter/material.dart")>]
type ToggleableStateMixin =
  interface end

/// https://api.flutter.dev/flutter/material/AboutListTile-class.html
[<ImportMember("package:flutter/material.dart")>]
type AboutListTile [<IsConst; NamedParams>] (?key: Key, ?icon: Widget, ?child: Widget, ?applicationName: string, ?applicationVersion: string, ?applicationIcon: Widget, ?applicationLegalese: string, ?aboutBoxChildren: Widget[], ?dense: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/AboutDialog-class.html
[<ImportMember("package:flutter/material.dart")>]
type AboutDialog [<IsConst; NamedParams>] (?key: Key, ?applicationName: string, ?applicationVersion: string, ?applicationIcon: Widget, ?applicationLegalese: string, ?children: Widget[]) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/LicensePage-class.html
[<ImportMember("package:flutter/material.dart")>]
type LicensePage [<IsConst; NamedParams>] (?key: Key, ?applicationName: string, ?applicationVersion: string, ?applicationIcon: Widget, ?applicationLegalese: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/AnimatedIcon-class.html
[<ImportMember("package:flutter/material.dart")>]
type AnimatedIcon [<IsConst; NamedParams>] (icon: AnimatedIconData, progress: Animation<float>, ?key: Key, ?color: Color, ?size: float, ?semanticLabel: string, ?textDirection: TextDirection) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/AnimatedIcons-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type AnimatedIcons () =
  [<IsConst>] static member add_event: AnimatedIconData = nativeOnly
  [<IsConst>] static member arrow_menu: AnimatedIconData = nativeOnly
  [<IsConst>] static member close_menu: AnimatedIconData = nativeOnly
  [<IsConst>] static member ellipsis_search: AnimatedIconData = nativeOnly
  [<IsConst>] static member event_add: AnimatedIconData = nativeOnly
  [<IsConst>] static member home_menu: AnimatedIconData = nativeOnly
  [<IsConst>] static member list_view: AnimatedIconData = nativeOnly
  [<IsConst>] static member menu_arrow: AnimatedIconData = nativeOnly
  [<IsConst>] static member menu_close: AnimatedIconData = nativeOnly
  [<IsConst>] static member menu_home: AnimatedIconData = nativeOnly
  [<IsConst>] static member pause_play: AnimatedIconData = nativeOnly
  [<IsConst>] static member play_pause: AnimatedIconData = nativeOnly
  [<IsConst>] static member search_ellipsis: AnimatedIconData = nativeOnly
  [<IsConst>] static member view_list: AnimatedIconData = nativeOnly

/// https://api.flutter.dev/flutter/material/AnimatedIconData-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type AnimatedIconData [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/material/MaterialApp-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialApp [<IsConst; NamedParams>] (?key: Key, ?navigatorKey: GlobalKey<NavigatorState>, ?scaffoldMessengerKey: GlobalKey<ScaffoldMessengerState>, ?home: Widget, ?routes: Dictionary<string, (BuildContext -> Widget)>, ?initialRoute: string, ?onGenerateRoute: (RouteSettings -> Route<obj> option), ?onGenerateInitialRoutes: (string -> Route<obj>[]), ?onUnknownRoute: (RouteSettings -> Route<obj> option), ?navigatorObservers: NavigatorObserver[], ?builder: (BuildContext -> Widget option -> Widget), ?title: string, ?onGenerateTitle: (BuildContext -> string), ?color: Color, ?theme: ThemeData, ?darkTheme: ThemeData, ?highContrastTheme: ThemeData, ?highContrastDarkTheme: ThemeData, ?themeMode: ThemeMode, ?locale: Locale, ?localizationsDelegates: LocalizationsDelegate<obj> seq, ?localeListResolutionCallback: (Locale[] option -> Locale seq -> Locale option), ?localeResolutionCallback: (Locale option -> Locale seq -> Locale option), ?supportedLocales: Locale seq, ?debugShowMaterialGrid: bool, ?showPerformanceOverlay: bool, ?checkerboardRasterCacheImages: bool, ?checkerboardOffscreenLayers: bool, ?showSemanticsDebugger: bool, ?debugShowCheckedModeBanner: bool, ?shortcuts: Dictionary<ShortcutActivator, Intent>, ?actions: Dictionary<Type, Action<Intent>>, ?restorationScopeId: string, ?scrollBehavior: ScrollBehavior, ?useInheritedMediaQuery: bool) =
  inherit Widget()
  [<IsConst; NamedParams>] static member router(routeInformationParser: RouteInformationParser<obj>, routerDelegate: RouterDelegate<obj>, ?key: Key, ?scaffoldMessengerKey: GlobalKey<ScaffoldMessengerState>, ?routeInformationProvider: RouteInformationProvider, ?backButtonDispatcher: BackButtonDispatcher, ?builder: (BuildContext -> Widget option -> Widget), ?title: string, ?onGenerateTitle: (BuildContext -> string), ?color: Color, ?theme: ThemeData, ?darkTheme: ThemeData, ?highContrastTheme: ThemeData, ?highContrastDarkTheme: ThemeData, ?themeMode: ThemeMode, ?locale: Locale, ?localizationsDelegates: LocalizationsDelegate<obj> seq, ?localeListResolutionCallback: (Locale[] option -> Locale seq -> Locale option), ?localeResolutionCallback: (Locale option -> Locale seq -> Locale option), ?supportedLocales: Locale seq, ?debugShowMaterialGrid: bool, ?showPerformanceOverlay: bool, ?checkerboardRasterCacheImages: bool, ?checkerboardOffscreenLayers: bool, ?showSemanticsDebugger: bool, ?debugShowCheckedModeBanner: bool, ?shortcuts: Dictionary<ShortcutActivator, Intent>, ?actions: Dictionary<Type, Action<Intent>>, ?restorationScopeId: string, ?scrollBehavior: ScrollBehavior, ?useInheritedMediaQuery: bool): MaterialApp = nativeOnly

/// https://api.flutter.dev/flutter/material/MaterialScrollBehavior-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialScrollBehavior [<IsConst; NamedParams>] (?androidOverscrollIndicator: AndroidOverscrollIndicator) =
  inherit ScrollBehavior()

/// https://api.flutter.dev/flutter/material/AppBar-class.html
[<ImportMember("package:flutter/material.dart")>]
type AppBar [<NamedParams>] (?key: Key, ?leading: Widget, ?automaticallyImplyLeading: bool, ?title: Widget, ?actions: Widget[], ?flexibleSpace: Widget, ?bottom: PreferredSizeWidget, ?elevation: float, ?scrolledUnderElevation: float, ?shadowColor: Color, ?surfaceTintColor: Color, ?shape: ShapeBorder, ?backgroundColor: Color, ?foregroundColor: Color, ?brightness: Brightness, ?iconTheme: IconThemeData, ?actionsIconTheme: IconThemeData, ?textTheme: TextTheme, ?primary: bool, ?centerTitle: bool, ?excludeHeaderSemantics: bool, ?titleSpacing: float, ?toolbarOpacity: float, ?bottomOpacity: float, ?toolbarHeight: float, ?leadingWidth: float, ?backwardsCompatibility: bool, ?toolbarTextStyle: TextStyle, ?titleTextStyle: TextStyle, ?systemOverlayStyle: SystemUiOverlayStyle) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/SliverAppBar-class.html
[<ImportMember("package:flutter/material.dart")>]
type SliverAppBar [<IsConst; NamedParams>] (?key: Key, ?leading: Widget, ?automaticallyImplyLeading: bool, ?title: Widget, ?actions: Widget[], ?flexibleSpace: Widget, ?bottom: PreferredSizeWidget, ?elevation: float, ?scrolledUnderElevation: float, ?shadowColor: Color, ?surfaceTintColor: Color, ?forceElevated: bool, ?backgroundColor: Color, ?foregroundColor: Color, ?brightness: Brightness, ?iconTheme: IconThemeData, ?actionsIconTheme: IconThemeData, ?textTheme: TextTheme, ?primary: bool, ?centerTitle: bool, ?excludeHeaderSemantics: bool, ?titleSpacing: float, ?collapsedHeight: float, ?expandedHeight: float, ?floating: bool, ?pinned: bool, ?snap: bool, ?stretch: bool, ?stretchTriggerOffset: float, ?onStretchTrigger: (unit -> Future<unit>), ?shape: ShapeBorder, ?toolbarHeight: float, ?leadingWidth: float, ?backwardsCompatibility: bool, ?toolbarTextStyle: TextStyle, ?titleTextStyle: TextStyle, ?systemOverlayStyle: SystemUiOverlayStyle) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/AppBarTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type AppBarTheme [<IsConst; NamedParams>] (?brightness: Brightness, ?color: Color, ?backgroundColor: Color, ?foregroundColor: Color, ?elevation: float, ?scrolledUnderElevation: float, ?shadowColor: Color, ?surfaceTintColor: Color, ?shape: ShapeBorder, ?iconTheme: IconThemeData, ?actionsIconTheme: IconThemeData, ?textTheme: TextTheme, ?centerTitle: bool, ?titleSpacing: float, ?toolbarHeight: float, ?toolbarTextStyle: TextStyle, ?titleTextStyle: TextStyle, ?systemOverlayStyle: SystemUiOverlayStyle, ?backwardsCompatibility: bool) =
  class end

/// https://api.flutter.dev/flutter/material/MaterialPointArcTween-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialPointArcTween [<NamedParams>] (?``begin``: Offset, ?``end``: Offset) =
  inherit Tween<Offset>()

/// https://api.flutter.dev/flutter/material/MaterialRectArcTween-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialRectArcTween [<NamedParams>] (?``begin``: Rect, ?``end``: Rect) =
  inherit RectTween()

/// https://api.flutter.dev/flutter/material/MaterialRectCenterArcTween-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialRectCenterArcTween [<NamedParams>] (?``begin``: Rect, ?``end``: Rect) =
  inherit RectTween()

/// https://api.flutter.dev/flutter/material/Autocomplete-class.html
[<ImportMember("package:flutter/material.dart")>]
type Autocomplete<'T> [<IsConst; NamedParams>] (optionsBuilder: (TextEditingValue -> FutureOr<'T seq>), ?key: Key, ?displayStringForOption: ('T -> string), ?fieldViewBuilder: (BuildContext -> TextEditingController -> FocusNode -> (unit -> unit) -> Widget), ?onSelected: ('T -> unit), ?optionsMaxHeight: float, ?optionsViewBuilder: (BuildContext -> ('T -> unit) -> 'T seq -> Widget), ?initialValue: TextEditingValue) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/BackButtonIcon-class.html
[<ImportMember("package:flutter/material.dart")>]
type BackButtonIcon [<IsConst; NamedParams>] (?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/BackButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type BackButton [<IsConst; NamedParams>] (?key: Key, ?color: Color, ?onPressed: (unit -> unit)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/CloseButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type CloseButton [<IsConst; NamedParams>] (?key: Key, ?color: Color, ?onPressed: (unit -> unit)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/MaterialBanner-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialBanner [<IsConst; NamedParams>] (content: Widget, actions: Widget[], ?key: Key, ?contentTextStyle: TextStyle, ?elevation: float, ?leading: Widget, ?backgroundColor: Color, ?padding: EdgeInsetsGeometry, ?leadingPadding: EdgeInsetsGeometry, ?forceActionsBelow: bool, ?overflowAlignment: OverflowBarAlignment, ?animation: Animation<float>, ?onVisible: (unit -> unit)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/MaterialBannerThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialBannerThemeData [<IsConst; NamedParams>] (?backgroundColor: Color, ?contentTextStyle: TextStyle, ?elevation: float, ?padding: EdgeInsetsGeometry, ?leadingPadding: EdgeInsetsGeometry) =
  class end

/// https://api.flutter.dev/flutter/material/MaterialBannerTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialBannerTheme [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?data: MaterialBannerThemeData) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/BottomAppBar-class.html
[<ImportMember("package:flutter/material.dart")>]
type BottomAppBar [<IsConst; NamedParams>] (?key: Key, ?color: Color, ?elevation: float, ?shape: NotchedShape, ?clipBehavior: Clip, ?notchMargin: float, ?child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/BottomAppBarTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type BottomAppBarTheme [<IsConst; NamedParams>] (?color: Color, ?elevation: float, ?shape: NotchedShape) =
  class end

/// https://api.flutter.dev/flutter/material/BottomNavigationBar-class.html
[<ImportMember("package:flutter/material.dart")>]
type BottomNavigationBar [<NamedParams>] (items: BottomNavigationBarItem[], ?key: Key, ?onTap: (int -> unit), ?currentIndex: int, ?elevation: float, ?``type``: BottomNavigationBarType, ?fixedColor: Color, ?backgroundColor: Color, ?iconSize: float, ?selectedItemColor: Color, ?unselectedItemColor: Color, ?selectedIconTheme: IconThemeData, ?unselectedIconTheme: IconThemeData, ?selectedFontSize: float, ?unselectedFontSize: float, ?selectedLabelStyle: TextStyle, ?unselectedLabelStyle: TextStyle, ?showSelectedLabels: bool, ?showUnselectedLabels: bool, ?mouseCursor: MouseCursor, ?enableFeedback: bool, ?landscapeLayout: BottomNavigationBarLandscapeLayout) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/BottomNavigationBarThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type BottomNavigationBarThemeData [<IsConst; NamedParams>] (?backgroundColor: Color, ?elevation: float, ?selectedIconTheme: IconThemeData, ?unselectedIconTheme: IconThemeData, ?selectedItemColor: Color, ?unselectedItemColor: Color, ?selectedLabelStyle: TextStyle, ?unselectedLabelStyle: TextStyle, ?showSelectedLabels: bool, ?showUnselectedLabels: bool, ?``type``: BottomNavigationBarType, ?enableFeedback: bool, ?landscapeLayout: BottomNavigationBarLandscapeLayout, ?mouseCursor: MaterialStateProperty<MouseCursor option>) =
  class end

/// https://api.flutter.dev/flutter/material/BottomNavigationBarTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type BottomNavigationBarTheme [<IsConst; NamedParams>] (data: BottomNavigationBarThemeData, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/material/BottomSheet-class.html
[<ImportMember("package:flutter/material.dart")>]
type BottomSheet [<IsConst; NamedParams>] (onClosing: (unit -> unit), builder: (BuildContext -> Widget), ?key: Key, ?animationController: AnimationController, ?enableDrag: bool, ?onDragStart: (DragStartDetails -> unit), ?onDragEnd: (DragEndDetails -> bool -> unit), ?backgroundColor: Color, ?elevation: float, ?shape: ShapeBorder, ?clipBehavior: Clip, ?constraints: BoxConstraints) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/BottomSheetThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type BottomSheetThemeData [<IsConst; NamedParams>] (?backgroundColor: Color, ?elevation: float, ?modalBackgroundColor: Color, ?modalElevation: float, ?shape: ShapeBorder, ?clipBehavior: Clip, ?constraints: BoxConstraints) =
  class end

/// https://api.flutter.dev/flutter/material/RawMaterialButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type RawMaterialButton [<IsConst; NamedParams>] (onPressed: (unit -> unit), ?key: Key, ?onLongPress: (unit -> unit), ?onHighlightChanged: (bool -> unit), ?mouseCursor: MouseCursor, ?textStyle: TextStyle, ?fillColor: Color, ?focusColor: Color, ?hoverColor: Color, ?highlightColor: Color, ?splashColor: Color, ?elevation: float, ?focusElevation: float, ?hoverElevation: float, ?highlightElevation: float, ?disabledElevation: float, ?padding: EdgeInsetsGeometry, ?visualDensity: VisualDensity, ?constraints: BoxConstraints, ?shape: ShapeBorder, ?animationDuration: TimeSpan, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?materialTapTargetSize: MaterialTapTargetSize, ?child: Widget, ?enableFeedback: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ButtonBar-class.html
[<ImportMember("package:flutter/material.dart")>]
type ButtonBar [<IsConst; NamedParams>] (?key: Key, ?alignment: MainAxisAlignment, ?mainAxisSize: MainAxisSize, ?buttonTextTheme: ButtonTextTheme, ?buttonMinWidth: float, ?buttonHeight: float, ?buttonPadding: EdgeInsetsGeometry, ?buttonAlignedDropdown: bool, ?layoutBehavior: ButtonBarLayoutBehavior, ?overflowDirection: VerticalDirection, ?overflowButtonSpacing: float, ?children: Widget[]) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ButtonBarThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type ButtonBarThemeData [<IsConst; NamedParams>] (?alignment: MainAxisAlignment, ?mainAxisSize: MainAxisSize, ?buttonTextTheme: ButtonTextTheme, ?buttonMinWidth: float, ?buttonHeight: float, ?buttonPadding: EdgeInsetsGeometry, ?buttonAlignedDropdown: bool, ?layoutBehavior: ButtonBarLayoutBehavior, ?overflowDirection: VerticalDirection) =
  class end

/// https://api.flutter.dev/flutter/material/ButtonBarTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type ButtonBarTheme [<IsConst; NamedParams>] (data: ButtonBarThemeData, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/material/ButtonStyle-class.html
[<ImportMember("package:flutter/material.dart")>]
type ButtonStyle [<IsConst; NamedParams>] (?textStyle: MaterialStateProperty<TextStyle option>, ?backgroundColor: MaterialStateProperty<Color option>, ?foregroundColor: MaterialStateProperty<Color option>, ?overlayColor: MaterialStateProperty<Color option>, ?shadowColor: MaterialStateProperty<Color option>, ?surfaceTintColor: MaterialStateProperty<Color option>, ?elevation: MaterialStateProperty<float option>, ?padding: MaterialStateProperty<EdgeInsetsGeometry option>, ?minimumSize: MaterialStateProperty<Size option>, ?fixedSize: MaterialStateProperty<Size option>, ?maximumSize: MaterialStateProperty<Size option>, ?side: MaterialStateProperty<BorderSide option>, ?shape: MaterialStateProperty<OutlinedBorder option>, ?mouseCursor: MaterialStateProperty<MouseCursor option>, ?visualDensity: VisualDensity, ?tapTargetSize: MaterialTapTargetSize, ?animationDuration: TimeSpan, ?enableFeedback: bool, ?alignment: AlignmentGeometry, ?splashFactory: InteractiveInkFeatureFactory) =
  class end

/// https://api.flutter.dev/flutter/material/ButtonStyleButton-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type ButtonStyleButton [<IsConst; NamedParams>] (onPressed: (unit -> unit), onLongPress: (unit -> unit), onHover: (bool -> unit), onFocusChange: (bool -> unit), style: ButtonStyle option, focusNode: FocusNode option, autofocus: bool, clipBehavior: Clip, child: Widget option, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ButtonTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type ButtonTheme [<NamedParams>] (child: Widget, ?key: Key, ?textTheme: ButtonTextTheme, ?layoutBehavior: ButtonBarLayoutBehavior, ?minWidth: float, ?height: float, ?padding: EdgeInsetsGeometry, ?shape: ShapeBorder, ?alignedDropdown: bool, ?buttonColor: Color, ?disabledColor: Color, ?focusColor: Color, ?hoverColor: Color, ?highlightColor: Color, ?splashColor: Color, ?colorScheme: ColorScheme, ?materialTapTargetSize: MaterialTapTargetSize) =
  inherit InheritedTheme(child)
  [<IsConst; NamedParams>] static member fromButtonThemeData(data: ButtonThemeData, child: Widget, ?key: Key): ButtonTheme = nativeOnly

/// https://api.flutter.dev/flutter/material/ButtonThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type ButtonThemeData [<IsConst; NamedParams>] (?textTheme: ButtonTextTheme, ?minWidth: float, ?height: float, ?padding: EdgeInsetsGeometry, ?shape: ShapeBorder, ?layoutBehavior: ButtonBarLayoutBehavior, ?alignedDropdown: bool, ?buttonColor: Color, ?disabledColor: Color, ?focusColor: Color, ?hoverColor: Color, ?highlightColor: Color, ?splashColor: Color, ?colorScheme: ColorScheme, ?materialTapTargetSize: MaterialTapTargetSize) =
  class end

/// https://api.flutter.dev/flutter/material/CalendarDatePicker-class.html
[<ImportMember("package:flutter/material.dart")>]
type CalendarDatePicker [<NamedParams>] (initialDate: DateTime, firstDate: DateTime, lastDate: DateTime, onDateChanged: (DateTime -> unit), ?key: Key, ?currentDate: DateTime, ?onDisplayedMonthChanged: (DateTime -> unit), ?initialCalendarMode: DatePickerMode, ?selectableDayPredicate: (DateTime -> bool)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/YearPicker-class.html
[<ImportMember("package:flutter/material.dart")>]
type YearPicker [<NamedParams>] (firstDate: DateTime, lastDate: DateTime, selectedDate: DateTime, onChanged: (DateTime -> unit), ?key: Key, ?currentDate: DateTime, ?initialDate: DateTime, ?dragStartBehavior: DragStartBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/Card-class.html
[<ImportMember("package:flutter/material.dart")>]
type Card [<IsConst; NamedParams>] (?key: Key, ?color: Color, ?shadowColor: Color, ?surfaceTintColor: Color, ?elevation: float, ?shape: ShapeBorder, ?borderOnForeground: bool, ?margin: EdgeInsetsGeometry, ?clipBehavior: Clip, ?child: Widget, ?semanticContainer: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/CardTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type CardTheme [<IsConst; NamedParams>] (?clipBehavior: Clip, ?color: Color, ?shadowColor: Color, ?surfaceTintColor: Color, ?elevation: float, ?margin: EdgeInsetsGeometry, ?shape: ShapeBorder) =
  class end

/// https://api.flutter.dev/flutter/material/Checkbox-class.html
[<ImportMember("package:flutter/material.dart")>]
type Checkbox [<IsConst; NamedParams>] (value: bool option, onChanged: (bool option -> unit), ?key: Key, ?tristate: bool, ?mouseCursor: MouseCursor, ?activeColor: Color, ?fillColor: MaterialStateProperty<Color option>, ?checkColor: Color, ?focusColor: Color, ?hoverColor: Color, ?overlayColor: MaterialStateProperty<Color option>, ?splashRadius: float, ?materialTapTargetSize: MaterialTapTargetSize, ?visualDensity: VisualDensity, ?focusNode: FocusNode, ?autofocus: bool, ?shape: OutlinedBorder, ?side: BorderSide) =
  inherit Widget()
  [<IsConst>] static member width: float = nativeOnly

/// https://api.flutter.dev/flutter/material/CheckboxListTile-class.html
[<ImportMember("package:flutter/material.dart")>]
type CheckboxListTile [<IsConst; NamedParams>] (value: bool option, onChanged: (bool option -> unit), ?key: Key, ?activeColor: Color, ?checkColor: Color, ?tileColor: Color, ?title: Widget, ?subtitle: Widget, ?isThreeLine: bool, ?dense: bool, ?secondary: Widget, ?selected: bool, ?controlAffinity: ListTileControlAffinity, ?autofocus: bool, ?contentPadding: EdgeInsetsGeometry, ?tristate: bool, ?shape: ShapeBorder, ?checkboxShape: OutlinedBorder, ?selectedTileColor: Color, ?side: BorderSide, ?visualDensity: VisualDensity, ?focusNode: FocusNode, ?enableFeedback: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/CheckboxThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type CheckboxThemeData [<IsConst; NamedParams>] (?mouseCursor: MaterialStateProperty<MouseCursor option>, ?fillColor: MaterialStateProperty<Color option>, ?checkColor: MaterialStateProperty<Color option>, ?overlayColor: MaterialStateProperty<Color option>, ?splashRadius: float, ?materialTapTargetSize: MaterialTapTargetSize, ?visualDensity: VisualDensity, ?shape: OutlinedBorder, ?side: BorderSide) =
  class end

/// https://api.flutter.dev/flutter/material/CheckboxTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type CheckboxTheme [<IsConst; NamedParams>] (data: CheckboxThemeData, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/material/ChipAttributes-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type ChipAttributes =
  class end

/// https://api.flutter.dev/flutter/material/DeletableChipAttributes-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type DeletableChipAttributes =
  class end

/// https://api.flutter.dev/flutter/material/CheckmarkableChipAttributes-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type CheckmarkableChipAttributes =
  class end

/// https://api.flutter.dev/flutter/material/SelectableChipAttributes-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type SelectableChipAttributes =
  class end

/// https://api.flutter.dev/flutter/material/DisabledChipAttributes-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type DisabledChipAttributes =
  class end

/// https://api.flutter.dev/flutter/material/TappableChipAttributes-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type TappableChipAttributes =
  class end

/// https://api.flutter.dev/flutter/material/Chip-class.html
[<ImportMember("package:flutter/material.dart")>]
type Chip [<IsConst; NamedParams>] (label: Widget, ?key: Key, ?avatar: Widget, ?labelStyle: TextStyle, ?labelPadding: EdgeInsetsGeometry, ?deleteIcon: Widget, ?onDeleted: (unit -> unit), ?deleteIconColor: Color, ?deleteButtonTooltipMessage: string, ?side: BorderSide, ?shape: OutlinedBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?backgroundColor: Color, ?padding: EdgeInsetsGeometry, ?visualDensity: VisualDensity, ?materialTapTargetSize: MaterialTapTargetSize, ?elevation: float, ?shadowColor: Color, ?useDeleteButtonTooltip: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/InputChip-class.html
[<ImportMember("package:flutter/material.dart")>]
type InputChip [<IsConst; NamedParams>] (label: Widget, ?key: Key, ?avatar: Widget, ?labelStyle: TextStyle, ?labelPadding: EdgeInsetsGeometry, ?selected: bool, ?isEnabled: bool, ?onSelected: (bool -> unit), ?deleteIcon: Widget, ?onDeleted: (unit -> unit), ?deleteIconColor: Color, ?deleteButtonTooltipMessage: string, ?onPressed: (unit -> unit), ?pressElevation: float, ?disabledColor: Color, ?selectedColor: Color, ?tooltip: string, ?side: BorderSide, ?shape: OutlinedBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?backgroundColor: Color, ?padding: EdgeInsetsGeometry, ?visualDensity: VisualDensity, ?materialTapTargetSize: MaterialTapTargetSize, ?elevation: float, ?shadowColor: Color, ?selectedShadowColor: Color, ?showCheckmark: bool, ?checkmarkColor: Color, ?avatarBorder: ShapeBorder, ?useDeleteButtonTooltip: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ChoiceChip-class.html
[<ImportMember("package:flutter/material.dart")>]
type ChoiceChip [<IsConst; NamedParams>] (label: Widget, selected: bool, ?key: Key, ?avatar: Widget, ?labelStyle: TextStyle, ?labelPadding: EdgeInsetsGeometry, ?onSelected: (bool -> unit), ?pressElevation: float, ?selectedColor: Color, ?disabledColor: Color, ?tooltip: string, ?side: BorderSide, ?shape: OutlinedBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?backgroundColor: Color, ?padding: EdgeInsetsGeometry, ?visualDensity: VisualDensity, ?materialTapTargetSize: MaterialTapTargetSize, ?elevation: float, ?shadowColor: Color, ?selectedShadowColor: Color, ?avatarBorder: ShapeBorder) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/FilterChip-class.html
[<ImportMember("package:flutter/material.dart")>]
type FilterChip [<IsConst; NamedParams>] (label: Widget, onSelected: (bool -> unit), ?key: Key, ?avatar: Widget, ?labelStyle: TextStyle, ?labelPadding: EdgeInsetsGeometry, ?selected: bool, ?pressElevation: float, ?disabledColor: Color, ?selectedColor: Color, ?tooltip: string, ?side: BorderSide, ?shape: OutlinedBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?backgroundColor: Color, ?padding: EdgeInsetsGeometry, ?visualDensity: VisualDensity, ?materialTapTargetSize: MaterialTapTargetSize, ?elevation: float, ?shadowColor: Color, ?selectedShadowColor: Color, ?showCheckmark: bool, ?checkmarkColor: Color, ?avatarBorder: ShapeBorder) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ActionChip-class.html
[<ImportMember("package:flutter/material.dart")>]
type ActionChip [<IsConst; NamedParams>] (label: Widget, onPressed: (unit -> unit), ?key: Key, ?avatar: Widget, ?labelStyle: TextStyle, ?labelPadding: EdgeInsetsGeometry, ?pressElevation: float, ?tooltip: string, ?side: BorderSide, ?shape: OutlinedBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?backgroundColor: Color, ?padding: EdgeInsetsGeometry, ?visualDensity: VisualDensity, ?materialTapTargetSize: MaterialTapTargetSize, ?elevation: float, ?shadowColor: Color) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/RawChip-class.html
[<ImportMember("package:flutter/material.dart")>]
type RawChip [<IsConst; NamedParams>] (label: Widget, ?key: Key, ?avatar: Widget, ?labelStyle: TextStyle, ?padding: EdgeInsetsGeometry, ?visualDensity: VisualDensity, ?labelPadding: EdgeInsetsGeometry, ?deleteIcon: Widget, ?onDeleted: (unit -> unit), ?deleteIconColor: Color, ?deleteButtonTooltipMessage: string, ?onPressed: (unit -> unit), ?onSelected: (bool -> unit), ?pressElevation: float, ?tapEnabled: bool, ?selected: bool, ?isEnabled: bool, ?disabledColor: Color, ?selectedColor: Color, ?tooltip: string, ?side: BorderSide, ?shape: OutlinedBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?backgroundColor: Color, ?materialTapTargetSize: MaterialTapTargetSize, ?elevation: float, ?shadowColor: Color, ?selectedShadowColor: Color, ?showCheckmark: bool, ?checkmarkColor: Color, ?avatarBorder: ShapeBorder, ?useDeleteButtonTooltip: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ChipTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type ChipTheme [<IsConst; NamedParams>] (data: ChipThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/ChipThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type ChipThemeData [<IsConst; NamedParams>] (?backgroundColor: Color, ?deleteIconColor: Color, ?disabledColor: Color, ?selectedColor: Color, ?secondarySelectedColor: Color, ?shadowColor: Color, ?selectedShadowColor: Color, ?showCheckmark: bool, ?checkmarkColor: Color, ?labelPadding: EdgeInsetsGeometry, ?padding: EdgeInsetsGeometry, ?side: BorderSide, ?shape: OutlinedBorder, ?labelStyle: TextStyle, ?secondaryLabelStyle: TextStyle, ?brightness: Brightness, ?elevation: float, ?pressElevation: float) =
  [<NamedParams>] static member fromDefaults(secondaryColor: Color, labelStyle: TextStyle, ?brightness: Brightness, ?primaryColor: Color): ChipThemeData = nativeOnly

/// https://api.flutter.dev/flutter/material/CircleAvatar-class.html
[<ImportMember("package:flutter/material.dart")>]
type CircleAvatar [<IsConst; NamedParams>] (?key: Key, ?child: Widget, ?backgroundColor: Color, ?backgroundImage: ImageProvider<obj>, ?foregroundImage: ImageProvider<obj>, ?onBackgroundImageError: (obj -> StackTrace option -> unit), ?onForegroundImageError: (obj -> StackTrace option -> unit), ?foregroundColor: Color, ?radius: float, ?minRadius: float, ?maxRadius: float) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ColorScheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type ColorScheme [<IsConst; NamedParams>] (brightness: Brightness, primary: Color, onPrimary: Color, secondary: Color, onSecondary: Color, error: Color, onError: Color, background: Color, onBackground: Color, surface: Color, onSurface: Color, ?primaryContainer: Color, ?onPrimaryContainer: Color, ?secondaryContainer: Color, ?onSecondaryContainer: Color, ?tertiary: Color, ?onTertiary: Color, ?tertiaryContainer: Color, ?onTertiaryContainer: Color, ?errorContainer: Color, ?onErrorContainer: Color, ?surfaceVariant: Color, ?onSurfaceVariant: Color, ?outline: Color, ?shadow: Color, ?inverseSurface: Color, ?onInverseSurface: Color, ?inversePrimary: Color, ?surfaceTint: Color, ?primaryVariant: Color, ?secondaryVariant: Color) =
  [<NamedParams>] static member fromSeed(seedColor: Color, ?brightness: Brightness, ?primary: Color, ?onPrimary: Color, ?primaryContainer: Color, ?onPrimaryContainer: Color, ?secondary: Color, ?onSecondary: Color, ?secondaryContainer: Color, ?onSecondaryContainer: Color, ?tertiary: Color, ?onTertiary: Color, ?tertiaryContainer: Color, ?onTertiaryContainer: Color, ?error: Color, ?onError: Color, ?errorContainer: Color, ?onErrorContainer: Color, ?outline: Color, ?background: Color, ?onBackground: Color, ?surface: Color, ?onSurface: Color, ?surfaceVariant: Color, ?onSurfaceVariant: Color, ?inverseSurface: Color, ?onInverseSurface: Color, ?inversePrimary: Color, ?shadow: Color, ?surfaceTint: Color): ColorScheme = nativeOnly
  [<IsConst; NamedParams>] static member light(?brightness: Brightness, ?primary: Color, ?onPrimary: Color, ?primaryContainer: Color, ?onPrimaryContainer: Color, ?secondary: Color, ?onSecondary: Color, ?secondaryContainer: Color, ?onSecondaryContainer: Color, ?tertiary: Color, ?onTertiary: Color, ?tertiaryContainer: Color, ?onTertiaryContainer: Color, ?error: Color, ?onError: Color, ?errorContainer: Color, ?onErrorContainer: Color, ?background: Color, ?onBackground: Color, ?surface: Color, ?onSurface: Color, ?surfaceVariant: Color, ?onSurfaceVariant: Color, ?outline: Color, ?shadow: Color, ?inverseSurface: Color, ?onInverseSurface: Color, ?inversePrimary: Color, ?surfaceTint: Color, ?primaryVariant: Color, ?secondaryVariant: Color): ColorScheme = nativeOnly
  [<IsConst; NamedParams>] static member dark(?brightness: Brightness, ?primary: Color, ?onPrimary: Color, ?primaryContainer: Color, ?onPrimaryContainer: Color, ?secondary: Color, ?onSecondary: Color, ?secondaryContainer: Color, ?onSecondaryContainer: Color, ?tertiary: Color, ?onTertiary: Color, ?tertiaryContainer: Color, ?onTertiaryContainer: Color, ?error: Color, ?onError: Color, ?errorContainer: Color, ?onErrorContainer: Color, ?background: Color, ?onBackground: Color, ?surface: Color, ?onSurface: Color, ?surfaceVariant: Color, ?onSurfaceVariant: Color, ?outline: Color, ?shadow: Color, ?inverseSurface: Color, ?onInverseSurface: Color, ?inversePrimary: Color, ?surfaceTint: Color, ?primaryVariant: Color, ?secondaryVariant: Color): ColorScheme = nativeOnly
  [<IsConst; NamedParams>] static member highContrastLight(?brightness: Brightness, ?primary: Color, ?onPrimary: Color, ?primaryContainer: Color, ?onPrimaryContainer: Color, ?secondary: Color, ?onSecondary: Color, ?secondaryContainer: Color, ?onSecondaryContainer: Color, ?tertiary: Color, ?onTertiary: Color, ?tertiaryContainer: Color, ?onTertiaryContainer: Color, ?error: Color, ?onError: Color, ?errorContainer: Color, ?onErrorContainer: Color, ?background: Color, ?onBackground: Color, ?surface: Color, ?onSurface: Color, ?surfaceVariant: Color, ?onSurfaceVariant: Color, ?outline: Color, ?shadow: Color, ?inverseSurface: Color, ?onInverseSurface: Color, ?inversePrimary: Color, ?surfaceTint: Color, ?primaryVariant: Color, ?secondaryVariant: Color): ColorScheme = nativeOnly
  [<IsConst; NamedParams>] static member highContrastDark(?brightness: Brightness, ?primary: Color, ?onPrimary: Color, ?primaryContainer: Color, ?onPrimaryContainer: Color, ?secondary: Color, ?onSecondary: Color, ?secondaryContainer: Color, ?onSecondaryContainer: Color, ?tertiary: Color, ?onTertiary: Color, ?tertiaryContainer: Color, ?onTertiaryContainer: Color, ?error: Color, ?onError: Color, ?errorContainer: Color, ?onErrorContainer: Color, ?background: Color, ?onBackground: Color, ?surface: Color, ?onSurface: Color, ?surfaceVariant: Color, ?onSurfaceVariant: Color, ?outline: Color, ?shadow: Color, ?inverseSurface: Color, ?onInverseSurface: Color, ?inversePrimary: Color, ?surfaceTint: Color, ?primaryVariant: Color, ?secondaryVariant: Color): ColorScheme = nativeOnly
  [<NamedParams>] static member fromSwatch(?primarySwatch: MaterialColor, ?primaryColorDark: Color, ?accentColor: Color, ?cardColor: Color, ?backgroundColor: Color, ?errorColor: Color, ?brightness: Brightness): ColorScheme = nativeOnly

/// https://api.flutter.dev/flutter/material/MaterialColor-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialColor [<IsConst>] (primary: int, swatch: Dictionary<int, Color>) =
  inherit ColorSwatch<int>(primary, nativeOnly)

/// https://api.flutter.dev/flutter/material/MaterialAccentColor-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialAccentColor [<IsConst>] (primary: int, swatch: Dictionary<int, Color>) =
  inherit ColorSwatch<int>(primary, nativeOnly)

/// https://api.flutter.dev/flutter/material/Colors-class.html
[<ImportMember("package:flutter/material.dart")>]
type Colors =
  [<IsConst>] static member transparent: Color = nativeOnly
  [<IsConst>] static member black: Color = nativeOnly
  [<IsConst>] static member black87: Color = nativeOnly
  [<IsConst>] static member black54: Color = nativeOnly
  [<IsConst>] static member black45: Color = nativeOnly
  [<IsConst>] static member black38: Color = nativeOnly
  [<IsConst>] static member black26: Color = nativeOnly
  [<IsConst>] static member black12: Color = nativeOnly
  [<IsConst>] static member white: Color = nativeOnly
  [<IsConst>] static member white70: Color = nativeOnly
  [<IsConst>] static member white60: Color = nativeOnly
  [<IsConst>] static member white54: Color = nativeOnly
  [<IsConst>] static member white38: Color = nativeOnly
  [<IsConst>] static member white30: Color = nativeOnly
  [<IsConst>] static member white24: Color = nativeOnly
  [<IsConst>] static member white12: Color = nativeOnly
  [<IsConst>] static member white10: Color = nativeOnly
  [<IsConst>] static member red: MaterialColor = nativeOnly
  [<IsConst>] static member redAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member pink: MaterialColor = nativeOnly
  [<IsConst>] static member pinkAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member purple: MaterialColor = nativeOnly
  [<IsConst>] static member purpleAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member deepPurple: MaterialColor = nativeOnly
  [<IsConst>] static member deepPurpleAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member indigo: MaterialColor = nativeOnly
  [<IsConst>] static member indigoAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member blue: MaterialColor = nativeOnly
  [<IsConst>] static member blueAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member lightBlue: MaterialColor = nativeOnly
  [<IsConst>] static member lightBlueAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member cyan: MaterialColor = nativeOnly
  [<IsConst>] static member cyanAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member teal: MaterialColor = nativeOnly
  [<IsConst>] static member tealAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member green: MaterialColor = nativeOnly
  [<IsConst>] static member greenAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member lightGreen: MaterialColor = nativeOnly
  [<IsConst>] static member lightGreenAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member lime: MaterialColor = nativeOnly
  [<IsConst>] static member limeAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member yellow: MaterialColor = nativeOnly
  [<IsConst>] static member yellowAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member amber: MaterialColor = nativeOnly
  [<IsConst>] static member amberAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member orange: MaterialColor = nativeOnly
  [<IsConst>] static member orangeAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member deepOrange: MaterialColor = nativeOnly
  [<IsConst>] static member deepOrangeAccent: MaterialAccentColor = nativeOnly
  [<IsConst>] static member brown: MaterialColor = nativeOnly
  [<IsConst>] static member grey: MaterialColor = nativeOnly
  [<IsConst>] static member blueGrey: MaterialColor = nativeOnly
  [<IsConst>] static member primaries: MaterialColor[] = nativeOnly
  [<IsConst>] static member accents: MaterialAccentColor[] = nativeOnly

/// https://api.flutter.dev/flutter/material/DataColumn-class.html
[<ImportMember("package:flutter/material.dart")>]
type DataColumn [<IsConst; NamedParams>] (label: Widget, ?tooltip: string, ?numeric: bool, ?onSort: (int -> bool -> unit)) =
  class end

/// https://api.flutter.dev/flutter/material/DataRow-class.html
[<ImportMember("package:flutter/material.dart")>]
type DataRow [<IsConst; NamedParams>] (cells: DataCell[], ?key: LocalKey, ?selected: bool, ?onSelectChanged: (bool option -> unit), ?onLongPress: (unit -> unit), ?color: MaterialStateProperty<Color option>) =
  [<NamedParams>] static member byIndex(cells: DataCell[], ?index: int, ?selected: bool, ?onSelectChanged: (bool option -> unit), ?onLongPress: (unit -> unit), ?color: MaterialStateProperty<Color option>): DataRow = nativeOnly

/// https://api.flutter.dev/flutter/material/DataCell-class.html
[<ImportMember("package:flutter/material.dart")>]
type DataCell [<IsConst; NamedParams(fromIndex=1)>] (child: Widget, ?placeholder: bool, ?showEditIcon: bool, ?onTap: (unit -> unit), ?onLongPress: (unit -> unit), ?onTapDown: (TapDownDetails -> unit), ?onDoubleTap: (unit -> unit), ?onTapCancel: (unit -> unit)) =
  [<IsConst>] static member empty: DataCell = nativeOnly

/// https://api.flutter.dev/flutter/material/DataTable-class.html
[<ImportMember("package:flutter/material.dart")>]
type DataTable [<NamedParams>] (columns: DataColumn[], rows: DataRow[], ?key: Key, ?sortColumnIndex: int, ?sortAscending: bool, ?onSelectAll: (bool option -> unit), ?decoration: Decoration, ?dataRowColor: MaterialStateProperty<Color option>, ?dataRowHeight: float, ?dataTextStyle: TextStyle, ?headingRowColor: MaterialStateProperty<Color option>, ?headingRowHeight: float, ?headingTextStyle: TextStyle, ?horizontalMargin: float, ?columnSpacing: float, ?showCheckboxColumn: bool, ?showBottomBorder: bool, ?dividerThickness: float, ?checkboxHorizontalMargin: float, ?border: TableBorder) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/TableRowInkWell-class.html
[<ImportMember("package:flutter/material.dart")>]
type TableRowInkWell [<IsConst; NamedParams>] (?key: Key, ?child: Widget, ?onTap: (unit -> unit), ?onDoubleTap: (unit -> unit), ?onLongPress: (unit -> unit), ?onHighlightChanged: (bool -> unit), ?overlayColor: MaterialStateProperty<Color option>) =
  inherit InkResponse()

/// https://api.flutter.dev/flutter/material/DataTableSource-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type DataTableSource () =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/material/DataTableThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type DataTableThemeData [<IsConst; NamedParams>] (?decoration: Decoration, ?dataRowColor: MaterialStateProperty<Color option>, ?dataRowHeight: float, ?dataTextStyle: TextStyle, ?headingRowColor: MaterialStateProperty<Color option>, ?headingRowHeight: float, ?headingTextStyle: TextStyle, ?horizontalMargin: float, ?columnSpacing: float, ?dividerThickness: float, ?checkboxHorizontalMargin: float) =
  class end

/// https://api.flutter.dev/flutter/material/DataTableTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type DataTableTheme [<IsConst; NamedParams>] (data: DataTableThemeData, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/material/DateUtils-class.html
[<ImportMember("package:flutter/material.dart")>]
type DateUtils =
  class end

/// https://api.flutter.dev/flutter/material/DateTimeRange-class.html
[<ImportMember("package:flutter/material.dart")>]
type DateTimeRange [<NamedParams>] (start: DateTime, ``end``: DateTime) =
  class end

/// https://api.flutter.dev/flutter/material/DatePickerDialog-class.html
[<ImportMember("package:flutter/material.dart")>]
type DatePickerDialog [<NamedParams>] (initialDate: DateTime, firstDate: DateTime, lastDate: DateTime, ?key: Key, ?currentDate: DateTime, ?initialEntryMode: DatePickerEntryMode, ?selectableDayPredicate: (DateTime -> bool), ?cancelText: string, ?confirmText: string, ?helpText: string, ?initialCalendarMode: DatePickerMode, ?errorFormatText: string, ?errorInvalidText: string, ?fieldHintText: string, ?fieldLabelText: string, ?keyboardType: TextInputType, ?restorationId: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/DateRangePickerDialog-class.html
[<ImportMember("package:flutter/material.dart")>]
type DateRangePickerDialog [<IsConst; NamedParams>] (firstDate: DateTime, lastDate: DateTime, ?key: Key, ?initialDateRange: DateTimeRange, ?currentDate: DateTime, ?initialEntryMode: DatePickerEntryMode, ?helpText: string, ?cancelText: string, ?confirmText: string, ?saveText: string, ?errorInvalidRangeText: string, ?errorFormatText: string, ?errorInvalidText: string, ?fieldStartHintText: string, ?fieldEndHintText: string, ?fieldStartLabelText: string, ?fieldEndLabelText: string, ?restorationId: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/Dialog-class.html
[<ImportMember("package:flutter/material.dart")>]
type Dialog [<IsConst; NamedParams>] (?key: Key, ?backgroundColor: Color, ?elevation: float, ?insetAnimationDuration: TimeSpan, ?insetAnimationCurve: Curve, ?insetPadding: EdgeInsets, ?clipBehavior: Clip, ?shape: ShapeBorder, ?alignment: AlignmentGeometry, ?child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/AlertDialog-class.html
[<ImportMember("package:flutter/material.dart")>]
type AlertDialog [<IsConst; NamedParams>] (?key: Key, ?title: Widget, ?titlePadding: EdgeInsetsGeometry, ?titleTextStyle: TextStyle, ?content: Widget, ?contentPadding: EdgeInsetsGeometry, ?contentTextStyle: TextStyle, ?actions: Widget[], ?actionsPadding: EdgeInsetsGeometry, ?actionsAlignment: MainAxisAlignment, ?actionsOverflowAlignment: OverflowBarAlignment, ?actionsOverflowDirection: VerticalDirection, ?actionsOverflowButtonSpacing: float, ?buttonPadding: EdgeInsetsGeometry, ?backgroundColor: Color, ?elevation: float, ?semanticLabel: string, ?insetPadding: EdgeInsets, ?clipBehavior: Clip, ?shape: ShapeBorder, ?alignment: AlignmentGeometry, ?scrollable: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/SimpleDialogOption-class.html
[<ImportMember("package:flutter/material.dart")>]
type SimpleDialogOption [<IsConst; NamedParams>] (?key: Key, ?onPressed: (unit -> unit), ?padding: EdgeInsets, ?child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/SimpleDialog-class.html
[<ImportMember("package:flutter/material.dart")>]
type SimpleDialog [<IsConst; NamedParams>] (?key: Key, ?title: Widget, ?titlePadding: EdgeInsetsGeometry, ?titleTextStyle: TextStyle, ?children: Widget[], ?contentPadding: EdgeInsetsGeometry, ?backgroundColor: Color, ?elevation: float, ?semanticLabel: string, ?insetPadding: EdgeInsets, ?clipBehavior: Clip, ?shape: ShapeBorder, ?alignment: AlignmentGeometry) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/DialogRoute-class.html
[<ImportMember("package:flutter/material.dart")>]
type DialogRoute<'T> [<NamedParams>] (context: BuildContext, builder: (BuildContext -> Widget), ?themes: CapturedThemes, ?barrierColor: Color, ?barrierDismissible: bool, ?barrierLabel: string, ?useSafeArea: bool, ?settings: RouteSettings, ?anchorPoint: Offset) =
  inherit RawDialogRoute<'T>(nativeOnly)

/// https://api.flutter.dev/flutter/material/DialogTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type DialogTheme [<IsConst; NamedParams>] (?backgroundColor: Color, ?elevation: float, ?shape: ShapeBorder, ?alignment: AlignmentGeometry, ?titleTextStyle: TextStyle, ?contentTextStyle: TextStyle) =
  class end

/// https://api.flutter.dev/flutter/material/Divider-class.html
[<ImportMember("package:flutter/material.dart")>]
type Divider [<IsConst; NamedParams>] (?key: Key, ?height: float, ?thickness: float, ?indent: float, ?endIndent: float, ?color: Color) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/VerticalDivider-class.html
[<ImportMember("package:flutter/material.dart")>]
type VerticalDivider [<IsConst; NamedParams>] (?key: Key, ?width: float, ?thickness: float, ?indent: float, ?endIndent: float, ?color: Color) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/DividerThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type DividerThemeData [<IsConst; NamedParams>] (?color: Color, ?space: float, ?thickness: float, ?indent: float, ?endIndent: float) =
  class end

/// https://api.flutter.dev/flutter/material/DividerTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type DividerTheme [<IsConst; NamedParams>] (data: DividerThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/Drawer-class.html
[<ImportMember("package:flutter/material.dart")>]
type Drawer [<IsConst; NamedParams>] (?key: Key, ?backgroundColor: Color, ?elevation: float, ?shape: ShapeBorder, ?width: float, ?child: Widget, ?semanticLabel: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/DrawerController-class.html
[<ImportMember("package:flutter/material.dart")>]
type DrawerController [<IsConst; NamedParams>] (child: Widget, alignment: DrawerAlignment, ?key: GlobalKey<State<StatefulWidget>>, ?isDrawerOpen: bool, ?drawerCallback: (bool -> unit), ?dragStartBehavior: DragStartBehavior, ?scrimColor: Color, ?edgeDragWidth: float, ?enableOpenDragGesture: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/DrawerControllerState-class.html
[<ImportMember("package:flutter/material.dart")>]
type DrawerControllerState () =
  interface State

/// https://api.flutter.dev/flutter/material/DrawerHeader-class.html
[<ImportMember("package:flutter/material.dart")>]
type DrawerHeader [<IsConst; NamedParams>] (child: Widget option, ?key: Key, ?decoration: Decoration, ?margin: EdgeInsetsGeometry, ?padding: EdgeInsetsGeometry, ?duration: TimeSpan, ?curve: Curve) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/DrawerThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type DrawerThemeData [<IsConst; NamedParams>] (?backgroundColor: Color, ?scrimColor: Color, ?elevation: float, ?shape: ShapeBorder, ?width: float) =
  class end

/// https://api.flutter.dev/flutter/material/DrawerTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type DrawerTheme [<IsConst; NamedParams>] (data: DrawerThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/DropdownMenuItem-class.html
[<ImportMember("package:flutter/material.dart")>]
type DropdownMenuItem<'T> [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?onTap: (unit -> unit), ?value: 'T, ?enabled: bool, ?alignment: AlignmentGeometry) =
  class end

/// https://api.flutter.dev/flutter/material/DropdownButtonHideUnderline-class.html
[<ImportMember("package:flutter/material.dart")>]
type DropdownButtonHideUnderline [<IsConst; NamedParams>] (child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/material/DropdownButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type DropdownButton<'T> [<NamedParams>] (items: DropdownMenuItem<'T>[] option, onChanged: ('T option -> unit), ?key: Key, ?selectedItemBuilder: (BuildContext -> Widget[]), ?value: 'T, ?hint: Widget, ?disabledHint: Widget, ?onTap: (unit -> unit), ?elevation: int, ?style: TextStyle, ?underline: Widget, ?icon: Widget, ?iconDisabledColor: Color, ?iconEnabledColor: Color, ?iconSize: float, ?isDense: bool, ?isExpanded: bool, ?itemHeight: float, ?focusColor: Color, ?focusNode: FocusNode, ?autofocus: bool, ?dropdownColor: Color, ?menuMaxHeight: float, ?enableFeedback: bool, ?alignment: AlignmentGeometry, ?borderRadius: BorderRadius) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/DropdownButtonFormField-class.html
[<ImportMember("package:flutter/material.dart")>]
type DropdownButtonFormField<'T> [<NamedParams>] (items: DropdownMenuItem<'T>[] option, onChanged: ('T option -> unit), ?key: Key, ?selectedItemBuilder: (BuildContext -> Widget[]), ?value: 'T, ?hint: Widget, ?disabledHint: Widget, ?onTap: (unit -> unit), ?elevation: int, ?style: TextStyle, ?icon: Widget, ?iconDisabledColor: Color, ?iconEnabledColor: Color, ?iconSize: float, ?isDense: bool, ?isExpanded: bool, ?itemHeight: float, ?focusColor: Color, ?focusNode: FocusNode, ?autofocus: bool, ?dropdownColor: Color, ?decoration: InputDecoration, ?onSaved: ('T option -> unit), ?validator: ('T option -> string option), ?autovalidateMode: AutovalidateMode, ?menuMaxHeight: float, ?enableFeedback: bool, ?alignment: AlignmentGeometry, ?borderRadius: BorderRadius) =
  inherit FormField<'T>(nativeOnly)

/// https://api.flutter.dev/flutter/material/ElevatedButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type ElevatedButton [<IsConst; NamedParams>] (onPressed: (unit -> unit), child: Widget option, ?key: Key, ?onLongPress: (unit -> unit), ?onHover: (bool -> unit), ?onFocusChange: (bool -> unit), ?style: ButtonStyle, ?focusNode: FocusNode, ?autofocus: bool, ?clipBehavior: Clip) =
  inherit ButtonStyleButton(nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly)
  [<NamedParams>] static member icon(onPressed: (unit -> unit), icon: Widget, label: Widget, ?key: Key, ?onLongPress: (unit -> unit), ?onHover: (bool -> unit), ?onFocusChange: (bool -> unit), ?style: ButtonStyle, ?focusNode: FocusNode, ?autofocus: bool, ?clipBehavior: Clip): ElevatedButton = nativeOnly

/// https://api.flutter.dev/flutter/material/ElevatedButtonThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type ElevatedButtonThemeData [<IsConst; NamedParams>] (?style: ButtonStyle) =
  class end

/// https://api.flutter.dev/flutter/material/ElevatedButtonTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type ElevatedButtonTheme [<IsConst; NamedParams>] (data: ElevatedButtonThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/ElevationOverlay-class.html
[<ImportMember("package:flutter/material.dart")>]
type ElevationOverlay =
  class end

/// https://api.flutter.dev/flutter/material/ExpandIcon-class.html
[<ImportMember("package:flutter/material.dart")>]
type ExpandIcon [<IsConst; NamedParams>] (onPressed: (bool -> unit), ?key: Key, ?isExpanded: bool, ?size: float, ?padding: EdgeInsetsGeometry, ?color: Color, ?disabledColor: Color, ?expandedColor: Color) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ExpansionPanel-class.html
[<ImportMember("package:flutter/material.dart")>]
type ExpansionPanel [<NamedParams>] (headerBuilder: (BuildContext -> bool -> Widget), body: Widget, ?isExpanded: bool, ?canTapOnHeader: bool, ?backgroundColor: Color) =
  class end

/// https://api.flutter.dev/flutter/material/ExpansionPanelRadio-class.html
[<ImportMember("package:flutter/material.dart")>]
type ExpansionPanelRadio [<NamedParams>] (value: obj, headerBuilder: (BuildContext -> bool -> Widget), body: Widget, ?canTapOnHeader: bool, ?backgroundColor: Color) =
  inherit ExpansionPanel(headerBuilder, body)

/// https://api.flutter.dev/flutter/material/ExpansionPanelList-class.html
[<ImportMember("package:flutter/material.dart")>]
type ExpansionPanelList [<IsConst; NamedParams>] (?key: Key, ?children: ExpansionPanel[], ?expansionCallback: (int -> bool -> unit), ?animationDuration: TimeSpan, ?expandedHeaderPadding: EdgeInsets, ?dividerColor: Color, ?elevation: float) =
  inherit Widget()
  [<IsConst; NamedParams>] static member radio(?key: Key, ?children: ExpansionPanel[], ?expansionCallback: (int -> bool -> unit), ?animationDuration: TimeSpan, ?initialOpenPanelValue: obj, ?expandedHeaderPadding: EdgeInsets, ?dividerColor: Color, ?elevation: float): ExpansionPanelList = nativeOnly

/// https://api.flutter.dev/flutter/material/ExpansionTile-class.html
[<ImportMember("package:flutter/material.dart")>]
type ExpansionTile [<IsConst; NamedParams>] (title: Widget, ?key: Key, ?leading: Widget, ?subtitle: Widget, ?onExpansionChanged: (bool -> unit), ?children: Widget[], ?trailing: Widget, ?initiallyExpanded: bool, ?maintainState: bool, ?tilePadding: EdgeInsetsGeometry, ?expandedCrossAxisAlignment: CrossAxisAlignment, ?expandedAlignment: Alignment, ?childrenPadding: EdgeInsetsGeometry, ?backgroundColor: Color, ?collapsedBackgroundColor: Color, ?textColor: Color, ?collapsedTextColor: Color, ?iconColor: Color, ?collapsedIconColor: Color, ?controlAffinity: ListTileControlAffinity) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ExpansionTileThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type ExpansionTileThemeData [<IsConst; NamedParams>] (?backgroundColor: Color, ?collapsedBackgroundColor: Color, ?tilePadding: EdgeInsetsGeometry, ?expandedAlignment: AlignmentGeometry, ?childrenPadding: EdgeInsetsGeometry, ?iconColor: Color, ?collapsedIconColor: Color, ?textColor: Color, ?collapsedTextColor: Color) =
  class end

/// https://api.flutter.dev/flutter/material/ExpansionTileTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type ExpansionTileTheme [<IsConst; NamedParams>] (data: ExpansionTileThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/Feedback-class.html
[<ImportMember("package:flutter/material.dart")>]
type Feedback =
  class end

/// https://api.flutter.dev/flutter/material/FlatButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type FlatButton [<IsConst; NamedParams>] (onPressed: (unit -> unit), child: Widget, ?key: Key, ?onLongPress: (unit -> unit), ?onHighlightChanged: (bool -> unit), ?mouseCursor: MouseCursor, ?textTheme: ButtonTextTheme, ?textColor: Color, ?disabledTextColor: Color, ?color: Color, ?disabledColor: Color, ?focusColor: Color, ?hoverColor: Color, ?highlightColor: Color, ?splashColor: Color, ?colorBrightness: Brightness, ?padding: EdgeInsetsGeometry, ?visualDensity: VisualDensity, ?shape: ShapeBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?materialTapTargetSize: MaterialTapTargetSize, ?height: float, ?minWidth: float) =
  inherit MaterialButton(onPressed)
  [<NamedParams>] static member icon(onPressed: (unit -> unit), icon: Widget, label: Widget, ?key: Key, ?onLongPress: (unit -> unit), ?onHighlightChanged: (bool -> unit), ?mouseCursor: MouseCursor, ?textTheme: ButtonTextTheme, ?textColor: Color, ?disabledTextColor: Color, ?color: Color, ?disabledColor: Color, ?focusColor: Color, ?hoverColor: Color, ?highlightColor: Color, ?splashColor: Color, ?colorBrightness: Brightness, ?padding: EdgeInsetsGeometry, ?shape: ShapeBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?materialTapTargetSize: MaterialTapTargetSize, ?minWidth: float, ?height: float): FlatButton = nativeOnly

/// https://api.flutter.dev/flutter/material/FlexibleSpaceBar-class.html
[<ImportMember("package:flutter/material.dart")>]
type FlexibleSpaceBar [<IsConst; NamedParams>] (?key: Key, ?title: Widget, ?background: Widget, ?centerTitle: bool, ?titlePadding: EdgeInsetsGeometry, ?collapseMode: CollapseMode, ?stretchModes: StretchMode[], ?expandedTitleScale: float) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/FlexibleSpaceBarSettings-class.html
[<ImportMember("package:flutter/material.dart")>]
type FlexibleSpaceBarSettings [<IsConst; NamedParams>] (toolbarOpacity: float, minExtent: float, maxExtent: float, currentExtent: float, child: Widget, ?key: Key, ?isScrolledUnder: bool) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/material/FloatingActionButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type FloatingActionButton [<IsConst; NamedParams>] (onPressed: (unit -> unit), ?key: Key, ?child: Widget, ?tooltip: string, ?foregroundColor: Color, ?backgroundColor: Color, ?focusColor: Color, ?hoverColor: Color, ?splashColor: Color, ?heroTag: obj, ?elevation: float, ?focusElevation: float, ?hoverElevation: float, ?highlightElevation: float, ?disabledElevation: float, ?mouseCursor: MouseCursor, ?mini: bool, ?shape: ShapeBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?materialTapTargetSize: MaterialTapTargetSize, ?isExtended: bool, ?enableFeedback: bool) =
  inherit Widget()
  [<IsConst; NamedParams>] static member small(onPressed: (unit -> unit), ?key: Key, ?child: Widget, ?tooltip: string, ?foregroundColor: Color, ?backgroundColor: Color, ?focusColor: Color, ?hoverColor: Color, ?splashColor: Color, ?heroTag: obj, ?elevation: float, ?focusElevation: float, ?hoverElevation: float, ?highlightElevation: float, ?disabledElevation: float, ?mouseCursor: MouseCursor, ?shape: ShapeBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?materialTapTargetSize: MaterialTapTargetSize, ?enableFeedback: bool): FloatingActionButton = nativeOnly
  [<IsConst; NamedParams>] static member large(onPressed: (unit -> unit), ?key: Key, ?child: Widget, ?tooltip: string, ?foregroundColor: Color, ?backgroundColor: Color, ?focusColor: Color, ?hoverColor: Color, ?splashColor: Color, ?heroTag: obj, ?elevation: float, ?focusElevation: float, ?hoverElevation: float, ?highlightElevation: float, ?disabledElevation: float, ?mouseCursor: MouseCursor, ?shape: ShapeBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?materialTapTargetSize: MaterialTapTargetSize, ?enableFeedback: bool): FloatingActionButton = nativeOnly
  [<IsConst; NamedParams>] static member extended(onPressed: (unit -> unit), label: Widget, ?key: Key, ?tooltip: string, ?foregroundColor: Color, ?backgroundColor: Color, ?focusColor: Color, ?hoverColor: Color, ?heroTag: obj, ?elevation: float, ?focusElevation: float, ?hoverElevation: float, ?splashColor: Color, ?highlightElevation: float, ?disabledElevation: float, ?mouseCursor: MouseCursor, ?shape: ShapeBorder, ?isExtended: bool, ?materialTapTargetSize: MaterialTapTargetSize, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?extendedIconLabelSpacing: float, ?extendedPadding: EdgeInsetsGeometry, ?extendedTextStyle: TextStyle, ?icon: Widget, ?enableFeedback: bool): FloatingActionButton = nativeOnly

/// https://api.flutter.dev/flutter/material/FloatingActionButtonLocation-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type FloatingActionButtonLocation [<IsConst>] () =
  [<IsConst>] static member startTop: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member miniStartTop: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member centerTop: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member miniCenterTop: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member endTop: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member miniEndTop: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member startFloat: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member miniStartFloat: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member centerFloat: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member miniCenterFloat: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member endFloat: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member miniEndFloat: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member startDocked: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member miniStartDocked: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member centerDocked: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member miniCenterDocked: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member endDocked: FloatingActionButtonLocation = nativeOnly
  [<IsConst>] static member miniEndDocked: FloatingActionButtonLocation = nativeOnly

/// https://api.flutter.dev/flutter/material/StandardFabLocation-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type StandardFabLocation [<IsConst>] () =
  inherit FloatingActionButtonLocation()

/// https://api.flutter.dev/flutter/material/FloatingActionButtonAnimator-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type FloatingActionButtonAnimator [<IsConst>] () =
  [<IsConst>] static member scaling: FloatingActionButtonAnimator = nativeOnly

/// https://api.flutter.dev/flutter/material/FloatingActionButtonThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type FloatingActionButtonThemeData [<IsConst; NamedParams>] (?foregroundColor: Color, ?backgroundColor: Color, ?focusColor: Color, ?hoverColor: Color, ?splashColor: Color, ?elevation: float, ?focusElevation: float, ?hoverElevation: float, ?disabledElevation: float, ?highlightElevation: float, ?shape: ShapeBorder, ?enableFeedback: bool, ?iconSize: float, ?sizeConstraints: BoxConstraints, ?smallSizeConstraints: BoxConstraints, ?largeSizeConstraints: BoxConstraints, ?extendedSizeConstraints: BoxConstraints, ?extendedIconLabelSpacing: float, ?extendedPadding: EdgeInsetsGeometry, ?extendedTextStyle: TextStyle) =
  class end

/// https://api.flutter.dev/flutter/material/FlutterLogo-class.html
[<ImportMember("package:flutter/material.dart")>]
type FlutterLogo [<IsConst; NamedParams>] (?key: Key, ?size: float, ?textColor: Color, ?style: FlutterLogoStyle, ?duration: TimeSpan, ?curve: Curve) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/GridTile-class.html
[<ImportMember("package:flutter/material.dart")>]
type GridTile [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?header: Widget, ?footer: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/GridTileBar-class.html
[<ImportMember("package:flutter/material.dart")>]
type GridTileBar [<IsConst; NamedParams>] (?key: Key, ?backgroundColor: Color, ?leading: Widget, ?title: Widget, ?subtitle: Widget, ?trailing: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/IconButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type IconButton [<IsConst; NamedParams>] (onPressed: (unit -> unit), icon: Widget, ?key: Key, ?iconSize: float, ?visualDensity: VisualDensity, ?padding: EdgeInsetsGeometry, ?alignment: AlignmentGeometry, ?splashRadius: float, ?color: Color, ?focusColor: Color, ?hoverColor: Color, ?highlightColor: Color, ?splashColor: Color, ?disabledColor: Color, ?mouseCursor: MouseCursor, ?focusNode: FocusNode, ?autofocus: bool, ?tooltip: string, ?enableFeedback: bool, ?constraints: BoxConstraints) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/PlatformAdaptiveIcons-class.html
[<ImportMember("package:flutter/material.dart")>]
type PlatformAdaptiveIcons =
  class end

/// https://api.flutter.dev/flutter/material/Icons-class.html
[<ImportMember("package:flutter/material.dart")>]
type Icons =
  [<IsConst>] static member ten_k: IconData = nativeOnly
  [<IsConst>] static member ten_k_sharp: IconData = nativeOnly
  [<IsConst>] static member ten_k_rounded: IconData = nativeOnly
  [<IsConst>] static member ten_k_outlined: IconData = nativeOnly
  [<IsConst>] static member ten_mp: IconData = nativeOnly
  [<IsConst>] static member ten_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member ten_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member ten_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member eleven_mp: IconData = nativeOnly
  [<IsConst>] static member eleven_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member eleven_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member eleven_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member onetwothree: IconData = nativeOnly
  [<IsConst>] static member onetwothree_sharp: IconData = nativeOnly
  [<IsConst>] static member onetwothree_rounded: IconData = nativeOnly
  [<IsConst>] static member onetwothree_outlined: IconData = nativeOnly
  [<IsConst>] static member twelve_mp: IconData = nativeOnly
  [<IsConst>] static member twelve_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member twelve_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member twelve_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member thirteen_mp: IconData = nativeOnly
  [<IsConst>] static member thirteen_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member thirteen_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member thirteen_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member fourteen_mp: IconData = nativeOnly
  [<IsConst>] static member fourteen_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member fourteen_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member fourteen_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member fifteen_mp: IconData = nativeOnly
  [<IsConst>] static member fifteen_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member fifteen_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member fifteen_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member sixteen_mp: IconData = nativeOnly
  [<IsConst>] static member sixteen_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member sixteen_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member sixteen_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member seventeen_mp: IconData = nativeOnly
  [<IsConst>] static member seventeen_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member seventeen_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member seventeen_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member eighteen_up_rating: IconData = nativeOnly
  [<IsConst>] static member eighteen_up_rating_sharp: IconData = nativeOnly
  [<IsConst>] static member eighteen_up_rating_rounded: IconData = nativeOnly
  [<IsConst>] static member eighteen_up_rating_outlined: IconData = nativeOnly
  [<IsConst>] static member eighteen_mp: IconData = nativeOnly
  [<IsConst>] static member eighteen_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member eighteen_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member eighteen_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member nineteen_mp: IconData = nativeOnly
  [<IsConst>] static member nineteen_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member nineteen_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member nineteen_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member one_k: IconData = nativeOnly
  [<IsConst>] static member one_k_sharp: IconData = nativeOnly
  [<IsConst>] static member one_k_rounded: IconData = nativeOnly
  [<IsConst>] static member one_k_outlined: IconData = nativeOnly
  [<IsConst>] static member one_k_plus: IconData = nativeOnly
  [<IsConst>] static member one_k_plus_sharp: IconData = nativeOnly
  [<IsConst>] static member one_k_plus_rounded: IconData = nativeOnly
  [<IsConst>] static member one_k_plus_outlined: IconData = nativeOnly
  [<IsConst>] static member one_x_mobiledata: IconData = nativeOnly
  [<IsConst>] static member one_x_mobiledata_sharp: IconData = nativeOnly
  [<IsConst>] static member one_x_mobiledata_rounded: IconData = nativeOnly
  [<IsConst>] static member one_x_mobiledata_outlined: IconData = nativeOnly
  [<IsConst>] static member twenty_mp: IconData = nativeOnly
  [<IsConst>] static member twenty_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member twenty_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member twenty_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member twenty_one_mp: IconData = nativeOnly
  [<IsConst>] static member twenty_one_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member twenty_one_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member twenty_one_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member twenty_two_mp: IconData = nativeOnly
  [<IsConst>] static member twenty_two_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member twenty_two_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member twenty_two_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member twenty_three_mp: IconData = nativeOnly
  [<IsConst>] static member twenty_three_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member twenty_three_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member twenty_three_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member twenty_four_mp: IconData = nativeOnly
  [<IsConst>] static member twenty_four_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member twenty_four_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member twenty_four_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member two_k: IconData = nativeOnly
  [<IsConst>] static member two_k_sharp: IconData = nativeOnly
  [<IsConst>] static member two_k_rounded: IconData = nativeOnly
  [<IsConst>] static member two_k_outlined: IconData = nativeOnly
  [<IsConst>] static member two_k_plus: IconData = nativeOnly
  [<IsConst>] static member two_k_plus_sharp: IconData = nativeOnly
  [<IsConst>] static member two_k_plus_rounded: IconData = nativeOnly
  [<IsConst>] static member two_k_plus_outlined: IconData = nativeOnly
  [<IsConst>] static member two_mp: IconData = nativeOnly
  [<IsConst>] static member two_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member two_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member two_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member thirty_fps: IconData = nativeOnly
  [<IsConst>] static member thirty_fps_sharp: IconData = nativeOnly
  [<IsConst>] static member thirty_fps_rounded: IconData = nativeOnly
  [<IsConst>] static member thirty_fps_outlined: IconData = nativeOnly
  [<IsConst>] static member thirty_fps_select: IconData = nativeOnly
  [<IsConst>] static member thirty_fps_select_sharp: IconData = nativeOnly
  [<IsConst>] static member thirty_fps_select_rounded: IconData = nativeOnly
  [<IsConst>] static member thirty_fps_select_outlined: IconData = nativeOnly
  [<IsConst>] static member threesixty: IconData = nativeOnly
  [<IsConst>] static member threesixty_sharp: IconData = nativeOnly
  [<IsConst>] static member threesixty_rounded: IconData = nativeOnly
  [<IsConst>] static member threesixty_outlined: IconData = nativeOnly
  [<IsConst>] static member threed_rotation: IconData = nativeOnly
  [<IsConst>] static member threed_rotation_sharp: IconData = nativeOnly
  [<IsConst>] static member threed_rotation_rounded: IconData = nativeOnly
  [<IsConst>] static member threed_rotation_outlined: IconData = nativeOnly
  [<IsConst>] static member three_g_mobiledata: IconData = nativeOnly
  [<IsConst>] static member three_g_mobiledata_sharp: IconData = nativeOnly
  [<IsConst>] static member three_g_mobiledata_rounded: IconData = nativeOnly
  [<IsConst>] static member three_g_mobiledata_outlined: IconData = nativeOnly
  [<IsConst>] static member three_k: IconData = nativeOnly
  [<IsConst>] static member three_k_sharp: IconData = nativeOnly
  [<IsConst>] static member three_k_rounded: IconData = nativeOnly
  [<IsConst>] static member three_k_outlined: IconData = nativeOnly
  [<IsConst>] static member three_k_plus: IconData = nativeOnly
  [<IsConst>] static member three_k_plus_sharp: IconData = nativeOnly
  [<IsConst>] static member three_k_plus_rounded: IconData = nativeOnly
  [<IsConst>] static member three_k_plus_outlined: IconData = nativeOnly
  [<IsConst>] static member three_mp: IconData = nativeOnly
  [<IsConst>] static member three_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member three_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member three_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member three_p: IconData = nativeOnly
  [<IsConst>] static member three_p_sharp: IconData = nativeOnly
  [<IsConst>] static member three_p_rounded: IconData = nativeOnly
  [<IsConst>] static member three_p_outlined: IconData = nativeOnly
  [<IsConst>] static member four_g_mobiledata: IconData = nativeOnly
  [<IsConst>] static member four_g_mobiledata_sharp: IconData = nativeOnly
  [<IsConst>] static member four_g_mobiledata_rounded: IconData = nativeOnly
  [<IsConst>] static member four_g_mobiledata_outlined: IconData = nativeOnly
  [<IsConst>] static member four_g_plus_mobiledata: IconData = nativeOnly
  [<IsConst>] static member four_g_plus_mobiledata_sharp: IconData = nativeOnly
  [<IsConst>] static member four_g_plus_mobiledata_rounded: IconData = nativeOnly
  [<IsConst>] static member four_g_plus_mobiledata_outlined: IconData = nativeOnly
  [<IsConst>] static member four_k: IconData = nativeOnly
  [<IsConst>] static member four_k_sharp: IconData = nativeOnly
  [<IsConst>] static member four_k_rounded: IconData = nativeOnly
  [<IsConst>] static member four_k_outlined: IconData = nativeOnly
  [<IsConst>] static member four_k_plus: IconData = nativeOnly
  [<IsConst>] static member four_k_plus_sharp: IconData = nativeOnly
  [<IsConst>] static member four_k_plus_rounded: IconData = nativeOnly
  [<IsConst>] static member four_k_plus_outlined: IconData = nativeOnly
  [<IsConst>] static member four_mp: IconData = nativeOnly
  [<IsConst>] static member four_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member four_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member four_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member five_g: IconData = nativeOnly
  [<IsConst>] static member five_g_sharp: IconData = nativeOnly
  [<IsConst>] static member five_g_rounded: IconData = nativeOnly
  [<IsConst>] static member five_g_outlined: IconData = nativeOnly
  [<IsConst>] static member five_k: IconData = nativeOnly
  [<IsConst>] static member five_k_sharp: IconData = nativeOnly
  [<IsConst>] static member five_k_rounded: IconData = nativeOnly
  [<IsConst>] static member five_k_outlined: IconData = nativeOnly
  [<IsConst>] static member five_k_plus: IconData = nativeOnly
  [<IsConst>] static member five_k_plus_sharp: IconData = nativeOnly
  [<IsConst>] static member five_k_plus_rounded: IconData = nativeOnly
  [<IsConst>] static member five_k_plus_outlined: IconData = nativeOnly
  [<IsConst>] static member five_mp: IconData = nativeOnly
  [<IsConst>] static member five_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member five_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member five_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member sixty_fps: IconData = nativeOnly
  [<IsConst>] static member sixty_fps_sharp: IconData = nativeOnly
  [<IsConst>] static member sixty_fps_rounded: IconData = nativeOnly
  [<IsConst>] static member sixty_fps_outlined: IconData = nativeOnly
  [<IsConst>] static member sixty_fps_select: IconData = nativeOnly
  [<IsConst>] static member sixty_fps_select_sharp: IconData = nativeOnly
  [<IsConst>] static member sixty_fps_select_rounded: IconData = nativeOnly
  [<IsConst>] static member sixty_fps_select_outlined: IconData = nativeOnly
  [<IsConst>] static member six_ft_apart: IconData = nativeOnly
  [<IsConst>] static member six_ft_apart_sharp: IconData = nativeOnly
  [<IsConst>] static member six_ft_apart_rounded: IconData = nativeOnly
  [<IsConst>] static member six_ft_apart_outlined: IconData = nativeOnly
  [<IsConst>] static member six_k: IconData = nativeOnly
  [<IsConst>] static member six_k_sharp: IconData = nativeOnly
  [<IsConst>] static member six_k_rounded: IconData = nativeOnly
  [<IsConst>] static member six_k_outlined: IconData = nativeOnly
  [<IsConst>] static member six_k_plus: IconData = nativeOnly
  [<IsConst>] static member six_k_plus_sharp: IconData = nativeOnly
  [<IsConst>] static member six_k_plus_rounded: IconData = nativeOnly
  [<IsConst>] static member six_k_plus_outlined: IconData = nativeOnly
  [<IsConst>] static member six_mp: IconData = nativeOnly
  [<IsConst>] static member six_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member six_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member six_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member seven_k: IconData = nativeOnly
  [<IsConst>] static member seven_k_sharp: IconData = nativeOnly
  [<IsConst>] static member seven_k_rounded: IconData = nativeOnly
  [<IsConst>] static member seven_k_outlined: IconData = nativeOnly
  [<IsConst>] static member seven_k_plus: IconData = nativeOnly
  [<IsConst>] static member seven_k_plus_sharp: IconData = nativeOnly
  [<IsConst>] static member seven_k_plus_rounded: IconData = nativeOnly
  [<IsConst>] static member seven_k_plus_outlined: IconData = nativeOnly
  [<IsConst>] static member seven_mp: IconData = nativeOnly
  [<IsConst>] static member seven_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member seven_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member seven_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member eight_k: IconData = nativeOnly
  [<IsConst>] static member eight_k_sharp: IconData = nativeOnly
  [<IsConst>] static member eight_k_rounded: IconData = nativeOnly
  [<IsConst>] static member eight_k_outlined: IconData = nativeOnly
  [<IsConst>] static member eight_k_plus: IconData = nativeOnly
  [<IsConst>] static member eight_k_plus_sharp: IconData = nativeOnly
  [<IsConst>] static member eight_k_plus_rounded: IconData = nativeOnly
  [<IsConst>] static member eight_k_plus_outlined: IconData = nativeOnly
  [<IsConst>] static member eight_mp: IconData = nativeOnly
  [<IsConst>] static member eight_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member eight_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member eight_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member nine_k: IconData = nativeOnly
  [<IsConst>] static member nine_k_sharp: IconData = nativeOnly
  [<IsConst>] static member nine_k_rounded: IconData = nativeOnly
  [<IsConst>] static member nine_k_outlined: IconData = nativeOnly
  [<IsConst>] static member nine_k_plus: IconData = nativeOnly
  [<IsConst>] static member nine_k_plus_sharp: IconData = nativeOnly
  [<IsConst>] static member nine_k_plus_rounded: IconData = nativeOnly
  [<IsConst>] static member nine_k_plus_outlined: IconData = nativeOnly
  [<IsConst>] static member nine_mp: IconData = nativeOnly
  [<IsConst>] static member nine_mp_sharp: IconData = nativeOnly
  [<IsConst>] static member nine_mp_rounded: IconData = nativeOnly
  [<IsConst>] static member nine_mp_outlined: IconData = nativeOnly
  [<IsConst>] static member abc: IconData = nativeOnly
  [<IsConst>] static member abc_sharp: IconData = nativeOnly
  [<IsConst>] static member abc_rounded: IconData = nativeOnly
  [<IsConst>] static member abc_outlined: IconData = nativeOnly
  [<IsConst>] static member ac_unit: IconData = nativeOnly
  [<IsConst>] static member ac_unit_sharp: IconData = nativeOnly
  [<IsConst>] static member ac_unit_rounded: IconData = nativeOnly
  [<IsConst>] static member ac_unit_outlined: IconData = nativeOnly
  [<IsConst>] static member access_alarm: IconData = nativeOnly
  [<IsConst>] static member access_alarm_sharp: IconData = nativeOnly
  [<IsConst>] static member access_alarm_rounded: IconData = nativeOnly
  [<IsConst>] static member access_alarm_outlined: IconData = nativeOnly
  [<IsConst>] static member access_alarms: IconData = nativeOnly
  [<IsConst>] static member access_alarms_sharp: IconData = nativeOnly
  [<IsConst>] static member access_alarms_rounded: IconData = nativeOnly
  [<IsConst>] static member access_alarms_outlined: IconData = nativeOnly
  [<IsConst>] static member access_time: IconData = nativeOnly
  [<IsConst>] static member access_time_sharp: IconData = nativeOnly
  [<IsConst>] static member access_time_rounded: IconData = nativeOnly
  [<IsConst>] static member access_time_outlined: IconData = nativeOnly
  [<IsConst>] static member access_time_filled: IconData = nativeOnly
  [<IsConst>] static member access_time_filled_sharp: IconData = nativeOnly
  [<IsConst>] static member access_time_filled_rounded: IconData = nativeOnly
  [<IsConst>] static member access_time_filled_outlined: IconData = nativeOnly
  [<IsConst>] static member accessibility: IconData = nativeOnly
  [<IsConst>] static member accessibility_sharp: IconData = nativeOnly
  [<IsConst>] static member accessibility_rounded: IconData = nativeOnly
  [<IsConst>] static member accessibility_outlined: IconData = nativeOnly
  [<IsConst>] static member accessibility_new: IconData = nativeOnly
  [<IsConst>] static member accessibility_new_sharp: IconData = nativeOnly
  [<IsConst>] static member accessibility_new_rounded: IconData = nativeOnly
  [<IsConst>] static member accessibility_new_outlined: IconData = nativeOnly
  [<IsConst>] static member accessible: IconData = nativeOnly
  [<IsConst>] static member accessible_sharp: IconData = nativeOnly
  [<IsConst>] static member accessible_rounded: IconData = nativeOnly
  [<IsConst>] static member accessible_outlined: IconData = nativeOnly
  [<IsConst>] static member accessible_forward: IconData = nativeOnly
  [<IsConst>] static member accessible_forward_sharp: IconData = nativeOnly
  [<IsConst>] static member accessible_forward_rounded: IconData = nativeOnly
  [<IsConst>] static member accessible_forward_outlined: IconData = nativeOnly
  [<IsConst>] static member account_balance: IconData = nativeOnly
  [<IsConst>] static member account_balance_sharp: IconData = nativeOnly
  [<IsConst>] static member account_balance_rounded: IconData = nativeOnly
  [<IsConst>] static member account_balance_outlined: IconData = nativeOnly
  [<IsConst>] static member account_balance_wallet: IconData = nativeOnly
  [<IsConst>] static member account_balance_wallet_sharp: IconData = nativeOnly
  [<IsConst>] static member account_balance_wallet_rounded: IconData = nativeOnly
  [<IsConst>] static member account_balance_wallet_outlined: IconData = nativeOnly
  [<IsConst>] static member account_box: IconData = nativeOnly
  [<IsConst>] static member account_box_sharp: IconData = nativeOnly
  [<IsConst>] static member account_box_rounded: IconData = nativeOnly
  [<IsConst>] static member account_box_outlined: IconData = nativeOnly
  [<IsConst>] static member account_circle: IconData = nativeOnly
  [<IsConst>] static member account_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member account_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member account_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member account_tree: IconData = nativeOnly
  [<IsConst>] static member account_tree_sharp: IconData = nativeOnly
  [<IsConst>] static member account_tree_rounded: IconData = nativeOnly
  [<IsConst>] static member account_tree_outlined: IconData = nativeOnly
  [<IsConst>] static member ad_units: IconData = nativeOnly
  [<IsConst>] static member ad_units_sharp: IconData = nativeOnly
  [<IsConst>] static member ad_units_rounded: IconData = nativeOnly
  [<IsConst>] static member ad_units_outlined: IconData = nativeOnly
  [<IsConst>] static member adb: IconData = nativeOnly
  [<IsConst>] static member adb_sharp: IconData = nativeOnly
  [<IsConst>] static member adb_rounded: IconData = nativeOnly
  [<IsConst>] static member adb_outlined: IconData = nativeOnly
  [<IsConst>] static member add: IconData = nativeOnly
  [<IsConst>] static member add_sharp: IconData = nativeOnly
  [<IsConst>] static member add_rounded: IconData = nativeOnly
  [<IsConst>] static member add_outlined: IconData = nativeOnly
  [<IsConst>] static member add_a_photo: IconData = nativeOnly
  [<IsConst>] static member add_a_photo_sharp: IconData = nativeOnly
  [<IsConst>] static member add_a_photo_rounded: IconData = nativeOnly
  [<IsConst>] static member add_a_photo_outlined: IconData = nativeOnly
  [<IsConst>] static member add_alarm: IconData = nativeOnly
  [<IsConst>] static member add_alarm_sharp: IconData = nativeOnly
  [<IsConst>] static member add_alarm_rounded: IconData = nativeOnly
  [<IsConst>] static member add_alarm_outlined: IconData = nativeOnly
  [<IsConst>] static member add_alert: IconData = nativeOnly
  [<IsConst>] static member add_alert_sharp: IconData = nativeOnly
  [<IsConst>] static member add_alert_rounded: IconData = nativeOnly
  [<IsConst>] static member add_alert_outlined: IconData = nativeOnly
  [<IsConst>] static member add_box: IconData = nativeOnly
  [<IsConst>] static member add_box_sharp: IconData = nativeOnly
  [<IsConst>] static member add_box_rounded: IconData = nativeOnly
  [<IsConst>] static member add_box_outlined: IconData = nativeOnly
  [<IsConst>] static member add_business: IconData = nativeOnly
  [<IsConst>] static member add_business_sharp: IconData = nativeOnly
  [<IsConst>] static member add_business_rounded: IconData = nativeOnly
  [<IsConst>] static member add_business_outlined: IconData = nativeOnly
  [<IsConst>] static member add_call: IconData = nativeOnly
  [<IsConst>] static member add_card: IconData = nativeOnly
  [<IsConst>] static member add_card_sharp: IconData = nativeOnly
  [<IsConst>] static member add_card_rounded: IconData = nativeOnly
  [<IsConst>] static member add_card_outlined: IconData = nativeOnly
  [<IsConst>] static member add_chart: IconData = nativeOnly
  [<IsConst>] static member add_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member add_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member add_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member add_circle: IconData = nativeOnly
  [<IsConst>] static member add_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member add_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member add_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member add_circle_outline: IconData = nativeOnly
  [<IsConst>] static member add_circle_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member add_circle_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member add_circle_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member add_comment: IconData = nativeOnly
  [<IsConst>] static member add_comment_sharp: IconData = nativeOnly
  [<IsConst>] static member add_comment_rounded: IconData = nativeOnly
  [<IsConst>] static member add_comment_outlined: IconData = nativeOnly
  [<IsConst>] static member add_home: IconData = nativeOnly
  [<IsConst>] static member add_home_sharp: IconData = nativeOnly
  [<IsConst>] static member add_home_rounded: IconData = nativeOnly
  [<IsConst>] static member add_home_outlined: IconData = nativeOnly
  [<IsConst>] static member add_home_work: IconData = nativeOnly
  [<IsConst>] static member add_home_work_sharp: IconData = nativeOnly
  [<IsConst>] static member add_home_work_rounded: IconData = nativeOnly
  [<IsConst>] static member add_home_work_outlined: IconData = nativeOnly
  [<IsConst>] static member add_ic_call: IconData = nativeOnly
  [<IsConst>] static member add_ic_call_sharp: IconData = nativeOnly
  [<IsConst>] static member add_ic_call_rounded: IconData = nativeOnly
  [<IsConst>] static member add_ic_call_outlined: IconData = nativeOnly
  [<IsConst>] static member add_link: IconData = nativeOnly
  [<IsConst>] static member add_link_sharp: IconData = nativeOnly
  [<IsConst>] static member add_link_rounded: IconData = nativeOnly
  [<IsConst>] static member add_link_outlined: IconData = nativeOnly
  [<IsConst>] static member add_location: IconData = nativeOnly
  [<IsConst>] static member add_location_sharp: IconData = nativeOnly
  [<IsConst>] static member add_location_rounded: IconData = nativeOnly
  [<IsConst>] static member add_location_outlined: IconData = nativeOnly
  [<IsConst>] static member add_location_alt: IconData = nativeOnly
  [<IsConst>] static member add_location_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member add_location_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member add_location_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member add_moderator: IconData = nativeOnly
  [<IsConst>] static member add_moderator_sharp: IconData = nativeOnly
  [<IsConst>] static member add_moderator_rounded: IconData = nativeOnly
  [<IsConst>] static member add_moderator_outlined: IconData = nativeOnly
  [<IsConst>] static member add_photo_alternate: IconData = nativeOnly
  [<IsConst>] static member add_photo_alternate_sharp: IconData = nativeOnly
  [<IsConst>] static member add_photo_alternate_rounded: IconData = nativeOnly
  [<IsConst>] static member add_photo_alternate_outlined: IconData = nativeOnly
  [<IsConst>] static member add_reaction: IconData = nativeOnly
  [<IsConst>] static member add_reaction_sharp: IconData = nativeOnly
  [<IsConst>] static member add_reaction_rounded: IconData = nativeOnly
  [<IsConst>] static member add_reaction_outlined: IconData = nativeOnly
  [<IsConst>] static member add_road: IconData = nativeOnly
  [<IsConst>] static member add_road_sharp: IconData = nativeOnly
  [<IsConst>] static member add_road_rounded: IconData = nativeOnly
  [<IsConst>] static member add_road_outlined: IconData = nativeOnly
  [<IsConst>] static member add_shopping_cart: IconData = nativeOnly
  [<IsConst>] static member add_shopping_cart_sharp: IconData = nativeOnly
  [<IsConst>] static member add_shopping_cart_rounded: IconData = nativeOnly
  [<IsConst>] static member add_shopping_cart_outlined: IconData = nativeOnly
  [<IsConst>] static member add_task: IconData = nativeOnly
  [<IsConst>] static member add_task_sharp: IconData = nativeOnly
  [<IsConst>] static member add_task_rounded: IconData = nativeOnly
  [<IsConst>] static member add_task_outlined: IconData = nativeOnly
  [<IsConst>] static member add_to_drive: IconData = nativeOnly
  [<IsConst>] static member add_to_drive_sharp: IconData = nativeOnly
  [<IsConst>] static member add_to_drive_rounded: IconData = nativeOnly
  [<IsConst>] static member add_to_drive_outlined: IconData = nativeOnly
  [<IsConst>] static member add_to_home_screen: IconData = nativeOnly
  [<IsConst>] static member add_to_home_screen_sharp: IconData = nativeOnly
  [<IsConst>] static member add_to_home_screen_rounded: IconData = nativeOnly
  [<IsConst>] static member add_to_home_screen_outlined: IconData = nativeOnly
  [<IsConst>] static member add_to_photos: IconData = nativeOnly
  [<IsConst>] static member add_to_photos_sharp: IconData = nativeOnly
  [<IsConst>] static member add_to_photos_rounded: IconData = nativeOnly
  [<IsConst>] static member add_to_photos_outlined: IconData = nativeOnly
  [<IsConst>] static member add_to_queue: IconData = nativeOnly
  [<IsConst>] static member add_to_queue_sharp: IconData = nativeOnly
  [<IsConst>] static member add_to_queue_rounded: IconData = nativeOnly
  [<IsConst>] static member add_to_queue_outlined: IconData = nativeOnly
  [<IsConst>] static member addchart: IconData = nativeOnly
  [<IsConst>] static member addchart_sharp: IconData = nativeOnly
  [<IsConst>] static member addchart_rounded: IconData = nativeOnly
  [<IsConst>] static member addchart_outlined: IconData = nativeOnly
  [<IsConst>] static member adf_scanner: IconData = nativeOnly
  [<IsConst>] static member adf_scanner_sharp: IconData = nativeOnly
  [<IsConst>] static member adf_scanner_rounded: IconData = nativeOnly
  [<IsConst>] static member adf_scanner_outlined: IconData = nativeOnly
  [<IsConst>] static member adjust: IconData = nativeOnly
  [<IsConst>] static member adjust_sharp: IconData = nativeOnly
  [<IsConst>] static member adjust_rounded: IconData = nativeOnly
  [<IsConst>] static member adjust_outlined: IconData = nativeOnly
  [<IsConst>] static member admin_panel_settings: IconData = nativeOnly
  [<IsConst>] static member admin_panel_settings_sharp: IconData = nativeOnly
  [<IsConst>] static member admin_panel_settings_rounded: IconData = nativeOnly
  [<IsConst>] static member admin_panel_settings_outlined: IconData = nativeOnly
  [<IsConst>] static member adobe: IconData = nativeOnly
  [<IsConst>] static member adobe_sharp: IconData = nativeOnly
  [<IsConst>] static member adobe_rounded: IconData = nativeOnly
  [<IsConst>] static member adobe_outlined: IconData = nativeOnly
  [<IsConst>] static member ads_click: IconData = nativeOnly
  [<IsConst>] static member ads_click_sharp: IconData = nativeOnly
  [<IsConst>] static member ads_click_rounded: IconData = nativeOnly
  [<IsConst>] static member ads_click_outlined: IconData = nativeOnly
  [<IsConst>] static member agriculture: IconData = nativeOnly
  [<IsConst>] static member agriculture_sharp: IconData = nativeOnly
  [<IsConst>] static member agriculture_rounded: IconData = nativeOnly
  [<IsConst>] static member agriculture_outlined: IconData = nativeOnly
  [<IsConst>] static member air: IconData = nativeOnly
  [<IsConst>] static member air_sharp: IconData = nativeOnly
  [<IsConst>] static member air_rounded: IconData = nativeOnly
  [<IsConst>] static member air_outlined: IconData = nativeOnly
  [<IsConst>] static member airline_seat_flat: IconData = nativeOnly
  [<IsConst>] static member airline_seat_flat_sharp: IconData = nativeOnly
  [<IsConst>] static member airline_seat_flat_rounded: IconData = nativeOnly
  [<IsConst>] static member airline_seat_flat_outlined: IconData = nativeOnly
  [<IsConst>] static member airline_seat_flat_angled: IconData = nativeOnly
  [<IsConst>] static member airline_seat_flat_angled_sharp: IconData = nativeOnly
  [<IsConst>] static member airline_seat_flat_angled_rounded: IconData = nativeOnly
  [<IsConst>] static member airline_seat_flat_angled_outlined: IconData = nativeOnly
  [<IsConst>] static member airline_seat_individual_suite: IconData = nativeOnly
  [<IsConst>] static member airline_seat_individual_suite_sharp: IconData = nativeOnly
  [<IsConst>] static member airline_seat_individual_suite_rounded: IconData = nativeOnly
  [<IsConst>] static member airline_seat_individual_suite_outlined: IconData = nativeOnly
  [<IsConst>] static member airline_seat_legroom_extra: IconData = nativeOnly
  [<IsConst>] static member airline_seat_legroom_extra_sharp: IconData = nativeOnly
  [<IsConst>] static member airline_seat_legroom_extra_rounded: IconData = nativeOnly
  [<IsConst>] static member airline_seat_legroom_extra_outlined: IconData = nativeOnly
  [<IsConst>] static member airline_seat_legroom_normal: IconData = nativeOnly
  [<IsConst>] static member airline_seat_legroom_normal_sharp: IconData = nativeOnly
  [<IsConst>] static member airline_seat_legroom_normal_rounded: IconData = nativeOnly
  [<IsConst>] static member airline_seat_legroom_normal_outlined: IconData = nativeOnly
  [<IsConst>] static member airline_seat_legroom_reduced: IconData = nativeOnly
  [<IsConst>] static member airline_seat_legroom_reduced_sharp: IconData = nativeOnly
  [<IsConst>] static member airline_seat_legroom_reduced_rounded: IconData = nativeOnly
  [<IsConst>] static member airline_seat_legroom_reduced_outlined: IconData = nativeOnly
  [<IsConst>] static member airline_seat_recline_extra: IconData = nativeOnly
  [<IsConst>] static member airline_seat_recline_extra_sharp: IconData = nativeOnly
  [<IsConst>] static member airline_seat_recline_extra_rounded: IconData = nativeOnly
  [<IsConst>] static member airline_seat_recline_extra_outlined: IconData = nativeOnly
  [<IsConst>] static member airline_seat_recline_normal: IconData = nativeOnly
  [<IsConst>] static member airline_seat_recline_normal_sharp: IconData = nativeOnly
  [<IsConst>] static member airline_seat_recline_normal_rounded: IconData = nativeOnly
  [<IsConst>] static member airline_seat_recline_normal_outlined: IconData = nativeOnly
  [<IsConst>] static member airline_stops: IconData = nativeOnly
  [<IsConst>] static member airline_stops_sharp: IconData = nativeOnly
  [<IsConst>] static member airline_stops_rounded: IconData = nativeOnly
  [<IsConst>] static member airline_stops_outlined: IconData = nativeOnly
  [<IsConst>] static member airlines: IconData = nativeOnly
  [<IsConst>] static member airlines_sharp: IconData = nativeOnly
  [<IsConst>] static member airlines_rounded: IconData = nativeOnly
  [<IsConst>] static member airlines_outlined: IconData = nativeOnly
  [<IsConst>] static member airplane_ticket: IconData = nativeOnly
  [<IsConst>] static member airplane_ticket_sharp: IconData = nativeOnly
  [<IsConst>] static member airplane_ticket_rounded: IconData = nativeOnly
  [<IsConst>] static member airplane_ticket_outlined: IconData = nativeOnly
  [<IsConst>] static member airplanemode_active: IconData = nativeOnly
  [<IsConst>] static member airplanemode_active_sharp: IconData = nativeOnly
  [<IsConst>] static member airplanemode_active_rounded: IconData = nativeOnly
  [<IsConst>] static member airplanemode_active_outlined: IconData = nativeOnly
  [<IsConst>] static member airplanemode_inactive: IconData = nativeOnly
  [<IsConst>] static member airplanemode_inactive_sharp: IconData = nativeOnly
  [<IsConst>] static member airplanemode_inactive_rounded: IconData = nativeOnly
  [<IsConst>] static member airplanemode_inactive_outlined: IconData = nativeOnly
  [<IsConst>] static member airplanemode_off: IconData = nativeOnly
  [<IsConst>] static member airplanemode_off_sharp: IconData = nativeOnly
  [<IsConst>] static member airplanemode_off_rounded: IconData = nativeOnly
  [<IsConst>] static member airplanemode_off_outlined: IconData = nativeOnly
  [<IsConst>] static member airplanemode_on: IconData = nativeOnly
  [<IsConst>] static member airplanemode_on_sharp: IconData = nativeOnly
  [<IsConst>] static member airplanemode_on_rounded: IconData = nativeOnly
  [<IsConst>] static member airplanemode_on_outlined: IconData = nativeOnly
  [<IsConst>] static member airplay: IconData = nativeOnly
  [<IsConst>] static member airplay_sharp: IconData = nativeOnly
  [<IsConst>] static member airplay_rounded: IconData = nativeOnly
  [<IsConst>] static member airplay_outlined: IconData = nativeOnly
  [<IsConst>] static member airport_shuttle: IconData = nativeOnly
  [<IsConst>] static member airport_shuttle_sharp: IconData = nativeOnly
  [<IsConst>] static member airport_shuttle_rounded: IconData = nativeOnly
  [<IsConst>] static member airport_shuttle_outlined: IconData = nativeOnly
  [<IsConst>] static member alarm: IconData = nativeOnly
  [<IsConst>] static member alarm_sharp: IconData = nativeOnly
  [<IsConst>] static member alarm_rounded: IconData = nativeOnly
  [<IsConst>] static member alarm_outlined: IconData = nativeOnly
  [<IsConst>] static member alarm_add: IconData = nativeOnly
  [<IsConst>] static member alarm_add_sharp: IconData = nativeOnly
  [<IsConst>] static member alarm_add_rounded: IconData = nativeOnly
  [<IsConst>] static member alarm_add_outlined: IconData = nativeOnly
  [<IsConst>] static member alarm_off: IconData = nativeOnly
  [<IsConst>] static member alarm_off_sharp: IconData = nativeOnly
  [<IsConst>] static member alarm_off_rounded: IconData = nativeOnly
  [<IsConst>] static member alarm_off_outlined: IconData = nativeOnly
  [<IsConst>] static member alarm_on: IconData = nativeOnly
  [<IsConst>] static member alarm_on_sharp: IconData = nativeOnly
  [<IsConst>] static member alarm_on_rounded: IconData = nativeOnly
  [<IsConst>] static member alarm_on_outlined: IconData = nativeOnly
  [<IsConst>] static member album: IconData = nativeOnly
  [<IsConst>] static member album_sharp: IconData = nativeOnly
  [<IsConst>] static member album_rounded: IconData = nativeOnly
  [<IsConst>] static member album_outlined: IconData = nativeOnly
  [<IsConst>] static member align_horizontal_center: IconData = nativeOnly
  [<IsConst>] static member align_horizontal_center_sharp: IconData = nativeOnly
  [<IsConst>] static member align_horizontal_center_rounded: IconData = nativeOnly
  [<IsConst>] static member align_horizontal_center_outlined: IconData = nativeOnly
  [<IsConst>] static member align_horizontal_left: IconData = nativeOnly
  [<IsConst>] static member align_horizontal_left_sharp: IconData = nativeOnly
  [<IsConst>] static member align_horizontal_left_rounded: IconData = nativeOnly
  [<IsConst>] static member align_horizontal_left_outlined: IconData = nativeOnly
  [<IsConst>] static member align_horizontal_right: IconData = nativeOnly
  [<IsConst>] static member align_horizontal_right_sharp: IconData = nativeOnly
  [<IsConst>] static member align_horizontal_right_rounded: IconData = nativeOnly
  [<IsConst>] static member align_horizontal_right_outlined: IconData = nativeOnly
  [<IsConst>] static member align_vertical_bottom: IconData = nativeOnly
  [<IsConst>] static member align_vertical_bottom_sharp: IconData = nativeOnly
  [<IsConst>] static member align_vertical_bottom_rounded: IconData = nativeOnly
  [<IsConst>] static member align_vertical_bottom_outlined: IconData = nativeOnly
  [<IsConst>] static member align_vertical_center: IconData = nativeOnly
  [<IsConst>] static member align_vertical_center_sharp: IconData = nativeOnly
  [<IsConst>] static member align_vertical_center_rounded: IconData = nativeOnly
  [<IsConst>] static member align_vertical_center_outlined: IconData = nativeOnly
  [<IsConst>] static member align_vertical_top: IconData = nativeOnly
  [<IsConst>] static member align_vertical_top_sharp: IconData = nativeOnly
  [<IsConst>] static member align_vertical_top_rounded: IconData = nativeOnly
  [<IsConst>] static member align_vertical_top_outlined: IconData = nativeOnly
  [<IsConst>] static member all_inbox: IconData = nativeOnly
  [<IsConst>] static member all_inbox_sharp: IconData = nativeOnly
  [<IsConst>] static member all_inbox_rounded: IconData = nativeOnly
  [<IsConst>] static member all_inbox_outlined: IconData = nativeOnly
  [<IsConst>] static member all_inclusive: IconData = nativeOnly
  [<IsConst>] static member all_inclusive_sharp: IconData = nativeOnly
  [<IsConst>] static member all_inclusive_rounded: IconData = nativeOnly
  [<IsConst>] static member all_inclusive_outlined: IconData = nativeOnly
  [<IsConst>] static member all_out: IconData = nativeOnly
  [<IsConst>] static member all_out_sharp: IconData = nativeOnly
  [<IsConst>] static member all_out_rounded: IconData = nativeOnly
  [<IsConst>] static member all_out_outlined: IconData = nativeOnly
  [<IsConst>] static member alt_route: IconData = nativeOnly
  [<IsConst>] static member alt_route_sharp: IconData = nativeOnly
  [<IsConst>] static member alt_route_rounded: IconData = nativeOnly
  [<IsConst>] static member alt_route_outlined: IconData = nativeOnly
  [<IsConst>] static member alternate_email: IconData = nativeOnly
  [<IsConst>] static member alternate_email_sharp: IconData = nativeOnly
  [<IsConst>] static member alternate_email_rounded: IconData = nativeOnly
  [<IsConst>] static member alternate_email_outlined: IconData = nativeOnly
  [<IsConst>] static member amp_stories: IconData = nativeOnly
  [<IsConst>] static member amp_stories_sharp: IconData = nativeOnly
  [<IsConst>] static member amp_stories_rounded: IconData = nativeOnly
  [<IsConst>] static member amp_stories_outlined: IconData = nativeOnly
  [<IsConst>] static member analytics: IconData = nativeOnly
  [<IsConst>] static member analytics_sharp: IconData = nativeOnly
  [<IsConst>] static member analytics_rounded: IconData = nativeOnly
  [<IsConst>] static member analytics_outlined: IconData = nativeOnly
  [<IsConst>] static member anchor: IconData = nativeOnly
  [<IsConst>] static member anchor_sharp: IconData = nativeOnly
  [<IsConst>] static member anchor_rounded: IconData = nativeOnly
  [<IsConst>] static member anchor_outlined: IconData = nativeOnly
  [<IsConst>] static member android: IconData = nativeOnly
  [<IsConst>] static member android_sharp: IconData = nativeOnly
  [<IsConst>] static member android_rounded: IconData = nativeOnly
  [<IsConst>] static member android_outlined: IconData = nativeOnly
  [<IsConst>] static member animation: IconData = nativeOnly
  [<IsConst>] static member animation_sharp: IconData = nativeOnly
  [<IsConst>] static member animation_rounded: IconData = nativeOnly
  [<IsConst>] static member animation_outlined: IconData = nativeOnly
  [<IsConst>] static member announcement: IconData = nativeOnly
  [<IsConst>] static member announcement_sharp: IconData = nativeOnly
  [<IsConst>] static member announcement_rounded: IconData = nativeOnly
  [<IsConst>] static member announcement_outlined: IconData = nativeOnly
  [<IsConst>] static member aod: IconData = nativeOnly
  [<IsConst>] static member aod_sharp: IconData = nativeOnly
  [<IsConst>] static member aod_rounded: IconData = nativeOnly
  [<IsConst>] static member aod_outlined: IconData = nativeOnly
  [<IsConst>] static member apartment: IconData = nativeOnly
  [<IsConst>] static member apartment_sharp: IconData = nativeOnly
  [<IsConst>] static member apartment_rounded: IconData = nativeOnly
  [<IsConst>] static member apartment_outlined: IconData = nativeOnly
  [<IsConst>] static member api: IconData = nativeOnly
  [<IsConst>] static member api_sharp: IconData = nativeOnly
  [<IsConst>] static member api_rounded: IconData = nativeOnly
  [<IsConst>] static member api_outlined: IconData = nativeOnly
  [<IsConst>] static member app_blocking: IconData = nativeOnly
  [<IsConst>] static member app_blocking_sharp: IconData = nativeOnly
  [<IsConst>] static member app_blocking_rounded: IconData = nativeOnly
  [<IsConst>] static member app_blocking_outlined: IconData = nativeOnly
  [<IsConst>] static member app_registration: IconData = nativeOnly
  [<IsConst>] static member app_registration_sharp: IconData = nativeOnly
  [<IsConst>] static member app_registration_rounded: IconData = nativeOnly
  [<IsConst>] static member app_registration_outlined: IconData = nativeOnly
  [<IsConst>] static member app_settings_alt: IconData = nativeOnly
  [<IsConst>] static member app_settings_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member app_settings_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member app_settings_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member app_shortcut: IconData = nativeOnly
  [<IsConst>] static member app_shortcut_sharp: IconData = nativeOnly
  [<IsConst>] static member app_shortcut_rounded: IconData = nativeOnly
  [<IsConst>] static member app_shortcut_outlined: IconData = nativeOnly
  [<IsConst>] static member apple: IconData = nativeOnly
  [<IsConst>] static member apple_sharp: IconData = nativeOnly
  [<IsConst>] static member apple_rounded: IconData = nativeOnly
  [<IsConst>] static member apple_outlined: IconData = nativeOnly
  [<IsConst>] static member approval: IconData = nativeOnly
  [<IsConst>] static member approval_sharp: IconData = nativeOnly
  [<IsConst>] static member approval_rounded: IconData = nativeOnly
  [<IsConst>] static member approval_outlined: IconData = nativeOnly
  [<IsConst>] static member apps: IconData = nativeOnly
  [<IsConst>] static member apps_sharp: IconData = nativeOnly
  [<IsConst>] static member apps_rounded: IconData = nativeOnly
  [<IsConst>] static member apps_outlined: IconData = nativeOnly
  [<IsConst>] static member apps_outage: IconData = nativeOnly
  [<IsConst>] static member apps_outage_sharp: IconData = nativeOnly
  [<IsConst>] static member apps_outage_rounded: IconData = nativeOnly
  [<IsConst>] static member apps_outage_outlined: IconData = nativeOnly
  [<IsConst>] static member architecture: IconData = nativeOnly
  [<IsConst>] static member architecture_sharp: IconData = nativeOnly
  [<IsConst>] static member architecture_rounded: IconData = nativeOnly
  [<IsConst>] static member architecture_outlined: IconData = nativeOnly
  [<IsConst>] static member archive: IconData = nativeOnly
  [<IsConst>] static member archive_sharp: IconData = nativeOnly
  [<IsConst>] static member archive_rounded: IconData = nativeOnly
  [<IsConst>] static member archive_outlined: IconData = nativeOnly
  [<IsConst>] static member area_chart: IconData = nativeOnly
  [<IsConst>] static member area_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member area_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member area_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_back: IconData = nativeOnly
  [<IsConst>] static member arrow_back_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_back_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_back_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_back_ios: IconData = nativeOnly
  [<IsConst>] static member arrow_back_ios_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_back_ios_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_back_ios_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_back_ios_new: IconData = nativeOnly
  [<IsConst>] static member arrow_back_ios_new_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_back_ios_new_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_back_ios_new_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_down: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_down_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_down_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_down_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_left: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_left_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_left_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_left_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_right: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_right_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_right_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_right_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_up: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_up_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_up_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_circle_up_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_downward: IconData = nativeOnly
  [<IsConst>] static member arrow_downward_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_downward_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_downward_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_drop_down: IconData = nativeOnly
  [<IsConst>] static member arrow_drop_down_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_drop_down_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_drop_down_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_drop_down_circle: IconData = nativeOnly
  [<IsConst>] static member arrow_drop_down_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_drop_down_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_drop_down_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_drop_up: IconData = nativeOnly
  [<IsConst>] static member arrow_drop_up_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_drop_up_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_drop_up_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_forward: IconData = nativeOnly
  [<IsConst>] static member arrow_forward_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_forward_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_forward_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_forward_ios: IconData = nativeOnly
  [<IsConst>] static member arrow_forward_ios_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_forward_ios_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_forward_ios_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_left: IconData = nativeOnly
  [<IsConst>] static member arrow_left_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_left_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_left_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_right: IconData = nativeOnly
  [<IsConst>] static member arrow_right_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_right_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_right_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_right_alt: IconData = nativeOnly
  [<IsConst>] static member arrow_right_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_right_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_right_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member arrow_upward: IconData = nativeOnly
  [<IsConst>] static member arrow_upward_sharp: IconData = nativeOnly
  [<IsConst>] static member arrow_upward_rounded: IconData = nativeOnly
  [<IsConst>] static member arrow_upward_outlined: IconData = nativeOnly
  [<IsConst>] static member art_track: IconData = nativeOnly
  [<IsConst>] static member art_track_sharp: IconData = nativeOnly
  [<IsConst>] static member art_track_rounded: IconData = nativeOnly
  [<IsConst>] static member art_track_outlined: IconData = nativeOnly
  [<IsConst>] static member article: IconData = nativeOnly
  [<IsConst>] static member article_sharp: IconData = nativeOnly
  [<IsConst>] static member article_rounded: IconData = nativeOnly
  [<IsConst>] static member article_outlined: IconData = nativeOnly
  [<IsConst>] static member aspect_ratio: IconData = nativeOnly
  [<IsConst>] static member aspect_ratio_sharp: IconData = nativeOnly
  [<IsConst>] static member aspect_ratio_rounded: IconData = nativeOnly
  [<IsConst>] static member aspect_ratio_outlined: IconData = nativeOnly
  [<IsConst>] static member assessment: IconData = nativeOnly
  [<IsConst>] static member assessment_sharp: IconData = nativeOnly
  [<IsConst>] static member assessment_rounded: IconData = nativeOnly
  [<IsConst>] static member assessment_outlined: IconData = nativeOnly
  [<IsConst>] static member assignment: IconData = nativeOnly
  [<IsConst>] static member assignment_sharp: IconData = nativeOnly
  [<IsConst>] static member assignment_rounded: IconData = nativeOnly
  [<IsConst>] static member assignment_outlined: IconData = nativeOnly
  [<IsConst>] static member assignment_ind: IconData = nativeOnly
  [<IsConst>] static member assignment_ind_sharp: IconData = nativeOnly
  [<IsConst>] static member assignment_ind_rounded: IconData = nativeOnly
  [<IsConst>] static member assignment_ind_outlined: IconData = nativeOnly
  [<IsConst>] static member assignment_late: IconData = nativeOnly
  [<IsConst>] static member assignment_late_sharp: IconData = nativeOnly
  [<IsConst>] static member assignment_late_rounded: IconData = nativeOnly
  [<IsConst>] static member assignment_late_outlined: IconData = nativeOnly
  [<IsConst>] static member assignment_return: IconData = nativeOnly
  [<IsConst>] static member assignment_return_sharp: IconData = nativeOnly
  [<IsConst>] static member assignment_return_rounded: IconData = nativeOnly
  [<IsConst>] static member assignment_return_outlined: IconData = nativeOnly
  [<IsConst>] static member assignment_returned: IconData = nativeOnly
  [<IsConst>] static member assignment_returned_sharp: IconData = nativeOnly
  [<IsConst>] static member assignment_returned_rounded: IconData = nativeOnly
  [<IsConst>] static member assignment_returned_outlined: IconData = nativeOnly
  [<IsConst>] static member assignment_turned_in: IconData = nativeOnly
  [<IsConst>] static member assignment_turned_in_sharp: IconData = nativeOnly
  [<IsConst>] static member assignment_turned_in_rounded: IconData = nativeOnly
  [<IsConst>] static member assignment_turned_in_outlined: IconData = nativeOnly
  [<IsConst>] static member assistant: IconData = nativeOnly
  [<IsConst>] static member assistant_sharp: IconData = nativeOnly
  [<IsConst>] static member assistant_rounded: IconData = nativeOnly
  [<IsConst>] static member assistant_outlined: IconData = nativeOnly
  [<IsConst>] static member assistant_direction: IconData = nativeOnly
  [<IsConst>] static member assistant_direction_sharp: IconData = nativeOnly
  [<IsConst>] static member assistant_direction_rounded: IconData = nativeOnly
  [<IsConst>] static member assistant_direction_outlined: IconData = nativeOnly
  [<IsConst>] static member assistant_navigation: IconData = nativeOnly
  [<IsConst>] static member assistant_photo: IconData = nativeOnly
  [<IsConst>] static member assistant_photo_sharp: IconData = nativeOnly
  [<IsConst>] static member assistant_photo_rounded: IconData = nativeOnly
  [<IsConst>] static member assistant_photo_outlined: IconData = nativeOnly
  [<IsConst>] static member assured_workload: IconData = nativeOnly
  [<IsConst>] static member assured_workload_sharp: IconData = nativeOnly
  [<IsConst>] static member assured_workload_rounded: IconData = nativeOnly
  [<IsConst>] static member assured_workload_outlined: IconData = nativeOnly
  [<IsConst>] static member atm: IconData = nativeOnly
  [<IsConst>] static member atm_sharp: IconData = nativeOnly
  [<IsConst>] static member atm_rounded: IconData = nativeOnly
  [<IsConst>] static member atm_outlined: IconData = nativeOnly
  [<IsConst>] static member attach_email: IconData = nativeOnly
  [<IsConst>] static member attach_email_sharp: IconData = nativeOnly
  [<IsConst>] static member attach_email_rounded: IconData = nativeOnly
  [<IsConst>] static member attach_email_outlined: IconData = nativeOnly
  [<IsConst>] static member attach_file: IconData = nativeOnly
  [<IsConst>] static member attach_file_sharp: IconData = nativeOnly
  [<IsConst>] static member attach_file_rounded: IconData = nativeOnly
  [<IsConst>] static member attach_file_outlined: IconData = nativeOnly
  [<IsConst>] static member attach_money: IconData = nativeOnly
  [<IsConst>] static member attach_money_sharp: IconData = nativeOnly
  [<IsConst>] static member attach_money_rounded: IconData = nativeOnly
  [<IsConst>] static member attach_money_outlined: IconData = nativeOnly
  [<IsConst>] static member attachment: IconData = nativeOnly
  [<IsConst>] static member attachment_sharp: IconData = nativeOnly
  [<IsConst>] static member attachment_rounded: IconData = nativeOnly
  [<IsConst>] static member attachment_outlined: IconData = nativeOnly
  [<IsConst>] static member attractions: IconData = nativeOnly
  [<IsConst>] static member attractions_sharp: IconData = nativeOnly
  [<IsConst>] static member attractions_rounded: IconData = nativeOnly
  [<IsConst>] static member attractions_outlined: IconData = nativeOnly
  [<IsConst>] static member attribution: IconData = nativeOnly
  [<IsConst>] static member attribution_sharp: IconData = nativeOnly
  [<IsConst>] static member attribution_rounded: IconData = nativeOnly
  [<IsConst>] static member attribution_outlined: IconData = nativeOnly
  [<IsConst>] static member audio_file: IconData = nativeOnly
  [<IsConst>] static member audio_file_sharp: IconData = nativeOnly
  [<IsConst>] static member audio_file_rounded: IconData = nativeOnly
  [<IsConst>] static member audio_file_outlined: IconData = nativeOnly
  [<IsConst>] static member audiotrack: IconData = nativeOnly
  [<IsConst>] static member audiotrack_sharp: IconData = nativeOnly
  [<IsConst>] static member audiotrack_rounded: IconData = nativeOnly
  [<IsConst>] static member audiotrack_outlined: IconData = nativeOnly
  [<IsConst>] static member auto_awesome: IconData = nativeOnly
  [<IsConst>] static member auto_awesome_sharp: IconData = nativeOnly
  [<IsConst>] static member auto_awesome_rounded: IconData = nativeOnly
  [<IsConst>] static member auto_awesome_outlined: IconData = nativeOnly
  [<IsConst>] static member auto_awesome_mosaic: IconData = nativeOnly
  [<IsConst>] static member auto_awesome_mosaic_sharp: IconData = nativeOnly
  [<IsConst>] static member auto_awesome_mosaic_rounded: IconData = nativeOnly
  [<IsConst>] static member auto_awesome_mosaic_outlined: IconData = nativeOnly
  [<IsConst>] static member auto_awesome_motion: IconData = nativeOnly
  [<IsConst>] static member auto_awesome_motion_sharp: IconData = nativeOnly
  [<IsConst>] static member auto_awesome_motion_rounded: IconData = nativeOnly
  [<IsConst>] static member auto_awesome_motion_outlined: IconData = nativeOnly
  [<IsConst>] static member auto_delete: IconData = nativeOnly
  [<IsConst>] static member auto_delete_sharp: IconData = nativeOnly
  [<IsConst>] static member auto_delete_rounded: IconData = nativeOnly
  [<IsConst>] static member auto_delete_outlined: IconData = nativeOnly
  [<IsConst>] static member auto_fix_high: IconData = nativeOnly
  [<IsConst>] static member auto_fix_high_sharp: IconData = nativeOnly
  [<IsConst>] static member auto_fix_high_rounded: IconData = nativeOnly
  [<IsConst>] static member auto_fix_high_outlined: IconData = nativeOnly
  [<IsConst>] static member auto_fix_normal: IconData = nativeOnly
  [<IsConst>] static member auto_fix_normal_sharp: IconData = nativeOnly
  [<IsConst>] static member auto_fix_normal_rounded: IconData = nativeOnly
  [<IsConst>] static member auto_fix_normal_outlined: IconData = nativeOnly
  [<IsConst>] static member auto_fix_off: IconData = nativeOnly
  [<IsConst>] static member auto_fix_off_sharp: IconData = nativeOnly
  [<IsConst>] static member auto_fix_off_rounded: IconData = nativeOnly
  [<IsConst>] static member auto_fix_off_outlined: IconData = nativeOnly
  [<IsConst>] static member auto_graph: IconData = nativeOnly
  [<IsConst>] static member auto_graph_sharp: IconData = nativeOnly
  [<IsConst>] static member auto_graph_rounded: IconData = nativeOnly
  [<IsConst>] static member auto_graph_outlined: IconData = nativeOnly
  [<IsConst>] static member auto_mode: IconData = nativeOnly
  [<IsConst>] static member auto_mode_sharp: IconData = nativeOnly
  [<IsConst>] static member auto_mode_rounded: IconData = nativeOnly
  [<IsConst>] static member auto_mode_outlined: IconData = nativeOnly
  [<IsConst>] static member auto_stories: IconData = nativeOnly
  [<IsConst>] static member auto_stories_sharp: IconData = nativeOnly
  [<IsConst>] static member auto_stories_rounded: IconData = nativeOnly
  [<IsConst>] static member auto_stories_outlined: IconData = nativeOnly
  [<IsConst>] static member autofps_select: IconData = nativeOnly
  [<IsConst>] static member autofps_select_sharp: IconData = nativeOnly
  [<IsConst>] static member autofps_select_rounded: IconData = nativeOnly
  [<IsConst>] static member autofps_select_outlined: IconData = nativeOnly
  [<IsConst>] static member autorenew: IconData = nativeOnly
  [<IsConst>] static member autorenew_sharp: IconData = nativeOnly
  [<IsConst>] static member autorenew_rounded: IconData = nativeOnly
  [<IsConst>] static member autorenew_outlined: IconData = nativeOnly
  [<IsConst>] static member av_timer: IconData = nativeOnly
  [<IsConst>] static member av_timer_sharp: IconData = nativeOnly
  [<IsConst>] static member av_timer_rounded: IconData = nativeOnly
  [<IsConst>] static member av_timer_outlined: IconData = nativeOnly
  [<IsConst>] static member baby_changing_station: IconData = nativeOnly
  [<IsConst>] static member baby_changing_station_sharp: IconData = nativeOnly
  [<IsConst>] static member baby_changing_station_rounded: IconData = nativeOnly
  [<IsConst>] static member baby_changing_station_outlined: IconData = nativeOnly
  [<IsConst>] static member back_hand: IconData = nativeOnly
  [<IsConst>] static member back_hand_sharp: IconData = nativeOnly
  [<IsConst>] static member back_hand_rounded: IconData = nativeOnly
  [<IsConst>] static member back_hand_outlined: IconData = nativeOnly
  [<IsConst>] static member backpack: IconData = nativeOnly
  [<IsConst>] static member backpack_sharp: IconData = nativeOnly
  [<IsConst>] static member backpack_rounded: IconData = nativeOnly
  [<IsConst>] static member backpack_outlined: IconData = nativeOnly
  [<IsConst>] static member backspace: IconData = nativeOnly
  [<IsConst>] static member backspace_sharp: IconData = nativeOnly
  [<IsConst>] static member backspace_rounded: IconData = nativeOnly
  [<IsConst>] static member backspace_outlined: IconData = nativeOnly
  [<IsConst>] static member backup: IconData = nativeOnly
  [<IsConst>] static member backup_sharp: IconData = nativeOnly
  [<IsConst>] static member backup_rounded: IconData = nativeOnly
  [<IsConst>] static member backup_outlined: IconData = nativeOnly
  [<IsConst>] static member backup_table: IconData = nativeOnly
  [<IsConst>] static member backup_table_sharp: IconData = nativeOnly
  [<IsConst>] static member backup_table_rounded: IconData = nativeOnly
  [<IsConst>] static member backup_table_outlined: IconData = nativeOnly
  [<IsConst>] static member badge: IconData = nativeOnly
  [<IsConst>] static member badge_sharp: IconData = nativeOnly
  [<IsConst>] static member badge_rounded: IconData = nativeOnly
  [<IsConst>] static member badge_outlined: IconData = nativeOnly
  [<IsConst>] static member bakery_dining: IconData = nativeOnly
  [<IsConst>] static member bakery_dining_sharp: IconData = nativeOnly
  [<IsConst>] static member bakery_dining_rounded: IconData = nativeOnly
  [<IsConst>] static member bakery_dining_outlined: IconData = nativeOnly
  [<IsConst>] static member balance: IconData = nativeOnly
  [<IsConst>] static member balance_sharp: IconData = nativeOnly
  [<IsConst>] static member balance_rounded: IconData = nativeOnly
  [<IsConst>] static member balance_outlined: IconData = nativeOnly
  [<IsConst>] static member balcony: IconData = nativeOnly
  [<IsConst>] static member balcony_sharp: IconData = nativeOnly
  [<IsConst>] static member balcony_rounded: IconData = nativeOnly
  [<IsConst>] static member balcony_outlined: IconData = nativeOnly
  [<IsConst>] static member ballot: IconData = nativeOnly
  [<IsConst>] static member ballot_sharp: IconData = nativeOnly
  [<IsConst>] static member ballot_rounded: IconData = nativeOnly
  [<IsConst>] static member ballot_outlined: IconData = nativeOnly
  [<IsConst>] static member bar_chart: IconData = nativeOnly
  [<IsConst>] static member bar_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member bar_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member bar_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member batch_prediction: IconData = nativeOnly
  [<IsConst>] static member batch_prediction_sharp: IconData = nativeOnly
  [<IsConst>] static member batch_prediction_rounded: IconData = nativeOnly
  [<IsConst>] static member batch_prediction_outlined: IconData = nativeOnly
  [<IsConst>] static member bathroom: IconData = nativeOnly
  [<IsConst>] static member bathroom_sharp: IconData = nativeOnly
  [<IsConst>] static member bathroom_rounded: IconData = nativeOnly
  [<IsConst>] static member bathroom_outlined: IconData = nativeOnly
  [<IsConst>] static member bathtub: IconData = nativeOnly
  [<IsConst>] static member bathtub_sharp: IconData = nativeOnly
  [<IsConst>] static member bathtub_rounded: IconData = nativeOnly
  [<IsConst>] static member bathtub_outlined: IconData = nativeOnly
  [<IsConst>] static member battery_0_bar: IconData = nativeOnly
  [<IsConst>] static member battery_0_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member battery_0_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member battery_0_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member battery_1_bar: IconData = nativeOnly
  [<IsConst>] static member battery_1_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member battery_1_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member battery_1_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member battery_2_bar: IconData = nativeOnly
  [<IsConst>] static member battery_2_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member battery_2_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member battery_2_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member battery_3_bar: IconData = nativeOnly
  [<IsConst>] static member battery_3_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member battery_3_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member battery_3_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member battery_4_bar: IconData = nativeOnly
  [<IsConst>] static member battery_4_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member battery_4_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member battery_4_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member battery_5_bar: IconData = nativeOnly
  [<IsConst>] static member battery_5_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member battery_5_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member battery_5_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member battery_6_bar: IconData = nativeOnly
  [<IsConst>] static member battery_6_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member battery_6_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member battery_6_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member battery_alert: IconData = nativeOnly
  [<IsConst>] static member battery_alert_sharp: IconData = nativeOnly
  [<IsConst>] static member battery_alert_rounded: IconData = nativeOnly
  [<IsConst>] static member battery_alert_outlined: IconData = nativeOnly
  [<IsConst>] static member battery_charging_full: IconData = nativeOnly
  [<IsConst>] static member battery_charging_full_sharp: IconData = nativeOnly
  [<IsConst>] static member battery_charging_full_rounded: IconData = nativeOnly
  [<IsConst>] static member battery_charging_full_outlined: IconData = nativeOnly
  [<IsConst>] static member battery_full: IconData = nativeOnly
  [<IsConst>] static member battery_full_sharp: IconData = nativeOnly
  [<IsConst>] static member battery_full_rounded: IconData = nativeOnly
  [<IsConst>] static member battery_full_outlined: IconData = nativeOnly
  [<IsConst>] static member battery_saver: IconData = nativeOnly
  [<IsConst>] static member battery_saver_sharp: IconData = nativeOnly
  [<IsConst>] static member battery_saver_rounded: IconData = nativeOnly
  [<IsConst>] static member battery_saver_outlined: IconData = nativeOnly
  [<IsConst>] static member battery_std: IconData = nativeOnly
  [<IsConst>] static member battery_std_sharp: IconData = nativeOnly
  [<IsConst>] static member battery_std_rounded: IconData = nativeOnly
  [<IsConst>] static member battery_std_outlined: IconData = nativeOnly
  [<IsConst>] static member battery_unknown: IconData = nativeOnly
  [<IsConst>] static member battery_unknown_sharp: IconData = nativeOnly
  [<IsConst>] static member battery_unknown_rounded: IconData = nativeOnly
  [<IsConst>] static member battery_unknown_outlined: IconData = nativeOnly
  [<IsConst>] static member beach_access: IconData = nativeOnly
  [<IsConst>] static member beach_access_sharp: IconData = nativeOnly
  [<IsConst>] static member beach_access_rounded: IconData = nativeOnly
  [<IsConst>] static member beach_access_outlined: IconData = nativeOnly
  [<IsConst>] static member bed: IconData = nativeOnly
  [<IsConst>] static member bed_sharp: IconData = nativeOnly
  [<IsConst>] static member bed_rounded: IconData = nativeOnly
  [<IsConst>] static member bed_outlined: IconData = nativeOnly
  [<IsConst>] static member bedroom_baby: IconData = nativeOnly
  [<IsConst>] static member bedroom_baby_sharp: IconData = nativeOnly
  [<IsConst>] static member bedroom_baby_rounded: IconData = nativeOnly
  [<IsConst>] static member bedroom_baby_outlined: IconData = nativeOnly
  [<IsConst>] static member bedroom_child: IconData = nativeOnly
  [<IsConst>] static member bedroom_child_sharp: IconData = nativeOnly
  [<IsConst>] static member bedroom_child_rounded: IconData = nativeOnly
  [<IsConst>] static member bedroom_child_outlined: IconData = nativeOnly
  [<IsConst>] static member bedroom_parent: IconData = nativeOnly
  [<IsConst>] static member bedroom_parent_sharp: IconData = nativeOnly
  [<IsConst>] static member bedroom_parent_rounded: IconData = nativeOnly
  [<IsConst>] static member bedroom_parent_outlined: IconData = nativeOnly
  [<IsConst>] static member bedtime: IconData = nativeOnly
  [<IsConst>] static member bedtime_sharp: IconData = nativeOnly
  [<IsConst>] static member bedtime_rounded: IconData = nativeOnly
  [<IsConst>] static member bedtime_outlined: IconData = nativeOnly
  [<IsConst>] static member bedtime_off: IconData = nativeOnly
  [<IsConst>] static member bedtime_off_sharp: IconData = nativeOnly
  [<IsConst>] static member bedtime_off_rounded: IconData = nativeOnly
  [<IsConst>] static member bedtime_off_outlined: IconData = nativeOnly
  [<IsConst>] static member beenhere: IconData = nativeOnly
  [<IsConst>] static member beenhere_sharp: IconData = nativeOnly
  [<IsConst>] static member beenhere_rounded: IconData = nativeOnly
  [<IsConst>] static member beenhere_outlined: IconData = nativeOnly
  [<IsConst>] static member bento: IconData = nativeOnly
  [<IsConst>] static member bento_sharp: IconData = nativeOnly
  [<IsConst>] static member bento_rounded: IconData = nativeOnly
  [<IsConst>] static member bento_outlined: IconData = nativeOnly
  [<IsConst>] static member bike_scooter: IconData = nativeOnly
  [<IsConst>] static member bike_scooter_sharp: IconData = nativeOnly
  [<IsConst>] static member bike_scooter_rounded: IconData = nativeOnly
  [<IsConst>] static member bike_scooter_outlined: IconData = nativeOnly
  [<IsConst>] static member biotech: IconData = nativeOnly
  [<IsConst>] static member biotech_sharp: IconData = nativeOnly
  [<IsConst>] static member biotech_rounded: IconData = nativeOnly
  [<IsConst>] static member biotech_outlined: IconData = nativeOnly
  [<IsConst>] static member blender: IconData = nativeOnly
  [<IsConst>] static member blender_sharp: IconData = nativeOnly
  [<IsConst>] static member blender_rounded: IconData = nativeOnly
  [<IsConst>] static member blender_outlined: IconData = nativeOnly
  [<IsConst>] static member blinds: IconData = nativeOnly
  [<IsConst>] static member blinds_sharp: IconData = nativeOnly
  [<IsConst>] static member blinds_rounded: IconData = nativeOnly
  [<IsConst>] static member blinds_outlined: IconData = nativeOnly
  [<IsConst>] static member blinds_closed: IconData = nativeOnly
  [<IsConst>] static member blinds_closed_sharp: IconData = nativeOnly
  [<IsConst>] static member blinds_closed_rounded: IconData = nativeOnly
  [<IsConst>] static member blinds_closed_outlined: IconData = nativeOnly
  [<IsConst>] static member block: IconData = nativeOnly
  [<IsConst>] static member block_sharp: IconData = nativeOnly
  [<IsConst>] static member block_rounded: IconData = nativeOnly
  [<IsConst>] static member block_outlined: IconData = nativeOnly
  [<IsConst>] static member block_flipped: IconData = nativeOnly
  [<IsConst>] static member bloodtype: IconData = nativeOnly
  [<IsConst>] static member bloodtype_sharp: IconData = nativeOnly
  [<IsConst>] static member bloodtype_rounded: IconData = nativeOnly
  [<IsConst>] static member bloodtype_outlined: IconData = nativeOnly
  [<IsConst>] static member bluetooth: IconData = nativeOnly
  [<IsConst>] static member bluetooth_sharp: IconData = nativeOnly
  [<IsConst>] static member bluetooth_rounded: IconData = nativeOnly
  [<IsConst>] static member bluetooth_outlined: IconData = nativeOnly
  [<IsConst>] static member bluetooth_audio: IconData = nativeOnly
  [<IsConst>] static member bluetooth_audio_sharp: IconData = nativeOnly
  [<IsConst>] static member bluetooth_audio_rounded: IconData = nativeOnly
  [<IsConst>] static member bluetooth_audio_outlined: IconData = nativeOnly
  [<IsConst>] static member bluetooth_connected: IconData = nativeOnly
  [<IsConst>] static member bluetooth_connected_sharp: IconData = nativeOnly
  [<IsConst>] static member bluetooth_connected_rounded: IconData = nativeOnly
  [<IsConst>] static member bluetooth_connected_outlined: IconData = nativeOnly
  [<IsConst>] static member bluetooth_disabled: IconData = nativeOnly
  [<IsConst>] static member bluetooth_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member bluetooth_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member bluetooth_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member bluetooth_drive: IconData = nativeOnly
  [<IsConst>] static member bluetooth_drive_sharp: IconData = nativeOnly
  [<IsConst>] static member bluetooth_drive_rounded: IconData = nativeOnly
  [<IsConst>] static member bluetooth_drive_outlined: IconData = nativeOnly
  [<IsConst>] static member bluetooth_searching: IconData = nativeOnly
  [<IsConst>] static member bluetooth_searching_sharp: IconData = nativeOnly
  [<IsConst>] static member bluetooth_searching_rounded: IconData = nativeOnly
  [<IsConst>] static member bluetooth_searching_outlined: IconData = nativeOnly
  [<IsConst>] static member blur_circular: IconData = nativeOnly
  [<IsConst>] static member blur_circular_sharp: IconData = nativeOnly
  [<IsConst>] static member blur_circular_rounded: IconData = nativeOnly
  [<IsConst>] static member blur_circular_outlined: IconData = nativeOnly
  [<IsConst>] static member blur_linear: IconData = nativeOnly
  [<IsConst>] static member blur_linear_sharp: IconData = nativeOnly
  [<IsConst>] static member blur_linear_rounded: IconData = nativeOnly
  [<IsConst>] static member blur_linear_outlined: IconData = nativeOnly
  [<IsConst>] static member blur_off: IconData = nativeOnly
  [<IsConst>] static member blur_off_sharp: IconData = nativeOnly
  [<IsConst>] static member blur_off_rounded: IconData = nativeOnly
  [<IsConst>] static member blur_off_outlined: IconData = nativeOnly
  [<IsConst>] static member blur_on: IconData = nativeOnly
  [<IsConst>] static member blur_on_sharp: IconData = nativeOnly
  [<IsConst>] static member blur_on_rounded: IconData = nativeOnly
  [<IsConst>] static member blur_on_outlined: IconData = nativeOnly
  [<IsConst>] static member bolt: IconData = nativeOnly
  [<IsConst>] static member bolt_sharp: IconData = nativeOnly
  [<IsConst>] static member bolt_rounded: IconData = nativeOnly
  [<IsConst>] static member bolt_outlined: IconData = nativeOnly
  [<IsConst>] static member book: IconData = nativeOnly
  [<IsConst>] static member book_sharp: IconData = nativeOnly
  [<IsConst>] static member book_rounded: IconData = nativeOnly
  [<IsConst>] static member book_outlined: IconData = nativeOnly
  [<IsConst>] static member book_online: IconData = nativeOnly
  [<IsConst>] static member book_online_sharp: IconData = nativeOnly
  [<IsConst>] static member book_online_rounded: IconData = nativeOnly
  [<IsConst>] static member book_online_outlined: IconData = nativeOnly
  [<IsConst>] static member bookmark: IconData = nativeOnly
  [<IsConst>] static member bookmark_sharp: IconData = nativeOnly
  [<IsConst>] static member bookmark_rounded: IconData = nativeOnly
  [<IsConst>] static member bookmark_outlined: IconData = nativeOnly
  [<IsConst>] static member bookmark_add: IconData = nativeOnly
  [<IsConst>] static member bookmark_add_sharp: IconData = nativeOnly
  [<IsConst>] static member bookmark_add_rounded: IconData = nativeOnly
  [<IsConst>] static member bookmark_add_outlined: IconData = nativeOnly
  [<IsConst>] static member bookmark_added: IconData = nativeOnly
  [<IsConst>] static member bookmark_added_sharp: IconData = nativeOnly
  [<IsConst>] static member bookmark_added_rounded: IconData = nativeOnly
  [<IsConst>] static member bookmark_added_outlined: IconData = nativeOnly
  [<IsConst>] static member bookmark_border: IconData = nativeOnly
  [<IsConst>] static member bookmark_border_sharp: IconData = nativeOnly
  [<IsConst>] static member bookmark_border_rounded: IconData = nativeOnly
  [<IsConst>] static member bookmark_border_outlined: IconData = nativeOnly
  [<IsConst>] static member bookmark_outline: IconData = nativeOnly
  [<IsConst>] static member bookmark_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member bookmark_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member bookmark_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member bookmark_remove: IconData = nativeOnly
  [<IsConst>] static member bookmark_remove_sharp: IconData = nativeOnly
  [<IsConst>] static member bookmark_remove_rounded: IconData = nativeOnly
  [<IsConst>] static member bookmark_remove_outlined: IconData = nativeOnly
  [<IsConst>] static member bookmarks: IconData = nativeOnly
  [<IsConst>] static member bookmarks_sharp: IconData = nativeOnly
  [<IsConst>] static member bookmarks_rounded: IconData = nativeOnly
  [<IsConst>] static member bookmarks_outlined: IconData = nativeOnly
  [<IsConst>] static member border_all: IconData = nativeOnly
  [<IsConst>] static member border_all_sharp: IconData = nativeOnly
  [<IsConst>] static member border_all_rounded: IconData = nativeOnly
  [<IsConst>] static member border_all_outlined: IconData = nativeOnly
  [<IsConst>] static member border_bottom: IconData = nativeOnly
  [<IsConst>] static member border_bottom_sharp: IconData = nativeOnly
  [<IsConst>] static member border_bottom_rounded: IconData = nativeOnly
  [<IsConst>] static member border_bottom_outlined: IconData = nativeOnly
  [<IsConst>] static member border_clear: IconData = nativeOnly
  [<IsConst>] static member border_clear_sharp: IconData = nativeOnly
  [<IsConst>] static member border_clear_rounded: IconData = nativeOnly
  [<IsConst>] static member border_clear_outlined: IconData = nativeOnly
  [<IsConst>] static member border_color: IconData = nativeOnly
  [<IsConst>] static member border_color_sharp: IconData = nativeOnly
  [<IsConst>] static member border_color_rounded: IconData = nativeOnly
  [<IsConst>] static member border_color_outlined: IconData = nativeOnly
  [<IsConst>] static member border_horizontal: IconData = nativeOnly
  [<IsConst>] static member border_horizontal_sharp: IconData = nativeOnly
  [<IsConst>] static member border_horizontal_rounded: IconData = nativeOnly
  [<IsConst>] static member border_horizontal_outlined: IconData = nativeOnly
  [<IsConst>] static member border_inner: IconData = nativeOnly
  [<IsConst>] static member border_inner_sharp: IconData = nativeOnly
  [<IsConst>] static member border_inner_rounded: IconData = nativeOnly
  [<IsConst>] static member border_inner_outlined: IconData = nativeOnly
  [<IsConst>] static member border_left: IconData = nativeOnly
  [<IsConst>] static member border_left_sharp: IconData = nativeOnly
  [<IsConst>] static member border_left_rounded: IconData = nativeOnly
  [<IsConst>] static member border_left_outlined: IconData = nativeOnly
  [<IsConst>] static member border_outer: IconData = nativeOnly
  [<IsConst>] static member border_outer_sharp: IconData = nativeOnly
  [<IsConst>] static member border_outer_rounded: IconData = nativeOnly
  [<IsConst>] static member border_outer_outlined: IconData = nativeOnly
  [<IsConst>] static member border_right: IconData = nativeOnly
  [<IsConst>] static member border_right_sharp: IconData = nativeOnly
  [<IsConst>] static member border_right_rounded: IconData = nativeOnly
  [<IsConst>] static member border_right_outlined: IconData = nativeOnly
  [<IsConst>] static member border_style: IconData = nativeOnly
  [<IsConst>] static member border_style_sharp: IconData = nativeOnly
  [<IsConst>] static member border_style_rounded: IconData = nativeOnly
  [<IsConst>] static member border_style_outlined: IconData = nativeOnly
  [<IsConst>] static member border_top: IconData = nativeOnly
  [<IsConst>] static member border_top_sharp: IconData = nativeOnly
  [<IsConst>] static member border_top_rounded: IconData = nativeOnly
  [<IsConst>] static member border_top_outlined: IconData = nativeOnly
  [<IsConst>] static member border_vertical: IconData = nativeOnly
  [<IsConst>] static member border_vertical_sharp: IconData = nativeOnly
  [<IsConst>] static member border_vertical_rounded: IconData = nativeOnly
  [<IsConst>] static member border_vertical_outlined: IconData = nativeOnly
  [<IsConst>] static member boy: IconData = nativeOnly
  [<IsConst>] static member boy_sharp: IconData = nativeOnly
  [<IsConst>] static member boy_rounded: IconData = nativeOnly
  [<IsConst>] static member boy_outlined: IconData = nativeOnly
  [<IsConst>] static member branding_watermark: IconData = nativeOnly
  [<IsConst>] static member branding_watermark_sharp: IconData = nativeOnly
  [<IsConst>] static member branding_watermark_rounded: IconData = nativeOnly
  [<IsConst>] static member branding_watermark_outlined: IconData = nativeOnly
  [<IsConst>] static member breakfast_dining: IconData = nativeOnly
  [<IsConst>] static member breakfast_dining_sharp: IconData = nativeOnly
  [<IsConst>] static member breakfast_dining_rounded: IconData = nativeOnly
  [<IsConst>] static member breakfast_dining_outlined: IconData = nativeOnly
  [<IsConst>] static member brightness_1: IconData = nativeOnly
  [<IsConst>] static member brightness_1_sharp: IconData = nativeOnly
  [<IsConst>] static member brightness_1_rounded: IconData = nativeOnly
  [<IsConst>] static member brightness_1_outlined: IconData = nativeOnly
  [<IsConst>] static member brightness_2: IconData = nativeOnly
  [<IsConst>] static member brightness_2_sharp: IconData = nativeOnly
  [<IsConst>] static member brightness_2_rounded: IconData = nativeOnly
  [<IsConst>] static member brightness_2_outlined: IconData = nativeOnly
  [<IsConst>] static member brightness_3: IconData = nativeOnly
  [<IsConst>] static member brightness_3_sharp: IconData = nativeOnly
  [<IsConst>] static member brightness_3_rounded: IconData = nativeOnly
  [<IsConst>] static member brightness_3_outlined: IconData = nativeOnly
  [<IsConst>] static member brightness_4: IconData = nativeOnly
  [<IsConst>] static member brightness_4_sharp: IconData = nativeOnly
  [<IsConst>] static member brightness_4_rounded: IconData = nativeOnly
  [<IsConst>] static member brightness_4_outlined: IconData = nativeOnly
  [<IsConst>] static member brightness_5: IconData = nativeOnly
  [<IsConst>] static member brightness_5_sharp: IconData = nativeOnly
  [<IsConst>] static member brightness_5_rounded: IconData = nativeOnly
  [<IsConst>] static member brightness_5_outlined: IconData = nativeOnly
  [<IsConst>] static member brightness_6: IconData = nativeOnly
  [<IsConst>] static member brightness_6_sharp: IconData = nativeOnly
  [<IsConst>] static member brightness_6_rounded: IconData = nativeOnly
  [<IsConst>] static member brightness_6_outlined: IconData = nativeOnly
  [<IsConst>] static member brightness_7: IconData = nativeOnly
  [<IsConst>] static member brightness_7_sharp: IconData = nativeOnly
  [<IsConst>] static member brightness_7_rounded: IconData = nativeOnly
  [<IsConst>] static member brightness_7_outlined: IconData = nativeOnly
  [<IsConst>] static member brightness_auto: IconData = nativeOnly
  [<IsConst>] static member brightness_auto_sharp: IconData = nativeOnly
  [<IsConst>] static member brightness_auto_rounded: IconData = nativeOnly
  [<IsConst>] static member brightness_auto_outlined: IconData = nativeOnly
  [<IsConst>] static member brightness_high: IconData = nativeOnly
  [<IsConst>] static member brightness_high_sharp: IconData = nativeOnly
  [<IsConst>] static member brightness_high_rounded: IconData = nativeOnly
  [<IsConst>] static member brightness_high_outlined: IconData = nativeOnly
  [<IsConst>] static member brightness_low: IconData = nativeOnly
  [<IsConst>] static member brightness_low_sharp: IconData = nativeOnly
  [<IsConst>] static member brightness_low_rounded: IconData = nativeOnly
  [<IsConst>] static member brightness_low_outlined: IconData = nativeOnly
  [<IsConst>] static member brightness_medium: IconData = nativeOnly
  [<IsConst>] static member brightness_medium_sharp: IconData = nativeOnly
  [<IsConst>] static member brightness_medium_rounded: IconData = nativeOnly
  [<IsConst>] static member brightness_medium_outlined: IconData = nativeOnly
  [<IsConst>] static member broadcast_on_home: IconData = nativeOnly
  [<IsConst>] static member broadcast_on_home_sharp: IconData = nativeOnly
  [<IsConst>] static member broadcast_on_home_rounded: IconData = nativeOnly
  [<IsConst>] static member broadcast_on_home_outlined: IconData = nativeOnly
  [<IsConst>] static member broadcast_on_personal: IconData = nativeOnly
  [<IsConst>] static member broadcast_on_personal_sharp: IconData = nativeOnly
  [<IsConst>] static member broadcast_on_personal_rounded: IconData = nativeOnly
  [<IsConst>] static member broadcast_on_personal_outlined: IconData = nativeOnly
  [<IsConst>] static member broken_image: IconData = nativeOnly
  [<IsConst>] static member broken_image_sharp: IconData = nativeOnly
  [<IsConst>] static member broken_image_rounded: IconData = nativeOnly
  [<IsConst>] static member broken_image_outlined: IconData = nativeOnly
  [<IsConst>] static member browse_gallery: IconData = nativeOnly
  [<IsConst>] static member browse_gallery_sharp: IconData = nativeOnly
  [<IsConst>] static member browse_gallery_rounded: IconData = nativeOnly
  [<IsConst>] static member browse_gallery_outlined: IconData = nativeOnly
  [<IsConst>] static member browser_not_supported: IconData = nativeOnly
  [<IsConst>] static member browser_not_supported_sharp: IconData = nativeOnly
  [<IsConst>] static member browser_not_supported_rounded: IconData = nativeOnly
  [<IsConst>] static member browser_not_supported_outlined: IconData = nativeOnly
  [<IsConst>] static member browser_updated: IconData = nativeOnly
  [<IsConst>] static member browser_updated_sharp: IconData = nativeOnly
  [<IsConst>] static member browser_updated_rounded: IconData = nativeOnly
  [<IsConst>] static member browser_updated_outlined: IconData = nativeOnly
  [<IsConst>] static member brunch_dining: IconData = nativeOnly
  [<IsConst>] static member brunch_dining_sharp: IconData = nativeOnly
  [<IsConst>] static member brunch_dining_rounded: IconData = nativeOnly
  [<IsConst>] static member brunch_dining_outlined: IconData = nativeOnly
  [<IsConst>] static member brush: IconData = nativeOnly
  [<IsConst>] static member brush_sharp: IconData = nativeOnly
  [<IsConst>] static member brush_rounded: IconData = nativeOnly
  [<IsConst>] static member brush_outlined: IconData = nativeOnly
  [<IsConst>] static member bubble_chart: IconData = nativeOnly
  [<IsConst>] static member bubble_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member bubble_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member bubble_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member bug_report: IconData = nativeOnly
  [<IsConst>] static member bug_report_sharp: IconData = nativeOnly
  [<IsConst>] static member bug_report_rounded: IconData = nativeOnly
  [<IsConst>] static member bug_report_outlined: IconData = nativeOnly
  [<IsConst>] static member build: IconData = nativeOnly
  [<IsConst>] static member build_sharp: IconData = nativeOnly
  [<IsConst>] static member build_rounded: IconData = nativeOnly
  [<IsConst>] static member build_outlined: IconData = nativeOnly
  [<IsConst>] static member build_circle: IconData = nativeOnly
  [<IsConst>] static member build_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member build_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member build_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member bungalow: IconData = nativeOnly
  [<IsConst>] static member bungalow_sharp: IconData = nativeOnly
  [<IsConst>] static member bungalow_rounded: IconData = nativeOnly
  [<IsConst>] static member bungalow_outlined: IconData = nativeOnly
  [<IsConst>] static member burst_mode: IconData = nativeOnly
  [<IsConst>] static member burst_mode_sharp: IconData = nativeOnly
  [<IsConst>] static member burst_mode_rounded: IconData = nativeOnly
  [<IsConst>] static member burst_mode_outlined: IconData = nativeOnly
  [<IsConst>] static member bus_alert: IconData = nativeOnly
  [<IsConst>] static member bus_alert_sharp: IconData = nativeOnly
  [<IsConst>] static member bus_alert_rounded: IconData = nativeOnly
  [<IsConst>] static member bus_alert_outlined: IconData = nativeOnly
  [<IsConst>] static member business: IconData = nativeOnly
  [<IsConst>] static member business_sharp: IconData = nativeOnly
  [<IsConst>] static member business_rounded: IconData = nativeOnly
  [<IsConst>] static member business_outlined: IconData = nativeOnly
  [<IsConst>] static member business_center: IconData = nativeOnly
  [<IsConst>] static member business_center_sharp: IconData = nativeOnly
  [<IsConst>] static member business_center_rounded: IconData = nativeOnly
  [<IsConst>] static member business_center_outlined: IconData = nativeOnly
  [<IsConst>] static member cabin: IconData = nativeOnly
  [<IsConst>] static member cabin_sharp: IconData = nativeOnly
  [<IsConst>] static member cabin_rounded: IconData = nativeOnly
  [<IsConst>] static member cabin_outlined: IconData = nativeOnly
  [<IsConst>] static member cable: IconData = nativeOnly
  [<IsConst>] static member cable_sharp: IconData = nativeOnly
  [<IsConst>] static member cable_rounded: IconData = nativeOnly
  [<IsConst>] static member cable_outlined: IconData = nativeOnly
  [<IsConst>] static member cached: IconData = nativeOnly
  [<IsConst>] static member cached_sharp: IconData = nativeOnly
  [<IsConst>] static member cached_rounded: IconData = nativeOnly
  [<IsConst>] static member cached_outlined: IconData = nativeOnly
  [<IsConst>] static member cake: IconData = nativeOnly
  [<IsConst>] static member cake_sharp: IconData = nativeOnly
  [<IsConst>] static member cake_rounded: IconData = nativeOnly
  [<IsConst>] static member cake_outlined: IconData = nativeOnly
  [<IsConst>] static member calculate: IconData = nativeOnly
  [<IsConst>] static member calculate_sharp: IconData = nativeOnly
  [<IsConst>] static member calculate_rounded: IconData = nativeOnly
  [<IsConst>] static member calculate_outlined: IconData = nativeOnly
  [<IsConst>] static member calendar_month: IconData = nativeOnly
  [<IsConst>] static member calendar_month_sharp: IconData = nativeOnly
  [<IsConst>] static member calendar_month_rounded: IconData = nativeOnly
  [<IsConst>] static member calendar_month_outlined: IconData = nativeOnly
  [<IsConst>] static member calendar_today: IconData = nativeOnly
  [<IsConst>] static member calendar_today_sharp: IconData = nativeOnly
  [<IsConst>] static member calendar_today_rounded: IconData = nativeOnly
  [<IsConst>] static member calendar_today_outlined: IconData = nativeOnly
  [<IsConst>] static member calendar_view_day: IconData = nativeOnly
  [<IsConst>] static member calendar_view_day_sharp: IconData = nativeOnly
  [<IsConst>] static member calendar_view_day_rounded: IconData = nativeOnly
  [<IsConst>] static member calendar_view_day_outlined: IconData = nativeOnly
  [<IsConst>] static member calendar_view_month: IconData = nativeOnly
  [<IsConst>] static member calendar_view_month_sharp: IconData = nativeOnly
  [<IsConst>] static member calendar_view_month_rounded: IconData = nativeOnly
  [<IsConst>] static member calendar_view_month_outlined: IconData = nativeOnly
  [<IsConst>] static member calendar_view_week: IconData = nativeOnly
  [<IsConst>] static member calendar_view_week_sharp: IconData = nativeOnly
  [<IsConst>] static member calendar_view_week_rounded: IconData = nativeOnly
  [<IsConst>] static member calendar_view_week_outlined: IconData = nativeOnly
  [<IsConst>] static member call: IconData = nativeOnly
  [<IsConst>] static member call_sharp: IconData = nativeOnly
  [<IsConst>] static member call_rounded: IconData = nativeOnly
  [<IsConst>] static member call_outlined: IconData = nativeOnly
  [<IsConst>] static member call_end: IconData = nativeOnly
  [<IsConst>] static member call_end_sharp: IconData = nativeOnly
  [<IsConst>] static member call_end_rounded: IconData = nativeOnly
  [<IsConst>] static member call_end_outlined: IconData = nativeOnly
  [<IsConst>] static member call_made: IconData = nativeOnly
  [<IsConst>] static member call_made_sharp: IconData = nativeOnly
  [<IsConst>] static member call_made_rounded: IconData = nativeOnly
  [<IsConst>] static member call_made_outlined: IconData = nativeOnly
  [<IsConst>] static member call_merge: IconData = nativeOnly
  [<IsConst>] static member call_merge_sharp: IconData = nativeOnly
  [<IsConst>] static member call_merge_rounded: IconData = nativeOnly
  [<IsConst>] static member call_merge_outlined: IconData = nativeOnly
  [<IsConst>] static member call_missed: IconData = nativeOnly
  [<IsConst>] static member call_missed_sharp: IconData = nativeOnly
  [<IsConst>] static member call_missed_rounded: IconData = nativeOnly
  [<IsConst>] static member call_missed_outlined: IconData = nativeOnly
  [<IsConst>] static member call_missed_outgoing: IconData = nativeOnly
  [<IsConst>] static member call_missed_outgoing_sharp: IconData = nativeOnly
  [<IsConst>] static member call_missed_outgoing_rounded: IconData = nativeOnly
  [<IsConst>] static member call_missed_outgoing_outlined: IconData = nativeOnly
  [<IsConst>] static member call_received: IconData = nativeOnly
  [<IsConst>] static member call_received_sharp: IconData = nativeOnly
  [<IsConst>] static member call_received_rounded: IconData = nativeOnly
  [<IsConst>] static member call_received_outlined: IconData = nativeOnly
  [<IsConst>] static member call_split: IconData = nativeOnly
  [<IsConst>] static member call_split_sharp: IconData = nativeOnly
  [<IsConst>] static member call_split_rounded: IconData = nativeOnly
  [<IsConst>] static member call_split_outlined: IconData = nativeOnly
  [<IsConst>] static member call_to_action: IconData = nativeOnly
  [<IsConst>] static member call_to_action_sharp: IconData = nativeOnly
  [<IsConst>] static member call_to_action_rounded: IconData = nativeOnly
  [<IsConst>] static member call_to_action_outlined: IconData = nativeOnly
  [<IsConst>] static member camera: IconData = nativeOnly
  [<IsConst>] static member camera_sharp: IconData = nativeOnly
  [<IsConst>] static member camera_rounded: IconData = nativeOnly
  [<IsConst>] static member camera_outlined: IconData = nativeOnly
  [<IsConst>] static member camera_alt: IconData = nativeOnly
  [<IsConst>] static member camera_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member camera_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member camera_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member camera_enhance: IconData = nativeOnly
  [<IsConst>] static member camera_enhance_sharp: IconData = nativeOnly
  [<IsConst>] static member camera_enhance_rounded: IconData = nativeOnly
  [<IsConst>] static member camera_enhance_outlined: IconData = nativeOnly
  [<IsConst>] static member camera_front: IconData = nativeOnly
  [<IsConst>] static member camera_front_sharp: IconData = nativeOnly
  [<IsConst>] static member camera_front_rounded: IconData = nativeOnly
  [<IsConst>] static member camera_front_outlined: IconData = nativeOnly
  [<IsConst>] static member camera_indoor: IconData = nativeOnly
  [<IsConst>] static member camera_indoor_sharp: IconData = nativeOnly
  [<IsConst>] static member camera_indoor_rounded: IconData = nativeOnly
  [<IsConst>] static member camera_indoor_outlined: IconData = nativeOnly
  [<IsConst>] static member camera_outdoor: IconData = nativeOnly
  [<IsConst>] static member camera_outdoor_sharp: IconData = nativeOnly
  [<IsConst>] static member camera_outdoor_rounded: IconData = nativeOnly
  [<IsConst>] static member camera_outdoor_outlined: IconData = nativeOnly
  [<IsConst>] static member camera_rear: IconData = nativeOnly
  [<IsConst>] static member camera_rear_sharp: IconData = nativeOnly
  [<IsConst>] static member camera_rear_rounded: IconData = nativeOnly
  [<IsConst>] static member camera_rear_outlined: IconData = nativeOnly
  [<IsConst>] static member camera_roll: IconData = nativeOnly
  [<IsConst>] static member camera_roll_sharp: IconData = nativeOnly
  [<IsConst>] static member camera_roll_rounded: IconData = nativeOnly
  [<IsConst>] static member camera_roll_outlined: IconData = nativeOnly
  [<IsConst>] static member cameraswitch: IconData = nativeOnly
  [<IsConst>] static member cameraswitch_sharp: IconData = nativeOnly
  [<IsConst>] static member cameraswitch_rounded: IconData = nativeOnly
  [<IsConst>] static member cameraswitch_outlined: IconData = nativeOnly
  [<IsConst>] static member campaign: IconData = nativeOnly
  [<IsConst>] static member campaign_sharp: IconData = nativeOnly
  [<IsConst>] static member campaign_rounded: IconData = nativeOnly
  [<IsConst>] static member campaign_outlined: IconData = nativeOnly
  [<IsConst>] static member cancel: IconData = nativeOnly
  [<IsConst>] static member cancel_sharp: IconData = nativeOnly
  [<IsConst>] static member cancel_rounded: IconData = nativeOnly
  [<IsConst>] static member cancel_outlined: IconData = nativeOnly
  [<IsConst>] static member cancel_presentation: IconData = nativeOnly
  [<IsConst>] static member cancel_presentation_sharp: IconData = nativeOnly
  [<IsConst>] static member cancel_presentation_rounded: IconData = nativeOnly
  [<IsConst>] static member cancel_presentation_outlined: IconData = nativeOnly
  [<IsConst>] static member cancel_schedule_send: IconData = nativeOnly
  [<IsConst>] static member cancel_schedule_send_sharp: IconData = nativeOnly
  [<IsConst>] static member cancel_schedule_send_rounded: IconData = nativeOnly
  [<IsConst>] static member cancel_schedule_send_outlined: IconData = nativeOnly
  [<IsConst>] static member candlestick_chart: IconData = nativeOnly
  [<IsConst>] static member candlestick_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member candlestick_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member candlestick_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member car_crash: IconData = nativeOnly
  [<IsConst>] static member car_crash_sharp: IconData = nativeOnly
  [<IsConst>] static member car_crash_rounded: IconData = nativeOnly
  [<IsConst>] static member car_crash_outlined: IconData = nativeOnly
  [<IsConst>] static member car_rental: IconData = nativeOnly
  [<IsConst>] static member car_rental_sharp: IconData = nativeOnly
  [<IsConst>] static member car_rental_rounded: IconData = nativeOnly
  [<IsConst>] static member car_rental_outlined: IconData = nativeOnly
  [<IsConst>] static member car_repair: IconData = nativeOnly
  [<IsConst>] static member car_repair_sharp: IconData = nativeOnly
  [<IsConst>] static member car_repair_rounded: IconData = nativeOnly
  [<IsConst>] static member car_repair_outlined: IconData = nativeOnly
  [<IsConst>] static member card_giftcard: IconData = nativeOnly
  [<IsConst>] static member card_giftcard_sharp: IconData = nativeOnly
  [<IsConst>] static member card_giftcard_rounded: IconData = nativeOnly
  [<IsConst>] static member card_giftcard_outlined: IconData = nativeOnly
  [<IsConst>] static member card_membership: IconData = nativeOnly
  [<IsConst>] static member card_membership_sharp: IconData = nativeOnly
  [<IsConst>] static member card_membership_rounded: IconData = nativeOnly
  [<IsConst>] static member card_membership_outlined: IconData = nativeOnly
  [<IsConst>] static member card_travel: IconData = nativeOnly
  [<IsConst>] static member card_travel_sharp: IconData = nativeOnly
  [<IsConst>] static member card_travel_rounded: IconData = nativeOnly
  [<IsConst>] static member card_travel_outlined: IconData = nativeOnly
  [<IsConst>] static member carpenter: IconData = nativeOnly
  [<IsConst>] static member carpenter_sharp: IconData = nativeOnly
  [<IsConst>] static member carpenter_rounded: IconData = nativeOnly
  [<IsConst>] static member carpenter_outlined: IconData = nativeOnly
  [<IsConst>] static member cases: IconData = nativeOnly
  [<IsConst>] static member cases_sharp: IconData = nativeOnly
  [<IsConst>] static member cases_rounded: IconData = nativeOnly
  [<IsConst>] static member cases_outlined: IconData = nativeOnly
  [<IsConst>] static member casino: IconData = nativeOnly
  [<IsConst>] static member casino_sharp: IconData = nativeOnly
  [<IsConst>] static member casino_rounded: IconData = nativeOnly
  [<IsConst>] static member casino_outlined: IconData = nativeOnly
  [<IsConst>] static member cast: IconData = nativeOnly
  [<IsConst>] static member cast_sharp: IconData = nativeOnly
  [<IsConst>] static member cast_rounded: IconData = nativeOnly
  [<IsConst>] static member cast_outlined: IconData = nativeOnly
  [<IsConst>] static member cast_connected: IconData = nativeOnly
  [<IsConst>] static member cast_connected_sharp: IconData = nativeOnly
  [<IsConst>] static member cast_connected_rounded: IconData = nativeOnly
  [<IsConst>] static member cast_connected_outlined: IconData = nativeOnly
  [<IsConst>] static member cast_for_education: IconData = nativeOnly
  [<IsConst>] static member cast_for_education_sharp: IconData = nativeOnly
  [<IsConst>] static member cast_for_education_rounded: IconData = nativeOnly
  [<IsConst>] static member cast_for_education_outlined: IconData = nativeOnly
  [<IsConst>] static member castle: IconData = nativeOnly
  [<IsConst>] static member castle_sharp: IconData = nativeOnly
  [<IsConst>] static member castle_rounded: IconData = nativeOnly
  [<IsConst>] static member castle_outlined: IconData = nativeOnly
  [<IsConst>] static member catching_pokemon: IconData = nativeOnly
  [<IsConst>] static member catching_pokemon_sharp: IconData = nativeOnly
  [<IsConst>] static member catching_pokemon_rounded: IconData = nativeOnly
  [<IsConst>] static member catching_pokemon_outlined: IconData = nativeOnly
  [<IsConst>] static member category: IconData = nativeOnly
  [<IsConst>] static member category_sharp: IconData = nativeOnly
  [<IsConst>] static member category_rounded: IconData = nativeOnly
  [<IsConst>] static member category_outlined: IconData = nativeOnly
  [<IsConst>] static member celebration: IconData = nativeOnly
  [<IsConst>] static member celebration_sharp: IconData = nativeOnly
  [<IsConst>] static member celebration_rounded: IconData = nativeOnly
  [<IsConst>] static member celebration_outlined: IconData = nativeOnly
  [<IsConst>] static member cell_tower: IconData = nativeOnly
  [<IsConst>] static member cell_tower_sharp: IconData = nativeOnly
  [<IsConst>] static member cell_tower_rounded: IconData = nativeOnly
  [<IsConst>] static member cell_tower_outlined: IconData = nativeOnly
  [<IsConst>] static member cell_wifi: IconData = nativeOnly
  [<IsConst>] static member cell_wifi_sharp: IconData = nativeOnly
  [<IsConst>] static member cell_wifi_rounded: IconData = nativeOnly
  [<IsConst>] static member cell_wifi_outlined: IconData = nativeOnly
  [<IsConst>] static member center_focus_strong: IconData = nativeOnly
  [<IsConst>] static member center_focus_strong_sharp: IconData = nativeOnly
  [<IsConst>] static member center_focus_strong_rounded: IconData = nativeOnly
  [<IsConst>] static member center_focus_strong_outlined: IconData = nativeOnly
  [<IsConst>] static member center_focus_weak: IconData = nativeOnly
  [<IsConst>] static member center_focus_weak_sharp: IconData = nativeOnly
  [<IsConst>] static member center_focus_weak_rounded: IconData = nativeOnly
  [<IsConst>] static member center_focus_weak_outlined: IconData = nativeOnly
  [<IsConst>] static member chair: IconData = nativeOnly
  [<IsConst>] static member chair_sharp: IconData = nativeOnly
  [<IsConst>] static member chair_rounded: IconData = nativeOnly
  [<IsConst>] static member chair_outlined: IconData = nativeOnly
  [<IsConst>] static member chair_alt: IconData = nativeOnly
  [<IsConst>] static member chair_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member chair_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member chair_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member chalet: IconData = nativeOnly
  [<IsConst>] static member chalet_sharp: IconData = nativeOnly
  [<IsConst>] static member chalet_rounded: IconData = nativeOnly
  [<IsConst>] static member chalet_outlined: IconData = nativeOnly
  [<IsConst>] static member change_circle: IconData = nativeOnly
  [<IsConst>] static member change_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member change_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member change_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member change_history: IconData = nativeOnly
  [<IsConst>] static member change_history_sharp: IconData = nativeOnly
  [<IsConst>] static member change_history_rounded: IconData = nativeOnly
  [<IsConst>] static member change_history_outlined: IconData = nativeOnly
  [<IsConst>] static member charging_station: IconData = nativeOnly
  [<IsConst>] static member charging_station_sharp: IconData = nativeOnly
  [<IsConst>] static member charging_station_rounded: IconData = nativeOnly
  [<IsConst>] static member charging_station_outlined: IconData = nativeOnly
  [<IsConst>] static member chat: IconData = nativeOnly
  [<IsConst>] static member chat_sharp: IconData = nativeOnly
  [<IsConst>] static member chat_rounded: IconData = nativeOnly
  [<IsConst>] static member chat_outlined: IconData = nativeOnly
  [<IsConst>] static member chat_bubble: IconData = nativeOnly
  [<IsConst>] static member chat_bubble_sharp: IconData = nativeOnly
  [<IsConst>] static member chat_bubble_rounded: IconData = nativeOnly
  [<IsConst>] static member chat_bubble_outlined: IconData = nativeOnly
  [<IsConst>] static member chat_bubble_outline: IconData = nativeOnly
  [<IsConst>] static member chat_bubble_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member chat_bubble_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member chat_bubble_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member check: IconData = nativeOnly
  [<IsConst>] static member check_sharp: IconData = nativeOnly
  [<IsConst>] static member check_rounded: IconData = nativeOnly
  [<IsConst>] static member check_outlined: IconData = nativeOnly
  [<IsConst>] static member check_box: IconData = nativeOnly
  [<IsConst>] static member check_box_sharp: IconData = nativeOnly
  [<IsConst>] static member check_box_rounded: IconData = nativeOnly
  [<IsConst>] static member check_box_outlined: IconData = nativeOnly
  [<IsConst>] static member check_box_outline_blank: IconData = nativeOnly
  [<IsConst>] static member check_box_outline_blank_sharp: IconData = nativeOnly
  [<IsConst>] static member check_box_outline_blank_rounded: IconData = nativeOnly
  [<IsConst>] static member check_box_outline_blank_outlined: IconData = nativeOnly
  [<IsConst>] static member check_circle: IconData = nativeOnly
  [<IsConst>] static member check_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member check_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member check_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member check_circle_outline: IconData = nativeOnly
  [<IsConst>] static member check_circle_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member check_circle_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member check_circle_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member checklist: IconData = nativeOnly
  [<IsConst>] static member checklist_sharp: IconData = nativeOnly
  [<IsConst>] static member checklist_rounded: IconData = nativeOnly
  [<IsConst>] static member checklist_outlined: IconData = nativeOnly
  [<IsConst>] static member checklist_rtl: IconData = nativeOnly
  [<IsConst>] static member checklist_rtl_sharp: IconData = nativeOnly
  [<IsConst>] static member checklist_rtl_rounded: IconData = nativeOnly
  [<IsConst>] static member checklist_rtl_outlined: IconData = nativeOnly
  [<IsConst>] static member checkroom: IconData = nativeOnly
  [<IsConst>] static member checkroom_sharp: IconData = nativeOnly
  [<IsConst>] static member checkroom_rounded: IconData = nativeOnly
  [<IsConst>] static member checkroom_outlined: IconData = nativeOnly
  [<IsConst>] static member chevron_left: IconData = nativeOnly
  [<IsConst>] static member chevron_left_sharp: IconData = nativeOnly
  [<IsConst>] static member chevron_left_rounded: IconData = nativeOnly
  [<IsConst>] static member chevron_left_outlined: IconData = nativeOnly
  [<IsConst>] static member chevron_right: IconData = nativeOnly
  [<IsConst>] static member chevron_right_sharp: IconData = nativeOnly
  [<IsConst>] static member chevron_right_rounded: IconData = nativeOnly
  [<IsConst>] static member chevron_right_outlined: IconData = nativeOnly
  [<IsConst>] static member child_care: IconData = nativeOnly
  [<IsConst>] static member child_care_sharp: IconData = nativeOnly
  [<IsConst>] static member child_care_rounded: IconData = nativeOnly
  [<IsConst>] static member child_care_outlined: IconData = nativeOnly
  [<IsConst>] static member child_friendly: IconData = nativeOnly
  [<IsConst>] static member child_friendly_sharp: IconData = nativeOnly
  [<IsConst>] static member child_friendly_rounded: IconData = nativeOnly
  [<IsConst>] static member child_friendly_outlined: IconData = nativeOnly
  [<IsConst>] static member chrome_reader_mode: IconData = nativeOnly
  [<IsConst>] static member chrome_reader_mode_sharp: IconData = nativeOnly
  [<IsConst>] static member chrome_reader_mode_rounded: IconData = nativeOnly
  [<IsConst>] static member chrome_reader_mode_outlined: IconData = nativeOnly
  [<IsConst>] static member church: IconData = nativeOnly
  [<IsConst>] static member church_sharp: IconData = nativeOnly
  [<IsConst>] static member church_rounded: IconData = nativeOnly
  [<IsConst>] static member church_outlined: IconData = nativeOnly
  [<IsConst>] static member circle: IconData = nativeOnly
  [<IsConst>] static member circle_sharp: IconData = nativeOnly
  [<IsConst>] static member circle_rounded: IconData = nativeOnly
  [<IsConst>] static member circle_outlined: IconData = nativeOnly
  [<IsConst>] static member circle_notifications: IconData = nativeOnly
  [<IsConst>] static member circle_notifications_sharp: IconData = nativeOnly
  [<IsConst>] static member circle_notifications_rounded: IconData = nativeOnly
  [<IsConst>] static member circle_notifications_outlined: IconData = nativeOnly
  [<IsConst>] static member class_: IconData = nativeOnly
  [<IsConst>] static member class_sharp: IconData = nativeOnly
  [<IsConst>] static member class_rounded: IconData = nativeOnly
  [<IsConst>] static member class_outlined: IconData = nativeOnly
  [<IsConst>] static member clean_hands: IconData = nativeOnly
  [<IsConst>] static member clean_hands_sharp: IconData = nativeOnly
  [<IsConst>] static member clean_hands_rounded: IconData = nativeOnly
  [<IsConst>] static member clean_hands_outlined: IconData = nativeOnly
  [<IsConst>] static member cleaning_services: IconData = nativeOnly
  [<IsConst>] static member cleaning_services_sharp: IconData = nativeOnly
  [<IsConst>] static member cleaning_services_rounded: IconData = nativeOnly
  [<IsConst>] static member cleaning_services_outlined: IconData = nativeOnly
  [<IsConst>] static member clear: IconData = nativeOnly
  [<IsConst>] static member clear_sharp: IconData = nativeOnly
  [<IsConst>] static member clear_rounded: IconData = nativeOnly
  [<IsConst>] static member clear_outlined: IconData = nativeOnly
  [<IsConst>] static member clear_all: IconData = nativeOnly
  [<IsConst>] static member clear_all_sharp: IconData = nativeOnly
  [<IsConst>] static member clear_all_rounded: IconData = nativeOnly
  [<IsConst>] static member clear_all_outlined: IconData = nativeOnly
  [<IsConst>] static member close: IconData = nativeOnly
  [<IsConst>] static member close_sharp: IconData = nativeOnly
  [<IsConst>] static member close_rounded: IconData = nativeOnly
  [<IsConst>] static member close_outlined: IconData = nativeOnly
  [<IsConst>] static member close_fullscreen: IconData = nativeOnly
  [<IsConst>] static member close_fullscreen_sharp: IconData = nativeOnly
  [<IsConst>] static member close_fullscreen_rounded: IconData = nativeOnly
  [<IsConst>] static member close_fullscreen_outlined: IconData = nativeOnly
  [<IsConst>] static member closed_caption: IconData = nativeOnly
  [<IsConst>] static member closed_caption_sharp: IconData = nativeOnly
  [<IsConst>] static member closed_caption_rounded: IconData = nativeOnly
  [<IsConst>] static member closed_caption_outlined: IconData = nativeOnly
  [<IsConst>] static member closed_caption_disabled: IconData = nativeOnly
  [<IsConst>] static member closed_caption_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member closed_caption_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member closed_caption_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member closed_caption_off: IconData = nativeOnly
  [<IsConst>] static member closed_caption_off_sharp: IconData = nativeOnly
  [<IsConst>] static member closed_caption_off_rounded: IconData = nativeOnly
  [<IsConst>] static member closed_caption_off_outlined: IconData = nativeOnly
  [<IsConst>] static member cloud: IconData = nativeOnly
  [<IsConst>] static member cloud_sharp: IconData = nativeOnly
  [<IsConst>] static member cloud_rounded: IconData = nativeOnly
  [<IsConst>] static member cloud_outlined: IconData = nativeOnly
  [<IsConst>] static member cloud_circle: IconData = nativeOnly
  [<IsConst>] static member cloud_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member cloud_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member cloud_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member cloud_done: IconData = nativeOnly
  [<IsConst>] static member cloud_done_sharp: IconData = nativeOnly
  [<IsConst>] static member cloud_done_rounded: IconData = nativeOnly
  [<IsConst>] static member cloud_done_outlined: IconData = nativeOnly
  [<IsConst>] static member cloud_download: IconData = nativeOnly
  [<IsConst>] static member cloud_download_sharp: IconData = nativeOnly
  [<IsConst>] static member cloud_download_rounded: IconData = nativeOnly
  [<IsConst>] static member cloud_download_outlined: IconData = nativeOnly
  [<IsConst>] static member cloud_off: IconData = nativeOnly
  [<IsConst>] static member cloud_off_sharp: IconData = nativeOnly
  [<IsConst>] static member cloud_off_rounded: IconData = nativeOnly
  [<IsConst>] static member cloud_off_outlined: IconData = nativeOnly
  [<IsConst>] static member cloud_queue: IconData = nativeOnly
  [<IsConst>] static member cloud_queue_sharp: IconData = nativeOnly
  [<IsConst>] static member cloud_queue_rounded: IconData = nativeOnly
  [<IsConst>] static member cloud_queue_outlined: IconData = nativeOnly
  [<IsConst>] static member cloud_sync: IconData = nativeOnly
  [<IsConst>] static member cloud_sync_sharp: IconData = nativeOnly
  [<IsConst>] static member cloud_sync_rounded: IconData = nativeOnly
  [<IsConst>] static member cloud_sync_outlined: IconData = nativeOnly
  [<IsConst>] static member cloud_upload: IconData = nativeOnly
  [<IsConst>] static member cloud_upload_sharp: IconData = nativeOnly
  [<IsConst>] static member cloud_upload_rounded: IconData = nativeOnly
  [<IsConst>] static member cloud_upload_outlined: IconData = nativeOnly
  [<IsConst>] static member cloudy_snowing: IconData = nativeOnly
  [<IsConst>] static member co2: IconData = nativeOnly
  [<IsConst>] static member co2_sharp: IconData = nativeOnly
  [<IsConst>] static member co2_rounded: IconData = nativeOnly
  [<IsConst>] static member co2_outlined: IconData = nativeOnly
  [<IsConst>] static member co_present: IconData = nativeOnly
  [<IsConst>] static member co_present_sharp: IconData = nativeOnly
  [<IsConst>] static member co_present_rounded: IconData = nativeOnly
  [<IsConst>] static member co_present_outlined: IconData = nativeOnly
  [<IsConst>] static member code: IconData = nativeOnly
  [<IsConst>] static member code_sharp: IconData = nativeOnly
  [<IsConst>] static member code_rounded: IconData = nativeOnly
  [<IsConst>] static member code_outlined: IconData = nativeOnly
  [<IsConst>] static member code_off: IconData = nativeOnly
  [<IsConst>] static member code_off_sharp: IconData = nativeOnly
  [<IsConst>] static member code_off_rounded: IconData = nativeOnly
  [<IsConst>] static member code_off_outlined: IconData = nativeOnly
  [<IsConst>] static member coffee: IconData = nativeOnly
  [<IsConst>] static member coffee_sharp: IconData = nativeOnly
  [<IsConst>] static member coffee_rounded: IconData = nativeOnly
  [<IsConst>] static member coffee_outlined: IconData = nativeOnly
  [<IsConst>] static member coffee_maker: IconData = nativeOnly
  [<IsConst>] static member coffee_maker_sharp: IconData = nativeOnly
  [<IsConst>] static member coffee_maker_rounded: IconData = nativeOnly
  [<IsConst>] static member coffee_maker_outlined: IconData = nativeOnly
  [<IsConst>] static member collections: IconData = nativeOnly
  [<IsConst>] static member collections_sharp: IconData = nativeOnly
  [<IsConst>] static member collections_rounded: IconData = nativeOnly
  [<IsConst>] static member collections_outlined: IconData = nativeOnly
  [<IsConst>] static member collections_bookmark: IconData = nativeOnly
  [<IsConst>] static member collections_bookmark_sharp: IconData = nativeOnly
  [<IsConst>] static member collections_bookmark_rounded: IconData = nativeOnly
  [<IsConst>] static member collections_bookmark_outlined: IconData = nativeOnly
  [<IsConst>] static member color_lens: IconData = nativeOnly
  [<IsConst>] static member color_lens_sharp: IconData = nativeOnly
  [<IsConst>] static member color_lens_rounded: IconData = nativeOnly
  [<IsConst>] static member color_lens_outlined: IconData = nativeOnly
  [<IsConst>] static member colorize: IconData = nativeOnly
  [<IsConst>] static member colorize_sharp: IconData = nativeOnly
  [<IsConst>] static member colorize_rounded: IconData = nativeOnly
  [<IsConst>] static member colorize_outlined: IconData = nativeOnly
  [<IsConst>] static member comment: IconData = nativeOnly
  [<IsConst>] static member comment_sharp: IconData = nativeOnly
  [<IsConst>] static member comment_rounded: IconData = nativeOnly
  [<IsConst>] static member comment_outlined: IconData = nativeOnly
  [<IsConst>] static member comment_bank: IconData = nativeOnly
  [<IsConst>] static member comment_bank_sharp: IconData = nativeOnly
  [<IsConst>] static member comment_bank_rounded: IconData = nativeOnly
  [<IsConst>] static member comment_bank_outlined: IconData = nativeOnly
  [<IsConst>] static member comments_disabled: IconData = nativeOnly
  [<IsConst>] static member comments_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member comments_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member comments_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member commit: IconData = nativeOnly
  [<IsConst>] static member commit_sharp: IconData = nativeOnly
  [<IsConst>] static member commit_rounded: IconData = nativeOnly
  [<IsConst>] static member commit_outlined: IconData = nativeOnly
  [<IsConst>] static member commute: IconData = nativeOnly
  [<IsConst>] static member commute_sharp: IconData = nativeOnly
  [<IsConst>] static member commute_rounded: IconData = nativeOnly
  [<IsConst>] static member commute_outlined: IconData = nativeOnly
  [<IsConst>] static member compare: IconData = nativeOnly
  [<IsConst>] static member compare_sharp: IconData = nativeOnly
  [<IsConst>] static member compare_rounded: IconData = nativeOnly
  [<IsConst>] static member compare_outlined: IconData = nativeOnly
  [<IsConst>] static member compare_arrows: IconData = nativeOnly
  [<IsConst>] static member compare_arrows_sharp: IconData = nativeOnly
  [<IsConst>] static member compare_arrows_rounded: IconData = nativeOnly
  [<IsConst>] static member compare_arrows_outlined: IconData = nativeOnly
  [<IsConst>] static member compass_calibration: IconData = nativeOnly
  [<IsConst>] static member compass_calibration_sharp: IconData = nativeOnly
  [<IsConst>] static member compass_calibration_rounded: IconData = nativeOnly
  [<IsConst>] static member compass_calibration_outlined: IconData = nativeOnly
  [<IsConst>] static member compost: IconData = nativeOnly
  [<IsConst>] static member compost_sharp: IconData = nativeOnly
  [<IsConst>] static member compost_rounded: IconData = nativeOnly
  [<IsConst>] static member compost_outlined: IconData = nativeOnly
  [<IsConst>] static member compress: IconData = nativeOnly
  [<IsConst>] static member compress_sharp: IconData = nativeOnly
  [<IsConst>] static member compress_rounded: IconData = nativeOnly
  [<IsConst>] static member compress_outlined: IconData = nativeOnly
  [<IsConst>] static member computer: IconData = nativeOnly
  [<IsConst>] static member computer_sharp: IconData = nativeOnly
  [<IsConst>] static member computer_rounded: IconData = nativeOnly
  [<IsConst>] static member computer_outlined: IconData = nativeOnly
  [<IsConst>] static member confirmation_num: IconData = nativeOnly
  [<IsConst>] static member confirmation_num_sharp: IconData = nativeOnly
  [<IsConst>] static member confirmation_num_rounded: IconData = nativeOnly
  [<IsConst>] static member confirmation_num_outlined: IconData = nativeOnly
  [<IsConst>] static member confirmation_number: IconData = nativeOnly
  [<IsConst>] static member confirmation_number_sharp: IconData = nativeOnly
  [<IsConst>] static member confirmation_number_rounded: IconData = nativeOnly
  [<IsConst>] static member confirmation_number_outlined: IconData = nativeOnly
  [<IsConst>] static member connect_without_contact: IconData = nativeOnly
  [<IsConst>] static member connect_without_contact_sharp: IconData = nativeOnly
  [<IsConst>] static member connect_without_contact_rounded: IconData = nativeOnly
  [<IsConst>] static member connect_without_contact_outlined: IconData = nativeOnly
  [<IsConst>] static member connected_tv: IconData = nativeOnly
  [<IsConst>] static member connected_tv_sharp: IconData = nativeOnly
  [<IsConst>] static member connected_tv_rounded: IconData = nativeOnly
  [<IsConst>] static member connected_tv_outlined: IconData = nativeOnly
  [<IsConst>] static member connecting_airports: IconData = nativeOnly
  [<IsConst>] static member connecting_airports_sharp: IconData = nativeOnly
  [<IsConst>] static member connecting_airports_rounded: IconData = nativeOnly
  [<IsConst>] static member connecting_airports_outlined: IconData = nativeOnly
  [<IsConst>] static member construction: IconData = nativeOnly
  [<IsConst>] static member construction_sharp: IconData = nativeOnly
  [<IsConst>] static member construction_rounded: IconData = nativeOnly
  [<IsConst>] static member construction_outlined: IconData = nativeOnly
  [<IsConst>] static member contact_mail: IconData = nativeOnly
  [<IsConst>] static member contact_mail_sharp: IconData = nativeOnly
  [<IsConst>] static member contact_mail_rounded: IconData = nativeOnly
  [<IsConst>] static member contact_mail_outlined: IconData = nativeOnly
  [<IsConst>] static member contact_page: IconData = nativeOnly
  [<IsConst>] static member contact_page_sharp: IconData = nativeOnly
  [<IsConst>] static member contact_page_rounded: IconData = nativeOnly
  [<IsConst>] static member contact_page_outlined: IconData = nativeOnly
  [<IsConst>] static member contact_phone: IconData = nativeOnly
  [<IsConst>] static member contact_phone_sharp: IconData = nativeOnly
  [<IsConst>] static member contact_phone_rounded: IconData = nativeOnly
  [<IsConst>] static member contact_phone_outlined: IconData = nativeOnly
  [<IsConst>] static member contact_support: IconData = nativeOnly
  [<IsConst>] static member contact_support_sharp: IconData = nativeOnly
  [<IsConst>] static member contact_support_rounded: IconData = nativeOnly
  [<IsConst>] static member contact_support_outlined: IconData = nativeOnly
  [<IsConst>] static member contactless: IconData = nativeOnly
  [<IsConst>] static member contactless_sharp: IconData = nativeOnly
  [<IsConst>] static member contactless_rounded: IconData = nativeOnly
  [<IsConst>] static member contactless_outlined: IconData = nativeOnly
  [<IsConst>] static member contacts: IconData = nativeOnly
  [<IsConst>] static member contacts_sharp: IconData = nativeOnly
  [<IsConst>] static member contacts_rounded: IconData = nativeOnly
  [<IsConst>] static member contacts_outlined: IconData = nativeOnly
  [<IsConst>] static member content_copy: IconData = nativeOnly
  [<IsConst>] static member content_copy_sharp: IconData = nativeOnly
  [<IsConst>] static member content_copy_rounded: IconData = nativeOnly
  [<IsConst>] static member content_copy_outlined: IconData = nativeOnly
  [<IsConst>] static member content_cut: IconData = nativeOnly
  [<IsConst>] static member content_cut_sharp: IconData = nativeOnly
  [<IsConst>] static member content_cut_rounded: IconData = nativeOnly
  [<IsConst>] static member content_cut_outlined: IconData = nativeOnly
  [<IsConst>] static member content_paste: IconData = nativeOnly
  [<IsConst>] static member content_paste_sharp: IconData = nativeOnly
  [<IsConst>] static member content_paste_rounded: IconData = nativeOnly
  [<IsConst>] static member content_paste_outlined: IconData = nativeOnly
  [<IsConst>] static member content_paste_go: IconData = nativeOnly
  [<IsConst>] static member content_paste_go_sharp: IconData = nativeOnly
  [<IsConst>] static member content_paste_go_rounded: IconData = nativeOnly
  [<IsConst>] static member content_paste_go_outlined: IconData = nativeOnly
  [<IsConst>] static member content_paste_off: IconData = nativeOnly
  [<IsConst>] static member content_paste_off_sharp: IconData = nativeOnly
  [<IsConst>] static member content_paste_off_rounded: IconData = nativeOnly
  [<IsConst>] static member content_paste_off_outlined: IconData = nativeOnly
  [<IsConst>] static member content_paste_search: IconData = nativeOnly
  [<IsConst>] static member content_paste_search_sharp: IconData = nativeOnly
  [<IsConst>] static member content_paste_search_rounded: IconData = nativeOnly
  [<IsConst>] static member content_paste_search_outlined: IconData = nativeOnly
  [<IsConst>] static member contrast: IconData = nativeOnly
  [<IsConst>] static member contrast_sharp: IconData = nativeOnly
  [<IsConst>] static member contrast_rounded: IconData = nativeOnly
  [<IsConst>] static member contrast_outlined: IconData = nativeOnly
  [<IsConst>] static member control_camera: IconData = nativeOnly
  [<IsConst>] static member control_camera_sharp: IconData = nativeOnly
  [<IsConst>] static member control_camera_rounded: IconData = nativeOnly
  [<IsConst>] static member control_camera_outlined: IconData = nativeOnly
  [<IsConst>] static member control_point: IconData = nativeOnly
  [<IsConst>] static member control_point_sharp: IconData = nativeOnly
  [<IsConst>] static member control_point_rounded: IconData = nativeOnly
  [<IsConst>] static member control_point_outlined: IconData = nativeOnly
  [<IsConst>] static member control_point_duplicate: IconData = nativeOnly
  [<IsConst>] static member control_point_duplicate_sharp: IconData = nativeOnly
  [<IsConst>] static member control_point_duplicate_rounded: IconData = nativeOnly
  [<IsConst>] static member control_point_duplicate_outlined: IconData = nativeOnly
  [<IsConst>] static member cookie: IconData = nativeOnly
  [<IsConst>] static member cookie_sharp: IconData = nativeOnly
  [<IsConst>] static member cookie_rounded: IconData = nativeOnly
  [<IsConst>] static member cookie_outlined: IconData = nativeOnly
  [<IsConst>] static member copy: IconData = nativeOnly
  [<IsConst>] static member copy_sharp: IconData = nativeOnly
  [<IsConst>] static member copy_rounded: IconData = nativeOnly
  [<IsConst>] static member copy_outlined: IconData = nativeOnly
  [<IsConst>] static member copy_all: IconData = nativeOnly
  [<IsConst>] static member copy_all_sharp: IconData = nativeOnly
  [<IsConst>] static member copy_all_rounded: IconData = nativeOnly
  [<IsConst>] static member copy_all_outlined: IconData = nativeOnly
  [<IsConst>] static member copyright: IconData = nativeOnly
  [<IsConst>] static member copyright_sharp: IconData = nativeOnly
  [<IsConst>] static member copyright_rounded: IconData = nativeOnly
  [<IsConst>] static member copyright_outlined: IconData = nativeOnly
  [<IsConst>] static member coronavirus: IconData = nativeOnly
  [<IsConst>] static member coronavirus_sharp: IconData = nativeOnly
  [<IsConst>] static member coronavirus_rounded: IconData = nativeOnly
  [<IsConst>] static member coronavirus_outlined: IconData = nativeOnly
  [<IsConst>] static member corporate_fare: IconData = nativeOnly
  [<IsConst>] static member corporate_fare_sharp: IconData = nativeOnly
  [<IsConst>] static member corporate_fare_rounded: IconData = nativeOnly
  [<IsConst>] static member corporate_fare_outlined: IconData = nativeOnly
  [<IsConst>] static member cottage: IconData = nativeOnly
  [<IsConst>] static member cottage_sharp: IconData = nativeOnly
  [<IsConst>] static member cottage_rounded: IconData = nativeOnly
  [<IsConst>] static member cottage_outlined: IconData = nativeOnly
  [<IsConst>] static member countertops: IconData = nativeOnly
  [<IsConst>] static member countertops_sharp: IconData = nativeOnly
  [<IsConst>] static member countertops_rounded: IconData = nativeOnly
  [<IsConst>] static member countertops_outlined: IconData = nativeOnly
  [<IsConst>] static member create: IconData = nativeOnly
  [<IsConst>] static member create_sharp: IconData = nativeOnly
  [<IsConst>] static member create_rounded: IconData = nativeOnly
  [<IsConst>] static member create_outlined: IconData = nativeOnly
  [<IsConst>] static member create_new_folder: IconData = nativeOnly
  [<IsConst>] static member create_new_folder_sharp: IconData = nativeOnly
  [<IsConst>] static member create_new_folder_rounded: IconData = nativeOnly
  [<IsConst>] static member create_new_folder_outlined: IconData = nativeOnly
  [<IsConst>] static member credit_card: IconData = nativeOnly
  [<IsConst>] static member credit_card_sharp: IconData = nativeOnly
  [<IsConst>] static member credit_card_rounded: IconData = nativeOnly
  [<IsConst>] static member credit_card_outlined: IconData = nativeOnly
  [<IsConst>] static member credit_card_off: IconData = nativeOnly
  [<IsConst>] static member credit_card_off_sharp: IconData = nativeOnly
  [<IsConst>] static member credit_card_off_rounded: IconData = nativeOnly
  [<IsConst>] static member credit_card_off_outlined: IconData = nativeOnly
  [<IsConst>] static member credit_score: IconData = nativeOnly
  [<IsConst>] static member credit_score_sharp: IconData = nativeOnly
  [<IsConst>] static member credit_score_rounded: IconData = nativeOnly
  [<IsConst>] static member credit_score_outlined: IconData = nativeOnly
  [<IsConst>] static member crib: IconData = nativeOnly
  [<IsConst>] static member crib_sharp: IconData = nativeOnly
  [<IsConst>] static member crib_rounded: IconData = nativeOnly
  [<IsConst>] static member crib_outlined: IconData = nativeOnly
  [<IsConst>] static member crisis_alert: IconData = nativeOnly
  [<IsConst>] static member crisis_alert_sharp: IconData = nativeOnly
  [<IsConst>] static member crisis_alert_rounded: IconData = nativeOnly
  [<IsConst>] static member crisis_alert_outlined: IconData = nativeOnly
  [<IsConst>] static member crop: IconData = nativeOnly
  [<IsConst>] static member crop_sharp: IconData = nativeOnly
  [<IsConst>] static member crop_rounded: IconData = nativeOnly
  [<IsConst>] static member crop_outlined: IconData = nativeOnly
  [<IsConst>] static member crop_16_9: IconData = nativeOnly
  [<IsConst>] static member crop_16_9_sharp: IconData = nativeOnly
  [<IsConst>] static member crop_16_9_rounded: IconData = nativeOnly
  [<IsConst>] static member crop_16_9_outlined: IconData = nativeOnly
  [<IsConst>] static member crop_3_2: IconData = nativeOnly
  [<IsConst>] static member crop_3_2_sharp: IconData = nativeOnly
  [<IsConst>] static member crop_3_2_rounded: IconData = nativeOnly
  [<IsConst>] static member crop_3_2_outlined: IconData = nativeOnly
  [<IsConst>] static member crop_5_4: IconData = nativeOnly
  [<IsConst>] static member crop_5_4_sharp: IconData = nativeOnly
  [<IsConst>] static member crop_5_4_rounded: IconData = nativeOnly
  [<IsConst>] static member crop_5_4_outlined: IconData = nativeOnly
  [<IsConst>] static member crop_7_5: IconData = nativeOnly
  [<IsConst>] static member crop_7_5_sharp: IconData = nativeOnly
  [<IsConst>] static member crop_7_5_rounded: IconData = nativeOnly
  [<IsConst>] static member crop_7_5_outlined: IconData = nativeOnly
  [<IsConst>] static member crop_din: IconData = nativeOnly
  [<IsConst>] static member crop_din_sharp: IconData = nativeOnly
  [<IsConst>] static member crop_din_rounded: IconData = nativeOnly
  [<IsConst>] static member crop_din_outlined: IconData = nativeOnly
  [<IsConst>] static member crop_free: IconData = nativeOnly
  [<IsConst>] static member crop_free_sharp: IconData = nativeOnly
  [<IsConst>] static member crop_free_rounded: IconData = nativeOnly
  [<IsConst>] static member crop_free_outlined: IconData = nativeOnly
  [<IsConst>] static member crop_landscape: IconData = nativeOnly
  [<IsConst>] static member crop_landscape_sharp: IconData = nativeOnly
  [<IsConst>] static member crop_landscape_rounded: IconData = nativeOnly
  [<IsConst>] static member crop_landscape_outlined: IconData = nativeOnly
  [<IsConst>] static member crop_original: IconData = nativeOnly
  [<IsConst>] static member crop_original_sharp: IconData = nativeOnly
  [<IsConst>] static member crop_original_rounded: IconData = nativeOnly
  [<IsConst>] static member crop_original_outlined: IconData = nativeOnly
  [<IsConst>] static member crop_portrait: IconData = nativeOnly
  [<IsConst>] static member crop_portrait_sharp: IconData = nativeOnly
  [<IsConst>] static member crop_portrait_rounded: IconData = nativeOnly
  [<IsConst>] static member crop_portrait_outlined: IconData = nativeOnly
  [<IsConst>] static member crop_rotate: IconData = nativeOnly
  [<IsConst>] static member crop_rotate_sharp: IconData = nativeOnly
  [<IsConst>] static member crop_rotate_rounded: IconData = nativeOnly
  [<IsConst>] static member crop_rotate_outlined: IconData = nativeOnly
  [<IsConst>] static member crop_square: IconData = nativeOnly
  [<IsConst>] static member crop_square_sharp: IconData = nativeOnly
  [<IsConst>] static member crop_square_rounded: IconData = nativeOnly
  [<IsConst>] static member crop_square_outlined: IconData = nativeOnly
  [<IsConst>] static member cruelty_free: IconData = nativeOnly
  [<IsConst>] static member cruelty_free_sharp: IconData = nativeOnly
  [<IsConst>] static member cruelty_free_rounded: IconData = nativeOnly
  [<IsConst>] static member cruelty_free_outlined: IconData = nativeOnly
  [<IsConst>] static member css: IconData = nativeOnly
  [<IsConst>] static member css_sharp: IconData = nativeOnly
  [<IsConst>] static member css_rounded: IconData = nativeOnly
  [<IsConst>] static member css_outlined: IconData = nativeOnly
  [<IsConst>] static member currency_bitcoin: IconData = nativeOnly
  [<IsConst>] static member currency_bitcoin_sharp: IconData = nativeOnly
  [<IsConst>] static member currency_bitcoin_rounded: IconData = nativeOnly
  [<IsConst>] static member currency_bitcoin_outlined: IconData = nativeOnly
  [<IsConst>] static member currency_exchange: IconData = nativeOnly
  [<IsConst>] static member currency_exchange_sharp: IconData = nativeOnly
  [<IsConst>] static member currency_exchange_rounded: IconData = nativeOnly
  [<IsConst>] static member currency_exchange_outlined: IconData = nativeOnly
  [<IsConst>] static member currency_franc: IconData = nativeOnly
  [<IsConst>] static member currency_franc_sharp: IconData = nativeOnly
  [<IsConst>] static member currency_franc_rounded: IconData = nativeOnly
  [<IsConst>] static member currency_franc_outlined: IconData = nativeOnly
  [<IsConst>] static member currency_lira: IconData = nativeOnly
  [<IsConst>] static member currency_lira_sharp: IconData = nativeOnly
  [<IsConst>] static member currency_lira_rounded: IconData = nativeOnly
  [<IsConst>] static member currency_lira_outlined: IconData = nativeOnly
  [<IsConst>] static member currency_pound: IconData = nativeOnly
  [<IsConst>] static member currency_pound_sharp: IconData = nativeOnly
  [<IsConst>] static member currency_pound_rounded: IconData = nativeOnly
  [<IsConst>] static member currency_pound_outlined: IconData = nativeOnly
  [<IsConst>] static member currency_ruble: IconData = nativeOnly
  [<IsConst>] static member currency_ruble_sharp: IconData = nativeOnly
  [<IsConst>] static member currency_ruble_rounded: IconData = nativeOnly
  [<IsConst>] static member currency_ruble_outlined: IconData = nativeOnly
  [<IsConst>] static member currency_rupee: IconData = nativeOnly
  [<IsConst>] static member currency_rupee_sharp: IconData = nativeOnly
  [<IsConst>] static member currency_rupee_rounded: IconData = nativeOnly
  [<IsConst>] static member currency_rupee_outlined: IconData = nativeOnly
  [<IsConst>] static member currency_yen: IconData = nativeOnly
  [<IsConst>] static member currency_yen_sharp: IconData = nativeOnly
  [<IsConst>] static member currency_yen_rounded: IconData = nativeOnly
  [<IsConst>] static member currency_yen_outlined: IconData = nativeOnly
  [<IsConst>] static member currency_yuan: IconData = nativeOnly
  [<IsConst>] static member currency_yuan_sharp: IconData = nativeOnly
  [<IsConst>] static member currency_yuan_rounded: IconData = nativeOnly
  [<IsConst>] static member currency_yuan_outlined: IconData = nativeOnly
  [<IsConst>] static member curtains: IconData = nativeOnly
  [<IsConst>] static member curtains_sharp: IconData = nativeOnly
  [<IsConst>] static member curtains_rounded: IconData = nativeOnly
  [<IsConst>] static member curtains_outlined: IconData = nativeOnly
  [<IsConst>] static member curtains_closed: IconData = nativeOnly
  [<IsConst>] static member curtains_closed_sharp: IconData = nativeOnly
  [<IsConst>] static member curtains_closed_rounded: IconData = nativeOnly
  [<IsConst>] static member curtains_closed_outlined: IconData = nativeOnly
  [<IsConst>] static member cut: IconData = nativeOnly
  [<IsConst>] static member cut_sharp: IconData = nativeOnly
  [<IsConst>] static member cut_rounded: IconData = nativeOnly
  [<IsConst>] static member cut_outlined: IconData = nativeOnly
  [<IsConst>] static member cyclone: IconData = nativeOnly
  [<IsConst>] static member cyclone_sharp: IconData = nativeOnly
  [<IsConst>] static member cyclone_rounded: IconData = nativeOnly
  [<IsConst>] static member cyclone_outlined: IconData = nativeOnly
  [<IsConst>] static member dangerous: IconData = nativeOnly
  [<IsConst>] static member dangerous_sharp: IconData = nativeOnly
  [<IsConst>] static member dangerous_rounded: IconData = nativeOnly
  [<IsConst>] static member dangerous_outlined: IconData = nativeOnly
  [<IsConst>] static member dark_mode: IconData = nativeOnly
  [<IsConst>] static member dark_mode_sharp: IconData = nativeOnly
  [<IsConst>] static member dark_mode_rounded: IconData = nativeOnly
  [<IsConst>] static member dark_mode_outlined: IconData = nativeOnly
  [<IsConst>] static member dashboard: IconData = nativeOnly
  [<IsConst>] static member dashboard_sharp: IconData = nativeOnly
  [<IsConst>] static member dashboard_rounded: IconData = nativeOnly
  [<IsConst>] static member dashboard_outlined: IconData = nativeOnly
  [<IsConst>] static member dashboard_customize: IconData = nativeOnly
  [<IsConst>] static member dashboard_customize_sharp: IconData = nativeOnly
  [<IsConst>] static member dashboard_customize_rounded: IconData = nativeOnly
  [<IsConst>] static member dashboard_customize_outlined: IconData = nativeOnly
  [<IsConst>] static member data_array: IconData = nativeOnly
  [<IsConst>] static member data_array_sharp: IconData = nativeOnly
  [<IsConst>] static member data_array_rounded: IconData = nativeOnly
  [<IsConst>] static member data_array_outlined: IconData = nativeOnly
  [<IsConst>] static member data_exploration: IconData = nativeOnly
  [<IsConst>] static member data_exploration_sharp: IconData = nativeOnly
  [<IsConst>] static member data_exploration_rounded: IconData = nativeOnly
  [<IsConst>] static member data_exploration_outlined: IconData = nativeOnly
  [<IsConst>] static member data_object: IconData = nativeOnly
  [<IsConst>] static member data_object_sharp: IconData = nativeOnly
  [<IsConst>] static member data_object_rounded: IconData = nativeOnly
  [<IsConst>] static member data_object_outlined: IconData = nativeOnly
  [<IsConst>] static member data_saver_off: IconData = nativeOnly
  [<IsConst>] static member data_saver_off_sharp: IconData = nativeOnly
  [<IsConst>] static member data_saver_off_rounded: IconData = nativeOnly
  [<IsConst>] static member data_saver_off_outlined: IconData = nativeOnly
  [<IsConst>] static member data_saver_on: IconData = nativeOnly
  [<IsConst>] static member data_saver_on_sharp: IconData = nativeOnly
  [<IsConst>] static member data_saver_on_rounded: IconData = nativeOnly
  [<IsConst>] static member data_saver_on_outlined: IconData = nativeOnly
  [<IsConst>] static member data_thresholding: IconData = nativeOnly
  [<IsConst>] static member data_thresholding_sharp: IconData = nativeOnly
  [<IsConst>] static member data_thresholding_rounded: IconData = nativeOnly
  [<IsConst>] static member data_thresholding_outlined: IconData = nativeOnly
  [<IsConst>] static member data_usage: IconData = nativeOnly
  [<IsConst>] static member data_usage_sharp: IconData = nativeOnly
  [<IsConst>] static member data_usage_rounded: IconData = nativeOnly
  [<IsConst>] static member data_usage_outlined: IconData = nativeOnly
  [<IsConst>] static member dataset: IconData = nativeOnly
  [<IsConst>] static member dataset_sharp: IconData = nativeOnly
  [<IsConst>] static member dataset_rounded: IconData = nativeOnly
  [<IsConst>] static member dataset_outlined: IconData = nativeOnly
  [<IsConst>] static member dataset_linked: IconData = nativeOnly
  [<IsConst>] static member dataset_linked_sharp: IconData = nativeOnly
  [<IsConst>] static member dataset_linked_rounded: IconData = nativeOnly
  [<IsConst>] static member dataset_linked_outlined: IconData = nativeOnly
  [<IsConst>] static member date_range: IconData = nativeOnly
  [<IsConst>] static member date_range_sharp: IconData = nativeOnly
  [<IsConst>] static member date_range_rounded: IconData = nativeOnly
  [<IsConst>] static member date_range_outlined: IconData = nativeOnly
  [<IsConst>] static member deblur: IconData = nativeOnly
  [<IsConst>] static member deblur_sharp: IconData = nativeOnly
  [<IsConst>] static member deblur_rounded: IconData = nativeOnly
  [<IsConst>] static member deblur_outlined: IconData = nativeOnly
  [<IsConst>] static member deck: IconData = nativeOnly
  [<IsConst>] static member deck_sharp: IconData = nativeOnly
  [<IsConst>] static member deck_rounded: IconData = nativeOnly
  [<IsConst>] static member deck_outlined: IconData = nativeOnly
  [<IsConst>] static member dehaze: IconData = nativeOnly
  [<IsConst>] static member dehaze_sharp: IconData = nativeOnly
  [<IsConst>] static member dehaze_rounded: IconData = nativeOnly
  [<IsConst>] static member dehaze_outlined: IconData = nativeOnly
  [<IsConst>] static member delete: IconData = nativeOnly
  [<IsConst>] static member delete_sharp: IconData = nativeOnly
  [<IsConst>] static member delete_rounded: IconData = nativeOnly
  [<IsConst>] static member delete_outlined: IconData = nativeOnly
  [<IsConst>] static member delete_forever: IconData = nativeOnly
  [<IsConst>] static member delete_forever_sharp: IconData = nativeOnly
  [<IsConst>] static member delete_forever_rounded: IconData = nativeOnly
  [<IsConst>] static member delete_forever_outlined: IconData = nativeOnly
  [<IsConst>] static member delete_outline: IconData = nativeOnly
  [<IsConst>] static member delete_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member delete_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member delete_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member delete_sweep: IconData = nativeOnly
  [<IsConst>] static member delete_sweep_sharp: IconData = nativeOnly
  [<IsConst>] static member delete_sweep_rounded: IconData = nativeOnly
  [<IsConst>] static member delete_sweep_outlined: IconData = nativeOnly
  [<IsConst>] static member delivery_dining: IconData = nativeOnly
  [<IsConst>] static member delivery_dining_sharp: IconData = nativeOnly
  [<IsConst>] static member delivery_dining_rounded: IconData = nativeOnly
  [<IsConst>] static member delivery_dining_outlined: IconData = nativeOnly
  [<IsConst>] static member density_large: IconData = nativeOnly
  [<IsConst>] static member density_large_sharp: IconData = nativeOnly
  [<IsConst>] static member density_large_rounded: IconData = nativeOnly
  [<IsConst>] static member density_large_outlined: IconData = nativeOnly
  [<IsConst>] static member density_medium: IconData = nativeOnly
  [<IsConst>] static member density_medium_sharp: IconData = nativeOnly
  [<IsConst>] static member density_medium_rounded: IconData = nativeOnly
  [<IsConst>] static member density_medium_outlined: IconData = nativeOnly
  [<IsConst>] static member density_small: IconData = nativeOnly
  [<IsConst>] static member density_small_sharp: IconData = nativeOnly
  [<IsConst>] static member density_small_rounded: IconData = nativeOnly
  [<IsConst>] static member density_small_outlined: IconData = nativeOnly
  [<IsConst>] static member departure_board: IconData = nativeOnly
  [<IsConst>] static member departure_board_sharp: IconData = nativeOnly
  [<IsConst>] static member departure_board_rounded: IconData = nativeOnly
  [<IsConst>] static member departure_board_outlined: IconData = nativeOnly
  [<IsConst>] static member description: IconData = nativeOnly
  [<IsConst>] static member description_sharp: IconData = nativeOnly
  [<IsConst>] static member description_rounded: IconData = nativeOnly
  [<IsConst>] static member description_outlined: IconData = nativeOnly
  [<IsConst>] static member deselect: IconData = nativeOnly
  [<IsConst>] static member deselect_sharp: IconData = nativeOnly
  [<IsConst>] static member deselect_rounded: IconData = nativeOnly
  [<IsConst>] static member deselect_outlined: IconData = nativeOnly
  [<IsConst>] static member design_services: IconData = nativeOnly
  [<IsConst>] static member design_services_sharp: IconData = nativeOnly
  [<IsConst>] static member design_services_rounded: IconData = nativeOnly
  [<IsConst>] static member design_services_outlined: IconData = nativeOnly
  [<IsConst>] static member desk: IconData = nativeOnly
  [<IsConst>] static member desk_sharp: IconData = nativeOnly
  [<IsConst>] static member desk_rounded: IconData = nativeOnly
  [<IsConst>] static member desk_outlined: IconData = nativeOnly
  [<IsConst>] static member desktop_access_disabled: IconData = nativeOnly
  [<IsConst>] static member desktop_access_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member desktop_access_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member desktop_access_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member desktop_mac: IconData = nativeOnly
  [<IsConst>] static member desktop_mac_sharp: IconData = nativeOnly
  [<IsConst>] static member desktop_mac_rounded: IconData = nativeOnly
  [<IsConst>] static member desktop_mac_outlined: IconData = nativeOnly
  [<IsConst>] static member desktop_windows: IconData = nativeOnly
  [<IsConst>] static member desktop_windows_sharp: IconData = nativeOnly
  [<IsConst>] static member desktop_windows_rounded: IconData = nativeOnly
  [<IsConst>] static member desktop_windows_outlined: IconData = nativeOnly
  [<IsConst>] static member details: IconData = nativeOnly
  [<IsConst>] static member details_sharp: IconData = nativeOnly
  [<IsConst>] static member details_rounded: IconData = nativeOnly
  [<IsConst>] static member details_outlined: IconData = nativeOnly
  [<IsConst>] static member developer_board: IconData = nativeOnly
  [<IsConst>] static member developer_board_sharp: IconData = nativeOnly
  [<IsConst>] static member developer_board_rounded: IconData = nativeOnly
  [<IsConst>] static member developer_board_outlined: IconData = nativeOnly
  [<IsConst>] static member developer_board_off: IconData = nativeOnly
  [<IsConst>] static member developer_board_off_sharp: IconData = nativeOnly
  [<IsConst>] static member developer_board_off_rounded: IconData = nativeOnly
  [<IsConst>] static member developer_board_off_outlined: IconData = nativeOnly
  [<IsConst>] static member developer_mode: IconData = nativeOnly
  [<IsConst>] static member developer_mode_sharp: IconData = nativeOnly
  [<IsConst>] static member developer_mode_rounded: IconData = nativeOnly
  [<IsConst>] static member developer_mode_outlined: IconData = nativeOnly
  [<IsConst>] static member device_hub: IconData = nativeOnly
  [<IsConst>] static member device_hub_sharp: IconData = nativeOnly
  [<IsConst>] static member device_hub_rounded: IconData = nativeOnly
  [<IsConst>] static member device_hub_outlined: IconData = nativeOnly
  [<IsConst>] static member device_thermostat: IconData = nativeOnly
  [<IsConst>] static member device_thermostat_sharp: IconData = nativeOnly
  [<IsConst>] static member device_thermostat_rounded: IconData = nativeOnly
  [<IsConst>] static member device_thermostat_outlined: IconData = nativeOnly
  [<IsConst>] static member device_unknown: IconData = nativeOnly
  [<IsConst>] static member device_unknown_sharp: IconData = nativeOnly
  [<IsConst>] static member device_unknown_rounded: IconData = nativeOnly
  [<IsConst>] static member device_unknown_outlined: IconData = nativeOnly
  [<IsConst>] static member devices: IconData = nativeOnly
  [<IsConst>] static member devices_sharp: IconData = nativeOnly
  [<IsConst>] static member devices_rounded: IconData = nativeOnly
  [<IsConst>] static member devices_outlined: IconData = nativeOnly
  [<IsConst>] static member devices_fold: IconData = nativeOnly
  [<IsConst>] static member devices_fold_sharp: IconData = nativeOnly
  [<IsConst>] static member devices_fold_rounded: IconData = nativeOnly
  [<IsConst>] static member devices_fold_outlined: IconData = nativeOnly
  [<IsConst>] static member devices_other: IconData = nativeOnly
  [<IsConst>] static member devices_other_sharp: IconData = nativeOnly
  [<IsConst>] static member devices_other_rounded: IconData = nativeOnly
  [<IsConst>] static member devices_other_outlined: IconData = nativeOnly
  [<IsConst>] static member dialer_sip: IconData = nativeOnly
  [<IsConst>] static member dialer_sip_sharp: IconData = nativeOnly
  [<IsConst>] static member dialer_sip_rounded: IconData = nativeOnly
  [<IsConst>] static member dialer_sip_outlined: IconData = nativeOnly
  [<IsConst>] static member dialpad: IconData = nativeOnly
  [<IsConst>] static member dialpad_sharp: IconData = nativeOnly
  [<IsConst>] static member dialpad_rounded: IconData = nativeOnly
  [<IsConst>] static member dialpad_outlined: IconData = nativeOnly
  [<IsConst>] static member diamond: IconData = nativeOnly
  [<IsConst>] static member diamond_sharp: IconData = nativeOnly
  [<IsConst>] static member diamond_rounded: IconData = nativeOnly
  [<IsConst>] static member diamond_outlined: IconData = nativeOnly
  [<IsConst>] static member difference: IconData = nativeOnly
  [<IsConst>] static member difference_sharp: IconData = nativeOnly
  [<IsConst>] static member difference_rounded: IconData = nativeOnly
  [<IsConst>] static member difference_outlined: IconData = nativeOnly
  [<IsConst>] static member dining: IconData = nativeOnly
  [<IsConst>] static member dining_sharp: IconData = nativeOnly
  [<IsConst>] static member dining_rounded: IconData = nativeOnly
  [<IsConst>] static member dining_outlined: IconData = nativeOnly
  [<IsConst>] static member dinner_dining: IconData = nativeOnly
  [<IsConst>] static member dinner_dining_sharp: IconData = nativeOnly
  [<IsConst>] static member dinner_dining_rounded: IconData = nativeOnly
  [<IsConst>] static member dinner_dining_outlined: IconData = nativeOnly
  [<IsConst>] static member directions: IconData = nativeOnly
  [<IsConst>] static member directions_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_bike: IconData = nativeOnly
  [<IsConst>] static member directions_bike_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_bike_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_bike_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_boat: IconData = nativeOnly
  [<IsConst>] static member directions_boat_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_boat_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_boat_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_boat_filled: IconData = nativeOnly
  [<IsConst>] static member directions_boat_filled_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_boat_filled_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_boat_filled_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_bus: IconData = nativeOnly
  [<IsConst>] static member directions_bus_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_bus_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_bus_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_bus_filled: IconData = nativeOnly
  [<IsConst>] static member directions_bus_filled_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_bus_filled_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_bus_filled_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_car: IconData = nativeOnly
  [<IsConst>] static member directions_car_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_car_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_car_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_car_filled: IconData = nativeOnly
  [<IsConst>] static member directions_car_filled_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_car_filled_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_car_filled_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_ferry: IconData = nativeOnly
  [<IsConst>] static member directions_ferry_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_ferry_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_ferry_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_off: IconData = nativeOnly
  [<IsConst>] static member directions_off_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_off_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_off_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_railway: IconData = nativeOnly
  [<IsConst>] static member directions_railway_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_railway_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_railway_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_railway_filled: IconData = nativeOnly
  [<IsConst>] static member directions_railway_filled_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_railway_filled_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_railway_filled_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_run: IconData = nativeOnly
  [<IsConst>] static member directions_run_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_run_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_run_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_subway: IconData = nativeOnly
  [<IsConst>] static member directions_subway_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_subway_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_subway_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_subway_filled: IconData = nativeOnly
  [<IsConst>] static member directions_subway_filled_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_subway_filled_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_subway_filled_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_train: IconData = nativeOnly
  [<IsConst>] static member directions_train_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_train_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_train_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_transit: IconData = nativeOnly
  [<IsConst>] static member directions_transit_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_transit_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_transit_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_transit_filled: IconData = nativeOnly
  [<IsConst>] static member directions_transit_filled_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_transit_filled_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_transit_filled_outlined: IconData = nativeOnly
  [<IsConst>] static member directions_walk: IconData = nativeOnly
  [<IsConst>] static member directions_walk_sharp: IconData = nativeOnly
  [<IsConst>] static member directions_walk_rounded: IconData = nativeOnly
  [<IsConst>] static member directions_walk_outlined: IconData = nativeOnly
  [<IsConst>] static member dirty_lens: IconData = nativeOnly
  [<IsConst>] static member dirty_lens_sharp: IconData = nativeOnly
  [<IsConst>] static member dirty_lens_rounded: IconData = nativeOnly
  [<IsConst>] static member dirty_lens_outlined: IconData = nativeOnly
  [<IsConst>] static member disabled_by_default: IconData = nativeOnly
  [<IsConst>] static member disabled_by_default_sharp: IconData = nativeOnly
  [<IsConst>] static member disabled_by_default_rounded: IconData = nativeOnly
  [<IsConst>] static member disabled_by_default_outlined: IconData = nativeOnly
  [<IsConst>] static member disabled_visible: IconData = nativeOnly
  [<IsConst>] static member disabled_visible_sharp: IconData = nativeOnly
  [<IsConst>] static member disabled_visible_rounded: IconData = nativeOnly
  [<IsConst>] static member disabled_visible_outlined: IconData = nativeOnly
  [<IsConst>] static member disc_full: IconData = nativeOnly
  [<IsConst>] static member disc_full_sharp: IconData = nativeOnly
  [<IsConst>] static member disc_full_rounded: IconData = nativeOnly
  [<IsConst>] static member disc_full_outlined: IconData = nativeOnly
  [<IsConst>] static member discord: IconData = nativeOnly
  [<IsConst>] static member discord_sharp: IconData = nativeOnly
  [<IsConst>] static member discord_rounded: IconData = nativeOnly
  [<IsConst>] static member discord_outlined: IconData = nativeOnly
  [<IsConst>] static member discount: IconData = nativeOnly
  [<IsConst>] static member discount_sharp: IconData = nativeOnly
  [<IsConst>] static member discount_rounded: IconData = nativeOnly
  [<IsConst>] static member discount_outlined: IconData = nativeOnly
  [<IsConst>] static member display_settings: IconData = nativeOnly
  [<IsConst>] static member display_settings_sharp: IconData = nativeOnly
  [<IsConst>] static member display_settings_rounded: IconData = nativeOnly
  [<IsConst>] static member display_settings_outlined: IconData = nativeOnly
  [<IsConst>] static member dnd_forwardslash: IconData = nativeOnly
  [<IsConst>] static member dnd_forwardslash_sharp: IconData = nativeOnly
  [<IsConst>] static member dnd_forwardslash_rounded: IconData = nativeOnly
  [<IsConst>] static member dnd_forwardslash_outlined: IconData = nativeOnly
  [<IsConst>] static member dns: IconData = nativeOnly
  [<IsConst>] static member dns_sharp: IconData = nativeOnly
  [<IsConst>] static member dns_rounded: IconData = nativeOnly
  [<IsConst>] static member dns_outlined: IconData = nativeOnly
  [<IsConst>] static member do_disturb: IconData = nativeOnly
  [<IsConst>] static member do_disturb_sharp: IconData = nativeOnly
  [<IsConst>] static member do_disturb_rounded: IconData = nativeOnly
  [<IsConst>] static member do_disturb_outlined: IconData = nativeOnly
  [<IsConst>] static member do_disturb_alt: IconData = nativeOnly
  [<IsConst>] static member do_disturb_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member do_disturb_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member do_disturb_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member do_disturb_off: IconData = nativeOnly
  [<IsConst>] static member do_disturb_off_sharp: IconData = nativeOnly
  [<IsConst>] static member do_disturb_off_rounded: IconData = nativeOnly
  [<IsConst>] static member do_disturb_off_outlined: IconData = nativeOnly
  [<IsConst>] static member do_disturb_on: IconData = nativeOnly
  [<IsConst>] static member do_disturb_on_sharp: IconData = nativeOnly
  [<IsConst>] static member do_disturb_on_rounded: IconData = nativeOnly
  [<IsConst>] static member do_disturb_on_outlined: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_sharp: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_rounded: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_outlined: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_alt: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_off: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_off_sharp: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_off_rounded: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_off_outlined: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_on: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_on_sharp: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_on_rounded: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_on_outlined: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_on_total_silence: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_on_total_silence_sharp: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_on_total_silence_rounded: IconData = nativeOnly
  [<IsConst>] static member do_not_disturb_on_total_silence_outlined: IconData = nativeOnly
  [<IsConst>] static member do_not_step: IconData = nativeOnly
  [<IsConst>] static member do_not_step_sharp: IconData = nativeOnly
  [<IsConst>] static member do_not_step_rounded: IconData = nativeOnly
  [<IsConst>] static member do_not_step_outlined: IconData = nativeOnly
  [<IsConst>] static member do_not_touch: IconData = nativeOnly
  [<IsConst>] static member do_not_touch_sharp: IconData = nativeOnly
  [<IsConst>] static member do_not_touch_rounded: IconData = nativeOnly
  [<IsConst>] static member do_not_touch_outlined: IconData = nativeOnly
  [<IsConst>] static member dock: IconData = nativeOnly
  [<IsConst>] static member dock_sharp: IconData = nativeOnly
  [<IsConst>] static member dock_rounded: IconData = nativeOnly
  [<IsConst>] static member dock_outlined: IconData = nativeOnly
  [<IsConst>] static member document_scanner: IconData = nativeOnly
  [<IsConst>] static member document_scanner_sharp: IconData = nativeOnly
  [<IsConst>] static member document_scanner_rounded: IconData = nativeOnly
  [<IsConst>] static member document_scanner_outlined: IconData = nativeOnly
  [<IsConst>] static member domain: IconData = nativeOnly
  [<IsConst>] static member domain_sharp: IconData = nativeOnly
  [<IsConst>] static member domain_rounded: IconData = nativeOnly
  [<IsConst>] static member domain_outlined: IconData = nativeOnly
  [<IsConst>] static member domain_add: IconData = nativeOnly
  [<IsConst>] static member domain_add_sharp: IconData = nativeOnly
  [<IsConst>] static member domain_add_rounded: IconData = nativeOnly
  [<IsConst>] static member domain_add_outlined: IconData = nativeOnly
  [<IsConst>] static member domain_disabled: IconData = nativeOnly
  [<IsConst>] static member domain_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member domain_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member domain_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member domain_verification: IconData = nativeOnly
  [<IsConst>] static member domain_verification_sharp: IconData = nativeOnly
  [<IsConst>] static member domain_verification_rounded: IconData = nativeOnly
  [<IsConst>] static member domain_verification_outlined: IconData = nativeOnly
  [<IsConst>] static member ``done``: IconData = nativeOnly
  [<IsConst>] static member done_sharp: IconData = nativeOnly
  [<IsConst>] static member done_rounded: IconData = nativeOnly
  [<IsConst>] static member done_outlined: IconData = nativeOnly
  [<IsConst>] static member done_all: IconData = nativeOnly
  [<IsConst>] static member done_all_sharp: IconData = nativeOnly
  [<IsConst>] static member done_all_rounded: IconData = nativeOnly
  [<IsConst>] static member done_all_outlined: IconData = nativeOnly
  [<IsConst>] static member done_outline: IconData = nativeOnly
  [<IsConst>] static member done_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member done_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member done_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member donut_large: IconData = nativeOnly
  [<IsConst>] static member donut_large_sharp: IconData = nativeOnly
  [<IsConst>] static member donut_large_rounded: IconData = nativeOnly
  [<IsConst>] static member donut_large_outlined: IconData = nativeOnly
  [<IsConst>] static member donut_small: IconData = nativeOnly
  [<IsConst>] static member donut_small_sharp: IconData = nativeOnly
  [<IsConst>] static member donut_small_rounded: IconData = nativeOnly
  [<IsConst>] static member donut_small_outlined: IconData = nativeOnly
  [<IsConst>] static member door_back_door: IconData = nativeOnly
  [<IsConst>] static member door_back_door_sharp: IconData = nativeOnly
  [<IsConst>] static member door_back_door_rounded: IconData = nativeOnly
  [<IsConst>] static member door_back_door_outlined: IconData = nativeOnly
  [<IsConst>] static member door_front_door: IconData = nativeOnly
  [<IsConst>] static member door_front_door_sharp: IconData = nativeOnly
  [<IsConst>] static member door_front_door_rounded: IconData = nativeOnly
  [<IsConst>] static member door_front_door_outlined: IconData = nativeOnly
  [<IsConst>] static member door_sliding: IconData = nativeOnly
  [<IsConst>] static member door_sliding_sharp: IconData = nativeOnly
  [<IsConst>] static member door_sliding_rounded: IconData = nativeOnly
  [<IsConst>] static member door_sliding_outlined: IconData = nativeOnly
  [<IsConst>] static member doorbell: IconData = nativeOnly
  [<IsConst>] static member doorbell_sharp: IconData = nativeOnly
  [<IsConst>] static member doorbell_rounded: IconData = nativeOnly
  [<IsConst>] static member doorbell_outlined: IconData = nativeOnly
  [<IsConst>] static member double_arrow: IconData = nativeOnly
  [<IsConst>] static member double_arrow_sharp: IconData = nativeOnly
  [<IsConst>] static member double_arrow_rounded: IconData = nativeOnly
  [<IsConst>] static member double_arrow_outlined: IconData = nativeOnly
  [<IsConst>] static member downhill_skiing: IconData = nativeOnly
  [<IsConst>] static member downhill_skiing_sharp: IconData = nativeOnly
  [<IsConst>] static member downhill_skiing_rounded: IconData = nativeOnly
  [<IsConst>] static member downhill_skiing_outlined: IconData = nativeOnly
  [<IsConst>] static member download: IconData = nativeOnly
  [<IsConst>] static member download_sharp: IconData = nativeOnly
  [<IsConst>] static member download_rounded: IconData = nativeOnly
  [<IsConst>] static member download_outlined: IconData = nativeOnly
  [<IsConst>] static member download_done: IconData = nativeOnly
  [<IsConst>] static member download_done_sharp: IconData = nativeOnly
  [<IsConst>] static member download_done_rounded: IconData = nativeOnly
  [<IsConst>] static member download_done_outlined: IconData = nativeOnly
  [<IsConst>] static member download_for_offline: IconData = nativeOnly
  [<IsConst>] static member download_for_offline_sharp: IconData = nativeOnly
  [<IsConst>] static member download_for_offline_rounded: IconData = nativeOnly
  [<IsConst>] static member download_for_offline_outlined: IconData = nativeOnly
  [<IsConst>] static member downloading: IconData = nativeOnly
  [<IsConst>] static member downloading_sharp: IconData = nativeOnly
  [<IsConst>] static member downloading_rounded: IconData = nativeOnly
  [<IsConst>] static member downloading_outlined: IconData = nativeOnly
  [<IsConst>] static member drafts: IconData = nativeOnly
  [<IsConst>] static member drafts_sharp: IconData = nativeOnly
  [<IsConst>] static member drafts_rounded: IconData = nativeOnly
  [<IsConst>] static member drafts_outlined: IconData = nativeOnly
  [<IsConst>] static member drag_handle: IconData = nativeOnly
  [<IsConst>] static member drag_handle_sharp: IconData = nativeOnly
  [<IsConst>] static member drag_handle_rounded: IconData = nativeOnly
  [<IsConst>] static member drag_handle_outlined: IconData = nativeOnly
  [<IsConst>] static member drag_indicator: IconData = nativeOnly
  [<IsConst>] static member drag_indicator_sharp: IconData = nativeOnly
  [<IsConst>] static member drag_indicator_rounded: IconData = nativeOnly
  [<IsConst>] static member drag_indicator_outlined: IconData = nativeOnly
  [<IsConst>] static member draw: IconData = nativeOnly
  [<IsConst>] static member draw_sharp: IconData = nativeOnly
  [<IsConst>] static member draw_rounded: IconData = nativeOnly
  [<IsConst>] static member draw_outlined: IconData = nativeOnly
  [<IsConst>] static member drive_eta: IconData = nativeOnly
  [<IsConst>] static member drive_eta_sharp: IconData = nativeOnly
  [<IsConst>] static member drive_eta_rounded: IconData = nativeOnly
  [<IsConst>] static member drive_eta_outlined: IconData = nativeOnly
  [<IsConst>] static member drive_file_move: IconData = nativeOnly
  [<IsConst>] static member drive_file_move_sharp: IconData = nativeOnly
  [<IsConst>] static member drive_file_move_rounded: IconData = nativeOnly
  [<IsConst>] static member drive_file_move_outlined: IconData = nativeOnly
  [<IsConst>] static member drive_file_move_outline: IconData = nativeOnly
  [<IsConst>] static member drive_file_move_rtl: IconData = nativeOnly
  [<IsConst>] static member drive_file_move_rtl_sharp: IconData = nativeOnly
  [<IsConst>] static member drive_file_move_rtl_rounded: IconData = nativeOnly
  [<IsConst>] static member drive_file_move_rtl_outlined: IconData = nativeOnly
  [<IsConst>] static member drive_file_rename_outline: IconData = nativeOnly
  [<IsConst>] static member drive_file_rename_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member drive_file_rename_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member drive_file_rename_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member drive_folder_upload: IconData = nativeOnly
  [<IsConst>] static member drive_folder_upload_sharp: IconData = nativeOnly
  [<IsConst>] static member drive_folder_upload_rounded: IconData = nativeOnly
  [<IsConst>] static member drive_folder_upload_outlined: IconData = nativeOnly
  [<IsConst>] static member dry: IconData = nativeOnly
  [<IsConst>] static member dry_sharp: IconData = nativeOnly
  [<IsConst>] static member dry_rounded: IconData = nativeOnly
  [<IsConst>] static member dry_outlined: IconData = nativeOnly
  [<IsConst>] static member dry_cleaning: IconData = nativeOnly
  [<IsConst>] static member dry_cleaning_sharp: IconData = nativeOnly
  [<IsConst>] static member dry_cleaning_rounded: IconData = nativeOnly
  [<IsConst>] static member dry_cleaning_outlined: IconData = nativeOnly
  [<IsConst>] static member duo: IconData = nativeOnly
  [<IsConst>] static member duo_sharp: IconData = nativeOnly
  [<IsConst>] static member duo_rounded: IconData = nativeOnly
  [<IsConst>] static member duo_outlined: IconData = nativeOnly
  [<IsConst>] static member dvr: IconData = nativeOnly
  [<IsConst>] static member dvr_sharp: IconData = nativeOnly
  [<IsConst>] static member dvr_rounded: IconData = nativeOnly
  [<IsConst>] static member dvr_outlined: IconData = nativeOnly
  [<IsConst>] static member dynamic_feed: IconData = nativeOnly
  [<IsConst>] static member dynamic_feed_sharp: IconData = nativeOnly
  [<IsConst>] static member dynamic_feed_rounded: IconData = nativeOnly
  [<IsConst>] static member dynamic_feed_outlined: IconData = nativeOnly
  [<IsConst>] static member dynamic_form: IconData = nativeOnly
  [<IsConst>] static member dynamic_form_sharp: IconData = nativeOnly
  [<IsConst>] static member dynamic_form_rounded: IconData = nativeOnly
  [<IsConst>] static member dynamic_form_outlined: IconData = nativeOnly
  [<IsConst>] static member e_mobiledata: IconData = nativeOnly
  [<IsConst>] static member e_mobiledata_sharp: IconData = nativeOnly
  [<IsConst>] static member e_mobiledata_rounded: IconData = nativeOnly
  [<IsConst>] static member e_mobiledata_outlined: IconData = nativeOnly
  [<IsConst>] static member earbuds: IconData = nativeOnly
  [<IsConst>] static member earbuds_sharp: IconData = nativeOnly
  [<IsConst>] static member earbuds_rounded: IconData = nativeOnly
  [<IsConst>] static member earbuds_outlined: IconData = nativeOnly
  [<IsConst>] static member earbuds_battery: IconData = nativeOnly
  [<IsConst>] static member earbuds_battery_sharp: IconData = nativeOnly
  [<IsConst>] static member earbuds_battery_rounded: IconData = nativeOnly
  [<IsConst>] static member earbuds_battery_outlined: IconData = nativeOnly
  [<IsConst>] static member east: IconData = nativeOnly
  [<IsConst>] static member east_sharp: IconData = nativeOnly
  [<IsConst>] static member east_rounded: IconData = nativeOnly
  [<IsConst>] static member east_outlined: IconData = nativeOnly
  [<IsConst>] static member eco: IconData = nativeOnly
  [<IsConst>] static member eco_sharp: IconData = nativeOnly
  [<IsConst>] static member eco_rounded: IconData = nativeOnly
  [<IsConst>] static member eco_outlined: IconData = nativeOnly
  [<IsConst>] static member edgesensor_high: IconData = nativeOnly
  [<IsConst>] static member edgesensor_high_sharp: IconData = nativeOnly
  [<IsConst>] static member edgesensor_high_rounded: IconData = nativeOnly
  [<IsConst>] static member edgesensor_high_outlined: IconData = nativeOnly
  [<IsConst>] static member edgesensor_low: IconData = nativeOnly
  [<IsConst>] static member edgesensor_low_sharp: IconData = nativeOnly
  [<IsConst>] static member edgesensor_low_rounded: IconData = nativeOnly
  [<IsConst>] static member edgesensor_low_outlined: IconData = nativeOnly
  [<IsConst>] static member edit: IconData = nativeOnly
  [<IsConst>] static member edit_sharp: IconData = nativeOnly
  [<IsConst>] static member edit_rounded: IconData = nativeOnly
  [<IsConst>] static member edit_outlined: IconData = nativeOnly
  [<IsConst>] static member edit_attributes: IconData = nativeOnly
  [<IsConst>] static member edit_attributes_sharp: IconData = nativeOnly
  [<IsConst>] static member edit_attributes_rounded: IconData = nativeOnly
  [<IsConst>] static member edit_attributes_outlined: IconData = nativeOnly
  [<IsConst>] static member edit_calendar: IconData = nativeOnly
  [<IsConst>] static member edit_calendar_sharp: IconData = nativeOnly
  [<IsConst>] static member edit_calendar_rounded: IconData = nativeOnly
  [<IsConst>] static member edit_calendar_outlined: IconData = nativeOnly
  [<IsConst>] static member edit_location: IconData = nativeOnly
  [<IsConst>] static member edit_location_sharp: IconData = nativeOnly
  [<IsConst>] static member edit_location_rounded: IconData = nativeOnly
  [<IsConst>] static member edit_location_outlined: IconData = nativeOnly
  [<IsConst>] static member edit_location_alt: IconData = nativeOnly
  [<IsConst>] static member edit_location_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member edit_location_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member edit_location_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member edit_note: IconData = nativeOnly
  [<IsConst>] static member edit_note_sharp: IconData = nativeOnly
  [<IsConst>] static member edit_note_rounded: IconData = nativeOnly
  [<IsConst>] static member edit_note_outlined: IconData = nativeOnly
  [<IsConst>] static member edit_notifications: IconData = nativeOnly
  [<IsConst>] static member edit_notifications_sharp: IconData = nativeOnly
  [<IsConst>] static member edit_notifications_rounded: IconData = nativeOnly
  [<IsConst>] static member edit_notifications_outlined: IconData = nativeOnly
  [<IsConst>] static member edit_off: IconData = nativeOnly
  [<IsConst>] static member edit_off_sharp: IconData = nativeOnly
  [<IsConst>] static member edit_off_rounded: IconData = nativeOnly
  [<IsConst>] static member edit_off_outlined: IconData = nativeOnly
  [<IsConst>] static member edit_road: IconData = nativeOnly
  [<IsConst>] static member edit_road_sharp: IconData = nativeOnly
  [<IsConst>] static member edit_road_rounded: IconData = nativeOnly
  [<IsConst>] static member edit_road_outlined: IconData = nativeOnly
  [<IsConst>] static member egg: IconData = nativeOnly
  [<IsConst>] static member egg_sharp: IconData = nativeOnly
  [<IsConst>] static member egg_rounded: IconData = nativeOnly
  [<IsConst>] static member egg_outlined: IconData = nativeOnly
  [<IsConst>] static member egg_alt: IconData = nativeOnly
  [<IsConst>] static member egg_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member egg_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member egg_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member eject: IconData = nativeOnly
  [<IsConst>] static member eject_sharp: IconData = nativeOnly
  [<IsConst>] static member eject_rounded: IconData = nativeOnly
  [<IsConst>] static member eject_outlined: IconData = nativeOnly
  [<IsConst>] static member elderly: IconData = nativeOnly
  [<IsConst>] static member elderly_sharp: IconData = nativeOnly
  [<IsConst>] static member elderly_rounded: IconData = nativeOnly
  [<IsConst>] static member elderly_outlined: IconData = nativeOnly
  [<IsConst>] static member elderly_woman: IconData = nativeOnly
  [<IsConst>] static member elderly_woman_sharp: IconData = nativeOnly
  [<IsConst>] static member elderly_woman_rounded: IconData = nativeOnly
  [<IsConst>] static member elderly_woman_outlined: IconData = nativeOnly
  [<IsConst>] static member electric_bike: IconData = nativeOnly
  [<IsConst>] static member electric_bike_sharp: IconData = nativeOnly
  [<IsConst>] static member electric_bike_rounded: IconData = nativeOnly
  [<IsConst>] static member electric_bike_outlined: IconData = nativeOnly
  [<IsConst>] static member electric_bolt: IconData = nativeOnly
  [<IsConst>] static member electric_bolt_sharp: IconData = nativeOnly
  [<IsConst>] static member electric_bolt_rounded: IconData = nativeOnly
  [<IsConst>] static member electric_bolt_outlined: IconData = nativeOnly
  [<IsConst>] static member electric_car: IconData = nativeOnly
  [<IsConst>] static member electric_car_sharp: IconData = nativeOnly
  [<IsConst>] static member electric_car_rounded: IconData = nativeOnly
  [<IsConst>] static member electric_car_outlined: IconData = nativeOnly
  [<IsConst>] static member electric_meter: IconData = nativeOnly
  [<IsConst>] static member electric_meter_sharp: IconData = nativeOnly
  [<IsConst>] static member electric_meter_rounded: IconData = nativeOnly
  [<IsConst>] static member electric_meter_outlined: IconData = nativeOnly
  [<IsConst>] static member electric_moped: IconData = nativeOnly
  [<IsConst>] static member electric_moped_sharp: IconData = nativeOnly
  [<IsConst>] static member electric_moped_rounded: IconData = nativeOnly
  [<IsConst>] static member electric_moped_outlined: IconData = nativeOnly
  [<IsConst>] static member electric_rickshaw: IconData = nativeOnly
  [<IsConst>] static member electric_rickshaw_sharp: IconData = nativeOnly
  [<IsConst>] static member electric_rickshaw_rounded: IconData = nativeOnly
  [<IsConst>] static member electric_rickshaw_outlined: IconData = nativeOnly
  [<IsConst>] static member electric_scooter: IconData = nativeOnly
  [<IsConst>] static member electric_scooter_sharp: IconData = nativeOnly
  [<IsConst>] static member electric_scooter_rounded: IconData = nativeOnly
  [<IsConst>] static member electric_scooter_outlined: IconData = nativeOnly
  [<IsConst>] static member electrical_services: IconData = nativeOnly
  [<IsConst>] static member electrical_services_sharp: IconData = nativeOnly
  [<IsConst>] static member electrical_services_rounded: IconData = nativeOnly
  [<IsConst>] static member electrical_services_outlined: IconData = nativeOnly
  [<IsConst>] static member elevator: IconData = nativeOnly
  [<IsConst>] static member elevator_sharp: IconData = nativeOnly
  [<IsConst>] static member elevator_rounded: IconData = nativeOnly
  [<IsConst>] static member elevator_outlined: IconData = nativeOnly
  [<IsConst>] static member email: IconData = nativeOnly
  [<IsConst>] static member email_sharp: IconData = nativeOnly
  [<IsConst>] static member email_rounded: IconData = nativeOnly
  [<IsConst>] static member email_outlined: IconData = nativeOnly
  [<IsConst>] static member emergency: IconData = nativeOnly
  [<IsConst>] static member emergency_sharp: IconData = nativeOnly
  [<IsConst>] static member emergency_rounded: IconData = nativeOnly
  [<IsConst>] static member emergency_outlined: IconData = nativeOnly
  [<IsConst>] static member emergency_recording: IconData = nativeOnly
  [<IsConst>] static member emergency_recording_sharp: IconData = nativeOnly
  [<IsConst>] static member emergency_recording_rounded: IconData = nativeOnly
  [<IsConst>] static member emergency_recording_outlined: IconData = nativeOnly
  [<IsConst>] static member emergency_share: IconData = nativeOnly
  [<IsConst>] static member emergency_share_sharp: IconData = nativeOnly
  [<IsConst>] static member emergency_share_rounded: IconData = nativeOnly
  [<IsConst>] static member emergency_share_outlined: IconData = nativeOnly
  [<IsConst>] static member emoji_emotions: IconData = nativeOnly
  [<IsConst>] static member emoji_emotions_sharp: IconData = nativeOnly
  [<IsConst>] static member emoji_emotions_rounded: IconData = nativeOnly
  [<IsConst>] static member emoji_emotions_outlined: IconData = nativeOnly
  [<IsConst>] static member emoji_events: IconData = nativeOnly
  [<IsConst>] static member emoji_events_sharp: IconData = nativeOnly
  [<IsConst>] static member emoji_events_rounded: IconData = nativeOnly
  [<IsConst>] static member emoji_events_outlined: IconData = nativeOnly
  [<IsConst>] static member emoji_flags: IconData = nativeOnly
  [<IsConst>] static member emoji_flags_sharp: IconData = nativeOnly
  [<IsConst>] static member emoji_flags_rounded: IconData = nativeOnly
  [<IsConst>] static member emoji_flags_outlined: IconData = nativeOnly
  [<IsConst>] static member emoji_food_beverage: IconData = nativeOnly
  [<IsConst>] static member emoji_food_beverage_sharp: IconData = nativeOnly
  [<IsConst>] static member emoji_food_beverage_rounded: IconData = nativeOnly
  [<IsConst>] static member emoji_food_beverage_outlined: IconData = nativeOnly
  [<IsConst>] static member emoji_nature: IconData = nativeOnly
  [<IsConst>] static member emoji_nature_sharp: IconData = nativeOnly
  [<IsConst>] static member emoji_nature_rounded: IconData = nativeOnly
  [<IsConst>] static member emoji_nature_outlined: IconData = nativeOnly
  [<IsConst>] static member emoji_objects: IconData = nativeOnly
  [<IsConst>] static member emoji_objects_sharp: IconData = nativeOnly
  [<IsConst>] static member emoji_objects_rounded: IconData = nativeOnly
  [<IsConst>] static member emoji_objects_outlined: IconData = nativeOnly
  [<IsConst>] static member emoji_people: IconData = nativeOnly
  [<IsConst>] static member emoji_people_sharp: IconData = nativeOnly
  [<IsConst>] static member emoji_people_rounded: IconData = nativeOnly
  [<IsConst>] static member emoji_people_outlined: IconData = nativeOnly
  [<IsConst>] static member emoji_symbols: IconData = nativeOnly
  [<IsConst>] static member emoji_symbols_sharp: IconData = nativeOnly
  [<IsConst>] static member emoji_symbols_rounded: IconData = nativeOnly
  [<IsConst>] static member emoji_symbols_outlined: IconData = nativeOnly
  [<IsConst>] static member emoji_transportation: IconData = nativeOnly
  [<IsConst>] static member emoji_transportation_sharp: IconData = nativeOnly
  [<IsConst>] static member emoji_transportation_rounded: IconData = nativeOnly
  [<IsConst>] static member emoji_transportation_outlined: IconData = nativeOnly
  [<IsConst>] static member energy_savings_leaf: IconData = nativeOnly
  [<IsConst>] static member energy_savings_leaf_sharp: IconData = nativeOnly
  [<IsConst>] static member energy_savings_leaf_rounded: IconData = nativeOnly
  [<IsConst>] static member energy_savings_leaf_outlined: IconData = nativeOnly
  [<IsConst>] static member engineering: IconData = nativeOnly
  [<IsConst>] static member engineering_sharp: IconData = nativeOnly
  [<IsConst>] static member engineering_rounded: IconData = nativeOnly
  [<IsConst>] static member engineering_outlined: IconData = nativeOnly
  [<IsConst>] static member enhance_photo_translate: IconData = nativeOnly
  [<IsConst>] static member enhance_photo_translate_sharp: IconData = nativeOnly
  [<IsConst>] static member enhance_photo_translate_rounded: IconData = nativeOnly
  [<IsConst>] static member enhance_photo_translate_outlined: IconData = nativeOnly
  [<IsConst>] static member enhanced_encryption: IconData = nativeOnly
  [<IsConst>] static member enhanced_encryption_sharp: IconData = nativeOnly
  [<IsConst>] static member enhanced_encryption_rounded: IconData = nativeOnly
  [<IsConst>] static member enhanced_encryption_outlined: IconData = nativeOnly
  [<IsConst>] static member equalizer: IconData = nativeOnly
  [<IsConst>] static member equalizer_sharp: IconData = nativeOnly
  [<IsConst>] static member equalizer_rounded: IconData = nativeOnly
  [<IsConst>] static member equalizer_outlined: IconData = nativeOnly
  [<IsConst>] static member error: IconData = nativeOnly
  [<IsConst>] static member error_sharp: IconData = nativeOnly
  [<IsConst>] static member error_rounded: IconData = nativeOnly
  [<IsConst>] static member error_outlined: IconData = nativeOnly
  [<IsConst>] static member error_outline: IconData = nativeOnly
  [<IsConst>] static member error_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member error_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member error_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member escalator: IconData = nativeOnly
  [<IsConst>] static member escalator_sharp: IconData = nativeOnly
  [<IsConst>] static member escalator_rounded: IconData = nativeOnly
  [<IsConst>] static member escalator_outlined: IconData = nativeOnly
  [<IsConst>] static member escalator_warning: IconData = nativeOnly
  [<IsConst>] static member escalator_warning_sharp: IconData = nativeOnly
  [<IsConst>] static member escalator_warning_rounded: IconData = nativeOnly
  [<IsConst>] static member escalator_warning_outlined: IconData = nativeOnly
  [<IsConst>] static member euro: IconData = nativeOnly
  [<IsConst>] static member euro_sharp: IconData = nativeOnly
  [<IsConst>] static member euro_rounded: IconData = nativeOnly
  [<IsConst>] static member euro_outlined: IconData = nativeOnly
  [<IsConst>] static member euro_symbol: IconData = nativeOnly
  [<IsConst>] static member euro_symbol_sharp: IconData = nativeOnly
  [<IsConst>] static member euro_symbol_rounded: IconData = nativeOnly
  [<IsConst>] static member euro_symbol_outlined: IconData = nativeOnly
  [<IsConst>] static member ev_station: IconData = nativeOnly
  [<IsConst>] static member ev_station_sharp: IconData = nativeOnly
  [<IsConst>] static member ev_station_rounded: IconData = nativeOnly
  [<IsConst>] static member ev_station_outlined: IconData = nativeOnly
  [<IsConst>] static member event: IconData = nativeOnly
  [<IsConst>] static member event_sharp: IconData = nativeOnly
  [<IsConst>] static member event_rounded: IconData = nativeOnly
  [<IsConst>] static member event_outlined: IconData = nativeOnly
  [<IsConst>] static member event_available: IconData = nativeOnly
  [<IsConst>] static member event_available_sharp: IconData = nativeOnly
  [<IsConst>] static member event_available_rounded: IconData = nativeOnly
  [<IsConst>] static member event_available_outlined: IconData = nativeOnly
  [<IsConst>] static member event_busy: IconData = nativeOnly
  [<IsConst>] static member event_busy_sharp: IconData = nativeOnly
  [<IsConst>] static member event_busy_rounded: IconData = nativeOnly
  [<IsConst>] static member event_busy_outlined: IconData = nativeOnly
  [<IsConst>] static member event_note: IconData = nativeOnly
  [<IsConst>] static member event_note_sharp: IconData = nativeOnly
  [<IsConst>] static member event_note_rounded: IconData = nativeOnly
  [<IsConst>] static member event_note_outlined: IconData = nativeOnly
  [<IsConst>] static member event_repeat: IconData = nativeOnly
  [<IsConst>] static member event_repeat_sharp: IconData = nativeOnly
  [<IsConst>] static member event_repeat_rounded: IconData = nativeOnly
  [<IsConst>] static member event_repeat_outlined: IconData = nativeOnly
  [<IsConst>] static member event_seat: IconData = nativeOnly
  [<IsConst>] static member event_seat_sharp: IconData = nativeOnly
  [<IsConst>] static member event_seat_rounded: IconData = nativeOnly
  [<IsConst>] static member event_seat_outlined: IconData = nativeOnly
  [<IsConst>] static member exit_to_app: IconData = nativeOnly
  [<IsConst>] static member exit_to_app_sharp: IconData = nativeOnly
  [<IsConst>] static member exit_to_app_rounded: IconData = nativeOnly
  [<IsConst>] static member exit_to_app_outlined: IconData = nativeOnly
  [<IsConst>] static member expand: IconData = nativeOnly
  [<IsConst>] static member expand_sharp: IconData = nativeOnly
  [<IsConst>] static member expand_rounded: IconData = nativeOnly
  [<IsConst>] static member expand_outlined: IconData = nativeOnly
  [<IsConst>] static member expand_circle_down: IconData = nativeOnly
  [<IsConst>] static member expand_circle_down_sharp: IconData = nativeOnly
  [<IsConst>] static member expand_circle_down_rounded: IconData = nativeOnly
  [<IsConst>] static member expand_circle_down_outlined: IconData = nativeOnly
  [<IsConst>] static member expand_less: IconData = nativeOnly
  [<IsConst>] static member expand_less_sharp: IconData = nativeOnly
  [<IsConst>] static member expand_less_rounded: IconData = nativeOnly
  [<IsConst>] static member expand_less_outlined: IconData = nativeOnly
  [<IsConst>] static member expand_more: IconData = nativeOnly
  [<IsConst>] static member expand_more_sharp: IconData = nativeOnly
  [<IsConst>] static member expand_more_rounded: IconData = nativeOnly
  [<IsConst>] static member expand_more_outlined: IconData = nativeOnly
  [<IsConst>] static member explicit: IconData = nativeOnly
  [<IsConst>] static member explicit_sharp: IconData = nativeOnly
  [<IsConst>] static member explicit_rounded: IconData = nativeOnly
  [<IsConst>] static member explicit_outlined: IconData = nativeOnly
  [<IsConst>] static member explore: IconData = nativeOnly
  [<IsConst>] static member explore_sharp: IconData = nativeOnly
  [<IsConst>] static member explore_rounded: IconData = nativeOnly
  [<IsConst>] static member explore_outlined: IconData = nativeOnly
  [<IsConst>] static member explore_off: IconData = nativeOnly
  [<IsConst>] static member explore_off_sharp: IconData = nativeOnly
  [<IsConst>] static member explore_off_rounded: IconData = nativeOnly
  [<IsConst>] static member explore_off_outlined: IconData = nativeOnly
  [<IsConst>] static member exposure: IconData = nativeOnly
  [<IsConst>] static member exposure_sharp: IconData = nativeOnly
  [<IsConst>] static member exposure_rounded: IconData = nativeOnly
  [<IsConst>] static member exposure_outlined: IconData = nativeOnly
  [<IsConst>] static member exposure_minus_1: IconData = nativeOnly
  [<IsConst>] static member exposure_minus_1_sharp: IconData = nativeOnly
  [<IsConst>] static member exposure_minus_1_rounded: IconData = nativeOnly
  [<IsConst>] static member exposure_minus_1_outlined: IconData = nativeOnly
  [<IsConst>] static member exposure_minus_2: IconData = nativeOnly
  [<IsConst>] static member exposure_minus_2_sharp: IconData = nativeOnly
  [<IsConst>] static member exposure_minus_2_rounded: IconData = nativeOnly
  [<IsConst>] static member exposure_minus_2_outlined: IconData = nativeOnly
  [<IsConst>] static member exposure_neg_1: IconData = nativeOnly
  [<IsConst>] static member exposure_neg_1_sharp: IconData = nativeOnly
  [<IsConst>] static member exposure_neg_1_rounded: IconData = nativeOnly
  [<IsConst>] static member exposure_neg_1_outlined: IconData = nativeOnly
  [<IsConst>] static member exposure_neg_2: IconData = nativeOnly
  [<IsConst>] static member exposure_neg_2_sharp: IconData = nativeOnly
  [<IsConst>] static member exposure_neg_2_rounded: IconData = nativeOnly
  [<IsConst>] static member exposure_neg_2_outlined: IconData = nativeOnly
  [<IsConst>] static member exposure_plus_1: IconData = nativeOnly
  [<IsConst>] static member exposure_plus_1_sharp: IconData = nativeOnly
  [<IsConst>] static member exposure_plus_1_rounded: IconData = nativeOnly
  [<IsConst>] static member exposure_plus_1_outlined: IconData = nativeOnly
  [<IsConst>] static member exposure_plus_2: IconData = nativeOnly
  [<IsConst>] static member exposure_plus_2_sharp: IconData = nativeOnly
  [<IsConst>] static member exposure_plus_2_rounded: IconData = nativeOnly
  [<IsConst>] static member exposure_plus_2_outlined: IconData = nativeOnly
  [<IsConst>] static member exposure_zero: IconData = nativeOnly
  [<IsConst>] static member exposure_zero_sharp: IconData = nativeOnly
  [<IsConst>] static member exposure_zero_rounded: IconData = nativeOnly
  [<IsConst>] static member exposure_zero_outlined: IconData = nativeOnly
  [<IsConst>] static member extension: IconData = nativeOnly
  [<IsConst>] static member extension_sharp: IconData = nativeOnly
  [<IsConst>] static member extension_rounded: IconData = nativeOnly
  [<IsConst>] static member extension_outlined: IconData = nativeOnly
  [<IsConst>] static member extension_off: IconData = nativeOnly
  [<IsConst>] static member extension_off_sharp: IconData = nativeOnly
  [<IsConst>] static member extension_off_rounded: IconData = nativeOnly
  [<IsConst>] static member extension_off_outlined: IconData = nativeOnly
  [<IsConst>] static member face: IconData = nativeOnly
  [<IsConst>] static member face_sharp: IconData = nativeOnly
  [<IsConst>] static member face_rounded: IconData = nativeOnly
  [<IsConst>] static member face_outlined: IconData = nativeOnly
  [<IsConst>] static member face_retouching_natural: IconData = nativeOnly
  [<IsConst>] static member face_retouching_natural_sharp: IconData = nativeOnly
  [<IsConst>] static member face_retouching_natural_rounded: IconData = nativeOnly
  [<IsConst>] static member face_retouching_natural_outlined: IconData = nativeOnly
  [<IsConst>] static member face_retouching_off: IconData = nativeOnly
  [<IsConst>] static member face_retouching_off_sharp: IconData = nativeOnly
  [<IsConst>] static member face_retouching_off_rounded: IconData = nativeOnly
  [<IsConst>] static member face_retouching_off_outlined: IconData = nativeOnly
  [<IsConst>] static member face_unlock_sharp: IconData = nativeOnly
  [<IsConst>] static member face_unlock_rounded: IconData = nativeOnly
  [<IsConst>] static member face_unlock_outlined: IconData = nativeOnly
  [<IsConst>] static member facebook: IconData = nativeOnly
  [<IsConst>] static member facebook_sharp: IconData = nativeOnly
  [<IsConst>] static member facebook_rounded: IconData = nativeOnly
  [<IsConst>] static member facebook_outlined: IconData = nativeOnly
  [<IsConst>] static member fact_check: IconData = nativeOnly
  [<IsConst>] static member fact_check_sharp: IconData = nativeOnly
  [<IsConst>] static member fact_check_rounded: IconData = nativeOnly
  [<IsConst>] static member fact_check_outlined: IconData = nativeOnly
  [<IsConst>] static member factory: IconData = nativeOnly
  [<IsConst>] static member factory_sharp: IconData = nativeOnly
  [<IsConst>] static member factory_rounded: IconData = nativeOnly
  [<IsConst>] static member factory_outlined: IconData = nativeOnly
  [<IsConst>] static member family_restroom: IconData = nativeOnly
  [<IsConst>] static member family_restroom_sharp: IconData = nativeOnly
  [<IsConst>] static member family_restroom_rounded: IconData = nativeOnly
  [<IsConst>] static member family_restroom_outlined: IconData = nativeOnly
  [<IsConst>] static member fast_forward: IconData = nativeOnly
  [<IsConst>] static member fast_forward_sharp: IconData = nativeOnly
  [<IsConst>] static member fast_forward_rounded: IconData = nativeOnly
  [<IsConst>] static member fast_forward_outlined: IconData = nativeOnly
  [<IsConst>] static member fast_rewind: IconData = nativeOnly
  [<IsConst>] static member fast_rewind_sharp: IconData = nativeOnly
  [<IsConst>] static member fast_rewind_rounded: IconData = nativeOnly
  [<IsConst>] static member fast_rewind_outlined: IconData = nativeOnly
  [<IsConst>] static member fastfood: IconData = nativeOnly
  [<IsConst>] static member fastfood_sharp: IconData = nativeOnly
  [<IsConst>] static member fastfood_rounded: IconData = nativeOnly
  [<IsConst>] static member fastfood_outlined: IconData = nativeOnly
  [<IsConst>] static member favorite: IconData = nativeOnly
  [<IsConst>] static member favorite_sharp: IconData = nativeOnly
  [<IsConst>] static member favorite_rounded: IconData = nativeOnly
  [<IsConst>] static member favorite_outlined: IconData = nativeOnly
  [<IsConst>] static member favorite_border: IconData = nativeOnly
  [<IsConst>] static member favorite_border_sharp: IconData = nativeOnly
  [<IsConst>] static member favorite_border_rounded: IconData = nativeOnly
  [<IsConst>] static member favorite_border_outlined: IconData = nativeOnly
  [<IsConst>] static member favorite_outline: IconData = nativeOnly
  [<IsConst>] static member favorite_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member favorite_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member favorite_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member fax: IconData = nativeOnly
  [<IsConst>] static member fax_sharp: IconData = nativeOnly
  [<IsConst>] static member fax_rounded: IconData = nativeOnly
  [<IsConst>] static member fax_outlined: IconData = nativeOnly
  [<IsConst>] static member featured_play_list: IconData = nativeOnly
  [<IsConst>] static member featured_play_list_sharp: IconData = nativeOnly
  [<IsConst>] static member featured_play_list_rounded: IconData = nativeOnly
  [<IsConst>] static member featured_play_list_outlined: IconData = nativeOnly
  [<IsConst>] static member featured_video: IconData = nativeOnly
  [<IsConst>] static member featured_video_sharp: IconData = nativeOnly
  [<IsConst>] static member featured_video_rounded: IconData = nativeOnly
  [<IsConst>] static member featured_video_outlined: IconData = nativeOnly
  [<IsConst>] static member feed: IconData = nativeOnly
  [<IsConst>] static member feed_sharp: IconData = nativeOnly
  [<IsConst>] static member feed_rounded: IconData = nativeOnly
  [<IsConst>] static member feed_outlined: IconData = nativeOnly
  [<IsConst>] static member feedback: IconData = nativeOnly
  [<IsConst>] static member feedback_sharp: IconData = nativeOnly
  [<IsConst>] static member feedback_rounded: IconData = nativeOnly
  [<IsConst>] static member feedback_outlined: IconData = nativeOnly
  [<IsConst>] static member female: IconData = nativeOnly
  [<IsConst>] static member female_sharp: IconData = nativeOnly
  [<IsConst>] static member female_rounded: IconData = nativeOnly
  [<IsConst>] static member female_outlined: IconData = nativeOnly
  [<IsConst>] static member fence: IconData = nativeOnly
  [<IsConst>] static member fence_sharp: IconData = nativeOnly
  [<IsConst>] static member fence_rounded: IconData = nativeOnly
  [<IsConst>] static member fence_outlined: IconData = nativeOnly
  [<IsConst>] static member festival: IconData = nativeOnly
  [<IsConst>] static member festival_sharp: IconData = nativeOnly
  [<IsConst>] static member festival_rounded: IconData = nativeOnly
  [<IsConst>] static member festival_outlined: IconData = nativeOnly
  [<IsConst>] static member fiber_dvr: IconData = nativeOnly
  [<IsConst>] static member fiber_dvr_sharp: IconData = nativeOnly
  [<IsConst>] static member fiber_dvr_rounded: IconData = nativeOnly
  [<IsConst>] static member fiber_dvr_outlined: IconData = nativeOnly
  [<IsConst>] static member fiber_manual_record: IconData = nativeOnly
  [<IsConst>] static member fiber_manual_record_sharp: IconData = nativeOnly
  [<IsConst>] static member fiber_manual_record_rounded: IconData = nativeOnly
  [<IsConst>] static member fiber_manual_record_outlined: IconData = nativeOnly
  [<IsConst>] static member fiber_new: IconData = nativeOnly
  [<IsConst>] static member fiber_new_sharp: IconData = nativeOnly
  [<IsConst>] static member fiber_new_rounded: IconData = nativeOnly
  [<IsConst>] static member fiber_new_outlined: IconData = nativeOnly
  [<IsConst>] static member fiber_pin: IconData = nativeOnly
  [<IsConst>] static member fiber_pin_sharp: IconData = nativeOnly
  [<IsConst>] static member fiber_pin_rounded: IconData = nativeOnly
  [<IsConst>] static member fiber_pin_outlined: IconData = nativeOnly
  [<IsConst>] static member fiber_smart_record: IconData = nativeOnly
  [<IsConst>] static member fiber_smart_record_sharp: IconData = nativeOnly
  [<IsConst>] static member fiber_smart_record_rounded: IconData = nativeOnly
  [<IsConst>] static member fiber_smart_record_outlined: IconData = nativeOnly
  [<IsConst>] static member file_copy: IconData = nativeOnly
  [<IsConst>] static member file_copy_sharp: IconData = nativeOnly
  [<IsConst>] static member file_copy_rounded: IconData = nativeOnly
  [<IsConst>] static member file_copy_outlined: IconData = nativeOnly
  [<IsConst>] static member file_download: IconData = nativeOnly
  [<IsConst>] static member file_download_sharp: IconData = nativeOnly
  [<IsConst>] static member file_download_rounded: IconData = nativeOnly
  [<IsConst>] static member file_download_outlined: IconData = nativeOnly
  [<IsConst>] static member file_download_done: IconData = nativeOnly
  [<IsConst>] static member file_download_done_sharp: IconData = nativeOnly
  [<IsConst>] static member file_download_done_rounded: IconData = nativeOnly
  [<IsConst>] static member file_download_done_outlined: IconData = nativeOnly
  [<IsConst>] static member file_download_off: IconData = nativeOnly
  [<IsConst>] static member file_download_off_sharp: IconData = nativeOnly
  [<IsConst>] static member file_download_off_rounded: IconData = nativeOnly
  [<IsConst>] static member file_download_off_outlined: IconData = nativeOnly
  [<IsConst>] static member file_open: IconData = nativeOnly
  [<IsConst>] static member file_open_sharp: IconData = nativeOnly
  [<IsConst>] static member file_open_rounded: IconData = nativeOnly
  [<IsConst>] static member file_open_outlined: IconData = nativeOnly
  [<IsConst>] static member file_present: IconData = nativeOnly
  [<IsConst>] static member file_present_sharp: IconData = nativeOnly
  [<IsConst>] static member file_present_rounded: IconData = nativeOnly
  [<IsConst>] static member file_present_outlined: IconData = nativeOnly
  [<IsConst>] static member file_upload: IconData = nativeOnly
  [<IsConst>] static member file_upload_sharp: IconData = nativeOnly
  [<IsConst>] static member file_upload_rounded: IconData = nativeOnly
  [<IsConst>] static member file_upload_outlined: IconData = nativeOnly
  [<IsConst>] static member filter: IconData = nativeOnly
  [<IsConst>] static member filter_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_1: IconData = nativeOnly
  [<IsConst>] static member filter_1_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_1_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_1_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_2: IconData = nativeOnly
  [<IsConst>] static member filter_2_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_2_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_2_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_3: IconData = nativeOnly
  [<IsConst>] static member filter_3_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_3_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_3_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_4: IconData = nativeOnly
  [<IsConst>] static member filter_4_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_4_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_4_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_5: IconData = nativeOnly
  [<IsConst>] static member filter_5_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_5_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_5_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_6: IconData = nativeOnly
  [<IsConst>] static member filter_6_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_6_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_6_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_7: IconData = nativeOnly
  [<IsConst>] static member filter_7_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_7_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_7_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_8: IconData = nativeOnly
  [<IsConst>] static member filter_8_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_8_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_8_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_9: IconData = nativeOnly
  [<IsConst>] static member filter_9_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_9_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_9_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_9_plus: IconData = nativeOnly
  [<IsConst>] static member filter_9_plus_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_9_plus_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_9_plus_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_alt: IconData = nativeOnly
  [<IsConst>] static member filter_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_alt_off: IconData = nativeOnly
  [<IsConst>] static member filter_alt_off_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_alt_off_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_alt_off_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_b_and_w: IconData = nativeOnly
  [<IsConst>] static member filter_b_and_w_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_b_and_w_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_b_and_w_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_center_focus: IconData = nativeOnly
  [<IsConst>] static member filter_center_focus_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_center_focus_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_center_focus_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_drama: IconData = nativeOnly
  [<IsConst>] static member filter_drama_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_drama_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_drama_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_frames: IconData = nativeOnly
  [<IsConst>] static member filter_frames_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_frames_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_frames_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_hdr: IconData = nativeOnly
  [<IsConst>] static member filter_hdr_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_hdr_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_hdr_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_list: IconData = nativeOnly
  [<IsConst>] static member filter_list_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_list_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_list_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_list_alt: IconData = nativeOnly
  [<IsConst>] static member filter_list_off: IconData = nativeOnly
  [<IsConst>] static member filter_list_off_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_list_off_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_list_off_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_none: IconData = nativeOnly
  [<IsConst>] static member filter_none_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_none_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_none_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_tilt_shift: IconData = nativeOnly
  [<IsConst>] static member filter_tilt_shift_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_tilt_shift_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_tilt_shift_outlined: IconData = nativeOnly
  [<IsConst>] static member filter_vintage: IconData = nativeOnly
  [<IsConst>] static member filter_vintage_sharp: IconData = nativeOnly
  [<IsConst>] static member filter_vintage_rounded: IconData = nativeOnly
  [<IsConst>] static member filter_vintage_outlined: IconData = nativeOnly
  [<IsConst>] static member find_in_page: IconData = nativeOnly
  [<IsConst>] static member find_in_page_sharp: IconData = nativeOnly
  [<IsConst>] static member find_in_page_rounded: IconData = nativeOnly
  [<IsConst>] static member find_in_page_outlined: IconData = nativeOnly
  [<IsConst>] static member find_replace: IconData = nativeOnly
  [<IsConst>] static member find_replace_sharp: IconData = nativeOnly
  [<IsConst>] static member find_replace_rounded: IconData = nativeOnly
  [<IsConst>] static member find_replace_outlined: IconData = nativeOnly
  [<IsConst>] static member fingerprint: IconData = nativeOnly
  [<IsConst>] static member fingerprint_sharp: IconData = nativeOnly
  [<IsConst>] static member fingerprint_rounded: IconData = nativeOnly
  [<IsConst>] static member fingerprint_outlined: IconData = nativeOnly
  [<IsConst>] static member fire_extinguisher: IconData = nativeOnly
  [<IsConst>] static member fire_extinguisher_sharp: IconData = nativeOnly
  [<IsConst>] static member fire_extinguisher_rounded: IconData = nativeOnly
  [<IsConst>] static member fire_extinguisher_outlined: IconData = nativeOnly
  [<IsConst>] static member fire_hydrant: IconData = nativeOnly
  [<IsConst>] static member fire_hydrant_alt: IconData = nativeOnly
  [<IsConst>] static member fire_hydrant_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member fire_hydrant_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member fire_hydrant_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member fire_truck: IconData = nativeOnly
  [<IsConst>] static member fire_truck_sharp: IconData = nativeOnly
  [<IsConst>] static member fire_truck_rounded: IconData = nativeOnly
  [<IsConst>] static member fire_truck_outlined: IconData = nativeOnly
  [<IsConst>] static member fireplace: IconData = nativeOnly
  [<IsConst>] static member fireplace_sharp: IconData = nativeOnly
  [<IsConst>] static member fireplace_rounded: IconData = nativeOnly
  [<IsConst>] static member fireplace_outlined: IconData = nativeOnly
  [<IsConst>] static member first_page: IconData = nativeOnly
  [<IsConst>] static member first_page_sharp: IconData = nativeOnly
  [<IsConst>] static member first_page_rounded: IconData = nativeOnly
  [<IsConst>] static member first_page_outlined: IconData = nativeOnly
  [<IsConst>] static member fit_screen: IconData = nativeOnly
  [<IsConst>] static member fit_screen_sharp: IconData = nativeOnly
  [<IsConst>] static member fit_screen_rounded: IconData = nativeOnly
  [<IsConst>] static member fit_screen_outlined: IconData = nativeOnly
  [<IsConst>] static member fitbit: IconData = nativeOnly
  [<IsConst>] static member fitbit_sharp: IconData = nativeOnly
  [<IsConst>] static member fitbit_rounded: IconData = nativeOnly
  [<IsConst>] static member fitbit_outlined: IconData = nativeOnly
  [<IsConst>] static member fitness_center: IconData = nativeOnly
  [<IsConst>] static member fitness_center_sharp: IconData = nativeOnly
  [<IsConst>] static member fitness_center_rounded: IconData = nativeOnly
  [<IsConst>] static member fitness_center_outlined: IconData = nativeOnly
  [<IsConst>] static member flag: IconData = nativeOnly
  [<IsConst>] static member flag_sharp: IconData = nativeOnly
  [<IsConst>] static member flag_rounded: IconData = nativeOnly
  [<IsConst>] static member flag_outlined: IconData = nativeOnly
  [<IsConst>] static member flag_circle: IconData = nativeOnly
  [<IsConst>] static member flag_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member flag_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member flag_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member flaky: IconData = nativeOnly
  [<IsConst>] static member flaky_sharp: IconData = nativeOnly
  [<IsConst>] static member flaky_rounded: IconData = nativeOnly
  [<IsConst>] static member flaky_outlined: IconData = nativeOnly
  [<IsConst>] static member flare: IconData = nativeOnly
  [<IsConst>] static member flare_sharp: IconData = nativeOnly
  [<IsConst>] static member flare_rounded: IconData = nativeOnly
  [<IsConst>] static member flare_outlined: IconData = nativeOnly
  [<IsConst>] static member flash_auto: IconData = nativeOnly
  [<IsConst>] static member flash_auto_sharp: IconData = nativeOnly
  [<IsConst>] static member flash_auto_rounded: IconData = nativeOnly
  [<IsConst>] static member flash_auto_outlined: IconData = nativeOnly
  [<IsConst>] static member flash_off: IconData = nativeOnly
  [<IsConst>] static member flash_off_sharp: IconData = nativeOnly
  [<IsConst>] static member flash_off_rounded: IconData = nativeOnly
  [<IsConst>] static member flash_off_outlined: IconData = nativeOnly
  [<IsConst>] static member flash_on: IconData = nativeOnly
  [<IsConst>] static member flash_on_sharp: IconData = nativeOnly
  [<IsConst>] static member flash_on_rounded: IconData = nativeOnly
  [<IsConst>] static member flash_on_outlined: IconData = nativeOnly
  [<IsConst>] static member flashlight_off: IconData = nativeOnly
  [<IsConst>] static member flashlight_off_sharp: IconData = nativeOnly
  [<IsConst>] static member flashlight_off_rounded: IconData = nativeOnly
  [<IsConst>] static member flashlight_off_outlined: IconData = nativeOnly
  [<IsConst>] static member flashlight_on: IconData = nativeOnly
  [<IsConst>] static member flashlight_on_sharp: IconData = nativeOnly
  [<IsConst>] static member flashlight_on_rounded: IconData = nativeOnly
  [<IsConst>] static member flashlight_on_outlined: IconData = nativeOnly
  [<IsConst>] static member flatware: IconData = nativeOnly
  [<IsConst>] static member flatware_sharp: IconData = nativeOnly
  [<IsConst>] static member flatware_rounded: IconData = nativeOnly
  [<IsConst>] static member flatware_outlined: IconData = nativeOnly
  [<IsConst>] static member flight: IconData = nativeOnly
  [<IsConst>] static member flight_sharp: IconData = nativeOnly
  [<IsConst>] static member flight_rounded: IconData = nativeOnly
  [<IsConst>] static member flight_outlined: IconData = nativeOnly
  [<IsConst>] static member flight_class: IconData = nativeOnly
  [<IsConst>] static member flight_class_sharp: IconData = nativeOnly
  [<IsConst>] static member flight_class_rounded: IconData = nativeOnly
  [<IsConst>] static member flight_class_outlined: IconData = nativeOnly
  [<IsConst>] static member flight_land: IconData = nativeOnly
  [<IsConst>] static member flight_land_sharp: IconData = nativeOnly
  [<IsConst>] static member flight_land_rounded: IconData = nativeOnly
  [<IsConst>] static member flight_land_outlined: IconData = nativeOnly
  [<IsConst>] static member flight_takeoff: IconData = nativeOnly
  [<IsConst>] static member flight_takeoff_sharp: IconData = nativeOnly
  [<IsConst>] static member flight_takeoff_rounded: IconData = nativeOnly
  [<IsConst>] static member flight_takeoff_outlined: IconData = nativeOnly
  [<IsConst>] static member flip: IconData = nativeOnly
  [<IsConst>] static member flip_sharp: IconData = nativeOnly
  [<IsConst>] static member flip_rounded: IconData = nativeOnly
  [<IsConst>] static member flip_outlined: IconData = nativeOnly
  [<IsConst>] static member flip_camera_android: IconData = nativeOnly
  [<IsConst>] static member flip_camera_android_sharp: IconData = nativeOnly
  [<IsConst>] static member flip_camera_android_rounded: IconData = nativeOnly
  [<IsConst>] static member flip_camera_android_outlined: IconData = nativeOnly
  [<IsConst>] static member flip_camera_ios: IconData = nativeOnly
  [<IsConst>] static member flip_camera_ios_sharp: IconData = nativeOnly
  [<IsConst>] static member flip_camera_ios_rounded: IconData = nativeOnly
  [<IsConst>] static member flip_camera_ios_outlined: IconData = nativeOnly
  [<IsConst>] static member flip_to_back: IconData = nativeOnly
  [<IsConst>] static member flip_to_back_sharp: IconData = nativeOnly
  [<IsConst>] static member flip_to_back_rounded: IconData = nativeOnly
  [<IsConst>] static member flip_to_back_outlined: IconData = nativeOnly
  [<IsConst>] static member flip_to_front: IconData = nativeOnly
  [<IsConst>] static member flip_to_front_sharp: IconData = nativeOnly
  [<IsConst>] static member flip_to_front_rounded: IconData = nativeOnly
  [<IsConst>] static member flip_to_front_outlined: IconData = nativeOnly
  [<IsConst>] static member flood: IconData = nativeOnly
  [<IsConst>] static member flood_sharp: IconData = nativeOnly
  [<IsConst>] static member flood_rounded: IconData = nativeOnly
  [<IsConst>] static member flood_outlined: IconData = nativeOnly
  [<IsConst>] static member flourescent: IconData = nativeOnly
  [<IsConst>] static member flourescent_sharp: IconData = nativeOnly
  [<IsConst>] static member flourescent_rounded: IconData = nativeOnly
  [<IsConst>] static member flourescent_outlined: IconData = nativeOnly
  [<IsConst>] static member flutter_dash: IconData = nativeOnly
  [<IsConst>] static member flutter_dash_sharp: IconData = nativeOnly
  [<IsConst>] static member flutter_dash_rounded: IconData = nativeOnly
  [<IsConst>] static member flutter_dash_outlined: IconData = nativeOnly
  [<IsConst>] static member fmd_bad: IconData = nativeOnly
  [<IsConst>] static member fmd_bad_sharp: IconData = nativeOnly
  [<IsConst>] static member fmd_bad_rounded: IconData = nativeOnly
  [<IsConst>] static member fmd_bad_outlined: IconData = nativeOnly
  [<IsConst>] static member fmd_good: IconData = nativeOnly
  [<IsConst>] static member fmd_good_sharp: IconData = nativeOnly
  [<IsConst>] static member fmd_good_rounded: IconData = nativeOnly
  [<IsConst>] static member fmd_good_outlined: IconData = nativeOnly
  [<IsConst>] static member foggy: IconData = nativeOnly
  [<IsConst>] static member folder: IconData = nativeOnly
  [<IsConst>] static member folder_sharp: IconData = nativeOnly
  [<IsConst>] static member folder_rounded: IconData = nativeOnly
  [<IsConst>] static member folder_outlined: IconData = nativeOnly
  [<IsConst>] static member folder_copy: IconData = nativeOnly
  [<IsConst>] static member folder_copy_sharp: IconData = nativeOnly
  [<IsConst>] static member folder_copy_rounded: IconData = nativeOnly
  [<IsConst>] static member folder_copy_outlined: IconData = nativeOnly
  [<IsConst>] static member folder_delete: IconData = nativeOnly
  [<IsConst>] static member folder_delete_sharp: IconData = nativeOnly
  [<IsConst>] static member folder_delete_rounded: IconData = nativeOnly
  [<IsConst>] static member folder_delete_outlined: IconData = nativeOnly
  [<IsConst>] static member folder_off: IconData = nativeOnly
  [<IsConst>] static member folder_off_sharp: IconData = nativeOnly
  [<IsConst>] static member folder_off_rounded: IconData = nativeOnly
  [<IsConst>] static member folder_off_outlined: IconData = nativeOnly
  [<IsConst>] static member folder_open: IconData = nativeOnly
  [<IsConst>] static member folder_open_sharp: IconData = nativeOnly
  [<IsConst>] static member folder_open_rounded: IconData = nativeOnly
  [<IsConst>] static member folder_open_outlined: IconData = nativeOnly
  [<IsConst>] static member folder_shared: IconData = nativeOnly
  [<IsConst>] static member folder_shared_sharp: IconData = nativeOnly
  [<IsConst>] static member folder_shared_rounded: IconData = nativeOnly
  [<IsConst>] static member folder_shared_outlined: IconData = nativeOnly
  [<IsConst>] static member folder_special: IconData = nativeOnly
  [<IsConst>] static member folder_special_sharp: IconData = nativeOnly
  [<IsConst>] static member folder_special_rounded: IconData = nativeOnly
  [<IsConst>] static member folder_special_outlined: IconData = nativeOnly
  [<IsConst>] static member folder_zip: IconData = nativeOnly
  [<IsConst>] static member folder_zip_sharp: IconData = nativeOnly
  [<IsConst>] static member folder_zip_rounded: IconData = nativeOnly
  [<IsConst>] static member folder_zip_outlined: IconData = nativeOnly
  [<IsConst>] static member follow_the_signs: IconData = nativeOnly
  [<IsConst>] static member follow_the_signs_sharp: IconData = nativeOnly
  [<IsConst>] static member follow_the_signs_rounded: IconData = nativeOnly
  [<IsConst>] static member follow_the_signs_outlined: IconData = nativeOnly
  [<IsConst>] static member font_download: IconData = nativeOnly
  [<IsConst>] static member font_download_sharp: IconData = nativeOnly
  [<IsConst>] static member font_download_rounded: IconData = nativeOnly
  [<IsConst>] static member font_download_outlined: IconData = nativeOnly
  [<IsConst>] static member font_download_off: IconData = nativeOnly
  [<IsConst>] static member font_download_off_sharp: IconData = nativeOnly
  [<IsConst>] static member font_download_off_rounded: IconData = nativeOnly
  [<IsConst>] static member font_download_off_outlined: IconData = nativeOnly
  [<IsConst>] static member food_bank: IconData = nativeOnly
  [<IsConst>] static member food_bank_sharp: IconData = nativeOnly
  [<IsConst>] static member food_bank_rounded: IconData = nativeOnly
  [<IsConst>] static member food_bank_outlined: IconData = nativeOnly
  [<IsConst>] static member forest: IconData = nativeOnly
  [<IsConst>] static member forest_sharp: IconData = nativeOnly
  [<IsConst>] static member forest_rounded: IconData = nativeOnly
  [<IsConst>] static member forest_outlined: IconData = nativeOnly
  [<IsConst>] static member fork_left: IconData = nativeOnly
  [<IsConst>] static member fork_left_sharp: IconData = nativeOnly
  [<IsConst>] static member fork_left_rounded: IconData = nativeOnly
  [<IsConst>] static member fork_left_outlined: IconData = nativeOnly
  [<IsConst>] static member fork_right: IconData = nativeOnly
  [<IsConst>] static member fork_right_sharp: IconData = nativeOnly
  [<IsConst>] static member fork_right_rounded: IconData = nativeOnly
  [<IsConst>] static member fork_right_outlined: IconData = nativeOnly
  [<IsConst>] static member format_align_center: IconData = nativeOnly
  [<IsConst>] static member format_align_center_sharp: IconData = nativeOnly
  [<IsConst>] static member format_align_center_rounded: IconData = nativeOnly
  [<IsConst>] static member format_align_center_outlined: IconData = nativeOnly
  [<IsConst>] static member format_align_justify: IconData = nativeOnly
  [<IsConst>] static member format_align_justify_sharp: IconData = nativeOnly
  [<IsConst>] static member format_align_justify_rounded: IconData = nativeOnly
  [<IsConst>] static member format_align_justify_outlined: IconData = nativeOnly
  [<IsConst>] static member format_align_left: IconData = nativeOnly
  [<IsConst>] static member format_align_left_sharp: IconData = nativeOnly
  [<IsConst>] static member format_align_left_rounded: IconData = nativeOnly
  [<IsConst>] static member format_align_left_outlined: IconData = nativeOnly
  [<IsConst>] static member format_align_right: IconData = nativeOnly
  [<IsConst>] static member format_align_right_sharp: IconData = nativeOnly
  [<IsConst>] static member format_align_right_rounded: IconData = nativeOnly
  [<IsConst>] static member format_align_right_outlined: IconData = nativeOnly
  [<IsConst>] static member format_bold: IconData = nativeOnly
  [<IsConst>] static member format_bold_sharp: IconData = nativeOnly
  [<IsConst>] static member format_bold_rounded: IconData = nativeOnly
  [<IsConst>] static member format_bold_outlined: IconData = nativeOnly
  [<IsConst>] static member format_clear: IconData = nativeOnly
  [<IsConst>] static member format_clear_sharp: IconData = nativeOnly
  [<IsConst>] static member format_clear_rounded: IconData = nativeOnly
  [<IsConst>] static member format_clear_outlined: IconData = nativeOnly
  [<IsConst>] static member format_color_fill: IconData = nativeOnly
  [<IsConst>] static member format_color_fill_sharp: IconData = nativeOnly
  [<IsConst>] static member format_color_fill_rounded: IconData = nativeOnly
  [<IsConst>] static member format_color_fill_outlined: IconData = nativeOnly
  [<IsConst>] static member format_color_reset: IconData = nativeOnly
  [<IsConst>] static member format_color_reset_sharp: IconData = nativeOnly
  [<IsConst>] static member format_color_reset_rounded: IconData = nativeOnly
  [<IsConst>] static member format_color_reset_outlined: IconData = nativeOnly
  [<IsConst>] static member format_color_text: IconData = nativeOnly
  [<IsConst>] static member format_color_text_sharp: IconData = nativeOnly
  [<IsConst>] static member format_color_text_rounded: IconData = nativeOnly
  [<IsConst>] static member format_color_text_outlined: IconData = nativeOnly
  [<IsConst>] static member format_indent_decrease: IconData = nativeOnly
  [<IsConst>] static member format_indent_decrease_sharp: IconData = nativeOnly
  [<IsConst>] static member format_indent_decrease_rounded: IconData = nativeOnly
  [<IsConst>] static member format_indent_decrease_outlined: IconData = nativeOnly
  [<IsConst>] static member format_indent_increase: IconData = nativeOnly
  [<IsConst>] static member format_indent_increase_sharp: IconData = nativeOnly
  [<IsConst>] static member format_indent_increase_rounded: IconData = nativeOnly
  [<IsConst>] static member format_indent_increase_outlined: IconData = nativeOnly
  [<IsConst>] static member format_italic: IconData = nativeOnly
  [<IsConst>] static member format_italic_sharp: IconData = nativeOnly
  [<IsConst>] static member format_italic_rounded: IconData = nativeOnly
  [<IsConst>] static member format_italic_outlined: IconData = nativeOnly
  [<IsConst>] static member format_line_spacing: IconData = nativeOnly
  [<IsConst>] static member format_line_spacing_sharp: IconData = nativeOnly
  [<IsConst>] static member format_line_spacing_rounded: IconData = nativeOnly
  [<IsConst>] static member format_line_spacing_outlined: IconData = nativeOnly
  [<IsConst>] static member format_list_bulleted: IconData = nativeOnly
  [<IsConst>] static member format_list_bulleted_sharp: IconData = nativeOnly
  [<IsConst>] static member format_list_bulleted_rounded: IconData = nativeOnly
  [<IsConst>] static member format_list_bulleted_outlined: IconData = nativeOnly
  [<IsConst>] static member format_list_numbered: IconData = nativeOnly
  [<IsConst>] static member format_list_numbered_sharp: IconData = nativeOnly
  [<IsConst>] static member format_list_numbered_rounded: IconData = nativeOnly
  [<IsConst>] static member format_list_numbered_outlined: IconData = nativeOnly
  [<IsConst>] static member format_list_numbered_rtl: IconData = nativeOnly
  [<IsConst>] static member format_list_numbered_rtl_sharp: IconData = nativeOnly
  [<IsConst>] static member format_list_numbered_rtl_rounded: IconData = nativeOnly
  [<IsConst>] static member format_list_numbered_rtl_outlined: IconData = nativeOnly
  [<IsConst>] static member format_overline: IconData = nativeOnly
  [<IsConst>] static member format_overline_sharp: IconData = nativeOnly
  [<IsConst>] static member format_overline_rounded: IconData = nativeOnly
  [<IsConst>] static member format_overline_outlined: IconData = nativeOnly
  [<IsConst>] static member format_paint: IconData = nativeOnly
  [<IsConst>] static member format_paint_sharp: IconData = nativeOnly
  [<IsConst>] static member format_paint_rounded: IconData = nativeOnly
  [<IsConst>] static member format_paint_outlined: IconData = nativeOnly
  [<IsConst>] static member format_quote: IconData = nativeOnly
  [<IsConst>] static member format_quote_sharp: IconData = nativeOnly
  [<IsConst>] static member format_quote_rounded: IconData = nativeOnly
  [<IsConst>] static member format_quote_outlined: IconData = nativeOnly
  [<IsConst>] static member format_shapes: IconData = nativeOnly
  [<IsConst>] static member format_shapes_sharp: IconData = nativeOnly
  [<IsConst>] static member format_shapes_rounded: IconData = nativeOnly
  [<IsConst>] static member format_shapes_outlined: IconData = nativeOnly
  [<IsConst>] static member format_size: IconData = nativeOnly
  [<IsConst>] static member format_size_sharp: IconData = nativeOnly
  [<IsConst>] static member format_size_rounded: IconData = nativeOnly
  [<IsConst>] static member format_size_outlined: IconData = nativeOnly
  [<IsConst>] static member format_strikethrough: IconData = nativeOnly
  [<IsConst>] static member format_strikethrough_sharp: IconData = nativeOnly
  [<IsConst>] static member format_strikethrough_rounded: IconData = nativeOnly
  [<IsConst>] static member format_strikethrough_outlined: IconData = nativeOnly
  [<IsConst>] static member format_textdirection_l_to_r: IconData = nativeOnly
  [<IsConst>] static member format_textdirection_l_to_r_sharp: IconData = nativeOnly
  [<IsConst>] static member format_textdirection_l_to_r_rounded: IconData = nativeOnly
  [<IsConst>] static member format_textdirection_l_to_r_outlined: IconData = nativeOnly
  [<IsConst>] static member format_textdirection_r_to_l: IconData = nativeOnly
  [<IsConst>] static member format_textdirection_r_to_l_sharp: IconData = nativeOnly
  [<IsConst>] static member format_textdirection_r_to_l_rounded: IconData = nativeOnly
  [<IsConst>] static member format_textdirection_r_to_l_outlined: IconData = nativeOnly
  [<IsConst>] static member format_underline: IconData = nativeOnly
  [<IsConst>] static member format_underline_sharp: IconData = nativeOnly
  [<IsConst>] static member format_underline_rounded: IconData = nativeOnly
  [<IsConst>] static member format_underline_outlined: IconData = nativeOnly
  [<IsConst>] static member format_underlined: IconData = nativeOnly
  [<IsConst>] static member format_underlined_sharp: IconData = nativeOnly
  [<IsConst>] static member format_underlined_rounded: IconData = nativeOnly
  [<IsConst>] static member format_underlined_outlined: IconData = nativeOnly
  [<IsConst>] static member fort: IconData = nativeOnly
  [<IsConst>] static member fort_sharp: IconData = nativeOnly
  [<IsConst>] static member fort_rounded: IconData = nativeOnly
  [<IsConst>] static member fort_outlined: IconData = nativeOnly
  [<IsConst>] static member forum: IconData = nativeOnly
  [<IsConst>] static member forum_sharp: IconData = nativeOnly
  [<IsConst>] static member forum_rounded: IconData = nativeOnly
  [<IsConst>] static member forum_outlined: IconData = nativeOnly
  [<IsConst>] static member forward: IconData = nativeOnly
  [<IsConst>] static member forward_sharp: IconData = nativeOnly
  [<IsConst>] static member forward_rounded: IconData = nativeOnly
  [<IsConst>] static member forward_outlined: IconData = nativeOnly
  [<IsConst>] static member forward_10: IconData = nativeOnly
  [<IsConst>] static member forward_10_sharp: IconData = nativeOnly
  [<IsConst>] static member forward_10_rounded: IconData = nativeOnly
  [<IsConst>] static member forward_10_outlined: IconData = nativeOnly
  [<IsConst>] static member forward_30: IconData = nativeOnly
  [<IsConst>] static member forward_30_sharp: IconData = nativeOnly
  [<IsConst>] static member forward_30_rounded: IconData = nativeOnly
  [<IsConst>] static member forward_30_outlined: IconData = nativeOnly
  [<IsConst>] static member forward_5: IconData = nativeOnly
  [<IsConst>] static member forward_5_sharp: IconData = nativeOnly
  [<IsConst>] static member forward_5_rounded: IconData = nativeOnly
  [<IsConst>] static member forward_5_outlined: IconData = nativeOnly
  [<IsConst>] static member forward_to_inbox: IconData = nativeOnly
  [<IsConst>] static member forward_to_inbox_sharp: IconData = nativeOnly
  [<IsConst>] static member forward_to_inbox_rounded: IconData = nativeOnly
  [<IsConst>] static member forward_to_inbox_outlined: IconData = nativeOnly
  [<IsConst>] static member foundation: IconData = nativeOnly
  [<IsConst>] static member foundation_sharp: IconData = nativeOnly
  [<IsConst>] static member foundation_rounded: IconData = nativeOnly
  [<IsConst>] static member foundation_outlined: IconData = nativeOnly
  [<IsConst>] static member free_breakfast: IconData = nativeOnly
  [<IsConst>] static member free_breakfast_sharp: IconData = nativeOnly
  [<IsConst>] static member free_breakfast_rounded: IconData = nativeOnly
  [<IsConst>] static member free_breakfast_outlined: IconData = nativeOnly
  [<IsConst>] static member free_cancellation: IconData = nativeOnly
  [<IsConst>] static member free_cancellation_sharp: IconData = nativeOnly
  [<IsConst>] static member free_cancellation_rounded: IconData = nativeOnly
  [<IsConst>] static member free_cancellation_outlined: IconData = nativeOnly
  [<IsConst>] static member front_hand: IconData = nativeOnly
  [<IsConst>] static member front_hand_sharp: IconData = nativeOnly
  [<IsConst>] static member front_hand_rounded: IconData = nativeOnly
  [<IsConst>] static member front_hand_outlined: IconData = nativeOnly
  [<IsConst>] static member fullscreen: IconData = nativeOnly
  [<IsConst>] static member fullscreen_sharp: IconData = nativeOnly
  [<IsConst>] static member fullscreen_rounded: IconData = nativeOnly
  [<IsConst>] static member fullscreen_outlined: IconData = nativeOnly
  [<IsConst>] static member fullscreen_exit: IconData = nativeOnly
  [<IsConst>] static member fullscreen_exit_sharp: IconData = nativeOnly
  [<IsConst>] static member fullscreen_exit_rounded: IconData = nativeOnly
  [<IsConst>] static member fullscreen_exit_outlined: IconData = nativeOnly
  [<IsConst>] static member functions: IconData = nativeOnly
  [<IsConst>] static member functions_sharp: IconData = nativeOnly
  [<IsConst>] static member functions_rounded: IconData = nativeOnly
  [<IsConst>] static member functions_outlined: IconData = nativeOnly
  [<IsConst>] static member g_mobiledata: IconData = nativeOnly
  [<IsConst>] static member g_mobiledata_sharp: IconData = nativeOnly
  [<IsConst>] static member g_mobiledata_rounded: IconData = nativeOnly
  [<IsConst>] static member g_mobiledata_outlined: IconData = nativeOnly
  [<IsConst>] static member g_translate: IconData = nativeOnly
  [<IsConst>] static member g_translate_sharp: IconData = nativeOnly
  [<IsConst>] static member g_translate_rounded: IconData = nativeOnly
  [<IsConst>] static member g_translate_outlined: IconData = nativeOnly
  [<IsConst>] static member gamepad: IconData = nativeOnly
  [<IsConst>] static member gamepad_sharp: IconData = nativeOnly
  [<IsConst>] static member gamepad_rounded: IconData = nativeOnly
  [<IsConst>] static member gamepad_outlined: IconData = nativeOnly
  [<IsConst>] static member games: IconData = nativeOnly
  [<IsConst>] static member games_sharp: IconData = nativeOnly
  [<IsConst>] static member games_rounded: IconData = nativeOnly
  [<IsConst>] static member games_outlined: IconData = nativeOnly
  [<IsConst>] static member garage: IconData = nativeOnly
  [<IsConst>] static member garage_sharp: IconData = nativeOnly
  [<IsConst>] static member garage_rounded: IconData = nativeOnly
  [<IsConst>] static member garage_outlined: IconData = nativeOnly
  [<IsConst>] static member gas_meter: IconData = nativeOnly
  [<IsConst>] static member gas_meter_sharp: IconData = nativeOnly
  [<IsConst>] static member gas_meter_rounded: IconData = nativeOnly
  [<IsConst>] static member gas_meter_outlined: IconData = nativeOnly
  [<IsConst>] static member gavel: IconData = nativeOnly
  [<IsConst>] static member gavel_sharp: IconData = nativeOnly
  [<IsConst>] static member gavel_rounded: IconData = nativeOnly
  [<IsConst>] static member gavel_outlined: IconData = nativeOnly
  [<IsConst>] static member generating_tokens: IconData = nativeOnly
  [<IsConst>] static member generating_tokens_sharp: IconData = nativeOnly
  [<IsConst>] static member generating_tokens_rounded: IconData = nativeOnly
  [<IsConst>] static member generating_tokens_outlined: IconData = nativeOnly
  [<IsConst>] static member gesture: IconData = nativeOnly
  [<IsConst>] static member gesture_sharp: IconData = nativeOnly
  [<IsConst>] static member gesture_rounded: IconData = nativeOnly
  [<IsConst>] static member gesture_outlined: IconData = nativeOnly
  [<IsConst>] static member get_app: IconData = nativeOnly
  [<IsConst>] static member get_app_sharp: IconData = nativeOnly
  [<IsConst>] static member get_app_rounded: IconData = nativeOnly
  [<IsConst>] static member get_app_outlined: IconData = nativeOnly
  [<IsConst>] static member gif: IconData = nativeOnly
  [<IsConst>] static member gif_sharp: IconData = nativeOnly
  [<IsConst>] static member gif_rounded: IconData = nativeOnly
  [<IsConst>] static member gif_outlined: IconData = nativeOnly
  [<IsConst>] static member gif_box: IconData = nativeOnly
  [<IsConst>] static member gif_box_sharp: IconData = nativeOnly
  [<IsConst>] static member gif_box_rounded: IconData = nativeOnly
  [<IsConst>] static member gif_box_outlined: IconData = nativeOnly
  [<IsConst>] static member girl: IconData = nativeOnly
  [<IsConst>] static member girl_sharp: IconData = nativeOnly
  [<IsConst>] static member girl_rounded: IconData = nativeOnly
  [<IsConst>] static member girl_outlined: IconData = nativeOnly
  [<IsConst>] static member gite: IconData = nativeOnly
  [<IsConst>] static member gite_sharp: IconData = nativeOnly
  [<IsConst>] static member gite_rounded: IconData = nativeOnly
  [<IsConst>] static member gite_outlined: IconData = nativeOnly
  [<IsConst>] static member golf_course: IconData = nativeOnly
  [<IsConst>] static member golf_course_sharp: IconData = nativeOnly
  [<IsConst>] static member golf_course_rounded: IconData = nativeOnly
  [<IsConst>] static member golf_course_outlined: IconData = nativeOnly
  [<IsConst>] static member gpp_bad: IconData = nativeOnly
  [<IsConst>] static member gpp_bad_sharp: IconData = nativeOnly
  [<IsConst>] static member gpp_bad_rounded: IconData = nativeOnly
  [<IsConst>] static member gpp_bad_outlined: IconData = nativeOnly
  [<IsConst>] static member gpp_good: IconData = nativeOnly
  [<IsConst>] static member gpp_good_sharp: IconData = nativeOnly
  [<IsConst>] static member gpp_good_rounded: IconData = nativeOnly
  [<IsConst>] static member gpp_good_outlined: IconData = nativeOnly
  [<IsConst>] static member gpp_maybe: IconData = nativeOnly
  [<IsConst>] static member gpp_maybe_sharp: IconData = nativeOnly
  [<IsConst>] static member gpp_maybe_rounded: IconData = nativeOnly
  [<IsConst>] static member gpp_maybe_outlined: IconData = nativeOnly
  [<IsConst>] static member gps_fixed: IconData = nativeOnly
  [<IsConst>] static member gps_fixed_sharp: IconData = nativeOnly
  [<IsConst>] static member gps_fixed_rounded: IconData = nativeOnly
  [<IsConst>] static member gps_fixed_outlined: IconData = nativeOnly
  [<IsConst>] static member gps_not_fixed: IconData = nativeOnly
  [<IsConst>] static member gps_not_fixed_sharp: IconData = nativeOnly
  [<IsConst>] static member gps_not_fixed_rounded: IconData = nativeOnly
  [<IsConst>] static member gps_not_fixed_outlined: IconData = nativeOnly
  [<IsConst>] static member gps_off: IconData = nativeOnly
  [<IsConst>] static member gps_off_sharp: IconData = nativeOnly
  [<IsConst>] static member gps_off_rounded: IconData = nativeOnly
  [<IsConst>] static member gps_off_outlined: IconData = nativeOnly
  [<IsConst>] static member grade: IconData = nativeOnly
  [<IsConst>] static member grade_sharp: IconData = nativeOnly
  [<IsConst>] static member grade_rounded: IconData = nativeOnly
  [<IsConst>] static member grade_outlined: IconData = nativeOnly
  [<IsConst>] static member gradient: IconData = nativeOnly
  [<IsConst>] static member gradient_sharp: IconData = nativeOnly
  [<IsConst>] static member gradient_rounded: IconData = nativeOnly
  [<IsConst>] static member gradient_outlined: IconData = nativeOnly
  [<IsConst>] static member grading: IconData = nativeOnly
  [<IsConst>] static member grading_sharp: IconData = nativeOnly
  [<IsConst>] static member grading_rounded: IconData = nativeOnly
  [<IsConst>] static member grading_outlined: IconData = nativeOnly
  [<IsConst>] static member grain: IconData = nativeOnly
  [<IsConst>] static member grain_sharp: IconData = nativeOnly
  [<IsConst>] static member grain_rounded: IconData = nativeOnly
  [<IsConst>] static member grain_outlined: IconData = nativeOnly
  [<IsConst>] static member graphic_eq: IconData = nativeOnly
  [<IsConst>] static member graphic_eq_sharp: IconData = nativeOnly
  [<IsConst>] static member graphic_eq_rounded: IconData = nativeOnly
  [<IsConst>] static member graphic_eq_outlined: IconData = nativeOnly
  [<IsConst>] static member grass: IconData = nativeOnly
  [<IsConst>] static member grass_sharp: IconData = nativeOnly
  [<IsConst>] static member grass_rounded: IconData = nativeOnly
  [<IsConst>] static member grass_outlined: IconData = nativeOnly
  [<IsConst>] static member grid_3x3: IconData = nativeOnly
  [<IsConst>] static member grid_3x3_sharp: IconData = nativeOnly
  [<IsConst>] static member grid_3x3_rounded: IconData = nativeOnly
  [<IsConst>] static member grid_3x3_outlined: IconData = nativeOnly
  [<IsConst>] static member grid_4x4: IconData = nativeOnly
  [<IsConst>] static member grid_4x4_sharp: IconData = nativeOnly
  [<IsConst>] static member grid_4x4_rounded: IconData = nativeOnly
  [<IsConst>] static member grid_4x4_outlined: IconData = nativeOnly
  [<IsConst>] static member grid_goldenratio: IconData = nativeOnly
  [<IsConst>] static member grid_goldenratio_sharp: IconData = nativeOnly
  [<IsConst>] static member grid_goldenratio_rounded: IconData = nativeOnly
  [<IsConst>] static member grid_goldenratio_outlined: IconData = nativeOnly
  [<IsConst>] static member grid_off: IconData = nativeOnly
  [<IsConst>] static member grid_off_sharp: IconData = nativeOnly
  [<IsConst>] static member grid_off_rounded: IconData = nativeOnly
  [<IsConst>] static member grid_off_outlined: IconData = nativeOnly
  [<IsConst>] static member grid_on: IconData = nativeOnly
  [<IsConst>] static member grid_on_sharp: IconData = nativeOnly
  [<IsConst>] static member grid_on_rounded: IconData = nativeOnly
  [<IsConst>] static member grid_on_outlined: IconData = nativeOnly
  [<IsConst>] static member grid_view: IconData = nativeOnly
  [<IsConst>] static member grid_view_sharp: IconData = nativeOnly
  [<IsConst>] static member grid_view_rounded: IconData = nativeOnly
  [<IsConst>] static member grid_view_outlined: IconData = nativeOnly
  [<IsConst>] static member group: IconData = nativeOnly
  [<IsConst>] static member group_sharp: IconData = nativeOnly
  [<IsConst>] static member group_rounded: IconData = nativeOnly
  [<IsConst>] static member group_outlined: IconData = nativeOnly
  [<IsConst>] static member group_add: IconData = nativeOnly
  [<IsConst>] static member group_add_sharp: IconData = nativeOnly
  [<IsConst>] static member group_add_rounded: IconData = nativeOnly
  [<IsConst>] static member group_add_outlined: IconData = nativeOnly
  [<IsConst>] static member group_off: IconData = nativeOnly
  [<IsConst>] static member group_off_sharp: IconData = nativeOnly
  [<IsConst>] static member group_off_rounded: IconData = nativeOnly
  [<IsConst>] static member group_off_outlined: IconData = nativeOnly
  [<IsConst>] static member group_remove: IconData = nativeOnly
  [<IsConst>] static member group_remove_sharp: IconData = nativeOnly
  [<IsConst>] static member group_remove_rounded: IconData = nativeOnly
  [<IsConst>] static member group_remove_outlined: IconData = nativeOnly
  [<IsConst>] static member group_work: IconData = nativeOnly
  [<IsConst>] static member group_work_sharp: IconData = nativeOnly
  [<IsConst>] static member group_work_rounded: IconData = nativeOnly
  [<IsConst>] static member group_work_outlined: IconData = nativeOnly
  [<IsConst>] static member groups: IconData = nativeOnly
  [<IsConst>] static member groups_sharp: IconData = nativeOnly
  [<IsConst>] static member groups_rounded: IconData = nativeOnly
  [<IsConst>] static member groups_outlined: IconData = nativeOnly
  [<IsConst>] static member h_mobiledata: IconData = nativeOnly
  [<IsConst>] static member h_mobiledata_sharp: IconData = nativeOnly
  [<IsConst>] static member h_mobiledata_rounded: IconData = nativeOnly
  [<IsConst>] static member h_mobiledata_outlined: IconData = nativeOnly
  [<IsConst>] static member h_plus_mobiledata: IconData = nativeOnly
  [<IsConst>] static member h_plus_mobiledata_sharp: IconData = nativeOnly
  [<IsConst>] static member h_plus_mobiledata_rounded: IconData = nativeOnly
  [<IsConst>] static member h_plus_mobiledata_outlined: IconData = nativeOnly
  [<IsConst>] static member hail: IconData = nativeOnly
  [<IsConst>] static member hail_sharp: IconData = nativeOnly
  [<IsConst>] static member hail_rounded: IconData = nativeOnly
  [<IsConst>] static member hail_outlined: IconData = nativeOnly
  [<IsConst>] static member handshake: IconData = nativeOnly
  [<IsConst>] static member handshake_sharp: IconData = nativeOnly
  [<IsConst>] static member handshake_rounded: IconData = nativeOnly
  [<IsConst>] static member handshake_outlined: IconData = nativeOnly
  [<IsConst>] static member handyman: IconData = nativeOnly
  [<IsConst>] static member handyman_sharp: IconData = nativeOnly
  [<IsConst>] static member handyman_rounded: IconData = nativeOnly
  [<IsConst>] static member handyman_outlined: IconData = nativeOnly
  [<IsConst>] static member hardware: IconData = nativeOnly
  [<IsConst>] static member hardware_sharp: IconData = nativeOnly
  [<IsConst>] static member hardware_rounded: IconData = nativeOnly
  [<IsConst>] static member hardware_outlined: IconData = nativeOnly
  [<IsConst>] static member hd: IconData = nativeOnly
  [<IsConst>] static member hd_sharp: IconData = nativeOnly
  [<IsConst>] static member hd_rounded: IconData = nativeOnly
  [<IsConst>] static member hd_outlined: IconData = nativeOnly
  [<IsConst>] static member hdr_auto: IconData = nativeOnly
  [<IsConst>] static member hdr_auto_sharp: IconData = nativeOnly
  [<IsConst>] static member hdr_auto_rounded: IconData = nativeOnly
  [<IsConst>] static member hdr_auto_outlined: IconData = nativeOnly
  [<IsConst>] static member hdr_auto_select: IconData = nativeOnly
  [<IsConst>] static member hdr_auto_select_sharp: IconData = nativeOnly
  [<IsConst>] static member hdr_auto_select_rounded: IconData = nativeOnly
  [<IsConst>] static member hdr_auto_select_outlined: IconData = nativeOnly
  [<IsConst>] static member hdr_enhanced_select: IconData = nativeOnly
  [<IsConst>] static member hdr_enhanced_select_sharp: IconData = nativeOnly
  [<IsConst>] static member hdr_enhanced_select_rounded: IconData = nativeOnly
  [<IsConst>] static member hdr_enhanced_select_outlined: IconData = nativeOnly
  [<IsConst>] static member hdr_off: IconData = nativeOnly
  [<IsConst>] static member hdr_off_sharp: IconData = nativeOnly
  [<IsConst>] static member hdr_off_rounded: IconData = nativeOnly
  [<IsConst>] static member hdr_off_outlined: IconData = nativeOnly
  [<IsConst>] static member hdr_off_select: IconData = nativeOnly
  [<IsConst>] static member hdr_off_select_sharp: IconData = nativeOnly
  [<IsConst>] static member hdr_off_select_rounded: IconData = nativeOnly
  [<IsConst>] static member hdr_off_select_outlined: IconData = nativeOnly
  [<IsConst>] static member hdr_on: IconData = nativeOnly
  [<IsConst>] static member hdr_on_sharp: IconData = nativeOnly
  [<IsConst>] static member hdr_on_rounded: IconData = nativeOnly
  [<IsConst>] static member hdr_on_outlined: IconData = nativeOnly
  [<IsConst>] static member hdr_on_select: IconData = nativeOnly
  [<IsConst>] static member hdr_on_select_sharp: IconData = nativeOnly
  [<IsConst>] static member hdr_on_select_rounded: IconData = nativeOnly
  [<IsConst>] static member hdr_on_select_outlined: IconData = nativeOnly
  [<IsConst>] static member hdr_plus: IconData = nativeOnly
  [<IsConst>] static member hdr_plus_sharp: IconData = nativeOnly
  [<IsConst>] static member hdr_plus_rounded: IconData = nativeOnly
  [<IsConst>] static member hdr_plus_outlined: IconData = nativeOnly
  [<IsConst>] static member hdr_strong: IconData = nativeOnly
  [<IsConst>] static member hdr_strong_sharp: IconData = nativeOnly
  [<IsConst>] static member hdr_strong_rounded: IconData = nativeOnly
  [<IsConst>] static member hdr_strong_outlined: IconData = nativeOnly
  [<IsConst>] static member hdr_weak: IconData = nativeOnly
  [<IsConst>] static member hdr_weak_sharp: IconData = nativeOnly
  [<IsConst>] static member hdr_weak_rounded: IconData = nativeOnly
  [<IsConst>] static member hdr_weak_outlined: IconData = nativeOnly
  [<IsConst>] static member headphones: IconData = nativeOnly
  [<IsConst>] static member headphones_sharp: IconData = nativeOnly
  [<IsConst>] static member headphones_rounded: IconData = nativeOnly
  [<IsConst>] static member headphones_outlined: IconData = nativeOnly
  [<IsConst>] static member headphones_battery: IconData = nativeOnly
  [<IsConst>] static member headphones_battery_sharp: IconData = nativeOnly
  [<IsConst>] static member headphones_battery_rounded: IconData = nativeOnly
  [<IsConst>] static member headphones_battery_outlined: IconData = nativeOnly
  [<IsConst>] static member headset: IconData = nativeOnly
  [<IsConst>] static member headset_sharp: IconData = nativeOnly
  [<IsConst>] static member headset_rounded: IconData = nativeOnly
  [<IsConst>] static member headset_outlined: IconData = nativeOnly
  [<IsConst>] static member headset_mic: IconData = nativeOnly
  [<IsConst>] static member headset_mic_sharp: IconData = nativeOnly
  [<IsConst>] static member headset_mic_rounded: IconData = nativeOnly
  [<IsConst>] static member headset_mic_outlined: IconData = nativeOnly
  [<IsConst>] static member headset_off: IconData = nativeOnly
  [<IsConst>] static member headset_off_sharp: IconData = nativeOnly
  [<IsConst>] static member headset_off_rounded: IconData = nativeOnly
  [<IsConst>] static member headset_off_outlined: IconData = nativeOnly
  [<IsConst>] static member healing: IconData = nativeOnly
  [<IsConst>] static member healing_sharp: IconData = nativeOnly
  [<IsConst>] static member healing_rounded: IconData = nativeOnly
  [<IsConst>] static member healing_outlined: IconData = nativeOnly
  [<IsConst>] static member health_and_safety: IconData = nativeOnly
  [<IsConst>] static member health_and_safety_sharp: IconData = nativeOnly
  [<IsConst>] static member health_and_safety_rounded: IconData = nativeOnly
  [<IsConst>] static member health_and_safety_outlined: IconData = nativeOnly
  [<IsConst>] static member hearing: IconData = nativeOnly
  [<IsConst>] static member hearing_sharp: IconData = nativeOnly
  [<IsConst>] static member hearing_rounded: IconData = nativeOnly
  [<IsConst>] static member hearing_outlined: IconData = nativeOnly
  [<IsConst>] static member hearing_disabled: IconData = nativeOnly
  [<IsConst>] static member hearing_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member hearing_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member hearing_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member heart_broken: IconData = nativeOnly
  [<IsConst>] static member heart_broken_sharp: IconData = nativeOnly
  [<IsConst>] static member heart_broken_rounded: IconData = nativeOnly
  [<IsConst>] static member heart_broken_outlined: IconData = nativeOnly
  [<IsConst>] static member heat_pump: IconData = nativeOnly
  [<IsConst>] static member heat_pump_sharp: IconData = nativeOnly
  [<IsConst>] static member heat_pump_rounded: IconData = nativeOnly
  [<IsConst>] static member heat_pump_outlined: IconData = nativeOnly
  [<IsConst>] static member height: IconData = nativeOnly
  [<IsConst>] static member height_sharp: IconData = nativeOnly
  [<IsConst>] static member height_rounded: IconData = nativeOnly
  [<IsConst>] static member height_outlined: IconData = nativeOnly
  [<IsConst>] static member help: IconData = nativeOnly
  [<IsConst>] static member help_sharp: IconData = nativeOnly
  [<IsConst>] static member help_rounded: IconData = nativeOnly
  [<IsConst>] static member help_outlined: IconData = nativeOnly
  [<IsConst>] static member help_center: IconData = nativeOnly
  [<IsConst>] static member help_center_sharp: IconData = nativeOnly
  [<IsConst>] static member help_center_rounded: IconData = nativeOnly
  [<IsConst>] static member help_center_outlined: IconData = nativeOnly
  [<IsConst>] static member help_outline: IconData = nativeOnly
  [<IsConst>] static member help_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member help_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member help_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member hevc: IconData = nativeOnly
  [<IsConst>] static member hevc_sharp: IconData = nativeOnly
  [<IsConst>] static member hevc_rounded: IconData = nativeOnly
  [<IsConst>] static member hevc_outlined: IconData = nativeOnly
  [<IsConst>] static member hexagon: IconData = nativeOnly
  [<IsConst>] static member hexagon_sharp: IconData = nativeOnly
  [<IsConst>] static member hexagon_rounded: IconData = nativeOnly
  [<IsConst>] static member hexagon_outlined: IconData = nativeOnly
  [<IsConst>] static member hide_image: IconData = nativeOnly
  [<IsConst>] static member hide_image_sharp: IconData = nativeOnly
  [<IsConst>] static member hide_image_rounded: IconData = nativeOnly
  [<IsConst>] static member hide_image_outlined: IconData = nativeOnly
  [<IsConst>] static member hide_source: IconData = nativeOnly
  [<IsConst>] static member hide_source_sharp: IconData = nativeOnly
  [<IsConst>] static member hide_source_rounded: IconData = nativeOnly
  [<IsConst>] static member hide_source_outlined: IconData = nativeOnly
  [<IsConst>] static member high_quality: IconData = nativeOnly
  [<IsConst>] static member high_quality_sharp: IconData = nativeOnly
  [<IsConst>] static member high_quality_rounded: IconData = nativeOnly
  [<IsConst>] static member high_quality_outlined: IconData = nativeOnly
  [<IsConst>] static member highlight: IconData = nativeOnly
  [<IsConst>] static member highlight_sharp: IconData = nativeOnly
  [<IsConst>] static member highlight_rounded: IconData = nativeOnly
  [<IsConst>] static member highlight_outlined: IconData = nativeOnly
  [<IsConst>] static member highlight_alt: IconData = nativeOnly
  [<IsConst>] static member highlight_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member highlight_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member highlight_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member highlight_off: IconData = nativeOnly
  [<IsConst>] static member highlight_off_sharp: IconData = nativeOnly
  [<IsConst>] static member highlight_off_rounded: IconData = nativeOnly
  [<IsConst>] static member highlight_off_outlined: IconData = nativeOnly
  [<IsConst>] static member highlight_remove: IconData = nativeOnly
  [<IsConst>] static member highlight_remove_sharp: IconData = nativeOnly
  [<IsConst>] static member highlight_remove_rounded: IconData = nativeOnly
  [<IsConst>] static member highlight_remove_outlined: IconData = nativeOnly
  [<IsConst>] static member hiking: IconData = nativeOnly
  [<IsConst>] static member hiking_sharp: IconData = nativeOnly
  [<IsConst>] static member hiking_rounded: IconData = nativeOnly
  [<IsConst>] static member hiking_outlined: IconData = nativeOnly
  [<IsConst>] static member history: IconData = nativeOnly
  [<IsConst>] static member history_sharp: IconData = nativeOnly
  [<IsConst>] static member history_rounded: IconData = nativeOnly
  [<IsConst>] static member history_outlined: IconData = nativeOnly
  [<IsConst>] static member history_edu: IconData = nativeOnly
  [<IsConst>] static member history_edu_sharp: IconData = nativeOnly
  [<IsConst>] static member history_edu_rounded: IconData = nativeOnly
  [<IsConst>] static member history_edu_outlined: IconData = nativeOnly
  [<IsConst>] static member history_toggle_off: IconData = nativeOnly
  [<IsConst>] static member history_toggle_off_sharp: IconData = nativeOnly
  [<IsConst>] static member history_toggle_off_rounded: IconData = nativeOnly
  [<IsConst>] static member history_toggle_off_outlined: IconData = nativeOnly
  [<IsConst>] static member hive: IconData = nativeOnly
  [<IsConst>] static member hive_sharp: IconData = nativeOnly
  [<IsConst>] static member hive_rounded: IconData = nativeOnly
  [<IsConst>] static member hive_outlined: IconData = nativeOnly
  [<IsConst>] static member hls: IconData = nativeOnly
  [<IsConst>] static member hls_sharp: IconData = nativeOnly
  [<IsConst>] static member hls_rounded: IconData = nativeOnly
  [<IsConst>] static member hls_outlined: IconData = nativeOnly
  [<IsConst>] static member hls_off: IconData = nativeOnly
  [<IsConst>] static member hls_off_sharp: IconData = nativeOnly
  [<IsConst>] static member hls_off_rounded: IconData = nativeOnly
  [<IsConst>] static member hls_off_outlined: IconData = nativeOnly
  [<IsConst>] static member holiday_village: IconData = nativeOnly
  [<IsConst>] static member holiday_village_sharp: IconData = nativeOnly
  [<IsConst>] static member holiday_village_rounded: IconData = nativeOnly
  [<IsConst>] static member holiday_village_outlined: IconData = nativeOnly
  [<IsConst>] static member home: IconData = nativeOnly
  [<IsConst>] static member home_sharp: IconData = nativeOnly
  [<IsConst>] static member home_rounded: IconData = nativeOnly
  [<IsConst>] static member home_outlined: IconData = nativeOnly
  [<IsConst>] static member home_filled: IconData = nativeOnly
  [<IsConst>] static member home_max: IconData = nativeOnly
  [<IsConst>] static member home_max_sharp: IconData = nativeOnly
  [<IsConst>] static member home_max_rounded: IconData = nativeOnly
  [<IsConst>] static member home_max_outlined: IconData = nativeOnly
  [<IsConst>] static member home_mini: IconData = nativeOnly
  [<IsConst>] static member home_mini_sharp: IconData = nativeOnly
  [<IsConst>] static member home_mini_rounded: IconData = nativeOnly
  [<IsConst>] static member home_mini_outlined: IconData = nativeOnly
  [<IsConst>] static member home_repair_service: IconData = nativeOnly
  [<IsConst>] static member home_repair_service_sharp: IconData = nativeOnly
  [<IsConst>] static member home_repair_service_rounded: IconData = nativeOnly
  [<IsConst>] static member home_repair_service_outlined: IconData = nativeOnly
  [<IsConst>] static member home_work: IconData = nativeOnly
  [<IsConst>] static member home_work_sharp: IconData = nativeOnly
  [<IsConst>] static member home_work_rounded: IconData = nativeOnly
  [<IsConst>] static member home_work_outlined: IconData = nativeOnly
  [<IsConst>] static member horizontal_distribute: IconData = nativeOnly
  [<IsConst>] static member horizontal_distribute_sharp: IconData = nativeOnly
  [<IsConst>] static member horizontal_distribute_rounded: IconData = nativeOnly
  [<IsConst>] static member horizontal_distribute_outlined: IconData = nativeOnly
  [<IsConst>] static member horizontal_rule: IconData = nativeOnly
  [<IsConst>] static member horizontal_rule_sharp: IconData = nativeOnly
  [<IsConst>] static member horizontal_rule_rounded: IconData = nativeOnly
  [<IsConst>] static member horizontal_rule_outlined: IconData = nativeOnly
  [<IsConst>] static member horizontal_split: IconData = nativeOnly
  [<IsConst>] static member horizontal_split_sharp: IconData = nativeOnly
  [<IsConst>] static member horizontal_split_rounded: IconData = nativeOnly
  [<IsConst>] static member horizontal_split_outlined: IconData = nativeOnly
  [<IsConst>] static member hot_tub: IconData = nativeOnly
  [<IsConst>] static member hot_tub_sharp: IconData = nativeOnly
  [<IsConst>] static member hot_tub_rounded: IconData = nativeOnly
  [<IsConst>] static member hot_tub_outlined: IconData = nativeOnly
  [<IsConst>] static member hotel: IconData = nativeOnly
  [<IsConst>] static member hotel_sharp: IconData = nativeOnly
  [<IsConst>] static member hotel_rounded: IconData = nativeOnly
  [<IsConst>] static member hotel_outlined: IconData = nativeOnly
  [<IsConst>] static member hotel_class: IconData = nativeOnly
  [<IsConst>] static member hotel_class_sharp: IconData = nativeOnly
  [<IsConst>] static member hotel_class_rounded: IconData = nativeOnly
  [<IsConst>] static member hotel_class_outlined: IconData = nativeOnly
  [<IsConst>] static member hourglass_bottom: IconData = nativeOnly
  [<IsConst>] static member hourglass_bottom_sharp: IconData = nativeOnly
  [<IsConst>] static member hourglass_bottom_rounded: IconData = nativeOnly
  [<IsConst>] static member hourglass_bottom_outlined: IconData = nativeOnly
  [<IsConst>] static member hourglass_disabled: IconData = nativeOnly
  [<IsConst>] static member hourglass_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member hourglass_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member hourglass_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member hourglass_empty: IconData = nativeOnly
  [<IsConst>] static member hourglass_empty_sharp: IconData = nativeOnly
  [<IsConst>] static member hourglass_empty_rounded: IconData = nativeOnly
  [<IsConst>] static member hourglass_empty_outlined: IconData = nativeOnly
  [<IsConst>] static member hourglass_full: IconData = nativeOnly
  [<IsConst>] static member hourglass_full_sharp: IconData = nativeOnly
  [<IsConst>] static member hourglass_full_rounded: IconData = nativeOnly
  [<IsConst>] static member hourglass_full_outlined: IconData = nativeOnly
  [<IsConst>] static member hourglass_top: IconData = nativeOnly
  [<IsConst>] static member hourglass_top_sharp: IconData = nativeOnly
  [<IsConst>] static member hourglass_top_rounded: IconData = nativeOnly
  [<IsConst>] static member hourglass_top_outlined: IconData = nativeOnly
  [<IsConst>] static member house: IconData = nativeOnly
  [<IsConst>] static member house_sharp: IconData = nativeOnly
  [<IsConst>] static member house_rounded: IconData = nativeOnly
  [<IsConst>] static member house_outlined: IconData = nativeOnly
  [<IsConst>] static member house_siding: IconData = nativeOnly
  [<IsConst>] static member house_siding_sharp: IconData = nativeOnly
  [<IsConst>] static member house_siding_rounded: IconData = nativeOnly
  [<IsConst>] static member house_siding_outlined: IconData = nativeOnly
  [<IsConst>] static member houseboat: IconData = nativeOnly
  [<IsConst>] static member houseboat_sharp: IconData = nativeOnly
  [<IsConst>] static member houseboat_rounded: IconData = nativeOnly
  [<IsConst>] static member houseboat_outlined: IconData = nativeOnly
  [<IsConst>] static member how_to_reg: IconData = nativeOnly
  [<IsConst>] static member how_to_reg_sharp: IconData = nativeOnly
  [<IsConst>] static member how_to_reg_rounded: IconData = nativeOnly
  [<IsConst>] static member how_to_reg_outlined: IconData = nativeOnly
  [<IsConst>] static member how_to_vote: IconData = nativeOnly
  [<IsConst>] static member how_to_vote_sharp: IconData = nativeOnly
  [<IsConst>] static member how_to_vote_rounded: IconData = nativeOnly
  [<IsConst>] static member how_to_vote_outlined: IconData = nativeOnly
  [<IsConst>] static member html: IconData = nativeOnly
  [<IsConst>] static member html_sharp: IconData = nativeOnly
  [<IsConst>] static member html_rounded: IconData = nativeOnly
  [<IsConst>] static member html_outlined: IconData = nativeOnly
  [<IsConst>] static member http: IconData = nativeOnly
  [<IsConst>] static member http_sharp: IconData = nativeOnly
  [<IsConst>] static member http_rounded: IconData = nativeOnly
  [<IsConst>] static member http_outlined: IconData = nativeOnly
  [<IsConst>] static member https: IconData = nativeOnly
  [<IsConst>] static member https_sharp: IconData = nativeOnly
  [<IsConst>] static member https_rounded: IconData = nativeOnly
  [<IsConst>] static member https_outlined: IconData = nativeOnly
  [<IsConst>] static member hub: IconData = nativeOnly
  [<IsConst>] static member hub_sharp: IconData = nativeOnly
  [<IsConst>] static member hub_rounded: IconData = nativeOnly
  [<IsConst>] static member hub_outlined: IconData = nativeOnly
  [<IsConst>] static member hvac: IconData = nativeOnly
  [<IsConst>] static member hvac_sharp: IconData = nativeOnly
  [<IsConst>] static member hvac_rounded: IconData = nativeOnly
  [<IsConst>] static member hvac_outlined: IconData = nativeOnly
  [<IsConst>] static member ice_skating: IconData = nativeOnly
  [<IsConst>] static member ice_skating_sharp: IconData = nativeOnly
  [<IsConst>] static member ice_skating_rounded: IconData = nativeOnly
  [<IsConst>] static member ice_skating_outlined: IconData = nativeOnly
  [<IsConst>] static member icecream: IconData = nativeOnly
  [<IsConst>] static member icecream_sharp: IconData = nativeOnly
  [<IsConst>] static member icecream_rounded: IconData = nativeOnly
  [<IsConst>] static member icecream_outlined: IconData = nativeOnly
  [<IsConst>] static member image: IconData = nativeOnly
  [<IsConst>] static member image_sharp: IconData = nativeOnly
  [<IsConst>] static member image_rounded: IconData = nativeOnly
  [<IsConst>] static member image_outlined: IconData = nativeOnly
  [<IsConst>] static member image_aspect_ratio: IconData = nativeOnly
  [<IsConst>] static member image_aspect_ratio_sharp: IconData = nativeOnly
  [<IsConst>] static member image_aspect_ratio_rounded: IconData = nativeOnly
  [<IsConst>] static member image_aspect_ratio_outlined: IconData = nativeOnly
  [<IsConst>] static member image_not_supported: IconData = nativeOnly
  [<IsConst>] static member image_not_supported_sharp: IconData = nativeOnly
  [<IsConst>] static member image_not_supported_rounded: IconData = nativeOnly
  [<IsConst>] static member image_not_supported_outlined: IconData = nativeOnly
  [<IsConst>] static member image_search: IconData = nativeOnly
  [<IsConst>] static member image_search_sharp: IconData = nativeOnly
  [<IsConst>] static member image_search_rounded: IconData = nativeOnly
  [<IsConst>] static member image_search_outlined: IconData = nativeOnly
  [<IsConst>] static member imagesearch_roller: IconData = nativeOnly
  [<IsConst>] static member imagesearch_roller_sharp: IconData = nativeOnly
  [<IsConst>] static member imagesearch_roller_rounded: IconData = nativeOnly
  [<IsConst>] static member imagesearch_roller_outlined: IconData = nativeOnly
  [<IsConst>] static member import_contacts: IconData = nativeOnly
  [<IsConst>] static member import_contacts_sharp: IconData = nativeOnly
  [<IsConst>] static member import_contacts_rounded: IconData = nativeOnly
  [<IsConst>] static member import_contacts_outlined: IconData = nativeOnly
  [<IsConst>] static member import_export: IconData = nativeOnly
  [<IsConst>] static member import_export_sharp: IconData = nativeOnly
  [<IsConst>] static member import_export_rounded: IconData = nativeOnly
  [<IsConst>] static member import_export_outlined: IconData = nativeOnly
  [<IsConst>] static member important_devices: IconData = nativeOnly
  [<IsConst>] static member important_devices_sharp: IconData = nativeOnly
  [<IsConst>] static member important_devices_rounded: IconData = nativeOnly
  [<IsConst>] static member important_devices_outlined: IconData = nativeOnly
  [<IsConst>] static member inbox: IconData = nativeOnly
  [<IsConst>] static member inbox_sharp: IconData = nativeOnly
  [<IsConst>] static member inbox_rounded: IconData = nativeOnly
  [<IsConst>] static member inbox_outlined: IconData = nativeOnly
  [<IsConst>] static member incomplete_circle: IconData = nativeOnly
  [<IsConst>] static member incomplete_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member incomplete_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member incomplete_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member indeterminate_check_box: IconData = nativeOnly
  [<IsConst>] static member indeterminate_check_box_sharp: IconData = nativeOnly
  [<IsConst>] static member indeterminate_check_box_rounded: IconData = nativeOnly
  [<IsConst>] static member indeterminate_check_box_outlined: IconData = nativeOnly
  [<IsConst>] static member info: IconData = nativeOnly
  [<IsConst>] static member info_sharp: IconData = nativeOnly
  [<IsConst>] static member info_rounded: IconData = nativeOnly
  [<IsConst>] static member info_outlined: IconData = nativeOnly
  [<IsConst>] static member info_outline: IconData = nativeOnly
  [<IsConst>] static member info_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member info_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member input: IconData = nativeOnly
  [<IsConst>] static member input_sharp: IconData = nativeOnly
  [<IsConst>] static member input_rounded: IconData = nativeOnly
  [<IsConst>] static member input_outlined: IconData = nativeOnly
  [<IsConst>] static member insert_chart: IconData = nativeOnly
  [<IsConst>] static member insert_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member insert_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member insert_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member insert_chart_outlined_sharp: IconData = nativeOnly
  [<IsConst>] static member insert_chart_outlined_rounded: IconData = nativeOnly
  [<IsConst>] static member insert_chart_outlined_outlined: IconData = nativeOnly
  [<IsConst>] static member insert_comment: IconData = nativeOnly
  [<IsConst>] static member insert_comment_sharp: IconData = nativeOnly
  [<IsConst>] static member insert_comment_rounded: IconData = nativeOnly
  [<IsConst>] static member insert_comment_outlined: IconData = nativeOnly
  [<IsConst>] static member insert_drive_file: IconData = nativeOnly
  [<IsConst>] static member insert_drive_file_sharp: IconData = nativeOnly
  [<IsConst>] static member insert_drive_file_rounded: IconData = nativeOnly
  [<IsConst>] static member insert_drive_file_outlined: IconData = nativeOnly
  [<IsConst>] static member insert_emoticon: IconData = nativeOnly
  [<IsConst>] static member insert_emoticon_sharp: IconData = nativeOnly
  [<IsConst>] static member insert_emoticon_rounded: IconData = nativeOnly
  [<IsConst>] static member insert_emoticon_outlined: IconData = nativeOnly
  [<IsConst>] static member insert_invitation: IconData = nativeOnly
  [<IsConst>] static member insert_invitation_sharp: IconData = nativeOnly
  [<IsConst>] static member insert_invitation_rounded: IconData = nativeOnly
  [<IsConst>] static member insert_invitation_outlined: IconData = nativeOnly
  [<IsConst>] static member insert_link: IconData = nativeOnly
  [<IsConst>] static member insert_link_sharp: IconData = nativeOnly
  [<IsConst>] static member insert_link_rounded: IconData = nativeOnly
  [<IsConst>] static member insert_link_outlined: IconData = nativeOnly
  [<IsConst>] static member insert_page_break: IconData = nativeOnly
  [<IsConst>] static member insert_page_break_sharp: IconData = nativeOnly
  [<IsConst>] static member insert_page_break_rounded: IconData = nativeOnly
  [<IsConst>] static member insert_page_break_outlined: IconData = nativeOnly
  [<IsConst>] static member insert_photo: IconData = nativeOnly
  [<IsConst>] static member insert_photo_sharp: IconData = nativeOnly
  [<IsConst>] static member insert_photo_rounded: IconData = nativeOnly
  [<IsConst>] static member insert_photo_outlined: IconData = nativeOnly
  [<IsConst>] static member insights: IconData = nativeOnly
  [<IsConst>] static member insights_sharp: IconData = nativeOnly
  [<IsConst>] static member insights_rounded: IconData = nativeOnly
  [<IsConst>] static member insights_outlined: IconData = nativeOnly
  [<IsConst>] static member install_desktop: IconData = nativeOnly
  [<IsConst>] static member install_desktop_sharp: IconData = nativeOnly
  [<IsConst>] static member install_desktop_rounded: IconData = nativeOnly
  [<IsConst>] static member install_desktop_outlined: IconData = nativeOnly
  [<IsConst>] static member install_mobile: IconData = nativeOnly
  [<IsConst>] static member install_mobile_sharp: IconData = nativeOnly
  [<IsConst>] static member install_mobile_rounded: IconData = nativeOnly
  [<IsConst>] static member install_mobile_outlined: IconData = nativeOnly
  [<IsConst>] static member integration_instructions: IconData = nativeOnly
  [<IsConst>] static member integration_instructions_sharp: IconData = nativeOnly
  [<IsConst>] static member integration_instructions_rounded: IconData = nativeOnly
  [<IsConst>] static member integration_instructions_outlined: IconData = nativeOnly
  [<IsConst>] static member interests: IconData = nativeOnly
  [<IsConst>] static member interests_sharp: IconData = nativeOnly
  [<IsConst>] static member interests_rounded: IconData = nativeOnly
  [<IsConst>] static member interests_outlined: IconData = nativeOnly
  [<IsConst>] static member interpreter_mode: IconData = nativeOnly
  [<IsConst>] static member interpreter_mode_sharp: IconData = nativeOnly
  [<IsConst>] static member interpreter_mode_rounded: IconData = nativeOnly
  [<IsConst>] static member interpreter_mode_outlined: IconData = nativeOnly
  [<IsConst>] static member inventory: IconData = nativeOnly
  [<IsConst>] static member inventory_sharp: IconData = nativeOnly
  [<IsConst>] static member inventory_rounded: IconData = nativeOnly
  [<IsConst>] static member inventory_outlined: IconData = nativeOnly
  [<IsConst>] static member inventory_2: IconData = nativeOnly
  [<IsConst>] static member inventory_2_sharp: IconData = nativeOnly
  [<IsConst>] static member inventory_2_rounded: IconData = nativeOnly
  [<IsConst>] static member inventory_2_outlined: IconData = nativeOnly
  [<IsConst>] static member invert_colors: IconData = nativeOnly
  [<IsConst>] static member invert_colors_sharp: IconData = nativeOnly
  [<IsConst>] static member invert_colors_rounded: IconData = nativeOnly
  [<IsConst>] static member invert_colors_outlined: IconData = nativeOnly
  [<IsConst>] static member invert_colors_off: IconData = nativeOnly
  [<IsConst>] static member invert_colors_off_sharp: IconData = nativeOnly
  [<IsConst>] static member invert_colors_off_rounded: IconData = nativeOnly
  [<IsConst>] static member invert_colors_off_outlined: IconData = nativeOnly
  [<IsConst>] static member invert_colors_on: IconData = nativeOnly
  [<IsConst>] static member invert_colors_on_sharp: IconData = nativeOnly
  [<IsConst>] static member invert_colors_on_rounded: IconData = nativeOnly
  [<IsConst>] static member invert_colors_on_outlined: IconData = nativeOnly
  [<IsConst>] static member ios_share: IconData = nativeOnly
  [<IsConst>] static member ios_share_sharp: IconData = nativeOnly
  [<IsConst>] static member ios_share_rounded: IconData = nativeOnly
  [<IsConst>] static member ios_share_outlined: IconData = nativeOnly
  [<IsConst>] static member iron: IconData = nativeOnly
  [<IsConst>] static member iron_sharp: IconData = nativeOnly
  [<IsConst>] static member iron_rounded: IconData = nativeOnly
  [<IsConst>] static member iron_outlined: IconData = nativeOnly
  [<IsConst>] static member iso: IconData = nativeOnly
  [<IsConst>] static member iso_sharp: IconData = nativeOnly
  [<IsConst>] static member iso_rounded: IconData = nativeOnly
  [<IsConst>] static member iso_outlined: IconData = nativeOnly
  [<IsConst>] static member javascript: IconData = nativeOnly
  [<IsConst>] static member javascript_sharp: IconData = nativeOnly
  [<IsConst>] static member javascript_rounded: IconData = nativeOnly
  [<IsConst>] static member javascript_outlined: IconData = nativeOnly
  [<IsConst>] static member join_full: IconData = nativeOnly
  [<IsConst>] static member join_full_sharp: IconData = nativeOnly
  [<IsConst>] static member join_full_rounded: IconData = nativeOnly
  [<IsConst>] static member join_full_outlined: IconData = nativeOnly
  [<IsConst>] static member join_inner: IconData = nativeOnly
  [<IsConst>] static member join_inner_sharp: IconData = nativeOnly
  [<IsConst>] static member join_inner_rounded: IconData = nativeOnly
  [<IsConst>] static member join_inner_outlined: IconData = nativeOnly
  [<IsConst>] static member join_left: IconData = nativeOnly
  [<IsConst>] static member join_left_sharp: IconData = nativeOnly
  [<IsConst>] static member join_left_rounded: IconData = nativeOnly
  [<IsConst>] static member join_left_outlined: IconData = nativeOnly
  [<IsConst>] static member join_right: IconData = nativeOnly
  [<IsConst>] static member join_right_sharp: IconData = nativeOnly
  [<IsConst>] static member join_right_rounded: IconData = nativeOnly
  [<IsConst>] static member join_right_outlined: IconData = nativeOnly
  [<IsConst>] static member kayaking: IconData = nativeOnly
  [<IsConst>] static member kayaking_sharp: IconData = nativeOnly
  [<IsConst>] static member kayaking_rounded: IconData = nativeOnly
  [<IsConst>] static member kayaking_outlined: IconData = nativeOnly
  [<IsConst>] static member kebab_dining: IconData = nativeOnly
  [<IsConst>] static member kebab_dining_sharp: IconData = nativeOnly
  [<IsConst>] static member kebab_dining_rounded: IconData = nativeOnly
  [<IsConst>] static member kebab_dining_outlined: IconData = nativeOnly
  [<IsConst>] static member key: IconData = nativeOnly
  [<IsConst>] static member key_sharp: IconData = nativeOnly
  [<IsConst>] static member key_rounded: IconData = nativeOnly
  [<IsConst>] static member key_outlined: IconData = nativeOnly
  [<IsConst>] static member key_off: IconData = nativeOnly
  [<IsConst>] static member key_off_sharp: IconData = nativeOnly
  [<IsConst>] static member key_off_rounded: IconData = nativeOnly
  [<IsConst>] static member key_off_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard: IconData = nativeOnly
  [<IsConst>] static member keyboard_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_alt: IconData = nativeOnly
  [<IsConst>] static member keyboard_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_down: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_down_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_down_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_down_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_left: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_left_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_left_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_left_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_right: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_right_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_right_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_right_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_up: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_up_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_up_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_arrow_up_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_backspace: IconData = nativeOnly
  [<IsConst>] static member keyboard_backspace_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_backspace_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_backspace_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_capslock: IconData = nativeOnly
  [<IsConst>] static member keyboard_capslock_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_capslock_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_capslock_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_command_key: IconData = nativeOnly
  [<IsConst>] static member keyboard_command_key_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_command_key_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_command_key_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_control: IconData = nativeOnly
  [<IsConst>] static member keyboard_control_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_control_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_control_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_control_key: IconData = nativeOnly
  [<IsConst>] static member keyboard_control_key_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_control_key_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_control_key_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_down: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_down_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_down_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_down_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_left: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_left_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_left_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_left_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_right: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_right_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_right_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_right_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_up: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_up_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_up_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_double_arrow_up_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_hide: IconData = nativeOnly
  [<IsConst>] static member keyboard_hide_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_hide_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_hide_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_option_key: IconData = nativeOnly
  [<IsConst>] static member keyboard_option_key_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_option_key_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_option_key_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_return: IconData = nativeOnly
  [<IsConst>] static member keyboard_return_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_return_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_return_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_tab: IconData = nativeOnly
  [<IsConst>] static member keyboard_tab_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_tab_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_tab_outlined: IconData = nativeOnly
  [<IsConst>] static member keyboard_voice: IconData = nativeOnly
  [<IsConst>] static member keyboard_voice_sharp: IconData = nativeOnly
  [<IsConst>] static member keyboard_voice_rounded: IconData = nativeOnly
  [<IsConst>] static member keyboard_voice_outlined: IconData = nativeOnly
  [<IsConst>] static member king_bed: IconData = nativeOnly
  [<IsConst>] static member king_bed_sharp: IconData = nativeOnly
  [<IsConst>] static member king_bed_rounded: IconData = nativeOnly
  [<IsConst>] static member king_bed_outlined: IconData = nativeOnly
  [<IsConst>] static member kitchen: IconData = nativeOnly
  [<IsConst>] static member kitchen_sharp: IconData = nativeOnly
  [<IsConst>] static member kitchen_rounded: IconData = nativeOnly
  [<IsConst>] static member kitchen_outlined: IconData = nativeOnly
  [<IsConst>] static member kitesurfing: IconData = nativeOnly
  [<IsConst>] static member kitesurfing_sharp: IconData = nativeOnly
  [<IsConst>] static member kitesurfing_rounded: IconData = nativeOnly
  [<IsConst>] static member kitesurfing_outlined: IconData = nativeOnly
  [<IsConst>] static member label: IconData = nativeOnly
  [<IsConst>] static member label_sharp: IconData = nativeOnly
  [<IsConst>] static member label_rounded: IconData = nativeOnly
  [<IsConst>] static member label_outlined: IconData = nativeOnly
  [<IsConst>] static member label_important: IconData = nativeOnly
  [<IsConst>] static member label_important_sharp: IconData = nativeOnly
  [<IsConst>] static member label_important_rounded: IconData = nativeOnly
  [<IsConst>] static member label_important_outlined: IconData = nativeOnly
  [<IsConst>] static member label_important_outline: IconData = nativeOnly
  [<IsConst>] static member label_important_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member label_important_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member label_off: IconData = nativeOnly
  [<IsConst>] static member label_off_sharp: IconData = nativeOnly
  [<IsConst>] static member label_off_rounded: IconData = nativeOnly
  [<IsConst>] static member label_off_outlined: IconData = nativeOnly
  [<IsConst>] static member label_outline: IconData = nativeOnly
  [<IsConst>] static member label_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member label_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member lan: IconData = nativeOnly
  [<IsConst>] static member lan_sharp: IconData = nativeOnly
  [<IsConst>] static member lan_rounded: IconData = nativeOnly
  [<IsConst>] static member lan_outlined: IconData = nativeOnly
  [<IsConst>] static member landscape: IconData = nativeOnly
  [<IsConst>] static member landscape_sharp: IconData = nativeOnly
  [<IsConst>] static member landscape_rounded: IconData = nativeOnly
  [<IsConst>] static member landscape_outlined: IconData = nativeOnly
  [<IsConst>] static member landslide: IconData = nativeOnly
  [<IsConst>] static member landslide_sharp: IconData = nativeOnly
  [<IsConst>] static member landslide_rounded: IconData = nativeOnly
  [<IsConst>] static member landslide_outlined: IconData = nativeOnly
  [<IsConst>] static member language: IconData = nativeOnly
  [<IsConst>] static member language_sharp: IconData = nativeOnly
  [<IsConst>] static member language_rounded: IconData = nativeOnly
  [<IsConst>] static member language_outlined: IconData = nativeOnly
  [<IsConst>] static member laptop: IconData = nativeOnly
  [<IsConst>] static member laptop_sharp: IconData = nativeOnly
  [<IsConst>] static member laptop_rounded: IconData = nativeOnly
  [<IsConst>] static member laptop_outlined: IconData = nativeOnly
  [<IsConst>] static member laptop_chromebook: IconData = nativeOnly
  [<IsConst>] static member laptop_chromebook_sharp: IconData = nativeOnly
  [<IsConst>] static member laptop_chromebook_rounded: IconData = nativeOnly
  [<IsConst>] static member laptop_chromebook_outlined: IconData = nativeOnly
  [<IsConst>] static member laptop_mac: IconData = nativeOnly
  [<IsConst>] static member laptop_mac_sharp: IconData = nativeOnly
  [<IsConst>] static member laptop_mac_rounded: IconData = nativeOnly
  [<IsConst>] static member laptop_mac_outlined: IconData = nativeOnly
  [<IsConst>] static member laptop_windows: IconData = nativeOnly
  [<IsConst>] static member laptop_windows_sharp: IconData = nativeOnly
  [<IsConst>] static member laptop_windows_rounded: IconData = nativeOnly
  [<IsConst>] static member laptop_windows_outlined: IconData = nativeOnly
  [<IsConst>] static member last_page: IconData = nativeOnly
  [<IsConst>] static member last_page_sharp: IconData = nativeOnly
  [<IsConst>] static member last_page_rounded: IconData = nativeOnly
  [<IsConst>] static member last_page_outlined: IconData = nativeOnly
  [<IsConst>] static member launch: IconData = nativeOnly
  [<IsConst>] static member launch_sharp: IconData = nativeOnly
  [<IsConst>] static member launch_rounded: IconData = nativeOnly
  [<IsConst>] static member launch_outlined: IconData = nativeOnly
  [<IsConst>] static member layers: IconData = nativeOnly
  [<IsConst>] static member layers_sharp: IconData = nativeOnly
  [<IsConst>] static member layers_rounded: IconData = nativeOnly
  [<IsConst>] static member layers_outlined: IconData = nativeOnly
  [<IsConst>] static member layers_clear: IconData = nativeOnly
  [<IsConst>] static member layers_clear_sharp: IconData = nativeOnly
  [<IsConst>] static member layers_clear_rounded: IconData = nativeOnly
  [<IsConst>] static member layers_clear_outlined: IconData = nativeOnly
  [<IsConst>] static member leaderboard: IconData = nativeOnly
  [<IsConst>] static member leaderboard_sharp: IconData = nativeOnly
  [<IsConst>] static member leaderboard_rounded: IconData = nativeOnly
  [<IsConst>] static member leaderboard_outlined: IconData = nativeOnly
  [<IsConst>] static member leak_add: IconData = nativeOnly
  [<IsConst>] static member leak_add_sharp: IconData = nativeOnly
  [<IsConst>] static member leak_add_rounded: IconData = nativeOnly
  [<IsConst>] static member leak_add_outlined: IconData = nativeOnly
  [<IsConst>] static member leak_remove: IconData = nativeOnly
  [<IsConst>] static member leak_remove_sharp: IconData = nativeOnly
  [<IsConst>] static member leak_remove_rounded: IconData = nativeOnly
  [<IsConst>] static member leak_remove_outlined: IconData = nativeOnly
  [<IsConst>] static member leave_bags_at_home: IconData = nativeOnly
  [<IsConst>] static member leave_bags_at_home_sharp: IconData = nativeOnly
  [<IsConst>] static member leave_bags_at_home_rounded: IconData = nativeOnly
  [<IsConst>] static member leave_bags_at_home_outlined: IconData = nativeOnly
  [<IsConst>] static member legend_toggle: IconData = nativeOnly
  [<IsConst>] static member legend_toggle_sharp: IconData = nativeOnly
  [<IsConst>] static member legend_toggle_rounded: IconData = nativeOnly
  [<IsConst>] static member legend_toggle_outlined: IconData = nativeOnly
  [<IsConst>] static member lens: IconData = nativeOnly
  [<IsConst>] static member lens_sharp: IconData = nativeOnly
  [<IsConst>] static member lens_rounded: IconData = nativeOnly
  [<IsConst>] static member lens_outlined: IconData = nativeOnly
  [<IsConst>] static member lens_blur: IconData = nativeOnly
  [<IsConst>] static member lens_blur_sharp: IconData = nativeOnly
  [<IsConst>] static member lens_blur_rounded: IconData = nativeOnly
  [<IsConst>] static member lens_blur_outlined: IconData = nativeOnly
  [<IsConst>] static member library_add: IconData = nativeOnly
  [<IsConst>] static member library_add_sharp: IconData = nativeOnly
  [<IsConst>] static member library_add_rounded: IconData = nativeOnly
  [<IsConst>] static member library_add_outlined: IconData = nativeOnly
  [<IsConst>] static member library_add_check: IconData = nativeOnly
  [<IsConst>] static member library_add_check_sharp: IconData = nativeOnly
  [<IsConst>] static member library_add_check_rounded: IconData = nativeOnly
  [<IsConst>] static member library_add_check_outlined: IconData = nativeOnly
  [<IsConst>] static member library_books: IconData = nativeOnly
  [<IsConst>] static member library_books_sharp: IconData = nativeOnly
  [<IsConst>] static member library_books_rounded: IconData = nativeOnly
  [<IsConst>] static member library_books_outlined: IconData = nativeOnly
  [<IsConst>] static member library_music: IconData = nativeOnly
  [<IsConst>] static member library_music_sharp: IconData = nativeOnly
  [<IsConst>] static member library_music_rounded: IconData = nativeOnly
  [<IsConst>] static member library_music_outlined: IconData = nativeOnly
  [<IsConst>] static member light: IconData = nativeOnly
  [<IsConst>] static member light_sharp: IconData = nativeOnly
  [<IsConst>] static member light_rounded: IconData = nativeOnly
  [<IsConst>] static member light_outlined: IconData = nativeOnly
  [<IsConst>] static member light_mode: IconData = nativeOnly
  [<IsConst>] static member light_mode_sharp: IconData = nativeOnly
  [<IsConst>] static member light_mode_rounded: IconData = nativeOnly
  [<IsConst>] static member light_mode_outlined: IconData = nativeOnly
  [<IsConst>] static member lightbulb: IconData = nativeOnly
  [<IsConst>] static member lightbulb_sharp: IconData = nativeOnly
  [<IsConst>] static member lightbulb_rounded: IconData = nativeOnly
  [<IsConst>] static member lightbulb_outlined: IconData = nativeOnly
  [<IsConst>] static member lightbulb_circle: IconData = nativeOnly
  [<IsConst>] static member lightbulb_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member lightbulb_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member lightbulb_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member lightbulb_outline: IconData = nativeOnly
  [<IsConst>] static member lightbulb_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member lightbulb_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member line_axis: IconData = nativeOnly
  [<IsConst>] static member line_axis_sharp: IconData = nativeOnly
  [<IsConst>] static member line_axis_rounded: IconData = nativeOnly
  [<IsConst>] static member line_axis_outlined: IconData = nativeOnly
  [<IsConst>] static member line_style: IconData = nativeOnly
  [<IsConst>] static member line_style_sharp: IconData = nativeOnly
  [<IsConst>] static member line_style_rounded: IconData = nativeOnly
  [<IsConst>] static member line_style_outlined: IconData = nativeOnly
  [<IsConst>] static member line_weight: IconData = nativeOnly
  [<IsConst>] static member line_weight_sharp: IconData = nativeOnly
  [<IsConst>] static member line_weight_rounded: IconData = nativeOnly
  [<IsConst>] static member line_weight_outlined: IconData = nativeOnly
  [<IsConst>] static member linear_scale: IconData = nativeOnly
  [<IsConst>] static member linear_scale_sharp: IconData = nativeOnly
  [<IsConst>] static member linear_scale_rounded: IconData = nativeOnly
  [<IsConst>] static member linear_scale_outlined: IconData = nativeOnly
  [<IsConst>] static member link: IconData = nativeOnly
  [<IsConst>] static member link_sharp: IconData = nativeOnly
  [<IsConst>] static member link_rounded: IconData = nativeOnly
  [<IsConst>] static member link_outlined: IconData = nativeOnly
  [<IsConst>] static member link_off: IconData = nativeOnly
  [<IsConst>] static member link_off_sharp: IconData = nativeOnly
  [<IsConst>] static member link_off_rounded: IconData = nativeOnly
  [<IsConst>] static member link_off_outlined: IconData = nativeOnly
  [<IsConst>] static member linked_camera: IconData = nativeOnly
  [<IsConst>] static member linked_camera_sharp: IconData = nativeOnly
  [<IsConst>] static member linked_camera_rounded: IconData = nativeOnly
  [<IsConst>] static member linked_camera_outlined: IconData = nativeOnly
  [<IsConst>] static member liquor: IconData = nativeOnly
  [<IsConst>] static member liquor_sharp: IconData = nativeOnly
  [<IsConst>] static member liquor_rounded: IconData = nativeOnly
  [<IsConst>] static member liquor_outlined: IconData = nativeOnly
  [<IsConst>] static member list: IconData = nativeOnly
  [<IsConst>] static member list_sharp: IconData = nativeOnly
  [<IsConst>] static member list_rounded: IconData = nativeOnly
  [<IsConst>] static member list_outlined: IconData = nativeOnly
  [<IsConst>] static member list_alt: IconData = nativeOnly
  [<IsConst>] static member list_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member list_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member list_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member live_help: IconData = nativeOnly
  [<IsConst>] static member live_help_sharp: IconData = nativeOnly
  [<IsConst>] static member live_help_rounded: IconData = nativeOnly
  [<IsConst>] static member live_help_outlined: IconData = nativeOnly
  [<IsConst>] static member live_tv: IconData = nativeOnly
  [<IsConst>] static member live_tv_sharp: IconData = nativeOnly
  [<IsConst>] static member live_tv_rounded: IconData = nativeOnly
  [<IsConst>] static member live_tv_outlined: IconData = nativeOnly
  [<IsConst>] static member living: IconData = nativeOnly
  [<IsConst>] static member living_sharp: IconData = nativeOnly
  [<IsConst>] static member living_rounded: IconData = nativeOnly
  [<IsConst>] static member living_outlined: IconData = nativeOnly
  [<IsConst>] static member local_activity: IconData = nativeOnly
  [<IsConst>] static member local_activity_sharp: IconData = nativeOnly
  [<IsConst>] static member local_activity_rounded: IconData = nativeOnly
  [<IsConst>] static member local_activity_outlined: IconData = nativeOnly
  [<IsConst>] static member local_airport: IconData = nativeOnly
  [<IsConst>] static member local_airport_sharp: IconData = nativeOnly
  [<IsConst>] static member local_airport_rounded: IconData = nativeOnly
  [<IsConst>] static member local_airport_outlined: IconData = nativeOnly
  [<IsConst>] static member local_atm: IconData = nativeOnly
  [<IsConst>] static member local_atm_sharp: IconData = nativeOnly
  [<IsConst>] static member local_atm_rounded: IconData = nativeOnly
  [<IsConst>] static member local_atm_outlined: IconData = nativeOnly
  [<IsConst>] static member local_attraction: IconData = nativeOnly
  [<IsConst>] static member local_attraction_sharp: IconData = nativeOnly
  [<IsConst>] static member local_attraction_rounded: IconData = nativeOnly
  [<IsConst>] static member local_attraction_outlined: IconData = nativeOnly
  [<IsConst>] static member local_bar: IconData = nativeOnly
  [<IsConst>] static member local_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member local_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member local_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member local_cafe: IconData = nativeOnly
  [<IsConst>] static member local_cafe_sharp: IconData = nativeOnly
  [<IsConst>] static member local_cafe_rounded: IconData = nativeOnly
  [<IsConst>] static member local_cafe_outlined: IconData = nativeOnly
  [<IsConst>] static member local_car_wash: IconData = nativeOnly
  [<IsConst>] static member local_car_wash_sharp: IconData = nativeOnly
  [<IsConst>] static member local_car_wash_rounded: IconData = nativeOnly
  [<IsConst>] static member local_car_wash_outlined: IconData = nativeOnly
  [<IsConst>] static member local_convenience_store: IconData = nativeOnly
  [<IsConst>] static member local_convenience_store_sharp: IconData = nativeOnly
  [<IsConst>] static member local_convenience_store_rounded: IconData = nativeOnly
  [<IsConst>] static member local_convenience_store_outlined: IconData = nativeOnly
  [<IsConst>] static member local_dining: IconData = nativeOnly
  [<IsConst>] static member local_dining_sharp: IconData = nativeOnly
  [<IsConst>] static member local_dining_rounded: IconData = nativeOnly
  [<IsConst>] static member local_dining_outlined: IconData = nativeOnly
  [<IsConst>] static member local_drink: IconData = nativeOnly
  [<IsConst>] static member local_drink_sharp: IconData = nativeOnly
  [<IsConst>] static member local_drink_rounded: IconData = nativeOnly
  [<IsConst>] static member local_drink_outlined: IconData = nativeOnly
  [<IsConst>] static member local_fire_department: IconData = nativeOnly
  [<IsConst>] static member local_fire_department_sharp: IconData = nativeOnly
  [<IsConst>] static member local_fire_department_rounded: IconData = nativeOnly
  [<IsConst>] static member local_fire_department_outlined: IconData = nativeOnly
  [<IsConst>] static member local_florist: IconData = nativeOnly
  [<IsConst>] static member local_florist_sharp: IconData = nativeOnly
  [<IsConst>] static member local_florist_rounded: IconData = nativeOnly
  [<IsConst>] static member local_florist_outlined: IconData = nativeOnly
  [<IsConst>] static member local_gas_station: IconData = nativeOnly
  [<IsConst>] static member local_gas_station_sharp: IconData = nativeOnly
  [<IsConst>] static member local_gas_station_rounded: IconData = nativeOnly
  [<IsConst>] static member local_gas_station_outlined: IconData = nativeOnly
  [<IsConst>] static member local_grocery_store: IconData = nativeOnly
  [<IsConst>] static member local_grocery_store_sharp: IconData = nativeOnly
  [<IsConst>] static member local_grocery_store_rounded: IconData = nativeOnly
  [<IsConst>] static member local_grocery_store_outlined: IconData = nativeOnly
  [<IsConst>] static member local_hospital: IconData = nativeOnly
  [<IsConst>] static member local_hospital_sharp: IconData = nativeOnly
  [<IsConst>] static member local_hospital_rounded: IconData = nativeOnly
  [<IsConst>] static member local_hospital_outlined: IconData = nativeOnly
  [<IsConst>] static member local_hotel: IconData = nativeOnly
  [<IsConst>] static member local_hotel_sharp: IconData = nativeOnly
  [<IsConst>] static member local_hotel_rounded: IconData = nativeOnly
  [<IsConst>] static member local_hotel_outlined: IconData = nativeOnly
  [<IsConst>] static member local_laundry_service: IconData = nativeOnly
  [<IsConst>] static member local_laundry_service_sharp: IconData = nativeOnly
  [<IsConst>] static member local_laundry_service_rounded: IconData = nativeOnly
  [<IsConst>] static member local_laundry_service_outlined: IconData = nativeOnly
  [<IsConst>] static member local_library: IconData = nativeOnly
  [<IsConst>] static member local_library_sharp: IconData = nativeOnly
  [<IsConst>] static member local_library_rounded: IconData = nativeOnly
  [<IsConst>] static member local_library_outlined: IconData = nativeOnly
  [<IsConst>] static member local_mall: IconData = nativeOnly
  [<IsConst>] static member local_mall_sharp: IconData = nativeOnly
  [<IsConst>] static member local_mall_rounded: IconData = nativeOnly
  [<IsConst>] static member local_mall_outlined: IconData = nativeOnly
  [<IsConst>] static member local_movies: IconData = nativeOnly
  [<IsConst>] static member local_movies_sharp: IconData = nativeOnly
  [<IsConst>] static member local_movies_rounded: IconData = nativeOnly
  [<IsConst>] static member local_movies_outlined: IconData = nativeOnly
  [<IsConst>] static member local_offer: IconData = nativeOnly
  [<IsConst>] static member local_offer_sharp: IconData = nativeOnly
  [<IsConst>] static member local_offer_rounded: IconData = nativeOnly
  [<IsConst>] static member local_offer_outlined: IconData = nativeOnly
  [<IsConst>] static member local_parking: IconData = nativeOnly
  [<IsConst>] static member local_parking_sharp: IconData = nativeOnly
  [<IsConst>] static member local_parking_rounded: IconData = nativeOnly
  [<IsConst>] static member local_parking_outlined: IconData = nativeOnly
  [<IsConst>] static member local_pharmacy: IconData = nativeOnly
  [<IsConst>] static member local_pharmacy_sharp: IconData = nativeOnly
  [<IsConst>] static member local_pharmacy_rounded: IconData = nativeOnly
  [<IsConst>] static member local_pharmacy_outlined: IconData = nativeOnly
  [<IsConst>] static member local_phone: IconData = nativeOnly
  [<IsConst>] static member local_phone_sharp: IconData = nativeOnly
  [<IsConst>] static member local_phone_rounded: IconData = nativeOnly
  [<IsConst>] static member local_phone_outlined: IconData = nativeOnly
  [<IsConst>] static member local_pizza: IconData = nativeOnly
  [<IsConst>] static member local_pizza_sharp: IconData = nativeOnly
  [<IsConst>] static member local_pizza_rounded: IconData = nativeOnly
  [<IsConst>] static member local_pizza_outlined: IconData = nativeOnly
  [<IsConst>] static member local_play: IconData = nativeOnly
  [<IsConst>] static member local_play_sharp: IconData = nativeOnly
  [<IsConst>] static member local_play_rounded: IconData = nativeOnly
  [<IsConst>] static member local_play_outlined: IconData = nativeOnly
  [<IsConst>] static member local_police: IconData = nativeOnly
  [<IsConst>] static member local_police_sharp: IconData = nativeOnly
  [<IsConst>] static member local_police_rounded: IconData = nativeOnly
  [<IsConst>] static member local_police_outlined: IconData = nativeOnly
  [<IsConst>] static member local_post_office: IconData = nativeOnly
  [<IsConst>] static member local_post_office_sharp: IconData = nativeOnly
  [<IsConst>] static member local_post_office_rounded: IconData = nativeOnly
  [<IsConst>] static member local_post_office_outlined: IconData = nativeOnly
  [<IsConst>] static member local_print_shop: IconData = nativeOnly
  [<IsConst>] static member local_print_shop_sharp: IconData = nativeOnly
  [<IsConst>] static member local_print_shop_rounded: IconData = nativeOnly
  [<IsConst>] static member local_print_shop_outlined: IconData = nativeOnly
  [<IsConst>] static member local_printshop: IconData = nativeOnly
  [<IsConst>] static member local_printshop_sharp: IconData = nativeOnly
  [<IsConst>] static member local_printshop_rounded: IconData = nativeOnly
  [<IsConst>] static member local_printshop_outlined: IconData = nativeOnly
  [<IsConst>] static member local_restaurant: IconData = nativeOnly
  [<IsConst>] static member local_restaurant_sharp: IconData = nativeOnly
  [<IsConst>] static member local_restaurant_rounded: IconData = nativeOnly
  [<IsConst>] static member local_restaurant_outlined: IconData = nativeOnly
  [<IsConst>] static member local_see: IconData = nativeOnly
  [<IsConst>] static member local_see_sharp: IconData = nativeOnly
  [<IsConst>] static member local_see_rounded: IconData = nativeOnly
  [<IsConst>] static member local_see_outlined: IconData = nativeOnly
  [<IsConst>] static member local_shipping: IconData = nativeOnly
  [<IsConst>] static member local_shipping_sharp: IconData = nativeOnly
  [<IsConst>] static member local_shipping_rounded: IconData = nativeOnly
  [<IsConst>] static member local_shipping_outlined: IconData = nativeOnly
  [<IsConst>] static member local_taxi: IconData = nativeOnly
  [<IsConst>] static member local_taxi_sharp: IconData = nativeOnly
  [<IsConst>] static member local_taxi_rounded: IconData = nativeOnly
  [<IsConst>] static member local_taxi_outlined: IconData = nativeOnly
  [<IsConst>] static member location_city: IconData = nativeOnly
  [<IsConst>] static member location_city_sharp: IconData = nativeOnly
  [<IsConst>] static member location_city_rounded: IconData = nativeOnly
  [<IsConst>] static member location_city_outlined: IconData = nativeOnly
  [<IsConst>] static member location_disabled: IconData = nativeOnly
  [<IsConst>] static member location_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member location_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member location_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member location_history: IconData = nativeOnly
  [<IsConst>] static member location_history_sharp: IconData = nativeOnly
  [<IsConst>] static member location_history_rounded: IconData = nativeOnly
  [<IsConst>] static member location_history_outlined: IconData = nativeOnly
  [<IsConst>] static member location_off: IconData = nativeOnly
  [<IsConst>] static member location_off_sharp: IconData = nativeOnly
  [<IsConst>] static member location_off_rounded: IconData = nativeOnly
  [<IsConst>] static member location_off_outlined: IconData = nativeOnly
  [<IsConst>] static member location_on: IconData = nativeOnly
  [<IsConst>] static member location_on_sharp: IconData = nativeOnly
  [<IsConst>] static member location_on_rounded: IconData = nativeOnly
  [<IsConst>] static member location_on_outlined: IconData = nativeOnly
  [<IsConst>] static member location_pin: IconData = nativeOnly
  [<IsConst>] static member location_searching: IconData = nativeOnly
  [<IsConst>] static member location_searching_sharp: IconData = nativeOnly
  [<IsConst>] static member location_searching_rounded: IconData = nativeOnly
  [<IsConst>] static member location_searching_outlined: IconData = nativeOnly
  [<IsConst>] static member lock: IconData = nativeOnly
  [<IsConst>] static member lock_sharp: IconData = nativeOnly
  [<IsConst>] static member lock_rounded: IconData = nativeOnly
  [<IsConst>] static member lock_outlined: IconData = nativeOnly
  [<IsConst>] static member lock_clock: IconData = nativeOnly
  [<IsConst>] static member lock_clock_sharp: IconData = nativeOnly
  [<IsConst>] static member lock_clock_rounded: IconData = nativeOnly
  [<IsConst>] static member lock_clock_outlined: IconData = nativeOnly
  [<IsConst>] static member lock_open: IconData = nativeOnly
  [<IsConst>] static member lock_open_sharp: IconData = nativeOnly
  [<IsConst>] static member lock_open_rounded: IconData = nativeOnly
  [<IsConst>] static member lock_open_outlined: IconData = nativeOnly
  [<IsConst>] static member lock_outline: IconData = nativeOnly
  [<IsConst>] static member lock_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member lock_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member lock_person: IconData = nativeOnly
  [<IsConst>] static member lock_person_sharp: IconData = nativeOnly
  [<IsConst>] static member lock_person_rounded: IconData = nativeOnly
  [<IsConst>] static member lock_person_outlined: IconData = nativeOnly
  [<IsConst>] static member lock_reset: IconData = nativeOnly
  [<IsConst>] static member lock_reset_sharp: IconData = nativeOnly
  [<IsConst>] static member lock_reset_rounded: IconData = nativeOnly
  [<IsConst>] static member lock_reset_outlined: IconData = nativeOnly
  [<IsConst>] static member login: IconData = nativeOnly
  [<IsConst>] static member login_sharp: IconData = nativeOnly
  [<IsConst>] static member login_rounded: IconData = nativeOnly
  [<IsConst>] static member login_outlined: IconData = nativeOnly
  [<IsConst>] static member logo_dev: IconData = nativeOnly
  [<IsConst>] static member logo_dev_sharp: IconData = nativeOnly
  [<IsConst>] static member logo_dev_rounded: IconData = nativeOnly
  [<IsConst>] static member logo_dev_outlined: IconData = nativeOnly
  [<IsConst>] static member logout: IconData = nativeOnly
  [<IsConst>] static member logout_sharp: IconData = nativeOnly
  [<IsConst>] static member logout_rounded: IconData = nativeOnly
  [<IsConst>] static member logout_outlined: IconData = nativeOnly
  [<IsConst>] static member looks: IconData = nativeOnly
  [<IsConst>] static member looks_sharp: IconData = nativeOnly
  [<IsConst>] static member looks_rounded: IconData = nativeOnly
  [<IsConst>] static member looks_outlined: IconData = nativeOnly
  [<IsConst>] static member looks_3: IconData = nativeOnly
  [<IsConst>] static member looks_3_sharp: IconData = nativeOnly
  [<IsConst>] static member looks_3_rounded: IconData = nativeOnly
  [<IsConst>] static member looks_3_outlined: IconData = nativeOnly
  [<IsConst>] static member looks_4: IconData = nativeOnly
  [<IsConst>] static member looks_4_sharp: IconData = nativeOnly
  [<IsConst>] static member looks_4_rounded: IconData = nativeOnly
  [<IsConst>] static member looks_4_outlined: IconData = nativeOnly
  [<IsConst>] static member looks_5: IconData = nativeOnly
  [<IsConst>] static member looks_5_sharp: IconData = nativeOnly
  [<IsConst>] static member looks_5_rounded: IconData = nativeOnly
  [<IsConst>] static member looks_5_outlined: IconData = nativeOnly
  [<IsConst>] static member looks_6: IconData = nativeOnly
  [<IsConst>] static member looks_6_sharp: IconData = nativeOnly
  [<IsConst>] static member looks_6_rounded: IconData = nativeOnly
  [<IsConst>] static member looks_6_outlined: IconData = nativeOnly
  [<IsConst>] static member looks_one: IconData = nativeOnly
  [<IsConst>] static member looks_one_sharp: IconData = nativeOnly
  [<IsConst>] static member looks_one_rounded: IconData = nativeOnly
  [<IsConst>] static member looks_one_outlined: IconData = nativeOnly
  [<IsConst>] static member looks_two: IconData = nativeOnly
  [<IsConst>] static member looks_two_sharp: IconData = nativeOnly
  [<IsConst>] static member looks_two_rounded: IconData = nativeOnly
  [<IsConst>] static member looks_two_outlined: IconData = nativeOnly
  [<IsConst>] static member loop: IconData = nativeOnly
  [<IsConst>] static member loop_sharp: IconData = nativeOnly
  [<IsConst>] static member loop_rounded: IconData = nativeOnly
  [<IsConst>] static member loop_outlined: IconData = nativeOnly
  [<IsConst>] static member loupe: IconData = nativeOnly
  [<IsConst>] static member loupe_sharp: IconData = nativeOnly
  [<IsConst>] static member loupe_rounded: IconData = nativeOnly
  [<IsConst>] static member loupe_outlined: IconData = nativeOnly
  [<IsConst>] static member low_priority: IconData = nativeOnly
  [<IsConst>] static member low_priority_sharp: IconData = nativeOnly
  [<IsConst>] static member low_priority_rounded: IconData = nativeOnly
  [<IsConst>] static member low_priority_outlined: IconData = nativeOnly
  [<IsConst>] static member loyalty: IconData = nativeOnly
  [<IsConst>] static member loyalty_sharp: IconData = nativeOnly
  [<IsConst>] static member loyalty_rounded: IconData = nativeOnly
  [<IsConst>] static member loyalty_outlined: IconData = nativeOnly
  [<IsConst>] static member lte_mobiledata: IconData = nativeOnly
  [<IsConst>] static member lte_mobiledata_sharp: IconData = nativeOnly
  [<IsConst>] static member lte_mobiledata_rounded: IconData = nativeOnly
  [<IsConst>] static member lte_mobiledata_outlined: IconData = nativeOnly
  [<IsConst>] static member lte_plus_mobiledata: IconData = nativeOnly
  [<IsConst>] static member lte_plus_mobiledata_sharp: IconData = nativeOnly
  [<IsConst>] static member lte_plus_mobiledata_rounded: IconData = nativeOnly
  [<IsConst>] static member lte_plus_mobiledata_outlined: IconData = nativeOnly
  [<IsConst>] static member luggage: IconData = nativeOnly
  [<IsConst>] static member luggage_sharp: IconData = nativeOnly
  [<IsConst>] static member luggage_rounded: IconData = nativeOnly
  [<IsConst>] static member luggage_outlined: IconData = nativeOnly
  [<IsConst>] static member lunch_dining: IconData = nativeOnly
  [<IsConst>] static member lunch_dining_sharp: IconData = nativeOnly
  [<IsConst>] static member lunch_dining_rounded: IconData = nativeOnly
  [<IsConst>] static member lunch_dining_outlined: IconData = nativeOnly
  [<IsConst>] static member lyrics: IconData = nativeOnly
  [<IsConst>] static member lyrics_sharp: IconData = nativeOnly
  [<IsConst>] static member lyrics_rounded: IconData = nativeOnly
  [<IsConst>] static member lyrics_outlined: IconData = nativeOnly
  [<IsConst>] static member mail: IconData = nativeOnly
  [<IsConst>] static member mail_sharp: IconData = nativeOnly
  [<IsConst>] static member mail_rounded: IconData = nativeOnly
  [<IsConst>] static member mail_outlined: IconData = nativeOnly
  [<IsConst>] static member mail_lock: IconData = nativeOnly
  [<IsConst>] static member mail_lock_sharp: IconData = nativeOnly
  [<IsConst>] static member mail_lock_rounded: IconData = nativeOnly
  [<IsConst>] static member mail_lock_outlined: IconData = nativeOnly
  [<IsConst>] static member mail_outline: IconData = nativeOnly
  [<IsConst>] static member mail_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member mail_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member mail_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member male: IconData = nativeOnly
  [<IsConst>] static member male_sharp: IconData = nativeOnly
  [<IsConst>] static member male_rounded: IconData = nativeOnly
  [<IsConst>] static member male_outlined: IconData = nativeOnly
  [<IsConst>] static member man: IconData = nativeOnly
  [<IsConst>] static member man_sharp: IconData = nativeOnly
  [<IsConst>] static member man_rounded: IconData = nativeOnly
  [<IsConst>] static member man_outlined: IconData = nativeOnly
  [<IsConst>] static member manage_accounts: IconData = nativeOnly
  [<IsConst>] static member manage_accounts_sharp: IconData = nativeOnly
  [<IsConst>] static member manage_accounts_rounded: IconData = nativeOnly
  [<IsConst>] static member manage_accounts_outlined: IconData = nativeOnly
  [<IsConst>] static member manage_history: IconData = nativeOnly
  [<IsConst>] static member manage_history_sharp: IconData = nativeOnly
  [<IsConst>] static member manage_history_rounded: IconData = nativeOnly
  [<IsConst>] static member manage_history_outlined: IconData = nativeOnly
  [<IsConst>] static member manage_search: IconData = nativeOnly
  [<IsConst>] static member manage_search_sharp: IconData = nativeOnly
  [<IsConst>] static member manage_search_rounded: IconData = nativeOnly
  [<IsConst>] static member manage_search_outlined: IconData = nativeOnly
  [<IsConst>] static member map: IconData = nativeOnly
  [<IsConst>] static member map_sharp: IconData = nativeOnly
  [<IsConst>] static member map_rounded: IconData = nativeOnly
  [<IsConst>] static member map_outlined: IconData = nativeOnly
  [<IsConst>] static member maps_home_work: IconData = nativeOnly
  [<IsConst>] static member maps_home_work_sharp: IconData = nativeOnly
  [<IsConst>] static member maps_home_work_rounded: IconData = nativeOnly
  [<IsConst>] static member maps_home_work_outlined: IconData = nativeOnly
  [<IsConst>] static member maps_ugc: IconData = nativeOnly
  [<IsConst>] static member maps_ugc_sharp: IconData = nativeOnly
  [<IsConst>] static member maps_ugc_rounded: IconData = nativeOnly
  [<IsConst>] static member maps_ugc_outlined: IconData = nativeOnly
  [<IsConst>] static member margin: IconData = nativeOnly
  [<IsConst>] static member margin_sharp: IconData = nativeOnly
  [<IsConst>] static member margin_rounded: IconData = nativeOnly
  [<IsConst>] static member margin_outlined: IconData = nativeOnly
  [<IsConst>] static member mark_as_unread: IconData = nativeOnly
  [<IsConst>] static member mark_as_unread_sharp: IconData = nativeOnly
  [<IsConst>] static member mark_as_unread_rounded: IconData = nativeOnly
  [<IsConst>] static member mark_as_unread_outlined: IconData = nativeOnly
  [<IsConst>] static member mark_chat_read: IconData = nativeOnly
  [<IsConst>] static member mark_chat_read_sharp: IconData = nativeOnly
  [<IsConst>] static member mark_chat_read_rounded: IconData = nativeOnly
  [<IsConst>] static member mark_chat_read_outlined: IconData = nativeOnly
  [<IsConst>] static member mark_chat_unread: IconData = nativeOnly
  [<IsConst>] static member mark_chat_unread_sharp: IconData = nativeOnly
  [<IsConst>] static member mark_chat_unread_rounded: IconData = nativeOnly
  [<IsConst>] static member mark_chat_unread_outlined: IconData = nativeOnly
  [<IsConst>] static member mark_email_read: IconData = nativeOnly
  [<IsConst>] static member mark_email_read_sharp: IconData = nativeOnly
  [<IsConst>] static member mark_email_read_rounded: IconData = nativeOnly
  [<IsConst>] static member mark_email_read_outlined: IconData = nativeOnly
  [<IsConst>] static member mark_email_unread: IconData = nativeOnly
  [<IsConst>] static member mark_email_unread_sharp: IconData = nativeOnly
  [<IsConst>] static member mark_email_unread_rounded: IconData = nativeOnly
  [<IsConst>] static member mark_email_unread_outlined: IconData = nativeOnly
  [<IsConst>] static member mark_unread_chat_alt: IconData = nativeOnly
  [<IsConst>] static member mark_unread_chat_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member mark_unread_chat_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member mark_unread_chat_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member markunread: IconData = nativeOnly
  [<IsConst>] static member markunread_sharp: IconData = nativeOnly
  [<IsConst>] static member markunread_rounded: IconData = nativeOnly
  [<IsConst>] static member markunread_outlined: IconData = nativeOnly
  [<IsConst>] static member markunread_mailbox: IconData = nativeOnly
  [<IsConst>] static member markunread_mailbox_sharp: IconData = nativeOnly
  [<IsConst>] static member markunread_mailbox_rounded: IconData = nativeOnly
  [<IsConst>] static member markunread_mailbox_outlined: IconData = nativeOnly
  [<IsConst>] static member masks: IconData = nativeOnly
  [<IsConst>] static member masks_sharp: IconData = nativeOnly
  [<IsConst>] static member masks_rounded: IconData = nativeOnly
  [<IsConst>] static member masks_outlined: IconData = nativeOnly
  [<IsConst>] static member maximize: IconData = nativeOnly
  [<IsConst>] static member maximize_sharp: IconData = nativeOnly
  [<IsConst>] static member maximize_rounded: IconData = nativeOnly
  [<IsConst>] static member maximize_outlined: IconData = nativeOnly
  [<IsConst>] static member media_bluetooth_off: IconData = nativeOnly
  [<IsConst>] static member media_bluetooth_off_sharp: IconData = nativeOnly
  [<IsConst>] static member media_bluetooth_off_rounded: IconData = nativeOnly
  [<IsConst>] static member media_bluetooth_off_outlined: IconData = nativeOnly
  [<IsConst>] static member media_bluetooth_on: IconData = nativeOnly
  [<IsConst>] static member media_bluetooth_on_sharp: IconData = nativeOnly
  [<IsConst>] static member media_bluetooth_on_rounded: IconData = nativeOnly
  [<IsConst>] static member media_bluetooth_on_outlined: IconData = nativeOnly
  [<IsConst>] static member mediation: IconData = nativeOnly
  [<IsConst>] static member mediation_sharp: IconData = nativeOnly
  [<IsConst>] static member mediation_rounded: IconData = nativeOnly
  [<IsConst>] static member mediation_outlined: IconData = nativeOnly
  [<IsConst>] static member medical_information: IconData = nativeOnly
  [<IsConst>] static member medical_information_sharp: IconData = nativeOnly
  [<IsConst>] static member medical_information_rounded: IconData = nativeOnly
  [<IsConst>] static member medical_information_outlined: IconData = nativeOnly
  [<IsConst>] static member medical_services: IconData = nativeOnly
  [<IsConst>] static member medical_services_sharp: IconData = nativeOnly
  [<IsConst>] static member medical_services_rounded: IconData = nativeOnly
  [<IsConst>] static member medical_services_outlined: IconData = nativeOnly
  [<IsConst>] static member medication: IconData = nativeOnly
  [<IsConst>] static member medication_sharp: IconData = nativeOnly
  [<IsConst>] static member medication_rounded: IconData = nativeOnly
  [<IsConst>] static member medication_outlined: IconData = nativeOnly
  [<IsConst>] static member medication_liquid: IconData = nativeOnly
  [<IsConst>] static member medication_liquid_sharp: IconData = nativeOnly
  [<IsConst>] static member medication_liquid_rounded: IconData = nativeOnly
  [<IsConst>] static member medication_liquid_outlined: IconData = nativeOnly
  [<IsConst>] static member meeting_room: IconData = nativeOnly
  [<IsConst>] static member meeting_room_sharp: IconData = nativeOnly
  [<IsConst>] static member meeting_room_rounded: IconData = nativeOnly
  [<IsConst>] static member meeting_room_outlined: IconData = nativeOnly
  [<IsConst>] static member memory: IconData = nativeOnly
  [<IsConst>] static member memory_sharp: IconData = nativeOnly
  [<IsConst>] static member memory_rounded: IconData = nativeOnly
  [<IsConst>] static member memory_outlined: IconData = nativeOnly
  [<IsConst>] static member menu: IconData = nativeOnly
  [<IsConst>] static member menu_sharp: IconData = nativeOnly
  [<IsConst>] static member menu_rounded: IconData = nativeOnly
  [<IsConst>] static member menu_outlined: IconData = nativeOnly
  [<IsConst>] static member menu_book: IconData = nativeOnly
  [<IsConst>] static member menu_book_sharp: IconData = nativeOnly
  [<IsConst>] static member menu_book_rounded: IconData = nativeOnly
  [<IsConst>] static member menu_book_outlined: IconData = nativeOnly
  [<IsConst>] static member menu_open: IconData = nativeOnly
  [<IsConst>] static member menu_open_sharp: IconData = nativeOnly
  [<IsConst>] static member menu_open_rounded: IconData = nativeOnly
  [<IsConst>] static member menu_open_outlined: IconData = nativeOnly
  [<IsConst>] static member merge: IconData = nativeOnly
  [<IsConst>] static member merge_sharp: IconData = nativeOnly
  [<IsConst>] static member merge_rounded: IconData = nativeOnly
  [<IsConst>] static member merge_outlined: IconData = nativeOnly
  [<IsConst>] static member merge_type: IconData = nativeOnly
  [<IsConst>] static member merge_type_sharp: IconData = nativeOnly
  [<IsConst>] static member merge_type_rounded: IconData = nativeOnly
  [<IsConst>] static member merge_type_outlined: IconData = nativeOnly
  [<IsConst>] static member message: IconData = nativeOnly
  [<IsConst>] static member message_sharp: IconData = nativeOnly
  [<IsConst>] static member message_rounded: IconData = nativeOnly
  [<IsConst>] static member message_outlined: IconData = nativeOnly
  [<IsConst>] static member messenger: IconData = nativeOnly
  [<IsConst>] static member messenger_sharp: IconData = nativeOnly
  [<IsConst>] static member messenger_rounded: IconData = nativeOnly
  [<IsConst>] static member messenger_outlined: IconData = nativeOnly
  [<IsConst>] static member messenger_outline: IconData = nativeOnly
  [<IsConst>] static member messenger_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member messenger_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member messenger_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member mic: IconData = nativeOnly
  [<IsConst>] static member mic_sharp: IconData = nativeOnly
  [<IsConst>] static member mic_rounded: IconData = nativeOnly
  [<IsConst>] static member mic_outlined: IconData = nativeOnly
  [<IsConst>] static member mic_external_off: IconData = nativeOnly
  [<IsConst>] static member mic_external_off_sharp: IconData = nativeOnly
  [<IsConst>] static member mic_external_off_rounded: IconData = nativeOnly
  [<IsConst>] static member mic_external_off_outlined: IconData = nativeOnly
  [<IsConst>] static member mic_external_on: IconData = nativeOnly
  [<IsConst>] static member mic_external_on_sharp: IconData = nativeOnly
  [<IsConst>] static member mic_external_on_rounded: IconData = nativeOnly
  [<IsConst>] static member mic_external_on_outlined: IconData = nativeOnly
  [<IsConst>] static member mic_none: IconData = nativeOnly
  [<IsConst>] static member mic_none_sharp: IconData = nativeOnly
  [<IsConst>] static member mic_none_rounded: IconData = nativeOnly
  [<IsConst>] static member mic_none_outlined: IconData = nativeOnly
  [<IsConst>] static member mic_off: IconData = nativeOnly
  [<IsConst>] static member mic_off_sharp: IconData = nativeOnly
  [<IsConst>] static member mic_off_rounded: IconData = nativeOnly
  [<IsConst>] static member mic_off_outlined: IconData = nativeOnly
  [<IsConst>] static member microwave: IconData = nativeOnly
  [<IsConst>] static member microwave_sharp: IconData = nativeOnly
  [<IsConst>] static member microwave_rounded: IconData = nativeOnly
  [<IsConst>] static member microwave_outlined: IconData = nativeOnly
  [<IsConst>] static member military_tech: IconData = nativeOnly
  [<IsConst>] static member military_tech_sharp: IconData = nativeOnly
  [<IsConst>] static member military_tech_rounded: IconData = nativeOnly
  [<IsConst>] static member military_tech_outlined: IconData = nativeOnly
  [<IsConst>] static member minimize: IconData = nativeOnly
  [<IsConst>] static member minimize_sharp: IconData = nativeOnly
  [<IsConst>] static member minimize_rounded: IconData = nativeOnly
  [<IsConst>] static member minimize_outlined: IconData = nativeOnly
  [<IsConst>] static member minor_crash: IconData = nativeOnly
  [<IsConst>] static member minor_crash_sharp: IconData = nativeOnly
  [<IsConst>] static member minor_crash_rounded: IconData = nativeOnly
  [<IsConst>] static member minor_crash_outlined: IconData = nativeOnly
  [<IsConst>] static member miscellaneous_services: IconData = nativeOnly
  [<IsConst>] static member miscellaneous_services_sharp: IconData = nativeOnly
  [<IsConst>] static member miscellaneous_services_rounded: IconData = nativeOnly
  [<IsConst>] static member miscellaneous_services_outlined: IconData = nativeOnly
  [<IsConst>] static member missed_video_call: IconData = nativeOnly
  [<IsConst>] static member missed_video_call_sharp: IconData = nativeOnly
  [<IsConst>] static member missed_video_call_rounded: IconData = nativeOnly
  [<IsConst>] static member missed_video_call_outlined: IconData = nativeOnly
  [<IsConst>] static member mms: IconData = nativeOnly
  [<IsConst>] static member mms_sharp: IconData = nativeOnly
  [<IsConst>] static member mms_rounded: IconData = nativeOnly
  [<IsConst>] static member mms_outlined: IconData = nativeOnly
  [<IsConst>] static member mobile_friendly: IconData = nativeOnly
  [<IsConst>] static member mobile_friendly_sharp: IconData = nativeOnly
  [<IsConst>] static member mobile_friendly_rounded: IconData = nativeOnly
  [<IsConst>] static member mobile_friendly_outlined: IconData = nativeOnly
  [<IsConst>] static member mobile_off: IconData = nativeOnly
  [<IsConst>] static member mobile_off_sharp: IconData = nativeOnly
  [<IsConst>] static member mobile_off_rounded: IconData = nativeOnly
  [<IsConst>] static member mobile_off_outlined: IconData = nativeOnly
  [<IsConst>] static member mobile_screen_share: IconData = nativeOnly
  [<IsConst>] static member mobile_screen_share_sharp: IconData = nativeOnly
  [<IsConst>] static member mobile_screen_share_rounded: IconData = nativeOnly
  [<IsConst>] static member mobile_screen_share_outlined: IconData = nativeOnly
  [<IsConst>] static member mobiledata_off: IconData = nativeOnly
  [<IsConst>] static member mobiledata_off_sharp: IconData = nativeOnly
  [<IsConst>] static member mobiledata_off_rounded: IconData = nativeOnly
  [<IsConst>] static member mobiledata_off_outlined: IconData = nativeOnly
  [<IsConst>] static member mode: IconData = nativeOnly
  [<IsConst>] static member mode_sharp: IconData = nativeOnly
  [<IsConst>] static member mode_rounded: IconData = nativeOnly
  [<IsConst>] static member mode_outlined: IconData = nativeOnly
  [<IsConst>] static member mode_comment: IconData = nativeOnly
  [<IsConst>] static member mode_comment_sharp: IconData = nativeOnly
  [<IsConst>] static member mode_comment_rounded: IconData = nativeOnly
  [<IsConst>] static member mode_comment_outlined: IconData = nativeOnly
  [<IsConst>] static member mode_edit: IconData = nativeOnly
  [<IsConst>] static member mode_edit_sharp: IconData = nativeOnly
  [<IsConst>] static member mode_edit_rounded: IconData = nativeOnly
  [<IsConst>] static member mode_edit_outlined: IconData = nativeOnly
  [<IsConst>] static member mode_edit_outline: IconData = nativeOnly
  [<IsConst>] static member mode_edit_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member mode_edit_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member mode_edit_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member mode_fan_off: IconData = nativeOnly
  [<IsConst>] static member mode_fan_off_sharp: IconData = nativeOnly
  [<IsConst>] static member mode_fan_off_rounded: IconData = nativeOnly
  [<IsConst>] static member mode_fan_off_outlined: IconData = nativeOnly
  [<IsConst>] static member mode_night: IconData = nativeOnly
  [<IsConst>] static member mode_night_sharp: IconData = nativeOnly
  [<IsConst>] static member mode_night_rounded: IconData = nativeOnly
  [<IsConst>] static member mode_night_outlined: IconData = nativeOnly
  [<IsConst>] static member mode_of_travel: IconData = nativeOnly
  [<IsConst>] static member mode_of_travel_sharp: IconData = nativeOnly
  [<IsConst>] static member mode_of_travel_rounded: IconData = nativeOnly
  [<IsConst>] static member mode_of_travel_outlined: IconData = nativeOnly
  [<IsConst>] static member mode_standby: IconData = nativeOnly
  [<IsConst>] static member mode_standby_sharp: IconData = nativeOnly
  [<IsConst>] static member mode_standby_rounded: IconData = nativeOnly
  [<IsConst>] static member mode_standby_outlined: IconData = nativeOnly
  [<IsConst>] static member model_training: IconData = nativeOnly
  [<IsConst>] static member model_training_sharp: IconData = nativeOnly
  [<IsConst>] static member model_training_rounded: IconData = nativeOnly
  [<IsConst>] static member model_training_outlined: IconData = nativeOnly
  [<IsConst>] static member monetization_on: IconData = nativeOnly
  [<IsConst>] static member monetization_on_sharp: IconData = nativeOnly
  [<IsConst>] static member monetization_on_rounded: IconData = nativeOnly
  [<IsConst>] static member monetization_on_outlined: IconData = nativeOnly
  [<IsConst>] static member money: IconData = nativeOnly
  [<IsConst>] static member money_sharp: IconData = nativeOnly
  [<IsConst>] static member money_rounded: IconData = nativeOnly
  [<IsConst>] static member money_outlined: IconData = nativeOnly
  [<IsConst>] static member money_off: IconData = nativeOnly
  [<IsConst>] static member money_off_sharp: IconData = nativeOnly
  [<IsConst>] static member money_off_rounded: IconData = nativeOnly
  [<IsConst>] static member money_off_outlined: IconData = nativeOnly
  [<IsConst>] static member money_off_csred: IconData = nativeOnly
  [<IsConst>] static member money_off_csred_sharp: IconData = nativeOnly
  [<IsConst>] static member money_off_csred_rounded: IconData = nativeOnly
  [<IsConst>] static member money_off_csred_outlined: IconData = nativeOnly
  [<IsConst>] static member monitor: IconData = nativeOnly
  [<IsConst>] static member monitor_sharp: IconData = nativeOnly
  [<IsConst>] static member monitor_rounded: IconData = nativeOnly
  [<IsConst>] static member monitor_outlined: IconData = nativeOnly
  [<IsConst>] static member monitor_heart: IconData = nativeOnly
  [<IsConst>] static member monitor_heart_sharp: IconData = nativeOnly
  [<IsConst>] static member monitor_heart_rounded: IconData = nativeOnly
  [<IsConst>] static member monitor_heart_outlined: IconData = nativeOnly
  [<IsConst>] static member monitor_weight: IconData = nativeOnly
  [<IsConst>] static member monitor_weight_sharp: IconData = nativeOnly
  [<IsConst>] static member monitor_weight_rounded: IconData = nativeOnly
  [<IsConst>] static member monitor_weight_outlined: IconData = nativeOnly
  [<IsConst>] static member monochrome_photos: IconData = nativeOnly
  [<IsConst>] static member monochrome_photos_sharp: IconData = nativeOnly
  [<IsConst>] static member monochrome_photos_rounded: IconData = nativeOnly
  [<IsConst>] static member monochrome_photos_outlined: IconData = nativeOnly
  [<IsConst>] static member mood: IconData = nativeOnly
  [<IsConst>] static member mood_sharp: IconData = nativeOnly
  [<IsConst>] static member mood_rounded: IconData = nativeOnly
  [<IsConst>] static member mood_outlined: IconData = nativeOnly
  [<IsConst>] static member mood_bad: IconData = nativeOnly
  [<IsConst>] static member mood_bad_sharp: IconData = nativeOnly
  [<IsConst>] static member mood_bad_rounded: IconData = nativeOnly
  [<IsConst>] static member mood_bad_outlined: IconData = nativeOnly
  [<IsConst>] static member moped: IconData = nativeOnly
  [<IsConst>] static member moped_sharp: IconData = nativeOnly
  [<IsConst>] static member moped_rounded: IconData = nativeOnly
  [<IsConst>] static member moped_outlined: IconData = nativeOnly
  [<IsConst>] static member more: IconData = nativeOnly
  [<IsConst>] static member more_sharp: IconData = nativeOnly
  [<IsConst>] static member more_rounded: IconData = nativeOnly
  [<IsConst>] static member more_outlined: IconData = nativeOnly
  [<IsConst>] static member more_horiz: IconData = nativeOnly
  [<IsConst>] static member more_horiz_sharp: IconData = nativeOnly
  [<IsConst>] static member more_horiz_rounded: IconData = nativeOnly
  [<IsConst>] static member more_horiz_outlined: IconData = nativeOnly
  [<IsConst>] static member more_time: IconData = nativeOnly
  [<IsConst>] static member more_time_sharp: IconData = nativeOnly
  [<IsConst>] static member more_time_rounded: IconData = nativeOnly
  [<IsConst>] static member more_time_outlined: IconData = nativeOnly
  [<IsConst>] static member more_vert: IconData = nativeOnly
  [<IsConst>] static member more_vert_sharp: IconData = nativeOnly
  [<IsConst>] static member more_vert_rounded: IconData = nativeOnly
  [<IsConst>] static member more_vert_outlined: IconData = nativeOnly
  [<IsConst>] static member mosque: IconData = nativeOnly
  [<IsConst>] static member mosque_sharp: IconData = nativeOnly
  [<IsConst>] static member mosque_rounded: IconData = nativeOnly
  [<IsConst>] static member mosque_outlined: IconData = nativeOnly
  [<IsConst>] static member motion_photos_auto: IconData = nativeOnly
  [<IsConst>] static member motion_photos_auto_sharp: IconData = nativeOnly
  [<IsConst>] static member motion_photos_auto_rounded: IconData = nativeOnly
  [<IsConst>] static member motion_photos_auto_outlined: IconData = nativeOnly
  [<IsConst>] static member motion_photos_off: IconData = nativeOnly
  [<IsConst>] static member motion_photos_off_sharp: IconData = nativeOnly
  [<IsConst>] static member motion_photos_off_rounded: IconData = nativeOnly
  [<IsConst>] static member motion_photos_off_outlined: IconData = nativeOnly
  [<IsConst>] static member motion_photos_on: IconData = nativeOnly
  [<IsConst>] static member motion_photos_on_sharp: IconData = nativeOnly
  [<IsConst>] static member motion_photos_on_rounded: IconData = nativeOnly
  [<IsConst>] static member motion_photos_on_outlined: IconData = nativeOnly
  [<IsConst>] static member motion_photos_pause: IconData = nativeOnly
  [<IsConst>] static member motion_photos_pause_sharp: IconData = nativeOnly
  [<IsConst>] static member motion_photos_pause_rounded: IconData = nativeOnly
  [<IsConst>] static member motion_photos_pause_outlined: IconData = nativeOnly
  [<IsConst>] static member motion_photos_paused: IconData = nativeOnly
  [<IsConst>] static member motion_photos_paused_sharp: IconData = nativeOnly
  [<IsConst>] static member motion_photos_paused_rounded: IconData = nativeOnly
  [<IsConst>] static member motion_photos_paused_outlined: IconData = nativeOnly
  [<IsConst>] static member motorcycle: IconData = nativeOnly
  [<IsConst>] static member motorcycle_sharp: IconData = nativeOnly
  [<IsConst>] static member motorcycle_rounded: IconData = nativeOnly
  [<IsConst>] static member motorcycle_outlined: IconData = nativeOnly
  [<IsConst>] static member mouse: IconData = nativeOnly
  [<IsConst>] static member mouse_sharp: IconData = nativeOnly
  [<IsConst>] static member mouse_rounded: IconData = nativeOnly
  [<IsConst>] static member mouse_outlined: IconData = nativeOnly
  [<IsConst>] static member move_down: IconData = nativeOnly
  [<IsConst>] static member move_down_sharp: IconData = nativeOnly
  [<IsConst>] static member move_down_rounded: IconData = nativeOnly
  [<IsConst>] static member move_down_outlined: IconData = nativeOnly
  [<IsConst>] static member move_to_inbox: IconData = nativeOnly
  [<IsConst>] static member move_to_inbox_sharp: IconData = nativeOnly
  [<IsConst>] static member move_to_inbox_rounded: IconData = nativeOnly
  [<IsConst>] static member move_to_inbox_outlined: IconData = nativeOnly
  [<IsConst>] static member move_up: IconData = nativeOnly
  [<IsConst>] static member move_up_sharp: IconData = nativeOnly
  [<IsConst>] static member move_up_rounded: IconData = nativeOnly
  [<IsConst>] static member move_up_outlined: IconData = nativeOnly
  [<IsConst>] static member movie: IconData = nativeOnly
  [<IsConst>] static member movie_sharp: IconData = nativeOnly
  [<IsConst>] static member movie_rounded: IconData = nativeOnly
  [<IsConst>] static member movie_outlined: IconData = nativeOnly
  [<IsConst>] static member movie_creation: IconData = nativeOnly
  [<IsConst>] static member movie_creation_sharp: IconData = nativeOnly
  [<IsConst>] static member movie_creation_rounded: IconData = nativeOnly
  [<IsConst>] static member movie_creation_outlined: IconData = nativeOnly
  [<IsConst>] static member movie_filter: IconData = nativeOnly
  [<IsConst>] static member movie_filter_sharp: IconData = nativeOnly
  [<IsConst>] static member movie_filter_rounded: IconData = nativeOnly
  [<IsConst>] static member movie_filter_outlined: IconData = nativeOnly
  [<IsConst>] static member moving: IconData = nativeOnly
  [<IsConst>] static member moving_sharp: IconData = nativeOnly
  [<IsConst>] static member moving_rounded: IconData = nativeOnly
  [<IsConst>] static member moving_outlined: IconData = nativeOnly
  [<IsConst>] static member mp: IconData = nativeOnly
  [<IsConst>] static member mp_sharp: IconData = nativeOnly
  [<IsConst>] static member mp_rounded: IconData = nativeOnly
  [<IsConst>] static member mp_outlined: IconData = nativeOnly
  [<IsConst>] static member multiline_chart: IconData = nativeOnly
  [<IsConst>] static member multiline_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member multiline_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member multiline_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member multiple_stop: IconData = nativeOnly
  [<IsConst>] static member multiple_stop_sharp: IconData = nativeOnly
  [<IsConst>] static member multiple_stop_rounded: IconData = nativeOnly
  [<IsConst>] static member multiple_stop_outlined: IconData = nativeOnly
  [<IsConst>] static member multitrack_audio: IconData = nativeOnly
  [<IsConst>] static member multitrack_audio_sharp: IconData = nativeOnly
  [<IsConst>] static member multitrack_audio_rounded: IconData = nativeOnly
  [<IsConst>] static member multitrack_audio_outlined: IconData = nativeOnly
  [<IsConst>] static member museum: IconData = nativeOnly
  [<IsConst>] static member museum_sharp: IconData = nativeOnly
  [<IsConst>] static member museum_rounded: IconData = nativeOnly
  [<IsConst>] static member museum_outlined: IconData = nativeOnly
  [<IsConst>] static member music_note: IconData = nativeOnly
  [<IsConst>] static member music_note_sharp: IconData = nativeOnly
  [<IsConst>] static member music_note_rounded: IconData = nativeOnly
  [<IsConst>] static member music_note_outlined: IconData = nativeOnly
  [<IsConst>] static member music_off: IconData = nativeOnly
  [<IsConst>] static member music_off_sharp: IconData = nativeOnly
  [<IsConst>] static member music_off_rounded: IconData = nativeOnly
  [<IsConst>] static member music_off_outlined: IconData = nativeOnly
  [<IsConst>] static member music_video: IconData = nativeOnly
  [<IsConst>] static member music_video_sharp: IconData = nativeOnly
  [<IsConst>] static member music_video_rounded: IconData = nativeOnly
  [<IsConst>] static member music_video_outlined: IconData = nativeOnly
  [<IsConst>] static member my_library_add: IconData = nativeOnly
  [<IsConst>] static member my_library_add_sharp: IconData = nativeOnly
  [<IsConst>] static member my_library_add_rounded: IconData = nativeOnly
  [<IsConst>] static member my_library_add_outlined: IconData = nativeOnly
  [<IsConst>] static member my_library_books: IconData = nativeOnly
  [<IsConst>] static member my_library_books_sharp: IconData = nativeOnly
  [<IsConst>] static member my_library_books_rounded: IconData = nativeOnly
  [<IsConst>] static member my_library_books_outlined: IconData = nativeOnly
  [<IsConst>] static member my_library_music: IconData = nativeOnly
  [<IsConst>] static member my_library_music_sharp: IconData = nativeOnly
  [<IsConst>] static member my_library_music_rounded: IconData = nativeOnly
  [<IsConst>] static member my_library_music_outlined: IconData = nativeOnly
  [<IsConst>] static member my_location: IconData = nativeOnly
  [<IsConst>] static member my_location_sharp: IconData = nativeOnly
  [<IsConst>] static member my_location_rounded: IconData = nativeOnly
  [<IsConst>] static member my_location_outlined: IconData = nativeOnly
  [<IsConst>] static member nat: IconData = nativeOnly
  [<IsConst>] static member nat_sharp: IconData = nativeOnly
  [<IsConst>] static member nat_rounded: IconData = nativeOnly
  [<IsConst>] static member nat_outlined: IconData = nativeOnly
  [<IsConst>] static member nature: IconData = nativeOnly
  [<IsConst>] static member nature_sharp: IconData = nativeOnly
  [<IsConst>] static member nature_rounded: IconData = nativeOnly
  [<IsConst>] static member nature_outlined: IconData = nativeOnly
  [<IsConst>] static member nature_people: IconData = nativeOnly
  [<IsConst>] static member nature_people_sharp: IconData = nativeOnly
  [<IsConst>] static member nature_people_rounded: IconData = nativeOnly
  [<IsConst>] static member nature_people_outlined: IconData = nativeOnly
  [<IsConst>] static member navigate_before: IconData = nativeOnly
  [<IsConst>] static member navigate_before_sharp: IconData = nativeOnly
  [<IsConst>] static member navigate_before_rounded: IconData = nativeOnly
  [<IsConst>] static member navigate_before_outlined: IconData = nativeOnly
  [<IsConst>] static member navigate_next: IconData = nativeOnly
  [<IsConst>] static member navigate_next_sharp: IconData = nativeOnly
  [<IsConst>] static member navigate_next_rounded: IconData = nativeOnly
  [<IsConst>] static member navigate_next_outlined: IconData = nativeOnly
  [<IsConst>] static member navigation: IconData = nativeOnly
  [<IsConst>] static member navigation_sharp: IconData = nativeOnly
  [<IsConst>] static member navigation_rounded: IconData = nativeOnly
  [<IsConst>] static member navigation_outlined: IconData = nativeOnly
  [<IsConst>] static member near_me: IconData = nativeOnly
  [<IsConst>] static member near_me_sharp: IconData = nativeOnly
  [<IsConst>] static member near_me_rounded: IconData = nativeOnly
  [<IsConst>] static member near_me_outlined: IconData = nativeOnly
  [<IsConst>] static member near_me_disabled: IconData = nativeOnly
  [<IsConst>] static member near_me_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member near_me_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member near_me_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member nearby_error: IconData = nativeOnly
  [<IsConst>] static member nearby_error_sharp: IconData = nativeOnly
  [<IsConst>] static member nearby_error_rounded: IconData = nativeOnly
  [<IsConst>] static member nearby_error_outlined: IconData = nativeOnly
  [<IsConst>] static member nearby_off: IconData = nativeOnly
  [<IsConst>] static member nearby_off_sharp: IconData = nativeOnly
  [<IsConst>] static member nearby_off_rounded: IconData = nativeOnly
  [<IsConst>] static member nearby_off_outlined: IconData = nativeOnly
  [<IsConst>] static member nest_cam_wired_stand: IconData = nativeOnly
  [<IsConst>] static member nest_cam_wired_stand_sharp: IconData = nativeOnly
  [<IsConst>] static member nest_cam_wired_stand_rounded: IconData = nativeOnly
  [<IsConst>] static member nest_cam_wired_stand_outlined: IconData = nativeOnly
  [<IsConst>] static member network_cell: IconData = nativeOnly
  [<IsConst>] static member network_cell_sharp: IconData = nativeOnly
  [<IsConst>] static member network_cell_rounded: IconData = nativeOnly
  [<IsConst>] static member network_cell_outlined: IconData = nativeOnly
  [<IsConst>] static member network_check: IconData = nativeOnly
  [<IsConst>] static member network_check_sharp: IconData = nativeOnly
  [<IsConst>] static member network_check_rounded: IconData = nativeOnly
  [<IsConst>] static member network_check_outlined: IconData = nativeOnly
  [<IsConst>] static member network_locked: IconData = nativeOnly
  [<IsConst>] static member network_locked_sharp: IconData = nativeOnly
  [<IsConst>] static member network_locked_rounded: IconData = nativeOnly
  [<IsConst>] static member network_locked_outlined: IconData = nativeOnly
  [<IsConst>] static member network_ping: IconData = nativeOnly
  [<IsConst>] static member network_ping_sharp: IconData = nativeOnly
  [<IsConst>] static member network_ping_rounded: IconData = nativeOnly
  [<IsConst>] static member network_ping_outlined: IconData = nativeOnly
  [<IsConst>] static member network_wifi: IconData = nativeOnly
  [<IsConst>] static member network_wifi_sharp: IconData = nativeOnly
  [<IsConst>] static member network_wifi_rounded: IconData = nativeOnly
  [<IsConst>] static member network_wifi_outlined: IconData = nativeOnly
  [<IsConst>] static member network_wifi_1_bar: IconData = nativeOnly
  [<IsConst>] static member network_wifi_1_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member network_wifi_1_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member network_wifi_1_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member network_wifi_2_bar: IconData = nativeOnly
  [<IsConst>] static member network_wifi_2_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member network_wifi_2_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member network_wifi_2_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member network_wifi_3_bar: IconData = nativeOnly
  [<IsConst>] static member network_wifi_3_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member network_wifi_3_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member network_wifi_3_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member new_label: IconData = nativeOnly
  [<IsConst>] static member new_label_sharp: IconData = nativeOnly
  [<IsConst>] static member new_label_rounded: IconData = nativeOnly
  [<IsConst>] static member new_label_outlined: IconData = nativeOnly
  [<IsConst>] static member new_releases: IconData = nativeOnly
  [<IsConst>] static member new_releases_sharp: IconData = nativeOnly
  [<IsConst>] static member new_releases_rounded: IconData = nativeOnly
  [<IsConst>] static member new_releases_outlined: IconData = nativeOnly
  [<IsConst>] static member newspaper: IconData = nativeOnly
  [<IsConst>] static member newspaper_sharp: IconData = nativeOnly
  [<IsConst>] static member newspaper_rounded: IconData = nativeOnly
  [<IsConst>] static member newspaper_outlined: IconData = nativeOnly
  [<IsConst>] static member next_plan: IconData = nativeOnly
  [<IsConst>] static member next_plan_sharp: IconData = nativeOnly
  [<IsConst>] static member next_plan_rounded: IconData = nativeOnly
  [<IsConst>] static member next_plan_outlined: IconData = nativeOnly
  [<IsConst>] static member next_week: IconData = nativeOnly
  [<IsConst>] static member next_week_sharp: IconData = nativeOnly
  [<IsConst>] static member next_week_rounded: IconData = nativeOnly
  [<IsConst>] static member next_week_outlined: IconData = nativeOnly
  [<IsConst>] static member nfc: IconData = nativeOnly
  [<IsConst>] static member nfc_sharp: IconData = nativeOnly
  [<IsConst>] static member nfc_rounded: IconData = nativeOnly
  [<IsConst>] static member nfc_outlined: IconData = nativeOnly
  [<IsConst>] static member night_shelter: IconData = nativeOnly
  [<IsConst>] static member night_shelter_sharp: IconData = nativeOnly
  [<IsConst>] static member night_shelter_rounded: IconData = nativeOnly
  [<IsConst>] static member night_shelter_outlined: IconData = nativeOnly
  [<IsConst>] static member nightlife: IconData = nativeOnly
  [<IsConst>] static member nightlife_sharp: IconData = nativeOnly
  [<IsConst>] static member nightlife_rounded: IconData = nativeOnly
  [<IsConst>] static member nightlife_outlined: IconData = nativeOnly
  [<IsConst>] static member nightlight: IconData = nativeOnly
  [<IsConst>] static member nightlight_sharp: IconData = nativeOnly
  [<IsConst>] static member nightlight_rounded: IconData = nativeOnly
  [<IsConst>] static member nightlight_outlined: IconData = nativeOnly
  [<IsConst>] static member nightlight_round: IconData = nativeOnly
  [<IsConst>] static member nightlight_round_sharp: IconData = nativeOnly
  [<IsConst>] static member nightlight_round_rounded: IconData = nativeOnly
  [<IsConst>] static member nightlight_round_outlined: IconData = nativeOnly
  [<IsConst>] static member nights_stay: IconData = nativeOnly
  [<IsConst>] static member nights_stay_sharp: IconData = nativeOnly
  [<IsConst>] static member nights_stay_rounded: IconData = nativeOnly
  [<IsConst>] static member nights_stay_outlined: IconData = nativeOnly
  [<IsConst>] static member no_accounts: IconData = nativeOnly
  [<IsConst>] static member no_accounts_sharp: IconData = nativeOnly
  [<IsConst>] static member no_accounts_rounded: IconData = nativeOnly
  [<IsConst>] static member no_accounts_outlined: IconData = nativeOnly
  [<IsConst>] static member no_adult_content: IconData = nativeOnly
  [<IsConst>] static member no_adult_content_sharp: IconData = nativeOnly
  [<IsConst>] static member no_adult_content_rounded: IconData = nativeOnly
  [<IsConst>] static member no_adult_content_outlined: IconData = nativeOnly
  [<IsConst>] static member no_backpack: IconData = nativeOnly
  [<IsConst>] static member no_backpack_sharp: IconData = nativeOnly
  [<IsConst>] static member no_backpack_rounded: IconData = nativeOnly
  [<IsConst>] static member no_backpack_outlined: IconData = nativeOnly
  [<IsConst>] static member no_cell: IconData = nativeOnly
  [<IsConst>] static member no_cell_sharp: IconData = nativeOnly
  [<IsConst>] static member no_cell_rounded: IconData = nativeOnly
  [<IsConst>] static member no_cell_outlined: IconData = nativeOnly
  [<IsConst>] static member no_crash: IconData = nativeOnly
  [<IsConst>] static member no_crash_sharp: IconData = nativeOnly
  [<IsConst>] static member no_crash_rounded: IconData = nativeOnly
  [<IsConst>] static member no_crash_outlined: IconData = nativeOnly
  [<IsConst>] static member no_drinks: IconData = nativeOnly
  [<IsConst>] static member no_drinks_sharp: IconData = nativeOnly
  [<IsConst>] static member no_drinks_rounded: IconData = nativeOnly
  [<IsConst>] static member no_drinks_outlined: IconData = nativeOnly
  [<IsConst>] static member no_encryption: IconData = nativeOnly
  [<IsConst>] static member no_encryption_sharp: IconData = nativeOnly
  [<IsConst>] static member no_encryption_rounded: IconData = nativeOnly
  [<IsConst>] static member no_encryption_outlined: IconData = nativeOnly
  [<IsConst>] static member no_encryption_gmailerrorred: IconData = nativeOnly
  [<IsConst>] static member no_encryption_gmailerrorred_sharp: IconData = nativeOnly
  [<IsConst>] static member no_encryption_gmailerrorred_rounded: IconData = nativeOnly
  [<IsConst>] static member no_encryption_gmailerrorred_outlined: IconData = nativeOnly
  [<IsConst>] static member no_flash: IconData = nativeOnly
  [<IsConst>] static member no_flash_sharp: IconData = nativeOnly
  [<IsConst>] static member no_flash_rounded: IconData = nativeOnly
  [<IsConst>] static member no_flash_outlined: IconData = nativeOnly
  [<IsConst>] static member no_food: IconData = nativeOnly
  [<IsConst>] static member no_food_sharp: IconData = nativeOnly
  [<IsConst>] static member no_food_rounded: IconData = nativeOnly
  [<IsConst>] static member no_food_outlined: IconData = nativeOnly
  [<IsConst>] static member no_luggage: IconData = nativeOnly
  [<IsConst>] static member no_luggage_sharp: IconData = nativeOnly
  [<IsConst>] static member no_luggage_rounded: IconData = nativeOnly
  [<IsConst>] static member no_luggage_outlined: IconData = nativeOnly
  [<IsConst>] static member no_meals: IconData = nativeOnly
  [<IsConst>] static member no_meals_sharp: IconData = nativeOnly
  [<IsConst>] static member no_meals_rounded: IconData = nativeOnly
  [<IsConst>] static member no_meals_outlined: IconData = nativeOnly
  [<IsConst>] static member no_meals_ouline: IconData = nativeOnly
  [<IsConst>] static member no_meeting_room: IconData = nativeOnly
  [<IsConst>] static member no_meeting_room_sharp: IconData = nativeOnly
  [<IsConst>] static member no_meeting_room_rounded: IconData = nativeOnly
  [<IsConst>] static member no_meeting_room_outlined: IconData = nativeOnly
  [<IsConst>] static member no_photography: IconData = nativeOnly
  [<IsConst>] static member no_photography_sharp: IconData = nativeOnly
  [<IsConst>] static member no_photography_rounded: IconData = nativeOnly
  [<IsConst>] static member no_photography_outlined: IconData = nativeOnly
  [<IsConst>] static member no_sim: IconData = nativeOnly
  [<IsConst>] static member no_sim_sharp: IconData = nativeOnly
  [<IsConst>] static member no_sim_rounded: IconData = nativeOnly
  [<IsConst>] static member no_sim_outlined: IconData = nativeOnly
  [<IsConst>] static member no_stroller: IconData = nativeOnly
  [<IsConst>] static member no_stroller_sharp: IconData = nativeOnly
  [<IsConst>] static member no_stroller_rounded: IconData = nativeOnly
  [<IsConst>] static member no_stroller_outlined: IconData = nativeOnly
  [<IsConst>] static member no_transfer: IconData = nativeOnly
  [<IsConst>] static member no_transfer_sharp: IconData = nativeOnly
  [<IsConst>] static member no_transfer_rounded: IconData = nativeOnly
  [<IsConst>] static member no_transfer_outlined: IconData = nativeOnly
  [<IsConst>] static member noise_aware: IconData = nativeOnly
  [<IsConst>] static member noise_aware_sharp: IconData = nativeOnly
  [<IsConst>] static member noise_aware_rounded: IconData = nativeOnly
  [<IsConst>] static member noise_aware_outlined: IconData = nativeOnly
  [<IsConst>] static member noise_control_off: IconData = nativeOnly
  [<IsConst>] static member noise_control_off_sharp: IconData = nativeOnly
  [<IsConst>] static member noise_control_off_rounded: IconData = nativeOnly
  [<IsConst>] static member noise_control_off_outlined: IconData = nativeOnly
  [<IsConst>] static member nordic_walking: IconData = nativeOnly
  [<IsConst>] static member nordic_walking_sharp: IconData = nativeOnly
  [<IsConst>] static member nordic_walking_rounded: IconData = nativeOnly
  [<IsConst>] static member nordic_walking_outlined: IconData = nativeOnly
  [<IsConst>] static member north: IconData = nativeOnly
  [<IsConst>] static member north_sharp: IconData = nativeOnly
  [<IsConst>] static member north_rounded: IconData = nativeOnly
  [<IsConst>] static member north_outlined: IconData = nativeOnly
  [<IsConst>] static member north_east: IconData = nativeOnly
  [<IsConst>] static member north_east_sharp: IconData = nativeOnly
  [<IsConst>] static member north_east_rounded: IconData = nativeOnly
  [<IsConst>] static member north_east_outlined: IconData = nativeOnly
  [<IsConst>] static member north_west: IconData = nativeOnly
  [<IsConst>] static member north_west_sharp: IconData = nativeOnly
  [<IsConst>] static member north_west_rounded: IconData = nativeOnly
  [<IsConst>] static member north_west_outlined: IconData = nativeOnly
  [<IsConst>] static member not_accessible: IconData = nativeOnly
  [<IsConst>] static member not_accessible_sharp: IconData = nativeOnly
  [<IsConst>] static member not_accessible_rounded: IconData = nativeOnly
  [<IsConst>] static member not_accessible_outlined: IconData = nativeOnly
  [<IsConst>] static member not_interested: IconData = nativeOnly
  [<IsConst>] static member not_interested_sharp: IconData = nativeOnly
  [<IsConst>] static member not_interested_rounded: IconData = nativeOnly
  [<IsConst>] static member not_interested_outlined: IconData = nativeOnly
  [<IsConst>] static member not_listed_location: IconData = nativeOnly
  [<IsConst>] static member not_listed_location_sharp: IconData = nativeOnly
  [<IsConst>] static member not_listed_location_rounded: IconData = nativeOnly
  [<IsConst>] static member not_listed_location_outlined: IconData = nativeOnly
  [<IsConst>] static member not_started: IconData = nativeOnly
  [<IsConst>] static member not_started_sharp: IconData = nativeOnly
  [<IsConst>] static member not_started_rounded: IconData = nativeOnly
  [<IsConst>] static member not_started_outlined: IconData = nativeOnly
  [<IsConst>] static member note: IconData = nativeOnly
  [<IsConst>] static member note_sharp: IconData = nativeOnly
  [<IsConst>] static member note_rounded: IconData = nativeOnly
  [<IsConst>] static member note_outlined: IconData = nativeOnly
  [<IsConst>] static member note_add: IconData = nativeOnly
  [<IsConst>] static member note_add_sharp: IconData = nativeOnly
  [<IsConst>] static member note_add_rounded: IconData = nativeOnly
  [<IsConst>] static member note_add_outlined: IconData = nativeOnly
  [<IsConst>] static member note_alt: IconData = nativeOnly
  [<IsConst>] static member note_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member note_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member note_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member notes: IconData = nativeOnly
  [<IsConst>] static member notes_sharp: IconData = nativeOnly
  [<IsConst>] static member notes_rounded: IconData = nativeOnly
  [<IsConst>] static member notes_outlined: IconData = nativeOnly
  [<IsConst>] static member notification_add: IconData = nativeOnly
  [<IsConst>] static member notification_add_sharp: IconData = nativeOnly
  [<IsConst>] static member notification_add_rounded: IconData = nativeOnly
  [<IsConst>] static member notification_add_outlined: IconData = nativeOnly
  [<IsConst>] static member notification_important: IconData = nativeOnly
  [<IsConst>] static member notification_important_sharp: IconData = nativeOnly
  [<IsConst>] static member notification_important_rounded: IconData = nativeOnly
  [<IsConst>] static member notification_important_outlined: IconData = nativeOnly
  [<IsConst>] static member notifications: IconData = nativeOnly
  [<IsConst>] static member notifications_sharp: IconData = nativeOnly
  [<IsConst>] static member notifications_rounded: IconData = nativeOnly
  [<IsConst>] static member notifications_outlined: IconData = nativeOnly
  [<IsConst>] static member notifications_active: IconData = nativeOnly
  [<IsConst>] static member notifications_active_sharp: IconData = nativeOnly
  [<IsConst>] static member notifications_active_rounded: IconData = nativeOnly
  [<IsConst>] static member notifications_active_outlined: IconData = nativeOnly
  [<IsConst>] static member notifications_none: IconData = nativeOnly
  [<IsConst>] static member notifications_none_sharp: IconData = nativeOnly
  [<IsConst>] static member notifications_none_rounded: IconData = nativeOnly
  [<IsConst>] static member notifications_none_outlined: IconData = nativeOnly
  [<IsConst>] static member notifications_off: IconData = nativeOnly
  [<IsConst>] static member notifications_off_sharp: IconData = nativeOnly
  [<IsConst>] static member notifications_off_rounded: IconData = nativeOnly
  [<IsConst>] static member notifications_off_outlined: IconData = nativeOnly
  [<IsConst>] static member notifications_on: IconData = nativeOnly
  [<IsConst>] static member notifications_on_sharp: IconData = nativeOnly
  [<IsConst>] static member notifications_on_rounded: IconData = nativeOnly
  [<IsConst>] static member notifications_on_outlined: IconData = nativeOnly
  [<IsConst>] static member notifications_paused: IconData = nativeOnly
  [<IsConst>] static member notifications_paused_sharp: IconData = nativeOnly
  [<IsConst>] static member notifications_paused_rounded: IconData = nativeOnly
  [<IsConst>] static member notifications_paused_outlined: IconData = nativeOnly
  [<IsConst>] static member now_wallpaper: IconData = nativeOnly
  [<IsConst>] static member now_wallpaper_sharp: IconData = nativeOnly
  [<IsConst>] static member now_wallpaper_rounded: IconData = nativeOnly
  [<IsConst>] static member now_wallpaper_outlined: IconData = nativeOnly
  [<IsConst>] static member now_widgets: IconData = nativeOnly
  [<IsConst>] static member now_widgets_sharp: IconData = nativeOnly
  [<IsConst>] static member now_widgets_rounded: IconData = nativeOnly
  [<IsConst>] static member now_widgets_outlined: IconData = nativeOnly
  [<IsConst>] static member numbers: IconData = nativeOnly
  [<IsConst>] static member numbers_sharp: IconData = nativeOnly
  [<IsConst>] static member numbers_rounded: IconData = nativeOnly
  [<IsConst>] static member numbers_outlined: IconData = nativeOnly
  [<IsConst>] static member offline_bolt: IconData = nativeOnly
  [<IsConst>] static member offline_bolt_sharp: IconData = nativeOnly
  [<IsConst>] static member offline_bolt_rounded: IconData = nativeOnly
  [<IsConst>] static member offline_bolt_outlined: IconData = nativeOnly
  [<IsConst>] static member offline_pin: IconData = nativeOnly
  [<IsConst>] static member offline_pin_sharp: IconData = nativeOnly
  [<IsConst>] static member offline_pin_rounded: IconData = nativeOnly
  [<IsConst>] static member offline_pin_outlined: IconData = nativeOnly
  [<IsConst>] static member offline_share: IconData = nativeOnly
  [<IsConst>] static member offline_share_sharp: IconData = nativeOnly
  [<IsConst>] static member offline_share_rounded: IconData = nativeOnly
  [<IsConst>] static member offline_share_outlined: IconData = nativeOnly
  [<IsConst>] static member oil_barrel: IconData = nativeOnly
  [<IsConst>] static member oil_barrel_sharp: IconData = nativeOnly
  [<IsConst>] static member oil_barrel_rounded: IconData = nativeOnly
  [<IsConst>] static member oil_barrel_outlined: IconData = nativeOnly
  [<IsConst>] static member on_device_training: IconData = nativeOnly
  [<IsConst>] static member on_device_training_sharp: IconData = nativeOnly
  [<IsConst>] static member on_device_training_rounded: IconData = nativeOnly
  [<IsConst>] static member on_device_training_outlined: IconData = nativeOnly
  [<IsConst>] static member ondemand_video: IconData = nativeOnly
  [<IsConst>] static member ondemand_video_sharp: IconData = nativeOnly
  [<IsConst>] static member ondemand_video_rounded: IconData = nativeOnly
  [<IsConst>] static member ondemand_video_outlined: IconData = nativeOnly
  [<IsConst>] static member online_prediction: IconData = nativeOnly
  [<IsConst>] static member online_prediction_sharp: IconData = nativeOnly
  [<IsConst>] static member online_prediction_rounded: IconData = nativeOnly
  [<IsConst>] static member online_prediction_outlined: IconData = nativeOnly
  [<IsConst>] static member opacity: IconData = nativeOnly
  [<IsConst>] static member opacity_sharp: IconData = nativeOnly
  [<IsConst>] static member opacity_rounded: IconData = nativeOnly
  [<IsConst>] static member opacity_outlined: IconData = nativeOnly
  [<IsConst>] static member open_in_browser: IconData = nativeOnly
  [<IsConst>] static member open_in_browser_sharp: IconData = nativeOnly
  [<IsConst>] static member open_in_browser_rounded: IconData = nativeOnly
  [<IsConst>] static member open_in_browser_outlined: IconData = nativeOnly
  [<IsConst>] static member open_in_full: IconData = nativeOnly
  [<IsConst>] static member open_in_full_sharp: IconData = nativeOnly
  [<IsConst>] static member open_in_full_rounded: IconData = nativeOnly
  [<IsConst>] static member open_in_full_outlined: IconData = nativeOnly
  [<IsConst>] static member open_in_new: IconData = nativeOnly
  [<IsConst>] static member open_in_new_sharp: IconData = nativeOnly
  [<IsConst>] static member open_in_new_rounded: IconData = nativeOnly
  [<IsConst>] static member open_in_new_outlined: IconData = nativeOnly
  [<IsConst>] static member open_in_new_off: IconData = nativeOnly
  [<IsConst>] static member open_in_new_off_sharp: IconData = nativeOnly
  [<IsConst>] static member open_in_new_off_rounded: IconData = nativeOnly
  [<IsConst>] static member open_in_new_off_outlined: IconData = nativeOnly
  [<IsConst>] static member open_with: IconData = nativeOnly
  [<IsConst>] static member open_with_sharp: IconData = nativeOnly
  [<IsConst>] static member open_with_rounded: IconData = nativeOnly
  [<IsConst>] static member open_with_outlined: IconData = nativeOnly
  [<IsConst>] static member other_houses: IconData = nativeOnly
  [<IsConst>] static member other_houses_sharp: IconData = nativeOnly
  [<IsConst>] static member other_houses_rounded: IconData = nativeOnly
  [<IsConst>] static member other_houses_outlined: IconData = nativeOnly
  [<IsConst>] static member outbond: IconData = nativeOnly
  [<IsConst>] static member outbond_sharp: IconData = nativeOnly
  [<IsConst>] static member outbond_rounded: IconData = nativeOnly
  [<IsConst>] static member outbond_outlined: IconData = nativeOnly
  [<IsConst>] static member outbound: IconData = nativeOnly
  [<IsConst>] static member outbound_sharp: IconData = nativeOnly
  [<IsConst>] static member outbound_rounded: IconData = nativeOnly
  [<IsConst>] static member outbound_outlined: IconData = nativeOnly
  [<IsConst>] static member outbox: IconData = nativeOnly
  [<IsConst>] static member outbox_sharp: IconData = nativeOnly
  [<IsConst>] static member outbox_rounded: IconData = nativeOnly
  [<IsConst>] static member outbox_outlined: IconData = nativeOnly
  [<IsConst>] static member outdoor_grill: IconData = nativeOnly
  [<IsConst>] static member outdoor_grill_sharp: IconData = nativeOnly
  [<IsConst>] static member outdoor_grill_rounded: IconData = nativeOnly
  [<IsConst>] static member outdoor_grill_outlined: IconData = nativeOnly
  [<IsConst>] static member outgoing_mail: IconData = nativeOnly
  [<IsConst>] static member outlet: IconData = nativeOnly
  [<IsConst>] static member outlet_sharp: IconData = nativeOnly
  [<IsConst>] static member outlet_rounded: IconData = nativeOnly
  [<IsConst>] static member outlet_outlined: IconData = nativeOnly
  [<IsConst>] static member outlined_flag: IconData = nativeOnly
  [<IsConst>] static member outlined_flag_sharp: IconData = nativeOnly
  [<IsConst>] static member outlined_flag_rounded: IconData = nativeOnly
  [<IsConst>] static member outlined_flag_outlined: IconData = nativeOnly
  [<IsConst>] static member output: IconData = nativeOnly
  [<IsConst>] static member output_sharp: IconData = nativeOnly
  [<IsConst>] static member output_rounded: IconData = nativeOnly
  [<IsConst>] static member output_outlined: IconData = nativeOnly
  [<IsConst>] static member padding: IconData = nativeOnly
  [<IsConst>] static member padding_sharp: IconData = nativeOnly
  [<IsConst>] static member padding_rounded: IconData = nativeOnly
  [<IsConst>] static member padding_outlined: IconData = nativeOnly
  [<IsConst>] static member pages: IconData = nativeOnly
  [<IsConst>] static member pages_sharp: IconData = nativeOnly
  [<IsConst>] static member pages_rounded: IconData = nativeOnly
  [<IsConst>] static member pages_outlined: IconData = nativeOnly
  [<IsConst>] static member pageview: IconData = nativeOnly
  [<IsConst>] static member pageview_sharp: IconData = nativeOnly
  [<IsConst>] static member pageview_rounded: IconData = nativeOnly
  [<IsConst>] static member pageview_outlined: IconData = nativeOnly
  [<IsConst>] static member paid: IconData = nativeOnly
  [<IsConst>] static member paid_sharp: IconData = nativeOnly
  [<IsConst>] static member paid_rounded: IconData = nativeOnly
  [<IsConst>] static member paid_outlined: IconData = nativeOnly
  [<IsConst>] static member palette: IconData = nativeOnly
  [<IsConst>] static member palette_sharp: IconData = nativeOnly
  [<IsConst>] static member palette_rounded: IconData = nativeOnly
  [<IsConst>] static member palette_outlined: IconData = nativeOnly
  [<IsConst>] static member pan_tool: IconData = nativeOnly
  [<IsConst>] static member pan_tool_sharp: IconData = nativeOnly
  [<IsConst>] static member pan_tool_rounded: IconData = nativeOnly
  [<IsConst>] static member pan_tool_outlined: IconData = nativeOnly
  [<IsConst>] static member pan_tool_alt: IconData = nativeOnly
  [<IsConst>] static member pan_tool_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member pan_tool_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member pan_tool_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member panorama: IconData = nativeOnly
  [<IsConst>] static member panorama_sharp: IconData = nativeOnly
  [<IsConst>] static member panorama_rounded: IconData = nativeOnly
  [<IsConst>] static member panorama_outlined: IconData = nativeOnly
  [<IsConst>] static member panorama_fish_eye: IconData = nativeOnly
  [<IsConst>] static member panorama_fish_eye_sharp: IconData = nativeOnly
  [<IsConst>] static member panorama_fish_eye_rounded: IconData = nativeOnly
  [<IsConst>] static member panorama_fish_eye_outlined: IconData = nativeOnly
  [<IsConst>] static member panorama_fisheye: IconData = nativeOnly
  [<IsConst>] static member panorama_fisheye_sharp: IconData = nativeOnly
  [<IsConst>] static member panorama_fisheye_rounded: IconData = nativeOnly
  [<IsConst>] static member panorama_fisheye_outlined: IconData = nativeOnly
  [<IsConst>] static member panorama_horizontal: IconData = nativeOnly
  [<IsConst>] static member panorama_horizontal_sharp: IconData = nativeOnly
  [<IsConst>] static member panorama_horizontal_rounded: IconData = nativeOnly
  [<IsConst>] static member panorama_horizontal_outlined: IconData = nativeOnly
  [<IsConst>] static member panorama_horizontal_select: IconData = nativeOnly
  [<IsConst>] static member panorama_horizontal_select_sharp: IconData = nativeOnly
  [<IsConst>] static member panorama_horizontal_select_rounded: IconData = nativeOnly
  [<IsConst>] static member panorama_horizontal_select_outlined: IconData = nativeOnly
  [<IsConst>] static member panorama_photosphere: IconData = nativeOnly
  [<IsConst>] static member panorama_photosphere_sharp: IconData = nativeOnly
  [<IsConst>] static member panorama_photosphere_rounded: IconData = nativeOnly
  [<IsConst>] static member panorama_photosphere_outlined: IconData = nativeOnly
  [<IsConst>] static member panorama_photosphere_select: IconData = nativeOnly
  [<IsConst>] static member panorama_photosphere_select_sharp: IconData = nativeOnly
  [<IsConst>] static member panorama_photosphere_select_rounded: IconData = nativeOnly
  [<IsConst>] static member panorama_photosphere_select_outlined: IconData = nativeOnly
  [<IsConst>] static member panorama_vertical: IconData = nativeOnly
  [<IsConst>] static member panorama_vertical_sharp: IconData = nativeOnly
  [<IsConst>] static member panorama_vertical_rounded: IconData = nativeOnly
  [<IsConst>] static member panorama_vertical_outlined: IconData = nativeOnly
  [<IsConst>] static member panorama_vertical_select: IconData = nativeOnly
  [<IsConst>] static member panorama_vertical_select_sharp: IconData = nativeOnly
  [<IsConst>] static member panorama_vertical_select_rounded: IconData = nativeOnly
  [<IsConst>] static member panorama_vertical_select_outlined: IconData = nativeOnly
  [<IsConst>] static member panorama_wide_angle: IconData = nativeOnly
  [<IsConst>] static member panorama_wide_angle_sharp: IconData = nativeOnly
  [<IsConst>] static member panorama_wide_angle_rounded: IconData = nativeOnly
  [<IsConst>] static member panorama_wide_angle_outlined: IconData = nativeOnly
  [<IsConst>] static member panorama_wide_angle_select: IconData = nativeOnly
  [<IsConst>] static member panorama_wide_angle_select_sharp: IconData = nativeOnly
  [<IsConst>] static member panorama_wide_angle_select_rounded: IconData = nativeOnly
  [<IsConst>] static member panorama_wide_angle_select_outlined: IconData = nativeOnly
  [<IsConst>] static member paragliding: IconData = nativeOnly
  [<IsConst>] static member paragliding_sharp: IconData = nativeOnly
  [<IsConst>] static member paragliding_rounded: IconData = nativeOnly
  [<IsConst>] static member paragliding_outlined: IconData = nativeOnly
  [<IsConst>] static member park: IconData = nativeOnly
  [<IsConst>] static member park_sharp: IconData = nativeOnly
  [<IsConst>] static member park_rounded: IconData = nativeOnly
  [<IsConst>] static member park_outlined: IconData = nativeOnly
  [<IsConst>] static member party_mode: IconData = nativeOnly
  [<IsConst>] static member party_mode_sharp: IconData = nativeOnly
  [<IsConst>] static member party_mode_rounded: IconData = nativeOnly
  [<IsConst>] static member party_mode_outlined: IconData = nativeOnly
  [<IsConst>] static member password: IconData = nativeOnly
  [<IsConst>] static member password_sharp: IconData = nativeOnly
  [<IsConst>] static member password_rounded: IconData = nativeOnly
  [<IsConst>] static member password_outlined: IconData = nativeOnly
  [<IsConst>] static member paste: IconData = nativeOnly
  [<IsConst>] static member paste_sharp: IconData = nativeOnly
  [<IsConst>] static member paste_rounded: IconData = nativeOnly
  [<IsConst>] static member paste_outlined: IconData = nativeOnly
  [<IsConst>] static member pattern: IconData = nativeOnly
  [<IsConst>] static member pattern_sharp: IconData = nativeOnly
  [<IsConst>] static member pattern_rounded: IconData = nativeOnly
  [<IsConst>] static member pattern_outlined: IconData = nativeOnly
  [<IsConst>] static member pause: IconData = nativeOnly
  [<IsConst>] static member pause_sharp: IconData = nativeOnly
  [<IsConst>] static member pause_rounded: IconData = nativeOnly
  [<IsConst>] static member pause_outlined: IconData = nativeOnly
  [<IsConst>] static member pause_circle: IconData = nativeOnly
  [<IsConst>] static member pause_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member pause_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member pause_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member pause_circle_filled: IconData = nativeOnly
  [<IsConst>] static member pause_circle_filled_sharp: IconData = nativeOnly
  [<IsConst>] static member pause_circle_filled_rounded: IconData = nativeOnly
  [<IsConst>] static member pause_circle_filled_outlined: IconData = nativeOnly
  [<IsConst>] static member pause_circle_outline: IconData = nativeOnly
  [<IsConst>] static member pause_circle_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member pause_circle_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member pause_circle_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member pause_presentation: IconData = nativeOnly
  [<IsConst>] static member pause_presentation_sharp: IconData = nativeOnly
  [<IsConst>] static member pause_presentation_rounded: IconData = nativeOnly
  [<IsConst>] static member pause_presentation_outlined: IconData = nativeOnly
  [<IsConst>] static member payment: IconData = nativeOnly
  [<IsConst>] static member payment_sharp: IconData = nativeOnly
  [<IsConst>] static member payment_rounded: IconData = nativeOnly
  [<IsConst>] static member payment_outlined: IconData = nativeOnly
  [<IsConst>] static member payments: IconData = nativeOnly
  [<IsConst>] static member payments_sharp: IconData = nativeOnly
  [<IsConst>] static member payments_rounded: IconData = nativeOnly
  [<IsConst>] static member payments_outlined: IconData = nativeOnly
  [<IsConst>] static member paypal: IconData = nativeOnly
  [<IsConst>] static member paypal_sharp: IconData = nativeOnly
  [<IsConst>] static member paypal_rounded: IconData = nativeOnly
  [<IsConst>] static member paypal_outlined: IconData = nativeOnly
  [<IsConst>] static member pedal_bike: IconData = nativeOnly
  [<IsConst>] static member pedal_bike_sharp: IconData = nativeOnly
  [<IsConst>] static member pedal_bike_rounded: IconData = nativeOnly
  [<IsConst>] static member pedal_bike_outlined: IconData = nativeOnly
  [<IsConst>] static member pending: IconData = nativeOnly
  [<IsConst>] static member pending_sharp: IconData = nativeOnly
  [<IsConst>] static member pending_rounded: IconData = nativeOnly
  [<IsConst>] static member pending_outlined: IconData = nativeOnly
  [<IsConst>] static member pending_actions: IconData = nativeOnly
  [<IsConst>] static member pending_actions_sharp: IconData = nativeOnly
  [<IsConst>] static member pending_actions_rounded: IconData = nativeOnly
  [<IsConst>] static member pending_actions_outlined: IconData = nativeOnly
  [<IsConst>] static member pentagon: IconData = nativeOnly
  [<IsConst>] static member pentagon_sharp: IconData = nativeOnly
  [<IsConst>] static member pentagon_rounded: IconData = nativeOnly
  [<IsConst>] static member pentagon_outlined: IconData = nativeOnly
  [<IsConst>] static member people: IconData = nativeOnly
  [<IsConst>] static member people_sharp: IconData = nativeOnly
  [<IsConst>] static member people_rounded: IconData = nativeOnly
  [<IsConst>] static member people_outlined: IconData = nativeOnly
  [<IsConst>] static member people_alt: IconData = nativeOnly
  [<IsConst>] static member people_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member people_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member people_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member people_outline: IconData = nativeOnly
  [<IsConst>] static member people_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member people_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member people_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member percent: IconData = nativeOnly
  [<IsConst>] static member percent_sharp: IconData = nativeOnly
  [<IsConst>] static member percent_rounded: IconData = nativeOnly
  [<IsConst>] static member percent_outlined: IconData = nativeOnly
  [<IsConst>] static member perm_camera_mic: IconData = nativeOnly
  [<IsConst>] static member perm_camera_mic_sharp: IconData = nativeOnly
  [<IsConst>] static member perm_camera_mic_rounded: IconData = nativeOnly
  [<IsConst>] static member perm_camera_mic_outlined: IconData = nativeOnly
  [<IsConst>] static member perm_contact_cal: IconData = nativeOnly
  [<IsConst>] static member perm_contact_cal_sharp: IconData = nativeOnly
  [<IsConst>] static member perm_contact_cal_rounded: IconData = nativeOnly
  [<IsConst>] static member perm_contact_cal_outlined: IconData = nativeOnly
  [<IsConst>] static member perm_contact_calendar: IconData = nativeOnly
  [<IsConst>] static member perm_contact_calendar_sharp: IconData = nativeOnly
  [<IsConst>] static member perm_contact_calendar_rounded: IconData = nativeOnly
  [<IsConst>] static member perm_contact_calendar_outlined: IconData = nativeOnly
  [<IsConst>] static member perm_data_setting: IconData = nativeOnly
  [<IsConst>] static member perm_data_setting_sharp: IconData = nativeOnly
  [<IsConst>] static member perm_data_setting_rounded: IconData = nativeOnly
  [<IsConst>] static member perm_data_setting_outlined: IconData = nativeOnly
  [<IsConst>] static member perm_device_info: IconData = nativeOnly
  [<IsConst>] static member perm_device_info_sharp: IconData = nativeOnly
  [<IsConst>] static member perm_device_info_rounded: IconData = nativeOnly
  [<IsConst>] static member perm_device_info_outlined: IconData = nativeOnly
  [<IsConst>] static member perm_device_information: IconData = nativeOnly
  [<IsConst>] static member perm_device_information_sharp: IconData = nativeOnly
  [<IsConst>] static member perm_device_information_rounded: IconData = nativeOnly
  [<IsConst>] static member perm_device_information_outlined: IconData = nativeOnly
  [<IsConst>] static member perm_identity: IconData = nativeOnly
  [<IsConst>] static member perm_identity_sharp: IconData = nativeOnly
  [<IsConst>] static member perm_identity_rounded: IconData = nativeOnly
  [<IsConst>] static member perm_identity_outlined: IconData = nativeOnly
  [<IsConst>] static member perm_media: IconData = nativeOnly
  [<IsConst>] static member perm_media_sharp: IconData = nativeOnly
  [<IsConst>] static member perm_media_rounded: IconData = nativeOnly
  [<IsConst>] static member perm_media_outlined: IconData = nativeOnly
  [<IsConst>] static member perm_phone_msg: IconData = nativeOnly
  [<IsConst>] static member perm_phone_msg_sharp: IconData = nativeOnly
  [<IsConst>] static member perm_phone_msg_rounded: IconData = nativeOnly
  [<IsConst>] static member perm_phone_msg_outlined: IconData = nativeOnly
  [<IsConst>] static member perm_scan_wifi: IconData = nativeOnly
  [<IsConst>] static member perm_scan_wifi_sharp: IconData = nativeOnly
  [<IsConst>] static member perm_scan_wifi_rounded: IconData = nativeOnly
  [<IsConst>] static member perm_scan_wifi_outlined: IconData = nativeOnly
  [<IsConst>] static member person: IconData = nativeOnly
  [<IsConst>] static member person_sharp: IconData = nativeOnly
  [<IsConst>] static member person_rounded: IconData = nativeOnly
  [<IsConst>] static member person_outlined: IconData = nativeOnly
  [<IsConst>] static member person_add: IconData = nativeOnly
  [<IsConst>] static member person_add_sharp: IconData = nativeOnly
  [<IsConst>] static member person_add_rounded: IconData = nativeOnly
  [<IsConst>] static member person_add_outlined: IconData = nativeOnly
  [<IsConst>] static member person_add_alt: IconData = nativeOnly
  [<IsConst>] static member person_add_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member person_add_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member person_add_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member person_add_alt_1: IconData = nativeOnly
  [<IsConst>] static member person_add_alt_1_sharp: IconData = nativeOnly
  [<IsConst>] static member person_add_alt_1_rounded: IconData = nativeOnly
  [<IsConst>] static member person_add_alt_1_outlined: IconData = nativeOnly
  [<IsConst>] static member person_add_disabled: IconData = nativeOnly
  [<IsConst>] static member person_add_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member person_add_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member person_add_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member person_off: IconData = nativeOnly
  [<IsConst>] static member person_off_sharp: IconData = nativeOnly
  [<IsConst>] static member person_off_rounded: IconData = nativeOnly
  [<IsConst>] static member person_off_outlined: IconData = nativeOnly
  [<IsConst>] static member person_outline: IconData = nativeOnly
  [<IsConst>] static member person_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member person_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member person_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member person_pin: IconData = nativeOnly
  [<IsConst>] static member person_pin_sharp: IconData = nativeOnly
  [<IsConst>] static member person_pin_rounded: IconData = nativeOnly
  [<IsConst>] static member person_pin_outlined: IconData = nativeOnly
  [<IsConst>] static member person_pin_circle: IconData = nativeOnly
  [<IsConst>] static member person_pin_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member person_pin_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member person_pin_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member person_remove: IconData = nativeOnly
  [<IsConst>] static member person_remove_sharp: IconData = nativeOnly
  [<IsConst>] static member person_remove_rounded: IconData = nativeOnly
  [<IsConst>] static member person_remove_outlined: IconData = nativeOnly
  [<IsConst>] static member person_remove_alt_1: IconData = nativeOnly
  [<IsConst>] static member person_remove_alt_1_sharp: IconData = nativeOnly
  [<IsConst>] static member person_remove_alt_1_rounded: IconData = nativeOnly
  [<IsConst>] static member person_remove_alt_1_outlined: IconData = nativeOnly
  [<IsConst>] static member person_search: IconData = nativeOnly
  [<IsConst>] static member person_search_sharp: IconData = nativeOnly
  [<IsConst>] static member person_search_rounded: IconData = nativeOnly
  [<IsConst>] static member person_search_outlined: IconData = nativeOnly
  [<IsConst>] static member personal_injury: IconData = nativeOnly
  [<IsConst>] static member personal_injury_sharp: IconData = nativeOnly
  [<IsConst>] static member personal_injury_rounded: IconData = nativeOnly
  [<IsConst>] static member personal_injury_outlined: IconData = nativeOnly
  [<IsConst>] static member personal_video: IconData = nativeOnly
  [<IsConst>] static member personal_video_sharp: IconData = nativeOnly
  [<IsConst>] static member personal_video_rounded: IconData = nativeOnly
  [<IsConst>] static member personal_video_outlined: IconData = nativeOnly
  [<IsConst>] static member pest_control: IconData = nativeOnly
  [<IsConst>] static member pest_control_sharp: IconData = nativeOnly
  [<IsConst>] static member pest_control_rounded: IconData = nativeOnly
  [<IsConst>] static member pest_control_outlined: IconData = nativeOnly
  [<IsConst>] static member pest_control_rodent: IconData = nativeOnly
  [<IsConst>] static member pest_control_rodent_sharp: IconData = nativeOnly
  [<IsConst>] static member pest_control_rodent_rounded: IconData = nativeOnly
  [<IsConst>] static member pest_control_rodent_outlined: IconData = nativeOnly
  [<IsConst>] static member pets: IconData = nativeOnly
  [<IsConst>] static member pets_sharp: IconData = nativeOnly
  [<IsConst>] static member pets_rounded: IconData = nativeOnly
  [<IsConst>] static member pets_outlined: IconData = nativeOnly
  [<IsConst>] static member phishing: IconData = nativeOnly
  [<IsConst>] static member phishing_sharp: IconData = nativeOnly
  [<IsConst>] static member phishing_rounded: IconData = nativeOnly
  [<IsConst>] static member phishing_outlined: IconData = nativeOnly
  [<IsConst>] static member phone: IconData = nativeOnly
  [<IsConst>] static member phone_sharp: IconData = nativeOnly
  [<IsConst>] static member phone_rounded: IconData = nativeOnly
  [<IsConst>] static member phone_outlined: IconData = nativeOnly
  [<IsConst>] static member phone_android: IconData = nativeOnly
  [<IsConst>] static member phone_android_sharp: IconData = nativeOnly
  [<IsConst>] static member phone_android_rounded: IconData = nativeOnly
  [<IsConst>] static member phone_android_outlined: IconData = nativeOnly
  [<IsConst>] static member phone_bluetooth_speaker: IconData = nativeOnly
  [<IsConst>] static member phone_bluetooth_speaker_sharp: IconData = nativeOnly
  [<IsConst>] static member phone_bluetooth_speaker_rounded: IconData = nativeOnly
  [<IsConst>] static member phone_bluetooth_speaker_outlined: IconData = nativeOnly
  [<IsConst>] static member phone_callback: IconData = nativeOnly
  [<IsConst>] static member phone_callback_sharp: IconData = nativeOnly
  [<IsConst>] static member phone_callback_rounded: IconData = nativeOnly
  [<IsConst>] static member phone_callback_outlined: IconData = nativeOnly
  [<IsConst>] static member phone_disabled: IconData = nativeOnly
  [<IsConst>] static member phone_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member phone_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member phone_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member phone_enabled: IconData = nativeOnly
  [<IsConst>] static member phone_enabled_sharp: IconData = nativeOnly
  [<IsConst>] static member phone_enabled_rounded: IconData = nativeOnly
  [<IsConst>] static member phone_enabled_outlined: IconData = nativeOnly
  [<IsConst>] static member phone_forwarded: IconData = nativeOnly
  [<IsConst>] static member phone_forwarded_sharp: IconData = nativeOnly
  [<IsConst>] static member phone_forwarded_rounded: IconData = nativeOnly
  [<IsConst>] static member phone_forwarded_outlined: IconData = nativeOnly
  [<IsConst>] static member phone_in_talk: IconData = nativeOnly
  [<IsConst>] static member phone_in_talk_sharp: IconData = nativeOnly
  [<IsConst>] static member phone_in_talk_rounded: IconData = nativeOnly
  [<IsConst>] static member phone_in_talk_outlined: IconData = nativeOnly
  [<IsConst>] static member phone_iphone: IconData = nativeOnly
  [<IsConst>] static member phone_iphone_sharp: IconData = nativeOnly
  [<IsConst>] static member phone_iphone_rounded: IconData = nativeOnly
  [<IsConst>] static member phone_iphone_outlined: IconData = nativeOnly
  [<IsConst>] static member phone_locked: IconData = nativeOnly
  [<IsConst>] static member phone_locked_sharp: IconData = nativeOnly
  [<IsConst>] static member phone_locked_rounded: IconData = nativeOnly
  [<IsConst>] static member phone_locked_outlined: IconData = nativeOnly
  [<IsConst>] static member phone_missed: IconData = nativeOnly
  [<IsConst>] static member phone_missed_sharp: IconData = nativeOnly
  [<IsConst>] static member phone_missed_rounded: IconData = nativeOnly
  [<IsConst>] static member phone_missed_outlined: IconData = nativeOnly
  [<IsConst>] static member phone_paused: IconData = nativeOnly
  [<IsConst>] static member phone_paused_sharp: IconData = nativeOnly
  [<IsConst>] static member phone_paused_rounded: IconData = nativeOnly
  [<IsConst>] static member phone_paused_outlined: IconData = nativeOnly
  [<IsConst>] static member phonelink: IconData = nativeOnly
  [<IsConst>] static member phonelink_sharp: IconData = nativeOnly
  [<IsConst>] static member phonelink_rounded: IconData = nativeOnly
  [<IsConst>] static member phonelink_outlined: IconData = nativeOnly
  [<IsConst>] static member phonelink_erase: IconData = nativeOnly
  [<IsConst>] static member phonelink_erase_sharp: IconData = nativeOnly
  [<IsConst>] static member phonelink_erase_rounded: IconData = nativeOnly
  [<IsConst>] static member phonelink_erase_outlined: IconData = nativeOnly
  [<IsConst>] static member phonelink_lock: IconData = nativeOnly
  [<IsConst>] static member phonelink_lock_sharp: IconData = nativeOnly
  [<IsConst>] static member phonelink_lock_rounded: IconData = nativeOnly
  [<IsConst>] static member phonelink_lock_outlined: IconData = nativeOnly
  [<IsConst>] static member phonelink_off: IconData = nativeOnly
  [<IsConst>] static member phonelink_off_sharp: IconData = nativeOnly
  [<IsConst>] static member phonelink_off_rounded: IconData = nativeOnly
  [<IsConst>] static member phonelink_off_outlined: IconData = nativeOnly
  [<IsConst>] static member phonelink_ring: IconData = nativeOnly
  [<IsConst>] static member phonelink_ring_sharp: IconData = nativeOnly
  [<IsConst>] static member phonelink_ring_rounded: IconData = nativeOnly
  [<IsConst>] static member phonelink_ring_outlined: IconData = nativeOnly
  [<IsConst>] static member phonelink_setup: IconData = nativeOnly
  [<IsConst>] static member phonelink_setup_sharp: IconData = nativeOnly
  [<IsConst>] static member phonelink_setup_rounded: IconData = nativeOnly
  [<IsConst>] static member phonelink_setup_outlined: IconData = nativeOnly
  [<IsConst>] static member photo: IconData = nativeOnly
  [<IsConst>] static member photo_sharp: IconData = nativeOnly
  [<IsConst>] static member photo_rounded: IconData = nativeOnly
  [<IsConst>] static member photo_outlined: IconData = nativeOnly
  [<IsConst>] static member photo_album: IconData = nativeOnly
  [<IsConst>] static member photo_album_sharp: IconData = nativeOnly
  [<IsConst>] static member photo_album_rounded: IconData = nativeOnly
  [<IsConst>] static member photo_album_outlined: IconData = nativeOnly
  [<IsConst>] static member photo_camera: IconData = nativeOnly
  [<IsConst>] static member photo_camera_sharp: IconData = nativeOnly
  [<IsConst>] static member photo_camera_rounded: IconData = nativeOnly
  [<IsConst>] static member photo_camera_outlined: IconData = nativeOnly
  [<IsConst>] static member photo_camera_back: IconData = nativeOnly
  [<IsConst>] static member photo_camera_back_sharp: IconData = nativeOnly
  [<IsConst>] static member photo_camera_back_rounded: IconData = nativeOnly
  [<IsConst>] static member photo_camera_back_outlined: IconData = nativeOnly
  [<IsConst>] static member photo_camera_front: IconData = nativeOnly
  [<IsConst>] static member photo_camera_front_sharp: IconData = nativeOnly
  [<IsConst>] static member photo_camera_front_rounded: IconData = nativeOnly
  [<IsConst>] static member photo_camera_front_outlined: IconData = nativeOnly
  [<IsConst>] static member photo_filter: IconData = nativeOnly
  [<IsConst>] static member photo_filter_sharp: IconData = nativeOnly
  [<IsConst>] static member photo_filter_rounded: IconData = nativeOnly
  [<IsConst>] static member photo_filter_outlined: IconData = nativeOnly
  [<IsConst>] static member photo_library: IconData = nativeOnly
  [<IsConst>] static member photo_library_sharp: IconData = nativeOnly
  [<IsConst>] static member photo_library_rounded: IconData = nativeOnly
  [<IsConst>] static member photo_library_outlined: IconData = nativeOnly
  [<IsConst>] static member photo_size_select_actual: IconData = nativeOnly
  [<IsConst>] static member photo_size_select_actual_sharp: IconData = nativeOnly
  [<IsConst>] static member photo_size_select_actual_rounded: IconData = nativeOnly
  [<IsConst>] static member photo_size_select_actual_outlined: IconData = nativeOnly
  [<IsConst>] static member photo_size_select_large: IconData = nativeOnly
  [<IsConst>] static member photo_size_select_large_sharp: IconData = nativeOnly
  [<IsConst>] static member photo_size_select_large_rounded: IconData = nativeOnly
  [<IsConst>] static member photo_size_select_large_outlined: IconData = nativeOnly
  [<IsConst>] static member photo_size_select_small: IconData = nativeOnly
  [<IsConst>] static member photo_size_select_small_sharp: IconData = nativeOnly
  [<IsConst>] static member photo_size_select_small_rounded: IconData = nativeOnly
  [<IsConst>] static member photo_size_select_small_outlined: IconData = nativeOnly
  [<IsConst>] static member php: IconData = nativeOnly
  [<IsConst>] static member php_sharp: IconData = nativeOnly
  [<IsConst>] static member php_rounded: IconData = nativeOnly
  [<IsConst>] static member php_outlined: IconData = nativeOnly
  [<IsConst>] static member piano: IconData = nativeOnly
  [<IsConst>] static member piano_sharp: IconData = nativeOnly
  [<IsConst>] static member piano_rounded: IconData = nativeOnly
  [<IsConst>] static member piano_outlined: IconData = nativeOnly
  [<IsConst>] static member piano_off: IconData = nativeOnly
  [<IsConst>] static member piano_off_sharp: IconData = nativeOnly
  [<IsConst>] static member piano_off_rounded: IconData = nativeOnly
  [<IsConst>] static member piano_off_outlined: IconData = nativeOnly
  [<IsConst>] static member picture_as_pdf: IconData = nativeOnly
  [<IsConst>] static member picture_as_pdf_sharp: IconData = nativeOnly
  [<IsConst>] static member picture_as_pdf_rounded: IconData = nativeOnly
  [<IsConst>] static member picture_as_pdf_outlined: IconData = nativeOnly
  [<IsConst>] static member picture_in_picture: IconData = nativeOnly
  [<IsConst>] static member picture_in_picture_sharp: IconData = nativeOnly
  [<IsConst>] static member picture_in_picture_rounded: IconData = nativeOnly
  [<IsConst>] static member picture_in_picture_outlined: IconData = nativeOnly
  [<IsConst>] static member picture_in_picture_alt: IconData = nativeOnly
  [<IsConst>] static member picture_in_picture_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member picture_in_picture_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member picture_in_picture_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member pie_chart: IconData = nativeOnly
  [<IsConst>] static member pie_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member pie_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member pie_chart_outline: IconData = nativeOnly
  [<IsConst>] static member pie_chart_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member pie_chart_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member pie_chart_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member pin: IconData = nativeOnly
  [<IsConst>] static member pin_sharp: IconData = nativeOnly
  [<IsConst>] static member pin_rounded: IconData = nativeOnly
  [<IsConst>] static member pin_outlined: IconData = nativeOnly
  [<IsConst>] static member pin_drop: IconData = nativeOnly
  [<IsConst>] static member pin_drop_sharp: IconData = nativeOnly
  [<IsConst>] static member pin_drop_rounded: IconData = nativeOnly
  [<IsConst>] static member pin_drop_outlined: IconData = nativeOnly
  [<IsConst>] static member pin_end: IconData = nativeOnly
  [<IsConst>] static member pin_end_sharp: IconData = nativeOnly
  [<IsConst>] static member pin_end_rounded: IconData = nativeOnly
  [<IsConst>] static member pin_end_outlined: IconData = nativeOnly
  [<IsConst>] static member pin_invoke: IconData = nativeOnly
  [<IsConst>] static member pin_invoke_sharp: IconData = nativeOnly
  [<IsConst>] static member pin_invoke_rounded: IconData = nativeOnly
  [<IsConst>] static member pin_invoke_outlined: IconData = nativeOnly
  [<IsConst>] static member pinch: IconData = nativeOnly
  [<IsConst>] static member pinch_sharp: IconData = nativeOnly
  [<IsConst>] static member pinch_rounded: IconData = nativeOnly
  [<IsConst>] static member pinch_outlined: IconData = nativeOnly
  [<IsConst>] static member pivot_table_chart: IconData = nativeOnly
  [<IsConst>] static member pivot_table_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member pivot_table_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member pivot_table_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member pix: IconData = nativeOnly
  [<IsConst>] static member pix_sharp: IconData = nativeOnly
  [<IsConst>] static member pix_rounded: IconData = nativeOnly
  [<IsConst>] static member pix_outlined: IconData = nativeOnly
  [<IsConst>] static member place: IconData = nativeOnly
  [<IsConst>] static member place_sharp: IconData = nativeOnly
  [<IsConst>] static member place_rounded: IconData = nativeOnly
  [<IsConst>] static member place_outlined: IconData = nativeOnly
  [<IsConst>] static member plagiarism: IconData = nativeOnly
  [<IsConst>] static member plagiarism_sharp: IconData = nativeOnly
  [<IsConst>] static member plagiarism_rounded: IconData = nativeOnly
  [<IsConst>] static member plagiarism_outlined: IconData = nativeOnly
  [<IsConst>] static member play_arrow: IconData = nativeOnly
  [<IsConst>] static member play_arrow_sharp: IconData = nativeOnly
  [<IsConst>] static member play_arrow_rounded: IconData = nativeOnly
  [<IsConst>] static member play_arrow_outlined: IconData = nativeOnly
  [<IsConst>] static member play_circle: IconData = nativeOnly
  [<IsConst>] static member play_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member play_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member play_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member play_circle_fill: IconData = nativeOnly
  [<IsConst>] static member play_circle_fill_sharp: IconData = nativeOnly
  [<IsConst>] static member play_circle_fill_rounded: IconData = nativeOnly
  [<IsConst>] static member play_circle_fill_outlined: IconData = nativeOnly
  [<IsConst>] static member play_circle_filled: IconData = nativeOnly
  [<IsConst>] static member play_circle_filled_sharp: IconData = nativeOnly
  [<IsConst>] static member play_circle_filled_rounded: IconData = nativeOnly
  [<IsConst>] static member play_circle_filled_outlined: IconData = nativeOnly
  [<IsConst>] static member play_circle_outline: IconData = nativeOnly
  [<IsConst>] static member play_circle_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member play_circle_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member play_circle_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member play_disabled: IconData = nativeOnly
  [<IsConst>] static member play_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member play_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member play_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member play_for_work: IconData = nativeOnly
  [<IsConst>] static member play_for_work_sharp: IconData = nativeOnly
  [<IsConst>] static member play_for_work_rounded: IconData = nativeOnly
  [<IsConst>] static member play_for_work_outlined: IconData = nativeOnly
  [<IsConst>] static member play_lesson: IconData = nativeOnly
  [<IsConst>] static member play_lesson_sharp: IconData = nativeOnly
  [<IsConst>] static member play_lesson_rounded: IconData = nativeOnly
  [<IsConst>] static member play_lesson_outlined: IconData = nativeOnly
  [<IsConst>] static member playlist_add: IconData = nativeOnly
  [<IsConst>] static member playlist_add_sharp: IconData = nativeOnly
  [<IsConst>] static member playlist_add_rounded: IconData = nativeOnly
  [<IsConst>] static member playlist_add_outlined: IconData = nativeOnly
  [<IsConst>] static member playlist_add_check: IconData = nativeOnly
  [<IsConst>] static member playlist_add_check_sharp: IconData = nativeOnly
  [<IsConst>] static member playlist_add_check_rounded: IconData = nativeOnly
  [<IsConst>] static member playlist_add_check_outlined: IconData = nativeOnly
  [<IsConst>] static member playlist_add_check_circle: IconData = nativeOnly
  [<IsConst>] static member playlist_add_check_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member playlist_add_check_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member playlist_add_check_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member playlist_add_circle: IconData = nativeOnly
  [<IsConst>] static member playlist_add_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member playlist_add_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member playlist_add_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member playlist_play: IconData = nativeOnly
  [<IsConst>] static member playlist_play_sharp: IconData = nativeOnly
  [<IsConst>] static member playlist_play_rounded: IconData = nativeOnly
  [<IsConst>] static member playlist_play_outlined: IconData = nativeOnly
  [<IsConst>] static member playlist_remove: IconData = nativeOnly
  [<IsConst>] static member playlist_remove_sharp: IconData = nativeOnly
  [<IsConst>] static member playlist_remove_rounded: IconData = nativeOnly
  [<IsConst>] static member playlist_remove_outlined: IconData = nativeOnly
  [<IsConst>] static member plumbing: IconData = nativeOnly
  [<IsConst>] static member plumbing_sharp: IconData = nativeOnly
  [<IsConst>] static member plumbing_rounded: IconData = nativeOnly
  [<IsConst>] static member plumbing_outlined: IconData = nativeOnly
  [<IsConst>] static member plus_one: IconData = nativeOnly
  [<IsConst>] static member plus_one_sharp: IconData = nativeOnly
  [<IsConst>] static member plus_one_rounded: IconData = nativeOnly
  [<IsConst>] static member plus_one_outlined: IconData = nativeOnly
  [<IsConst>] static member podcasts: IconData = nativeOnly
  [<IsConst>] static member podcasts_sharp: IconData = nativeOnly
  [<IsConst>] static member podcasts_rounded: IconData = nativeOnly
  [<IsConst>] static member podcasts_outlined: IconData = nativeOnly
  [<IsConst>] static member point_of_sale: IconData = nativeOnly
  [<IsConst>] static member point_of_sale_sharp: IconData = nativeOnly
  [<IsConst>] static member point_of_sale_rounded: IconData = nativeOnly
  [<IsConst>] static member point_of_sale_outlined: IconData = nativeOnly
  [<IsConst>] static member policy: IconData = nativeOnly
  [<IsConst>] static member policy_sharp: IconData = nativeOnly
  [<IsConst>] static member policy_rounded: IconData = nativeOnly
  [<IsConst>] static member policy_outlined: IconData = nativeOnly
  [<IsConst>] static member poll: IconData = nativeOnly
  [<IsConst>] static member poll_sharp: IconData = nativeOnly
  [<IsConst>] static member poll_rounded: IconData = nativeOnly
  [<IsConst>] static member poll_outlined: IconData = nativeOnly
  [<IsConst>] static member polyline: IconData = nativeOnly
  [<IsConst>] static member polyline_sharp: IconData = nativeOnly
  [<IsConst>] static member polyline_rounded: IconData = nativeOnly
  [<IsConst>] static member polyline_outlined: IconData = nativeOnly
  [<IsConst>] static member polymer: IconData = nativeOnly
  [<IsConst>] static member polymer_sharp: IconData = nativeOnly
  [<IsConst>] static member polymer_rounded: IconData = nativeOnly
  [<IsConst>] static member polymer_outlined: IconData = nativeOnly
  [<IsConst>] static member pool: IconData = nativeOnly
  [<IsConst>] static member pool_sharp: IconData = nativeOnly
  [<IsConst>] static member pool_rounded: IconData = nativeOnly
  [<IsConst>] static member pool_outlined: IconData = nativeOnly
  [<IsConst>] static member portable_wifi_off: IconData = nativeOnly
  [<IsConst>] static member portable_wifi_off_sharp: IconData = nativeOnly
  [<IsConst>] static member portable_wifi_off_rounded: IconData = nativeOnly
  [<IsConst>] static member portable_wifi_off_outlined: IconData = nativeOnly
  [<IsConst>] static member portrait: IconData = nativeOnly
  [<IsConst>] static member portrait_sharp: IconData = nativeOnly
  [<IsConst>] static member portrait_rounded: IconData = nativeOnly
  [<IsConst>] static member portrait_outlined: IconData = nativeOnly
  [<IsConst>] static member post_add: IconData = nativeOnly
  [<IsConst>] static member post_add_sharp: IconData = nativeOnly
  [<IsConst>] static member post_add_rounded: IconData = nativeOnly
  [<IsConst>] static member post_add_outlined: IconData = nativeOnly
  [<IsConst>] static member power: IconData = nativeOnly
  [<IsConst>] static member power_sharp: IconData = nativeOnly
  [<IsConst>] static member power_rounded: IconData = nativeOnly
  [<IsConst>] static member power_outlined: IconData = nativeOnly
  [<IsConst>] static member power_input: IconData = nativeOnly
  [<IsConst>] static member power_input_sharp: IconData = nativeOnly
  [<IsConst>] static member power_input_rounded: IconData = nativeOnly
  [<IsConst>] static member power_input_outlined: IconData = nativeOnly
  [<IsConst>] static member power_off: IconData = nativeOnly
  [<IsConst>] static member power_off_sharp: IconData = nativeOnly
  [<IsConst>] static member power_off_rounded: IconData = nativeOnly
  [<IsConst>] static member power_off_outlined: IconData = nativeOnly
  [<IsConst>] static member power_settings_new: IconData = nativeOnly
  [<IsConst>] static member power_settings_new_sharp: IconData = nativeOnly
  [<IsConst>] static member power_settings_new_rounded: IconData = nativeOnly
  [<IsConst>] static member power_settings_new_outlined: IconData = nativeOnly
  [<IsConst>] static member precision_manufacturing: IconData = nativeOnly
  [<IsConst>] static member precision_manufacturing_sharp: IconData = nativeOnly
  [<IsConst>] static member precision_manufacturing_rounded: IconData = nativeOnly
  [<IsConst>] static member precision_manufacturing_outlined: IconData = nativeOnly
  [<IsConst>] static member pregnant_woman: IconData = nativeOnly
  [<IsConst>] static member pregnant_woman_sharp: IconData = nativeOnly
  [<IsConst>] static member pregnant_woman_rounded: IconData = nativeOnly
  [<IsConst>] static member pregnant_woman_outlined: IconData = nativeOnly
  [<IsConst>] static member present_to_all: IconData = nativeOnly
  [<IsConst>] static member present_to_all_sharp: IconData = nativeOnly
  [<IsConst>] static member present_to_all_rounded: IconData = nativeOnly
  [<IsConst>] static member present_to_all_outlined: IconData = nativeOnly
  [<IsConst>] static member preview: IconData = nativeOnly
  [<IsConst>] static member preview_sharp: IconData = nativeOnly
  [<IsConst>] static member preview_rounded: IconData = nativeOnly
  [<IsConst>] static member preview_outlined: IconData = nativeOnly
  [<IsConst>] static member price_change: IconData = nativeOnly
  [<IsConst>] static member price_change_sharp: IconData = nativeOnly
  [<IsConst>] static member price_change_rounded: IconData = nativeOnly
  [<IsConst>] static member price_change_outlined: IconData = nativeOnly
  [<IsConst>] static member price_check: IconData = nativeOnly
  [<IsConst>] static member price_check_sharp: IconData = nativeOnly
  [<IsConst>] static member price_check_rounded: IconData = nativeOnly
  [<IsConst>] static member price_check_outlined: IconData = nativeOnly
  [<IsConst>] static member print: IconData = nativeOnly
  [<IsConst>] static member print_sharp: IconData = nativeOnly
  [<IsConst>] static member print_rounded: IconData = nativeOnly
  [<IsConst>] static member print_outlined: IconData = nativeOnly
  [<IsConst>] static member print_disabled: IconData = nativeOnly
  [<IsConst>] static member print_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member print_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member print_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member priority_high: IconData = nativeOnly
  [<IsConst>] static member priority_high_sharp: IconData = nativeOnly
  [<IsConst>] static member priority_high_rounded: IconData = nativeOnly
  [<IsConst>] static member priority_high_outlined: IconData = nativeOnly
  [<IsConst>] static member privacy_tip: IconData = nativeOnly
  [<IsConst>] static member privacy_tip_sharp: IconData = nativeOnly
  [<IsConst>] static member privacy_tip_rounded: IconData = nativeOnly
  [<IsConst>] static member privacy_tip_outlined: IconData = nativeOnly
  [<IsConst>] static member private_connectivity: IconData = nativeOnly
  [<IsConst>] static member private_connectivity_sharp: IconData = nativeOnly
  [<IsConst>] static member private_connectivity_rounded: IconData = nativeOnly
  [<IsConst>] static member private_connectivity_outlined: IconData = nativeOnly
  [<IsConst>] static member production_quantity_limits: IconData = nativeOnly
  [<IsConst>] static member production_quantity_limits_sharp: IconData = nativeOnly
  [<IsConst>] static member production_quantity_limits_rounded: IconData = nativeOnly
  [<IsConst>] static member production_quantity_limits_outlined: IconData = nativeOnly
  [<IsConst>] static member propane: IconData = nativeOnly
  [<IsConst>] static member propane_sharp: IconData = nativeOnly
  [<IsConst>] static member propane_rounded: IconData = nativeOnly
  [<IsConst>] static member propane_outlined: IconData = nativeOnly
  [<IsConst>] static member propane_tank: IconData = nativeOnly
  [<IsConst>] static member propane_tank_sharp: IconData = nativeOnly
  [<IsConst>] static member propane_tank_rounded: IconData = nativeOnly
  [<IsConst>] static member propane_tank_outlined: IconData = nativeOnly
  [<IsConst>] static member psychology: IconData = nativeOnly
  [<IsConst>] static member psychology_sharp: IconData = nativeOnly
  [<IsConst>] static member psychology_rounded: IconData = nativeOnly
  [<IsConst>] static member psychology_outlined: IconData = nativeOnly
  [<IsConst>] static member ``public``: IconData = nativeOnly
  [<IsConst>] static member public_sharp: IconData = nativeOnly
  [<IsConst>] static member public_rounded: IconData = nativeOnly
  [<IsConst>] static member public_outlined: IconData = nativeOnly
  [<IsConst>] static member public_off: IconData = nativeOnly
  [<IsConst>] static member public_off_sharp: IconData = nativeOnly
  [<IsConst>] static member public_off_rounded: IconData = nativeOnly
  [<IsConst>] static member public_off_outlined: IconData = nativeOnly
  [<IsConst>] static member publish: IconData = nativeOnly
  [<IsConst>] static member publish_sharp: IconData = nativeOnly
  [<IsConst>] static member publish_rounded: IconData = nativeOnly
  [<IsConst>] static member publish_outlined: IconData = nativeOnly
  [<IsConst>] static member published_with_changes: IconData = nativeOnly
  [<IsConst>] static member published_with_changes_sharp: IconData = nativeOnly
  [<IsConst>] static member published_with_changes_rounded: IconData = nativeOnly
  [<IsConst>] static member published_with_changes_outlined: IconData = nativeOnly
  [<IsConst>] static member punch_clock: IconData = nativeOnly
  [<IsConst>] static member punch_clock_sharp: IconData = nativeOnly
  [<IsConst>] static member punch_clock_rounded: IconData = nativeOnly
  [<IsConst>] static member punch_clock_outlined: IconData = nativeOnly
  [<IsConst>] static member push_pin: IconData = nativeOnly
  [<IsConst>] static member push_pin_sharp: IconData = nativeOnly
  [<IsConst>] static member push_pin_rounded: IconData = nativeOnly
  [<IsConst>] static member push_pin_outlined: IconData = nativeOnly
  [<IsConst>] static member qr_code: IconData = nativeOnly
  [<IsConst>] static member qr_code_sharp: IconData = nativeOnly
  [<IsConst>] static member qr_code_rounded: IconData = nativeOnly
  [<IsConst>] static member qr_code_outlined: IconData = nativeOnly
  [<IsConst>] static member qr_code_2: IconData = nativeOnly
  [<IsConst>] static member qr_code_2_sharp: IconData = nativeOnly
  [<IsConst>] static member qr_code_2_rounded: IconData = nativeOnly
  [<IsConst>] static member qr_code_2_outlined: IconData = nativeOnly
  [<IsConst>] static member qr_code_scanner: IconData = nativeOnly
  [<IsConst>] static member qr_code_scanner_sharp: IconData = nativeOnly
  [<IsConst>] static member qr_code_scanner_rounded: IconData = nativeOnly
  [<IsConst>] static member qr_code_scanner_outlined: IconData = nativeOnly
  [<IsConst>] static member query_builder: IconData = nativeOnly
  [<IsConst>] static member query_builder_sharp: IconData = nativeOnly
  [<IsConst>] static member query_builder_rounded: IconData = nativeOnly
  [<IsConst>] static member query_builder_outlined: IconData = nativeOnly
  [<IsConst>] static member query_stats: IconData = nativeOnly
  [<IsConst>] static member query_stats_sharp: IconData = nativeOnly
  [<IsConst>] static member query_stats_rounded: IconData = nativeOnly
  [<IsConst>] static member query_stats_outlined: IconData = nativeOnly
  [<IsConst>] static member question_answer: IconData = nativeOnly
  [<IsConst>] static member question_answer_sharp: IconData = nativeOnly
  [<IsConst>] static member question_answer_rounded: IconData = nativeOnly
  [<IsConst>] static member question_answer_outlined: IconData = nativeOnly
  [<IsConst>] static member question_mark: IconData = nativeOnly
  [<IsConst>] static member question_mark_sharp: IconData = nativeOnly
  [<IsConst>] static member question_mark_rounded: IconData = nativeOnly
  [<IsConst>] static member question_mark_outlined: IconData = nativeOnly
  [<IsConst>] static member queue: IconData = nativeOnly
  [<IsConst>] static member queue_sharp: IconData = nativeOnly
  [<IsConst>] static member queue_rounded: IconData = nativeOnly
  [<IsConst>] static member queue_outlined: IconData = nativeOnly
  [<IsConst>] static member queue_music: IconData = nativeOnly
  [<IsConst>] static member queue_music_sharp: IconData = nativeOnly
  [<IsConst>] static member queue_music_rounded: IconData = nativeOnly
  [<IsConst>] static member queue_music_outlined: IconData = nativeOnly
  [<IsConst>] static member queue_play_next: IconData = nativeOnly
  [<IsConst>] static member queue_play_next_sharp: IconData = nativeOnly
  [<IsConst>] static member queue_play_next_rounded: IconData = nativeOnly
  [<IsConst>] static member queue_play_next_outlined: IconData = nativeOnly
  [<IsConst>] static member quick_contacts_dialer: IconData = nativeOnly
  [<IsConst>] static member quick_contacts_dialer_sharp: IconData = nativeOnly
  [<IsConst>] static member quick_contacts_dialer_rounded: IconData = nativeOnly
  [<IsConst>] static member quick_contacts_dialer_outlined: IconData = nativeOnly
  [<IsConst>] static member quick_contacts_mail: IconData = nativeOnly
  [<IsConst>] static member quick_contacts_mail_sharp: IconData = nativeOnly
  [<IsConst>] static member quick_contacts_mail_rounded: IconData = nativeOnly
  [<IsConst>] static member quick_contacts_mail_outlined: IconData = nativeOnly
  [<IsConst>] static member quickreply: IconData = nativeOnly
  [<IsConst>] static member quickreply_sharp: IconData = nativeOnly
  [<IsConst>] static member quickreply_rounded: IconData = nativeOnly
  [<IsConst>] static member quickreply_outlined: IconData = nativeOnly
  [<IsConst>] static member quiz: IconData = nativeOnly
  [<IsConst>] static member quiz_sharp: IconData = nativeOnly
  [<IsConst>] static member quiz_rounded: IconData = nativeOnly
  [<IsConst>] static member quiz_outlined: IconData = nativeOnly
  [<IsConst>] static member quora: IconData = nativeOnly
  [<IsConst>] static member quora_sharp: IconData = nativeOnly
  [<IsConst>] static member quora_rounded: IconData = nativeOnly
  [<IsConst>] static member quora_outlined: IconData = nativeOnly
  [<IsConst>] static member r_mobiledata: IconData = nativeOnly
  [<IsConst>] static member r_mobiledata_sharp: IconData = nativeOnly
  [<IsConst>] static member r_mobiledata_rounded: IconData = nativeOnly
  [<IsConst>] static member r_mobiledata_outlined: IconData = nativeOnly
  [<IsConst>] static member radar: IconData = nativeOnly
  [<IsConst>] static member radar_sharp: IconData = nativeOnly
  [<IsConst>] static member radar_rounded: IconData = nativeOnly
  [<IsConst>] static member radar_outlined: IconData = nativeOnly
  [<IsConst>] static member radio: IconData = nativeOnly
  [<IsConst>] static member radio_sharp: IconData = nativeOnly
  [<IsConst>] static member radio_rounded: IconData = nativeOnly
  [<IsConst>] static member radio_outlined: IconData = nativeOnly
  [<IsConst>] static member radio_button_checked: IconData = nativeOnly
  [<IsConst>] static member radio_button_checked_sharp: IconData = nativeOnly
  [<IsConst>] static member radio_button_checked_rounded: IconData = nativeOnly
  [<IsConst>] static member radio_button_checked_outlined: IconData = nativeOnly
  [<IsConst>] static member radio_button_off: IconData = nativeOnly
  [<IsConst>] static member radio_button_off_sharp: IconData = nativeOnly
  [<IsConst>] static member radio_button_off_rounded: IconData = nativeOnly
  [<IsConst>] static member radio_button_off_outlined: IconData = nativeOnly
  [<IsConst>] static member radio_button_on: IconData = nativeOnly
  [<IsConst>] static member radio_button_on_sharp: IconData = nativeOnly
  [<IsConst>] static member radio_button_on_rounded: IconData = nativeOnly
  [<IsConst>] static member radio_button_on_outlined: IconData = nativeOnly
  [<IsConst>] static member radio_button_unchecked: IconData = nativeOnly
  [<IsConst>] static member radio_button_unchecked_sharp: IconData = nativeOnly
  [<IsConst>] static member radio_button_unchecked_rounded: IconData = nativeOnly
  [<IsConst>] static member radio_button_unchecked_outlined: IconData = nativeOnly
  [<IsConst>] static member railway_alert: IconData = nativeOnly
  [<IsConst>] static member railway_alert_sharp: IconData = nativeOnly
  [<IsConst>] static member railway_alert_rounded: IconData = nativeOnly
  [<IsConst>] static member railway_alert_outlined: IconData = nativeOnly
  [<IsConst>] static member ramen_dining: IconData = nativeOnly
  [<IsConst>] static member ramen_dining_sharp: IconData = nativeOnly
  [<IsConst>] static member ramen_dining_rounded: IconData = nativeOnly
  [<IsConst>] static member ramen_dining_outlined: IconData = nativeOnly
  [<IsConst>] static member ramp_left: IconData = nativeOnly
  [<IsConst>] static member ramp_left_sharp: IconData = nativeOnly
  [<IsConst>] static member ramp_left_rounded: IconData = nativeOnly
  [<IsConst>] static member ramp_left_outlined: IconData = nativeOnly
  [<IsConst>] static member ramp_right: IconData = nativeOnly
  [<IsConst>] static member ramp_right_sharp: IconData = nativeOnly
  [<IsConst>] static member ramp_right_rounded: IconData = nativeOnly
  [<IsConst>] static member ramp_right_outlined: IconData = nativeOnly
  [<IsConst>] static member rate_review: IconData = nativeOnly
  [<IsConst>] static member rate_review_sharp: IconData = nativeOnly
  [<IsConst>] static member rate_review_rounded: IconData = nativeOnly
  [<IsConst>] static member rate_review_outlined: IconData = nativeOnly
  [<IsConst>] static member raw_off: IconData = nativeOnly
  [<IsConst>] static member raw_off_sharp: IconData = nativeOnly
  [<IsConst>] static member raw_off_rounded: IconData = nativeOnly
  [<IsConst>] static member raw_off_outlined: IconData = nativeOnly
  [<IsConst>] static member raw_on: IconData = nativeOnly
  [<IsConst>] static member raw_on_sharp: IconData = nativeOnly
  [<IsConst>] static member raw_on_rounded: IconData = nativeOnly
  [<IsConst>] static member raw_on_outlined: IconData = nativeOnly
  [<IsConst>] static member read_more: IconData = nativeOnly
  [<IsConst>] static member read_more_sharp: IconData = nativeOnly
  [<IsConst>] static member read_more_rounded: IconData = nativeOnly
  [<IsConst>] static member read_more_outlined: IconData = nativeOnly
  [<IsConst>] static member real_estate_agent: IconData = nativeOnly
  [<IsConst>] static member real_estate_agent_sharp: IconData = nativeOnly
  [<IsConst>] static member real_estate_agent_rounded: IconData = nativeOnly
  [<IsConst>] static member real_estate_agent_outlined: IconData = nativeOnly
  [<IsConst>] static member receipt: IconData = nativeOnly
  [<IsConst>] static member receipt_sharp: IconData = nativeOnly
  [<IsConst>] static member receipt_rounded: IconData = nativeOnly
  [<IsConst>] static member receipt_outlined: IconData = nativeOnly
  [<IsConst>] static member receipt_long: IconData = nativeOnly
  [<IsConst>] static member receipt_long_sharp: IconData = nativeOnly
  [<IsConst>] static member receipt_long_rounded: IconData = nativeOnly
  [<IsConst>] static member receipt_long_outlined: IconData = nativeOnly
  [<IsConst>] static member recent_actors: IconData = nativeOnly
  [<IsConst>] static member recent_actors_sharp: IconData = nativeOnly
  [<IsConst>] static member recent_actors_rounded: IconData = nativeOnly
  [<IsConst>] static member recent_actors_outlined: IconData = nativeOnly
  [<IsConst>] static member recommend: IconData = nativeOnly
  [<IsConst>] static member recommend_sharp: IconData = nativeOnly
  [<IsConst>] static member recommend_rounded: IconData = nativeOnly
  [<IsConst>] static member recommend_outlined: IconData = nativeOnly
  [<IsConst>] static member record_voice_over: IconData = nativeOnly
  [<IsConst>] static member record_voice_over_sharp: IconData = nativeOnly
  [<IsConst>] static member record_voice_over_rounded: IconData = nativeOnly
  [<IsConst>] static member record_voice_over_outlined: IconData = nativeOnly
  [<IsConst>] static member rectangle: IconData = nativeOnly
  [<IsConst>] static member rectangle_sharp: IconData = nativeOnly
  [<IsConst>] static member rectangle_rounded: IconData = nativeOnly
  [<IsConst>] static member rectangle_outlined: IconData = nativeOnly
  [<IsConst>] static member recycling: IconData = nativeOnly
  [<IsConst>] static member recycling_sharp: IconData = nativeOnly
  [<IsConst>] static member recycling_rounded: IconData = nativeOnly
  [<IsConst>] static member recycling_outlined: IconData = nativeOnly
  [<IsConst>] static member reddit: IconData = nativeOnly
  [<IsConst>] static member reddit_sharp: IconData = nativeOnly
  [<IsConst>] static member reddit_rounded: IconData = nativeOnly
  [<IsConst>] static member reddit_outlined: IconData = nativeOnly
  [<IsConst>] static member redeem: IconData = nativeOnly
  [<IsConst>] static member redeem_sharp: IconData = nativeOnly
  [<IsConst>] static member redeem_rounded: IconData = nativeOnly
  [<IsConst>] static member redeem_outlined: IconData = nativeOnly
  [<IsConst>] static member redo: IconData = nativeOnly
  [<IsConst>] static member redo_sharp: IconData = nativeOnly
  [<IsConst>] static member redo_rounded: IconData = nativeOnly
  [<IsConst>] static member redo_outlined: IconData = nativeOnly
  [<IsConst>] static member reduce_capacity: IconData = nativeOnly
  [<IsConst>] static member reduce_capacity_sharp: IconData = nativeOnly
  [<IsConst>] static member reduce_capacity_rounded: IconData = nativeOnly
  [<IsConst>] static member reduce_capacity_outlined: IconData = nativeOnly
  [<IsConst>] static member refresh: IconData = nativeOnly
  [<IsConst>] static member refresh_sharp: IconData = nativeOnly
  [<IsConst>] static member refresh_rounded: IconData = nativeOnly
  [<IsConst>] static member refresh_outlined: IconData = nativeOnly
  [<IsConst>] static member remember_me: IconData = nativeOnly
  [<IsConst>] static member remember_me_sharp: IconData = nativeOnly
  [<IsConst>] static member remember_me_rounded: IconData = nativeOnly
  [<IsConst>] static member remember_me_outlined: IconData = nativeOnly
  [<IsConst>] static member remove: IconData = nativeOnly
  [<IsConst>] static member remove_sharp: IconData = nativeOnly
  [<IsConst>] static member remove_rounded: IconData = nativeOnly
  [<IsConst>] static member remove_outlined: IconData = nativeOnly
  [<IsConst>] static member remove_circle: IconData = nativeOnly
  [<IsConst>] static member remove_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member remove_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member remove_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member remove_circle_outline: IconData = nativeOnly
  [<IsConst>] static member remove_circle_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member remove_circle_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member remove_circle_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member remove_done: IconData = nativeOnly
  [<IsConst>] static member remove_done_sharp: IconData = nativeOnly
  [<IsConst>] static member remove_done_rounded: IconData = nativeOnly
  [<IsConst>] static member remove_done_outlined: IconData = nativeOnly
  [<IsConst>] static member remove_from_queue: IconData = nativeOnly
  [<IsConst>] static member remove_from_queue_sharp: IconData = nativeOnly
  [<IsConst>] static member remove_from_queue_rounded: IconData = nativeOnly
  [<IsConst>] static member remove_from_queue_outlined: IconData = nativeOnly
  [<IsConst>] static member remove_moderator: IconData = nativeOnly
  [<IsConst>] static member remove_moderator_sharp: IconData = nativeOnly
  [<IsConst>] static member remove_moderator_rounded: IconData = nativeOnly
  [<IsConst>] static member remove_moderator_outlined: IconData = nativeOnly
  [<IsConst>] static member remove_red_eye: IconData = nativeOnly
  [<IsConst>] static member remove_red_eye_sharp: IconData = nativeOnly
  [<IsConst>] static member remove_red_eye_rounded: IconData = nativeOnly
  [<IsConst>] static member remove_red_eye_outlined: IconData = nativeOnly
  [<IsConst>] static member remove_road: IconData = nativeOnly
  [<IsConst>] static member remove_road_sharp: IconData = nativeOnly
  [<IsConst>] static member remove_road_rounded: IconData = nativeOnly
  [<IsConst>] static member remove_road_outlined: IconData = nativeOnly
  [<IsConst>] static member remove_shopping_cart: IconData = nativeOnly
  [<IsConst>] static member remove_shopping_cart_sharp: IconData = nativeOnly
  [<IsConst>] static member remove_shopping_cart_rounded: IconData = nativeOnly
  [<IsConst>] static member remove_shopping_cart_outlined: IconData = nativeOnly
  [<IsConst>] static member reorder: IconData = nativeOnly
  [<IsConst>] static member reorder_sharp: IconData = nativeOnly
  [<IsConst>] static member reorder_rounded: IconData = nativeOnly
  [<IsConst>] static member reorder_outlined: IconData = nativeOnly
  [<IsConst>] static member repeat: IconData = nativeOnly
  [<IsConst>] static member repeat_sharp: IconData = nativeOnly
  [<IsConst>] static member repeat_rounded: IconData = nativeOnly
  [<IsConst>] static member repeat_outlined: IconData = nativeOnly
  [<IsConst>] static member repeat_on: IconData = nativeOnly
  [<IsConst>] static member repeat_on_sharp: IconData = nativeOnly
  [<IsConst>] static member repeat_on_rounded: IconData = nativeOnly
  [<IsConst>] static member repeat_on_outlined: IconData = nativeOnly
  [<IsConst>] static member repeat_one: IconData = nativeOnly
  [<IsConst>] static member repeat_one_sharp: IconData = nativeOnly
  [<IsConst>] static member repeat_one_rounded: IconData = nativeOnly
  [<IsConst>] static member repeat_one_outlined: IconData = nativeOnly
  [<IsConst>] static member repeat_one_on: IconData = nativeOnly
  [<IsConst>] static member repeat_one_on_sharp: IconData = nativeOnly
  [<IsConst>] static member repeat_one_on_rounded: IconData = nativeOnly
  [<IsConst>] static member repeat_one_on_outlined: IconData = nativeOnly
  [<IsConst>] static member replay: IconData = nativeOnly
  [<IsConst>] static member replay_sharp: IconData = nativeOnly
  [<IsConst>] static member replay_rounded: IconData = nativeOnly
  [<IsConst>] static member replay_outlined: IconData = nativeOnly
  [<IsConst>] static member replay_10: IconData = nativeOnly
  [<IsConst>] static member replay_10_sharp: IconData = nativeOnly
  [<IsConst>] static member replay_10_rounded: IconData = nativeOnly
  [<IsConst>] static member replay_10_outlined: IconData = nativeOnly
  [<IsConst>] static member replay_30: IconData = nativeOnly
  [<IsConst>] static member replay_30_sharp: IconData = nativeOnly
  [<IsConst>] static member replay_30_rounded: IconData = nativeOnly
  [<IsConst>] static member replay_30_outlined: IconData = nativeOnly
  [<IsConst>] static member replay_5: IconData = nativeOnly
  [<IsConst>] static member replay_5_sharp: IconData = nativeOnly
  [<IsConst>] static member replay_5_rounded: IconData = nativeOnly
  [<IsConst>] static member replay_5_outlined: IconData = nativeOnly
  [<IsConst>] static member replay_circle_filled: IconData = nativeOnly
  [<IsConst>] static member replay_circle_filled_sharp: IconData = nativeOnly
  [<IsConst>] static member replay_circle_filled_rounded: IconData = nativeOnly
  [<IsConst>] static member replay_circle_filled_outlined: IconData = nativeOnly
  [<IsConst>] static member reply: IconData = nativeOnly
  [<IsConst>] static member reply_sharp: IconData = nativeOnly
  [<IsConst>] static member reply_rounded: IconData = nativeOnly
  [<IsConst>] static member reply_outlined: IconData = nativeOnly
  [<IsConst>] static member reply_all: IconData = nativeOnly
  [<IsConst>] static member reply_all_sharp: IconData = nativeOnly
  [<IsConst>] static member reply_all_rounded: IconData = nativeOnly
  [<IsConst>] static member reply_all_outlined: IconData = nativeOnly
  [<IsConst>] static member report: IconData = nativeOnly
  [<IsConst>] static member report_sharp: IconData = nativeOnly
  [<IsConst>] static member report_rounded: IconData = nativeOnly
  [<IsConst>] static member report_outlined: IconData = nativeOnly
  [<IsConst>] static member report_gmailerrorred: IconData = nativeOnly
  [<IsConst>] static member report_gmailerrorred_sharp: IconData = nativeOnly
  [<IsConst>] static member report_gmailerrorred_rounded: IconData = nativeOnly
  [<IsConst>] static member report_gmailerrorred_outlined: IconData = nativeOnly
  [<IsConst>] static member report_off: IconData = nativeOnly
  [<IsConst>] static member report_off_sharp: IconData = nativeOnly
  [<IsConst>] static member report_off_rounded: IconData = nativeOnly
  [<IsConst>] static member report_off_outlined: IconData = nativeOnly
  [<IsConst>] static member report_problem: IconData = nativeOnly
  [<IsConst>] static member report_problem_sharp: IconData = nativeOnly
  [<IsConst>] static member report_problem_rounded: IconData = nativeOnly
  [<IsConst>] static member report_problem_outlined: IconData = nativeOnly
  [<IsConst>] static member request_page: IconData = nativeOnly
  [<IsConst>] static member request_page_sharp: IconData = nativeOnly
  [<IsConst>] static member request_page_rounded: IconData = nativeOnly
  [<IsConst>] static member request_page_outlined: IconData = nativeOnly
  [<IsConst>] static member request_quote: IconData = nativeOnly
  [<IsConst>] static member request_quote_sharp: IconData = nativeOnly
  [<IsConst>] static member request_quote_rounded: IconData = nativeOnly
  [<IsConst>] static member request_quote_outlined: IconData = nativeOnly
  [<IsConst>] static member reset_tv: IconData = nativeOnly
  [<IsConst>] static member reset_tv_sharp: IconData = nativeOnly
  [<IsConst>] static member reset_tv_rounded: IconData = nativeOnly
  [<IsConst>] static member reset_tv_outlined: IconData = nativeOnly
  [<IsConst>] static member restart_alt: IconData = nativeOnly
  [<IsConst>] static member restart_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member restart_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member restart_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member restaurant: IconData = nativeOnly
  [<IsConst>] static member restaurant_sharp: IconData = nativeOnly
  [<IsConst>] static member restaurant_rounded: IconData = nativeOnly
  [<IsConst>] static member restaurant_outlined: IconData = nativeOnly
  [<IsConst>] static member restaurant_menu: IconData = nativeOnly
  [<IsConst>] static member restaurant_menu_sharp: IconData = nativeOnly
  [<IsConst>] static member restaurant_menu_rounded: IconData = nativeOnly
  [<IsConst>] static member restaurant_menu_outlined: IconData = nativeOnly
  [<IsConst>] static member restore: IconData = nativeOnly
  [<IsConst>] static member restore_sharp: IconData = nativeOnly
  [<IsConst>] static member restore_rounded: IconData = nativeOnly
  [<IsConst>] static member restore_outlined: IconData = nativeOnly
  [<IsConst>] static member restore_from_trash: IconData = nativeOnly
  [<IsConst>] static member restore_from_trash_sharp: IconData = nativeOnly
  [<IsConst>] static member restore_from_trash_rounded: IconData = nativeOnly
  [<IsConst>] static member restore_from_trash_outlined: IconData = nativeOnly
  [<IsConst>] static member restore_page: IconData = nativeOnly
  [<IsConst>] static member restore_page_sharp: IconData = nativeOnly
  [<IsConst>] static member restore_page_rounded: IconData = nativeOnly
  [<IsConst>] static member restore_page_outlined: IconData = nativeOnly
  [<IsConst>] static member reviews: IconData = nativeOnly
  [<IsConst>] static member reviews_sharp: IconData = nativeOnly
  [<IsConst>] static member reviews_rounded: IconData = nativeOnly
  [<IsConst>] static member reviews_outlined: IconData = nativeOnly
  [<IsConst>] static member rice_bowl: IconData = nativeOnly
  [<IsConst>] static member rice_bowl_sharp: IconData = nativeOnly
  [<IsConst>] static member rice_bowl_rounded: IconData = nativeOnly
  [<IsConst>] static member rice_bowl_outlined: IconData = nativeOnly
  [<IsConst>] static member ring_volume: IconData = nativeOnly
  [<IsConst>] static member ring_volume_sharp: IconData = nativeOnly
  [<IsConst>] static member ring_volume_rounded: IconData = nativeOnly
  [<IsConst>] static member ring_volume_outlined: IconData = nativeOnly
  [<IsConst>] static member rocket: IconData = nativeOnly
  [<IsConst>] static member rocket_sharp: IconData = nativeOnly
  [<IsConst>] static member rocket_rounded: IconData = nativeOnly
  [<IsConst>] static member rocket_outlined: IconData = nativeOnly
  [<IsConst>] static member rocket_launch: IconData = nativeOnly
  [<IsConst>] static member rocket_launch_sharp: IconData = nativeOnly
  [<IsConst>] static member rocket_launch_rounded: IconData = nativeOnly
  [<IsConst>] static member rocket_launch_outlined: IconData = nativeOnly
  [<IsConst>] static member roller_shades: IconData = nativeOnly
  [<IsConst>] static member roller_shades_sharp: IconData = nativeOnly
  [<IsConst>] static member roller_shades_rounded: IconData = nativeOnly
  [<IsConst>] static member roller_shades_outlined: IconData = nativeOnly
  [<IsConst>] static member roller_shades_closed: IconData = nativeOnly
  [<IsConst>] static member roller_shades_closed_sharp: IconData = nativeOnly
  [<IsConst>] static member roller_shades_closed_rounded: IconData = nativeOnly
  [<IsConst>] static member roller_shades_closed_outlined: IconData = nativeOnly
  [<IsConst>] static member roller_skating: IconData = nativeOnly
  [<IsConst>] static member roller_skating_sharp: IconData = nativeOnly
  [<IsConst>] static member roller_skating_rounded: IconData = nativeOnly
  [<IsConst>] static member roller_skating_outlined: IconData = nativeOnly
  [<IsConst>] static member roofing: IconData = nativeOnly
  [<IsConst>] static member roofing_sharp: IconData = nativeOnly
  [<IsConst>] static member roofing_rounded: IconData = nativeOnly
  [<IsConst>] static member roofing_outlined: IconData = nativeOnly
  [<IsConst>] static member room: IconData = nativeOnly
  [<IsConst>] static member room_sharp: IconData = nativeOnly
  [<IsConst>] static member room_rounded: IconData = nativeOnly
  [<IsConst>] static member room_outlined: IconData = nativeOnly
  [<IsConst>] static member room_preferences: IconData = nativeOnly
  [<IsConst>] static member room_preferences_sharp: IconData = nativeOnly
  [<IsConst>] static member room_preferences_rounded: IconData = nativeOnly
  [<IsConst>] static member room_preferences_outlined: IconData = nativeOnly
  [<IsConst>] static member room_service: IconData = nativeOnly
  [<IsConst>] static member room_service_sharp: IconData = nativeOnly
  [<IsConst>] static member room_service_rounded: IconData = nativeOnly
  [<IsConst>] static member room_service_outlined: IconData = nativeOnly
  [<IsConst>] static member rotate_90_degrees_ccw: IconData = nativeOnly
  [<IsConst>] static member rotate_90_degrees_ccw_sharp: IconData = nativeOnly
  [<IsConst>] static member rotate_90_degrees_ccw_rounded: IconData = nativeOnly
  [<IsConst>] static member rotate_90_degrees_ccw_outlined: IconData = nativeOnly
  [<IsConst>] static member rotate_90_degrees_cw: IconData = nativeOnly
  [<IsConst>] static member rotate_90_degrees_cw_sharp: IconData = nativeOnly
  [<IsConst>] static member rotate_90_degrees_cw_rounded: IconData = nativeOnly
  [<IsConst>] static member rotate_90_degrees_cw_outlined: IconData = nativeOnly
  [<IsConst>] static member rotate_left: IconData = nativeOnly
  [<IsConst>] static member rotate_left_sharp: IconData = nativeOnly
  [<IsConst>] static member rotate_left_rounded: IconData = nativeOnly
  [<IsConst>] static member rotate_left_outlined: IconData = nativeOnly
  [<IsConst>] static member rotate_right: IconData = nativeOnly
  [<IsConst>] static member rotate_right_sharp: IconData = nativeOnly
  [<IsConst>] static member rotate_right_rounded: IconData = nativeOnly
  [<IsConst>] static member rotate_right_outlined: IconData = nativeOnly
  [<IsConst>] static member roundabout_left: IconData = nativeOnly
  [<IsConst>] static member roundabout_left_sharp: IconData = nativeOnly
  [<IsConst>] static member roundabout_left_rounded: IconData = nativeOnly
  [<IsConst>] static member roundabout_left_outlined: IconData = nativeOnly
  [<IsConst>] static member roundabout_right: IconData = nativeOnly
  [<IsConst>] static member roundabout_right_sharp: IconData = nativeOnly
  [<IsConst>] static member roundabout_right_rounded: IconData = nativeOnly
  [<IsConst>] static member roundabout_right_outlined: IconData = nativeOnly
  [<IsConst>] static member rounded_corner: IconData = nativeOnly
  [<IsConst>] static member rounded_corner_sharp: IconData = nativeOnly
  [<IsConst>] static member rounded_corner_rounded: IconData = nativeOnly
  [<IsConst>] static member rounded_corner_outlined: IconData = nativeOnly
  [<IsConst>] static member route: IconData = nativeOnly
  [<IsConst>] static member route_sharp: IconData = nativeOnly
  [<IsConst>] static member route_rounded: IconData = nativeOnly
  [<IsConst>] static member route_outlined: IconData = nativeOnly
  [<IsConst>] static member router: IconData = nativeOnly
  [<IsConst>] static member router_sharp: IconData = nativeOnly
  [<IsConst>] static member router_rounded: IconData = nativeOnly
  [<IsConst>] static member router_outlined: IconData = nativeOnly
  [<IsConst>] static member rowing: IconData = nativeOnly
  [<IsConst>] static member rowing_sharp: IconData = nativeOnly
  [<IsConst>] static member rowing_rounded: IconData = nativeOnly
  [<IsConst>] static member rowing_outlined: IconData = nativeOnly
  [<IsConst>] static member rss_feed: IconData = nativeOnly
  [<IsConst>] static member rss_feed_sharp: IconData = nativeOnly
  [<IsConst>] static member rss_feed_rounded: IconData = nativeOnly
  [<IsConst>] static member rss_feed_outlined: IconData = nativeOnly
  [<IsConst>] static member rsvp: IconData = nativeOnly
  [<IsConst>] static member rsvp_sharp: IconData = nativeOnly
  [<IsConst>] static member rsvp_rounded: IconData = nativeOnly
  [<IsConst>] static member rsvp_outlined: IconData = nativeOnly
  [<IsConst>] static member rtt: IconData = nativeOnly
  [<IsConst>] static member rtt_sharp: IconData = nativeOnly
  [<IsConst>] static member rtt_rounded: IconData = nativeOnly
  [<IsConst>] static member rtt_outlined: IconData = nativeOnly
  [<IsConst>] static member rule: IconData = nativeOnly
  [<IsConst>] static member rule_sharp: IconData = nativeOnly
  [<IsConst>] static member rule_rounded: IconData = nativeOnly
  [<IsConst>] static member rule_outlined: IconData = nativeOnly
  [<IsConst>] static member rule_folder: IconData = nativeOnly
  [<IsConst>] static member rule_folder_sharp: IconData = nativeOnly
  [<IsConst>] static member rule_folder_rounded: IconData = nativeOnly
  [<IsConst>] static member rule_folder_outlined: IconData = nativeOnly
  [<IsConst>] static member run_circle: IconData = nativeOnly
  [<IsConst>] static member run_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member run_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member run_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member running_with_errors: IconData = nativeOnly
  [<IsConst>] static member running_with_errors_sharp: IconData = nativeOnly
  [<IsConst>] static member running_with_errors_rounded: IconData = nativeOnly
  [<IsConst>] static member running_with_errors_outlined: IconData = nativeOnly
  [<IsConst>] static member rv_hookup: IconData = nativeOnly
  [<IsConst>] static member rv_hookup_sharp: IconData = nativeOnly
  [<IsConst>] static member rv_hookup_rounded: IconData = nativeOnly
  [<IsConst>] static member rv_hookup_outlined: IconData = nativeOnly
  [<IsConst>] static member safety_check: IconData = nativeOnly
  [<IsConst>] static member safety_check_sharp: IconData = nativeOnly
  [<IsConst>] static member safety_check_rounded: IconData = nativeOnly
  [<IsConst>] static member safety_check_outlined: IconData = nativeOnly
  [<IsConst>] static member safety_divider: IconData = nativeOnly
  [<IsConst>] static member safety_divider_sharp: IconData = nativeOnly
  [<IsConst>] static member safety_divider_rounded: IconData = nativeOnly
  [<IsConst>] static member safety_divider_outlined: IconData = nativeOnly
  [<IsConst>] static member sailing: IconData = nativeOnly
  [<IsConst>] static member sailing_sharp: IconData = nativeOnly
  [<IsConst>] static member sailing_rounded: IconData = nativeOnly
  [<IsConst>] static member sailing_outlined: IconData = nativeOnly
  [<IsConst>] static member sanitizer: IconData = nativeOnly
  [<IsConst>] static member sanitizer_sharp: IconData = nativeOnly
  [<IsConst>] static member sanitizer_rounded: IconData = nativeOnly
  [<IsConst>] static member sanitizer_outlined: IconData = nativeOnly
  [<IsConst>] static member satellite: IconData = nativeOnly
  [<IsConst>] static member satellite_sharp: IconData = nativeOnly
  [<IsConst>] static member satellite_rounded: IconData = nativeOnly
  [<IsConst>] static member satellite_outlined: IconData = nativeOnly
  [<IsConst>] static member satellite_alt: IconData = nativeOnly
  [<IsConst>] static member satellite_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member satellite_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member satellite_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member save: IconData = nativeOnly
  [<IsConst>] static member save_sharp: IconData = nativeOnly
  [<IsConst>] static member save_rounded: IconData = nativeOnly
  [<IsConst>] static member save_outlined: IconData = nativeOnly
  [<IsConst>] static member save_alt: IconData = nativeOnly
  [<IsConst>] static member save_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member save_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member save_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member save_as: IconData = nativeOnly
  [<IsConst>] static member save_as_sharp: IconData = nativeOnly
  [<IsConst>] static member save_as_rounded: IconData = nativeOnly
  [<IsConst>] static member save_as_outlined: IconData = nativeOnly
  [<IsConst>] static member saved_search: IconData = nativeOnly
  [<IsConst>] static member saved_search_sharp: IconData = nativeOnly
  [<IsConst>] static member saved_search_rounded: IconData = nativeOnly
  [<IsConst>] static member saved_search_outlined: IconData = nativeOnly
  [<IsConst>] static member savings: IconData = nativeOnly
  [<IsConst>] static member savings_sharp: IconData = nativeOnly
  [<IsConst>] static member savings_rounded: IconData = nativeOnly
  [<IsConst>] static member savings_outlined: IconData = nativeOnly
  [<IsConst>] static member scale: IconData = nativeOnly
  [<IsConst>] static member scale_sharp: IconData = nativeOnly
  [<IsConst>] static member scale_rounded: IconData = nativeOnly
  [<IsConst>] static member scale_outlined: IconData = nativeOnly
  [<IsConst>] static member scanner: IconData = nativeOnly
  [<IsConst>] static member scanner_sharp: IconData = nativeOnly
  [<IsConst>] static member scanner_rounded: IconData = nativeOnly
  [<IsConst>] static member scanner_outlined: IconData = nativeOnly
  [<IsConst>] static member scatter_plot: IconData = nativeOnly
  [<IsConst>] static member scatter_plot_sharp: IconData = nativeOnly
  [<IsConst>] static member scatter_plot_rounded: IconData = nativeOnly
  [<IsConst>] static member scatter_plot_outlined: IconData = nativeOnly
  [<IsConst>] static member schedule: IconData = nativeOnly
  [<IsConst>] static member schedule_sharp: IconData = nativeOnly
  [<IsConst>] static member schedule_rounded: IconData = nativeOnly
  [<IsConst>] static member schedule_outlined: IconData = nativeOnly
  [<IsConst>] static member schedule_send: IconData = nativeOnly
  [<IsConst>] static member schedule_send_sharp: IconData = nativeOnly
  [<IsConst>] static member schedule_send_rounded: IconData = nativeOnly
  [<IsConst>] static member schedule_send_outlined: IconData = nativeOnly
  [<IsConst>] static member schema: IconData = nativeOnly
  [<IsConst>] static member schema_sharp: IconData = nativeOnly
  [<IsConst>] static member schema_rounded: IconData = nativeOnly
  [<IsConst>] static member schema_outlined: IconData = nativeOnly
  [<IsConst>] static member school: IconData = nativeOnly
  [<IsConst>] static member school_sharp: IconData = nativeOnly
  [<IsConst>] static member school_rounded: IconData = nativeOnly
  [<IsConst>] static member school_outlined: IconData = nativeOnly
  [<IsConst>] static member science: IconData = nativeOnly
  [<IsConst>] static member science_sharp: IconData = nativeOnly
  [<IsConst>] static member science_rounded: IconData = nativeOnly
  [<IsConst>] static member science_outlined: IconData = nativeOnly
  [<IsConst>] static member score: IconData = nativeOnly
  [<IsConst>] static member score_sharp: IconData = nativeOnly
  [<IsConst>] static member score_rounded: IconData = nativeOnly
  [<IsConst>] static member score_outlined: IconData = nativeOnly
  [<IsConst>] static member scoreboard: IconData = nativeOnly
  [<IsConst>] static member scoreboard_sharp: IconData = nativeOnly
  [<IsConst>] static member scoreboard_rounded: IconData = nativeOnly
  [<IsConst>] static member scoreboard_outlined: IconData = nativeOnly
  [<IsConst>] static member screen_lock_landscape: IconData = nativeOnly
  [<IsConst>] static member screen_lock_landscape_sharp: IconData = nativeOnly
  [<IsConst>] static member screen_lock_landscape_rounded: IconData = nativeOnly
  [<IsConst>] static member screen_lock_landscape_outlined: IconData = nativeOnly
  [<IsConst>] static member screen_lock_portrait: IconData = nativeOnly
  [<IsConst>] static member screen_lock_portrait_sharp: IconData = nativeOnly
  [<IsConst>] static member screen_lock_portrait_rounded: IconData = nativeOnly
  [<IsConst>] static member screen_lock_portrait_outlined: IconData = nativeOnly
  [<IsConst>] static member screen_lock_rotation: IconData = nativeOnly
  [<IsConst>] static member screen_lock_rotation_sharp: IconData = nativeOnly
  [<IsConst>] static member screen_lock_rotation_rounded: IconData = nativeOnly
  [<IsConst>] static member screen_lock_rotation_outlined: IconData = nativeOnly
  [<IsConst>] static member screen_rotation: IconData = nativeOnly
  [<IsConst>] static member screen_rotation_sharp: IconData = nativeOnly
  [<IsConst>] static member screen_rotation_rounded: IconData = nativeOnly
  [<IsConst>] static member screen_rotation_outlined: IconData = nativeOnly
  [<IsConst>] static member screen_rotation_alt: IconData = nativeOnly
  [<IsConst>] static member screen_rotation_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member screen_rotation_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member screen_rotation_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member screen_search_desktop: IconData = nativeOnly
  [<IsConst>] static member screen_search_desktop_sharp: IconData = nativeOnly
  [<IsConst>] static member screen_search_desktop_rounded: IconData = nativeOnly
  [<IsConst>] static member screen_search_desktop_outlined: IconData = nativeOnly
  [<IsConst>] static member screen_share: IconData = nativeOnly
  [<IsConst>] static member screen_share_sharp: IconData = nativeOnly
  [<IsConst>] static member screen_share_rounded: IconData = nativeOnly
  [<IsConst>] static member screen_share_outlined: IconData = nativeOnly
  [<IsConst>] static member screenshot: IconData = nativeOnly
  [<IsConst>] static member screenshot_sharp: IconData = nativeOnly
  [<IsConst>] static member screenshot_rounded: IconData = nativeOnly
  [<IsConst>] static member screenshot_outlined: IconData = nativeOnly
  [<IsConst>] static member screenshot_monitor: IconData = nativeOnly
  [<IsConst>] static member screenshot_monitor_sharp: IconData = nativeOnly
  [<IsConst>] static member screenshot_monitor_rounded: IconData = nativeOnly
  [<IsConst>] static member screenshot_monitor_outlined: IconData = nativeOnly
  [<IsConst>] static member scuba_diving: IconData = nativeOnly
  [<IsConst>] static member scuba_diving_sharp: IconData = nativeOnly
  [<IsConst>] static member scuba_diving_rounded: IconData = nativeOnly
  [<IsConst>] static member scuba_diving_outlined: IconData = nativeOnly
  [<IsConst>] static member sd: IconData = nativeOnly
  [<IsConst>] static member sd_sharp: IconData = nativeOnly
  [<IsConst>] static member sd_rounded: IconData = nativeOnly
  [<IsConst>] static member sd_outlined: IconData = nativeOnly
  [<IsConst>] static member sd_card: IconData = nativeOnly
  [<IsConst>] static member sd_card_sharp: IconData = nativeOnly
  [<IsConst>] static member sd_card_rounded: IconData = nativeOnly
  [<IsConst>] static member sd_card_outlined: IconData = nativeOnly
  [<IsConst>] static member sd_card_alert: IconData = nativeOnly
  [<IsConst>] static member sd_card_alert_sharp: IconData = nativeOnly
  [<IsConst>] static member sd_card_alert_rounded: IconData = nativeOnly
  [<IsConst>] static member sd_card_alert_outlined: IconData = nativeOnly
  [<IsConst>] static member sd_storage: IconData = nativeOnly
  [<IsConst>] static member sd_storage_sharp: IconData = nativeOnly
  [<IsConst>] static member sd_storage_rounded: IconData = nativeOnly
  [<IsConst>] static member sd_storage_outlined: IconData = nativeOnly
  [<IsConst>] static member search: IconData = nativeOnly
  [<IsConst>] static member search_sharp: IconData = nativeOnly
  [<IsConst>] static member search_rounded: IconData = nativeOnly
  [<IsConst>] static member search_outlined: IconData = nativeOnly
  [<IsConst>] static member search_off: IconData = nativeOnly
  [<IsConst>] static member search_off_sharp: IconData = nativeOnly
  [<IsConst>] static member search_off_rounded: IconData = nativeOnly
  [<IsConst>] static member search_off_outlined: IconData = nativeOnly
  [<IsConst>] static member security: IconData = nativeOnly
  [<IsConst>] static member security_sharp: IconData = nativeOnly
  [<IsConst>] static member security_rounded: IconData = nativeOnly
  [<IsConst>] static member security_outlined: IconData = nativeOnly
  [<IsConst>] static member security_update: IconData = nativeOnly
  [<IsConst>] static member security_update_sharp: IconData = nativeOnly
  [<IsConst>] static member security_update_rounded: IconData = nativeOnly
  [<IsConst>] static member security_update_outlined: IconData = nativeOnly
  [<IsConst>] static member security_update_good: IconData = nativeOnly
  [<IsConst>] static member security_update_good_sharp: IconData = nativeOnly
  [<IsConst>] static member security_update_good_rounded: IconData = nativeOnly
  [<IsConst>] static member security_update_good_outlined: IconData = nativeOnly
  [<IsConst>] static member security_update_warning: IconData = nativeOnly
  [<IsConst>] static member security_update_warning_sharp: IconData = nativeOnly
  [<IsConst>] static member security_update_warning_rounded: IconData = nativeOnly
  [<IsConst>] static member security_update_warning_outlined: IconData = nativeOnly
  [<IsConst>] static member segment: IconData = nativeOnly
  [<IsConst>] static member segment_sharp: IconData = nativeOnly
  [<IsConst>] static member segment_rounded: IconData = nativeOnly
  [<IsConst>] static member segment_outlined: IconData = nativeOnly
  [<IsConst>] static member select_all: IconData = nativeOnly
  [<IsConst>] static member select_all_sharp: IconData = nativeOnly
  [<IsConst>] static member select_all_rounded: IconData = nativeOnly
  [<IsConst>] static member select_all_outlined: IconData = nativeOnly
  [<IsConst>] static member self_improvement: IconData = nativeOnly
  [<IsConst>] static member self_improvement_sharp: IconData = nativeOnly
  [<IsConst>] static member self_improvement_rounded: IconData = nativeOnly
  [<IsConst>] static member self_improvement_outlined: IconData = nativeOnly
  [<IsConst>] static member sell: IconData = nativeOnly
  [<IsConst>] static member sell_sharp: IconData = nativeOnly
  [<IsConst>] static member sell_rounded: IconData = nativeOnly
  [<IsConst>] static member sell_outlined: IconData = nativeOnly
  [<IsConst>] static member send: IconData = nativeOnly
  [<IsConst>] static member send_sharp: IconData = nativeOnly
  [<IsConst>] static member send_rounded: IconData = nativeOnly
  [<IsConst>] static member send_outlined: IconData = nativeOnly
  [<IsConst>] static member send_and_archive: IconData = nativeOnly
  [<IsConst>] static member send_and_archive_sharp: IconData = nativeOnly
  [<IsConst>] static member send_and_archive_rounded: IconData = nativeOnly
  [<IsConst>] static member send_and_archive_outlined: IconData = nativeOnly
  [<IsConst>] static member send_time_extension: IconData = nativeOnly
  [<IsConst>] static member send_time_extension_sharp: IconData = nativeOnly
  [<IsConst>] static member send_time_extension_rounded: IconData = nativeOnly
  [<IsConst>] static member send_time_extension_outlined: IconData = nativeOnly
  [<IsConst>] static member send_to_mobile: IconData = nativeOnly
  [<IsConst>] static member send_to_mobile_sharp: IconData = nativeOnly
  [<IsConst>] static member send_to_mobile_rounded: IconData = nativeOnly
  [<IsConst>] static member send_to_mobile_outlined: IconData = nativeOnly
  [<IsConst>] static member sensor_door: IconData = nativeOnly
  [<IsConst>] static member sensor_door_sharp: IconData = nativeOnly
  [<IsConst>] static member sensor_door_rounded: IconData = nativeOnly
  [<IsConst>] static member sensor_door_outlined: IconData = nativeOnly
  [<IsConst>] static member sensor_occupied: IconData = nativeOnly
  [<IsConst>] static member sensor_occupied_sharp: IconData = nativeOnly
  [<IsConst>] static member sensor_occupied_rounded: IconData = nativeOnly
  [<IsConst>] static member sensor_occupied_outlined: IconData = nativeOnly
  [<IsConst>] static member sensor_window: IconData = nativeOnly
  [<IsConst>] static member sensor_window_sharp: IconData = nativeOnly
  [<IsConst>] static member sensor_window_rounded: IconData = nativeOnly
  [<IsConst>] static member sensor_window_outlined: IconData = nativeOnly
  [<IsConst>] static member sensors: IconData = nativeOnly
  [<IsConst>] static member sensors_sharp: IconData = nativeOnly
  [<IsConst>] static member sensors_rounded: IconData = nativeOnly
  [<IsConst>] static member sensors_outlined: IconData = nativeOnly
  [<IsConst>] static member sensors_off: IconData = nativeOnly
  [<IsConst>] static member sensors_off_sharp: IconData = nativeOnly
  [<IsConst>] static member sensors_off_rounded: IconData = nativeOnly
  [<IsConst>] static member sensors_off_outlined: IconData = nativeOnly
  [<IsConst>] static member sentiment_dissatisfied: IconData = nativeOnly
  [<IsConst>] static member sentiment_dissatisfied_sharp: IconData = nativeOnly
  [<IsConst>] static member sentiment_dissatisfied_rounded: IconData = nativeOnly
  [<IsConst>] static member sentiment_dissatisfied_outlined: IconData = nativeOnly
  [<IsConst>] static member sentiment_neutral: IconData = nativeOnly
  [<IsConst>] static member sentiment_neutral_sharp: IconData = nativeOnly
  [<IsConst>] static member sentiment_neutral_rounded: IconData = nativeOnly
  [<IsConst>] static member sentiment_neutral_outlined: IconData = nativeOnly
  [<IsConst>] static member sentiment_satisfied: IconData = nativeOnly
  [<IsConst>] static member sentiment_satisfied_sharp: IconData = nativeOnly
  [<IsConst>] static member sentiment_satisfied_rounded: IconData = nativeOnly
  [<IsConst>] static member sentiment_satisfied_outlined: IconData = nativeOnly
  [<IsConst>] static member sentiment_satisfied_alt: IconData = nativeOnly
  [<IsConst>] static member sentiment_satisfied_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member sentiment_satisfied_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member sentiment_satisfied_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member sentiment_very_dissatisfied: IconData = nativeOnly
  [<IsConst>] static member sentiment_very_dissatisfied_sharp: IconData = nativeOnly
  [<IsConst>] static member sentiment_very_dissatisfied_rounded: IconData = nativeOnly
  [<IsConst>] static member sentiment_very_dissatisfied_outlined: IconData = nativeOnly
  [<IsConst>] static member sentiment_very_satisfied: IconData = nativeOnly
  [<IsConst>] static member sentiment_very_satisfied_sharp: IconData = nativeOnly
  [<IsConst>] static member sentiment_very_satisfied_rounded: IconData = nativeOnly
  [<IsConst>] static member sentiment_very_satisfied_outlined: IconData = nativeOnly
  [<IsConst>] static member set_meal: IconData = nativeOnly
  [<IsConst>] static member set_meal_sharp: IconData = nativeOnly
  [<IsConst>] static member set_meal_rounded: IconData = nativeOnly
  [<IsConst>] static member set_meal_outlined: IconData = nativeOnly
  [<IsConst>] static member settings: IconData = nativeOnly
  [<IsConst>] static member settings_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_accessibility: IconData = nativeOnly
  [<IsConst>] static member settings_accessibility_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_accessibility_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_accessibility_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_applications: IconData = nativeOnly
  [<IsConst>] static member settings_applications_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_applications_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_applications_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_backup_restore: IconData = nativeOnly
  [<IsConst>] static member settings_backup_restore_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_backup_restore_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_backup_restore_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_bluetooth: IconData = nativeOnly
  [<IsConst>] static member settings_bluetooth_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_bluetooth_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_bluetooth_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_brightness: IconData = nativeOnly
  [<IsConst>] static member settings_brightness_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_brightness_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_brightness_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_cell: IconData = nativeOnly
  [<IsConst>] static member settings_cell_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_cell_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_cell_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_display: IconData = nativeOnly
  [<IsConst>] static member settings_display_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_display_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_display_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_ethernet: IconData = nativeOnly
  [<IsConst>] static member settings_ethernet_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_ethernet_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_ethernet_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_input_antenna: IconData = nativeOnly
  [<IsConst>] static member settings_input_antenna_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_input_antenna_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_input_antenna_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_input_component: IconData = nativeOnly
  [<IsConst>] static member settings_input_component_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_input_component_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_input_component_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_input_composite: IconData = nativeOnly
  [<IsConst>] static member settings_input_composite_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_input_composite_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_input_composite_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_input_hdmi: IconData = nativeOnly
  [<IsConst>] static member settings_input_hdmi_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_input_hdmi_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_input_hdmi_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_input_svideo: IconData = nativeOnly
  [<IsConst>] static member settings_input_svideo_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_input_svideo_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_input_svideo_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_overscan: IconData = nativeOnly
  [<IsConst>] static member settings_overscan_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_overscan_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_overscan_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_phone: IconData = nativeOnly
  [<IsConst>] static member settings_phone_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_phone_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_phone_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_power: IconData = nativeOnly
  [<IsConst>] static member settings_power_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_power_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_power_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_remote: IconData = nativeOnly
  [<IsConst>] static member settings_remote_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_remote_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_remote_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_suggest: IconData = nativeOnly
  [<IsConst>] static member settings_suggest_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_suggest_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_suggest_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_system_daydream: IconData = nativeOnly
  [<IsConst>] static member settings_system_daydream_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_system_daydream_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_system_daydream_outlined: IconData = nativeOnly
  [<IsConst>] static member settings_voice: IconData = nativeOnly
  [<IsConst>] static member settings_voice_sharp: IconData = nativeOnly
  [<IsConst>] static member settings_voice_rounded: IconData = nativeOnly
  [<IsConst>] static member settings_voice_outlined: IconData = nativeOnly
  [<IsConst>] static member severe_cold: IconData = nativeOnly
  [<IsConst>] static member severe_cold_sharp: IconData = nativeOnly
  [<IsConst>] static member severe_cold_rounded: IconData = nativeOnly
  [<IsConst>] static member severe_cold_outlined: IconData = nativeOnly
  [<IsConst>] static member share: IconData = nativeOnly
  [<IsConst>] static member share_sharp: IconData = nativeOnly
  [<IsConst>] static member share_rounded: IconData = nativeOnly
  [<IsConst>] static member share_outlined: IconData = nativeOnly
  [<IsConst>] static member share_arrival_time: IconData = nativeOnly
  [<IsConst>] static member share_arrival_time_sharp: IconData = nativeOnly
  [<IsConst>] static member share_arrival_time_rounded: IconData = nativeOnly
  [<IsConst>] static member share_arrival_time_outlined: IconData = nativeOnly
  [<IsConst>] static member share_location: IconData = nativeOnly
  [<IsConst>] static member share_location_sharp: IconData = nativeOnly
  [<IsConst>] static member share_location_rounded: IconData = nativeOnly
  [<IsConst>] static member share_location_outlined: IconData = nativeOnly
  [<IsConst>] static member shield: IconData = nativeOnly
  [<IsConst>] static member shield_sharp: IconData = nativeOnly
  [<IsConst>] static member shield_rounded: IconData = nativeOnly
  [<IsConst>] static member shield_outlined: IconData = nativeOnly
  [<IsConst>] static member shield_moon: IconData = nativeOnly
  [<IsConst>] static member shield_moon_sharp: IconData = nativeOnly
  [<IsConst>] static member shield_moon_rounded: IconData = nativeOnly
  [<IsConst>] static member shield_moon_outlined: IconData = nativeOnly
  [<IsConst>] static member shop: IconData = nativeOnly
  [<IsConst>] static member shop_sharp: IconData = nativeOnly
  [<IsConst>] static member shop_rounded: IconData = nativeOnly
  [<IsConst>] static member shop_outlined: IconData = nativeOnly
  [<IsConst>] static member shop_2: IconData = nativeOnly
  [<IsConst>] static member shop_2_sharp: IconData = nativeOnly
  [<IsConst>] static member shop_2_rounded: IconData = nativeOnly
  [<IsConst>] static member shop_2_outlined: IconData = nativeOnly
  [<IsConst>] static member shop_two: IconData = nativeOnly
  [<IsConst>] static member shop_two_sharp: IconData = nativeOnly
  [<IsConst>] static member shop_two_rounded: IconData = nativeOnly
  [<IsConst>] static member shop_two_outlined: IconData = nativeOnly
  [<IsConst>] static member shopify: IconData = nativeOnly
  [<IsConst>] static member shopify_sharp: IconData = nativeOnly
  [<IsConst>] static member shopify_rounded: IconData = nativeOnly
  [<IsConst>] static member shopify_outlined: IconData = nativeOnly
  [<IsConst>] static member shopping_bag: IconData = nativeOnly
  [<IsConst>] static member shopping_bag_sharp: IconData = nativeOnly
  [<IsConst>] static member shopping_bag_rounded: IconData = nativeOnly
  [<IsConst>] static member shopping_bag_outlined: IconData = nativeOnly
  [<IsConst>] static member shopping_basket: IconData = nativeOnly
  [<IsConst>] static member shopping_basket_sharp: IconData = nativeOnly
  [<IsConst>] static member shopping_basket_rounded: IconData = nativeOnly
  [<IsConst>] static member shopping_basket_outlined: IconData = nativeOnly
  [<IsConst>] static member shopping_cart: IconData = nativeOnly
  [<IsConst>] static member shopping_cart_sharp: IconData = nativeOnly
  [<IsConst>] static member shopping_cart_rounded: IconData = nativeOnly
  [<IsConst>] static member shopping_cart_outlined: IconData = nativeOnly
  [<IsConst>] static member shopping_cart_checkout: IconData = nativeOnly
  [<IsConst>] static member shopping_cart_checkout_sharp: IconData = nativeOnly
  [<IsConst>] static member shopping_cart_checkout_rounded: IconData = nativeOnly
  [<IsConst>] static member shopping_cart_checkout_outlined: IconData = nativeOnly
  [<IsConst>] static member short_text: IconData = nativeOnly
  [<IsConst>] static member short_text_sharp: IconData = nativeOnly
  [<IsConst>] static member short_text_rounded: IconData = nativeOnly
  [<IsConst>] static member short_text_outlined: IconData = nativeOnly
  [<IsConst>] static member shortcut: IconData = nativeOnly
  [<IsConst>] static member shortcut_sharp: IconData = nativeOnly
  [<IsConst>] static member shortcut_rounded: IconData = nativeOnly
  [<IsConst>] static member shortcut_outlined: IconData = nativeOnly
  [<IsConst>] static member show_chart: IconData = nativeOnly
  [<IsConst>] static member show_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member show_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member show_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member shower: IconData = nativeOnly
  [<IsConst>] static member shower_sharp: IconData = nativeOnly
  [<IsConst>] static member shower_rounded: IconData = nativeOnly
  [<IsConst>] static member shower_outlined: IconData = nativeOnly
  [<IsConst>] static member shuffle: IconData = nativeOnly
  [<IsConst>] static member shuffle_sharp: IconData = nativeOnly
  [<IsConst>] static member shuffle_rounded: IconData = nativeOnly
  [<IsConst>] static member shuffle_outlined: IconData = nativeOnly
  [<IsConst>] static member shuffle_on: IconData = nativeOnly
  [<IsConst>] static member shuffle_on_sharp: IconData = nativeOnly
  [<IsConst>] static member shuffle_on_rounded: IconData = nativeOnly
  [<IsConst>] static member shuffle_on_outlined: IconData = nativeOnly
  [<IsConst>] static member shutter_speed: IconData = nativeOnly
  [<IsConst>] static member shutter_speed_sharp: IconData = nativeOnly
  [<IsConst>] static member shutter_speed_rounded: IconData = nativeOnly
  [<IsConst>] static member shutter_speed_outlined: IconData = nativeOnly
  [<IsConst>] static member sick: IconData = nativeOnly
  [<IsConst>] static member sick_sharp: IconData = nativeOnly
  [<IsConst>] static member sick_rounded: IconData = nativeOnly
  [<IsConst>] static member sick_outlined: IconData = nativeOnly
  [<IsConst>] static member sign_language: IconData = nativeOnly
  [<IsConst>] static member sign_language_sharp: IconData = nativeOnly
  [<IsConst>] static member sign_language_rounded: IconData = nativeOnly
  [<IsConst>] static member sign_language_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_0_bar: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_0_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_0_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_0_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_4_bar: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_4_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_4_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_4_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_alt: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_alt_1_bar: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_alt_1_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_alt_1_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_alt_1_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_alt_2_bar: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_alt_2_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_alt_2_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_alt_2_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_connected_no_internet_0_bar: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_connected_no_internet_0_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_connected_no_internet_0_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_connected_no_internet_0_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_connected_no_internet_4_bar: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_connected_no_internet_4_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_connected_no_internet_4_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_connected_no_internet_4_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_no_sim: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_no_sim_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_no_sim_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_no_sim_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_nodata: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_nodata_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_nodata_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_nodata_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_null: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_null_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_null_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_null_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_off: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_off_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_off_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_cellular_off_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_0_bar: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_0_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_0_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_0_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_4_bar: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_4_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_4_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_4_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_4_bar_lock: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_4_bar_lock_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_4_bar_lock_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_4_bar_lock_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_bad: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_bad_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_bad_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_bad_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_connected_no_internet_4: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_connected_no_internet_4_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_connected_no_internet_4_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_connected_no_internet_4_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_off: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_off_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_off_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_off_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_statusbar_4_bar: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_statusbar_4_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_statusbar_4_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_statusbar_4_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_statusbar_connected_no_internet_4: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_statusbar_connected_no_internet_4_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_statusbar_connected_no_internet_4_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_statusbar_connected_no_internet_4_outlined: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_statusbar_null: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_statusbar_null_sharp: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_statusbar_null_rounded: IconData = nativeOnly
  [<IsConst>] static member signal_wifi_statusbar_null_outlined: IconData = nativeOnly
  [<IsConst>] static member signpost: IconData = nativeOnly
  [<IsConst>] static member signpost_sharp: IconData = nativeOnly
  [<IsConst>] static member signpost_rounded: IconData = nativeOnly
  [<IsConst>] static member signpost_outlined: IconData = nativeOnly
  [<IsConst>] static member sim_card: IconData = nativeOnly
  [<IsConst>] static member sim_card_sharp: IconData = nativeOnly
  [<IsConst>] static member sim_card_rounded: IconData = nativeOnly
  [<IsConst>] static member sim_card_outlined: IconData = nativeOnly
  [<IsConst>] static member sim_card_alert: IconData = nativeOnly
  [<IsConst>] static member sim_card_alert_sharp: IconData = nativeOnly
  [<IsConst>] static member sim_card_alert_rounded: IconData = nativeOnly
  [<IsConst>] static member sim_card_alert_outlined: IconData = nativeOnly
  [<IsConst>] static member sim_card_download: IconData = nativeOnly
  [<IsConst>] static member sim_card_download_sharp: IconData = nativeOnly
  [<IsConst>] static member sim_card_download_rounded: IconData = nativeOnly
  [<IsConst>] static member sim_card_download_outlined: IconData = nativeOnly
  [<IsConst>] static member single_bed: IconData = nativeOnly
  [<IsConst>] static member single_bed_sharp: IconData = nativeOnly
  [<IsConst>] static member single_bed_rounded: IconData = nativeOnly
  [<IsConst>] static member single_bed_outlined: IconData = nativeOnly
  [<IsConst>] static member sip: IconData = nativeOnly
  [<IsConst>] static member sip_sharp: IconData = nativeOnly
  [<IsConst>] static member sip_rounded: IconData = nativeOnly
  [<IsConst>] static member sip_outlined: IconData = nativeOnly
  [<IsConst>] static member skateboarding: IconData = nativeOnly
  [<IsConst>] static member skateboarding_sharp: IconData = nativeOnly
  [<IsConst>] static member skateboarding_rounded: IconData = nativeOnly
  [<IsConst>] static member skateboarding_outlined: IconData = nativeOnly
  [<IsConst>] static member skip_next: IconData = nativeOnly
  [<IsConst>] static member skip_next_sharp: IconData = nativeOnly
  [<IsConst>] static member skip_next_rounded: IconData = nativeOnly
  [<IsConst>] static member skip_next_outlined: IconData = nativeOnly
  [<IsConst>] static member skip_previous: IconData = nativeOnly
  [<IsConst>] static member skip_previous_sharp: IconData = nativeOnly
  [<IsConst>] static member skip_previous_rounded: IconData = nativeOnly
  [<IsConst>] static member skip_previous_outlined: IconData = nativeOnly
  [<IsConst>] static member sledding: IconData = nativeOnly
  [<IsConst>] static member sledding_sharp: IconData = nativeOnly
  [<IsConst>] static member sledding_rounded: IconData = nativeOnly
  [<IsConst>] static member sledding_outlined: IconData = nativeOnly
  [<IsConst>] static member slideshow: IconData = nativeOnly
  [<IsConst>] static member slideshow_sharp: IconData = nativeOnly
  [<IsConst>] static member slideshow_rounded: IconData = nativeOnly
  [<IsConst>] static member slideshow_outlined: IconData = nativeOnly
  [<IsConst>] static member slow_motion_video: IconData = nativeOnly
  [<IsConst>] static member slow_motion_video_sharp: IconData = nativeOnly
  [<IsConst>] static member slow_motion_video_rounded: IconData = nativeOnly
  [<IsConst>] static member slow_motion_video_outlined: IconData = nativeOnly
  [<IsConst>] static member smart_button: IconData = nativeOnly
  [<IsConst>] static member smart_button_sharp: IconData = nativeOnly
  [<IsConst>] static member smart_button_rounded: IconData = nativeOnly
  [<IsConst>] static member smart_button_outlined: IconData = nativeOnly
  [<IsConst>] static member smart_display: IconData = nativeOnly
  [<IsConst>] static member smart_display_sharp: IconData = nativeOnly
  [<IsConst>] static member smart_display_rounded: IconData = nativeOnly
  [<IsConst>] static member smart_display_outlined: IconData = nativeOnly
  [<IsConst>] static member smart_screen: IconData = nativeOnly
  [<IsConst>] static member smart_screen_sharp: IconData = nativeOnly
  [<IsConst>] static member smart_screen_rounded: IconData = nativeOnly
  [<IsConst>] static member smart_screen_outlined: IconData = nativeOnly
  [<IsConst>] static member smart_toy: IconData = nativeOnly
  [<IsConst>] static member smart_toy_sharp: IconData = nativeOnly
  [<IsConst>] static member smart_toy_rounded: IconData = nativeOnly
  [<IsConst>] static member smart_toy_outlined: IconData = nativeOnly
  [<IsConst>] static member smartphone: IconData = nativeOnly
  [<IsConst>] static member smartphone_sharp: IconData = nativeOnly
  [<IsConst>] static member smartphone_rounded: IconData = nativeOnly
  [<IsConst>] static member smartphone_outlined: IconData = nativeOnly
  [<IsConst>] static member smoke_free: IconData = nativeOnly
  [<IsConst>] static member smoke_free_sharp: IconData = nativeOnly
  [<IsConst>] static member smoke_free_rounded: IconData = nativeOnly
  [<IsConst>] static member smoke_free_outlined: IconData = nativeOnly
  [<IsConst>] static member smoking_rooms: IconData = nativeOnly
  [<IsConst>] static member smoking_rooms_sharp: IconData = nativeOnly
  [<IsConst>] static member smoking_rooms_rounded: IconData = nativeOnly
  [<IsConst>] static member smoking_rooms_outlined: IconData = nativeOnly
  [<IsConst>] static member sms: IconData = nativeOnly
  [<IsConst>] static member sms_sharp: IconData = nativeOnly
  [<IsConst>] static member sms_rounded: IconData = nativeOnly
  [<IsConst>] static member sms_outlined: IconData = nativeOnly
  [<IsConst>] static member sms_failed: IconData = nativeOnly
  [<IsConst>] static member sms_failed_sharp: IconData = nativeOnly
  [<IsConst>] static member sms_failed_rounded: IconData = nativeOnly
  [<IsConst>] static member sms_failed_outlined: IconData = nativeOnly
  [<IsConst>] static member snapchat: IconData = nativeOnly
  [<IsConst>] static member snapchat_sharp: IconData = nativeOnly
  [<IsConst>] static member snapchat_rounded: IconData = nativeOnly
  [<IsConst>] static member snapchat_outlined: IconData = nativeOnly
  [<IsConst>] static member snippet_folder: IconData = nativeOnly
  [<IsConst>] static member snippet_folder_sharp: IconData = nativeOnly
  [<IsConst>] static member snippet_folder_rounded: IconData = nativeOnly
  [<IsConst>] static member snippet_folder_outlined: IconData = nativeOnly
  [<IsConst>] static member snooze: IconData = nativeOnly
  [<IsConst>] static member snooze_sharp: IconData = nativeOnly
  [<IsConst>] static member snooze_rounded: IconData = nativeOnly
  [<IsConst>] static member snooze_outlined: IconData = nativeOnly
  [<IsConst>] static member snowboarding: IconData = nativeOnly
  [<IsConst>] static member snowboarding_sharp: IconData = nativeOnly
  [<IsConst>] static member snowboarding_rounded: IconData = nativeOnly
  [<IsConst>] static member snowboarding_outlined: IconData = nativeOnly
  [<IsConst>] static member snowing: IconData = nativeOnly
  [<IsConst>] static member snowmobile: IconData = nativeOnly
  [<IsConst>] static member snowmobile_sharp: IconData = nativeOnly
  [<IsConst>] static member snowmobile_rounded: IconData = nativeOnly
  [<IsConst>] static member snowmobile_outlined: IconData = nativeOnly
  [<IsConst>] static member snowshoeing: IconData = nativeOnly
  [<IsConst>] static member snowshoeing_sharp: IconData = nativeOnly
  [<IsConst>] static member snowshoeing_rounded: IconData = nativeOnly
  [<IsConst>] static member snowshoeing_outlined: IconData = nativeOnly
  [<IsConst>] static member soap: IconData = nativeOnly
  [<IsConst>] static member soap_sharp: IconData = nativeOnly
  [<IsConst>] static member soap_rounded: IconData = nativeOnly
  [<IsConst>] static member soap_outlined: IconData = nativeOnly
  [<IsConst>] static member social_distance: IconData = nativeOnly
  [<IsConst>] static member social_distance_sharp: IconData = nativeOnly
  [<IsConst>] static member social_distance_rounded: IconData = nativeOnly
  [<IsConst>] static member social_distance_outlined: IconData = nativeOnly
  [<IsConst>] static member solar_power: IconData = nativeOnly
  [<IsConst>] static member solar_power_sharp: IconData = nativeOnly
  [<IsConst>] static member solar_power_rounded: IconData = nativeOnly
  [<IsConst>] static member solar_power_outlined: IconData = nativeOnly
  [<IsConst>] static member sort: IconData = nativeOnly
  [<IsConst>] static member sort_sharp: IconData = nativeOnly
  [<IsConst>] static member sort_rounded: IconData = nativeOnly
  [<IsConst>] static member sort_outlined: IconData = nativeOnly
  [<IsConst>] static member sort_by_alpha: IconData = nativeOnly
  [<IsConst>] static member sort_by_alpha_sharp: IconData = nativeOnly
  [<IsConst>] static member sort_by_alpha_rounded: IconData = nativeOnly
  [<IsConst>] static member sort_by_alpha_outlined: IconData = nativeOnly
  [<IsConst>] static member sos: IconData = nativeOnly
  [<IsConst>] static member sos_sharp: IconData = nativeOnly
  [<IsConst>] static member sos_rounded: IconData = nativeOnly
  [<IsConst>] static member sos_outlined: IconData = nativeOnly
  [<IsConst>] static member soup_kitchen: IconData = nativeOnly
  [<IsConst>] static member soup_kitchen_sharp: IconData = nativeOnly
  [<IsConst>] static member soup_kitchen_rounded: IconData = nativeOnly
  [<IsConst>] static member soup_kitchen_outlined: IconData = nativeOnly
  [<IsConst>] static member source: IconData = nativeOnly
  [<IsConst>] static member source_sharp: IconData = nativeOnly
  [<IsConst>] static member source_rounded: IconData = nativeOnly
  [<IsConst>] static member source_outlined: IconData = nativeOnly
  [<IsConst>] static member south: IconData = nativeOnly
  [<IsConst>] static member south_sharp: IconData = nativeOnly
  [<IsConst>] static member south_rounded: IconData = nativeOnly
  [<IsConst>] static member south_outlined: IconData = nativeOnly
  [<IsConst>] static member south_america: IconData = nativeOnly
  [<IsConst>] static member south_america_sharp: IconData = nativeOnly
  [<IsConst>] static member south_america_rounded: IconData = nativeOnly
  [<IsConst>] static member south_america_outlined: IconData = nativeOnly
  [<IsConst>] static member south_east: IconData = nativeOnly
  [<IsConst>] static member south_east_sharp: IconData = nativeOnly
  [<IsConst>] static member south_east_rounded: IconData = nativeOnly
  [<IsConst>] static member south_east_outlined: IconData = nativeOnly
  [<IsConst>] static member south_west: IconData = nativeOnly
  [<IsConst>] static member south_west_sharp: IconData = nativeOnly
  [<IsConst>] static member south_west_rounded: IconData = nativeOnly
  [<IsConst>] static member south_west_outlined: IconData = nativeOnly
  [<IsConst>] static member spa: IconData = nativeOnly
  [<IsConst>] static member spa_sharp: IconData = nativeOnly
  [<IsConst>] static member spa_rounded: IconData = nativeOnly
  [<IsConst>] static member spa_outlined: IconData = nativeOnly
  [<IsConst>] static member space_bar: IconData = nativeOnly
  [<IsConst>] static member space_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member space_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member space_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member space_dashboard: IconData = nativeOnly
  [<IsConst>] static member space_dashboard_sharp: IconData = nativeOnly
  [<IsConst>] static member space_dashboard_rounded: IconData = nativeOnly
  [<IsConst>] static member space_dashboard_outlined: IconData = nativeOnly
  [<IsConst>] static member spatial_audio: IconData = nativeOnly
  [<IsConst>] static member spatial_audio_sharp: IconData = nativeOnly
  [<IsConst>] static member spatial_audio_rounded: IconData = nativeOnly
  [<IsConst>] static member spatial_audio_outlined: IconData = nativeOnly
  [<IsConst>] static member spatial_audio_off: IconData = nativeOnly
  [<IsConst>] static member spatial_audio_off_sharp: IconData = nativeOnly
  [<IsConst>] static member spatial_audio_off_rounded: IconData = nativeOnly
  [<IsConst>] static member spatial_audio_off_outlined: IconData = nativeOnly
  [<IsConst>] static member spatial_tracking: IconData = nativeOnly
  [<IsConst>] static member spatial_tracking_sharp: IconData = nativeOnly
  [<IsConst>] static member spatial_tracking_rounded: IconData = nativeOnly
  [<IsConst>] static member spatial_tracking_outlined: IconData = nativeOnly
  [<IsConst>] static member speaker: IconData = nativeOnly
  [<IsConst>] static member speaker_sharp: IconData = nativeOnly
  [<IsConst>] static member speaker_rounded: IconData = nativeOnly
  [<IsConst>] static member speaker_outlined: IconData = nativeOnly
  [<IsConst>] static member speaker_group: IconData = nativeOnly
  [<IsConst>] static member speaker_group_sharp: IconData = nativeOnly
  [<IsConst>] static member speaker_group_rounded: IconData = nativeOnly
  [<IsConst>] static member speaker_group_outlined: IconData = nativeOnly
  [<IsConst>] static member speaker_notes: IconData = nativeOnly
  [<IsConst>] static member speaker_notes_sharp: IconData = nativeOnly
  [<IsConst>] static member speaker_notes_rounded: IconData = nativeOnly
  [<IsConst>] static member speaker_notes_outlined: IconData = nativeOnly
  [<IsConst>] static member speaker_notes_off: IconData = nativeOnly
  [<IsConst>] static member speaker_notes_off_sharp: IconData = nativeOnly
  [<IsConst>] static member speaker_notes_off_rounded: IconData = nativeOnly
  [<IsConst>] static member speaker_notes_off_outlined: IconData = nativeOnly
  [<IsConst>] static member speaker_phone: IconData = nativeOnly
  [<IsConst>] static member speaker_phone_sharp: IconData = nativeOnly
  [<IsConst>] static member speaker_phone_rounded: IconData = nativeOnly
  [<IsConst>] static member speaker_phone_outlined: IconData = nativeOnly
  [<IsConst>] static member speed: IconData = nativeOnly
  [<IsConst>] static member speed_sharp: IconData = nativeOnly
  [<IsConst>] static member speed_rounded: IconData = nativeOnly
  [<IsConst>] static member speed_outlined: IconData = nativeOnly
  [<IsConst>] static member spellcheck: IconData = nativeOnly
  [<IsConst>] static member spellcheck_sharp: IconData = nativeOnly
  [<IsConst>] static member spellcheck_rounded: IconData = nativeOnly
  [<IsConst>] static member spellcheck_outlined: IconData = nativeOnly
  [<IsConst>] static member splitscreen: IconData = nativeOnly
  [<IsConst>] static member splitscreen_sharp: IconData = nativeOnly
  [<IsConst>] static member splitscreen_rounded: IconData = nativeOnly
  [<IsConst>] static member splitscreen_outlined: IconData = nativeOnly
  [<IsConst>] static member spoke: IconData = nativeOnly
  [<IsConst>] static member spoke_sharp: IconData = nativeOnly
  [<IsConst>] static member spoke_rounded: IconData = nativeOnly
  [<IsConst>] static member spoke_outlined: IconData = nativeOnly
  [<IsConst>] static member sports: IconData = nativeOnly
  [<IsConst>] static member sports_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_bar: IconData = nativeOnly
  [<IsConst>] static member sports_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_baseball: IconData = nativeOnly
  [<IsConst>] static member sports_baseball_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_baseball_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_baseball_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_basketball: IconData = nativeOnly
  [<IsConst>] static member sports_basketball_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_basketball_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_basketball_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_cricket: IconData = nativeOnly
  [<IsConst>] static member sports_cricket_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_cricket_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_cricket_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_esports: IconData = nativeOnly
  [<IsConst>] static member sports_esports_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_esports_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_esports_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_football: IconData = nativeOnly
  [<IsConst>] static member sports_football_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_football_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_football_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_golf: IconData = nativeOnly
  [<IsConst>] static member sports_golf_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_golf_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_golf_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_gymnastics: IconData = nativeOnly
  [<IsConst>] static member sports_gymnastics_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_gymnastics_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_gymnastics_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_handball: IconData = nativeOnly
  [<IsConst>] static member sports_handball_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_handball_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_handball_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_hockey: IconData = nativeOnly
  [<IsConst>] static member sports_hockey_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_hockey_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_hockey_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_kabaddi: IconData = nativeOnly
  [<IsConst>] static member sports_kabaddi_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_kabaddi_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_kabaddi_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_martial_arts: IconData = nativeOnly
  [<IsConst>] static member sports_martial_arts_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_martial_arts_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_martial_arts_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_mma: IconData = nativeOnly
  [<IsConst>] static member sports_mma_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_mma_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_mma_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_motorsports: IconData = nativeOnly
  [<IsConst>] static member sports_motorsports_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_motorsports_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_motorsports_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_rugby: IconData = nativeOnly
  [<IsConst>] static member sports_rugby_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_rugby_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_rugby_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_score: IconData = nativeOnly
  [<IsConst>] static member sports_score_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_score_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_score_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_soccer: IconData = nativeOnly
  [<IsConst>] static member sports_soccer_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_soccer_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_soccer_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_tennis: IconData = nativeOnly
  [<IsConst>] static member sports_tennis_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_tennis_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_tennis_outlined: IconData = nativeOnly
  [<IsConst>] static member sports_volleyball: IconData = nativeOnly
  [<IsConst>] static member sports_volleyball_sharp: IconData = nativeOnly
  [<IsConst>] static member sports_volleyball_rounded: IconData = nativeOnly
  [<IsConst>] static member sports_volleyball_outlined: IconData = nativeOnly
  [<IsConst>] static member square: IconData = nativeOnly
  [<IsConst>] static member square_sharp: IconData = nativeOnly
  [<IsConst>] static member square_rounded: IconData = nativeOnly
  [<IsConst>] static member square_outlined: IconData = nativeOnly
  [<IsConst>] static member square_foot: IconData = nativeOnly
  [<IsConst>] static member square_foot_sharp: IconData = nativeOnly
  [<IsConst>] static member square_foot_rounded: IconData = nativeOnly
  [<IsConst>] static member square_foot_outlined: IconData = nativeOnly
  [<IsConst>] static member ssid_chart: IconData = nativeOnly
  [<IsConst>] static member ssid_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member ssid_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member ssid_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member stacked_bar_chart: IconData = nativeOnly
  [<IsConst>] static member stacked_bar_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member stacked_bar_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member stacked_bar_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member stacked_line_chart: IconData = nativeOnly
  [<IsConst>] static member stacked_line_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member stacked_line_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member stacked_line_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member stadium: IconData = nativeOnly
  [<IsConst>] static member stadium_sharp: IconData = nativeOnly
  [<IsConst>] static member stadium_rounded: IconData = nativeOnly
  [<IsConst>] static member stadium_outlined: IconData = nativeOnly
  [<IsConst>] static member stairs: IconData = nativeOnly
  [<IsConst>] static member stairs_sharp: IconData = nativeOnly
  [<IsConst>] static member stairs_rounded: IconData = nativeOnly
  [<IsConst>] static member stairs_outlined: IconData = nativeOnly
  [<IsConst>] static member star: IconData = nativeOnly
  [<IsConst>] static member star_sharp: IconData = nativeOnly
  [<IsConst>] static member star_rounded: IconData = nativeOnly
  [<IsConst>] static member star_outlined: IconData = nativeOnly
  [<IsConst>] static member star_border: IconData = nativeOnly
  [<IsConst>] static member star_border_sharp: IconData = nativeOnly
  [<IsConst>] static member star_border_rounded: IconData = nativeOnly
  [<IsConst>] static member star_border_outlined: IconData = nativeOnly
  [<IsConst>] static member star_border_purple500: IconData = nativeOnly
  [<IsConst>] static member star_border_purple500_sharp: IconData = nativeOnly
  [<IsConst>] static member star_border_purple500_rounded: IconData = nativeOnly
  [<IsConst>] static member star_border_purple500_outlined: IconData = nativeOnly
  [<IsConst>] static member star_half: IconData = nativeOnly
  [<IsConst>] static member star_half_sharp: IconData = nativeOnly
  [<IsConst>] static member star_half_rounded: IconData = nativeOnly
  [<IsConst>] static member star_half_outlined: IconData = nativeOnly
  [<IsConst>] static member star_outline: IconData = nativeOnly
  [<IsConst>] static member star_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member star_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member star_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member star_purple500: IconData = nativeOnly
  [<IsConst>] static member star_purple500_sharp: IconData = nativeOnly
  [<IsConst>] static member star_purple500_rounded: IconData = nativeOnly
  [<IsConst>] static member star_purple500_outlined: IconData = nativeOnly
  [<IsConst>] static member star_rate: IconData = nativeOnly
  [<IsConst>] static member star_rate_sharp: IconData = nativeOnly
  [<IsConst>] static member star_rate_rounded: IconData = nativeOnly
  [<IsConst>] static member star_rate_outlined: IconData = nativeOnly
  [<IsConst>] static member stars: IconData = nativeOnly
  [<IsConst>] static member stars_sharp: IconData = nativeOnly
  [<IsConst>] static member stars_rounded: IconData = nativeOnly
  [<IsConst>] static member stars_outlined: IconData = nativeOnly
  [<IsConst>] static member start: IconData = nativeOnly
  [<IsConst>] static member start_sharp: IconData = nativeOnly
  [<IsConst>] static member start_rounded: IconData = nativeOnly
  [<IsConst>] static member start_outlined: IconData = nativeOnly
  [<IsConst>] static member stay_current_landscape: IconData = nativeOnly
  [<IsConst>] static member stay_current_landscape_sharp: IconData = nativeOnly
  [<IsConst>] static member stay_current_landscape_rounded: IconData = nativeOnly
  [<IsConst>] static member stay_current_landscape_outlined: IconData = nativeOnly
  [<IsConst>] static member stay_current_portrait: IconData = nativeOnly
  [<IsConst>] static member stay_current_portrait_sharp: IconData = nativeOnly
  [<IsConst>] static member stay_current_portrait_rounded: IconData = nativeOnly
  [<IsConst>] static member stay_current_portrait_outlined: IconData = nativeOnly
  [<IsConst>] static member stay_primary_landscape: IconData = nativeOnly
  [<IsConst>] static member stay_primary_landscape_sharp: IconData = nativeOnly
  [<IsConst>] static member stay_primary_landscape_rounded: IconData = nativeOnly
  [<IsConst>] static member stay_primary_landscape_outlined: IconData = nativeOnly
  [<IsConst>] static member stay_primary_portrait: IconData = nativeOnly
  [<IsConst>] static member stay_primary_portrait_sharp: IconData = nativeOnly
  [<IsConst>] static member stay_primary_portrait_rounded: IconData = nativeOnly
  [<IsConst>] static member stay_primary_portrait_outlined: IconData = nativeOnly
  [<IsConst>] static member sticky_note_2: IconData = nativeOnly
  [<IsConst>] static member sticky_note_2_sharp: IconData = nativeOnly
  [<IsConst>] static member sticky_note_2_rounded: IconData = nativeOnly
  [<IsConst>] static member sticky_note_2_outlined: IconData = nativeOnly
  [<IsConst>] static member stop: IconData = nativeOnly
  [<IsConst>] static member stop_sharp: IconData = nativeOnly
  [<IsConst>] static member stop_rounded: IconData = nativeOnly
  [<IsConst>] static member stop_outlined: IconData = nativeOnly
  [<IsConst>] static member stop_circle: IconData = nativeOnly
  [<IsConst>] static member stop_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member stop_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member stop_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member stop_screen_share: IconData = nativeOnly
  [<IsConst>] static member stop_screen_share_sharp: IconData = nativeOnly
  [<IsConst>] static member stop_screen_share_rounded: IconData = nativeOnly
  [<IsConst>] static member stop_screen_share_outlined: IconData = nativeOnly
  [<IsConst>] static member storage: IconData = nativeOnly
  [<IsConst>] static member storage_sharp: IconData = nativeOnly
  [<IsConst>] static member storage_rounded: IconData = nativeOnly
  [<IsConst>] static member storage_outlined: IconData = nativeOnly
  [<IsConst>] static member store: IconData = nativeOnly
  [<IsConst>] static member store_sharp: IconData = nativeOnly
  [<IsConst>] static member store_rounded: IconData = nativeOnly
  [<IsConst>] static member store_outlined: IconData = nativeOnly
  [<IsConst>] static member store_mall_directory: IconData = nativeOnly
  [<IsConst>] static member store_mall_directory_sharp: IconData = nativeOnly
  [<IsConst>] static member store_mall_directory_rounded: IconData = nativeOnly
  [<IsConst>] static member store_mall_directory_outlined: IconData = nativeOnly
  [<IsConst>] static member storefront: IconData = nativeOnly
  [<IsConst>] static member storefront_sharp: IconData = nativeOnly
  [<IsConst>] static member storefront_rounded: IconData = nativeOnly
  [<IsConst>] static member storefront_outlined: IconData = nativeOnly
  [<IsConst>] static member storm: IconData = nativeOnly
  [<IsConst>] static member storm_sharp: IconData = nativeOnly
  [<IsConst>] static member storm_rounded: IconData = nativeOnly
  [<IsConst>] static member storm_outlined: IconData = nativeOnly
  [<IsConst>] static member straight: IconData = nativeOnly
  [<IsConst>] static member straight_sharp: IconData = nativeOnly
  [<IsConst>] static member straight_rounded: IconData = nativeOnly
  [<IsConst>] static member straight_outlined: IconData = nativeOnly
  [<IsConst>] static member straighten: IconData = nativeOnly
  [<IsConst>] static member straighten_sharp: IconData = nativeOnly
  [<IsConst>] static member straighten_rounded: IconData = nativeOnly
  [<IsConst>] static member straighten_outlined: IconData = nativeOnly
  [<IsConst>] static member stream: IconData = nativeOnly
  [<IsConst>] static member stream_sharp: IconData = nativeOnly
  [<IsConst>] static member stream_rounded: IconData = nativeOnly
  [<IsConst>] static member stream_outlined: IconData = nativeOnly
  [<IsConst>] static member streetview: IconData = nativeOnly
  [<IsConst>] static member streetview_sharp: IconData = nativeOnly
  [<IsConst>] static member streetview_rounded: IconData = nativeOnly
  [<IsConst>] static member streetview_outlined: IconData = nativeOnly
  [<IsConst>] static member strikethrough_s: IconData = nativeOnly
  [<IsConst>] static member strikethrough_s_sharp: IconData = nativeOnly
  [<IsConst>] static member strikethrough_s_rounded: IconData = nativeOnly
  [<IsConst>] static member strikethrough_s_outlined: IconData = nativeOnly
  [<IsConst>] static member stroller: IconData = nativeOnly
  [<IsConst>] static member stroller_sharp: IconData = nativeOnly
  [<IsConst>] static member stroller_rounded: IconData = nativeOnly
  [<IsConst>] static member stroller_outlined: IconData = nativeOnly
  [<IsConst>] static member style: IconData = nativeOnly
  [<IsConst>] static member style_sharp: IconData = nativeOnly
  [<IsConst>] static member style_rounded: IconData = nativeOnly
  [<IsConst>] static member style_outlined: IconData = nativeOnly
  [<IsConst>] static member subdirectory_arrow_left: IconData = nativeOnly
  [<IsConst>] static member subdirectory_arrow_left_sharp: IconData = nativeOnly
  [<IsConst>] static member subdirectory_arrow_left_rounded: IconData = nativeOnly
  [<IsConst>] static member subdirectory_arrow_left_outlined: IconData = nativeOnly
  [<IsConst>] static member subdirectory_arrow_right: IconData = nativeOnly
  [<IsConst>] static member subdirectory_arrow_right_sharp: IconData = nativeOnly
  [<IsConst>] static member subdirectory_arrow_right_rounded: IconData = nativeOnly
  [<IsConst>] static member subdirectory_arrow_right_outlined: IconData = nativeOnly
  [<IsConst>] static member subject: IconData = nativeOnly
  [<IsConst>] static member subject_sharp: IconData = nativeOnly
  [<IsConst>] static member subject_rounded: IconData = nativeOnly
  [<IsConst>] static member subject_outlined: IconData = nativeOnly
  [<IsConst>] static member subscript: IconData = nativeOnly
  [<IsConst>] static member subscript_sharp: IconData = nativeOnly
  [<IsConst>] static member subscript_rounded: IconData = nativeOnly
  [<IsConst>] static member subscript_outlined: IconData = nativeOnly
  [<IsConst>] static member subscriptions: IconData = nativeOnly
  [<IsConst>] static member subscriptions_sharp: IconData = nativeOnly
  [<IsConst>] static member subscriptions_rounded: IconData = nativeOnly
  [<IsConst>] static member subscriptions_outlined: IconData = nativeOnly
  [<IsConst>] static member subtitles: IconData = nativeOnly
  [<IsConst>] static member subtitles_sharp: IconData = nativeOnly
  [<IsConst>] static member subtitles_rounded: IconData = nativeOnly
  [<IsConst>] static member subtitles_outlined: IconData = nativeOnly
  [<IsConst>] static member subtitles_off: IconData = nativeOnly
  [<IsConst>] static member subtitles_off_sharp: IconData = nativeOnly
  [<IsConst>] static member subtitles_off_rounded: IconData = nativeOnly
  [<IsConst>] static member subtitles_off_outlined: IconData = nativeOnly
  [<IsConst>] static member subway: IconData = nativeOnly
  [<IsConst>] static member subway_sharp: IconData = nativeOnly
  [<IsConst>] static member subway_rounded: IconData = nativeOnly
  [<IsConst>] static member subway_outlined: IconData = nativeOnly
  [<IsConst>] static member summarize: IconData = nativeOnly
  [<IsConst>] static member summarize_sharp: IconData = nativeOnly
  [<IsConst>] static member summarize_rounded: IconData = nativeOnly
  [<IsConst>] static member summarize_outlined: IconData = nativeOnly
  [<IsConst>] static member sunny: IconData = nativeOnly
  [<IsConst>] static member sunny_snowing: IconData = nativeOnly
  [<IsConst>] static member superscript: IconData = nativeOnly
  [<IsConst>] static member superscript_sharp: IconData = nativeOnly
  [<IsConst>] static member superscript_rounded: IconData = nativeOnly
  [<IsConst>] static member superscript_outlined: IconData = nativeOnly
  [<IsConst>] static member supervised_user_circle: IconData = nativeOnly
  [<IsConst>] static member supervised_user_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member supervised_user_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member supervised_user_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member supervisor_account: IconData = nativeOnly
  [<IsConst>] static member supervisor_account_sharp: IconData = nativeOnly
  [<IsConst>] static member supervisor_account_rounded: IconData = nativeOnly
  [<IsConst>] static member supervisor_account_outlined: IconData = nativeOnly
  [<IsConst>] static member support: IconData = nativeOnly
  [<IsConst>] static member support_sharp: IconData = nativeOnly
  [<IsConst>] static member support_rounded: IconData = nativeOnly
  [<IsConst>] static member support_outlined: IconData = nativeOnly
  [<IsConst>] static member support_agent: IconData = nativeOnly
  [<IsConst>] static member support_agent_sharp: IconData = nativeOnly
  [<IsConst>] static member support_agent_rounded: IconData = nativeOnly
  [<IsConst>] static member support_agent_outlined: IconData = nativeOnly
  [<IsConst>] static member surfing: IconData = nativeOnly
  [<IsConst>] static member surfing_sharp: IconData = nativeOnly
  [<IsConst>] static member surfing_rounded: IconData = nativeOnly
  [<IsConst>] static member surfing_outlined: IconData = nativeOnly
  [<IsConst>] static member surround_sound: IconData = nativeOnly
  [<IsConst>] static member surround_sound_sharp: IconData = nativeOnly
  [<IsConst>] static member surround_sound_rounded: IconData = nativeOnly
  [<IsConst>] static member surround_sound_outlined: IconData = nativeOnly
  [<IsConst>] static member swap_calls: IconData = nativeOnly
  [<IsConst>] static member swap_calls_sharp: IconData = nativeOnly
  [<IsConst>] static member swap_calls_rounded: IconData = nativeOnly
  [<IsConst>] static member swap_calls_outlined: IconData = nativeOnly
  [<IsConst>] static member swap_horiz: IconData = nativeOnly
  [<IsConst>] static member swap_horiz_sharp: IconData = nativeOnly
  [<IsConst>] static member swap_horiz_rounded: IconData = nativeOnly
  [<IsConst>] static member swap_horiz_outlined: IconData = nativeOnly
  [<IsConst>] static member swap_horizontal_circle: IconData = nativeOnly
  [<IsConst>] static member swap_horizontal_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member swap_horizontal_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member swap_horizontal_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member swap_vert: IconData = nativeOnly
  [<IsConst>] static member swap_vert_sharp: IconData = nativeOnly
  [<IsConst>] static member swap_vert_rounded: IconData = nativeOnly
  [<IsConst>] static member swap_vert_outlined: IconData = nativeOnly
  [<IsConst>] static member swap_vert_circle: IconData = nativeOnly
  [<IsConst>] static member swap_vert_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member swap_vert_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member swap_vert_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member swap_vertical_circle: IconData = nativeOnly
  [<IsConst>] static member swap_vertical_circle_sharp: IconData = nativeOnly
  [<IsConst>] static member swap_vertical_circle_rounded: IconData = nativeOnly
  [<IsConst>] static member swap_vertical_circle_outlined: IconData = nativeOnly
  [<IsConst>] static member swipe: IconData = nativeOnly
  [<IsConst>] static member swipe_sharp: IconData = nativeOnly
  [<IsConst>] static member swipe_rounded: IconData = nativeOnly
  [<IsConst>] static member swipe_outlined: IconData = nativeOnly
  [<IsConst>] static member swipe_down: IconData = nativeOnly
  [<IsConst>] static member swipe_down_sharp: IconData = nativeOnly
  [<IsConst>] static member swipe_down_rounded: IconData = nativeOnly
  [<IsConst>] static member swipe_down_outlined: IconData = nativeOnly
  [<IsConst>] static member swipe_down_alt: IconData = nativeOnly
  [<IsConst>] static member swipe_down_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member swipe_down_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member swipe_down_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member swipe_left: IconData = nativeOnly
  [<IsConst>] static member swipe_left_sharp: IconData = nativeOnly
  [<IsConst>] static member swipe_left_rounded: IconData = nativeOnly
  [<IsConst>] static member swipe_left_outlined: IconData = nativeOnly
  [<IsConst>] static member swipe_left_alt: IconData = nativeOnly
  [<IsConst>] static member swipe_left_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member swipe_left_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member swipe_left_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member swipe_right: IconData = nativeOnly
  [<IsConst>] static member swipe_right_sharp: IconData = nativeOnly
  [<IsConst>] static member swipe_right_rounded: IconData = nativeOnly
  [<IsConst>] static member swipe_right_outlined: IconData = nativeOnly
  [<IsConst>] static member swipe_right_alt: IconData = nativeOnly
  [<IsConst>] static member swipe_right_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member swipe_right_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member swipe_right_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member swipe_up: IconData = nativeOnly
  [<IsConst>] static member swipe_up_sharp: IconData = nativeOnly
  [<IsConst>] static member swipe_up_rounded: IconData = nativeOnly
  [<IsConst>] static member swipe_up_outlined: IconData = nativeOnly
  [<IsConst>] static member swipe_up_alt: IconData = nativeOnly
  [<IsConst>] static member swipe_up_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member swipe_up_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member swipe_up_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member swipe_vertical: IconData = nativeOnly
  [<IsConst>] static member swipe_vertical_sharp: IconData = nativeOnly
  [<IsConst>] static member swipe_vertical_rounded: IconData = nativeOnly
  [<IsConst>] static member swipe_vertical_outlined: IconData = nativeOnly
  [<IsConst>] static member switch_access_shortcut: IconData = nativeOnly
  [<IsConst>] static member switch_access_shortcut_sharp: IconData = nativeOnly
  [<IsConst>] static member switch_access_shortcut_rounded: IconData = nativeOnly
  [<IsConst>] static member switch_access_shortcut_outlined: IconData = nativeOnly
  [<IsConst>] static member switch_access_shortcut_add: IconData = nativeOnly
  [<IsConst>] static member switch_access_shortcut_add_sharp: IconData = nativeOnly
  [<IsConst>] static member switch_access_shortcut_add_rounded: IconData = nativeOnly
  [<IsConst>] static member switch_access_shortcut_add_outlined: IconData = nativeOnly
  [<IsConst>] static member switch_account: IconData = nativeOnly
  [<IsConst>] static member switch_account_sharp: IconData = nativeOnly
  [<IsConst>] static member switch_account_rounded: IconData = nativeOnly
  [<IsConst>] static member switch_account_outlined: IconData = nativeOnly
  [<IsConst>] static member switch_camera: IconData = nativeOnly
  [<IsConst>] static member switch_camera_sharp: IconData = nativeOnly
  [<IsConst>] static member switch_camera_rounded: IconData = nativeOnly
  [<IsConst>] static member switch_camera_outlined: IconData = nativeOnly
  [<IsConst>] static member switch_left: IconData = nativeOnly
  [<IsConst>] static member switch_left_sharp: IconData = nativeOnly
  [<IsConst>] static member switch_left_rounded: IconData = nativeOnly
  [<IsConst>] static member switch_left_outlined: IconData = nativeOnly
  [<IsConst>] static member switch_right: IconData = nativeOnly
  [<IsConst>] static member switch_right_sharp: IconData = nativeOnly
  [<IsConst>] static member switch_right_rounded: IconData = nativeOnly
  [<IsConst>] static member switch_right_outlined: IconData = nativeOnly
  [<IsConst>] static member switch_video: IconData = nativeOnly
  [<IsConst>] static member switch_video_sharp: IconData = nativeOnly
  [<IsConst>] static member switch_video_rounded: IconData = nativeOnly
  [<IsConst>] static member switch_video_outlined: IconData = nativeOnly
  [<IsConst>] static member synagogue: IconData = nativeOnly
  [<IsConst>] static member synagogue_sharp: IconData = nativeOnly
  [<IsConst>] static member synagogue_rounded: IconData = nativeOnly
  [<IsConst>] static member synagogue_outlined: IconData = nativeOnly
  [<IsConst>] static member sync: IconData = nativeOnly
  [<IsConst>] static member sync_sharp: IconData = nativeOnly
  [<IsConst>] static member sync_rounded: IconData = nativeOnly
  [<IsConst>] static member sync_outlined: IconData = nativeOnly
  [<IsConst>] static member sync_alt: IconData = nativeOnly
  [<IsConst>] static member sync_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member sync_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member sync_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member sync_disabled: IconData = nativeOnly
  [<IsConst>] static member sync_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member sync_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member sync_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member sync_lock: IconData = nativeOnly
  [<IsConst>] static member sync_lock_sharp: IconData = nativeOnly
  [<IsConst>] static member sync_lock_rounded: IconData = nativeOnly
  [<IsConst>] static member sync_lock_outlined: IconData = nativeOnly
  [<IsConst>] static member sync_problem: IconData = nativeOnly
  [<IsConst>] static member sync_problem_sharp: IconData = nativeOnly
  [<IsConst>] static member sync_problem_rounded: IconData = nativeOnly
  [<IsConst>] static member sync_problem_outlined: IconData = nativeOnly
  [<IsConst>] static member system_security_update: IconData = nativeOnly
  [<IsConst>] static member system_security_update_sharp: IconData = nativeOnly
  [<IsConst>] static member system_security_update_rounded: IconData = nativeOnly
  [<IsConst>] static member system_security_update_outlined: IconData = nativeOnly
  [<IsConst>] static member system_security_update_good: IconData = nativeOnly
  [<IsConst>] static member system_security_update_good_sharp: IconData = nativeOnly
  [<IsConst>] static member system_security_update_good_rounded: IconData = nativeOnly
  [<IsConst>] static member system_security_update_good_outlined: IconData = nativeOnly
  [<IsConst>] static member system_security_update_warning: IconData = nativeOnly
  [<IsConst>] static member system_security_update_warning_sharp: IconData = nativeOnly
  [<IsConst>] static member system_security_update_warning_rounded: IconData = nativeOnly
  [<IsConst>] static member system_security_update_warning_outlined: IconData = nativeOnly
  [<IsConst>] static member system_update: IconData = nativeOnly
  [<IsConst>] static member system_update_sharp: IconData = nativeOnly
  [<IsConst>] static member system_update_rounded: IconData = nativeOnly
  [<IsConst>] static member system_update_outlined: IconData = nativeOnly
  [<IsConst>] static member system_update_alt: IconData = nativeOnly
  [<IsConst>] static member system_update_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member system_update_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member system_update_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member system_update_tv: IconData = nativeOnly
  [<IsConst>] static member system_update_tv_sharp: IconData = nativeOnly
  [<IsConst>] static member system_update_tv_rounded: IconData = nativeOnly
  [<IsConst>] static member system_update_tv_outlined: IconData = nativeOnly
  [<IsConst>] static member tab: IconData = nativeOnly
  [<IsConst>] static member tab_sharp: IconData = nativeOnly
  [<IsConst>] static member tab_rounded: IconData = nativeOnly
  [<IsConst>] static member tab_outlined: IconData = nativeOnly
  [<IsConst>] static member tab_unselected: IconData = nativeOnly
  [<IsConst>] static member tab_unselected_sharp: IconData = nativeOnly
  [<IsConst>] static member tab_unselected_rounded: IconData = nativeOnly
  [<IsConst>] static member tab_unselected_outlined: IconData = nativeOnly
  [<IsConst>] static member table_bar: IconData = nativeOnly
  [<IsConst>] static member table_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member table_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member table_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member table_chart: IconData = nativeOnly
  [<IsConst>] static member table_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member table_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member table_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member table_restaurant: IconData = nativeOnly
  [<IsConst>] static member table_restaurant_sharp: IconData = nativeOnly
  [<IsConst>] static member table_restaurant_rounded: IconData = nativeOnly
  [<IsConst>] static member table_restaurant_outlined: IconData = nativeOnly
  [<IsConst>] static member table_rows: IconData = nativeOnly
  [<IsConst>] static member table_rows_sharp: IconData = nativeOnly
  [<IsConst>] static member table_rows_rounded: IconData = nativeOnly
  [<IsConst>] static member table_rows_outlined: IconData = nativeOnly
  [<IsConst>] static member table_view: IconData = nativeOnly
  [<IsConst>] static member table_view_sharp: IconData = nativeOnly
  [<IsConst>] static member table_view_rounded: IconData = nativeOnly
  [<IsConst>] static member table_view_outlined: IconData = nativeOnly
  [<IsConst>] static member tablet: IconData = nativeOnly
  [<IsConst>] static member tablet_sharp: IconData = nativeOnly
  [<IsConst>] static member tablet_rounded: IconData = nativeOnly
  [<IsConst>] static member tablet_outlined: IconData = nativeOnly
  [<IsConst>] static member tablet_android: IconData = nativeOnly
  [<IsConst>] static member tablet_android_sharp: IconData = nativeOnly
  [<IsConst>] static member tablet_android_rounded: IconData = nativeOnly
  [<IsConst>] static member tablet_android_outlined: IconData = nativeOnly
  [<IsConst>] static member tablet_mac: IconData = nativeOnly
  [<IsConst>] static member tablet_mac_sharp: IconData = nativeOnly
  [<IsConst>] static member tablet_mac_rounded: IconData = nativeOnly
  [<IsConst>] static member tablet_mac_outlined: IconData = nativeOnly
  [<IsConst>] static member tag: IconData = nativeOnly
  [<IsConst>] static member tag_sharp: IconData = nativeOnly
  [<IsConst>] static member tag_rounded: IconData = nativeOnly
  [<IsConst>] static member tag_outlined: IconData = nativeOnly
  [<IsConst>] static member tag_faces: IconData = nativeOnly
  [<IsConst>] static member tag_faces_sharp: IconData = nativeOnly
  [<IsConst>] static member tag_faces_rounded: IconData = nativeOnly
  [<IsConst>] static member tag_faces_outlined: IconData = nativeOnly
  [<IsConst>] static member takeout_dining: IconData = nativeOnly
  [<IsConst>] static member takeout_dining_sharp: IconData = nativeOnly
  [<IsConst>] static member takeout_dining_rounded: IconData = nativeOnly
  [<IsConst>] static member takeout_dining_outlined: IconData = nativeOnly
  [<IsConst>] static member tap_and_play: IconData = nativeOnly
  [<IsConst>] static member tap_and_play_sharp: IconData = nativeOnly
  [<IsConst>] static member tap_and_play_rounded: IconData = nativeOnly
  [<IsConst>] static member tap_and_play_outlined: IconData = nativeOnly
  [<IsConst>] static member tapas: IconData = nativeOnly
  [<IsConst>] static member tapas_sharp: IconData = nativeOnly
  [<IsConst>] static member tapas_rounded: IconData = nativeOnly
  [<IsConst>] static member tapas_outlined: IconData = nativeOnly
  [<IsConst>] static member task: IconData = nativeOnly
  [<IsConst>] static member task_sharp: IconData = nativeOnly
  [<IsConst>] static member task_rounded: IconData = nativeOnly
  [<IsConst>] static member task_outlined: IconData = nativeOnly
  [<IsConst>] static member task_alt: IconData = nativeOnly
  [<IsConst>] static member task_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member task_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member task_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member taxi_alert: IconData = nativeOnly
  [<IsConst>] static member taxi_alert_sharp: IconData = nativeOnly
  [<IsConst>] static member taxi_alert_rounded: IconData = nativeOnly
  [<IsConst>] static member taxi_alert_outlined: IconData = nativeOnly
  [<IsConst>] static member telegram: IconData = nativeOnly
  [<IsConst>] static member telegram_sharp: IconData = nativeOnly
  [<IsConst>] static member telegram_rounded: IconData = nativeOnly
  [<IsConst>] static member telegram_outlined: IconData = nativeOnly
  [<IsConst>] static member temple_buddhist: IconData = nativeOnly
  [<IsConst>] static member temple_buddhist_sharp: IconData = nativeOnly
  [<IsConst>] static member temple_buddhist_rounded: IconData = nativeOnly
  [<IsConst>] static member temple_buddhist_outlined: IconData = nativeOnly
  [<IsConst>] static member temple_hindu: IconData = nativeOnly
  [<IsConst>] static member temple_hindu_sharp: IconData = nativeOnly
  [<IsConst>] static member temple_hindu_rounded: IconData = nativeOnly
  [<IsConst>] static member temple_hindu_outlined: IconData = nativeOnly
  [<IsConst>] static member terminal: IconData = nativeOnly
  [<IsConst>] static member terminal_sharp: IconData = nativeOnly
  [<IsConst>] static member terminal_rounded: IconData = nativeOnly
  [<IsConst>] static member terminal_outlined: IconData = nativeOnly
  [<IsConst>] static member terrain: IconData = nativeOnly
  [<IsConst>] static member terrain_sharp: IconData = nativeOnly
  [<IsConst>] static member terrain_rounded: IconData = nativeOnly
  [<IsConst>] static member terrain_outlined: IconData = nativeOnly
  [<IsConst>] static member text_decrease: IconData = nativeOnly
  [<IsConst>] static member text_decrease_sharp: IconData = nativeOnly
  [<IsConst>] static member text_decrease_rounded: IconData = nativeOnly
  [<IsConst>] static member text_decrease_outlined: IconData = nativeOnly
  [<IsConst>] static member text_fields: IconData = nativeOnly
  [<IsConst>] static member text_fields_sharp: IconData = nativeOnly
  [<IsConst>] static member text_fields_rounded: IconData = nativeOnly
  [<IsConst>] static member text_fields_outlined: IconData = nativeOnly
  [<IsConst>] static member text_format: IconData = nativeOnly
  [<IsConst>] static member text_format_sharp: IconData = nativeOnly
  [<IsConst>] static member text_format_rounded: IconData = nativeOnly
  [<IsConst>] static member text_format_outlined: IconData = nativeOnly
  [<IsConst>] static member text_increase: IconData = nativeOnly
  [<IsConst>] static member text_increase_sharp: IconData = nativeOnly
  [<IsConst>] static member text_increase_rounded: IconData = nativeOnly
  [<IsConst>] static member text_increase_outlined: IconData = nativeOnly
  [<IsConst>] static member text_rotate_up: IconData = nativeOnly
  [<IsConst>] static member text_rotate_up_sharp: IconData = nativeOnly
  [<IsConst>] static member text_rotate_up_rounded: IconData = nativeOnly
  [<IsConst>] static member text_rotate_up_outlined: IconData = nativeOnly
  [<IsConst>] static member text_rotate_vertical: IconData = nativeOnly
  [<IsConst>] static member text_rotate_vertical_sharp: IconData = nativeOnly
  [<IsConst>] static member text_rotate_vertical_rounded: IconData = nativeOnly
  [<IsConst>] static member text_rotate_vertical_outlined: IconData = nativeOnly
  [<IsConst>] static member text_rotation_angledown: IconData = nativeOnly
  [<IsConst>] static member text_rotation_angledown_sharp: IconData = nativeOnly
  [<IsConst>] static member text_rotation_angledown_rounded: IconData = nativeOnly
  [<IsConst>] static member text_rotation_angledown_outlined: IconData = nativeOnly
  [<IsConst>] static member text_rotation_angleup: IconData = nativeOnly
  [<IsConst>] static member text_rotation_angleup_sharp: IconData = nativeOnly
  [<IsConst>] static member text_rotation_angleup_rounded: IconData = nativeOnly
  [<IsConst>] static member text_rotation_angleup_outlined: IconData = nativeOnly
  [<IsConst>] static member text_rotation_down: IconData = nativeOnly
  [<IsConst>] static member text_rotation_down_sharp: IconData = nativeOnly
  [<IsConst>] static member text_rotation_down_rounded: IconData = nativeOnly
  [<IsConst>] static member text_rotation_down_outlined: IconData = nativeOnly
  [<IsConst>] static member text_rotation_none: IconData = nativeOnly
  [<IsConst>] static member text_rotation_none_sharp: IconData = nativeOnly
  [<IsConst>] static member text_rotation_none_rounded: IconData = nativeOnly
  [<IsConst>] static member text_rotation_none_outlined: IconData = nativeOnly
  [<IsConst>] static member text_snippet: IconData = nativeOnly
  [<IsConst>] static member text_snippet_sharp: IconData = nativeOnly
  [<IsConst>] static member text_snippet_rounded: IconData = nativeOnly
  [<IsConst>] static member text_snippet_outlined: IconData = nativeOnly
  [<IsConst>] static member textsms: IconData = nativeOnly
  [<IsConst>] static member textsms_sharp: IconData = nativeOnly
  [<IsConst>] static member textsms_rounded: IconData = nativeOnly
  [<IsConst>] static member textsms_outlined: IconData = nativeOnly
  [<IsConst>] static member texture: IconData = nativeOnly
  [<IsConst>] static member texture_sharp: IconData = nativeOnly
  [<IsConst>] static member texture_rounded: IconData = nativeOnly
  [<IsConst>] static member texture_outlined: IconData = nativeOnly
  [<IsConst>] static member theater_comedy: IconData = nativeOnly
  [<IsConst>] static member theater_comedy_sharp: IconData = nativeOnly
  [<IsConst>] static member theater_comedy_rounded: IconData = nativeOnly
  [<IsConst>] static member theater_comedy_outlined: IconData = nativeOnly
  [<IsConst>] static member theaters: IconData = nativeOnly
  [<IsConst>] static member theaters_sharp: IconData = nativeOnly
  [<IsConst>] static member theaters_rounded: IconData = nativeOnly
  [<IsConst>] static member theaters_outlined: IconData = nativeOnly
  [<IsConst>] static member thermostat: IconData = nativeOnly
  [<IsConst>] static member thermostat_sharp: IconData = nativeOnly
  [<IsConst>] static member thermostat_rounded: IconData = nativeOnly
  [<IsConst>] static member thermostat_outlined: IconData = nativeOnly
  [<IsConst>] static member thermostat_auto: IconData = nativeOnly
  [<IsConst>] static member thermostat_auto_sharp: IconData = nativeOnly
  [<IsConst>] static member thermostat_auto_rounded: IconData = nativeOnly
  [<IsConst>] static member thermostat_auto_outlined: IconData = nativeOnly
  [<IsConst>] static member thumb_down: IconData = nativeOnly
  [<IsConst>] static member thumb_down_sharp: IconData = nativeOnly
  [<IsConst>] static member thumb_down_rounded: IconData = nativeOnly
  [<IsConst>] static member thumb_down_outlined: IconData = nativeOnly
  [<IsConst>] static member thumb_down_alt: IconData = nativeOnly
  [<IsConst>] static member thumb_down_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member thumb_down_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member thumb_down_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member thumb_down_off_alt: IconData = nativeOnly
  [<IsConst>] static member thumb_down_off_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member thumb_down_off_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member thumb_down_off_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member thumb_up: IconData = nativeOnly
  [<IsConst>] static member thumb_up_sharp: IconData = nativeOnly
  [<IsConst>] static member thumb_up_rounded: IconData = nativeOnly
  [<IsConst>] static member thumb_up_outlined: IconData = nativeOnly
  [<IsConst>] static member thumb_up_alt: IconData = nativeOnly
  [<IsConst>] static member thumb_up_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member thumb_up_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member thumb_up_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member thumb_up_off_alt: IconData = nativeOnly
  [<IsConst>] static member thumb_up_off_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member thumb_up_off_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member thumb_up_off_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member thumbs_up_down: IconData = nativeOnly
  [<IsConst>] static member thumbs_up_down_sharp: IconData = nativeOnly
  [<IsConst>] static member thumbs_up_down_rounded: IconData = nativeOnly
  [<IsConst>] static member thumbs_up_down_outlined: IconData = nativeOnly
  [<IsConst>] static member thunderstorm: IconData = nativeOnly
  [<IsConst>] static member thunderstorm_sharp: IconData = nativeOnly
  [<IsConst>] static member thunderstorm_rounded: IconData = nativeOnly
  [<IsConst>] static member thunderstorm_outlined: IconData = nativeOnly
  [<IsConst>] static member tiktok: IconData = nativeOnly
  [<IsConst>] static member tiktok_sharp: IconData = nativeOnly
  [<IsConst>] static member tiktok_rounded: IconData = nativeOnly
  [<IsConst>] static member tiktok_outlined: IconData = nativeOnly
  [<IsConst>] static member time_to_leave: IconData = nativeOnly
  [<IsConst>] static member time_to_leave_sharp: IconData = nativeOnly
  [<IsConst>] static member time_to_leave_rounded: IconData = nativeOnly
  [<IsConst>] static member time_to_leave_outlined: IconData = nativeOnly
  [<IsConst>] static member timelapse: IconData = nativeOnly
  [<IsConst>] static member timelapse_sharp: IconData = nativeOnly
  [<IsConst>] static member timelapse_rounded: IconData = nativeOnly
  [<IsConst>] static member timelapse_outlined: IconData = nativeOnly
  [<IsConst>] static member timeline: IconData = nativeOnly
  [<IsConst>] static member timeline_sharp: IconData = nativeOnly
  [<IsConst>] static member timeline_rounded: IconData = nativeOnly
  [<IsConst>] static member timeline_outlined: IconData = nativeOnly
  [<IsConst>] static member timer: IconData = nativeOnly
  [<IsConst>] static member timer_sharp: IconData = nativeOnly
  [<IsConst>] static member timer_rounded: IconData = nativeOnly
  [<IsConst>] static member timer_outlined: IconData = nativeOnly
  [<IsConst>] static member timer_10: IconData = nativeOnly
  [<IsConst>] static member timer_10_sharp: IconData = nativeOnly
  [<IsConst>] static member timer_10_rounded: IconData = nativeOnly
  [<IsConst>] static member timer_10_outlined: IconData = nativeOnly
  [<IsConst>] static member timer_10_select: IconData = nativeOnly
  [<IsConst>] static member timer_10_select_sharp: IconData = nativeOnly
  [<IsConst>] static member timer_10_select_rounded: IconData = nativeOnly
  [<IsConst>] static member timer_10_select_outlined: IconData = nativeOnly
  [<IsConst>] static member timer_3: IconData = nativeOnly
  [<IsConst>] static member timer_3_sharp: IconData = nativeOnly
  [<IsConst>] static member timer_3_rounded: IconData = nativeOnly
  [<IsConst>] static member timer_3_outlined: IconData = nativeOnly
  [<IsConst>] static member timer_3_select: IconData = nativeOnly
  [<IsConst>] static member timer_3_select_sharp: IconData = nativeOnly
  [<IsConst>] static member timer_3_select_rounded: IconData = nativeOnly
  [<IsConst>] static member timer_3_select_outlined: IconData = nativeOnly
  [<IsConst>] static member timer_off: IconData = nativeOnly
  [<IsConst>] static member timer_off_sharp: IconData = nativeOnly
  [<IsConst>] static member timer_off_rounded: IconData = nativeOnly
  [<IsConst>] static member timer_off_outlined: IconData = nativeOnly
  [<IsConst>] static member tips_and_updates: IconData = nativeOnly
  [<IsConst>] static member tips_and_updates_sharp: IconData = nativeOnly
  [<IsConst>] static member tips_and_updates_rounded: IconData = nativeOnly
  [<IsConst>] static member tips_and_updates_outlined: IconData = nativeOnly
  [<IsConst>] static member tire_repair: IconData = nativeOnly
  [<IsConst>] static member tire_repair_sharp: IconData = nativeOnly
  [<IsConst>] static member tire_repair_rounded: IconData = nativeOnly
  [<IsConst>] static member tire_repair_outlined: IconData = nativeOnly
  [<IsConst>] static member title: IconData = nativeOnly
  [<IsConst>] static member title_sharp: IconData = nativeOnly
  [<IsConst>] static member title_rounded: IconData = nativeOnly
  [<IsConst>] static member title_outlined: IconData = nativeOnly
  [<IsConst>] static member toc: IconData = nativeOnly
  [<IsConst>] static member toc_sharp: IconData = nativeOnly
  [<IsConst>] static member toc_rounded: IconData = nativeOnly
  [<IsConst>] static member toc_outlined: IconData = nativeOnly
  [<IsConst>] static member today: IconData = nativeOnly
  [<IsConst>] static member today_sharp: IconData = nativeOnly
  [<IsConst>] static member today_rounded: IconData = nativeOnly
  [<IsConst>] static member today_outlined: IconData = nativeOnly
  [<IsConst>] static member toggle_off: IconData = nativeOnly
  [<IsConst>] static member toggle_off_sharp: IconData = nativeOnly
  [<IsConst>] static member toggle_off_rounded: IconData = nativeOnly
  [<IsConst>] static member toggle_off_outlined: IconData = nativeOnly
  [<IsConst>] static member toggle_on: IconData = nativeOnly
  [<IsConst>] static member toggle_on_sharp: IconData = nativeOnly
  [<IsConst>] static member toggle_on_rounded: IconData = nativeOnly
  [<IsConst>] static member toggle_on_outlined: IconData = nativeOnly
  [<IsConst>] static member token: IconData = nativeOnly
  [<IsConst>] static member token_sharp: IconData = nativeOnly
  [<IsConst>] static member token_rounded: IconData = nativeOnly
  [<IsConst>] static member token_outlined: IconData = nativeOnly
  [<IsConst>] static member toll: IconData = nativeOnly
  [<IsConst>] static member toll_sharp: IconData = nativeOnly
  [<IsConst>] static member toll_rounded: IconData = nativeOnly
  [<IsConst>] static member toll_outlined: IconData = nativeOnly
  [<IsConst>] static member tonality: IconData = nativeOnly
  [<IsConst>] static member tonality_sharp: IconData = nativeOnly
  [<IsConst>] static member tonality_rounded: IconData = nativeOnly
  [<IsConst>] static member tonality_outlined: IconData = nativeOnly
  [<IsConst>] static member topic: IconData = nativeOnly
  [<IsConst>] static member topic_sharp: IconData = nativeOnly
  [<IsConst>] static member topic_rounded: IconData = nativeOnly
  [<IsConst>] static member topic_outlined: IconData = nativeOnly
  [<IsConst>] static member tornado: IconData = nativeOnly
  [<IsConst>] static member tornado_sharp: IconData = nativeOnly
  [<IsConst>] static member tornado_rounded: IconData = nativeOnly
  [<IsConst>] static member tornado_outlined: IconData = nativeOnly
  [<IsConst>] static member touch_app: IconData = nativeOnly
  [<IsConst>] static member touch_app_sharp: IconData = nativeOnly
  [<IsConst>] static member touch_app_rounded: IconData = nativeOnly
  [<IsConst>] static member touch_app_outlined: IconData = nativeOnly
  [<IsConst>] static member tour: IconData = nativeOnly
  [<IsConst>] static member tour_sharp: IconData = nativeOnly
  [<IsConst>] static member tour_rounded: IconData = nativeOnly
  [<IsConst>] static member tour_outlined: IconData = nativeOnly
  [<IsConst>] static member toys: IconData = nativeOnly
  [<IsConst>] static member toys_sharp: IconData = nativeOnly
  [<IsConst>] static member toys_rounded: IconData = nativeOnly
  [<IsConst>] static member toys_outlined: IconData = nativeOnly
  [<IsConst>] static member track_changes: IconData = nativeOnly
  [<IsConst>] static member track_changes_sharp: IconData = nativeOnly
  [<IsConst>] static member track_changes_rounded: IconData = nativeOnly
  [<IsConst>] static member track_changes_outlined: IconData = nativeOnly
  [<IsConst>] static member traffic: IconData = nativeOnly
  [<IsConst>] static member traffic_sharp: IconData = nativeOnly
  [<IsConst>] static member traffic_rounded: IconData = nativeOnly
  [<IsConst>] static member traffic_outlined: IconData = nativeOnly
  [<IsConst>] static member train: IconData = nativeOnly
  [<IsConst>] static member train_sharp: IconData = nativeOnly
  [<IsConst>] static member train_rounded: IconData = nativeOnly
  [<IsConst>] static member train_outlined: IconData = nativeOnly
  [<IsConst>] static member tram: IconData = nativeOnly
  [<IsConst>] static member tram_sharp: IconData = nativeOnly
  [<IsConst>] static member tram_rounded: IconData = nativeOnly
  [<IsConst>] static member tram_outlined: IconData = nativeOnly
  [<IsConst>] static member transcribe: IconData = nativeOnly
  [<IsConst>] static member transcribe_sharp: IconData = nativeOnly
  [<IsConst>] static member transcribe_rounded: IconData = nativeOnly
  [<IsConst>] static member transcribe_outlined: IconData = nativeOnly
  [<IsConst>] static member transfer_within_a_station: IconData = nativeOnly
  [<IsConst>] static member transfer_within_a_station_sharp: IconData = nativeOnly
  [<IsConst>] static member transfer_within_a_station_rounded: IconData = nativeOnly
  [<IsConst>] static member transfer_within_a_station_outlined: IconData = nativeOnly
  [<IsConst>] static member transform: IconData = nativeOnly
  [<IsConst>] static member transform_sharp: IconData = nativeOnly
  [<IsConst>] static member transform_rounded: IconData = nativeOnly
  [<IsConst>] static member transform_outlined: IconData = nativeOnly
  [<IsConst>] static member transgender: IconData = nativeOnly
  [<IsConst>] static member transgender_sharp: IconData = nativeOnly
  [<IsConst>] static member transgender_rounded: IconData = nativeOnly
  [<IsConst>] static member transgender_outlined: IconData = nativeOnly
  [<IsConst>] static member transit_enterexit: IconData = nativeOnly
  [<IsConst>] static member transit_enterexit_sharp: IconData = nativeOnly
  [<IsConst>] static member transit_enterexit_rounded: IconData = nativeOnly
  [<IsConst>] static member transit_enterexit_outlined: IconData = nativeOnly
  [<IsConst>] static member translate: IconData = nativeOnly
  [<IsConst>] static member translate_sharp: IconData = nativeOnly
  [<IsConst>] static member translate_rounded: IconData = nativeOnly
  [<IsConst>] static member translate_outlined: IconData = nativeOnly
  [<IsConst>] static member travel_explore: IconData = nativeOnly
  [<IsConst>] static member travel_explore_sharp: IconData = nativeOnly
  [<IsConst>] static member travel_explore_rounded: IconData = nativeOnly
  [<IsConst>] static member travel_explore_outlined: IconData = nativeOnly
  [<IsConst>] static member trending_down: IconData = nativeOnly
  [<IsConst>] static member trending_down_sharp: IconData = nativeOnly
  [<IsConst>] static member trending_down_rounded: IconData = nativeOnly
  [<IsConst>] static member trending_down_outlined: IconData = nativeOnly
  [<IsConst>] static member trending_flat: IconData = nativeOnly
  [<IsConst>] static member trending_flat_sharp: IconData = nativeOnly
  [<IsConst>] static member trending_flat_rounded: IconData = nativeOnly
  [<IsConst>] static member trending_flat_outlined: IconData = nativeOnly
  [<IsConst>] static member trending_neutral: IconData = nativeOnly
  [<IsConst>] static member trending_neutral_sharp: IconData = nativeOnly
  [<IsConst>] static member trending_neutral_rounded: IconData = nativeOnly
  [<IsConst>] static member trending_neutral_outlined: IconData = nativeOnly
  [<IsConst>] static member trending_up: IconData = nativeOnly
  [<IsConst>] static member trending_up_sharp: IconData = nativeOnly
  [<IsConst>] static member trending_up_rounded: IconData = nativeOnly
  [<IsConst>] static member trending_up_outlined: IconData = nativeOnly
  [<IsConst>] static member trip_origin: IconData = nativeOnly
  [<IsConst>] static member trip_origin_sharp: IconData = nativeOnly
  [<IsConst>] static member trip_origin_rounded: IconData = nativeOnly
  [<IsConst>] static member trip_origin_outlined: IconData = nativeOnly
  [<IsConst>] static member troubleshoot: IconData = nativeOnly
  [<IsConst>] static member troubleshoot_sharp: IconData = nativeOnly
  [<IsConst>] static member troubleshoot_rounded: IconData = nativeOnly
  [<IsConst>] static member troubleshoot_outlined: IconData = nativeOnly
  [<IsConst>] static member try_sms_star: IconData = nativeOnly
  [<IsConst>] static member try_sms_star_sharp: IconData = nativeOnly
  [<IsConst>] static member try_sms_star_rounded: IconData = nativeOnly
  [<IsConst>] static member try_sms_star_outlined: IconData = nativeOnly
  [<IsConst>] static member tsunami: IconData = nativeOnly
  [<IsConst>] static member tsunami_sharp: IconData = nativeOnly
  [<IsConst>] static member tsunami_rounded: IconData = nativeOnly
  [<IsConst>] static member tsunami_outlined: IconData = nativeOnly
  [<IsConst>] static member tty: IconData = nativeOnly
  [<IsConst>] static member tty_sharp: IconData = nativeOnly
  [<IsConst>] static member tty_rounded: IconData = nativeOnly
  [<IsConst>] static member tty_outlined: IconData = nativeOnly
  [<IsConst>] static member tune: IconData = nativeOnly
  [<IsConst>] static member tune_sharp: IconData = nativeOnly
  [<IsConst>] static member tune_rounded: IconData = nativeOnly
  [<IsConst>] static member tune_outlined: IconData = nativeOnly
  [<IsConst>] static member tungsten: IconData = nativeOnly
  [<IsConst>] static member tungsten_sharp: IconData = nativeOnly
  [<IsConst>] static member tungsten_rounded: IconData = nativeOnly
  [<IsConst>] static member tungsten_outlined: IconData = nativeOnly
  [<IsConst>] static member turn_left: IconData = nativeOnly
  [<IsConst>] static member turn_left_sharp: IconData = nativeOnly
  [<IsConst>] static member turn_left_rounded: IconData = nativeOnly
  [<IsConst>] static member turn_left_outlined: IconData = nativeOnly
  [<IsConst>] static member turn_right: IconData = nativeOnly
  [<IsConst>] static member turn_right_sharp: IconData = nativeOnly
  [<IsConst>] static member turn_right_rounded: IconData = nativeOnly
  [<IsConst>] static member turn_right_outlined: IconData = nativeOnly
  [<IsConst>] static member turn_sharp_left: IconData = nativeOnly
  [<IsConst>] static member turn_sharp_left_sharp: IconData = nativeOnly
  [<IsConst>] static member turn_sharp_left_rounded: IconData = nativeOnly
  [<IsConst>] static member turn_sharp_left_outlined: IconData = nativeOnly
  [<IsConst>] static member turn_sharp_right: IconData = nativeOnly
  [<IsConst>] static member turn_sharp_right_sharp: IconData = nativeOnly
  [<IsConst>] static member turn_sharp_right_rounded: IconData = nativeOnly
  [<IsConst>] static member turn_sharp_right_outlined: IconData = nativeOnly
  [<IsConst>] static member turn_slight_left: IconData = nativeOnly
  [<IsConst>] static member turn_slight_left_sharp: IconData = nativeOnly
  [<IsConst>] static member turn_slight_left_rounded: IconData = nativeOnly
  [<IsConst>] static member turn_slight_left_outlined: IconData = nativeOnly
  [<IsConst>] static member turn_slight_right: IconData = nativeOnly
  [<IsConst>] static member turn_slight_right_sharp: IconData = nativeOnly
  [<IsConst>] static member turn_slight_right_rounded: IconData = nativeOnly
  [<IsConst>] static member turn_slight_right_outlined: IconData = nativeOnly
  [<IsConst>] static member turned_in: IconData = nativeOnly
  [<IsConst>] static member turned_in_sharp: IconData = nativeOnly
  [<IsConst>] static member turned_in_rounded: IconData = nativeOnly
  [<IsConst>] static member turned_in_outlined: IconData = nativeOnly
  [<IsConst>] static member turned_in_not: IconData = nativeOnly
  [<IsConst>] static member turned_in_not_sharp: IconData = nativeOnly
  [<IsConst>] static member turned_in_not_rounded: IconData = nativeOnly
  [<IsConst>] static member turned_in_not_outlined: IconData = nativeOnly
  [<IsConst>] static member tv: IconData = nativeOnly
  [<IsConst>] static member tv_sharp: IconData = nativeOnly
  [<IsConst>] static member tv_rounded: IconData = nativeOnly
  [<IsConst>] static member tv_outlined: IconData = nativeOnly
  [<IsConst>] static member tv_off: IconData = nativeOnly
  [<IsConst>] static member tv_off_sharp: IconData = nativeOnly
  [<IsConst>] static member tv_off_rounded: IconData = nativeOnly
  [<IsConst>] static member tv_off_outlined: IconData = nativeOnly
  [<IsConst>] static member two_wheeler: IconData = nativeOnly
  [<IsConst>] static member two_wheeler_sharp: IconData = nativeOnly
  [<IsConst>] static member two_wheeler_rounded: IconData = nativeOnly
  [<IsConst>] static member two_wheeler_outlined: IconData = nativeOnly
  [<IsConst>] static member type_specimen: IconData = nativeOnly
  [<IsConst>] static member type_specimen_sharp: IconData = nativeOnly
  [<IsConst>] static member type_specimen_rounded: IconData = nativeOnly
  [<IsConst>] static member type_specimen_outlined: IconData = nativeOnly
  [<IsConst>] static member u_turn_left: IconData = nativeOnly
  [<IsConst>] static member u_turn_left_sharp: IconData = nativeOnly
  [<IsConst>] static member u_turn_left_rounded: IconData = nativeOnly
  [<IsConst>] static member u_turn_left_outlined: IconData = nativeOnly
  [<IsConst>] static member u_turn_right: IconData = nativeOnly
  [<IsConst>] static member u_turn_right_sharp: IconData = nativeOnly
  [<IsConst>] static member u_turn_right_rounded: IconData = nativeOnly
  [<IsConst>] static member u_turn_right_outlined: IconData = nativeOnly
  [<IsConst>] static member umbrella: IconData = nativeOnly
  [<IsConst>] static member umbrella_sharp: IconData = nativeOnly
  [<IsConst>] static member umbrella_rounded: IconData = nativeOnly
  [<IsConst>] static member umbrella_outlined: IconData = nativeOnly
  [<IsConst>] static member unarchive: IconData = nativeOnly
  [<IsConst>] static member unarchive_sharp: IconData = nativeOnly
  [<IsConst>] static member unarchive_rounded: IconData = nativeOnly
  [<IsConst>] static member unarchive_outlined: IconData = nativeOnly
  [<IsConst>] static member undo: IconData = nativeOnly
  [<IsConst>] static member undo_sharp: IconData = nativeOnly
  [<IsConst>] static member undo_rounded: IconData = nativeOnly
  [<IsConst>] static member undo_outlined: IconData = nativeOnly
  [<IsConst>] static member unfold_less: IconData = nativeOnly
  [<IsConst>] static member unfold_less_sharp: IconData = nativeOnly
  [<IsConst>] static member unfold_less_rounded: IconData = nativeOnly
  [<IsConst>] static member unfold_less_outlined: IconData = nativeOnly
  [<IsConst>] static member unfold_more: IconData = nativeOnly
  [<IsConst>] static member unfold_more_sharp: IconData = nativeOnly
  [<IsConst>] static member unfold_more_rounded: IconData = nativeOnly
  [<IsConst>] static member unfold_more_outlined: IconData = nativeOnly
  [<IsConst>] static member unpublished: IconData = nativeOnly
  [<IsConst>] static member unpublished_sharp: IconData = nativeOnly
  [<IsConst>] static member unpublished_rounded: IconData = nativeOnly
  [<IsConst>] static member unpublished_outlined: IconData = nativeOnly
  [<IsConst>] static member unsubscribe: IconData = nativeOnly
  [<IsConst>] static member unsubscribe_sharp: IconData = nativeOnly
  [<IsConst>] static member unsubscribe_rounded: IconData = nativeOnly
  [<IsConst>] static member unsubscribe_outlined: IconData = nativeOnly
  [<IsConst>] static member upcoming: IconData = nativeOnly
  [<IsConst>] static member upcoming_sharp: IconData = nativeOnly
  [<IsConst>] static member upcoming_rounded: IconData = nativeOnly
  [<IsConst>] static member upcoming_outlined: IconData = nativeOnly
  [<IsConst>] static member update: IconData = nativeOnly
  [<IsConst>] static member update_sharp: IconData = nativeOnly
  [<IsConst>] static member update_rounded: IconData = nativeOnly
  [<IsConst>] static member update_outlined: IconData = nativeOnly
  [<IsConst>] static member update_disabled: IconData = nativeOnly
  [<IsConst>] static member update_disabled_sharp: IconData = nativeOnly
  [<IsConst>] static member update_disabled_rounded: IconData = nativeOnly
  [<IsConst>] static member update_disabled_outlined: IconData = nativeOnly
  [<IsConst>] static member upgrade: IconData = nativeOnly
  [<IsConst>] static member upgrade_sharp: IconData = nativeOnly
  [<IsConst>] static member upgrade_rounded: IconData = nativeOnly
  [<IsConst>] static member upgrade_outlined: IconData = nativeOnly
  [<IsConst>] static member upload: IconData = nativeOnly
  [<IsConst>] static member upload_sharp: IconData = nativeOnly
  [<IsConst>] static member upload_rounded: IconData = nativeOnly
  [<IsConst>] static member upload_outlined: IconData = nativeOnly
  [<IsConst>] static member upload_file: IconData = nativeOnly
  [<IsConst>] static member upload_file_sharp: IconData = nativeOnly
  [<IsConst>] static member upload_file_rounded: IconData = nativeOnly
  [<IsConst>] static member upload_file_outlined: IconData = nativeOnly
  [<IsConst>] static member usb: IconData = nativeOnly
  [<IsConst>] static member usb_sharp: IconData = nativeOnly
  [<IsConst>] static member usb_rounded: IconData = nativeOnly
  [<IsConst>] static member usb_outlined: IconData = nativeOnly
  [<IsConst>] static member usb_off: IconData = nativeOnly
  [<IsConst>] static member usb_off_sharp: IconData = nativeOnly
  [<IsConst>] static member usb_off_rounded: IconData = nativeOnly
  [<IsConst>] static member usb_off_outlined: IconData = nativeOnly
  [<IsConst>] static member vaccines: IconData = nativeOnly
  [<IsConst>] static member vaccines_sharp: IconData = nativeOnly
  [<IsConst>] static member vaccines_rounded: IconData = nativeOnly
  [<IsConst>] static member vaccines_outlined: IconData = nativeOnly
  [<IsConst>] static member vape_free: IconData = nativeOnly
  [<IsConst>] static member vape_free_sharp: IconData = nativeOnly
  [<IsConst>] static member vape_free_rounded: IconData = nativeOnly
  [<IsConst>] static member vape_free_outlined: IconData = nativeOnly
  [<IsConst>] static member vaping_rooms: IconData = nativeOnly
  [<IsConst>] static member vaping_rooms_sharp: IconData = nativeOnly
  [<IsConst>] static member vaping_rooms_rounded: IconData = nativeOnly
  [<IsConst>] static member vaping_rooms_outlined: IconData = nativeOnly
  [<IsConst>] static member verified: IconData = nativeOnly
  [<IsConst>] static member verified_sharp: IconData = nativeOnly
  [<IsConst>] static member verified_rounded: IconData = nativeOnly
  [<IsConst>] static member verified_outlined: IconData = nativeOnly
  [<IsConst>] static member verified_user: IconData = nativeOnly
  [<IsConst>] static member verified_user_sharp: IconData = nativeOnly
  [<IsConst>] static member verified_user_rounded: IconData = nativeOnly
  [<IsConst>] static member verified_user_outlined: IconData = nativeOnly
  [<IsConst>] static member vertical_align_bottom: IconData = nativeOnly
  [<IsConst>] static member vertical_align_bottom_sharp: IconData = nativeOnly
  [<IsConst>] static member vertical_align_bottom_rounded: IconData = nativeOnly
  [<IsConst>] static member vertical_align_bottom_outlined: IconData = nativeOnly
  [<IsConst>] static member vertical_align_center: IconData = nativeOnly
  [<IsConst>] static member vertical_align_center_sharp: IconData = nativeOnly
  [<IsConst>] static member vertical_align_center_rounded: IconData = nativeOnly
  [<IsConst>] static member vertical_align_center_outlined: IconData = nativeOnly
  [<IsConst>] static member vertical_align_top: IconData = nativeOnly
  [<IsConst>] static member vertical_align_top_sharp: IconData = nativeOnly
  [<IsConst>] static member vertical_align_top_rounded: IconData = nativeOnly
  [<IsConst>] static member vertical_align_top_outlined: IconData = nativeOnly
  [<IsConst>] static member vertical_distribute: IconData = nativeOnly
  [<IsConst>] static member vertical_distribute_sharp: IconData = nativeOnly
  [<IsConst>] static member vertical_distribute_rounded: IconData = nativeOnly
  [<IsConst>] static member vertical_distribute_outlined: IconData = nativeOnly
  [<IsConst>] static member vertical_shades: IconData = nativeOnly
  [<IsConst>] static member vertical_shades_sharp: IconData = nativeOnly
  [<IsConst>] static member vertical_shades_rounded: IconData = nativeOnly
  [<IsConst>] static member vertical_shades_outlined: IconData = nativeOnly
  [<IsConst>] static member vertical_shades_closed: IconData = nativeOnly
  [<IsConst>] static member vertical_shades_closed_sharp: IconData = nativeOnly
  [<IsConst>] static member vertical_shades_closed_rounded: IconData = nativeOnly
  [<IsConst>] static member vertical_shades_closed_outlined: IconData = nativeOnly
  [<IsConst>] static member vertical_split: IconData = nativeOnly
  [<IsConst>] static member vertical_split_sharp: IconData = nativeOnly
  [<IsConst>] static member vertical_split_rounded: IconData = nativeOnly
  [<IsConst>] static member vertical_split_outlined: IconData = nativeOnly
  [<IsConst>] static member vibration: IconData = nativeOnly
  [<IsConst>] static member vibration_sharp: IconData = nativeOnly
  [<IsConst>] static member vibration_rounded: IconData = nativeOnly
  [<IsConst>] static member vibration_outlined: IconData = nativeOnly
  [<IsConst>] static member video_call: IconData = nativeOnly
  [<IsConst>] static member video_call_sharp: IconData = nativeOnly
  [<IsConst>] static member video_call_rounded: IconData = nativeOnly
  [<IsConst>] static member video_call_outlined: IconData = nativeOnly
  [<IsConst>] static member video_camera_back: IconData = nativeOnly
  [<IsConst>] static member video_camera_back_sharp: IconData = nativeOnly
  [<IsConst>] static member video_camera_back_rounded: IconData = nativeOnly
  [<IsConst>] static member video_camera_back_outlined: IconData = nativeOnly
  [<IsConst>] static member video_camera_front: IconData = nativeOnly
  [<IsConst>] static member video_camera_front_sharp: IconData = nativeOnly
  [<IsConst>] static member video_camera_front_rounded: IconData = nativeOnly
  [<IsConst>] static member video_camera_front_outlined: IconData = nativeOnly
  [<IsConst>] static member video_collection: IconData = nativeOnly
  [<IsConst>] static member video_collection_sharp: IconData = nativeOnly
  [<IsConst>] static member video_collection_rounded: IconData = nativeOnly
  [<IsConst>] static member video_collection_outlined: IconData = nativeOnly
  [<IsConst>] static member video_file: IconData = nativeOnly
  [<IsConst>] static member video_file_sharp: IconData = nativeOnly
  [<IsConst>] static member video_file_rounded: IconData = nativeOnly
  [<IsConst>] static member video_file_outlined: IconData = nativeOnly
  [<IsConst>] static member video_label: IconData = nativeOnly
  [<IsConst>] static member video_label_sharp: IconData = nativeOnly
  [<IsConst>] static member video_label_rounded: IconData = nativeOnly
  [<IsConst>] static member video_label_outlined: IconData = nativeOnly
  [<IsConst>] static member video_library: IconData = nativeOnly
  [<IsConst>] static member video_library_sharp: IconData = nativeOnly
  [<IsConst>] static member video_library_rounded: IconData = nativeOnly
  [<IsConst>] static member video_library_outlined: IconData = nativeOnly
  [<IsConst>] static member video_settings: IconData = nativeOnly
  [<IsConst>] static member video_settings_sharp: IconData = nativeOnly
  [<IsConst>] static member video_settings_rounded: IconData = nativeOnly
  [<IsConst>] static member video_settings_outlined: IconData = nativeOnly
  [<IsConst>] static member video_stable: IconData = nativeOnly
  [<IsConst>] static member video_stable_sharp: IconData = nativeOnly
  [<IsConst>] static member video_stable_rounded: IconData = nativeOnly
  [<IsConst>] static member video_stable_outlined: IconData = nativeOnly
  [<IsConst>] static member videocam: IconData = nativeOnly
  [<IsConst>] static member videocam_sharp: IconData = nativeOnly
  [<IsConst>] static member videocam_rounded: IconData = nativeOnly
  [<IsConst>] static member videocam_outlined: IconData = nativeOnly
  [<IsConst>] static member videocam_off: IconData = nativeOnly
  [<IsConst>] static member videocam_off_sharp: IconData = nativeOnly
  [<IsConst>] static member videocam_off_rounded: IconData = nativeOnly
  [<IsConst>] static member videocam_off_outlined: IconData = nativeOnly
  [<IsConst>] static member videogame_asset: IconData = nativeOnly
  [<IsConst>] static member videogame_asset_sharp: IconData = nativeOnly
  [<IsConst>] static member videogame_asset_rounded: IconData = nativeOnly
  [<IsConst>] static member videogame_asset_outlined: IconData = nativeOnly
  [<IsConst>] static member videogame_asset_off: IconData = nativeOnly
  [<IsConst>] static member videogame_asset_off_sharp: IconData = nativeOnly
  [<IsConst>] static member videogame_asset_off_rounded: IconData = nativeOnly
  [<IsConst>] static member videogame_asset_off_outlined: IconData = nativeOnly
  [<IsConst>] static member view_agenda: IconData = nativeOnly
  [<IsConst>] static member view_agenda_sharp: IconData = nativeOnly
  [<IsConst>] static member view_agenda_rounded: IconData = nativeOnly
  [<IsConst>] static member view_agenda_outlined: IconData = nativeOnly
  [<IsConst>] static member view_array: IconData = nativeOnly
  [<IsConst>] static member view_array_sharp: IconData = nativeOnly
  [<IsConst>] static member view_array_rounded: IconData = nativeOnly
  [<IsConst>] static member view_array_outlined: IconData = nativeOnly
  [<IsConst>] static member view_carousel: IconData = nativeOnly
  [<IsConst>] static member view_carousel_sharp: IconData = nativeOnly
  [<IsConst>] static member view_carousel_rounded: IconData = nativeOnly
  [<IsConst>] static member view_carousel_outlined: IconData = nativeOnly
  [<IsConst>] static member view_column: IconData = nativeOnly
  [<IsConst>] static member view_column_sharp: IconData = nativeOnly
  [<IsConst>] static member view_column_rounded: IconData = nativeOnly
  [<IsConst>] static member view_column_outlined: IconData = nativeOnly
  [<IsConst>] static member view_comfortable: IconData = nativeOnly
  [<IsConst>] static member view_comfortable_sharp: IconData = nativeOnly
  [<IsConst>] static member view_comfortable_rounded: IconData = nativeOnly
  [<IsConst>] static member view_comfortable_outlined: IconData = nativeOnly
  [<IsConst>] static member view_comfy: IconData = nativeOnly
  [<IsConst>] static member view_comfy_sharp: IconData = nativeOnly
  [<IsConst>] static member view_comfy_rounded: IconData = nativeOnly
  [<IsConst>] static member view_comfy_outlined: IconData = nativeOnly
  [<IsConst>] static member view_comfy_alt: IconData = nativeOnly
  [<IsConst>] static member view_comfy_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member view_comfy_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member view_comfy_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member view_compact: IconData = nativeOnly
  [<IsConst>] static member view_compact_sharp: IconData = nativeOnly
  [<IsConst>] static member view_compact_rounded: IconData = nativeOnly
  [<IsConst>] static member view_compact_outlined: IconData = nativeOnly
  [<IsConst>] static member view_compact_alt: IconData = nativeOnly
  [<IsConst>] static member view_compact_alt_sharp: IconData = nativeOnly
  [<IsConst>] static member view_compact_alt_rounded: IconData = nativeOnly
  [<IsConst>] static member view_compact_alt_outlined: IconData = nativeOnly
  [<IsConst>] static member view_cozy: IconData = nativeOnly
  [<IsConst>] static member view_cozy_sharp: IconData = nativeOnly
  [<IsConst>] static member view_cozy_rounded: IconData = nativeOnly
  [<IsConst>] static member view_cozy_outlined: IconData = nativeOnly
  [<IsConst>] static member view_day: IconData = nativeOnly
  [<IsConst>] static member view_day_sharp: IconData = nativeOnly
  [<IsConst>] static member view_day_rounded: IconData = nativeOnly
  [<IsConst>] static member view_day_outlined: IconData = nativeOnly
  [<IsConst>] static member view_headline: IconData = nativeOnly
  [<IsConst>] static member view_headline_sharp: IconData = nativeOnly
  [<IsConst>] static member view_headline_rounded: IconData = nativeOnly
  [<IsConst>] static member view_headline_outlined: IconData = nativeOnly
  [<IsConst>] static member view_in_ar: IconData = nativeOnly
  [<IsConst>] static member view_in_ar_sharp: IconData = nativeOnly
  [<IsConst>] static member view_in_ar_rounded: IconData = nativeOnly
  [<IsConst>] static member view_in_ar_outlined: IconData = nativeOnly
  [<IsConst>] static member view_kanban: IconData = nativeOnly
  [<IsConst>] static member view_kanban_sharp: IconData = nativeOnly
  [<IsConst>] static member view_kanban_rounded: IconData = nativeOnly
  [<IsConst>] static member view_kanban_outlined: IconData = nativeOnly
  [<IsConst>] static member view_list: IconData = nativeOnly
  [<IsConst>] static member view_list_sharp: IconData = nativeOnly
  [<IsConst>] static member view_list_rounded: IconData = nativeOnly
  [<IsConst>] static member view_list_outlined: IconData = nativeOnly
  [<IsConst>] static member view_module: IconData = nativeOnly
  [<IsConst>] static member view_module_sharp: IconData = nativeOnly
  [<IsConst>] static member view_module_rounded: IconData = nativeOnly
  [<IsConst>] static member view_module_outlined: IconData = nativeOnly
  [<IsConst>] static member view_quilt: IconData = nativeOnly
  [<IsConst>] static member view_quilt_sharp: IconData = nativeOnly
  [<IsConst>] static member view_quilt_rounded: IconData = nativeOnly
  [<IsConst>] static member view_quilt_outlined: IconData = nativeOnly
  [<IsConst>] static member view_sidebar: IconData = nativeOnly
  [<IsConst>] static member view_sidebar_sharp: IconData = nativeOnly
  [<IsConst>] static member view_sidebar_rounded: IconData = nativeOnly
  [<IsConst>] static member view_sidebar_outlined: IconData = nativeOnly
  [<IsConst>] static member view_stream: IconData = nativeOnly
  [<IsConst>] static member view_stream_sharp: IconData = nativeOnly
  [<IsConst>] static member view_stream_rounded: IconData = nativeOnly
  [<IsConst>] static member view_stream_outlined: IconData = nativeOnly
  [<IsConst>] static member view_timeline: IconData = nativeOnly
  [<IsConst>] static member view_timeline_sharp: IconData = nativeOnly
  [<IsConst>] static member view_timeline_rounded: IconData = nativeOnly
  [<IsConst>] static member view_timeline_outlined: IconData = nativeOnly
  [<IsConst>] static member view_week: IconData = nativeOnly
  [<IsConst>] static member view_week_sharp: IconData = nativeOnly
  [<IsConst>] static member view_week_rounded: IconData = nativeOnly
  [<IsConst>] static member view_week_outlined: IconData = nativeOnly
  [<IsConst>] static member vignette: IconData = nativeOnly
  [<IsConst>] static member vignette_sharp: IconData = nativeOnly
  [<IsConst>] static member vignette_rounded: IconData = nativeOnly
  [<IsConst>] static member vignette_outlined: IconData = nativeOnly
  [<IsConst>] static member villa: IconData = nativeOnly
  [<IsConst>] static member villa_sharp: IconData = nativeOnly
  [<IsConst>] static member villa_rounded: IconData = nativeOnly
  [<IsConst>] static member villa_outlined: IconData = nativeOnly
  [<IsConst>] static member visibility: IconData = nativeOnly
  [<IsConst>] static member visibility_sharp: IconData = nativeOnly
  [<IsConst>] static member visibility_rounded: IconData = nativeOnly
  [<IsConst>] static member visibility_outlined: IconData = nativeOnly
  [<IsConst>] static member visibility_off: IconData = nativeOnly
  [<IsConst>] static member visibility_off_sharp: IconData = nativeOnly
  [<IsConst>] static member visibility_off_rounded: IconData = nativeOnly
  [<IsConst>] static member visibility_off_outlined: IconData = nativeOnly
  [<IsConst>] static member voice_chat: IconData = nativeOnly
  [<IsConst>] static member voice_chat_sharp: IconData = nativeOnly
  [<IsConst>] static member voice_chat_rounded: IconData = nativeOnly
  [<IsConst>] static member voice_chat_outlined: IconData = nativeOnly
  [<IsConst>] static member voice_over_off: IconData = nativeOnly
  [<IsConst>] static member voice_over_off_sharp: IconData = nativeOnly
  [<IsConst>] static member voice_over_off_rounded: IconData = nativeOnly
  [<IsConst>] static member voice_over_off_outlined: IconData = nativeOnly
  [<IsConst>] static member voicemail: IconData = nativeOnly
  [<IsConst>] static member voicemail_sharp: IconData = nativeOnly
  [<IsConst>] static member voicemail_rounded: IconData = nativeOnly
  [<IsConst>] static member voicemail_outlined: IconData = nativeOnly
  [<IsConst>] static member volcano: IconData = nativeOnly
  [<IsConst>] static member volcano_sharp: IconData = nativeOnly
  [<IsConst>] static member volcano_rounded: IconData = nativeOnly
  [<IsConst>] static member volcano_outlined: IconData = nativeOnly
  [<IsConst>] static member volume_down: IconData = nativeOnly
  [<IsConst>] static member volume_down_sharp: IconData = nativeOnly
  [<IsConst>] static member volume_down_rounded: IconData = nativeOnly
  [<IsConst>] static member volume_down_outlined: IconData = nativeOnly
  [<IsConst>] static member volume_down_alt: IconData = nativeOnly
  [<IsConst>] static member volume_mute: IconData = nativeOnly
  [<IsConst>] static member volume_mute_sharp: IconData = nativeOnly
  [<IsConst>] static member volume_mute_rounded: IconData = nativeOnly
  [<IsConst>] static member volume_mute_outlined: IconData = nativeOnly
  [<IsConst>] static member volume_off: IconData = nativeOnly
  [<IsConst>] static member volume_off_sharp: IconData = nativeOnly
  [<IsConst>] static member volume_off_rounded: IconData = nativeOnly
  [<IsConst>] static member volume_off_outlined: IconData = nativeOnly
  [<IsConst>] static member volume_up: IconData = nativeOnly
  [<IsConst>] static member volume_up_sharp: IconData = nativeOnly
  [<IsConst>] static member volume_up_rounded: IconData = nativeOnly
  [<IsConst>] static member volume_up_outlined: IconData = nativeOnly
  [<IsConst>] static member volunteer_activism: IconData = nativeOnly
  [<IsConst>] static member volunteer_activism_sharp: IconData = nativeOnly
  [<IsConst>] static member volunteer_activism_rounded: IconData = nativeOnly
  [<IsConst>] static member volunteer_activism_outlined: IconData = nativeOnly
  [<IsConst>] static member vpn_key: IconData = nativeOnly
  [<IsConst>] static member vpn_key_sharp: IconData = nativeOnly
  [<IsConst>] static member vpn_key_rounded: IconData = nativeOnly
  [<IsConst>] static member vpn_key_outlined: IconData = nativeOnly
  [<IsConst>] static member vpn_key_off: IconData = nativeOnly
  [<IsConst>] static member vpn_key_off_sharp: IconData = nativeOnly
  [<IsConst>] static member vpn_key_off_rounded: IconData = nativeOnly
  [<IsConst>] static member vpn_key_off_outlined: IconData = nativeOnly
  [<IsConst>] static member vpn_lock: IconData = nativeOnly
  [<IsConst>] static member vpn_lock_sharp: IconData = nativeOnly
  [<IsConst>] static member vpn_lock_rounded: IconData = nativeOnly
  [<IsConst>] static member vpn_lock_outlined: IconData = nativeOnly
  [<IsConst>] static member vrpano: IconData = nativeOnly
  [<IsConst>] static member vrpano_sharp: IconData = nativeOnly
  [<IsConst>] static member vrpano_rounded: IconData = nativeOnly
  [<IsConst>] static member vrpano_outlined: IconData = nativeOnly
  [<IsConst>] static member wallet: IconData = nativeOnly
  [<IsConst>] static member wallet_sharp: IconData = nativeOnly
  [<IsConst>] static member wallet_rounded: IconData = nativeOnly
  [<IsConst>] static member wallet_outlined: IconData = nativeOnly
  [<IsConst>] static member wallet_giftcard: IconData = nativeOnly
  [<IsConst>] static member wallet_giftcard_sharp: IconData = nativeOnly
  [<IsConst>] static member wallet_giftcard_rounded: IconData = nativeOnly
  [<IsConst>] static member wallet_giftcard_outlined: IconData = nativeOnly
  [<IsConst>] static member wallet_membership: IconData = nativeOnly
  [<IsConst>] static member wallet_membership_sharp: IconData = nativeOnly
  [<IsConst>] static member wallet_membership_rounded: IconData = nativeOnly
  [<IsConst>] static member wallet_membership_outlined: IconData = nativeOnly
  [<IsConst>] static member wallet_travel: IconData = nativeOnly
  [<IsConst>] static member wallet_travel_sharp: IconData = nativeOnly
  [<IsConst>] static member wallet_travel_rounded: IconData = nativeOnly
  [<IsConst>] static member wallet_travel_outlined: IconData = nativeOnly
  [<IsConst>] static member wallpaper: IconData = nativeOnly
  [<IsConst>] static member wallpaper_sharp: IconData = nativeOnly
  [<IsConst>] static member wallpaper_rounded: IconData = nativeOnly
  [<IsConst>] static member wallpaper_outlined: IconData = nativeOnly
  [<IsConst>] static member warehouse: IconData = nativeOnly
  [<IsConst>] static member warehouse_sharp: IconData = nativeOnly
  [<IsConst>] static member warehouse_rounded: IconData = nativeOnly
  [<IsConst>] static member warehouse_outlined: IconData = nativeOnly
  [<IsConst>] static member warning: IconData = nativeOnly
  [<IsConst>] static member warning_sharp: IconData = nativeOnly
  [<IsConst>] static member warning_rounded: IconData = nativeOnly
  [<IsConst>] static member warning_outlined: IconData = nativeOnly
  [<IsConst>] static member warning_amber: IconData = nativeOnly
  [<IsConst>] static member warning_amber_sharp: IconData = nativeOnly
  [<IsConst>] static member warning_amber_rounded: IconData = nativeOnly
  [<IsConst>] static member warning_amber_outlined: IconData = nativeOnly
  [<IsConst>] static member wash: IconData = nativeOnly
  [<IsConst>] static member wash_sharp: IconData = nativeOnly
  [<IsConst>] static member wash_rounded: IconData = nativeOnly
  [<IsConst>] static member wash_outlined: IconData = nativeOnly
  [<IsConst>] static member watch: IconData = nativeOnly
  [<IsConst>] static member watch_sharp: IconData = nativeOnly
  [<IsConst>] static member watch_rounded: IconData = nativeOnly
  [<IsConst>] static member watch_outlined: IconData = nativeOnly
  [<IsConst>] static member watch_later: IconData = nativeOnly
  [<IsConst>] static member watch_later_sharp: IconData = nativeOnly
  [<IsConst>] static member watch_later_rounded: IconData = nativeOnly
  [<IsConst>] static member watch_later_outlined: IconData = nativeOnly
  [<IsConst>] static member watch_off: IconData = nativeOnly
  [<IsConst>] static member watch_off_sharp: IconData = nativeOnly
  [<IsConst>] static member watch_off_rounded: IconData = nativeOnly
  [<IsConst>] static member watch_off_outlined: IconData = nativeOnly
  [<IsConst>] static member water: IconData = nativeOnly
  [<IsConst>] static member water_sharp: IconData = nativeOnly
  [<IsConst>] static member water_rounded: IconData = nativeOnly
  [<IsConst>] static member water_outlined: IconData = nativeOnly
  [<IsConst>] static member water_damage: IconData = nativeOnly
  [<IsConst>] static member water_damage_sharp: IconData = nativeOnly
  [<IsConst>] static member water_damage_rounded: IconData = nativeOnly
  [<IsConst>] static member water_damage_outlined: IconData = nativeOnly
  [<IsConst>] static member water_drop: IconData = nativeOnly
  [<IsConst>] static member water_drop_sharp: IconData = nativeOnly
  [<IsConst>] static member water_drop_rounded: IconData = nativeOnly
  [<IsConst>] static member water_drop_outlined: IconData = nativeOnly
  [<IsConst>] static member waterfall_chart: IconData = nativeOnly
  [<IsConst>] static member waterfall_chart_sharp: IconData = nativeOnly
  [<IsConst>] static member waterfall_chart_rounded: IconData = nativeOnly
  [<IsConst>] static member waterfall_chart_outlined: IconData = nativeOnly
  [<IsConst>] static member waves: IconData = nativeOnly
  [<IsConst>] static member waves_sharp: IconData = nativeOnly
  [<IsConst>] static member waves_rounded: IconData = nativeOnly
  [<IsConst>] static member waves_outlined: IconData = nativeOnly
  [<IsConst>] static member waving_hand: IconData = nativeOnly
  [<IsConst>] static member waving_hand_sharp: IconData = nativeOnly
  [<IsConst>] static member waving_hand_rounded: IconData = nativeOnly
  [<IsConst>] static member waving_hand_outlined: IconData = nativeOnly
  [<IsConst>] static member wb_auto: IconData = nativeOnly
  [<IsConst>] static member wb_auto_sharp: IconData = nativeOnly
  [<IsConst>] static member wb_auto_rounded: IconData = nativeOnly
  [<IsConst>] static member wb_auto_outlined: IconData = nativeOnly
  [<IsConst>] static member wb_cloudy: IconData = nativeOnly
  [<IsConst>] static member wb_cloudy_sharp: IconData = nativeOnly
  [<IsConst>] static member wb_cloudy_rounded: IconData = nativeOnly
  [<IsConst>] static member wb_cloudy_outlined: IconData = nativeOnly
  [<IsConst>] static member wb_incandescent: IconData = nativeOnly
  [<IsConst>] static member wb_incandescent_sharp: IconData = nativeOnly
  [<IsConst>] static member wb_incandescent_rounded: IconData = nativeOnly
  [<IsConst>] static member wb_incandescent_outlined: IconData = nativeOnly
  [<IsConst>] static member wb_iridescent: IconData = nativeOnly
  [<IsConst>] static member wb_iridescent_sharp: IconData = nativeOnly
  [<IsConst>] static member wb_iridescent_rounded: IconData = nativeOnly
  [<IsConst>] static member wb_iridescent_outlined: IconData = nativeOnly
  [<IsConst>] static member wb_shade: IconData = nativeOnly
  [<IsConst>] static member wb_shade_sharp: IconData = nativeOnly
  [<IsConst>] static member wb_shade_rounded: IconData = nativeOnly
  [<IsConst>] static member wb_shade_outlined: IconData = nativeOnly
  [<IsConst>] static member wb_sunny: IconData = nativeOnly
  [<IsConst>] static member wb_sunny_sharp: IconData = nativeOnly
  [<IsConst>] static member wb_sunny_rounded: IconData = nativeOnly
  [<IsConst>] static member wb_sunny_outlined: IconData = nativeOnly
  [<IsConst>] static member wb_twighlight: IconData = nativeOnly
  [<IsConst>] static member wb_twilight: IconData = nativeOnly
  [<IsConst>] static member wb_twilight_sharp: IconData = nativeOnly
  [<IsConst>] static member wb_twilight_rounded: IconData = nativeOnly
  [<IsConst>] static member wb_twilight_outlined: IconData = nativeOnly
  [<IsConst>] static member wc: IconData = nativeOnly
  [<IsConst>] static member wc_sharp: IconData = nativeOnly
  [<IsConst>] static member wc_rounded: IconData = nativeOnly
  [<IsConst>] static member wc_outlined: IconData = nativeOnly
  [<IsConst>] static member web: IconData = nativeOnly
  [<IsConst>] static member web_sharp: IconData = nativeOnly
  [<IsConst>] static member web_rounded: IconData = nativeOnly
  [<IsConst>] static member web_outlined: IconData = nativeOnly
  [<IsConst>] static member web_asset: IconData = nativeOnly
  [<IsConst>] static member web_asset_sharp: IconData = nativeOnly
  [<IsConst>] static member web_asset_rounded: IconData = nativeOnly
  [<IsConst>] static member web_asset_outlined: IconData = nativeOnly
  [<IsConst>] static member web_asset_off: IconData = nativeOnly
  [<IsConst>] static member web_asset_off_sharp: IconData = nativeOnly
  [<IsConst>] static member web_asset_off_rounded: IconData = nativeOnly
  [<IsConst>] static member web_asset_off_outlined: IconData = nativeOnly
  [<IsConst>] static member web_stories: IconData = nativeOnly
  [<IsConst>] static member webhook: IconData = nativeOnly
  [<IsConst>] static member webhook_sharp: IconData = nativeOnly
  [<IsConst>] static member webhook_rounded: IconData = nativeOnly
  [<IsConst>] static member webhook_outlined: IconData = nativeOnly
  [<IsConst>] static member wechat: IconData = nativeOnly
  [<IsConst>] static member wechat_sharp: IconData = nativeOnly
  [<IsConst>] static member wechat_rounded: IconData = nativeOnly
  [<IsConst>] static member wechat_outlined: IconData = nativeOnly
  [<IsConst>] static member weekend: IconData = nativeOnly
  [<IsConst>] static member weekend_sharp: IconData = nativeOnly
  [<IsConst>] static member weekend_rounded: IconData = nativeOnly
  [<IsConst>] static member weekend_outlined: IconData = nativeOnly
  [<IsConst>] static member west: IconData = nativeOnly
  [<IsConst>] static member west_sharp: IconData = nativeOnly
  [<IsConst>] static member west_rounded: IconData = nativeOnly
  [<IsConst>] static member west_outlined: IconData = nativeOnly
  [<IsConst>] static member whatsapp: IconData = nativeOnly
  [<IsConst>] static member whatsapp_sharp: IconData = nativeOnly
  [<IsConst>] static member whatsapp_rounded: IconData = nativeOnly
  [<IsConst>] static member whatsapp_outlined: IconData = nativeOnly
  [<IsConst>] static member whatshot: IconData = nativeOnly
  [<IsConst>] static member whatshot_sharp: IconData = nativeOnly
  [<IsConst>] static member whatshot_rounded: IconData = nativeOnly
  [<IsConst>] static member whatshot_outlined: IconData = nativeOnly
  [<IsConst>] static member wheelchair_pickup: IconData = nativeOnly
  [<IsConst>] static member wheelchair_pickup_sharp: IconData = nativeOnly
  [<IsConst>] static member wheelchair_pickup_rounded: IconData = nativeOnly
  [<IsConst>] static member wheelchair_pickup_outlined: IconData = nativeOnly
  [<IsConst>] static member where_to_vote: IconData = nativeOnly
  [<IsConst>] static member where_to_vote_sharp: IconData = nativeOnly
  [<IsConst>] static member where_to_vote_rounded: IconData = nativeOnly
  [<IsConst>] static member where_to_vote_outlined: IconData = nativeOnly
  [<IsConst>] static member widgets: IconData = nativeOnly
  [<IsConst>] static member widgets_sharp: IconData = nativeOnly
  [<IsConst>] static member widgets_rounded: IconData = nativeOnly
  [<IsConst>] static member widgets_outlined: IconData = nativeOnly
  [<IsConst>] static member width_full: IconData = nativeOnly
  [<IsConst>] static member width_full_sharp: IconData = nativeOnly
  [<IsConst>] static member width_full_rounded: IconData = nativeOnly
  [<IsConst>] static member width_full_outlined: IconData = nativeOnly
  [<IsConst>] static member width_normal: IconData = nativeOnly
  [<IsConst>] static member width_normal_sharp: IconData = nativeOnly
  [<IsConst>] static member width_normal_rounded: IconData = nativeOnly
  [<IsConst>] static member width_normal_outlined: IconData = nativeOnly
  [<IsConst>] static member width_wide: IconData = nativeOnly
  [<IsConst>] static member width_wide_sharp: IconData = nativeOnly
  [<IsConst>] static member width_wide_rounded: IconData = nativeOnly
  [<IsConst>] static member width_wide_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi: IconData = nativeOnly
  [<IsConst>] static member wifi_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_1_bar: IconData = nativeOnly
  [<IsConst>] static member wifi_1_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_1_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_1_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_2_bar: IconData = nativeOnly
  [<IsConst>] static member wifi_2_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_2_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_2_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_calling: IconData = nativeOnly
  [<IsConst>] static member wifi_calling_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_calling_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_calling_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_calling_3: IconData = nativeOnly
  [<IsConst>] static member wifi_calling_3_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_calling_3_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_calling_3_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_channel: IconData = nativeOnly
  [<IsConst>] static member wifi_channel_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_channel_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_channel_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_find: IconData = nativeOnly
  [<IsConst>] static member wifi_find_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_find_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_find_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_lock: IconData = nativeOnly
  [<IsConst>] static member wifi_lock_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_lock_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_lock_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_off: IconData = nativeOnly
  [<IsConst>] static member wifi_off_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_off_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_off_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_password: IconData = nativeOnly
  [<IsConst>] static member wifi_password_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_password_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_password_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_protected_setup: IconData = nativeOnly
  [<IsConst>] static member wifi_protected_setup_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_protected_setup_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_protected_setup_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_error: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_error_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_error_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_error_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_error_rounded_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_error_rounded_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_error_rounded_outlined: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_off: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_off_sharp: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_off_rounded: IconData = nativeOnly
  [<IsConst>] static member wifi_tethering_off_outlined: IconData = nativeOnly
  [<IsConst>] static member wind_power: IconData = nativeOnly
  [<IsConst>] static member wind_power_sharp: IconData = nativeOnly
  [<IsConst>] static member wind_power_rounded: IconData = nativeOnly
  [<IsConst>] static member wind_power_outlined: IconData = nativeOnly
  [<IsConst>] static member window: IconData = nativeOnly
  [<IsConst>] static member window_sharp: IconData = nativeOnly
  [<IsConst>] static member window_rounded: IconData = nativeOnly
  [<IsConst>] static member window_outlined: IconData = nativeOnly
  [<IsConst>] static member wine_bar: IconData = nativeOnly
  [<IsConst>] static member wine_bar_sharp: IconData = nativeOnly
  [<IsConst>] static member wine_bar_rounded: IconData = nativeOnly
  [<IsConst>] static member wine_bar_outlined: IconData = nativeOnly
  [<IsConst>] static member woman: IconData = nativeOnly
  [<IsConst>] static member woman_sharp: IconData = nativeOnly
  [<IsConst>] static member woman_rounded: IconData = nativeOnly
  [<IsConst>] static member woman_outlined: IconData = nativeOnly
  [<IsConst>] static member woo_commerce: IconData = nativeOnly
  [<IsConst>] static member woo_commerce_sharp: IconData = nativeOnly
  [<IsConst>] static member woo_commerce_rounded: IconData = nativeOnly
  [<IsConst>] static member woo_commerce_outlined: IconData = nativeOnly
  [<IsConst>] static member wordpress: IconData = nativeOnly
  [<IsConst>] static member wordpress_sharp: IconData = nativeOnly
  [<IsConst>] static member wordpress_rounded: IconData = nativeOnly
  [<IsConst>] static member wordpress_outlined: IconData = nativeOnly
  [<IsConst>] static member work: IconData = nativeOnly
  [<IsConst>] static member work_sharp: IconData = nativeOnly
  [<IsConst>] static member work_rounded: IconData = nativeOnly
  [<IsConst>] static member work_outlined: IconData = nativeOnly
  [<IsConst>] static member work_history: IconData = nativeOnly
  [<IsConst>] static member work_history_sharp: IconData = nativeOnly
  [<IsConst>] static member work_history_rounded: IconData = nativeOnly
  [<IsConst>] static member work_history_outlined: IconData = nativeOnly
  [<IsConst>] static member work_off: IconData = nativeOnly
  [<IsConst>] static member work_off_sharp: IconData = nativeOnly
  [<IsConst>] static member work_off_rounded: IconData = nativeOnly
  [<IsConst>] static member work_off_outlined: IconData = nativeOnly
  [<IsConst>] static member work_outline: IconData = nativeOnly
  [<IsConst>] static member work_outline_sharp: IconData = nativeOnly
  [<IsConst>] static member work_outline_rounded: IconData = nativeOnly
  [<IsConst>] static member work_outline_outlined: IconData = nativeOnly
  [<IsConst>] static member workspace_premium: IconData = nativeOnly
  [<IsConst>] static member workspace_premium_sharp: IconData = nativeOnly
  [<IsConst>] static member workspace_premium_rounded: IconData = nativeOnly
  [<IsConst>] static member workspace_premium_outlined: IconData = nativeOnly
  [<IsConst>] static member workspaces: IconData = nativeOnly
  [<IsConst>] static member workspaces_sharp: IconData = nativeOnly
  [<IsConst>] static member workspaces_rounded: IconData = nativeOnly
  [<IsConst>] static member workspaces_outlined: IconData = nativeOnly
  [<IsConst>] static member workspaces_filled: IconData = nativeOnly
  [<IsConst>] static member workspaces_outline: IconData = nativeOnly
  [<IsConst>] static member wrap_text: IconData = nativeOnly
  [<IsConst>] static member wrap_text_sharp: IconData = nativeOnly
  [<IsConst>] static member wrap_text_rounded: IconData = nativeOnly
  [<IsConst>] static member wrap_text_outlined: IconData = nativeOnly
  [<IsConst>] static member wrong_location: IconData = nativeOnly
  [<IsConst>] static member wrong_location_sharp: IconData = nativeOnly
  [<IsConst>] static member wrong_location_rounded: IconData = nativeOnly
  [<IsConst>] static member wrong_location_outlined: IconData = nativeOnly
  [<IsConst>] static member wysiwyg: IconData = nativeOnly
  [<IsConst>] static member wysiwyg_sharp: IconData = nativeOnly
  [<IsConst>] static member wysiwyg_rounded: IconData = nativeOnly
  [<IsConst>] static member wysiwyg_outlined: IconData = nativeOnly
  [<IsConst>] static member yard: IconData = nativeOnly
  [<IsConst>] static member yard_sharp: IconData = nativeOnly
  [<IsConst>] static member yard_rounded: IconData = nativeOnly
  [<IsConst>] static member yard_outlined: IconData = nativeOnly
  [<IsConst>] static member youtube_searched_for: IconData = nativeOnly
  [<IsConst>] static member youtube_searched_for_sharp: IconData = nativeOnly
  [<IsConst>] static member youtube_searched_for_rounded: IconData = nativeOnly
  [<IsConst>] static member youtube_searched_for_outlined: IconData = nativeOnly
  [<IsConst>] static member zoom_in: IconData = nativeOnly
  [<IsConst>] static member zoom_in_sharp: IconData = nativeOnly
  [<IsConst>] static member zoom_in_rounded: IconData = nativeOnly
  [<IsConst>] static member zoom_in_outlined: IconData = nativeOnly
  [<IsConst>] static member zoom_in_map: IconData = nativeOnly
  [<IsConst>] static member zoom_in_map_sharp: IconData = nativeOnly
  [<IsConst>] static member zoom_in_map_rounded: IconData = nativeOnly
  [<IsConst>] static member zoom_in_map_outlined: IconData = nativeOnly
  [<IsConst>] static member zoom_out: IconData = nativeOnly
  [<IsConst>] static member zoom_out_sharp: IconData = nativeOnly
  [<IsConst>] static member zoom_out_rounded: IconData = nativeOnly
  [<IsConst>] static member zoom_out_outlined: IconData = nativeOnly
  [<IsConst>] static member zoom_out_map: IconData = nativeOnly
  [<IsConst>] static member zoom_out_map_sharp: IconData = nativeOnly
  [<IsConst>] static member zoom_out_map_rounded: IconData = nativeOnly
  [<IsConst>] static member zoom_out_map_outlined: IconData = nativeOnly

/// https://api.flutter.dev/flutter/material/Ink-class.html
[<ImportMember("package:flutter/material.dart")>]
type Ink [<NamedParams>] (?key: Key, ?padding: EdgeInsetsGeometry, ?color: Color, ?decoration: Decoration, ?width: float, ?height: float, ?child: Widget) =
  inherit Widget()
  [<NamedParams>] static member image(image: ImageProvider<obj>, ?key: Key, ?padding: EdgeInsetsGeometry, ?onImageError: (obj -> StackTrace option -> unit), ?colorFilter: ColorFilter, ?fit: BoxFit, ?alignment: AlignmentGeometry, ?centerSlice: Rect, ?repeat: ImageRepeat, ?matchTextDirection: bool, ?width: float, ?height: float, ?child: Widget): Ink = nativeOnly

/// https://api.flutter.dev/flutter/material/InkDecoration-class.html
[<ImportMember("package:flutter/material.dart")>]
type InkDecoration [<NamedParams>] (decoration: Decoration option, configuration: ImageConfiguration, controller: MaterialInkController, referenceBox: RenderBox, ?onRemoved: (unit -> unit)) =
  inherit InkFeature(controller, referenceBox)

/// https://api.flutter.dev/flutter/material/InkHighlight-class.html
[<ImportMember("package:flutter/material.dart")>]
type InkHighlight [<NamedParams>] (controller: MaterialInkController, referenceBox: RenderBox, color: Color, textDirection: TextDirection, ?shape: BoxShape, ?radius: float, ?borderRadius: BorderRadius, ?customBorder: ShapeBorder, ?rectCallback: (unit -> Rect), ?onRemoved: (unit -> unit), ?fadeDuration: TimeSpan) =
  inherit InteractiveInkFeature(controller, referenceBox, color)

/// https://api.flutter.dev/flutter/material/InkRipple-class.html
[<ImportMember("package:flutter/material.dart")>]
type InkRipple [<NamedParams>] (controller: MaterialInkController, referenceBox: RenderBox, position: Offset, color: Color, textDirection: TextDirection, ?containedInkWell: bool, ?rectCallback: (unit -> Rect), ?borderRadius: BorderRadius, ?customBorder: ShapeBorder, ?radius: float, ?onRemoved: (unit -> unit)) =
  inherit InteractiveInkFeature(controller, referenceBox, color)
  [<IsConst>] static member splashFactory: InteractiveInkFeatureFactory = nativeOnly

/// https://api.flutter.dev/flutter/material/InkSparkle-class.html
[<ImportMember("package:flutter/material.dart")>]
type InkSparkle [<NamedParams>] (controller: MaterialInkController, referenceBox: RenderBox, color: Color, position: Offset, textDirection: TextDirection, ?containedInkWell: bool, ?rectCallback: (unit -> Rect), ?borderRadius: BorderRadius, ?customBorder: ShapeBorder, ?radius: float, ?onRemoved: (unit -> unit), ?turbulenceSeed: float) =
  inherit InteractiveInkFeature(controller, referenceBox, color)
  [<IsConst>] static member splashFactory: InteractiveInkFeatureFactory = nativeOnly
  [<IsConst>] static member constantTurbulenceSeedSplashFactory: InteractiveInkFeatureFactory = nativeOnly

/// https://api.flutter.dev/flutter/material/FragmentShaderManager-class.html
[<ImportMember("package:flutter/material.dart")>]
type FragmentShaderManager =
  class end

/// https://api.flutter.dev/flutter/material/InkSplash-class.html
[<ImportMember("package:flutter/material.dart")>]
type InkSplash [<NamedParams>] (controller: MaterialInkController, referenceBox: RenderBox, textDirection: TextDirection, color: Color, ?position: Offset, ?containedInkWell: bool, ?rectCallback: (unit -> Rect), ?borderRadius: BorderRadius, ?customBorder: ShapeBorder, ?radius: float, ?onRemoved: (unit -> unit)) =
  inherit InteractiveInkFeature(controller, referenceBox, color)
  [<IsConst>] static member splashFactory: InteractiveInkFeatureFactory = nativeOnly

/// https://api.flutter.dev/flutter/material/InteractiveInkFeature-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type InteractiveInkFeature [<NamedParams>] (controller: MaterialInkController, referenceBox: RenderBox, color: Color, ?onRemoved: (unit -> unit)) =
  inherit InkFeature(controller, referenceBox)

/// https://api.flutter.dev/flutter/material/InteractiveInkFeatureFactory-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type InteractiveInkFeatureFactory [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/material/InkResponse-class.html
[<ImportMember("package:flutter/material.dart")>]
type InkResponse [<IsConst; NamedParams>] (?key: Key, ?child: Widget, ?onTap: (unit -> unit), ?onTapDown: (TapDownDetails -> unit), ?onTapUp: (TapUpDetails -> unit), ?onTapCancel: (unit -> unit), ?onDoubleTap: (unit -> unit), ?onLongPress: (unit -> unit), ?onHighlightChanged: (bool -> unit), ?onHover: (bool -> unit), ?mouseCursor: MouseCursor, ?containedInkWell: bool, ?highlightShape: BoxShape, ?radius: float, ?borderRadius: BorderRadius, ?customBorder: ShapeBorder, ?focusColor: Color, ?hoverColor: Color, ?highlightColor: Color, ?overlayColor: MaterialStateProperty<Color option>, ?splashColor: Color, ?splashFactory: InteractiveInkFeatureFactory, ?enableFeedback: bool, ?excludeFromSemantics: bool, ?focusNode: FocusNode, ?canRequestFocus: bool, ?onFocusChange: (bool -> unit), ?autofocus: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/InkWell-class.html
[<ImportMember("package:flutter/material.dart")>]
type InkWell [<IsConst; NamedParams>] (?key: Key, ?child: Widget, ?onTap: (unit -> unit), ?onDoubleTap: (unit -> unit), ?onLongPress: (unit -> unit), ?onTapDown: (TapDownDetails -> unit), ?onTapUp: (TapUpDetails -> unit), ?onTapCancel: (unit -> unit), ?onHighlightChanged: (bool -> unit), ?onHover: (bool -> unit), ?mouseCursor: MouseCursor, ?focusColor: Color, ?hoverColor: Color, ?highlightColor: Color, ?overlayColor: MaterialStateProperty<Color option>, ?splashColor: Color, ?splashFactory: InteractiveInkFeatureFactory, ?radius: float, ?borderRadius: BorderRadius, ?customBorder: ShapeBorder, ?enableFeedback: bool, ?excludeFromSemantics: bool, ?focusNode: FocusNode, ?canRequestFocus: bool, ?onFocusChange: (bool -> unit), ?autofocus: bool) =
  inherit InkResponse()

/// https://api.flutter.dev/flutter/material/InputBorder-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type InputBorder [<IsConst; NamedParams>] (?borderSide: BorderSide) =
  inherit ShapeBorder()
  [<IsConst>] static member none: InputBorder = nativeOnly

/// https://api.flutter.dev/flutter/material/UnderlineInputBorder-class.html
[<ImportMember("package:flutter/material.dart")>]
type UnderlineInputBorder [<IsConst; NamedParams>] (?borderSide: BorderSide, ?borderRadius: BorderRadius) =
  inherit InputBorder()

/// https://api.flutter.dev/flutter/material/OutlineInputBorder-class.html
[<ImportMember("package:flutter/material.dart")>]
type OutlineInputBorder [<IsConst; NamedParams>] (?borderSide: BorderSide, ?borderRadius: BorderRadius, ?gapPadding: float) =
  inherit InputBorder()

/// https://api.flutter.dev/flutter/material/InputDatePickerFormField-class.html
[<ImportMember("package:flutter/material.dart")>]
type InputDatePickerFormField [<NamedParams>] (firstDate: DateTime, lastDate: DateTime, ?key: Key, ?initialDate: DateTime, ?onDateSubmitted: (DateTime -> unit), ?onDateSaved: (DateTime -> unit), ?selectableDayPredicate: (DateTime -> bool), ?errorFormatText: string, ?errorInvalidText: string, ?fieldHintText: string, ?fieldLabelText: string, ?keyboardType: TextInputType, ?autofocus: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/FloatingLabelAlignment-class.html
[<ImportMember("package:flutter/material.dart")>]
type FloatingLabelAlignment =
  [<IsConst>] static member start: FloatingLabelAlignment = nativeOnly
  [<IsConst>] static member center: FloatingLabelAlignment = nativeOnly

/// https://api.flutter.dev/flutter/material/InputDecorator-class.html
[<ImportMember("package:flutter/material.dart")>]
type InputDecorator [<IsConst; NamedParams>] (decoration: InputDecoration, ?key: Key, ?baseStyle: TextStyle, ?textAlign: TextAlign, ?textAlignVertical: TextAlignVertical, ?isFocused: bool, ?isHovering: bool, ?expands: bool, ?isEmpty: bool, ?child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/InputDecoration-class.html
[<ImportMember("package:flutter/material.dart")>]
type InputDecoration [<IsConst; NamedParams>] (?icon: Widget, ?iconColor: Color, ?label: Widget, ?labelText: string, ?labelStyle: TextStyle, ?floatingLabelStyle: TextStyle, ?helperText: string, ?helperStyle: TextStyle, ?helperMaxLines: int, ?hintText: string, ?hintStyle: TextStyle, ?hintTextDirection: TextDirection, ?hintMaxLines: int, ?errorText: string, ?errorStyle: TextStyle, ?errorMaxLines: int, ?floatingLabelBehavior: FloatingLabelBehavior, ?floatingLabelAlignment: FloatingLabelAlignment, ?isCollapsed: bool, ?isDense: bool, ?contentPadding: EdgeInsetsGeometry, ?prefixIcon: Widget, ?prefixIconConstraints: BoxConstraints, ?prefix: Widget, ?prefixText: string, ?prefixStyle: TextStyle, ?prefixIconColor: Color, ?suffixIcon: Widget, ?suffix: Widget, ?suffixText: string, ?suffixStyle: TextStyle, ?suffixIconColor: Color, ?suffixIconConstraints: BoxConstraints, ?counter: Widget, ?counterText: string, ?counterStyle: TextStyle, ?filled: bool, ?fillColor: Color, ?focusColor: Color, ?hoverColor: Color, ?errorBorder: InputBorder, ?focusedBorder: InputBorder, ?focusedErrorBorder: InputBorder, ?disabledBorder: InputBorder, ?enabledBorder: InputBorder, ?border: InputBorder, ?enabled: bool, ?semanticCounterText: string, ?alignLabelWithHint: bool, ?constraints: BoxConstraints) =
  [<IsConst; NamedParams>] static member collapsed(hintText: string option, ?floatingLabelBehavior: FloatingLabelBehavior, ?floatingLabelAlignment: FloatingLabelAlignment, ?hintStyle: TextStyle, ?hintTextDirection: TextDirection, ?filled: bool, ?fillColor: Color, ?focusColor: Color, ?hoverColor: Color, ?border: InputBorder, ?enabled: bool): InputDecoration = nativeOnly

/// https://api.flutter.dev/flutter/material/InputDecorationTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type InputDecorationTheme [<IsConst; NamedParams>] (?labelStyle: TextStyle, ?floatingLabelStyle: TextStyle, ?helperStyle: TextStyle, ?helperMaxLines: int, ?hintStyle: TextStyle, ?errorStyle: TextStyle, ?errorMaxLines: int, ?floatingLabelBehavior: FloatingLabelBehavior, ?floatingLabelAlignment: FloatingLabelAlignment, ?isDense: bool, ?contentPadding: EdgeInsetsGeometry, ?isCollapsed: bool, ?iconColor: Color, ?prefixStyle: TextStyle, ?prefixIconColor: Color, ?suffixStyle: TextStyle, ?suffixIconColor: Color, ?counterStyle: TextStyle, ?filled: bool, ?fillColor: Color, ?focusColor: Color, ?hoverColor: Color, ?errorBorder: InputBorder, ?focusedBorder: InputBorder, ?focusedErrorBorder: InputBorder, ?disabledBorder: InputBorder, ?enabledBorder: InputBorder, ?border: InputBorder, ?alignLabelWithHint: bool, ?constraints: BoxConstraints) =
  class end

/// https://api.flutter.dev/flutter/material/ListTile-class.html
[<ImportMember("package:flutter/material.dart")>]
type ListTile [<IsConst; NamedParams>] (?key: Key, ?leading: Widget, ?title: Widget, ?subtitle: Widget, ?trailing: Widget, ?isThreeLine: bool, ?dense: bool, ?visualDensity: VisualDensity, ?shape: ShapeBorder, ?style: ListTileStyle, ?selectedColor: Color, ?iconColor: Color, ?textColor: Color, ?contentPadding: EdgeInsetsGeometry, ?enabled: bool, ?onTap: (unit -> unit), ?onLongPress: (unit -> unit), ?mouseCursor: MouseCursor, ?selected: bool, ?focusColor: Color, ?hoverColor: Color, ?focusNode: FocusNode, ?autofocus: bool, ?tileColor: Color, ?selectedTileColor: Color, ?enableFeedback: bool, ?horizontalTitleGap: float, ?minVerticalPadding: float, ?minLeadingWidth: float) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ListTileThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type ListTileThemeData [<IsConst; NamedParams>] (?dense: bool, ?shape: ShapeBorder, ?style: ListTileStyle, ?selectedColor: Color, ?iconColor: Color, ?textColor: Color, ?contentPadding: EdgeInsetsGeometry, ?tileColor: Color, ?selectedTileColor: Color, ?horizontalTitleGap: float, ?minVerticalPadding: float, ?minLeadingWidth: float, ?enableFeedback: bool, ?mouseCursor: MaterialStateProperty<MouseCursor option>, ?visualDensity: VisualDensity) =
  class end

/// https://api.flutter.dev/flutter/material/ListTileTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type ListTileTheme [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?data: ListTileThemeData, ?dense: bool, ?shape: ShapeBorder, ?style: ListTileStyle, ?selectedColor: Color, ?iconColor: Color, ?textColor: Color, ?contentPadding: EdgeInsetsGeometry, ?tileColor: Color, ?selectedTileColor: Color, ?enableFeedback: bool, ?mouseCursor: MaterialStateProperty<MouseCursor option>, ?horizontalTitleGap: float, ?minVerticalPadding: float, ?minLeadingWidth: float) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/MaterialInkController-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type MaterialInkController () =
  class end

/// https://api.flutter.dev/flutter/material/Material-class.html
[<ImportMember("package:flutter/material.dart")>]
type Material [<IsConst; NamedParams>] (?key: Key, ?``type``: MaterialType, ?elevation: float, ?color: Color, ?shadowColor: Color, ?surfaceTintColor: Color, ?textStyle: TextStyle, ?borderRadius: BorderRadiusGeometry, ?shape: ShapeBorder, ?borderOnForeground: bool, ?clipBehavior: Clip, ?animationDuration: TimeSpan, ?child: Widget) =
  inherit Widget()
  [<IsConst>] static member defaultSplashRadius: float = nativeOnly

/// https://api.flutter.dev/flutter/material/InkFeature-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type InkFeature [<NamedParams>] (controller: MaterialInkController, referenceBox: RenderBox, ?onRemoved: (unit -> unit)) =
  class end

/// https://api.flutter.dev/flutter/material/ShapeBorderTween-class.html
[<ImportMember("package:flutter/material.dart")>]
type ShapeBorderTween [<NamedParams>] (?``begin``: ShapeBorder, ?``end``: ShapeBorder) =
  inherit Tween<ShapeBorder option>()

/// https://api.flutter.dev/flutter/material/MaterialButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialButton [<IsConst; NamedParams>] (onPressed: (unit -> unit), ?key: Key, ?onLongPress: (unit -> unit), ?onHighlightChanged: (bool -> unit), ?mouseCursor: MouseCursor, ?textTheme: ButtonTextTheme, ?textColor: Color, ?disabledTextColor: Color, ?color: Color, ?disabledColor: Color, ?focusColor: Color, ?hoverColor: Color, ?highlightColor: Color, ?splashColor: Color, ?colorBrightness: Brightness, ?elevation: float, ?focusElevation: float, ?hoverElevation: float, ?highlightElevation: float, ?disabledElevation: float, ?padding: EdgeInsetsGeometry, ?visualDensity: VisualDensity, ?shape: ShapeBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?materialTapTargetSize: MaterialTapTargetSize, ?animationDuration: TimeSpan, ?minWidth: float, ?height: float, ?enableFeedback: bool, ?child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/MaterialLocalizations-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type MaterialLocalizations () =
  class end

/// https://api.flutter.dev/flutter/material/DefaultMaterialLocalizations-class.html
[<ImportMember("package:flutter/material.dart")>]
type DefaultMaterialLocalizations [<IsConst>] () =
  [<IsConst>] static member ``delegate``: LocalizationsDelegate<MaterialLocalizations> = nativeOnly

/// https://api.flutter.dev/flutter/material/MaterialStateColor-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type MaterialStateColor [<IsConst>] (defaultValue: int) =
  inherit Color(nativeOnly)

/// https://api.flutter.dev/flutter/material/MaterialStateMouseCursor-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type MaterialStateMouseCursor [<IsConst>] () =
  inherit MouseCursor()
  [<IsConst>] static member clickable: MaterialStateMouseCursor = nativeOnly
  [<IsConst>] static member textable: MaterialStateMouseCursor = nativeOnly

/// https://api.flutter.dev/flutter/material/MaterialStateBorderSide-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type MaterialStateBorderSide [<IsConst>] () =
  inherit BorderSide()

/// https://api.flutter.dev/flutter/material/MaterialStateOutlinedBorder-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type MaterialStateOutlinedBorder [<IsConst>] () =
  inherit OutlinedBorder()

/// https://api.flutter.dev/flutter/material/MaterialStateTextStyle-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type MaterialStateTextStyle [<IsConst>] () =
  inherit TextStyle()

/// https://api.flutter.dev/flutter/material/MaterialStateOutlineInputBorder-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type MaterialStateOutlineInputBorder [<IsConst>] () =
  inherit OutlineInputBorder()

/// https://api.flutter.dev/flutter/material/MaterialStateUnderlineInputBorder-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type MaterialStateUnderlineInputBorder [<IsConst>] () =
  inherit UnderlineInputBorder()

/// https://api.flutter.dev/flutter/material/MaterialStateProperty-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type MaterialStateProperty<'T> () =
  class end

/// https://api.flutter.dev/flutter/material/MergeableMaterialItem-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type MergeableMaterialItem [<IsConst>] (key: LocalKey) =
  class end

/// https://api.flutter.dev/flutter/material/MaterialSlice-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialSlice [<IsConst; NamedParams>] (key: LocalKey, child: Widget, ?color: Color) =
  inherit MergeableMaterialItem(key)

/// https://api.flutter.dev/flutter/material/MaterialGap-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialGap [<IsConst; NamedParams>] (key: LocalKey, ?size: float) =
  inherit MergeableMaterialItem(key)

/// https://api.flutter.dev/flutter/material/MergeableMaterial-class.html
[<ImportMember("package:flutter/material.dart")>]
type MergeableMaterial [<IsConst; NamedParams>] (?key: Key, ?mainAxis: Axis, ?elevation: float, ?hasDividers: bool, ?children: MergeableMaterialItem[], ?dividerColor: Color) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/NavigationBar-class.html
[<ImportMember("package:flutter/material.dart")>]
type NavigationBar [<IsConst; NamedParams>] (destinations: Widget[], ?key: Key, ?animationDuration: TimeSpan, ?selectedIndex: int, ?onDestinationSelected: (int -> unit), ?backgroundColor: Color, ?elevation: float, ?height: float, ?labelBehavior: NavigationDestinationLabelBehavior) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/NavigationDestination-class.html
[<ImportMember("package:flutter/material.dart")>]
type NavigationDestination [<IsConst; NamedParams>] (icon: Widget, label: string, ?key: Key, ?selectedIcon: Widget, ?tooltip: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/NavigationIndicator-class.html
[<ImportMember("package:flutter/material.dart")>]
type NavigationIndicator [<IsConst; NamedParams>] (animation: Animation<float>, ?key: Key, ?color: Color, ?width: float, ?height: float, ?borderRadius: BorderRadius, ?shape: ShapeBorder) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/NavigationBarThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type NavigationBarThemeData [<IsConst; NamedParams>] (?height: float, ?backgroundColor: Color, ?elevation: float, ?indicatorColor: Color, ?indicatorShape: ShapeBorder, ?labelTextStyle: MaterialStateProperty<TextStyle option>, ?iconTheme: MaterialStateProperty<IconThemeData option>, ?labelBehavior: NavigationDestinationLabelBehavior) =
  class end

/// https://api.flutter.dev/flutter/material/NavigationBarTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type NavigationBarTheme [<IsConst; NamedParams>] (data: NavigationBarThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/NavigationRail-class.html
[<ImportMember("package:flutter/material.dart")>]
type NavigationRail [<IsConst; NamedParams>] (destinations: NavigationRailDestination[], selectedIndex: int option, ?key: Key, ?backgroundColor: Color, ?extended: bool, ?leading: Widget, ?trailing: Widget, ?onDestinationSelected: (int -> unit), ?elevation: float, ?groupAlignment: float, ?labelType: NavigationRailLabelType, ?unselectedLabelTextStyle: TextStyle, ?selectedLabelTextStyle: TextStyle, ?unselectedIconTheme: IconThemeData, ?selectedIconTheme: IconThemeData, ?minWidth: float, ?minExtendedWidth: float, ?useIndicator: bool, ?indicatorColor: Color) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/NavigationRailDestination-class.html
[<ImportMember("package:flutter/material.dart")>]
type NavigationRailDestination [<IsConst; NamedParams>] (icon: Widget, label: Widget, ?selectedIcon: Widget, ?padding: EdgeInsetsGeometry) =
  class end

/// https://api.flutter.dev/flutter/material/NavigationRailThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type NavigationRailThemeData [<IsConst; NamedParams>] (?backgroundColor: Color, ?elevation: float, ?unselectedLabelTextStyle: TextStyle, ?selectedLabelTextStyle: TextStyle, ?unselectedIconTheme: IconThemeData, ?selectedIconTheme: IconThemeData, ?groupAlignment: float, ?labelType: NavigationRailLabelType, ?useIndicator: bool, ?indicatorColor: Color, ?minWidth: float, ?minExtendedWidth: float) =
  class end

/// https://api.flutter.dev/flutter/material/NavigationRailTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type NavigationRailTheme [<IsConst; NamedParams>] (data: NavigationRailThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/NoSplash-class.html
[<ImportMember("package:flutter/material.dart")>]
type NoSplash [<NamedParams>] (controller: MaterialInkController, referenceBox: RenderBox, color: Color, ?onRemoved: (unit -> unit)) =
  inherit InteractiveInkFeature(controller, referenceBox, color)
  [<IsConst>] static member splashFactory: InteractiveInkFeatureFactory = nativeOnly

/// https://api.flutter.dev/flutter/material/OutlinedButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type OutlinedButton [<IsConst; NamedParams>] (onPressed: (unit -> unit), child: Widget, ?key: Key, ?onLongPress: (unit -> unit), ?onHover: (bool -> unit), ?onFocusChange: (bool -> unit), ?style: ButtonStyle, ?focusNode: FocusNode, ?autofocus: bool, ?clipBehavior: Clip) =
  inherit ButtonStyleButton(nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly)
  [<NamedParams>] static member icon(onPressed: (unit -> unit), icon: Widget, label: Widget, ?key: Key, ?onLongPress: (unit -> unit), ?style: ButtonStyle, ?focusNode: FocusNode, ?autofocus: bool, ?clipBehavior: Clip): OutlinedButton = nativeOnly

/// https://api.flutter.dev/flutter/material/OutlinedButtonThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type OutlinedButtonThemeData [<IsConst; NamedParams>] (?style: ButtonStyle) =
  class end

/// https://api.flutter.dev/flutter/material/OutlinedButtonTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type OutlinedButtonTheme [<IsConst; NamedParams>] (data: OutlinedButtonThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/MaterialPageRoute-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialPageRoute<'T> [<NamedParams>] (builder: (BuildContext -> Widget), ?settings: RouteSettings, ?maintainState: bool, ?fullscreenDialog: bool) =
  inherit PageRoute<'T>()

/// https://api.flutter.dev/flutter/material/MaterialPage-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialPage<'T> [<IsConst; NamedParams>] (child: Widget, ?maintainState: bool, ?fullscreenDialog: bool, ?key: LocalKey, ?name: string, ?arguments: obj, ?restorationId: string) =
  inherit Page<'T>()

/// https://api.flutter.dev/flutter/material/PageTransitionsBuilder-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type PageTransitionsBuilder [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/material/FadeUpwardsPageTransitionsBuilder-class.html
[<ImportMember("package:flutter/material.dart")>]
type FadeUpwardsPageTransitionsBuilder [<IsConst>] () =
  inherit PageTransitionsBuilder()

/// https://api.flutter.dev/flutter/material/OpenUpwardsPageTransitionsBuilder-class.html
[<ImportMember("package:flutter/material.dart")>]
type OpenUpwardsPageTransitionsBuilder [<IsConst>] () =
  inherit PageTransitionsBuilder()

/// https://api.flutter.dev/flutter/material/ZoomPageTransitionsBuilder-class.html
[<ImportMember("package:flutter/material.dart")>]
type ZoomPageTransitionsBuilder [<IsConst>] () =
  inherit PageTransitionsBuilder()

/// https://api.flutter.dev/flutter/material/CupertinoPageTransitionsBuilder-class.html
[<ImportMember("package:flutter/material.dart")>]
type CupertinoPageTransitionsBuilder [<IsConst>] () =
  inherit PageTransitionsBuilder()

/// https://api.flutter.dev/flutter/material/PageTransitionsTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type PageTransitionsTheme [<IsConst; NamedParams>] (?builders: Dictionary<TargetPlatform, PageTransitionsBuilder>) =
  class end

/// https://api.flutter.dev/flutter/material/PaginatedDataTable-class.html
[<ImportMember("package:flutter/material.dart")>]
type PaginatedDataTable [<NamedParams>] (columns: DataColumn[], source: DataTableSource, ?key: Key, ?header: Widget, ?actions: Widget[], ?sortColumnIndex: int, ?sortAscending: bool, ?onSelectAll: (bool option -> unit), ?dataRowHeight: float, ?headingRowHeight: float, ?horizontalMargin: float, ?columnSpacing: float, ?showCheckboxColumn: bool, ?showFirstLastButtons: bool, ?initialFirstRowIndex: int, ?onPageChanged: (int -> unit), ?rowsPerPage: int, ?availableRowsPerPage: int[], ?onRowsPerPageChanged: (int option -> unit), ?dragStartBehavior: DragStartBehavior, ?arrowHeadColor: Color, ?checkboxHorizontalMargin: float) =
  inherit Widget()
  [<IsConst>] static member defaultRowsPerPage: int = nativeOnly

/// https://api.flutter.dev/flutter/material/PaginatedDataTableState-class.html
[<ImportMember("package:flutter/material.dart")>]
type PaginatedDataTableState () =
  interface State

/// https://api.flutter.dev/flutter/material/PopupMenuEntry-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type PopupMenuEntry<'T> [<IsConst; NamedParams>] (?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/PopupMenuDivider-class.html
[<ImportMember("package:flutter/material.dart")>]
type PopupMenuDivider [<IsConst; NamedParams>] (?key: Key, ?height: float) =
  inherit PopupMenuEntry<unit>()

/// https://api.flutter.dev/flutter/material/PopupMenuItem-class.html
[<ImportMember("package:flutter/material.dart")>]
type PopupMenuItem<'T> [<IsConst; NamedParams>] (child: Widget option, ?key: Key, ?value: 'T, ?onTap: (unit -> unit), ?enabled: bool, ?height: float, ?padding: EdgeInsets, ?textStyle: TextStyle, ?mouseCursor: MouseCursor) =
  inherit PopupMenuEntry<'T>()

/// https://api.flutter.dev/flutter/material/PopupMenuItemState-class.html
[<ImportMember("package:flutter/material.dart")>]
type PopupMenuItemState<'T, 'W> () =
  interface State

/// https://api.flutter.dev/flutter/material/CheckedPopupMenuItem-class.html
[<ImportMember("package:flutter/material.dart")>]
type CheckedPopupMenuItem<'T> [<IsConst; NamedParams>] (?key: Key, ?value: 'T, ?``checked``: bool, ?enabled: bool, ?padding: EdgeInsets, ?height: float, ?child: Widget) =
  inherit PopupMenuItem<'T>(child)

/// https://api.flutter.dev/flutter/material/PopupMenuButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type PopupMenuButton<'T> [<IsConst; NamedParams>] (itemBuilder: (BuildContext -> PopupMenuEntry<'T>[]), ?key: Key, ?initialValue: 'T, ?onSelected: ('T -> unit), ?onCanceled: (unit -> unit), ?tooltip: string, ?elevation: float, ?padding: EdgeInsetsGeometry, ?child: Widget, ?splashRadius: float, ?icon: Widget, ?iconSize: float, ?offset: Offset, ?enabled: bool, ?shape: ShapeBorder, ?color: Color, ?enableFeedback: bool, ?constraints: BoxConstraints, ?position: PopupMenuPosition) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/PopupMenuButtonState-class.html
[<ImportMember("package:flutter/material.dart")>]
type PopupMenuButtonState<'T> () =
  interface State

/// https://api.flutter.dev/flutter/material/PopupMenuThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type PopupMenuThemeData [<IsConst; NamedParams>] (?color: Color, ?shape: ShapeBorder, ?elevation: float, ?textStyle: TextStyle, ?enableFeedback: bool, ?mouseCursor: MaterialStateProperty<MouseCursor option>) =
  class end

/// https://api.flutter.dev/flutter/material/PopupMenuTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type PopupMenuTheme [<IsConst; NamedParams>] (data: PopupMenuThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/ProgressIndicator-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type ProgressIndicator [<IsConst; NamedParams>] (?key: Key, ?value: float, ?backgroundColor: Color, ?color: Color, ?valueColor: Animation<Color option>, ?semanticsLabel: string, ?semanticsValue: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/LinearProgressIndicator-class.html
[<ImportMember("package:flutter/material.dart")>]
type LinearProgressIndicator [<IsConst; NamedParams>] (?key: Key, ?value: float, ?backgroundColor: Color, ?color: Color, ?valueColor: Animation<Color option>, ?minHeight: float, ?semanticsLabel: string, ?semanticsValue: string) =
  inherit ProgressIndicator()

/// https://api.flutter.dev/flutter/material/CircularProgressIndicator-class.html
[<ImportMember("package:flutter/material.dart")>]
type CircularProgressIndicator [<IsConst; NamedParams>] (?key: Key, ?value: float, ?backgroundColor: Color, ?color: Color, ?valueColor: Animation<Color option>, ?strokeWidth: float, ?semanticsLabel: string, ?semanticsValue: string) =
  inherit ProgressIndicator()
  [<IsConst; NamedParams>] static member adaptive(?key: Key, ?value: float, ?backgroundColor: Color, ?valueColor: Animation<Color option>, ?strokeWidth: float, ?semanticsLabel: string, ?semanticsValue: string): CircularProgressIndicator = nativeOnly

/// https://api.flutter.dev/flutter/material/RefreshProgressIndicator-class.html
[<ImportMember("package:flutter/material.dart")>]
type RefreshProgressIndicator [<IsConst; NamedParams>] (?key: Key, ?value: float, ?backgroundColor: Color, ?color: Color, ?valueColor: Animation<Color option>, ?strokeWidth: float, ?semanticsLabel: string, ?semanticsValue: string) =
  inherit CircularProgressIndicator()
  [<IsConst>] static member defaultStrokeWidth: float = nativeOnly

/// https://api.flutter.dev/flutter/material/ProgressIndicatorThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type ProgressIndicatorThemeData [<IsConst; NamedParams>] (?color: Color, ?linearTrackColor: Color, ?linearMinHeight: float, ?circularTrackColor: Color, ?refreshBackgroundColor: Color) =
  class end

/// https://api.flutter.dev/flutter/material/ProgressIndicatorTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type ProgressIndicatorTheme [<IsConst; NamedParams>] (data: ProgressIndicatorThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/Radio-class.html
[<ImportMember("package:flutter/material.dart")>]
type Radio<'T> [<IsConst; NamedParams>] (value: 'T, groupValue: 'T option, onChanged: ('T option -> unit), ?key: Key, ?mouseCursor: MouseCursor, ?toggleable: bool, ?activeColor: Color, ?fillColor: MaterialStateProperty<Color option>, ?focusColor: Color, ?hoverColor: Color, ?overlayColor: MaterialStateProperty<Color option>, ?splashRadius: float, ?materialTapTargetSize: MaterialTapTargetSize, ?visualDensity: VisualDensity, ?focusNode: FocusNode, ?autofocus: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/RadioListTile-class.html
[<ImportMember("package:flutter/material.dart")>]
type RadioListTile<'T> [<IsConst; NamedParams>] (value: 'T, groupValue: 'T option, onChanged: ('T option -> unit), ?key: Key, ?toggleable: bool, ?activeColor: Color, ?title: Widget, ?subtitle: Widget, ?isThreeLine: bool, ?dense: bool, ?secondary: Widget, ?selected: bool, ?controlAffinity: ListTileControlAffinity, ?autofocus: bool, ?contentPadding: EdgeInsetsGeometry, ?shape: ShapeBorder, ?tileColor: Color, ?selectedTileColor: Color, ?visualDensity: VisualDensity, ?focusNode: FocusNode, ?enableFeedback: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/RadioThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type RadioThemeData [<IsConst; NamedParams>] (?mouseCursor: MaterialStateProperty<MouseCursor option>, ?fillColor: MaterialStateProperty<Color option>, ?overlayColor: MaterialStateProperty<Color option>, ?splashRadius: float, ?materialTapTargetSize: MaterialTapTargetSize, ?visualDensity: VisualDensity) =
  class end

/// https://api.flutter.dev/flutter/material/RadioTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type RadioTheme [<IsConst; NamedParams>] (data: RadioThemeData, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/material/RaisedButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type RaisedButton [<IsConst; NamedParams>] (onPressed: (unit -> unit), ?key: Key, ?onLongPress: (unit -> unit), ?onHighlightChanged: (bool -> unit), ?mouseCursor: MouseCursor, ?textTheme: ButtonTextTheme, ?textColor: Color, ?disabledTextColor: Color, ?color: Color, ?disabledColor: Color, ?focusColor: Color, ?hoverColor: Color, ?highlightColor: Color, ?splashColor: Color, ?colorBrightness: Brightness, ?elevation: float, ?focusElevation: float, ?hoverElevation: float, ?highlightElevation: float, ?disabledElevation: float, ?padding: EdgeInsetsGeometry, ?visualDensity: VisualDensity, ?shape: ShapeBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?materialTapTargetSize: MaterialTapTargetSize, ?animationDuration: TimeSpan, ?child: Widget) =
  inherit MaterialButton(onPressed)
  [<NamedParams>] static member icon(onPressed: (unit -> unit), icon: Widget, label: Widget, ?key: Key, ?onLongPress: (unit -> unit), ?onHighlightChanged: (bool -> unit), ?mouseCursor: MouseCursor, ?textTheme: ButtonTextTheme, ?textColor: Color, ?disabledTextColor: Color, ?color: Color, ?disabledColor: Color, ?focusColor: Color, ?hoverColor: Color, ?highlightColor: Color, ?splashColor: Color, ?colorBrightness: Brightness, ?elevation: float, ?highlightElevation: float, ?disabledElevation: float, ?shape: ShapeBorder, ?clipBehavior: Clip, ?focusNode: FocusNode, ?autofocus: bool, ?padding: EdgeInsetsGeometry, ?materialTapTargetSize: MaterialTapTargetSize, ?animationDuration: TimeSpan): RaisedButton = nativeOnly

/// https://api.flutter.dev/flutter/material/RangeSlider-class.html
[<ImportMember("package:flutter/material.dart")>]
type RangeSlider [<NamedParams>] (values: RangeValues, onChanged: (RangeValues -> unit), ?key: Key, ?onChangeStart: (RangeValues -> unit), ?onChangeEnd: (RangeValues -> unit), ?min: float, ?max: float, ?divisions: int, ?labels: RangeLabels, ?activeColor: Color, ?inactiveColor: Color, ?semanticFormatterCallback: (float -> string)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/RefreshIndicator-class.html
[<ImportMember("package:flutter/material.dart")>]
type RefreshIndicator [<IsConst; NamedParams>] (child: Widget, onRefresh: (unit -> Future<unit>), ?key: Key, ?displacement: float, ?edgeOffset: float, ?color: Color, ?backgroundColor: Color, ?notificationPredicate: (ScrollNotification -> bool), ?semanticsLabel: string, ?semanticsValue: string, ?strokeWidth: float, ?triggerMode: RefreshIndicatorTriggerMode) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/RefreshIndicatorState-class.html
[<ImportMember("package:flutter/material.dart")>]
type RefreshIndicatorState () =
  interface State

/// https://api.flutter.dev/flutter/material/ReorderableListView-class.html
[<ImportMember("package:flutter/material.dart")>]
type ReorderableListView [<NamedParams>] (children: Widget[], onReorder: (int -> int -> unit), ?key: Key, ?onReorderStart: (int -> unit), ?onReorderEnd: (int -> unit), ?itemExtent: float, ?prototypeItem: Widget, ?proxyDecorator: (Widget -> int -> Animation<float> -> Widget), ?buildDefaultDragHandles: bool, ?padding: EdgeInsets, ?header: Widget, ?footer: Widget, ?scrollDirection: Axis, ?reverse: bool, ?scrollController: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?anchor: float, ?cacheExtent: float, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip) =
  inherit Widget()
  [<IsConst; NamedParams>] static member builder(itemBuilder: (BuildContext -> int -> Widget), itemCount: int, onReorder: (int -> int -> unit), ?key: Key, ?onReorderStart: (int -> unit), ?onReorderEnd: (int -> unit), ?itemExtent: float, ?prototypeItem: Widget, ?proxyDecorator: (Widget -> int -> Animation<float> -> Widget), ?buildDefaultDragHandles: bool, ?padding: EdgeInsets, ?header: Widget, ?footer: Widget, ?scrollDirection: Axis, ?reverse: bool, ?scrollController: ScrollController, ?primary: bool, ?physics: ScrollPhysics, ?shrinkWrap: bool, ?anchor: float, ?cacheExtent: float, ?dragStartBehavior: DragStartBehavior, ?keyboardDismissBehavior: ScrollViewKeyboardDismissBehavior, ?restorationId: string, ?clipBehavior: Clip): ReorderableListView = nativeOnly

/// https://api.flutter.dev/flutter/material/ScaffoldMessenger-class.html
[<ImportMember("package:flutter/material.dart")>]
type ScaffoldMessenger [<IsConst; NamedParams>] (child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ScaffoldMessengerState-class.html
[<ImportMember("package:flutter/material.dart")>]
type ScaffoldMessengerState () =
  interface State

/// https://api.flutter.dev/flutter/material/ScaffoldPrelayoutGeometry-class.html
[<ImportMember("package:flutter/material.dart")>]
type ScaffoldPrelayoutGeometry [<IsConst; NamedParams>] (bottomSheetSize: Size, contentBottom: float, contentTop: float, floatingActionButtonSize: Size, minInsets: EdgeInsets, minViewPadding: EdgeInsets, scaffoldSize: Size, snackBarSize: Size, materialBannerSize: Size, textDirection: TextDirection) =
  class end

/// https://api.flutter.dev/flutter/material/ScaffoldGeometry-class.html
[<ImportMember("package:flutter/material.dart")>]
type ScaffoldGeometry [<IsConst; NamedParams>] (?bottomNavigationBarTop: float, ?floatingActionButtonArea: Rect) =
  class end

/// https://api.flutter.dev/flutter/material/Scaffold-class.html
[<ImportMember("package:flutter/material.dart")>]
type Scaffold [<IsConst; NamedParams>] (?key: Key, ?appBar: Widget (* PreferredSizeWidget *), ?body: Widget, ?floatingActionButton: Widget, ?floatingActionButtonLocation: FloatingActionButtonLocation, ?floatingActionButtonAnimator: FloatingActionButtonAnimator, ?persistentFooterButtons: Widget[], ?drawer: Widget, ?onDrawerChanged: (bool -> unit), ?endDrawer: Widget, ?onEndDrawerChanged: (bool -> unit), ?bottomNavigationBar: Widget, ?bottomSheet: Widget, ?backgroundColor: Color, ?resizeToAvoidBottomInset: bool, ?primary: bool, ?drawerDragStartBehavior: DragStartBehavior, ?extendBody: bool, ?extendBodyBehindAppBar: bool, ?drawerScrimColor: Color, ?drawerEdgeDragWidth: float, ?drawerEnableOpenDragGesture: bool, ?endDrawerEnableOpenDragGesture: bool, ?restorationId: string) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ScaffoldState-class.html
[<ImportMember("package:flutter/material.dart")>]
type ScaffoldState () =
  interface State

/// https://api.flutter.dev/flutter/material/ScaffoldFeatureController-class.html
[<ImportMember("package:flutter/material.dart")>]
type ScaffoldFeatureController<'T, 'U> =
  class end

/// https://api.flutter.dev/flutter/material/PersistentBottomSheetController-class.html
[<ImportMember("package:flutter/material.dart")>]
type PersistentBottomSheetController<'T> =
  class end

/// https://api.flutter.dev/flutter/material/Scrollbar-class.html
[<ImportMember("package:flutter/material.dart")>]
type Scrollbar [<IsConst; NamedParams>] (child: Widget, ?key: Key, ?controller: ScrollController, ?thumbVisibility: bool, ?trackVisibility: bool, ?thickness: float, ?radius: Radius, ?notificationPredicate: (ScrollNotification -> bool), ?interactive: bool, ?scrollbarOrientation: ScrollbarOrientation, ?isAlwaysShown: bool, ?showTrackOnHover: bool, ?hoverThickness: float) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ScrollbarThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type ScrollbarThemeData [<IsConst; NamedParams>] (?thumbVisibility: MaterialStateProperty<bool option>, ?thickness: MaterialStateProperty<float option>, ?trackVisibility: MaterialStateProperty<bool option>, ?radius: Radius, ?thumbColor: MaterialStateProperty<Color option>, ?trackColor: MaterialStateProperty<Color option>, ?trackBorderColor: MaterialStateProperty<Color option>, ?crossAxisMargin: float, ?mainAxisMargin: float, ?minThumbLength: float, ?interactive: bool, ?isAlwaysShown: bool, ?showTrackOnHover: bool) =
  class end

/// https://api.flutter.dev/flutter/material/ScrollbarTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type ScrollbarTheme [<IsConst; NamedParams>] (data: ScrollbarThemeData, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/material/SearchDelegate-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type SearchDelegate<'T> [<NamedParams>] (?searchFieldLabel: string, ?searchFieldStyle: TextStyle, ?searchFieldDecorationTheme: InputDecorationTheme, ?keyboardType: TextInputType, ?textInputAction: TextInputAction) =
  class end

/// https://api.flutter.dev/flutter/material/SelectableText-class.html
[<ImportMember("package:flutter/material.dart")>]
type SelectableText [<IsConst; NamedParams(fromIndex=1)>] (data: string, ?key: Key, ?focusNode: FocusNode, ?style: TextStyle, ?strutStyle: StrutStyle, ?textAlign: TextAlign, ?textDirection: TextDirection, ?textScaleFactor: float, ?showCursor: bool, ?autofocus: bool, ?toolbarOptions: ToolbarOptions, ?minLines: int, ?maxLines: int, ?cursorWidth: float, ?cursorHeight: float, ?cursorRadius: Radius, ?cursorColor: Color, ?selectionHeightStyle: BoxHeightStyle, ?selectionWidthStyle: BoxWidthStyle, ?dragStartBehavior: DragStartBehavior, ?enableInteractiveSelection: bool, ?selectionControls: TextSelectionControls, ?onTap: (unit -> unit), ?scrollPhysics: ScrollPhysics, ?semanticsLabel: string, ?textHeightBehavior: TextHeightBehavior, ?textWidthBasis: TextWidthBasis, ?onSelectionChanged: (TextSelection -> SelectionChangedCause option -> unit)) =
  inherit Widget()
  [<IsConst; NamedParams(fromIndex=1)>] static member rich(textSpan: TextSpan, ?key: Key, ?focusNode: FocusNode, ?style: TextStyle, ?strutStyle: StrutStyle, ?textAlign: TextAlign, ?textDirection: TextDirection, ?textScaleFactor: float, ?showCursor: bool, ?autofocus: bool, ?toolbarOptions: ToolbarOptions, ?minLines: int, ?maxLines: int, ?cursorWidth: float, ?cursorHeight: float, ?cursorRadius: Radius, ?cursorColor: Color, ?selectionHeightStyle: BoxHeightStyle, ?selectionWidthStyle: BoxWidthStyle, ?dragStartBehavior: DragStartBehavior, ?enableInteractiveSelection: bool, ?selectionControls: TextSelectionControls, ?onTap: (unit -> unit), ?scrollPhysics: ScrollPhysics, ?semanticsLabel: string, ?textHeightBehavior: TextHeightBehavior, ?textWidthBasis: TextWidthBasis, ?onSelectionChanged: (TextSelection -> SelectionChangedCause option -> unit)): SelectableText = nativeOnly

/// https://api.flutter.dev/flutter/material/Slider-class.html
[<ImportMember("package:flutter/material.dart")>]
type Slider [<IsConst; NamedParams>] (value: float, onChanged: (float -> unit), ?key: Key, ?onChangeStart: (float -> unit), ?onChangeEnd: (float -> unit), ?min: float, ?max: float, ?divisions: int, ?label: string, ?activeColor: Color, ?inactiveColor: Color, ?thumbColor: Color, ?mouseCursor: MouseCursor, ?semanticFormatterCallback: (float -> string), ?focusNode: FocusNode, ?autofocus: bool) =
  inherit Widget()
  [<IsConst; NamedParams>] static member adaptive(value: float, onChanged: (float -> unit), ?key: Key, ?onChangeStart: (float -> unit), ?onChangeEnd: (float -> unit), ?min: float, ?max: float, ?divisions: int, ?label: string, ?mouseCursor: MouseCursor, ?activeColor: Color, ?inactiveColor: Color, ?thumbColor: Color, ?semanticFormatterCallback: (float -> string), ?focusNode: FocusNode, ?autofocus: bool): Slider = nativeOnly

/// https://api.flutter.dev/flutter/material/SliderTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type SliderTheme [<IsConst; NamedParams>] (data: SliderThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/SliderThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type SliderThemeData [<IsConst; NamedParams>] (?trackHeight: float, ?activeTrackColor: Color, ?inactiveTrackColor: Color, ?disabledActiveTrackColor: Color, ?disabledInactiveTrackColor: Color, ?activeTickMarkColor: Color, ?inactiveTickMarkColor: Color, ?disabledActiveTickMarkColor: Color, ?disabledInactiveTickMarkColor: Color, ?thumbColor: Color, ?overlappingShapeStrokeColor: Color, ?disabledThumbColor: Color, ?overlayColor: Color, ?valueIndicatorColor: Color, ?overlayShape: SliderComponentShape, ?tickMarkShape: SliderTickMarkShape, ?thumbShape: SliderComponentShape, ?trackShape: SliderTrackShape, ?valueIndicatorShape: SliderComponentShape, ?rangeTickMarkShape: RangeSliderTickMarkShape, ?rangeThumbShape: RangeSliderThumbShape, ?rangeTrackShape: RangeSliderTrackShape, ?rangeValueIndicatorShape: RangeSliderValueIndicatorShape, ?showValueIndicator: ShowValueIndicator, ?valueIndicatorTextStyle: TextStyle, ?minThumbSeparation: float, ?thumbSelector: (TextDirection -> RangeValues -> float -> Size -> Size -> float -> Thumb option), ?mouseCursor: MaterialStateProperty<MouseCursor option>) =
  [<NamedParams>] static member fromPrimaryColors(primaryColor: Color, primaryColorDark: Color, primaryColorLight: Color, valueIndicatorTextStyle: TextStyle): SliderThemeData = nativeOnly

/// https://api.flutter.dev/flutter/material/SliderComponentShape-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type SliderComponentShape [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/material/SliderTickMarkShape-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type SliderTickMarkShape [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/material/SliderTrackShape-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type SliderTrackShape [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/material/RangeSliderThumbShape-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type RangeSliderThumbShape [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/material/RangeSliderValueIndicatorShape-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type RangeSliderValueIndicatorShape [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/material/RangeSliderTickMarkShape-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type RangeSliderTickMarkShape [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/material/RangeSliderTrackShape-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type RangeSliderTrackShape [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/material/RectangularSliderTrackShape-class.html
[<ImportMember("package:flutter/material.dart")>]
type RectangularSliderTrackShape [<IsConst>] () =
  inherit SliderTrackShape()

/// https://api.flutter.dev/flutter/material/RoundedRectSliderTrackShape-class.html
[<ImportMember("package:flutter/material.dart")>]
type RoundedRectSliderTrackShape [<IsConst>] () =
  inherit SliderTrackShape()

/// https://api.flutter.dev/flutter/material/RectangularRangeSliderTrackShape-class.html
[<ImportMember("package:flutter/material.dart")>]
type RectangularRangeSliderTrackShape [<IsConst>] () =
  inherit RangeSliderTrackShape()

/// https://api.flutter.dev/flutter/material/RoundedRectRangeSliderTrackShape-class.html
[<ImportMember("package:flutter/material.dart")>]
type RoundedRectRangeSliderTrackShape [<IsConst>] () =
  inherit RangeSliderTrackShape()

/// https://api.flutter.dev/flutter/material/RoundSliderTickMarkShape-class.html
[<ImportMember("package:flutter/material.dart")>]
type RoundSliderTickMarkShape [<IsConst; NamedParams>] (?tickMarkRadius: float) =
  inherit SliderTickMarkShape()

/// https://api.flutter.dev/flutter/material/RoundRangeSliderTickMarkShape-class.html
[<ImportMember("package:flutter/material.dart")>]
type RoundRangeSliderTickMarkShape [<IsConst; NamedParams>] (?tickMarkRadius: float) =
  inherit RangeSliderTickMarkShape()

/// https://api.flutter.dev/flutter/material/RoundSliderThumbShape-class.html
[<ImportMember("package:flutter/material.dart")>]
type RoundSliderThumbShape [<IsConst; NamedParams>] (?enabledThumbRadius: float, ?disabledThumbRadius: float, ?elevation: float, ?pressedElevation: float) =
  inherit SliderComponentShape()

/// https://api.flutter.dev/flutter/material/RoundRangeSliderThumbShape-class.html
[<ImportMember("package:flutter/material.dart")>]
type RoundRangeSliderThumbShape [<IsConst; NamedParams>] (?enabledThumbRadius: float, ?disabledThumbRadius: float, ?elevation: float, ?pressedElevation: float) =
  inherit RangeSliderThumbShape()

/// https://api.flutter.dev/flutter/material/RoundSliderOverlayShape-class.html
[<ImportMember("package:flutter/material.dart")>]
type RoundSliderOverlayShape [<IsConst; NamedParams>] (?overlayRadius: float) =
  inherit SliderComponentShape()

/// https://api.flutter.dev/flutter/material/RectangularSliderValueIndicatorShape-class.html
[<ImportMember("package:flutter/material.dart")>]
type RectangularSliderValueIndicatorShape [<IsConst>] () =
  inherit SliderComponentShape()

/// https://api.flutter.dev/flutter/material/RectangularRangeSliderValueIndicatorShape-class.html
[<ImportMember("package:flutter/material.dart")>]
type RectangularRangeSliderValueIndicatorShape [<IsConst>] () =
  inherit RangeSliderValueIndicatorShape()

/// https://api.flutter.dev/flutter/material/PaddleSliderValueIndicatorShape-class.html
[<ImportMember("package:flutter/material.dart")>]
type PaddleSliderValueIndicatorShape [<IsConst>] () =
  inherit SliderComponentShape()

/// https://api.flutter.dev/flutter/material/PaddleRangeSliderValueIndicatorShape-class.html
[<ImportMember("package:flutter/material.dart")>]
type PaddleRangeSliderValueIndicatorShape [<IsConst>] () =
  inherit RangeSliderValueIndicatorShape()

/// https://api.flutter.dev/flutter/material/RangeValues-class.html
[<ImportMember("package:flutter/material.dart")>]
type RangeValues [<IsConst>] (start: float, ``end``: float) =
  class end

/// https://api.flutter.dev/flutter/material/RangeLabels-class.html
[<ImportMember("package:flutter/material.dart")>]
type RangeLabels [<IsConst>] (start: string, ``end``: string) =
  class end

/// https://api.flutter.dev/flutter/material/SnackBarAction-class.html
[<ImportMember("package:flutter/material.dart")>]
type SnackBarAction [<IsConst; NamedParams>] (label: string, onPressed: (unit -> unit), ?key: Key, ?textColor: Color, ?disabledTextColor: Color) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/SnackBar-class.html
[<ImportMember("package:flutter/material.dart")>]
type SnackBar [<IsConst; NamedParams>] (content: Widget, ?key: Key, ?backgroundColor: Color, ?elevation: float, ?margin: EdgeInsetsGeometry, ?padding: EdgeInsetsGeometry, ?width: float, ?shape: ShapeBorder, ?behavior: SnackBarBehavior, ?action: SnackBarAction, ?duration: TimeSpan, ?animation: Animation<float>, ?onVisible: (unit -> unit), ?dismissDirection: DismissDirection, ?clipBehavior: Clip) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/SnackBarThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type SnackBarThemeData [<IsConst; NamedParams>] (?backgroundColor: Color, ?actionTextColor: Color, ?disabledActionTextColor: Color, ?contentTextStyle: TextStyle, ?elevation: float, ?shape: ShapeBorder, ?behavior: SnackBarBehavior) =
  class end

/// https://api.flutter.dev/flutter/material/ControlsDetails-class.html
[<ImportMember("package:flutter/material.dart")>]
type ControlsDetails [<IsConst; NamedParams>] (currentStep: int, stepIndex: int, ?onStepCancel: (unit -> unit), ?onStepContinue: (unit -> unit)) =
  class end

/// https://api.flutter.dev/flutter/material/Step-class.html
[<ImportMember("package:flutter/material.dart")>]
type Step [<IsConst; NamedParams>] (title: Widget, content: Widget, ?subtitle: Widget, ?state: StepState, ?isActive: bool) =
  class end

/// https://api.flutter.dev/flutter/material/Stepper-class.html
[<ImportMember("package:flutter/material.dart")>]
type Stepper [<IsConst; NamedParams>] (steps: Step[], ?key: Key, ?physics: ScrollPhysics, ?``type``: StepperType, ?currentStep: int, ?onStepTapped: (int -> unit), ?onStepContinue: (unit -> unit), ?onStepCancel: (unit -> unit), ?controlsBuilder: (BuildContext -> ControlsDetails -> Widget), ?elevation: float, ?margin: EdgeInsetsGeometry) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/Switch-class.html
[<ImportMember("package:flutter/material.dart")>]
type Switch [<IsConst; NamedParams>] (value: bool, onChanged: (bool -> unit), ?key: Key, ?activeColor: Color, ?activeTrackColor: Color, ?inactiveThumbColor: Color, ?inactiveTrackColor: Color, ?activeThumbImage: ImageProvider<obj>, ?onActiveThumbImageError: (obj -> StackTrace option -> unit), ?inactiveThumbImage: ImageProvider<obj>, ?onInactiveThumbImageError: (obj -> StackTrace option -> unit), ?thumbColor: MaterialStateProperty<Color option>, ?trackColor: MaterialStateProperty<Color option>, ?materialTapTargetSize: MaterialTapTargetSize, ?dragStartBehavior: DragStartBehavior, ?mouseCursor: MouseCursor, ?focusColor: Color, ?hoverColor: Color, ?overlayColor: MaterialStateProperty<Color option>, ?splashRadius: float, ?focusNode: FocusNode, ?autofocus: bool) =
  inherit Widget()
  [<IsConst; NamedParams>] static member adaptive(value: bool, onChanged: (bool -> unit), ?key: Key, ?activeColor: Color, ?activeTrackColor: Color, ?inactiveThumbColor: Color, ?inactiveTrackColor: Color, ?activeThumbImage: ImageProvider<obj>, ?onActiveThumbImageError: (obj -> StackTrace option -> unit), ?inactiveThumbImage: ImageProvider<obj>, ?onInactiveThumbImageError: (obj -> StackTrace option -> unit), ?materialTapTargetSize: MaterialTapTargetSize, ?thumbColor: MaterialStateProperty<Color option>, ?trackColor: MaterialStateProperty<Color option>, ?dragStartBehavior: DragStartBehavior, ?mouseCursor: MouseCursor, ?focusColor: Color, ?hoverColor: Color, ?overlayColor: MaterialStateProperty<Color option>, ?splashRadius: float, ?focusNode: FocusNode, ?autofocus: bool): Switch = nativeOnly

/// https://api.flutter.dev/flutter/material/SwitchListTile-class.html
[<ImportMember("package:flutter/material.dart")>]
type SwitchListTile [<IsConst; NamedParams>] (value: bool, onChanged: (bool -> unit), ?key: Key, ?tileColor: Color, ?activeColor: Color, ?activeTrackColor: Color, ?inactiveThumbColor: Color, ?inactiveTrackColor: Color, ?activeThumbImage: ImageProvider<obj>, ?inactiveThumbImage: ImageProvider<obj>, ?title: Widget, ?subtitle: Widget, ?isThreeLine: bool, ?dense: bool, ?contentPadding: EdgeInsetsGeometry, ?secondary: Widget, ?selected: bool, ?autofocus: bool, ?controlAffinity: ListTileControlAffinity, ?shape: ShapeBorder, ?selectedTileColor: Color, ?visualDensity: VisualDensity, ?focusNode: FocusNode, ?enableFeedback: bool, ?hoverColor: Color) =
  inherit Widget()
  [<IsConst; NamedParams>] static member adaptive(value: bool, onChanged: (bool -> unit), ?key: Key, ?tileColor: Color, ?activeColor: Color, ?activeTrackColor: Color, ?inactiveThumbColor: Color, ?inactiveTrackColor: Color, ?activeThumbImage: ImageProvider<obj>, ?inactiveThumbImage: ImageProvider<obj>, ?title: Widget, ?subtitle: Widget, ?isThreeLine: bool, ?dense: bool, ?contentPadding: EdgeInsetsGeometry, ?secondary: Widget, ?selected: bool, ?autofocus: bool, ?controlAffinity: ListTileControlAffinity, ?shape: ShapeBorder, ?selectedTileColor: Color, ?visualDensity: VisualDensity, ?focusNode: FocusNode, ?enableFeedback: bool, ?hoverColor: Color): SwitchListTile = nativeOnly

/// https://api.flutter.dev/flutter/material/SwitchThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type SwitchThemeData [<IsConst; NamedParams>] (?thumbColor: MaterialStateProperty<Color option>, ?trackColor: MaterialStateProperty<Color option>, ?materialTapTargetSize: MaterialTapTargetSize, ?mouseCursor: MaterialStateProperty<MouseCursor option>, ?overlayColor: MaterialStateProperty<Color option>, ?splashRadius: float) =
  class end

/// https://api.flutter.dev/flutter/material/SwitchTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type SwitchTheme [<IsConst; NamedParams>] (data: SwitchThemeData, child: Widget, ?key: Key) =
  inherit InheritedWidget(child)

/// https://api.flutter.dev/flutter/material/TabBarTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type TabBarTheme [<IsConst; NamedParams>] (?indicator: Decoration, ?indicatorSize: TabBarIndicatorSize, ?labelColor: Color, ?labelPadding: EdgeInsetsGeometry, ?labelStyle: TextStyle, ?unselectedLabelColor: Color, ?unselectedLabelStyle: TextStyle, ?overlayColor: MaterialStateProperty<Color option>, ?splashFactory: InteractiveInkFeatureFactory, ?mouseCursor: MaterialStateProperty<MouseCursor option>) =
  class end

/// https://api.flutter.dev/flutter/material/TabController-class.html
[<ImportMember("package:flutter/material.dart")>]
type TabController [<NamedParams>] (length: int, vsync: TickerProvider, ?initialIndex: int, ?animationDuration: TimeSpan) =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/material/DefaultTabController-class.html
[<ImportMember("package:flutter/material.dart")>]
type DefaultTabController [<IsConst; NamedParams>] (length: int, child: Widget, ?key: Key, ?initialIndex: int, ?animationDuration: TimeSpan) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/UnderlineTabIndicator-class.html
[<ImportMember("package:flutter/material.dart")>]
type UnderlineTabIndicator [<IsConst; NamedParams>] (?borderSide: BorderSide, ?insets: EdgeInsetsGeometry) =
  inherit Decoration()

/// https://api.flutter.dev/flutter/material/Tab-class.html
[<ImportMember("package:flutter/material.dart")>]
type Tab [<IsConst; NamedParams>] (?key: Key, ?text: string, ?icon: Widget, ?iconMargin: EdgeInsetsGeometry, ?height: float, ?child: Widget) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/TabBar-class.html
[<ImportMember("package:flutter/material.dart")>]
type TabBar [<IsConst; NamedParams>] (tabs: Widget[], ?key: Key, ?controller: TabController, ?isScrollable: bool, ?padding: EdgeInsetsGeometry, ?indicatorColor: Color, ?automaticIndicatorColorAdjustment: bool, ?indicatorWeight: float, ?indicatorPadding: EdgeInsetsGeometry, ?indicator: Decoration, ?indicatorSize: TabBarIndicatorSize, ?labelColor: Color, ?labelStyle: TextStyle, ?labelPadding: EdgeInsetsGeometry, ?unselectedLabelColor: Color, ?unselectedLabelStyle: TextStyle, ?dragStartBehavior: DragStartBehavior, ?overlayColor: MaterialStateProperty<Color option>, ?mouseCursor: MouseCursor, ?enableFeedback: bool, ?onTap: (int -> unit), ?physics: ScrollPhysics, ?splashFactory: InteractiveInkFeatureFactory, ?splashBorderRadius: BorderRadius) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/TabBarView-class.html
[<ImportMember("package:flutter/material.dart")>]
type TabBarView [<IsConst; NamedParams>] (children: Widget[], ?key: Key, ?controller: TabController, ?physics: ScrollPhysics, ?dragStartBehavior: DragStartBehavior, ?viewportFraction: float) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/TabPageSelectorIndicator-class.html
[<ImportMember("package:flutter/material.dart")>]
type TabPageSelectorIndicator [<IsConst; NamedParams>] (backgroundColor: Color, borderColor: Color, size: float, ?key: Key, ?borderStyle: BorderStyle) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/TabPageSelector-class.html
[<ImportMember("package:flutter/material.dart")>]
type TabPageSelector [<IsConst; NamedParams>] (?key: Key, ?controller: TabController, ?indicatorSize: float, ?color: Color, ?selectedColor: Color, ?borderStyle: BorderStyle) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/TextButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type TextButton [<IsConst; NamedParams>] (onPressed: (unit -> unit), child: Widget, ?key: Key, ?onLongPress: (unit -> unit), ?onHover: (bool -> unit), ?onFocusChange: (bool -> unit), ?style: ButtonStyle, ?focusNode: FocusNode, ?autofocus: bool, ?clipBehavior: Clip) =
  inherit ButtonStyleButton(nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly, nativeOnly)
  [<NamedParams>] static member icon(onPressed: (unit -> unit), icon: Widget, label: Widget, ?key: Key, ?onLongPress: (unit -> unit), ?onHover: (bool -> unit), ?onFocusChange: (bool -> unit), ?style: ButtonStyle, ?focusNode: FocusNode, ?autofocus: bool, ?clipBehavior: Clip): TextButton = nativeOnly

/// https://api.flutter.dev/flutter/material/TextButtonThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type TextButtonThemeData [<IsConst; NamedParams>] (?style: ButtonStyle) =
  class end

/// https://api.flutter.dev/flutter/material/TextButtonTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type TextButtonTheme [<IsConst; NamedParams>] (data: TextButtonThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/TextField-class.html
[<ImportMember("package:flutter/material.dart")>]
type TextField [<IsConst; NamedParams>] (?key: Key, ?controller: TextEditingController, ?focusNode: FocusNode, ?decoration: InputDecoration, ?keyboardType: TextInputType, ?textInputAction: TextInputAction, ?textCapitalization: TextCapitalization, ?style: TextStyle, ?strutStyle: StrutStyle, ?textAlign: TextAlign, ?textAlignVertical: TextAlignVertical, ?textDirection: TextDirection, ?readOnly: bool, ?toolbarOptions: ToolbarOptions, ?showCursor: bool, ?autofocus: bool, ?obscuringCharacter: string, ?obscureText: bool, ?autocorrect: bool, ?smartDashesType: SmartDashesType, ?smartQuotesType: SmartQuotesType, ?enableSuggestions: bool, ?maxLines: int, ?minLines: int, ?expands: bool, ?maxLength: int, ?maxLengthEnforcement: MaxLengthEnforcement, ?onChanged: (string -> unit), ?onEditingComplete: (unit -> unit), ?onSubmitted: (string -> unit), ?onAppPrivateCommand: (string -> Dictionary<string, obj> -> unit), ?inputFormatters: TextInputFormatter[], ?enabled: bool, ?cursorWidth: float, ?cursorHeight: float, ?cursorRadius: Radius, ?cursorColor: Color, ?selectionHeightStyle: BoxHeightStyle, ?selectionWidthStyle: BoxWidthStyle, ?keyboardAppearance: Brightness, ?scrollPadding: EdgeInsets, ?dragStartBehavior: DragStartBehavior, ?enableInteractiveSelection: bool, ?selectionControls: TextSelectionControls, ?onTap: (unit -> unit), ?mouseCursor: MouseCursor, ?buildCounter: (BuildContext -> int -> bool -> int option -> Widget option), ?scrollController: ScrollController, ?scrollPhysics: ScrollPhysics, ?autofillHints: string seq, ?clipBehavior: Clip, ?restorationId: string, ?scribbleEnabled: bool, ?enableIMEPersonalizedLearning: bool) =
  inherit Widget()
  [<IsConst>] static member noMaxLength: int = nativeOnly

/// https://api.flutter.dev/flutter/material/TextFormField-class.html
[<ImportMember("package:flutter/material.dart")>]
type TextFormField [<NamedParams>] (?key: Key, ?controller: TextEditingController, ?initialValue: string, ?focusNode: FocusNode, ?decoration: InputDecoration, ?keyboardType: TextInputType, ?textCapitalization: TextCapitalization, ?textInputAction: TextInputAction, ?style: TextStyle, ?strutStyle: StrutStyle, ?textDirection: TextDirection, ?textAlign: TextAlign, ?textAlignVertical: TextAlignVertical, ?autofocus: bool, ?readOnly: bool, ?toolbarOptions: ToolbarOptions, ?showCursor: bool, ?obscuringCharacter: string, ?obscureText: bool, ?autocorrect: bool, ?smartDashesType: SmartDashesType, ?smartQuotesType: SmartQuotesType, ?enableSuggestions: bool, ?maxLengthEnforcement: MaxLengthEnforcement, ?maxLines: int, ?minLines: int, ?expands: bool, ?maxLength: int, ?onChanged: (string -> unit), ?onTap: (unit -> unit), ?onEditingComplete: (unit -> unit), ?onFieldSubmitted: (string -> unit), ?onSaved: (string option -> unit), ?validator: (string option -> string option), ?inputFormatters: TextInputFormatter[], ?enabled: bool, ?cursorWidth: float, ?cursorHeight: float, ?cursorRadius: Radius, ?cursorColor: Color, ?keyboardAppearance: Brightness, ?scrollPadding: EdgeInsets, ?enableInteractiveSelection: bool, ?selectionControls: TextSelectionControls, ?buildCounter: (BuildContext -> int -> bool -> int option -> Widget option), ?scrollPhysics: ScrollPhysics, ?autofillHints: string seq, ?autovalidateMode: AutovalidateMode, ?scrollController: ScrollController, ?restorationId: string, ?enableIMEPersonalizedLearning: bool, ?mouseCursor: MouseCursor) =
  inherit FormField<string>(nativeOnly)

/// https://api.flutter.dev/flutter/material/MaterialTextSelectionControls-class.html
[<ImportMember("package:flutter/material.dart")>]
type MaterialTextSelectionControls () =
  inherit TextSelectionControls()

/// https://api.flutter.dev/flutter/material/TextSelectionThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type TextSelectionThemeData [<IsConst; NamedParams>] (?cursorColor: Color, ?selectionColor: Color, ?selectionHandleColor: Color) =
  class end

/// https://api.flutter.dev/flutter/material/TextSelectionTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type TextSelectionTheme [<IsConst; NamedParams>] (data: TextSelectionThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/TextSelectionToolbar-class.html
[<ImportMember("package:flutter/material.dart")>]
type TextSelectionToolbar [<IsConst; NamedParams>] (anchorAbove: Offset, anchorBelow: Offset, children: Widget[], ?key: Key, ?toolbarBuilder: (BuildContext -> Widget -> Widget)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/TextSelectionToolbarTextButton-class.html
[<ImportMember("package:flutter/material.dart")>]
type TextSelectionToolbarTextButton [<IsConst; NamedParams>] (child: Widget, padding: EdgeInsets, ?key: Key, ?onPressed: (unit -> unit)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/TextTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type TextTheme [<IsConst; NamedParams>] (?displayLarge: TextStyle, ?displayMedium: TextStyle, ?displaySmall: TextStyle, ?headlineLarge: TextStyle, ?headlineMedium: TextStyle, ?headlineSmall: TextStyle, ?titleLarge: TextStyle, ?titleMedium: TextStyle, ?titleSmall: TextStyle, ?bodyLarge: TextStyle, ?bodyMedium: TextStyle, ?bodySmall: TextStyle, ?labelLarge: TextStyle, ?labelMedium: TextStyle, ?labelSmall: TextStyle, ?headline1: TextStyle, ?headline2: TextStyle, ?headline3: TextStyle, ?headline4: TextStyle, ?headline5: TextStyle, ?headline6: TextStyle, ?subtitle1: TextStyle, ?subtitle2: TextStyle, ?bodyText1: TextStyle, ?bodyText2: TextStyle, ?caption: TextStyle, ?button: TextStyle, ?overline: TextStyle) =
  class end

/// https://api.flutter.dev/flutter/material/Theme-class.html
[<ImportMember("package:flutter/material.dart")>]
type Theme [<IsConst; NamedParams>] (data: ThemeData, child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ThemeDataTween-class.html
[<ImportMember("package:flutter/material.dart")>]
type ThemeDataTween [<NamedParams>] (?``begin``: ThemeData, ?``end``: ThemeData) =
  inherit Tween<ThemeData>()

/// https://api.flutter.dev/flutter/material/AnimatedTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type AnimatedTheme [<IsConst; NamedParams>] (data: ThemeData, child: Widget, ?key: Key, ?curve: Curve, ?duration: TimeSpan, ?onEnd: (unit -> unit)) =
  inherit ImplicitlyAnimatedWidget(nativeOnly)

/// https://api.flutter.dev/flutter/material/ThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type ThemeData [<NamedParams>] (?applyElevationOverlayColor: bool, (*?cupertinoOverrideTheme: NoDefaultCupertinoThemeData,*) ?extensions: ThemeExtension<obj> seq, ?inputDecorationTheme: InputDecorationTheme, ?materialTapTargetSize: MaterialTapTargetSize, ?pageTransitionsTheme: PageTransitionsTheme, ?platform: TargetPlatform, ?scrollbarTheme: ScrollbarThemeData, ?splashFactory: InteractiveInkFeatureFactory, ?visualDensity: VisualDensity, ?useMaterial3: bool, ?colorScheme: ColorScheme, ?colorSchemeSeed: Color, ?brightness: Brightness, ?primarySwatch: MaterialColor, ?primaryColor: Color, ?primaryColorLight: Color, ?primaryColorDark: Color, ?focusColor: Color, ?hoverColor: Color, ?shadowColor: Color, ?canvasColor: Color, ?scaffoldBackgroundColor: Color, ?bottomAppBarColor: Color, ?cardColor: Color, ?dividerColor: Color, ?highlightColor: Color, ?splashColor: Color, ?selectedRowColor: Color, ?unselectedWidgetColor: Color, ?disabledColor: Color, ?secondaryHeaderColor: Color, ?backgroundColor: Color, ?dialogBackgroundColor: Color, ?indicatorColor: Color, ?hintColor: Color, ?errorColor: Color, ?toggleableActiveColor: Color, ?fontFamily: string, ?typography: Typography, ?textTheme: TextTheme, ?primaryTextTheme: TextTheme, ?iconTheme: IconThemeData, ?primaryIconTheme: IconThemeData, ?appBarTheme: AppBarTheme, ?bannerTheme: MaterialBannerThemeData, ?bottomAppBarTheme: BottomAppBarTheme, ?bottomNavigationBarTheme: BottomNavigationBarThemeData, ?bottomSheetTheme: BottomSheetThemeData, ?buttonBarTheme: ButtonBarThemeData, ?buttonTheme: ButtonThemeData, ?cardTheme: CardTheme, ?checkboxTheme: CheckboxThemeData, ?chipTheme: ChipThemeData, ?dataTableTheme: DataTableThemeData, ?dialogTheme: DialogTheme, ?dividerTheme: DividerThemeData, ?drawerTheme: DrawerThemeData, ?elevatedButtonTheme: ElevatedButtonThemeData, ?floatingActionButtonTheme: FloatingActionButtonThemeData, ?listTileTheme: ListTileThemeData, ?navigationBarTheme: NavigationBarThemeData, ?navigationRailTheme: NavigationRailThemeData, ?outlinedButtonTheme: OutlinedButtonThemeData, ?popupMenuTheme: PopupMenuThemeData, ?progressIndicatorTheme: ProgressIndicatorThemeData, ?radioTheme: RadioThemeData, ?sliderTheme: SliderThemeData, ?snackBarTheme: SnackBarThemeData, ?switchTheme: SwitchThemeData, ?tabBarTheme: TabBarTheme, ?textButtonTheme: TextButtonThemeData, ?textSelectionTheme: TextSelectionThemeData, ?timePickerTheme: TimePickerThemeData, ?toggleButtonsTheme: ToggleButtonsThemeData, ?tooltipTheme: TooltipThemeData, ?expansionTileTheme: ExpansionTileThemeData, ?useTextSelectionTheme: bool, ?textSelectionColor: Color, ?cursorColor: Color, ?textSelectionHandleColor: Color, ?accentColor: Color, ?accentColorBrightness: Brightness, ?accentTextTheme: TextTheme, ?accentIconTheme: IconThemeData, ?buttonColor: Color, ?fixTextFieldOutlineLabel: bool, ?primaryColorBrightness: Brightness, ?androidOverscrollIndicator: AndroidOverscrollIndicator) =
  // [<IsConst; NamedParams>] static member raw(applyElevationOverlayColor: bool, cupertinoOverrideTheme: NoDefaultCupertinoThemeData option, extensions: Dictionary<obj, ThemeExtension<obj>>, inputDecorationTheme: InputDecorationTheme, materialTapTargetSize: MaterialTapTargetSize, pageTransitionsTheme: PageTransitionsTheme, platform: TargetPlatform, scrollbarTheme: ScrollbarThemeData, splashFactory: InteractiveInkFeatureFactory, visualDensity: VisualDensity, useMaterial3: bool, colorScheme: ColorScheme, primaryColor: Color, primaryColorLight: Color, primaryColorDark: Color, focusColor: Color, hoverColor: Color, shadowColor: Color, canvasColor: Color, scaffoldBackgroundColor: Color, bottomAppBarColor: Color, cardColor: Color, dividerColor: Color, highlightColor: Color, splashColor: Color, selectedRowColor: Color, unselectedWidgetColor: Color, disabledColor: Color, secondaryHeaderColor: Color, backgroundColor: Color, dialogBackgroundColor: Color, indicatorColor: Color, hintColor: Color, errorColor: Color, toggleableActiveColor: Color, typography: Typography, textTheme: TextTheme, primaryTextTheme: TextTheme, iconTheme: IconThemeData, primaryIconTheme: IconThemeData, appBarTheme: AppBarTheme, bannerTheme: MaterialBannerThemeData, bottomAppBarTheme: BottomAppBarTheme, bottomNavigationBarTheme: BottomNavigationBarThemeData, bottomSheetTheme: BottomSheetThemeData, buttonBarTheme: ButtonBarThemeData, buttonTheme: ButtonThemeData, cardTheme: CardTheme, checkboxTheme: CheckboxThemeData, chipTheme: ChipThemeData, dataTableTheme: DataTableThemeData, dialogTheme: DialogTheme, dividerTheme: DividerThemeData, drawerTheme: DrawerThemeData, elevatedButtonTheme: ElevatedButtonThemeData, floatingActionButtonTheme: FloatingActionButtonThemeData, listTileTheme: ListTileThemeData, navigationBarTheme: NavigationBarThemeData, navigationRailTheme: NavigationRailThemeData, outlinedButtonTheme: OutlinedButtonThemeData, popupMenuTheme: PopupMenuThemeData, progressIndicatorTheme: ProgressIndicatorThemeData, radioTheme: RadioThemeData, sliderTheme: SliderThemeData, snackBarTheme: SnackBarThemeData, switchTheme: SwitchThemeData, tabBarTheme: TabBarTheme, textButtonTheme: TextButtonThemeData, textSelectionTheme: TextSelectionThemeData, timePickerTheme: TimePickerThemeData, toggleButtonsTheme: ToggleButtonsThemeData, tooltipTheme: TooltipThemeData, expansionTileTheme: ExpansionTileThemeData, useTextSelectionTheme: bool, textSelectionColor: Color, cursorColor: Color, textSelectionHandleColor: Color, accentColor: Color, accentColorBrightness: Brightness, accentTextTheme: TextTheme, accentIconTheme: IconThemeData, buttonColor: Color, fixTextFieldOutlineLabel: bool, primaryColorBrightness: Brightness, androidOverscrollIndicator: AndroidOverscrollIndicator option): ThemeData = nativeOnly
  [<NamedParams>] static member from(colorScheme: ColorScheme, ?textTheme: TextTheme, ?useMaterial3: bool): ThemeData = nativeOnly
  static member light(): ThemeData = nativeOnly
  static member dark(): ThemeData = nativeOnly
  static member fallback(): ThemeData = nativeOnly

/// https://api.flutter.dev/flutter/material/ThemeExtension-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type ThemeExtension<'T> [<IsConst>] () =
  class end

// /// https://api.flutter.dev/flutter/material/MaterialBasedCupertinoThemeData-class.html
// [<ImportMember("package:flutter/material.dart")>]
// type MaterialBasedCupertinoThemeData [<NamedParams>] (materialTheme: ThemeData) =
//   inherit CupertinoThemeData()

/// https://api.flutter.dev/flutter/material/VisualDensity-class.html
[<ImportMember("package:flutter/material.dart")>]
type VisualDensity [<IsConst; NamedParams>] (?horizontal: float, ?vertical: float) =
  [<IsConst>] static member minimumDensity: float = nativeOnly
  [<IsConst>] static member maximumDensity: float = nativeOnly
  [<IsConst>] static member standard: VisualDensity = nativeOnly
  [<IsConst>] static member comfortable: VisualDensity = nativeOnly
  [<IsConst>] static member compact: VisualDensity = nativeOnly

/// https://api.flutter.dev/flutter/material/TimeOfDay-class.html
[<ImportMember("package:flutter/material.dart")>]
type TimeOfDay [<IsConst; NamedParams>] (hour: int, minute: int) =
  static member fromDateTime(time: DateTime): TimeOfDay = nativeOnly
  static member now(): TimeOfDay = nativeOnly
  [<IsConst>] static member hoursPerDay: int = nativeOnly
  [<IsConst>] static member hoursPerPeriod: int = nativeOnly
  [<IsConst>] static member minutesPerHour: int = nativeOnly

/// https://api.flutter.dev/flutter/material/RestorableTimeOfDay-class.html
[<ImportMember("package:flutter/material.dart")>]
type RestorableTimeOfDay (defaultValue: TimeOfDay) =
  inherit RestorableValue<TimeOfDay>()

/// https://api.flutter.dev/flutter/material/TimePickerDialog-class.html
[<ImportMember("package:flutter/material.dart")>]
type TimePickerDialog [<IsConst; NamedParams>] (initialTime: TimeOfDay, ?key: Key, ?cancelText: string, ?confirmText: string, ?helpText: string, ?errorInvalidText: string, ?hourLabelText: string, ?minuteLabelText: string, ?restorationId: string, ?initialEntryMode: TimePickerEntryMode, ?onEntryModeChanged: (TimePickerEntryMode -> unit)) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/TimePickerThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type TimePickerThemeData [<IsConst; NamedParams>] (?backgroundColor: Color, ?hourMinuteTextColor: Color, ?hourMinuteColor: Color, ?dayPeriodTextColor: Color, ?dayPeriodColor: Color, ?dialHandColor: Color, ?dialBackgroundColor: Color, ?dialTextColor: Color, ?entryModeIconColor: Color, ?hourMinuteTextStyle: TextStyle, ?dayPeriodTextStyle: TextStyle, ?helpTextStyle: TextStyle, ?shape: ShapeBorder, ?hourMinuteShape: ShapeBorder, ?dayPeriodShape: OutlinedBorder, ?dayPeriodBorderSide: BorderSide, ?inputDecorationTheme: InputDecorationTheme) =
  class end

/// https://api.flutter.dev/flutter/material/TimePickerTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type TimePickerTheme [<IsConst; NamedParams>] (data: TimePickerThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/ToggleButtons-class.html
[<ImportMember("package:flutter/material.dart")>]
type ToggleButtons [<IsConst; NamedParams>] (children: Widget[], isSelected: bool[], ?key: Key, ?onPressed: (int -> unit), ?mouseCursor: MouseCursor, ?tapTargetSize: MaterialTapTargetSize, ?textStyle: TextStyle, ?constraints: BoxConstraints, ?color: Color, ?selectedColor: Color, ?disabledColor: Color, ?fillColor: Color, ?focusColor: Color, ?highlightColor: Color, ?hoverColor: Color, ?splashColor: Color, ?focusNodes: FocusNode[], ?renderBorder: bool, ?borderColor: Color, ?selectedBorderColor: Color, ?disabledBorderColor: Color, ?borderRadius: BorderRadius, ?borderWidth: float, ?direction: Axis, ?verticalDirection: VerticalDirection) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/ToggleButtonsThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type ToggleButtonsThemeData [<IsConst; NamedParams>] (?textStyle: TextStyle, ?constraints: BoxConstraints, ?color: Color, ?selectedColor: Color, ?disabledColor: Color, ?fillColor: Color, ?focusColor: Color, ?highlightColor: Color, ?hoverColor: Color, ?splashColor: Color, ?borderColor: Color, ?selectedBorderColor: Color, ?disabledBorderColor: Color, ?borderRadius: BorderRadius, ?borderWidth: float) =
  class end

/// https://api.flutter.dev/flutter/material/ToggleButtonsTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type ToggleButtonsTheme [<IsConst; NamedParams>] (data: ToggleButtonsThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/ToggleablePainter-class.html
[<ImportMember("package:flutter/material.dart"); AbstractClass>]
type ToggleablePainter () =
  inherit ChangeNotifier()

/// https://api.flutter.dev/flutter/material/Tooltip-class.html
[<ImportMember("package:flutter/material.dart")>]
type Tooltip [<IsConst; NamedParams>] (?key: Key, ?message: string, ?richMessage: InlineSpan, ?height: float, ?padding: EdgeInsetsGeometry, ?margin: EdgeInsetsGeometry, ?verticalOffset: float, ?preferBelow: bool, ?excludeFromSemantics: bool, ?decoration: Decoration, ?textStyle: TextStyle, ?waitDuration: TimeSpan, ?showDuration: TimeSpan, ?child: Widget, ?triggerMode: TooltipTriggerMode, ?enableFeedback: bool) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/TooltipState-class.html
[<ImportMember("package:flutter/material.dart")>]
type TooltipState () =
  interface State

/// https://api.flutter.dev/flutter/material/TooltipThemeData-class.html
[<ImportMember("package:flutter/material.dart")>]
type TooltipThemeData [<IsConst; NamedParams>] (?height: float, ?padding: EdgeInsetsGeometry, ?margin: EdgeInsetsGeometry, ?verticalOffset: float, ?preferBelow: bool, ?excludeFromSemantics: bool, ?decoration: Decoration, ?textStyle: TextStyle, ?waitDuration: TimeSpan, ?showDuration: TimeSpan, ?triggerMode: TooltipTriggerMode, ?enableFeedback: bool) =
  class end

/// https://api.flutter.dev/flutter/material/TooltipTheme-class.html
[<ImportMember("package:flutter/material.dart")>]
type TooltipTheme [<IsConst; NamedParams>] (data: TooltipThemeData, child: Widget, ?key: Key) =
  inherit InheritedTheme(child)

/// https://api.flutter.dev/flutter/material/TooltipVisibility-class.html
[<ImportMember("package:flutter/material.dart")>]
type TooltipVisibility [<IsConst; NamedParams>] (visible: bool, child: Widget, ?key: Key) =
  inherit Widget()

/// https://api.flutter.dev/flutter/material/Typography-class.html
[<ImportMember("package:flutter/material.dart")>]
type Typography [<NamedParams>] (?platform: TargetPlatform, ?black: TextTheme, ?white: TextTheme, ?englishLike: TextTheme, ?dense: TextTheme, ?tall: TextTheme) =
  [<NamedParams>] static member material2014(?platform: TargetPlatform, ?black: TextTheme, ?white: TextTheme, ?englishLike: TextTheme, ?dense: TextTheme, ?tall: TextTheme): Typography = nativeOnly
  [<NamedParams>] static member material2018(?platform: TargetPlatform, ?black: TextTheme, ?white: TextTheme, ?englishLike: TextTheme, ?dense: TextTheme, ?tall: TextTheme): Typography = nativeOnly
  [<NamedParams>] static member material2021(?platform: TargetPlatform, ?black: TextTheme, ?white: TextTheme, ?englishLike: TextTheme, ?dense: TextTheme, ?tall: TextTheme): Typography = nativeOnly
  [<IsConst>] static member blackMountainView: TextTheme = nativeOnly
  [<IsConst>] static member whiteMountainView: TextTheme = nativeOnly
  [<IsConst>] static member blackRedmond: TextTheme = nativeOnly
  [<IsConst>] static member whiteRedmond: TextTheme = nativeOnly
  [<IsConst>] static member blackHelsinki: TextTheme = nativeOnly
  [<IsConst>] static member whiteHelsinki: TextTheme = nativeOnly
  [<IsConst>] static member blackCupertino: TextTheme = nativeOnly
  [<IsConst>] static member whiteCupertino: TextTheme = nativeOnly
  [<IsConst>] static member blackRedwoodCity: TextTheme = nativeOnly
  [<IsConst>] static member whiteRedwoodCity: TextTheme = nativeOnly
  [<IsConst>] static member englishLike2014: TextTheme = nativeOnly
  [<IsConst>] static member englishLike2018: TextTheme = nativeOnly
  [<IsConst>] static member dense2014: TextTheme = nativeOnly
  [<IsConst>] static member dense2018: TextTheme = nativeOnly
  [<IsConst>] static member tall2014: TextTheme = nativeOnly
  [<IsConst>] static member tall2018: TextTheme = nativeOnly
  [<IsConst>] static member englishLike2021: TextTheme = nativeOnly
  [<IsConst>] static member dense2021: TextTheme = nativeOnly
  [<IsConst>] static member tall2021: TextTheme = nativeOnly

/// https://api.flutter.dev/flutter/material/UserAccountsDrawerHeader-class.html
[<ImportMember("package:flutter/material.dart")>]
type UserAccountsDrawerHeader [<IsConst; NamedParams>] (accountName: Widget option, accountEmail: Widget option, ?key: Key, ?decoration: Decoration, ?margin: EdgeInsetsGeometry, ?currentAccountPicture: Widget, ?otherAccountsPictures: Widget[], ?currentAccountPictureSize: Size, ?otherAccountsPicturesSize: Size, ?onDetailsPressed: (unit -> unit), ?arrowColor: Color) =
  inherit Widget()

[<AutoOpen>]
module Functions =

  [<ImportAll("package:flutter/material.dart")>]
  type Material =
    /// https://api.flutter.dev/flutter/material/showAboutDialog.html
    [<NamedParams>] static member showAboutDialog(context: BuildContext, ?applicationName: string, ?applicationVersion: string, ?applicationIcon: Widget, ?applicationLegalese: string, ?children: Widget[], ?useRootNavigator: bool, ?routeSettings: RouteSettings, ?anchorPoint: Offset): unit = nativeOnly
    /// https://api.flutter.dev/flutter/material/showLicensePage.html
    [<NamedParams>] static member showLicensePage(context: BuildContext, ?applicationName: string, ?applicationVersion: string, ?applicationIcon: Widget, ?applicationLegalese: string, ?useRootNavigator: bool): unit = nativeOnly
    /// https://api.flutter.dev/flutter/material/showModalBottomSheet.html
    [<NamedParams>] static member showModalBottomSheet<'T>(context: BuildContext, builder: (BuildContext -> Widget), ?backgroundColor: Color, ?elevation: float, ?shape: ShapeBorder, ?clipBehavior: Clip, ?constraints: BoxConstraints, ?barrierColor: Color, ?isScrollControlled: bool, ?useRootNavigator: bool, ?isDismissible: bool, ?enableDrag: bool, ?routeSettings: RouteSettings, ?transitionAnimationController: AnimationController, ?anchorPoint: Offset): Future<'T option> = nativeOnly
    /// https://api.flutter.dev/flutter/material/showBottomSheet.html
    [<NamedParams>] static member showBottomSheet<'T>(context: BuildContext, builder: (BuildContext -> Widget), ?backgroundColor: Color, ?elevation: float, ?shape: ShapeBorder, ?clipBehavior: Clip, ?constraints: BoxConstraints, ?enableDrag: bool, ?transitionAnimationController: AnimationController): PersistentBottomSheetController<'T> = nativeOnly
    /// https://api.flutter.dev/flutter/material/showDatePicker.html
    [<NamedParams>] static member showDatePicker(context: BuildContext, initialDate: DateTime, firstDate: DateTime, lastDate: DateTime, ?currentDate: DateTime, ?initialEntryMode: DatePickerEntryMode, ?selectableDayPredicate: (DateTime -> bool), ?helpText: string, ?cancelText: string, ?confirmText: string, ?locale: Locale, ?useRootNavigator: bool, ?routeSettings: RouteSettings, ?textDirection: TextDirection, ?builder: (BuildContext -> Widget option -> Widget), ?initialDatePickerMode: DatePickerMode, ?errorFormatText: string, ?errorInvalidText: string, ?fieldHintText: string, ?fieldLabelText: string, ?keyboardType: TextInputType, ?anchorPoint: Offset): Future<DateTime option> = nativeOnly
    /// https://api.flutter.dev/flutter/material/showDateRangePicker.html
    [<NamedParams>] static member showDateRangePicker(context: BuildContext, firstDate: DateTime, lastDate: DateTime, ?initialDateRange: DateTimeRange, ?currentDate: DateTime, ?initialEntryMode: DatePickerEntryMode, ?helpText: string, ?cancelText: string, ?confirmText: string, ?saveText: string, ?errorFormatText: string, ?errorInvalidText: string, ?errorInvalidRangeText: string, ?fieldStartHintText: string, ?fieldEndHintText: string, ?fieldStartLabelText: string, ?fieldEndLabelText: string, ?locale: Locale, ?useRootNavigator: bool, ?routeSettings: RouteSettings, ?textDirection: TextDirection, ?builder: (BuildContext -> Widget option -> Widget), ?anchorPoint: Offset): Future<DateTimeRange option> = nativeOnly
    /// https://api.flutter.dev/flutter/material/debugCheckHasMaterial.html
    static member debugCheckHasMaterial(context: BuildContext): bool = nativeOnly
    /// https://api.flutter.dev/flutter/material/debugCheckHasMaterialLocalizations.html
    static member debugCheckHasMaterialLocalizations(context: BuildContext): bool = nativeOnly
    /// https://api.flutter.dev/flutter/material/debugCheckHasScaffold.html
    static member debugCheckHasScaffold(context: BuildContext): bool = nativeOnly
    /// https://api.flutter.dev/flutter/material/debugCheckHasScaffoldMessenger.html
    static member debugCheckHasScaffoldMessenger(context: BuildContext): bool = nativeOnly
    /// https://api.flutter.dev/flutter/material/showDialog.html
    [<NamedParams>] static member showDialog<'T>(context: BuildContext, builder: (BuildContext -> Widget), ?barrierDismissible: bool, ?barrierColor: Color, ?barrierLabel: string, ?useSafeArea: bool, ?useRootNavigator: bool, ?routeSettings: RouteSettings, ?anchorPoint: Offset): Future<'T option> = nativeOnly
    /// https://api.flutter.dev/flutter/material/showMenu.html
    [<NamedParams>] static member showMenu<'T>(context: BuildContext, position: RelativeRect, items: PopupMenuEntry<'T>[], ?initialValue: 'T, ?elevation: float, ?semanticLabel: string, ?shape: ShapeBorder, ?color: Color, ?useRootNavigator: bool, ?constraints: BoxConstraints): Future<'T option> = nativeOnly
    /// https://api.flutter.dev/flutter/material/showSearch.html
    [<NamedParams>] static member showSearch<'T>(context: BuildContext, ``delegate``: SearchDelegate<'T>, ?query: string, ?useRootNavigator: bool): Future<'T option> = nativeOnly
    /// https://api.flutter.dev/flutter/material/hourFormat.html
    [<NamedParams>] static member hourFormat(``of``: TimeOfDayFormat): HourFormat = nativeOnly
    /// https://api.flutter.dev/flutter/material/showTimePicker.html
    [<NamedParams>] static member showTimePicker(context: BuildContext, initialTime: TimeOfDay, ?builder: (BuildContext -> Widget option -> Widget), ?useRootNavigator: bool, ?initialEntryMode: TimePickerEntryMode, ?cancelText: string, ?confirmText: string, ?helpText: string, ?errorInvalidText: string, ?hourLabelText: string, ?minuteLabelText: string, ?routeSettings: RouteSettings, ?onEntryModeChanged: (TimePickerEntryMode -> unit), ?anchorPoint: Offset): Future<TimeOfDay option> = nativeOnly
