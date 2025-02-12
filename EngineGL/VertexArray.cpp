#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>

#define export __declspec(dllexport)

extern "C"
{
	export unsigned int GenVertexArray()
	{
		GLuint vao = 0;
		glGenVertexArrays(1, &vao);
		return vao;

	}
}