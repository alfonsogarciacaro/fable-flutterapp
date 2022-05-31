namespace rec Flutter.Foundation

open System
open System.Collections.Generic
open Fable.Core
open Fable.Core.Dart
open Dart

/// https://api.flutter.dev/flutter/foundation/DiagnosticLevel.html
[<ImportMember("package:flutter/foundation.dart")>]
type DiagnosticLevel =
  [<IsConst>] static member hidden: DiagnosticLevel = nativeOnly
  [<IsConst>] static member fine: DiagnosticLevel = nativeOnly
  [<IsConst>] static member debug: DiagnosticLevel = nativeOnly
  [<IsConst>] static member info: DiagnosticLevel = nativeOnly
  [<IsConst>] static member warning: DiagnosticLevel = nativeOnly
  [<IsConst>] static member hint: DiagnosticLevel = nativeOnly
  [<IsConst>] static member summary: DiagnosticLevel = nativeOnly
  [<IsConst>] static member error: DiagnosticLevel = nativeOnly
  [<IsConst>] static member off: DiagnosticLevel = nativeOnly
  [<IsConst>] static member values: DiagnosticLevel = nativeOnly

/// https://api.flutter.dev/flutter/foundation/DiagnosticsTreeStyle.html
[<ImportMember("package:flutter/foundation.dart")>]
type DiagnosticsTreeStyle =
  [<IsConst>] static member none: DiagnosticsTreeStyle = nativeOnly
  [<IsConst>] static member sparse: DiagnosticsTreeStyle = nativeOnly
  [<IsConst>] static member offstage: DiagnosticsTreeStyle = nativeOnly
  [<IsConst>] static member dense: DiagnosticsTreeStyle = nativeOnly
  [<IsConst>] static member transition: DiagnosticsTreeStyle = nativeOnly
  [<IsConst>] static member error: DiagnosticsTreeStyle = nativeOnly
  [<IsConst>] static member whitespace: DiagnosticsTreeStyle = nativeOnly
  [<IsConst>] static member flat: DiagnosticsTreeStyle = nativeOnly
  [<IsConst>] static member singleLine: DiagnosticsTreeStyle = nativeOnly
  [<IsConst>] static member errorProperty: DiagnosticsTreeStyle = nativeOnly
  [<IsConst>] static member shallow: DiagnosticsTreeStyle = nativeOnly
  [<IsConst>] static member truncateChildren: DiagnosticsTreeStyle = nativeOnly
  [<IsConst>] static member values: DiagnosticsTreeStyle = nativeOnly

/// https://api.flutter.dev/flutter/foundation/TargetPlatform.html
[<ImportMember("package:flutter/foundation.dart")>]
type TargetPlatform =
  [<IsConst>] static member android: TargetPlatform = nativeOnly
  [<IsConst>] static member fuchsia: TargetPlatform = nativeOnly
  [<IsConst>] static member iOS: TargetPlatform = nativeOnly
  [<IsConst>] static member linux: TargetPlatform = nativeOnly
  [<IsConst>] static member macOS: TargetPlatform = nativeOnly
  [<IsConst>] static member windows: TargetPlatform = nativeOnly
  [<IsConst>] static member values: TargetPlatform = nativeOnly

/// https://api.flutter.dev/flutter/foundation/Category-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type Category [<IsConst>] (sections: string[]) =
  class end

/// https://api.flutter.dev/flutter/foundation/DocumentationIcon-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type DocumentationIcon [<IsConst>] (url: string) =
  class end

/// https://api.flutter.dev/flutter/foundation/Summary-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type Summary [<IsConst>] (text: string) =
  class end

/// https://api.flutter.dev/flutter/foundation/PartialStackFrame-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type PartialStackFrame [<IsConst; NamedParams>] (package: Pattern, className: string, method: string) =
  [<IsConst>] static member asynchronousSuspension: PartialStackFrame = nativeOnly

/// https://api.flutter.dev/flutter/foundation/StackFilter-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type StackFilter [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/foundation/RepetitiveStackFrameFilter-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type RepetitiveStackFrameFilter [<IsConst; NamedParams>] (frames: PartialStackFrame[], replacement: string) =
  class end

/// https://api.flutter.dev/flutter/foundation/ErrorDescription-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type ErrorDescription (message: string) =
  class end

/// https://api.flutter.dev/flutter/foundation/ErrorSummary-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type ErrorSummary (message: string) =
  class end

/// https://api.flutter.dev/flutter/foundation/ErrorHint-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type ErrorHint (message: string) =
  class end

/// https://api.flutter.dev/flutter/foundation/ErrorSpacer-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type ErrorSpacer () =
  class end

/// https://api.flutter.dev/flutter/foundation/FlutterErrorDetails-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type FlutterErrorDetails [<IsConst; NamedParams>] (``exception``: obj, ?stack: StackTrace, ?library: string, ?context: DiagnosticsNode, ?stackFilter: (string seq -> string seq), ?informationCollector: (unit -> DiagnosticsNode seq), ?silent: bool) =
  class end

/// https://api.flutter.dev/flutter/foundation/DiagnosticsStackTrace-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type DiagnosticsStackTrace [<NamedParams(fromIndex=2)>] (name: string, stack: StackTrace option, ?stackFilter: (string seq -> string seq), ?showSeparator: bool) =
  [<NamedParams(fromIndex=1)>] static member singleFrame(name: string, frame: string, ?showSeparator: bool): DiagnosticsStackTrace = nativeOnly

/// https://api.flutter.dev/flutter/foundation/CachingIterable-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type CachingIterable<'E> (_prefillIterator: IEnumerator<'E>) =
  class end

/// https://api.flutter.dev/flutter/foundation/Factory-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type Factory<'T> [<IsConst>] (constructor: (unit -> 'T)) =
  class end

/// https://api.flutter.dev/flutter/foundation/BindingBase-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type BindingBase () =
  class end

/// https://api.flutter.dev/flutter/foundation/DebugReassembleConfig-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type DebugReassembleConfig [<NamedParams>] (?widgetName: string) =
  class end

/// https://api.flutter.dev/flutter/foundation/BitField-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type BitField<'T> (length: int) =
  static member filled(length: int, value: bool): BitField<'T> = nativeOnly

/// https://api.flutter.dev/flutter/foundation/Listenable-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type Listenable [<IsConst>] () =
  static member merge(listenables: Listenable option[]): Listenable = nativeOnly

/// https://api.flutter.dev/flutter/foundation/ValueListenable-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type ValueListenable<'T> [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/foundation/ChangeNotifier-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type ChangeNotifier () =
  class end

/// https://api.flutter.dev/flutter/foundation/ValueNotifier-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type ValueNotifier<'T> (_value: 'T) =
  class end

/// https://api.flutter.dev/flutter/foundation/TextTreeConfiguration-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type TextTreeConfiguration [<NamedParams>] (prefixLineOne: string, prefixOtherLines: string, prefixLastChildLineOne: string, prefixOtherLinesRootNode: string, linkCharacter: string, propertyPrefixIfChildren: string, propertyPrefixNoChildren: string, ?lineBreak: string, ?lineBreakProperties: bool, ?afterName: string, ?afterDescriptionIfBody: string, ?afterDescription: string, ?beforeProperties: string, ?afterProperties: string, ?mandatoryAfterProperties: string, ?propertySeparator: string, ?bodyIndent: string, ?footer: string, ?showChildren: bool, ?addBlankLineIfNoChildren: bool, ?isNameOnOwnLine: bool, ?isBlankLineBetweenPropertiesAndChildren: bool, ?beforeName: string, ?suffixLineOne: string, ?mandatoryFooter: string) =
  class end

/// https://api.flutter.dev/flutter/foundation/TextTreeRenderer-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type TextTreeRenderer [<NamedParams>] (?minLevel: DiagnosticLevel, ?wrapWidth: int, ?wrapWidthProperties: int, ?maxDescendentsTruncatableNode: int) =
  class end

/// https://api.flutter.dev/flutter/foundation/DiagnosticsNode-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type DiagnosticsNode [<NamedParams>] (name: string option, ?style: DiagnosticsTreeStyle, ?showName: bool, ?showSeparator: bool, ?linePrefix: string) =
  [<NamedParams(fromIndex=1)>] static member message(message: string, ?style: DiagnosticsTreeStyle, ?level: DiagnosticLevel, ?allowWrap: bool): DiagnosticsNode = nativeOnly

/// https://api.flutter.dev/flutter/foundation/MessageProperty-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type MessageProperty [<NamedParams(fromIndex=2)>] (name: string, message: string, ?style: DiagnosticsTreeStyle, ?level: DiagnosticLevel) =
  class end

/// https://api.flutter.dev/flutter/foundation/StringProperty-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type StringProperty [<NamedParams(fromIndex=2)>] (name: string, value: string option, ?description: string, ?tooltip: string, ?showName: bool, ?defaultValue: obj, ?quoted: bool, ?ifEmpty: string, ?style: DiagnosticsTreeStyle, ?level: DiagnosticLevel) =
  class end

/// https://api.flutter.dev/flutter/foundation/DoubleProperty-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type DoubleProperty [<NamedParams(fromIndex=2)>] (name: string, value: float option, ?ifNull: string, ?unit: string, ?tooltip: string, ?defaultValue: obj, ?showName: bool, ?style: DiagnosticsTreeStyle, ?level: DiagnosticLevel) =
  [<NamedParams(fromIndex=2)>] static member ``lazy``(name: string, computeValue: (unit -> float option), ?ifNull: string, ?showName: bool, ?unit: string, ?tooltip: string, ?defaultValue: obj, ?level: DiagnosticLevel): DoubleProperty = nativeOnly

/// https://api.flutter.dev/flutter/foundation/IntProperty-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type IntProperty [<NamedParams(fromIndex=2)>] (name: string, value: int option, ?ifNull: string, ?showName: bool, ?unit: string, ?defaultValue: obj, ?style: DiagnosticsTreeStyle, ?level: DiagnosticLevel) =
  class end

/// https://api.flutter.dev/flutter/foundation/PercentProperty-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type PercentProperty [<NamedParams(fromIndex=2)>] (name: string, fraction: float option, ?ifNull: string, ?showName: bool, ?tooltip: string, ?unit: string, ?level: DiagnosticLevel) =
  class end

/// https://api.flutter.dev/flutter/foundation/FlagProperty-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type FlagProperty [<NamedParams(fromIndex=1)>] (name: string, value: bool option, ?ifTrue: string, ?ifFalse: string, ?showName: bool, ?defaultValue: obj, ?level: DiagnosticLevel) =
  class end

/// https://api.flutter.dev/flutter/foundation/IterableProperty-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type IterableProperty<'T> [<NamedParams(fromIndex=2)>] (name: string, value: 'T seq option, ?defaultValue: obj, ?ifNull: string, ?ifEmpty: string, ?style: DiagnosticsTreeStyle, ?showName: bool, ?showSeparator: bool, ?level: DiagnosticLevel) =
  class end

/// https://api.flutter.dev/flutter/foundation/EnumProperty-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type EnumProperty<'T> [<NamedParams(fromIndex=2)>] (name: string, value: 'T option, ?defaultValue: obj, ?level: DiagnosticLevel) =
  class end

/// https://api.flutter.dev/flutter/foundation/ObjectFlagProperty-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type ObjectFlagProperty<'T> [<NamedParams(fromIndex=2)>] (name: string, value: 'T option, ?ifPresent: string, ?ifNull: string, ?showName: bool, ?level: DiagnosticLevel) =
  [<NamedParams(fromIndex=2)>] static member has(name: string, value: 'T option, ?level: DiagnosticLevel): ObjectFlagProperty<'T> = nativeOnly

/// https://api.flutter.dev/flutter/foundation/FlagsSummary-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type FlagsSummary<'T> [<NamedParams(fromIndex=2)>] (name: string, value: Dictionary<string, 'T option>, ?ifEmpty: string, ?showName: bool, ?showSeparator: bool, ?level: DiagnosticLevel) =
  class end

/// https://api.flutter.dev/flutter/foundation/DiagnosticsProperty-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type DiagnosticsProperty<'T> [<NamedParams(fromIndex=2)>] (name: string option, value: 'T option, ?description: string, ?ifNull: string, ?ifEmpty: string, ?showName: bool, ?showSeparator: bool, ?defaultValue: obj, ?tooltip: string, ?missingIfNull: bool, ?linePrefix: string, ?expandableValue: bool, ?allowWrap: bool, ?allowNameWrap: bool, ?style: DiagnosticsTreeStyle, ?level: DiagnosticLevel) =
  [<NamedParams(fromIndex=2)>] static member ``lazy``(name: string option, computeValue: (unit -> 'T option), ?description: string, ?ifNull: string, ?ifEmpty: string, ?showName: bool, ?showSeparator: bool, ?defaultValue: obj, ?tooltip: string, ?missingIfNull: bool, ?expandableValue: bool, ?allowWrap: bool, ?allowNameWrap: bool, ?style: DiagnosticsTreeStyle, ?level: DiagnosticLevel): DiagnosticsProperty<'T> = nativeOnly

/// https://api.flutter.dev/flutter/foundation/DiagnosticableNode-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type DiagnosticableNode<'T> [<NamedParams>] (value: 'T, style: DiagnosticsTreeStyle option, ?name: string) =
  class end

/// https://api.flutter.dev/flutter/foundation/DiagnosticableTreeNode-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type DiagnosticableTreeNode [<NamedParams>] (value: DiagnosticableTree, style: DiagnosticsTreeStyle option, ?name: string) =
  class end

/// https://api.flutter.dev/flutter/foundation/DiagnosticPropertiesBuilder-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type DiagnosticPropertiesBuilder () =
  static member fromProperties(properties: DiagnosticsNode[]): DiagnosticPropertiesBuilder = nativeOnly

/// https://api.flutter.dev/flutter/foundation/DiagnosticableTree-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type DiagnosticableTree [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/foundation/DiagnosticsBlock-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type DiagnosticsBlock [<NamedParams>] (?name: string, ?style: DiagnosticsTreeStyle, ?showName: bool, ?showSeparator: bool, ?linePrefix: string, ?value: obj, ?description: string, ?level: DiagnosticLevel, ?allowTruncate: bool, ?children: DiagnosticsNode[], ?properties: DiagnosticsNode[]) =
  class end

/// https://api.flutter.dev/flutter/foundation/DiagnosticsSerializationDelegate-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type DiagnosticsSerializationDelegate [<IsConst; NamedParams>] (?subtreeDepth: int, ?includeProperties: bool) =
  class end

/// https://api.flutter.dev/flutter/foundation/Key-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type Key [<IsConst>] (value: string) =
  [<IsConst>] static member empty(): Key = nativeOnly

/// https://api.flutter.dev/flutter/foundation/LocalKey-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type LocalKey [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/foundation/UniqueKey-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type UniqueKey () =
  class end

/// https://api.flutter.dev/flutter/foundation/ValueKey-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type ValueKey<'T> [<IsConst>] (value: 'T) =
  class end

/// https://api.flutter.dev/flutter/foundation/LicenseParagraph-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type LicenseParagraph [<IsConst>] (text: string, indent: int) =
  [<IsConst>] static member centeredIndent: int = nativeOnly

/// https://api.flutter.dev/flutter/foundation/LicenseEntry-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type LicenseEntry [<IsConst>] () =
  class end

/// https://api.flutter.dev/flutter/foundation/LicenseEntryWithLineBreaks-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type LicenseEntryWithLineBreaks [<IsConst>] (packages: string[], text: string) =
  class end

/// https://api.flutter.dev/flutter/foundation/LicenseRegistry-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type LicenseRegistry =
  class end

/// https://api.flutter.dev/flutter/foundation/AbstractNode-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type AbstractNode () =
  class end

/// https://api.flutter.dev/flutter/foundation/ObserverList-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type ObserverList<'T> () =
  class end

/// https://api.flutter.dev/flutter/foundation/HashedObserverList-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type HashedObserverList<'T> () =
  class end

/// https://api.flutter.dev/flutter/foundation/WriteBuffer-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type WriteBuffer () =
  class end

/// https://api.flutter.dev/flutter/foundation/ReadBuffer-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type ReadBuffer (data: ByteData) =
  class end

/// https://api.flutter.dev/flutter/foundation/StackFrame-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type StackFrame [<IsConst; NamedParams>] (number: int, column: int, line: int, packageScheme: string, package: string, packagePath: string, method: string, source: string, ?className: string, ?isConstructor: bool) =
  [<IsConst>] static member asynchronousSuspension: StackFrame = nativeOnly
  [<IsConst>] static member stackOverFlowElision: StackFrame = nativeOnly

/// https://api.flutter.dev/flutter/foundation/SynchronousFuture-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type SynchronousFuture<'T> (_value: 'T) =
  class end

/// https://api.flutter.dev/flutter/foundation/Unicode-class.html
[<ImportMember("package:flutter/foundation.dart")>]
type Unicode =
  [<IsConst>] static member LRE: string = nativeOnly
  [<IsConst>] static member RLE: string = nativeOnly
  [<IsConst>] static member PDF: string = nativeOnly
  [<IsConst>] static member LRO: string = nativeOnly
  [<IsConst>] static member RLO: string = nativeOnly
  [<IsConst>] static member LRI: string = nativeOnly
  [<IsConst>] static member RLI: string = nativeOnly
  [<IsConst>] static member FSI: string = nativeOnly
  [<IsConst>] static member PDI: string = nativeOnly
  [<IsConst>] static member LRM: string = nativeOnly
  [<IsConst>] static member RLM: string = nativeOnly
  [<IsConst>] static member ALM: string = nativeOnly

