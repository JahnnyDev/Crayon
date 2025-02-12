using Crayon.GL;
using Crayon.Windowing;
using static Crayon.GL.Flags;

namespace Crayon.Graphics.Buffers
{
    public class BufferObject
    {
        private uint id;

        public static implicit operator uint(BufferObject b) => b.id;

        public int elementCount, elementSize, usage, target;
        public bool hasData;

        public BufferObject(int usage, int target, int elementSize)
        {
            hasData = false;
            id = gl.GenBuffer();
            this.usage = usage;
            this.target = target;
            this.elementSize = elementSize;
        }
        public bool isBound { get => id == Context.boundBuffer; }

        public void Bind() 
        {
            if (isBound) return;
            gl.BindBuffer(target, id);
            Context.boundBuffer = id;
        }

        public void Dispose() => gl.DeleteBuffer(id);

        public unsafe void CreateAttribPointer<T>(uint index, int size, int offset)
        {
            Bind();
            gl.VertexAttribPointer(index, size, GetTypeFlag<T>(), false, elementSize, (void*)(offset * sizeof(T)));
            gl.EnableVertexAttribArray(index);
        }

        public static int GetTypeFlag<T>()
        {
            return
                (typeof(T) == typeof(Half)) ? GL_HALF_FLOAT :
                (typeof(T) == typeof(float)) ? GL_FLOAT :
                (typeof(T) == typeof(byte)) ? GL_UNSIGNED_BYTE :
                (typeof(T) == typeof(short)) ? GL_SHORT :
                (typeof(T) == typeof(int)) ? GL_INT :
                (typeof(T) == typeof(uint)) ? GL_UNSIGNED_INT :
                (typeof(T) == typeof(ushort)) ? GL_SHORT :
                throw new InvalidDataException("The data type '" + typeof(T) + "' is not supported for buffers");
        }

        public unsafe void SetData<T>(T[] data)
        {
            Bind();
            elementCount = data.Length;
            fixed (void* p = &data[0])
            {
                gl.BufferData(target, elementCount * sizeof(T), p, usage);
            }
        }
    }
}