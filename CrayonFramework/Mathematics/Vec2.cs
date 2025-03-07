using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Crayon.Mathematics
{
    public struct Vec2 : IEquatable<Vec2>, IFormattable
    {
        private Vector2 value;
        public Vec2(Vector2 value) => this.value = value;
        public Vec2(float x, float y) => value = new(x, y);

        public static implicit operator Vector2(Vec2 v) => v.value;
        public static implicit operator Vec2(Vector2 v) => new(v);
        
        public static Vec2 zero => Vector2.Zero;
        public static Vec2 one => Vector2.One;
        public static Vec2 unitX => Vector2.UnitX;
        public static Vec2 unitY => Vector2.UnitY;


        public override int GetHashCode() => value.GetHashCode();
        public override bool Equals(object? obj) => value.Equals(obj);
        public  bool Equals(Vec2 other) => value.Equals(other.value);
        public override string ToString() => value.ToString();
        public string ToString(string format) => value.ToString(format);
        public string ToString(string? format, IFormatProvider? formatProvider) => value.ToString(format, formatProvider);
        public void CopyTo(float[] array) => value.CopyTo(array);
        public void CopyTo(Span<float> destination) => value.CopyTo(destination);
        public void CopyTo(float[] array, int index) => value.CopyTo(array, index);
        public Vec2 Select(Func<float> function) => new(function.Invoke(), function.Invoke());
        public Vec2 Select(Func<float, float> function) => new(function.Invoke(x), function.Invoke(y));

        public float x { get => value.X; set => this.value.X = value; }
        public float y { get => value.Y; set => this.value.Y = value; }

        public float length => value.Length();
        public float sqrLength => value.LengthSquared();
        public Vec2 normalized => Normalize(this);


        public static float Dist(Vec2 a, Vec2 b) => Vector2.Distance(a, b);
        public static float SqrDist(Vec2 a, Vec2 b) => Vector2.DistanceSquared(a, b);
        public static Vec2 Reflect(Vec2 v, Vec2 normal) => Vector2.Reflect(v, normal);
        public static float Dot(Vec2 a, Vec2 b) => Vector2.Dot(a, b);
        public static Vec2 Normalize(Vec2 v) => Vector2.Normalize(v);
        public static Vec2 Min(Vec2 a, Vec2 b) => Vector2.Min(a, b);
        public static Vec2 Max(Vec2 a, Vec2 b) => Vector2.Max(a, b);
        public static Vec2 Clamp(Vec2 v, Vec2 min, Vec2 max) => Vector2.Clamp(v, min, max);
        public static Vec2 Lerp(Vec2 a, Vec2 b, float t) => Vector2.Lerp(a, b, t);
        public static Vec2 Abs(Vec2 v) => Vector2.Abs(v);
        public static Vec2 Sqrt(Vec2 v) => Vector2.SquareRoot(v);
        public static Vec2 Transform(Vec2 v, Mat4 m) => Vector2.Transform(v, m);
        public static Vec2 TransformNormal(Vec2 v, Mat4 m) => Vector2.TransformNormal(v, m);
        public static Vec2 operator +(Vec2 a, Vec2 b) => a.value + b.value;
        public static Vec2 operator -(Vec2 a, Vec2 b) => a.value - b.value;
        public static Vec2 operator *(Vec2 a, Vec2 b) => a.value * b.value;
        public static Vec2 operator *(float a, Vec2 b) => a * b.value;
        public static Vec2 operator *(Vec2 a, float b) => a.value * b;
        public static Vec2 operator /(Vec2 a, Vec2 b) => a.value / b.value;
        public static Vec2 operator /(Vec2 a, float b) => a.value / b;
        public static Vec2 operator -(Vec2 a) => -a.value;
        public static bool operator ==(Vec2 a, Vec2 b) => a.value == b.value;
        public static bool operator !=(Vec2 a, Vec2 b) => a.value != b.value;

    }
}