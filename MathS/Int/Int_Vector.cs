using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace MathS
{
    public static partial class Int
    {
        public class Vector
        {
            private int[] values;
            public static implicit operator int[](Vector vector) => vector.values;
            public static explicit operator Vector(int[] values) => new(values);
            public int sqrMagnitude { get => values.Select(a => a * a).Sum(); }

            public int this[int key]
            {
                get => values[key];
                set => values[key] = value;
            }
            public Vector(Vector v, Func<int, int> modifier)
            {
                values = v.values.Select(modifier).ToArray();
            }
            public Vector(Vector a, Vector b, Func<(int, int), int> modifier)
            {
                values = a.values.Zip(b.values).Select(modifier).ToArray();
            }
            public Vector(Vector a, Vector b, Vector c, Func<(int, int, int), int> modifier)
            {
                values = a.values.Zip(b.values, c.values).Select(modifier).ToArray();
            }
            public Vector(int[] values)
            {
                this.values = values;
            }

            public static Vector operator +(Vector a, Vector b)
                => new Vector(a.values.Zip(b.values, (A, B) => A + B).ToArray());
            public static Vector operator -(Vector a, Vector b)
                => new Vector(a.values.Zip(b.values, (A, B) => A - B).ToArray());
            public static Vector operator *(Vector a, Vector b)
                => new Vector(a.values.Zip(b.values, (A, B) => A * B).ToArray());
            public static Vector operator *(Vector a, int b)
                => new Vector(a.values.Select(v => v * b).ToArray());
            public static Vector operator *(int a, Vector b)
                => new Vector(b.values.Select(v => v * a).ToArray());
            public static Vector operator /(Vector a, Vector b)
                => new Vector(a.values.Zip(b.values, (A, B) => A / B).ToArray());
            public static Vector operator /(Vector a, int b)
                => new Vector(a.values.Select(v => v / b).ToArray());
            public static Vector operator /(int a, Vector b)
               => new Vector(b.values.Select(v => v / a).ToArray());
            public static Vector operator %(Vector a, Vector b)
                => new Vector(a.values.Zip(b.values, (A, B) => A % B).ToArray());
            public static Vector operator %(Vector a, int b)
                => new Vector(a.values.Select(v => v % b).ToArray());
            public static Vector operator %(int a, Vector b)
               => new Vector(b.values.Select(v => v % a).ToArray());
            public static Vector operator ^(Vector a, Vector b)
                => new Vector(a.values.Zip(b.values, (A, B) => A ^ B).ToArray());
            public static Vector operator ^(Vector a, int b)
                => new Vector(a.values.Select(v => v ^ b).ToArray());
            public static Vector operator ^(int a, Vector b)
               => new Vector(b.values.Select(v => v ^ a).ToArray());
            public static Vector operator &(Vector a, Vector b)
                => new Vector(a.values.Zip(b.values, (A, B) => A & B).ToArray());
            public static Vector operator &(Vector a, int b)
                => new Vector(a.values.Select(v => v & b).ToArray());
            public static Vector operator &(int a, Vector b)
               => new Vector(b.values.Select(v => v & a).ToArray());
            public static Vector operator |(Vector a, Vector b)
                => new Vector(a.values.Zip(b.values, (A, B) => A | B).ToArray());
            public static Vector operator |(Vector a, int b)
                => new Vector(a.values.Select(v => v | b).ToArray());
            public static Vector operator |(int a, Vector b)
               => new Vector(b.values.Select(v => v | a).ToArray());
            public static Vector operator >>(Vector a, Vector b)
                => new Vector(a.values.Zip(b.values, (A, B) => A >> B).ToArray());
            public static Vector operator >>(Vector a, int b)
                => new Vector(a.values.Select(v => v >> b).ToArray());
            public static Vector operator <<(Vector a, Vector b)
                => new Vector(a.values.Zip(b.values, (A, B) => A << B).ToArray());
            public static Vector operator <<(Vector a, int b)
                => new Vector(a.values.Select(v => v << b).ToArray());

            public static bool operator ==(Vector a, Vector b) => a.values == b.values;
            public static bool operator !=(Vector a, Vector b) => a.values != b.values;
            public int size { get => values.Length; }
        }

        public static Vector Abs(Vector v) => new(v, Abs);
        public static Vector Clamp(Vector v, int min, int max) => new(v, V => Clamp(V, min, max));
        public static Vector Clamp(Vector v, Vector min, Vector max) => new(v, min, max, V => Clamp(V.Item1, V.Item2, V.Item3));
        public static Vector Max(Vector v, int max) => new(v, V => Max(V, max));
        public static Vector Max(Vector v, Vector max) => new(v, max, V => Max(V.Item1, V.Item2));
        public static Vector Min(Vector v, int min) => new(v, V => Min(V, min));
        public static Vector Min(Vector v, Vector min) => new(v, min, V => Min(V.Item1, V.Item2));
        public static Vector Sign(Vector v) => new(v, Sign);
        public static Vector Log2(Vector v) => new(v, Log2);
        public static int Dot(Vector a, Vector b) => ((int[])a).Zip((int[])b, (A, B) => A * B).Sum();
        public static int SqrDist(Vector a, Vector b) => (a - b).sqrMagnitude;
        public static Vector Reflect(Vector a, Vector b) => a - (2 * (Dot(a, b) * b));
    }
}
