using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GL.Flags;
using STBI;
using GL;

namespace Graphics.Textures
{
    public class Texture2D : Texture
    {
        public Texture2D() : base(GL_TEXTURE_2D)
        {}
        public int width, height, channelCount;

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
