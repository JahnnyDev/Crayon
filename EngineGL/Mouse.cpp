#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>
#include <array>
using namespace std;

#define export __declspec(dllexport)
#define uint unsigned int
extern "C"
{
	static double scrollPos;
	void ScrollCallbackOutput(GLFWwindow* window, double xoffset, double yoffset)
	{
		scrollPos = yoffset;
	}

	export int GetMouseButton(intptr_t window, int button)
	{
		return glfwGetMouseButton((GLFWwindow*)window, button);
	}

	export void GetMousePos(intptr_t window, double* x, double* y)
	{
		glfwGetCursorPos((GLFWwindow*)window, x, y);

	}
	export double GetScroll(intptr_t window, double positon)
	{
		glfwSetScrollCallback((GLFWwindow*)window, ScrollCallbackOutput);
		return scrollPos;
	}


}