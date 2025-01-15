using Graphics;
using Graphics.Buffers;
using GL;
using Input;
using static GL.Flags;
using static GLFW.Flags;
using Windowing;
using static MathS.Float;
using  MathS;
using Graphics.Textures;
using Utilities;

namespace TestApp
{
    public class Application : Context
    {

        ShaderProgram shaderProgram;
        VertexArray vao;
        Texture2D texture;

        public Application(int width, int height, string title) : base(width, height, title){}

        public override void Initialize()
        {
            Console.WriteLine("Wow,  The Program is Booting!");
            base.Initialize();
        }

        public unsafe override void Load()
        {
            Console.WriteLine("Wow,  The Program is Loading!");

            string vertexShaderSource = @"#version 330 core
            layout (location = 0) in vec2 pos;
            layout (location = 1) in vec2 texCoord;
            uniform mat4 view;
            out vec2 uv;

            void main()
            {
               uv = texCoord;
               gl_Position = vec4(pos, 0, 1.0);
               
            }";

            string fragmentShaderSource = @"#version 330 core
            in vec2 uv;
            uniform vec3 color;
            uniform sampler2D tex;
            out vec4 FragColor;
            void main()
            {
                vec4 texCol = texture(tex, uv);
                FragColor = texCol * vec4(color, 1.0f);
            }";

            Shader vertexShader = new(GL_VERTEX_SHADER, vertexShaderSource);
            Shader fragShader = new(GL_FRAGMENT_SHADER, fragmentShaderSource);
            shaderProgram = new(new Shader[] { vertexShader, fragShader });


            float[] vertices = new float[] {
            // positions            // texture coords
              0.5f,  0.5f,          1.0f, 1.0f, // top right
              0.5f, -0.5f,          1.0f, 0.0f, // bottom right
             -0.5f, -0.5f,          0.0f, 0.0f, // bottom left

             -0.5f, -0.5f,          0.0f, 0.0f, // bottom left
             -0.5f,  0.5f,          0.0f, 1.0f, // top left  
              0.5f,  0.5f,          1.0f, 1.0f, // top right
        };

            vao = new();

            VertexBuffer vbo = new(GL_STATIC_DRAW, sizeof(float) * 4);
            vao.Bind();
            vbo.Bind();

            vbo.SetData(vertices);
            vbo.CreateAttribPointer<float>(0, 2, 0);
            vbo.CreateAttribPointer<float>(1, 2, 2);


            vbo.Unbind();
            vao.Unbind();

            texture = new();
            texture.Bind();
            texture.SetFilteringMode(GL_LINEAR_MIPMAP_LINEAR, GL_LINEAR);
            texture.SetWrapMode(GL_REPEAT);
            texture.LoadFromImage(AssetManager.directory + "Textures\\lad.png", GL_RGB);
            

        }
        Vec3 color;
        Mat4 view;
        public override void Update()
        {
            base.Update();

            float x = Keyboard.GetAxis(GLFW_KEY_A, GLFW_KEY_D) + 1f / 2f;
            float y = Keyboard.GetAxis(GLFW_KEY_W, GLFW_KEY_S) + 1f / 2f;

            Vec2 mpos = Min(Max(Mouse.position, Vec2.zero), Int.CastToFloat(window.size));
            color = new(mpos / Int.CastToFloat(window.size), 0f);    

        }
        public override void Render()
        {
            
            gl.Clear(GL_COLOR_BUFFER_BIT);
            gl.ClearColor(0.1f, 0.3f, 0.4f, 1f);

            texture.Bind();
            shaderProgram.Bind();
            shaderProgram.SetUniform("color", color);
            //shaderProgram.SetUniform("view", view);
            vao.Bind();
            gl.DrawArrays(GL_TRIANGLES, 0, 6);

            base.Render();
        }
        public override void Quit()
        {
            Console.WriteLine("Wow,  The Program is Exiting!");
            base.Quit();
        }

    }
}
