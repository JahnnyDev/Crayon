using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MathS
{
    public static partial class Float
    {
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct Mat3x2
        {
            public Matrix3x2 value;
            public static implicit operator Matrix3x2(Mat3x2 m) => m.value;
            public static implicit operator Mat3x2(Matrix3x2 m) => new(m);
            public Mat3x2(Matrix3x2 val) { value = val; }
            public Mat3x2(float a1, float a2,float b1, float b2,float c1, float c2)
            {
                value = new(a1, a2, b1, b2, c1, c2);
            }

            public Mat3x2(float v) { value = new(v, v, v, v, v, v); }
            public Mat3x2(Vec2 v)
            {
                value = new(v.x, v.y, v.x, v.y, v.x, v.y);
            }
            public Mat3x2(Vec2 a, Vec2 b, Vec2 c)
            {
                value = new(a.x, a.y, b.x, b.y, c.x, c.y);
            }
            public Mat3x2(Mat3x2 m)
            {
                value = m.value;
            }

            public float a1 { get => value.M11; set => this.value.M11 = value; }
            public float a2 { get => value.M12; set => this.value.M12 = value; }
            public float b1 { get => value.M21; set => this.value.M21 = value; }
            public float b2 { get => value.M22; set => this.value.M22 = value; }
            public float c1 { get => value.M31; set => this.value.M31 = value; }
            public float c2 { get => value.M32; set => this.value.M32 = value; }

            public Vec2 a { get => new(a1, a2); set { a1 = value.x; a2 = value.y; } }
            public Vec2 b { get => new(b1, b2); set { b1 = value.x; b2 = value.y; } }
            public Vec2 c { get => new(c1, c2); set { c1 = value.x; c2 = value.y; } }

            public static readonly Mat3x2 zero = new(0);
            public static readonly Mat3x2 one = new(1);
            public static readonly Mat3x2 identity = Matrix3x2.Identity;

            public Mat3x2 invert
            {
                get
                {
                    Matrix3x2 m = this.value;
                    Matrix3x2.Invert(m, out m);
                    return m;
                }
            }

            [Pure] public Mat3x2 aaa { get => new(a, a, a); }
            [Pure] public Mat3x2 aab { get => new(a, a, b); }
            [Pure] public Mat3x2 aac { get => new(a, a, c); }
            [Pure] public Mat3x2 aba { get => new(a, b, a); }
            [Pure] public Mat3x2 abb { get => new(a, b, b); }
            [Pure] public Mat3x2 abc { get => new(a, b, c); set { a = value.a; b = value.b; c = value.c; } }
            [Pure] public Mat3x2 aca { get => new(a, c, a); }
            [Pure] public Mat3x2 acb { get => new(a, c, b); set { a = value.a; c = value.b; b = value.c; } }
            [Pure] public Mat3x2 acc { get => new(a, c, c); }
            [Pure] public Mat3x2 baa { get => new(b, a, a); }
            [Pure] public Mat3x2 bab { get => new(b, a, b); }
            [Pure] public Mat3x2 bac { get => new(b, a, c);  set { b = value.a; a = value.b; c = value.c; } }
            [Pure] public Mat3x2 bba { get => new(b, b, a); }
            [Pure] public Mat3x2 bbb { get => new(b, b, b); }
            [Pure] public Mat3x2 bbc { get => new(b, b, c); }
            [Pure] public Mat3x2 bca { get => new(b, c, a);  set { b = value.a; c = value.b; a = value.c; } }
            [Pure] public Mat3x2 bcb { get => new(b, c, b); }
            [Pure] public Mat3x2 bcc { get => new(b, c, c); }
            [Pure] public Mat3x2 caa { get => new(c, a, a); }
            [Pure] public Mat3x2 cab { get => new(c, a, b); set { c = value.a; a = value.b; b = value.c; } }
            [Pure] public Mat3x2 cac { get => new(c, a, c); }
            [Pure] public Mat3x2 cba { get => new(c, b, a); set { c = value.a; b = value.b; a = value.c; } }
            [Pure] public Mat3x2 cbb { get => new(c, b, b); }
            [Pure] public Mat3x2 cbc { get => new(c, b, c); }
            [Pure] public Mat3x2 cca { get => new(c, c, a); }
            [Pure] public Mat3x2 ccb { get => new(c, c, b); }
            [Pure] public Mat3x2 ccc { get => new(c, c, c); }

            public static Mat3x2 Rotate(float angle) => Matrix3x2.CreateRotation(angle);
            public static Mat3x2 Scale(float s) => Matrix3x2.CreateScale(s);
            public static Mat3x2 Scale(Vec2 s) => Matrix3x2.CreateScale(s);
            public static Mat3x2 Skew(float angleX, float angleY) => Matrix3x2.CreateSkew(angleX, angleY);
            public static Mat3x2 Skew(Vec2 angles) => Matrix3x2.CreateSkew(angles.x, angles.y);
            public static Mat3x2 Translate(float x,float y) => Matrix3x2.CreateTranslation(x,y);
            public static Mat3x2 Translate(Vec2 t) => Matrix3x2.CreateTranslation(t);
            public static Mat3x2 Invert(Mat3x2 m)
            {
                Matrix3x2.Invert(m, out m.value);
                return m;
            }
            public static Mat3x2 Lerp(Mat3x2 a, Mat3x2 b, float t) => Matrix3x2.Lerp(a, b, t);
            public static Mat3x2 operator +(Mat3x2 a, Mat3x2 b) => a.value + b.value;
            public static Mat3x2 operator -(Mat3x2 a, Mat3x2 b) => a.value - b.value;
            public static Mat3x2 operator *(Mat3x2 a, Mat3x2 b) => a.value * b.value;
            public static Mat3x2 operator *(Mat3x2 a, float b) => a.value * b;
            public static bool operator ==(Mat3x2 a, Mat3x2 b) => a.value == b.value;
            public static bool operator !=(Mat3x2 a, Mat3x2 b) => a.value != b.value;
        }

    }
}
