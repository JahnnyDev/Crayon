using System;
using System.Collections.Generic;
using System.Linq;
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
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct Vec4<T> where T : struct, System.Numerics.INumber<T>
        {
            public T x, y, z, w;
            public Vec4(T v)
            {
                x = v;
                y = v;
                z = v;
                w = v;
            }
            public Vec4(T x, T y, T z, T w)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                this.w = w;
            }
            public Vec4(Vec2<T> v, T z, T w)
            {
                x = v.x;
                y = v.y;
                this.z = z;
                this.w = w;
            }
            public Vec4(T x, Vec2<T> v, T w)
            {
                this.x = x;
                y = v.x;
                z = v.y;
                this.w = w;
            }
            public Vec4(T x, T y, Vec2<T> v)
            {
                this.x = x;
                this.y = y;
                z = v.x;
                w = v.y;
            }
            public Vec4(Vec2<T> a, Vec2<T> b)
            {
                x = a.x;
                y = a.y;
                z = b.x;
                w = b.y;
            }
            public Vec4(Vec3<T> v, T w)
            {
                x = v.x;
                y = v.y;
                z = v.z;
                this.w = w;
            }
            public Vec4(T x, Vec3<T> v)
            {
                this.x = x;
                y = v.x;
                z = v.y;
                w = v.z;
            }
            public Vec4(Vec4<T> v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
                w = v.w;
            }

            public static readonly Vec4<T> zero = new(T.Zero);
            public static readonly Vec4<T> one = new(T.One);
            public static readonly Vec4<T> unitX = new(T.One, T.Zero, T.Zero, T.Zero);
            public static readonly Vec4<T> unitY = new(T.Zero, T.One, T.Zero, T.Zero);
            public static readonly Vec4<T> unitZ = new(T.Zero, T.Zero, T.One, T.Zero);
            public static readonly Vec4<T> unitW = new(T.Zero, T.Zero, T.Zero, T.One);
            public static readonly Vec4<T> unitXY = new(T.One, T.One, T.Zero, T.Zero);
            public static readonly Vec4<T> unitXZ = new(T.One, T.Zero, T.One, T.Zero);
            public static readonly Vec4<T> unitXW = new(T.One, T.Zero, T.Zero, T.One);
            public static readonly Vec4<T> unitYZ = new(T.Zero, T.One, T.One, T.Zero);
            public static readonly Vec4<T> unitYW = new(T.Zero, T.One, T.Zero, T.One);
            public static readonly Vec4<T> unitZW = new(T.Zero, T.Zero, T.One, T.One);

            [Pure] public T sqrMagnitude { get => (x * x) + (y * y) + (z * z) * (w * w); }
            [Pure] public Vec4<T> mirrorX { get => new(-x, yzw); }
            [Pure] public Vec4<T> mirrorY { get => new(x, -y, zw); }
            [Pure] public Vec4<T> mirrorZ { get => new(xy, -z, w); }
            [Pure] public Vec4<T> mirrorW { get => new(xyz, -w); }
            [Pure] public Vec4<T> mirrorXY { get => new(-xy, zw); }
            [Pure] public Vec4<T> mirrorXZ { get => new(-x, y, -z, w); }
            [Pure] public Vec4<T> mirrorXW { get => new(-x, yz, -w); }
            [Pure] public Vec4<T> mirrorYZ { get => new(x, -yz, w); }
            [Pure] public Vec4<T> mirrorYW { get => new(x, -y, z, -w); }
            [Pure] public Vec4<T> mirrorZW { get => new(xy, -zw); }
            [Pure] public Vec4<T> flattenX { get => new(T.Zero, yzw); }
            [Pure] public Vec4<T> flattenY { get => new(x, T.Zero, zw); }
            [Pure] public Vec4<T> FlattenZ { get => new(xy, T.Zero, w); }
            [Pure] public Vec4<T> flattenXY { get => new(T.Zero, T.Zero, zw); }
            [Pure] public Vec4<T> flattenXZ { get => new(T.Zero, y, T.Zero, w); }
            [Pure] public Vec4<T> flattenXW { get => new(T.Zero, yz, T.Zero); }
            [Pure] public Vec4<T> FlattenYZ { get => new(x, T.Zero, T.Zero, w); }
            [Pure] public Vec4<T> FlattenYW { get => new(x, T.Zero, z, T.Zero); }
            [Pure] public Vec4<T> FlattenZW { get => new(xy, T.Zero, T.Zero); }

            [Pure] public Vec2<T> xx { get => new Vec2<T>(x); }
            public Vec2<T> xy { get => new Vec2<T>(x, y); set { x = value.x; y = value.y; } }
            public Vec2<T> xz { get => new Vec2<T>(x, z); set { x = value.x; z = value.y; } }
            public Vec2<T> xw { get => new Vec2<T>(x, w); set { x = value.x; w = value.y; } }
            public Vec2<T> yx { get => new Vec2<T>(y, x); set { y = value.x; x = value.y; } }
            [Pure] public Vec2<T> yy { get => new Vec2<T>(y); }
            public Vec2<T> yz { get => new Vec2<T>(y, z); set { y = value.x; z = value.y; } }
            public Vec2<T> yw { get => new Vec2<T>(y, w); set { y = value.x; w = value.y; } }
            public Vec2<T> zx { get => new Vec2<T>(z, x); set { z = value.x; x = value.y; } }
            public Vec2<T> zy { get => new Vec2<T>(z, y); set { z = value.x; y = value.y; } }
            [Pure] public Vec2<T> zz { get => new Vec2<T>(z); }
            public Vec2<T> zw { get => new Vec2<T>(z, w); set { z = value.x; w = value.y; } }
            public Vec2<T> wx { get => new Vec2<T>(w, x); set { w = value.x; x = value.y; } }
            public Vec2<T> wy { get => new Vec2<T>(w, y); set { w = value.x; y = value.y; } }
            public Vec2<T> wz { get => new Vec2<T>(w, z); set { w = value.x; z = value.y; } }
            [Pure] public Vec2<T> ww { get => new Vec2<T>(w); }

            [Pure] public Vec3<T> xxx { get => new(x); }
            [Pure] public Vec3<T> xxy { get => new(xx, y); }
            [Pure] public Vec3<T> xxz { get => new(xx, z); }
            [Pure] public Vec3<T> xxw { get => new(xx, w); }
            [Pure] public Vec3<T> xyx { get => new(xy, x); }
            [Pure] public Vec3<T> xyy { get => new(xy, y); }
            public Vec3<T> xyz { get => new(xy, z); set { x = value.x; y = value.y; z = value.z; } }
            public Vec3<T> xyw { get => new(xy, w); set { x = value.x; y = value.y; w = value.z; } }
            [Pure] public Vec3<T> xzx { get => new(xz, x); }
            public Vec3<T> xzy { get => new(xz, y); set { x = value.x; z = value.y; y = value.z; } }
            [Pure] public Vec3<T> xzz { get => new(xz, z); }
            public Vec3<T> xzw { get => new(xz, w); set { x = value.x; z = value.y; w = value.z; } }
            [Pure] public Vec3<T> xwx { get => new(xw, x); }
            public Vec3<T> xwy { get => new(xw, y); set { x = value.x; w = value.y; y = value.z; } }
            public Vec3<T> xwz { get => new(xw, z); set { x = value.x; w = value.y; z = value.z; } }
            [Pure] public Vec3<T> xww { get => new(xw, w); }
            [Pure] public Vec3<T> yxx { get => new(yx, x); }
            [Pure] public Vec3<T> yxy { get => new(yx, y); }
            public Vec3<T> yxz { get => new(yx, z); set { y = value.x; x = value.y; z = value.z; } }
            public Vec3<T> yxw { get => new(yx, w); set { x = value.x; y = value.y; w = value.z; } }
            [Pure] public Vec3<T> yyx { get => new(yy, x); }
            [Pure] public Vec3<T> yyy { get => new(y); }
            [Pure] public Vec3<T> yyz { get => new(yy, z); }
            [Pure] public Vec3<T> yyw { get => new(yy, w); }
            public Vec3<T> yzx { get => new(yz, x); set { y = value.x; z = value.y; x = value.z; } }
            [Pure] public Vec3<T> yzy { get => new(yz, y); }
            [Pure] public Vec3<T> yzz { get => new(yz, z); }
            public Vec3<T> yzw { get => new(yz, w); set { y = value.x; z = value.y; w = value.z; } }
            public Vec3<T> ywx { get => new(yw, x); set { y = value.x; w = value.y; x = value.z; } }
            [Pure] public Vec3<T> ywy { get => new(yw, y); }
            public Vec3<T> ywz { get => new(yw, z); set { y = value.x; w = value.y; z = value.z; } }
            [Pure] public Vec3<T> yww { get => new(yw, w); }
            [Pure] public Vec3<T> zxx { get => new(zx, x); }
            public Vec3<T> zxy { get => new(zx, y); set { z = value.x; x = value.y; y = value.z; } }
            [Pure] public Vec3<T> zxz { get => new(zx, z); }
            public Vec3<T> zxw { get => new(zx, w); set { z = value.x; x = value.y; w = value.z; } }
            public Vec3<T> zyx { get => new(zy, x); set { z = value.x; y = value.y; x = value.z; } }
            [Pure] public Vec3<T> zyy { get => new(zy, y); }
            [Pure] public Vec3<T> zyz { get => new(zy, z); }
            public Vec3<T> zyw { get => new(zy, w); set { z = value.x; y = value.y; w = value.z; } }
            [Pure] public Vec3<T> zzx { get => new(zz, x); }
            [Pure] public Vec3<T> zzy { get => new(zz, y); }
            [Pure] public Vec3<T> zzz { get => new(z); }
            [Pure] public Vec3<T> zzw { get => new(zz, w); }
            public Vec3<T> zwx { get => new(zw, x); set { z = value.x; w = value.y; x = value.z; } }
            public Vec3<T> zwy { get => new(zw, y); set { z = value.x; w = value.y; y = value.z; } }
            [Pure] public Vec3<T> zwz { get => new(zw, z); }
            [Pure] public Vec3<T> zww { get => new(zw, w); }
            [Pure] public Vec3<T> wxx { get => new(wx, x); }
            public Vec3<T> wxy { get => new(wx, y); set { w = value.x; x = value.y; y = value.z; } }
            public Vec3<T> wxz { get => new(wx, z); set { w = value.x; x = value.y; z = value.z; } }
            [Pure] public Vec3<T> wxw { get => new(wx, w); }
            public Vec3<T> wyx { get => new(wy, x); set { w = value.x; y = value.y; x = value.z; } }
            [Pure] public Vec3<T> wyy { get => new(wy, y); }
            public Vec3<T> wyz { get => new(wy, z); set { w = value.x; y = value.y; z = value.z; } }
            [Pure] public Vec3<T> wyw { get => new(wy, w); }
            public Vec3<T> wzx { get => new(wz, x); set { w = value.x; z = value.y; x = value.z; } }
            public Vec3<T> wzy { get => new(wz, y); set { w = value.x; z = value.y; y = value.z; } }
            [Pure] public Vec3<T> wzz { get => new(wz, z); }
            [Pure] public Vec3<T> wzw { get => new(wz, w); }
            [Pure] public Vec3<T> wwx { get => new(ww, x); }
            [Pure] public Vec3<T> wwy { get => new(ww, y); }
            [Pure] public Vec3<T> wwz { get => new(ww, z); }
            [Pure] public Vec3<T> www { get => new(w); }

            [Pure] public Vec4<T> xxxx { get => new(x); }
            [Pure] public Vec4<T> xxxy { get => new(xxx, y); }
            [Pure] public Vec4<T> xxxz { get => new(xxx, z); }
            [Pure] public Vec4<T> xxxw { get => new(xxx, w); }
            [Pure] public Vec4<T> xxyx { get => new(xxy, x); }
            [Pure] public Vec4<T> xxyy { get => new(xxy, y); }
            [Pure] public Vec4<T> xxyz { get => new(xxy, z); }
            [Pure] public Vec4<T> xxyw { get => new(xxy, w); }
            [Pure] public Vec4<T> xxzx { get => new(xxz, x); }
            [Pure] public Vec4<T> xxzy { get => new(xxz, y); }
            [Pure] public Vec4<T> xxzz { get => new(xxz, z); }
            [Pure] public Vec4<T> xxzw { get => new(xxz, w); }
            [Pure] public Vec4<T> xxwx { get => new(xxw, x); }
            [Pure] public Vec4<T> xxwy { get => new(xxw, y); }
            [Pure] public Vec4<T> xxwz { get => new(xxw, z); }
            [Pure] public Vec4<T> xxww { get => new(xxw, w); }
            [Pure] public Vec4<T> xyxx { get => new(xyx, x); }
            [Pure] public Vec4<T> xyxy { get => new(xyx, y); }
            [Pure] public Vec4<T> xyxz { get => new(xyx, z); }
            [Pure] public Vec4<T> xyxw { get => new(xyx, w); }
            [Pure] public Vec4<T> xyyx { get => new(xyy, x); }
            [Pure] public Vec4<T> xyyy { get => new(xyy, y); }
            [Pure] public Vec4<T> xyyz { get => new(xyy, z); }
            [Pure] public Vec4<T> xyyw { get => new(xyy, w); }
            [Pure] public Vec4<T> xyzx { get => new(xyz, x); }
            [Pure] public Vec4<T> xyzy { get => new(xyz, y); }
            [Pure] public Vec4<T> xyzz { get => new(xyz, z); }
            public Vec4<T> xyzw { get => new(xyz, w); set { x = value.x; y = value.y; z = value.z; w = value.w; } }
            [Pure] public Vec4<T> xywx { get => new(xyw, x); }
            [Pure] public Vec4<T> xywy { get => new(xyw, y); }
            [Pure] public Vec4<T> xywz { get => new(xyw, z); set { x = value.x; y = value.y; w = value.z; z = value.w; } }
            [Pure] public Vec4<T> xyww { get => new(xyw, w); }
            [Pure] public Vec4<T> xzxx { get => new(xzx, x); }
            [Pure] public Vec4<T> xzxy { get => new(xzx, y); }
            [Pure] public Vec4<T> xzxz { get => new(xzx, z); }
            [Pure] public Vec4<T> xzxw { get => new(xzx, w); }
            [Pure] public Vec4<T> xzyx { get => new(xzy, x); }
            [Pure] public Vec4<T> xzyy { get => new(xzy, y); }
            [Pure] public Vec4<T> xzyz { get => new(xzy, z); }
            [Pure] public Vec4<T> xzyw { get => new(xzy, w); set { x = value.x; z = value.y; y = value.z; w = value.w; } }
            [Pure] public Vec4<T> xzzx { get => new(xzz, x); }
            [Pure] public Vec4<T> xzzy { get => new(xzz, y); }
            [Pure] public Vec4<T> xzzz { get => new(xzz, z); }
            [Pure] public Vec4<T> xzzw { get => new(xzz, w); }
            [Pure] public Vec4<T> xzwx { get => new(xzw, x); }
            [Pure] public Vec4<T> xzwy { get => new(xzw, y); set { x = value.x; z = value.y; w = value.z; y = value.w; } }
            [Pure] public Vec4<T> xzwz { get => new(xzw, z); }
            [Pure] public Vec4<T> xzww { get => new(xzw, w); }
            [Pure] public Vec4<T> xwxx { get => new(xwx, x); }
            [Pure] public Vec4<T> xwxy { get => new(xwx, y); }
            [Pure] public Vec4<T> xwxz { get => new(xwx, z); }
            [Pure] public Vec4<T> xwxw { get => new(xwx, w); }
            [Pure] public Vec4<T> xwyx { get => new(xwy, x); }
            [Pure] public Vec4<T> xwyy { get => new(xwy, y); }
            [Pure] public Vec4<T> xwyz { get => new(xwy, z); set { x = value.x; w = value.y; y = value.z; z = value.w; } }
            [Pure] public Vec4<T> xwyw { get => new(xwy, w); }
            [Pure] public Vec4<T> xwzx { get => new(xwz, x); }
            [Pure] public Vec4<T> xwzy { get => new(xwz, y); set { x = value.x; w = value.y; z = value.z; y = value.w; } }
            [Pure] public Vec4<T> xwzz { get => new(xwz, z); }
            [Pure] public Vec4<T> xwzw { get => new(xwz, w); }
            [Pure] public Vec4<T> xwwx { get => new(xww, x); }
            [Pure] public Vec4<T> xwwy { get => new(xww, y); }
            [Pure] public Vec4<T> xwwz { get => new(xww, z); }
            [Pure] public Vec4<T> xwww { get => new(xww, w); }

            [Pure] public Vec4<T> yxxx { get => new(yxx, x); }
            [Pure] public Vec4<T> yxxy { get => new(yxx, y); }
            [Pure] public Vec4<T> yxxz { get => new(yxx, z); }
            [Pure] public Vec4<T> yxxw { get => new(yxx, w); }
            [Pure] public Vec4<T> yxyx { get => new(yxy, x); }
            [Pure] public Vec4<T> yxyy { get => new(yxy, y); }
            [Pure] public Vec4<T> yxyz { get => new(yxy, z); }
            [Pure] public Vec4<T> yxyw { get => new(yxy, w); }
            [Pure] public Vec4<T> yxzx { get => new(yxz, x); }
            [Pure] public Vec4<T> yxzy { get => new(yxz, y); }
            [Pure] public Vec4<T> yxzz { get => new(yxz, z); }
            [Pure] public Vec4<T> yxzw { get => new(yxz, w); set { y = value.x; x = value.y; z = value.z; w = value.w; } }
            [Pure] public Vec4<T> yxwx { get => new(yxw, x); }
            [Pure] public Vec4<T> yxwy { get => new(yxw, y); }
            [Pure] public Vec4<T> yxwz { get => new(yxw, z); set { y = value.x; x = value.y; w = value.z; z = value.w; } }
            [Pure] public Vec4<T> yxww { get => new(yxw, w); }
            [Pure] public Vec4<T> yyxx { get => new(yyx, x); }
            [Pure] public Vec4<T> yyxy { get => new(yyx, y); }
            [Pure] public Vec4<T> yyxz { get => new(yyx, z); }
            [Pure] public Vec4<T> yyxw { get => new(yyx, w); }
            [Pure] public Vec4<T> yyyx { get => new(yyy, x); }
            [Pure] public Vec4<T> yyyy { get => new(yyy, y); }
            [Pure] public Vec4<T> yyyz { get => new(yyy, z); }
            [Pure] public Vec4<T> yyyw { get => new(yyy, w); }
            [Pure] public Vec4<T> yyzx { get => new(yyz, x); }
            [Pure] public Vec4<T> yyzy { get => new(yyz, y); }
            [Pure] public Vec4<T> yyzz { get => new(yyz, z); }
            [Pure] public Vec4<T> yyzw { get => new(yyz, w); }
            [Pure] public Vec4<T> yywx { get => new(yyw, x); }
            [Pure] public Vec4<T> yywy { get => new(yyw, y); }
            [Pure] public Vec4<T> yywz { get => new(yyw, z); }
            [Pure] public Vec4<T> yyww { get => new(yyw, w); }
            [Pure] public Vec4<T> yzxx { get => new(yzx, x); }
            [Pure] public Vec4<T> yzxy { get => new(yzx, y); }
            [Pure] public Vec4<T> yzxz { get => new(yzx, z); }
            public Vec4<T> yzxw { get => new(yzx, w); set { y = value.x; z = value.y; x = value.z; w = value.w; } }
            [Pure] public Vec4<T> yzyx { get => new(yzy, x); }
            [Pure] public Vec4<T> yzyy { get => new(yzy, y); }
            [Pure] public Vec4<T> yzyz { get => new(yzy, z); }
            [Pure] public Vec4<T> yzyw { get => new(yzy, w); }
            [Pure] public Vec4<T> yzzx { get => new(yzz, x); }
            [Pure] public Vec4<T> yzzy { get => new(yzz, y); }
            [Pure] public Vec4<T> yzzz { get => new(yzz, z); }
            [Pure] public Vec4<T> yzzw { get => new(yzz, w); }
            public Vec4<T> yzwx { get => new(yzw, x); set { y = value.x; z = value.y; w = value.z; x = value.w; } }
            [Pure] public Vec4<T> yzwy { get => new(yzw, y); }
            [Pure] public Vec4<T> yzwz { get => new(yzw, z); }
            [Pure] public Vec4<T> yzww { get => new(yzw, w); }
            [Pure] public Vec4<T> ywxx { get => new(ywx, x); }
            [Pure] public Vec4<T> ywxy { get => new(ywx, y); }
            public Vec4<T> ywxz { get => new(ywx, z); set { y = value.x; w = value.y; x = value.z; z = value.w; } }
            [Pure] public Vec4<T> ywxw { get => new(ywx, w); }
            [Pure] public Vec4<T> ywyx { get => new(ywy, x); }
            [Pure] public Vec4<T> ywyy { get => new(ywy, y); }
            [Pure] public Vec4<T> ywyz { get => new(ywy, z); }
            [Pure] public Vec4<T> ywyw { get => new(ywy, w); }
            public Vec4<T> ywzx { get => new(ywz, x); set { y = value.x; w = value.y; z = value.z; x = value.w; } }
            [Pure] public Vec4<T> ywzy { get => new(ywz, y); }
            [Pure] public Vec4<T> ywzz { get => new(ywz, z); }
            [Pure] public Vec4<T> ywzw { get => new(ywz, w); }
            [Pure] public Vec4<T> ywwx { get => new(yww, x); }
            [Pure] public Vec4<T> ywwy { get => new(yww, y); }
            [Pure] public Vec4<T> ywwz { get => new(yww, z); }
            [Pure] public Vec4<T> ywww { get => new(yww, w); }

            [Pure] public Vec4<T> zxxx { get => new(zxx, x); }
            [Pure] public Vec4<T> zxxy { get => new(zxx, y); }
            [Pure] public Vec4<T> zxxz { get => new(zxx, z); }
            [Pure] public Vec4<T> zxxw { get => new(zxx, w); }
            [Pure] public Vec4<T> zxyx { get => new(zxy, x); }
            [Pure] public Vec4<T> zxyy { get => new(zxy, y); }
            [Pure] public Vec4<T> zxyz { get => new(zxy, z); }
            public Vec4<T> zxyw { get => new(zxy, w); set { z = value.x; x = value.y; y = value.z; w = value.w; } }
            [Pure] public Vec4<T> zxzx { get => new(zxz, x); }
            [Pure] public Vec4<T> zxzy { get => new(zxz, y); }
            [Pure] public Vec4<T> zxzz { get => new(zxz, z); }
            [Pure] public Vec4<T> zxzw { get => new(zxz, w); }
            [Pure] public Vec4<T> zxwx { get => new(zxw, x); }
            public Vec4<T> zxwy { get => new(zxw, y); set { z = value.x; x = value.y; w = value.z; y = value.w; } }
            [Pure] public Vec4<T> zxwz { get => new(zxw, z); }
            [Pure] public Vec4<T> zxww { get => new(zxw, w); }
            [Pure] public Vec4<T> zyxx { get => new(zyx, x); }
            [Pure] public Vec4<T> zyxy { get => new(zyx, y); }
            [Pure] public Vec4<T> zyxz { get => new(zyx, z); }
            public Vec4<T> zyxw { get => new(zyx, w); set { z = value.x; y = value.y; x = value.z; w = value.w; } }
            [Pure] public Vec4<T> zyyx { get => new(zyy, x); }
            [Pure] public Vec4<T> zyyy { get => new(zyy, y); }
            [Pure] public Vec4<T> zyyz { get => new(zyy, z); }
            [Pure] public Vec4<T> zyyw { get => new(zyy, w); }
            [Pure] public Vec4<T> zyzx { get => new(zyz, x); }
            [Pure] public Vec4<T> zyzy { get => new(zyz, y); }
            [Pure] public Vec4<T> zyzz { get => new(zyz, z); }
            [Pure] public Vec4<T> zyzw { get => new(zyz, w); }
            public Vec4<T> zywx { get => new(zyw, x); set { z = value.x; y = value.y; w = value.z; x = value.w; } }
            [Pure] public Vec4<T> zywy { get => new(zyw, y); }
            [Pure] public Vec4<T> zywz { get => new(zyw, z); }
            [Pure] public Vec4<T> zyww { get => new(zyw, w); }
            [Pure] public Vec4<T> zzxx { get => new(zzx, x); }
            [Pure] public Vec4<T> zzxy { get => new(zzx, y); }
            [Pure] public Vec4<T> zzxz { get => new(zzx, z); }
            [Pure] public Vec4<T> zzxw { get => new(zzx, w); }
            [Pure] public Vec4<T> zzyx { get => new(zzy, x); }
            [Pure] public Vec4<T> zzyy { get => new(zzy, y); }
            [Pure] public Vec4<T> zzyz { get => new(zzy, z); }
            [Pure] public Vec4<T> zzyw { get => new(zzy, w); }
            [Pure] public Vec4<T> zzzx { get => new(zzz, x); }
            [Pure] public Vec4<T> zzzy { get => new(zzz, y); }
            [Pure] public Vec4<T> zzzz { get => new(zzz, z); }
            [Pure] public Vec4<T> zzzw { get => new(zzz, w); }
            [Pure] public Vec4<T> zzwx { get => new(zzw, x); }
            [Pure] public Vec4<T> zzwy { get => new(zzw, y); }
            [Pure] public Vec4<T> zzwz { get => new(zzw, z); }
            [Pure] public Vec4<T> zzww { get => new(zzw, w); }
            [Pure] public Vec4<T> zwxx { get => new(zwx, x); }
            public Vec4<T> zwxy { get => new(zwx, y); set { z = value.x; w = value.y; x = value.z; y = value.w; } }
            [Pure] public Vec4<T> zwxz { get => new(zwx, z); }
            [Pure] public Vec4<T> zwxw { get => new(zwx, w); }
            public Vec4<T> zwyx { get => new(zwy, x); set { z = value.x; w = value.y; y = value.z; x = value.w; } }
            [Pure] public Vec4<T> zwyy { get => new(zwy, y); }
            [Pure] public Vec4<T> zwyz { get => new(zwy, z); }
            [Pure] public Vec4<T> zwyw { get => new(zwy, w); }
            [Pure] public Vec4<T> zwzx { get => new(zwz, x); }
            [Pure] public Vec4<T> zwzy { get => new(zwz, y); }
            [Pure] public Vec4<T> zwzz { get => new(zwz, z); }
            [Pure] public Vec4<T> zwzw { get => new(zwz, w); }
            [Pure] public Vec4<T> zwwx { get => new(zww, x); }
            [Pure] public Vec4<T> zwwy { get => new(zww, y); }
            [Pure] public Vec4<T> zwwz { get => new(zww, z); }
            [Pure] public Vec4<T> zwww { get => new(zww, w); }

            [Pure] public Vec4<T> wxxx { get => new(wxx, x); }
            [Pure] public Vec4<T> wxxy { get => new(wxx, y); }
            [Pure] public Vec4<T> wxxz { get => new(wxx, z); }
            [Pure] public Vec4<T> wxxw { get => new(wxx, w); }
            [Pure] public Vec4<T> wxyx { get => new(wxy, x); }
            [Pure] public Vec4<T> wxyy { get => new(wxy, y); }
            public Vec4<T> wxyz { get => new(wxy, z); set { w = value.x; x = value.y; y = value.z; z = value.w; } }
            [Pure] public Vec4<T> wxyw { get => new(wxy, w); }
            [Pure] public Vec4<T> wxzx { get => new(wxz, x); }
            public Vec4<T> wxzy { get => new(wxz, y); set { w = value.x; x = value.y; z = value.z; y = value.w; } }
            [Pure] public Vec4<T> wxzz { get => new(wxz, z); }
            [Pure] public Vec4<T> wxzw { get => new(wxz, w); }
            [Pure] public Vec4<T> wxwx { get => new(wxw, x); }
            [Pure] public Vec4<T> wxwy { get => new(wxw, y); }
            [Pure] public Vec4<T> wxwz { get => new(wxw, z); }
            [Pure] public Vec4<T> wxww { get => new(wxw, w); }
            [Pure] public Vec4<T> wyxx { get => new(wyx, x); }
            [Pure] public Vec4<T> wyxy { get => new(wyx, y); }
            public Vec4<T> wyxz { get => new(wyx, z); set { w = value.x; y = value.y; x = value.z; z = value.w; } }
            [Pure] public Vec4<T> wyxw { get => new(wyx, w); }
            [Pure] public Vec4<T> wyyx { get => new(wyy, x); }
            [Pure] public Vec4<T> wyyy { get => new(wyy, y); }
            [Pure] public Vec4<T> wyyz { get => new(wyy, z); }
            [Pure] public Vec4<T> wyyw { get => new(wyy, w); }
            public Vec4<T> wyzx { get => new(wyz, x); set { w = value.x; y = value.y; z = value.z; x = value.w; } }
            [Pure] public Vec4<T> wyzy { get => new(wyz, y); }
            [Pure] public Vec4<T> wyzz { get => new(wyz, z); }
            [Pure] public Vec4<T> wyzw { get => new(wyz, w); }
            [Pure] public Vec4<T> wywx { get => new(wyw, x); }
            [Pure] public Vec4<T> wywy { get => new(wyw, y); }
            [Pure] public Vec4<T> wywz { get => new(wyw, z); }
            [Pure] public Vec4<T> wyww { get => new(wyw, w); }
            [Pure] public Vec4<T> wzxx { get => new(wzx, x); }
            public Vec4<T> wzxy { get => new(wzx, y); set { w = value.x; z = value.y; x = value.z; y = value.w; } }
            [Pure] public Vec4<T> wzxz { get => new(wzx, z); }
            [Pure] public Vec4<T> wzxw { get => new(wzx, w); }
            public Vec4<T> wzyx { get => new(wzy, x); set { w = value.x; z = value.y; y = value.z; x = value.w; } }
            [Pure] public Vec4<T> wzyy { get => new(wzy, y); }
            [Pure] public Vec4<T> wzyz { get => new(wzy, z); }
            [Pure] public Vec4<T> wzyw { get => new(wzy, w); }
            [Pure] public Vec4<T> wzzx { get => new(wzz, x); }
            [Pure] public Vec4<T> wzzy { get => new(wzz, y); }
            [Pure] public Vec4<T> wzzz { get => new(wzz, z); }
            [Pure] public Vec4<T> wzzw { get => new(wzz, w); }
            [Pure] public Vec4<T> wzwx { get => new(wzw, x); }
            [Pure] public Vec4<T> wzwy { get => new(wzw, y); }
            [Pure] public Vec4<T> wzwz { get => new(wzw, z); }
            [Pure] public Vec4<T> wzww { get => new(wzw, w); }
            [Pure] public Vec4<T> wwxx { get => new(wwx, x); }
            [Pure] public Vec4<T> wwxy { get => new(wwx, y); }
            [Pure] public Vec4<T> wwxz { get => new(wwx, z); }
            [Pure] public Vec4<T> wwxw { get => new(wwx, w); }
            [Pure] public Vec4<T> wwyx { get => new(wwy, x); }
            [Pure] public Vec4<T> wwyy { get => new(wwy, y); }
            [Pure] public Vec4<T> wwyz { get => new(wwy, z); }
            [Pure] public Vec4<T> wwyw { get => new(wwy, w); }
            [Pure] public Vec4<T> wwzx { get => new(wwz, x); }
            [Pure] public Vec4<T> wwzy { get => new(wwz, y); }
            [Pure] public Vec4<T> wwzz { get => new(wwz, z); }
            [Pure] public Vec4<T> wwzw { get => new(wwz, w); }
            [Pure] public Vec4<T> wwwx { get => new(www, x); }
            [Pure] public Vec4<T> wwwy { get => new(www, y); }
            [Pure] public Vec4<T> wwwz { get => new(www, z); }
            [Pure] public Vec4<T> wwww { get => new(www, w); }

            public static Vec4<T> operator +(Vec4<T> a, Vec4<T> b) => new(a.xy + b.xy, a.zw + b.zw);
            public static Vec4<T> operator -(Vec4<T> a, Vec4<T> b) => new(a.xy - b.xy, a.zw - b.zw);
            public static Vec4<T> operator *(Vec4<T> a, Vec4<T> b) => new(a.xy * b.xy, a.zw * b.zw);
            public static Vec4<T> operator *(T a, Vec4<T> b) => new(a * b.xy, a * b.zw);
            public static Vec4<T> operator *(Vec4<T> a, T b) => new(a.xy * b, a.zw * b);
            public static Vec4<T> operator /(Vec4<T> a, Vec4<T> b) => new(a.xy / b.xy, a.zw / b.zw);
            public static Vec4<T> operator /(T a, Vec4<T> b) => new(a / b.xy, a / b.zw);
            public static Vec4<T> operator /(Vec4<T> a, T b) => new(a.xy / b, a.zw / b);
            public static Vec4<T> operator %(Vec4<T> a, Vec4<T> b) => new(a.xy % b.xy, a.zw % b.zw);
            public static Vec4<T> operator %(T a, Vec4<T> b) => new(a % b.xy, a % b.zw);
            public static Vec4<T> operator %(Vec4<T> a, T b) => new(a.xy % b, a.zw % b);
        }

        public static Vec4<T> Abs<T>(Vec4<T> v) where T : struct, INumber<T> => new(Abs(v.x), Abs(v.yzw));
        public static Vec4<T> Clamp<T>(Vec4<T> v, Vec4<T> min, Vec4<T> max) where T : struct, INumber<T> => new(Clamp(v.x, min.x, max.x), Clamp(v.yzw, min.yzw, max.yzw));
        public static Vec4<T> Clamp<T>(Vec4<T> v, T min, T max) where T : struct, INumber<T> => new(Clamp(v.x, min, max), Clamp(v.yzw, min, max));
        public static Vec4<T> Max<T>(Vec4<T> v, Vec4<T> max) where T : struct, INumber<T> => new(Max(v.x, max.x), Max(v.yzw, max.yzw));
        public static Vec4<T> Min<T>(Vec4<T> v, Vec4<T> min) where T : struct, INumber<T> => new(Min(v.x, min.x), Min(v.yzw, min.yzw));
        public static Vec4<T> Max<T>(Vec4<T> v, T max) where T : struct, INumber<T> => new(Max(v.x, max), Max(v.yzw, max));
        public static Vec4<T> Min<T>(Vec4<T> v, T min) where T : struct, INumber<T> => new(Min(v.x, min), Min(v.yzw, min));
        public static Vec4<T> Frac<T>(Vec4<T> v) where T : struct, IFloatingPoint<T> => new(Frac(v.x), Frac(v.yzw));
        public static Vec4<T> Lerp<T>(Vec4<T> a, Vec4<T> b, T t) where T : struct, INumber<T> => a + (t * (b - a));
        public static Vec4<T> Sin<T>(Vec4<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Sin(v.x), Sin(v.yzw));
        public static Vec4<T> Cos<T>(Vec4<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Cos(v.x), Cos(v.yzw));
        public static Vec4<T> Tan<T>(Vec4<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Tan(v.x), Tan(v.yzw));
        public static Vec4<T> Csc<T>(Vec4<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Csc(v.x), Csc(v.yzw));
        public static Vec4<T> Sec<T>(Vec4<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Sec(v.x), Sec(v.yzw));
        public static Vec4<T> Cot<T>(Vec4<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Cot(v.x), Cot(v.yzw));
        public static Vec4<T> Asin<T>(Vec4<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Asin(v.x), Asin(v.yzw));
        public static Vec4<T> Acos<T>(Vec4<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Acos(v.x), Acos(v.yzw));
        public static Vec4<T> Atan<T>(Vec4<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => new(Atan(v.x), Atan(v.yzw));
        public static T Atan2<T>(Vec4<T> v) where T : struct, INumber<T>, ITrigonometricFunctions<T> => Atan2(v.y, v.x);
        public static Vec4<T> Sinh<T>(Vec4<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Sinh(v.x), Sinh(v.yzw));
        public static Vec4<T> Cosh<T>(Vec4<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Cosh(v.x), Cosh(v.yzw));
        public static Vec4<T> Tanh<T>(Vec4<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Tanh(v.x), Tanh(v.yzw));
        public static Vec4<T> Asinh<T>(Vec4<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Asinh(v.x), Asinh(v.yzw));
        public static Vec4<T> Acosh<T>(Vec4<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Acosh(v.x), Acosh(v.yzw));
        public static Vec4<T> Atanh<T>(Vec4<T> v) where T : struct, INumber<T>, IHyperbolicFunctions<T> => new(Atanh(v.x), Atanh(v.yzw));
        public static Vec4<T> Pow<T>(Vec4<T> v, Vec4<T> p) where T : struct, INumber<T>, IPowerFunctions<T> => new(Pow(v.x, p.x), Pow(v.yzw, p.yzw));
        public static Vec4<T> Pow<T>(Vec4<T> v, T p) where T : struct, INumber<T>, IPowerFunctions<T> => new(Pow(v.x, p), Pow(v.yzw, p));
        public static Vec4<T> Exp<T>(Vec4<T> v) where T : struct, INumber<T>, IExponentialFunctions<T> => new(Exp(v.x), Exp(v.yzw));
        public static Vec4<T> Exp10<T>(Vec4<T> v) where T : struct, INumber<T>, IExponentialFunctions<T> => new(Exp10(v.x), Exp10(v.yzw));
        public static Vec4<T> Exp2<T>(Vec4<T> v) where T : struct, INumber<T>, IExponentialFunctions<T> => new(Exp2(v.x), Exp2(v.yzw));
        public static Vec4<T> Logn<T>(Vec4<T> v) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(Logn(v.x), Logn(v.yzw));
        public static Vec4<T> Log10<T>(Vec4<T> v) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(Log10(v.x), Log10(v.yzw));
        public static Vec4<T> Log2<T>(Vec4<T> v) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(Log2(v.x), Log2(v.yzw));
        public static Vec4<T> Log<T>(Vec4<T> v, Vec4<T> b) where T : struct, INumber<T>, ILogarithmicFunctions<T> => new(Log(v.x, b.x), Log(v.yzw, b.yzw));
        public static Vec4<T> Sqrt<T>(Vec4<T> v) where T : struct, INumber<T>, IRootFunctions<T> => new(Sqrt(v.x), Sqrt(v.yzw));
        public static Vec4<T> Cbrt<T>(Vec4<T> v) where T : struct, INumber<T>, IRootFunctions<T> => new(Cbrt(v.x), Cbrt(v.yzw));
        public static Vec4<T> Nroot<T>(Vec4<T> v, Vec4<T> b) where T : struct, INumber<T>, IPowerFunctions<T> => new(Nroot(v.x, b.x), Nroot(v.yzw, b.yzw));
        public static T Magnitude<T>(Vec4<T> v) where T : struct, INumber<T>, IRootFunctions<T> => Sqrt(v.sqrMagnitude);
        public static Vec4<T> Direction<T>(Vec4<T> v) where T : struct, INumber<T>, IRootFunctions<T> => v / Magnitude(v);
        public static T Distance<T>(Vec4<T> a, Vec4<T> b) where T : struct, INumber<T>, IRootFunctions<T> => Magnitude(a - b);
        public static T SqrDist<T>(Vec4<T> a, Vec4<T> b) where T : struct, INumber<T> => (a - b).sqrMagnitude;
        public static T Dot<T>(Vec4<T> a, Vec4<T> b) where T : struct, INumber<T> => (a.x * b.x) + (a.y * b.y);
        public static Vec4<T> Reflect<T>(Vec4<T> a, Vec4<T> b) where T : struct, INumber<T> => a - ((T.One + T.One) * (Dot(a, b) * b));
    }

}
