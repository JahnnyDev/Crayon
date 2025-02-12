﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Crayon.GL;
using Crayon.GLFW;
using static Crayon.GL.Flags;
using static Crayon.GLFW.Flags;
using Crayon.Utilities;



namespace Crayon.Windowing
{
    public abstract class Context
    {
        private int windowWidth, windowHeight;
        private string windowName;
        public bool programShouldClose;
        public static float elapsedTime, deltaTime;
        public static uint boundBuffer = 0u, boundVertexArray = 0u, boundShader = 0u, boundTexture = 0u;
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
