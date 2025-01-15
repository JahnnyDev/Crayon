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
        public struct Vec4
        {
            public int x, y, z, w;
            public Vec4(int v)
            {
                x = v;
                y = v;
                z = v;
                w = v;
            }
            public Vec4(int x, int y, int z, int w)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                this.w = w;
            }
            public Vec4(Vec2 v, int z, int w)
            {
                x = v.x;
                y = v.y;
                this.z = z;
                this.w = w;
            }
            public Vec4(int x, Vec2 v, int w)
            {
                this.x = x;
                y = v.x;
                z = v.y;
                this.w = w;
            }
            public Vec4(int x, int y, Vec2 v)
            {
                this.x = x;
                this.y = y;
                z = v.x;
                w = v.y;
            }
            public Vec4(Vec2 a, Vec2 b)
            {
                x = a.x;
                y = a.y;
                z = b.x;
                w = b.y;
            }
            public Vec4(Vec3 v, int w)
            {
                x = v.x;
                y = v.y;
                z = v.z;
                this.w = w;
            }
            public Vec4(int x, Vec3 v)
            {
                this.x = x;
                y = v.x;
                z = v.y;
                w = v.z;
            }
            public Vec4(Vec4 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
                w = v.w;
            }

            public static readonly Vec4 zero = new(0);
            public static readonly Vec4 one = new(1);
            public static readonly Vec4 unitX = new(1, 0, 0, 0);
            public static readonly Vec4 unitY = new(0, 1, 0, 0);
            public static readonly Vec4 unitZ = new(0, 0, 1, 0);
            public static readonly Vec4 unitW = new(0, 0, 0, 1);
            public static readonly Vec4 unitXY = new(1, 1, 0, 0);
            public static readonly Vec4 unitXZ = new(1, 0, 1, 0);
            public static readonly Vec4 unitXW = new(1, 0, 0, 1);
            public static readonly Vec4 unitYZ = new(0, 1, 1, 0);
            public static readonly Vec4 unitYW = new(0, 1, 0, 1);
            public static readonly Vec4 unitZW = new(0, 0, 1, 1);

            [Pure] public int sqrMagnitude { get => (x * x) + (y * y) + (z * z) * (w * w); }
            [Pure] public Vec4 mirrorX { get => new(-x, yzw); }
            [Pure] public Vec4 mirrorY { get => new(x, -y, zw); }
            [Pure] public Vec4 mirrorZ { get => new(xy, -z, w); }
            [Pure] public Vec4 mirrorW { get => new(xyz, -w); }
            [Pure] public Vec4 mirrorXY { get => new(-xy, zw); }
            [Pure] public Vec4 mirrorXZ { get => new(-x, y, -z, w); }
            [Pure] public Vec4 mirrorXW { get => new(-x, yz, -w); }
            [Pure] public Vec4 mirrorYZ { get => new(x, -yz, w); }
            [Pure] public Vec4 mirrorYW { get => new(x, -y, z, -w); }
            [Pure] public Vec4 mirrorZW { get => new(xy, -zw); }
            [Pure] public Vec4 flattenX { get => new(0, yzw); }
            [Pure] public Vec4 flattenY { get => new(x, 0, zw); }
            [Pure] public Vec4 FlattenZ { get => new(xy, 0, w); }
            [Pure] public Vec4 flattenXY { get => new(0, 0, zw); }
            [Pure] public Vec4 flattenXZ { get => new(0, y, 0, w); }
            [Pure] public Vec4 flattenXW { get => new(0, yz, 0); }
            [Pure] public Vec4 FlattenYZ { get => new(x, 0, 0, w); }
            [Pure] public Vec4 FlattenYW { get => new(x, 0, z, 0); }
            [Pure] public Vec4 FlattenZW { get => new(xy, 0, 0); }
            [Pure] public Vec2 xx { get => new Vec2(x); }
            public Vec2 xy { get => new(x, y); set { x = value.x; y = value.y; } }
            public Vec2 xz { get => new(x, z); set { x = value.x; z = value.y; } }
            public Vec2 xw { get => new(x, w); set { x = value.x; w = value.y; } }
            public Vec2 yx { get => new(y, x); set { y = value.x; x = value.y; } }
            [Pure] public Vec2 yy { get => new(y); }
            public Vec2 yz { get => new(y, z); set { y = value.x; z = value.y; } }
            public Vec2 yw { get => new(y, w); set { y = value.x; w = value.y; } }
            public Vec2 zx { get => new(z, x); set { z = value.x; x = value.y; } }
            public Vec2 zy { get => new(z, y); set { z = value.x; y = value.y; } }
            [Pure] public Vec2 zz { get => new(z); }
            public Vec2 zw { get => new(z, w); set { z = value.x; w = value.y; } }
            public Vec2 wx { get => new(w, x); set { w = value.x; x = value.y; } }
            public Vec2 wy { get => new(w, y); set { w = value.x; y = value.y; } }
            public Vec2 wz { get => new(w, z); set { w = value.x; z = value.y; } }
            [Pure] public Vec2 ww { get => new(w); }

            [Pure] public Vec3 xxx { get => new(x); }
            [Pure] public Vec3 xxy { get => new(xx, y); }
            [Pure] public Vec3 xxz { get => new(xx, z); }
            [Pure] public Vec3 xxw { get => new(xx, w); }
            [Pure] public Vec3 xyx { get => new(xy, x); }
            [Pure] public Vec3 xyy { get => new(xy, y); }
            public Vec3 xyz { get => new(xy, z); set { x = value.x; y = value.y; z = value.z; } }
            public Vec3 xyw { get => new(xy, w); set { x = value.x; y = value.y; w = value.z; } }
            [Pure] public Vec3 xzx { get => new(xz, x); }
            public Vec3 xzy { get => new(xz, y); set { x = value.x; z = value.y; y = value.z; } }
            [Pure] public Vec3 xzz { get => new(xz, z); }
            public Vec3 xzw { get => new(xz, w); set { x = value.x; z = value.y; w = value.z; } }
            [Pure] public Vec3 xwx { get => new(xw, x); }
            public Vec3 xwy { get => new(xw, y); set { x = value.x; w = value.y; y = value.z; } }
            public Vec3 xwz { get => new(xw, z); set { x = value.x; w = value.y; z = value.z; } }
            [Pure] public Vec3 xww { get => new(xw, w); }
            [Pure] public Vec3 yxx { get => new(yx, x); }
            [Pure] public Vec3 yxy { get => new(yx, y); }
            public Vec3 yxz { get => new(yx, z); set { y = value.x; x = value.y; z = value.z; } }
            public Vec3 yxw { get => new(yx, w); set { x = value.x; y = value.y; w = value.z; } }
            [Pure] public Vec3 yyx { get => new(yy, x); }
            [Pure] public Vec3 yyy { get => new(y); }
            [Pure] public Vec3 yyz { get => new(yy, z); }
            [Pure] public Vec3 yyw { get => new(yy, w); }
            public Vec3 yzx { get => new(yz, x); set { y = value.x; z = value.y; x = value.z; } }
            [Pure] public Vec3 yzy { get => new(yz, y); }
            [Pure] public Vec3 yzz { get => new(yz, z); }
            public Vec3 yzw { get => new(yz, w); set { y = value.x; z = value.y; w = value.z; } }
            public Vec3 ywx { get => new(yw, x); set { y = value.x; w = value.y; x = value.z; } }
            [Pure] public Vec3 ywy { get => new(yw, y); }
            public Vec3 ywz { get => new(yw, z); set { y = value.x; w = value.y; z = value.z; } }
            [Pure] public Vec3 yww { get => new(yw, w); }
            [Pure] public Vec3 zxx { get => new(zx, x); }
            public Vec3 zxy { get => new(zx, y); set { z = value.x; x = value.y; y = value.z; } }
            [Pure] public Vec3 zxz { get => new(zx, z); }
            public Vec3 zxw { get => new(zx, w); set { z = value.x; x = value.y; w = value.z; } }
            public Vec3 zyx { get => new(zy, x); set { z = value.x; y = value.y; x = value.z; } }
            [Pure] public Vec3 zyy { get => new(zy, y); }
            [Pure] public Vec3 zyz { get => new(zy, z); }
            public Vec3 zyw { get => new(zy, w); set { z = value.x; y = value.y; w = value.z; } }
            [Pure] public Vec3 zzx { get => new(zz, x); }
            [Pure] public Vec3 zzy { get => new(zz, y); }
            [Pure] public Vec3 zzz { get => new(z); }
            [Pure] public Vec3 zzw { get => new(zz, w); }
            public Vec3 zwx { get => new(zw, x); set { z = value.x; w = value.y; x = value.z; } }
            public Vec3 zwy { get => new(zw, y); set { z = value.x; w = value.y; y = value.z; } }
            [Pure] public Vec3 zwz { get => new(zw, z); }
            [Pure] public Vec3 zww { get => new(zw, w); }
            [Pure] public Vec3 wxx { get => new(wx, x); }
            public Vec3 wxy { get => new(wx, y); set { w = value.x; x = value.y; y = value.z; } }
            public Vec3 wxz { get => new(wx, z); set { w = value.x; x = value.y; z = value.z; } }
            [Pure] public Vec3 wxw { get => new(wx, w); }
            public Vec3 wyx { get => new(wy, x); set { w = value.x; y = value.y; x = value.z; } }
            [Pure] public Vec3 wyy { get => new(wy, y); }
            public Vec3 wyz { get => new(wy, z); set { w = value.x; y = value.y; z = value.z; } }
            [Pure] public Vec3 wyw { get => new(wy, w); }
            public Vec3 wzx { get => new(wz, x); set { w = value.x; z = value.y; x = value.z; } }
            public Vec3 wzy { get => new(wz, y); set { w = value.x; z = value.y; y = value.z; } }
            [Pure] public Vec3 wzz { get => new(wz, z); }
            [Pure] public Vec3 wzw { get => new(wz, w); }
            [Pure] public Vec3 wwx { get => new(ww, x); }
            [Pure] public Vec3 wwy { get => new(ww, y); }
            [Pure] public Vec3 wwz { get => new(ww, z); }
            [Pure] public Vec3 www { get => new(w); }

            [Pure] public Vec4 xxxx { get => new(x); }
            [Pure] public Vec4 xxxy { get => new(xxx, y); }
            [Pure] public Vec4 xxxz { get => new(xxx, z); }
            [Pure] public Vec4 xxxw { get => new(xxx, w); }
            [Pure] public Vec4 xxyx { get => new(xxy, x); }
            [Pure] public Vec4 xxyy { get => new(xxy, y); }
            [Pure] public Vec4 xxyz { get => new(xxy, z); }
            [Pure] public Vec4 xxyw { get => new(xxy, w); }
            [Pure] public Vec4 xxzx { get => new(xxz, x); }
            [Pure] public Vec4 xxzy { get => new(xxz, y); }
            [Pure] public Vec4 xxzz { get => new(xxz, z); }
            [Pure] public Vec4 xxzw { get => new(xxz, w); }
            [Pure] public Vec4 xxwx { get => new(xxw, x); }
            [Pure] public Vec4 xxwy { get => new(xxw, y); }
            [Pure] public Vec4 xxwz { get => new(xxw, z); }
            [Pure] public Vec4 xxww { get => new(xxw, w); }
            [Pure] public Vec4 xyxx { get => new(xyx, x); }
            [Pure] public Vec4 xyxy { get => new(xyx, y); }
            [Pure] public Vec4 xyxz { get => new(xyx, z); }
            [Pure] public Vec4 xyxw { get => new(xyx, w); }
            [Pure] public Vec4 xyyx { get => new(xyy, x); }
            [Pure] public Vec4 xyyy { get => new(xyy, y); }
            [Pure] public Vec4 xyyz { get => new(xyy, z); }
            [Pure] public Vec4 xyyw { get => new(xyy, w); }
            [Pure] public Vec4 xyzx { get => new(xyz, x); }
            [Pure] public Vec4 xyzy { get => new(xyz, y); }
            [Pure] public Vec4 xyzz { get => new(xyz, z); }
            public Vec4 xyzw { get => new(xyz, w); set { x = value.x; y = value.y; z = value.z; w = value.w; } }
            [Pure] public Vec4 xywx { get => new(xyw, x); }
            [Pure] public Vec4 xywy { get => new(xyw, y); }
            public Vec4 xywz { get => new(xyw, z); set { x = value.x; y = value.y; w = value.z; z = value.w; } }
            [Pure] public Vec4 xyww { get => new(xyw, w); }
            [Pure] public Vec4 xzxx { get => new(xzx, x); }
            [Pure] public Vec4 xzxy { get => new(xzx, y); }
            [Pure] public Vec4 xzxz { get => new(xzx, z); }
            [Pure] public Vec4 xzxw { get => new(xzx, w); }
            [Pure] public Vec4 xzyx { get => new(xzy, x); }
            [Pure] public Vec4 xzyy { get => new(xzy, y); }
            [Pure] public Vec4 xzyz { get => new(xzy, z); }
            [Pure] public Vec4 xzyw { get => new(xzy, w); set { x = value.x; z = value.y; y = value.z; w = value.w; } }
            [Pure] public Vec4 xzzx { get => new(xzz, x); }
            [Pure] public Vec4 xzzy { get => new(xzz, y); }
            [Pure] public Vec4 xzzz { get => new(xzz, z); }
            [Pure] public Vec4 xzzw { get => new(xzz, w); }
            [Pure] public Vec4 xzwx { get => new(xzw, x); }
            [Pure] public Vec4 xzwy { get => new(xzw, y); set { x = value.x; z = value.y; w = value.z; y = value.w; } }
            [Pure] public Vec4 xzwz { get => new(xzw, z); }
            [Pure] public Vec4 xzww { get => new(xzw, w); }
            [Pure] public Vec4 xwxx { get => new(xwx, x); }
            [Pure] public Vec4 xwxy { get => new(xwx, y); }
            [Pure] public Vec4 xwxz { get => new(xwx, z); }
            [Pure] public Vec4 xwxw { get => new(xwx, w); }
            [Pure] public Vec4 xwyx { get => new(xwy, x); }
            [Pure] public Vec4 xwyy { get => new(xwy, y); }
            [Pure] public Vec4 xwyz { get => new(xwy, z); set { x = value.x; w = value.y; y = value.z; z = value.w; } }
            [Pure] public Vec4 xwyw { get => new(xwy, w); }
            [Pure] public Vec4 xwzx { get => new(xwz, x); }
            [Pure] public Vec4 xwzy { get => new(xwz, y); set { x = value.x; w = value.y; z = value.z; y = value.w; } }
            [Pure] public Vec4 xwzz { get => new(xwz, z); }
            [Pure] public Vec4 xwzw { get => new(xwz, w); }
            [Pure] public Vec4 xwwx { get => new(xww, x); }
            [Pure] public Vec4 xwwy { get => new(xww, y); }
            [Pure] public Vec4 xwwz { get => new(xww, z); }
            [Pure] public Vec4 xwww { get => new(xww, w); }

            [Pure] public Vec4 yxxx { get => new(yxx, x); }
            [Pure] public Vec4 yxxy { get => new(yxx, y); }
            [Pure] public Vec4 yxxz { get => new(yxx, z); }
            [Pure] public Vec4 yxxw { get => new(yxx, w); }
            [Pure] public Vec4 yxyx { get => new(yxy, x); }
            [Pure] public Vec4 yxyy { get => new(yxy, y); }
            [Pure] public Vec4 yxyz { get => new(yxy, z); }
            [Pure] public Vec4 yxyw { get => new(yxy, w); }
            [Pure] public Vec4 yxzx { get => new(yxz, x); }
            [Pure] public Vec4 yxzy { get => new(yxz, y); }
            [Pure] public Vec4 yxzz { get => new(yxz, z); }
            [Pure] public Vec4 yxzw { get => new(yxz, w); set { y = value.x; x = value.y; z = value.z; w = value.w; } }
            [Pure] public Vec4 yxwx { get => new(yxw, x); }
            [Pure] public Vec4 yxwy { get => new(yxw, y); }
            [Pure] public Vec4 yxwz { get => new(yxw, z); set { y = value.x; x = value.y; w = value.z; z = value.w; } }
            [Pure] public Vec4 yxww { get => new(yxw, w); }
            [Pure] public Vec4 yyxx { get => new(yyx, x); }
            [Pure] public Vec4 yyxy { get => new(yyx, y); }
            [Pure] public Vec4 yyxz { get => new(yyx, z); }
            [Pure] public Vec4 yyxw { get => new(yyx, w); }
            [Pure] public Vec4 yyyx { get => new(yyy, x); }
            [Pure] public Vec4 yyyy { get => new(yyy, y); }
            [Pure] public Vec4 yyyz { get => new(yyy, z); }
            [Pure] public Vec4 yyyw { get => new(yyy, w); }
            [Pure] public Vec4 yyzx { get => new(yyz, x); }
            [Pure] public Vec4 yyzy { get => new(yyz, y); }
            [Pure] public Vec4 yyzz { get => new(yyz, z); }
            [Pure] public Vec4 yyzw { get => new(yyz, w); }
            [Pure] public Vec4 yywx { get => new(yyw, x); }
            [Pure] public Vec4 yywy { get => new(yyw, y); }
            [Pure] public Vec4 yywz { get => new(yyw, z); }
            [Pure] public Vec4 yyww { get => new(yyw, w); }
            [Pure] public Vec4 yzxx { get => new(yzx, x); }
            [Pure] public Vec4 yzxy { get => new(yzx, y); }
            [Pure] public Vec4 yzxz { get => new(yzx, z); }
            public Vec4 yzxw { get => new(yzx, w); set { y = value.x; z = value.y; x = value.z; w = value.w; } }
            [Pure] public Vec4 yzyx { get => new(yzy, x); }
            [Pure] public Vec4 yzyy { get => new(yzy, y); }
            [Pure] public Vec4 yzyz { get => new(yzy, z); }
            [Pure] public Vec4 yzyw { get => new(yzy, w); }
            [Pure] public Vec4 yzzx { get => new(yzz, x); }
            [Pure] public Vec4 yzzy { get => new(yzz, y); }
            [Pure] public Vec4 yzzz { get => new(yzz, z); }
            [Pure] public Vec4 yzzw { get => new(yzz, w); }
            public Vec4 yzwx { get => new(yzw, x); set { y = value.x; z = value.y; w = value.z; x = value.w; } }
            [Pure] public Vec4 yzwy { get => new(yzw, y); }
            [Pure] public Vec4 yzwz { get => new(yzw, z); }
            [Pure] public Vec4 yzww { get => new(yzw, w); }
            [Pure] public Vec4 ywxx { get => new(ywx, x); }
            [Pure] public Vec4 ywxy { get => new(ywx, y); }
            public Vec4 ywxz { get => new(ywx, z); set { y = value.x; w = value.y; x = value.z; z = value.w; } }
            [Pure] public Vec4 ywxw { get => new(ywx, w); }
            [Pure] public Vec4 ywyx { get => new(ywy, x); }
            [Pure] public Vec4 ywyy { get => new(ywy, y); }
            [Pure] public Vec4 ywyz { get => new(ywy, z); }
            [Pure] public Vec4 ywyw { get => new(ywy, w); }
            public Vec4 ywzx { get => new(ywz, x); set { y = value.x; w = value.y; z = value.z; x = value.w; } }
            [Pure] public Vec4 ywzy { get => new(ywz, y); }
            [Pure] public Vec4 ywzz { get => new(ywz, z); }
            [Pure] public Vec4 ywzw { get => new(ywz, w); }
            [Pure] public Vec4 ywwx { get => new(yww, x); }
            [Pure] public Vec4 ywwy { get => new(yww, y); }
            [Pure] public Vec4 ywwz { get => new(yww, z); }
            [Pure] public Vec4 ywww { get => new(yww, w); }

            [Pure] public Vec4 zxxx { get => new(zxx, x); }
            [Pure] public Vec4 zxxy { get => new(zxx, y); }
            [Pure] public Vec4 zxxz { get => new(zxx, z); }
            [Pure] public Vec4 zxxw { get => new(zxx, w); }
            [Pure] public Vec4 zxyx { get => new(zxy, x); }
            [Pure] public Vec4 zxyy { get => new(zxy, y); }
            [Pure] public Vec4 zxyz { get => new(zxy, z); }
            public Vec4 zxyw { get => new(zxy, w); set { z = value.x; x = value.y; y = value.z; w = value.w; } }
            [Pure] public Vec4 zxzx { get => new(zxz, x); }
            [Pure] public Vec4 zxzy { get => new(zxz, y); }
            [Pure] public Vec4 zxzz { get => new(zxz, z); }
            [Pure] public Vec4 zxzw { get => new(zxz, w); }
            [Pure] public Vec4 zxwx { get => new(zxw, x); }
            public Vec4 zxwy { get => new(zxw, y); set { z = value.x; x = value.y; w = value.z; y = value.w; } }
            [Pure] public Vec4 zxwz { get => new(zxw, z); }
            [Pure] public Vec4 zxww { get => new(zxw, w); }
            [Pure] public Vec4 zyxx { get => new(zyx, x); }
            [Pure] public Vec4 zyxy { get => new(zyx, y); }
            [Pure] public Vec4 zyxz { get => new(zyx, z); }
            public Vec4 zyxw { get => new(zyx, w); set { z = value.x; y = value.y; x = value.z; w = value.w; } }
            [Pure] public Vec4 zyyx { get => new(zyy, x); }
            [Pure] public Vec4 zyyy { get => new(zyy, y); }
            [Pure] public Vec4 zyyz { get => new(zyy, z); }
            [Pure] public Vec4 zyyw { get => new(zyy, w); }
            [Pure] public Vec4 zyzx { get => new(zyz, x); }
            [Pure] public Vec4 zyzy { get => new(zyz, y); }
            [Pure] public Vec4 zyzz { get => new(zyz, z); }
            [Pure] public Vec4 zyzw { get => new(zyz, w); }
            public Vec4 zywx { get => new(zyw, x); set { z = value.x; y = value.y; w = value.z; x = value.w; } }
            [Pure] public Vec4 zywy { get => new(zyw, y); }
            [Pure] public Vec4 zywz { get => new(zyw, z); }
            [Pure] public Vec4 zyww { get => new(zyw, w); }
            [Pure] public Vec4 zzxx { get => new(zzx, x); }
            [Pure] public Vec4 zzxy { get => new(zzx, y); }
            [Pure] public Vec4 zzxz { get => new(zzx, z); }
            [Pure] public Vec4 zzxw { get => new(zzx, w); }
            [Pure] public Vec4 zzyx { get => new(zzy, x); }
            [Pure] public Vec4 zzyy { get => new(zzy, y); }
            [Pure] public Vec4 zzyz { get => new(zzy, z); }
            [Pure] public Vec4 zzyw { get => new(zzy, w); }
            [Pure] public Vec4 zzzx { get => new(zzz, x); }
            [Pure] public Vec4 zzzy { get => new(zzz, y); }
            [Pure] public Vec4 zzzz { get => new(zzz, z); }
            [Pure] public Vec4 zzzw { get => new(zzz, w); }
            [Pure] public Vec4 zzwx { get => new(zzw, x); }
            [Pure] public Vec4 zzwy { get => new(zzw, y); }
            [Pure] public Vec4 zzwz { get => new(zzw, z); }
            [Pure] public Vec4 zzww { get => new(zzw, w); }
            [Pure] public Vec4 zwxx { get => new(zwx, x); }
            public Vec4 zwxy { get => new(zwx, y); set { z = value.x; w = value.y; x = value.z; y = value.w; } }
            [Pure] public Vec4 zwxz { get => new(zwx, z); }
            [Pure] public Vec4 zwxw { get => new(zwx, w); }
            public Vec4 zwyx { get => new(zwy, x); set { z = value.x; w = value.y; y = value.z; x = value.w; } }
            [Pure] public Vec4 zwyy { get => new(zwy, y); }
            [Pure] public Vec4 zwyz { get => new(zwy, z); }
            [Pure] public Vec4 zwyw { get => new(zwy, w); }
            [Pure] public Vec4 zwzx { get => new(zwz, x); }
            [Pure] public Vec4 zwzy { get => new(zwz, y); }
            [Pure] public Vec4 zwzz { get => new(zwz, z); }
            [Pure] public Vec4 zwzw { get => new(zwz, w); }
            [Pure] public Vec4 zwwx { get => new(zww, x); }
            [Pure] public Vec4 zwwy { get => new(zww, y); }
            [Pure] public Vec4 zwwz { get => new(zww, z); }
            [Pure] public Vec4 zwww { get => new(zww, w); }

            [Pure] public Vec4 wxxx { get => new(wxx, x); }
            [Pure] public Vec4 wxxy { get => new(wxx, y); }
            [Pure] public Vec4 wxxz { get => new(wxx, z); }
            [Pure] public Vec4 wxxw { get => new(wxx, w); }
            [Pure] public Vec4 wxyx { get => new(wxy, x); }
            [Pure] public Vec4 wxyy { get => new(wxy, y); }
            public Vec4 wxyz { get => new(wxy, z); set { w = value.x; x = value.y; y = value.z; z = value.w; } }
            [Pure] public Vec4 wxyw { get => new(wxy, w); }
            [Pure] public Vec4 wxzx { get => new(wxz, x); }
            public Vec4 wxzy { get => new(wxz, y); set { w = value.x; x = value.y; z = value.z; y = value.w; } }
            [Pure] public Vec4 wxzz { get => new(wxz, z); }
            [Pure] public Vec4 wxzw { get => new(wxz, w); }
            [Pure] public Vec4 wxwx { get => new(wxw, x); }
            [Pure] public Vec4 wxwy { get => new(wxw, y); }
            [Pure] public Vec4 wxwz { get => new(wxw, z); }
            [Pure] public Vec4 wxww { get => new(wxw, w); }
            [Pure] public Vec4 wyxx { get => new(wyx, x); }
            [Pure] public Vec4 wyxy { get => new(wyx, y); }
            public Vec4 wyxz { get => new(wyx, z); set { w = value.x; y = value.y; x = value.z; z = value.w; } }
            [Pure] public Vec4 wyxw { get => new(wyx, w); }
            [Pure] public Vec4 wyyx { get => new(wyy, x); }
            [Pure] public Vec4 wyyy { get => new(wyy, y); }
            [Pure] public Vec4 wyyz { get => new(wyy, z); }
            [Pure] public Vec4 wyyw { get => new(wyy, w); }
            public Vec4 wyzx { get => new(wyz, x); set { w = value.x; y = value.y; z = value.z; x = value.w; } }
            [Pure] public Vec4 wyzy { get => new(wyz, y); }
            [Pure] public Vec4 wyzz { get => new(wyz, z); }
            [Pure] public Vec4 wyzw { get => new(wyz, w); }
            [Pure] public Vec4 wywx { get => new(wyw, x); }
            [Pure] public Vec4 wywy { get => new(wyw, y); }
            [Pure] public Vec4 wywz { get => new(wyw, z); }
            [Pure] public Vec4 wyww { get => new(wyw, w); }
            [Pure] public Vec4 wzxx { get => new(wzx, x); }
            public Vec4 wzxy { get => new(wzx, y); set { w = value.x; z = value.y; x = value.z; y = value.w; } }
            [Pure] public Vec4 wzxz { get => new(wzx, z); }
            [Pure] public Vec4 wzxw { get => new(wzx, w); }
            public Vec4 wzyx { get => new(wzy, x); set { w = value.x; z = value.y; y = value.z; x = value.w; } }
            [Pure] public Vec4 wzyy { get => new(wzy, y); }
            [Pure] public Vec4 wzyz { get => new(wzy, z); }
            [Pure] public Vec4 wzyw { get => new(wzy, w); }
            [Pure] public Vec4 wzzx { get => new(wzz, x); }
            [Pure] public Vec4 wzzy { get => new(wzz, y); }
            [Pure] public Vec4 wzzz { get => new(wzz, z); }
            [Pure] public Vec4 wzzw { get => new(wzz, w); }
            [Pure] public Vec4 wzwx { get => new(wzw, x); }
            [Pure] public Vec4 wzwy { get => new(wzw, y); }
            [Pure] public Vec4 wzwz { get => new(wzw, z); }
            [Pure] public Vec4 wzww { get => new(wzw, w); }
            [Pure] public Vec4 wwxx { get => new(wwx, x); }
            [Pure] public Vec4 wwxy { get => new(wwx, y); }
            [Pure] public Vec4 wwxz { get => new(wwx, z); }
            [Pure] public Vec4 wwxw { get => new(wwx, w); }
            [Pure] public Vec4 wwyx { get => new(wwy, x); }
            [Pure] public Vec4 wwyy { get => new(wwy, y); }
            [Pure] public Vec4 wwyz { get => new(wwy, z); }
            [Pure] public Vec4 wwyw { get => new(wwy, w); }
            [Pure] public Vec4 wwzx { get => new(wwz, x); }
            [Pure] public Vec4 wwzy { get => new(wwz, y); }
            [Pure] public Vec4 wwzz { get => new(wwz, z); }
            [Pure] public Vec4 wwzw { get => new(wwz, w); }
            [Pure] public Vec4 wwwx { get => new(www, x); }
            [Pure] public Vec4 wwwy { get => new(www, y); }
            [Pure] public Vec4 wwwz { get => new(www, z); }
            [Pure] public Vec4 wwww { get => new(www, w); }

            public static Vec4 operator +(Vec4 a, Vec4 b) => new(a.xy + b.xy, a.zw + b.zw);
            public static Vec4 operator -(Vec4 a, Vec4 b) => new(a.xy - b.xy, a.zw - b.zw);
            public static Vec4 operator *(Vec4 a, Vec4 b) => new(a.xy * b.xy, a.zw * b.zw);
            public static Vec4 operator *(int a, Vec4 b) => new(a * b.xy, a * b.zw);
            public static Vec4 operator *(Vec4 a, int b) => new(a.xy * b, a.zw * b);
            public static Vec4 operator /(Vec4 a, Vec4 b) => new(a.xy / b.xy, a.zw / b.zw);
            public static Vec4 operator /(int a, Vec4 b) => new(a / b.xy, a / b.zw);
            public static Vec4 operator /(Vec4 a, int b) => new(a.xy / b, a.zw / b);
            public static Vec4 operator %(Vec4 a, Vec4 b) => new(a.xy % b.xy, a.zw % b.zw);
            public static Vec4 operator %(int a, Vec4 b) => new(a % b.xy, a % b.zw);
            public static Vec4 operator %(Vec4 a, int b) => new(a.xy % b, a.zw % b);
            public static Vec4 operator ^(Vec4 a, Vec4 b) => new(a.xy ^ b.xy, a.zw ^ b.zw);
            public static Vec4 operator ^(int a, Vec4 b) => new(a ^ b.xy, a ^ b.zw);
            public static Vec4 operator ^(Vec4 a, int b) => new(a.xy ^ b, a.zw ^ b);
            public static Vec4 operator &(Vec4 a, Vec4 b) => new(a.xy & b.xy, a.zw & b.zw);
            public static Vec4 operator &(int a, Vec4 b) => new(a & b.xy, a & b.zw);
            public static Vec4 operator &(Vec4 a, int b) => new(a.xy & b, a.zw & b);
            public static Vec4 operator |(Vec4 a, Vec4 b) => new(a.xy | b.xy, a.zw | b.zw);
            public static Vec4 operator |(int a, Vec4 b) => new(a | b.xy, a | b.zw);
            public static Vec4 operator |(Vec4 a, int b) => new(a.xy | b, a.zw | b);
            public static Vec4 operator >>(Vec4 a, Vec4 b) => new(a.xy >> b.x, a.zw >> b.zw);
            public static Vec4 operator >>(Vec4 a, int b) => new(a.xy >> b, a.zw >> b);
            public static Vec4 operator <<(Vec4 a, Vec4 b) => new(a.xy << b.x, a.zw << b.zw);
            public static Vec4 operator <<(Vec4 a, int b) => new(a.xy << b, a.zw << b);
            public static bool operator ==(Vec4 a, Vec4 b) => a.xy == b.xy && a.zw == b.zw;
            public static bool operator !=(Vec4 a, Vec4 b) => a.xy != b.xy || a.zw != b.zw;
        }

        public static Vec4 Abs(Vec4 v) => new(Abs(v.x), Abs(v.yzw));
        public static Vec4 Clamp(Vec4 v, int min, int max) => new(Clamp(v.x, min, max), Clamp(v.yzw, min, max));
        public static Vec4 Clamp(Vec4 v, Vec4 min, Vec4 max) => new(Clamp(v.x, min.x, max.x), Clamp(v.yzw, min.yzw, max.yzw));
        public static Vec4 Max(Vec4 v, int max) => new(Max(v.x, max), Max(v.yzw, max));
        public static Vec4 Max(Vec4 v, Vec4 max) => new(Max(v.x, max.x), Max(v.yzw, max.yzw));
        public static Vec4 Min(Vec4 v, int min) => new(Min(v.x, min), Min(v.yzw, min));
        public static Vec4 Min(Vec4 v, Vec4 min) => new(Min(v.x, min.x), Min(v.yzw, min.xzw));
        public static Vec4 Sign(Vec4 v) => new(Sign(v.x), Sign(v.yzw));
        public static Vec4 Log2(Vec4 v) => new(Log2(v.x), Log2(v.yzw));
        public static int Dot(Vec4 a, Vec4 b) => (a.x * b.x) + (a.y * b.y) + (a.z * b.z) + (a.w * b.w);
        public static int SqrDist(Vec4 a, Vec4 b) => (a - b).sqrMagnitude;
        public static Vec4 Reflect(Vec4 a, Vec4 b) => a - (2 * (Dot(a, b) * b));
    }
}
