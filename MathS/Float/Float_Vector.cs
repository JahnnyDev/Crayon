using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathS
{
    public static partial class Float
    {
        public class Vector
        {
            private float[] values;
            public static implicit operator float[](Vector vector) => vector.values;
            public static explicit operator Vector(float[] values) => new(values);
            public float this[int key]
            {
                get => values[key];
                set => values[key] = value;
            }

            public Vector(float[] values)
            {
                this.values = values;
            }
            public Vector(Vector v, Func<float, float> modifier)
            {
                values = v.values.Select(modifier).ToArray();
            }
            public Vector(Vector a, Vector b, Func<(float, float), float> modifier)
            {
                values = a.values.Zip(b.values).Select(modifier).ToArray();
            }
            public Vector(Vector a, Vector b, Vector c, Func<(float, float, float), float> modifier)
            {
                values = a.values.Zip(b.values, c.values).Select(modifier).ToArray();
            }

            public float sqrMagnitude { get => values.Select(v => v * v).Sum(); }
            public float magnitude { get => Sqrt(sqrMagnitude); }
            public static Vector operator +(Vector a, Vector b)
                 => new Vector(a, b, v => v.Item1 + v.Item2);
            public static Vector operator -(Vector a, Vector b)
                => new Vector(a, b, v => v.Item1 - v.Item2);
            public static Vector operator -(Vector a)
                => new Vector(a, v => -v);
            public static Vector operator *(Vector a, Vector b)
                => new Vector(a, b, v => v.Item1 * v.Item2);
            public static Vector operator *(Vector a, float b)
                => new Vector(a, v => v * b);
            public static Vector operator *(float a, Vector b)
                => new Vector(b, v => a * v);
            public static Vector operator /(Vector a, Vector b)
               => new Vector(a, b, v => v.Item1 / v.Item2);
            public static Vector operator /(Vector a, float b)
                => new Vector(a, v => v / b);
            public static Vector operator /(float a, Vector b)
                => new Vector(b, v => a / v);
            public static Vector operator %(Vector a, Vector b)
               => new Vector(a, b, v => v.Item1 % v.Item2);
            public static Vector operator %(Vector a, float b)
                => new Vector(a, v => v % b);
            public static Vector operator %(float a, Vector b)
                => new Vector(b, v => a % v);
            public static bool operator ==(Vector a, Vector b) => a.values == b.values;
            public static bool operator !=(Vector a, Vector b) => a.values != b.values;
            public int size
            {
                get => values.Length;
                set
                {
                    float[] vals = new float[value];
                    for (int i = 0; i < value; i++)
                    {
                        if (i < values.Length)
                            vals[i] = values[i];
                    }
                    values = vals;
                }
            }
        }
        public static Vector Clamp(Vector v, Vector min, Vector max) => new(v, min, max, V => Clamp(V.Item1, V.Item2, V.Item3));
        public static Vector Clamp(Vector v, float min, float max) => new(v, V => Clamp(V, min, max));
        public static Vector Max(Vector v, Vector max) => new(v, max, V => Max(V.Item1, V.Item2));
        public static Vector Min(Vector v, Vector min) => new(v, min, V => Min(V.Item1, V.Item2));
        public static Vector Max(Vector v, float max) => new(v, V => Max(V, max));
        public static Vector Min(Vector v, float min) => new(v, V => Min(V, min));
        public static Vector Frac(Vector v) => new(v, V => Frac(V));
        public static Vector Lerp(Vector a, Vector b, float t) => a + (t * (b - a));
        public static Vector Sign(Vector v) => new(v, V => Sign(V));

        public static Vector Degrees(Vector v) => v * degreeConversionConst;
        public static Vector Radians(Vector v) => v * radianConversionConst;
        public static Vector Sin(Vector v) => new(v, V => Sin(V));
        public static Vector Cos(Vector v) => new(v, V => Cos(V));
        public static Vector Tan(Vector v) => new(v, V => Tan(V));
        public static Vector Csc(Vector v) => new(v, V => Csc(V));
        public static Vector Sec(Vector v) => new(v, Sec);
        public static Vector Cot(Vector v) => new(v, V => Cot(V));
        public static Vector Asin(Vector v) => new(v, V => Asin(V));
        public static Vector Acos(Vector v) => new(v, V => Acos(V));
        public static Vector Atan(Vector v) => new(v, V => Acos(V));

        public static Vector Sinh(Vector v) => new(v, V => Sinh(V));
        public static Vector Cosh(Vector v) => new(v, V => Cosh(V));
        public static Vector Tanh(Vector v) => new(v, V => Tanh(V));
        public static Vector Asinh(Vector v) => new(v, V => Asinh(V));
        public static Vector Acosh(Vector v) => new(v, V => Acosh(V));
        public static Vector Atanh(Vector v) => new(v, V => Atanh(V));

        public static Vector Pow(Vector v, Vector p) => new(v, p, V => Pow(V.Item1, V.Item2));
        public static Vector Pow(Vector v, float p) => new(v, V => Pow(V, p));
        public static Vector Exp(Vector v) => new(v, V => Exp(V));
        public static Vector Exp10(Vector v) => new(v, V => Exp10(V));
        public static Vector Exp2(Vector v) => new(v, V => Exp2(V));
        public static Vector Logn(Vector v) => new(v, V => Logn(V));
        public static Vector Log10(Vector v) => new(v, V => Log10(V));
        public static Vector Log2(Vector v) => new(v, V => Log2(V));
        public static Vector Log(Vector v, Vector b) => new(v, b, V => Log(V.Item1, V.Item2));
        public static Vector Sqrt(Vector v) => new(v, V => Sqrt(V));
        public static Vector Cbrt(Vector v) => new(v, V => Cbrt(V));
        public static Vector Nroot(Vector v, Vector b) => new(v, b, V => Nroot(V.Item1, V.Item2));
        public static Vector InvSqrt(Vector v) => new(v, V => InvSqrt(V));

        public static float Distance(Vector a, Vector b) => (a - b).magnitude;
        public static float SqrDist(Vector a, Vector b) => (a - b).sqrMagnitude;
        public static float Dot(Vector a, Vector b) => ((float[])(a * b)).Sum();
        public static Vector Reflect(Vector a, Vector b) => a - (2f * (Dot(a, b) * b));
    }
}
