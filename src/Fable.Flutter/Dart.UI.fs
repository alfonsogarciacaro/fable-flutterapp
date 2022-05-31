namespace rec Dart //.UI

open System
open System.Collections.Generic
open Fable.Core
open Fable.Core.Dart

/// https://api.flutter.dev/flutter/dart-ui/KeyEventType.html
[<ImportMember("dart:ui")>]
type KeyEventType =
  [<IsConst>] static member down: KeyEventType = nativeOnly
  [<IsConst>] static member up: KeyEventType = nativeOnly
  [<IsConst>] static member repeat: KeyEventType = nativeOnly
  [<IsConst>] static member values: KeyEventType = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/BlendMode.html
[<ImportMember("dart:ui")>]
type BlendMode =
  [<IsConst>] static member clear: BlendMode = nativeOnly
  [<IsConst>] static member src: BlendMode = nativeOnly
  [<IsConst>] static member dst: BlendMode = nativeOnly
  [<IsConst>] static member srcOver: BlendMode = nativeOnly
  [<IsConst>] static member dstOver: BlendMode = nativeOnly
  [<IsConst>] static member srcIn: BlendMode = nativeOnly
  [<IsConst>] static member dstIn: BlendMode = nativeOnly
  [<IsConst>] static member srcOut: BlendMode = nativeOnly
  [<IsConst>] static member dstOut: BlendMode = nativeOnly
  [<IsConst>] static member srcATop: BlendMode = nativeOnly
  [<IsConst>] static member dstATop: BlendMode = nativeOnly
  [<IsConst>] static member xor: BlendMode = nativeOnly
  [<IsConst>] static member plus: BlendMode = nativeOnly
  [<IsConst>] static member modulate: BlendMode = nativeOnly
  [<IsConst>] static member screen: BlendMode = nativeOnly
  [<IsConst>] static member overlay: BlendMode = nativeOnly
  [<IsConst>] static member darken: BlendMode = nativeOnly
  [<IsConst>] static member lighten: BlendMode = nativeOnly
  [<IsConst>] static member colorDodge: BlendMode = nativeOnly
  [<IsConst>] static member colorBurn: BlendMode = nativeOnly
  [<IsConst>] static member hardLight: BlendMode = nativeOnly
  [<IsConst>] static member softLight: BlendMode = nativeOnly
  [<IsConst>] static member difference: BlendMode = nativeOnly
  [<IsConst>] static member exclusion: BlendMode = nativeOnly
  [<IsConst>] static member multiply: BlendMode = nativeOnly
  [<IsConst>] static member hue: BlendMode = nativeOnly
  [<IsConst>] static member saturation: BlendMode = nativeOnly
  [<IsConst>] static member color: BlendMode = nativeOnly
  [<IsConst>] static member luminosity: BlendMode = nativeOnly
  [<IsConst>] static member values: BlendMode = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/FilterQuality.html
[<ImportMember("dart:ui")>]
type FilterQuality =
  [<IsConst>] static member none: FilterQuality = nativeOnly
  [<IsConst>] static member low: FilterQuality = nativeOnly
  [<IsConst>] static member medium: FilterQuality = nativeOnly
  [<IsConst>] static member high: FilterQuality = nativeOnly
  [<IsConst>] static member values: FilterQuality = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/StrokeCap.html
[<ImportMember("dart:ui")>]
type StrokeCap =
  [<IsConst>] static member butt: StrokeCap = nativeOnly
  [<IsConst>] static member round: StrokeCap = nativeOnly
  [<IsConst>] static member square: StrokeCap = nativeOnly
  [<IsConst>] static member values: StrokeCap = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/StrokeJoin.html
[<ImportMember("dart:ui")>]
type StrokeJoin =
  [<IsConst>] static member miter: StrokeJoin = nativeOnly
  [<IsConst>] static member round: StrokeJoin = nativeOnly
  [<IsConst>] static member bevel: StrokeJoin = nativeOnly
  [<IsConst>] static member values: StrokeJoin = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/PaintingStyle.html
[<ImportMember("dart:ui")>]
type PaintingStyle =
  [<IsConst>] static member fill: PaintingStyle = nativeOnly
  [<IsConst>] static member stroke: PaintingStyle = nativeOnly
  [<IsConst>] static member values: PaintingStyle = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/Clip.html
[<ImportMember("dart:ui")>]
type Clip =
  [<IsConst>] static member none: Clip = nativeOnly
  [<IsConst>] static member hardEdge: Clip = nativeOnly
  [<IsConst>] static member antiAlias: Clip = nativeOnly
  [<IsConst>] static member antiAliasWithSaveLayer: Clip = nativeOnly
  [<IsConst>] static member values: Clip = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/ImageByteFormat.html
[<ImportMember("dart:ui")>]
type ImageByteFormat =
  [<IsConst>] static member rawRgba: ImageByteFormat = nativeOnly
  [<IsConst>] static member rawStraightRgba: ImageByteFormat = nativeOnly
  [<IsConst>] static member rawUnmodified: ImageByteFormat = nativeOnly
  [<IsConst>] static member png: ImageByteFormat = nativeOnly
  [<IsConst>] static member values: ImageByteFormat = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/PixelFormat.html
[<ImportMember("dart:ui")>]
type PixelFormat =
  [<IsConst>] static member rgba8888: PixelFormat = nativeOnly
  [<IsConst>] static member bgra8888: PixelFormat = nativeOnly
  [<IsConst>] static member values: PixelFormat = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/PathFillType.html
[<ImportMember("dart:ui")>]
type PathFillType =
  [<IsConst>] static member nonZero: PathFillType = nativeOnly
  [<IsConst>] static member evenOdd: PathFillType = nativeOnly
  [<IsConst>] static member values: PathFillType = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/PathOperation.html
[<ImportMember("dart:ui")>]
type PathOperation =
  [<IsConst>] static member difference: PathOperation = nativeOnly
  [<IsConst>] static member intersect: PathOperation = nativeOnly
  [<IsConst>] static member union: PathOperation = nativeOnly
  [<IsConst>] static member xor: PathOperation = nativeOnly
  [<IsConst>] static member reverseDifference: PathOperation = nativeOnly
  [<IsConst>] static member values: PathOperation = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/BlurStyle.html
[<ImportMember("dart:ui")>]
type BlurStyle =
  [<IsConst>] static member normal: BlurStyle = nativeOnly
  [<IsConst>] static member solid: BlurStyle = nativeOnly
  [<IsConst>] static member outer: BlurStyle = nativeOnly
  [<IsConst>] static member inner: BlurStyle = nativeOnly
  [<IsConst>] static member values: BlurStyle = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/TileMode.html
[<ImportMember("dart:ui")>]
type TileMode =
  [<IsConst>] static member clamp: TileMode = nativeOnly
  [<IsConst>] static member repeated: TileMode = nativeOnly
  [<IsConst>] static member mirror: TileMode = nativeOnly
  [<IsConst>] static member decal: TileMode = nativeOnly
  [<IsConst>] static member values: TileMode = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/VertexMode.html
[<ImportMember("dart:ui")>]
type VertexMode =
  [<IsConst>] static member triangles: VertexMode = nativeOnly
  [<IsConst>] static member triangleStrip: VertexMode = nativeOnly
  [<IsConst>] static member triangleFan: VertexMode = nativeOnly
  [<IsConst>] static member values: VertexMode = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/PointMode.html
[<ImportMember("dart:ui")>]
type PointMode =
  [<IsConst>] static member points: PointMode = nativeOnly
  [<IsConst>] static member lines: PointMode = nativeOnly
  [<IsConst>] static member polygon: PointMode = nativeOnly
  [<IsConst>] static member values: PointMode = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/ClipOp.html
[<ImportMember("dart:ui")>]
type ClipOp =
  [<IsConst>] static member difference: ClipOp = nativeOnly
  [<IsConst>] static member intersect: ClipOp = nativeOnly
  [<IsConst>] static member values: ClipOp = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/FramePhase.html
[<ImportMember("dart:ui")>]
type FramePhase =
  [<IsConst>] static member vsyncStart: FramePhase = nativeOnly
  [<IsConst>] static member buildStart: FramePhase = nativeOnly
  [<IsConst>] static member buildFinish: FramePhase = nativeOnly
  [<IsConst>] static member rasterStart: FramePhase = nativeOnly
  [<IsConst>] static member rasterFinish: FramePhase = nativeOnly
  [<IsConst>] static member rasterFinishWallTime: FramePhase = nativeOnly
  [<IsConst>] static member values: FramePhase = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/AppLifecycleState.html
[<ImportMember("dart:ui")>]
type AppLifecycleState =
  [<IsConst>] static member resumed: AppLifecycleState = nativeOnly
  [<IsConst>] static member inactive: AppLifecycleState = nativeOnly
  [<IsConst>] static member paused: AppLifecycleState = nativeOnly
  [<IsConst>] static member detached: AppLifecycleState = nativeOnly
  [<IsConst>] static member values: AppLifecycleState = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/DisplayFeatureType.html
[<ImportMember("dart:ui")>]
type DisplayFeatureType =
  [<IsConst>] static member unknown: DisplayFeatureType = nativeOnly
  [<IsConst>] static member fold: DisplayFeatureType = nativeOnly
  [<IsConst>] static member hinge: DisplayFeatureType = nativeOnly
  [<IsConst>] static member cutout: DisplayFeatureType = nativeOnly
  [<IsConst>] static member values: DisplayFeatureType = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/DisplayFeatureState.html
[<ImportMember("dart:ui")>]
type DisplayFeatureState =
  [<IsConst>] static member unknown: DisplayFeatureState = nativeOnly
  [<IsConst>] static member postureFlat: DisplayFeatureState = nativeOnly
  [<IsConst>] static member postureHalfOpened: DisplayFeatureState = nativeOnly
  [<IsConst>] static member values: DisplayFeatureState = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/PointerChange.html
[<ImportMember("dart:ui")>]
type PointerChange =
  [<IsConst>] static member cancel: PointerChange = nativeOnly
  [<IsConst>] static member add: PointerChange = nativeOnly
  [<IsConst>] static member remove: PointerChange = nativeOnly
  [<IsConst>] static member hover: PointerChange = nativeOnly
  [<IsConst>] static member down: PointerChange = nativeOnly
  [<IsConst>] static member move: PointerChange = nativeOnly
  [<IsConst>] static member up: PointerChange = nativeOnly
  [<IsConst>] static member panZoomStart: PointerChange = nativeOnly
  [<IsConst>] static member panZoomUpdate: PointerChange = nativeOnly
  [<IsConst>] static member panZoomEnd: PointerChange = nativeOnly
  [<IsConst>] static member values: PointerChange = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/PointerDeviceKind.html
[<ImportMember("dart:ui")>]
type PointerDeviceKind =
  [<IsConst>] static member touch: PointerDeviceKind = nativeOnly
  [<IsConst>] static member mouse: PointerDeviceKind = nativeOnly
  [<IsConst>] static member stylus: PointerDeviceKind = nativeOnly
  [<IsConst>] static member invertedStylus: PointerDeviceKind = nativeOnly
  [<IsConst>] static member trackpad: PointerDeviceKind = nativeOnly
  [<IsConst>] static member unknown: PointerDeviceKind = nativeOnly
  [<IsConst>] static member values: PointerDeviceKind = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/PointerSignalKind.html
[<ImportMember("dart:ui")>]
type PointerSignalKind =
  [<IsConst>] static member none: PointerSignalKind = nativeOnly
  [<IsConst>] static member scroll: PointerSignalKind = nativeOnly
  [<IsConst>] static member unknown: PointerSignalKind = nativeOnly
  [<IsConst>] static member values: PointerSignalKind = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/FontStyle.html
[<ImportMember("dart:ui")>]
type FontStyle =
  [<IsConst>] static member normal: FontStyle = nativeOnly
  [<IsConst>] static member italic: FontStyle = nativeOnly
  [<IsConst>] static member values: FontStyle = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/TextAlign.html
[<ImportMember("dart:ui")>]
type TextAlign =
  [<IsConst>] static member left: TextAlign = nativeOnly
  [<IsConst>] static member right: TextAlign = nativeOnly
  [<IsConst>] static member center: TextAlign = nativeOnly
  [<IsConst>] static member justify: TextAlign = nativeOnly
  [<IsConst>] static member start: TextAlign = nativeOnly
  [<IsConst>] static member ``end``: TextAlign = nativeOnly
  [<IsConst>] static member values: TextAlign = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/TextBaseline.html
[<ImportMember("dart:ui")>]
type TextBaseline =
  [<IsConst>] static member alphabetic: TextBaseline = nativeOnly
  [<IsConst>] static member ideographic: TextBaseline = nativeOnly
  [<IsConst>] static member values: TextBaseline = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/TextDecorationStyle.html
[<ImportMember("dart:ui")>]
type TextDecorationStyle =
  [<IsConst>] static member solid: TextDecorationStyle = nativeOnly
  [<IsConst>] static member double: TextDecorationStyle = nativeOnly
  [<IsConst>] static member dotted: TextDecorationStyle = nativeOnly
  [<IsConst>] static member dashed: TextDecorationStyle = nativeOnly
  [<IsConst>] static member wavy: TextDecorationStyle = nativeOnly
  [<IsConst>] static member values: TextDecorationStyle = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/TextLeadingDistribution.html
[<ImportMember("dart:ui")>]
type TextLeadingDistribution =
  [<IsConst>] static member proportional: TextLeadingDistribution = nativeOnly
  [<IsConst>] static member even: TextLeadingDistribution = nativeOnly
  [<IsConst>] static member values: TextLeadingDistribution = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/TextDirection.html
[<ImportMember("dart:ui")>]
type TextDirection =
  [<IsConst>] static member rtl: TextDirection = nativeOnly
  [<IsConst>] static member ltr: TextDirection = nativeOnly
  [<IsConst>] static member values: TextDirection = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/TextAffinity.html
[<ImportMember("dart:ui")>]
type TextAffinity =
  [<IsConst>] static member upstream: TextAffinity = nativeOnly
  [<IsConst>] static member downstream: TextAffinity = nativeOnly
  [<IsConst>] static member values: TextAffinity = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/BoxHeightStyle.html
[<ImportMember("dart:ui")>]
type BoxHeightStyle =
  [<IsConst>] static member tight: BoxHeightStyle = nativeOnly
  [<IsConst>] static member max: BoxHeightStyle = nativeOnly
  [<IsConst>] static member includeLineSpacingMiddle: BoxHeightStyle = nativeOnly
  [<IsConst>] static member includeLineSpacingTop: BoxHeightStyle = nativeOnly
  [<IsConst>] static member includeLineSpacingBottom: BoxHeightStyle = nativeOnly
  [<IsConst>] static member strut: BoxHeightStyle = nativeOnly
  [<IsConst>] static member values: BoxHeightStyle = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/BoxWidthStyle.html
[<ImportMember("dart:ui")>]
type BoxWidthStyle =
  [<IsConst>] static member tight: BoxWidthStyle = nativeOnly
  [<IsConst>] static member max: BoxWidthStyle = nativeOnly
  [<IsConst>] static member values: BoxWidthStyle = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/PlaceholderAlignment.html
[<ImportMember("dart:ui")>]
type PlaceholderAlignment =
  [<IsConst>] static member baseline: PlaceholderAlignment = nativeOnly
  [<IsConst>] static member aboveBaseline: PlaceholderAlignment = nativeOnly
  [<IsConst>] static member belowBaseline: PlaceholderAlignment = nativeOnly
  [<IsConst>] static member top: PlaceholderAlignment = nativeOnly
  [<IsConst>] static member bottom: PlaceholderAlignment = nativeOnly
  [<IsConst>] static member middle: PlaceholderAlignment = nativeOnly
  [<IsConst>] static member values: PlaceholderAlignment = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/Brightness.html
[<ImportMember("dart:ui")>]
type Brightness =
  [<IsConst>] static member dark: Brightness = nativeOnly
  [<IsConst>] static member light: Brightness = nativeOnly
  [<IsConst>] static member values: Brightness = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/ChannelBuffers-class.html
[<ImportMember("dart:ui")>]
type ChannelBuffers () =
  [<IsConst>] static member kDefaultBufferSize: int = nativeOnly
  [<IsConst>] static member kControlChannelName: string = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/Scene-class.html
[<ImportMember("dart:ui")>]
type Scene =
  class end

/// https://api.flutter.dev/flutter/dart-ui/TransformEngineLayer-class.html
[<ImportMember("dart:ui")>]
type TransformEngineLayer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/OffsetEngineLayer-class.html
[<ImportMember("dart:ui")>]
type OffsetEngineLayer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/ClipRectEngineLayer-class.html
[<ImportMember("dart:ui")>]
type ClipRectEngineLayer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/ClipRRectEngineLayer-class.html
[<ImportMember("dart:ui")>]
type ClipRRectEngineLayer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/ClipPathEngineLayer-class.html
[<ImportMember("dart:ui")>]
type ClipPathEngineLayer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/OpacityEngineLayer-class.html
[<ImportMember("dart:ui")>]
type OpacityEngineLayer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/ColorFilterEngineLayer-class.html
[<ImportMember("dart:ui")>]
type ColorFilterEngineLayer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/ImageFilterEngineLayer-class.html
[<ImportMember("dart:ui")>]
type ImageFilterEngineLayer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/BackdropFilterEngineLayer-class.html
[<ImportMember("dart:ui")>]
type BackdropFilterEngineLayer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/ShaderMaskEngineLayer-class.html
[<ImportMember("dart:ui")>]
type ShaderMaskEngineLayer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/PhysicalShapeEngineLayer-class.html
[<ImportMember("dart:ui")>]
type PhysicalShapeEngineLayer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/SceneBuilder-class.html
[<ImportMember("dart:ui")>]
type SceneBuilder () =
  class end

/// https://api.flutter.dev/flutter/dart-ui/OffsetBase-class.html
[<ImportMember("dart:ui")>]
type OffsetBase [<IsConst>] (_dx: float, _dy: float) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/Offset-class.html
[<ImportMember("dart:ui")>]
type Offset [<IsConst>] (dx: float, dy: float) =
  // inherit OffsetBase()
  static member fromDirection(direction: float, ?distance: float): Offset = nativeOnly
  [<IsConst>] static member zero: Offset = nativeOnly
  [<IsConst>] static member infinite: Offset = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/Size-class.html
[<ImportMember("dart:ui")>]
type Size [<IsConst>] (width: float, height: float) =
  // inherit OffsetBase()
  static member copy(source: Size): Size = nativeOnly
  [<IsConst>] static member square(dimension: float): Size = nativeOnly
  [<IsConst>] static member fromWidth(width: float): Size = nativeOnly
  [<IsConst>] static member fromHeight(height: float): Size = nativeOnly
  [<IsConst>] static member fromRadius(radius: float): Size = nativeOnly
  [<IsConst>] static member zero: Size = nativeOnly
  [<IsConst>] static member infinite: Size = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/Rect-class.html
[<ImportMember("dart:ui")>]
type Rect =
  [<IsConst>] static member fromLTRB(left: float, top: float, right: float, bottom: float): Rect = nativeOnly
  [<IsConst>] static member fromLTWH(left: float, top: float, width: float, height: float): Rect = nativeOnly
  [<NamedParams>] static member fromCircle(center: Offset, radius: float): Rect = nativeOnly
  [<NamedParams>] static member fromCenter(center: Offset, width: float, height: float): Rect = nativeOnly
  static member fromPoints(a: Offset, b: Offset): Rect = nativeOnly
  [<IsConst>] static member zero: Rect = nativeOnly
  [<IsConst>] static member largest: Rect = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/Radius-class.html
[<ImportMember("dart:ui")>]
type Radius =
  [<IsConst>] static member circular(radius: float): Radius = nativeOnly
  [<IsConst>] static member elliptical(x: float, y: float): Radius = nativeOnly
  [<IsConst>] static member zero: Radius = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/RRect-class.html
[<ImportMember("dart:ui")>]
type RRect =
  [<IsConst>] static member fromLTRBXY(left: float, top: float, right: float, bottom: float, radiusX: float, radiusY: float): RRect = nativeOnly
  static member fromLTRBR(left: float, top: float, right: float, bottom: float, radius: Radius): RRect = nativeOnly
  static member fromRectXY(rect: Rect, radiusX: float, radiusY: float): RRect = nativeOnly
  static member fromRectAndRadius(rect: Rect, radius: Radius): RRect = nativeOnly
  [<NamedParams(fromIndex=4)>] static member fromLTRBAndCorners(left: float, top: float, right: float, bottom: float, ?topLeft: Radius, ?topRight: Radius, ?bottomRight: Radius, ?bottomLeft: Radius): RRect = nativeOnly
  [<NamedParams(fromIndex=1)>] static member fromRectAndCorners(rect: Rect, ?topLeft: Radius, ?topRight: Radius, ?bottomRight: Radius, ?bottomLeft: Radius): RRect = nativeOnly
  [<IsConst>] static member zero: RRect = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/RSTransform-class.html
[<ImportMember("dart:ui")>]
type RSTransform (scos: float, ssin: float, tx: float, ty: float) =
  [<NamedParams>] static member fromComponents(rotation: float, scale: float, anchorX: float, anchorY: float, translateX: float, translateY: float): RSTransform = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/IsolateNameServer-class.html
[<ImportMember("dart:ui")>]
type IsolateNameServer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/KeyData-class.html
[<ImportMember("dart:ui")>]
type KeyData [<IsConst; NamedParams>] (timeStamp: TimeSpan, ``type``: KeyEventType, physical: int, logical: int, character: string option, synthesized: bool) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/DartPluginRegistrant-class.html
[<ImportMember("dart:ui")>]
type DartPluginRegistrant () =
  class end

/// https://api.flutter.dev/flutter/dart-ui/Color-class.html
[<ImportMember("dart:ui")>]
type Color [<IsConst>] (value: int) =
  [<IsConst>] static member fromARGB(a: int, r: int, g: int, b: int): Color = nativeOnly
  [<IsConst>] static member fromRGBO(r: int, g: int, b: int, opacity: float): Color = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/Paint-class.html
[<ImportMember("dart:ui")>]
type Paint () =
  class end

/// https://api.flutter.dev/flutter/dart-ui/Image-class.html
[<ImportMember("dart:ui")>]
type Image =
  class end

/// https://api.flutter.dev/flutter/dart-ui/FrameInfo-class.html
[<ImportMember("dart:ui")>]
type FrameInfo =
  class end

/// https://api.flutter.dev/flutter/dart-ui/Codec-class.html
[<ImportMember("dart:ui")>]
type Codec =
  class end

/// https://api.flutter.dev/flutter/dart-ui/EngineLayer-class.html
[<ImportMember("dart:ui")>]
type EngineLayer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/Path-class.html
[<ImportMember("dart:ui")>]
type Path () =
  static member from(source: Path): Path = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/Tangent-class.html
[<ImportMember("dart:ui")>]
type Tangent [<IsConst>] (position: Offset, vector: Offset) =
  static member fromAngle(position: Offset, angle: float): Tangent = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/PathMetrics-class.html
[<ImportMember("dart:ui")>]
type PathMetrics =
  class end

/// https://api.flutter.dev/flutter/dart-ui/PathMetricIterator-class.html
[<ImportMember("dart:ui")>]
type PathMetricIterator =
  class end

/// https://api.flutter.dev/flutter/dart-ui/PathMetric-class.html
[<ImportMember("dart:ui")>]
type PathMetric =
  class end

/// https://api.flutter.dev/flutter/dart-ui/MaskFilter-class.html
[<ImportMember("dart:ui")>]
type MaskFilter =
  [<IsConst>] static member blur(_style: BlurStyle, _sigma: float): MaskFilter = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/ColorFilter-class.html
[<ImportMember("dart:ui")>]
type ColorFilter =
  [<IsConst>] static member mode(color: Color, blendMode: BlendMode): ColorFilter = nativeOnly
  [<IsConst>] static member matrix(matrix: float[]): ColorFilter = nativeOnly
  [<IsConst>] static member linearToSrgbGamma(): ColorFilter = nativeOnly
  [<IsConst>] static member srgbToLinearGamma(): ColorFilter = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/ImageFilter-class.html
[<ImportMember("dart:ui")>]
type ImageFilter =
  [<NamedParams>] static member blur(?sigmaX: float, ?sigmaY: float, ?tileMode: TileMode): ImageFilter = nativeOnly
  [<NamedParams>] static member dilate(?radiusX: float, ?radiusY: float): ImageFilter = nativeOnly
  [<NamedParams>] static member erode(?radiusX: float, ?radiusY: float): ImageFilter = nativeOnly
  [<NamedParams(fromIndex=1)>] static member matrix(matrix4: float[], ?filterQuality: FilterQuality): ImageFilter = nativeOnly
  [<NamedParams>] static member compose(outer: ImageFilter, inner: ImageFilter): ImageFilter = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/Shader-class.html
[<ImportMember("dart:ui")>]
type Shader =
  interface end

/// https://api.flutter.dev/flutter/dart-ui/Gradient-class.html
[<ImportMember("dart:ui")>]
type Gradient =
  static member linear(from: Offset, ``to``: Offset, colors: Color[], ?colorStops: float[], ?tileMode: TileMode, ?matrix4: float[]): Gradient = nativeOnly
  static member radial(center: Offset, radius: float, colors: Color[], ?colorStops: float[], ?tileMode: TileMode, ?matrix4: float[], ?focal: Offset, ?focalRadius: float): Gradient = nativeOnly
  static member sweep(center: Offset, colors: Color[], ?colorStops: float[], ?tileMode: TileMode, ?startAngle: float, ?endAngle: float, ?matrix4: float[]): Gradient = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/ImageShader-class.html
[<ImportMember("dart:ui")>]
type ImageShader [<NamedParams(fromIndex=4)>] (image: Image, tmx: TileMode, tmy: TileMode, matrix4: float[], ?filterQuality: FilterQuality) =
  interface Shader

/// https://api.flutter.dev/flutter/dart-ui/FragmentProgram-class.html
[<ImportMember("dart:ui")>]
type FragmentProgram =
  class end

/// https://api.flutter.dev/flutter/dart-ui/Vertices-class.html
[<ImportMember("dart:ui")>]
type Vertices [<NamedParams(fromIndex=2)>] (mode: VertexMode, positions: Offset[], ?textureCoordinates: Offset[], ?colors: Color[], ?indices: int[]) =
  [<NamedParams(fromIndex=2)>] static member raw(mode: VertexMode, positions: single[], ?textureCoordinates: single[], ?colors: int[], ?indices: uint16[]): Vertices = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/Canvas-class.html
[<ImportMember("dart:ui")>]
type Canvas (recorder: PictureRecorder, ?cullRect: Rect) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/Picture-class.html
[<ImportMember("dart:ui")>]
type Picture =
  class end

/// https://api.flutter.dev/flutter/dart-ui/PictureRecorder-class.html
[<ImportMember("dart:ui")>]
type PictureRecorder () =
  class end

/// https://api.flutter.dev/flutter/dart-ui/Shadow-class.html
[<ImportMember("dart:ui")>]
type Shadow [<IsConst; NamedParams>] (?color: Color, ?offset: Offset, ?blurRadius: float) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/ImmutableBuffer-class.html
[<ImportMember("dart:ui")>]
type ImmutableBuffer =
  class end

/// https://api.flutter.dev/flutter/dart-ui/ImageDescriptor-class.html
[<ImportMember("dart:ui")>]
type ImageDescriptor =
  [<NamedParams(fromIndex=1)>] static member raw(buffer: ImmutableBuffer, width: int, height: int, pixelFormat: PixelFormat, ?rowBytes: int): ImageDescriptor = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/PlatformDispatcher-class.html
[<ImportMember("dart:ui")>]
type PlatformDispatcher =
  class end

/// https://api.flutter.dev/flutter/dart-ui/PlatformConfiguration-class.html
[<ImportMember("dart:ui")>]
type PlatformConfiguration [<IsConst; NamedParams>] (?accessibilityFeatures: AccessibilityFeatures, ?alwaysUse24HourFormat: bool, ?semanticsEnabled: bool, ?platformBrightness: Brightness, ?textScaleFactor: float, ?locales: Locale[], ?defaultRouteName: string, ?systemFontFamily: string) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/ViewConfiguration-class.html
[<ImportMember("dart:ui")>]
type ViewConfiguration [<IsConst; NamedParams>] (?window: FlutterView, ?devicePixelRatio: float, ?geometry: Rect, ?visible: bool, ?viewInsets: WindowPadding, ?viewPadding: WindowPadding, ?systemGestureInsets: WindowPadding, ?padding: WindowPadding, ?gestureSettings: GestureSettings, ?displayFeatures: DisplayFeature[]) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/FrameTiming-class.html
[<ImportMember("dart:ui")>]
type FrameTiming [<NamedParams>] (vsyncStart: int, buildStart: int, buildFinish: int, rasterStart: int, rasterFinish: int, rasterFinishWallTime: int, ?layerCacheCount: int, ?layerCacheBytes: int, ?pictureCacheCount: int, ?pictureCacheBytes: int, ?frameNumber: int) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/WindowPadding-class.html
[<ImportMember("dart:ui")>]
type WindowPadding =
  [<IsConst>] static member zero: WindowPadding = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/DisplayFeature-class.html
[<ImportMember("dart:ui")>]
type DisplayFeature [<IsConst; NamedParams>] (bounds: Rect, ``type``: DisplayFeatureType, state: DisplayFeatureState) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/Locale-class.html
[<ImportMember("dart:ui")>]
type Locale [<IsConst>] (_languageCode: string, ?_countryCode: string) =
  [<IsConst; NamedParams>] static member fromSubtags(?languageCode: string, ?scriptCode: string, ?countryCode: string): Locale = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/CallbackHandle-class.html
[<ImportMember("dart:ui")>]
type CallbackHandle =
  static member fromRawHandle(_handle: int): CallbackHandle = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/PluginUtilities-class.html
[<ImportMember("dart:ui")>]
type PluginUtilities =
  class end

/// https://api.flutter.dev/flutter/dart-ui/PointerData-class.html
[<ImportMember("dart:ui")>]
type PointerData [<IsConst; NamedParams>] (?embedderId: int, ?timeStamp: TimeSpan, ?change: PointerChange, ?kind: PointerDeviceKind, ?signalKind: PointerSignalKind, ?device: int, ?pointerIdentifier: int, ?physicalX: float, ?physicalY: float, ?physicalDeltaX: float, ?physicalDeltaY: float, ?buttons: int, ?obscured: bool, ?synthesized: bool, ?pressure: float, ?pressureMin: float, ?pressureMax: float, ?distance: float, ?distanceMax: float, ?size: float, ?radiusMajor: float, ?radiusMinor: float, ?radiusMin: float, ?radiusMax: float, ?orientation: float, ?tilt: float, ?platformData: int, ?scrollDeltaX: float, ?scrollDeltaY: float, ?panX: float, ?panY: float, ?panDeltaX: float, ?panDeltaY: float, ?scale: float, ?rotation: float) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/PointerDataPacket-class.html
[<ImportMember("dart:ui")>]
type PointerDataPacket [<IsConst; NamedParams>] (?data: PointerData[]) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/SemanticsAction-class.html
[<ImportMember("dart:ui")>]
type SemanticsAction =
  [<IsConst>] static member tap: SemanticsAction = nativeOnly
  [<IsConst>] static member longPress: SemanticsAction = nativeOnly
  [<IsConst>] static member scrollLeft: SemanticsAction = nativeOnly
  [<IsConst>] static member scrollRight: SemanticsAction = nativeOnly
  [<IsConst>] static member scrollUp: SemanticsAction = nativeOnly
  [<IsConst>] static member scrollDown: SemanticsAction = nativeOnly
  [<IsConst>] static member increase: SemanticsAction = nativeOnly
  [<IsConst>] static member decrease: SemanticsAction = nativeOnly
  [<IsConst>] static member showOnScreen: SemanticsAction = nativeOnly
  [<IsConst>] static member moveCursorForwardByCharacter: SemanticsAction = nativeOnly
  [<IsConst>] static member moveCursorBackwardByCharacter: SemanticsAction = nativeOnly
  [<IsConst>] static member setText: SemanticsAction = nativeOnly
  [<IsConst>] static member setSelection: SemanticsAction = nativeOnly
  [<IsConst>] static member copy: SemanticsAction = nativeOnly
  [<IsConst>] static member cut: SemanticsAction = nativeOnly
  [<IsConst>] static member paste: SemanticsAction = nativeOnly
  [<IsConst>] static member didGainAccessibilityFocus: SemanticsAction = nativeOnly
  [<IsConst>] static member didLoseAccessibilityFocus: SemanticsAction = nativeOnly
  [<IsConst>] static member customAction: SemanticsAction = nativeOnly
  [<IsConst>] static member dismiss: SemanticsAction = nativeOnly
  [<IsConst>] static member moveCursorForwardByWord: SemanticsAction = nativeOnly
  [<IsConst>] static member moveCursorBackwardByWord: SemanticsAction = nativeOnly
  [<IsConst>] static member values: Dictionary<int, SemanticsAction> = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/SemanticsFlag-class.html
[<ImportMember("dart:ui")>]
type SemanticsFlag =
  [<IsConst>] static member hasCheckedState: SemanticsFlag = nativeOnly
  [<IsConst>] static member isChecked: SemanticsFlag = nativeOnly
  [<IsConst>] static member isSelected: SemanticsFlag = nativeOnly
  [<IsConst>] static member isButton: SemanticsFlag = nativeOnly
  [<IsConst>] static member isTextField: SemanticsFlag = nativeOnly
  [<IsConst>] static member isSlider: SemanticsFlag = nativeOnly
  [<IsConst>] static member isKeyboardKey: SemanticsFlag = nativeOnly
  [<IsConst>] static member isReadOnly: SemanticsFlag = nativeOnly
  [<IsConst>] static member isLink: SemanticsFlag = nativeOnly
  [<IsConst>] static member isFocusable: SemanticsFlag = nativeOnly
  [<IsConst>] static member isFocused: SemanticsFlag = nativeOnly
  [<IsConst>] static member hasEnabledState: SemanticsFlag = nativeOnly
  [<IsConst>] static member isEnabled: SemanticsFlag = nativeOnly
  [<IsConst>] static member isInMutuallyExclusiveGroup: SemanticsFlag = nativeOnly
  [<IsConst>] static member isHeader: SemanticsFlag = nativeOnly
  [<IsConst>] static member isObscured: SemanticsFlag = nativeOnly
  [<IsConst>] static member isMultiline: SemanticsFlag = nativeOnly
  [<IsConst>] static member scopesRoute: SemanticsFlag = nativeOnly
  [<IsConst>] static member namesRoute: SemanticsFlag = nativeOnly
  [<IsConst>] static member isHidden: SemanticsFlag = nativeOnly
  [<IsConst>] static member isImage: SemanticsFlag = nativeOnly
  [<IsConst>] static member isLiveRegion: SemanticsFlag = nativeOnly
  [<IsConst>] static member hasToggledState: SemanticsFlag = nativeOnly
  [<IsConst>] static member isToggled: SemanticsFlag = nativeOnly
  [<IsConst>] static member hasImplicitScrolling: SemanticsFlag = nativeOnly
  [<IsConst>] static member values: Dictionary<int, SemanticsFlag> = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/StringAttribute-class.html
[<ImportMember("dart:ui")>]
type StringAttribute =
  interface end

/// https://api.flutter.dev/flutter/dart-ui/SpellOutStringAttribute-class.html
[<ImportMember("dart:ui")>]
type SpellOutStringAttribute [<NamedParams>] (range: TextRange) =
  interface StringAttribute

/// https://api.flutter.dev/flutter/dart-ui/LocaleStringAttribute-class.html
[<ImportMember("dart:ui")>]
type LocaleStringAttribute [<NamedParams>] (range: TextRange, locale: Locale) =
  interface StringAttribute

/// https://api.flutter.dev/flutter/dart-ui/SemanticsUpdateBuilder-class.html
[<ImportMember("dart:ui")>]
type SemanticsUpdateBuilder () =
  class end

/// https://api.flutter.dev/flutter/dart-ui/SemanticsUpdate-class.html
[<ImportMember("dart:ui")>]
type SemanticsUpdate =
  class end

/// https://api.flutter.dev/flutter/dart-ui/FontWeight-class.html
[<ImportMember("dart:ui")>]
type FontWeight =
  [<IsConst>] static member w100: FontWeight = nativeOnly
  [<IsConst>] static member w200: FontWeight = nativeOnly
  [<IsConst>] static member w300: FontWeight = nativeOnly
  [<IsConst>] static member w400: FontWeight = nativeOnly
  [<IsConst>] static member w500: FontWeight = nativeOnly
  [<IsConst>] static member w600: FontWeight = nativeOnly
  [<IsConst>] static member w700: FontWeight = nativeOnly
  [<IsConst>] static member w800: FontWeight = nativeOnly
  [<IsConst>] static member w900: FontWeight = nativeOnly
  [<IsConst>] static member normal: FontWeight = nativeOnly
  [<IsConst>] static member bold: FontWeight = nativeOnly
  [<IsConst>] static member values: FontWeight[] = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/FontFeature-class.html
[<ImportMember("dart:ui")>]
type FontFeature [<IsConst>] (feature: string, ?value: int) =
  [<IsConst>] static member enable(feature: string): FontFeature = nativeOnly
  [<IsConst>] static member disable(feature: string): FontFeature = nativeOnly
  [<IsConst>] static member alternative(value: int): FontFeature = nativeOnly
  [<IsConst>] static member alternativeFractions(): FontFeature = nativeOnly
  [<IsConst>] static member contextualAlternates(): FontFeature = nativeOnly
  [<IsConst>] static member caseSensitiveForms(): FontFeature = nativeOnly
  static member characterVariant(value: int): FontFeature = nativeOnly
  [<IsConst>] static member denominator(): FontFeature = nativeOnly
  [<IsConst>] static member fractions(): FontFeature = nativeOnly
  [<IsConst>] static member historicalForms(): FontFeature = nativeOnly
  [<IsConst>] static member historicalLigatures(): FontFeature = nativeOnly
  [<IsConst>] static member liningFigures(): FontFeature = nativeOnly
  [<IsConst; NamedParams>] static member localeAware(?enable: bool): FontFeature = nativeOnly
  [<IsConst>] static member notationalForms(?value: int): FontFeature = nativeOnly
  [<IsConst>] static member numerators(): FontFeature = nativeOnly
  [<IsConst>] static member oldstyleFigures(): FontFeature = nativeOnly
  [<IsConst>] static member ordinalForms(): FontFeature = nativeOnly
  [<IsConst>] static member proportionalFigures(): FontFeature = nativeOnly
  [<IsConst>] static member randomize(): FontFeature = nativeOnly
  [<IsConst>] static member stylisticAlternates(): FontFeature = nativeOnly
  [<IsConst>] static member scientificInferiors(): FontFeature = nativeOnly
  static member stylisticSet(value: int): FontFeature = nativeOnly
  [<IsConst>] static member subscripts(): FontFeature = nativeOnly
  [<IsConst>] static member superscripts(): FontFeature = nativeOnly
  [<IsConst>] static member swash(?value: int): FontFeature = nativeOnly
  [<IsConst>] static member tabularFigures(): FontFeature = nativeOnly
  [<IsConst>] static member slashedZero(): FontFeature = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/FontVariation-class.html
[<ImportMember("dart:ui")>]
type FontVariation [<IsConst>] (axis: string, value: float) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/TextDecoration-class.html
[<ImportMember("dart:ui")>]
type TextDecoration =
  static member combine(decorations: TextDecoration[]): TextDecoration = nativeOnly
  [<IsConst>] static member none: TextDecoration = nativeOnly
  [<IsConst>] static member underline: TextDecoration = nativeOnly
  [<IsConst>] static member overline: TextDecoration = nativeOnly
  [<IsConst>] static member lineThrough: TextDecoration = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/TextHeightBehavior-class.html
[<ImportMember("dart:ui")>]
type TextHeightBehavior [<IsConst; NamedParams>] (?applyHeightToFirstAscent: bool, ?applyHeightToLastDescent: bool, ?leadingDistribution: TextLeadingDistribution) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/TextStyle-class.html
[<ImportMember("dart:ui")>]
type TextStyle [<NamedParams>] (?color: Color, ?decoration: TextDecoration, ?decorationColor: Color, ?decorationStyle: TextDecorationStyle, ?decorationThickness: float, ?fontWeight: FontWeight, ?fontStyle: FontStyle, ?textBaseline: TextBaseline, ?fontFamily: string, ?fontFamilyFallback: string[], ?fontSize: float, ?letterSpacing: float, ?wordSpacing: float, ?height: float, ?leadingDistribution: TextLeadingDistribution, ?locale: Locale, ?background: Paint, ?foreground: Paint, ?shadows: Shadow[], ?fontFeatures: FontFeature[], ?fontVariations: FontVariation[]) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/ParagraphStyle-class.html
[<ImportMember("dart:ui")>]
type ParagraphStyle [<NamedParams>] (?textAlign: TextAlign, ?textDirection: TextDirection, ?maxLines: int, ?fontFamily: string, ?fontSize: float, ?height: float, ?textHeightBehavior: TextHeightBehavior, ?fontWeight: FontWeight, ?fontStyle: FontStyle, ?strutStyle: StrutStyle, ?ellipsis: string, ?locale: Locale) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/StrutStyle-class.html
[<ImportMember("dart:ui")>]
type StrutStyle [<NamedParams>] (?fontFamily: string, ?fontFamilyFallback: string[], ?fontSize: float, ?height: float, ?leadingDistribution: TextLeadingDistribution, ?leading: float, ?fontWeight: FontWeight, ?fontStyle: FontStyle, ?forceStrutHeight: bool) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/TextBox-class.html
[<ImportMember("dart:ui")>]
type TextBox =
  [<IsConst>] static member fromLTRBD(left: float, top: float, right: float, bottom: float, direction: TextDirection): TextBox = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/TextPosition-class.html
[<ImportMember("dart:ui")>]
type TextPosition [<IsConst; NamedParams>] (offset: int, ?affinity: TextAffinity) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/TextRange-class.html
[<ImportMember("dart:ui")>]
type TextRange [<IsConst; NamedParams>] (start: int, ``end``: int) =
  [<IsConst>] static member collapsed(offset: int): TextRange = nativeOnly
  [<IsConst>] static member empty: TextRange = nativeOnly

/// https://api.flutter.dev/flutter/dart-ui/ParagraphConstraints-class.html
[<ImportMember("dart:ui")>]
type ParagraphConstraints [<IsConst; NamedParams>] (width: float) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/LineMetrics-class.html
[<ImportMember("dart:ui")>]
type LineMetrics [<NamedParams>] (hardBreak: bool, ascent: float, descent: float, unscaledAscent: float, height: float, width: float, left: float, baseline: float, lineNumber: int) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/Paragraph-class.html
[<ImportMember("dart:ui")>]
type Paragraph =
  class end

/// https://api.flutter.dev/flutter/dart-ui/ParagraphBuilder-class.html
[<ImportMember("dart:ui")>]
type ParagraphBuilder (style: ParagraphStyle) =
  class end

/// https://api.flutter.dev/flutter/dart-ui/FlutterView-class.html
[<ImportMember("dart:ui")>]
type FlutterView () =
  class end

/// https://api.flutter.dev/flutter/dart-ui/FlutterWindow-class.html
[<ImportMember("dart:ui")>]
type FlutterWindow =
  class end

/// https://api.flutter.dev/flutter/dart-ui/SingletonFlutterWindow-class.html
[<ImportMember("dart:ui")>]
type SingletonFlutterWindow =
  class end

/// https://api.flutter.dev/flutter/dart-ui/AccessibilityFeatures-class.html
[<ImportMember("dart:ui")>]
type AccessibilityFeatures =
  class end

/// https://api.flutter.dev/flutter/dart-ui/FrameData-class.html
[<ImportMember("dart:ui")>]
type FrameData =
  class end

/// https://api.flutter.dev/flutter/dart-ui/GestureSettings-class.html
[<ImportMember("dart:ui")>]
type GestureSettings [<IsConst; NamedParams>] (?physicalTouchSlop: float, ?physicalDoubleTapSlop: float) =
  class end

[<ImportAll("dart:ui")>]
type UI =
  /// https://api.flutter.dev/flutter/dart-ui/hashValues.html
  static member hashValues(arg01: obj option, arg02: obj option, ?arg03: obj, ?arg04: obj, ?arg05: obj, ?arg06: obj, ?arg07: obj, ?arg08: obj, ?arg09: obj, ?arg10: obj, ?arg11: obj, ?arg12: obj, ?arg13: obj, ?arg14: obj, ?arg15: obj, ?arg16: obj, ?arg17: obj, ?arg18: obj, ?arg19: obj, ?arg20: obj): int = nativeOnly
  /// https://api.flutter.dev/flutter/dart-ui/hashList.html
  static member hashList(arguments: obj option seq option): int = nativeOnly
  /// https://api.flutter.dev/flutter/dart-ui/lerpDouble.html
  static member lerpDouble(a: int option, b: int option, t: float): float option = nativeOnly
  /// https://api.flutter.dev/flutter/dart-ui/lerpDouble.html
  static member lerpDouble(a: float option, b: float option, t: float): float option = nativeOnly
  /// https://api.flutter.dev/flutter/dart-ui/saveCompilationTrace.html
  static member saveCompilationTrace(): int[] = nativeOnly
  /// https://api.flutter.dev/flutter/dart-ui/instantiateImageCodec.html
  [<NamedParams(fromIndex=1)>] static member instantiateImageCodec(list: byte[], ?targetWidth: int, ?targetHeight: int, ?allowUpscaling: bool): Future<Codec> = nativeOnly
  /// https://api.flutter.dev/flutter/dart-ui/decodeImageFromList.html
  static member decodeImageFromList(list: byte[], callback: (Image -> unit)): unit = nativeOnly
  /// https://api.flutter.dev/flutter/dart-ui/decodeImageFromPixels.html
  [<NamedParams(fromIndex=5)>] static member decodeImageFromPixels(pixels: byte[], width: int, height: int, format: PixelFormat, callback: (Image -> unit), ?rowBytes: int, ?targetWidth: int, ?targetHeight: int, ?allowUpscaling: bool): unit = nativeOnly
  /// https://api.flutter.dev/flutter/dart-ui/loadFontFromList.html
  [<NamedParams(fromIndex=1)>] static member loadFontFromList(list: byte[], ?fontFamily: string): Future<unit> = nativeOnly
