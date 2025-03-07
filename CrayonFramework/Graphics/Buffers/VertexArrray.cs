using Crayon.GL;
using Crayon.Windowing;

namespace Crayon.Graphics.Buffers
{
    public class VertexArray
    {
        private uint id;
        public int vertexSize { get; private set; }
        public bool isBound { get => id == Context.boundVertexArray; }

        public static implicit operator uint(VertexArray vao) => vao.id;

        public VertexArray()
        {
            id = gl.GenVertexArray();
        }

        public void Bind()
        {
            if (isBound) return;
            gl.BindVertexArray(id);
            Context.boundVertexArray = id;
        }
    }
}