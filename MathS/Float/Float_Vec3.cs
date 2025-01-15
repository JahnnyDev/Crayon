using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace MathS
{
    public static partial class Float
    {
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct Vec3
        {
            public Vector3 value;
            public static implicit operator Vector3(Vec3 v) => v.value;
            public static implicit operator Vec3(Vector3 v) => new(v);
            
            public Vec3(Vector3 v)
            {
                value = v;
            }
            public Vec3(float v)
            {
                value = new(v);

            }
            public Vec3(float x, float y, float z)
            {
                value = new(x,y,z);
            }
            public Vec3(Vec2 v, float z)
            {
                value = new(v.x, v.y, z);
            }
            public Vec3(float x, Vec2 v)
            {
                value = new(x, v.x, v.y);
            }
            public Vec3(Vec3 v)
            {
                value = v.value;
            }

            public static readonly Vec3 zero = new(0f);
            public static readonly Vec3 one = new(1f);
            public static readonly Vec3 unitX = new(1f, 0f, 0f);
            public static readonly Vec3 unitY = new(0f, 1f, 0f);
            public static readonly Vec3 unitZ = new(0f, 0f, 1f);
            public static readonly Vec3 unitXY = new Vec3(1, 1, 0);
            public static readonly Vec3 unitXZ = new Vec3(1, 0, 1);
            public static readonly Vec3 unitYZ = new Vec3(0, 1, 1);

            [Pure] public float sqrMagnitude { get => (x * x) + (y * y) + (z * z); }
            [Pure] public float magnitude { get => Sqrt(sqrMagnitude); }
            [Pure] public Vec3 mirrorX { get => new(-x, yz); }
            [Pure] public Vec3 mirrorY { get => new(x, -y, z); }
            [Pure] public Vec3 mirrorZ { get => new(xy, -z); }
            [Pure] public Vec3 mirrorXY { get => new(-xy, z); }
            [Pure] public Vec3 mirrorXZ { get => new(-x, y, -z); }
            [Pure] public Vec3 mirrorYZ { get => new(x, -yz); }
            [Pure] public Vec3 flattenX { get => new(0f, yz); }
            [Pure] public Vec3 flattenY { get => new(x, 0f, z); }
            [Pure] public Vec3 FlattenZ { get => new(xy, 0f); }
            [Pure] public Vec3 flattenXY { get => new(0, 0, z); }
            [Pure] public Vec3 flattenXZ { get => new(0, y, 0); }
            [Pure] public Vec3 FlattenYZ { get => new(x, 0f, 0f); }
            [Pure] public Vec3 direction { get => xyz * InvSqrt(sqrMagnitude); }


            public float x { get => value.X; set => this.value.X = value; }
            public float y { get => value.Y; set => this.value.Y = value; }
            public float z { get => value.Z; set => this.value.Z = value; }

            [Pure] public Vec2 xx { get => new(x); }
            public Vec2 xy { get => new(x, y); set { x = value.x; y = value.y; } }
            public Vec2 xz { get => new(x, z); set { x = value.x; z = value.y; } }
            public Vec2 yx { get => new(y, x); set { y = value.x; x = value.y; } }
            [Pure] public Vec2 yy { get => new(y); }
            public Vec2 yz { get => new(y, z); set { y = value.x; z = value.y; } }
            public Vec2 zx { get => new(z, x); set { z = value.x; x = value.y; } }
            public Vec2 zy { get => new(z, y); set { z = value.x; y = value.y; } }
            [Pure] public Vec2 zz { get => new(z); }

            [Pure] public Vec3 xxx { get => new(x); }
            [Pure] public Vec3 xxy { get => new(xx, y); }
            [Pure] public Vec3 xxz { get => new(xx, z); }
            [Pure] public Vec3 xyx { get => new(xy, x); }
            [Pure] public Vec3 xyy { get => new(xy, y); }
            public Vec3 xyz { get => this; set { x = value.x; y = value.y; z = value.z; } }
            [Pure] public Vec3 xzx { get => new(xz, x); }
            public Vec3 xzy { get => new(xz, y); set { x = value.x; z = value.y; y = value.z; } }
            [Pure] public Vec3 xzz { get => new(xz, z); }
            [Pure] public Vec3 yxx { get => new(yx, x); }
            [Pure] public Vec3 yxy { get => new(yx, y); }
            public Vec3 yxz { get => new(yx, z); set { y = value.x; x = value.y; z = value.z; } }
            [Pure] public Vec3 yyx { get => new(yy, x); }
            [Pure] public Vec3 yyy { get => new(y); }
            [Pure] public Vec3 yyz { get => new(yy, z); }
            public Vec3 yzx { get => new(yz, x); set { y = value.x; z = value.y; x = value.z; } }
            [Pure] public Vec3 yzy { get => new(yz, y); }
            [Pure] public Vec3 yzz { get => new(yz, z); }
            [Pure] public Vec3 zxx { get => new(zx, x); }
            public Vec3 zxy { get => new(zx, y); set { z = value.x; x = value.y; y = value.z; } }
            [Pure] public Vec3 zxz { get => new(zx, z); }
            public Vec3 zyx { get => new(zy, x); set { z = value.y; y = value.y; x = value.z; } }
            [Pure] public Vec3 zyy { get => new(zy, y); }
            [Pure] public Vec3 zyz { get => new(zy, z); }
            [Pure] public Vec3 zzx { get => new(zz, x); }
            [Pure] public Vec3 zzy { get => new(zz, y); }
            [Pure] public Vec3 zzz { get => new(z); }

            [Pure] public Vec4 xxxx { get => new(x); }
            [Pure] public Vec4 xxxy { get => new(xxx, y); }
            [Pure] public Vec4 xxxz { get => new(xxx, z); }
            [Pure] public Vec4 xxyx { get => new(xxy, x); }
            [Pure] public Vec4 xxyy { get => new(xxy, y); }
            [Pure] public Vec4 xxyz { get => new(xxy, z); }
            [Pure] public Vec4 xxzx { get => new(xxz, x); }
            [Pure] public Vec4 xxzy { get => new(xxz, y); }
            [Pure] public Vec4 xxzz { get => new(xxz, z); }
            [Pure] public Vec4 xyxx { get => new(xyx, x); }
            [Pure] public Vec4 xyxy { get => new(xyx, y); }
            [Pure] public Vec4 xyxz { get => new(xyx, z); }
            [Pure] public Vec4 xyyx { get => new(xyy, x); }
            [Pure] public Vec4 xyyy { get => new(xyy, y); }
            [Pure] public Vec4 xyyz { get => new(xyy, z); }
            [Pure] public Vec4 xyzx { get => new(xyz, x); }
            [Pure] public Vec4 xyzy { get => new(xyz, y); }
            [Pure] public Vec4 xyzz { get => new(xyz, z); }
            [Pure] public Vec4 xzxx { get => new(xzx, x); }
            [Pure] public Vec4 xzxy { get => new(xzx, y); }
            [Pure] public Vec4 xzxz { get => new(xzx, z); }
            [Pure] public Vec4 xzyx { get => new(xzy, x); }
            [Pure] public Vec4 xzyy { get => new(xzy, y); }
            [Pure] public Vec4 xzyz { get => new(xzy, z); }
            [Pure] public Vec4 xzzx { get => new(xzz, x); }
            [Pure] public Vec4 xzzy { get => new(xzz, y); }
            [Pure] public Vec4 xzzz { get => new(xzz, z); }
            [Pure] public Vec4 yxxx { get => new(yxx, x); }
            [Pure] public Vec4 yxxy { get => new(yxx, y); }
            [Pure] public Vec4 yxxz { get => new(yxx, z); }
            [Pure] public Vec4 yxyx { get => new(yxy, x); }
            [Pure] public Vec4 yxyy { get => new(yxy, y); }
            [Pure] public Vec4 yxyz { get => new(yxy, z); }
            [Pure] public Vec4 yxzx { get => new(yxz, x); }
            [Pure] public Vec4 yxzy { get => new(yxz, y); }
            [Pure] public Vec4 yxzz { get => new(yxz, z); }
            [Pure] public Vec4 yyxx { get => new(yyx, x); }
            [Pure] public Vec4 yyxy { get => new(yyx, y); }
            [Pure] public Vec4 yyxz { get => new(yyx, z); }
            [Pure] public Vec4 yyyx { get => new(yyy, x); }
            [Pure] public Vec4 yyyy { get => new(y); }
            [Pure] public Vec4 yyyz { get => new(yyy, z); }
            [Pure] public Vec4 yyzx { get => new(yyz, x); }
            [Pure] public Vec4 yyzy { get => new(yyz, y); }
            [Pure] public Vec4 yyzz { get => new(yyz, z); }
            [Pure] public Vec4 yzxx { get => new(yzx, x); }
            [Pure] public Vec4 yzxy { get => new(yzx, y); }
            [Pure] public Vec4 yzxz { get => new(yzx, z); }
            [Pure] public Vec4 yzyx { get => new(yzy, x); }
            [Pure] public Vec4 yzyy { get => new(yzy, y); }
            [Pure] public Vec4 yzyz { get => new(yzy, z); }
            [Pure] public Vec4 yzzx { get => new(yzz, x); }
            [Pure] public Vec4 yzzy { get => new(yzz, y); }
            [Pure] public Vec4 yzzz { get => new(yzz, z); }
            [Pure] public Vec4 zxxx { get => new(zxx, x); }
            [Pure] public Vec4 zxxy { get => new(zxx, y); }
            [Pure] public Vec4 zxxz { get => new(zxx, z); }
            [Pure] public Vec4 zxyx { get => new(zxy, x); }
            [Pure] public Vec4 zxyy { get => new(zxy, y); }
            [Pure] public Vec4 zxyz { get => new(zxy, z); }
            [Pure] public Vec4 zxzx { get => new(zxz, x); }
            [Pure] public Vec4 zxzy { get => new(zxz, y); }
            [Pure] public Vec4 zxzz { get => new(zxz, z); }
            [Pure] public Vec4 zyxx { get => new(zyx, x); }
            [Pure] public Vec4 zyxy { get => new(zyx, y); }
            [Pure] public Vec4 zyxz { get => new(zyx, z); }
            [Pure] public Vec4 zyyx { get => new(zyy, x); }
            [Pure] public Vec4 zyyy { get => new(zyy, y); }
            [Pure] public Vec4 zyyz { get => new(zyy, z); }
            [Pure] public Vec4 zyzx { get => new(zyz, x); }
            [Pure] public Vec4 zyzy { get => new(zyz, y); }
            [Pure] public Vec4 zyzz { get => new(zyz, z); }
            [Pure] public Vec4 zzxx { get => new(zzx, x); }
            [Pure] public Vec4 zzxy { get => new(zzx, y); }
            [Pure] public Vec4 zzxz { get => new(zzx, z); }
            [Pure] public Vec4 zzyx { get => new(zzy, x); }
            [Pure] public Vec4 zzyy { get => new(zzy, y); }
            [Pure] public Vec4 zzyz { get => new(zzy, z); }
            [Pure] public Vec4 zzzx { get => new(zzz, x); }
            [Pure] public Vec4 zzzy { get => new(zzz, y); }
            [Pure] public Vec4 zzzz { get => new(z); }

            public static Vec3 operator +(Vec3 a, Vec3 b) => a.value + b.value;
            public static Vec3 operator -(Vec3 a, Vec3 b) => a.value - b.value;
            public static Vec3 operator *(Vec3 a, Vec3 b) => a.value * b.value;
            public static Vec3 operator *(float a, Vec3 b) => a * b.value;
            public static Vec3 operator *(Vec3 a, float b) => a.value * b;
            public static Vec3 operator /(Vec3 a, Vec3 b) => a.value / b.value;
            public static Vec3 operator /(float a, Vec3 b) => new(a / b.xy, a / b.z);
            public static Vec3 operator /(Vec3 a, float b) => a.value /b;
            public static Vec3 operator %(Vec3 a, Vec3 b) => new(a.xy % b.xy, a.z % b.z);
            public static Vec3 operator %(float a, Vec3 b) => new(a % b.xy, a % b.z);
            public static Vec3 operator %(Vec3 a, float b) => new(a.xy % b, a.z % b);

            public static bool operator ==(Vec3 a, Vec3 b) => a.value == b.value;
            public static bool operator !=(Vec3 a, Vec3 b) => a.value != b.value;
            public static implicit operator string(Vec3 v) => (v.x, v.y, v.z).ToString();

        }
        public static Vec3 Abs(Vec3 v) => new(Abs(v.xy), Abs(v.z));
        public static Vec3 Clamp(Vec3 v, Vec3 min, Vec3 max) => new(Clamp(v.xy, min.xy, max.xy), Clamp(v.z, min.z, max.z));
        public static Vec3 Clamp(Vec3 v, float min, float max) => new(Clamp(v.xy, min, max), Clamp(v.z, min, max));
        public static Vec3 Max(Vec3 v, Vec3 max) => new(Max(v.xy, max.xy), Max(v.z, max.z));
        public static Vec3 Min(Vec3 v, Vec3 min) => new(Min(v.xy, min.xy), Min(v.z, min.z));
        public static Vec3 Max(Vec3 v, float max) => new(Max(v.xy, max), Max(v.z, max));
        public static Vec3 Min(Vec3 v, float min) => new(Min(v.xy, min), Min(v.z, min));
        public static Vec3 Frac(Vec3 v) => new(Frac(v.xy), Frac(v.z));
        public static Vec3 Lerp(Vec3 a, Vec3 b, float t) => a + (t * (b - a));
        public static Vec3 Sign(Vec3 v) => new(Sign(v.xy), Sign(v.z));

        public static Vec3 Degrees(Vec3 v) => v * degreeConversionConst;
        public static Vec3 Radians(Vec3 v) => v * radianConversionConst;
        public static Vec3 Sin(Vec3 v) => new(Sin(v.xy), Sin(v.z));
        public static Vec3 Cos(Vec3 v) => new(Cos(v.xy), Cos(v.z));
        public static Vec3 Tan(Vec3 v) => new(Tan(v.xy), Tan(v.z));
        public static Vec3 Csc(Vec3 v) => new(Csc(v.xy), Csc(v.z));
        public static Vec3 Sec(Vec3 v) => new(Sec(v.xy), Sec(v.z));
        public static Vec3 Cot(Vec3 v) => new(Cot(v.xy), Cot(v.z));
        public static Vec3 Asin(Vec3 v) => new(Asin(v.xy), Asin(v.z));
        public static Vec3 Acos(Vec3 v) => new(Acos(v.xy), Acos(v.z));
        public static Vec3 Atan(Vec3 v) => new(Atan(v.xy), Atan(v.z));

        public static Vec3 Sinh(Vec3 v) => new(Sinh(v.xy), Sinh(v.z));
        public static Vec3 Cosh(Vec3 v) => new(Cosh(v.xy), Cosh(v.z));
        public static Vec3 Tanh(Vec3 v) => new(Tanh(v.xy), Tanh(v.z));
        public static Vec3 Asinh(Vec3 v) => new(Asinh(v.xy), Asinh(v.z));
        public static Vec3 Acosh(Vec3 v) => new(Acosh(v.xy), Acosh(v.z));
        public static Vec3 Atanh(Vec3 v) => new(Atanh(v.xy), Atanh(v.z));

        public static Vec3 Pow(Vec3 v, Vec3 p) => new(Pow(v.xy, p.xy), Pow(v.z, p.z));
        public static Vec3 Pow(Vec3 v, float p) => new(Pow(v.xy, p), Pow(v.z, p));
        public static Vec3 Exp(Vec3 v) => new(Exp(v.xy), Exp(v.z));
        public static Vec3 Exp10(Vec3 v) => new(Exp10(v.xy), Exp10(v.z));
        public static Vec3 Exp2(Vec3 v) => new(Exp2(v.xy), Exp2(v.z));
        public static Vec3 Logn(Vec3 v) => new(Logn(v.xy), Logn(v.z));
        public static Vec3 Log10(Vec3 v) => new(Log10(v.xy), Log10(v.z));
        public static Vec3 Log2(Vec3 v) => new(Log2(v.xy), Log2(v.z));
        public static Vec3 Log(Vec3 v, Vec3 b) => new(Log(v.xy, b.xy), Log(v.z, b.z));
        public static Vec3 Sqrt(Vec3 v) => new(Sqrt(v.xy), Sqrt(v.z));
        public static Vec3 Cbrt(Vec3 v) => new(Cbrt(v.xy), Cbrt(v.z));
        public static Vec3 Nroot(Vec3 v, Vec3 b) => new(Nroot(v.xy, b.xy), Nroot(v.z, b.z));
        public static Vec3 InvSqrt(Vec3 v) => new(InvSqrt(v.xy), InvSqrt(v.z));

        public static float Distance(Vec3 a, Vec3 b) => (a - b).magnitude;
        public static float SqrDist(Vec3 a, Vec3 b) => (a - b).sqrMagnitude;
        public static Vec3 Cross(Vec3 a, Vec3 b)
            => Vector3.Cross(a, b);
        public static float Dot(Vec3 a, Vec3 b) => Vector3.Dot(a, b);
        public static Vec3 Reflect(Vec3 a, Vec3 b) => a - (2f * (Dot(a, b) * b));
        public static Vec3 Transform(Vec3 a, Mat4 m) => Vector3.Transform(a, m);
    }
}
