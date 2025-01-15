using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GL;
using MathS;
using Utilities;
using static GL.Flags;

namespace Graphics
{
    public class ShaderProgram
    {
        private uint id;
        public static implicit operator uint(ShaderProgram p) => p.id;

        public ShaderProgram(Shader[] shaders)
        {
            id = gl.GenShaderProgram();
            for (int i = 0; i < shaders.Length; i++) AttachShader(shaders[i]);

            LinkShaderProgram();
            bool compiled = GetInfo(out string infoLog);
            if(!compiled) throw new Exception(infoLog);

            for (int i = 0; i < shaders.Length; i++) DisposeOf(shaders[i]);
        }
        public void AttachShader(uint shader) => gl.AttachShader(id, shader);
        public void LinkShaderProgram() => gl.LinkShaderProgram(id);
        public void Bind() => gl.BindShaderProgram(id);
        public void Unbind() => gl.BindShaderProgram(0);
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

        public static ShaderProgram LoadFromAssets(string name)
        {
            string[] programs = ShaderPrecompiler.CreateShaderProgram(name, out int[] types);
            return new(programs.Zip(types).Select(p => new Shader(p.Second, p.First)).ToArray());
        }

        public void SetUniform(string name, float value) => gl.Uniform1f(gl.GetUniformLocation(id, name), value);
        public void SetUniform(string name, double value) => gl.Uniform1d(gl.GetUniformLocation(id, name), value);
        public void SetUniform(string name, int value) => gl.Uniform1i(gl.GetUniformLocation(id, name), value);
        public void SetUniform(string name, uint value) => gl.Uniform1ui(gl.GetUniformLocation(id, name), value);

        public void SetUniform(string name, Float.Vec2 value) => gl.Uniform2f(gl.GetUniformLocation(id, name), value.x, value.y);
        public void SetUniform(string name, Generic.Vec2<double> value) => gl.Uniform2d(gl.GetUniformLocation(id, name), value.x, value.y);
        public void SetUniform(string name, Int.Vec2 value) => gl.Uniform2i(gl.GetUniformLocation(id, name), value.x, value.y);
        public void SetUniform(string name, Generic.Vec2<uint> value) => gl.Uniform2ui(gl.GetUniformLocation(id, name), value.x, value.y);

        public void SetUniform(string name, Float.Vec3 value) => gl.Uniform3f(gl.GetUniformLocation(id, name), value.x, value.y, value.z);
        public void SetUniform(string name, Generic.Vec3<double> value) => gl.Uniform3d(gl.GetUniformLocation(id, name), value.x, value.y, value.z);
        public void SetUniform(string name, Int.Vec3 value) => gl.Uniform3i(gl.GetUniformLocation(id, name), value.x, value.y, value.z);
        public void SetUniform(string name, Generic.Vec3<uint> value) => gl.Uniform3ui(gl.GetUniformLocation(id, name), value.x, value.y, value.z);

        public void SetUniform(string name, Float.Vec4 value) => gl.Uniform4f(gl.GetUniformLocation(id, name), value.x, value.y, value.z, value.w);
        public void SetUniform(string name, Generic.Vec4<double> value) => gl.Uniform4d(gl.GetUniformLocation(id, name), value.x, value.y, value.z, value.w);
        public void SetUniform(string name, Int.Vec4 value) => gl.Uniform4i(gl.GetUniformLocation(id, name), value.x, value.y, value.z, value.w);
        public void SetUniform(string name, Generic.Vec4<uint> value) => gl.Uniform4ui(gl.GetUniformLocation(id, name), value.x, value.y, value.z, value.w);

        public unsafe void SetUniform(string name, Float.Mat4 value)
        {
            float[] v = value.ToArray();
            fixed (float* p = &v[0]) gl.UniformMat4f(gl.GetUniformLocation(id, name), p);
        }

    }
}
