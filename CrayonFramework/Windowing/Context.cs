using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Crayon.GL.Flags;
using static Crayon.GLFW.Flags;
using Crayon.Utilities;
using Crayon.GL;
using Crayon.GLFW;

namespace Crayon.Windowing
{
    public abstract class Context
    {
        private int windowWidth, windowHeight;
        private string windowName;
        public bool programShouldClose;
        public static float elapsedTime, deltaTime;
        public static uint boundVertexArray = 0u, boundShader = 0u, boundTexture = 0u;

        public static Dictionary<int, uint> boundBuffers = new()
        {
            {GL_ARRAY_BUFFER, 0 },
            {GL_COPY_READ_BUFFER, 0 },
            {GL_COPY_WRITE_BUFFER, 0 },
            {GL_ELEMENT_ARRAY_BUFFER, 0 },
            {GL_PIXEL_PACK_BUFFER, 0 },
            {GL_PIXEL_UNPACK_BUFFER, 0 },
            {GL_TEXTURE_BUFFER, 0 },
            {GL_TRANSFORM_FEEDBACK_BUFFER, 0 },
            {GL_UNIFORM_BUFFER, 0 },

        };

        public Window window;
        protected Context(int width, int height, string title)
        {
            windowWidth = width;
            windowHeight = height;
            windowName = title;
        }

        public virtual void Initialize()
        {
            AssetManager.directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Assets\\";
            ShaderPrecompiler.directory = AssetManager.directory + "Shaders\\";
            

            if (!gl.Initialize(4, 6, GLFW_OPENGL_CORE_PROFILE)) throw new Exception("Could not initialize Context");
            window = new(windowWidth, windowHeight, windowName);
            if (!gl.Load()) throw new Exception("Could not initalize GLAD");

            Input.Keyboard.ActiveWindow = window;
            Input.Mouse.ActiveWindow = window;
            
            
        }
        public abstract void Load();
        
        public virtual void Update()
        {
            deltaTime = glfw.GetTime() - elapsedTime;
            elapsedTime = glfw.GetTime();
        }
        public virtual void Render()=> window.Render();


        public virtual void Quit()
        {
            programShouldClose = true;
            gl.Quit();
        }

        public void Run()
        {
            Initialize();
            Load();
            while(!(window.shouldClose || programShouldClose))
            {
                Update();
                Render();
            }
            Quit();
        }
    }
}
