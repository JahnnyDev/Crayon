#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>

#define export __declspec(dllexport)
#define uint unsigned int
#define uchar unsigned char
#define ushort unsigned short
extern "C"
{
	export void CullFace(uint mode) {
		glCullFace(mode);
	}
	export void FrontFace(uint mode) {
		glFrontFace(mode);
	}
	export void Hint(uint target, uint mode) {
		glHint(target, mode);
	}
	export void LineWidth(float width) {
		glLineWidth(width);
	}
	export void PointSize(float size) {
		glPointSize(size);
	}
	export void PolygonMode(uint face, uint mode) {
		glPolygonMode(face, mode);
	}
	export void Scissor(int x, int y, int width, int height) {
		glScissor(x, y, width, height);
	}
	export void TexParameterf(uint target, uint pname, float param) {
		glTexParameterf(target, pname, param);
	}
	export void TexParameterfv(uint target, uint pname, const float* params) {
		glTexParameterfv(target, pname, params);
	}
	export void TexParameteri(uint target, uint pname, int param) {
		glTexParameteri(target, pname, param);
	}
	export void TexParameteriv(uint target, uint pname, const int* params) {
		glTexParameteriv(target, pname, params);
	}
	export void TexImage1D(uint target, int level, int internalformat, int width, int border, uint format, uint type, const void* pixels) {
		glTexImage1D(target, level, internalformat, width, border, format, type, pixels);
	}
	export void TexImage2D(uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, const void* pixels) {
		glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
	}
	export void DrawBuffer(uint buf) {
		glDrawBuffer(buf);
	}
	export void Clear(uint mask) {
		glClear(mask);
	}
	export void ClearColor(float red, float green, float blue, float alpha) {
		glClearColor(red, green, blue, alpha);
	}
	export void ClearStencil(int s) {
		glClearStencil(s);
	}
	export void ClearDepth(double depth) {
		glClearDepth(depth);
	}
	export void StencilMask(uint mask) {
		glStencilMask(mask);
	}
	export void ColorMask(uchar red, uchar green, uchar blue, uchar alpha) {
		glColorMask(red, green, blue, alpha);
	}
	export void DepthMask(uchar flag) {
		glDepthMask(flag);
	}
	export void Disable(int cap) {
		glDisable(cap);
	}
	export void Enable(int cap) {
		glEnable((GLenum)cap);
	}
	export void Finnish(void) {
		glFinish();
	}
	export void Flush(void) {
		glFlush();
	}
	export void BlendFunc(uint sfactor, uint dfactor) {
		glBlendFunc(sfactor, dfactor);
	}
	export void LogicOp(uint opcode) {
		glLogicOp(opcode);
	}
	export void StencilFunc(uint func, int ref, uint mask) {
		glStencilFunc(func, ref, mask);
	}
	export void StencilOp(uint fail, uint zfail, uint zpass) {
		glStencilOp(fail, zfail, zpass);
	}
	export void DepthFunc(uint func) {
		glDepthFunc(func);
	}
	export void PixelStoref(uint pname, float param) {
		glPixelStoref(pname, param);
	}
	export void PixelStorei(uint pname, int param) {
		glPixelStorei(pname, param);
	}
	export void ReadBuffer(uint src) {
		glReadBuffer(src);
	}
	export void ReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels) {
		glReadPixels(x, y, width, height, format, type, pixels);
	}
	export void GetBooleanv(uint pname, uchar* data) {
		glGetBooleanv(pname, data);
	}
	export void GetDoublev(uint pname, double* data) {
		glGetDoublev(pname, data);
	}
	export void GetError(void) {
		glGetError();
	}
	export void GetFloatv(uint pname, float* data) {
		glGetFloatv(pname, data);
	}
	export void GetIntegerv(uint pname, int* data) {
		glGetIntegerv(pname, data);
	}
	export void GetString(uint name) {
		glGetString(name);
	}
	export void GetTexImage(uint target, int level, uint format, uint type, void* pixels) {
		glGetTexImage(target, level, format, type, pixels);
	}
	export void GetTexParameterfv(uint target, uint pname, float* params) {
		glGetTexParameterfv(target, pname, params);
	}
	export void GetTexParameteriv(uint target, uint pname, int* params) {
		glGetTexParameteriv(target, pname, params);
	}
	export void GetTexLevelParameterfv(uint target, int level, uint pname, float* params) {
		glGetTexLevelParameterfv(target, level, pname, params);
	}
	export void GetTexLevelParameteriv(uint target, int level, uint pname, int* params) {
		glGetTexLevelParameteriv(target, level, pname, params);
	}
	export void IsEnabled(uint cap) {
		glIsEnabled(cap);
	}
	export void DepthRange(double n, double f) {
		glDepthRange(n, f);
	}
	export void Viewport(int x, int y, int width, int height) {
		glViewport(x, y, width, height);
	}
	export void DrawArrays(uint mode, int first, int count) {
		glDrawArrays(mode, first, count);
	}
	export void DrawElements(uint mode, int count, uint type, const void* indices) {
		glDrawElements(mode, count, type, indices);
	}
	export void PolygonOffset(float factor, float units) {
		glPolygonOffset(factor, units);
	}
	export void CopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border) {
		glCopyTexImage1D(target, level, internalformat, x, y, width, border);
	}
	export void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border) {
		glCopyTexImage2D(target, level, internalformat, x, y, width, height, border);
	}
	export void CopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width) {
		glCopyTexSubImage1D(target, level, xoffset, x, y, width);
	}
	export void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
		glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
	}
	export void TexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, const void* pixels) {
		glTexSubImage1D(target, level, xoffset, width, format, type, pixels);
	}
	export void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, const void* pixels) {
		glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
	}
	export void BindTexture(uint target, uint texture) {
		glBindTexture(target, texture);
	}
	export void DeleteTextures(int n, const uint* textures) {
		glDeleteTextures(n, textures);
	}
	export void GenTextures(int n, uint* textures) {
		glGenTextures(n, textures);
	}
	export void IsTexture(uint texture) {
		glIsTexture(texture);
	}
	export void DrawRangeElements(uint mode, uint start, uint end, int count, uint type, const void* indices) {
		glDrawRangeElements(mode, start, end, count, type, indices);
	}
	export void TexImage3D(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, const void* pixels) {
		glTexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
	}
	export void TexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, const void* pixels) {
		glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
	}
	export void CopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) {
		glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
	}
	export void ActiveTexture(uint texture) {
		glActiveTexture(texture);
	}
	export void SampleCoverage(float value, uchar invert) {
		glSampleCoverage(value, invert);
	}
	export void CompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, const void* data) {
		glCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
	}
	export void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, const void* data) {
		glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
	}
	export void CompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, const void* data) {
		glCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
	}
	export void CompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, const void* data) {
		glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
	}
	export void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, const void* data) {
		glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
	}
	export void CompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, const void* data) {
		glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
	}
	export void GetCompressedTexImage(uint target, int level, void* img) {
		glGetCompressedTexImage(target, level, img);
	}
	export void BlendFuncSeparate(uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha) {
		glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
	}
	export void MultiDrawArrays(uint mode, const int* first, const int* count, int drawcount) {
		glMultiDrawArrays(mode, first, count, drawcount);
	}
	export void MultiDrawElements(uint mode, const int* count, uint type, const void* const* indices, int drawcount) {
		glMultiDrawElements(mode, count, type, indices, drawcount);
	}
	export void PointParameterf(uint pname, float param) {
		glPointParameterf(pname, param);
	}
	export void PointParameterfv(uint pname, const float* params) {
		glPointParameterfv(pname, params);
	}
	export void PointParameteri(uint pname, int param) {
		glPointParameteri(pname, param);
	}
	export void PointParameteriv(uint pname, const int* params) {
		glPointParameteriv(pname, params);
	}
	export void BlendColor(float red, float green, float blue, float alpha) {
		glBlendColor(red, green, blue, alpha);
	}
	export void BlendEquation(uint mode) {
		glBlendEquation(mode);
	}
	export void GenQueries(int n, uint* ids) {
		glGenQueries(n, ids);
	}
	export void DeleteQueries(int n, const uint* ids) {
		glDeleteQueries(n, ids);
	}
	export void IsQuery(uint id) {
		glIsQuery(id);
	}
	export void BeginQuery(uint target, uint id) {
		glBeginQuery(target, id);
	}
	export void EndQuery(uint target) {
		glEndQuery(target);
	}
	export void GetQueryiv(uint target, uint pname, int* params) {
		glGetQueryiv(target, pname, params);
	}
	export void GetQueryObjectiv(uint id, uint pname, int* params) {
		glGetQueryObjectiv(id, pname, params);
	}
	export void GetQueryObjectuiv(uint id, uint pname, uint* params) {
		glGetQueryObjectuiv(id, pname, params);
	}
	export void BindBuffer(uint target, uint buffer) {
		glBindBuffer(target, buffer);
	}
	export void DeleteBuffers(int n, const uint* buffers) {
		glDeleteBuffers(n, buffers);
	}
	export void GenBuffers(int n, uint* buffers) {
		glGenBuffers(n, buffers);
	}
	export void IsBuffer(uint buffer) {
		glIsBuffer(buffer);
	}
	export void BufferData(uint target, intptr_t size, const void* data, uint usage) {
		glBufferData(target, size, data, usage);
	}
	export void BufferSubData(uint target, intptr_t offset, intptr_t size, const void* data) {
		glBufferSubData(target, offset, size, data);
	}
	export void GetBufferSubData(uint target, intptr_t offset, intptr_t size, void* data) {
		glGetBufferSubData(target, offset, size, data);
	}
	export void MapBuffer(uint target, uint access) {
		glMapBuffer(target, access);
	}
	export void UnmapBuffer(uint target) {
		glUnmapBuffer(target);
	}
	export void GetBufferParameteriv(uint target, uint pname, int* params) {
		glGetBufferParameteriv(target, pname, params);
	}
	export void GetBufferPointerv(uint target, uint pname, void** params) {
		glGetBufferPointerv(target, pname, params);
	}
	export void BlendEquationSeparate(uint modeRGB, uint modeAlpha) {
		glBlendEquationSeparate(modeRGB, modeAlpha);
	}
	export void DrawBuffers(int n, const uint* bufs) {
		glDrawBuffers(n, bufs);
	}
	export void StencilOpSeparate(uint face, uint sfail, uint dpfail, uint dppass) {
		glStencilOpSeparate(face, sfail, dpfail, dppass);
	}
	export void StencilFuncSeparate(uint face, uint func, int ref, uint mask) {
		glStencilFuncSeparate(face, func, ref, mask);
	}
	export void StencilMaskSeparate(uint face, uint mask) {
		glStencilMaskSeparate(face, mask);
	}
	export void AttachShader(uint program, uint shader) {
		glAttachShader(program, shader);
	}
	export void BindAttribLocation(uint program, uint index, const char* name) {
		glBindAttribLocation(program, index, name);
	}
	export void CompileShader(uint shader) {
		glCompileShader(shader);
	}

	export void DeleteShaderProgram(uint program) {
		glDeleteProgram(program);
	}
	export void DeleteShader(uint shader) {
		glDeleteShader(shader);
	}
	export void DetachShader(uint program, uint shader) {
		glDetachShader(program, shader);
	}
	export void DisableVertexAttribArray(uint index) {
		glDisableVertexAttribArray(index);
	}
	export void EnableVertexAttribArray(uint index) {
		glEnableVertexAttribArray(index);
	}
	export void GetActiveAttrib(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) {
		glGetActiveAttrib(program, index, bufSize, length, size, type, name);
	}
	export void GetActiveUniform(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) {
		glGetActiveUniform(program, index, bufSize, length, size, type, name);
	}
	export void GetAttachedShaders(uint program, int maxCount, int* count, uint* shaders) {
		glGetAttachedShaders(program, maxCount, count, shaders);
	}
	export void GetAttribLocation(uint program, const char* name) {
		glGetAttribLocation(program, name);
	}
	export void GetProgramiv(uint program, uint pname, int* params) {
		glGetProgramiv(program, pname, params);
	}
	export void GetProgramInfoLog(uint program, int bufSize, int* length, char* infoLog) {
		glGetProgramInfoLog(program, bufSize, length, infoLog);
	}
	export void GetShaderiv(uint shader, uint pname, int* params) {
		glGetShaderiv(shader, pname, params);
	}
	export void GetShaderInfoLog(uint shader, int bufSize, int* length, char* infoLog) {
		glGetShaderInfoLog(shader, bufSize, length, infoLog);
	}
	export void GetShaderSource(uint shader, int bufSize, int* length, char* source) {
		glGetShaderSource(shader, bufSize, length, source);
	}
	export void GetUniformLocation(uint program, const char* name) {
		glGetUniformLocation(program, name);
	}
	export void GetUniformfv(uint program, int location, float* params) {
		glGetUniformfv(program, location, params);
	}
	export void GetUniformiv(uint program, int location, int* params) {
		glGetUniformiv(program, location, params);
	}
	export void GetVertexAttribdv(uint index, uint pname, double* params) {
		glGetVertexAttribdv(index, pname, params);
	}
	export void GetVertexAttribfv(uint index, uint pname, float* params) {
		glGetVertexAttribfv(index, pname, params);
	}
	export void GetVertexAttribiv(uint index, uint pname, int* params) {
		glGetVertexAttribiv(index, pname, params);
	}
	export void GetVertexAttribPointerv(uint index, uint pname, void** pointer) {
		glGetVertexAttribPointerv(index, pname, pointer);
	}
	export void IsProgram(uint program) {
		glIsProgram(program);
	}
	export void IsShader(uint shader) {
		glIsShader(shader);
	}
	export void LinkProgram(uint program) {
		glLinkProgram(program);
	}
	export void UseProgram(uint program) {
		glUseProgram(program);
	}
	export void Uniform1f(int location, float v0) {
		glUniform1f(location, v0);
	}
	export void Uniform2f(int location, float v0, float v1) {
		glUniform2f(location, v0, v1);
	}
	export void Uniform3f(int location, float v0, float v1, float v2) {
		glUniform3f(location, v0, v1, v2);
	}
	export void Uniform4f(int location, float v0, float v1, float v2, float v3) {
		glUniform4f(location, v0, v1, v2, v3);
	}
	export void Uniform1i(int location, int v0) {
		glUniform1i(location, v0);
	}
	export void Uniform2i(int location, int v0, int v1) {
		glUniform2i(location, v0, v1);
	}
	export void Uniform3i(int location, int v0, int v1, int v2) {
		glUniform3i(location, v0, v1, v2);
	}
	export void Uniform4i(int location, int v0, int v1, int v2, int v3) {
		glUniform4i(location, v0, v1, v2, v3);
	}
	export void Uniform1fv(int location, int count, const float* value) {
		glUniform1fv(location, count, value);
	}
	export void Uniform2fv(int location, int count, const float* value) {
		glUniform2fv(location, count, value);
	}
	export void Uniform3fv(int location, int count, const float* value) {
		glUniform3fv(location, count, value);
	}
	export void Uniform4fv(int location, int count, const float* value) {
		glUniform4fv(location, count, value);
	}
	export void Uniform1iv(int location, int count, const int* value) {
		glUniform1iv(location, count, value);
	}
	export void Uniform2iv(int location, int count, const int* value) {
		glUniform2iv(location, count, value);
	}
	export void Uniform3iv(int location, int count, const int* value) {
		glUniform3iv(location, count, value);
	}
	export void Uniform4iv(int location, int count, const int* value) {
		glUniform4iv(location, count, value);
	}
	export void  UniformMat2fv(int location , const float* value) {
		glUniformMatrix2fv(location,  1, false, value);
	}
	export void  UniformMat3fv(int location , const float* value) {
		glUniformMatrix3fv(location,  1, false, value);
	}
	export void  UniformMat4fv(int location , const float* value) {
		glUniformMatrix4fv(location,  1, false, value);
	}
	export void ValidateProgram(uint program) {
		glValidateProgram(program);
	}
	export void VertexAttrib1d(uint index, double x) {
		glVertexAttrib1d(index, x);
	}
	export void VertexAttrib1dv(uint index, const double* v) {
		glVertexAttrib1dv(index, v);
	}
	export void VertexAttrib1f(uint index, float x) {
		glVertexAttrib1f(index, x);
	}
	export void VertexAttrib1fv(uint index, const float* v) {
		glVertexAttrib1fv(index, v);
	}
	export void VertexAttrib1s(uint index, short x) {
		glVertexAttrib1s(index, x);
	}
	export void VertexAttrib1sv(uint index, const short* v) {
		glVertexAttrib1sv(index, v);
	}
	export void VertexAttrib2d(uint index, double x, double y) {
		glVertexAttrib2d(index, x, y);
	}
	export void VertexAttrib2dv(uint index, const double* v) {
		glVertexAttrib2dv(index, v);
	}
	export void VertexAttrib2f(uint index, float x, float y) {
		glVertexAttrib2f(index, x, y);
	}
	export void VertexAttrib2fv(uint index, const float* v) {
		glVertexAttrib2fv(index, v);
	}
	export void VertexAttrib2s(uint index, short x, short y) {
		glVertexAttrib2s(index, x, y);
	}
	export void VertexAttrib2sv(uint index, const short* v) {
		glVertexAttrib2sv(index, v);
	}
	export void VertexAttrib3d(uint index, double x, double y, double z) {
		glVertexAttrib3d(index, x, y, z);
	}
	export void VertexAttrib3dv(uint index, const double* v) {
		glVertexAttrib3dv(index, v);
	}
	export void VertexAttrib3f(uint index, float x, float y, float z) {
		glVertexAttrib3f(index, x, y, z);
	}
	export void VertexAttrib3fv(uint index, const float* v) {
		glVertexAttrib3fv(index, v);
	}
	export void VertexAttrib3s(uint index, short x, short y, short z) {
		glVertexAttrib3s(index, x, y, z);
	}
	export void VertexAttrib3sv(uint index, const short* v) {
		glVertexAttrib3sv(index, v);
	}
	export void VertexAttrib4Nbv(uint index, intptr_t v) {
		glVertexAttrib4Nbv(index, (GLbyte*)v);
	}
	export void VertexAttrib4Niv(uint index, const int* v) {
		glVertexAttrib4Niv(index, v);
	}
	export void VertexAttrib4Nsv(uint index, const short* v) {
		glVertexAttrib4Nsv(index, v);
	}
	export void VertexAttrib4Nub(uint index, uchar  x, uchar  y, uchar  z, uchar  w) {
		glVertexAttrib4Nub(index, x, y, z, w);
	}
	export void VertexAttrib4Nubv(uint index, const uchar* v) {
		glVertexAttrib4Nubv(index, v);
	}
	export void VertexAttrib4Nuiv(uint index, const uint* v) {
		glVertexAttrib4Nuiv(index, v);
	}
	export void VertexAttrib4Nusv(uint index, const ushort* v) {
		glVertexAttrib4Nusv(index, v);
	}
	export void VertexAttrib4bv(uint index, intptr_t v) {
		glVertexAttrib4bv(index, (GLbyte*)v);
	}
	export void VertexAttrib4d(uint index, double x, double y, double z, double w) {
		glVertexAttrib4d(index, x, y, z, w);
	}
	export void VertexAttrib4dv(uint index, const double* v) {
		glVertexAttrib4dv(index, v);
	}
	export void VertexAttrib4f(uint index, float x, float y, float z, float w) {
		glVertexAttrib4f(index, x, y, z, w);
	}
	export void VertexAttrib4fv(uint index, const float* v) {
		glVertexAttrib4fv(index, v);
	}
	export void VertexAttrib4iv(uint index, const int* v) {
		glVertexAttrib4iv(index, v);
	}
	export void VertexAttrib4s(uint index, short x, short y, short z, short w) {
		glVertexAttrib4s(index, x, y, z, w);
	}
	export void VertexAttrib4sv(uint index, const short* v) {
		glVertexAttrib4sv(index, v);
	}
	export void VertexAttrib4ubv(uint index, const uchar* v) {
		glVertexAttrib4ubv(index, v);
	}
	export void VertexAttrib4uiv(uint index, const uint* v) {
		glVertexAttrib4uiv(index, v);
	}
	export void VertexAttrib4usv(uint index, const ushort* v) {
		glVertexAttrib4usv(index, v);
	}
	export void  UniformMat2x3fv(int location , const float* value) {
		glUniformMatrix2x3fv(location,  1, false, value);
	}
	export void  UniformMat3x2fv(int location , const float* value) {
		glUniformMatrix3x2fv(location,  1, false, value);
	}
	export void  UniformMat2x4fv(int location , const float* value) {
		glUniformMatrix2x4fv(location,  1, false, value);
	}
	export void  UniformMat4x2fv(int location , const float* value) {
		glUniformMatrix4x2fv(location,  1, false, value);
	}
	export void  UniformMat3x4fv(int location , const float* value) {
		glUniformMatrix3x4fv(location,  1, false, value);
	}
	export void  UniformMat4x3fv(int location , const float* value) {
		glUniformMatrix4x3fv(location,  1, false, value);
	}
	export void ColorMaski(uint index, uchar r, uchar g, uchar b, uchar a) {
		glColorMaski(index, r, g, b, a);
	}
	export void GetBooleani_v(uint target, uint index, uchar* data) {
		glGetBooleani_v(target, index, data);
	}
	export void GetIntegeri_v(uint target, uint index, int* data) {
		glGetIntegeri_v(target, index, data);
	}
	export void Enablei(uint target, uint index) {
		glEnablei(target, index);
	}
	export void Disablei(uint target, uint index) {
		glDisablei(target, index);
	}
	export void IsEnabledi(uint target, uint index) {
		glIsEnabledi(target, index);
	}
	export void BeginTransformFeedback(uint primitiveMode) {
		glBeginTransformFeedback(primitiveMode);
	}
	export void EndTransformFeedback(void) {
		glEndTransformFeedback();
	}
	export void BindBufferRange(uint target, uint index, uint buffer, intptr_t offset, intptr_t size) {
		glBindBufferRange(target, index, buffer, offset, size);
	}
	export void BindBufferBase(uint target, uint index, uint buffer) {
		glBindBufferBase(target, index, buffer);
	}
	export void TransformFeedbackVaryings(uint program, int count, const char* const* varyings, uint bufferMode) {
		glTransformFeedbackVaryings(program, count, varyings, bufferMode);
	}
	export void GetTransformFeedbackVarying(uint program, uint index, int bufSize, int* length, int* size, uint* type, char* name) {
		glGetTransformFeedbackVarying(program, index, bufSize, length, size, type, name);
	}
	export void ClampColor(uint target, uint clamp) {
		glClampColor(target, clamp);
	}
	export void BeginConditionalRender(uint id, uint mode) {
		glBeginConditionalRender(id, mode);
	}
	export void EndConditionalRender(void) {
		glEndConditionalRender();
	}
	export void VertexAttribIPointer(uint index, int size, uint type, int stride, const void* pointer) {
		glVertexAttribIPointer(index, size, type, stride, pointer);
	}
	export void GetVertexAttribIiv(uint index, uint pname, int* params) {
		glGetVertexAttribIiv(index, pname, params);
	}
	export void GetVertexAttribIuiv(uint index, uint pname, uint* params) {
		glGetVertexAttribIuiv(index, pname, params);
	}
	export void VertexAttribI1i(uint index, int x) {
		glVertexAttribI1i(index, x);
	}
	export void VertexAttribI2i(uint index, int x, int y) {
		glVertexAttribI2i(index, x, y);
	}
	export void VertexAttribI3i(uint index, int x, int y, int z) {
		glVertexAttribI3i(index, x, y, z);
	}
	export void VertexAttribI4i(uint index, int x, int y, int z, int w) {
		glVertexAttribI4i(index, x, y, z, w);
	}
	export void VertexAttribI1ui(uint index, uint x) {
		glVertexAttribI1ui(index, x);
	}
	export void VertexAttribI2ui(uint index, uint x, uint y) {
		glVertexAttribI2ui(index, x, y);
	}
	export void VertexAttribI3ui(uint index, uint x, uint y, uint z) {
		glVertexAttribI3ui(index, x, y, z);
	}
	export void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w) {
		glVertexAttribI4ui(index, x, y, z, w);
	}
	export void VertexAttribI1iv(uint index, const int* v) {
		glVertexAttribI1iv(index, v);
	}
	export void VertexAttribI2iv(uint index, const int* v) {
		glVertexAttribI2iv(index, v);
	}
	export void VertexAttribI3iv(uint index, const int* v) {
		glVertexAttribI3iv(index, v);
	}
	export void VertexAttribI4iv(uint index, const int* v) {
		glVertexAttribI4iv(index, v);
	}
	export void VertexAttribI1uiv(uint index, const uint* v) {
		glVertexAttribI1uiv(index, v);
	}
	export void VertexAttribI2uiv(uint index, const uint* v) {
		glVertexAttribI2uiv(index, v);
	}
	export void VertexAttribI3uiv(uint index, const uint* v) {
		glVertexAttribI3uiv(index, v);
	}
	export void VertexAttribI4uiv(uint index, const uint* v) {
		glVertexAttribI4uiv(index, v);
	}
	export void VertexAttribI4bv(uint index, intptr_t v) {
		glVertexAttribI4bv(index, (GLbyte*)v);
	}
	export void VertexAttribI4sv(uint index, const short* v) {
		glVertexAttribI4sv(index, v);
	}
	export void VertexAttribI4ubv(uint index, const uchar* v) {
		glVertexAttribI4ubv(index, v);
	}
	export void VertexAttribI4usv(uint index, const ushort* v) {
		glVertexAttribI4usv(index, v);
	}
	export void GetUniformuiv(uint program, int location, uint* params) {
		glGetUniformuiv(program, location, params);
	}
	export void BindFragDataLocation(uint program, uint color, const char* name) {
		glBindFragDataLocation(program, color, name);
	}
	export void GetFragDataLocation(uint program, const char* name) {
		glGetFragDataLocation(program, name);
	}
	export void Uniform1ui(int location, uint v0) {
		glUniform1ui(location, v0);
	}
	export void Uniform2ui(int location, uint v0, uint v1) {
		glUniform2ui(location, v0, v1);
	}
	export void Uniform3ui(int location, uint v0, uint v1, uint v2) {
		glUniform3ui(location, v0, v1, v2);
	}
	export void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3) {
		glUniform4ui(location, v0, v1, v2, v3);
	}
	export void Uniform1uiv(int location, int count, const uint* value) {
		glUniform1uiv(location, count, value);
	}
	export void Uniform2uiv(int location, int count, const uint* value) {
		glUniform2uiv(location, count, value);
	}
	export void Uniform3uiv(int location, int count, const uint* value) {
		glUniform3uiv(location, count, value);
	}
	export void Uniform4uiv(int location, int count, const uint* value) {
		glUniform4uiv(location, count, value);
	}
	export void TexParameterIiv(uint target, uint pname, const int* params) {
		glTexParameterIiv(target, pname, params);
	}
	export void TexParameterIuiv(uint target, uint pname, const uint* params) {
		glTexParameterIuiv(target, pname, params);
	}
	export void GetTexParameterIiv(uint target, uint pname, int* params) {
		glGetTexParameterIiv(target, pname, params);
	}
	export void GetTexParameterIuiv(uint target, uint pname, uint* params) {
		glGetTexParameterIuiv(target, pname, params);
	}
	export void ClearBufferiv(uint buffer, int drawbuffer, const int* value) {
		glClearBufferiv(buffer, drawbuffer, value);
	}
	export void ClearBufferuiv(uint buffer, int drawbuffer, const uint* value) {
		glClearBufferuiv(buffer, drawbuffer, value);
	}
	export void ClearBufferfv(uint buffer, int drawbuffer, const float* value) {
		glClearBufferfv(buffer, drawbuffer, value);
	}
	export void ClearBufferfi(uint buffer, int drawbuffer, float depth, int stencil) {
		glClearBufferfi(buffer, drawbuffer, depth, stencil);
	}
	export void GetStringi(uint name, uint index) {
		glGetStringi(name, index);
	}
	export void IsRenderbuffer(uint renderbuffer) {
		glIsRenderbuffer(renderbuffer);
	}
	export void BindRenderbuffer(uint target, uint renderbuffer) {
		glBindRenderbuffer(target, renderbuffer);
	}
	export void DeleteRenderbuffers(int n, const uint* renderbuffers) {
		glDeleteRenderbuffers(n, renderbuffers);
	}
	export void GenRenderbuffers(int n, uint* renderbuffers) {
		glGenRenderbuffers(n, renderbuffers);
	}
	export void RenderbufferStorage(uint target, uint internalformat, int width, int height) {
		glRenderbufferStorage(target, internalformat, width, height);
	}
	export void GetRenderbufferParameteriv(uint target, uint pname, int* params) {
		glGetRenderbufferParameteriv(target, pname, params);
	}
	export void IsFramebuffer(uint framebuffer) {
		glIsFramebuffer(framebuffer);
	}
	export void BindFramebuffer(uint target, uint framebuffer) {
		glBindFramebuffer(target, framebuffer);
	}
	export void DeleteFramebuffers(int n, const uint* framebuffers) {
		glDeleteFramebuffers(n, framebuffers);
	}
	export void GenFramebuffers(int n, uint* framebuffers) {
		glGenFramebuffers(n, framebuffers);
	}
	export void CheckFramebufferStatus(uint target) {
		glCheckFramebufferStatus(target);
	}
	export void FramebufferTexture1D(uint target, uint attachment, uint textarget, uint texture, int level) {
		glFramebufferTexture1D(target, attachment, textarget, texture, level);
	}
	export void FramebufferTexture2D(uint target, uint attachment, uint textarget, uint texture, int level) {
		glFramebufferTexture2D(target, attachment, textarget, texture, level);
	}
	export void FramebufferTexture3D(uint target, uint attachment, uint textarget, uint texture, int level, int zoffset) {
		glFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
	}
	export void FramebufferRenderbuffer(uint target, uint attachment, uint renderbuffertarget, uint renderbuffer) {
		glFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
	}
	export void GetFramebufferAttachmentParameteriv(uint target, uint attachment, uint pname, int* params) {
		glGetFramebufferAttachmentParameteriv(target, attachment, pname, params);
	}
	export void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) {
		glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
	}
	export void RenderbufferStorageMultisample(uint target, int samples, uint internalformat, int width, int height) {
		glRenderbufferStorageMultisample(target, samples, internalformat, width, height);
	}
	export void FramebufferTextureLayer(uint target, uint attachment, uint texture, int level, int layer) {
		glFramebufferTextureLayer(target, attachment, texture, level, layer);
	}
	export void MapBufferRange(uint target, intptr_t offset, intptr_t length, uint access) {
		glMapBufferRange(target, offset, length, access);
	}
	export void FlushMappedBufferRange(uint target, intptr_t offset, intptr_t length) {
		glFlushMappedBufferRange(target, offset, length);
	}
	export void BindVertexArray(uint array) {
		glBindVertexArray(array);
	}
	export void DeleteVertexArrays(int n, const uint* arrays) {
		glDeleteVertexArrays(n, arrays);
	}
	export void GenVertexArrays(int n, uint* arrays) {
		glGenVertexArrays(n, arrays);
	}
	export void IsVertexArray(uint array) {
		glIsVertexArray(array);
	}
	export void DrawArraysInstanced(uint mode, int first, int count, int instancecount) {
		glDrawArraysInstanced(mode, first, count, instancecount);
	}
	export void DrawElementsInstanced(uint mode, int count, uint type, const void* indices, int instancecount) {
		glDrawElementsInstanced(mode, count, type, indices, instancecount);
	}
	export void TexBuffer(uint target, uint internalformat, uint buffer) {
		glTexBuffer(target, internalformat, buffer);
	}
	export void PrimitiveRestartIndex(uint index) {
		glPrimitiveRestartIndex(index);
	}
	export void CopyBufferSubData(uint readTarget, uint writeTarget, intptr_t readOffset, intptr_t writeOffset, intptr_t size) {
		glCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
	}
	export void GetUniformIndices(uint program, int uniformCount, const char* const* uniformNames, uint* uniformIndices) {
		glGetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
	}
	export void GetActiveUniformsiv(uint program, int uniformCount, const uint* uniformIndices, uint pname, int* params) {
		glGetActiveUniformsiv(program, uniformCount, uniformIndices, pname, params);
	}
	export void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, int* length, char* uniformName) {
		glGetActiveUniformName(program, uniformIndex, bufSize, length, uniformName);
	}
	export void GetUniformBlockIndex(uint program, const char* uniformBlockName) {
		glGetUniformBlockIndex(program, uniformBlockName);
	}
	export void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, uint pname, int* params) {
		glGetActiveUniformBlockiv(program, uniformBlockIndex, pname, params);
	}
	export void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, int* length, char* uniformBlockName) {
		glGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, length, uniformBlockName);
	}
	export void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding) {
		glUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
	}
	export void DrawElementsBaseVertex(uint mode, int count, uint type, const void* indices, int basevertex) {
		glDrawElementsBaseVertex(mode, count, type, indices, basevertex);
	}
	export void DrawRangeElementsBaseVertex(uint mode, uint start, uint end, int count, uint type, const void* indices, int basevertex) {
		glDrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
	}
	export void DrawElementsInstancedBaseVertex(uint mode, int count, uint type, const void* indices, int instancecount, int basevertex) {
		glDrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
	}
	export void MultiDrawElementsBaseVertex(uint mode, const int* count, uint type, const void* const* indices, int drawcount, const int* basevertex) {
		glMultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, basevertex);
	}
	export void ProvokingVertex(uint mode) {
		glProvokingVertex(mode);
	}
	export void FenceSync(uint condition, uint flags) {
		glFenceSync(condition, flags);
	}
	export void IsSync(intptr_t sync) {
		glIsSync((GLsync)sync);
	}
	export void DeleteSync(intptr_t sync) {
		glDeleteSync((GLsync)sync);
	}
	export void ClientWaitSync(intptr_t sync, uint flags, long timeout) {
		glClientWaitSync((GLsync)sync, flags, timeout);
	}
	export void WaitSync(intptr_t sync, uint flags, long timeout) {
		glWaitSync((GLsync)sync, flags,  timeout);
	}
	export void GetInteger64v(uint pname, long* data) {
		glGetInteger64v(pname,  (GLint64*)data);
	}
	export void GetSynciv(intptr_t sync, uint pname, int count, int* length, int* values) {
		glGetSynciv((GLsync)sync, pname, count, length, values);
	}
	export void GetInteger64i_v(uint target, uint index, long* data) {
		glGetInteger64i_v(target, index, (GLint64*)data);
	}
	export void GetBufferParameteri64v(uint target, uint pname, long* params) {
		glGetBufferParameteri64v(target, pname, (GLint64*)params);
	}
	export void FramebufferTexture(uint target, uint attachment, uint texture, int level) {
		glFramebufferTexture(target, attachment, texture, level);
	}
	export void TexImage2DMultisample(uint target, int samples, uint internalformat, int width, int height, uchar fixedsamplelocations) {
		glTexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
	}
	export void TexImage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, uchar fixedsamplelocations) {
		glTexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
	}
	export void GetMultisamplefv(uint pname, uint index, float* val) {
		glGetMultisamplefv(pname, index, val);
	}
	export void SampleMaski(uint maskNumber, uint mask) {
		glSampleMaski(maskNumber, mask);
	}
	export void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, const char* name) {
		glBindFragDataLocationIndexed(program, colorNumber, index, name);
	}
	export void GetFragDataIndex(uint program, const char* name) {
		glGetFragDataIndex(program, name);
	}
	export void GenSamplers(int count, uint* samplers) {
		glGenSamplers(count, samplers);
	}
	export void DeleteSamplers(int count, const uint* samplers) {
		glDeleteSamplers(count, samplers);
	}
	export void IsSampler(uint sampler) {
		glIsSampler(sampler);
	}
	export void BindSampler(uint unit, uint sampler) {
		glBindSampler(unit, sampler);
	}
	export void SamplerParameteri(uint sampler, uint pname, int param) {
		glSamplerParameteri(sampler, pname, param);
	}
	export void SamplerParameteriv(uint sampler, uint pname, const int* param) {
		glSamplerParameteriv(sampler, pname, param);
	}
	export void SamplerParameterf(uint sampler, uint pname, float param) {
		glSamplerParameterf(sampler, pname, param);
	}
	export void SamplerParameterfv(uint sampler, uint pname, const float* param) {
		glSamplerParameterfv(sampler, pname, param);
	}
	export void SamplerParameterIiv(uint sampler, uint pname, const int* param) {
		glSamplerParameterIiv(sampler, pname, param);
	}
	export void SamplerParameterIuiv(uint sampler, uint pname, const uint* param) {
		glSamplerParameterIuiv(sampler, pname, param);
	}
	export void GetSamplerParameteriv(uint sampler, uint pname, int* params) {
		glGetSamplerParameteriv(sampler, pname, params);
	}
	export void GetSamplerParameterIiv(uint sampler, uint pname, int* params) {
		glGetSamplerParameterIiv(sampler, pname, params);
	}
	export void GetSamplerParameterfv(uint sampler, uint pname, float* params) {
		glGetSamplerParameterfv(sampler, pname, params);
	}
	export void GetSamplerParameterIuiv(uint sampler, uint pname, uint* params) {
		glGetSamplerParameterIuiv(sampler, pname, params);
	}
	export void QueryCounter(uint id, uint target) {
		glQueryCounter(id, target);
	}
	export void GetQueryObjecti64v(uint id, uint pname, long* params) {
		glGetQueryObjecti64v(id, pname, (GLint64*)params);
	}
	export void GetQueryObjectui64v(uint id, uint pname, unsigned long* params) {
		glGetQueryObjectui64v(id, pname, (GLuint64*)params);
	}
	export void VertexAttribDivisor(uint index, uint divisor) {
		glVertexAttribDivisor(index, divisor);
	}
	export void VertexAttribP1ui(uint index, uint type, uchar normalized, uint value) {
		glVertexAttribP1ui(index, type, normalized, value);
	}
	export void VertexAttribP1uiv(uint index, uint type, uchar normalized, const uint* value) {
		glVertexAttribP1uiv(index, type, normalized, value);
	}
	export void VertexAttribP2ui(uint index, uint type, uchar normalized, uint value) {
		glVertexAttribP2ui(index, type, normalized, value);
	}
	export void VertexAttribP2uiv(uint index, uint type, uchar normalized, const uint* value) {
		glVertexAttribP2uiv(index, type, normalized, value);
	}
	export void VertexAttribP3ui(uint index, uint type, uchar normalized, uint value) {
		glVertexAttribP3ui(index, type, normalized, value);
	}
	export void VertexAttribP3uiv(uint index, uint type, uchar normalized, const uint* value) {
		glVertexAttribP3uiv(index, type, normalized, value);
	}
	export void VertexAttribP4ui(uint index, uint type, uchar normalized, uint value) {
		glVertexAttribP4ui(index, type, normalized, value);
	}
	export void VertexAttribP4uiv(uint index, uint type, uchar normalized, const uint* value) {
		glVertexAttribP4uiv(index, type, normalized, value);
	}
	export void VertexP2ui(uint type, uint value) {
		glVertexP2ui(type, value);
	}
	export void VertexP2uiv(uint type, const uint* value) {
		glVertexP2uiv(type, value);
	}
	export void VertexP3ui(uint type, uint value) {
		glVertexP3ui(type, value);
	}
	export void VertexP3uiv(uint type, const uint* value) {
		glVertexP3uiv(type, value);
	}
	export void VertexP4ui(uint type, uint value) {
		glVertexP4ui(type, value);
	}
	export void VertexP4uiv(uint type, const uint* value) {
		glVertexP4uiv(type, value);
	}
	export void TexCoordP1ui(uint type, uint coords) {
		glTexCoordP1ui(type, coords);
	}
	export void TexCoordP1uiv(uint type, const uint* coords) {
		glTexCoordP1uiv(type, coords);
	}
	export void TexCoordP2ui(uint type, uint coords) {
		glTexCoordP2ui(type, coords);
	}
	export void TexCoordP2uiv(uint type, const uint* coords) {
		glTexCoordP2uiv(type, coords);
	}
	export void TexCoordP3ui(uint type, uint coords) {
		glTexCoordP3ui(type, coords);
	}
	export void TexCoordP3uiv(uint type, const uint* coords) {
		glTexCoordP3uiv(type, coords);
	}
	export void TexCoordP4ui(uint type, uint coords) {
		glTexCoordP4ui(type, coords);
	}
	export void TexCoordP4uiv(uint type, const uint* coords) {
		glTexCoordP4uiv(type, coords);
	}
	export void MultiTexCoordP1ui(uint texture, uint type, uint coords) {
		glMultiTexCoordP1ui(texture, type, coords);
	}
	export void MultiTexCoordP1uiv(uint texture, uint type, const uint* coords) {
		glMultiTexCoordP1uiv(texture, type, coords);
	}
	export void MultiTexCoordP2ui(uint texture, uint type, uint coords) {
		glMultiTexCoordP2ui(texture, type, coords);
	}
	export void MultiTexCoordP2uiv(uint texture, uint type, const uint* coords) {
		glMultiTexCoordP2uiv(texture, type, coords);
	}
	export void MultiTexCoordP3ui(uint texture, uint type, uint coords) {
		glMultiTexCoordP3ui(texture, type, coords);
	}
	export void MultiTexCoordP3uiv(uint texture, uint type, const uint* coords) {
		glMultiTexCoordP3uiv(texture, type, coords);
	}
	export void MultiTexCoordP4ui(uint texture, uint type, uint coords) {
		glMultiTexCoordP4ui(texture, type, coords);
	}
	export void MultiTexCoordP4uiv(uint texture, uint type, const uint* coords) {
		glMultiTexCoordP4uiv(texture, type, coords);
	}
	export void NormalP3ui(uint type, uint coords) {
		glNormalP3ui(type, coords);
	}
	export void NormalP3uiv(uint type, const uint* coords) {
		glNormalP3uiv(type, coords);
	}
	export void ColorP3ui(uint type, uint color) {
		glColorP3ui(type, color);
	}
	export void ColorP3uiv(uint type, const uint* color) {
		glColorP3uiv(type, color);
	}
	export void ColorP4ui(uint type, uint color) {
		glColorP4ui(type, color);
	}
	export void ColorP4uiv(uint type, const uint* color) {
		glColorP4uiv(type, color);
	}
	export void SecondaryColorP3ui(uint type, uint color) {
		glSecondaryColorP3ui(type, color);
	}
	export void SecondaryColorP3uiv(uint type, const uint* color) {
		glSecondaryColorP3uiv(type, color);
	}
	export void MinSampleShading(float value) {
		glMinSampleShading(value);
	}
	export void BlendEquationi(uint buf, uint mode) {
		glBlendEquationi(buf, mode);
	}
	export void BlendEquationSeparatei(uint buf, uint modeRGB, uint modeAlpha) {
		glBlendEquationSeparatei(buf, modeRGB, modeAlpha);
	}
	export void BlendFunci(uint buf, uint src, uint dst) {
		glBlendFunci(buf, src, dst);
	}
	export void BlendFuncSeparatei(uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha) {
		glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
	}
	export void DrawArraysIndirect(uint mode, const void* indirect) {
		glDrawArraysIndirect(mode, indirect);
	}
	export void DrawElementsIndirect(uint mode, uint type, const void* indirect) {
		glDrawElementsIndirect(mode, type, indirect);
	}
	export void Uniform1d(int location, double x) {
		glUniform1d(location, x);
	}
	export void Uniform2d(int location, double x, double y) {
		glUniform2d(location, x, y);
	}
	export void Uniform3d(int location, double x, double y, double z) {
		glUniform3d(location, x, y, z);
	}
	export void Uniform4d(int location, double x, double y, double z, double w) {
		glUniform4d(location, x, y, z, w);
	}
	export void Uniform1dv(int location, int count, const double* value) {
		glUniform1dv(location, count, value);
	}
	export void Uniform2dv(int location, int count, const double* value) {
		glUniform2dv(location, count, value);
	}
	export void Uniform3dv(int location, int count, const double* value) {
		glUniform3dv(location, count, value);
	}
	export void Uniform4dv(int location, int count, const double* value) {
		glUniform4dv(location, count, value);
	}
	export void  UniformMat2dv(int location , const double* value) {
		glUniformMatrix2dv(location,  1, false, value);
	}
	export void  UniformMat3dv(int location , const double* value) {
		glUniformMatrix3dv(location,  1, false, value);
	}
	export void  UniformMat4dv(int location , const double* value) {
		glUniformMatrix4dv(location,  1, false, value);
	}
	export void  UniformMat2x3dv(int location , const double* value) {
		glUniformMatrix2x3dv(location,  1, false, value);
	}
	export void  UniformMat2x4dv(int location , const double* value) {
		glUniformMatrix2x4dv(location,  1, false, value);
	}
	export void  UniformMat3x2dv(int location , const double* value) {
		glUniformMatrix3x2dv(location,  1, false, value);
	}
	export void  UniformMat3x4dv(int location , const double* value) {
		glUniformMatrix3x4dv(location,  1, false, value);
	}
	export void  UniformMat4x2dv(int location , const double* value) {
		glUniformMatrix4x2dv(location,  1, false, value);
	}
	export void  UniformMat4x3dv(int location , const double* value) {
		glUniformMatrix4x3dv(location,  1, false, value);
	}
	export void GetUniformdv(uint program, int location, double* params) {
		glGetUniformdv(program, location, params);
	}
	export void GetSubroutineUniformLocation(uint program, uint shadertype, const char* name) {
		glGetSubroutineUniformLocation(program, shadertype, name);
	}
	export void GetSubroutineIndex(uint program, uint shadertype, const char* name) {
		glGetSubroutineIndex(program, shadertype, name);
	}
	export void GetActiveSubroutineUniformiv(uint program, uint shadertype, uint index, uint pname, int* values) {
		glGetActiveSubroutineUniformiv(program, shadertype, index, pname, values);
	}
	export void GetActiveSubroutineUniformName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name) {
		glGetActiveSubroutineUniformName(program, shadertype, index, bufSize, length, name);
	}
	export void GetActiveSubroutineName(uint program, uint shadertype, uint index, int bufSize, int* length, char* name) {
		glGetActiveSubroutineName(program, shadertype, index, bufSize, length, name);
	}
	export void UniformSubroutinesuiv(uint shadertype, int count, const uint* indices) {
		glUniformSubroutinesuiv(shadertype, count, indices);
	}
	export void GetUniformSubroutineuiv(uint shadertype, int location, uint* params) {
		glGetUniformSubroutineuiv(shadertype, location, params);
	}
	export void GetProgramStageiv(uint program, uint shadertype, uint pname, int* values) {
		glGetProgramStageiv(program, shadertype, pname, values);
	}
	export void PatchParameteri(uint pname, int value) {
		glPatchParameteri(pname, value);
	}
	export void PatchParameterfv(uint pname, const float* values) {
		glPatchParameterfv(pname, values);
	}
	export void BindTransformFeedback(uint target, uint id) {
		glBindTransformFeedback(target, id);
	}
	export void DeleteTransformFeedbacks(int n, const uint* ids) {
		glDeleteTransformFeedbacks(n, ids);
	}
	export void GenTransformFeedbacks(int n, uint* ids) {
		glGenTransformFeedbacks(n, ids);
	}
	export void IsTransformFeedback(uint id) {
		glIsTransformFeedback(id);
	}
	export void PauseTransformFeedback(void) {
		glPauseTransformFeedback();
	}
	export void ResumeTransformFeedback(void) {
		glResumeTransformFeedback();
	}
	export void DrawTransformFeedback(uint mode, uint id) {
		glDrawTransformFeedback(mode, id);
	}
	export void DrawTransformFeedbackStream(uint mode, uint id, uint stream) {
		glDrawTransformFeedbackStream(mode, id, stream);
	}
	export void BeginQueryIndexed(uint target, uint index, uint id) {
		glBeginQueryIndexed(target, index, id);
	}
	export void EndQueryIndexed(uint target, uint index) {
		glEndQueryIndexed(target, index);
	}
	export void GetQueryIndexediv(uint target, uint index, uint pname, int* params) {
		glGetQueryIndexediv(target, index, pname, params);
	}
	export void ReleaseShaderCompiler(void) {
		glReleaseShaderCompiler();
	}
	export void ShaderBinary(int count, const uint* shaders, uint binaryFormat, const void* binary, int length) {
		glShaderBinary(count, shaders, binaryFormat, binary, length);
	}
	export void GetShaderPrecisionFormat(uint shadertype, uint precisiontype, int* range, int* precision) {
		glGetShaderPrecisionFormat(shadertype, precisiontype, range, precision);
	}
	export void DepthRangef(float n, float f) {
		glDepthRangef(n, f);
	}
	export void ClearDepthf(float d) {
		glClearDepthf(d);
	}
	export void GetProgramBinary(uint program, int bufSize, int* length, uint* binaryFormat, void* binary) {
		glGetProgramBinary(program, bufSize, length, binaryFormat, binary);
	}
	export void ProgramBinary(uint program, uint binaryFormat, const void* binary, int length) {
		glProgramBinary(program, binaryFormat, binary, length);
	}
	export void ProgramParameteri(uint program, uint pname, int value) {
		glProgramParameteri(program, pname, value);
	}
	export void UseProgramStages(uint pipeline, uint stages, uint program) {
		glUseProgramStages(pipeline, stages, program);
	}
	export void ActiveShaderProgram(uint pipeline, uint program) {
		glActiveShaderProgram(pipeline, program);
	}
	export void CreateShaderProgramv(uint type, int count, const char* const* strings) {
		glCreateShaderProgramv(type, count, strings);
	}
	export void BindProgramPipeline(uint pipeline) {
		glBindProgramPipeline(pipeline);
	}
	export void DeleteProgramPipelines(int n, const uint* pipelines) {
		glDeleteProgramPipelines(n, pipelines);
	}
	export void GenProgramPipelines(int n, uint* pipelines) {
		glGenProgramPipelines(n, pipelines);
	}
	export void IsProgramPipeline(uint pipeline) {
		glIsProgramPipeline(pipeline);
	}
	export void GetProgramPipelineiv(uint pipeline, uint pname, int* params) {
		glGetProgramPipelineiv(pipeline, pname, params);
	}
	export void ProgramUniform1i(uint program, int location, int v0) {
		glProgramUniform1i(program, location, v0);
	}
	export void ProgramUniform1iv(uint program, int location, int count, const int* value) {
		glProgramUniform1iv(program, location, count, value);
	}
	export void ProgramUniform1f(uint program, int location, float v0) {
		glProgramUniform1f(program, location, v0);
	}
	export void ProgramUniform1fv(uint program, int location, int count, const float* value) {
		glProgramUniform1fv(program, location, count, value);
	}
	export void ProgramUniform1d(uint program, int location, double v0) {
		glProgramUniform1d(program, location, v0);
	}
	export void ProgramUniform1dv(uint program, int location, int count, const double* value) {
		glProgramUniform1dv(program, location, count, value);
	}
	export void ProgramUniform1ui(uint program, int location, uint v0) {
		glProgramUniform1ui(program, location, v0);
	}
	export void ProgramUniform1uiv(uint program, int location, int count, const uint* value) {
		glProgramUniform1uiv(program, location, count, value);
	}
	export void ProgramUniform2i(uint program, int location, int v0, int v1) {
		glProgramUniform2i(program, location, v0, v1);
	}
	export void ProgramUniform2iv(uint program, int location, int count, const int* value) {
		glProgramUniform2iv(program, location, count, value);
	}
	export void ProgramUniform2f(uint program, int location, float v0, float v1) {
		glProgramUniform2f(program, location, v0, v1);
	}
	export void ProgramUniform2fv(uint program, int location, int count, const float* value) {
		glProgramUniform2fv(program, location, count, value);
	}
	export void ProgramUniform2d(uint program, int location, double v0, double v1) {
		glProgramUniform2d(program, location, v0, v1);
	}
	export void ProgramUniform2dv(uint program, int location, int count, const double* value) {
		glProgramUniform2dv(program, location, count, value);
	}
	export void ProgramUniform2ui(uint program, int location, uint v0, uint v1) {
		glProgramUniform2ui(program, location, v0, v1);
	}
	export void ProgramUniform2uiv(uint program, int location, int count, const uint* value) {
		glProgramUniform2uiv(program, location, count, value);
	}
	export void ProgramUniform3i(uint program, int location, int v0, int v1, int v2) {
		glProgramUniform3i(program, location, v0, v1, v2);
	}
	export void ProgramUniform3iv(uint program, int location, int count, const int* value) {
		glProgramUniform3iv(program, location, count, value);
	}
	export void ProgramUniform3f(uint program, int location, float v0, float v1, float v2) {
		glProgramUniform3f(program, location, v0, v1, v2);
	}
	export void ProgramUniform3fv(uint program, int location, int count, const float* value) {
		glProgramUniform3fv(program, location, count, value);
	}
	export void ProgramUniform3d(uint program, int location, double v0, double v1, double v2) {
		glProgramUniform3d(program, location, v0, v1, v2);
	}
	export void ProgramUniform3dv(uint program, int location, int count, const double* value) {
		glProgramUniform3dv(program, location, count, value);
	}
	export void ProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2) {
		glProgramUniform3ui(program, location, v0, v1, v2);
	}
	export void ProgramUniform3uiv(uint program, int location, int count, const uint* value) {
		glProgramUniform3uiv(program, location, count, value);
	}
	export void ProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3) {
		glProgramUniform4i(program, location, v0, v1, v2, v3);
	}
	export void ProgramUniform4iv(uint program, int location, int count, const int* value) {
		glProgramUniform4iv(program, location, count, value);
	}
	export void ProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3) {
		glProgramUniform4f(program, location, v0, v1, v2, v3);
	}
	export void ProgramUniform4fv(uint program, int location, int count, const float* value) {
		glProgramUniform4fv(program, location, count, value);
	}
	export void ProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3) {
		glProgramUniform4d(program, location, v0, v1, v2, v3);
	}
	export void ProgramUniform4dv(uint program, int location, int count, const double* value) {
		glProgramUniform4dv(program, location, count, value);
	}
	export void ProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3) {
		glProgramUniform4ui(program, location, v0, v1, v2, v3);
	}
	export void ProgramUniform4uiv(uint program, int location, int count, const uint* value) {
		glProgramUniform4uiv(program, location, count, value);
	}
	export void ProgramUniformMatrix2fv(uint program, int location , const float* value) {
		glProgramUniformMatrix2fv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix3fv(uint program, int location , const float* value) {
		glProgramUniformMatrix3fv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix4fv(uint program, int location , const float* value) {
		glProgramUniformMatrix4fv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix2dv(uint program, int location , const double* value) {
		glProgramUniformMatrix2dv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix3dv(uint program, int location , const double* value) {
		glProgramUniformMatrix3dv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix4dv(uint program, int location , const double* value) {
		glProgramUniformMatrix4dv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix2x3fv(uint program, int location , const float* value) {
		glProgramUniformMatrix2x3fv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix3x2fv(uint program, int location , const float* value) {
		glProgramUniformMatrix3x2fv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix2x4fv(uint program, int location , const float* value) {
		glProgramUniformMatrix2x4fv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix4x2fv(uint program, int location , const float* value) {
		glProgramUniformMatrix4x2fv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix3x4fv(uint program, int location , const float* value) {
		glProgramUniformMatrix3x4fv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix4x3fv(uint program, int location , const float* value) {
		glProgramUniformMatrix4x3fv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix2x3dv(uint program, int location , const double* value) {
		glProgramUniformMatrix2x3dv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix3x2dv(uint program, int location , const double* value) {
		glProgramUniformMatrix3x2dv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix2x4dv(uint program, int location , const double* value) {
		glProgramUniformMatrix2x4dv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix4x2dv(uint program, int location , const double* value) {
		glProgramUniformMatrix4x2dv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix3x4dv(uint program, int location , const double* value) {
		glProgramUniformMatrix3x4dv(program, location,  1, false, value);
	}
	export void ProgramUniformMatrix4x3dv(uint program, int location , const double* value) {
		glProgramUniformMatrix4x3dv(program, location,  1, false, value);
	}
	export void ValidateProgramPipeline(uint pipeline) {
		glValidateProgramPipeline(pipeline);
	}
	export void GetProgramPipelineInfoLog(uint pipeline, int bufSize, int* length, char* infoLog) {
		glGetProgramPipelineInfoLog(pipeline, bufSize, length, infoLog);
	}
	export void VertexAttribL1d(uint index, double x) {
		glVertexAttribL1d(index, x);
	}
	export void VertexAttribL2d(uint index, double x, double y) {
		glVertexAttribL2d(index, x, y);
	}
	export void VertexAttribL3d(uint index, double x, double y, double z) {
		glVertexAttribL3d(index, x, y, z);
	}
	export void VertexAttribL4d(uint index, double x, double y, double z, double w) {
		glVertexAttribL4d(index, x, y, z, w);
	}
	export void VertexAttribL1dv(uint index, const double* v) {
		glVertexAttribL1dv(index, v);
	}
	export void VertexAttribL2dv(uint index, const double* v) {
		glVertexAttribL2dv(index, v);
	}
	export void VertexAttribL3dv(uint index, const double* v) {
		glVertexAttribL3dv(index, v);
	}
	export void VertexAttribL4dv(uint index, const double* v) {
		glVertexAttribL4dv(index, v);
	}
	export void VertexAttribLPointer(uint index, int size, uint type, int stride, const void* pointer) {
		glVertexAttribLPointer(index, size, type, stride, pointer);
	}
	export void GetVertexAttribLdv(uint index, uint pname, double* params) {
		glGetVertexAttribLdv(index, pname, params);
	}
	export void ViewportArrayv(uint first, int count, const float* v) {
		glViewportArrayv(first, count, v);
	}
	export void ViewportIndexedf(uint index, float x, float y, float w, float h) {
		glViewportIndexedf(index, x, y, w, h);
	}
	export void ViewportIndexedfv(uint index, const float* v) {
		glViewportIndexedfv(index, v);
	}
	export void ScissorArrayv(uint first, int count, const int* v) {
		glScissorArrayv(first, count, v);
	}
	export void ScissorIndexed(uint index, int left, int bottom, int width, int height) {
		glScissorIndexed(index, left, bottom, width, height);
	}
	export void ScissorIndexedv(uint index, const int* v) {
		glScissorIndexedv(index, v);
	}
	export void DepthRangeArrayv(uint first, int count, const double* v) {
		glDepthRangeArrayv(first, count, v);
	}
	export void DepthRangeIndexed(uint index, double n, double f) {
		glDepthRangeIndexed(index, n, f);
	}
	export void GetFloati_v(uint target, uint index, float* data) {
		glGetFloati_v(target, index, data);
	}
	export void GetDoublei_v(uint target, uint index, double* data) {
		glGetDoublei_v(target, index, data);
	}
	export void DrawArraysInstancedBaseInstance(uint mode, int first, int count, int instancecount, uint baseinstance) {
		glDrawArraysInstancedBaseInstance(mode, first, count, instancecount, baseinstance);
	}
	export void DrawElementsInstancedBaseInstance(uint mode, int count, uint type, const void* indices, int instancecount, uint baseinstance) {
		glDrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
	}
	export void DrawElementsInstancedBaseVertexBaseInstance(uint mode, int count, uint type, const void* indices, int instancecount, int basevertex, uint baseinstance) {
		glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
	}
	export void GetInternalformativ(uint target, uint internalformat, uint pname, int count, int* params) {
		glGetInternalformativ(target, internalformat, pname, count, params);
	}
	export void GetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, uint pname, int* params) {
		glGetActiveAtomicCounterBufferiv(program, bufferIndex, pname, params);
	}
	export void BindImageTexture(uint unit, uint texture, int level, uchar layered, int layer, uint access, uint format) {
		glBindImageTexture(unit, texture, level, layered, layer, access, format);
	}
	export void GetMemoryBarrier(uint barriers) {
		glMemoryBarrier(barriers);
	}
	export void TexStorage1D(uint target, int levels, uint internalformat, int width) {
		glTexStorage1D(target, levels, internalformat, width);
	}
	export void TexStorage2D(uint target, int levels, uint internalformat, int width, int height) {
		glTexStorage2D(target, levels, internalformat, width, height);
	}
	export void TexStorage3D(uint target, int levels, uint internalformat, int width, int height, int depth) {
		glTexStorage3D(target, levels, internalformat, width, height, depth);
	}
	export void DrawTransformFeedbackInstanced(uint mode, uint id, int instancecount) {
		glDrawTransformFeedbackInstanced(mode, id, instancecount);
	}
	export void DrawTransformFeedbackStreamInstanced(uint mode, uint id, uint stream, int instancecount) {
		glDrawTransformFeedbackStreamInstanced(mode, id, stream, instancecount);
	}
	export void ClearBufferData(uint target, uint internalformat, uint format, uint type, const void* data) {
		glClearBufferData(target, internalformat, format, type, data);
	}
	export void ClearBufferSubData(uint target, uint internalformat, intptr_t offset, intptr_t size, uint format, uint type, const void* data) {
		glClearBufferSubData(target, internalformat, offset, size, format, type, data);
	}
	export void DispatchCompute(uint num_groups_x, uint num_groups_y, uint num_groups_z) {
		glDispatchCompute(num_groups_x, num_groups_y, num_groups_z);
	}
	export void DispatchComputeIndirect(intptr_t indirect) {
		glDispatchComputeIndirect(indirect);
	}
	export void CopyImageSubData(uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth) {
		glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
	}
	export void FramebufferParameteri(uint target, uint pname, int param) {
		glFramebufferParameteri(target, pname, param);
	}
	export void GetFramebufferParameteriv(uint target, uint pname, int* params) {
		glGetFramebufferParameteriv(target, pname, params);
	}
	export void GetInternalformati64v(uint target, uint internalformat, uint pname, int count, long* params) {
		glGetInternalformati64v(target, internalformat, pname, count, (GLint64*)params);
	}
	export void InvalidateTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth) {
		glInvalidateTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth);
	}
	export void InvalidateTexImage(uint texture, int level) {
		glInvalidateTexImage(texture, level);
	}
	export void InvalidateBufferSubData(uint buffer, intptr_t offset, intptr_t length) {
		glInvalidateBufferSubData(buffer, offset, length);
	}
	export void InvalidateBufferData(uint buffer) {
		glInvalidateBufferData(buffer);
	}
	export void InvalidateFramebuffer(uint target, int numAttachments, const uint* attachments) {
		glInvalidateFramebuffer(target, numAttachments, attachments);
	}
	export void InvalidateSubFramebuffer(uint target, int numAttachments, const uint* attachments, int x, int y, int width, int height) {
		glInvalidateSubFramebuffer(target, numAttachments, attachments, x, y, width, height);
	}
	export void MultiDrawArraysIndirect(uint mode, const void* indirect, int drawcount, int stride) {
		glMultiDrawArraysIndirect(mode, indirect, drawcount, stride);
	}
	export void MultiDrawElementsIndirect(uint mode, uint type, const void* indirect, int drawcount, int stride) {
		glMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);
	}
	export void GetProgramInterfaceiv(uint program, uint programInterface, uint pname, int* params) {
		glGetProgramInterfaceiv(program, programInterface, pname, params);
	}
	export void GetProgramResourceIndex(uint program, uint programInterface, const char* name) {
		glGetProgramResourceIndex(program, programInterface, name);
	}
	export void GetProgramResourceName(uint program, uint programInterface, uint index, int bufSize, int* length, char* name) {
		glGetProgramResourceName(program, programInterface, index, bufSize, length, name);
	}
	export void GetProgramResourceiv(uint program, uint programInterface, uint index, int propCount, const uint* props, int count, int* length, int* params) {
		glGetProgramResourceiv(program, programInterface, index, propCount, props, count, length, params);
	}
	export void GetProgramResourceLocation(uint program, uint programInterface, const char* name) {
		glGetProgramResourceLocation(program, programInterface, name);
	}
	export void GetProgramResourceLocationIndex(uint program, uint programInterface, const char* name) {
		glGetProgramResourceLocationIndex(program, programInterface, name);
	}
	export void ShaderStorageBlockBinding(uint program, uint storageBlockIndex, uint storageBlockBinding) {
		glShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);
	}
	export void TexBufferRange(uint target, uint internalformat, uint buffer, intptr_t offset, intptr_t size) {
		glTexBufferRange(target, internalformat, buffer, offset, size);
	}
	export void TexStorage2DMultisample(uint target, int samples, uint internalformat, int width, int height, uchar fixedsamplelocations) {
		glTexStorage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
	}
	export void TexStorage3DMultisample(uint target, int samples, uint internalformat, int width, int height, int depth, uchar fixedsamplelocations) {
		glTexStorage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
	}
	export void TextureView(uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers) {
		glTextureView(texture, target, origtexture, internalformat, minlevel, numlevels, minlayer, numlayers);
	}
	export void BindVertexBuffer(uint bindingindex, uint buffer, intptr_t offset, int stride) {
		glBindVertexBuffer(bindingindex, buffer, offset, stride);
	}
	export void VertexAttribFormat(uint attribindex, int size, uint type, uchar normalized, uint relativeoffset) {
		glVertexAttribFormat(attribindex, size, type, normalized, relativeoffset);
	}
	export void VertexAttribIFormat(uint attribindex, int size, uint type, uint relativeoffset) {
		glVertexAttribIFormat(attribindex, size, type, relativeoffset);
	}
	export void VertexAttribLFormat(uint attribindex, int size, uint type, uint relativeoffset) {
		glVertexAttribLFormat(attribindex, size, type, relativeoffset);
	}
	export void VertexAttribBinding(uint attribindex, uint bindingindex) {
		glVertexAttribBinding(attribindex, bindingindex);
	}
	export void VertexBindingDivisor(uint bindingindex, uint divisor) {
		glVertexBindingDivisor(bindingindex, divisor);
	}
	export void DebugMessageControl(uint source, uint type, uint severity, int count, const uint* ids, uchar enabled) {
		glDebugMessageControl(source, type, severity, count, ids, enabled);
	}
	export void DebugMessageInsert(uint source, uint type, uint id, uint severity, int length, const char* buf) {
		glDebugMessageInsert(source, type, id, severity, length, buf);
	}
	export void GetDebugMessageLog(uint count, int bufSize, uint* sources, uint* types, uint* ids, uint* severities, int* lengths, char* messageLog) {
		glGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);
	}
	export void PushDebugGroup(uint source, uint id, int length, const char* message) {
		glPushDebugGroup(source, id, length, message);
	}
	export void PopDebugGroup(void) {
		glPopDebugGroup();
	}
	export void ObjectLabel(uint identifier, uint name, int length, const char* label) {
		glObjectLabel(identifier, name, length, label);
	}
	export void GetObjectLabel(uint identifier, uint name, int bufSize, int* length, char* label) {
		glGetObjectLabel(identifier, name, bufSize, length, label);
	}
	export void ObjectPtrLabel(const void* ptr, int length, const char* label) {
		glObjectPtrLabel(ptr, length, label);
	}
	export void GetObjectPtrLabel(const void* ptr, int bufSize, int* length, char* label) {
		glGetObjectPtrLabel(ptr, bufSize, length, label);
	}
	export void GetPointerv(uint pname, void** params) {
		glGetPointerv(pname, params);
	}
	export void BufferStorage(uint target, intptr_t size, const void* data, uint flags) {
		glBufferStorage(target, size, data, flags);
	}
	export void ClearTexImage(uint texture, int level, uint format, uint type, const void* data) {
		glClearTexImage(texture, level, format, type, data);
	}
	export void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, const void* data) {
		glClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
	}
	export void BindBuffersBase(uint target, uint first, int count, const uint* buffers) {
		glBindBuffersBase(target, first, count, buffers);
	}
	export void BindBuffersRange(uint target, uint first, int count, const uint* buffers, const intptr_t* offsets, const intptr_t* sizes) {
		glBindBuffersRange(target, first, count, buffers, offsets, sizes);
	}
	export void BindTextures(uint first, int count, const uint* textures) {
		glBindTextures(first, count, textures);
	}
	export void BindSamplers(uint first, int count, const uint* samplers) {
		glBindSamplers(first, count, samplers);
	}
	export void BindImageTextures(uint first, int count, const uint* textures) {
		glBindImageTextures(first, count, textures);
	}
	export void BindVertexBuffers(uint first, int count, const uint* buffers, const intptr_t* offsets, const int* strides) {
		glBindVertexBuffers(first, count, buffers, offsets, strides);
	}
	export void ClipControl(uint origin, uint depth) {
		glClipControl(origin, depth);
	}
	export void CreateTransformFeedbacks(int n, uint* ids) {
		glCreateTransformFeedbacks(n, ids);
	}
	export void TransformFeedbackBufferBase(uint xfb, uint index, uint buffer) {
		glTransformFeedbackBufferBase(xfb, index, buffer);
	}
	export void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, intptr_t offset, intptr_t size) {
		glTransformFeedbackBufferRange(xfb, index, buffer, offset, size);
	}
	export void GetTransformFeedbackiv(uint xfb, uint pname, int* param) {
		glGetTransformFeedbackiv(xfb, pname, param);
	}
	export void GetTransformFeedbacki_v(uint xfb, uint pname, uint index, int* param) {
		glGetTransformFeedbacki_v(xfb, pname, index, param);
	}
	export void GetTransformFeedbacki64_v(uint xfb, uint pname, uint index, long* param) {
		glGetTransformFeedbacki64_v(xfb, pname, index, (GLint64*)param);
	}
	export void CreateBuffers(int n, uint* buffers) {
		glCreateBuffers(n, buffers);
	}
	export void NamedBufferStorage(uint buffer, intptr_t size, const void* data, uint flags) {
		glNamedBufferStorage(buffer, size, data, flags);
	}
	export void NamedBufferData(uint buffer, intptr_t size, const void* data, uint usage) {
		glNamedBufferData(buffer, size, data, usage);
	}
	export void NamedBufferSubData(uint buffer, intptr_t offset, intptr_t size, const void* data) {
		glNamedBufferSubData(buffer, offset, size, data);
	}
	export void CopyNamedBufferSubData(uint readBuffer, uint writeBuffer, intptr_t readOffset, intptr_t writeOffset, intptr_t size) {
		glCopyNamedBufferSubData(readBuffer, writeBuffer, readOffset, writeOffset, size);
	}
	export void ClearNamedBufferData(uint buffer, uint internalformat, uint format, uint type, const void* data) {
		glClearNamedBufferData(buffer, internalformat, format, type, data);
	}
	export void ClearNamedBufferSubData(uint buffer, uint internalformat, intptr_t offset, intptr_t size, uint format, uint type, const void* data) {
		glClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, data);
	}
	export void MapNamedBuffer(uint buffer, uint access) {
		glMapNamedBuffer(buffer, access);
	}
	export void MapNamedBufferRange(uint buffer, intptr_t offset, intptr_t length, uint access) {
		glMapNamedBufferRange(buffer, offset, length, access);
	}
	export void UnmapNamedBuffer(uint buffer) {
		glUnmapNamedBuffer(buffer);
	}
	export void FlushMappedNamedBufferRange(uint buffer, intptr_t offset, intptr_t length) {
		glFlushMappedNamedBufferRange(buffer, offset, length);
	}
	export void GetNamedBufferParameteriv(uint buffer, uint pname, int* params) {
		glGetNamedBufferParameteriv(buffer, pname, params);
	}
	export void GetNamedBufferParameteri64v(uint buffer, uint pname, long* params) {
		glGetNamedBufferParameteri64v(buffer, pname, (GLint64*)params);
	}
	export void GetNamedBufferPointerv(uint buffer, uint pname, void** params) {
		glGetNamedBufferPointerv(buffer, pname, params);
	}
	export void GetNamedBufferSubData(uint buffer, intptr_t offset, intptr_t size, void* data) {
		glGetNamedBufferSubData(buffer, offset, size, data);
	}
	export void CreateFramebuffers(int n, uint* framebuffers) {
		glCreateFramebuffers(n, framebuffers);
	}
	export void NamedFramebufferRenderbuffer(uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer) {
		glNamedFramebufferRenderbuffer(framebuffer, attachment, renderbuffertarget, renderbuffer);
	}
	export void NamedFramebufferParameteri(uint framebuffer, uint pname, int param) {
		glNamedFramebufferParameteri(framebuffer, pname, param);
	}
	export void NamedFramebufferTexture(uint framebuffer, uint attachment, uint texture, int level) {
		glNamedFramebufferTexture(framebuffer, attachment, texture, level);
	}
	export void NamedFramebufferTextureLayer(uint framebuffer, uint attachment, uint texture, int level, int layer) {
		glNamedFramebufferTextureLayer(framebuffer, attachment, texture, level, layer);
	}
	export void NamedFramebufferDrawBuffer(uint framebuffer, uint buf) {
		glNamedFramebufferDrawBuffer(framebuffer, buf);
	}
	export void NamedFramebufferDrawBuffers(uint framebuffer, int n, const uint* bufs) {
		glNamedFramebufferDrawBuffers(framebuffer, n, bufs);
	}
	export void NamedFramebufferReadBuffer(uint framebuffer, uint src) {
		glNamedFramebufferReadBuffer(framebuffer, src);
	}
	export void InvalidateNamedFramebufferData(uint framebuffer, int numAttachments, const uint* attachments) {
		glInvalidateNamedFramebufferData(framebuffer, numAttachments, attachments);
	}
	export void InvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, const uint* attachments, int x, int y, int width, int height) {
		glInvalidateNamedFramebufferSubData(framebuffer, numAttachments, attachments, x, y, width, height);
	}
	export void ClearNamedFramebufferiv(uint framebuffer, uint buffer, int drawbuffer, const int* value) {
		glClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, value);
	}
	export void ClearNamedFramebufferuiv(uint framebuffer, uint buffer, int drawbuffer, const uint* value) {
		glClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, value);
	}
	export void ClearNamedFramebufferfv(uint framebuffer, uint buffer, int drawbuffer, const float* value) {
		glClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, value);
	}
	export void ClearNamedFramebufferfi(uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil) {
		glClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);
	}
	export void BlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter) {
		glBlitNamedFramebuffer(readFramebuffer, drawFramebuffer, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
	}
	export void CheckNamedFramebufferStatus(uint framebuffer, uint target) {
		glCheckNamedFramebufferStatus(framebuffer, target);
	}
	export void GetNamedFramebufferParameteriv(uint framebuffer, uint pname, int* param) {
		glGetNamedFramebufferParameteriv(framebuffer, pname, param);
	}
	export void GetNamedFramebufferAttachmentParameteriv(uint framebuffer, uint attachment, uint pname, int* params) {
		glGetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, params);
	}
	export void CreateRenderbuffers(int n, uint* renderbuffers) {
		glCreateRenderbuffers(n, renderbuffers);
	}
	export void NamedRenderbufferStorage(uint renderbuffer, uint internalformat, int width, int height) {
		glNamedRenderbufferStorage(renderbuffer, internalformat, width, height);
	}
	export void NamedRenderbufferStorageMultisample(uint renderbuffer, int samples, uint internalformat, int width, int height) {
		glNamedRenderbufferStorageMultisample(renderbuffer, samples, internalformat, width, height);
	}
	export void GetNamedRenderbufferParameteriv(uint renderbuffer, uint pname, int* params) {
		glGetNamedRenderbufferParameteriv(renderbuffer, pname, params);
	}
	export void CreateTextures(uint target, int n, uint* textures) {
		glCreateTextures(target, n, textures);
	}
	export void TextureBuffer(uint texture, uint internalformat, uint buffer) {
		glTextureBuffer(texture, internalformat, buffer);
	}
	export void TextureBufferRange(uint texture, uint internalformat, uint buffer, intptr_t offset, intptr_t size) {
		glTextureBufferRange(texture, internalformat, buffer, offset, size);
	}
	export void TextureStorage1D(uint texture, int levels, uint internalformat, int width) {
		glTextureStorage1D(texture, levels, internalformat, width);
	}
	export void TextureStorage2D(uint texture, int levels, uint internalformat, int width, int height) {
		glTextureStorage2D(texture, levels, internalformat, width, height);
	}
	export void TextureStorage3D(uint texture, int levels, uint internalformat, int width, int height, int depth) {
		glTextureStorage3D(texture, levels, internalformat, width, height, depth);
	}
	export void TextureStorage2DMultisample(uint texture, int samples, uint internalformat, int width, int height, uchar fixedsamplelocations) {
		glTextureStorage2DMultisample(texture, samples, internalformat, width, height, fixedsamplelocations);
	}
	export void TextureStorage3DMultisample(uint texture, int samples, uint internalformat, int width, int height, int depth, uchar fixedsamplelocations) {
		glTextureStorage3DMultisample(texture, samples, internalformat, width, height, depth, fixedsamplelocations);
	}
	export void TextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, uint type, const void* pixels) {
		glTextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
	}
	export void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, const void* pixels) {
		glTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
	}
	export void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, const void* pixels) {
		glTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
	}
	export void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, uint format, int imageSize, const void* data) {
		glCompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, data);
	}
	export void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, const void* data) {
		glCompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, data);
	}
	export void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, const void* data) {
		glCompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
	}
	export void CopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width) {
		glCopyTextureSubImage1D(texture, level, xoffset, x, y, width);
	}
	export void CopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height) {
		glCopyTextureSubImage2D(texture, level, xoffset, yoffset, x, y, width, height);
	}
	export void CopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height) {
		glCopyTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, x, y, width, height);
	}
	export void TextureParameterf(uint texture, uint pname, float param) {
		glTextureParameterf(texture, pname, param);
	}
	export void TextureParameterfv(uint texture, uint pname, const float* param) {
		glTextureParameterfv(texture, pname, param);
	}
	export void TextureParameteri(uint texture, uint pname, int param) {
		glTextureParameteri(texture, pname, param);
	}
	export void TextureParameterIiv(uint texture, uint pname, const int* params) {
		glTextureParameterIiv(texture, pname, params);
	}
	export void TextureParameterIuiv(uint texture, uint pname, const uint* params) {
		glTextureParameterIuiv(texture, pname, params);
	}
	export void TextureParameteriv(uint texture, uint pname, const int* param) {
		glTextureParameteriv(texture, pname, param);
	}
	export void GenerateTextureMipmap(uint texture) {
		glGenerateTextureMipmap(texture);
	}
	export void BindTextureUnit(uint unit, uint texture) {
		glBindTextureUnit(unit, texture);
	}
	export void GetTextureImage(uint texture, int level, uint format, uint type, int bufSize, void* pixels) {
		glGetTextureImage(texture, level, format, type, bufSize, pixels);
	}
	export void GetCompressedTextureImage(uint texture, int level, int bufSize, void* pixels) {
		glGetCompressedTextureImage(texture, level, bufSize, pixels);
	}
	export void GetTextureLevelParameterfv(uint texture, int level, uint pname, float* params) {
		glGetTextureLevelParameterfv(texture, level, pname, params);
	}
	export void GetTextureLevelParameteriv(uint texture, int level, uint pname, int* params) {
		glGetTextureLevelParameteriv(texture, level, pname, params);
	}
	export void GetTextureParameterfv(uint texture, uint pname, float* params) {
		glGetTextureParameterfv(texture, pname, params);
	}
	export void GetTextureParameterIiv(uint texture, uint pname, int* params) {
		glGetTextureParameterIiv(texture, pname, params);
	}
	export void GetTextureParameterIuiv(uint texture, uint pname, uint* params) {
		glGetTextureParameterIuiv(texture, pname, params);
	}
	export void GetTextureParameteriv(uint texture, uint pname, int* params) {
		glGetTextureParameteriv(texture, pname, params);
	}
	export void CreateVertexArrays(int n, uint* arrays) {
		glCreateVertexArrays(n, arrays);
	}
	export void DisableVertexArrayAttrib(uint vaobj, uint index) {
		glDisableVertexArrayAttrib(vaobj, index);
	}
	export void EnableVertexArrayAttrib(uint vaobj, uint index) {
		glEnableVertexArrayAttrib(vaobj, index);
	}
	export void VertexArrayElementBuffer(uint vaobj, uint buffer) {
		glVertexArrayElementBuffer(vaobj, buffer);
	}
	export void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, intptr_t offset, int stride) {
		glVertexArrayVertexBuffer(vaobj, bindingindex, buffer, offset, stride);
	}
	export void VertexArrayVertexBuffers(uint vaobj, uint first, int count, const uint* buffers, const intptr_t* offsets, const int* strides) {
		glVertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);
	}
	export void VertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex) {
		glVertexArrayAttribBinding(vaobj, attribindex, bindingindex);
	}
	export void VertexArrayAttribFormat(uint vaobj, uint attribindex, int size, uint type, uchar normalized, uint relativeoffset) {
		glVertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
	}
	export void VertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) {
		glVertexArrayAttribIFormat(vaobj, attribindex, size, type, relativeoffset);
	}
	export void VertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, uint type, uint relativeoffset) {
		glVertexArrayAttribLFormat(vaobj, attribindex, size, type, relativeoffset);
	}
	export void VertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor) {
		glVertexArrayBindingDivisor(vaobj, bindingindex, divisor);
	}
	export void GetVertexArrayiv(uint vaobj, uint pname, int* param) {
		glGetVertexArrayiv(vaobj, pname, param);
	}
	export void GetVertexArrayIndexediv(uint vaobj, uint index, uint pname, int* param) {
		glGetVertexArrayIndexediv(vaobj, index, pname, param);
	}
	export void GetVertexArrayIndexed64iv(uint vaobj, uint index, uint pname, long* param) {
		glGetVertexArrayIndexed64iv(vaobj, index, pname, (GLint64*)param);
	}
	export void CreateSamplers(int n, uint* samplers) {
		glCreateSamplers(n, samplers);
	}
	export void CreateProgramPipelines(int n, uint* pipelines) {
		glCreateProgramPipelines(n, pipelines);
	}
	export void CreateQueries(uint target, int n, uint* ids) {
		glCreateQueries(target, n, ids);
	}
	export void GetQueryBufferObjecti64v(uint id, uint buffer, uint pname, intptr_t offset) {
		glGetQueryBufferObjecti64v(id, buffer, pname, offset);
	}
	export void GetQueryBufferObjectiv(uint id, uint buffer, uint pname, intptr_t offset) {
		glGetQueryBufferObjectiv(id, buffer, pname, offset);
	}
	export void GetQueryBufferObjectui64v(uint id, uint buffer, uint pname, intptr_t offset) {
		glGetQueryBufferObjectui64v(id, buffer, pname, offset);
	}
	export void GetQueryBufferObjectuiv(uint id, uint buffer, uint pname, intptr_t offset) {
		glGetQueryBufferObjectuiv(id, buffer, pname, offset);
	}
	export void MemoryBarrierByRegion(uint barriers) {
		glMemoryBarrierByRegion(barriers);
	}
	export void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, void* pixels) {
		glGetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
	}
	export void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, void* pixels) {
		glGetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, pixels);
	}
	export void GetGraphicsResetStatus(void) {
		glGetGraphicsResetStatus();
	}
	export void GetnCompressedTexImage(uint target, int lod, int bufSize, void* pixels) {
		glGetnCompressedTexImage(target, lod, bufSize, pixels);
	}
	export void GetnTexImage(uint target, int level, uint format, uint type, int bufSize, void* pixels) {
		glGetnTexImage(target, level, format, type, bufSize, pixels);
	}
	export void GetnUniformdv(uint program, int location, int bufSize, double* params) {
		glGetnUniformdv(program, location, bufSize, params);
	}
	export void GetnUniformfv(uint program, int location, int bufSize, float* params) {
		glGetnUniformfv(program, location, bufSize, params);
	}
	export void GetnUniformiv(uint program, int location, int bufSize, int* params) {
		glGetnUniformiv(program, location, bufSize, params);
	}
	export void GetnUniformuiv(uint program, int location, int bufSize, uint* params) {
		glGetnUniformuiv(program, location, bufSize, params);
	}
	export void ReadnPixels(int x, int y, int width, int height, uint format, uint type, int bufSize, void* data) {
		glReadnPixels(x, y, width, height, format, type, bufSize, data);
	}
	export void GetnMapdv(uint target, uint query, int bufSize, double* v) {
		glGetnMapdv(target, query, bufSize, v);
	}
	export void GetnMapfv(uint target, uint query, int bufSize, float* v) {
		glGetnMapfv(target, query, bufSize, v);
	}
	export void GetnMapiv(uint target, uint query, int bufSize, int* v) {
		glGetnMapiv(target, query, bufSize, v);
	}
	export void GetnPixelMapfv(uint map, int bufSize, float* values) {
		glGetnPixelMapfv(map, bufSize, values);
	}
	export void GetnPixelMapuiv(uint map, int bufSize, uint* values) {
		glGetnPixelMapuiv(map, bufSize, values);
	}
	export void GetnPixelMapusv(uint map, int bufSize, ushort* values) {
		glGetnPixelMapusv(map, bufSize, values);
	}
	export void GetnPolygonStipple(int bufSize, uchar* pattern) {
		glGetnPolygonStipple(bufSize, pattern);
	}
	export void GetnColorTable(uint target, uint format, uint type, int bufSize, void* table) {
		glGetnColorTable(target, format, type, bufSize, table);
	}
	export void GetnConvolutionFilter(uint target, uint format, uint type, int bufSize, void* image) {
		glGetnConvolutionFilter(target, format, type, bufSize, image);
	}
	export void GetnSeparableFilter(uint target, uint format, uint type, int rowBufSize, void* row, int columnBufSize, void* column, void* span) {
		glGetnSeparableFilter(target, format, type, rowBufSize, row, columnBufSize, column, span);
	}
	export void GetnHistogram(uint target, uchar reset, uint format, uint type, int bufSize, void* values) {
		glGetnHistogram(target, reset, format, type, bufSize, values);
	}
	export void GetnMinmax(uint target, uchar reset, uint format, uint type, int bufSize, void* values) {
		glGetnMinmax(target, reset, format, type, bufSize, values);
	}
	export void TextureBarrier(void) {
		glTextureBarrier();
	}
	export void SpecializeShader(uint shader, const char* pEntryPoint, uint numSpecializationConstants, const uint* pConstantIndex, const uint* pConstantValue) {
		glSpecializeShader(shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue);
	}
	export void MultiDrawArraysIndirectCount(uint mode, const void* indirect, intptr_t drawcount, int maxdrawcount, int stride) {
		glMultiDrawArraysIndirectCount(mode, indirect, drawcount, maxdrawcount, stride);
	}
	export void MultiDrawElementsIndirectCount(uint mode, uint type, const void* indirect, intptr_t drawcount, int maxdrawcount, int stride) {
		glMultiDrawElementsIndirectCount(mode, type, indirect, drawcount, maxdrawcount, stride);
	}
	export void PolygonOffsetClamp(float factor, float units, float clamp) {
		glPolygonOffsetClamp(factor, units, clamp);
	}
}