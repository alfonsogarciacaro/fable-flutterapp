namespace rec Flutter.Rendering

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
type RenderAnimatedSize [<NamedParams>] (vsync: TickerProvider, duration: TimeSpan, [<Optional>] reverseDuration: TimeSpan, [<Optional>] curve: Curve, [<Optional>] alignment: AlignmentGeometry, [<Optional>] textDirection: TextDirection, [<Optional>] child: RenderBox, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderingFlutterBinding-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderingFlutterBinding [<NamedParams>] ([<Optional>] root: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/BoxConstraints-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type BoxConstraints [<IsConst; NamedParams>] ([<Optional>] minWidth: float, [<Optional>] maxWidth: float, [<Optional>] minHeight: float, [<Optional>] maxHeight: float) =
  static member tight(size: Size): BoxConstraints = nativeOnly
  [<IsConst; NamedParams>] static member tightFor([<Optional>] width: float, [<Optional>] height: float): BoxConstraints = nativeOnly
  [<IsConst; NamedParams>] static member tightForFinite([<Optional>] width: float, [<Optional>] height: float): BoxConstraints = nativeOnly
  static member loose(size: Size): BoxConstraints = nativeOnly
  [<IsConst; NamedParams>] static member expand([<Optional>] width: float, [<Optional>] height: float): BoxConstraints = nativeOnly

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
type MultiChildLayoutDelegate [<NamedParams>] ([<Optional>] relayout: Listenable) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderCustomMultiChildLayoutBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderCustomMultiChildLayoutBox [<NamedParams>] (``delegate``: MultiChildLayoutDelegate, [<Optional>] children: RenderBox[]) =
  class end

/// https://api.flutter.dev/flutter/rendering/CustomPainter-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type CustomPainter [<IsConst; NamedParams>] ([<Optional>] repaint: Listenable) =
  class end

/// https://api.flutter.dev/flutter/rendering/CustomPainterSemantics-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type CustomPainterSemantics [<IsConst; NamedParams>] (rect: Rect, properties: SemanticsProperties, [<Optional>] key: Key, [<Optional>] transform: Matrix4, [<Optional>] tags: HashSet<SemanticsTag>) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderCustomPaint-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderCustomPaint [<NamedParams>] ([<Optional>] painter: CustomPainter, [<Optional>] foregroundPainter: CustomPainter, [<Optional>] preferredSize: Size, [<Optional>] isComplex: bool, [<Optional>] willChange: bool, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/TextSelectionPoint-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type TextSelectionPoint [<IsConst>] (point: Offset, direction: DartNullable<TextDirection>) =
  class end

/// https://api.flutter.dev/flutter/rendering/VerticalCaretMovementRun-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type VerticalCaretMovementRun =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderEditable-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderEditable [<NamedParams>] (textDirection: TextDirection, startHandleLayerLink: LayerLink, endHandleLayerLink: LayerLink, offset: ViewportOffset, (*textSelectionDelegate: TextSelectionDelegate,*) [<Optional>] text: InlineSpan, [<Optional>] textAlign: TextAlign, [<Optional>] cursorColor: Color, [<Optional>] backgroundCursorColor: Color, [<Optional>] showCursor: ValueNotifier<bool>, [<Optional>] hasFocus: bool, [<Optional>] maxLines: int, [<Optional>] minLines: int, [<Optional>] expands: bool, [<Optional>] strutStyle: StrutStyle, [<Optional>] selectionColor: Color, [<Optional>] textScaleFactor: float, [<Optional>] selection: TextSelection, [<Optional>] onCaretChanged: (Rect -> unit), [<Optional>] ignorePointer: bool, [<Optional>] readOnly: bool, [<Optional>] forceLine: bool, [<Optional>] textHeightBehavior: TextHeightBehavior, [<Optional>] textWidthBasis: TextWidthBasis, [<Optional>] obscuringCharacter: string, [<Optional>] obscureText: bool, [<Optional>] locale: Locale, [<Optional>] cursorWidth: float, [<Optional>] cursorHeight: float, [<Optional>] cursorRadius: Radius, [<Optional>] paintCursorAboveText: bool, [<Optional>] cursorOffset: Offset, [<Optional>] devicePixelRatio: float, [<Optional>] selectionHeightStyle: BoxHeightStyle, [<Optional>] selectionWidthStyle: BoxWidthStyle, [<Optional>] enableInteractiveSelection: bool, [<Optional>] floatingCursorAddedMargin: EdgeInsets, [<Optional>] promptRectRange: TextRange, [<Optional>] promptRectColor: Color, [<Optional>] clipBehavior: Clip, [<Optional>] painter: RenderEditablePainter, [<Optional>] foregroundPainter: RenderEditablePainter, [<Optional>] children: RenderBox[]) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderEditablePainter-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderEditablePainter () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderErrorBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderErrorBox ([<Optional>] message: string) =
  class end

/// https://api.flutter.dev/flutter/rendering/FlexParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FlexParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderFlex-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderFlex [<NamedParams>] ([<Optional>] children: RenderBox[], [<Optional>] direction: Axis, [<Optional>] mainAxisSize: MainAxisSize, [<Optional>] mainAxisAlignment: MainAxisAlignment, [<Optional>] crossAxisAlignment: CrossAxisAlignment, [<Optional>] textDirection: TextDirection, [<Optional>] verticalDirection: VerticalDirection, [<Optional>] textBaseline: TextBaseline, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/FlowPaintingContext-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FlowPaintingContext () =
  class end

/// https://api.flutter.dev/flutter/rendering/FlowDelegate-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FlowDelegate [<IsConst; NamedParams>] ([<Optional>] repaint: Listenable) =
  class end

/// https://api.flutter.dev/flutter/rendering/FlowParentData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FlowParentData () =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderFlow-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderFlow [<NamedParams>] (``delegate``: FlowDelegate, [<Optional>] children: RenderBox[], [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderImage-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderImage [<NamedParams>] ([<Optional>] image: Image, [<Optional>] debugImageLabel: string, [<Optional>] width: float, [<Optional>] height: float, [<Optional>] scale: float, [<Optional>] color: Color, [<Optional>] opacity: Animation<float>, [<Optional>] colorBlendMode: BlendMode, [<Optional>] fit: BoxFit, [<Optional>] alignment: AlignmentGeometry, [<Optional>] repeat: ImageRepeat, [<Optional>] centerSlice: Rect, [<Optional>] matchTextDirection: bool, [<Optional>] textDirection: TextDirection, [<Optional>] invertColors: bool, [<Optional>] isAntiAlias: bool, [<Optional>] filterQuality: FilterQuality) =
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
type LayerHandle<'T> ([<Optional>] _layer: 'T) =
  class end

/// https://api.flutter.dev/flutter/rendering/PictureLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type PictureLayer (canvasBounds: Rect) =
  class end

/// https://api.flutter.dev/flutter/rendering/TextureLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type TextureLayer [<NamedParams>] (rect: Rect, textureId: int, [<Optional>] freeze: bool, [<Optional>] filterQuality: FilterQuality) =
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
type OffsetLayer [<NamedParams>] ([<Optional>] offset: Offset) =
  class end

/// https://api.flutter.dev/flutter/rendering/ClipRectLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ClipRectLayer [<NamedParams>] ([<Optional>] clipRect: Rect, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/ClipRRectLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ClipRRectLayer [<NamedParams>] ([<Optional>] clipRRect: RRect, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/ClipPathLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ClipPathLayer [<NamedParams>] ([<Optional>] clipPath: Path, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/ColorFilterLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ColorFilterLayer [<NamedParams>] ([<Optional>] colorFilter: ColorFilter) =
  class end

/// https://api.flutter.dev/flutter/rendering/ImageFilterLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ImageFilterLayer [<NamedParams>] ([<Optional>] imageFilter: ImageFilter) =
  class end

/// https://api.flutter.dev/flutter/rendering/TransformLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type TransformLayer [<NamedParams>] ([<Optional>] transform: Matrix4, [<Optional>] offset: Offset) =
  class end

/// https://api.flutter.dev/flutter/rendering/OpacityLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type OpacityLayer [<NamedParams>] ([<Optional>] alpha: int, [<Optional>] offset: Offset) =
  class end

/// https://api.flutter.dev/flutter/rendering/ShaderMaskLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ShaderMaskLayer [<NamedParams>] ([<Optional>] shader: Shader, [<Optional>] maskRect: Rect, [<Optional>] blendMode: BlendMode) =
  class end

/// https://api.flutter.dev/flutter/rendering/BackdropFilterLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type BackdropFilterLayer [<NamedParams>] ([<Optional>] filter: ImageFilter, [<Optional>] blendMode: BlendMode) =
  class end

/// https://api.flutter.dev/flutter/rendering/PhysicalModelLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type PhysicalModelLayer [<NamedParams>] ([<Optional>] clipPath: Path, [<Optional>] clipBehavior: Clip, [<Optional>] elevation: float, [<Optional>] color: Color, [<Optional>] shadowColor: Color) =
  class end

/// https://api.flutter.dev/flutter/rendering/LayerLink-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type LayerLink () =
  class end

/// https://api.flutter.dev/flutter/rendering/LeaderLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type LeaderLayer [<NamedParams>] (link: LayerLink, [<Optional>] offset: Offset) =
  class end

/// https://api.flutter.dev/flutter/rendering/FollowerLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FollowerLayer [<NamedParams>] (link: LayerLink, [<Optional>] showWhenUnlinked: bool, [<Optional>] unlinkedOffset: Offset, [<Optional>] linkedOffset: Offset) =
  class end

/// https://api.flutter.dev/flutter/rendering/AnnotatedRegionLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type AnnotatedRegionLayer<'T> [<NamedParams(fromIndex=1)>] (value: 'T, [<Optional>] size: Size, [<Optional>] offset: Offset, [<Optional>] opaque: bool) =
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
type RenderListBody [<NamedParams>] ([<Optional>] children: RenderBox[], [<Optional>] axisDirection: AxisDirection) =
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
type RenderListWheelViewport [<NamedParams>] (childManager: ListWheelChildManager, offset: ViewportOffset, itemExtent: float, [<Optional>] diameterRatio: float, [<Optional>] perspective: float, [<Optional>] offAxisFraction: float, [<Optional>] useMagnifier: bool, [<Optional>] magnification: float, [<Optional>] overAndUnderCenterOpacity: float, [<Optional>] squeeze: float, [<Optional>] renderChildrenOutsideViewport: bool, [<Optional>] clipBehavior: Clip, [<Optional>] children: RenderBox[]) =
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
type PipelineOwner [<NamedParams>] ([<Optional>] onNeedVisualUpdate: (unit -> unit), [<Optional>] onSemanticsOwnerCreated: (unit -> unit), [<Optional>] onSemanticsOwnerDisposed: (unit -> unit)) =
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
type RenderParagraph [<NamedParams(fromIndex=1)>] (text: InlineSpan, textDirection: TextDirection, [<Optional>] textAlign: TextAlign, [<Optional>] softWrap: bool, [<Optional>] overflow: TextOverflow, [<Optional>] textScaleFactor: float, [<Optional>] maxLines: int, [<Optional>] locale: Locale, [<Optional>] strutStyle: StrutStyle, [<Optional>] textWidthBasis: TextWidthBasis, [<Optional>] textHeightBehavior: TextHeightBehavior, [<Optional>] children: RenderBox[]) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderPerformanceOverlay-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderPerformanceOverlay [<NamedParams>] ([<Optional>] optionsMask: int, [<Optional>] rasterizerThreshold: int, [<Optional>] checkerboardRasterCacheImages: bool, [<Optional>] checkerboardOffscreenLayers: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderAndroidView-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAndroidView [<NamedParams>] (viewController: AndroidViewController, hitTestBehavior: PlatformViewHitTestBehavior, gestureRecognizers: HashSet<Factory<OneSequenceGestureRecognizer>>, [<Optional>] clipBehavior: Clip) =
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
type RenderProxyBox ([<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderProxyBoxWithHitTestBehavior-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderProxyBoxWithHitTestBehavior [<NamedParams>] ([<Optional>] behavior: HitTestBehavior, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderConstrainedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderConstrainedBox [<NamedParams>] (additionalConstraints: BoxConstraints, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderLimitedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderLimitedBox [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] maxWidth: float, [<Optional>] maxHeight: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderAspectRatio-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAspectRatio [<NamedParams>] (aspectRatio: float, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderIntrinsicWidth-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderIntrinsicWidth [<NamedParams>] ([<Optional>] stepWidth: float, [<Optional>] stepHeight: float, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderIntrinsicHeight-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderIntrinsicHeight [<NamedParams>] ([<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderOpacity-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderOpacity [<NamedParams>] ([<Optional>] opacity: float, [<Optional>] alwaysIncludeSemantics: bool, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderAnimatedOpacity-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAnimatedOpacity [<NamedParams>] (opacity: Animation<float>, [<Optional>] alwaysIncludeSemantics: bool, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderShaderMask-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderShaderMask [<NamedParams>] (shaderCallback: (Rect -> Shader), [<Optional>] child: RenderBox, [<Optional>] blendMode: BlendMode) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderBackdropFilter-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderBackdropFilter [<NamedParams>] (filter: ImageFilter, [<Optional>] child: RenderBox, [<Optional>] blendMode: BlendMode) =
  class end

/// https://api.flutter.dev/flutter/rendering/CustomClipper-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type CustomClipper<'T> [<IsConst; NamedParams>] ([<Optional>] reclip: Listenable) =
  class end

/// https://api.flutter.dev/flutter/rendering/ShapeBorderClipper-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ShapeBorderClipper [<IsConst; NamedParams>] (shape: ShapeBorder, [<Optional>] textDirection: TextDirection) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderClipRect-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderClipRect [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] clipper: CustomClipper<Rect>, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderClipRRect-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderClipRRect [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] borderRadius: BorderRadius, [<Optional>] clipper: CustomClipper<RRect>, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderClipOval-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderClipOval [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] clipper: CustomClipper<Rect>, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderClipPath-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderClipPath [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] clipper: CustomClipper<Path>, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderPhysicalModel-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderPhysicalModel [<NamedParams>] (color: Color, [<Optional>] child: RenderBox, [<Optional>] shape: BoxShape, [<Optional>] clipBehavior: Clip, [<Optional>] borderRadius: BorderRadius, [<Optional>] elevation: float, [<Optional>] shadowColor: Color) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderPhysicalShape-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderPhysicalShape [<NamedParams>] (clipper: CustomClipper<Path>, color: Color, [<Optional>] child: RenderBox, [<Optional>] clipBehavior: Clip, [<Optional>] elevation: float, [<Optional>] shadowColor: Color) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderDecoratedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderDecoratedBox [<NamedParams>] (decoration: Decoration, [<Optional>] position: DecorationPosition, [<Optional>] configuration: ImageConfiguration, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderTransform-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderTransform [<NamedParams>] (transform: Matrix4, [<Optional>] origin: Offset, [<Optional>] alignment: AlignmentGeometry, [<Optional>] textDirection: TextDirection, [<Optional>] transformHitTests: bool, [<Optional>] filterQuality: FilterQuality, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderFittedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderFittedBox [<NamedParams>] ([<Optional>] fit: BoxFit, [<Optional>] alignment: AlignmentGeometry, [<Optional>] textDirection: TextDirection, [<Optional>] child: RenderBox, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderFractionalTranslation-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderFractionalTranslation [<NamedParams>] (translation: Offset, [<Optional>] transformHitTests: bool, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderPointerListener-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderPointerListener [<NamedParams>] ([<Optional>] onPointerDown: (PointerDownEvent -> unit), [<Optional>] onPointerMove: (PointerMoveEvent -> unit), [<Optional>] onPointerUp: (PointerUpEvent -> unit), [<Optional>] onPointerHover: (PointerHoverEvent -> unit), [<Optional>] onPointerCancel: (PointerCancelEvent -> unit), [<Optional>] onPointerSignal: (PointerSignalEvent -> unit), [<Optional>] behavior: HitTestBehavior, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderMouseRegion-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderMouseRegion [<NamedParams>] ([<Optional>] onEnter: (PointerEnterEvent -> unit), [<Optional>] onHover: (PointerHoverEvent -> unit), [<Optional>] onExit: (PointerExitEvent -> unit), [<Optional>] cursor: MouseCursor, [<Optional>] validForMouseTracker: bool, [<Optional>] opaque: bool, [<Optional>] child: RenderBox, [<Optional>] hitTestBehavior: HitTestBehavior) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderRepaintBoundary-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderRepaintBoundary [<NamedParams>] ([<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderIgnorePointer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderIgnorePointer [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] ignoring: bool, [<Optional>] ignoringSemantics: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderOffstage-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderOffstage [<NamedParams>] ([<Optional>] offstage: bool, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderAbsorbPointer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAbsorbPointer [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] absorbing: bool, [<Optional>] ignoringSemantics: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderMetaData-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderMetaData [<NamedParams>] ([<Optional>] metaData: obj, [<Optional>] behavior: HitTestBehavior, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSemanticsGestureHandler-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSemanticsGestureHandler [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] onTap: (unit -> unit), [<Optional>] onLongPress: (unit -> unit), [<Optional>] onHorizontalDragUpdate: (DragUpdateDetails -> unit), [<Optional>] onVerticalDragUpdate: (DragUpdateDetails -> unit), [<Optional>] scrollFactor: float, [<Optional>] behavior: HitTestBehavior) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSemanticsAnnotations-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSemanticsAnnotations [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] container: bool, [<Optional>] explicitChildNodes: bool, [<Optional>] excludeSemantics: bool, [<Optional>] enabled: bool, [<Optional>] ``checked``: bool, [<Optional>] toggled: bool, [<Optional>] selected: bool, [<Optional>] button: bool, [<Optional>] slider: bool, [<Optional>] keyboardKey: bool, [<Optional>] link: bool, [<Optional>] header: bool, [<Optional>] textField: bool, [<Optional>] readOnly: bool, [<Optional>] focusable: bool, [<Optional>] focused: bool, [<Optional>] inMutuallyExclusiveGroup: bool, [<Optional>] obscured: bool, [<Optional>] multiline: bool, [<Optional>] scopesRoute: bool, [<Optional>] namesRoute: bool, [<Optional>] hidden: bool, [<Optional>] image: bool, [<Optional>] liveRegion: bool, [<Optional>] maxValueLength: int, [<Optional>] currentValueLength: int, [<Optional>] attributedLabel: AttributedString, [<Optional>] attributedValue: AttributedString, [<Optional>] attributedIncreasedValue: AttributedString, [<Optional>] attributedDecreasedValue: AttributedString, [<Optional>] attributedHint: AttributedString, [<Optional>] hintOverrides: SemanticsHintOverrides, [<Optional>] textDirection: TextDirection, [<Optional>] sortKey: SemanticsSortKey, [<Optional>] tagForChildren: SemanticsTag, [<Optional>] onTap: (unit -> unit), [<Optional>] onDismiss: (unit -> unit), [<Optional>] onLongPress: (unit -> unit), [<Optional>] onScrollLeft: (unit -> unit), [<Optional>] onScrollRight: (unit -> unit), [<Optional>] onScrollUp: (unit -> unit), [<Optional>] onScrollDown: (unit -> unit), [<Optional>] onIncrease: (unit -> unit), [<Optional>] onDecrease: (unit -> unit), [<Optional>] onCopy: (unit -> unit), [<Optional>] onCut: (unit -> unit), [<Optional>] onPaste: (unit -> unit), [<Optional>] onMoveCursorForwardByCharacter: (bool -> unit), [<Optional>] onMoveCursorBackwardByCharacter: (bool -> unit), [<Optional>] onMoveCursorForwardByWord: (bool -> unit), [<Optional>] onMoveCursorBackwardByWord: (bool -> unit), [<Optional>] onSetSelection: (TextSelection -> unit), [<Optional>] onSetText: (string -> unit), [<Optional>] onDidGainAccessibilityFocus: (unit -> unit), [<Optional>] onDidLoseAccessibilityFocus: (unit -> unit), [<Optional>] customSemanticsActions: Dictionary<CustomSemanticsAction, (unit -> unit)>) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderBlockSemantics-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderBlockSemantics [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] blocking: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderMergeSemantics-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderMergeSemantics [<NamedParams>] ([<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderExcludeSemantics-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderExcludeSemantics [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] excluding: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderIndexedSemantics-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderIndexedSemantics [<NamedParams>] (index: int, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderLeaderLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderLeaderLayer [<NamedParams>] (link: LayerLink, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderFollowerLayer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderFollowerLayer [<NamedParams>] (link: LayerLink, [<Optional>] showWhenUnlinked: bool, [<Optional>] offset: Offset, [<Optional>] leaderAnchor: Alignment, [<Optional>] followerAnchor: Alignment, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderAnnotatedRegion-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAnnotatedRegion<'T> [<NamedParams>] (value: 'T, sized: bool, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderProxySliver-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderProxySliver ([<Optional>] child: RenderSliver) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverOpacity-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverOpacity [<NamedParams>] ([<Optional>] opacity: float, [<Optional>] alwaysIncludeSemantics: bool, [<Optional>] sliver: RenderSliver) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverIgnorePointer-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverIgnorePointer [<NamedParams>] ([<Optional>] sliver: RenderSliver, [<Optional>] ignoring: bool, [<Optional>] ignoringSemantics: bool) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverOffstage-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverOffstage [<NamedParams>] ([<Optional>] offstage: bool, [<Optional>] sliver: RenderSliver) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverAnimatedOpacity-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverAnimatedOpacity [<NamedParams>] (opacity: Animation<float>, [<Optional>] alwaysIncludeSemantics: bool, [<Optional>] sliver: RenderSliver) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderRotatedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderRotatedBox [<NamedParams>] (quarterTurns: int, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderShiftedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderShiftedBox (child: DartNullable<RenderBox>) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderPadding-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderPadding [<NamedParams>] (padding: EdgeInsetsGeometry, [<Optional>] textDirection: TextDirection, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderAligningShiftedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderAligningShiftedBox [<NamedParams>] (textDirection: DartNullable<TextDirection>, [<Optional>] alignment: AlignmentGeometry, [<Optional>] child: RenderBox) =
  static member ``mixin``(alignment: AlignmentGeometry, textDirection: DartNullable<TextDirection>, child: DartNullable<RenderBox>): RenderAligningShiftedBox = nativeOnly

/// https://api.flutter.dev/flutter/rendering/RenderPositionedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderPositionedBox [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] widthFactor: float, [<Optional>] heightFactor: float, [<Optional>] alignment: AlignmentGeometry, [<Optional>] textDirection: TextDirection) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderConstrainedOverflowBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderConstrainedOverflowBox [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] minWidth: float, [<Optional>] maxWidth: float, [<Optional>] minHeight: float, [<Optional>] maxHeight: float, [<Optional>] alignment: AlignmentGeometry, [<Optional>] textDirection: TextDirection) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderConstraintsTransformBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderConstraintsTransformBox [<NamedParams>] (alignment: AlignmentGeometry, textDirection: DartNullable<TextDirection>, constraintsTransform: (BoxConstraints -> BoxConstraints), [<Optional>] child: RenderBox, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderUnconstrainedBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderUnconstrainedBox [<NamedParams>] (alignment: AlignmentGeometry, textDirection: DartNullable<TextDirection>, [<Optional>] constrainedAxis: Axis, [<Optional>] child: RenderBox, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSizedOverflowBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSizedOverflowBox [<NamedParams>] (requestedSize: Size, [<Optional>] child: RenderBox, [<Optional>] alignment: AlignmentGeometry, [<Optional>] textDirection: TextDirection) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderFractionallySizedOverflowBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderFractionallySizedOverflowBox [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] widthFactor: float, [<Optional>] heightFactor: float, [<Optional>] alignment: AlignmentGeometry, [<Optional>] textDirection: TextDirection) =
  class end

/// https://api.flutter.dev/flutter/rendering/SingleChildLayoutDelegate-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SingleChildLayoutDelegate [<IsConst; NamedParams>] ([<Optional>] relayout: Listenable) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderCustomSingleChildLayoutBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderCustomSingleChildLayoutBox [<NamedParams>] (``delegate``: SingleChildLayoutDelegate, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderBaseline-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderBaseline [<NamedParams>] (baseline: float, baselineType: TextBaseline, [<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverConstraints-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverConstraints [<IsConst; NamedParams>] (axisDirection: AxisDirection, growthDirection: GrowthDirection, userScrollDirection: ScrollDirection, scrollOffset: float, precedingScrollExtent: float, overlap: float, remainingPaintExtent: float, crossAxisExtent: float, crossAxisDirection: AxisDirection, viewportMainAxisExtent: float, remainingCacheExtent: float, cacheOrigin: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverGeometry-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverGeometry [<IsConst; NamedParams>] ([<Optional>] scrollExtent: float, [<Optional>] paintExtent: float, [<Optional>] paintOrigin: float, [<Optional>] layoutExtent: float, [<Optional>] maxPaintExtent: float, [<Optional>] maxScrollObstructionExtent: float, [<Optional>] hitTestExtent: float, [<Optional>] visible: bool, [<Optional>] hasVisualOverflow: bool, [<Optional>] scrollOffsetCorrection: float, [<Optional>] cacheExtent: float) =
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
type RenderSliverSingleBoxAdapter [<NamedParams>] ([<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverToBoxAdapter-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverToBoxAdapter [<NamedParams>] ([<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFillViewport-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFillViewport [<NamedParams>] (childManager: RenderSliverBoxChildManager, [<Optional>] viewportFraction: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFillRemainingWithScrollable-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFillRemainingWithScrollable [<NamedParams>] ([<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFillRemaining-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFillRemaining [<NamedParams>] ([<Optional>] child: RenderBox) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFillRemainingAndOverscroll-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFillRemainingAndOverscroll [<NamedParams>] ([<Optional>] child: RenderBox) =
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
type SliverGridDelegateWithFixedCrossAxisCount [<IsConst; NamedParams>] (crossAxisCount: int, [<Optional>] mainAxisSpacing: float, [<Optional>] crossAxisSpacing: float, [<Optional>] childAspectRatio: float, [<Optional>] mainAxisExtent: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/SliverGridDelegateWithMaxCrossAxisExtent-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type SliverGridDelegateWithMaxCrossAxisExtent [<IsConst; NamedParams>] (maxCrossAxisExtent: float, [<Optional>] mainAxisSpacing: float, [<Optional>] crossAxisSpacing: float, [<Optional>] childAspectRatio: float, [<Optional>] mainAxisExtent: float) =
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
type RenderSliverPadding [<NamedParams>] (padding: EdgeInsetsGeometry, [<Optional>] textDirection: TextDirection, [<Optional>] child: RenderSliver) =
  class end

/// https://api.flutter.dev/flutter/rendering/OverScrollHeaderStretchConfiguration-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type OverScrollHeaderStretchConfiguration [<NamedParams>] ([<Optional>] stretchTriggerOffset: float, [<Optional>] onStretchTrigger: (unit -> Future<unit>)) =
  class end

/// https://api.flutter.dev/flutter/rendering/PersistentHeaderShowOnScreenConfiguration-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type PersistentHeaderShowOnScreenConfiguration [<IsConst; NamedParams>] ([<Optional>] minShowOnScreenExtent: float, [<Optional>] maxShowOnScreenExtent: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverPersistentHeader-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverPersistentHeader [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] stretchConfiguration: OverScrollHeaderStretchConfiguration) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverScrollingPersistentHeader-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverScrollingPersistentHeader [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] stretchConfiguration: OverScrollHeaderStretchConfiguration) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverPinnedPersistentHeader-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverPinnedPersistentHeader [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] stretchConfiguration: OverScrollHeaderStretchConfiguration, [<Optional>] showOnScreenConfiguration: PersistentHeaderShowOnScreenConfiguration) =
  class end

/// https://api.flutter.dev/flutter/rendering/FloatingHeaderSnapConfiguration-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FloatingHeaderSnapConfiguration [<NamedParams>] ([<Optional>] curve: Curve, [<Optional>] duration: TimeSpan) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFloatingPersistentHeader-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFloatingPersistentHeader [<NamedParams>] (showOnScreenConfiguration: DartNullable<PersistentHeaderShowOnScreenConfiguration>, [<Optional>] child: RenderBox, [<Optional>] vsync: TickerProvider, [<Optional>] snapConfiguration: FloatingHeaderSnapConfiguration, [<Optional>] stretchConfiguration: OverScrollHeaderStretchConfiguration) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderSliverFloatingPinnedPersistentHeader-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderSliverFloatingPinnedPersistentHeader [<NamedParams>] ([<Optional>] child: RenderBox, [<Optional>] vsync: TickerProvider, [<Optional>] snapConfiguration: FloatingHeaderSnapConfiguration, [<Optional>] stretchConfiguration: OverScrollHeaderStretchConfiguration, [<Optional>] showOnScreenConfiguration: PersistentHeaderShowOnScreenConfiguration) =
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
type RenderStack [<NamedParams>] ([<Optional>] children: RenderBox[], [<Optional>] alignment: AlignmentGeometry, [<Optional>] textDirection: TextDirection, [<Optional>] fit: StackFit, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderIndexedStack-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderIndexedStack [<NamedParams>] ([<Optional>] children: RenderBox[], [<Optional>] alignment: AlignmentGeometry, [<Optional>] textDirection: TextDirection, [<Optional>] index: int) =
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
type IntrinsicColumnWidth [<IsConst; NamedParams>] ([<Optional>] flex: float) =
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
type FlexColumnWidth [<IsConst>] ([<Optional>] value: float) =
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
type RenderTable [<NamedParams>] (textDirection: TextDirection, [<Optional>] columns: int, [<Optional>] rows: int, [<Optional>] columnWidths: Dictionary<int, TableColumnWidth>, [<Optional>] defaultColumnWidth: TableColumnWidth, [<Optional>] border: TableBorder, [<Optional>] rowDecorations: DartNullable<Decoration>[], [<Optional>] configuration: ImageConfiguration, [<Optional>] defaultVerticalAlignment: TableCellVerticalAlignment, [<Optional>] textBaseline: TextBaseline, [<Optional>] children: RenderBox[][]) =
  class end

/// https://api.flutter.dev/flutter/rendering/TableBorder-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type TableBorder [<IsConst; NamedParams>] ([<Optional>] top: BorderSide, [<Optional>] right: BorderSide, [<Optional>] bottom: BorderSide, [<Optional>] left: BorderSide, [<Optional>] horizontalInside: BorderSide, [<Optional>] verticalInside: BorderSide, [<Optional>] borderRadius: BorderRadius) =
  [<NamedParams>] static member all([<Optional>] color: Color, [<Optional>] width: float, [<Optional>] style: BorderStyle, [<Optional>] borderRadius: BorderRadius): TableBorder = nativeOnly
  [<NamedParams>] static member symmetric([<Optional>] inside: BorderSide, [<Optional>] outside: BorderSide): TableBorder = nativeOnly

/// https://api.flutter.dev/flutter/rendering/TextureBox-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type TextureBox [<NamedParams>] (textureId: int, [<Optional>] freeze: bool, [<Optional>] filterQuality: FilterQuality) =
  class end

/// https://api.flutter.dev/flutter/rendering/FractionalOffsetTween-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type FractionalOffsetTween [<NamedParams>] ([<Optional>] ``begin``: FractionalOffset, [<Optional>] ``end``: FractionalOffset) =
  class end

/// https://api.flutter.dev/flutter/rendering/AlignmentTween-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type AlignmentTween [<NamedParams>] ([<Optional>] ``begin``: Alignment, [<Optional>] ``end``: Alignment) =
  class end

/// https://api.flutter.dev/flutter/rendering/AlignmentGeometryTween-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type AlignmentGeometryTween [<NamedParams>] ([<Optional>] ``begin``: AlignmentGeometry, [<Optional>] ``end``: AlignmentGeometry) =
  class end

/// https://api.flutter.dev/flutter/rendering/ViewConfiguration-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type ViewConfiguration [<IsConst; NamedParams>] ([<Optional>] size: Size, [<Optional>] devicePixelRatio: float) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderView-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderView [<NamedParams>] (configuration: ViewConfiguration, window: FlutterView, [<Optional>] child: RenderBox) =
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
type RenderViewportBase<'ParentDataClass> [<NamedParams>] (crossAxisDirection: AxisDirection, offset: ViewportOffset, [<Optional>] axisDirection: AxisDirection, [<Optional>] cacheExtent: float, [<Optional>] cacheExtentStyle: CacheExtentStyle, [<Optional>] clipBehavior: Clip) =
  class end

/// https://api.flutter.dev/flutter/rendering/RenderViewport-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderViewport [<NamedParams>] (crossAxisDirection: AxisDirection, offset: ViewportOffset, [<Optional>] axisDirection: AxisDirection, [<Optional>] anchor: float, [<Optional>] children: RenderSliver[], [<Optional>] center: RenderSliver, [<Optional>] cacheExtent: float, [<Optional>] cacheExtentStyle: CacheExtentStyle, [<Optional>] clipBehavior: Clip) =
  [<IsConst>] static member useTwoPaneSemantics: SemanticsTag = nativeOnly
  [<IsConst>] static member excludeFromScrolling: SemanticsTag = nativeOnly

/// https://api.flutter.dev/flutter/rendering/RenderShrinkWrappingViewport-class.html
[<ImportMember("package:flutter/rendering.dart")>]
type RenderShrinkWrappingViewport [<NamedParams>] (crossAxisDirection: AxisDirection, offset: ViewportOffset, [<Optional>] axisDirection: AxisDirection, [<Optional>] clipBehavior: Clip, [<Optional>] children: RenderSliver[]) =
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
type RenderWrap [<NamedParams>] ([<Optional>] children: RenderBox[], [<Optional>] direction: Axis, [<Optional>] alignment: WrapAlignment, [<Optional>] spacing: float, [<Optional>] runAlignment: WrapAlignment, [<Optional>] runSpacing: float, [<Optional>] crossAxisAlignment: WrapCrossAlignment, [<Optional>] textDirection: TextDirection, [<Optional>] verticalDirection: VerticalDirection, [<Optional>] clipBehavior: Clip) =
  class end

