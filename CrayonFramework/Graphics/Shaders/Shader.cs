using Crayon.GL;
using static Crayon.GL.Flags;

namespace Crayon.Graphics.Shaders
{
    public class Shader
    {
        private uint id;

        public static implicit operator uint(Shader s) => s.id;

        public int type;

        public bool GetInfo(out string infoLog)
        {
            infoLog = "";
            return gl.GetShaderInfo(id, GL_COMPILE_STATUS, infoLog);
        }

        public Shader(int type, string source)
        {
            this.type = type;
            id = gl.GenShader(type);
            gl.ShaderSource(id, source);
            gl.CompileShader(id);
            string info = "";

            bool compiled = GetInfo(out string infoLog);
            if (!compiled) throw new Exception(infoLog);
        }

        public void DetachFrom(uint program) => gl.DetachShader(program, id);

        public void Dispose() => gl.DeleteShader(id);
    }
}