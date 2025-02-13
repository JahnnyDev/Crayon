using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace MathS
{
    public static partial class Float
    {
        #region constants
        public const float pi = 3.14159274f;
        public const float tau = 6.28318531f;
        public const float e = 2.71828183f;
        public const float root2 = 1.41421356f;
        public const float root3 = 1.73205080f;
        public const float goldRatio = 1.61803398f;
        public static Random random = new();

        private const float degreeConversionConst = 57.29577951f;
        private const float radianConversionConst = 0.01745329f;

        #endregion

        #region functions
        public static float Abs(float v) => float.Abs(v);
        public static float Clamp(float v, float min, float max) => float.Clamp(v, min, max);
        public static float Max(float v, float max) => float.Max(v, max);
        public static float Min(float v, float min) => float.Min(v, min);
        public static float Frac(float v) => float.Truncate(v);
        public static float Sign(float v) => float.Sign(v);
        public static float Lerp(float a, float b, float t) => a + (t * (b - a));


        public static float Degrees(float v) => v * degreeConversionConst;
        public static float Radians(float v) => v * radianConversionConst;
        public static float Sin(float v) => MathF.Sin(v);
        public static float Cos(float v) => float.Cos(v);
        public static float Tan(float v) => float.Tan(v);
        public static float Csc(float v) => 1 / Sin(v);
        public static float Sec(float v) => 1 / Cos(v);
        public static float Cot(float v) => 1 / Tan(v);
        public static float Asin(float v) => float.Asin(v);
        public static float Acos(float v) => float.Acos(v);
        public static float Atan(float v) => float.Atan(v);
        public static float Atan2(float y, float x) => x >= 0f ? Atan(y / x) : Atan(y / x) - pi;

        public static float Sinh(float v) => float.Sinh(v);
        public static float Cosh(float v) => float.Cosh(v);
        public static float Tanh(float v) => float.Tanh(v);
        public static float Asinh(float v) => float.Asinh(v);
        public static float Acosh(float v) => float.Acosh(v);
        public static float Atanh(float v) => float.Atanh(v);

        public static float Pow(float v, float p)  => float.Pow(v, p);
        public static float Exp(float v) => float.Exp(v);
        public static float Exp10(float v) => float.Exp10(v);
        public static float Exp2(float v) => float.Exp2(v);
        public static float Logn(float v) => float.Log(v);
        public static float Log10(float v) => float.Log10(v);
        public static float Log2(float v) => float.Log2(v);
        public static float Log(float v, float b) => float.Log2(v) / float.Log2(b);
        public static float Sqrt(float v) => float.Sqrt(v);
        public static float Cbrt(float v) => float.Cbrt(v);
        public static float Nroot(float v, float b) => Pow(v, 1 / b);
        public static float InvSqrt(float v) => float.ReciprocalSqrtEstimate(v);

        public static Int.Vec2 CastToInt(Vec2 v) => new((int)v.x, (int)v.y);
        public static Int.Vec3 CastToInt(Vec3 v) => new((int)v.x, (int)v.y, (int)v.z);
        public static Int.Vec4 CastToInt(Vec4 v) => new((int)v.x, (int)v.y, (int)v.z, (int)v.w);




        #endregion
    }
}
