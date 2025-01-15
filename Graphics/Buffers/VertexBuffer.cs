using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GL.Flags;
namespace Graphics.Buffers
{
    public class VertexBuffer : BufferObject
    {
        public VertexBuffer(int usage, int elementSize) : base(usage, GL_ARRAY_BUFFER, elementSize){}
    }
}
