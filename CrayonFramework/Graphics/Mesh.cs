using Crayon.GL;
using Crayon.Graphics.Buffers;
using Crayon.Graphics.Shaders;
using Crayon.Mathematics;
using static Crayon.GL.Flags;

namespace Crayon.Graphics
{
    public class Mesh
    {
        private List<Mat4> _instances;
        public int instanceCapacity = 2000;

        public List<Mat4> instances { get => _instances; }

        protected VertexArray vertices;
        public VertexBuffer<float>[] VertexComponents { get; private set; }
        protected VertexBuffer<float> instanceBuffer { get; private set; }
        protected ElementBuffer<uint> indices { get; private set; }
        protected int vertexCount { get; private set; }

        public Mesh(BufferTemplate<float>[] parameters, float[][] vertexData, uint[] indexData)
        {
            _instances = new List<Mat4>();
            vertices = new();
            vertices.Bind();

            VertexComponents = new VertexBuffer<float>[parameters.Length];

            uint index = 0;
            int offset = 0;
            for (int i = 0; i < VertexComponents.Length; i++)
            {

                VertexComponents[i] = new(parameters[i]);
                VertexComponents[i].SetData(vertexData[i]);

                for (int j = 0; j < VertexComponents[i].subElementCount; j++)
                {
                    VertexComponents[i].CreateAttribPointer(index++, VertexComponents[i].subElementSizes[j], offset);
                    offset += VertexComponents[i].subElementSizes[j];
                }
            }

            // instanceBuffer = new(GL_DYNAMIC_DRAW, 16);
            // instanceBuffer.SetCapacity(instanceCapacity);

            indices = new(GL_STATIC_DRAW, 1);
            indices.SetData(indexData);

            vertexCount = indexData.Length;
        }

        public void Instantiate(Mat4 transform)
        {
            instances.Add(transform);
            vertices.Bind();

            instanceBuffer.SetDataRange(transform.ToArray(), instances.Count - 1);

            for (int j = 0; j < 4; j++)
                instanceBuffer.CreateAttribPointer((uint)(j + 2), 4, j * 4);
            for (uint j = 0; j < 4; j++)
                gl.VertexAttribDivisor(j + 2, 1);
        }

        public void Instantiate(Vec3 pos, Vec3 rotation, Vec3 scale) => Instantiate(Mat4.Transform(pos, rotation, scale));

        public  void Generate(BufferTemplate<float>[] parameters, float[][] vertexData, uint[] indexData)
        {
            _instances = new List<Mat4>();
            vertices = new();
            vertices.Bind();

            VertexComponents = new VertexBuffer<float>[parameters.Length];

            uint index = 0;
            int offset = 0;
            for (int i = 0; i < VertexComponents.Length; i++)
            {

                VertexComponents[i] = new(parameters[i]);
                VertexComponents[i].SetData(vertexData[i]);

                for (int j = 0; j < VertexComponents[i].subElementCount; j++)
                {
                    VertexComponents[i].CreateAttribPointer(index++, VertexComponents[i].subElementSizes[j], offset);
                    offset += VertexComponents[i].subElementSizes[j];
                }
            }

            // instanceBuffer = new(GL_DYNAMIC_DRAW, 16);
            // instanceBuffer.SetCapacity(instanceCapacity);

            indices = new(GL_STATIC_DRAW, 1);
            indices.SetData(indexData);

            vertexCount = indexData.Length;
        }
       

        public unsafe void Draw(uint mode, ShaderProgram shader)
        {
            shader.Bind();
            vertices.Bind();
            indices.Bind();
            gl.DrawElements(mode, vertexCount, GL_UNSIGNED_INT, (void*)0);
        }

        public void Draw(ShaderProgram shader) => Draw(GL_TRIANGLES, shader);

        public unsafe void DrawProjection(ShaderProgram shader, Mat4 projection, string projectionName)
        {
            shader.SetUniform(projectionName, projection);
            Draw(shader);
        }

        public unsafe void DrawProjection(uint mode, ShaderProgram shader, Mat4 projection, string projectionName)
        {
            shader.SetUniform(projectionName, projection);
            Draw(mode, shader);
        }

        public unsafe void DrawInstance(int instanceID, ShaderProgram shader, string projectionName)
            => DrawProjection(shader, instances[instanceID], projectionName);

        public unsafe void DrawInstance(uint mode, int instanceID, ShaderProgram shader, string projectionName)
            => DrawProjection(mode, shader, instances[instanceID], projectionName);

        public unsafe void DrawAllInstances(uint mode, ShaderProgram shader)
        {
            shader.Bind();
            vertices.Bind();
            indices.Bind();
            gl.DrawElementsInstanced(mode, vertexCount, GL_UNSIGNED_INT, (void*)0, instances.Count);
        }

        public unsafe void DrawAllInstances(ShaderProgram shader)
            => DrawAllInstances(GL_TRIANGLES, shader);

        public enum Flags
        {
            VERTEX_POSITION,
            VERTEX_POSITION_UV,
        }
    }
}