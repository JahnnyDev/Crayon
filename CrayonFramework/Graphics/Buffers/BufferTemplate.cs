using System.Numerics;

namespace Crayon.Graphics.Buffers
{
    public struct BufferTemplate<T> where T : INumber<T>
    {
        public int usage { get; init; }
        public int elementSize { get; init; }
        public unsafe int elementSpan { get => elementSize * sizeof(T); }
        public unsafe int[] subElementSizes { get; init; }
        public unsafe int[] subElementSpans { get => subElementSizes.Select(s => s * sizeof(T)).ToArray(); }

        public BufferTemplate(int usage, int size, int[] componentSizes)
        {
            this.usage = usage;
            this.elementSize = size;
            this.subElementSizes = componentSizes;
        }

        public BufferTemplate(int usage, int size)
        {
            this.usage = usage;
            this.elementSize = size;
            subElementSizes = new int[] { size };
        }

        #region Flags

        public const int VERTEX_POSITION = 0;
        public const int VERTEX_POSITION_UV = 1;

        #endregion Flags
    }
}