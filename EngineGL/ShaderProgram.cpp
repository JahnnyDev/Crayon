#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>

#define export __declspec(dllexport)
#define uint unsigned int
extern "C"
{
	export void ActiveShaderProgram(uint pipeline, uint program)
	{
		glActiveShaderProgram(pipeline, program);
	}
	export unsigned int GenShaderProgram()
	{
		return glCreateProgram();
	}
	export void AttachShader(unsigned int program, unsigned int shader)
	{
		glAttachShader(program, shader);
	}
	export void LinkShaderProgram(unsigned int program)
	{
		glLinkProgram(program);
	}
	export bool GetShaderProgramInfo(unsigned int program, int flag, char info[512])
	{
		int success;
		glGetProgramiv(program, flag, &success);
		if (!success) glGetProgramInfoLog(program, 512, NULL, &info[0]);
		return success;
	}

	export void BindShaderProgram(unsigned int program)
	{
		glUseProgram(program);
	}
	export int GetUniformLocation(unsigned int program, const char name[])
	{
		return glGetUniformLocation(program, name);
	}
	export void Uniform1d(int location, double value)
	{
		glUniform1d(location, value);
	}
	export void Uniform1f(int location, float value)
	{
		glUniform1f(location, value);
	}
	export void Uniform1i(int location, int value)
	{
		glUniform1i(location, value);
	}
	export void Uniform1ui(int location, unsigned int value)
	{
		glUniform1ui(location, value);
	}

	export void Uniform2d(int location, double x, double y)
	{
		glUniform2d(location, x, y);
	}
	export void Uniform2f(int location, float x, float y)
	{
		glUniform2f(location, x, y);
	}
	export void Uniform2i(int location, int x, int y)
	{
		glUniform2i(location, x, y);
	}
	export void Uniform2ui(int location, unsigned int x, unsigned int y)
	{
		glUniform2ui(location, x, y);
	}

	export void Uniform3d(int location, double x, double y, double z)
	{
		glUniform3d(location, x, y, z);
	}
	export void Uniform3f(int location, float x, float y, float z)
	{
		glUniform3f(location, x, y, z);
	}
	export void Uniform3i(int location, int x, int y, int z)
	{
		glUniform3i(location, x, y, z);
	}
	export void Uniform3ui(int location, unsigned int x, unsigned int y, unsigned int z)
	{
		glUniform3ui(location, x, y, z);
	}

	export void Uniform4d(int location, double x, double y, double z, double w)
	{
		glUniform4d(location, x, y, z, w);
	}
	export void Uniform4f(int location, float x, float y, float z, float w)
	{
		glUniform4f(location, x, y, z, w);
	}
	export void Uniform4i(int location, int x, int y, int z, int w)
	{
		glUniform4i(location, x, y, z, w);
	}
	export void Uniform4ui(int location, unsigned int x, unsigned int y, unsigned int z, unsigned int w)
	{
		glUniform4ui(location, x, y, z, w);
	}
	
	export void UniformMat2d(int location, const double* value)
	{
		glad_glUniformMatrix2dv(location, 1, false, value);
	}
	export void UniformMat2f(int location, const float* value)
	{
		glad_glUniformMatrix2fv(location, 1, false, value);
	}

	export void UniformMat3d(int location, const double* value)
	{
		glad_glUniformMatrix3dv(location, 1, false, value);
	}
	export void UniformMat3f(int location, const float* value)
	{
		glad_glUniformMatrix3fv(location, 1, false, value);
	}

	export void UniformMat4d(int location, const double* value)
	{
		glad_glUniformMatrix4dv(location, 1, false, value);
	}
	export void UniformMat4f(int location, const float* value)
	{
		glad_glUniformMatrix4fv(location, 1, false, value);
	}

}