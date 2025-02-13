using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace MathS
{
    public static partial class Int
    {
        public static int Abs(int v) => int.Abs(v);
        public static int Clamp(int v, int min, int max) => int.Clamp(v, min, max);
        public static int Max(int v, int max) => int.Max(v, max);
        public static int Min(int v, int max) => int.Min(v, max);
        public static int Sign(int v) => int.Sign(v);
        public static int Log2(int v) => int.Log2(v);

        public static Float.Vec2 CastToFloat(Vec2 v) => new((float)v.x, (float)v.y);
        public static Float.Vec3 CastToFloat(Vec3 v) => new((float)v.x, (float)v.y, (float)v.z);
        public static Float.Vec4 CastToFloat(Vec4 v) => new((float)v.x, (float)v.y, (float)v.z, (float)v.w);
    }
}
