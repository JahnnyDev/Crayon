using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Crayon.Mathematics
{
    public struct Vec3 : IEquatable<Vec3>, IFormattable
    {
        private Vector3 value;
        public Vec3(Vector3 value) => this.value = value;
        public Vec3(float x, float y, float z) => value = new(x, y, z);
        public Vec3(Vec2 xy, float z) => value = new(xy, z);
        public Vec3(float x, Vec2 yz) => value = new(x, yz.x, yz.y);

        public static implicit operator Vector3(Vec3 v) => v.value;
        public static implicit operator Vec3(Vector3 v) => new(v);

        public static Vec3 zero => Vector3.Zero;
        public static Vec3 one => Vector3.One;
        public static Vec3 unitX => Vector3.UnitX;
        public static Vec3 unitY => Vector3.UnitY;
        public static Vec3 unitZ => Vector3.UnitZ;
        public static Vec3 unitXY => new(1, 1, 0);
        public static Vec3 unitXZ => new(1, 0, 1);
        public static Vec3 unitYZ => new(0, 1, 1);

        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object? obj) => value.Equals(obj);
        public  bool Equals(Vec3 other) => value.Equals(other.value);
        public override string ToString() => value.ToString();
        public string ToString(string? format) => value.ToString(format);
        public  string ToString(string? format, IFormatProvider formatProvider) => value.ToString(format, formatProvider);
        public void CopyTo(float[] array) => value.CopyTo(array);
        public void CopyTo(Span<float> destination) => value.CopyTo(destination);
        public void CopyTo(float[] array, int index) => value.CopyTo(array, index);
        public Vec3 Select(Func<float> function) => new(function.Invoke(), function.Invoke(), function.Invoke());
        public Vec3 Select(Func<float, float> function) => new(function.Invoke(x), function.Invoke(y), function.Invoke(z));

        public float x { get => value.X; set => this.value.X = value; }
        public float y { get => value.Y; set => this.value.Y = value; }
        public float z { get => value.Z; set => this.value.Z = value; }
        public float length => value.Length();
        public float sqrLength => value.LengthSquared();
        public Vec3 normalized => Normalize(this);

        public static float Dist(Vec3 a, Vec3 b) => Vector3.Distance(a, b);
        public static float SqrDist(Vec3 a, Vec3 b) => Vector3.DistanceSquared(a, b);
        public static float Dot(Vec3 a, Vec3 b) => Vector3.Dot(a, b);
        public static Vec3 Normalize(Vec3 v) => Vector3.Normalize(v);
        public static Vec3 Cross(Vec3 a, Vec3 b) => Vector3.Cross(a,b);
        public static Vec3 Reflect(Vec3 v, Vec3 n) => Vector3.Reflect(v, n);
        public static Vec3 Min(Vec3 a, Vec3 b) => Vector3.Min(a, b);
        public static Vec3 Max(Vec3 a, Vec3 b) => Vector3.Max(a, b);
        public static Vec3 Clamp(Vec3 v, Vec3 min, Vec3 max) => Vector3.Clamp(v, min, max);
        public static Vec3 Lerp(Vec3 a, Vec3 b, float t) => Vector3.Lerp(a, b, t);
        public static Vec3 Abs(Vec3 v) => Vector3.Abs(v);
        public static Vec3 Sqrt(Vec3 v) => Vector3.SquareRoot(v);
            

        public static Vec3 Transform(Vec3 v, Mat4 m) => Vector3.Transform(v, m);
        public static Vec3 TransformNormal(Vec3 v, Mat4 m) => Vector3.TransformNormal(v, m);

        public static Vec3 operator +(Vec3 a, Vec3 b) => a.value + b.value;
        public static Vec3 operator -(Vec3 a, Vec3 b) => a.value - b.value;
        public static Vec3 operator *(Vec3 a, Vec3 b) => a.value * b.value;
        public static Vec3 operator *(float a, Vec3 b) => a * b.value;
        public static Vec3 operator *(Vec3 a, float b) => a.value * b;
        public static Vec3 operator /(Vec3 a, Vec3 b) => a.value / b.value;
        public static Vec3 operator /(Vec3 a, float b) => a.value / b;
        public static Vec3 operator -(Vec3 a) => -a.value;
        public static bool operator ==(Vec3 a, Vec3 b) => a.value == b.value;
        public static bool operator !=(Vec3 a, Vec3 b) => a.value != b.value;

    }
}
