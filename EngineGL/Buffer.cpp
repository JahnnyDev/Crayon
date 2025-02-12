#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>

#define export __declspec(dllexport)
#define uint unsigned int

extern "C"
{

	export unsigned int GenBuffer()
	{
		unsigned int buffer;
		glGenBuffers(1, &buffer);
		return buffer;
	}
	export void DeleteBuffer(uint buf)
	{
		glDeleteBuffers(1, &buf);
	}
	export void VertexAttribPointer(unsigned int index, int size, int type, bool normalized, int stride, void* pointer)
	{
		if (type == GL_FLOAT || GL_HALF_FLOAT)
			glVertexAttribPointer(index, size, type, normalized, stride, pointer);
		else if (type == GL_UNSIGNED_BYTE || GL_SHORT || GL_INT || GL_UNSIGNED_SHORT || GL_UNSIGNED_INT)
			glVertexAttribIPointer(index, size, type, stride, pointer);
	}

}