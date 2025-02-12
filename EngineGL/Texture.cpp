#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>

#define export __declspec(dllexport)
# define uint unsigned int

extern "C"
{

	export uint GenTexture()
	{
		uint texture;
		glGenTextures(1, &texture);
		return texture;
	}
	

	export void GenMipmap(int target)
	{
		return glGenerateMipmap(target);
	}
}