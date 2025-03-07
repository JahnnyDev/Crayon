using Crayon.GL;
using  Crayon.Mathematics;
using Crayon.Utilities;
using Crayon.Windowing;
using static Crayon.GL.Flags;

namespace Crayon.Graphics.Shaders
{
    public class ShaderProgram
    {
        private uint id;

        public static implicit operator uint(ShaderProgram p) => p.id;

        public bool isBound { get => id == Context.boundShader; }

        public ShaderProgram(Shader[] shaders)
        {
            id = gl.GenShaderProgram();
            for (int i = 0; i < shaders.Length; i++) AttachShader(shaders[i]);

            LinkShaderProgram();
            bool compiled = GetInfo(out string infoLog);
            if (!compiled) throw new Exception(infoLog);

            for (int i = 0; i < shaders.Length; i++) DisposeOf(shaders[i]);
        }

        public void AttachShader(uint shader) => gl.AttachShader(id, shader);

        public void LinkShaderProgram() => gl.LinkShaderProgram(id);

        public void Bind()
        {
            if (isBound) return;
            gl.BindShaderProgram(id);
            Context.boundShader = id;
        }

        public bool GetInfo(out string infoLog)
        {
            infoLog = "";
            return gl.GetShaderProgramInfo(id, GL_LINK_STATUS, infoLog);
        }

        public void DisposeOf(Shader s)
        {
            s.DetachFrom(id);
            s.Dispose();
        }

        public static ShaderProgram LoadFromAssets(string name) => ShaderPrecompiler.CreateShaderProgram(name);

        public void SetUniform(string name, float value)
        {
            Bind();
            gl.Uniform1f(gl.GetUniformLocation(id, name), value);
        }

        public void SetUniform(string name, double value)
        {
            Bind();
            gl.Uniform1d(gl.GetUniformLocation(id, name), value);
        }

        public void SetUniform(string name, int value)
        {
            Bind();
            gl.Uniform1i(gl.GetUniformLocation(id, name), value);
        }

        public void SetUniform(string name, uint value)
        {
            Bind();
            gl.Uniform1ui(gl.GetUniformLocation(id, name), value);
        }

        public void SetUniform(string name, Vec2 value)
        {
            Bind();
            gl.Uniform2f(gl.GetUniformLocation(id, name), value.x, value.x);
        }
        public void SetUniform(string name, (float, float) value)
        {
            Bind();
            gl.Uniform2f(gl.GetUniformLocation(id, name), value.Item1, value.Item2);
        }
        public void SetUniform(string name, (double, double) value)
        {
            Bind();
            gl.Uniform2d(gl.GetUniformLocation(id, name), value.Item1, value.Item2);
        }

        public void SetUniform(string name, (int, int) value)
        {
            Bind();
            gl.Uniform2i(gl.GetUniformLocation(id, name), value.Item1, value.Item2);
        }

        public void SetUniform(string name, (uint, uint) value)
        {
            Bind();
            gl.Uniform2ui(gl.GetUniformLocation(id, name), value.Item1, value.Item2);
        }

        public void SetUniform(string name, Vec3 value)
        {
            Bind();
            gl.Uniform3f(gl.GetUniformLocation(id, name), value.x, value.y, value.z);
        }

        public void SetUniform(string name, (double, double, double) value)
        {
            Bind();
            gl.Uniform3d(gl.GetUniformLocation(id, name), value.Item1, value.Item2, value.Item3);
        }

        public void SetUniform(string name, (int,int,int) value)
        {
            Bind();
            gl.Uniform3i(gl.GetUniformLocation(id, name), value.Item1, value.Item2, value.Item3);
        }

        public void SetUniform(string name, (uint, uint, uint) value)
        {
            Bind();
            gl.Uniform3ui(gl.GetUniformLocation(id, name), value.Item1, value.Item2, value.Item3);
        }

        public void SetUniform(string name, Vec4 value)
        {
            Bind();
            gl.Uniform4f(gl.GetUniformLocation(id, name), value.x, value.y, value.z, value.w);
        }

        public void SetUniform(string name, (double, double, double, double) value)
        {
            Bind();
            gl.Uniform4d(gl.GetUniformLocation(id, name), value.Item1, value.Item2, value.Item3, value.Item4);
        }

        public void SetUniform(string name, (int, int, int, int) value)
        {
            Bind();
            gl.Uniform4i(gl.GetUniformLocation(id, name), value.Item1, value.Item2, value.Item3, value.Item4);
        }

        public void SetUniform(string name, (uint, uint, uint, uint) value)
        {
            Bind();
            gl.Uniform4ui(gl.GetUniformLocation(id, name), value.Item1, value.Item2, value.Item3, value.Item4);
        }

        public unsafe void SetUniform(string name, Mat4 value)
        {
            Bind();
            float[] v = value.ToArray();
            fixed (float* p = &v[0]) gl.UniformMat4fv(gl.GetUniformLocation(id, name), p);
        }
    }
}