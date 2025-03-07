using System.Runtime.InteropServices;

namespace Crayon.GLFW
{
    public static class glfw
    {
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern nint InitWindow(int width, int height, string title);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern bool WindowShouldClose(nint window);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int GetKey(nint window, int key);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern string GetKeyName(int key, int scancode);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int GetKeyName(int key);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int GetMouseButton(nint window, int button);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetMousePos(nint window, double* x, double* y);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern float GetScroll(nint window);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern float GetTime();
    }
}