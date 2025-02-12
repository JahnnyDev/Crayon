using Stensil.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MathS.Float;
using Crayon.Windowing;
using Input;
using static Crayon.GLFW.Flags;

namespace TestApp.Assets.Scripts
{
    public class Camera : Transform
    {
        public Camera(float FOV, float aspectRatio) : base()
        {
            this.FOV = FOV;
            this.aspectRatio = aspectRatio;
        }
        public float FOV = 90f;
        public float aspectRatio;
        public float sensitivity = 25f;
        public Mat4 projection 
        {
            get
            {
                Vec3 offset = Transform(Vec3.unitZ, Mat4.RotateEuler(rotation));
                return Mat4.View(position, position + offset, Vec3.unitY) * Mat4.PerspectiveFOV(Radians(FOV), aspectRatio, 0.001f, 1000f);
             }
        }

        public void Update()
        {
            Vec3 inputAxis = new();

            inputAxis.x = Keyboard.GetAxis(GLFW_KEY_A, GLFW_KEY_D);
            inputAxis.y = Keyboard.GetAxis(GLFW_KEY_Q, GLFW_KEY_E);
            inputAxis.z = Keyboard.GetAxis(GLFW_KEY_W, GLFW_KEY_S);

            position += Transform(inputAxis, Mat4.RotateEuler(rotation)) * Context.deltaTime;

            rotation.xy += Mouse.delta.mirrorX * sensitivity * Context.deltaTime;
            rotation.y = Clamp(rotation.y, Radians(-89), Radians(89));
        }
    }
}
