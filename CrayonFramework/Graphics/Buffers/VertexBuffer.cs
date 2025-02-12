using static Crayon.GL.Flags;

namespace Crayon.Graphics.Buffers
{
    public class VertexBuffer : BufferObject
    {
        public VertexBuffer(int usage, int elementSize) : base(usage, GL_ARRAY_BUFFER, elementSize)
        {
        }
    }
}