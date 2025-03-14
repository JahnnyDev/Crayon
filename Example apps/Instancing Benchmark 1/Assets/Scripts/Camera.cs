using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crayon.Mathematics;
using Crayon.Windowing;
using Input;
using static Crayon.GLFW.Flags;

namespace nstancing_Benchmark_1.Assets.Scripts
{
    public class Camera
    {
        public Camera(float FOV, float aspectRatio) : base()
        {
            position = Vec3.zero;
            rotation = Vec3.zero;
            scale = Vec3.one;

            fov = FOV *float.Pi / 180f;
            this.aspectRatio = aspectRatio;
            }

        private float fov, aspectRatio;
        public float sensitivity = 30f;
        public Vec3 position, rotation, scale;
        public Mat4 transform => Mat4.Transform(position, rotation, scale);
        public Mat4 projection 
        {
            get
            {

                Vec3 offset = Vec3.Transform(Vec3.unitZ, Mat4.RotateEuler(rotation));
                Mat4 result = Mat4.LookAt(position, position + offset, Vec3.unitY);
                result *= Mat4.PerspectiveFOV(fov, aspectRatio, 0.001f, 141f);
                return result;
             }
        }

        public void Update()
        {
            Vec3 inputAxis = new();

            inputAxis.x = Keyboard.GetAxis(GLFW_KEY_A, GLFW_KEY_D);
            inputAxis.y = Keyboard.GetAxis(GLFW_KEY_Q, GLFW_KEY_E);
            inputAxis.z = Keyboard.GetAxis(GLFW_KEY_W, GLFW_KEY_S);

            position += Vec3.Transform(inputAxis, Mat4.RotateEuler(rotation)) * 10 * Context.deltaTime;

            Vec2 mouse = Mouse.delta * sensitivity * Context.deltaTime;
            rotation.x -= mouse.x;
            rotation.y += mouse.y;
            rotation.y = float.Clamp(rotation.y, -float.Pi *.499f , float.Pi * .499f);
        }
    }
}
