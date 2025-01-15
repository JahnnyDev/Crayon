#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>

#define export __declspec(dllexport)
# define uint unsigned int

extern "C"
{
	
	export void DrawArrays(uint mode, int first, int count)
	{
		glDrawArrays(mode, first, count);
	};
	export void DrawArraysInderect(uint mode, intptr_t id)
	{
		glDrawArraysIndirect(mode, (const void*)id);
	};
	export void DrawArraysInstanced(uint mode, int first, int count, int instanceCount)
	{
		glDrawArraysInstanced(mode, first, count, instanceCount);
	};
	export void DrawArraysBaseInstanced(uint mode, int first, int count, int instanceCount, unsigned int baseInstance)
	{
		glDrawArraysInstancedBaseInstance(mode, first, count, instanceCount, baseInstance);
	};
	export void DrawBuffer(uint Buffer)
	{
		glDrawBuffer(Buffer);
	};
	export void DrawBuffers(int count, intptr_t Buffer)
	{
		glDrawBuffers(count, (GLenum*)Buffer);
	};
	export void DrawElements(uint mode, int count, uint type, intptr_t indices)
	{
		glDrawElements(mode, count, type, (const void*)indices);
	};
	export void DrawElementsBaseVertex(uint mode, int count, uint type, intptr_t indices, int baseVertex)
	{
		glDrawElementsBaseVertex(mode, count, type, (const void*)indices, baseVertex);
	};
	
	
}