using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GL;


namespace Graphics.Buffers
{
    public class VertexArray
    {
        private uint id;
        public int vertexSize { get; private set; }

        public static implicit operator uint(VertexArray vao) => vao.id;

        public VertexArray()
        {
            id = gl.GenVertexArray();
        }

        public void Bind() => gl.BindVertexArray(id);
        public void Unbind() => gl.BindVertexArray(0);
    }
}
