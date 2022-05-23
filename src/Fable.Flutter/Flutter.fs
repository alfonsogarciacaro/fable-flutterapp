namespace Flutter

open Fable.Core
open Fable.Core.Dart

module rec Widgets =
  type Action = Action<obj>
  type Stream = Stream<obj>
  type Future = Future<obj>
  // type AsyncSnapshot = AsyncSnapshot<obj>
  // type Tween = Tween<obj>

  [<ImportMember("package:flutter/widgets.dart")>]
  type Key =
    interface end

  [<ImportMember("package:flutter/widgets.dart")>]
  type Intent () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type Action<'T> () =
    [<NamedParams>] static member overridable(defaultAction : Action, context : BuildContext) : Action<'T> = jsNative
(*
  [<ImportMember("package:flutter/widgets.dart")>]
  type ActionListener [<NamedParams>] (listener : ActionListenerCallback, action : Action, child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ContextAction<'T> () =
    inherit Action<'T>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type CallbackAction<'T> (onInvoke : OnInvokeCallback) =
    inherit Action<'T>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ActionDispatcher () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type Actions [<NamedParams>] (?dispatcher : ActionDispatcher, actions : Map, child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FocusableActionDetector [<NamedParams>] (?enabled : bool, ?focusNode : FocusNode, ?autofocus : bool, ?descendantsAreFocusable : bool, ?descendantsAreTraversable : bool, ?shortcuts : Map, ?actions : Map, ?onShowFocusHighlight : ValueChanged, ?onShowHoverHighlight : ValueChanged, ?onFocusChange : ValueChanged, ?mouseCursor : MouseCursor, child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DoNothingIntent () =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type DoNothingAndStopPropagationIntent () =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type DoNothingAction (?consumesKey : bool) =
    inherit Action<Intent>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ActivateIntent () =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ButtonActivateIntent () =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ActivateAction () =
    inherit Action<ActivateIntent>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type SelectIntent () =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type SelectAction () =
    inherit Action<SelectIntent>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type DismissIntent () =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type DismissAction () =
    inherit Action<DismissIntent>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type PrioritizedIntents (orderedIntents : List) =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type PrioritizedAction () =
    inherit Action<PrioritizedIntents>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedCrossFade [<NamedParams>] (firstChild : Widget, secondChild : Widget, ?firstCurve : Curve, ?secondCurve : Curve, ?sizeCurve : Curve, ?alignment : AlignmentGeometry, crossFadeState : CrossFadeState, duration : Duration, ?reverseDuration : Duration, ?layoutBuilder : AnimatedCrossFadeBuilder, ?excludeBottomFocus : bool, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedList [<NamedParams>] (itemBuilder : AnimatedListItemBuilder, ?initialItemCount : int, ?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?shrinkWrap : bool, ?padding : EdgeInsetsGeometry, ?clipBehavior : Clip, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedListState () =
    inherit State<AnimatedList>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverAnimatedList [<NamedParams>] (itemBuilder : AnimatedListItemBuilder, ?findChildIndexCallback : ChildIndexGetter, ?initialItemCount : int, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverAnimatedListState () =
    inherit State<SliverAnimatedList>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedSize [<NamedParams>] (?child : Widget, ?alignment : AlignmentGeometry, ?curve : Curve, duration : Duration, ?reverseDuration : Duration, ?vsync : TickerProvider, ?clipBehavior : Clip, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedSwitcher [<NamedParams>] (?child : Widget, duration : Duration, ?reverseDuration : Duration, ?switchInCurve : Curve, ?switchOutCurve : Curve, ?transitionBuilder : AnimatedSwitcherTransitionBuilder, ?layoutBuilder : AnimatedSwitcherLayoutBuilder, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnnotatedRegion<'T> [<NamedParams>] (child : Widget, value : T, ?sized : bool, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type WidgetsApp [<NamedParams>] (?navigatorKey : GlobalKey, ?onGenerateRoute : RouteFactory, ?onGenerateInitialRoutes : InitialRouteListFactory, ?onUnknownRoute : RouteFactory, ?navigatorObservers : List, ?initialRoute : string, ?pageRouteBuilder : PageRouteFactory, ?home : Widget, ?routes : Map, ?builder : TransitionBuilder, ?title : string, ?onGenerateTitle : GenerateAppTitle, ?textStyle : TextStyle, color : Color, ?locale : Locale, ?localizationsDelegates : Iterable, ?localeListResolutionCallback : LocaleListResolutionCallback, ?localeResolutionCallback : LocaleResolutionCallback, ?supportedLocales : Iterable, ?showPerformanceOverlay : bool, ?checkerboardRasterCacheImages : bool, ?checkerboardOffscreenLayers : bool, ?showSemanticsDebugger : bool, ?debugShowWidgetInspector : bool, ?debugShowCheckedModeBanner : bool, ?inspectorSelectButtonBuilder : InspectorSelectButtonBuilder, ?shortcuts : Map, ?actions : Map, ?restorationScopeId : string, ?useInheritedMediaQuery : bool, ?key : Key) =
    inherit StatefulWidget(jsNative)
    [<NamedParams>] static member router(?routeInformationProvider : RouteInformationProvider, routeInformationParser : RouteInformationParser, routerDelegate : RouterDelegate, ?backButtonDispatcher : BackButtonDispatcher, ?builder : TransitionBuilder, ?title : string, ?onGenerateTitle : GenerateAppTitle, ?textStyle : TextStyle, color : Color, ?locale : Locale, ?localizationsDelegates : Iterable, ?localeListResolutionCallback : LocaleListResolutionCallback, ?localeResolutionCallback : LocaleResolutionCallback, ?supportedLocales : Iterable, ?showPerformanceOverlay : bool, ?checkerboardRasterCacheImages : bool, ?checkerboardOffscreenLayers : bool, ?showSemanticsDebugger : bool, ?debugShowWidgetInspector : bool, ?debugShowCheckedModeBanner : bool, ?inspectorSelectButtonBuilder : InspectorSelectButtonBuilder, ?shortcuts : Map, ?actions : Map, ?restorationScopeId : string, ?useInheritedMediaQuery : bool) : WidgetsApp = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type StreamBuilderBase<'T, 'S> [<NamedParams>] (?stream : Stream, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AsyncSnapshot<'T> =
    static member nothing() : AsyncSnapshot<'T> = jsNative
    static member waiting() : AsyncSnapshot<'T> = jsNative
    static member withData(state : ConnectionState, data : T) : AsyncSnapshot<'T> = jsNative
    static member withError(state : ConnectionState, error : Object, ?stackTrace : StackTrace) : AsyncSnapshot<'T> = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type StreamBuilder<'T> [<NamedParams>] (?initialData : T, ?stream : Stream, builder : AsyncWidgetBuilder, ?key : Key) =
    inherit StreamBuilderBase<'T, AsyncSnapshot>(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FutureBuilder<'T> [<NamedParams>] (?future : Future, ?initialData : T, builder : AsyncWidgetBuilder, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RawAutocomplete<'T> [<NamedParams>] (optionsViewBuilder : AutocompleteOptionsViewBuilder, optionsBuilder : AutocompleteOptionsBuilder, ?displayStringForOption : AutocompleteOptionToString, ?fieldViewBuilder : AutocompleteFieldViewBuilder, ?focusNode : FocusNode, ?onSelected : AutocompleteOnSelected, ?textEditingController : TextEditingController, ?initialValue : TextEditingValue, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AutocompletePreviousOptionIntent () =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type AutocompleteNextOptionIntent () =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type AutocompleteHighlightedOption [<NamedParams>] (highlightIndexNotifier : ValueNotifier, child : Widget, ?key : Key) =
    inherit InheritedNotifier<ValueNotifier>(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AutofillGroup [<NamedParams>] (child : Widget, ?onDisposeAction : AutofillContextAction, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AutofillGroupState () =
    inherit State<AutofillGroup>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type AutomaticKeepAlive [<NamedParams>] (?child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type KeepAliveNotification (handle : Listenable) =
    inherit Notification()

  [<ImportMember("package:flutter/widgets.dart")>]
  type KeepAliveHandle () =
    inherit ChangeNotifier()

  [<ImportMember("package:flutter/widgets.dart")>]
  type BannerPainter [<NamedParams>] (message : string, textDirection : TextDirection, location : BannerLocation, layoutDirection : TextDirection, ?color : Color, ?textStyle : TextStyle) =
    inherit CustomPainter(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Banner [<NamedParams>] (?child : Widget, message : string, ?textDirection : TextDirection, location : BannerLocation, ?layoutDirection : TextDirection, ?color : Color, ?textStyle : TextStyle, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type CheckedModeBanner [<NamedParams>] (child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Directionality [<NamedParams>] (textDirection : TextDirection, child : Widget, ?key : Key) =
    inherit InheritedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Opacity [<NamedParams>] (opacity : double, ?alwaysIncludeSemantics : bool, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ShaderMask [<NamedParams>] (shaderCallback : ShaderCallback, ?blendMode : BlendMode, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type BackdropFilter [<NamedParams>] (filter : ImageFilter, ?child : Widget, ?blendMode : BlendMode, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type CustomPaint [<NamedParams>] (?painter : CustomPainter, ?foregroundPainter : CustomPainter, ?size : Size, ?isComplex : bool, ?willChange : bool, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ClipRect [<NamedParams>] (?clipper : CustomClipper, ?clipBehavior : Clip, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ClipRRect [<NamedParams>] (?borderRadius : BorderRadius, ?clipper : CustomClipper, ?clipBehavior : Clip, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ClipOval [<NamedParams>] (?clipper : CustomClipper, ?clipBehavior : Clip, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ClipPath [<NamedParams>] (?clipper : CustomClipper, ?clipBehavior : Clip, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PhysicalModel [<NamedParams>] (?shape : BoxShape, ?clipBehavior : Clip, ?borderRadius : BorderRadius, ?elevation : double, color : Color, ?shadowColor : Color, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PhysicalShape [<NamedParams>] (clipper : CustomClipper, ?clipBehavior : Clip, ?elevation : double, color : Color, ?shadowColor : Color, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Transform [<NamedParams>] (transform : Matrix4, ?origin : Offset, ?alignment : AlignmentGeometry, ?transformHitTests : bool, ?filterQuality : FilterQuality, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)
    [<NamedParams>] static member rotate(angle : double, ?origin : Offset, ?alignment : AlignmentGeometry, ?transformHitTests : bool, ?filterQuality : FilterQuality, ?child : Widget) : Transform = jsNat, ?key : Keyive
    [<NamedParams>] static member translate(offset : Offset, ?transformHitTests : bool, ?filterQuality : FilterQuality, ?child : Widget) : Transform = jsNat, ?key : Keyive
    [<NamedParams>] static member scale(?scale : double, ?scaleX : double, ?scaleY : double, ?origin : Offset, ?alignment : AlignmentGeometry, ?transformHitTests : bool, ?filterQuality : FilterQuality, ?child : Widget) : Transform = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type CompositedTransformTarget [<NamedParams>] (link : LayerLink, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type CompositedTransformFollower [<NamedParams>] (link : LayerLink, ?showWhenUnlinked : bool, ?offset : Offset, ?targetAnchor : Alignment, ?followerAnchor : Alignment, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FittedBox [<NamedParams>] (?fit : BoxFit, ?alignment : AlignmentGeometry, ?clipBehavior : Clip, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FractionalTranslation [<NamedParams>] (translation : Offset, ?transformHitTests : bool, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RotatedBox [<NamedParams>] (quarterTurns : int, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Padding [<NamedParams>] (padding : EdgeInsetsGeometry, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Align [<NamedParams>] (?alignment : AlignmentGeometry, ?widthFactor : double, ?heightFactor : double, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Center [<NamedParams>] (?widthFactor : double, ?heightFactor : double, ?child : Widget, ?key : Key) =
    inherit Align(jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type CustomSingleChildLayout [<NamedParams>] (delegate : SingleChildLayoutDelegate, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type LayoutId [<NamedParams>] (id : Object, child : Widget, ?key : Key) =
    inherit ParentDataWidget<MultiChildLayoutParentData>(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type CustomMultiChildLayout [<NamedParams>] (delegate : MultiChildLayoutDelegate, ?children : List, ?key : Key) =
    inherit MultiChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SizedBox [<NamedParams>] (?width : double, ?height : double, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)
    [<NamedParams>] static member expand(?child : Widget) : SizedBox = jsNat, ?key : Keyive
    [<NamedParams>] static member shrink(?child : Widget) : SizedBox = jsNat, ?key : Keyive
    [<NamedParams>] static member fromSize(?child : Widget, ?size : Size) : SizedBox = jsNat, ?key : Keyive
    [<NamedParams>] static member square(?child : Widget, ?dimension : double) : SizedBox = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type ConstrainedBox [<NamedParams>] (constraints : BoxConstraints, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ConstraintsTransformBox [<NamedParams>] (?child : Widget, ?textDirection : TextDirection, ?alignment : AlignmentGeometry, constraintsTransform : BoxConstraintsTransform, ?clipBehavior : Clip, ?debugTransformType : string, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type UnconstrainedBox [<NamedParams>] (?child : Widget, ?textDirection : TextDirection, ?alignment : AlignmentGeometry, ?constrainedAxis : Axis, ?clipBehavior : Clip, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FractionallySizedBox [<NamedParams>] (?alignment : AlignmentGeometry, ?widthFactor : double, ?heightFactor : double, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type LimitedBox [<NamedParams>] (?maxWidth : double, ?maxHeight : double, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type OverflowBox [<NamedParams>] (?alignment : AlignmentGeometry, ?minWidth : double, ?maxWidth : double, ?minHeight : double, ?maxHeight : double, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SizedOverflowBox [<NamedParams>] (size : Size, ?alignment : AlignmentGeometry, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Offstage [<NamedParams>] (?offstage : bool, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AspectRatio [<NamedParams>] (aspectRatio : double, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type IntrinsicWidth [<NamedParams>] (?stepWidth : double, ?stepHeight : double, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type IntrinsicHeight [<NamedParams>] (?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Baseline [<NamedParams>] (baseline : double, baselineType : TextBaseline, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverToBoxAdapter [<NamedParams>] (?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverPadding [<NamedParams>] (padding : EdgeInsetsGeometry, ?sliver : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ListBody [<NamedParams>] (?mainAxis : Axis, ?reverse : bool, ?children : List, ?key : Key) =
    inherit MultiChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Stack [<NamedParams>] (?alignment : AlignmentGeometry, ?textDirection : TextDirection, ?fit : StackFit, ?clipBehavior : Clip, ?children : List, ?key : Key) =
    inherit MultiChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type IndexedStack [<NamedParams>] (?alignment : AlignmentGeometry, ?textDirection : TextDirection, ?sizing : StackFit, ?index : int, ?children : List, ?key : Key) =
    inherit Stack(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Positioned [<NamedParams>] (?left : double, ?top : double, ?right : double, ?bottom : double, ?width : double, ?height : double, child : Widget, ?key : Key) =
    inherit ParentDataWidget<StackParentData>(jsNative, jsNative)
    [<NamedParams>] static member fromRect(rect : Rect, child : Widget) : Positioned = jsNat, ?key : Keyive
    [<NamedParams>] static member fromRelativeRect(rect : RelativeRect, child : Widget) : Positioned = jsNat, ?key : Keyive
    [<NamedParams>] static member fill(?left : double, ?top : double, ?right : double, ?bottom : double, child : Widget) : Positioned = jsNat, ?key : Keyive
    [<NamedParams>] static member directional(textDirection : TextDirection, ?start : double, ?top : double, ?``end`` : double, ?bottom : double, ?width : double, ?height : double, child : Widget) : Positioned = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type PositionedDirectional [<NamedParams>] (?start : double, ?top : double, ?``end`` : double, ?bottom : double, ?width : double, ?height : double, child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Flex [<NamedParams>] (direction : Axis, ?mainAxisAlignment : MainAxisAlignment, ?mainAxisSize : MainAxisSize, ?crossAxisAlignment : CrossAxisAlignment, ?textDirection : TextDirection, ?verticalDirection : VerticalDirection, ?textBaseline : TextBaseline, ?clipBehavior : Clip, ?children : List, ?key : Key) =
    inherit MultiChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Row [<NamedParams>] (?mainAxisAlignment : MainAxisAlignment, ?mainAxisSize : MainAxisSize, ?crossAxisAlignment : CrossAxisAlignment, ?textDirection : TextDirection, ?verticalDirection : VerticalDirection, ?textBaseline : TextBaseline, ?children : List, ?key : Key) =
    inherit Flex(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Column [<NamedParams>] (?mainAxisAlignment : MainAxisAlignment, ?mainAxisSize : MainAxisSize, ?crossAxisAlignment : CrossAxisAlignment, ?textDirection : TextDirection, ?verticalDirection : VerticalDirection, ?textBaseline : TextBaseline, ?children : List, ?key : Key) =
    inherit Flex(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Flexible [<NamedParams>] (?flex : int, ?fit : FlexFit, child : Widget, ?key : Key) =
    inherit ParentDataWidget<FlexParentData>(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Expanded [<NamedParams>] (?flex : int, child : Widget, ?key : Key) =
    inherit Flexible(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Wrap [<NamedParams>] (?direction : Axis, ?alignment : WrapAlignment, ?spacing : double, ?runAlignment : WrapAlignment, ?runSpacing : double, ?crossAxisAlignment : WrapCrossAlignment, ?textDirection : TextDirection, ?verticalDirection : VerticalDirection, ?clipBehavior : Clip, ?children : List, ?key : Key) =
    inherit MultiChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Flow [<NamedParams>] (delegate : FlowDelegate, ?children : List, ?clipBehavior : Clip, ?key : Key) =
    inherit MultiChildRenderObjectWidget(jsNative, jsNative)
    [<NamedParams>] static member unwrapped(delegate : FlowDelegate, ?children : List, ?clipBehavior : Clip) : Flow = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type RichText [<NamedParams>] (text : InlineSpan, ?textAlign : TextAlign, ?textDirection : TextDirection, ?softWrap : bool, ?overflow : TextOverflow, ?textScaleFactor : double, ?maxLines : int, ?locale : Locale, ?strutStyle : StrutStyle, ?textWidthBasis : TextWidthBasis, ?textHeightBehavior : TextHeightBehavior, ?key : Key) =
    inherit MultiChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RawImage [<NamedParams>] (?image : Image, ?debugImageLabel : string, ?width : double, ?height : double, ?scale : double, ?color : Color, ?opacity : Animation, ?colorBlendMode : BlendMode, ?fit : BoxFit, ?alignment : AlignmentGeometry, ?repeat : ImageRepeat, ?centerSlice : Rect, ?matchTextDirection : bool, ?invertColors : bool, ?filterQuality : FilterQuality, ?isAntiAlias : bool, ?key : Key) =
    inherit LeafRenderObjectWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DefaultAssetBundle [<NamedParams>] (bundle : AssetBundle, child : Widget, ?key : Key) =
    inherit InheritedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type WidgetToRenderBoxAdapter [<NamedParams>] (renderBox : RenderBox, ?onBuild : VoidCallback, ?onUnmount : VoidCallback) =
    inherit LeafRenderObjectWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Listener [<NamedParams>] (?onPointerDown : PointerDownEventListener, ?onPointerMove : PointerMoveEventListener, ?onPointerUp : PointerUpEventListener, ?onPointerHover : PointerHoverEventListener, ?onPointerCancel : PointerCancelEventListener, ?onPointerSignal : PointerSignalEventListener, ?behavior : HitTestBehavior, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type MouseRegion [<NamedParams>] (?onEnter : PointerEnterEventListener, ?onExit : PointerExitEventListener, ?onHover : PointerHoverEventListener, ?cursor : MouseCursor, ?opaque : bool, ?hitTestBehavior : HitTestBehavior, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RepaintBoundary [<NamedParams>] (?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)
    static member wrap(child : Widget, childIndex : int) : RepaintBoundary = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type IgnorePointer [<NamedParams>] (?ignoring : bool, ?ignoringSemantics : bool, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AbsorbPointer [<NamedParams>] (?absorbing : bool, ?child : Widget, ?ignoringSemantics : bool, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type MetaData [<NamedParams>] (?metaData : dynamic, ?behavior : HitTestBehavior, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Semantics [<NamedParams>] (?child : Widget, ?container : bool, ?explicitChildNodes : bool, ?excludeSemantics : bool, ?enabled : bool, ?checked : bool, ?selected : bool, ?toggled : bool, ?button : bool, ?slider : bool, ?keyboardKey : bool, ?link : bool, ?header : bool, ?textField : bool, ?readOnly : bool, ?focusable : bool, ?focused : bool, ?inMutuallyExclusiveGroup : bool, ?obscured : bool, ?multiline : bool, ?scopesRoute : bool, ?namesRoute : bool, ?hidden : bool, ?image : bool, ?liveRegion : bool, ?maxValueLength : int, ?currentValueLength : int, ?label : string, ?attributedLabel : AttributedString, ?value : string, ?attributedValue : AttributedString, ?increasedValue : string, ?attributedIncreasedValue : AttributedString, ?decreasedValue : string, ?attributedDecreasedValue : AttributedString, ?hint : string, ?attributedHint : AttributedString, ?onTapHint : string, ?onLongPressHint : string, ?textDirection : TextDirection, ?sortKey : SemanticsSortKey, ?tagForChildren : SemanticsTag, ?onTap : VoidCallback, ?onLongPress : VoidCallback, ?onScrollLeft : VoidCallback, ?onScrollRight : VoidCallback, ?onScrollUp : VoidCallback, ?onScrollDown : VoidCallback, ?onIncrease : VoidCallback, ?onDecrease : VoidCallback, ?onCopy : VoidCallback, ?onCut : VoidCallback, ?onPaste : VoidCallback, ?onDismiss : VoidCallback, ?onMoveCursorForwardByCharacter : MoveCursorHandler, ?onMoveCursorBackwardByCharacter : MoveCursorHandler, ?onSetSelection : SetSelectionHandler, ?onSetText : SetTextHandler, ?onDidGainAccessibilityFocus : VoidCallback, ?onDidLoseAccessibilityFocus : VoidCallback, ?customSemanticsActions : Map, ?key : Key) =
    inherit SingleChildRenderObjectWidget()
    [<NamedParams>] static member fromProperties(?child : Widget, ?container : bool, ?explicitChildNodes : bool, ?excludeSemantics : bool, properties : SemanticsProperties) : Semantics = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type MergeSemantics [<NamedParams>] (?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type BlockSemantics [<NamedParams>] (?blocking : bool, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ExcludeSemantics [<NamedParams>] (?excluding : bool, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type IndexedSemantics [<NamedParams>] (index : int, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type KeyedSubtree [<NamedParams>] (child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)
    static member wrap(child : Widget, childIndex : int) : KeyedSubtree = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type Builder [<NamedParams>] (builder : WidgetBuilder, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type StatefulBuilder [<NamedParams>] (builder : StatefulWidgetBuilder, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ColoredBox [<NamedParams>] (color : Color, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type WidgetsBindingObserver () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type RenderObjectToWidgetAdapter<'T> [<NamedParams>] (?child : Widget, container : RenderObjectWithChildMixin, ?debugShortDescription : string) =
    inherit RenderObjectWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RenderObjectToWidgetElement<'T> (widget : RenderObjectToWidgetAdapter) =
    inherit RootRenderObjectElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type WidgetsFlutterBinding () =
    inherit BindingBase()

  [<ImportMember("package:flutter/widgets.dart")>]
  type BottomNavigationBarItem [<NamedParams>] (icon : Widget, ?label : string, ?activeIcon : Widget, ?backgroundColor : Color, ?tooltip : string) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type ColorFiltered [<NamedParams>] (colorFilter : ColorFilter, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DecoratedBox [<NamedParams>] (decoration : Decoration, ?position : DecorationPosition, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Container [<NamedParams>] (?alignment : AlignmentGeometry, ?padding : EdgeInsetsGeometry, ?color : Color, ?decoration : Decoration, ?foregroundDecoration : Decoration, ?width : double, ?height : double, ?constraints : BoxConstraints, ?margin : EdgeInsetsGeometry, ?transform : Matrix4, ?transformAlignment : AlignmentGeometry, ?child : Widget, ?clipBehavior : Clip, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DefaultTextEditingShortcuts [<NamedParams>] (child : Widget, ?key : Key) =
    inherit Shortcuts(jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DesktopTextSelectionToolbarLayoutDelegate (anchor : Offset) =
    inherit SingleChildLayoutDelegate(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Dismissible [<NamedParams>] (key : Key, child : Widget, ?background : Widget, ?secondaryBackground : Widget, ?confirmDismiss : ConfirmDismissCallback, ?onResize : VoidCallback, ?onUpdate : DismissUpdateCallback, ?onDismissed : DismissDirectionCallback, ?direction : DismissDirection, ?resizeDuration : Duration, ?dismissThresholds : Map, ?movementDuration : Duration, ?crossAxisEndOffset : double, ?dragStartBehavior : DragStartBehavior, ?behavior : HitTestBehavior) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DismissUpdateDetails [<NamedParams>] (?direction : DismissDirection, ?reached : bool, ?previousReached : bool, ?progress : double) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type DisplayFeatureSubScreen [<NamedParams>] (?anchorPoint : Offset, child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DisposableBuildContext<'T> (_state : T) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type Draggable<'T> [<NamedParams>] (child : Widget, feedback : Widget, ?data : T, ?axis : Axis, ?childWhenDragging : Widget, ?feedbackOffset : Offset, ?dragAnchor : DragAnchor, ?dragAnchorStrategy : DragAnchorStrategy, ?affinity : Axis, ?maxSimultaneousDrags : int, ?onDragStarted : VoidCallback, ?onDragUpdate : DragUpdateCallback, ?onDraggableCanceled : DraggableCanceledCallback, ?onDragEnd : DragEndCallback, ?onDragCompleted : VoidCallback, ?ignoringFeedbackSemantics : bool, ?rootOverlay : bool, ?hitTestBehavior : HitTestBehavior, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type LongPressDraggable<'T> [<NamedParams>] (child : Widget, feedback : Widget, ?data : T, ?axis : Axis, ?childWhenDragging : Widget, ?feedbackOffset : Offset, ?dragAnchor : DragAnchor, ?dragAnchorStrategy : DragAnchorStrategy, ?maxSimultaneousDrags : int, ?onDragStarted : VoidCallback, ?onDragUpdate : DragUpdateCallback, ?onDraggableCanceled : DraggableCanceledCallback, ?onDragEnd : DragEndCallback, ?onDragCompleted : VoidCallback, ?hapticFeedbackOnStart : bool, ?ignoringFeedbackSemantics : bool, ?delay : Duration, ?key : Key) =
    inherit Draggable<'T>(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DraggableDetails [<NamedParams>] (?wasAccepted : bool, velocity : Velocity, offset : Offset) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type DragTargetDetails<'T> [<NamedParams>] (data : T, offset : Offset) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type DragTarget<'T> [<NamedParams>] (builder : DragTargetBuilder, ?onWillAccept : DragTargetWillAccept, ?onAccept : DragTargetAccept, ?onAcceptWithDetails : DragTargetAcceptWithDetails, ?onLeave : DragTargetLeave, ?onMove : DragTargetMove, ?hitTestBehavior : HitTestBehavior, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DraggableScrollableController () =
    inherit ChangeNotifier()

  [<ImportMember("package:flutter/widgets.dart")>]
  type DraggableScrollableSheet [<NamedParams>] (?initialChildSize : double, ?minChildSize : double, ?maxChildSize : double, ?expand : bool, ?snap : bool, ?snapSizes : List, ?controller : DraggableScrollableController, builder : ScrollableWidgetBuilder, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DraggableScrollableNotification [<NamedParams>] (extent : double, minExtent : double, maxExtent : double, initialExtent : double, context : BuildContext) =
    inherit Notification()

  [<ImportMember("package:flutter/widgets.dart")>]
  type DraggableScrollableActuator [<NamedParams>] (child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DualTransitionBuilder [<NamedParams>] (animation : Animation, forwardBuilder : AnimatedTransitionBuilder, reverseBuilder : AnimatedTransitionBuilder, ?child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type TextEditingController (?text : string) =
    inherit ValueNotifier<TextEditingValue>(jsNative)
    static member fromValue(value : TextEditingValue) : TextEditingController = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type ToolbarOptions [<NamedParams>] (?copy : bool, ?cut : bool, ?paste : bool, ?selectAll : bool) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type EditableText [<NamedParams>] (controller : TextEditingController, focusNode : FocusNode, ?readOnly : bool, ?obscuringCharacter : string, ?obscureText : bool, ?autocorrect : bool, ?smartDashesType : SmartDashesType, ?smartQuotesType : SmartQuotesType, ?enableSuggestions : bool, style : TextStyle, ?strutStyle : StrutStyle, cursorColor : Color, backgroundCursorColor : Color, ?textAlign : TextAlign, ?textDirection : TextDirection, ?locale : Locale, ?textScaleFactor : double, ?maxLines : int, ?minLines : int, ?expands : bool, ?forceLine : bool, ?textHeightBehavior : TextHeightBehavior, ?textWidthBasis : TextWidthBasis, ?autofocus : bool, ?showCursor : bool, ?showSelectionHandles : bool, ?selectionColor : Color, ?selectionControls : TextSelectionControls, ?keyboardType : TextInputType, ?textInputAction : TextInputAction, ?textCapitalization : TextCapitalization, ?onChanged : ValueChanged, ?onEditingComplete : VoidCallback, ?onSubmitted : ValueChanged, ?onAppPrivateCommand : AppPrivateCommandCallback, ?onSelectionChanged : SelectionChangedCallback, ?onSelectionHandleTapped : VoidCallback, ?inputFormatters : List, ?mouseCursor : MouseCursor, ?rendererIgnoresPointer : bool, ?cursorWidth : double, ?cursorHeight : double, ?cursorRadius : Radius, ?cursorOpacityAnimates : bool, ?cursorOffset : Offset, ?paintCursorAboveText : bool, ?selectionHeightStyle : BoxHeightStyle, ?selectionWidthStyle : BoxWidthStyle, ?scrollPadding : EdgeInsets, ?keyboardAppearance : Brightness, ?dragStartBehavior : DragStartBehavior, ?enableInteractiveSelection : bool, ?scrollController : ScrollController, ?scrollPhysics : ScrollPhysics, ?autocorrectionTextRectColor : Color, ?toolbarOptions : ToolbarOptions, ?autofillHints : Iterable, ?autofillClient : AutofillClient, ?clipBehavior : Clip, ?restorationId : string, ?scrollBehavior : ScrollBehavior, ?scribbleEnabled : bool, ?enableIMEPersonalizedLearning : bool, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type EditableTextState () =
    inherit State<EditableText>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type FadeInImage [<NamedParams>] (placeholder : ImageProvider, ?placeholderErrorBuilder : ImageErrorWidgetBuilder, image : ImageProvider, ?imageErrorBuilder : ImageErrorWidgetBuilder, ?excludeFromSemantics : bool, ?imageSemanticLabel : string, ?fadeOutDuration : Duration, ?fadeOutCurve : Curve, ?fadeInDuration : Duration, ?fadeInCurve : Curve, ?width : double, ?height : double, ?fit : BoxFit, ?placeholderFit : BoxFit, ?alignment : AlignmentGeometry, ?repeat : ImageRepeat, ?matchTextDirection : bool, ?key : Key) =
    inherit StatefulWidget(jsNative)
    [<NamedParams>] static member memoryNetwork(placeholder : Uint8List, ?placeholderErrorBuilder : ImageErrorWidgetBuilder, image : string, ?imageErrorBuilder : ImageErrorWidgetBuilder, ?placeholderScale : double, ?imageScale : double, ?excludeFromSemantics : bool, ?imageSemanticLabel : string, ?fadeOutDuration : Duration, ?fadeOutCurve : Curve, ?fadeInDuration : Duration, ?fadeInCurve : Curve, ?width : double, ?height : double, ?fit : BoxFit, ?placeholderFit : BoxFit, ?alignment : AlignmentGeometry, ?repeat : ImageRepeat, ?matchTextDirection : bool, ?placeholderCacheWidth : int, ?placeholderCacheHeight : int, ?imageCacheWidth : int, ?imageCacheHeight : int) : FadeInImage = jsNat, ?key : Keyive
    [<NamedParams>] static member assetNetwork(placeholder : string, ?placeholderErrorBuilder : ImageErrorWidgetBuilder, image : string, ?imageErrorBuilder : ImageErrorWidgetBuilder, ?bundle : AssetBundle, ?placeholderScale : double, ?imageScale : double, ?excludeFromSemantics : bool, ?imageSemanticLabel : string, ?fadeOutDuration : Duration, ?fadeOutCurve : Curve, ?fadeInDuration : Duration, ?fadeInCurve : Curve, ?width : double, ?height : double, ?fit : BoxFit, ?placeholderFit : BoxFit, ?alignment : AlignmentGeometry, ?repeat : ImageRepeat, ?matchTextDirection : bool, ?placeholderCacheWidth : int, ?placeholderCacheHeight : int, ?imageCacheWidth : int, ?imageCacheHeight : int) : FadeInImage = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type FocusAttachment =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type FocusNode [<NamedParams>] (?debugLabel : string, ?onKey : FocusOnKeyCallback, ?onKeyEvent : FocusOnKeyEventCallback, ?skipTraversal : bool, ?canRequestFocus : bool, ?descendantsAreFocusable : bool, ?descendantsAreTraversable : bool) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type FocusScopeNode [<NamedParams>] (?debugLabel : string, ?onKeyEvent : FocusOnKeyEventCallback, ?onKey : FocusOnKeyCallback, ?skipTraversal : bool, ?canRequestFocus : bool) =
    inherit FocusNode(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FocusManager () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type Focus [<NamedParams>] (child : Widget, ?focusNode : FocusNode, ?autofocus : bool, ?onFocusChange : ValueChanged, ?onKeyEvent : FocusOnKeyEventCallback, ?onKey : FocusOnKeyCallback, ?canRequestFocus : bool, ?skipTraversal : bool, ?descendantsAreFocusable : bool, ?descendantsAreTraversable : bool, ?includeSemantics : bool, ?debugLabel : string, ?key : Key) =
    inherit StatefulWidget(jsNative)
    [<NamedParams>] static member withExternalFocusNode(child : Widget, focusNode : FocusNode, ?autofocus : bool, ?onFocusChange : ValueChanged, ?includeSemantics : bool) : Focus = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type FocusScope [<NamedParams>] (?node : FocusScopeNode, child : Widget, ?autofocus : bool, ?onFocusChange : ValueChanged, ?canRequestFocus : bool, ?skipTraversal : bool, ?onKeyEvent : FocusOnKeyEventCallback, ?onKey : FocusOnKeyCallback, ?debugLabel : string, ?key : Key) =
    inherit Focus(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)
    [<NamedParams>] static member withExternalFocusNode(child : Widget, focusScopeNode : FocusScopeNode, ?autofocus : bool, ?onFocusChange : ValueChanged) : FocusScope = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type ExcludeFocus [<NamedParams>] (?excluding : bool, child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FocusTraversalPolicy () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type WidgetOrderTraversalPolicy () =
    inherit FocusTraversalPolicy()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ReadingOrderTraversalPolicy () =
    inherit FocusTraversalPolicy()

  [<ImportMember("package:flutter/widgets.dart")>]
  type FocusOrder () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type NumericFocusOrder (order : double) =
    inherit FocusOrder()

  [<ImportMember("package:flutter/widgets.dart")>]
  type LexicalFocusOrder (order : string) =
    inherit FocusOrder()

  [<ImportMember("package:flutter/widgets.dart")>]
  type OrderedTraversalPolicy (?secondary : FocusTraversalPolicy) =
    inherit FocusTraversalPolicy()

  [<ImportMember("package:flutter/widgets.dart")>]
  type FocusTraversalOrder [<NamedParams>] (order : FocusOrder, child : Widget, ?key : Key) =
    inherit InheritedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FocusTraversalGroup [<NamedParams>] (?policy : FocusTraversalPolicy, ?descendantsAreFocusable : bool, ?descendantsAreTraversable : bool, child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RequestFocusIntent (focusNode : FocusNode) =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type RequestFocusAction () =
    inherit Action<RequestFocusIntent>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type NextFocusIntent () =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type NextFocusAction () =
    inherit Action<NextFocusIntent>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type PreviousFocusIntent () =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type PreviousFocusAction () =
    inherit Action<PreviousFocusIntent>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type DirectionalFocusIntent (direction : TraversalDirection, ?ignoreTextFields : bool) =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type DirectionalFocusAction () =
    inherit Action<DirectionalFocusIntent>()
    static member forTextField() : DirectionalFocusAction = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type ExcludeFocusTraversal [<NamedParams>] (?excluding : bool, child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Form [<NamedParams>] (child : Widget, ?onWillPop : WillPopCallback, ?onChanged : VoidCallback, ?autovalidateMode : AutovalidateMode, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FormState () =
    inherit State<Form>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type FormField<'T> [<NamedParams>] (builder : FormFieldBuilder, ?onSaved : FormFieldSetter, ?validator : FormFieldValidator, ?initialValue : T, ?enabled : bool, ?autovalidateMode : AutovalidateMode, ?restorationId : string, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FormFieldState<'T> () =
    inherit State<FormField>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ObjectKey (value : Object) =
    inherit LocalKey()

  [<ImportMember("package:flutter/widgets.dart")>]
  type GlobalKey<'T> (?debugLabel : string) =
    inherit Key()
    static member constructor() : GlobalKey<'T> = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type LabeledGlobalKey<'T> (_debugLabel : string) =
    inherit GlobalKey<'T>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type GlobalObjectKey<'T> (value : Object) =
    inherit GlobalKey<'T>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type Widget (?key : Key) =
    inherit DiagnosticableTree()

  [<ImportMember("package:flutter/widgets.dart")>]
  type StatelessWidget (?key : Key) =
    inherit Widget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type StatefulWidget (?key : Key) =
    inherit Widget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type State<'T> () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type ProxyWidget [<NamedParams>] (child : Widget, ?key : Key) =
    inherit Widget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ParentDataWidget<'T> [<NamedParams>] (child : Widget, ?key : Key) =
    inherit ProxyWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type InheritedWidget [<NamedParams>] (child : Widget, ?key : Key) =
    inherit ProxyWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RenderObjectWidget (?key : Key) =
    inherit Widget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type LeafRenderObjectWidget (?key : Key) =
    inherit RenderObjectWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SingleChildRenderObjectWidget [<NamedParams>] (?child : Widget, ?key : Key) =
    inherit RenderObjectWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type MultiChildRenderObjectWidget [<NamedParams>] (?children : List, ?key : Key) =
    inherit RenderObjectWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type BuildContext () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type BuildOwner [<NamedParams>] (?onBuildScheduled : VoidCallback, ?focusManager : FocusManager) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type Element (widget : Widget) =
    inherit DiagnosticableTree()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ErrorWidget (error : Object) =
    inherit LeafRenderObjectWidget(jsNative)
    [<NamedParams>] static member withDetails(?message : string, ?error : FlutterError) : ErrorWidget = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type ComponentElement (widget : Widget) =
    inherit Element(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type StatelessElement (widget : StatelessWidget) =
    inherit ComponentElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type StatefulElement (widget : StatefulWidget) =
    inherit ComponentElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ProxyElement (widget : ProxyWidget) =
    inherit ComponentElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ParentDataElement<'T> (widget : ParentDataWidget) =
    inherit ProxyElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type InheritedElement (widget : InheritedWidget) =
    inherit ProxyElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RenderObjectElement (widget : RenderObjectWidget) =
    inherit Element(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RootRenderObjectElement (widget : RenderObjectWidget) =
    inherit RenderObjectElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type LeafRenderObjectElement (widget : LeafRenderObjectWidget) =
    inherit RenderObjectElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SingleChildRenderObjectElement (widget : SingleChildRenderObjectWidget) =
    inherit RenderObjectElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type MultiChildRenderObjectElement (widget : MultiChildRenderObjectWidget) =
    inherit RenderObjectElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DebugCreator (element : Element) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type IndexedSlot<'T> (index : int, value : T) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type GestureRecognizerFactory<'T> () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type GestureRecognizerFactoryWithHandlers<'T> (_constructor : GestureRecognizerFactoryConstructor, _initializer : GestureRecognizerFactoryInitializer) =
    inherit GestureRecognizerFactory<'T>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type GestureDetector [<NamedParams>] (?child : Widget, ?onTapDown : GestureTapDownCallback, ?onTapUp : GestureTapUpCallback, ?onTap : GestureTapCallback, ?onTapCancel : GestureTapCancelCallback, ?onSecondaryTap : GestureTapCallback, ?onSecondaryTapDown : GestureTapDownCallback, ?onSecondaryTapUp : GestureTapUpCallback, ?onSecondaryTapCancel : GestureTapCancelCallback, ?onTertiaryTapDown : GestureTapDownCallback, ?onTertiaryTapUp : GestureTapUpCallback, ?onTertiaryTapCancel : GestureTapCancelCallback, ?onDoubleTapDown : GestureTapDownCallback, ?onDoubleTap : GestureTapCallback, ?onDoubleTapCancel : GestureTapCancelCallback, ?onLongPressDown : GestureLongPressDownCallback, ?onLongPressCancel : GestureLongPressCancelCallback, ?onLongPress : GestureLongPressCallback, ?onLongPressStart : GestureLongPressStartCallback, ?onLongPressMoveUpdate : GestureLongPressMoveUpdateCallback, ?onLongPressUp : GestureLongPressUpCallback, ?onLongPressEnd : GestureLongPressEndCallback, ?onSecondaryLongPressDown : GestureLongPressDownCallback, ?onSecondaryLongPressCancel : GestureLongPressCancelCallback, ?onSecondaryLongPress : GestureLongPressCallback, ?onSecondaryLongPressStart : GestureLongPressStartCallback, ?onSecondaryLongPressMoveUpdate : GestureLongPressMoveUpdateCallback, ?onSecondaryLongPressUp : GestureLongPressUpCallback, ?onSecondaryLongPressEnd : GestureLongPressEndCallback, ?onTertiaryLongPressDown : GestureLongPressDownCallback, ?onTertiaryLongPressCancel : GestureLongPressCancelCallback, ?onTertiaryLongPress : GestureLongPressCallback, ?onTertiaryLongPressStart : GestureLongPressStartCallback, ?onTertiaryLongPressMoveUpdate : GestureLongPressMoveUpdateCallback, ?onTertiaryLongPressUp : GestureLongPressUpCallback, ?onTertiaryLongPressEnd : GestureLongPressEndCallback, ?onVerticalDragDown : GestureDragDownCallback, ?onVerticalDragStart : GestureDragStartCallback, ?onVerticalDragUpdate : GestureDragUpdateCallback, ?onVerticalDragEnd : GestureDragEndCallback, ?onVerticalDragCancel : GestureDragCancelCallback, ?onHorizontalDragDown : GestureDragDownCallback, ?onHorizontalDragStart : GestureDragStartCallback, ?onHorizontalDragUpdate : GestureDragUpdateCallback, ?onHorizontalDragEnd : GestureDragEndCallback, ?onHorizontalDragCancel : GestureDragCancelCallback, ?onForcePressStart : GestureForcePressStartCallback, ?onForcePressPeak : GestureForcePressPeakCallback, ?onForcePressUpdate : GestureForcePressUpdateCallback, ?onForcePressEnd : GestureForcePressEndCallback, ?onPanDown : GestureDragDownCallback, ?onPanStart : GestureDragStartCallback, ?onPanUpdate : GestureDragUpdateCallback, ?onPanEnd : GestureDragEndCallback, ?onPanCancel : GestureDragCancelCallback, ?onScaleStart : GestureScaleStartCallback, ?onScaleUpdate : GestureScaleUpdateCallback, ?onScaleEnd : GestureScaleEndCallback, ?behavior : HitTestBehavior, ?excludeFromSemantics : bool, ?dragStartBehavior : DragStartBehavior, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RawGestureDetector [<NamedParams>] (?child : Widget, ?gestures : Map, ?behavior : HitTestBehavior, ?excludeFromSemantics : bool, ?semantics : SemanticsGestureDelegate, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RawGestureDetectorState () =
    inherit State<RawGestureDetector>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type SemanticsGestureDelegate () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type GridPaper [<NamedParams>] (?color : Color, ?interval : double, ?divisions : int, ?subdivisions : int, ?child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Hero [<NamedParams>] (tag : Object, ?createRectTween : CreateRectTween, ?flightShuttleBuilder : HeroFlightShuttleBuilder, ?placeholderBuilder : HeroPlaceholderBuilder, ?transitionOnUserGestures : bool, child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type HeroController (?createRectTween : CreateRectTween) =
    inherit NavigatorObserver()

  [<ImportMember("package:flutter/widgets.dart")>]
  type HeroMode [<NamedParams>] (child : Widget, ?enabled : bool, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Icon [<NamedParams(fromIndex=1)>] (icon : IconData, ?size : double, ?color : Color, ?semanticLabel : string, ?textDirection : TextDirection, ?shadows : List, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type IconData [<NamedParams(fromIndex=1)>] (codePoint : int, ?fontFamily : string, ?fontPackage : string, ?matchTextDirection : bool) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type IconDataProperty [<NamedParams(fromIndex=2)>] (name : string, value : IconData, ?ifNull : string, ?showName : bool, ?style : DiagnosticsTreeStyle, ?level : DiagnosticLevel) =
    inherit DiagnosticsProperty<IconData>(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type IconTheme [<NamedParams>] (data : IconThemeData, child : Widget, ?key : Key) =
    inherit InheritedTheme(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type IconThemeData [<NamedParams>] (?color : Color, ?opacity : double, ?size : double, ?shadows : List) =
    static member fallback() : IconThemeData = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type Image [<NamedParams>] (image : ImageProvider, ?frameBuilder : ImageFrameBuilder, ?loadingBuilder : ImageLoadingBuilder, ?errorBuilder : ImageErrorWidgetBuilder, ?semanticLabel : string, ?excludeFromSemantics : bool, ?width : double, ?height : double, ?color : Color, ?opacity : Animation, ?colorBlendMode : BlendMode, ?fit : BoxFit, ?alignment : AlignmentGeometry, ?repeat : ImageRepeat, ?centerSlice : Rect, ?matchTextDirection : bool, ?gaplessPlayback : bool, ?isAntiAlias : bool, ?filterQuality : FilterQuality, ?key : Key) =
    inherit StatefulWidget(jsNative)
    [<NamedParams(fromIndex=1)>] static member network(src : string, ?scale : double, ?frameBuilder : ImageFrameBuilder, ?loadingBuilder : ImageLoadingBuilder, ?errorBuilder : ImageErrorWidgetBuilder, ?semanticLabel : string, ?excludeFromSemantics : bool, ?width : double, ?height : double, ?color : Color, ?opacity : Animation, ?colorBlendMode : BlendMode, ?fit : BoxFit, ?alignment : AlignmentGeometry, ?repeat : ImageRepeat, ?centerSlice : Rect, ?matchTextDirection : bool, ?gaplessPlayback : bool, ?filterQuality : FilterQuality, ?isAntiAlias : bool, ?headers : Map, ?cacheWidth : int, ?cacheHeight : int) : Image = jsNat, ?key : Keyive
    [<NamedParams(fromIndex=1)>] static member file(file : File, ?scale : double, ?frameBuilder : ImageFrameBuilder, ?errorBuilder : ImageErrorWidgetBuilder, ?semanticLabel : string, ?excludeFromSemantics : bool, ?width : double, ?height : double, ?color : Color, ?opacity : Animation, ?colorBlendMode : BlendMode, ?fit : BoxFit, ?alignment : AlignmentGeometry, ?repeat : ImageRepeat, ?centerSlice : Rect, ?matchTextDirection : bool, ?gaplessPlayback : bool, ?isAntiAlias : bool, ?filterQuality : FilterQuality, ?cacheWidth : int, ?cacheHeight : int) : Image = jsNat, ?key : Keyive
    [<NamedParams(fromIndex=1)>] static member asset(name : string, ?bundle : AssetBundle, ?frameBuilder : ImageFrameBuilder, ?errorBuilder : ImageErrorWidgetBuilder, ?semanticLabel : string, ?excludeFromSemantics : bool, ?scale : double, ?width : double, ?height : double, ?color : Color, ?opacity : Animation, ?colorBlendMode : BlendMode, ?fit : BoxFit, ?alignment : AlignmentGeometry, ?repeat : ImageRepeat, ?centerSlice : Rect, ?matchTextDirection : bool, ?gaplessPlayback : bool, ?isAntiAlias : bool, ?package : string, ?filterQuality : FilterQuality, ?cacheWidth : int, ?cacheHeight : int) : Image = jsNat, ?key : Keyive
    [<NamedParams(fromIndex=1)>] static member memory(bytes : Uint8List, ?scale : double, ?frameBuilder : ImageFrameBuilder, ?errorBuilder : ImageErrorWidgetBuilder, ?semanticLabel : string, ?excludeFromSemantics : bool, ?width : double, ?height : double, ?color : Color, ?opacity : Animation, ?colorBlendMode : BlendMode, ?fit : BoxFit, ?alignment : AlignmentGeometry, ?repeat : ImageRepeat, ?centerSlice : Rect, ?matchTextDirection : bool, ?gaplessPlayback : bool, ?isAntiAlias : bool, ?filterQuality : FilterQuality, ?cacheWidth : int, ?cacheHeight : int) : Image = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type ImageFiltered [<NamedParams>] (imageFilter : ImageFilter, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ImageIcon [<NamedParams(fromIndex=1)>] (image : ImageProvider, ?size : double, ?color : Color, ?semanticLabel : string, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Tween<'T> =
    interface end

  [<ImportMember("package:flutter/widgets.dart")>]
  type BoxConstraintsTween [<NamedParams>] (?``begin`` : BoxConstraints, ?``end`` : BoxConstraints) =
    interface Tween<BoxConstraints>

  [<ImportMember("package:flutter/widgets.dart")>]
  type DecorationTween [<NamedParams>] (?``begin`` : Decoration, ?``end`` : Decoration) =
    interface Tween<Decoration>

  [<ImportMember("package:flutter/widgets.dart")>]
  type EdgeInsetsTween [<NamedParams>] (?``begin`` : EdgeInsets, ?``end`` : EdgeInsets) =
    interface Tween<EdgeInsets>

  [<ImportMember("package:flutter/widgets.dart")>]
  type EdgeInsetsGeometryTween [<NamedParams>] (?``begin`` : EdgeInsetsGeometry, ?``end`` : EdgeInsetsGeometry) =
    interface Tween<EdgeInsetsGeometry>

  [<ImportMember("package:flutter/widgets.dart")>]
  type BorderRadiusTween [<NamedParams>] (?``begin`` : BorderRadius, ?``end`` : BorderRadius) =
    interface Tween<BorderRadius>

  [<ImportMember("package:flutter/widgets.dart")>]
  type BorderTween [<NamedParams>] (?``begin`` : Border, ?``end`` : Border) =
    interface Tween<Border>

  [<ImportMember("package:flutter/widgets.dart")>]
  type Matrix4Tween [<NamedParams>] (?``begin`` : Matrix4, ?``end`` : Matrix4) =
    interface Tween<Matrix4>

  [<ImportMember("package:flutter/widgets.dart")>]
  type TextStyleTween [<NamedParams>] (?``begin`` : TextStyle, ?``end`` : TextStyle) =
    interface Tween<TextStyle>

  [<ImportMember("package:flutter/widgets.dart")>]
  type ImplicitlyAnimatedWidget [<NamedParams>] (?curve : Curve, duration : Duration, ?onEnd : VoidCallback, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ImplicitlyAnimatedWidgetState<'T> () =
    inherit State<'T>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedWidgetBaseState<'T> () =
    inherit ImplicitlyAnimatedWidgetState<'T>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedContainer [<NamedParams>] (?alignment : AlignmentGeometry, ?padding : EdgeInsetsGeometry, ?color : Color, ?decoration : Decoration, ?foregroundDecoration : Decoration, ?width : double, ?height : double, ?constraints : BoxConstraints, ?margin : EdgeInsetsGeometry, ?transform : Matrix4, ?transformAlignment : AlignmentGeometry, ?child : Widget, ?clipBehavior : Clip, ?curve : Curve, duration : Duration, ?onEnd : VoidCallback, ?key : Key) =
    inherit ImplicitlyAnimatedWidget(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedPadding [<NamedParams>] (padding : EdgeInsetsGeometry, ?child : Widget, ?curve : Curve, duration : Duration, ?onEnd : VoidCallback, ?key : Key) =
    inherit ImplicitlyAnimatedWidget(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedAlign [<NamedParams>] (alignment : AlignmentGeometry, ?child : Widget, ?heightFactor : double, ?widthFactor : double, ?curve : Curve, duration : Duration, ?onEnd : VoidCallback, ?key : Key) =
    inherit ImplicitlyAnimatedWidget(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedPositioned [<NamedParams>] (child : Widget, ?left : double, ?top : double, ?right : double, ?bottom : double, ?width : double, ?height : double, ?curve : Curve, duration : Duration, ?onEnd : VoidCallback, ?key : Key) =
    inherit ImplicitlyAnimatedWidget(jsNative, jsNative, jsNative, jsNative)
    [<NamedParams>] static member fromRect(child : Widget, rect : Rect, ?curve : Curve, duration : Duration, ?onEnd : VoidCallback) : AnimatedPositioned = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedPositionedDirectional [<NamedParams>] (child : Widget, ?start : double, ?top : double, ?``end`` : double, ?bottom : double, ?width : double, ?height : double, ?curve : Curve, duration : Duration, ?onEnd : VoidCallback, ?key : Key) =
    inherit ImplicitlyAnimatedWidget(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedScale [<NamedParams>] (?child : Widget, scale : double, ?alignment : Alignment, ?filterQuality : FilterQuality, ?curve : Curve, duration : Duration, ?onEnd : VoidCallback, ?key : Key) =
    inherit ImplicitlyAnimatedWidget(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedRotation [<NamedParams>] (?child : Widget, turns : double, ?alignment : Alignment, ?filterQuality : FilterQuality, ?curve : Curve, duration : Duration, ?onEnd : VoidCallback, ?key : Key) =
    inherit ImplicitlyAnimatedWidget(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedSlide [<NamedParams>] (?child : Widget, offset : Offset, ?curve : Curve, duration : Duration, ?onEnd : VoidCallback, ?key : Key) =
    inherit ImplicitlyAnimatedWidget(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedOpacity [<NamedParams>] (?child : Widget, opacity : double, ?curve : Curve, duration : Duration, ?onEnd : VoidCallback, ?alwaysIncludeSemantics : bool, ?key : Key) =
    inherit ImplicitlyAnimatedWidget(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverAnimatedOpacity [<NamedParams>] (?sliver : Widget, opacity : double, ?curve : Curve, duration : Duration, ?onEnd : VoidCallback, ?alwaysIncludeSemantics : bool, ?key : Key) =
    inherit ImplicitlyAnimatedWidget(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedDefaultTextStyle [<NamedParams>] (child : Widget, style : TextStyle, ?textAlign : TextAlign, ?softWrap : bool, ?overflow : TextOverflow, ?maxLines : int, ?textWidthBasis : TextWidthBasis, ?textHeightBehavior : TextHeightBehavior, ?curve : Curve, duration : Duration, ?onEnd : VoidCallback, ?key : Key) =
    inherit ImplicitlyAnimatedWidget(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedPhysicalModel [<NamedParams>] (child : Widget, shape : BoxShape, ?clipBehavior : Clip, ?borderRadius : BorderRadius, elevation : double, color : Color, ?animateColor : bool, shadowColor : Color, ?animateShadowColor : bool, ?curve : Curve, duration : Duration, ?onEnd : VoidCallback, ?key : Key) =
    inherit ImplicitlyAnimatedWidget(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type InheritedModel<'T> [<NamedParams>] (child : Widget, ?key : Key) =
    inherit InheritedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type InheritedModelElement<'T> (widget : InheritedModel) =
    inherit InheritedElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type InheritedNotifier<'T> [<NamedParams>] (?notifier : T, child : Widget, ?key : Key) =
    inherit InheritedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type InheritedTheme [<NamedParams>] (child : Widget, ?key : Key) =
    inherit InheritedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type CapturedThemes =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type InteractiveViewer [<NamedParams>] (?clipBehavior : Clip, ?alignPanAxis : bool, ?boundaryMargin : EdgeInsets, ?constrained : bool, ?maxScale : double, ?minScale : double, ?onInteractionEnd : GestureScaleEndCallback, ?onInteractionStart : GestureScaleStartCallback, ?onInteractionUpdate : GestureScaleUpdateCallback, ?panEnabled : bool, ?scaleEnabled : bool, ?scaleFactor : double, ?transformationController : TransformationController, child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)
    [<NamedParams>] static member builder(?clipBehavior : Clip, ?alignPanAxis : bool, ?boundaryMargin : EdgeInsets, ?maxScale : double, ?minScale : double, ?onInteractionEnd : GestureScaleEndCallback, ?onInteractionStart : GestureScaleStartCallback, ?onInteractionUpdate : GestureScaleUpdateCallback, ?panEnabled : bool, ?scaleEnabled : bool, ?scaleFactor : double, ?transformationController : TransformationController, builder : InteractiveViewerWidgetBuilder) : InteractiveViewer = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type TransformationController (?value : Matrix4) =
    inherit ValueNotifier<Matrix4>(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type KeyboardListener [<NamedParams>] (focusNode : FocusNode, ?autofocus : bool, ?includeSemantics : bool, ?onKeyEvent : ValueChanged, child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ConstrainedLayoutBuilder<'ConstraintType> [<NamedParams>] (builder : Widget Function(BuildContext, ConstraintType), ?key : Key) =
    inherit RenderObjectWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type LayoutBuilder [<NamedParams>] (builder : LayoutWidgetBuilder, ?key : Key) =
    inherit ConstrainedLayoutBuilder<BoxConstraints>(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ListWheelChildDelegate () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type ListWheelChildListDelegate (children : List) =
    inherit ListWheelChildDelegate()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ListWheelChildLoopingListDelegate (children : List) =
    inherit ListWheelChildDelegate()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ListWheelChildBuilderDelegate [<NamedParams>] (builder : NullableIndexedWidgetBuilder, ?childCount : int) =
    inherit ListWheelChildDelegate()

  [<ImportMember("package:flutter/widgets.dart")>]
  type FixedExtentScrollController (?initialItem : int) =
    inherit ScrollController(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FixedExtentMetrics [<NamedParams>] (minScrollExtent : double, maxScrollExtent : double, pixels : double, viewportDimension : double, axisDirection : AxisDirection, itemIndex : int) =
    inherit FixedScrollMetrics(jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FixedExtentScrollPhysics (?parent : ScrollPhysics) =
    inherit ScrollPhysics(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ListWheelScrollView [<NamedParams>] (?controller : ScrollController, ?physics : ScrollPhysics, ?diameterRatio : double, ?perspective : double, ?offAxisFraction : double, ?useMagnifier : bool, ?magnification : double, ?overAndUnderCenterOpacity : double, itemExtent : double, ?squeeze : double, ?onSelectedItemChanged : ValueChanged, ?renderChildrenOutsideViewport : bool, ?clipBehavior : Clip, ?restorationId : string, ?scrollBehavior : ScrollBehavior, children : List, ?key : Key) =
    inherit StatefulWidget(jsNative)
    [<NamedParams>] static member useDelegate(?controller : ScrollController, ?physics : ScrollPhysics, ?diameterRatio : double, ?perspective : double, ?offAxisFraction : double, ?useMagnifier : bool, ?magnification : double, ?overAndUnderCenterOpacity : double, itemExtent : double, ?squeeze : double, ?onSelectedItemChanged : ValueChanged, ?renderChildrenOutsideViewport : bool, ?clipBehavior : Clip, ?restorationId : string, ?scrollBehavior : ScrollBehavior, childDelegate : ListWheelChildDelegate) : ListWheelScrollView = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type ListWheelElement (widget : ListWheelViewport) =
    inherit RenderObjectElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ListWheelViewport [<NamedParams>] (?diameterRatio : double, ?perspective : double, ?offAxisFraction : double, ?useMagnifier : bool, ?magnification : double, ?overAndUnderCenterOpacity : double, itemExtent : double, ?squeeze : double, ?renderChildrenOutsideViewport : bool, offset : ViewportOffset, childDelegate : ListWheelChildDelegate, ?clipBehavior : Clip, ?key : Key) =
    inherit RenderObjectWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type LocalizationsDelegate<'T> () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type WidgetsLocalizations () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type DefaultWidgetsLocalizations () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type Localizations [<NamedParams>] (locale : Locale, delegates : List, ?child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)
    [<NamedParams>] static member override(context : BuildContext, ?locale : Locale, ?delegates : List, ?child : Widget) : Localizations = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type MediaQueryData [<NamedParams>] (?size : Size, ?devicePixelRatio : double, ?textScaleFactor : double, ?platformBrightness : Brightness, ?padding : EdgeInsets, ?viewInsets : EdgeInsets, ?systemGestureInsets : EdgeInsets, ?viewPadding : EdgeInsets, ?alwaysUse24HourFormat : bool, ?accessibleNavigation : bool, ?invertColors : bool, ?highContrast : bool, ?disableAnimations : bool, ?boldText : bool, ?navigationMode : NavigationMode, ?gestureSettings : DeviceGestureSettings, ?displayFeatures : List) =
    static member fromWindow(window : FlutterView) : MediaQueryData = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type MediaQuery [<NamedParams>] (data : MediaQueryData, child : Widget, ?key : Key) =
    inherit InheritedWidget(jsNative, jsNative)
    [<NamedParams>] static member removePadding(context : BuildContext, ?removeLeft : bool, ?removeTop : bool, ?removeRight : bool, ?removeBottom : bool, child : Widget) : MediaQuery = jsNat, ?key : Keyive
    [<NamedParams>] static member removeViewInsets(context : BuildContext, ?removeLeft : bool, ?removeTop : bool, ?removeRight : bool, ?removeBottom : bool, child : Widget) : MediaQuery = jsNat, ?key : Keyive
    [<NamedParams>] static member removeViewPadding(context : BuildContext, ?removeLeft : bool, ?removeTop : bool, ?removeRight : bool, ?removeBottom : bool, child : Widget) : MediaQuery = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type ModalBarrier [<NamedParams>] (?color : Color, ?dismissible : bool, ?onDismiss : VoidCallback, ?semanticsLabel : string, ?barrierSemanticsDismissible : bool, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedModalBarrier [<NamedParams>] (color : Animation, ?dismissible : bool, ?semanticsLabel : string, ?barrierSemanticsDismissible : bool, ?key : Key) =
    inherit AnimatedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type NavigationToolbar [<NamedParams>] (?leading : Widget, ?middle : Widget, ?trailing : Widget, ?centerMiddle : bool, ?middleSpacing : double, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Route<'T> (?settings : RouteSettings) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type RouteSettings [<NamedParams>] (?name : string, ?arguments : Object) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type Page<'T> [<NamedParams>] (?key : LocalKey, ?name : string, ?arguments : Object, ?restorationId : string) =
    inherit RouteSettings(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type NavigatorObserver () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type HeroControllerScope [<NamedParams>] (controller : HeroController, child : Widget, ?key : Key) =
    inherit InheritedWidget(jsNative, jsNative)
    [<NamedParams>] static member none(child : Widget) : HeroControllerScope = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type RouteTransitionRecord () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type TransitionDelegate<'T> () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type DefaultTransitionDelegate<'T> () =
    inherit TransitionDelegate<'T>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type Navigator [<NamedParams>] (?pages : List, ?onPopPage : PopPageCallback, ?initialRoute : string, ?onGenerateInitialRoutes : RouteListFactory, ?onGenerateRoute : RouteFactory, ?onUnknownRoute : RouteFactory, ?transitionDelegate : TransitionDelegate, ?reportsRouteUpdateToEngine : bool, ?observers : List, ?requestFocus : bool, ?restorationScopeId : string, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type NavigatorState () =
    inherit State<Navigator>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableRouteFuture<'T> [<NamedParams>] (?navigatorFinder : NavigatorFinderCallback, onPresent : RoutePresentationCallback, ?onComplete : RouteCompletionCallback) =
    inherit RestorableProperty<string>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type NestedScrollView [<NamedParams>] (?controller : ScrollController, ?scrollDirection : Axis, ?reverse : bool, ?physics : ScrollPhysics, headerSliverBuilder : NestedScrollViewHeaderSliversBuilder, body : Widget, ?dragStartBehavior : DragStartBehavior, ?floatHeaderSlivers : bool, ?clipBehavior : Clip, ?restorationId : string, ?scrollBehavior : ScrollBehavior, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type NestedScrollViewState () =
    inherit State<NestedScrollView>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverOverlapAbsorberHandle () =
    inherit ChangeNotifier()

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverOverlapAbsorber [<NamedParams>] (handle : SliverOverlapAbsorberHandle, ?sliver : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RenderSliverOverlapAbsorber [<NamedParams>] (handle : SliverOverlapAbsorberHandle, ?sliver : RenderSliver) =
    inherit RenderSliver()

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverOverlapInjector [<NamedParams>] (handle : SliverOverlapAbsorberHandle, ?sliver : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RenderSliverOverlapInjector (handle : SliverOverlapAbsorberHandle) =
    inherit RenderSliver()

  [<ImportMember("package:flutter/widgets.dart")>]
  type NestedScrollViewViewport [<NamedParams>] (?axisDirection : AxisDirection, ?crossAxisDirection : AxisDirection, ?anchor : double, offset : ViewportOffset, ?center : Key, ?slivers : List, handle : SliverOverlapAbsorberHandle, ?clipBehavior : Clip, ?key : Key) =
    inherit Viewport(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RenderNestedScrollViewViewport [<NamedParams>] (?axisDirection : AxisDirection, crossAxisDirection : AxisDirection, offset : ViewportOffset, ?anchor : double, ?children : List, ?center : RenderSliver, handle : SliverOverlapAbsorberHandle, ?clipBehavior : Clip) =
    inherit RenderViewport(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Notification () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type NotificationListener<'T> [<NamedParams>] (child : Widget, ?onNotification : NotificationListenerCallback, ?key : Key) =
    inherit ProxyWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type LayoutChangedNotification () =
    inherit Notification()

  [<ImportMember("package:flutter/widgets.dart")>]
  type OrientationBuilder [<NamedParams>] (builder : OrientationWidgetBuilder, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type OverflowBar [<NamedParams>] (?spacing : double, ?alignment : MainAxisAlignment, ?overflowSpacing : double, ?overflowAlignment : OverflowBarAlignment, ?overflowDirection : VerticalDirection, ?textDirection : TextDirection, ?clipBehavior : Clip, ?children : List, ?key : Key) =
    inherit MultiChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type OverlayEntry [<NamedParams>] (builder : WidgetBuilder, ?opaque : bool, ?maintainState : bool) =
    inherit ChangeNotifier()

  [<ImportMember("package:flutter/widgets.dart")>]
  type Overlay [<NamedParams>] (?initialEntries : List, ?clipBehavior : Clip, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type OverlayState () =
    inherit State<Overlay>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type GlowingOverscrollIndicator [<NamedParams>] (?showLeading : bool, ?showTrailing : bool, axisDirection : AxisDirection, color : Color, ?notificationPredicate : ScrollNotificationPredicate, ?child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type StretchingOverscrollIndicator [<NamedParams>] (axisDirection : AxisDirection, ?notificationPredicate : ScrollNotificationPredicate, ?child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type OverscrollIndicatorNotification (leading : bool) =
    inherit Notification()

  [<ImportMember("package:flutter/widgets.dart")>]
  type PageStorageKey<'T> (value : T) =
    inherit ValueKey<'T>(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PageStorageBucket () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type PageStorage [<NamedParams>] (bucket : PageStorageBucket, child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PageController [<NamedParams>] (?initialPage : int, ?keepPage : bool, ?viewportFraction : double) =
    inherit ScrollController(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PageMetrics [<NamedParams>] (minScrollExtent : double, maxScrollExtent : double, pixels : double, viewportDimension : double, axisDirection : AxisDirection, viewportFraction : double) =
    inherit FixedScrollMetrics(jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PageScrollPhysics (?parent : ScrollPhysics) =
    inherit ScrollPhysics(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PageView [<NamedParams>] (?scrollDirection : Axis, ?reverse : bool, ?controller : PageController, ?physics : ScrollPhysics, ?pageSnapping : bool, ?onPageChanged : ValueChanged, ?children : List, ?dragStartBehavior : DragStartBehavior, ?allowImplicitScrolling : bool, ?restorationId : string, ?clipBehavior : Clip, ?scrollBehavior : ScrollBehavior, ?padEnds : bool, ?key : Key) =
    inherit StatefulWidget(jsNative)
    [<NamedParams>] static member builder(?scrollDirection : Axis, ?reverse : bool, ?controller : PageController, ?physics : ScrollPhysics, ?pageSnapping : bool, ?onPageChanged : ValueChanged, itemBuilder : IndexedWidgetBuilder, ?findChildIndexCallback : ChildIndexGetter, ?itemCount : int, ?dragStartBehavior : DragStartBehavior, ?allowImplicitScrolling : bool, ?restorationId : string, ?clipBehavior : Clip, ?scrollBehavior : ScrollBehavior, ?padEnds : bool) : PageView = jsNat, ?key : Keyive
    [<NamedParams>] static member custom(?scrollDirection : Axis, ?reverse : bool, ?controller : PageController, ?physics : ScrollPhysics, ?pageSnapping : bool, ?onPageChanged : ValueChanged, childrenDelegate : SliverChildDelegate, ?dragStartBehavior : DragStartBehavior, ?allowImplicitScrolling : bool, ?restorationId : string, ?clipBehavior : Clip, ?scrollBehavior : ScrollBehavior, ?padEnds : bool) : PageView = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type PageRoute<'T> [<NamedParams>] (?settings : RouteSettings, ?fullscreenDialog : bool) =
    inherit ModalRoute<'T>(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PageRouteBuilder<'T> [<NamedParams>] (?settings : RouteSettings, pageBuilder : RoutePageBuilder, ?transitionsBuilder : RouteTransitionsBuilder, ?transitionDuration : Duration, ?reverseTransitionDuration : Duration, ?opaque : bool, ?barrierDismissible : bool, ?barrierColor : Color, ?barrierLabel : string, ?maintainState : bool, ?fullscreenDialog : bool) =
    inherit PageRoute<'T>(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PerformanceOverlay [<NamedParams>] (?optionsMask : int, ?rasterizerThreshold : int, ?checkerboardRasterCacheImages : bool, ?checkerboardOffscreenLayers : bool, ?key : Key) =
    inherit LeafRenderObjectWidget(jsNative)
    [<NamedParams>] static member allEnabled(?rasterizerThreshold : int, ?checkerboardRasterCacheImages : bool, ?checkerboardOffscreenLayers : bool) : PerformanceOverlay = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type Placeholder [<NamedParams>] (?color : Color, ?strokeWidth : double, ?fallbackWidth : double, ?fallbackHeight : double, ?child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ShortcutSerialization =
    static member character(character : string) : ShortcutSerialization = jsNative
    [<NamedParams(fromIndex=1)>] static member modifier(trigger : LogicalKeyboardKey, ?control : bool, ?shift : bool, ?alt : bool, ?meta : bool) : ShortcutSerialization = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type MenuItem () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type PlatformMenuDelegate () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type DefaultPlatformMenuDelegate (?channel : MethodChannel) =
    inherit PlatformMenuDelegate()

  [<ImportMember("package:flutter/widgets.dart")>]
  type PlatformMenuBar [<NamedParams>] (body : Widget, menus : List, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PlatformMenu [<NamedParams>] (label : string, ?onOpen : VoidCallback, ?onClose : VoidCallback, menus : List) =
    inherit MenuItem()

  [<ImportMember("package:flutter/widgets.dart")>]
  type PlatformMenuItemGroup (members : List) =
    inherit MenuItem()

  [<ImportMember("package:flutter/widgets.dart")>]
  type PlatformMenuItem [<NamedParams>] (label : string, ?shortcut : MenuSerializableShortcut, ?onSelected : VoidCallback) =
    inherit MenuItem()

  [<ImportMember("package:flutter/widgets.dart")>]
  type PlatformProvidedMenuItem [<NamedParams>] (type : PlatformProvidedMenuItemType, ?enabled : bool) =
    inherit PlatformMenuItem(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AndroidView [<NamedParams>] (viewType : string, ?onPlatformViewCreated : PlatformViewCreatedCallback, ?hitTestBehavior : PlatformViewHitTestBehavior, ?layoutDirection : TextDirection, ?gestureRecognizers : Set, ?creationParams : dynamic, ?creationParamsCodec : MessageCodec, ?clipBehavior : Clip, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type UiKitView [<NamedParams>] (viewType : string, ?onPlatformViewCreated : PlatformViewCreatedCallback, ?hitTestBehavior : PlatformViewHitTestBehavior, ?layoutDirection : TextDirection, ?creationParams : dynamic, ?creationParamsCodec : MessageCodec, ?gestureRecognizers : Set, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type HtmlElementView [<NamedParams>] (viewType : string, ?onPlatformViewCreated : PlatformViewCreatedCallback, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PlatformViewCreationParams =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type PlatformViewLink [<NamedParams>] (surfaceFactory : PlatformViewSurfaceFactory, onCreatePlatformView : CreatePlatformViewCallback, viewType : string, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PlatformViewSurface [<NamedParams>] (controller : PlatformViewController, hitTestBehavior : PlatformViewHitTestBehavior, gestureRecognizers : Set, ?key : Key) =
    inherit LeafRenderObjectWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AndroidViewSurface [<NamedParams>] (controller : AndroidViewController, hitTestBehavior : PlatformViewHitTestBehavior, gestureRecognizers : Set, ?key : Key) =
    inherit PlatformViewSurface(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PreferredSizeWidget () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type PreferredSize [<NamedParams>] (child : Widget, preferredSize : Size, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PrimaryScrollController [<NamedParams>] (controller : ScrollController, child : Widget, ?key : Key) =
    inherit InheritedWidget(jsNative, jsNative)
    [<NamedParams>] static member none(child : Widget) : PrimaryScrollController = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type RawKeyboardListener [<NamedParams>] (focusNode : FocusNode, ?autofocus : bool, ?includeSemantics : bool, ?onKey : ValueChanged, child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ReorderableList [<NamedParams>] (itemBuilder : IndexedWidgetBuilder, itemCount : int, onReorder : ReorderCallback, ?onReorderStart : void Function(int)?, ?onReorderEnd : void Function(int)?, ?itemExtent : double, ?prototypeItem : Widget, ?proxyDecorator : ReorderItemProxyDecorator, ?padding : EdgeInsetsGeometry, ?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?shrinkWrap : bool, ?anchor : double, ?cacheExtent : double, ?dragStartBehavior : DragStartBehavior, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?restorationId : string, ?clipBehavior : Clip, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ReorderableListState () =
    inherit State<ReorderableList>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverReorderableList [<NamedParams>] (itemBuilder : IndexedWidgetBuilder, ?findChildIndexCallback : ChildIndexGetter, itemCount : int, onReorder : ReorderCallback, ?onReorderStart : void Function(int)?, ?onReorderEnd : void Function(int)?, ?itemExtent : double, ?prototypeItem : Widget, ?proxyDecorator : ReorderItemProxyDecorator, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverReorderableListState () =
    inherit State<SliverReorderableList>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ReorderableDragStartListener [<NamedParams>] (child : Widget, index : int, ?enabled : bool, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ReorderableDelayedDragStartListener [<NamedParams>] (child : Widget, index : int, ?enabled : bool, ?key : Key) =
    inherit ReorderableDragStartListener(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorationScope [<NamedParams>] (restorationId : string, child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type UnmanagedRestorationScope [<NamedParams>] (?bucket : RestorationBucket, child : Widget, ?key : Key) =
    inherit InheritedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RootRestorationScope [<NamedParams>] (restorationId : string, child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableProperty<'T> () =
    inherit ChangeNotifier()

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableValue<'T> () =
    inherit RestorableProperty<'T>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableNum<'T> (defaultValue : T) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableDouble (defaultValue : double) =
    inherit RestorableNum<double>(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableInt (defaultValue : int) =
    inherit RestorableNum<int>(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableString (defaultValue : string) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableBool (defaultValue : bool) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableBoolN (defaultValue : bool) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableNumN<'T> (defaultValue : T) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableDoubleN (defaultValue : double) =
    inherit RestorableNumN<double>(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableIntN (defaultValue : int) =
    inherit RestorableNumN<int>(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableStringN (defaultValue : string) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableDateTime (defaultValue : DateTime) =
    inherit RestorableValue<DateTime>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableDateTimeN (defaultValue : DateTime) =
    inherit RestorableValue<DateTime>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableListenable<'T> () =
    inherit RestorableProperty<'T>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableChangeNotifier<'T> () =
    inherit RestorableListenable<'T>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type RestorableTextEditingController (?text : string) =
    inherit RestorableChangeNotifier<TextEditingController>()
    static member fromValue(value : TextEditingValue) : RestorableTextEditingController = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type RouteInformation [<NamedParams>] (?location : string, ?state : Object) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type Router<'T> [<NamedParams>] (?routeInformationProvider : RouteInformationProvider, ?routeInformationParser : RouteInformationParser, routerDelegate : RouterDelegate, ?backButtonDispatcher : BackButtonDispatcher, ?restorationScopeId : string, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type BackButtonDispatcher () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type RootBackButtonDispatcher () =
    inherit BackButtonDispatcher()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ChildBackButtonDispatcher (parent : BackButtonDispatcher) =
    inherit BackButtonDispatcher()

  [<ImportMember("package:flutter/widgets.dart")>]
  type BackButtonListener [<NamedParams>] (child : Widget, onBackButtonPressed : ValueGetter, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RouteInformationParser<'T> () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type RouterDelegate<'T> () =
    inherit Listenable()

  [<ImportMember("package:flutter/widgets.dart")>]
  type RouteInformationProvider () =
    inherit ValueListenable<RouteInformation>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type PlatformRouteInformationProvider (initialRouteInformation : RouteInformation) =
    inherit RouteInformationProvider()

  [<ImportMember("package:flutter/widgets.dart")>]
  type OverlayRoute<'T> (?settings : RouteSettings) =
    inherit Route<'T>(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type TransitionRoute<'T> (?settings : RouteSettings) =
    inherit OverlayRoute<'T>(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type LocalHistoryEntry (?onRemove : VoidCallback) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type ModalRoute<'T> [<NamedParams>] (?settings : RouteSettings, ?filter : ImageFilter) =
    inherit TransitionRoute<'T>(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PopupRoute<'T> [<NamedParams>] (?settings : RouteSettings, ?filter : ImageFilter) =
    inherit ModalRoute<'T>(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RouteObserver<'R> () =
    inherit NavigatorObserver()

  [<ImportMember("package:flutter/widgets.dart")>]
  type RouteAware () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type RawDialogRoute<'T> [<NamedParams>] (pageBuilder : RoutePageBuilder, ?barrierDismissible : bool, ?barrierColor : Color, ?barrierLabel : string, ?transitionDuration : Duration, ?transitionBuilder : RouteTransitionsBuilder, ?settings : RouteSettings, ?anchorPoint : Offset) =
    inherit PopupRoute<'T>(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FocusTrap [<NamedParams>] (focusScopeNode : FocusScopeNode, child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FocusTrapArea [<NamedParams>] (focusNode : FocusNode, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SafeArea [<NamedParams>] (?left : bool, ?top : bool, ?right : bool, ?bottom : bool, ?minimum : EdgeInsets, ?maintainBottomViewPadding : bool, child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverSafeArea [<NamedParams>] (?left : bool, ?top : bool, ?right : bool, ?bottom : bool, ?minimum : EdgeInsets, sliver : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollActivityDelegate () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollActivity (_delegate : ScrollActivityDelegate) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type IdleScrollActivity (delegate : ScrollActivityDelegate) =
    inherit ScrollActivity(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollHoldController () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type HoldScrollActivity [<NamedParams>] (delegate : ScrollActivityDelegate, ?onHoldCanceled : VoidCallback) =
    inherit ScrollActivity(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollDragController [<NamedParams>] (delegate : ScrollActivityDelegate, details : DragStartDetails, ?onDragCanceled : VoidCallback, ?carriedVelocity : double, ?motionStartDistanceThreshold : double) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type DragScrollActivity (delegate : ScrollActivityDelegate, controller : ScrollDragController) =
    inherit ScrollActivity(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type BallisticScrollActivity (delegate : ScrollActivityDelegate, simulation : Simulation, vsync : TickerProvider) =
    inherit ScrollActivity(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DrivenScrollActivity [<NamedParams(fromIndex=1)>] (delegate : ScrollActivityDelegate, from : double, to : double, duration : Duration, curve : Curve, vsync : TickerProvider) =
    inherit ScrollActivity(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollAwareImageProvider<'T> [<NamedParams>] (context : DisposableBuildContext, imageProvider : ImageProvider) =
    inherit ImageProvider<'T>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollBehavior (?androidOverscrollIndicator : AndroidOverscrollIndicator) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollConfiguration [<NamedParams>] (behavior : ScrollBehavior, child : Widget, ?key : Key) =
    inherit InheritedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollContext () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollController [<NamedParams>] (?initialScrollOffset : double, ?keepScrollOffset : bool, ?debugLabel : string) =
    inherit ChangeNotifier()

  [<ImportMember("package:flutter/widgets.dart")>]
  type TrackingScrollController [<NamedParams>] (?initialScrollOffset : double, ?keepScrollOffset : bool, ?debugLabel : string) =
    inherit ScrollController(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FixedScrollMetrics [<NamedParams>] (minScrollExtent : double, maxScrollExtent : double, pixels : double, viewportDimension : double, axisDirection : AxisDirection) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollNotification [<NamedParams>] (metrics : ScrollMetrics, context : BuildContext) =
    inherit LayoutChangedNotification()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollStartNotification [<NamedParams>] (metrics : ScrollMetrics, context : BuildContext, ?dragDetails : DragStartDetails) =
    inherit ScrollNotification(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollUpdateNotification [<NamedParams>] (metrics : ScrollMetrics, context : BuildContext, ?dragDetails : DragUpdateDetails, ?scrollDelta : double, ?depth : int) =
    inherit ScrollNotification(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type OverscrollNotification [<NamedParams>] (metrics : ScrollMetrics, context : BuildContext, ?dragDetails : DragUpdateDetails, overscroll : double, ?velocity : double) =
    inherit ScrollNotification(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollEndNotification [<NamedParams>] (metrics : ScrollMetrics, context : BuildContext, ?dragDetails : DragEndDetails) =
    inherit ScrollNotification(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type UserScrollNotification [<NamedParams>] (metrics : ScrollMetrics, context : BuildContext, direction : ScrollDirection) =
    inherit ScrollNotification(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollNotificationObserver [<NamedParams>] (child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollNotificationObserverState () =
    inherit State<ScrollNotificationObserver>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollPhysics (?parent : ScrollPhysics) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type RangeMaintainingScrollPhysics (?parent : ScrollPhysics) =
    inherit ScrollPhysics(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type BouncingScrollPhysics (?parent : ScrollPhysics) =
    inherit ScrollPhysics(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ClampingScrollPhysics (?parent : ScrollPhysics) =
    inherit ScrollPhysics(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AlwaysScrollableScrollPhysics (?parent : ScrollPhysics) =
    inherit ScrollPhysics(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type NeverScrollableScrollPhysics (?parent : ScrollPhysics) =
    inherit ScrollPhysics(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollPosition [<NamedParams>] (physics : ScrollPhysics, context : ScrollContext, ?keepScrollOffset : bool, ?oldPosition : ScrollPosition, ?debugLabel : string) =
    inherit ViewportOffset()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollMetricsNotification [<NamedParams>] (metrics : ScrollMetrics, context : BuildContext) =
    inherit Notification()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollPositionWithSingleContext [<NamedParams>] (physics : ScrollPhysics, context : ScrollContext, ?initialPixels : double, ?keepScrollOffset : bool, ?oldPosition : ScrollPosition, ?debugLabel : string) =
    inherit ScrollPosition(jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type BouncingScrollSimulation [<NamedParams>] (position : double, velocity : double, leadingExtent : double, trailingExtent : double, spring : SpringDescription, ?tolerance : Tolerance) =
    inherit Simulation(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ClampingScrollSimulation [<NamedParams>] (position : double, velocity : double, ?friction : double, ?tolerance : Tolerance) =
    inherit Simulation(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollView [<NamedParams>] (?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?scrollBehavior : ScrollBehavior, ?shrinkWrap : bool, ?center : Key, ?anchor : double, ?cacheExtent : double, ?semanticChildCount : int, ?dragStartBehavior : DragStartBehavior, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?restorationId : string, ?clipBehavior : Clip, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type CustomScrollView [<NamedParams>] (?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?scrollBehavior : ScrollBehavior, ?shrinkWrap : bool, ?center : Key, ?anchor : double, ?cacheExtent : double, ?slivers : List, ?semanticChildCount : int, ?dragStartBehavior : DragStartBehavior, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?restorationId : string, ?clipBehavior : Clip, ?key : Key) =
    inherit ScrollView(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type BoxScrollView [<NamedParams>] (?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?shrinkWrap : bool, ?padding : EdgeInsetsGeometry, ?cacheExtent : double, ?semanticChildCount : int, ?dragStartBehavior : DragStartBehavior, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?restorationId : string, ?clipBehavior : Clip, ?key : Key) =
    inherit ScrollView(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ListView [<NamedParams>] (?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?shrinkWrap : bool, ?padding : EdgeInsetsGeometry, ?itemExtent : double, ?prototypeItem : Widget, ?addAutomaticKeepAlives : bool, ?addRepaintBoundaries : bool, ?addSemanticIndexes : bool, ?cacheExtent : double, ?children : List, ?semanticChildCount : int, ?dragStartBehavior : DragStartBehavior, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?restorationId : string, ?clipBehavior : Clip, ?key : Key) =
    inherit BoxScrollView(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)
    [<NamedParams>] static member builder(?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?shrinkWrap : bool, ?padding : EdgeInsetsGeometry, ?itemExtent : double, ?prototypeItem : Widget, itemBuilder : IndexedWidgetBuilder, ?findChildIndexCallback : ChildIndexGetter, ?itemCount : int, ?addAutomaticKeepAlives : bool, ?addRepaintBoundaries : bool, ?addSemanticIndexes : bool, ?cacheExtent : double, ?semanticChildCount : int, ?dragStartBehavior : DragStartBehavior, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?restorationId : string, ?clipBehavior : Clip) : ListView = jsNat, ?key : Keyive
    [<NamedParams>] static member separated(?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?shrinkWrap : bool, ?padding : EdgeInsetsGeometry, itemBuilder : IndexedWidgetBuilder, ?findChildIndexCallback : ChildIndexGetter, separatorBuilder : IndexedWidgetBuilder, itemCount : int, ?addAutomaticKeepAlives : bool, ?addRepaintBoundaries : bool, ?addSemanticIndexes : bool, ?cacheExtent : double, ?dragStartBehavior : DragStartBehavior, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?restorationId : string, ?clipBehavior : Clip) : ListView = jsNat, ?key : Keyive
    [<NamedParams>] static member custom(?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?shrinkWrap : bool, ?padding : EdgeInsetsGeometry, ?itemExtent : double, ?prototypeItem : Widget, childrenDelegate : SliverChildDelegate, ?cacheExtent : double, ?semanticChildCount : int, ?dragStartBehavior : DragStartBehavior, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?restorationId : string, ?clipBehavior : Clip) : ListView = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type GridView [<NamedParams>] (?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?shrinkWrap : bool, ?padding : EdgeInsetsGeometry, gridDelegate : SliverGridDelegate, ?addAutomaticKeepAlives : bool, ?addRepaintBoundaries : bool, ?addSemanticIndexes : bool, ?cacheExtent : double, ?children : List, ?semanticChildCount : int, ?dragStartBehavior : DragStartBehavior, ?clipBehavior : Clip, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?restorationId : string, ?key : Key) =
    inherit BoxScrollView(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)
    [<NamedParams>] static member builder(?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?shrinkWrap : bool, ?padding : EdgeInsetsGeometry, gridDelegate : SliverGridDelegate, itemBuilder : IndexedWidgetBuilder, ?findChildIndexCallback : ChildIndexGetter, ?itemCount : int, ?addAutomaticKeepAlives : bool, ?addRepaintBoundaries : bool, ?addSemanticIndexes : bool, ?cacheExtent : double, ?semanticChildCount : int, ?dragStartBehavior : DragStartBehavior, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?restorationId : string, ?clipBehavior : Clip) : GridView = jsNat, ?key : Keyive
    [<NamedParams>] static member custom(?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?shrinkWrap : bool, ?padding : EdgeInsetsGeometry, gridDelegate : SliverGridDelegate, childrenDelegate : SliverChildDelegate, ?cacheExtent : double, ?semanticChildCount : int, ?dragStartBehavior : DragStartBehavior, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?restorationId : string, ?clipBehavior : Clip) : GridView = jsNat, ?key : Keyive
    [<NamedParams>] static member count(?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?shrinkWrap : bool, ?padding : EdgeInsetsGeometry, crossAxisCount : int, ?mainAxisSpacing : double, ?crossAxisSpacing : double, ?childAspectRatio : double, ?addAutomaticKeepAlives : bool, ?addRepaintBoundaries : bool, ?addSemanticIndexes : bool, ?cacheExtent : double, ?children : List, ?semanticChildCount : int, ?dragStartBehavior : DragStartBehavior, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?restorationId : string, ?clipBehavior : Clip) : GridView = jsNat, ?key : Keyive
    [<NamedParams>] static member extent(?scrollDirection : Axis, ?reverse : bool, ?controller : ScrollController, ?primary : bool, ?physics : ScrollPhysics, ?shrinkWrap : bool, ?padding : EdgeInsetsGeometry, maxCrossAxisExtent : double, ?mainAxisSpacing : double, ?crossAxisSpacing : double, ?childAspectRatio : double, ?addAutomaticKeepAlives : bool, ?addRepaintBoundaries : bool, ?addSemanticIndexes : bool, ?cacheExtent : double, ?children : List, ?semanticChildCount : int, ?dragStartBehavior : DragStartBehavior, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?restorationId : string, ?clipBehavior : Clip) : GridView = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type Scrollable [<NamedParams>] (?axisDirection : AxisDirection, ?controller : ScrollController, ?physics : ScrollPhysics, viewportBuilder : ViewportBuilder, ?incrementCalculator : ScrollIncrementCalculator, ?excludeFromSemantics : bool, ?semanticChildCount : int, ?dragStartBehavior : DragStartBehavior, ?restorationId : string, ?scrollBehavior : ScrollBehavior, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollableState () =
    inherit State<Scrollable>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollableDetails [<NamedParams>] (direction : AxisDirection, controller : ScrollController) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollIncrementDetails [<NamedParams>] (type : ScrollIncrementType, metrics : ScrollMetrics) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollIntent [<NamedParams>] (direction : AxisDirection, ?type : ScrollIncrementType) =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollAction () =
    inherit Action<ScrollIntent>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollbarPainter [<NamedParams>] (color : Color, fadeoutOpacityAnimation : Animation, ?trackColor : Color, ?trackBorderColor : Color, ?textDirection : TextDirection, ?thickness : double, ?padding : EdgeInsets, ?mainAxisMargin : double, ?crossAxisMargin : double, ?radius : Radius, ?trackRadius : Radius, ?shape : OutlinedBorder, ?minLength : double, ?minOverscrollLength : double, ?scrollbarOrientation : ScrollbarOrientation, ?ignorePointer : bool) =
    inherit ChangeNotifier()

  [<ImportMember("package:flutter/widgets.dart")>]
  type RawScrollbar [<NamedParams>] (child : Widget, ?controller : ScrollController, ?thumbVisibility : bool, ?shape : OutlinedBorder, ?radius : Radius, ?thickness : double, ?thumbColor : Color, ?minThumbLength : double, ?minOverscrollLength : double, ?trackVisibility : bool, ?trackRadius : Radius, ?trackColor : Color, ?trackBorderColor : Color, ?fadeDuration : Duration, ?timeToFade : Duration, ?pressDuration : Duration, ?notificationPredicate : ScrollNotificationPredicate, ?interactive : bool, ?scrollbarOrientation : ScrollbarOrientation, ?mainAxisMargin : double, ?crossAxisMargin : double, ?isAlwaysShown : bool, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RawScrollbarState<'T> () =
    inherit State<'T>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type SemanticsDebugger [<NamedParams>] (child : Widget, ?labelStyle : TextStyle, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SharedAppData [<NamedParams>] (child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type KeySet<'T> (key1 : T, ?key2 : T, ?key3 : T, ?key4 : T) =
    static member fromSet(keys : Set) : KeySet<'T> = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type ShortcutActivator () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type LogicalKeySet (key1 : LogicalKeyboardKey, ?key2 : LogicalKeyboardKey, ?key3 : LogicalKeyboardKey, ?key4 : LogicalKeyboardKey) =
    inherit KeySet<LogicalKeyboardKey>(jsNative, jsNative, jsNative, jsNative)
    static member fromSet(keys : Set) : LogicalKeySet = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type ShortcutMapProperty [<NamedParams(fromIndex=2)>] (name : string, value : Map, ?showName : bool, ?defaultValue : Object, ?level : DiagnosticLevel, ?description : string) =
    inherit DiagnosticsProperty<Map>(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SingleActivator [<NamedParams(fromIndex=1)>] (trigger : LogicalKeyboardKey, ?control : bool, ?shift : bool, ?alt : bool, ?meta : bool, ?includeRepeats : bool) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type CharacterActivator (character : string) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type ShortcutManager [<NamedParams>] (?shortcuts : Map, ?modal : bool) =
    inherit ChangeNotifier()

  [<ImportMember("package:flutter/widgets.dart")>]
  type Shortcuts [<NamedParams>] (?manager : ShortcutManager, shortcuts : Map, child : Widget, ?debugLabel : string, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type CallbackShortcuts [<NamedParams>] (bindings : Map, child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SingleChildScrollView [<NamedParams>] (?scrollDirection : Axis, ?reverse : bool, ?padding : EdgeInsetsGeometry, ?primary : bool, ?physics : ScrollPhysics, ?controller : ScrollController, ?child : Widget, ?dragStartBehavior : DragStartBehavior, ?clipBehavior : Clip, ?restorationId : string, ?keyboardDismissBehavior : ScrollViewKeyboardDismissBehavior, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SizeChangedLayoutNotification () =
    inherit LayoutChangedNotification()

  [<ImportMember("package:flutter/widgets.dart")>]
  type SizeChangedLayoutNotifier [<NamedParams>] (?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverChildDelegate () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverChildBuilderDelegate [<NamedParams(fromIndex=1)>] (builder : NullableIndexedWidgetBuilder, ?findChildIndexCallback : ChildIndexGetter, ?childCount : int, ?addAutomaticKeepAlives : bool, ?addRepaintBoundaries : bool, ?addSemanticIndexes : bool, ?semanticIndexCallback : SemanticIndexCallback, ?semanticIndexOffset : int) =
    inherit SliverChildDelegate()

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverChildListDelegate [<NamedParams(fromIndex=1)>] (children : List, ?addAutomaticKeepAlives : bool, ?addRepaintBoundaries : bool, ?addSemanticIndexes : bool, ?semanticIndexCallback : SemanticIndexCallback, ?semanticIndexOffset : int) =
    inherit SliverChildDelegate()
    [<NamedParams(fromIndex=1)>] static member fixed(children : List, ?addAutomaticKeepAlives : bool, ?addRepaintBoundaries : bool, ?addSemanticIndexes : bool, ?semanticIndexCallback : SemanticIndexCallback, ?semanticIndexOffset : int) : SliverChildListDelegate = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverWithKeepAliveWidget (?key : Key) =
    inherit RenderObjectWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverMultiBoxAdaptorWidget [<NamedParams>] (delegate : SliverChildDelegate, ?key : Key) =
    inherit SliverWithKeepAliveWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverList [<NamedParams>] (delegate : SliverChildDelegate, ?key : Key) =
    inherit SliverMultiBoxAdaptorWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverFixedExtentList [<NamedParams>] (delegate : SliverChildDelegate, itemExtent : double, ?key : Key) =
    inherit SliverMultiBoxAdaptorWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverGrid [<NamedParams>] (delegate : SliverChildDelegate, gridDelegate : SliverGridDelegate, ?key : Key) =
    inherit SliverMultiBoxAdaptorWidget(jsNative, jsNative)
    [<NamedParams>] static member count(crossAxisCount : int, ?mainAxisSpacing : double, ?crossAxisSpacing : double, ?childAspectRatio : double, ?children : List) : SliverGrid = jsNat, ?key : Keyive
    [<NamedParams>] static member extent(maxCrossAxisExtent : double, ?mainAxisSpacing : double, ?crossAxisSpacing : double, ?childAspectRatio : double, ?children : List) : SliverGrid = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverMultiBoxAdaptorElement (widget : SliverMultiBoxAdaptorWidget, ?replaceMovedChildren : bool) =
    inherit RenderObjectElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverOpacity [<NamedParams>] (opacity : double, ?alwaysIncludeSemantics : bool, ?sliver : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverIgnorePointer [<NamedParams>] (?ignoring : bool, ?ignoringSemantics : bool, ?sliver : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverOffstage [<NamedParams>] (?offstage : bool, ?sliver : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type KeepAlive [<NamedParams>] (keepAlive : bool, child : Widget, ?key : Key) =
    inherit ParentDataWidget<KeepAliveParentDataMixin>(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverFillViewport [<NamedParams>] (delegate : SliverChildDelegate, ?viewportFraction : double, ?padEnds : bool, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverFillRemaining [<NamedParams>] (?child : Widget, ?hasScrollBody : bool, ?fillOverscroll : bool, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverLayoutBuilder [<NamedParams>] (builder : SliverLayoutWidgetBuilder, ?key : Key) =
    inherit ConstrainedLayoutBuilder<SliverConstraints>(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverPersistentHeaderDelegate () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverPersistentHeader [<NamedParams>] (delegate : SliverPersistentHeaderDelegate, ?pinned : bool, ?floating : bool, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverPrototypeExtentList [<NamedParams>] (delegate : SliverChildDelegate, prototypeItem : Widget, ?key : Key) =
    inherit SliverMultiBoxAdaptorWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SlottedRenderObjectElement<'S> (widget : SlottedMultiChildRenderObjectWidgetMixin) =
    inherit RenderObjectElement(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Spacer [<NamedParams>] (?flex : int, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type StatusTransitionWidget [<NamedParams>] (animation : Animation, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type TableRow [<NamedParams>] (?key : LocalKey, ?decoration : Decoration, ?children : List) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type Table [<NamedParams>] (?children : List, ?columnWidths : Map, ?defaultColumnWidth : TableColumnWidth, ?textDirection : TextDirection, ?border : TableBorder, ?defaultVerticalAlignment : TableCellVerticalAlignment, ?textBaseline : TextBaseline, ?key : Key) =
    inherit RenderObjectWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type TableCell [<NamedParams>] (?verticalAlignment : TableCellVerticalAlignment, child : Widget, ?key : Key) =
    inherit ParentDataWidget<TableCellParentData>(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DefaultTextStyle [<NamedParams>] (style : TextStyle, ?textAlign : TextAlign, ?softWrap : bool, ?overflow : TextOverflow, ?maxLines : int, ?textWidthBasis : TextWidthBasis, ?textHeightBehavior : TextHeightBehavior, child : Widget, ?key : Key) =
    inherit InheritedTheme(jsNative, jsNative)
    static member fallback(?key : Key) : DefaultTextStyle = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type DefaultTextHeightBehavior [<NamedParams>] (textHeightBehavior : TextHeightBehavior, child : Widget, ?key : Key) =
    inherit InheritedTheme(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Text [<NamedParams(fromIndex=1)>] (data : string, ?style : TextStyle, ?strutStyle : StrutStyle, ?textAlign : TextAlign, ?textDirection : TextDirection, ?locale : Locale, ?softWrap : bool, ?overflow : TextOverflow, ?textScaleFactor : double, ?maxLines : int, ?semanticsLabel : string, ?textWidthBasis : TextWidthBasis, ?textHeightBehavior : TextHeightBehavior, ?key : Key) =
    inherit StatelessWidget(jsNative)
    [<NamedParams(fromIndex=1)>] static member rich(textSpan : InlineSpan, ?style : TextStyle, ?strutStyle : StrutStyle, ?textAlign : TextAlign, ?textDirection : TextDirection, ?locale : Locale, ?softWrap : bool, ?overflow : TextOverflow, ?textScaleFactor : double, ?maxLines : int, ?semanticsLabel : string, ?textWidthBasis : TextWidthBasis, ?textHeightBehavior : TextHeightBehavior) : Text = jsNat, ?key : Keyive

  [<ImportMember("package:flutter/widgets.dart")>]
  type DoNothingAndStopPropagationTextIntent () =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type DirectionalTextEditingIntent (forward : bool) =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type DeleteCharacterIntent (forward : bool) =
    inherit DirectionalTextEditingIntent(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DeleteToNextWordBoundaryIntent (forward : bool) =
    inherit DirectionalTextEditingIntent(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DeleteToLineBreakIntent (forward : bool) =
    inherit DirectionalTextEditingIntent(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DirectionalCaretMovementIntent (forward : bool, collapseSelection : bool, ?collapseAtReversal : bool, ?continuesAtWrap : bool) =
    inherit DirectionalTextEditingIntent(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ExtendSelectionByCharacterIntent [<NamedParams>] (forward : bool, collapseSelection : bool) =
    inherit DirectionalCaretMovementIntent(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ExtendSelectionToNextWordBoundaryIntent [<NamedParams>] (forward : bool, collapseSelection : bool) =
    inherit DirectionalCaretMovementIntent(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ExtendSelectionToNextWordBoundaryOrCaretLocationIntent (forward : bool) =
    inherit DirectionalTextEditingIntent(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ExpandSelectionToDocumentBoundaryIntent (forward : bool) =
    inherit DirectionalTextEditingIntent(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ExpandSelectionToLineBreakIntent (forward : bool) =
    inherit DirectionalTextEditingIntent(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ExtendSelectionToLineBreakIntent [<NamedParams>] (forward : bool, collapseSelection : bool, ?collapseAtReversal : bool, ?continuesAtWrap : bool) =
    inherit DirectionalCaretMovementIntent(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ExtendSelectionVerticallyToAdjacentLineIntent [<NamedParams>] (forward : bool, collapseSelection : bool) =
    inherit DirectionalCaretMovementIntent(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ExtendSelectionToDocumentBoundaryIntent [<NamedParams>] (forward : bool, collapseSelection : bool) =
    inherit DirectionalCaretMovementIntent(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScrollToDocumentBoundaryIntent (forward : bool) =
    inherit DirectionalTextEditingIntent(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SelectAllTextIntent (cause : SelectionChangedCause) =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
    inherit Intent()
  type CopySelectionTextIntent =
    static member cut(cause : SelectionChangedCause) : CopySelectionTextIntent = jsNative

  [<ImportMember("package:flutter/widgets.dart")>]
  type PasteTextIntent (cause : SelectionChangedCause) =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type RedoTextIntent (cause : SelectionChangedCause) =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ReplaceTextIntent (currentTextEditingValue : TextEditingValue, replacementText : string, replacementRange : TextRange, cause : SelectionChangedCause) =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type UndoTextIntent (cause : SelectionChangedCause) =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type UpdateSelectionIntent (currentTextEditingValue : TextEditingValue, newSelection : TextSelection, cause : SelectionChangedCause) =
    inherit Intent()

  [<ImportMember("package:flutter/widgets.dart")>]
  type ToolbarItemsParentData () =
    inherit ContainerBoxParentData<RenderBox>()

  [<ImportMember("package:flutter/widgets.dart")>]
  type TextSelectionControls () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type TextSelectionOverlay [<NamedParams>] (value : TextEditingValue, context : BuildContext, ?debugRequiredFor : Widget, toolbarLayerLink : LayerLink, startHandleLayerLink : LayerLink, endHandleLayerLink : LayerLink, renderObject : RenderEditable, ?selectionControls : TextSelectionControls, ?handlesVisible : bool, selectionDelegate : TextSelectionDelegate, ?dragStartBehavior : DragStartBehavior, ?onSelectionHandleTapped : VoidCallback, ?clipboardStatus : ClipboardStatusNotifier) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type SelectionOverlay [<NamedParams>] (context : BuildContext, ?debugRequiredFor : Widget, startHandleType : TextSelectionHandleType, lineHeightAtStart : double, ?startHandlesVisible : ValueListenable, ?onStartHandleDragStart : ValueChanged, ?onStartHandleDragUpdate : ValueChanged, ?onStartHandleDragEnd : ValueChanged, endHandleType : TextSelectionHandleType, lineHeightAtEnd : double, ?``endHandlesVisible`` : ValueListenable, ?onEndHandleDragStart : ValueChanged, ?onEndHandleDragUpdate : ValueChanged, ?onEndHandleDragEnd : ValueChanged, ?toolbarVisible : ValueListenable, selectionEndPoints : List, selectionControls : TextSelectionControls, selectionDelegate : TextSelectionDelegate, clipboardStatus : ClipboardStatusNotifier, startHandleLayerLink : LayerLink, endHandleLayerLink : LayerLink, toolbarLayerLink : LayerLink, ?dragStartBehavior : DragStartBehavior, ?onSelectionHandleTapped : VoidCallback, ?toolbarLocation : Offset) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type TextSelectionGestureDetectorBuilderDelegate () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type TextSelectionGestureDetectorBuilder (delegate : TextSelectionGestureDetectorBuilderDelegate) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type TextSelectionGestureDetector [<NamedParams>] (?onTapDown : GestureTapDownCallback, ?onForcePressStart : GestureForcePressStartCallback, ?onForcePressEnd : GestureForcePressEndCallback, ?onSecondaryTap : GestureTapCallback, ?onSecondaryTapDown : GestureTapDownCallback, ?onSingleTapUp : GestureTapUpCallback, ?onSingleTapCancel : GestureTapCancelCallback, ?onSingleLongTapStart : GestureLongPressStartCallback, ?onSingleLongTapMoveUpdate : GestureLongPressMoveUpdateCallback, ?onSingleLongTapEnd : GestureLongPressEndCallback, ?onDoubleTapDown : GestureTapDownCallback, ?onDragSelectionStart : GestureDragStartCallback, ?onDragSelectionUpdate : DragSelectionUpdateCallback, ?onDragSelectionEnd : GestureDragEndCallback, ?behavior : HitTestBehavior, child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ClipboardStatusNotifier (?value : ClipboardStatus) =
    inherit ValueNotifier<ClipboardStatus>(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type TextSelectionToolbarLayoutDelegate [<NamedParams>] (anchorAbove : Offset, anchorBelow : Offset, ?fitsAbove : bool) =
    inherit SingleChildLayoutDelegate(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Texture [<NamedParams>] (textureId : int, ?freeze : bool, ?filterQuality : FilterQuality, ?key : Key) =
    inherit LeafRenderObjectWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type TickerMode [<NamedParams>] (enabled : bool, child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Title [<NamedParams>] (?title : string, color : Color, child : Widget, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedWidget [<NamedParams>] (listenable : Listenable, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SlideTransition [<NamedParams>] (position : Animation, ?transformHitTests : bool, ?textDirection : TextDirection, ?child : Widget, ?key : Key) =
    inherit AnimatedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ScaleTransition [<NamedParams>] (scale : Animation, ?alignment : Alignment, ?filterQuality : FilterQuality, ?child : Widget, ?key : Key) =
    inherit AnimatedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RotationTransition [<NamedParams>] (turns : Animation, ?alignment : Alignment, ?filterQuality : FilterQuality, ?child : Widget, ?key : Key) =
    inherit AnimatedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SizeTransition [<NamedParams>] (?axis : Axis, sizeFactor : Animation, ?axisAlignment : double, ?child : Widget, ?key : Key) =
    inherit AnimatedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type FadeTransition [<NamedParams>] (opacity : Animation, ?alwaysIncludeSemantics : bool, ?child : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverFadeTransition [<NamedParams>] (opacity : Animation, ?alwaysIncludeSemantics : bool, ?sliver : Widget, ?key : Key) =
    inherit SingleChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RelativeRectTween [<NamedParams>] (?``begin`` : RelativeRect, ?``end`` : RelativeRect) =
    inherit Tween<RelativeRect>(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type PositionedTransition [<NamedParams>] (rect : Animation, child : Widget, ?key : Key) =
    inherit AnimatedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type RelativePositionedTransition [<NamedParams>] (rect : Animation, size : Size, child : Widget, ?key : Key) =
    inherit AnimatedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DecoratedBoxTransition [<NamedParams>] (decoration : Animation, ?position : DecorationPosition, child : Widget, ?key : Key) =
    inherit AnimatedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AlignTransition [<NamedParams>] (alignment : Animation, child : Widget, ?widthFactor : double, ?heightFactor : double, ?key : Key) =
    inherit AnimatedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type DefaultTextStyleTransition [<NamedParams>] (style : Animation, child : Widget, ?textAlign : TextAlign, ?softWrap : bool, ?overflow : TextOverflow, ?maxLines : int, ?key : Key) =
    inherit AnimatedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type AnimatedBuilder [<NamedParams>] (animation : Listenable, builder : TransitionBuilder, ?child : Widget, ?key : Key) =
    inherit AnimatedWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type TweenAnimationBuilder<'T> [<NamedParams>] (tween : Tween, duration : Duration, ?curve : Curve, builder : ValueWidgetBuilder, ?onEnd : VoidCallback, ?child : Widget, ?key : Key) =
    inherit ImplicitlyAnimatedWidget(jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type UniqueWidget<'T> (key : GlobalKey) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ValueListenableBuilder<'T> [<NamedParams>] (valueListenable : ValueListenable, builder : ValueWidgetBuilder, ?child : Widget, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Viewport [<NamedParams>] (?axisDirection : AxisDirection, ?crossAxisDirection : AxisDirection, ?anchor : double, offset : ViewportOffset, ?center : Key, ?cacheExtent : double, ?cacheExtentStyle : CacheExtentStyle, ?clipBehavior : Clip, ?slivers : List, ?key : Key) =
    inherit MultiChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type ShrinkWrappingViewport [<NamedParams>] (?axisDirection : AxisDirection, ?crossAxisDirection : AxisDirection, offset : ViewportOffset, ?clipBehavior : Clip, ?slivers : List, ?key : Key) =
    inherit MultiChildRenderObjectWidget(jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type Visibility [<NamedParams>] (child : Widget, ?replacement : Widget, ?visible : bool, ?maintainState : bool, ?maintainAnimation : bool, ?maintainSize : bool, ?maintainSemantics : bool, ?maintainInteractivity : bool, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type SliverVisibility [<NamedParams>] (sliver : Widget, ?replacementSliver : Widget, ?visible : bool, ?maintainState : bool, ?maintainAnimation : bool, ?maintainSize : bool, ?maintainSemantics : bool, ?maintainInteractivity : bool, ?key : Key) =
    inherit StatelessWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type WidgetInspector [<NamedParams>] (child : Widget, selectButtonBuilder : InspectorSelectButtonBuilder, ?key : Key) =
    inherit StatefulWidget(jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type InspectorSelection () =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type DevToolsDeepLinkProperty (description : string, url : string) =
    inherit DiagnosticsProperty<string>(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type InspectorSerializationDelegate [<NamedParams>] (?groupName : string, ?summaryTree : bool, ?maxDescendentsTruncatableNode : int, ?expandPropertyValues : bool, ?subtreeDepth : int, ?includeProperties : bool, service : WidgetInspectorService, ?addAdditionalPropertiesCallback : Map<string, Object>? Function(DiagnosticsNode, InspectorSerializationDelegate)?) =
    class end

  [<ImportMember("package:flutter/widgets.dart")>]
  type WidgetSpan [<NamedParams>] (child : Widget, ?alignment : PlaceholderAlignment, ?baseline : TextBaseline, ?style : TextStyle) =
    inherit PlaceholderSpan(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/widgets.dart")>]
  type WillPopScope [<NamedParams>] (child : Widget, onWillPop : WillPopCallback, ?key : Key) =
    inherit StatefulWidget(jsNative)

module rec Foundation =
  [<ImportMember("package:flutter/foundation.dart")>
  type Category (sections : List) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type DocumentationIcon (url : string) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type Summary (text : string) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type PartialStackFrame [<NamedParams>] (package : Pattern, className : string, method : string) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type StackFilter () =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type RepetitiveStackFrameFilter [<NamedParams>] (frames : List, replacement : string) =
    inherit StackFilter()

  [<ImportMember("package:flutter/foundation.dart")>
  type ErrorDescription (message : string) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type ErrorSummary (message : string) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type ErrorHint (message : string) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type ErrorSpacer () =
    inherit DiagnosticsProperty(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/foundation.dart")>
  type FlutterErrorDetails [<NamedParams>] (error : Object, ?stack : StackTrace, ?library : string, ?context : DiagnosticsNode, ?stackFilter : IterableFilter, ?informationCollector : InformationCollector, ?silent : bool) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type DiagnosticsStackTrace [<NamedParams(fromIndex=2)>] (name : string, stack : StackTrace, ?stackFilter : IterableFilter, ?showSeparator : bool) =
    inherit DiagnosticsBlock(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)
    [<NamedParams(fromIndex=1)>] static member singleFrame(name : string, frame : string, ?showSeparator : bool) : DiagnosticsStackTrace = jsNative

  [<ImportMember("package:flutter/foundation.dart")>
  type CachingIterable<'E> (_prefillIterator : Iterator) =
    inherit IterableBase<'E>()

  [<ImportMember("package:flutter/foundation.dart")>
  type Factory<'T> (constructor : ValueGetter) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type BindingBase () =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type DebugReassembleConfig (?widgetName : string) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type BitField<'T> (length : int) =
    static member filled(length : int, value : bool) : BitField<'T> = jsNative

  [<ImportMember("package:flutter/foundation.dart")>
  type Listenable () =
    static member merge(listenables : List) : Listenable = jsNative

  [<ImportMember("package:flutter/foundation.dart")>
  type ValueListenable<'T> () =
    inherit Listenable()

  [<ImportMember("package:flutter/foundation.dart")>
  type ChangeNotifier () =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type ValueNotifier<'T> (_value : T) =
    inherit ChangeNotifier()

  [<ImportMember("package:flutter/foundation.dart")>
  type TextTreeConfiguration [<NamedParams>] (prefixLineOne : string, prefixOtherLines : string, prefixLastChildLineOne : string, prefixOtherLinesRootNode : string, linkCharacter : string, propertyPrefixIfChildren : string, propertyPrefixNoChildren : string, ?lineBreak : string, ?lineBreakProperties : bool, ?afterName : string, ?afterDescriptionIfBody : string, ?afterDescription : string, ?beforeProperties : string, ?afterProperties : string, ?mandatoryAfterProperties : string, ?propertySeparator : string, ?bodyIndent : string, ?footer : string, ?showChildren : bool, ?addBlankLineIfNoChildren : bool, ?isNameOnOwnLine : bool, ?isBlankLineBetweenPropertiesAndChildren : bool, ?beforeName : string, ?suffixLineOne : string, ?mandatoryFooter : string) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type TextTreeRenderer [<NamedParams>] (?minLevel : DiagnosticLevel, ?wrapWidth : int, ?wrapWidthProperties : int, ?maxDescendentsTruncatableNode : int) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type DiagnosticsNode [<NamedParams>] (name : string, ?style : DiagnosticsTreeStyle, ?showName : bool, ?showSeparator : bool, ?linePrefix : string) =
    [<NamedParams(fromIndex=1)>] static member message(message : string, ?style : DiagnosticsTreeStyle, ?level : DiagnosticLevel, ?allowWrap : bool) : DiagnosticsNode = jsNative

  [<ImportMember("package:flutter/foundation.dart")>
  type MessageProperty [<NamedParams(fromIndex=2)>] (name : string, message : string, ?style : DiagnosticsTreeStyle, ?level : DiagnosticLevel) =
    inherit DiagnosticsProperty(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/foundation.dart")>
  type StringProperty [<NamedParams(fromIndex=2)>] (name : string, value : string, ?description : string, ?tooltip : string, ?showName : bool, ?defaultValue : Object, ?quoted : bool, ?ifEmpty : string, ?style : DiagnosticsTreeStyle, ?level : DiagnosticLevel) =
    inherit DiagnosticsProperty<string>(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/foundation.dart")>
  type DoubleProperty [<NamedParams(fromIndex=2)>] (name : string, value : double, ?ifNull : string, ?unit : string, ?tooltip : string, ?defaultValue : Object, ?showName : bool, ?style : DiagnosticsTreeStyle, ?level : DiagnosticLevel) =
    [<NamedParams(fromIndex=2)>] static member lazy(name : string, computeValue : ComputePropertyValueCallback, ?ifNull : string, ?showName : bool, ?unit : string, ?tooltip : string, ?defaultValue : Object, ?level : DiagnosticLevel) : DoubleProperty = jsNative

  [<ImportMember("package:flutter/foundation.dart")>
  type IntProperty [<NamedParams(fromIndex=2)>] (name : string, value : int, ?ifNull : string, ?showName : bool, ?unit : string, ?defaultValue : Object, ?style : DiagnosticsTreeStyle, ?level : DiagnosticLevel) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type PercentProperty [<NamedParams(fromIndex=2)>] (name : string, fraction : double, ?ifNull : string, ?showName : bool, ?tooltip : string, ?unit : string, ?level : DiagnosticLevel) =
    inherit DoubleProperty(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/foundation.dart")>
  type FlagProperty [<NamedParams(fromIndex=1)>] (name : string, value : bool, ?ifTrue : string, ?ifFalse : string, ?showName : bool, ?defaultValue : Object, ?level : DiagnosticLevel) =
    inherit DiagnosticsProperty<bool>(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/foundation.dart")>
  type IterableProperty<'T> [<NamedParams(fromIndex=2)>] (name : string, value : Iterable, ?defaultValue : Object, ?ifNull : string, ?ifEmpty : string, ?style : DiagnosticsTreeStyle, ?showName : bool, ?showSeparator : bool, ?level : DiagnosticLevel) =
    inherit DiagnosticsProperty<Iterable>(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/foundation.dart")>
  type EnumProperty<'T> [<NamedParams(fromIndex=2)>] (name : string, value : T, ?defaultValue : Object, ?level : DiagnosticLevel) =
    inherit DiagnosticsProperty<'T>(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/foundation.dart")>
  type ObjectFlagProperty<'T> [<NamedParams(fromIndex=2)>] (name : string, value : T, ?ifPresent : string, ?ifNull : string, ?showName : bool, ?level : DiagnosticLevel) =
    inherit DiagnosticsProperty<'T>(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)
    static member has(name : string, value : T, ?level : DiagnosticLevel) : ObjectFlagProperty<'T> = jsNative

  [<ImportMember("package:flutter/foundation.dart")>
  type FlagsSummary<'T> [<NamedParams(fromIndex=2)>] (name : string, value : Map, ?ifEmpty : string, ?showName : bool, ?showSeparator : bool, ?level : DiagnosticLevel) =
    inherit DiagnosticsProperty<Map>(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/foundation.dart")>
  type DiagnosticsProperty<'T> [<NamedParams(fromIndex=2)>] (name : string, value : T, ?description : string, ?ifNull : string, ?ifEmpty : string, ?showName : bool, ?showSeparator : bool, ?defaultValue : Object, ?tooltip : string, ?missingIfNull : bool, ?linePrefix : string, ?expandableValue : bool, ?allowWrap : bool, ?allowNameWrap : bool, ?style : DiagnosticsTreeStyle, ?level : DiagnosticLevel) =
    inherit DiagnosticsNode(jsNative, jsNative, jsNative, jsNative, jsNative)
    [<NamedParams(fromIndex=2)>] static member lazy(name : string, computeValue : ComputePropertyValueCallback, ?description : string, ?ifNull : string, ?ifEmpty : string, ?showName : bool, ?showSeparator : bool, ?defaultValue : Object, ?tooltip : string, ?missingIfNull : bool, ?expandableValue : bool, ?allowWrap : bool, ?allowNameWrap : bool, ?style : DiagnosticsTreeStyle, ?level : DiagnosticLevel) : DiagnosticsProperty<'T> = jsNative

  [<ImportMember("package:flutter/foundation.dart")>
  type DiagnosticableNode<'T> [<NamedParams>] (?name : string, value : T, style : DiagnosticsTreeStyle) =
    inherit DiagnosticsNode(jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/foundation.dart")>
  type DiagnosticableTreeNode [<NamedParams>] (?name : string, value : DiagnosticableTree, style : DiagnosticsTreeStyle) =
    inherit DiagnosticableNode<DiagnosticableTree>(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/foundation.dart")>
  type DiagnosticPropertiesBuilder () =
    static member fromProperties(properties : List) : DiagnosticPropertiesBuilder = jsNative

  [<ImportMember("package:flutter/foundation.dart")>
  type DiagnosticableTree () =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type DiagnosticsBlock [<NamedParams>] (?name : string, ?style : DiagnosticsTreeStyle, ?showName : bool, ?showSeparator : bool, ?linePrefix : string, ?value : Object, ?description : string, ?level : DiagnosticLevel, ?allowTruncate : bool, ?children : List, ?properties : List) =
    inherit DiagnosticsNode(jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/foundation.dart")>
  type DiagnosticsSerializationDelegate [<NamedParams>] (?subtreeDepth : int, ?includeProperties : bool) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type Key (value : string) =
    static member empty() : Key = jsNative

  [<ImportMember("package:flutter/foundation.dart")>
  type LocalKey () =
    inherit Key()

  [<ImportMember("package:flutter/foundation.dart")>
  type UniqueKey () =
    inherit LocalKey()

  [<ImportMember("package:flutter/foundation.dart")>
  type ValueKey<'T> (value : T) =
    inherit LocalKey()

  [<ImportMember("package:flutter/foundation.dart")>
  type LicenseParagraph (text : string, indent : int) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type LicenseEntry () =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type LicenseEntryWithLineBreaks (packages : List, text : string) =
    inherit LicenseEntry()

  [<ImportMember("package:flutter/foundation.dart")>
  type LicenseRegistry =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type AbstractNode () =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type ObserverList<'T> () =
    inherit Iterable<'T>()

  [<ImportMember("package:flutter/foundation.dart")>
  type HashedObserverList<'T> () =
    inherit Iterable<'T>()

  [<ImportMember("package:flutter/foundation.dart")>
  type WriteBuffer () =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type ReadBuffer (data : ByteData) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type StackFrame [<NamedParams>] (number : int, column : int, line : int, packageScheme : string, package : string, packagePath : string, ?className : string, method : string, ?isConstructor : bool, source : string) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type SynchronousFuture<'T> (_value : T) =
    class end

  [<ImportMember("package:flutter/foundation.dart")>
  type Unicode =
    class end

module rec Gestures =
  [<ImportMember("package:flutter/gestures.dart")>
  type GestureArenaMember () =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type GestureArenaEntry =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type GestureArenaManager () =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type SamplingClock () =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type FlutterErrorDetailsForPointerEventDispatcher [<NamedParams>] (error : Object, ?stack : StackTrace, ?library : string, ?context : DiagnosticsNode, ?event : PointerEvent, ?hitTestEntry : HitTestEntry, ?informationCollector : InformationCollector, ?silent : bool) =
    inherit FlutterErrorDetails(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerEventConverter =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type Drag () =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type DragDownDetails [<NamedParams>] (?globalPosition : Offset, ?localPosition : Offset) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type DragStartDetails [<NamedParams>] (?sourceTimeStamp : Duration, ?globalPosition : Offset, ?localPosition : Offset, ?kind : PointerDeviceKind) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type DragUpdateDetails [<NamedParams>] (?sourceTimeStamp : Duration, ?delta : Offset, ?primaryDelta : double, globalPosition : Offset, ?localPosition : Offset) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type DragEndDetails [<NamedParams>] (?velocity : Velocity, ?primaryVelocity : double) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type EagerGestureRecognizer [<NamedParams>] (?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit OneSequenceGestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerEvent [<NamedParams>] (?embedderId : int, ?timeStamp : Duration, ?pointer : int, ?kind : PointerDeviceKind, ?device : int, ?position : Offset, ?delta : Offset, ?buttons : int, ?down : bool, ?obscured : bool, ?pressure : double, ?pressureMin : double, ?pressureMax : double, ?distance : double, ?distanceMax : double, ?size : double, ?radiusMajor : double, ?radiusMinor : double, ?radiusMin : double, ?radiusMax : double, ?orientation : double, ?tilt : double, ?platformData : int, ?synthesized : bool, ?transform : Matrix4, ?original : PointerEvent) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerAddedEvent [<NamedParams>] (?timeStamp : Duration, ?pointer : int, ?kind : PointerDeviceKind, ?device : int, ?position : Offset, ?obscured : bool, ?pressureMin : double, ?pressureMax : double, ?distance : double, ?distanceMax : double, ?radiusMin : double, ?radiusMax : double, ?orientation : double, ?tilt : double, ?embedderId : int) =
    inherit PointerEvent(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerRemovedEvent [<NamedParams>] (?timeStamp : Duration, ?pointer : int, ?kind : PointerDeviceKind, ?device : int, ?position : Offset, ?obscured : bool, ?pressureMin : double, ?pressureMax : double, ?distanceMax : double, ?radiusMin : double, ?radiusMax : double, ?original : PointerRemovedEvent, ?embedderId : int) =
    inherit PointerEvent(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerHoverEvent [<NamedParams>] (?timeStamp : Duration, ?kind : PointerDeviceKind, ?pointer : int, ?device : int, ?position : Offset, ?delta : Offset, ?buttons : int, ?obscured : bool, ?pressureMin : double, ?pressureMax : double, ?distance : double, ?distanceMax : double, ?size : double, ?radiusMajor : double, ?radiusMinor : double, ?radiusMin : double, ?radiusMax : double, ?orientation : double, ?tilt : double, ?synthesized : bool, ?embedderId : int) =
    inherit PointerEvent(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerEnterEvent [<NamedParams>] (?timeStamp : Duration, ?pointer : int, ?kind : PointerDeviceKind, ?device : int, ?position : Offset, ?delta : Offset, ?buttons : int, ?obscured : bool, ?pressureMin : double, ?pressureMax : double, ?distance : double, ?distanceMax : double, ?size : double, ?radiusMajor : double, ?radiusMinor : double, ?radiusMin : double, ?radiusMax : double, ?orientation : double, ?tilt : double, ?down : bool, ?synthesized : bool, ?embedderId : int) =
    inherit PointerEvent(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)
    static member fromMouseEvent(event : PointerEvent) : PointerEnterEvent = jsNative

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerExitEvent [<NamedParams>] (?timeStamp : Duration, ?kind : PointerDeviceKind, ?pointer : int, ?device : int, ?position : Offset, ?delta : Offset, ?buttons : int, ?obscured : bool, ?pressureMin : double, ?pressureMax : double, ?distance : double, ?distanceMax : double, ?size : double, ?radiusMajor : double, ?radiusMinor : double, ?radiusMin : double, ?radiusMax : double, ?orientation : double, ?tilt : double, ?down : bool, ?synthesized : bool, ?embedderId : int) =
    inherit PointerEvent(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)
    static member fromMouseEvent(event : PointerEvent) : PointerExitEvent = jsNative

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerDownEvent [<NamedParams>] (?timeStamp : Duration, ?pointer : int, ?kind : PointerDeviceKind, ?device : int, ?position : Offset, ?buttons : int, ?obscured : bool, ?pressure : double, ?pressureMin : double, ?pressureMax : double, ?distanceMax : double, ?size : double, ?radiusMajor : double, ?radiusMinor : double, ?radiusMin : double, ?radiusMax : double, ?orientation : double, ?tilt : double, ?embedderId : int) =
    inherit PointerEvent(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerMoveEvent [<NamedParams>] (?timeStamp : Duration, ?pointer : int, ?kind : PointerDeviceKind, ?device : int, ?position : Offset, ?delta : Offset, ?buttons : int, ?obscured : bool, ?pressure : double, ?pressureMin : double, ?pressureMax : double, ?distanceMax : double, ?size : double, ?radiusMajor : double, ?radiusMinor : double, ?radiusMin : double, ?radiusMax : double, ?orientation : double, ?tilt : double, ?platformData : int, ?synthesized : bool, ?embedderId : int) =
    inherit PointerEvent(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerUpEvent [<NamedParams>] (?timeStamp : Duration, ?pointer : int, ?kind : PointerDeviceKind, ?device : int, ?position : Offset, ?buttons : int, ?obscured : bool, ?pressure : double, ?pressureMin : double, ?pressureMax : double, ?distance : double, ?distanceMax : double, ?size : double, ?radiusMajor : double, ?radiusMinor : double, ?radiusMin : double, ?radiusMax : double, ?orientation : double, ?tilt : double, ?embedderId : int) =
    inherit PointerEvent(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerSignalEvent [<NamedParams>] (?timeStamp : Duration, ?pointer : int, ?kind : PointerDeviceKind, ?device : int, ?position : Offset, ?embedderId : int) =
    inherit PointerEvent(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerScrollEvent [<NamedParams>] (?timeStamp : Duration, ?kind : PointerDeviceKind, ?device : int, ?position : Offset, ?scrollDelta : Offset, ?embedderId : int) =
    inherit PointerSignalEvent(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerCancelEvent [<NamedParams>] (?timeStamp : Duration, ?pointer : int, ?kind : PointerDeviceKind, ?device : int, ?position : Offset, ?buttons : int, ?obscured : bool, ?pressureMin : double, ?pressureMax : double, ?distance : double, ?distanceMax : double, ?size : double, ?radiusMajor : double, ?radiusMinor : double, ?radiusMin : double, ?radiusMax : double, ?orientation : double, ?tilt : double, ?embedderId : int) =
    inherit PointerEvent(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type ForcePressDetails [<NamedParams>] (globalPosition : Offset, ?localPosition : Offset, pressure : double) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type ForcePressGestureRecognizer [<NamedParams>] (?startPressure : double, ?peakPressure : double, ?interpolation : GestureForceInterpolation, ?debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit OneSequenceGestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type DeviceGestureSettings (?touchSlop : double) =
    static member fromWindow(window : FlutterView) : DeviceGestureSettings = jsNative

  [<ImportMember("package:flutter/gestures.dart")>
  type HitTestable =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type HitTestDispatcher =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type HitTestTarget =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type HitTestEntry<'T> (target : T) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type HitTestResult () =
    static member wrap(result : HitTestResult) : HitTestResult = jsNative

  [<ImportMember("package:flutter/gestures.dart")>
  type LongPressDownDetails [<NamedParams>] (?globalPosition : Offset, ?localPosition : Offset, ?kind : PointerDeviceKind) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type LongPressStartDetails [<NamedParams>] (?globalPosition : Offset, ?localPosition : Offset) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type LongPressMoveUpdateDetails [<NamedParams>] (?globalPosition : Offset, ?localPosition : Offset, ?offsetFromOrigin : Offset, ?localOffsetFromOrigin : Offset) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type LongPressEndDetails [<NamedParams>] (?globalPosition : Offset, ?localPosition : Offset, ?velocity : Velocity) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type LongPressGestureRecognizer [<NamedParams>] (?duration : Duration, ?postAcceptSlopTolerance : double, ?kind : PointerDeviceKind, ?supportedDevices : Set, ?debugOwner : Object) =
    inherit PrimaryPointerGestureRecognizer(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PolynomialFit (degree : int) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type LeastSquaresSolver (x : List, y : List, w : List) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type DragGestureRecognizer [<NamedParams>] (?debugOwner : Object, ?kind : PointerDeviceKind, ?dragStartBehavior : DragStartBehavior, ?velocityTrackerBuilder : GestureVelocityTrackerBuilder, ?supportedDevices : Set) =
    inherit OneSequenceGestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type VerticalDragGestureRecognizer [<NamedParams>] (?debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit DragGestureRecognizer(jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type HorizontalDragGestureRecognizer [<NamedParams>] (?debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit DragGestureRecognizer(jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PanGestureRecognizer [<NamedParams>] (?debugOwner : Object, ?supportedDevices : Set) =
    inherit DragGestureRecognizer(jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type MultiDragPointerState (initialPosition : Offset, kind : PointerDeviceKind, gestureSettings : DeviceGestureSettings) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type MultiDragGestureRecognizer [<NamedParams>] (debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit GestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type ImmediateMultiDragGestureRecognizer [<NamedParams>] (?debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit MultiDragGestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type HorizontalMultiDragGestureRecognizer [<NamedParams>] (?debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit MultiDragGestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type VerticalMultiDragGestureRecognizer [<NamedParams>] (?debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit MultiDragGestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type DelayedMultiDragGestureRecognizer [<NamedParams>] (?delay : Duration, ?debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit MultiDragGestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type DoubleTapGestureRecognizer [<NamedParams>] (?debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit GestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type MultiTapGestureRecognizer [<NamedParams>] (?longTapDelay : Duration, ?debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit GestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type SerialTapDownDetails [<NamedParams>] (?globalPosition : Offset, ?localPosition : Offset, kind : PointerDeviceKind, ?buttons : int, ?count : int) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type SerialTapCancelDetails (?count : int) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type SerialTapUpDetails [<NamedParams>] (?globalPosition : Offset, ?localPosition : Offset, ?kind : PointerDeviceKind, ?count : int) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type SerialTapGestureRecognizer [<NamedParams>] (?debugOwner : Object, ?supportedDevices : Set) =
    inherit GestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerRouter () =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerSignalResolver () =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type GestureRecognizer [<NamedParams>] (?debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit GestureArenaMember()

  [<ImportMember("package:flutter/gestures.dart")>
  type OneSequenceGestureRecognizer [<NamedParams>] (?debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit GestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type PrimaryPointerGestureRecognizer [<NamedParams>] (?deadline : Duration, ?preAcceptSlopTolerance : double, ?postAcceptSlopTolerance : double, ?debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set) =
    inherit OneSequenceGestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type OffsetPair [<NamedParams>] (local : Offset, global : Offset) =
    static member fromEventPosition(event : PointerEvent) : OffsetPair = jsNative
    static member fromEventDelta(event : PointerEvent) : OffsetPair = jsNative

  [<ImportMember("package:flutter/gestures.dart")>
  type PointerEventResampler () =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type ScaleStartDetails [<NamedParams>] (?focalPoint : Offset, ?localFocalPoint : Offset, ?pointerCount : int) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type ScaleUpdateDetails [<NamedParams>] (?focalPoint : Offset, ?localFocalPoint : Offset, ?scale : double, ?horizontalScale : double, ?verticalScale : double, ?rotation : double, ?pointerCount : int, ?focalPointDelta : Offset) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type ScaleEndDetails [<NamedParams>] (?velocity : Velocity, ?pointerCount : int) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type ScaleGestureRecognizer [<NamedParams>] (?debugOwner : Object, ?kind : PointerDeviceKind, ?supportedDevices : Set, ?dragStartBehavior : DragStartBehavior) =
    inherit OneSequenceGestureRecognizer(jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type TapDownDetails [<NamedParams>] (?globalPosition : Offset, ?localPosition : Offset, ?kind : PointerDeviceKind) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type TapUpDetails [<NamedParams>] (kind : PointerDeviceKind, ?globalPosition : Offset, ?localPosition : Offset) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type BaseTapGestureRecognizer [<NamedParams>] (?debugOwner : Object, ?supportedDevices : Set) =
    inherit PrimaryPointerGestureRecognizer(jsNative, jsNative, jsNative, jsNative, jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type TapGestureRecognizer [<NamedParams>] (?debugOwner : Object, ?supportedDevices : Set) =
    inherit BaseTapGestureRecognizer(jsNative, jsNative)

  [<ImportMember("package:flutter/gestures.dart")>
  type GestureArenaTeam () =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type Velocity (pixelsPerSecond : Offset) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type VelocityEstimate [<NamedParams>] (pixelsPerSecond : Offset, confidence : double, duration : Duration, offset : Offset) =
    class end

  [<ImportMember("package:flutter/gestures.dart")>
  type VelocityTracker =
    static member withKind(kind : PointerDeviceKind) : VelocityTracker = jsNative

  [<ImportMember("package:flutter/gestures.dart")>
  type IOSScrollViewFlingVelocityTracker (kind : PointerDeviceKind) =
    inherit VelocityTracker(jsNative)
*)