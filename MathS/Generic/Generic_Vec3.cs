using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace MathS
{
    public static partial class Generic
    {
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct Vec3<T> where T : struct, System.Numerics.INumber<T>
        {
            public T x, y, z;
            public Vec3(T v)
            {
                x = v;
                y = v;
                z = v;
            }
            public Vec3(T x, T y, T z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public Vec3(Vec2<T> v, T z)
            {
                x = v.x;
                y = v.y;
                this.z = z;
            }
            public Vec3(T x, Vec2<T> v)
            {
                this.x = x;
                y = v.x;
                z = v.y;
            }
            public Vec3(Vec3<T> v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
            public static readonly Vec3<T> zero = new(T.Zero);
            public static readonly Vec3<T> one = new(T.One);
            public static readonly Vec3<T> unitX = new(T.One, T.Zero, T.Zero);
            public static readonly Vec3<T> unitY = new(T.Zero, T.One, T.Zero);
            public static readonly Vec3<T> unitZ = new(T.Zero, T.Zero, T.One);
            public static readonly Vec3<T> unitXY = new(T.One, T.One, T.Zero);
            public static readonly Vec3<T> unitXZ = new(T.One, T.Zero, T.One);
            public static readonly Vec3<T> unitYZ = new(T.Zero, T.One, T.One);

            [Pure] public T sqrMagnitude { get => (x * x) + (y * y) + (z * z); }
            [Pure] public Vec3<T> mirrorX { get => new(-x, yz); }
            [Pure] public Vec3<T> mirrorY { get => new(x, -y, z); }
            [Pure] public Vec3<T> mirrorZ { get => new(xy, -z); }
            [Pure] public Vec3<T> mirrorXY { get => new(-xy, z); }
            [Pure] public Vec3<T> mirrorXZ { get => new(-x, y, -z); }
            [Pure] public Vec3<T> mirrorYZ { get => new(x, -yz); }
            [Pure] public Vec3<T> flattenX { get => new(T.Zero, yz); }
            [Pure] public Vec3<T> flattenY { get => new(x, T.Zero, T.Zero); }
            [Pure] public Vec3<T> FlattenZ { get => new(xy, T.Zero); }
            [Pure] public Vec3<T> flattenXY { get => new(T.Zero, T.Zero, z); }
            [Pure] public Vec3<T> flattenXZ { get => new(T.Zero, y, T.Zero); }
            [Pure] public Vec3<T> FlattenYZ { get => new(x, T.Zero, T.Zero); }
            [Pure] public Vec2<T> xx { get => new(x); }
            public Vec2<T> xy { get => new(x, y); set { x = value.x; y = value.y; } }
            public Vec2<T> xz { get => new(x, z); set { x = value.x; z = value.y; } }
            public Vec2<T> yx { get => new(y, x); set { y = value.x; x = value.y; } }
            [Pure] public Vec2<T> yy { get => new(y); }
            public Vec2<T> yz { get => new(y, z); set { y = value.x; z = value.y; } }
            public Vec2<T> zx { get => new(z, x); set { z = value.x; x = value.y; } }
            public Vec2<T> zy { get => new(z, y); set { z = value.x; y = value.y; } }
            [Pure] public Vec2<T> zz { get => new(z); }

            [Pure] public Vec3<T> xxx { get => new(x); }
            [Pure] public Vec3<T> xxy { get => new(xx, y); }
            [Pure] public Vec3<T> xxz { get => new(xx, z); }
            [Pure] public Vec3<T> xyx { get => new(xy, x); }
            [Pure] public Vec3<T> xyy { get => new(xy, y); }
            public Vec3<T> xyz { get => this; set { x = value.x; y = value.y; z = value.z; } }
            [Pure] public Vec3<T> xzx { get => new(xz, x); }
            public Vec3<T> xzy { get => new(xz, y); set { x = value.x; z = value.y; y = value.z; } }
            [Pure] public Vec3<T> xzz { get => new(xz, z); }
            [Pure] public Vec3<T> yxx { get => new(yx, x); }
            [Pure] public Vec3<T> yxy { get => new(yx, y); }
            public Vec3<T> yxz { get => new(yx, z); set { y = value.x; x = value.y; z = value.z; } }
            [Pure] public Vec3<T> yyx { get => new(yy, x); }
            [Pure] public Vec3<T> yyy { get => new(y); }
            [Pure] public Vec3<T> yyz { get => new(yy, z); }
            public Vec3<T> yzx { get => new(yz, x); set { y = value.x; z = value.y; x = value.z; } }
            [Pure] public Vec3<T> yzy { get => new(yz, y); }
            [Pure] public Vec3<T> yzz { get => new(yz, z); }
            [Pure] public Vec3<T> zxx { get => new(zx, x); }
            public Vec3<T> zxy { get => new(zx, y); set { z = value.x; x = value.y; y = value.z; } }
            [Pure] public Vec3<T> zxz { get => new(zx, z); }
            public Vec3<T> zyx { get => new(zy, x); set { z = value.y; y = value.y; x = value.z; } }
            [Pure] public Vec3<T> zyy { get => new(zy, y); }
            [Pure] public Vec3<T> zyz { get => new(zy, z); }
            [Pure] public Vec3<T> zzx { get => new(zz, x); }
            [Pure] public Vec3<T> zzy { get => new(zz, y); }
            [Pure] public Vec3<T> zzz { get => new(z); }

            [Pure] public Vec4<T> xxxx { get => new(x); }
            [Pure] public Vec4<T> xxxy { get => new(xxx, y); }
            [Pure] public Vec4<T> xxxz { get => new(xxx, z); }
            [Pure] public Vec4<T> xxyx { get => new(xxy, x); }
            [Pure] public Vec4<T> xxyy { get => new(xxy, y); }
            [Pure] public Vec4<T> xxyz { get => new(xxy, z); }
            [Pure] public Vec4<T> xxzx { get => new(xxz, x); }
            [Pure] public Vec4<T> xxzy { get => new(xxz, y); }
            [Pure] public Vec4<T> xxzz { get => new(xxz, z); }
            [Pure] public Vec4<T> xyxx { get => new(xyx, x); }
            [Pure] public Vec4<T> xyxy { get => new(xyx, y); }
            [Pure] public Vec4<T> xyxz { get => new(xyx, z); }
            [Pure] public Vec4<T> xyyx { get => new(xyy, x); }
            [Pure] public Vec4<T> xyyy { get => new(xyy, y); }
            [Pure] public Vec4<T> xyyz { get => new(xyy, z); }
            [Pure] public Vec4<T> xyzx { get => new(xyz, x); }
            [Pure] public Vec4<T> xyzy { get => new(xyz, y); }
            [Pure] public Vec4<T> xyzz { get => new(xyz, z); }
            [Pure] public Vec4<T> xzxx { get => new(xzx, x); }
            [Pure] public Vec4<T> xzxy { get => new(xzx, y); }
            [Pure] public Vec4<T> xzxz { get => new(xzx, z); }
            [Pure] public Vec4<T> xzyx { get => new(xzy, x); }
            [Pure] public Vec4<T> xzyy { get => new(xzy, y); }
            [Pure] public Vec4<T> xzyz { get => new(xzy, z); }
            [Pure] public Vec4<T> xzzx { get => new(xzz, x); }
            [Pure] public Vec4<T> xzzy { get => new(xzz, y); }
            [Pure] public Vec4<T> xzzz { get => new(xzz, z); }
            [Pure] public Vec4<T> yxxx { get => new(yxx, x); }
            [Pure] public Vec4<T> yxxy { get => new(yxx, y); }
            [Pure] public Vec4<T> yxxz { get => new(yxx, z); }
            [Pure] public Vec4<T> yxyx { get => new(yxy, x); }
            [Pure] public Vec4<T> yxyy { get => new(yxy, y); }
            [Pure] public Vec4<T> yxyz { get => new(yxy, z); }
            [Pure] public Vec4<T> yxzx { get => new(yxz, x); }
            [Pure] public Vec4<T> yxzy { get => new(yxz, y); }
            [Pure] public Vec4<T> yxzz { get => new(yxz, z); }
            [Pure] public Vec4<T> yyxx { get => new(yyx, x); }
            [Pure] public Vec4<T> yyxy { get => new(yyx, y); }
            [Pure] public Vec4<T> yyxz { get => new(yyx, z); }
            [Pure] public Vec4<T> yyyx { get => new(yyy, x); }
            [Pure] public Vec4<T> yyyy { get => new(y); }
            [Pure] public Vec4<T> yyyz { get => new(yyy, z); }
            [Pure] public Vec4<T> yyzx { get => new(yyz, x); }
            [Pure] public Vec4<T> yyzy { get => new(yyz, y); }
            [Pure] public Vec4<T> yyzz { get => new(yyz, z); }
            [Pure] public Vec4<T> yzxx { get => new(yzx, x); }
            [Pure] public Vec4<T> yzxy { get => new(yzx, y); }
            [Pure] public Vec4<T> yzxz { get => new(yzx, z); }
            [Pure] public Vec4<T> yzyx { get => new(yzy, x); }
            [Pure] public Vec4<T> yzyy { get => new(yzy, y); }
            [Pure] public Vec4<T> yzyz { get => new(yzy, z); }
            [Pure] public Vec4<T> yzzx { get => new(yzz, x); }
            [Pure] public Vec4<T> yzzy { get => new(yzz, y); }
            [Pure] public Vec4<T> yzzz { get => new(yzz, z); }
            [Pure] public Vec4<T> zxxx { get => new(zxx, x); }
            [Pure] public Vec4<T> zxxy { get => new(zxx, y); }
            [Pure] public Vec4<T> zxxz { get => new(zxx, z); }
            [Pure] public Vec4<T> zxyx { get => new(zxy, x); }
            [Pure] public Vec4<T> zxyy { get => new(zxy, y); }
            [Pure] public Vec4<T> zxyz { get => new(zxy, z); }
            [Pure] public Vec4<T> zxzx { get => new(zxz, x); }
            [Pure] public Vec4<T> zxzy { get => new(zxz, y); }
            [Pure] public Vec4<T> zxzz { get => new(zxz, z); }
            [Pure] public Vec4<T> zyxx { get => new(zyx, x); }
            [Pure] public Vec4<T> zyxy { get => new(zyx, y); }
            [Pure] public Vec4<T> zyxz { get => new(zyx, z); }
            [Pure] public Vec4<T> zyyx { get => new(zyy, x); }
            [Pure] public Vec4<T> zyyy { get => new(zyy, y); }
            [Pure] public Vec4<T> zyyz { get => new(zyy, z); }
            [Pure] public Vec4<T> zyzx { get => new(zyz, x); }
            [Pure] public Vec4<T> zyzy { get => new(zyz, y); }
            [Pure] public Vec4<T> zyzz { get => new(zyz, z); }
            [Pure] public Vec4<T> zzxx { get => new(zzx, x); }
            [Pure] public Vec4<T> zzxy { get => new(zzx, y); }
            [Pure] public Vec4<T> zzxz { get => new(zzx, z); }
            [Pure] public Vec4<T> zzyx { get => new(zzy, x); }
            [Pure] public Vec4<T> zzyy { get => new(zzy, y); }
            [Pure] public Vec4<T> zzyz { get => new(zzy, z); }
            [Pure] public Vec4<T> zzzx { get => new(zzz, x); }
            [Pure] public Vec4<T> zzzy { get => new(zzz, y); }
            [Pure] public Vec4<T> zzzz { get => new(z); }

            public static Vec3<T> operator +(Vec3<T> a, Vec3<T> b) => new(a.xy + b.xy, a.z + b.z);
            public static Vec3<T> operator -(Vec3<T> a, Vec3<T> b) => new(a.xy - b.xy, a.z - b.z);
            public static Vec3<T> operator -(Vec3<T> a) => new(-a.xy, -a.z);
            public static Vec3<T> operator *(Vec3<T> a, Vec3<T> b) => new(a.xy * b.xy, a.z * b.z);
            public static Vec3<T> operator *(T a, Vec3<T> b) => new(a * b.xy, a * b.z);
            public static Vec3<T> operator *(Vec3<T> a, T b) => new(a.xy * b, a.z * b);
            public static Vec3<T> operator /(Vec3<T> a, Vec3<T> b) => new(a.xy / b.xy, a.z / b.z);
            public static Vec3<T> operator /(T a, Vec3<T> b) => new(a / b.xy, a / b.z);
            public static Vec3<T> operator /(Vec3<T> a, T b) => new(a.xy / b, a.z / b);
            public static Vec3<T> operator %(Vec3<T> a, Vec3<T> b) => new(a.xy % b.xy, a.z % b.z);
            public static Vec3<T> operator %(T a, Vec3<T> b) => new(a % b.xy, a % b.z);
            public static Vec3<T> operator %(Vec3<T> a, T b) => new(a.xy % b, a.z % b);
        }
        public static Vec3<T> Abs<T>(Vec3<T> v) where T : struct, INumber<T> => new(Abs(v.x), Abs(v.yz));
        public static Vec3<T> Clamp<T>(Vec3<T> v, Vec3<T> min, Vec3<T> max) where T : struct, INumber<T> => new(Clamp(v.x, min.x, max.x), Clamp(v.yz, min.yz, max.yz));
        public static Vec3<T> Clamp<T>(Vec3<T> v, T min, T max) where T : struct, INumber<T> => new(Clamp(v.x, min, max), Clamp(v.yz, min, max));
        public static Vec3<T> Max<T>(Vec3<T> v, Vec3<T> max) where T : struct, INumber<T> => new(Max(v.x, max.x), Max(v.yz, max.yz));
        public static Vec3<T> Min<T>(Vec3<T> v, Vec3<T> min) where T : struct, INumber<T> => new(Min(v.x, min.x), Min(v.yz, min.yz));
        public static Vec3<T> Max<T>(Vec3<T> v, T max) where T : struct, INumber<T> => new(Max(v.x, max), Max(v.yz, max));
        public static Vec3<T> Min<T>(Vec3<T> v, T min) where T : struct, INumber<T> => new(Min(v.x, min), Min(v.yz, min));
        public static Vec3<T> Frac<T>(Vec3<T> v) where T : struct, IFloatingPoint<T> => new(Frac(v.x), Frac(v.yz));
        public static Vec3<T> Lerp<T>(Vec3<T> a, Vec3<T> b, T t) where T : struct, INumber<T> => a + (t * (b - a));
        public static Vec3<T> Sin<T>(Vec3<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Sin(v.x), Sin(v.yz));
        public static Vec3<T> Cos<T>(Vec3<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Cos(v.x), Cos(v.yz));
        public static Vec3<T> Tan<T>(Vec3<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Tan(v.x), Tan(v.yz));
        public static Vec3<T> Csc<T>(Vec3<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Csc(v.x), Csc(v.yz));
        public static Vec3<T> Sec<T>(Vec3<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Sec(v.x), Sec(v.yz));
        public static Vec3<T> Cot<T>(Vec3<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Cot(v.x), Cot(v.yz));
        public static Vec3<T> Asin<T>(Vec3<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Asin(v.x), Asin(v.yz));
        public static Vec3<T> Acos<T>(Vec3<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Acos(v.x), Acos(v.yz));
        public static Vec3<T> Atan<T>(Vec3<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Atan(v.x), Atan(v.yz));
        public static T Atan2<T>(Vec3<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => Atan2(v.y, v.x);
        public static Vec3<T> Sinh<T>(Vec3<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Sinh(v.x), Sinh(v.yz));
        public static Vec3<T> Cosh<T>(Vec3<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Cosh(v.x), Cosh(v.yz));
        public static Vec3<T> Tanh<T>(Vec3<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Tanh(v.x), Tanh(v.yz));
        public static Vec3<T> Asinh<T>(Vec3<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Asinh(v.x), Asinh(v.yz));
        public static Vec3<T> Acosh<T>(Vec3<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Acosh(v.x), Acosh(v.yz));
        public static Vec3<T> Atanh<T>(Vec3<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Atanh(v.x), Atanh(v.yz));
        public static Vec3<T> Pow<T>(Vec3<T> v, Vec3<T> p) where T : struct, INumber<T>, IPowerFunctions<T> => new(Pow(v.x, p.x), Pow(v.yz, p.yz));
        public static Vec3<T> Pow<T>(Vec3<T> v, T p) where T : struct, INumber<T>, IPowerFunctions<T> => new(Pow(v.x, p), Pow(v.yz, p));
        public static Vec3<T> Exp<T>(Vec3<T> v) where T : struct, INumber<T>, IExponentialFunctions<T> => new(Exp(v.x), Exp(v.yz));
        public static Vec3<T> Exp10<T>(Vec3<T> v) where T : struct, INumber<T>, IExponentialFunctions<T> => new(Exp10(v.x), Exp10(v.yz));
        public static Vec3<T> Exp2<T>(Vec3<T> v) where T : struct, INumber<T>, IExponentialFunctions<T> => new(Exp2(v.x), Exp2(v.yz));
        public static Vec3<T> Logn<T>(Vec3<T> v) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(Logn(v.x), Logn(v.yz));
        public static Vec3<T> Log10<T>(Vec3<T> v) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(Log10(v.x), Log10(v.yz));
        public static Vec3<T> Log2<T>(Vec3<T> v) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(Log2(v.x), Log2(v.yz));
        public static Vec3<T> Log<T>(Vec3<T> v, Vec3<T> b) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(Log(v.x, b.x), Log(v.yz, b.yz));
        public static Vec3<T> Sqrt<T>(Vec3<T> v) where T : struct, INumber<T>, IRootFunctions<T> => new(Sqrt(v.x), Sqrt(v.yz));
        public static Vec3<T> Cbrt<T>(Vec3<T> v) where T : struct, INumber<T>, IRootFunctions<T> => new(Cbrt(v.x), Cbrt(v.yz));
        public static Vec3<T> Nroot<T>(Vec3<T> v, Vec3<T> b) where T : struct, INumber<T>, IPowerFunctions<T> => new(Nroot(v.x, b.x), Nroot(v.yz, b.yz));
        public static T Magnitude<T>(Vec3<T> v) where T : struct, INumber<T>, IRootFunctions<T> => Sqrt(v.sqrMagnitude);
        public static Vec3<T> Direction<T>(Vec3<T> v) where T : struct, INumber<T>, IRootFunctions<T> => v / Magnitude(v);
        public static T Distance<T>(Vec3<T> a, Vec3<T> b) where T : struct, INumber<T>, IRootFunctions<T> => Magnitude(a - b);
        public static T SqrDist<T>(Vec3<T> a, Vec3<T> b) where T : struct, INumber<T> => (a - b).sqrMagnitude;
        public static T Dot<T>(Vec3<T> a, Vec3<T> b) where T : struct, INumber<T> => (a.x * b.x) + (a.y * b.y);
        public static Vec3<T> Cross<T>(Vec3<T> a, Vec3<T> b) where T : struct, INumber<T>
    => new((a.y * b.z) - (a.z * b.y), (a.z * b.x) - (a.x * b.z), (a.x * b.y) - (a.y * b.x));
        public static Vec3<T> Reflect<T>(Vec3<T> a, Vec3<T> b) where T : struct, INumber<T> => a - ((T.One + T.One) * (Dot(a, b) * b));
    }
}
