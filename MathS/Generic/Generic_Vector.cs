using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace MathS
{
    public static partial class Generic
    {
        public class Vector<T>
    where T : System.Numerics.INumber<T>
        {
            private T[] values;
            public static implicit operator T[](Vector<T> vector) => vector.values;
            public static explicit operator Vector<T>(T[] values) => new(values);
            public T this[int key]
            {
                get => values[key];
                set => values[key] = value;
            }

            public Vector(T[] values)
            {
                this.values = values;
            }
            public Vector(Vector<T> v, Func<T, T> modifier)
            {
                values = v.values.Select(modifier).ToArray();
            }
            public Vector(Vector<T> a, Vector<T> b, Func<(T, T), T> modifier)
            {
                values = a.values.Zip(b.values).Select(modifier).ToArray();
            }
            public Vector(Vector<T> a, Vector<T> b, Vector<T> c, Func<(T, T, T), T> modifier)
            {
                values = a.values.Zip(b.values, c.values).Select(modifier).ToArray();
            }
            public T sqrMagnitude
            {
                get
                {
                    T v = T.Zero;
                    for (int i = 0; i < values.Length; i++)
                    {
                        v += values[i];
                    }
                    return v;
                }
            }

            public static Vector<T> operator +(Vector<T> a, Vector<T> b)
                 => new(a.values.Zip(b.values, (A, B) => A + B).ToArray());
            public static Vector<T> operator -(Vector<T> a, Vector<T> b)
                => new(a.values.Zip(b.values, (A, B) => A - B).ToArray());
            public static Vector<T> operator -(Vector<T> a)
    => new(a.values.Select(v => -v).ToArray());
            public static Vector<T> operator *(Vector<T> a, Vector<T> b)
                => new(a.values.Zip(b.values, (A, B) => A * B).ToArray());
            public static Vector<T> operator *(Vector<T> a, T b)
                => new(a.values.Select(v => v * b).ToArray());
            public static Vector<T> operator *(T a, Vector<T> b)
                => new(b.values.Select(v => v * a).ToArray());
            public static Vector<T> operator /(Vector<T> a, Vector<T> b)
                => new(a.values.Zip(b.values, (A, B) => A / B).ToArray());
            public static Vector<T> operator /(Vector<T> a, T b)
                => new(a.values.Select(v => v / b).ToArray());
            public static Vector<T> operator /(T a, Vector<T> b)
               => new(b.values.Select(v => v / a).ToArray());
            public static Vector<T> operator %(Vector<T> a, Vector<T> b)
                => new(a.values.Zip(b.values, (A, B) => A % B).ToArray());
            public static Vector<T> operator %(Vector<T> a, T b)
                => new(a.values.Select(v => v % b).ToArray());
            public static Vector<T> operator %(T a, Vector<T> b)
               => new(b.values.Select(v => v % a).ToArray());
            public static bool operator ==(Vector<T> a, Vector<T> b) => a.values == b.values;
            public static bool operator !=(Vector<T> a, Vector<T> b)
               => a.values != b.values;

            public int size { get => values.Length; }
        }

        public static Vector<T> Clamp<T>(Vector<T> v, Vector<T> min, Vector<T> max) where T : INumber<T> => new(v, min, max, V => Clamp(V.Item1, V.Item2, V.Item3));
        public static Vector<T> Clamp<T>(Vector<T> v, T min, T max) where T : INumber<T> => new(v, V => Clamp(V, min, max));
        public static Vector<T> Max<T>(Vector<T> v, Vector<T> max) where T : INumber<T> => new(v, max, V => Max(V.Item1, V.Item2));
        public static Vector<T> Min<T>(Vector<T> v, Vector<T> min) where T : INumber<T> => new(v, min, V => Min(V.Item1, V.Item2));
        public static Vector<T> Max<T>(Vector<T> v, T max) where T : INumber<T> => new(v, V => Max(V, max));
        public static Vector<T> Min<T>(Vector<T> v, T min) where T : INumber<T> => new(v, V => Min(V, min));
        public static Vector<T> Frac<T>(Vector<T> v) where T : IFloatingPoint<T> => new(v, V => Frac(V));
        public static Vector<T> Lerp<T>(Vector<T> a, Vector<T> b, T t) where T : INumber<T> => a + (t * (b - a));

        public static Vector<T> Sin<T>(Vector<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(v, V => Sin(V));
        public static Vector<T> Cos<T>(Vector<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(v, V => Cos(V));
        public static Vector<T> Tan<T>(Vector<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(v, V => Tan(V));
        public static Vector<T> Csc<T>(Vector<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(v, V => Csc(V));
        public static Vector<T> Sec<T>(Vector<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(v, Sec);
        public static Vector<T> Cot<T>(Vector<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(v, V => Cot(V));
        public static Vector<T> Asin<T>(Vector<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(v, V => Asin(V));
        public static Vector<T> Acos<T>(Vector<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(v, V => Acos(V));
        public static Vector<T> Atan<T>(Vector<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(v, V => Acos(V));

        public static Vector<T> Sinh<T>(Vector<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(v, V => Sinh(V));
        public static Vector<T> Cosh<T>(Vector<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(v, V => Cosh(V));
        public static Vector<T> Tanh<T>(Vector<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(v, V => Tanh(V));
        public static Vector<T> Asinh<T>(Vector<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(v, V => Asinh(V));
        public static Vector<T> Acosh<T>(Vector<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(v, V => Acosh(V));
        public static Vector<T> Atanh<T>(Vector<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(v, V => Atanh(V));

        public static Vector<T> Pow<T>(Vector<T> v, Vector<T> p) where T : struct, INumber<T>, IPowerFunctions<T> => new(v, p, V => Pow(V.Item1, V.Item2));
        public static Vector<T> Pow<T>(Vector<T> v, T p) where T : struct, INumber<T>, IPowerFunctions<T> => new(v, V => Pow(V, p));
        public static Vector<T> Exp<T>(Vector<T> v) where T : struct, INumber<T>, IExponentialFunctions<T> => new(v, V => Exp(V));
        public static Vector<T> Exp10<T>(Vector<T> v) where T : struct, INumber<T>, IExponentialFunctions<T> => new(v, V => Exp10(V));
        public static Vector<T> Exp2<T>(Vector<T> v) where T : struct, INumber<T>, IExponentialFunctions<T> => new(v, V => Exp2(V));
        public static Vector<T> Logn<T>(Vector<T> v) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(v, V => Logn(V));
        public static Vector<T> Log10<T>(Vector<T> v) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(v, V => Log10(V));
        public static Vector<T> Log2<T>(Vector<T> v) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(v, V => Log2(V));
        public static Vector<T> Log<T>(Vector<T> v, Vector<T> b) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(v, b, V => Log(V.Item1, V.Item2));
        public static Vector<T> Sqrt<T>(Vector<T> v) where T : struct, INumber<T>, IRootFunctions<T> => new(v, V => Sqrt(V));
        public static Vector<T> Cbrt<T>(Vector<T> v) where T : struct, INumber<T>, IRootFunctions<T> => new(v, V => Cbrt(V));
        public static Vector<T> Nroot<T>(Vector<T> v, Vector<T> b) where T : struct, INumber<T>, IPowerFunctions<T> => new(v, b, V => Nroot(V.Item1, V.Item2));

        public static T Magnitude<T>(Vector<T> v) where T : struct, INumber<T>, IRootFunctions<T> => Sqrt(v.sqrMagnitude);
        public static T Distance<T>(Vector<T> a, Vector<T> b) where T : struct, INumber<T>, IRootFunctions<T> => Magnitude(a - b);
        public static T SqrDist<T>(Vector<T> a, Vector<T> b) where T : INumber<T> => (a - b).sqrMagnitude;
        public static T Dot<T>(Vector<T> a, Vector<T> b) where T : INumber<T>
        {
            T v = T.Zero;
            for (int i = 0; i < a.size; i++)
            {
                v += (a[i] * b[i]);
            }
            return v;
        }
        public static Vector<T> Reflect<T>(Vector<T> a, Vector<T> b) where T : INumber<T> => a - ((T.One + T.One) * (Dot(a, b) * b));
    }
}
