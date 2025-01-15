using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GL
{
    public static class gl
    {
        #region tests
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int RunTestLoop(IntPtr window);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int RunTestMain();
        #endregion

        #region application loop
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern bool Initialize(int versionMajor, int versionMinor, int profile);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern bool Load();
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Quit();
        #endregion

        #region window

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Render(IntPtr window);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Clear(int maskFlag);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ClearColor(float red, float green, float blue, float alpha);
        #endregion

        #region buffers
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void GenBuffers(int count, IntPtr buffers);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern uint GenBuffer();
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindBuffer(int target, uint buffer);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void DeleteBuffers(int count, IntPtr buffer);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void DeleteBuffer(uint buffer);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void BufferData(int target, int size, void* data, int usage);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void VertexAttribPointer(uint index, int size, int type, bool normalized, int stride, void* pointer);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void EnableVertexAttribArray(uint index);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void GenVertexArrays(int count, IntPtr vao);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern uint GenVertexArray();
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void BindVertexArray(uint vao);
        #endregion

        #region shaders
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern uint GenShader(int type);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ShaderSource(uint shader, string source);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CompileShader(uint shader);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern bool GetShaderInfo(uint shader, int flag, string info);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DetachShader(uint program, uint shader);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DeleteShader(uint shader);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern uint GenShaderProgram();
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void AttachShader(uint program, uint shader);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void LinkShaderProgram(uint program);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern bool GetShaderProgramInfo(uint program, int flag, string info);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindShaderProgram(uint program);
        #region shader uniforms
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int GetUniformLocation(uint program, string name);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform1d(int location, double value);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform1f(int location, float value);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform1i(int location, int value);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform1ui(int location, uint value);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform2d(int location, double x, double y);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform2f(int location, float x, float y);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform2i(int location, int x, int y);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform2ui(int location, uint x, uint y);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform3d(int location, double x, double y, double z);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform3f(int location, float x, float y, float z);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform3i(int location, int x, int y, int z);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform3ui(int location, uint x, uint y, uint z);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform4d(int location, double x, double y, double z, double w);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform4f(int location, float x, float y, float z, float w);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform4i(int location, int x, int y, int z, int w);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform4ui(int location, uint x, uint y, uint z, uint w);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void UniformMat2d(int location, double* value);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void UniformMat2f(int location, float* value);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void UniformMat3d(int location, double* value);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void UniformMat3f(int location, float* value);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void UniformMat4d(int location, double* value);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void UniformMat4f(int location, float* value);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void DrawArrays(uint mode, int first, int count);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void DrawArraysInderect(uint mode, IntPtr id);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void DrawArraysInstanced(uint mode, int first, int count, int instanceCount);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void DrawArraysBaseInstanced(uint mode, int first, int count, int instanceCount, uint baseInstance);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void DrawBuffer(uint Buffer);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void DrawBuffers(int count, IntPtr Buffer);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void DrawElements(uint mode, int count, uint type, IntPtr indices);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void DrawElementsBaseVertex(uint mode, int count, uint type, IntPtr indices, int baseVertex);
        #endregion
        #endregion

        #region textures
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ActiveTexture(uint texture);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void GenTextures(int count, uint* textures);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern uint GenTexture();
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void BindImageTextures(uint first, int count, uint* textures);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindTexture(int target, uint texture);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void BindTextures(uint first, int count, uint* textures);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindTextureUnit(uint unit, uint texture);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ClearTexImage(uint texture, int level, uint format, uint type, IntPtr data);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexParameterf(int target, int param, int paramValue);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexParameteri(int target, int param, int paramValue);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static unsafe extern void TexImage2D(int target, int level, int internalFormat, int width, int height, int border, int format, int type, byte* pixels);
        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void GenMipmap(int target);
        #endregion


    }
}
