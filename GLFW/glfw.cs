using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GLFW
{
    public static class glfw
    {
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern IntPtr InitWindow(int width, int height, string title);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern bool WindowShouldClose(IntPtr window);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int GetKey(IntPtr window, int key);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern string GetKeyName(int key, int scancode);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int GetKeyName(int key);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int GetMouseButton(IntPtr window, int button);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void GetMousePos(IntPtr window, double* x, double* y);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern float GetScroll(IntPtr window);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern float GetTime();

    }
}
