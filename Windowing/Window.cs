using System;
using System.Runtime.InteropServices;
using GL;
using GLFW;
using MathS;

namespace Windowing
{
    public partial class Window
    {
        private IntPtr id;
        public static implicit operator IntPtr(Window w) => w.id;
        public int width { get; init; }
        public int height { get; init; }
        public string title { get; init; }
        public Int.Vec2 size { get => new(width, height); }
        public bool shouldClose { get => glfw.WindowShouldClose(id); }

        public Window(int width, int height, string title)
        {
            this.width = width;
            this.height = height;
            this.title = title;
            id = glfw.InitWindow(width, height, title);
        }
       

        public virtual void Render() => gl.Render(id);
        
    }
}