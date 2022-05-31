namespace rec Flutter.Rendering

open System
open System.Collections.Generic
open Fable.Core
open Fable.Core.Dart
open Dart
open Flutter.Foundation
open Flutter.Gestures
open Flutter.Services
open Flutter.Painting
open Flutter.Animation
open Flutter.Scheduler
open Flutter.Semantics
open Flutter.Services

/// https://api.flutter.dev/flutter/rendering/KeepAliveParentDataMixin-mixin.html
[<ImportMember("package:flutter/rendering.dart")>]
type KeepAliveParentDataMixin =
  interface end

/// https://api.flutter.dev/flutter/rendering/RenderAnimatedSizeState.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAnimatedSizeState =
  [<IsConst>] static member start: RenderAnimatedSizeState = nativeOnly
  [<IsConst>] static member stable: RenderAnimatedSizeState = nativeOnly
  [<IsConst>] static member changed: RenderAnimatedSizeState = nativeOnly
  [<IsConst>] static member unstable: RenderAnimatedSizeState = nativeOnly
  [<IsConst>] static member values: RenderAnimatedSizeState = nativeOnly

/// https://api.flutter.dev/flutter/rendering/FlexFit.html
[<ImportMember("package:flutter/rendering.dart")>]
type FlexFit =
  [<IsConst>] static member tight: FlexFit = nativeOnly
  [<IsConst>] static member loose: FlexFit = nativeOnly
  [<IsConst>] static member values: FlexFit = nativeOnly

/// https://api.flutter.dev/flutter/rendering/MainAxisSize.html
[<ImportMember("package:flutter/rendering.dart")>]
type MainAxisSize =
  [<IsConst>] static member min: MainAxisSize = nativeOnly
  [<IsConst>] static member max: MainAxisSize = nativeOnly
  [<IsConst>] static member values: MainAxisSize = nativeOnly

/// https://api.flutter.dev/flutter/rendering/MainAxisAlignment.html
[<ImportMember("package:flutter/rendering.dart")>]
type MainAxisAlignment =
  [<IsConst>] static member start: MainAxisAlignment = nativeOnly
  [<IsConst>] static member ``end``: MainAxisAlignment = nativeOnly
  [<IsConst>] static member center: MainAxisAlignment = nativeOnly
  [<IsConst>] static member spaceBetween: MainAxisAlignment = nativeOnly
  [<IsConst>] static member spaceAround: MainAxisAlignment = nativeOnly
  [<IsConst>] static member spaceEvenly: MainAxisAlignment = nativeOnly
  [<IsConst>] static member values: MainAxisAlignment = nativeOnly

/// https://api.flutter.dev/flutter/rendering/CrossAxisAlignment.html
[<ImportMember("package:flutter/rendering.dart")>]
type CrossAxisAlignment =
  [<IsConst>] static member start: CrossAxisAlignment = nativeOnly
  [<IsConst>] static member ``end``: CrossAxisAlignment = nativeOnly
  [<IsConst>] static member center: CrossAxisAlignment = nativeOnly
  [<IsConst>] static member stretch: CrossAxisAlignment = nativeOnly
  [<IsConst>] static member baseline: CrossAxisAlignment = nativeOnly
  [<IsConst>] static member values: CrossAxisAlignment = nativeOnly

/// https://api.flutter.dev/flutter/rendering/PerformanceOverlayOption.html
[<ImportMember("package:flutter/rendering.dart")>]
type PerformanceOverlayOption =
  [<IsConst>] static member displayRasterizerStatistics: PerformanceOverlayOption = nativeOnly
  [<IsConst>] static member visualizeRasterizerStatistics: PerformanceOverlayOption = nativeOnly
  [<IsConst>] static member displayEngineStatistics: PerformanceOverlayOption = nativeOnly
  [<IsConst>] static member visualizeEngineStatistics: PerformanceOverlayOption = nativeOnly
  [<IsConst>] static member values: PerformanceOverlayOption = nativeOnly

/// https://api.flutter.dev/flutter/rendering/PlatformViewHitTestBehavior.html
[<ImportMember("package:flutter/rendering.dart")>]
type PlatformViewHitTestBehavior =
  [<IsConst>] static member opaque: PlatformViewHitTestBehavior = nativeOnly
  [<IsConst>] static member translucent: PlatformViewHitTestBehavior = nativeOnly
  [<IsConst>] static member transparent: PlatformViewHitTestBehavior = nativeOnly
  [<IsConst>] static member values: PlatformViewHitTestBehavior = nativeOnly

/// https://api.flutter.dev/flutter/rendering/HitTestBehavior.html
[<ImportMember("package:flutter/rendering.dart")>]
type HitTestBehavior =
  [<IsConst>] static member deferToChild: HitTestBehavior = nativeOnly
  [<IsConst>] static member opaque: HitTestBehavior = nativeOnly
  [<IsConst>] static member translucent: HitTestBehavior = nativeOnly
  [<IsConst>] static member values: HitTestBehavior = nativeOnly

/// https://api.flutter.dev/flutter/rendering/DecorationPosition.html
[<ImportMember("package:flutter/rendering.dart")>]
type DecorationPosition =
  [<IsConst>] static member background: DecorationPosition = nativeOnly
  [<IsConst>] static member foreground: DecorationPosition = nativeOnly
  [<IsConst>] static member values: DecorationPosition = nativeOnly

/// https://api.flutter.dev/flutter/rendering/GrowthDirection.html
[<ImportMember("package:flutter/rendering.dart")>]
type GrowthDirection =
  [<IsConst>] static member forward: GrowthDirection = nativeOnly
  [<IsConst>] static member reverse: GrowthDirection = nativeOnly
  [<IsConst>] static member values: GrowthDirection = nativeOnly

/// https://api.flutter.dev/flutter/rendering/StackFit.html
[<ImportMember("package:flutter/rendering.dart")>]
type StackFit =
  [<IsConst>] static member loose: StackFit = nativeOnly
  [<IsConst>] static member expand: StackFit = nativeOnly
  [<IsConst>] static member passthrough: StackFit = nativeOnly
  [<IsConst>] static member values: StackFit = nativeOnly

/// https://api.flutter.dev/flutter/rendering/TableCellVerticalAlignment.html
[<ImportMember("package:flutter/rendering.dart")>]
type TableCellVerticalAlignment =
  [<IsConst>] static member top: TableCellVerticalAlignment = nativeOnly
  [<IsConst>] static member middle: TableCellVerticalAlignment = nativeOnly
  [<IsConst>] static member bottom: TableCellVerticalAlignment = nativeOnly
  [<IsConst>] static member baseline: TableCellVerticalAlignment = nativeOnly
  [<IsConst>] static member fill: TableCellVerticalAlignment = nativeOnly
  [<IsConst>] static member values: TableCellVerticalAlignment = nativeOnly

/// https://api.flutter.dev/flutter/rendering/CacheExtentStyle.html
[<ImportMember("package:flutter/rendering.dart")>]
type CacheExtentStyle =
  [<IsConst>] static member pixel: CacheExtentStyle = nativeOnly
  [<IsConst>] static member viewport: CacheExtentStyle = nativeOnly
  [<IsConst>] static member values: CacheExtentStyle = nativeOnly

/// https://api.flutter.dev/flutter/rendering/ScrollDirection.html
[<ImportMember("package:flutter/rendering.dart")>]
type ScrollDirection =
  [<IsConst>] static member idle: ScrollDirection = nativeOnly
  [<IsConst>] static member forward: ScrollDirection = nativeOnly
  [<IsConst>] static member reverse: ScrollDirection = nativeOnly
  [<IsConst>] static member values: ScrollDirection = nativeOnly

/// https://api.flutter.dev/flutter/rendering/WrapAlignment.html
[<ImportMember("package:flutter/rendering.dart")>]
type WrapAlignment =
  [<IsConst>] static member start: WrapAlignment = nativeOnly
  [<IsConst>] static member ``end``: WrapAlignment = nativeOnly
  [<IsConst>] static member center: WrapAlignment = nativeOnly
  [<IsConst>] static member spaceBetween: WrapAlignment = nativeOnly
  [<IsConst>] static member spaceAround: WrapAlignment = nativeOnly
  [<IsConst>] static member spaceEvenly: WrapAlignment = nativeOnly
  [<IsConst>] static member values: WrapAlignment = nativeOnly

/// https://api.flutter.dev/flutter/rendering/WrapCrossAlignment.html
[<ImportMember("package:flutter/rendering.dart")>]
type WrapCrossAlignment =
  [<IsConst>] static member start: WrapCrossAlignment = nativeOnly
  [<IsConst>] static member ``end``: WrapCrossAlignment = nativeOnly
  [<IsConst>] static member center: WrapCrossAlignment = nativeOnly
  [<IsConst>] static member values: WrapCrossAlignment = nativeOnly

/// https://api.flutter.dev/flutter/rendering/RenderAnimatedSize-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAnimatedSize [<NamedParams>] (vsync: TickerProvider, duration: TimeSpan, ?reverseDuration: TimeSpan, ?curve: Curve, ?alignment: AlignmentGeometry, ?textDirection: TextDirection, ?child: RenderBox, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderingFlutterBinding-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderingFlutterBinding [<NamedParams>] (?root: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/BoxConstraints-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type BoxConstraints [<IsConst; NamedParams>] (?minWidth: float, ?maxWidth: float, ?minHeight: float, ?maxHeight: float) =
  static member tight(size: Size): BoxConstraints = nativeOnly
  [<IsConst; NamedParams>] static member tightFor(?width: float, ?height: float): BoxConstraints = nativeOnly
  [<IsConst; NamedParams>] static member tightForFinite(?width: float, ?height: float): BoxConstraints = nativeOnly
  static member loose(size: Size): BoxConstraints = nativeOnly
  [<IsConst; NamedParams>] static member expand(?width: float, ?height: float): BoxConstraints = nativeOnly

/// https://api.flutter.dev/flutter/rendering/BoxHitTestResult-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type BoxHitTestResult () =
  static member wrap(result: HitTestResult): BoxHitTestResult = nativeOnly

/// https://api.flutter.dev/flutter/rendering/BoxHitTestEntry-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type BoxHitTestEntry (target: RenderBox, localPosition: Offset) =
  class end

/// https://api.flutter.dev/flutter/rendering/BoxParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type BoxParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/ContainerBoxParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ContainerBoxParentData<'ChildType> () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderBox () =
  class end

/// https://api.flutter.dev/flutter/rendering/MultiChildLayoutParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type MultiChildLayoutParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/MultiChildLayoutDelegate-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type MultiChildLayoutDelegate [<NamedParams>] (?relayout: Listenable) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderCustomMultiChildLayoutBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderCustomMultiChildLayoutBox [<NamedParams>] (``delegate``: MultiChildLayoutDelegate, ?children: RenderBox[]) =
  class end

/// https://api.flutter.dev/flutter/rendering/CustomPainter-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type CustomPainter [<IsConst; NamedParams>] (?repaint: Listenable) =
  class end

/// https://api.flutter.dev/flutter/rendering/CustomPainterSemantics-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type CustomPainterSemantics [<IsConst; NamedParams>] (rect: Rect, properties: SemanticsProperties, ?key: Key, ?transform: Matrix4, ?tags: HashSet<SemanticsTag>) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderCustomPaint-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderCustomPaint [<NamedParams>] (?painter: CustomPainter, ?foregroundPainter: CustomPainter, ?preferredSize: Size, ?isComplex: bool, ?willChange: bool, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/TextSelectionPoint-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type TextSelectionPoint [<IsConst>] (point: Offset, direction: TextDirection option) =
  class end

/// https://api.flutter.dev/flutter/rendering/VerticalCaretMovementRun-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type VerticalCaretMovementRun =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderEditable-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderEditable [<NamedParams>] (textDirection: TextDirection, startHandleLayerLink: LayerLink, endHandleLayerLink: LayerLink, offset: ViewportOffset, (*textSelectionDelegate: TextSelectionDelegate,*) ?text: InlineSpan, ?textAlign: TextAlign, ?cursorColor: Color, ?backgroundCursorColor: Color, ?showCursor: ValueNotifier<bool>, ?hasFocus: bool, ?maxLines: int, ?minLines: int, ?expands: bool, ?strutStyle: StrutStyle, ?selectionColor: Color, ?textScaleFactor: float, ?selection: TextSelection, ?onCaretChanged: (Rect -> unit), ?ignorePointer: bool, ?readOnly: bool, ?forceLine: bool, ?textHeightBehavior: TextHeightBehavior, ?textWidthBasis: TextWidthBasis, ?obscuringCharacter: string, ?obscureText: bool, ?locale: Locale, ?cursorWidth: float, ?cursorHeight: float, ?cursorRadius: Radius, ?paintCursorAboveText: bool, ?cursorOffset: Offset, ?devicePixelRatio: float, ?selectionHeightStyle: BoxHeightStyle, ?selectionWidthStyle: BoxWidthStyle, ?enableInteractiveSelection: bool, ?floatingCursorAddedMargin: EdgeInsets, ?promptRectRange: TextRange, ?promptRectColor: Color, ?clipBehavior: Clip, ?painter: RenderEditablePainter, ?foregroundPainter: RenderEditablePainter, ?children: RenderBox[]) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderEditablePainter-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderEditablePainter () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderErrorBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderErrorBox (?message: string) =
  class end

/// https://api.flutter.dev/flutter/rendering/FlexParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FlexParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderFlex-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderFlex [<NamedParams>] (?children: RenderBox[], ?direction: Axis, ?mainAxisSize: MainAxisSize, ?mainAxisAlignment: MainAxisAlignment, ?crossAxisAlignment: CrossAxisAlignment, ?textDirection: TextDirection, ?verticalDirection: VerticalDirection, ?textBaseline: TextBaseline, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/FlowPaintingContext-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FlowPaintingContext () =
  class end

/// https://api.flutter.dev/flutter/rendering/FlowDelegate-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FlowDelegate [<IsConst; NamedParams>] (?repaint: Listenable) =
  class end

/// https://api.flutter.dev/flutter/rendering/FlowParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FlowParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderFlow-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderFlow [<NamedParams>] (``delegate``: FlowDelegate, ?children: RenderBox[], ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderImage-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderImage [<NamedParams>] (?image: Image, ?debugImageLabel: string, ?width: float, ?height: float, ?scale: float, ?color: Color, ?opacity: Animation<float>, ?colorBlendMode: BlendMode, ?fit: BoxFit, ?alignment: AlignmentGeometry, ?repeat: ImageRepeat, ?centerSlice: Rect, ?matchTextDirection: bool, ?textDirection: TextDirection, ?invertColors: bool, ?isAntiAlias: bool, ?filterQuality: FilterQuality) =
  class end

/// https://api.flutter.dev/flutter/rendering/AnnotationEntry-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type AnnotationEntry<'T> [<IsConst; NamedParams>] (annotation: 'T, localPosition: Offset) =
  class end

/// https://api.flutter.dev/flutter/rendering/AnnotationResult-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type AnnotationResult<'T> () =
  class end

/// https://api.flutter.dev/flutter/rendering/Layer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type Layer () =
  class end

/// https://api.flutter.dev/flutter/rendering/LayerHandle-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type LayerHandle<'T> (?_layer: 'T) =
  class end

/// https://api.flutter.dev/flutter/rendering/PictureLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type PictureLayer (canvasBounds: Rect) =
  class end

/// https://api.flutter.dev/flutter/rendering/TextureLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type TextureLayer [<NamedParams>] (rect: Rect, textureId: int, ?freeze: bool, ?filterQuality: FilterQuality) =
  class end

/// https://api.flutter.dev/flutter/rendering/PlatformViewLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type PlatformViewLayer [<NamedParams>] (rect: Rect, viewId: int) =
  class end

/// https://api.flutter.dev/flutter/rendering/PerformanceOverlayLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type PerformanceOverlayLayer [<NamedParams>] (overlayRect: Rect, optionsMask: int, rasterizerThreshold: int, checkerboardRasterCacheImages: bool, checkerboardOffscreenLayers: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/ContainerLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ContainerLayer () =
  class end

/// https://api.flutter.dev/flutter/rendering/OffsetLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type OffsetLayer [<NamedParams>] (?offset: Offset) =
  class end

/// https://api.flutter.dev/flutter/rendering/ClipRectLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ClipRectLayer [<NamedParams>] (?clipRect: Rect, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/ClipRRectLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ClipRRectLayer [<NamedParams>] (?clipRRect: RRect, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/ClipPathLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ClipPathLayer [<NamedParams>] (?clipPath: Path, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/ColorFilterLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ColorFilterLayer [<NamedParams>] (?colorFilter: ColorFilter) =
  class end

/// https://api.flutter.dev/flutter/rendering/ImageFilterLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ImageFilterLayer [<NamedParams>] (?imageFilter: ImageFilter) =
  class end

/// https://api.flutter.dev/flutter/rendering/TransformLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type TransformLayer [<NamedParams>] (?transform: Matrix4, ?offset: Offset) =
  class end

/// https://api.flutter.dev/flutter/rendering/OpacityLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type OpacityLayer [<NamedParams>] (?alpha: int, ?offset: Offset) =
  class end

/// https://api.flutter.dev/flutter/rendering/ShaderMaskLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ShaderMaskLayer [<NamedParams>] (?shader: Shader, ?maskRect: Rect, ?blendMode: BlendMode) =
  class end

/// https://api.flutter.dev/flutter/rendering/BackdropFilterLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type BackdropFilterLayer [<NamedParams>] (?filter: ImageFilter, ?blendMode: BlendMode) =
  class end

/// https://api.flutter.dev/flutter/rendering/PhysicalModelLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type PhysicalModelLayer [<NamedParams>] (?clipPath: Path, ?clipBehavior: Clip, ?elevation: float, ?color: Color, ?shadowColor: Color) =
  class end

/// https://api.flutter.dev/flutter/rendering/LayerLink-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type LayerLink () =
  class end

/// https://api.flutter.dev/flutter/rendering/LeaderLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type LeaderLayer [<NamedParams>] (link: LayerLink, ?offset: Offset) =
  class end

/// https://api.flutter.dev/flutter/rendering/FollowerLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FollowerLayer [<NamedParams>] (link: LayerLink, ?showWhenUnlinked: bool, ?unlinkedOffset: Offset, ?linkedOffset: Offset) =
  class end

/// https://api.flutter.dev/flutter/rendering/AnnotatedRegionLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type AnnotatedRegionLayer<'T> [<NamedParams(fromIndex=1)>] (value: 'T, ?size: Size, ?offset: Offset, ?opaque: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/ChildLayoutHelper-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ChildLayoutHelper =
  class end

/// https://api.flutter.dev/flutter/rendering/ListBodyParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ListBodyParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderListBody-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderListBody [<NamedParams>] (?children: RenderBox[], ?axisDirection: AxisDirection) =
  class end

/// https://api.flutter.dev/flutter/rendering/ListWheelChildManager-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ListWheelChildManager () =
  class end

/// https://api.flutter.dev/flutter/rendering/ListWheelParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ListWheelParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderListWheelViewport-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderListWheelViewport [<NamedParams>] (childManager: ListWheelChildManager, offset: ViewportOffset, itemExtent: float, ?diameterRatio: float, ?perspective: float, ?offAxisFraction: float, ?useMagnifier: bool, ?magnification: float, ?overAndUnderCenterOpacity: float, ?squeeze: float, ?renderChildrenOutsideViewport: bool, ?clipBehavior: Clip, ?children: RenderBox[]) =
  [<IsConst>] static member defaultDiameterRatio: float = nativeOnly
  [<IsConst>] static member defaultPerspective: float = nativeOnly
  [<IsConst>] static member diameterRatioZeroMessage: string = nativeOnly
  [<IsConst>] static member perspectiveTooHighMessage: string = nativeOnly
  [<IsConst>] static member clipBehaviorAndRenderChildrenOutsideViewportConflict: string = nativeOnly

/// https://api.flutter.dev/flutter/rendering/MouseTracker-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type MouseTracker () =
  class end

/// https://api.flutter.dev/flutter/rendering/ParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/PaintingContext-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type PaintingContext (_containerLayer: ContainerLayer, estimatedBounds: Rect) =
  class end

/// https://api.flutter.dev/flutter/rendering/Constraints-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type Constraints [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/rendering/SemanticsHandle-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SemanticsHandle =
  class end

/// https://api.flutter.dev/flutter/rendering/PipelineOwner-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type PipelineOwner [<NamedParams>] (?onNeedVisualUpdate: (unit -> unit), ?onSemanticsOwnerCreated: (unit -> unit), ?onSemanticsOwnerDisposed: (unit -> unit)) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderObject-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderObject () =
  class end

/// https://api.flutter.dev/flutter/rendering/DiagnosticsDebugCreator-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type DiagnosticsDebugCreator (value: obj) =
  class end

/// https://api.flutter.dev/flutter/rendering/TextParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type TextParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/PlaceholderSpanIndexSemanticsTag-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type PlaceholderSpanIndexSemanticsTag [<IsConst>] (index: int) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderParagraph-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderParagraph [<NamedParams(fromIndex=1)>] (text: InlineSpan, textDirection: TextDirection, ?textAlign: TextAlign, ?softWrap: bool, ?overflow: TextOverflow, ?textScaleFactor: float, ?maxLines: int, ?locale: Locale, ?strutStyle: StrutStyle, ?textWidthBasis: TextWidthBasis, ?textHeightBehavior: TextHeightBehavior, ?children: RenderBox[]) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderPerformanceOverlay-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderPerformanceOverlay [<NamedParams>] (?optionsMask: int, ?rasterizerThreshold: int, ?checkerboardRasterCacheImages: bool, ?checkerboardOffscreenLayers: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderAndroidView-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAndroidView [<NamedParams>] (viewController: AndroidViewController, hitTestBehavior: PlatformViewHitTestBehavior, gestureRecognizers: HashSet<Factory<OneSequenceGestureRecognizer>>, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderUiKitView-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderUiKitView [<NamedParams>] (viewController: UiKitViewController, hitTestBehavior: PlatformViewHitTestBehavior, gestureRecognizers: HashSet<Factory<OneSequenceGestureRecognizer>>) =
  class end

/// https://api.flutter.dev/flutter/rendering/PlatformViewRenderBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type PlatformViewRenderBox [<NamedParams>] (controller: PlatformViewController, hitTestBehavior: PlatformViewHitTestBehavior, gestureRecognizers: HashSet<Factory<OneSequenceGestureRecognizer>>) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderProxyBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderProxyBox (?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderProxyBoxWithHitTestBehavior-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderProxyBoxWithHitTestBehavior [<NamedParams>] (?behavior: HitTestBehavior, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderConstrainedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderConstrainedBox [<NamedParams>] (additionalConstraints: BoxConstraints, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderLimitedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderLimitedBox [<NamedParams>] (?child: RenderBox, ?maxWidth: float, ?maxHeight: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderAspectRatio-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAspectRatio [<NamedParams>] (aspectRatio: float, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderIntrinsicWidth-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderIntrinsicWidth [<NamedParams>] (?stepWidth: float, ?stepHeight: float, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderIntrinsicHeight-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderIntrinsicHeight [<NamedParams>] (?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderOpacity-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderOpacity [<NamedParams>] (?opacity: float, ?alwaysIncludeSemantics: bool, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderAnimatedOpacity-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAnimatedOpacity [<NamedParams>] (opacity: Animation<float>, ?alwaysIncludeSemantics: bool, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderShaderMask-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderShaderMask [<NamedParams>] (shaderCallback: (Rect -> Shader), ?child: RenderBox, ?blendMode: BlendMode) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderBackdropFilter-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderBackdropFilter [<NamedParams>] (filter: ImageFilter, ?child: RenderBox, ?blendMode: BlendMode) =
  class end

/// https://api.flutter.dev/flutter/rendering/CustomClipper-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type CustomClipper<'T> [<IsConst; NamedParams>] (?reclip: Listenable) =
  class end

/// https://api.flutter.dev/flutter/rendering/ShapeBorderClipper-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ShapeBorderClipper [<IsConst; NamedParams>] (shape: ShapeBorder, ?textDirection: TextDirection) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderClipRect-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderClipRect [<NamedParams>] (?child: RenderBox, ?clipper: CustomClipper<Rect>, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderClipRRect-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderClipRRect [<NamedParams>] (?child: RenderBox, ?borderRadius: BorderRadius, ?clipper: CustomClipper<RRect>, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderClipOval-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderClipOval [<NamedParams>] (?child: RenderBox, ?clipper: CustomClipper<Rect>, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderClipPath-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderClipPath [<NamedParams>] (?child: RenderBox, ?clipper: CustomClipper<Path>, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderPhysicalModel-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderPhysicalModel [<NamedParams>] (color: Color, ?child: RenderBox, ?shape: BoxShape, ?clipBehavior: Clip, ?borderRadius: BorderRadius, ?elevation: float, ?shadowColor: Color) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderPhysicalShape-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderPhysicalShape [<NamedParams>] (clipper: CustomClipper<Path>, color: Color, ?child: RenderBox, ?clipBehavior: Clip, ?elevation: float, ?shadowColor: Color) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderDecoratedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderDecoratedBox [<NamedParams>] (decoration: Decoration, ?position: DecorationPosition, ?configuration: ImageConfiguration, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderTransform-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderTransform [<NamedParams>] (transform: Matrix4, ?origin: Offset, ?alignment: AlignmentGeometry, ?textDirection: TextDirection, ?transformHitTests: bool, ?filterQuality: FilterQuality, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderFittedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderFittedBox [<NamedParams>] (?fit: BoxFit, ?alignment: AlignmentGeometry, ?textDirection: TextDirection, ?child: RenderBox, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderFractionalTranslation-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderFractionalTranslation [<NamedParams>] (translation: Offset, ?transformHitTests: bool, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderPointerListener-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderPointerListener [<NamedParams>] (?onPointerDown: (PointerDownEvent -> unit), ?onPointerMove: (PointerMoveEvent -> unit), ?onPointerUp: (PointerUpEvent -> unit), ?onPointerHover: (PointerHoverEvent -> unit), ?onPointerCancel: (PointerCancelEvent -> unit), ?onPointerSignal: (PointerSignalEvent -> unit), ?behavior: HitTestBehavior, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderMouseRegion-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderMouseRegion [<NamedParams>] (?onEnter: (PointerEnterEvent -> unit), ?onHover: (PointerHoverEvent -> unit), ?onExit: (PointerExitEvent -> unit), ?cursor: MouseCursor, ?validForMouseTracker: bool, ?opaque: bool, ?child: RenderBox, ?hitTestBehavior: HitTestBehavior) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderRepaintBoundary-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderRepaintBoundary [<NamedParams>] (?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderIgnorePointer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderIgnorePointer [<NamedParams>] (?child: RenderBox, ?ignoring: bool, ?ignoringSemantics: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderOffstage-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderOffstage [<NamedParams>] (?offstage: bool, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderAbsorbPointer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAbsorbPointer [<NamedParams>] (?child: RenderBox, ?absorbing: bool, ?ignoringSemantics: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderMetaData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderMetaData [<NamedParams>] (?metaData: obj, ?behavior: HitTestBehavior, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSemanticsGestureHandler-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSemanticsGestureHandler [<NamedParams>] (?child: RenderBox, ?onTap: (unit -> unit), ?onLongPress: (unit -> unit), ?onHorizontalDragUpdate: (DragUpdateDetails -> unit), ?onVerticalDragUpdate: (DragUpdateDetails -> unit), ?scrollFactor: float, ?behavior: HitTestBehavior) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSemanticsAnnotations-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSemanticsAnnotations [<NamedParams>] (?child: RenderBox, ?container: bool, ?explicitChildNodes: bool, ?excludeSemantics: bool, ?enabled: bool, ?``checked``: bool, ?toggled: bool, ?selected: bool, ?button: bool, ?slider: bool, ?keyboardKey: bool, ?link: bool, ?header: bool, ?textField: bool, ?readOnly: bool, ?focusable: bool, ?focused: bool, ?inMutuallyExclusiveGroup: bool, ?obscured: bool, ?multiline: bool, ?scopesRoute: bool, ?namesRoute: bool, ?hidden: bool, ?image: bool, ?liveRegion: bool, ?maxValueLength: int, ?currentValueLength: int, ?attributedLabel: AttributedString, ?attributedValue: AttributedString, ?attributedIncreasedValue: AttributedString, ?attributedDecreasedValue: AttributedString, ?attributedHint: AttributedString, ?hintOverrides: SemanticsHintOverrides, ?textDirection: TextDirection, ?sortKey: SemanticsSortKey, ?tagForChildren: SemanticsTag, ?onTap: (unit -> unit), ?onDismiss: (unit -> unit), ?onLongPress: (unit -> unit), ?onScrollLeft: (unit -> unit), ?onScrollRight: (unit -> unit), ?onScrollUp: (unit -> unit), ?onScrollDown: (unit -> unit), ?onIncrease: (unit -> unit), ?onDecrease: (unit -> unit), ?onCopy: (unit -> unit), ?onCut: (unit -> unit), ?onPaste: (unit -> unit), ?onMoveCursorForwardByCharacter: (bool -> unit), ?onMoveCursorBackwardByCharacter: (bool -> unit), ?onMoveCursorForwardByWord: (bool -> unit), ?onMoveCursorBackwardByWord: (bool -> unit), ?onSetSelection: (TextSelection -> unit), ?onSetText: (string -> unit), ?onDidGainAccessibilityFocus: (unit -> unit), ?onDidLoseAccessibilityFocus: (unit -> unit), ?customSemanticsActions: Dictionary<CustomSemanticsAction, (unit -> unit)>) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderBlockSemantics-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderBlockSemantics [<NamedParams>] (?child: RenderBox, ?blocking: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderMergeSemantics-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderMergeSemantics [<NamedParams>] (?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderExcludeSemantics-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderExcludeSemantics [<NamedParams>] (?child: RenderBox, ?excluding: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderIndexedSemantics-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderIndexedSemantics [<NamedParams>] (index: int, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderLeaderLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderLeaderLayer [<NamedParams>] (link: LayerLink, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderFollowerLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderFollowerLayer [<NamedParams>] (link: LayerLink, ?showWhenUnlinked: bool, ?offset: Offset, ?leaderAnchor: Alignment, ?followerAnchor: Alignment, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderAnnotatedRegion-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAnnotatedRegion<'T> [<NamedParams>] (value: 'T, sized: bool, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderProxySliver-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderProxySliver (?child: RenderSliver) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverOpacity-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverOpacity [<NamedParams>] (?opacity: float, ?alwaysIncludeSemantics: bool, ?sliver: RenderSliver) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverIgnorePointer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverIgnorePointer [<NamedParams>] (?sliver: RenderSliver, ?ignoring: bool, ?ignoringSemantics: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverOffstage-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverOffstage [<NamedParams>] (?offstage: bool, ?sliver: RenderSliver) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverAnimatedOpacity-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverAnimatedOpacity [<NamedParams>] (opacity: Animation<float>, ?alwaysIncludeSemantics: bool, ?sliver: RenderSliver) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderRotatedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderRotatedBox [<NamedParams>] (quarterTurns: int, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderShiftedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderShiftedBox (child: RenderBox option) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderPadding-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderPadding [<NamedParams>] (padding: EdgeInsetsGeometry, ?textDirection: TextDirection, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderAligningShiftedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAligningShiftedBox [<NamedParams>] (textDirection: TextDirection option, ?alignment: AlignmentGeometry, ?child: RenderBox) =
  static member ``mixin``(alignment: AlignmentGeometry, textDirection: TextDirection option, child: RenderBox option): RenderAligningShiftedBox = nativeOnly

/// https://api.flutter.dev/flutter/rendering/RenderPositionedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderPositionedBox [<NamedParams>] (?child: RenderBox, ?widthFactor: float, ?heightFactor: float, ?alignment: AlignmentGeometry, ?textDirection: TextDirection) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderConstrainedOverflowBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderConstrainedOverflowBox [<NamedParams>] (?child: RenderBox, ?minWidth: float, ?maxWidth: float, ?minHeight: float, ?maxHeight: float, ?alignment: AlignmentGeometry, ?textDirection: TextDirection) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderConstraintsTransformBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderConstraintsTransformBox [<NamedParams>] (alignment: AlignmentGeometry, textDirection: TextDirection option, constraintsTransform: (BoxConstraints -> BoxConstraints), ?child: RenderBox, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderUnconstrainedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderUnconstrainedBox [<NamedParams>] (alignment: AlignmentGeometry, textDirection: TextDirection option, ?constrainedAxis: Axis, ?child: RenderBox, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSizedOverflowBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSizedOverflowBox [<NamedParams>] (requestedSize: Size, ?child: RenderBox, ?alignment: AlignmentGeometry, ?textDirection: TextDirection) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderFractionallySizedOverflowBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderFractionallySizedOverflowBox [<NamedParams>] (?child: RenderBox, ?widthFactor: float, ?heightFactor: float, ?alignment: AlignmentGeometry, ?textDirection: TextDirection) =
  class end

/// https://api.flutter.dev/flutter/rendering/SingleChildLayoutDelegate-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SingleChildLayoutDelegate [<IsConst; NamedParams>] (?relayout: Listenable) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderCustomSingleChildLayoutBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderCustomSingleChildLayoutBox [<NamedParams>] (``delegate``: SingleChildLayoutDelegate, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderBaseline-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderBaseline [<NamedParams>] (baseline: float, baselineType: TextBaseline, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverConstraints-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverConstraints [<IsConst; NamedParams>] (axisDirection: AxisDirection, growthDirection: GrowthDirection, userScrollDirection: ScrollDirection, scrollOffset: float, precedingScrollExtent: float, overlap: float, remainingPaintExtent: float, crossAxisExtent: float, crossAxisDirection: AxisDirection, viewportMainAxisExtent: float, remainingCacheExtent: float, cacheOrigin: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverGeometry-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverGeometry [<IsConst; NamedParams>] (?scrollExtent: float, ?paintExtent: float, ?paintOrigin: float, ?layoutExtent: float, ?maxPaintExtent: float, ?maxScrollObstructionExtent: float, ?hitTestExtent: float, ?visible: bool, ?hasVisualOverflow: bool, ?scrollOffsetCorrection: float, ?cacheExtent: float) =
  [<IsConst>] static member zero: SliverGeometry = nativeOnly

/// https://api.flutter.dev/flutter/rendering/SliverHitTestResult-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverHitTestResult () =
  static member wrap(result: HitTestResult): SliverHitTestResult = nativeOnly

/// https://api.flutter.dev/flutter/rendering/SliverHitTestEntry-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverHitTestEntry [<NamedParams(fromIndex=1)>] (target: RenderSliver, mainAxisPosition: float, crossAxisPosition: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverLogicalParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverLogicalParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverLogicalContainerParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverLogicalContainerParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverPhysicalParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverPhysicalParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverPhysicalContainerParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverPhysicalContainerParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliver-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliver () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverSingleBoxAdapter-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverSingleBoxAdapter [<NamedParams>] (?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverToBoxAdapter-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverToBoxAdapter [<NamedParams>] (?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFillViewport-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFillViewport [<NamedParams>] (childManager: RenderSliverBoxChildManager, ?viewportFraction: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFillRemainingWithScrollable-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFillRemainingWithScrollable [<NamedParams>] (?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFillRemaining-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFillRemaining [<NamedParams>] (?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFillRemainingAndOverscroll-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFillRemainingAndOverscroll [<NamedParams>] (?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFixedExtentBoxAdaptor-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFixedExtentBoxAdaptor [<NamedParams>] (childManager: RenderSliverBoxChildManager) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFixedExtentList-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFixedExtentList [<NamedParams>] (childManager: RenderSliverBoxChildManager, itemExtent: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverGridGeometry-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverGridGeometry [<IsConst; NamedParams>] (scrollOffset: float, crossAxisOffset: float, mainAxisExtent: float, crossAxisExtent: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverGridLayout-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverGridLayout [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverGridRegularTileLayout-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverGridRegularTileLayout [<IsConst; NamedParams>] (crossAxisCount: int, mainAxisStride: float, crossAxisStride: float, childMainAxisExtent: float, childCrossAxisExtent: float, reverseCrossAxis: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverGridDelegate-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverGridDelegate [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverGridDelegateWithFixedCrossAxisCount-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverGridDelegateWithFixedCrossAxisCount [<IsConst; NamedParams>] (crossAxisCount: int, ?mainAxisSpacing: float, ?crossAxisSpacing: float, ?childAspectRatio: float, ?mainAxisExtent: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverGridDelegateWithMaxCrossAxisExtent-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverGridDelegateWithMaxCrossAxisExtent [<IsConst; NamedParams>] (maxCrossAxisExtent: float, ?mainAxisSpacing: float, ?crossAxisSpacing: float, ?childAspectRatio: float, ?mainAxisExtent: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverGridParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverGridParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverGrid-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverGrid [<NamedParams>] (childManager: RenderSliverBoxChildManager, gridDelegate: SliverGridDelegate) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverList-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverList [<NamedParams>] (childManager: RenderSliverBoxChildManager) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverBoxChildManager-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverBoxChildManager () =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverMultiBoxAdaptorParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverMultiBoxAdaptorParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverMultiBoxAdaptor-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverMultiBoxAdaptor [<NamedParams>] (childManager: RenderSliverBoxChildManager) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverEdgeInsetsPadding-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverEdgeInsetsPadding () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverPadding-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverPadding [<NamedParams>] (padding: EdgeInsetsGeometry, ?textDirection: TextDirection, ?child: RenderSliver) =
  class end

/// https://api.flutter.dev/flutter/rendering/OverScrollHeaderStretchConfiguration-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type OverScrollHeaderStretchConfiguration [<NamedParams>] (?stretchTriggerOffset: float, ?onStretchTrigger: (unit -> Future<unit>)) =
  class end

/// https://api.flutter.dev/flutter/rendering/PersistentHeaderShowOnScreenConfiguration-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type PersistentHeaderShowOnScreenConfiguration [<IsConst; NamedParams>] (?minShowOnScreenExtent: float, ?maxShowOnScreenExtent: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverPersistentHeader-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverPersistentHeader [<NamedParams>] (?child: RenderBox, ?stretchConfiguration: OverScrollHeaderStretchConfiguration) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverScrollingPersistentHeader-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverScrollingPersistentHeader [<NamedParams>] (?child: RenderBox, ?stretchConfiguration: OverScrollHeaderStretchConfiguration) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverPinnedPersistentHeader-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverPinnedPersistentHeader [<NamedParams>] (?child: RenderBox, ?stretchConfiguration: OverScrollHeaderStretchConfiguration, ?showOnScreenConfiguration: PersistentHeaderShowOnScreenConfiguration) =
  class end

/// https://api.flutter.dev/flutter/rendering/FloatingHeaderSnapConfiguration-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FloatingHeaderSnapConfiguration [<NamedParams>] (?curve: Curve, ?duration: TimeSpan) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFloatingPersistentHeader-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFloatingPersistentHeader [<NamedParams>] (showOnScreenConfiguration: PersistentHeaderShowOnScreenConfiguration option, ?child: RenderBox, ?vsync: TickerProvider, ?snapConfiguration: FloatingHeaderSnapConfiguration, ?stretchConfiguration: OverScrollHeaderStretchConfiguration) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFloatingPinnedPersistentHeader-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFloatingPinnedPersistentHeader [<NamedParams>] (?child: RenderBox, ?vsync: TickerProvider, ?snapConfiguration: FloatingHeaderSnapConfiguration, ?stretchConfiguration: OverScrollHeaderStretchConfiguration, ?showOnScreenConfiguration: PersistentHeaderShowOnScreenConfiguration) =
  class end

/// https://api.flutter.dev/flutter/rendering/RelativeRect-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RelativeRect =
  [<IsConst>] static member fromLTRB(left: float, top: float, right: float, bottom: float): RelativeRect = nativeOnly
  static member fromSize(rect: Rect, container: Size): RelativeRect = nativeOnly
  static member fromRect(rect: Rect, container: Rect): RelativeRect = nativeOnly
  [<IsConst>] static member fill: RelativeRect = nativeOnly

/// https://api.flutter.dev/flutter/rendering/StackParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type StackParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderStack-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderStack [<NamedParams>] (?children: RenderBox[], ?alignment: AlignmentGeometry, ?textDirection: TextDirection, ?fit: StackFit, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderIndexedStack-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderIndexedStack [<NamedParams>] (?children: RenderBox[], ?alignment: AlignmentGeometry, ?textDirection: TextDirection, ?index: int) =
  class end

/// https://api.flutter.dev/flutter/rendering/TableCellParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type TableCellParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/TableColumnWidth-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type TableColumnWidth [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/rendering/IntrinsicColumnWidth-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type IntrinsicColumnWidth [<IsConst; NamedParams>] (?flex: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/FixedColumnWidth-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FixedColumnWidth [<IsConst>] (value: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/FractionColumnWidth-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FractionColumnWidth [<IsConst>] (value: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/FlexColumnWidth-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FlexColumnWidth [<IsConst>] (?value: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/MaxColumnWidth-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type MaxColumnWidth [<IsConst>] (a: TableColumnWidth, b: TableColumnWidth) =
  class end

/// https://api.flutter.dev/flutter/rendering/MinColumnWidth-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type MinColumnWidth [<IsConst>] (a: TableColumnWidth, b: TableColumnWidth) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderTable-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderTable [<NamedParams>] (textDirection: TextDirection, ?columns: int, ?rows: int, ?columnWidths: Dictionary<int, TableColumnWidth>, ?defaultColumnWidth: TableColumnWidth, ?border: TableBorder, ?rowDecorations: Decoration option[], ?configuration: ImageConfiguration, ?defaultVerticalAlignment: TableCellVerticalAlignment, ?textBaseline: TextBaseline, ?children: RenderBox[][]) =
  class end

/// https://api.flutter.dev/flutter/rendering/TableBorder-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type TableBorder [<IsConst; NamedParams>] (?top: BorderSide, ?right: BorderSide, ?bottom: BorderSide, ?left: BorderSide, ?horizontalInside: BorderSide, ?verticalInside: BorderSide, ?borderRadius: BorderRadius) =
  [<NamedParams>] static member all(?color: Color, ?width: float, ?style: BorderStyle, ?borderRadius: BorderRadius): TableBorder = nativeOnly
  [<NamedParams>] static member symmetric(?inside: BorderSide, ?outside: BorderSide): TableBorder = nativeOnly

/// https://api.flutter.dev/flutter/rendering/TextureBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type TextureBox [<NamedParams>] (textureId: int, ?freeze: bool, ?filterQuality: FilterQuality) =
  class end

/// https://api.flutter.dev/flutter/rendering/FractionalOffsetTween-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FractionalOffsetTween [<NamedParams>] (?``begin``: FractionalOffset, ?``end``: FractionalOffset) =
  class end

/// https://api.flutter.dev/flutter/rendering/AlignmentTween-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type AlignmentTween [<NamedParams>] (?``begin``: Alignment, ?``end``: Alignment) =
  class end

/// https://api.flutter.dev/flutter/rendering/AlignmentGeometryTween-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type AlignmentGeometryTween [<NamedParams>] (?``begin``: AlignmentGeometry, ?``end``: AlignmentGeometry) =
  class end

/// https://api.flutter.dev/flutter/rendering/ViewConfiguration-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ViewConfiguration [<IsConst; NamedParams>] (?size: Size, ?devicePixelRatio: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderView-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderView [<NamedParams>] (configuration: ViewConfiguration, window: FlutterView, ?child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderAbstractViewport-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAbstractViewport =
  [<IsConst>] static member defaultCacheExtent: float = nativeOnly

/// https://api.flutter.dev/flutter/rendering/RevealedOffset-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RevealedOffset [<IsConst; NamedParams>] (offset: float, rect: Rect) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderViewportBase-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderViewportBase<'ParentDataClass> [<NamedParams>] (crossAxisDirection: AxisDirection, offset: ViewportOffset, ?axisDirection: AxisDirection, ?cacheExtent: float, ?cacheExtentStyle: CacheExtentStyle, ?clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderViewport-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderViewport [<NamedParams>] (crossAxisDirection: AxisDirection, offset: ViewportOffset, ?axisDirection: AxisDirection, ?anchor: float, ?children: RenderSliver[], ?center: RenderSliver, ?cacheExtent: float, ?cacheExtentStyle: CacheExtentStyle, ?clipBehavior: Clip) =
  [<IsConst>] static member useTwoPaneSemantics: SemanticsTag = nativeOnly
  [<IsConst>] static member excludeFromScrolling: SemanticsTag = nativeOnly

/// https://api.flutter.dev/flutter/rendering/RenderShrinkWrappingViewport-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderShrinkWrappingViewport [<NamedParams>] (crossAxisDirection: AxisDirection, offset: ViewportOffset, ?axisDirection: AxisDirection, ?clipBehavior: Clip, ?children: RenderSliver[]) =
  class end

/// https://api.flutter.dev/flutter/rendering/ViewportOffset-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ViewportOffset () =
  static member ``fixed``(value: float): ViewportOffset = nativeOnly
  static member zero(): ViewportOffset = nativeOnly

/// https://api.flutter.dev/flutter/rendering/WrapParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type WrapParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderWrap-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderWrap [<NamedParams>] (?children: RenderBox[], ?direction: Axis, ?alignment: WrapAlignment, ?spacing: float, ?runAlignment: WrapAlignment, ?runSpacing: float, ?crossAxisAlignment: WrapCrossAlignment, ?textDirection: TextDirection, ?verticalDirection: VerticalDirection, ?clipBehavior: Clip) =
  class end

