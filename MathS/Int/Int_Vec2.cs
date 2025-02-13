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
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct Vec2
        {
            public Vec2(int[] v)
            {
                x = v[0];
                y = v[1];
            }
            public Vec2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public Vec2(int v)
            {
                x = v;
                y = v;
            }
            public Vec2(Vec2 v)
            {
                x = v.x;
                y = v.y;
            }
            public int x, y;

            public static readonly Vec2 zero = new(0);
            public static readonly Vec2 one = new(1);
            public static readonly Vec2 unitX = new(1, 0);
            public static readonly Vec2 unitY = new(0, 1);

            public int sqrMagnitude { get => (x * x) + (y * y); }
            public float slope { get => y / (float)x; }
            public Vec2 mirrorX { get => new(-x, y); }
            public Vec2 mirrorY { get => new(x, -y); }
            public Vec2 flattenX { get => new(0, y); }
            public Vec2 flattenY { get => new(x, 0); }
            public Vec2 orthagonal { get => yx.mirrorX; }

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



            public static Vec2 operator +(Vec2 a, Vec2 b) => new(a.x + b.x, a.y + b.y);
            public static Vec2 operator -(Vec2 a, Vec2 b) => new(a.x - b.x, a.y - b.y);
            public static Vec2 operator -(Vec2 v) => new(-v.x, -v.y);
            public static Vec2 operator *(Vec2 a, Vec2 b) => new(a.x * b.x, a.y * b.y);
            public static Vec2 operator *(int a, Vec2 b) => new(a * b.x, a * b.y);
            public static Vec2 operator *(Vec2 a, int b) => new(a.x * b, a.y * b);
            public static Vec2 operator /(Vec2 a, Vec2 b) => new(a.x / b.x, a.y / b.y);
            public static Vec2 operator /(int a, Vec2 b) => new(a / b.x, a / b.y);
            public static Vec2 operator /(Vec2 a, int b) => new(a.x / b, a.y / b);
            public static Vec2 operator %(Vec2 a, Vec2 b) => new(a.x % b.x, a.y % b.y);
            public static Vec2 operator %(int a, Vec2 b) => new(a % b.x, a % b.y);
            public static Vec2 operator %(Vec2 a, int b) => new(a.x % b, a.y % b);
            public static Vec2 operator ^(Vec2 a, Vec2 b) => new(a.x ^ b.x, a.y ^ b.y);
            public static Vec2 operator ^(int a, Vec2 b) => new(a ^ b.x, a ^ b.y);
            public static Vec2 operator ^(Vec2 a, int b) => new(a.x ^ b, a.y ^ b);
            public static Vec2 operator &(Vec2 a, Vec2 b) => new(a.x & b.x, a.y & b.y);
            public static Vec2 operator &(int a, Vec2 b) => new(a & b.x, a & b.y);
            public static Vec2 operator &(Vec2 a, int b) => new(a.x & b, a.y & b);
            public static Vec2 operator |(Vec2 a, Vec2 b) => new(a.x | b.x, a.y | b.y);
            public static Vec2 operator |(int a, Vec2 b) => new(a | b.x, a | b.y);
            public static Vec2 operator |(Vec2 a, int b) => new(a.x | b, a.y | b);
            public static Vec2 operator >>(Vec2 a, Vec2 b) => new(a.x >> b.x, a.y >> b.y);
            public static Vec2 operator >>(Vec2 a, int b) => new(a.x >> b, a.y >> b);
            public static Vec2 operator <<(Vec2 a, Vec2 b) => new(a.x << b.x, a.y << b.y);
            public static Vec2 operator <<(Vec2 a, int b) => new(a.x << b, a.y << b);
            public static bool operator ==(Vec2 a, Vec2 b) => a.x == b.x && a.y == b.y;
            public static bool operator !=(Vec2 a, Vec2 b) => a.x != b.x || a.y != b.y;
            public static implicit operator string(Vec2 v) => v.x + ", " + v.y;

        }
        public static Vec2 Abs(Vec2 v) => new(Abs(v.x), Abs(v.y));
        public static Vec2 Clamp(Vec2 v, int min, int max) => new(Clamp(v.x, min, max), Clamp(v.y, min, max));
        public static Vec2 Clamp(Vec2 v, Vec2 min, Vec2 max) => new(Clamp(v.x, min.x, max.x), Clamp(v.y, min.y, max.y));
        public static Vec2 Max(Vec2 v, int max) => new(Max(v.x, max), Max(v.y, max));
        public static Vec2 Max(Vec2 v, Vec2 max) => new(Max(v.x, max.x), Max(v.y, max.y));
        public static Vec2 Min(Vec2 v, int min) => new(Min(v.x, min), Min(v.y, min));
        public static Vec2 Min(Vec2 v, Vec2 min) => new(Min(v.x, min.x), Min(v.y, min.x));
        public static Vec2 Sign(Vec2 v) => new(Sign(v.x), Sign(v.y));
        public static Vec2 Log2(Vec2 v) => new(Log2(v.x), Log2(v.y));
        public static int Dot(Vec2 a, Vec2 b) => (a.x * b.x) + (a.y * b.y);
        public static int SqrDist(Vec2 a, Vec2 b) => (a - b).sqrMagnitude;
        public static Vec2 Reflect(Vec2 a, Vec2 b) => a - (2 * (Dot(a, b) * b));
    }
}
