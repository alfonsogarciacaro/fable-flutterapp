namespace rec Flutter.Painting

open System
open System.Collections.Generic
open Fable.Core
open Fable.Core.Dart
open Dart
open Flutter.Foundation
open Flutter.Gestures
open Flutter.Services

/// https://api.flutter.dev/flutter/painting/RenderComparison.html
[<ImportMember("package:flutter/painting.dart")>]
type RenderComparison =
  [<IsConst>] static member identical: RenderComparison = nativeOnly
  [<IsConst>] static member metadata: RenderComparison = nativeOnly
  [<IsConst>] static member paint: RenderComparison = nativeOnly
  [<IsConst>] static member layout: RenderComparison = nativeOnly
  [<IsConst>] static member values: RenderComparison = nativeOnly

/// https://api.flutter.dev/flutter/painting/Axis.html
[<ImportMember("package:flutter/painting.dart")>]
type Axis =
  [<IsConst>] static member horizontal: Axis = nativeOnly
  [<IsConst>] static member vertical: Axis = nativeOnly
  [<IsConst>] static member values: Axis = nativeOnly

/// https://api.flutter.dev/flutter/painting/VerticalDirection.html
[<ImportMember("package:flutter/painting.dart")>]
type VerticalDirection =
  [<IsConst>] static member up: VerticalDirection = nativeOnly
  [<IsConst>] static member down: VerticalDirection = nativeOnly
  [<IsConst>] static member values: VerticalDirection = nativeOnly

/// https://api.flutter.dev/flutter/painting/AxisDirection.html
[<ImportMember("package:flutter/painting.dart")>]
type AxisDirection =
  [<IsConst>] static member up: AxisDirection = nativeOnly
  [<IsConst>] static member right: AxisDirection = nativeOnly
  [<IsConst>] static member down: AxisDirection = nativeOnly
  [<IsConst>] static member left: AxisDirection = nativeOnly
  [<IsConst>] static member values: AxisDirection = nativeOnly

/// https://api.flutter.dev/flutter/painting/BorderStyle.html
[<ImportMember("package:flutter/painting.dart")>]
type BorderStyle =
  [<IsConst>] static member none: BorderStyle = nativeOnly
  [<IsConst>] static member solid: BorderStyle = nativeOnly
  [<IsConst>] static member values: BorderStyle = nativeOnly

/// https://api.flutter.dev/flutter/painting/BoxShape.html
[<ImportMember("package:flutter/painting.dart")>]
type BoxShape =
  [<IsConst>] static member rectangle: BoxShape = nativeOnly
  [<IsConst>] static member circle: BoxShape = nativeOnly
  [<IsConst>] static member values: BoxShape = nativeOnly

/// https://api.flutter.dev/flutter/painting/BoxFit.html
[<ImportMember("package:flutter/painting.dart")>]
type BoxFit =
  [<IsConst>] static member fill: BoxFit = nativeOnly
  [<IsConst>] static member contain: BoxFit = nativeOnly
  [<IsConst>] static member cover: BoxFit = nativeOnly
  [<IsConst>] static member fitWidth: BoxFit = nativeOnly
  [<IsConst>] static member fitHeight: BoxFit = nativeOnly
  [<IsConst>] static member none: BoxFit = nativeOnly
  [<IsConst>] static member scaleDown: BoxFit = nativeOnly
  [<IsConst>] static member values: BoxFit = nativeOnly

/// https://api.flutter.dev/flutter/painting/ImageRepeat.html
[<ImportMember("package:flutter/painting.dart")>]
type ImageRepeat =
  [<IsConst>] static member repeat: ImageRepeat = nativeOnly
  [<IsConst>] static member repeatX: ImageRepeat = nativeOnly
  [<IsConst>] static member repeatY: ImageRepeat = nativeOnly
  [<IsConst>] static member noRepeat: ImageRepeat = nativeOnly
  [<IsConst>] static member values: ImageRepeat = nativeOnly

/// https://api.flutter.dev/flutter/painting/FlutterLogoStyle.html
[<ImportMember("package:flutter/painting.dart")>]
type FlutterLogoStyle =
  [<IsConst>] static member markOnly: FlutterLogoStyle = nativeOnly
  [<IsConst>] static member horizontal: FlutterLogoStyle = nativeOnly
  [<IsConst>] static member stacked: FlutterLogoStyle = nativeOnly
  [<IsConst>] static member values: FlutterLogoStyle = nativeOnly

/// https://api.flutter.dev/flutter/painting/TextOverflow.html
[<ImportMember("package:flutter/painting.dart")>]
type TextOverflow =
  [<IsConst>] static member clip: TextOverflow = nativeOnly
  [<IsConst>] static member fade: TextOverflow = nativeOnly
  [<IsConst>] static member ellipsis: TextOverflow = nativeOnly
  [<IsConst>] static member visible: TextOverflow = nativeOnly
  [<IsConst>] static member values: TextOverflow = nativeOnly

/// https://api.flutter.dev/flutter/painting/TextWidthBasis.html
[<ImportMember("package:flutter/painting.dart")>]
type TextWidthBasis =
  [<IsConst>] static member parent: TextWidthBasis = nativeOnly
  [<IsConst>] static member longestLine: TextWidthBasis = nativeOnly
  [<IsConst>] static member values: TextWidthBasis = nativeOnly

/// https://api.flutter.dev/flutter/painting/AlignmentGeometry-class.html
[<ImportMember("package:flutter/painting.dart")>]
type AlignmentGeometry [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/painting/Alignment-class.html
[<ImportMember("package:flutter/painting.dart")>]
type Alignment [<IsConst>] (x: float, y: float) =
  [<IsConst>] static member topLeft: Alignment = nativeOnly
  [<IsConst>] static member topCenter: Alignment = nativeOnly
  [<IsConst>] static member topRight: Alignment = nativeOnly
  [<IsConst>] static member centerLeft: Alignment = nativeOnly
  [<IsConst>] static member center: Alignment = nativeOnly
  [<IsConst>] static member centerRight: Alignment = nativeOnly
  [<IsConst>] static member bottomLeft: Alignment = nativeOnly
  [<IsConst>] static member bottomCenter: Alignment = nativeOnly
  [<IsConst>] static member bottomRight: Alignment = nativeOnly

/// https://api.flutter.dev/flutter/painting/AlignmentDirectional-class.html
[<ImportMember("package:flutter/painting.dart")>]
type AlignmentDirectional [<IsConst>] (start: float, y: float) =
  [<IsConst>] static member topStart: AlignmentDirectional = nativeOnly
  [<IsConst>] static member topCenter: AlignmentDirectional = nativeOnly
  [<IsConst>] static member topEnd: AlignmentDirectional = nativeOnly
  [<IsConst>] static member centerStart: AlignmentDirectional = nativeOnly
  [<IsConst>] static member center: AlignmentDirectional = nativeOnly
  [<IsConst>] static member centerEnd: AlignmentDirectional = nativeOnly
  [<IsConst>] static member bottomStart: AlignmentDirectional = nativeOnly
  [<IsConst>] static member bottomCenter: AlignmentDirectional = nativeOnly
  [<IsConst>] static member bottomEnd: AlignmentDirectional = nativeOnly

/// https://api.flutter.dev/flutter/painting/TextAlignVertical-class.html
[<ImportMember("package:flutter/painting.dart")>]
type TextAlignVertical [<IsConst; NamedParams>] (y: float) =
  [<IsConst>] static member top: TextAlignVertical = nativeOnly
  [<IsConst>] static member center: TextAlignVertical = nativeOnly
  [<IsConst>] static member bottom: TextAlignVertical = nativeOnly

/// https://api.flutter.dev/flutter/painting/BeveledRectangleBorder-class.html
[<ImportMember("package:flutter/painting.dart")>]
type BeveledRectangleBorder [<IsConst; NamedParams>] (?side: BorderSide, ?borderRadius: BorderRadiusGeometry) =
  class end

/// https://api.flutter.dev/flutter/painting/BorderRadiusGeometry-class.html
[<ImportMember("package:flutter/painting.dart")>]
type BorderRadiusGeometry [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/painting/BorderRadius-class.html
[<ImportMember("package:flutter/painting.dart")>]
type BorderRadius =
  [<IsConst>] static member all(radius: Radius): BorderRadius = nativeOnly
  static member circular(radius: float): BorderRadius = nativeOnly
  [<IsConst; NamedParams>] static member vertical(?top: Radius, ?bottom: Radius): BorderRadius = nativeOnly
  [<IsConst; NamedParams>] static member horizontal(?left: Radius, ?right: Radius): BorderRadius = nativeOnly
  [<IsConst; NamedParams>] static member only(?topLeft: Radius, ?topRight: Radius, ?bottomLeft: Radius, ?bottomRight: Radius): BorderRadius = nativeOnly
  [<IsConst>] static member zero: BorderRadius = nativeOnly

/// https://api.flutter.dev/flutter/painting/BorderRadiusDirectional-class.html
[<ImportMember("package:flutter/painting.dart")>]
type BorderRadiusDirectional =
  [<IsConst>] static member all(radius: Radius): BorderRadiusDirectional = nativeOnly
  static member circular(radius: float): BorderRadiusDirectional = nativeOnly
  [<IsConst; NamedParams>] static member vertical(?top: Radius, ?bottom: Radius): BorderRadiusDirectional = nativeOnly
  [<IsConst; NamedParams>] static member horizontal(?start: Radius, ?``end``: Radius): BorderRadiusDirectional = nativeOnly
  [<IsConst; NamedParams>] static member only(?topStart: Radius, ?topEnd: Radius, ?bottomStart: Radius, ?bottomEnd: Radius): BorderRadiusDirectional = nativeOnly
  [<IsConst>] static member zero: BorderRadiusDirectional = nativeOnly

/// https://api.flutter.dev/flutter/painting/BorderSide-class.html
[<ImportMember("package:flutter/painting.dart")>]
type BorderSide [<IsConst; NamedParams>] (?color: Color, ?width: float, ?style: BorderStyle) =
  [<IsConst>] static member none: BorderSide = nativeOnly

/// https://api.flutter.dev/flutter/painting/ShapeBorder-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ShapeBorder [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/painting/OutlinedBorder-class.html
[<ImportMember("package:flutter/painting.dart")>]
type OutlinedBorder [<IsConst; NamedParams>] (?side: BorderSide) =
  class end

/// https://api.flutter.dev/flutter/painting/BoxBorder-class.html
[<ImportMember("package:flutter/painting.dart")>]
type BoxBorder [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/painting/Border-class.html
[<ImportMember("package:flutter/painting.dart")>]
type Border [<IsConst; NamedParams>] (?top: BorderSide, ?right: BorderSide, ?bottom: BorderSide, ?left: BorderSide) =
  [<IsConst>] static member fromBorderSide(side: BorderSide): Border = nativeOnly
  [<IsConst; NamedParams>] static member symmetric(?vertical: BorderSide, ?horizontal: BorderSide): Border = nativeOnly
  [<NamedParams>] static member all(?color: Color, ?width: float, ?style: BorderStyle): Border = nativeOnly

/// https://api.flutter.dev/flutter/painting/BorderDirectional-class.html
[<ImportMember("package:flutter/painting.dart")>]
type BorderDirectional [<IsConst; NamedParams>] (?top: BorderSide, ?start: BorderSide, ?``end``: BorderSide, ?bottom: BorderSide) =
  class end

/// https://api.flutter.dev/flutter/painting/BoxDecoration-class.html
[<ImportMember("package:flutter/painting.dart")>]
type BoxDecoration [<IsConst; NamedParams>] (?color: Color, ?image: DecorationImage, ?border: BoxBorder, ?borderRadius: BorderRadiusGeometry, ?boxShadow: BoxShadow[], ?gradient: Gradient, ?backgroundBlendMode: BlendMode, ?shape: BoxShape) =
  class end

/// https://api.flutter.dev/flutter/painting/FittedSizes-class.html
[<ImportMember("package:flutter/painting.dart")>]
type FittedSizes [<IsConst>] (source: Size, destination: Size) =
  class end

/// https://api.flutter.dev/flutter/painting/BoxShadow-class.html
[<ImportMember("package:flutter/painting.dart")>]
type BoxShadow [<IsConst; NamedParams>] (?color: Color, ?offset: Offset, ?blurRadius: float, ?spreadRadius: float, ?blurStyle: BlurStyle) =
  inherit Shadow()

/// https://api.flutter.dev/flutter/painting/CircleBorder-class.html
[<ImportMember("package:flutter/painting.dart")>]
type CircleBorder [<IsConst; NamedParams>] (?side: BorderSide) =
  class end

/// https://api.flutter.dev/flutter/painting/ClipContext-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ClipContext () =
  class end

/// https://api.flutter.dev/flutter/painting/HSVColor-class.html
[<ImportMember("package:flutter/painting.dart")>]
type HSVColor =
  [<IsConst>] static member fromAHSV(alpha: float, hue: float, saturation: float, value: float): HSVColor = nativeOnly
  static member fromColor(color: Color): HSVColor = nativeOnly

/// https://api.flutter.dev/flutter/painting/HSLColor-class.html
[<ImportMember("package:flutter/painting.dart")>]
type HSLColor =
  [<IsConst>] static member fromAHSL(alpha: float, hue: float, saturation: float, lightness: float): HSLColor = nativeOnly
  static member fromColor(color: Color): HSLColor = nativeOnly

/// https://api.flutter.dev/flutter/painting/ColorSwatch-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ColorSwatch<'T> [<IsConst>] (primary: int, _swatch: Dictionary<'T, Color>) =
  inherit Color(0)

/// https://api.flutter.dev/flutter/painting/ColorProperty-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ColorProperty [<NamedParams(fromIndex=2)>] (name: string, value: Color option, ?showName: bool, ?defaultValue: obj, ?style: DiagnosticsTreeStyle, ?level: DiagnosticLevel) =
  class end

/// https://api.flutter.dev/flutter/painting/ContinuousRectangleBorder-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ContinuousRectangleBorder [<IsConst; NamedParams>] (?side: BorderSide, ?borderRadius: BorderRadiusGeometry) =
  class end

/// https://api.flutter.dev/flutter/painting/ImageSizeInfo-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ImageSizeInfo [<IsConst; NamedParams>] (displaySize: Size, imageSize: Size, ?source: string) =
  class end

/// https://api.flutter.dev/flutter/painting/Decoration-class.html
[<ImportMember("package:flutter/painting.dart")>]
type Decoration [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/painting/BoxPainter-class.html
[<ImportMember("package:flutter/painting.dart")>]
type BoxPainter [<IsConst>] (?onChanged: (unit -> unit)) =
  class end

/// https://api.flutter.dev/flutter/painting/DecorationImage-class.html
[<ImportMember("package:flutter/painting.dart")>]
type DecorationImage [<IsConst; NamedParams>] (image: ImageProvider<obj>, ?onError: (obj -> StackTrace option -> unit), ?colorFilter: ColorFilter, ?fit: BoxFit, ?alignment: AlignmentGeometry, ?centerSlice: Rect, ?repeat: ImageRepeat, ?matchTextDirection: bool, ?scale: float, ?opacity: float, ?filterQuality: FilterQuality, ?invertColors: bool, ?isAntiAlias: bool) =
  class end

/// https://api.flutter.dev/flutter/painting/DecorationImagePainter-class.html
[<ImportMember("package:flutter/painting.dart")>]
type DecorationImagePainter =
  class end

/// https://api.flutter.dev/flutter/painting/EdgeInsetsGeometry-class.html
[<ImportMember("package:flutter/painting.dart")>]
type EdgeInsetsGeometry [<IsConst>] () =
  [<IsConst>] static member infinity: EdgeInsetsGeometry = nativeOnly

/// https://api.flutter.dev/flutter/painting/EdgeInsets-class.html
[<ImportMember("package:flutter/painting.dart")>]
type EdgeInsets =
  [<IsConst>] static member fromLTRB(left: float, top: float, right: float, bottom: float): EdgeInsets = nativeOnly
  [<IsConst>] static member all(value: float): EdgeInsets = nativeOnly
  [<IsConst; NamedParams>] static member only(?left: float, ?top: float, ?right: float, ?bottom: float): EdgeInsets = nativeOnly
  [<IsConst; NamedParams>] static member symmetric(?vertical: float, ?horizontal: float): EdgeInsets = nativeOnly
  static member fromWindowPadding(padding: WindowPadding, devicePixelRatio: float): EdgeInsets = nativeOnly
  [<IsConst>] static member zero: EdgeInsets = nativeOnly

/// https://api.flutter.dev/flutter/painting/EdgeInsetsDirectional-class.html
[<ImportMember("package:flutter/painting.dart")>]
type EdgeInsetsDirectional =
  [<IsConst>] static member fromSTEB(start: float, top: float, ``end``: float, bottom: float): EdgeInsetsDirectional = nativeOnly
  [<IsConst; NamedParams>] static member only(?start: float, ?top: float, ?``end``: float, ?bottom: float): EdgeInsetsDirectional = nativeOnly
  [<IsConst>] static member all(value: float): EdgeInsetsDirectional = nativeOnly
  [<IsConst>] static member zero: EdgeInsetsDirectional = nativeOnly

/// https://api.flutter.dev/flutter/painting/FlutterLogoDecoration-class.html
[<ImportMember("package:flutter/painting.dart")>]
type FlutterLogoDecoration [<IsConst; NamedParams>] (?textColor: Color, ?style: FlutterLogoStyle, ?margin: EdgeInsets) =
  class end

/// https://api.flutter.dev/flutter/painting/FractionalOffset-class.html
[<ImportMember("package:flutter/painting.dart")>]
type FractionalOffset [<IsConst>] (dx: float, dy: float) =
  static member fromOffsetAndSize(offset: Offset, size: Size): FractionalOffset = nativeOnly
  static member fromOffsetAndRect(offset: Offset, rect: Rect): FractionalOffset = nativeOnly
  [<IsConst>] static member topLeft: FractionalOffset = nativeOnly
  [<IsConst>] static member topCenter: FractionalOffset = nativeOnly
  [<IsConst>] static member topRight: FractionalOffset = nativeOnly
  [<IsConst>] static member centerLeft: FractionalOffset = nativeOnly
  [<IsConst>] static member center: FractionalOffset = nativeOnly
  [<IsConst>] static member centerRight: FractionalOffset = nativeOnly
  [<IsConst>] static member bottomLeft: FractionalOffset = nativeOnly
  [<IsConst>] static member bottomCenter: FractionalOffset = nativeOnly
  [<IsConst>] static member bottomRight: FractionalOffset = nativeOnly

/// https://api.flutter.dev/flutter/painting/GradientTransform-class.html
[<ImportMember("package:flutter/painting.dart")>]
type GradientTransform [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/painting/GradientRotation-class.html
[<ImportMember("package:flutter/painting.dart")>]
type GradientRotation [<IsConst>] (radians: float) =
  class end

/// https://api.flutter.dev/flutter/painting/Gradient-class.html
[<ImportMember("package:flutter/painting.dart")>]
type Gradient [<IsConst; NamedParams>] (colors: Color[], ?stops: float[], ?transform: GradientTransform) =
  class end

/// https://api.flutter.dev/flutter/painting/LinearGradient-class.html
[<ImportMember("package:flutter/painting.dart")>]
type LinearGradient [<IsConst; NamedParams>] (colors: Color[], ?``begin``: AlignmentGeometry, ?``end``: AlignmentGeometry, ?stops: float[], ?tileMode: TileMode, ?transform: GradientTransform) =
  class end

/// https://api.flutter.dev/flutter/painting/RadialGradient-class.html
[<ImportMember("package:flutter/painting.dart")>]
type RadialGradient [<IsConst; NamedParams>] (colors: Color[], ?center: AlignmentGeometry, ?radius: float, ?stops: float[], ?tileMode: TileMode, ?focal: AlignmentGeometry, ?focalRadius: float, ?transform: GradientTransform) =
  class end

/// https://api.flutter.dev/flutter/painting/SweepGradient-class.html
[<ImportMember("package:flutter/painting.dart")>]
type SweepGradient [<IsConst; NamedParams>] (colors: Color[], ?center: AlignmentGeometry, ?startAngle: float, ?endAngle: float, ?stops: float[], ?tileMode: TileMode, ?transform: GradientTransform) =
  class end

/// https://api.flutter.dev/flutter/painting/ImageCache-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ImageCache () =
  class end

/// https://api.flutter.dev/flutter/painting/ImageCacheStatus-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ImageCacheStatus =
  class end

/// https://api.flutter.dev/flutter/painting/ImageConfiguration-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ImageConfiguration [<IsConst; NamedParams>] (?bundle: AssetBundle, ?devicePixelRatio: float, ?locale: Locale, ?textDirection: TextDirection, ?size: Size, ?platform: TargetPlatform) =
  [<IsConst>] static member empty: ImageConfiguration = nativeOnly

/// https://api.flutter.dev/flutter/painting/ImageProvider-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ImageProvider<'T> [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/painting/AssetBundleImageKey-class.html
[<ImportMember("package:flutter/painting.dart")>]
type AssetBundleImageKey [<IsConst; NamedParams>] (bundle: AssetBundle, name: string, scale: float) =
  class end

/// https://api.flutter.dev/flutter/painting/AssetBundleImageProvider-class.html
[<ImportMember("package:flutter/painting.dart")>]
type AssetBundleImageProvider [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/painting/ResizeImageKey-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ResizeImageKey =
  class end

/// https://api.flutter.dev/flutter/painting/ResizeImage-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ResizeImage [<IsConst; NamedParams(fromIndex=1)>] (imageProvider: ImageProvider<obj>, ?width: int, ?height: int, ?allowUpscaling: bool) =
  class end

/// https://api.flutter.dev/flutter/painting/NetworkImage-class.html
[<ImportMember("package:flutter/painting.dart")>]
type NetworkImage [<IsConst; NamedParams(fromIndex=1)>] (url: string, ?scale: float, ?headers: Dictionary<string, string>) =
  class end

// TODO dart:io
// /// https://api.flutter.dev/flutter/painting/FileImage-class.html
// [<ImportMember("package:flutter/painting.dart")>]
// type FileImage [<IsConst; NamedParams(fromIndex=1)>] (file: File, ?scale: float) =
//   class end

/// https://api.flutter.dev/flutter/painting/MemoryImage-class.html
[<ImportMember("package:flutter/painting.dart")>]
type MemoryImage [<IsConst; NamedParams(fromIndex=1)>] (bytes: byte[], ?scale: float) =
  class end

/// https://api.flutter.dev/flutter/painting/ExactAssetImage-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ExactAssetImage [<IsConst; NamedParams(fromIndex=1)>] (assetName: string, ?scale: float, ?bundle: AssetBundle, ?package: string) =
  class end

/// https://api.flutter.dev/flutter/painting/AssetImage-class.html
[<ImportMember("package:flutter/painting.dart")>]
type AssetImage [<IsConst; NamedParams(fromIndex=1)>] (assetName: string, ?bundle: AssetBundle, ?package: string) =
  class end

/// https://api.flutter.dev/flutter/painting/ImageInfo-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ImageInfo [<IsConst; NamedParams>] (image: Image, ?scale: float, ?debugLabel: string) =
  class end

/// https://api.flutter.dev/flutter/painting/ImageStreamListener-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ImageStreamListener [<IsConst; NamedParams(fromIndex=1)>] (onImage: (ImageInfo -> bool -> unit), ?onChunk: (ImageChunkEvent -> unit), ?onError: (obj -> StackTrace option -> unit)) =
  class end

/// https://api.flutter.dev/flutter/painting/ImageChunkEvent-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ImageChunkEvent [<IsConst; NamedParams>] (cumulativeBytesLoaded: int, expectedTotalBytes: int option) =
  class end

/// https://api.flutter.dev/flutter/painting/ImageStream-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ImageStream () =
  class end

/// https://api.flutter.dev/flutter/painting/ImageStreamCompleterHandle-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ImageStreamCompleterHandle =
  class end

/// https://api.flutter.dev/flutter/painting/ImageStreamCompleter-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ImageStreamCompleter () =
  class end

/// https://api.flutter.dev/flutter/painting/OneFrameImageStreamCompleter-class.html
[<ImportMember("package:flutter/painting.dart")>]
type OneFrameImageStreamCompleter [<NamedParams(fromIndex=1)>] (image: Future<ImageInfo>, ?informationCollector: (unit -> DiagnosticsNode seq)) =
  class end

/// https://api.flutter.dev/flutter/painting/MultiFrameImageStreamCompleter-class.html
[<ImportMember("package:flutter/painting.dart")>]
type MultiFrameImageStreamCompleter [<NamedParams>] (codec: Future<Codec>, scale: float, ?debugLabel: string, ?chunkEvents: Stream<ImageChunkEvent>, ?informationCollector: (unit -> DiagnosticsNode seq)) =
  class end

/// https://api.flutter.dev/flutter/painting/Accumulator-class.html
[<ImportMember("package:flutter/painting.dart")>]
type Accumulator (?_value: int) =
  class end

/// https://api.flutter.dev/flutter/painting/InlineSpanSemanticsInformation-class.html
[<ImportMember("package:flutter/painting.dart")>]
type InlineSpanSemanticsInformation [<IsConst; NamedParams(fromIndex=1)>] (text: string, ?isPlaceholder: bool, ?semanticsLabel: string, ?stringAttributes: StringAttribute[], ?recognizer: GestureRecognizer) =
  [<IsConst>] static member placeholder: InlineSpanSemanticsInformation = nativeOnly

/// https://api.flutter.dev/flutter/painting/InlineSpan-class.html
[<ImportMember("package:flutter/painting.dart")>]
type InlineSpan [<IsConst; NamedParams>] (?style: TextStyle) =
  class end

/// https://api.flutter.dev/flutter/painting/MatrixUtils-class.html
[<ImportMember("package:flutter/painting.dart")>]
type MatrixUtils =
  class end

/// https://api.flutter.dev/flutter/painting/TransformProperty-class.html
[<ImportMember("package:flutter/painting.dart")>]
type TransformProperty [<NamedParams(fromIndex=2)>] (name: string, value: Matrix4 option, ?showName: bool, ?defaultValue: obj, ?level: DiagnosticLevel) =
  class end

/// https://api.flutter.dev/flutter/painting/NotchedShape-class.html
[<ImportMember("package:flutter/painting.dart")>]
type NotchedShape [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/painting/CircularNotchedRectangle-class.html
[<ImportMember("package:flutter/painting.dart")>]
type CircularNotchedRectangle [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/painting/AutomaticNotchedShape-class.html
[<ImportMember("package:flutter/painting.dart")>]
type AutomaticNotchedShape [<IsConst>] (host: ShapeBorder, ?guest: ShapeBorder) =
  class end

/// https://api.flutter.dev/flutter/painting/PlaceholderSpan-class.html
[<ImportMember("package:flutter/painting.dart")>]
type PlaceholderSpan [<IsConst; NamedParams>] (?alignment: PlaceholderAlignment, ?baseline: TextBaseline, ?style: TextStyle) =
  [<IsConst>] static member placeholderCodeUnit: int = nativeOnly

/// https://api.flutter.dev/flutter/painting/RoundedRectangleBorder-class.html
[<ImportMember("package:flutter/painting.dart")>]
type RoundedRectangleBorder [<IsConst; NamedParams>] (?side: BorderSide, ?borderRadius: BorderRadiusGeometry) =
  class end

/// https://api.flutter.dev/flutter/painting/ShaderWarmUp-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ShaderWarmUp [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/painting/ShapeDecoration-class.html
[<ImportMember("package:flutter/painting.dart")>]
type ShapeDecoration [<IsConst; NamedParams>] (shape: ShapeBorder, ?color: Color, ?image: DecorationImage, ?gradient: Gradient, ?shadows: BoxShadow[]) =
  static member fromBoxDecoration(source: BoxDecoration): ShapeDecoration = nativeOnly

/// https://api.flutter.dev/flutter/painting/StadiumBorder-class.html
[<ImportMember("package:flutter/painting.dart")>]
type StadiumBorder [<IsConst; NamedParams>] (?side: BorderSide) =
  class end

/// https://api.flutter.dev/flutter/painting/StrutStyle-class.html
[<ImportMember("package:flutter/painting.dart")>]
type StrutStyle [<IsConst; NamedParams>] (?fontFamily: string, ?fontFamilyFallback: string[], ?fontSize: float, ?height: float, ?leadingDistribution: TextLeadingDistribution, ?leading: float, ?fontWeight: FontWeight, ?fontStyle: FontStyle, ?forceStrutHeight: bool, ?debugLabel: string, ?package: string) =
  [<NamedParams(fromIndex=1)>] static member fromTextStyle(textStyle: TextStyle, ?fontFamily: string, ?fontFamilyFallback: string[], ?fontSize: float, ?height: float, ?leadingDistribution: TextLeadingDistribution, ?leading: float, ?fontWeight: FontWeight, ?fontStyle: FontStyle, ?forceStrutHeight: bool, ?debugLabel: string, ?package: string): StrutStyle = nativeOnly
  [<IsConst>] static member disabled: StrutStyle = nativeOnly

/// https://api.flutter.dev/flutter/painting/PlaceholderDimensions-class.html
[<ImportMember("package:flutter/painting.dart")>]
type PlaceholderDimensions [<IsConst; NamedParams>] (size: Size, alignment: PlaceholderAlignment, ?baseline: TextBaseline, ?baselineOffset: float) =
  [<IsConst>] static member empty: PlaceholderDimensions = nativeOnly

/// https://api.flutter.dev/flutter/painting/TextPainter-class.html
[<ImportMember("package:flutter/painting.dart")>]
type TextPainter [<NamedParams>] (?text: InlineSpan, ?textAlign: TextAlign, ?textDirection: TextDirection, ?textScaleFactor: float, ?maxLines: int, ?ellipsis: string, ?locale: Locale, ?strutStyle: StrutStyle, ?textWidthBasis: TextWidthBasis, ?textHeightBehavior: TextHeightBehavior) =
  class end

/// https://api.flutter.dev/flutter/painting/TextSpan-class.html
[<ImportMember("package:flutter/painting.dart")>]
type TextSpan [<IsConst; NamedParams>] (?text: string, ?children: InlineSpan[], ?style: TextStyle, ?recognizer: GestureRecognizer, ?mouseCursor: MouseCursor, ?onEnter: (PointerEnterEvent -> unit), ?onExit: (PointerExitEvent -> unit), ?semanticsLabel: string, ?locale: Locale, ?spellOut: bool) =
  class end

/// https://api.flutter.dev/flutter/painting/TextStyle-class.html
[<ImportMember("package:flutter/painting.dart")>]
type TextStyle [<IsConst; NamedParams>] (?``inherit``: bool, ?color: Color, ?backgroundColor: Color, ?fontSize: float, ?fontWeight: FontWeight, ?fontStyle: FontStyle, ?letterSpacing: float, ?wordSpacing: float, ?textBaseline: TextBaseline, ?height: float, ?leadingDistribution: TextLeadingDistribution, ?locale: Locale, ?foreground: Paint, ?background: Paint, ?shadows: Shadow[], ?fontFeatures: FontFeature[], ?decoration: TextDecoration, ?decorationColor: Color, ?decorationStyle: TextDecorationStyle, ?decorationThickness: float, ?debugLabel: string, ?fontFamily: string, ?fontFamilyFallback: string[], ?package: string, ?overflow: TextOverflow) =
  class end

