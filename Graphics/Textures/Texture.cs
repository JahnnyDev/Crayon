using GL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GL.Flags;

namespace Graphics.Textures
{
    public abstract class Texture
    {
        public static implicit operator uint(Texture t) => t.id;
        private uint id { get; init; }
        public int type { get; init; }
        public Texture(int type)
        {
            id = gl.GenTexture();
            this.type = type;
        }
        public void Bind() => gl.BindTexture(type, id);
        public void Unbind() => gl.BindTexture(type, 0);
        public void SetWrapMode(int mode)
        {
            gl.TexParameteri(type, GL_TEXTURE_WRAP_R, mode);
            gl.TexParameteri(type, GL_TEXTURE_WRAP_S, mode);
            gl.TexParameteri(type, GL_TEXTURE_WRAP_T, mode);
        }

        public void SetFilteringMode(int mipmapMode, int filterMode)
        {
            gl.TexParameteri(type, GL_TEXTURE_MIN_FILTER, mipmapMode);
            gl.TexParameteri(type, GL_TEXTURE_MAG_FILTER, filterMode);
        }


    }
}
