namespace rec Dart

open System
open System.Collections.Generic
open System.Runtime.InteropServices
open System.Text.RegularExpressions
open Fable.Core
open Fable.Core.Dart

[<Global>]
type StackTrace =
  interface end

[<Global>]
type FutureOr<'T> = Future<'T>

[<Global>]
type ByteData =
  interface end

[<Global>]
type ByteBuffer =
  interface end

[<Global>]
type Pattern private () =
  [<Emit("$0")>] new (pattern: string) = Pattern()
  [<Emit("$0")>] new (pattern: Regex) = Pattern()

[<Global>]
type num private () =
  [<Emit("$0")>] new (pattern: int) = num()
  [<Emit("$0")>] new (pattern: float) = num()
