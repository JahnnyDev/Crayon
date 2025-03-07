using System.Runtime.InteropServices;

namespace Crayon.GL
{
    public static class gl
    {
        #region tests

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int RunTestLoop(nint window);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern int RunTestMain();

        #endregion tests

        #region application loop

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern bool Initialize(int versionMajor, int versionMinor, int profile);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern bool Load();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Quit();

        #endregion application loop

        #region window

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Render(nint window);

        #endregion window

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern uint GenBuffer();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DeleteBuffer(uint buf);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribPointer(uint index, int size, int type, bool normalized, int stride, void* pointer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern uint GenShader(int type);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ShaderSource(uint shader, string source);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern bool GetShaderInfo(uint shader, int flag, string info);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern uint GenShaderProgram();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void LinkShaderProgram(uint program);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern bool GetShaderProgramInfo(uint program, int flag, string info);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindShaderProgram(uint program);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern uint GenTexture();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void GenMipmap(int target);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern uint GenVertexArray();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CullFace(uint mode);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void FrontFace(uint mode);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Hint(int target, uint mode);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void LineWidth(float width);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void PointSize(float size);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void PolygonMode(uint face, uint mode);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Scissor(int x, int y, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexParameterf(int target, uint pname, float param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexParameterfv(int target, uint pname, float* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexParameteri(int target, uint pname, int param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexParameteriv(int target, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexImage1D(int target, int level, int internalformat, int width, int border, int format, uint type, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexImage2D(int target, int level, int internalformat, int width, int height, int border, int format, int type, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DrawBuffer(uint buf);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Clear(uint mask);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ClearColor(float red, float green, float blue, float alpha);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ClearStencil(int s);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ClearDepth(double depth);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void StencilMask(uint mask);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ColorMask(byte red, byte green, byte blue, byte alpha);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DepthMask(byte flag);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Disable(uint cap);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Enable(uint cap);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Finnish();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Flush();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BlendFunc(uint sfactor, uint dfactor);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void LogicOp(uint opcode);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void StencilFunc(uint func, int reference, uint mask);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void StencilOp(uint fail, uint zfail, uint zpass);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DepthFunc(uint func);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void PixelStoref(uint pname, float param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void PixelStorei(uint pname, int param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ReadBuffer(uint src);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetBooleanv(uint pname, byte* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetDoublev(uint pname, double* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void GetError();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetFloatv(uint pname, float* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetIntegerv(uint pname, int* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void GetString(uint name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTexImage(int target, int level, uint format, uint type, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTexParameterfv(int target, uint pname, float* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTexParameteriv(int target, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTexLevelParameterfv(int target, int level, uint pname, float* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTexLevelParameteriv(int target, int level, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsEnabled(uint cap);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DepthRange(double n, double f);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Viewport(int x, int y, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DrawArrays(uint mode, int first, int count);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DrawElements(uint mode, int count, uint type, void* indices);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void PolygonOffset(float factor, float units);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CopyTexImage1D(int target, int level, uint internalformat, int x, int y, int width, int border);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CopyTexImage2D(int target, int level, uint internalformat, int x, int y, int width, int height, int border);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CopyTexSubImage1D(int target, int level, int xoffset, int x, int y, int width);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CopyTexSubImage2D(int target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexSubImage1D(int target, int level, int xoffset, int width, uint format, uint type, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindTexture(int target, uint texture);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DeleteTextures(int n, uint* textures);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GenTextures(int n, uint* textures);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsTexture(uint texture);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexImage3D(int target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexSubImage3D(int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CopyTexSubImage3D(int target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ActiveTexture(uint texture);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void SampleCoverage(float value, byte invert);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CompressedTexImage3D(int target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CompressedTexImage2D(int target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CompressedTexImage1D(int target, int level, uint internalformat, int width, int border, int imageSize, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CompressedTexSubImage3D(int target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CompressedTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CompressedTexSubImage1D(int target, int level, int xoffset, int width, uint format, int imageSize, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetCompressedTexImage(int target, int level, void* img);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void MultiDrawArrays(uint mode, int* first, int* count, int drawcount);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void MultiDrawElements(uint mode, int* count, uint type, void** indices, int drawcount);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void PointParameterf(uint pname, float param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void PointParameterfv(uint pname, float* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void PointParameteri(uint pname, int param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void PointParameteriv(uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BlendColor(float red, float green, float blue, float alpha);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BlendEquation(uint mode);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GenQueries(int n, uint* ids);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DeleteQueries(int n, uint* ids);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsQuery(uint id);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BeginQuery(int target, uint id);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void EndQuery(int target);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetQueryiv(int target, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetQueryObjectiv(uint id, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetQueryObjectuiv(uint id, uint pname, uint* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindBuffer(int target, uint buffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DeleteBuffers(int n, uint* buffers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GenBuffers(int n, uint* buffers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsBuffer(uint buffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void BufferData(int target, nint size, void* data, int usage);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void BufferSubData(int target, nint offset, nint size, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetBufferSubData(int target, nint offset, nint size, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void MapBuffer(int target, uint access);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void UnmapBuffer(int target);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetBufferParameteriv(int target, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetBufferPointerv(int target, uint pname, void** param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BlendEquationSeparate(uint modeRGB, uint modeAlpha);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DrawBuffers(int n, uint* bufs);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void StencilFuncSeparate(uint face, uint func, int reference, uint mask);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void StencilMaskSeparate(uint face, uint mask);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void AttachShader(uint program, uint shader);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void BindAttribLocation(uint program, uint index, string name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CompileShader(uint shader);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DeleteShaderProgram(uint program);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DeleteShader(uint shader);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DetachShader(uint program, uint shader);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DisableVertexAttribArray(uint index);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void EnableVertexAttribArray(uint index);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetAttachedShaders(uint program, int maxCount, int* count, uint* shaders);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetAttribLocation(uint program, string name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetProgramiv(uint program, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetProgramInfoLog(uint program, int bufSize, int* length, char* infoLog);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetShaderiv(uint shader, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetShaderInfoLog(uint shader, int bufSize, int* length, char* infoLog);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetShaderSource(uint shader, int bufSize, int* length, char* source);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe int GetUniformLocation(uint program, string name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetUniformfv(uint program, int location, float* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetUniformiv(uint program, int location, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetVertexAttribdv(uint index, uint pname, double* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetVertexAttribfv(uint index, uint pname, float* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetVertexAttribiv(uint index, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetVertexAttribPointerv(uint index, uint pname, void** pointer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsProgram(uint program);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsShader(uint shader);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void LinkProgram(uint program);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void UseProgram(uint program);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform1f(int location, float v0);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform2f(int location, float v0, float v1);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform3f(int location, float v0, float v1, float v2);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform4f(int location, float v0, float v1, float v2, float v3);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform1i(int location, int v0);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform2i(int location, int v0, int v1);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform3i(int location, int v0, int v1, int v2);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform4i(int location, int v0, int v1, int v2, int v3);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform1fv(int location, int count, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform2fv(int location, int count, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform3fv(int location, int count, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform4fv(int location, int count, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform1iv(int location, int count, int* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform2iv(int location, int count, int* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform3iv(int location, int count, int* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform4iv(int location, int count, int* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat2fv(int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat3fv(int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat4fv(int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ValidateProgram(uint program);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib1d(uint index, double x);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib1dv(uint index, double* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib1f(uint index, float x);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib1fv(uint index, float* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib1s(uint index, short x);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib1sv(uint index, short* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib2d(uint index, double x, double y);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib2dv(uint index, double* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib2f(uint index, float x, float y);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib2fv(uint index, float* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib2s(uint index, short x, short y);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib2sv(uint index, short* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib3d(uint index, double x, double y, double z);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib3dv(uint index, double* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib3f(uint index, float x, float y, float z);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib3fv(uint index, float* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib3s(uint index, short x, short y, short z);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib3sv(uint index, short* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib4Nbv(uint index, nint v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib4Niv(uint index, int* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib4Nsv(uint index, short* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib4Nubv(uint index, byte* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib4Nuiv(uint index, uint* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib4Nusv(uint index, ushort* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib4bv(uint index, nint v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib4d(uint index, double x, double y, double z, double w);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib4dv(uint index, double* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib4f(uint index, float x, float y, float z, float w);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib4fv(uint index, float* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib4iv(uint index, int* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttrib4s(uint index, short x, short y, short z, short w);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib4sv(uint index, short* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib4ubv(uint index, byte* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib4uiv(uint index, uint* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttrib4usv(uint index, ushort* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat2x3fv(int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat3x2fv(int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat2x4fv(int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat4x2fv(int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat3x4fv(int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat4x3fv(int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ColorMaski(uint index, byte r, byte g, byte b, byte a);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetBooleani_v(int target, uint index, byte* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetIntegeri_v(int target, uint index, int* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Enablei(int target, uint index);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Disablei(int target, uint index);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsEnabledi(int target, uint index);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BeginTransformFeedback(uint primitiveMode);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void EndTransformFeedback();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindBufferRange(int target, uint index, uint buffer, nint offset, nint size);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindBufferBase(int target, uint index, uint buffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TransformFeedbackVaryings(uint program, int count, string* varyings, uint bufferMode);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ClampColor(int target, uint clamp);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BeginConditionalRender(uint id, uint mode);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void EndConditionalRender();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribIPointer(uint index, int size, uint type, int stride, void* pointer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetVertexAttribIiv(uint index, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetVertexAttribIuiv(uint index, uint pname, uint* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribI1i(uint index, int x);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribI2i(uint index, int x, int y);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribI3i(uint index, int x, int y, int z);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribI4i(uint index, int x, int y, int z, int w);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribI1ui(uint index, uint x);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribI2ui(uint index, uint x, uint y);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribI3ui(uint index, uint x, uint y, uint z);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribI1iv(uint index, int* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribI2iv(uint index, int* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribI3iv(uint index, int* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribI4iv(uint index, int* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribI1uiv(uint index, uint* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribI2uiv(uint index, uint* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribI3uiv(uint index, uint* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribI4uiv(uint index, uint* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribI4bv(uint index, nint v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribI4sv(uint index, short* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribI4ubv(uint index, byte* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribI4usv(uint index, ushort* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetUniformuiv(uint program, int location, uint* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void BindFragDataLocation(uint program, uint color, string name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetFragDataLocation(uint program, string name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform1ui(int location, uint v0);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform2ui(int location, uint v0, uint v1);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform3ui(int location, uint v0, uint v1, uint v2);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform1uiv(int location, int count, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform2uiv(int location, int count, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform3uiv(int location, int count, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform4uiv(int location, int count, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexParameterIiv(int target, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexParameterIuiv(int target, uint pname, uint* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTexParameterIiv(int target, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTexParameterIuiv(int target, uint pname, uint* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ClearBufferiv(uint buffer, int drawbuffer, int* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ClearBufferuiv(uint buffer, int drawbuffer, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ClearBufferfv(uint buffer, int drawbuffer, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void GetStringi(uint name, uint index);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsRenderbuffer(uint renderbuffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindRenderbuffer(int target, uint renderbuffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DeleteRenderbuffers(int n, uint* renderbuffers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GenRenderbuffers(int n, uint* renderbuffers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void RenderbufferStorage(int target, uint internalformat, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetRenderbufferParameteriv(int target, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsFramebuffer(uint framebuffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindFramebuffer(int target, uint framebuffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DeleteFramebuffers(int n, uint* framebuffers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GenFramebuffers(int n, uint* framebuffers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CheckFramebufferStatus(int target);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void FramebufferTexture1D(int target, uint attachment, uint textarget, uint texture, int level);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void FramebufferTexture2D(int target, uint attachment, uint textarget, uint texture, int level);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void FramebufferTexture3D(int target, uint attachment, uint textarget, uint texture, int level, int zoffset);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void FramebufferRenderbuffer(int target, uint attachment, uint renderbuffertarget, uint renderbuffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetFramebufferAttachmentParameteriv(int target, uint attachment, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void RenderbufferStorageMultisample(int target, int samples, uint internalformat, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void FramebufferTextureLayer(int target, uint attachment, uint texture, int level, int layer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void MapBufferRange(int target, nint offset, nint length, uint access);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void FlushMappedBufferRange(int target, nint offset, nint length);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindVertexArray(uint array);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DeleteVertexArrays(int n, uint* arrays);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GenVertexArrays(int n, uint* arrays);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsVertexArray(uint array);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DrawArraysInstanced(uint mode, int first, int count, int instancecount);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DrawElementsInstanced(uint mode, int count, uint type, void* indices, int instancecount);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexBuffer(int target, uint internalformat, uint buffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void PrimitiveRestartIndex(uint index);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CopyBufferSubData(uint readTarget, uint writeTarget, nint readOffset, nint writeOffset, nint size);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetUniformIndices(uint program, int uniformCount, string* uniformNames, uint* uniformIndices);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetActiveUniformsiv(uint program, int uniformCount, uint* uniformIndices, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, char* uniformName);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetUniformBlockIndex(uint program, string uniformBlockName);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, char* uniformBlockName);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DrawElementsBaseVertex(uint mode, int count, uint type, void* indices, int basevertex);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, void* indices, int basevertex);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, void* indices, int instancecount, int basevertex);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void MultiDrawElementsBaseVertex(uint mode, int* count, uint type, void** indices, int drawcount, int* basevertex);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProvokingVertex(uint mode);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void FenceSync(uint condition, uint flags);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsSync(nint sync);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DeleteSync(nint sync);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ClientWaitSync(nint sync, uint flags, long timeout);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void WaitSync(nint sync, uint flags, long timeout);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetInteger64v(uint pname, long* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetSynciv(nint sync, uint pname, int count, int* length, int* values);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetInteger64i_v(int target, uint index, long* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetBufferParameteri64v(int target, uint pname, long* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void FramebufferTexture(int target, uint attachment, uint texture, int level);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexImage2DMultisample(int target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexImage3DMultisample(int target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetMultisamplefv(uint pname, uint index, float* val);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void SampleMaski(uint maskNumber, uint mask);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetFragDataIndex(uint program, string name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GenSamplers(int count, uint* samplers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DeleteSamplers(int count, uint* samplers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsSampler(uint sampler);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindSampler(uint unit, uint sampler);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void SamplerParameteri(uint sampler, uint pname, int param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void SamplerParameteriv(uint sampler, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void SamplerParameterf(uint sampler, uint pname, float param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void SamplerParameterfv(uint sampler, uint pname, float* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void SamplerParameterIiv(uint sampler, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void SamplerParameterIuiv(uint sampler, uint pname, uint* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetSamplerParameteriv(uint sampler, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetSamplerParameterIiv(uint sampler, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetSamplerParameterfv(uint sampler, uint pname, float* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetSamplerParameterIuiv(uint sampler, uint pname, uint* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void QueryCounter(uint id, int target);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetQueryObjecti64v(uint id, uint pname, long* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetQueryObjectui64v(uint id, uint pname, ulong* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribDivisor(uint index, uint divisor);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribP1ui(uint index, uint type, byte normalized, uint value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribP1uiv(uint index, uint type, byte normalized, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribP2ui(uint index, uint type, byte normalized, uint value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribP2uiv(uint index, uint type, byte normalized, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribP3ui(uint index, uint type, byte normalized, uint value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribP3uiv(uint index, uint type, byte normalized, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribP4ui(uint index, uint type, byte normalized, uint value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribP4uiv(uint index, uint type, byte normalized, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexP2ui(uint type, uint value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexP2uiv(uint type, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexP3ui(uint type, uint value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexP3uiv(uint type, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexP4ui(uint type, uint value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexP4uiv(uint type, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexCoordP1ui(uint type, uint coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexCoordP1uiv(uint type, uint* coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexCoordP2ui(uint type, uint coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexCoordP2uiv(uint type, uint* coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexCoordP3ui(uint type, uint coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexCoordP3uiv(uint type, uint* coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexCoordP4ui(uint type, uint coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TexCoordP4uiv(uint type, uint* coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void MultiTexCoordP1ui(uint texture, uint type, uint coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void MultiTexCoordP1uiv(uint texture, uint type, uint* coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void MultiTexCoordP2ui(uint texture, uint type, uint coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void MultiTexCoordP2uiv(uint texture, uint type, uint* coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void MultiTexCoordP3ui(uint texture, uint type, uint coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void MultiTexCoordP3uiv(uint texture, uint type, uint* coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void MultiTexCoordP4ui(uint texture, uint type, uint coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void MultiTexCoordP4uiv(uint texture, uint type, uint* coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void NormalP3ui(uint type, uint coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void NormalP3uiv(uint type, uint* coords);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ColorP3ui(uint type, uint color);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ColorP3uiv(uint type, uint* color);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ColorP4ui(uint type, uint color);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ColorP4uiv(uint type, uint* color);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void SecondaryColorP3ui(uint type, uint color);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void SecondaryColorP3uiv(uint type, uint* color);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void MinSampleShading(float value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BlendEquationi(uint buf, uint mode);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BlendFunci(uint buf, uint src, uint dst);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DrawArraysIndirect(uint mode, void* indirect);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DrawElementsIndirect(uint mode, uint type, void* indirect);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform1d(int location, double x);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform2d(int location, double x, double y);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform3d(int location, double x, double y, double z);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void Uniform4d(int location, double x, double y, double z, double w);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform1dv(int location, int count, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform2dv(int location, int count, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform3dv(int location, int count, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void Uniform4dv(int location, int count, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat2dv(int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat3dv(int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat4dv(int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat2x3dv(int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat2x4dv(int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat3x2dv(int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat3x4dv(int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat4x2dv(int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformMat4x3dv(int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetUniformdv(uint program, int location, double* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetSubroutineUniformLocation(uint program, uint shadertype, string name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetSubroutineIndex(uint program, uint shadertype, string name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetActiveSubroutineName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void UniformSubroutinesuiv(uint shadertype, int count, uint* indices);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetUniformSubroutineuiv(uint shadertype, int location, uint* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetProgramStageiv(uint program, uint shadertype, uint pname, int* values);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void PatchParameteri(uint pname, int value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void PatchParameterfv(uint pname, float* values);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindTransformFeedback(int target, uint id);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DeleteTransformFeedbacks(int n, uint* ids);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GenTransformFeedbacks(int n, uint* ids);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsTransformFeedback(uint id);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void PauseTransformFeedback();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ResumeTransformFeedback();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DrawTransformFeedback(uint mode, uint id);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DrawTransformFeedbackStream(uint mode, uint id, uint stream);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BeginQueryIndexed(int target, uint index, uint id);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void EndQueryIndexed(int target, uint index);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetQueryIndexediv(int target, uint index, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ReleaseShaderCompiler();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ShaderBinary(int count, uint* shaders, uint binaryFormat, void* binary, int length);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DepthRangef(float n, float f);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ClearDepthf(float d);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramBinary(uint program, uint binaryFormat, void* binary, int length);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramParameteri(uint program, uint pname, int value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void UseProgramStages(uint pipeline, uint stages, uint program);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ActiveShaderProgram(uint pipeline, uint program);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CreateShaderProgramv(uint type, int count, string* strings);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindProgramPipeline(uint pipeline);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DeleteProgramPipelines(int n, uint* pipelines);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GenProgramPipelines(int n, uint* pipelines);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void IsProgramPipeline(uint pipeline);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetProgramPipelineiv(uint pipeline, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform1i(uint program, int location, int v0);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform1iv(uint program, int location, int count, int* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform1f(uint program, int location, float v0);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform1fv(uint program, int location, int count, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform1d(uint program, int location, double v0);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform1dv(uint program, int location, int count, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform1ui(uint program, int location, uint v0);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform1uiv(uint program, int location, int count, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform2i(uint program, int location, int v0, int v1);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform2iv(uint program, int location, int count, int* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform2f(uint program, int location, float v0, float v1);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform2fv(uint program, int location, int count, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform2d(uint program, int location, double v0, double v1);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform2dv(uint program, int location, int count, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform2ui(uint program, int location, uint v0, uint v1);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform2uiv(uint program, int location, int count, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform3i(uint program, int location, int v0, int v1, int v2);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform3iv(uint program, int location, int count, int* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform3f(uint program, int location, float v0, float v1, float v2);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform3fv(uint program, int location, int count, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform3d(uint program, int location, double v0, double v1, double v2);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform3dv(uint program, int location, int count, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform3uiv(uint program, int location, int count, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform4iv(uint program, int location, int count, int* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform4fv(uint program, int location, int count, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform4dv(uint program, int location, int count, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniform4uiv(uint program, int location, int count, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix2fv(uint program, int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix3fv(uint program, int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix4fv(uint program, int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix2dv(uint program, int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix3dv(uint program, int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix4dv(uint program, int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix2x3fv(uint program, int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix3x2fv(uint program, int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix2x4fv(uint program, int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix4x2fv(uint program, int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix3x4fv(uint program, int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix4x3fv(uint program, int location, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix2x3dv(uint program, int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix3x2dv(uint program, int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix2x4dv(uint program, int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix4x2dv(uint program, int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix3x4dv(uint program, int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ProgramUniformMatrix4x3dv(uint program, int location, double* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ValidateProgramPipeline(uint pipeline);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, char* infoLog);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribL1d(uint index, double x);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribL2d(uint index, double x, double y);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribL3d(uint index, double x, double y, double z);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribL4d(uint index, double x, double y, double z, double w);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribL1dv(uint index, double* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribL2dv(uint index, double* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribL3dv(uint index, double* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribL4dv(uint index, double* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexAttribLPointer(uint index, int size, uint type, int stride, void* pointer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetVertexAttribLdv(uint index, uint pname, double* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ViewportArrayv(uint first, int count, float* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ViewportIndexedf(uint index, float x, float y, float w, float h);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ViewportIndexedfv(uint index, float* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ScissorArrayv(uint first, int count, int* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ScissorIndexed(uint index, int left, int bottom, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ScissorIndexedv(uint index, int* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DepthRangeArrayv(uint first, int count, double* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DepthRangeIndexed(uint index, double n, double f);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetFloati_v(int target, uint index, float* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetDoublei_v(int target, uint index, double* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, uint baseinstance);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, void* indices, int instancecount, int basevertex, uint baseinstance);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetInternalformativ(int target, uint internalformat, uint pname, int count, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindImageTexture(uint unit, uint texture, int level, byte layered, int layer, uint access, uint format);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void GetMemoryBarrier(uint barriers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexStorage1D(int target, int levels, uint internalformat, int width);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexStorage2D(int target, int levels, uint internalformat, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexStorage3D(int target, int levels, uint internalformat, int width, int height, int depth);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DrawTransformFeedbackInstanced(uint mode, uint id, int instancecount);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ClearBufferData(int target, uint internalformat, uint format, uint type, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ClearBufferSubData(int target, uint internalformat, nint offset, nint size, uint format, uint type, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DispatchComputeIndirect(nint indirect);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void FramebufferParameteri(int target, uint pname, int param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetFramebufferParameteriv(int target, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetInternalformati64v(int target, uint internalformat, uint pname, int count, long* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void InvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void InvalidateTexImage(uint texture, int level);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void InvalidateBufferSubData(uint buffer, nint offset, nint length);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void InvalidateBufferData(uint buffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void InvalidateFramebuffer(int target, int numAttachments, uint* attachments);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void InvalidateSubFramebuffer(int target, int numAttachments, uint* attachments, int x, int y, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void MultiDrawArraysIndirect(uint mode, void* indirect, int drawcount, int stride);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void MultiDrawElementsIndirect(uint mode, uint type, void* indirect, int drawcount, int stride);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetProgramResourceIndex(uint program, uint programInterface, string name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, char* name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, uint* props, int count, int* length, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetProgramResourceLocation(uint program, uint programInterface, string name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetProgramResourceLocationIndex(uint program, uint programInterface, string name);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexBufferRange(int target, uint internalformat, uint buffer, nint offset, nint size);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexStorage2DMultisample(int target, int samples, uint internalformat, int width, int height, byte fixedsamplelocations);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TexStorage3DMultisample(int target, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TextureView(uint texture, int target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindVertexBuffer(uint bindingindex, uint buffer, nint offset, int stride);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribFormat(uint attribindex, int size, uint type, byte normalized, uint relativeoffset);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexAttribBinding(uint attribindex, uint bindingindex);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexBindingDivisor(uint bindingindex, uint divisor);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DebugMessageControl(uint source, uint type, uint severity, int count, uint* ids, byte enabled);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void DebugMessageInsert(uint source, uint type, uint id, uint severity, int length, string buf);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetDebugMessageLog(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void PushDebugGroup(uint source, uint id, int length, string message);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void PopDebugGroup();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ObjectLabel(uint identifier, uint name, int length, string label);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetObjectLabel(uint identifier, uint name, int bufSize, int* length, char* label);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ObjectPtrLabel(void* ptr, int length, string label);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetObjectPtrLabel(void* ptr, int bufSize, int* length, char* label);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetPointerv(uint pname, void** param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void BufferStorage(int target, nint size, void* data, uint flags);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ClearTexImage(uint texture, int level, uint format, uint type, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void BindBuffersBase(int target, uint first, int count, uint* buffers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void BindBuffersRange(int target, uint first, int count, uint* buffers, nint* offsets, nint* sizes);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void BindTextures(uint first, int count, uint* textures);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void BindSamplers(uint first, int count, uint* samplers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void BindImageTextures(uint first, int count, uint* textures);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void BindVertexBuffers(uint first, int count, uint* buffers, nint* offsets, int* strides);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ClipControl(uint origin, uint depth);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CreateTransformFeedbacks(int n, uint* ids);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TransformFeedbackBufferBase(uint xfb, uint index, uint buffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, nint offset, nint size);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTransformFeedbackiv(uint xfb, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTransformFeedbacki_v(uint xfb, uint pname, uint index, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTransformFeedbacki64_v(uint xfb, uint pname, uint index, long* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CreateBuffers(int n, uint* buffers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void NamedBufferStorage(uint buffer, nint size, void* data, uint flags);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void NamedBufferData(uint buffer, nint size, void* data, uint usage);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void NamedBufferSubData(uint buffer, nint offset, nint size, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CopyNamedBufferSubData(uint readBuffer, uint writeBuffer, nint readOffset, nint writeOffset, nint size);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ClearNamedBufferSubData(uint buffer, uint internalformat, nint offset, nint size, uint format, uint type, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void MapNamedBuffer(uint buffer, uint access);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void MapNamedBufferRange(uint buffer, nint offset, nint length, uint access);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void UnmapNamedBuffer(uint buffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void FlushMappedNamedBufferRange(uint buffer, nint offset, nint length);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetNamedBufferParameteriv(uint buffer, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetNamedBufferParameteri64v(uint buffer, uint pname, long* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetNamedBufferPointerv(uint buffer, uint pname, void** param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetNamedBufferSubData(uint buffer, nint offset, nint size, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CreateFramebuffers(int n, uint* framebuffers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void NamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void NamedFramebufferParameteri(uint framebuffer, uint pname, int param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void NamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void NamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void NamedFramebufferDrawBuffer(uint framebuffer, uint buf);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void NamedFramebufferDrawBuffers(uint framebuffer, int n, uint* bufs);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void NamedFramebufferReadBuffer(uint framebuffer, uint src);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void InvalidateNamedFramebufferData(uint framebuffer, int numAttachments, uint* attachments);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void InvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, uint* attachments, int x, int y, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, int* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, uint* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, float* value);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void ClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CheckNamedFramebufferStatus(uint framebuffer, int target);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetNamedFramebufferParameteriv(uint framebuffer, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CreateRenderbuffers(int n, uint* renderbuffers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void NamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void NamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CreateTextures(int target, int n, uint* textures);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TextureBuffer(uint texture, uint internalformat, uint buffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TextureBufferRange(uint texture, uint internalformat, uint buffer, nint offset, nint size);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TextureStorage1D(uint texture, int levels, uint internalformat, int width);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TextureStorage2D(uint texture, int levels, uint internalformat, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, byte fixedsamplelocations);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, byte fixedsamplelocations);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void CopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TextureParameterf(uint texture, uint pname, float param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TextureParameterfv(uint texture, uint pname, float* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TextureParameteri(uint texture, uint pname, int param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TextureParameterIiv(uint texture, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TextureParameterIuiv(uint texture, uint pname, uint* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void TextureParameteriv(uint texture, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void GenerateTextureMipmap(uint texture);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void BindTextureUnit(uint unit, uint texture);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTextureImage(uint texture, int level, uint format, uint type, int bufSize, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetCompressedTextureImage(uint texture, int level, int bufSize, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTextureLevelParameterfv(uint texture, int level, uint pname, float* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTextureLevelParameteriv(uint texture, int level, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTextureParameterfv(uint texture, uint pname, float* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTextureParameterIiv(uint texture, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTextureParameterIuiv(uint texture, uint pname, uint* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTextureParameteriv(uint texture, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CreateVertexArrays(int n, uint* arrays);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void DisableVertexArrayAttrib(uint vaobj, uint index);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void EnableVertexArrayAttrib(uint vaobj, uint index);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexArrayElementBuffer(uint vaobj, uint buffer);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, nint offset, int stride);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void VertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, nint* offsets, int* strides);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, byte normalized, uint relativeoffset);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void VertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetVertexArrayiv(uint vaobj, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, long* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CreateSamplers(int n, uint* samplers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CreateProgramPipelines(int n, uint* pipelines);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void CreateQueries(int target, int n, uint* ids);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void GetQueryBufferObjecti64v(uint id, uint buffer, uint pname, nint offset);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void GetQueryBufferObjectiv(uint id, uint buffer, uint pname, nint offset);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void GetQueryBufferObjectui64v(uint id, uint buffer, uint pname, nint offset);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void GetQueryBufferObjectuiv(uint id, uint buffer, uint pname, nint offset);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void MemoryBarrierByRegion(uint barriers);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void GetGraphicsResetStatus();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnCompressedTexImage(int target, int lod, int bufSize, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnTexImage(int target, int level, uint format, uint type, int bufSize, void* pixels);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnUniformdv(uint program, int location, int bufSize, double* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnUniformfv(uint program, int location, int bufSize, float* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnUniformiv(uint program, int location, int bufSize, int* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnUniformuiv(uint program, int location, int bufSize, uint* param);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void ReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnMapdv(int target, uint query, int bufSize, double* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnMapfv(int target, uint query, int bufSize, float* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnMapiv(int target, uint query, int bufSize, int* v);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnPixelMapfv(uint map, int bufSize, float* values);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnPixelMapuiv(uint map, int bufSize, uint* values);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnPixelMapusv(uint map, int bufSize, ushort* values);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnPolygonStipple(int bufSize, byte* pattern);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnColorTable(int target, uint format, uint type, int bufSize, void* table);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnConvolutionFilter(int target, uint format, uint type, int bufSize, void* image);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnSeparableFilter(int target, uint format, uint type, int rowBufSize, void* row, int columnBufSize, void* column, void* span);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnHistogram(int target, byte reset, uint format, uint type, int bufSize, void* values);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void GetnMinmax(int target, byte reset, uint format, uint type, int bufSize, void* values);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void TextureBarrier();

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void SpecializeShader(uint shader, string pEntryPoint, uint numSpecializationConstants, uint* pConstantIndex, uint* pConstantValue);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void MultiDrawArraysIndirectCount(uint mode, void* indirect, nint drawcount, int maxdrawcount, int stride);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern unsafe void MultiDrawElementsIndirectCount(uint mode, uint type, void* indirect, nint drawcount, int maxdrawcount, int stride);

        [DllImport("EngineGL.dll", CallingConvention = CallingConvention.Cdecl)] public static extern void PolygonOffsetClamp(float factor, float units, float clamp);
    }
}