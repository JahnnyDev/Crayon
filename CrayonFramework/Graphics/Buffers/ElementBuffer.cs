﻿using static Crayon.GL.Flags;

namespace Crayon.Graphics.Buffers
{
    public class ElementBuffer : BufferObject
    {
        public int dataType;

        public ElementBuffer(int usage, int elementSize) : base(usage, GL_ELEMENT_ARRAY_BUFFER, elementSize)
        {
        }

        public void Compile<T>(T[] data) where T : struct
        {
            Bind();
            dataType = GetValidTypeFlag<T>();
            SetData(data);
        }

        public int GetValidTypeFlag<T>()
        {
            int t = GetTypeFlag<T>();
            if (t != GL_UNSIGNED_BYTE && t != GL_UNSIGNED_SHORT && t != GL_UNSIGNED_INT)
                throw new InvalidDataException("The data type '" + typeof(T) + "' is not supported for element buffers");
            return t;
        }
    }
}