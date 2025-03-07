using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Crayon.Mathematics
{
    
    public struct Mat4 : IEquatable<Mat4>
    {
        public Matrix4x4 value;
        public Mat4(Matrix4x4 value) => this.value = value;
        public Mat4(float m11, float m12, float m13, float m14,
                    float m21, float m22, float m23, float m24,
                    float m31, float m32, float m33, float m34,
                    float m41, float m42, float m43, float m44) =>
                    value = new(m11, m12, m13, m14,
                                m21, m22, m23, m24,
                                m31, m32, m33, m34,
                                m41, m42, m43, m44);
        public Mat4(Vec4 a, Vec4 b, Vec4 c, Vec4 d)
            => value = new(a.x, a.y, a.z, a.w,
                           b.x, b.y, b.z, b.w,
                           c.x, c.y, c.z, c.w,
                           d.x, d.y, d.z, d.w);
        //public Mat4(Mat3x2 value) => this.value = new(value);


        public static implicit operator Matrix4x4(Mat4 v) => v.value;
        public static implicit operator Mat4(Matrix4x4 v) => new(v);
        public float m11 { get => value.M11; set => this.value.M11 = value; }
        public float m21 { get => value.M21; set => this.value.M21 = value; }
        public float m31 { get => value.M31; set => this.value.M31 = value; }
        public float m41 { get => value.M41; set => this.value.M41 = value; }

        public float m12 { get => value.M12; set => this.value.M12 = value; }
        public float m22 { get => value.M22; set => this.value.M22 = value; }
        public float m32 { get => value.M32; set => this.value.M32 = value; }
        public float m42 { get => value.M42; set => this.value.M42 = value; }

        public float m13 { get => value.M13; set => this.value.M13 = value; }
        public float m23 { get => value.M23; set => this.value.M23 = value; }
        public float m33 { get => value.M33; set => this.value.M33 = value; }
        public float m43 { get => value.M43; set => this.value.M43 = value; }

        public float m14 { get => value.M14; set => this.value.M14 = value; }
        public float m24 { get => value.M24; set => this.value.M24 = value; }
        public float m34 { get => value.M34; set => this.value.M34 = value; }
        public float m44 { get => value.M44; set => this.value.M44 = value; }

        public float determinant => value.GetDeterminant();
        public Mat4 transpose => Transpose(this);

        public static Mat4 identity => Matrix4x4.Identity;
        public bool isIdentity => value.IsIdentity;
        public Vec3 translation { get => value.Translation; set => this.value.Translation = value; }
        public static Mat4 Billboard(Vec3 objectPosition, Vec3 cameraPosition, Vec3 cameraUpVector, Vec3 cameraForwardVector)
            => Matrix4x4.CreateBillboard(objectPosition, cameraPosition, cameraUpVector, cameraForwardVector);
        public static Mat4 ConstrainedBillboard(Vec3 objectPosition, Vec3 cameraPosition, Vec3 rotateAxis, Vec3 cameraForwardVector, Vec3 objectForwardVector)
            => Matrix4x4.CreateConstrainedBillboard(objectPosition, cameraPosition, rotateAxis, cameraForwardVector, objectForwardVector);
        public static Mat4 Translation(Vec3 position) => Matrix4x4.CreateTranslation(position);
        public static Mat4 Scale(Vec3 scale) => Matrix4x4.CreateScale(scale);
        public static Mat4 Scale(float scale) => Matrix4x4.CreateScale(scale);
        public static Mat4 Scale(float x, float y, float z) => Matrix4x4.CreateScale(x, y, z);
        public static Mat4 Scale(Vec3 scale, Vec3 center) => Matrix4x4.CreateScale(scale, center);
        public static Mat4 Scale(float scale, Vec3 center) => Matrix4x4.CreateScale(scale, center);
        public static Mat4 Scale(float x, float y, float z, Vec3 center) => Matrix4x4.CreateScale(x, y, z, center);
        public static Mat4 RotationX(float angle) => Matrix4x4.CreateRotationX(angle);
        public static Mat4 RotationY(float angle) => Matrix4x4.CreateRotationY(angle);
        public static Mat4 RotationZ(float angle) => Matrix4x4.CreateRotationZ(angle);
        public static Mat4 RotationX(float angle, Vec3 center) => Matrix4x4.CreateRotationX(angle, center);
        public static Mat4 RotationY(float angle, Vec3 center) => Matrix4x4.CreateRotationY(angle, center);
        public static Mat4 RotationZ(float angle, Vec3 center) => Matrix4x4.CreateRotationZ(angle, center);
        public static Mat4 RotateAngleAxis(float angle, Vec3 axis) => Matrix4x4.CreateFromAxisAngle(axis, angle);
        public static Mat4 PerspectiveFOV(float fov, float aspectRatio, float nearPlane, float farPlane)
            => Matrix4x4.CreatePerspectiveFieldOfView(fov, aspectRatio, nearPlane, farPlane);
        public static Mat4 Perspective(float width, float height, float nearPlane, float farPlane)
            => Matrix4x4.CreatePerspective(width, height, nearPlane, farPlane);
        public static Mat4 Perspective(Vec2 size, float nearPlane, float farPlane)
            => Matrix4x4.CreatePerspective(size.x, size.y, nearPlane, farPlane);
        public static Mat4 OffCenterPerspective(float left, float right, float bottom, float top, float nearPlane, float farPlane)
            => Matrix4x4.CreatePerspectiveOffCenter(left, right, bottom, top, nearPlane, farPlane);
        public static Mat4 Orthographic(float width, float height, float nearPlane, float farPlane)
            => Matrix4x4.CreateOrthographic(width, height, nearPlane, farPlane);
        public static Mat4 OffCenterOthographic(float left, float right, float bottom, float top, float nearPlane, float farPlane)
            => Matrix4x4.CreateOrthographicOffCenter(left, right, bottom, top, nearPlane, farPlane);
        public static Mat4 LookAt(Vec3 camPosition, Vec3 camTarget, Vec3 camUp) => Matrix4x4.CreateLookAt(camPosition, camTarget, camUp);
        public static Mat4 world(Vec3 position, Vec3 forward, Vec3 up) => Matrix4x4.CreateWorld(position, forward, up);
        public static Mat4 RotateQuaternion(Vec4 angle) => Matrix4x4.CreateFromQuaternion(new(angle.x, angle.y, angle.z, angle.w));
        public static Mat4 RotateEuler(Vec3 angle) => Matrix4x4.CreateFromYawPitchRoll(angle.x, angle.y, angle.z);
        public static Mat4 RotateEuler(float x, float y, float z) => Matrix4x4.CreateFromYawPitchRoll(x,y,z);
        public static Mat4 Transpose(Mat4 m) => Matrix4x4.Transpose(m);
        public static Mat4 Lerp(Mat4 a, Mat4 b, float t) => Matrix4x4.Lerp(a, b, t);
        public static Mat4 Transform(Vec3 pos, Vec3 sca, Vec3 rot) => Scale(sca) * RotateEuler(rot) * Translation(pos);

        public static Mat4 operator -(Mat4 v) => -v.value;
        public static Mat4 operator +(Mat4 a, Mat4 b) => a.value + b.value;
        public static Mat4 operator -(Mat4 a, Mat4 b) => a.value + b.value;
        public static Mat4 operator *(Mat4 a, Mat4 b) => a.value * b.value;
        public static Mat4 operator *(Mat4 a, float b) => a.value * b;
        public static Mat4 operator *(float a, Mat4 b) => b.value * a;
        public static bool operator ==(Mat4 a, Mat4 b) => a.value == b.value;
        public static bool operator !=(Mat4 a, Mat4 b) => a.value != b.value;

        public override bool Equals(object? obj) => value.Equals(obj);
        public bool Equals(Mat4 other) => this.value.Equals(other);
        public override string ToString() => value.ToString();
        public override int GetHashCode() => value.GetHashCode();
        public float[] ToArray() => new float[] { m11, m12, m13, m14, m21, m22, m23, m24, m31, m32, m33, m34, m41, m42, m43, m44 };

    }
}
