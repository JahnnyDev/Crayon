#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>

#define export __declspec(dllexport)

extern "C"
{
	export void GenVertexArrays(int count, intptr_t vao)
	{

		glGenVertexArrays(count, (GLuint*)vao);
		
	}
	export unsigned int GenVertexArray()
	{
		GLuint vao = 0;
		glGenVertexArrays(1, &vao);
		return vao;

	}
	export void BindVertexArray(unsigned int vao)
	{
		glBindVertexArray(vao);
	}
}