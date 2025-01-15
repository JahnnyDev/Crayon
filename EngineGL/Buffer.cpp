#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>

#define export __declspec(dllexport)
#define uint unsigned int

extern "C"
{
	
	export void GenBuffers(int count, intptr_t buffers)
	{
		glGenBuffers(count, (GLuint*)buffers);
	}
	export unsigned int GenBuffer()
	{
		unsigned int buffer;
		glGenBuffers(1, &buffer);
		return buffer;

	}
	export void BindBuffer(int target, unsigned int buffer)
	{
		glBindBuffer(target, buffer);
	}
	export void DeleteBuffers(int count, intptr_t buffer)
	{
		glDeleteBuffers(count, (GLuint*)buffer);
	}
	export void DeleteBuffer(unsigned int buffer)
	{
		glDeleteBuffers(1, &buffer);
	}
	export void BufferData(int target, int size, const void* data, int usage)
	{
		glBufferData(target, size, (const void*)data, usage);
	}
	export void VertexAttribPointer(unsigned int index, int size, int type, bool normalized, int stride, void* pointer)
	{
	    if(type == GL_FLOAT || GL_HALF_FLOAT) 
			glVertexAttribPointer(index, size, type, normalized, stride, pointer);
		else if( type == GL_UNSIGNED_BYTE || GL_SHORT || GL_INT || GL_UNSIGNED_SHORT || GL_UNSIGNED_INT)
			glVertexAttribIPointer(index, size, type, stride, pointer);
	}
	
	export void EnableVertexAttribArray(unsigned int index)
	{
		glEnableVertexAttribArray(index);
	}
	
}