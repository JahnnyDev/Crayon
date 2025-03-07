using Crayon.GL;
using System.Numerics;
using static Crayon.GL.Flags;

namespace Crayon.Graphics.Buffers
{
    public class VertexBuffer<T> : BufferObject<T> where T : IFloatingPoint<T>
    {
        public int[] subElementSizes;
        public int subElementCount { get => subElementSizes.Count(); }

        public unsafe int[] subElementSpans
        {
            get => subElementSizes.Select(e => e * sizeof(T)).ToArray();
        }

        public VertexBuffer(int usage, int elementSize) : base(usage, GL_ARRAY_BUFFER, elementSize)
        {
            subElementSizes = new[] { elementSize };
        }

        public VertexBuffer(int usage, int[] subElementSizes) : base(usage, GL_ARRAY_BUFFER, subElementSizes.Sum())
        {
            this.subElementSizes = subElementSizes;
        }

        public VertexBuffer(BufferTemplate<T> template) : base(template, GL_ARRAY_BUFFER)
        {
            subElementSizes = template.subElementSizes;
        }


    

        public unsafe void CreateAttribPointer(uint index, int size, int offset)
        {
            Bind();
            gl.VertexAttribPointer(index, size, GetTypeFlag(), false, elementSpan, (void*)(offset * sizeof(T)));
            gl.EnableVertexAttribArray(index);
        }
    }
}