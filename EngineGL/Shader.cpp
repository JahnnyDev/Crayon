#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>

#define export __declspec(dllexport)

extern "C"
{
	export unsigned int GenShader(int type)
	{
		return glCreateShader(type);
	}
	export void ShaderSource(unsigned int shader, const char source[])
	{
		glShaderSource(shader, 1, &source, NULL);
	}
	export void CompileShader(unsigned int shader)
	{
		glCompileShader(shader);
	}
	export bool GetShaderInfo(unsigned int shader, int flag, char info[512])
	{
		int success;
		glGetShaderiv(shader, flag, &success);
		if (!success)
		{
			glGetShaderInfoLog(shader, 512, NULL, &info[0]);
			return false;
		}
		return true;
	}
	export void DetachShader(unsigned int program, unsigned int shader)
	{
		glDetachShader(program, shader);
	}
	export void DeleteShader(unsigned int shader)
	{
		glDeleteShader(shader);
	}
}