using System.Runtime.InteropServices;

namespace Crayon.STBI
{
    public static class stbi
    {
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern byte* ImageLoad(string file, int* width, int* height, int* channelCount);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void DisposeImage(byte* data);
    }
}