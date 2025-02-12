#include "pch.h"
#include <glad/glad.h>
#include <glfw3.h>
#include <iostream>

#define export __declspec(dllexport)

extern "C"
{

    void framebuffer_size_callback(GLFWwindow* window, int width, int height);

    
    

    void processInput(GLFWwindow* window);

    void APIENTRY glDebugOutput(GLenum source, GLenum type, GLuint id, GLenum severity, GLsizei length, const GLchar* message, const void* userParam) {
        std::cerr << "OpenGL Debug Message: " << message << std::endl; if (severity == GL_DEBUG_SEVERITY_HIGH) {
            std::cerr << "Severity: HIGH!" << std::endl; __debugbreak(); // Breakpoint for high severity errors 
        }
    }

    export bool Initialize(int versionMajor, int versionMinor, int profile)
    {
        // glfw: initialize and configure
        // ------------------------------
        if (!glfwInit())
        {
            std::cout << "Failed to initialize GLFW" << std::endl;
            return false;
        }
        glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, versionMajor);
        glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, versionMinor);
        glfwWindowHint(GLFW_OPENGL_PROFILE, profile);
        glfwWindowHint(GLFW_DEPTH_BITS, 24);

#ifdef __APPLE__
        glfwWindowHint(GLFW_OPENGL_FORWARD_COMPAT, GL_TRUE);
#endif

        return true;
    }

    export intptr_t InitWindow(int width, int height, const char title[])
    {
        GLFWwindow* window = glfwCreateWindow(width, height, title, NULL, NULL);
        if (window == NULL)
        {
            std::cout << "Failed to create a window" << std::endl;
            glfwTerminate();
            return -1;
        }
        glfwMakeContextCurrent(window);
        glfwSetFramebufferSizeCallback(window, framebuffer_size_callback);
        return (intptr_t)window;
    }

    export bool Load()
    {
        if (!gladLoadGLLoader((GLADloadproc)glfwGetProcAddress))
        {
            std::cout << "Failed to initialize GLAD" << std::endl;
            return false;
        }
        glDebugMessageCallback(glDebugOutput, nullptr);
       // glEnable(GL_DEBUG_OUTPUT); 
        
        return true;
    }

    export bool WindowShouldClose(intptr_t window)
    {
        return glfwWindowShouldClose((GLFWwindow*)window);
    }
    
    export void Render(intptr_t window)
    {
        glfwSwapBuffers((GLFWwindow*)window);
        glfwPollEvents();
    }
    export void Quit()
    {
        glfwTerminate();
    }
    export float GetTime()
    {
        return (float)glfwGetTime();
    }
   
}