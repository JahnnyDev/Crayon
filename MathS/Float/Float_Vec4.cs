using System.Diagnostics.Contracts;
using System.Numerics;
using System.Runtime.InteropServices;

namespace MathS
{
    public static partial class Float
    {
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct Vec4
        {
            public Vector4 value;
            public static implicit operator Vector4(Vec4 v) => v.value;
            public static implicit operator Vec4(Vector4 v) => new(v);

            public Vec4(Vector4 val) { value = val; }
            public Vec4(float v)
            {
                value = new(v);
            }
            public Vec4(float x, float y, float z, float w)
            {
                value = new(x,y,z,w);
            }
            public Vec4(Vec2 v, float z, float w)
            {
                value = new(v.x, v.y, z,w);
            }
            public Vec4(float x, Vec2 v, float w)
            {
                value = new(x, v.x,v.y, w);
            }
            public Vec4(float x, float y, Vec2 v)
            {
                value = new(x,y, v.x,v.y);
            }
            public Vec4(Vec2 a, Vec2 b)
            {
                value = new(a.x,a.y,b.x,b.y);
            }
            public Vec4(Vec3 v, float w)
            {
                value = new(v.x,v.y,v.z,w);
            }
            public Vec4(float x, Vec3 v)
            {
                value = new(x, v.x, v.y, v.z);
            }
            public Vec4(Vec4 v)
            {
                value = v.value;
            }
            public static readonly Vec4 zero = new(0f);
            public static readonly Vec4 one = new(1f);
            public static readonly Vec4 unitX = new(1f, 0f, 0f, 0f);
            public static readonly Vec4 unitY = new(0f, 1f, 0f, 0);
            public static readonly Vec4 unitZ = new(0f, 0f, 1f, 0f);
            public static readonly Vec4 unitW = new(0f, 0f, 0f, 1f);
            public static readonly Vec4 unitXY = new(1, 1, 0, 0);
            public static readonly Vec4 unitXZ = new(1, 0, 1, 0);
            public static readonly Vec4 unitXW = new(1, 0, 0, 1);
            public static readonly Vec4 unitYZ = new(0, 1, 1, 0);
            public static readonly Vec4 unitYW = new(0, 1, 0, 1);
            public static readonly Vec4 unitZW = new(0, 0, 1, 1);

            [Pure] public float sqrMagnitude { get => (x * x) + (y * y) + (z * z) * (w * w); }
            [Pure] public float magnitude { get => Sqrt(sqrMagnitude); }
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
            [Pure] public Vec4 flattenX { get => new(0f, yzw); }
            [Pure] public Vec4 flattenY { get => new(x, 0f, 0f, 0f); }
            [Pure] public Vec4 FlattenZ { get => new(xy, 0f, w); }
            [Pure] public Vec4 flattenXY { get => new(0, 0, zw); }
            [Pure] public Vec4 flattenXZ { get => new(0, y, 0, w); }
            [Pure] public Vec4 flattenXW { get => new(0, yz, 0); }
            [Pure] public Vec4 FlattenYZ { get => new(x, 0f, 0f, w); }
            [Pure] public Vec4 FlattenYW { get => new(x, 0f, z, 0f); }
            [Pure] public Vec4 FlattenZW { get => new(xy, 0f, 0f); }
            public float y { get => value.Y; set => this.value.Y = value; }
            [Pure] public Vec4 direction { get => xyzw * InvSqrt(sqrMagnitude); }

            
            public float x { get => value.X; set => this.value.X = value; }
            public float z { get => value.Z; set => this.value.Z = value; }
            public float w { get => value.W; set => this.value.W = value; }

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

            public static Vec4 operator +(Vec4 a, Vec4 b) => a.value + b.value;
            public static Vec4 operator -(Vec4 a, Vec4 b) => a.value - b.value;
            public static Vec4 operator *(Vec4 a, Vec4 b) => a.value * b.value;
            public static Vec4 operator *(float a, Vec4 b) => a * b.value;
            public static Vec4 operator *(Vec4 a, float b) => a.value * b;
            public static Vec4 operator /(Vec4 a, Vec4 b) => a.value / b.value;
            public static Vec4 operator /(float a, Vec4 b) => new(a / b.xy, a / b.zw);
            public static Vec4 operator /(Vec4 a, float b) => a.value / b;
            public static Vec4 operator %(Vec4 a, Vec4 b) => new(a.xy % b.xy, a.zw % b.zw);
            public static Vec4 operator %(float a, Vec4 b) => new(a % b.xy, a % b.zw);
            public static Vec4 operator %(Vec4 a, float b) => new(a.xy % b, a.zw % b);
            public static bool operator ==(Vec4 a, Vec4 b) => a.value == b.value;
            public static bool operator !=(Vec4 a, Vec4 b) => a.value != b.value;
            public static implicit operator string(Vec4 v) => (v.x, v.y, v.z,v.w).ToString();

        }
        public static Vec4 Clamp(Vec4 v, Vec4 min, Vec4 max) => new(Clamp(v.xy, min.xy, max.xy), Clamp(v.zw, min.zw, max.zw));
        public static Vec4 Clamp(Vec4 v, float min, float max) => new(Clamp(v.xy, min, max), Clamp(v.zw, min, max));
        public static Vec4 Max(Vec4 v, Vec4 max) => new(Max(v.xy, max.xy), Max(v.zw, max.zw));
        public static Vec4 Min(Vec4 v, Vec4 min) => new(Min(v.xy, min.xy), Min(v.zw, min.zw));
        public static Vec4 Max(Vec4 v, float max) => new(Max(v.xy, max), Max(v.zw, max));
        public static Vec4 Min(Vec4 v, float min) => new(Min(v.xy, min), Min(v.zw, min));
        public static Vec4 Frac(Vec4 v) => new(Frac(v.xy), Frac(v.zw));
        public static Vec4 Lerp(Vec4 a, Vec4 b, float t) => a + (t * (b - a));
        public static Vec4 Sign(Vec4 v) => new(Sign(v.xy), Sign(v.zw));

        public static Vec4 Degrees(Vec4 v) => v * degreeConversionConst;
        public static Vec4 Radians(Vec4 v) => v * radianConversionConst;
        public static Vec4 Sin(Vec4 v) => new(Sin(v.xy), Sin(v.zw));
        public static Vec4 Cos(Vec4 v) => new(Cos(v.xy), Cos(v.zw));
        public static Vec4 Tan(Vec4 v) => new(Tan(v.xy), Tan(v.zw));
        public static Vec4 Csc(Vec4 v) => new(Csc(v.xy), Csc(v.zw));
        public static Vec4 Sec(Vec4 v) => new(Sec(v.xy), Sec(v.zw));
        public static Vec4 Cot(Vec4 v) => new(Cot(v.xy), Cot(v.zw));
        public static Vec4 Asin(Vec4 v) => new(Asin(v.xy), Asin(v.zw));
        public static Vec4 Acos(Vec4 v) => new(Acos(v.xy), Acos(v.zw));
        public static Vec4 Atan(Vec4 v) => new(Atan(v.xy), Atan(v.zw));

        public static Vec4 Sinh(Vec4 v) => new(Sinh(v.xy), Sinh(v.zw));
        public static Vec4 Cosh(Vec4 v) => new(Cosh(v.xy), Cosh(v.zw));
        public static Vec4 Tanh(Vec4 v) => new(Tanh(v.xy), Tanh(v.zw));
        public static Vec4 Asinh(Vec4 v) => new(Asinh(v.xy), Asinh(v.zw));
        public static Vec4 Acosh(Vec4 v) => new(Acosh(v.xy), Acosh(v.zw));
        public static Vec4 Atanh(Vec4 v) => new(Atanh(v.xy), Atanh(v.zw));

        public static Vec4 Pow(Vec4 v, Vec4 p) => new(Pow(v.xy, p.xy), Pow(v.zw, p.zw));
        public static Vec4 Pow(Vec4 v, float p) => new(Pow(v.xy, p), Pow(v.zw, p));
        public static Vec4 Exp(Vec4 v) => new(Exp(v.xy), Exp(v.zw));
        public static Vec4 Exp10(Vec4 v) => new(Exp10(v.xy), Exp10(v.zw));
        public static Vec4 Exp2(Vec4 v) => new(Exp2(v.xy), Exp2(v.zw));
        public static Vec4 Logn(Vec4 v) => new(Logn(v.xy), Logn(v.zw));
        public static Vec4 Log10(Vec4 v) => new(Log10(v.xy), Log10(v.zw));
        public static Vec4 Log2(Vec4 v) => new(Log2(v.xy), Log2(v.zw));
        public static Vec4 Log(Vec4 v, Vec4 b) => new(Log(v.xy, b.xy), Log(v.zw, b.zw));
        public static Vec4 Sqrt(Vec4 v) => new(Sqrt(v.xy), Sqrt(v.zw));
        public static Vec4 Cbrt(Vec4 v) => new(Cbrt(v.xy), Cbrt(v.zw));
        public static Vec4 Nroot(Vec4 v, Vec4 b) => new(Nroot(v.xy, b.xy), Nroot(v.zw, b.zw));
        public static Vec4 InvSqrt(Vec4 v) => new(InvSqrt(v.xy), InvSqrt(v.zw));

        public static float Distance(Vec4 a, Vec4 b) => (a - b).magnitude;
        public static float SqrDist(Vec4 a, Vec4 b) => (a - b).sqrMagnitude;
        public static float Dot(Vec4 a, Vec4 b) => (a.x * b.x) + (a.y * b.y) + (a.z * b.z) + (a.w * b.w);
        public static Vec4 Reflect(Vec4 a, Vec4 b) => a - (2f * (Dot(a, b) * b));
    }
}
