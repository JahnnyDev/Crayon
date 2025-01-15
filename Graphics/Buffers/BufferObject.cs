using System;
using System.Collections.Generic;
using System.Linq;
using GL;
using static GL.Flags;
using System.Text;
using System.Threading.Tasks;

namespace Graphics.Buffers
{
    public class BufferObject
    {
        private uint id;
        public static implicit operator uint(BufferObject b) => b.id;
        public int elementCount, elementSize, usage, target;
        public bool hasData;

        #region Externals
        
        #endregion

        public BufferObject(int usage, int target, int elementSize)
        {
            hasData = false;
            id = gl.GenBuffer();
            this.usage = usage;
            this.target = target;
            this.elementSize = elementSize;
        }
        public void Bind() => gl.BindBuffer(target, id);
        public void Unbind() => gl.BindBuffer(target, 0);
        public void Dispose() => gl.DeleteBuffer(id);

        public unsafe void CreateAttribPointer<T>(uint index, int size, int offset)
        {
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
            elementCount = data.Length;
            fixed (void* p = &data[0])
            {
                gl.BufferData(target, elementCount * sizeof(T), p, usage);
            }
        }
    }
}
