using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace MathS
{
    public static partial class Generic
    {
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct Vec2<T> where T : struct, INumber<T>
        {
            public Vec2(T x, T y)
            {
                this.x = x;
                this.y = y;
            }
            public Vec2(T v)
            {
                x = v;
                y = v;
            }
            public Vec2(Vec2<T> v)
            {
                x = v.x;
                y = v.y;
            }
            public T x, y;

            public static readonly Vec2<T> zero = new(T.Zero);
            public static readonly Vec2<T> one = new(T.One);
            public static readonly Vec2<T> unitX = new(T.One, T.Zero);
            public static readonly Vec2<T> unitY = new(T.Zero, T.One);

            public T sqrMagnitude { get => (x * x) + (y * y); }
            public T slope { get => y / x; }
            public Vec2<T> mirrorX { get => new(-x, y); }
            public Vec2<T> mirrorY { get => new(x, -y); }
            public Vec2<T> flattenX { get => new(T.Zero, y); }
            public Vec2<T> flattenY { get => new(x, T.Zero); }

            [Pure] public Vec2<T> xx { get => new(x); }
            public Vec2<T> xy { get => new(x, y); set { x = value.x; y = value.y; } }
            public Vec2<T> yx { get => new(y, x); set { y = value.x; x = value.y; } }
            [Pure] public Vec2<T> yy { get => new(y); }

            [Pure] public Vec3<T> xxx { get => new(xx, x); }
            [Pure] public Vec3<T> xxy { get => new(xx, y); }
            [Pure] public Vec3<T> xyx { get => new(xy, x); }
            [Pure] public Vec3<T> xyy { get => new(xy, y); }
            [Pure] public Vec3<T> yxx { get => new(yx, x); }
            [Pure] public Vec3<T> yxy { get => new(yx, y); }
            [Pure] public Vec3<T> yyx { get => new(yy, x); }
            [Pure] public Vec3<T> yyy { get => new(y); }

            [Pure] public Vec4<T> xxxx { get => new(x); }
            [Pure] public Vec4<T> xxxy { get => new(xxx, y); }
            [Pure] public Vec4<T> xxyx { get => new(xxy, x); }
            [Pure] public Vec4<T> xxyy { get => new(xxy, y); }
            [Pure] public Vec4<T> xyxx { get => new(xyx, x); }
            [Pure] public Vec4<T> xyxy { get => new(xyx, y); }
            [Pure] public Vec4<T> xyyx { get => new(xyy, x); }
            [Pure] public Vec4<T> xyyy { get => new(xyy, y); }
            [Pure] public Vec4<T> yxxx { get => new(yxx, x); }
            [Pure] public Vec4<T> yxxy { get => new(yxx, y); }
            [Pure] public Vec4<T> yxyx { get => new(yxy, x); }
            [Pure] public Vec4<T> yxyy { get => new(yxy, y); }
            [Pure] public Vec4<T> yyxx { get => new(yyx, x); }
            [Pure] public Vec4<T> yyxy { get => new(yyx, y); }
            [Pure] public Vec4<T> yyyx { get => new(yyy, x); }
            [Pure] public Vec4<T> yyyy { get => new(y); }



            public static Vec2<T> operator +(Vec2<T> a, Vec2<T> b) => new(a.x + b.x, a.y + b.y);
            public static Vec2<T> operator -(Vec2<T> a, Vec2<T> b) => new(a.x - b.x, a.y - b.y);
            public static Vec2<T> operator -(Vec2<T> a) => new(-a.x, -a.y);
            public static Vec2<T> operator *(Vec2<T> a, Vec2<T> b) => new(a.x * b.x, a.y * b.y);
            public static Vec2<T> operator *(T a, Vec2<T> b) => new(a * b.x, a * b.y);
            public static Vec2<T> operator *(Vec2<T> a, T b) => new(a.x * b, a.y * b);
            public static Vec2<T> operator /(Vec2<T> a, Vec2<T> b) => new(a.x / b.x, a.y / b.y);
            public static Vec2<T> operator /(T a, Vec2<T> b) => new(a / b.x, a / b.y);
            public static Vec2<T> operator /(Vec2<T> a, T b) => new(a.x / b, a.y / b);
            public static Vec2<T> operator %(Vec2<T> a, Vec2<T> b) => new(a.x % b.x, a.y % b.y);
            public static Vec2<T> operator %(T a, Vec2<T> b) => new(a % b.x, a % b.y);
            public static Vec2<T> operator %(Vec2<T> a, T b) => new(a.x % b, a.y % b);
            public static bool operator ==(Vec2<T> a, Vec2<T> b) => a.x == b.x && a.y == b.y;
            public static bool operator !=(Vec2<T> a, Vec2<T> b) => a.x != b.x || a.y != b.y;
            public static implicit operator string(Vec2<T> v) => v.x + ", " + v.y;

        }
        public static Vec2<T> Abs<T>(Vec2<T> v) where T : struct, INumber<T> => new(Abs(v.x), Abs(v.y));
        public static Vec2<T> Clamp<T>(Vec2<T> v, Vec2<T> min, Vec2<T> max) where T : struct, INumber<T> => new(Clamp(v.x, min.x, max.x), Clamp(v.y, min.y, max.y));
        public static Vec2<T> Clamp<T>(Vec2<T> v, T min, T max) where T : struct, INumber<T> => new(Clamp(v.x, min, max), Clamp(v.y, min, max));
        public static Vec2<T> Max<T>(Vec2<T> v, Vec2<T> max) where T : struct, INumber<T> => new(Max(v.x, max.x), Max(v.y, max.y));
        public static Vec2<T> Min<T>(Vec2<T> v, Vec2<T> min) where T : struct, INumber<T> => new(Min(v.x, min.x), Min(v.y, min.y));
        public static Vec2<T> Max<T>(Vec2<T> v, T max) where T : struct, INumber<T> => new(Max(v.x, max), Max(v.y, max));
        public static Vec2<T> Min<T>(Vec2<T> v, T min) where T : struct, INumber<T> => new(Min(v.x, min), Min(v.y, min));
        public static Vec2<T> Frac<T>(Vec2<T> v) where T : struct, IFloatingPoint<T> => new(Frac(v.x), Frac(v.y));
        public static Vec2<T> Lerp<T>(Vec2<T> a, Vec2<T> b, T t) where T : struct, INumber<T> => a + (t * (b - a));
        public static Vec2<T> Sin<T>(Vec2<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Sin(v.x), Sin(v.y));
        public static Vec2<T> Cos<T>(Vec2<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Cos(v.x), Cos(v.y));
        public static Vec2<T> Tan<T>(Vec2<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Tan(v.x), Tan(v.y));
        public static Vec2<T> Csc<T>(Vec2<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Csc(v.x), Csc(v.y));
        public static Vec2<T> Sec<T>(Vec2<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Sec(v.x), Sec(v.y));
        public static Vec2<T> Cot<T>(Vec2<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Cot(v.x), Cot(v.y));
        public static Vec2<T> Asin<T>(Vec2<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Asin(v.x), Asin(v.y));
        public static Vec2<T> Acos<T>(Vec2<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Acos(v.x), Acos(v.y));
        public static Vec2<T> Atan<T>(Vec2<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Atan(v.x), Atan(v.y));
        public static T Atan2<T>(Vec2<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => Atan2(v.y, v.x);
        public static Vec2<T> Sinh<T>(Vec2<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Sinh(v.x), Sinh(v.y));
        public static Vec2<T> Cosh<T>(Vec2<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Cosh(v.x), Cosh(v.y));
        public static Vec2<T> Tanh<T>(Vec2<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Tanh(v.x), Tanh(v.y));
        public static Vec2<T> Asinh<T>(Vec2<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Asinh(v.x), Asinh(v.y));
        public static Vec2<T> Acosh<T>(Vec2<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Acosh(v.x), Acosh(v.y));
        public static Vec2<T> Atanh<T>(Vec2<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Atanh(v.x), Atanh(v.y));
        public static Vec2<T> Pow<T>(Vec2<T> v, Vec2<T> p) where T : struct, INumber<T>, IPowerFunctions<T> => new(Pow(v.x, p.x), Pow(v.y, p.y));
        public static Vec2<T> Pow<T>(Vec2<T> v, T p) where T : struct, INumber<T>, IPowerFunctions<T> => new(Pow(v.x, p), Pow(v.y, p));
        public static Vec2<T> Exp<T>(Vec2<T> v) where T : struct, INumber<T>, IExponentialFunctions<T> => new(Exp(v.x), Exp(v.y));
        public static Vec2<T> Exp10<T>(Vec2<T> v) where T : struct, INumber<T>, IExponentialFunctions<T> => new(Exp10(v.x), Exp10(v.y));
        public static Vec2<T> Exp2<T>(Vec2<T> v) where T : struct, INumber<T>, IExponentialFunctions<T> => new(Exp2(v.x), Exp2(v.y));
        public static Vec2<T> Logn<T>(Vec2<T> v) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(Logn(v.x), Logn(v.y));
        public static Vec2<T> Log10<T>(Vec2<T> v) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(Log10(v.x), Log10(v.y));
        public static Vec2<T> Log2<T>(Vec2<T> v) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(Log2(v.x), Log2(v.y));
        public static Vec2<T> Log<T>(Vec2<T> v, Vec2<T> b) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(Log(v.x, b.x), Log(v.y, b.y));
        public static Vec2<T> Sqrt<T>(Vec2<T> v) where T : struct, INumber<T>, IRootFunctions<T> => new(Sqrt(v.x), Sqrt(v.y));
        public static Vec2<T> Cbrt<T>(Vec2<T> v) where T : struct, INumber<T>, IRootFunctions<T> => new(Cbrt(v.x), Cbrt(v.y));
        public static Vec2<T> Nroot<T>(Vec2<T> v, Vec2<T> b) where T : struct, INumber<T>, IPowerFunctions<T> => new(Nroot(v.x, b.x), Nroot(v.y, b.y));
        public static T Magnitude<T>(Vec2<T> v) where T : struct, INumber<T>, IRootFunctions<T> => Sqrt(v.sqrMagnitude);
        public static Vec2<T> Direction<T>(Vec2<T> v) where T : struct, INumber<T>, IRootFunctions<T> => v / Magnitude(v);
        public static Vec2<T> Normal<T>(Vec2<T> v) where T : struct, INumber<T>, IRootFunctions<T> => Direction(v.yx.mirrorX);
        public static T Distance<T>(Vec2<T> a, Vec2<T> b) where T : struct, INumber<T>, IRootFunctions<T> => Magnitude(a - b);
        public static T SqrDist<T>(Vec2<T> a, Vec2<T> b) where T : struct, INumber<T> => (a - b).sqrMagnitude;
        public static T Dot<T>(Vec2<T> a, Vec2<T> b) where T : struct, INumber<T> => (a.x * b.x) + (a.y * b.y);
        public static Vec2<T> Reflect<T>(Vec2<T> a, Vec2<T> b) where T : struct, INumber<T> => a - ((T.One + T.One) * (Dot(a, b) * b));
    }
}
