namespace rec Dart //.VectorMath

open System
open System.Collections.Generic
open Fable.Core
open Fable.Core.Dart

/// https://api.flutter.dev/flutter/vector_math/Aabb2-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Aabb2 () =
  static member copy(other: Aabb2): Aabb2 = nativeOnly
  static member minMax(min: Vector2, max: Vector2): Aabb2 = nativeOnly
  static member centerAndHalfExtents(center: Vector2, halfExtents: Vector2): Aabb2 = nativeOnly
  static member fromBuffer(buffer: ByteBuffer, offset: int): Aabb2 = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/Aabb3-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Aabb3 () =
  static member copy(other: Aabb3): Aabb3 = nativeOnly
  static member minMax(min: Vector3, max: Vector3): Aabb3 = nativeOnly
  static member fromSphere(sphere: Sphere): Aabb3 = nativeOnly
  static member fromTriangle(triangle: Triangle): Aabb3 = nativeOnly
  static member fromQuad(quad: Quad): Aabb3 = nativeOnly
  static member fromObb3(obb: Obb3): Aabb3 = nativeOnly
  static member fromRay(ray: Ray, limitMin: float, limitMax: float): Aabb3 = nativeOnly
  static member centerAndHalfExtents(center: Vector3, halfExtents: Vector3): Aabb3 = nativeOnly
  static member fromBuffer(buffer: ByteBuffer, offset: int): Aabb3 = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/Colors-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Colors =
  class end

/// https://api.flutter.dev/flutter/vector_math/Frustum-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Frustum () =
  static member copy(other: Frustum): Frustum = nativeOnly
  static member matrix(matrix: Matrix4): Frustum = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/IntersectionResult-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type IntersectionResult () =
  class end

/// https://api.flutter.dev/flutter/vector_math/Matrix2-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Matrix2 (arg0: float, arg1: float, arg2: float, arg3: float) =
  static member fromList(values: float[]): Matrix2 = nativeOnly
  static member zero(): Matrix2 = nativeOnly
  static member identity(): Matrix2 = nativeOnly
  static member copy(other: Matrix2): Matrix2 = nativeOnly
  static member columns(arg0: Vector2, arg1: Vector2): Matrix2 = nativeOnly
  static member outer(u: Vector2, v: Vector2): Matrix2 = nativeOnly
  static member rotation(radians: float): Matrix2 = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/Matrix3-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Matrix3 (arg0: float, arg1: float, arg2: float, arg3: float, arg4: float, arg5: float, arg6: float, arg7: float, arg8: float) =
  static member fromList(values: float[]): Matrix3 = nativeOnly
  static member zero(): Matrix3 = nativeOnly
  static member identity(): Matrix3 = nativeOnly
  static member copy(other: Matrix3): Matrix3 = nativeOnly
  static member columns(arg0: Vector3, arg1: Vector3, arg2: Vector3): Matrix3 = nativeOnly
  static member outer(u: Vector3, v: Vector3): Matrix3 = nativeOnly
  static member rotationX(radians: float): Matrix3 = nativeOnly
  static member rotationY(radians: float): Matrix3 = nativeOnly
  static member rotationZ(radians: float): Matrix3 = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/Matrix4-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Matrix4 (arg0: float, arg1: float, arg2: float, arg3: float, arg4: float, arg5: float, arg6: float, arg7: float, arg8: float, arg9: float, arg10: float, arg11: float, arg12: float, arg13: float, arg14: float, arg15: float) =
  static member fromList(values: float[]): Matrix4 = nativeOnly
  static member zero(): Matrix4 = nativeOnly
  static member identity(): Matrix4 = nativeOnly
  static member copy(other: Matrix4): Matrix4 = nativeOnly
  static member inverted(other: Matrix4): Matrix4 = nativeOnly
  static member columns(arg0: Vector4, arg1: Vector4, arg2: Vector4, arg3: Vector4): Matrix4 = nativeOnly
  static member outer(u: Vector4, v: Vector4): Matrix4 = nativeOnly
  static member rotationX(radians: float): Matrix4 = nativeOnly
  static member rotationY(radians: float): Matrix4 = nativeOnly
  static member rotationZ(radians: float): Matrix4 = nativeOnly
  static member translation(translation: Vector3): Matrix4 = nativeOnly
  static member translationValues(x: float, y: float, z: float): Matrix4 = nativeOnly
  static member diagonal3(scale: Vector3): Matrix4 = nativeOnly
  static member diagonal3Values(x: float, y: float, z: float): Matrix4 = nativeOnly
  static member skewX(alpha: float): Matrix4 = nativeOnly
  static member skewY(beta: float): Matrix4 = nativeOnly
  static member skew(alpha: float, beta: float): Matrix4 = nativeOnly
  static member fromFloat32List(_m4storage: single[]): Matrix4 = nativeOnly
  static member fromBuffer(buffer: ByteBuffer, offset: int): Matrix4 = nativeOnly
  static member compose(translation: Vector3, rotation: Quaternion, scale: Vector3): Matrix4 = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/Obb3-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Obb3 () =
  static member copy(other: Obb3): Obb3 = nativeOnly
  static member centerExtentsAxes(center: Vector3, halfExtents: Vector3, axis0: Vector3, axis1: Vector3, axis2: Vector3): Obb3 = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/Plane-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Plane () =
  static member copy(other: Plane): Plane = nativeOnly
  static member components(x: float, y: float, z: float, constant: float): Plane = nativeOnly
  static member normalconstant(normal_: Vector3, constant: float): Plane = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/Quad-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Quad () =
  static member copy(other: Quad): Quad = nativeOnly
  static member points(point0: Vector3, point1: Vector3, point2: Vector3, point3: Vector3): Quad = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/Quaternion-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Quaternion (x: float, y: float, z: float, w: float) =
  static member fromRotation(rotationMatrix: Matrix3): Quaternion = nativeOnly
  static member axisAngle(axis: Vector3, angle: float): Quaternion = nativeOnly
  static member fromTwoVectors(a: Vector3, b: Vector3): Quaternion = nativeOnly
  static member copy(original: Quaternion): Quaternion = nativeOnly
  static member random(rn: Random): Quaternion = nativeOnly
  static member identity(): Quaternion = nativeOnly
  static member dq(q: Quaternion, omega: Vector3): Quaternion = nativeOnly
  static member euler(yaw: float, pitch: float, roll: float): Quaternion = nativeOnly
  static member fromFloat32List(_qStorage: single[]): Quaternion = nativeOnly
  static member fromBuffer(buffer: ByteBuffer, offset: int): Quaternion = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/Ray-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Ray () =
  static member copy(other: Ray): Ray = nativeOnly
  static member originDirection(origin: Vector3, direction: Vector3): Ray = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/Sphere-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Sphere () =
  static member copy(other: Sphere): Sphere = nativeOnly
  static member centerRadius(center: Vector3, radius: float): Sphere = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/SimplexNoise-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type SimplexNoise (?r: Random) =
  class end

/// https://api.flutter.dev/flutter/vector_math/Triangle-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Triangle () =
  static member copy(other: Triangle): Triangle = nativeOnly
  static member points(point0: Vector3, point1: Vector3, point2: Vector3): Triangle = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/Vector-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Vector () =
  class end

/// https://api.flutter.dev/flutter/vector_math/Vector2-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Vector2 (x: float, y: float) =
  static member array(array: float[], ?offset: int): Vector2 = nativeOnly
  static member zero(): Vector2 = nativeOnly
  static member all(value: float): Vector2 = nativeOnly
  static member copy(other: Vector2): Vector2 = nativeOnly
  static member fromFloat32List(_v2storage: single[]): Vector2 = nativeOnly
  static member fromBuffer(buffer: ByteBuffer, offset: int): Vector2 = nativeOnly
  static member random(?rng: Random): Vector2 = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/Vector3-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Vector3 (x: float, y: float, z: float) =
  static member array(array: float[], ?offset: int): Vector3 = nativeOnly
  static member zero(): Vector3 = nativeOnly
  static member all(value: float): Vector3 = nativeOnly
  static member copy(other: Vector3): Vector3 = nativeOnly
  static member fromFloat32List(_v3storage: single[]): Vector3 = nativeOnly
  static member fromBuffer(buffer: ByteBuffer, offset: int): Vector3 = nativeOnly
  static member random(?rng: Random): Vector3 = nativeOnly

/// https://api.flutter.dev/flutter/vector_math/Vector4-class.html
[<ImportMember("package:vector_math/vector_math.dart")>]
type Vector4 (x: float, y: float, z: float, w: float) =
  static member array(array: float[], ?offset: int): Vector4 = nativeOnly
  static member zero(): Vector4 = nativeOnly
  static member identity(): Vector4 = nativeOnly
  static member all(value: float): Vector4 = nativeOnly
  static member copy(other: Vector4): Vector4 = nativeOnly
  static member fromFloat32List(_v4storage: single[]): Vector4 = nativeOnly
  static member fromBuffer(buffer: ByteBuffer, offset: int): Vector4 = nativeOnly
  static member random(?rng: Random): Vector4 = nativeOnly

[<ImportAll("package:vector_math/vector_math.dart")>]
type VectorMath =
  /// https://api.flutter.dev/flutter/vector_math/degrees.html
  static member degrees(radians: float): float = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/radians.html
  static member radians(degrees: float): float = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/mix.html
  static member mix(min: float, max: float, a: float): float = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/smoothStep.html
  static member smoothStep(edge0: float, edge1: float, amount: float): float = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/catmullRom.html
  static member catmullRom(edge0: float, edge1: float, edge2: float, edge3: float, amount: float): float = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/relativeError.html
  static member relativeError(calculated: obj, correct: obj): float = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/absoluteError.html
  static member absoluteError(calculated: obj, correct: obj): float = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/setRotationMatrix.html
  static member setRotationMatrix(rotationMatrix: Matrix4, forwardDirection: Vector3, upDirection: Vector3): unit = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/setModelMatrix.html
  static member setModelMatrix(modelMatrix: Matrix4, forwardDirection: Vector3, upDirection: Vector3, tx: float, ty: float, tz: float): unit = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/setViewMatrix.html
  static member setViewMatrix(viewMatrix: Matrix4, cameraPosition: Vector3, cameraFocusPosition: Vector3, upDirection: Vector3): unit = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/makeViewMatrix.html
  static member makeViewMatrix(cameraPosition: Vector3, cameraFocusPosition: Vector3, upDirection: Vector3): Matrix4 = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/setPerspectiveMatrix.html
  static member setPerspectiveMatrix(perspectiveMatrix: Matrix4, fovYRadians: float, aspectRatio: float, zNear: float, zFar: float): unit = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/makePerspectiveMatrix.html
  static member makePerspectiveMatrix(fovYRadians: float, aspectRatio: float, zNear: float, zFar: float): Matrix4 = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/setInfiniteMatrix.html
  static member setInfiniteMatrix(infiniteMatrix: Matrix4, fovYRadians: float, aspectRatio: float, zNear: float): unit = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/makeInfiniteMatrix.html
  static member makeInfiniteMatrix(fovYRadians: float, aspectRatio: float, zNear: float): Matrix4 = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/setFrustumMatrix.html
  static member setFrustumMatrix(perspectiveMatrix: Matrix4, left: float, right: float, bottom: float, top: float, near: float, far: float): unit = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/makeFrustumMatrix.html
  static member makeFrustumMatrix(left: float, right: float, bottom: float, top: float, near: float, far: float): Matrix4 = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/setOrthographicMatrix.html
  static member setOrthographicMatrix(orthographicMatrix: Matrix4, left: float, right: float, bottom: float, top: float, near: float, far: float): unit = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/makeOrthographicMatrix.html
  static member makeOrthographicMatrix(left: float, right: float, bottom: float, top: float, near: float, far: float): Matrix4 = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/makePlaneProjection.html
  static member makePlaneProjection(planeNormal: Vector3, planePoint: Vector3): Matrix4 = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/makePlaneReflection.html
  static member makePlaneReflection(planeNormal: Vector3, planePoint: Vector3): Matrix4 = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/unproject.html
  static member unproject(cameraMatrix: Matrix4, viewportX: num, viewportWidth: num, viewportY: num, viewportHeight: num, pickX: num, pickY: num, pickZ: num, pickWorld: Vector3): bool = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/pickRay.html
  static member pickRay(cameraMatrix: Matrix4, viewportX: num, viewportWidth: num, viewportY: num, viewportHeight: num, pickX: num, pickY: num, rayNear: Vector3, rayFar: Vector3): bool = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/dot2.html
  static member dot2(x: Vector2, y: Vector2): float = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/dot3.html
  static member dot3(x: Vector3, y: Vector3): float = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/cross3.html
  static member cross3(x: Vector3, y: Vector3, out: Vector3): unit = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/cross2.html
  static member cross2(x: Vector2, y: Vector2): float = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/cross2A.html
  static member cross2A(x: float, y: Vector2, out: Vector2): unit = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/cross2B.html
  static member cross2B(x: Vector2, y: float, out: Vector2): unit = nativeOnly
  /// https://api.flutter.dev/flutter/vector_math/buildPlaneVectors.html
  static member buildPlaneVectors(planeNormal: Vector3, u: Vector3, v: Vector3): unit = nativeOnly
