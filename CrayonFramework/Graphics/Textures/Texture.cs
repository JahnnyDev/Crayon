using Crayon.GL;
using Crayon.Windowing;
using static Crayon.GL.Flags;

namespace Crayon.Graphics.Textures
{
    public abstract class Texture
    {
        public static implicit operator uint(Texture t) => t.id;

        private uint id { get; init; }
        public int type { get; init; }
        public bool isBound { get => Context.boundTexture == id; }

        public Texture(int type)
        {
            id = gl.GenTexture();
            this.type = type;
        }

        public Texture(int type, int wrapMode, int mipmapMode, int filterMode)
        {
            id = gl.GenTexture();
            this.type = type;
            Bind();
            SetWrapMode(wrapMode);
            SetFilteringMode(mipmapMode, filterMode);
        }

        public void Bind()
        {
            if (isBound) return;
            gl.BindTexture(type, id);
            Context.boundTexture = id;
        }

        public void SetWrapMode(int mode)
        {
            Bind();
            gl.TexParameteri(type, GL_TEXTURE_WRAP_R, mode);
            gl.TexParameteri(type, GL_TEXTURE_WRAP_S, mode);
            gl.TexParameteri(type, GL_TEXTURE_WRAP_T, mode);
        }

        public void SetFilteringMode(int mipmapMode, int filterMode)
        {
            Bind();
            gl.TexParameteri(type, GL_TEXTURE_MIN_FILTER, mipmapMode);
            gl.TexParameteri(type, GL_TEXTURE_MAG_FILTER, filterMode);
        }
    }
}