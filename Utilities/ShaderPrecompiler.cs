using GL;
using static GL.Flags;

namespace Utilities
{
    public static class ShaderPrecompiler
    {
        public static string directory;
        public static int getShaderType(string[] file, int line)
        {

            switch (file[line].Trim())
            {
                case "@VERTEX_SHADER":
                    return GL_VERTEX_SHADER;
                case "@GEOMETRY_SHADER":
                    return GL_GEOMETRY_SHADER;
                case "@FRAGMENT_SHADER":
                    return GL_FRAGMENT_SHADER;
                default:
                    throw new NotImplementedException("Line:" + line + "Unknown type of shader");

            }
        }
        public static string CreateShader(string[] file, int start, out int? type, out int lineCount)
        {
            string code = "";
            lineCount = 0;
            type = null;
            for (int i = start; i<file.Length; i++)
            {

                if (file[i].Contains('@'))
                {
                    type = getShaderType(file, i);
                    break;
                }
                code += file[i];
                lineCount++;
            }
            Console.WriteLine(lineCount);
            Console.WriteLine(code);
            return code;

        }
        public static string[] CreateShaderProgram(string name, out int[] shaderTypes)
        {

            string[] file = AssetManager.ReadFile("Shaders\\" + name + ".shdr");
            List<string> shaders = new();
            List<int> types = new();
            int line = 0;
            int lineCount = 0;
            while (line < file.Length)
            {
                shaders.Add(CreateShader(file, line, out int? type, out lineCount));
                if (type != null)types.Add((int)type);
                line += lineCount;
            }
            shaderTypes = types.ToArray();
            return shaders.ToArray();
            
        }
    }
}
