#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>

#define export __declspec(dllexport)
# define uint unsigned int

extern "C"
{
	export void ActiveTexture(uint texture)
	{
		glActiveTexture(texture);
	}
	export void GenTextures(int count, uint* textures)
	{
		return glGenTextures(count, textures);
	}
	export uint GenTexture()
	{
		uint texture;
		glGenTextures(1, &texture);
		return texture;
	}
	export void BindImageTexture(uint unit, uint texture, int level, bool layered, int layer, uint access, uint format)
	{
		glBindImageTexture(unit, texture, level, layered, layer, access, format);
	}
	export void BindImageTextures(uint first, int count, uint* textures)
	{
		glBindImageTextures(first, count, textures);
	}
	export void BindTexture(int target, uint texture)
	{
		glBindTexture(target, texture);
	}
	export void BindTextures(uint first, int count, uint* textures)
	{
		glBindTextures(first, count, textures);
	}
	export void BindTextureUnit(uint unit, uint texture)
	{
		glBindTextureUnit(unit, texture);
	}
	export void ClearTexImage(uint texture, int level, uint format, uint type, intptr_t data )
	{
		glClearTexImage(texture, level, format, type, (const void*)data);
	}

	export void TexParameterf(int target, int param, int paramValue)
	{
		return glTexParameterf(target, param, paramValue);
	}
	export void TexParameteri(int target, int param, int paramValue)
	{
		return glTexParameteri(target, param, paramValue);
	}
	export void TexImage2D(int target, int level, int internalFormat, int width, int height, int border, int format, int type, unsigned char* pixels)
	{
		return glTexImage2D(target, level, internalFormat, width, height, border, format, type, pixels);
	}
	export void GenMipmap(int target)
	{
		return glGenerateMipmap(target);
	}
}