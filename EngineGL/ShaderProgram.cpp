#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>

#define export __declspec(dllexport)
#define uint unsigned int
extern "C"
{
	export unsigned int GenShaderProgram()
	{
		return glCreateProgram();
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
	
	


}