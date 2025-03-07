using System.Numerics;
using static Crayon.GL.Flags;

namespace Crayon.Graphics.Buffers
{
    public class ElementBuffer<T> : BufferObject<T> where T : INumber<T>, IUnsignedNumber<T>
    {
        public int dataType;

        public ElementBuffer(int usage, int elementSize) : base(usage, GL_ELEMENT_ARRAY_BUFFER, elementSize)
        {
        }
    }
}