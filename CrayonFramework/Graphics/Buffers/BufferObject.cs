using Crayon.GL;
using Crayon.Windowing;
using System.Numerics;
using static Crayon.GL.Flags;

namespace Crayon.Graphics.Buffers
{
    public class BufferObject<T> : IDisposable where T : INumber<T>
    {
        private uint id;

        public static implicit operator uint(BufferObject<T> b) => b.id;

        public int elementCount; // the total number of grouped elements in the buffer
        public int elementSize; // the number of values in each element

        public int capacity;

        public unsafe int elementSpan { get => elementSize * sizeof(T); } // the binary size of each element
        public unsafe int byteCapacity { get => capacity * sizeof(T); }
        protected int usage { get; init; }
        protected int defaultTarget { get; init; }

        public BufferObject(int usage, int target, int elementSize)
        {
            id = gl.GenBuffer();
            this.usage = usage;
            defaultTarget = target;
            this.elementSize = elementSize;
        }

        public BufferObject(BufferTemplate<T> parameter, int target)
        {
            id = gl.GenBuffer();
            usage = parameter.usage;
            defaultTarget = target;
            elementSize = parameter.elementSize;
        }

        public bool IsBound(int target) => Context.boundBuffers[target] == id;

        public void BindTo(int target)
        {
            if (IsBound(target)) return;
            gl.BindBuffer(target, id);
            Context.boundBuffers[target] = id;
        }

        public void Bind() => BindTo(defaultTarget);

        public void UnbindFrom(int target)
        {
            if (!IsBound(target)) return;
            gl.BindBuffer(target, 0);
            Context.boundBuffers[target] = 0;
        }

        public void Unbind() => UnbindFrom(defaultTarget);

        public void Dispose()
        {
            for (int i = 0; i < Context.boundBuffers.Count; i++)
                UnbindFrom(Context.boundBuffers.Keys.ToArray()[i]);

            gl.DeleteBuffer(id);
            GC.SuppressFinalize(this);
        }

        protected static int GetTypeFlag()
        {
            return
                (typeof(T) == typeof(Half)) ? GL_HALF_FLOAT :
                (typeof(T) == typeof(float)) ? GL_FLOAT :
                (typeof(T) == typeof(double)) ? GL_DOUBLE :

                (typeof(T) == typeof(short)) ? GL_SHORT :
                (typeof(T) == typeof(int)) ? GL_INT :

                (typeof(T) == typeof(byte)) ? GL_UNSIGNED_BYTE :
                (typeof(T) == typeof(ushort)) ? GL_SHORT :
                (typeof(T) == typeof(uint)) ? GL_UNSIGNED_INT :

                throw new InvalidDataException("The data type '" + typeof(T) + "' is not supported for buffers");
        }

        public virtual unsafe void SetData(T[] data)
        {
            Bind();
            elementCount = data.Length;
            fixed (void* p = &data[0])
            {
                gl.BufferData(defaultTarget, data.Length * sizeof(T), p, usage);
            }
        }

        public unsafe void SetData(T[] data, int capacity)
        {
            if (data.Length > capacity) throw new InsufficientMemoryException("Buffer's size was more than it's capacity!");
            Bind();
            elementCount = data.Length;
            this.capacity = capacity;
            fixed (void* p = &data[0])
            {
                gl.BufferData(defaultTarget, capacity * sizeof(T), p, usage);
            }
        }

        public unsafe void SetCapacity(int capacity)
        {
            BufferObject<T> copyBuffer = new(GL_STATIC_COPY, 0, elementSize);

            copyBuffer.BindTo(GL_COPY_WRITE_BUFFER);
            this.BindTo(GL_COPY_READ_BUFFER);

            gl.BufferData(GL_COPY_WRITE_BUFFER, this.byteCapacity, null, usage); // set the capacity of the copying buffer to match the original
            gl.CopyBufferSubData(GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, 0, 0, this.byteCapacity); // copy the data

            gl.BufferData(GL_COPY_READ_BUFFER, capacity * elementSpan, null, usage); // set the capacity of the original buffer

            copyBuffer.BindTo(GL_COPY_READ_BUFFER);
            this.BindTo(GL_COPY_WRITE_BUFFER);

            gl.CopyBufferSubData(GL_COPY_READ_BUFFER, GL_COPY_WRITE_BUFFER, 0, 0, capacity * elementSpan); // copy the data back into the original

            this.capacity = capacity;

            this.UnbindFrom(GL_COPY_WRITE_BUFFER);
            copyBuffer.Dispose();
        }

        public unsafe void SetDataRange(T[] data, int start)
        {
            Bind();
            elementCount = int.Max(elementCount, start + data.Length); // find a better solution to this eventually.
            fixed (void* p = &data[0])
            {
                gl.BufferSubData(defaultTarget, start * elementSpan, data.Length * sizeof(T), p);
            }
        }
    }
}