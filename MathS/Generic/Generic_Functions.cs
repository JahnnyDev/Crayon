using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MathS
{
    public static partial class Generic
    {



        
        #region functions
        public static T Abs<T>(T v) where T : INumber<T> => T.Abs(v);
        public static T Clamp<T>(T v, T min, T max) where T : INumber<T> => T.Clamp(v, min, max);
        public static T Max<T>(T v, T max) where T : INumber<T> => T.Max(v, max);
        public static T Min<T>(T v, T max) where T : INumber<T> => T.Min(v, max);
        public static T Frac<T>(T v)where T: IFloatingPoint<T> => T.Truncate(v);
        public static T Lerp<T>(T a, T b, T t) where T : INumber<T> => a + (t * (b - a));
        public static T Sin<T>(T v) where T : ITrigonometricFunctions<T> => T.Sin(v);
        public static T Cos<T>(T v) where T : ITrigonometricFunctions<T> => T.Cos(v);
        public static T Tan<T>(T v) where T : ITrigonometricFunctions<T> => T.Tan(v);
        public static T Csc<T>(T v) where T : ITrigonometricFunctions<T> => T.One / Sin(v);
        public static T Sec<T>(T v) where T : ITrigonometricFunctions<T> => T.One / Cos(v);
        public static T Cot<T>(T v) where T : ITrigonometricFunctions<T> => T.One / Tan(v);
        public static T Asin<T>(T v) where T : ITrigonometricFunctions<T> => T.Asin(v);
        public static T Acos<T>(T v) where T : ITrigonometricFunctions<T> => T.Acos(v);
        public static T Atan<T>(T v) where T : ITrigonometricFunctions<T> => T.Atan(v);
        public static T Atan2<T>(T y, T x) where T : IComparisonOperators<T, T, bool>, ITrigonometricFunctions<T>
            => x >= T.Zero ? Atan(y / x) : Atan(y / x) - T.Pi;

        public static T Sinh<T>(T v) where T: IHyperbolicFunctions<T> => T.Sinh(v);
        public static T Cosh<T>(T v) where T: IHyperbolicFunctions<T> => T.Cosh(v);
        public static T Tanh<T>(T v) where T: IHyperbolicFunctions<T> => T.Tanh(v);
        public static T Asinh<T>(T v) where T: IHyperbolicFunctions<T> => T.Asinh(v);
        public static T Acosh<T>(T v) where T: IHyperbolicFunctions<T> => T.Acosh(v);
        public static T Atanh<T>(T v) where T: IHyperbolicFunctions<T> => T.Atanh(v);


        public static T Pow<T>(T v, T p) where T : IPowerFunctions<T> => T.Pow(v, p);
        public static T Exp<T>(T v) where T : IExponentialFunctions<T> => T.Exp(v);
        public static T Exp10<T>(T v) where T : IExponentialFunctions<T> => T.Exp10(v);
        public static T Exp2<T>(T v) where T : IExponentialFunctions<T> => T.Exp2(v);
        public static T Logn<T>(T v) where T : ILogarithmicFunctions<T> => T.Log(v);
        public static T Log10<T>(T v) where T : ILogarithmicFunctions<T> => T.Log10(v);
        public static T Log2<T>(T v) where T : ILogarithmicFunctions<T> => T.Log2(v);
        public static T Log<T>(T v, T b) where T : ILogarithmicFunctions<T> => T.Log2(v) / T.Log2(b);
        public static T Sqrt<T>(T v) where T: IRootFunctions<T> => T.Sqrt(v);
        public static T Cbrt<T>(T v) where T : IRootFunctions<T> => T.Cbrt(v);
        public static T Nroot<T>(T v, T b) where T : IPowerFunctions<T> => Pow(v, T.One / b);

        

        

        #endregion



    }
}