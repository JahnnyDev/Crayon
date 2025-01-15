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
        public struct Vec3
        {
            public int x, y, z;
            public Vec3(int v)
            {
                x = v;
                y = v;
                z = v;
            }
            public Vec3(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            public Vec3(Vec2 v, int z)
            {
                x = v.x;
                y = v.y;
                this.z = z;
            }
            public Vec3(int x, Vec2 v)
            {
                this.x = x;
                y = v.x;
                z = v.y;
            }
            public Vec3(Vec3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
            public static readonly Vec3 zero = new(0);
            public static readonly Vec3 one = new(1);
            public static readonly Vec3 unitX = new(1, 0, 0);
            public static readonly Vec3 unitY = new(0, 1, 0);
            public static readonly Vec3 unitZ = new(0, 0, 1);
            public static readonly Vec3 unitXY = new Vec3(1, 1, 0);
            public static readonly Vec3 unitXZ = new Vec3(1, 0, 1);
            public static readonly Vec3 unitYZ = new Vec3(0, 1, 1);

            [Pure] public int sqrMagnitude { get => (x * x) + (y * y) + (z * z); }
            [Pure] public Vec3 mirrorX { get => new(-x, yz); }
            [Pure] public Vec3 mirrorY { get => new(x, -y, z); }
            [Pure] public Vec3 mirrorZ { get => new(xy, -z); }
            [Pure] public Vec3 mirrorXY { get => new(-xy, z); }
            [Pure] public Vec3 mirrorXZ { get => new(-x, y, -z); }
            [Pure] public Vec3 mirrorYZ { get => new(x, -yz); }
            [Pure] public Vec3 flattenX { get => new(0, yz); }
            [Pure] public Vec3 flattenY { get => new(x, 0, 0); }
            [Pure] public Vec3 FlattenZ { get => new(xy, 0); }
            [Pure] public Vec3 flattenXY { get => new(0, 0, z); }
            [Pure] public Vec3 flattenXZ { get => new(0, y, 0); }
            [Pure] public Vec3 FlattenYZ { get => new(x, 0, 0); }

            [Pure] public Vec2 xx { get => new(x); }
            public Vec2 xy { get => new(x, y); set { x = value.x; y = value.y; } }
            public Vec2 xz { get => new(x, z); set { x = value.x; z = value.y; } }
            public Vec2 yx { get => new(y, x); set { y = value.x; x = value.y; } }
            [Pure] public Vec2 yy { get => new(y); }
            public Vec2 yz { get => new(y, z); set { y = value.x; z = value.y; } }
            public Vec2 zx { get => new(z, x); set { z = value.x; x = value.y; } }
            public Vec2 zy { get => new(z, y); set { z = value.x; y = value.y; } }
            [Pure] public Vec2 zz { get => new(z); }

            [Pure] public Vec3 xxx { get => new(x); }
            [Pure] public Vec3 xxy { get => new(xx, y); }
            [Pure] public Vec3 xxz { get => new(xx, z); }
            [Pure] public Vec3 xyx { get => new(xy, x); }
            [Pure] public Vec3 xyy { get => new(xy, y); }
            public Vec3 xyz { get => this; set { x = value.x; y = value.y; z = value.z; } }
            [Pure] public Vec3 xzx { get => new(xz, x); }
            public Vec3 xzy { get => new(xz, y); set { x = value.x; z = value.y; y = value.z; } }
            [Pure] public Vec3 xzz { get => new(xz, z); }
            [Pure] public Vec3 yxx { get => new(yx, x); }
            [Pure] public Vec3 yxy { get => new(yx, y); }
            public Vec3 yxz { get => new(yx, z); set { y = value.x; x = value.y; z = value.z; } }
            [Pure] public Vec3 yyx { get => new(yy, x); }
            [Pure] public Vec3 yyy { get => new(y); }
            [Pure] public Vec3 yyz { get => new(yy, z); }
            public Vec3 yzx { get => new(yz, x); set { y = value.x; z = value.y; x = value.z; } }
            [Pure] public Vec3 yzy { get => new(yz, y); }
            [Pure] public Vec3 yzz { get => new(yz, z); }
            [Pure] public Vec3 zxx { get => new(zx, x); }
            public Vec3 zxy { get => new(zx, y); set { z = value.x; x = value.y; y = value.z; } }
            [Pure] public Vec3 zxz { get => new(zx, z); }
            public Vec3 zyx { get => new(zy, x); set { z = value.y; y = value.y; x = value.z; } }
            [Pure] public Vec3 zyy { get => new(zy, y); }
            [Pure] public Vec3 zyz { get => new(zy, z); }
            [Pure] public Vec3 zzx { get => new(zz, x); }
            [Pure] public Vec3 zzy { get => new(zz, y); }
            [Pure] public Vec3 zzz { get => new(z); }

            [Pure] public Vec4 xxxx { get => new(x); }
            [Pure] public Vec4 xxxy { get => new(xxx, y); }
            [Pure] public Vec4 xxxz { get => new(xxx, z); }
            [Pure] public Vec4 xxyx { get => new(xxy, x); }
            [Pure] public Vec4 xxyy { get => new(xxy, y); }
            [Pure] public Vec4 xxyz { get => new(xxy, z); }
            [Pure] public Vec4 xxzx { get => new(xxz, x); }
            [Pure] public Vec4 xxzy { get => new(xxz, y); }
            [Pure] public Vec4 xxzz { get => new(xxz, z); }
            [Pure] public Vec4 xyxx { get => new(xyx, x); }
            [Pure] public Vec4 xyxy { get => new(xyx, y); }
            [Pure] public Vec4 xyxz { get => new(xyx, z); }
            [Pure] public Vec4 xyyx { get => new(xyy, x); }
            [Pure] public Vec4 xyyy { get => new(xyy, y); }
            [Pure] public Vec4 xyyz { get => new(xyy, z); }
            [Pure] public Vec4 xyzx { get => new(xyz, x); }
            [Pure] public Vec4 xyzy { get => new(xyz, y); }
            [Pure] public Vec4 xyzz { get => new(xyz, z); }
            [Pure] public Vec4 xzxx { get => new(xzx, x); }
            [Pure] public Vec4 xzxy { get => new(xzx, y); }
            [Pure] public Vec4 xzxz { get => new(xzx, z); }
            [Pure] public Vec4 xzyx { get => new(xzy, x); }
            [Pure] public Vec4 xzyy { get => new(xzy, y); }
            [Pure] public Vec4 xzyz { get => new(xzy, z); }
            [Pure] public Vec4 xzzx { get => new(xzz, x); }
            [Pure] public Vec4 xzzy { get => new(xzz, y); }
            [Pure] public Vec4 xzzz { get => new(xzz, z); }
            [Pure] public Vec4 yxxx { get => new(yxx, x); }
            [Pure] public Vec4 yxxy { get => new(yxx, y); }
            [Pure] public Vec4 yxxz { get => new(yxx, z); }
            [Pure] public Vec4 yxyx { get => new(yxy, x); }
            [Pure] public Vec4 yxyy { get => new(yxy, y); }
            [Pure] public Vec4 yxyz { get => new(yxy, z); }
            [Pure] public Vec4 yxzx { get => new(yxz, x); }
            [Pure] public Vec4 yxzy { get => new(yxz, y); }
            [Pure] public Vec4 yxzz { get => new(yxz, z); }
            [Pure] public Vec4 yyxx { get => new(yyx, x); }
            [Pure] public Vec4 yyxy { get => new(yyx, y); }
            [Pure] public Vec4 yyxz { get => new(yyx, z); }
            [Pure] public Vec4 yyyx { get => new(yyy, x); }
            [Pure] public Vec4 yyyy { get => new(y); }
            [Pure] public Vec4 yyyz { get => new(yyy, z); }
            [Pure] public Vec4 yyzx { get => new(yyz, x); }
            [Pure] public Vec4 yyzy { get => new(yyz, y); }
            [Pure] public Vec4 yyzz { get => new(yyz, z); }
            [Pure] public Vec4 yzxx { get => new(yzx, x); }
            [Pure] public Vec4 yzxy { get => new(yzx, y); }
            [Pure] public Vec4 yzxz { get => new(yzx, z); }
            [Pure] public Vec4 yzyx { get => new(yzy, x); }
            [Pure] public Vec4 yzyy { get => new(yzy, y); }
            [Pure] public Vec4 yzyz { get => new(yzy, z); }
            [Pure] public Vec4 yzzx { get => new(yzz, x); }
            [Pure] public Vec4 yzzy { get => new(yzz, y); }
            [Pure] public Vec4 yzzz { get => new(yzz, z); }
            [Pure] public Vec4 zxxx { get => new(zxx, x); }
            [Pure] public Vec4 zxxy { get => new(zxx, y); }
            [Pure] public Vec4 zxxz { get => new(zxx, z); }
            [Pure] public Vec4 zxyx { get => new(zxy, x); }
            [Pure] public Vec4 zxyy { get => new(zxy, y); }
            [Pure] public Vec4 zxyz { get => new(zxy, z); }
            [Pure] public Vec4 zxzx { get => new(zxz, x); }
            [Pure] public Vec4 zxzy { get => new(zxz, y); }
            [Pure] public Vec4 zxzz { get => new(zxz, z); }
            [Pure] public Vec4 zyxx { get => new(zyx, x); }
            [Pure] public Vec4 zyxy { get => new(zyx, y); }
            [Pure] public Vec4 zyxz { get => new(zyx, z); }
            [Pure] public Vec4 zyyx { get => new(zyy, x); }
            [Pure] public Vec4 zyyy { get => new(zyy, y); }
            [Pure] public Vec4 zyyz { get => new(zyy, z); }
            [Pure] public Vec4 zyzx { get => new(zyz, x); }
            [Pure] public Vec4 zyzy { get => new(zyz, y); }
            [Pure] public Vec4 zyzz { get => new(zyz, z); }
            [Pure] public Vec4 zzxx { get => new(zzx, x); }
            [Pure] public Vec4 zzxy { get => new(zzx, y); }
            [Pure] public Vec4 zzxz { get => new(zzx, z); }
            [Pure] public Vec4 zzyx { get => new(zzy, x); }
            [Pure] public Vec4 zzyy { get => new(zzy, y); }
            [Pure] public Vec4 zzyz { get => new(zzy, z); }
            [Pure] public Vec4 zzzx { get => new(zzz, x); }
            [Pure] public Vec4 zzzy { get => new(zzz, y); }
            [Pure] public Vec4 zzzz { get => new(z); }

            public static Vec3 operator +(Vec3 a, Vec3 b) => new(a.xy + b.xy, a.z + b.z);
            public static Vec3 operator -(Vec3 a, Vec3 b) => new(a.xy - b.xy, a.z - b.z);
            public static Vec3 operator -(Vec3 v) => new(-v.x, -v.y, -v.z);
            public static Vec3 operator *(Vec3 a, Vec3 b) => new(a.xy * b.xy, a.z * b.z);
            public static Vec3 operator *(int a, Vec3 b) => new(a * b.xy, a * b.z);
            public static Vec3 operator *(Vec3 a, int b) => new(a.xy * b, a.z * b);
            public static Vec3 operator /(Vec3 a, Vec3 b) => new(a.xy / b.xy, a.z / b.z);
            public static Vec3 operator /(int a, Vec3 b) => new(a / b.xy, a / b.z);
            public static Vec3 operator /(Vec3 a, int b) => new(a.xy / b, a.z / b);
            public static Vec3 operator %(Vec3 a, Vec3 b) => new(a.xy % b.xy, a.z % b.z);
            public static Vec3 operator %(int a, Vec3 b) => new(a % b.xy, a % b.z);
            public static Vec3 operator %(Vec3 a, int b) => new(a.xy % b, a.z % b);
            public static Vec3 operator ^(Vec3 a, Vec3 b) => new(a.xy ^ b.xy, a.z ^ b.z);
            public static Vec3 operator ^(int a, Vec3 b) => new(a ^ b.xy, a ^ b.z);
            public static Vec3 operator ^(Vec3 a, int b) => new(a.xy ^ b, a.z ^ b);
            public static Vec3 operator &(Vec3 a, Vec3 b) => new(a.xy & b.xy, a.z & b.z);
            public static Vec3 operator &(int a, Vec3 b) => new(a & b.xy, a & b.z);
            public static Vec3 operator &(Vec3 a, int b) => new(a.xy & b, a.z & b);
            public static Vec3 operator |(Vec3 a, Vec3 b) => new(a.xy | b.xy, a.z | b.z);
            public static Vec3 operator |(int a, Vec3 b) => new(a | b.xy, a | b.z);
            public static Vec3 operator |(Vec3 a, int b) => new(a.xy | b, a.z | b);
            public static Vec3 operator >>(Vec3 a, Vec3 b) => new(a.xy >> b.x, a.z >> b.z);
            public static Vec3 operator >>(Vec3 a, int b) => new(a.xy >> b, a.z >> b);
            public static Vec3 operator <<(Vec3 a, Vec3 b) => new(a.xy << b.x, a.z << b.z);
            public static Vec3 operator <<(Vec3 a, int b) => new(a.xy << b, a.z << b);
            public static bool operator ==(Vec3 a, Vec3 b) => a.xy == b.xy && a.z == b.z;
            public static bool operator !=(Vec3 a, Vec3 b) => a.xy != b.xy || a.z != b.z;
        }
        public static Vec3 Abs(Vec3 v) => new(Abs(v.x), Abs(v.yz));
        public static Vec3 Clamp(Vec3 v, int min, int max) => new(Clamp(v.x, min, max), Clamp(v.yz, min, max));
        public static Vec3 Clamp(Vec3 v, Vec3 min, Vec3 max) => new(Clamp(v.x, min.x, max.x), Clamp(v.yz, min.yz, max.yz));
        public static Vec3 Max(Vec3 v, int max) => new(Max(v.x, max), Max(v.yz, max));
        public static Vec3 Max(Vec3 v, Vec3 max) => new(Max(v.x, max.x), Max(v.yz, max.yz));
        public static Vec3 Min(Vec3 v, int min) => new(Min(v.x, min), Min(v.yz, min));
        public static Vec3 Min(Vec3 v, Vec3 min) => new(Min(v.x, min.x), Min(v.yz, min.xz));
        public static Vec3 Sign(Vec3 v) => new(Sign(v.x), Sign(v.yz));
        public static Vec3 Log2(Vec3 v) => new(Log2(v.x), Log2(v.yz));
        public static int Dot(Vec3 a, Vec3 b) => (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
        public static int SqrDist(Vec3 a, Vec3 b) => (a - b).sqrMagnitude;
        public static Vec3 Cross(Vec3 a, Vec3 b)
    => new((a.y * b.z) - (a.z * b.y), (a.z * b.x) - (a.x * b.z), (a.x * b.y) - (a.y * b.x));
        public static Vec3 Reflect(Vec3 a, Vec3 b) => a - (2 * (Dot(a, b) * b));
    }
}
