#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>

#define export __declspec(dllexport)
#define uint unsigned int
extern "C"
{
	export int GetKey(intptr_t window, int key)
	{
		return glfwGetKey((GLFWwindow*)window, key);
	}
	export const char* GetKeyName(int key, int scancode)
	{
		return glfwGetKeyName(key, scancode);
	}
	export int GetKeyScancode(int key)
	{
		return glfwGetKeyScancode(key);
	}
}