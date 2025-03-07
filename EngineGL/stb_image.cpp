#include "pch.h"
#define STB_IMAGE_IMPLEMENTATION
#include "stb_image.h"
#include <iostream>

#define export __declspec(dllexport)
#define uint unsigned int


extern "C"
{

	export unsigned char* ImageLoad(const char* file, int* width, int* height, int* channelCount)
	{
		 return stbi_load(file, width, height, channelCount, 0);
	}
	export void DisposeImage(unsigned char* data)
	{
		return stbi_image_free(data);
	}
}