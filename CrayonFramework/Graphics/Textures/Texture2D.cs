using Crayon.GL;
using MathS;
using STBI;
using static Crayon.GL.Flags;

namespace Crayon.Graphics.Textures
{
    public class Texture2D : Texture
    {
        public Texture2D() : base(GL_TEXTURE_2D)
        { }
        public Texture2D(int wrapMode, int mipmapMode, int filterMode) : base(GL_TEXTURE_2D, wrapMode, mipmapMode, filterMode)
        { }
        public int width, height, channelCount;
        public Int.Vec2 size { get => new(width, height); }

        public unsafe void LoadFromImage(string path, int format)
        {
            int _width = 0;
            int _height = 0;
            int _channelCount;
            if (!File.Exists(path))
                throw new FileNotFoundException("the texture source '" + path.Split("\\").Last() + "' could not be found");
            byte* data = stbi.ImageLoad(path, &_width, &_height, &_channelCount);
            if (data != null)
            {
                Bind();
                gl.TexImage2D(type, 0, format, _width, _height, 0, format, GL_UNSIGNED_BYTE, data);
                gl.GenMipmap(type);
            }
            else throw new Exception("Texture Could not load Image");

            stbi.DisposeImage(data);

            width = _width;
            height = _height;
            channelCount = _channelCount;
        }
    }
}