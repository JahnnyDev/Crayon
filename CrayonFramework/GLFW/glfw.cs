using System.Runtime.InteropServices;

namespace Crayon.GLFW
{
    public static class glfw
    {
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern IntPtr InitWindow(int width, int height, string title);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern bool WindowShouldClose(IntPtr window);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int GetKey(IntPtr window, int key);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern string GetKeyName(int key, int scancode);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int GetKeyName(int key);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int GetMouseButton(IntPtr window, int button);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetMousePos(IntPtr window, double* x, double* y);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern float GetScroll(IntPtr window);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern float GetTime();
    }
}