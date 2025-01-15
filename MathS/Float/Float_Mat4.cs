using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics.Contracts;
using System.Numerics;
using OpenTK.Mathematics;

namespace MathS
{
    public static partial class Float
    {
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct Mat4
        {
            private Matrix4x4 value;
            public static implicit operator Matrix4x4(Mat4 m) => m.value;
           
            public static implicit operator Mat4(Matrix4x4 m) => new(m);
            public Mat4(Matrix4x4 m)
            {
                value = m;
            }
            public Mat4(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
            {
                value = new(m11, m12, m13, m14, m21, m22, m23, m24, m31, m32, m33, m34, m41, m42, m43, m44);
            }
            public Mat4(float v)
            {
                value = new(v, v, v, v, v, v, v, v, v, v, v, v, v, v, v, v);
            }
            public Mat4(Vec4 a, Vec4 b, Vec4 c, Vec4 d)
            {
                value = new(a.x, a.y, a.z, a.w, b.x, b.y, b.z, b.w, c.x, c.y, c.z, c.w, d.x, d.y, d.z, d.w);
            }
            public Mat4(Vec4 v)
            {
                value = new(v.x, v.y, v.z, v.w, v.x, v.y, v.z, v.w, v.x, v.y, v.z, v.w, v.x, v.y, v.z, v.w);
            }

            public static readonly Mat4 zero = new(0);
            public static readonly Mat4 one = new(1);
            public static readonly Mat4 identity = Matrix4x4.Identity;
            public float[] ToArray() => new float[]
            {
                a1,a2,a3,a4,
                b1,b2,b3,b4,
                c1,c2,c3,c4,
                d1,d2,d3,d4,
            };
         
            public Mat4 invert {
                get
                {
                    Matrix4x4 m = this.value;
                    Matrix4x4.Invert(m, out m);
                    return m;
                }
            }

            public float a1 { get => value.M11; set => this.value.M11 = value; }
            public float a2 { get => value.M12; set => this.value.M12 = value; }
            public float a3 { get => value.M13; set => this.value.M13 = value; }
            public float a4 { get => value.M14; set => this.value.M14 = value; }
            public float b1 { get => value.M21; set => this.value.M21 = value; }
            public float b2 { get => value.M22; set => this.value.M22 = value; }
            public float b3 { get => value.M23; set => this.value.M23 = value; }
            public float b4 { get => value.M24; set => this.value.M24 = value; }
            public float c1 { get => value.M31; set => this.value.M31 = value; }
            public float c2 { get => value.M32; set => this.value.M32 = value; }
            public float c3 { get => value.M33; set => this.value.M33 = value; }
            public float c4 { get => value.M34; set => this.value.M34 = value; }
            public float d1 { get => value.M41; set => this.value.M41 = value; }
            public float d2 { get => value.M42; set => this.value.M42 = value; }
            public float d3 { get => value.M43; set => this.value.M43 = value; }
            public float d4 { get => value.M44; set => this.value.M44 = value; }

            public Vec4 a { get => new(a1, a2, a3, a4); set { a1 = value.x; a2 = value.y; a3 = value.z; a4 = value.w; } }
            public Vec4 b { get => new(b1, b2, b3, b4); set { b1 = value.x; b2 = value.y; b3 = value.z; b4 = value.w; } }
            public Vec4 c { get => new(c1, c2, c3, c4); set { c1 = value.x; c2 = value.y; c3 = value.z; c4 = value.w; } }
            public Vec4 d { get => new(d1, c2, d3, d4); set { d1 = value.x; d2 = value.y; d3 = value.z; d4 = value.w; } }
            [Pure] public Mat4 aaaa { get => new(a, a, a, a); }
            [Pure] public Mat4 aaab { get => new(a, a, a, b); }
            [Pure] public Mat4 aaac { get => new(a, a, a, c); }
            [Pure] public Mat4 aaad { get => new(a, a, a, d); }
            [Pure] public Mat4 aaba { get => new(a, a, b, a); }
            [Pure] public Mat4 aabb { get => new(a, a, b, b); }
            [Pure] public Mat4 aabc { get => new(a, a, b, c); }
            [Pure] public Mat4 aabd { get => new(a, a, b, d); }
            [Pure] public Mat4 aaca { get => new(a, a, c, a); }
            [Pure] public Mat4 aacb { get => new(a, a, c, b); }
            [Pure] public Mat4 aacc { get => new(a, a, c, c); }
            [Pure] public Mat4 aacd { get => new(a, a, c, d); }
            [Pure] public Mat4 aada { get => new(a, a, d, a); }
            [Pure] public Mat4 aadb { get => new(a, a, d, b); }
            [Pure] public Mat4 aadc { get => new(a, a, d, c); }
            [Pure] public Mat4 aadd { get => new(a, a, d, d); }
            [Pure] public Mat4 abaa { get => new(a, b, a, a); }
            [Pure] public Mat4 abab { get => new(a, b, a, b); }
            [Pure] public Mat4 abac { get => new(a, b, a, c); }
            [Pure] public Mat4 abad { get => new(a, b, a, d); }
            [Pure] public Mat4 abba { get => new(a, b, b, a); }
            [Pure] public Mat4 abbb { get => new(a, b, b, b); }
            [Pure] public Mat4 abbc { get => new(a, b, b, c); }
            [Pure] public Mat4 abbd { get => new(a, b, b, d); }
            [Pure] public Mat4 abca { get => new(a, b, c, a); }
            [Pure] public Mat4 abcb { get => new(a, b, c, b); }
            [Pure] public Mat4 abcc { get => new(a, b, c, c); }
            [Pure] public Mat4 abcd { get => new(a, b, c, d); set { a = value.a; b = value.b; c = value.c; d = value.d; } }
            [Pure] public Mat4 abda { get => new(a, b, d, a); }
            [Pure] public Mat4 abdb { get => new(a, b, d, b); }
            
            [Pure] public Mat4 abdc { get => new(a, b, d, c); set { a = value.a; b = value.b; d = value.c; c = value.d; } }
            [Pure] public Mat4 abdd { get => new(a, b, d, d); }
            [Pure] public Mat4 acaa { get => new(a, c, a, a); }
            [Pure] public Mat4 acab { get => new(a, c, a, b); }
            [Pure] public Mat4 acac { get => new(a, c, a, c); }
            [Pure] public Mat4 acad { get => new(a, c, a, d); }
            [Pure] public Mat4 acba { get => new(a, c, b, a); }
            [Pure] public Mat4 acbb { get => new(a, c, b, b); }
            [Pure] public Mat4 acbc { get => new(a, c, b, c); }
            [Pure] public Mat4 acbd { get => new(a, c, b, d); set { a = value.a; c = value.b; b = value.c; d = value.d; } }
            [Pure] public Mat4 acca { get => new(a, c, c, a); }
            [Pure] public Mat4 accb { get => new(a, c, c, b); }
            [Pure] public Mat4 accc { get => new(a, c, c, c); }
            [Pure] public Mat4 accd { get => new(a, c, c, d); }
            [Pure] public Mat4 acda { get => new(a, c, d, a); }
            [Pure] public Mat4 acdb { get => new(a, c, d, b); set { a = value.a; c = value.b; d = value.c; b = value.d; } }
            [Pure] public Mat4 acdc { get => new(a, c, d, c); }
            [Pure] public Mat4 acdd { get => new(a, c, d, d); }
            [Pure] public Mat4 adaa { get => new(a, d, a, a); }
            [Pure] public Mat4 adab { get => new(a, d, a, b); }
            [Pure] public Mat4 adac { get => new(a, d, a, c); }
            [Pure] public Mat4 adad { get => new(a, d, a, d); }
            [Pure] public Mat4 adba { get => new(a, d, b, a); }
            [Pure] public Mat4 adbb { get => new(a, d, b, b); }
            [Pure] public Mat4 adbc { get => new(a, d, b, c); set { a = value.a; d = value.b; b = value.c; c = value.d; } }
            [Pure] public Mat4 adbd { get => new(a, d, b, d); }
            [Pure] public Mat4 adca { get => new(a, d, c, a); }
            [Pure] public Mat4 adcb { get => new(a, d, c, b); set { a = value.a; d = value.b; c = value.c; b = value.d; } }
            [Pure] public Mat4 adcc { get => new(a, d, c, c); }
            [Pure] public Mat4 adcd { get => new(a, d, c, d); }
            [Pure] public Mat4 adda { get => new(a, d, d, a); }
            [Pure] public Mat4 addb { get => new(a, d, d, b); }
            [Pure] public Mat4 addc { get => new(a, d, d, c); }
            [Pure] public Mat4 addd { get => new(a, d, d, d); }
            [Pure] public Mat4 baaa { get => new(b, a, a, a); }
            [Pure] public Mat4 baab { get => new(b, a, a, b); }
            [Pure] public Mat4 baac { get => new(b, a, a, c); }
            [Pure] public Mat4 baad { get => new(b, a, a, d); }
            [Pure] public Mat4 baba { get => new(b, a, b, a); }
            [Pure] public Mat4 babb { get => new(b, a, b, b); }
            [Pure] public Mat4 babc { get => new(b, a, b, c); }
            [Pure] public Mat4 babd { get => new(b, a, b, d); }
            [Pure] public Mat4 baca { get => new(b, a, c, a); }
            [Pure] public Mat4 bacb { get => new(b, a, c, b); }
            [Pure] public Mat4 bacc { get => new(b, a, c, c); }
            [Pure] public Mat4 bacd { get => new(b, a, c, d); set { b = value.a; a = value.b; c  = value.c; d = value.d; } }
            [Pure] public Mat4 bada { get => new(b, a, d, a); }
            [Pure] public Mat4 badb { get => new(b, a, d, b); }
            [Pure] public Mat4 badc { get => new(b, a, d, c); set { b = value.a; a = value.b; d = value.c; c = value.d; } }
            [Pure] public Mat4 badd { get => new(b, a, d, d); }
            [Pure] public Mat4 bbaa { get => new(b, b, a, a); }
            [Pure] public Mat4 bbab { get => new(b, b, a, b); }
            [Pure] public Mat4 bbac { get => new(b, b, a, c); }
            [Pure] public Mat4 bbad { get => new(b, b, a, d); }
            [Pure] public Mat4 bbba { get => new(b, b, b, a); }
            [Pure] public Mat4 bbbb { get => new(b, b, b, b); }
            [Pure] public Mat4 bbbc { get => new(b, b, b, c); }
            [Pure] public Mat4 bbbd { get => new(b, b, b, d); }
            [Pure] public Mat4 bbca { get => new(b, b, c, a); }
            [Pure] public Mat4 bbcb { get => new(b, b, c, b); }
            [Pure] public Mat4 bbcc { get => new(b, b, c, c); }
            [Pure] public Mat4 bbcd { get => new(b, b, c, d); }
            [Pure] public Mat4 bbda { get => new(b, b, d, a); }
            [Pure] public Mat4 bbdb { get => new(b, b, d, b); }
            [Pure] public Mat4 bbdc { get => new(b, b, d, c); }
            [Pure] public Mat4 bbdd { get => new(b, b, d, d); }
            [Pure] public Mat4 bcaa { get => new(b, c, a, a); }
            [Pure] public Mat4 bcab { get => new(b, c, a, b); }
            [Pure] public Mat4 bcac { get => new(b, c, a, c); }
            [Pure] public Mat4 bcad { get => new(b, c, a, d); set { b = value.a; c = value.b; a = value.c; d = value.d; } }
            [Pure] public Mat4 bcba { get => new(b, c, b, a); }
            [Pure] public Mat4 bcbb { get => new(b, c, b, b); }
            [Pure] public Mat4 bcbc { get => new(b, c, b, c); }
            [Pure] public Mat4 bcbd { get => new(b, c, b, d); }
            [Pure] public Mat4 bcca { get => new(b, c, c, a); }
            [Pure] public Mat4 bccb { get => new(b, c, c, b); }
            [Pure] public Mat4 bccc { get => new(b, c, c, c); }
            [Pure] public Mat4 bccd { get => new(b, c, c, d); }
            [Pure] public Mat4 bcda { get => new(b, c, d, a); set { b = value.a; c = value.b; d = value.c; a = value.d; } }
            [Pure] public Mat4 bcdb { get => new(b, c, d, b); }
            [Pure] public Mat4 bcdc { get => new(b, c, d, c); }
            [Pure] public Mat4 bcdd { get => new(b, c, d, d); }
            [Pure] public Mat4 bdaa { get => new(b, d, a, a); }
            [Pure] public Mat4 bdab { get => new(b, d, a, b); }
            [Pure] public Mat4 bdac { get => new(b, d, a, c); set { b = value.a; d = value.b; a = value.c; c = value.d; } }
            [Pure] public Mat4 bdad { get => new(b, d, a, d); }
            [Pure] public Mat4 bdba { get => new(b, d, b, a); }
            [Pure] public Mat4 bdbb { get => new(b, d, b, b); }
            [Pure] public Mat4 bdbc { get => new(b, d, b, c); }
            [Pure] public Mat4 bdbd { get => new(b, d, b, d); }
            [Pure] public Mat4 bdca { get => new(b, d, c, a); set { b = value.a; d = value.b; c = value.c; a = value.d; } }
            [Pure] public Mat4 bdcb { get => new(b, d, c, b); }
            [Pure] public Mat4 bdcc { get => new(b, d, c, c); }
            [Pure] public Mat4 bdcd { get => new(b, d, c, d); }
            [Pure] public Mat4 bdda { get => new(b, d, d, a); }
            [Pure] public Mat4 bddb { get => new(b, d, d, b); }
            [Pure] public Mat4 bddc { get => new(b, d, d, c); }
            [Pure] public Mat4 bddd { get => new(b, d, d, d); }
            [Pure] public Mat4 caaa { get => new(c, a, a, a); }
            [Pure] public Mat4 caab { get => new(c, a, a, b); }
            [Pure] public Mat4 caac { get => new(c, a, a, c); }
            [Pure] public Mat4 caad { get => new(c, a, a, d); }
            [Pure] public Mat4 caba { get => new(c, a, b, a); }
            [Pure] public Mat4 cabb { get => new(c, a, b, b); }
            [Pure] public Mat4 cabc { get => new(c, a, b, c); }
            [Pure] public Mat4 cabd { get => new(c, a, b, d); set { c = value.a; a = value.b; b = value.c; d = value.d; } }
            [Pure] public Mat4 caca { get => new(c, a, c, a); }
            [Pure] public Mat4 cacb { get => new(c, a, c, b); }
            [Pure] public Mat4 cacc { get => new(c, a, c, c); }
            [Pure] public Mat4 cacd { get => new(c, a, c, d); }
            [Pure] public Mat4 cada { get => new(c, a, d, a); }
            [Pure] public Mat4 cadb { get => new(c, a, d, b); set { c = value.a; a = value.b; d = value.c; b = value.d; } }
            [Pure] public Mat4 cadc { get => new(c, a, d, c); }
            [Pure] public Mat4 cadd { get => new(c, a, d, d); }
            [Pure] public Mat4 cbaa { get => new(c, b, a, a); }
            [Pure] public Mat4 cbab { get => new(c, b, a, b); }
            [Pure] public Mat4 cbac { get => new(c, b, a, c); }
            [Pure] public Mat4 cbad { get => new(c, b, a, d); set { c = value.a; b = value.b; a = value.c; d = value.d; } }
            [Pure] public Mat4 cbba { get => new(c, b, b, a); }
            [Pure] public Mat4 cbbb { get => new(c, b, b, b); }
            [Pure] public Mat4 cbbc { get => new(c, b, b, c); }
            [Pure] public Mat4 cbbd { get => new(c, b, b, d); }
            [Pure] public Mat4 cbca { get => new(c, b, c, a); }
            [Pure] public Mat4 cbcb { get => new(c, b, c, b); }
            [Pure] public Mat4 cbcc { get => new(c, b, c, c); }
            [Pure] public Mat4 cbcd { get => new(c, b, c, d); }
            [Pure] public Mat4 cbda { get => new(c, b, d, a); set { c = value.a; b = value.b; d = value.c; a = value.d; } }
            [Pure] public Mat4 cbdb { get => new(c, b, d, b); }
            [Pure] public Mat4 cbdc { get => new(c, b, d, c); }
            [Pure] public Mat4 cbdd { get => new(c, b, d, d); }
            [Pure] public Mat4 ccaa { get => new(c, c, a, a); }
            [Pure] public Mat4 ccab { get => new(c, c, a, b); }
            [Pure] public Mat4 ccac { get => new(c, c, a, c); }
            [Pure] public Mat4 ccad { get => new(c, c, a, d); }
            [Pure] public Mat4 ccba { get => new(c, c, b, a); }
            [Pure] public Mat4 ccbb { get => new(c, c, b, b); }
            [Pure] public Mat4 ccbc { get => new(c, c, b, c); }
            [Pure] public Mat4 ccbd { get => new(c, c, b, d); }
            [Pure] public Mat4 ccca { get => new(c, c, c, a); }
            [Pure] public Mat4 cccb { get => new(c, c, c, b); }
            [Pure] public Mat4 cccc { get => new(c, c, c, c); }
            [Pure] public Mat4 cccd { get => new(c, c, c, d); }
            [Pure] public Mat4 ccda { get => new(c, c, d, a); }
            [Pure] public Mat4 ccdb { get => new(c, c, d, b); }
            [Pure] public Mat4 ccdc { get => new(c, c, d, c); }
            [Pure] public Mat4 ccdd { get => new(c, c, d, d); }
            [Pure] public Mat4 cdaa { get => new(c, d, a, a); }
            [Pure] public Mat4 cdab { get => new(c, d, a, b); set { c = value.a; d = value.b; a = value.c; b = value.d; } }
            [Pure] public Mat4 cdac { get => new(c, d, a, c); }
            [Pure] public Mat4 cdad { get => new(c, d, a, d); }
            [Pure] public Mat4 cdba { get => new(c, d, b, a); set { c = value.a; d = value.b; b = value.c; a = value.d; } }
            [Pure] public Mat4 cdbb { get => new(c, d, b, b); }
            [Pure] public Mat4 cdbc { get => new(c, d, b, c); }
            [Pure] public Mat4 cdbd { get => new(c, d, b, d); }
            [Pure] public Mat4 cdca { get => new(c, d, c, a); }
            [Pure] public Mat4 cdcb { get => new(c, d, c, b); }
            [Pure] public Mat4 cdcc { get => new(c, d, c, c); }
            [Pure] public Mat4 cdcd { get => new(c, d, c, d); }
            [Pure] public Mat4 cdda { get => new(c, d, d, a); }
            [Pure] public Mat4 cddb { get => new(c, d, d, b); }
            [Pure] public Mat4 cddc { get => new(c, d, d, c); }
            [Pure] public Mat4 cddd { get => new(c, d, d, d); }
            [Pure] public Mat4 daaa { get => new(d, a, a, a); }
            [Pure] public Mat4 daab { get => new(d, a, a, b); }
            [Pure] public Mat4 daac { get => new(d, a, a, c); }
            [Pure] public Mat4 daad { get => new(d, a, a, d); }
            [Pure] public Mat4 daba { get => new(d, a, b, a); }
            [Pure] public Mat4 dabb { get => new(d, a, b, b); }
            [Pure] public Mat4 dabc { get => new(d, a, b, c); set { d = value.a; a = value.b; b = value.c; c = value.d; } }
            [Pure] public Mat4 dabd { get => new(d, a, b, d); }
            [Pure] public Mat4 daca { get => new(d, a, c, a); }
            [Pure] public Mat4 dacb { get => new(d, a, c, b); set { d = value.a; a = value.b; c = value.c; b = value.d; } }
            [Pure] public Mat4 dacc { get => new(d, a, c, c); }
            [Pure] public Mat4 dacd { get => new(d, a, c, d); }
            [Pure] public Mat4 dada { get => new(d, a, d, a); }
            [Pure] public Mat4 dadb { get => new(d, a, d, b); }
            [Pure] public Mat4 dadc { get => new(d, a, d, c); }
            [Pure] public Mat4 dadd { get => new(d, a, d, d); }
            [Pure] public Mat4 dbaa { get => new(d, b, a, a); }
            [Pure] public Mat4 dbab { get => new(d, b, a, b); }
            [Pure] public Mat4 dbac { get => new(d, b, a, c); set { d = value.a; b = value.b; a = value.c; c = value.d; } }
            [Pure] public Mat4 dbad { get => new(d, b, a, d); }
            [Pure] public Mat4 dbba { get => new(d, b, b, a); }
            [Pure] public Mat4 dbbb { get => new(d, b, b, b); }
            [Pure] public Mat4 dbbc { get => new(d, b, b, c); }
            [Pure] public Mat4 dbbd { get => new(d, b, b, d); }
            [Pure] public Mat4 dbca { get => new(d, b, c, a); set { d = value.a; b = value.b; c = value.c; a = value.d; } }
            [Pure] public Mat4 dbcb { get => new(d, b, c, b); }
            [Pure] public Mat4 dbcc { get => new(d, b, c, c); }
            [Pure] public Mat4 dbcd { get => new(d, b, c, d); }
            [Pure] public Mat4 dbda { get => new(d, b, d, a); }
            [Pure] public Mat4 dbdb { get => new(d, b, d, b); }
            [Pure] public Mat4 dbdc { get => new(d, b, d, c); }
            [Pure] public Mat4 dbdd { get => new(d, b, d, d); }
            [Pure] public Mat4 dcaa { get => new(d, c, a, a); }
            [Pure] public Mat4 dcab { get => new(d, c, a, b); set { d = value.a; c = value.b; a = value.c; b = value.d; } }
            [Pure] public Mat4 dcac { get => new(d, c, a, c); }
            [Pure] public Mat4 dcad { get => new(d, c, a, d); }
            [Pure] public Mat4 dcba { get => new(d, c, b, a); set { d = value.a; c = value.b; b = value.c; a = value.d; } }
            [Pure] public Mat4 dcbb { get => new(d, c, b, b); }
            [Pure] public Mat4 dcbc { get => new(d, c, b, c); }
            [Pure] public Mat4 dcbd { get => new(d, c, b, d); }
            [Pure] public Mat4 dcca { get => new(d, c, c, a); }
            [Pure] public Mat4 dccb { get => new(d, c, c, b); }
            [Pure] public Mat4 dccc { get => new(d, c, c, c); }
            [Pure] public Mat4 dccd { get => new(d, c, c, d); }
            [Pure] public Mat4 dcda { get => new(d, c, d, a); }
            [Pure] public Mat4 dcdb { get => new(d, c, d, b); }
            [Pure] public Mat4 dcdc { get => new(d, c, d, c); }
            [Pure] public Mat4 dcdd { get => new(d, c, d, d); }
            [Pure] public Mat4 ddaa { get => new(d, d, a, a); }
            [Pure] public Mat4 ddab { get => new(d, d, a, b); }
            [Pure] public Mat4 ddac { get => new(d, d, a, c); }
            [Pure] public Mat4 ddad { get => new(d, d, a, d); }
            [Pure] public Mat4 ddba { get => new(d, d, b, a); }
            [Pure] public Mat4 ddbb { get => new(d, d, b, b); }
            [Pure] public Mat4 ddbc { get => new(d, d, b, c); }
            [Pure] public Mat4 ddbd { get => new(d, d, b, d); }
            [Pure] public Mat4 ddca { get => new(d, d, c, a); }
            [Pure] public Mat4 ddcb { get => new(d, d, c, b); }
            [Pure] public Mat4 ddcc { get => new(d, d, c, c); }
            [Pure] public Mat4 ddcd { get => new(d, d, c, d); }
            [Pure] public Mat4 ddda { get => new(d, d, d, a); }
            [Pure] public Mat4 dddb { get => new(d, d, d, b); }
            [Pure] public Mat4 dddc { get => new(d, d, d, c); }
            [Pure] public Mat4 dddd { get => new(d, d, d, d); }


            public static Mat4 Billboard(Vec3 position, Vec3 cameraPos, Vec3 cameraUp, Vec3 cameraFwd)
            => Matrix4x4.CreateBillboard(position, cameraPos, cameraUp, cameraFwd);
            public static Mat4 ConstrainedBillboard(Vec3 position, Vec3 rotation, Vec3 cameraPos, Vec3 cameraUp, Vec3 cameraFwd)
            => Matrix4x4.CreateConstrainedBillboard(position, rotation,  cameraPos, cameraUp, cameraFwd);
            public static Mat4 RotateAngleAxis(Vec3 axis, float angle)
            => Matrix4x4.CreateFromAxisAngle(axis, angle);
            public static Mat4 RotateQuaternion(Vec4 axis)
            => Matrix4x4.CreateFromQuaternion(new(axis.x, axis.y, axis.z,axis.w));
            public static Mat4 RotateQuaternion(float x, float y, float z, float w)
            => Matrix4x4.CreateFromQuaternion(new(x,y,z,w));
            public static Mat4 RotateEuler(Vec3 axis)
            => Matrix4x4.CreateFromYawPitchRoll(axis.x, axis.y, axis.z);
            public static Mat4 RotateEuler(float x, float y, float z)
            => Matrix4x4.CreateFromYawPitchRoll(x,y,z);
            public static Mat4 View(Vec3 cameraPos, Vec3 cameraDirection, Vec3 cameraUp)
            => Matrix4x4.CreateLookAt(cameraPos, cameraDirection, cameraUp);
            public static Mat4 Orthographic(float width, float height, float near, float far)
            => Matrix4x4.CreateOrthographic(width, height, near, far);
            public static Mat4 Orthographic(Vec2 size, float near, float far)
            => Matrix4x4.CreateOrthographic(size.x, size.y, near, far);
            public static Mat4 OrthographicOffCenter(float left, float right, float bottom, float top, float near, float far)
            => Matrix4x4.CreateOrthographicOffCenter(left, right, bottom, top, near, far);
            public static Mat4 OrthographicOffCenter(Vec2 bottomLeft, Vec2 topRight, float near, float far)
            => Matrix4x4.CreateOrthographicOffCenter(bottomLeft.x, topRight.x, bottomLeft.y, topRight.y, near, far);
            public static Mat4 Perspective(float width, float height, float near, float far)
            => Matrix4x4.CreatePerspective(width, height, near, far);
            public static Mat4 Perspective(Vec2 size, float near, float far)
            => Matrix4x4.CreatePerspective(size.x, size.y, near, far);
            public static Mat4 PerspectiveFOV(float FOV, float aspectRatio, float near, float far)
            => Matrix4x4.CreatePerspectiveFieldOfView(FOV, aspectRatio, near, far);
            public static Mat4 PerspectiveOffCenter(float left, float right, float bottom, float top, float near, float far)
            => Matrix4x4.CreatePerspectiveOffCenter(left, right, bottom, top, near, far);
            public static Mat4 PerspectiveOffCenter(Vec2 bottomLeft, Vec2 topRight, float near, float far)
            => Matrix4x4.CreatePerspectiveOffCenter(bottomLeft.x, topRight.x, bottomLeft.y, topRight.y, near, far);
            public static Mat4 RotateX(float angle)
            => Matrix4x4.CreateRotationX(angle);
            public static Mat4 RotateY(float angle)
            => Matrix4x4.CreateRotationY(angle);
            public static Mat4 RotateZ(float angle)
            => Matrix4x4.CreateRotationZ(angle);
            public static Mat4 Scale(float scale)
            => Matrix4x4.CreateScale(scale);
            public static Mat4 Scale(float x, float y, float z)
            => Matrix4x4.CreateScale(x,y,z);
            public static Mat4 Scale(Vec3 scale)
            => Matrix4x4.CreateScale(scale);
            public static Mat4 Translate(Vec3 pos)
            => Matrix4x4.CreateTranslation(pos);
            public static Mat4 Translate(float x, float y, float z)
            => Matrix4x4.CreateTranslation(x, y, z);
            public static Mat4 World(Vec3 pos, Vec3 forward, Vec3 up)
            => Matrix4x4.CreateWorld(pos, forward, up);
            public static Mat4 Lerp(Mat4 a, Mat4 b, float t)
                => Matrix4x4.Lerp(a, b, t);
            public static Mat4 Transform(Mat4 m, Vec4 rotation)
            => Matrix4x4.Transform(m, new(rotation.x,rotation.y,rotation.z,rotation.w));
            public static Mat4 Transpose(Mat4 m)
           => Matrix4x4.Transpose(m);

            

            public static Mat4 operator +(Mat4 a, Mat4 b) => a.value + b.value;
            public static Mat4 operator -(Mat4 a, Mat4 b) => a.value - b.value;
            public static Mat4 operator -(Mat4 m) => -m.value;
            public static Mat4 operator *(Mat4 a, Mat4 b) => a.value * b.value;
            public static Mat4 operator *(Mat4 a, float b) => a.value * b;
            public static bool operator ==(Mat4 a, Mat4 b) => a.value == b.value;
            public static bool operator !=(Mat4 a, Mat4 b) => a.value != b.value;

        }

    }
}
