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
        public struct Vec2
        {
            private Vector2 value;
            public static implicit operator Vector2(Vec2 v) => v.value;
            public static implicit operator Vec2(Vector2 v) => new(v);
            public Vec2(Vector2 val) { value = val; }
            public Vec2(float x, float y)
            {
                value = new(x, y);
            }
            public Vec2(float v)
            {
                value = new(v);
            }
            public Vec2(Vec2 v)
            {
                value = v.value;
            }

            public static readonly Vec2 zero = new(0);
            public static readonly Vec2 one = new(1);
            public static readonly Vec2 unitX = new(1, 0);
            public static readonly Vec2 unitY = new(0, 1);

            public float sqrMagnitude { get => (x * x) + (y * y); }
            public float magnitude { get => Sqrt((x * x) + (y * y)); }
            public float slope { get => y / x; }
            public Vec2 mirrorX { get => new(-x, y); }
            public Vec2 mirrorY { get => new(x, -y); }
            public Vec2 flattenX { get => new(0f, y); }
            public Vec2 flattenY { get => new(x, 0f); }
            public Vec2 direction { get => xy * InvSqrt(sqrMagnitude); }
            public Vec2 normal { get => yx.mirrorX.direction; }


            public float x { get => value.X; set => this.value.X = value; }
            public float y { get => value.Y; set => this.value.Y = value; }
            [Pure] public Vec2 xx { get => new(x); }
            public Vec2 xy { get => new(x, y); set { x = value.x; y = value.y; } }
            public Vec2 yx { get => new(y, x); set { y = value.x; x = value.y; } }
            [Pure] public Vec2 yy { get => new(y); }

            [Pure] public Vec3 xxx { get => new(xx, x); }
            [Pure] public Vec3 xxy { get => new(xx, y); }
            [Pure] public Vec3 xyx { get => new(xy, x); }
            [Pure] public Vec3 xyy { get => new(xy, y); }
            [Pure] public Vec3 yxx { get => new(yx, x); }
            [Pure] public Vec3 yxy { get => new(yx, y); }
            [Pure] public Vec3 yyx { get => new(yy, x); }
            [Pure] public Vec3 yyy { get => new(y); }

            [Pure] public Vec4 xxxx { get => new(x); }
            [Pure] public Vec4 xxxy { get => new(xxx, y); }
            [Pure] public Vec4 xxyx { get => new(xxy, x); }
            [Pure] public Vec4 xxyy { get => new(xxy, y); }
            [Pure] public Vec4 xyxx { get => new(xyx, x); }
            [Pure] public Vec4 xyxy { get => new(xyx, y); }
            [Pure] public Vec4 xyyx { get => new(xyy, x); }
            [Pure] public Vec4 xyyy { get => new(xyy, y); }
            [Pure] public Vec4 yxxx { get => new(yxx, x); }
            [Pure] public Vec4 yxxy { get => new(yxx, y); }
            [Pure] public Vec4 yxyx { get => new(yxy, x); }
            [Pure] public Vec4 yxyy { get => new(yxy, y); }
            [Pure] public Vec4 yyxx { get => new(yyx, x); }
            [Pure] public Vec4 yyxy { get => new(yyx, y); }
            [Pure] public Vec4 yyyx { get => new(yyy, x); }
            [Pure] public Vec4 yyyy { get => new(y); }



            public static Vec2 operator +(Vec2 a, Vec2 b) => a.value + b.value;
            public static Vec2 operator -(Vec2 a, Vec2 b) => a.value - b.value;
            public static Vec2 operator -(Vec2 v) => -v.value;
            public static Vec2 operator *(Vec2 a, Vec2 b) => a.value * b.value;
            public static Vec2 operator *(float a, Vec2 b) => a * b.value;
            public static Vec2 operator *(Vec2 a, float b) => a.value * b;
            public static Vec2 operator /(Vec2 a, Vec2 b) => a.value / b.value;
            public static Vec2 operator /(float a, Vec2 b) => new(a / b.x, a / b.y);
            public static Vec2 operator /(Vec2 a, float b) => a.value / b;
            public static Vec2 operator %(Vec2 a, Vec2 b) => new(a.x % b.x, a.y % b.y);
            public static Vec2 operator %(float a, Vec2 b) => new(a % b.x, a % b.y);
            public static Vec2 operator %(Vec2 a, float b) => new(a.x % b, a.y % b);
            public static bool operator ==(Vec2 a, Vec2 b) => a.value == b.value;
            public static bool operator !=(Vec2 a, Vec2 b) => a.value != b.value;
            public static implicit operator string(Vec2 v) => (v.x, v.y).ToString();

        }
        public static Vec2 Abs(Vec2 v) => new(Abs(v.x), Abs(v.y));
        public static Vec2 Clamp(Vec2 v, Vec2 min, Vec2 max) => new(Clamp(v.x, min.x, max.x), Clamp(v.y, min.y, max.y));
        public static Vec2 Clamp(Vec2 v, float min, float max) => new(Clamp(v.x, min, max), Clamp(v.y, min, max));
        public static Vec2 Max(Vec2 v, Vec2 max) => new(Max(v.x, max.x), Max(v.y, max.y));
        public static Vec2 Min(Vec2 v, Vec2 min) => new(Min(v.x, min.x), Min(v.y, min.y));
        public static Vec2 Max(Vec2 v, float max) => new(Max(v.x, max), Max(v.y, max));
        public static Vec2 Min(Vec2 v, float min) => new(Min(v.x, min), Min(v.y, min));
        public static Vec2 Sign(Vec2 v) => new(Sign(v.x), Sign(v.y));
        public static Vec2 Frac(Vec2 v) => new(Frac(v.x), Frac(v.y));
        public static Vec2 Lerp(Vec2 a, Vec2 b, float t) => a + (t * (b - a));
        public static Vec2 Degrees(Vec2 v) => v * degreeConversionConst;
        public static Vec2 Radians(Vec2 v) => v * radianConversionConst;
        public static Vec2 Sin(Vec2 v) => new(Sin(v.x), Sin(v.y));
        public static Vec2 Cos(Vec2 v) => new(Cos(v.x), Cos(v.y));
        public static Vec2 CosSin(float a) => new(Cos(a), Sin(a));
        public static Vec2 Tan(Vec2 v) => new(Tan(v.x), Tan(v.y));
        public static Vec2 Csc(Vec2 v) => new(Csc(v.x), Csc(v.y));
        public static Vec2 Sec(Vec2 v) => new(Sec(v.x), Sec(v.y));
        public static Vec2 Cot(Vec2 v) => new(Cot(v.x), Cot(v.y));
        public static Vec2 Asin(Vec2 v) => new(Asin(v.x), Asin(v.y));
        public static Vec2 Acos(Vec2 v) => new(Acos(v.x), Acos(v.y));
        public static Vec2 Atan(Vec2 v) => new(Atan(v.x), Atan(v.y));
        public static float Atan2(Vec2 v) => Atan2(v.y, v.x);
        public static Vec2 Sinh(Vec2 v) => new(Sinh(v.x), Sinh(v.y));
        public static Vec2 Cosh(Vec2 v) => new(Cosh(v.x), Cosh(v.y));
        public static Vec2 Tanh(Vec2 v) => new(Tanh(v.x), Tanh(v.y));
        public static Vec2 Asinh(Vec2 v) => new(Asinh(v.x), Asinh(v.y));
        public static Vec2 Acosh(Vec2 v) => new(Acosh(v.x), Acosh(v.y));
        public static Vec2 Atanh(Vec2 v) => new(Atanh(v.x), Atanh(v.y));
        public static Vec2 Pow(Vec2 v, Vec2 p) => new(Pow(v.x, p.x), Pow(v.y, p.y));
        public static Vec2 Pow(Vec2 v, float p) => new(Pow(v.x, p), Pow(v.y, p));
        public static Vec2 Exp(Vec2 v) => new(Exp(v.x), Exp(v.y));
        public static Vec2 Exp10(Vec2 v) => new(Exp10(v.x), Exp10(v.y));
        public static Vec2 Exp2(Vec2 v) => new(Exp2(v.x), Exp2(v.y));
        public static Vec2 Logn(Vec2 v) => new(Logn(v.x), Logn(v.y));
        public static Vec2 Log10(Vec2 v) => new(Log10(v.x), Log10(v.y));
        public static Vec2 Log2(Vec2 v) => new(Log2(v.x), Log2(v.y));
        public static Vec2 Log(Vec2 v, Vec2 b) => new(Log(v.x, b.x), Log(v.y, b.y));
        public static Vec2 Sqrt(Vec2 v) => new(Sqrt(v.x), Sqrt(v.y));
        public static Vec2 Cbrt(Vec2 v) => new(Cbrt(v.x), Cbrt(v.y));
        public static Vec2 Nroot(Vec2 v, Vec2 b) => new(Nroot(v.x, b.x), Nroot(v.y, b.y));
        public static Vec2 InvSqrt(Vec2 v) => new(InvSqrt(v.x), InvSqrt(v.y));
        public static float Distance(Vec2 a, Vec2 b) => (a - b).magnitude;
        public static float SqrDist(Vec2 a, Vec2 b) => (a - b).sqrMagnitude;
        public static float Dot(Vec2 a, Vec2 b) => (a.x * b.x) + (a.y * b.y);
        public static Vec2 Reflect(Vec2 a, Vec2 b) => a - (2f * (Dot(a, b) * b));
    }
}
