using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Crayon.Mathematics
{
    public struct Vec4 : IEquatable<Vec4>, IFormattable
    {
        private Vector4 value;

        public Vec4(Vector4 value) => this.value = value;
        public Vec4(float x, float y, float z, float w) => value = new(x, y, z, w);
        public Vec4(Vec2 xy, float z, float w) => value = new(xy, z, w);
        public Vec4(float x, Vec2 yz, float w) => value = new(x, yz.x, yz.y, w);
        public Vec4(float x, float y, Vec2 zw) => value = new(x, y, zw.x, zw.y);
        public Vec4(Vec2 xy, Vec2 zw) => value = new(xy, zw.x, zw.y);
        public Vec4(Vec3 xyz, float w) => value = new(xyz, w);
        public Vec4(float x, Vec3 yzw) => value = new(x, yzw.x, yzw.y, yzw.z);

        public static implicit operator Vector4(Vec4 v) => v.value;
        public static implicit operator Vec4(Vector4 v) => new(v);


        public static Vec4 zero => Vector4.Zero;
        public static Vec4 one => Vector4.One;
        public static Vec4 unitX => Vector4.UnitX;
        public static Vec4 unitY => Vector4.UnitY;
        public static Vec4 unitZ => Vector4.UnitZ;
        public static Vec4 unitW => Vector4.UnitW;
        public static Vec4 unitXY => new(1, 1, 0, 0);
        public static Vec4 unitXZ => new(1, 0, 1, 0);
        public static Vec4 unitXW => new(1, 0, 0, 1);
        public static Vec4 unitYZ => new(0, 1, 1, 0);
        public static Vec4 unitYW => new(0, 1, 0, 1);
        public static Vec4 unitZW => new(0, 0, 1, 1);
        public static Vec4 unitXYZ => new(1, 1, 1, 0);
        public static Vec4 unitYZW => new(0, 1, 1, 1);

        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object? obj) => value.Equals(obj);
        public bool Equals(Vec4 other) => value.Equals(other);
        public override string ToString() => value.ToString();
        public string ToString(string format) => value.ToString(format);
        public string ToString(string format, IFormatProvider formatProvider) => value.ToString(format, formatProvider);
        public void CopyTo(float[] array) => value.CopyTo(array);
        public void CopyTo(Span<float> destination) => value.CopyTo(destination);
        public void CopyTo(float[] array, int index) => value.CopyTo(array, index);

        public Vec4 Select(Func<float> function) => new(function.Invoke(), function.Invoke(), function.Invoke(), function.Invoke());
        public Vec4 Select(Func<float, float> function) 
            => new(function.Invoke(x), function.Invoke(y), function.Invoke(z), function.Invoke(w));

        public float x { get => value.X; set => this.value.X = value; }
        public float y { get => value.Y; set => this.value.Y = value; }
        public float z { get => value.Z; set => this.value.Z = value; }
        public float w { get => value.W; set => this.value.W = value; }

        public float length => value.Length();
        public float sqrLength => value.LengthSquared();
        public Vector4 normalized => Normalize(this);

        
        public static float Dist(Vec4 a, Vec4 b) => Vector4.Distance(a, b);
        public static float SqrDist(Vec4 a, Vec4 b) => Vector4.DistanceSquared(a, b);
        public static float Dot(Vec4 a, Vec4 b) => Vector4.Dot(a, b); 
        public static Vec4 Normalize(Vec4 a) => Vector4.Normalize(a);
        
        public static Vec4 Min(Vec4 a, Vec4 b) => Vector4.Min(a, b);
        public static Vec4 Max(Vec4 a, Vec4 b) => Vector4.Max(a, b);
        public static Vec4 Clamp(Vec4 v, Vec4 min, Vec4 max) => Vector4.Clamp(v, min, max);
        public static Vec4 Lerp(Vec4 a, Vec4 b, float t) => Vector4.Lerp(a, b, t);
        public static Vec4 Transform(Vec4 v, Mat4 m) => Vector4.Transform(v, m);
        public static Vec4 Abs(Vec4 v) => Vector4.Abs(v);
        public static Vec4 Sqrt(Vec4 v) => Vector4.SquareRoot(v);

        public static Vec4 operator +(Vec4 a, Vec4 b) => a.value + b.value;
        public static Vec4 operator -(Vec4 a, Vec4 b) => a.value - b.value;
        public static Vec4 operator *(Vec4 a, Vec4 b) => a.value * b.value;
        public static Vec4 operator *(float a, Vec4 b) => a * b.value;
        public static Vec4 operator *(Vec4 a, float b) => a.value * b;
        public static Vec4 operator /(Vec4 a, Vec4 b) => a.value / b.value;
        public static Vec4 operator /(Vec4 a, float b) => a.value / b;
        public static Vec4 operator -(Vec4 a) => -a.value;
        public static bool operator ==(Vec4 a, Vec4 b) => a.value == b.value;
        public static bool operator !=(Vec4 a, Vec4 b) => a.value != b.value;


    }
}
