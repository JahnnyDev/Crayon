using Crayon.GL;
using Crayon.Graphics.Buffers;
using Crayon.Graphics.Shaders;
using Crayon.Graphics.Textures;
using Input;
using MathS;
using Stensil.Graphics.Primitives;
using Crayon.Utilities;
using Crayon.Windowing;
using static Crayon.GL.Flags;
using static Crayon.GLFW.Flags;
using static Stensil.Graphics.Primitives.Flags;
using static MathS.Float;
using TestApp.Assets.Scripts;

namespace TestApp
{
    public class Application : Context
    {

        private ShaderProgram shaderProgram;
        private Texture2D texture;

        public Application(int width, int height, string title) : base(width, height, title)
        {
        }

        public override void Initialize()
        {
            //Console.WriteLine("Wow,  The Program is Booting!");
            base.Initialize();
            gl.Enable(GL_DEPTH_TEST);
            gl.DepthFunc(GL_LESS);

        }

        public override unsafe void Load()
        {
            // Console.WriteLine("Wow,  The Program is Loading!");


            shaderProgram = ShaderProgram.LoadFromAssets("Ball");


            texture = new(GL_REPEAT, GL_LINEAR_MIPMAP_LINEAR, GL_LINEAR);
            texture.LoadFromImage(AssetManager.directory + "Textures\\wall.jpg", GL_RGB);

            box = new Box(VERTEX_POSITION);
            for (int i = 0; i < 10; i++)
                box.Instantiate(Vec3.random, Vec3.random, Vec3.one * 0.25f);
            cam = new(90, window.aspectRatio);


        }

        private Vec3 color;
        private Mat4 view;
        private Box box;
        private Camera cam;


        public override void Update()
        {
            base.Update();
            cam.Update();

            shaderProgram.SetUniform("view", cam.projection);
            

            
        }

        public unsafe override void Render()
        {

            gl.Clear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            gl.ClearColor(0.1f, 0.3f, 0.4f, 1f);

            for (int i = 0; i < 10; i++)
                box.DrawInstance(i, shaderProgram, "world");

            base.Render();
        }

        public override void Quit()
        {
            //Console.WriteLine("Wow,  The Program is Exiting!");
            base.Quit();
        }


    }
}