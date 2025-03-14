using Crayon.GL;
using Crayon.Graphics.Buffers;
using Crayon.Graphics.Shaders;
using Crayon.Graphics.Textures;
using Input;
using Crayon.Utilities;
using Crayon.Windowing;
using static Crayon.GL.Flags;
using static Crayon.GLFW.Flags;
using Crayon.Mathematics;
using nstancing_Benchmark_1.Assets.Scripts;
using System.Text;
using Crayon;
using Crayon.Graphics;

namespace Instancing_Benchmark_1
{
    public class Application : Context
    {


        public Application(int width, int height, string title) : base(width, height, title)
        {
        }
        private Mesh mesh;
        private ShaderProgram shaderProgram;
        private Vec3 color;
        private Mat4 view;
        private Camera cam;
        public override void Initialize()
        {
            base.Initialize();

            gl.Enable(GL_DEPTH_TEST);
            gl.DepthFunc(GL_LESS);
            gl.Enable(GL_CULL_FACE);
            gl.CullFace(GL_FRONT);

        }

        public override unsafe void Load()
        {


            shaderProgram = ShaderProgram.LoadFromAssets("Ball");
            Random r = new();


            cam = new(90, window.aspectRatio);


            mesh = MeshLoader.LoadMesh("Teapot");
            mesh.useCheckedInstancing = false;
            for (int i = 0; i < 2000; i++)
            {

                mesh.Instantiate(Vec3.Select(r.NextSingle) * 100, Vec3.Select(r.NextSingle) * float.Tau, Vec3.one);
            }
            shaderProgram.SetUniform("lightDir", new Vec3(float.Cos(elapsedTime), float.Sin(elapsedTime), 0));
        }




        public override void Update()
        {
            base.Update();
            cam.Update();
            shaderProgram.SetUniform("view", cam.projection);

            shaderProgram.SetUniform("time", elapsedTime);

        }

        public unsafe override void Render()
        {

            gl.Clear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            gl.ClearColor(0.1f, 0.3f, 0.4f, 1f);

            for (int x = -2; x < 2; x++)
                for (int y = -2; y < 2; y++)
                    for (int z = -2; z < 2; z++)
                    {
                        Vec3 offset = new Vec3(x, y, z) * 100f;
                        Mat4 world = Mat4.Translation(offset + cam.position.Select(v => float.Round(v / 100) * 100));
                        shaderProgram.SetUniform("world", world);
                        mesh.DrawAllInstances(shaderProgram);
                    }





            base.Render();
        }

        public override void Quit()
        {
            base.Quit();
        }


    }
}