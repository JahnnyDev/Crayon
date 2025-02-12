using Crayon.GL;
using Crayon.Graphics.Shaders;
using Crayon.Utilities;
using static Crayon.GL.Flags;

namespace Crayon.Utilities
{
    public static class ShaderPrecompiler
    {
        public static string directory;

        public static bool shaderEnd = false;
        public static int boundType;
        public static string boundCode = "";

        public static string currentLine { get; private set; }
        public static readonly Dictionary<string, Func<int>> tokens = new()
        {
            //shader type keys
            { "@VERTEX_SHADER", ShaderLibraries.DefVertexShader },
            { "@GEOMETRY_SHADER", ShaderLibraries.DefGeometryShader},
            { "@FRAGMENT_SHADER", ShaderLibraries.DefFragmentShader },
            { "@IMPORT", ShaderLibraries.Import },
            { "@END", ShaderLibraries.EndShader},
        };

        private static bool IsTokenLine(string line) => line.Contains('@');
        private static Func<int> GetToken(string line) => tokens['@'+line.Split('@')[1].Split(' ')[0]];
        public static string ReadTokenArg(string line, int arg) =>line.Split('@')[1].Split(' ')[arg + 1];

        private static Shader CreateShader(string[] file, int line, out int endLine)
        {
            boundCode = "";

            while( line < file.Length)
            {
                currentLine = file[line];
                if (shaderEnd) break;
                if (IsTokenLine(currentLine))
                {
                    GetToken(currentLine).Invoke();
                    
                }
                else boundCode += currentLine + '\n';
                
                line++;

            }
            endLine = line;
            shaderEnd = false;
            //Console.WriteLine(boundCode);
            return new(boundType, boundCode);
        }
        public static ShaderProgram CreateShaderProgram(string name)
        {
            string[] file = AssetManager.ReadFile("Shaders\\" + name + ".shdr");
            List<Shader> shaders = new();

            int line = 0;
            while (line < file.Length) shaders.Add(CreateShader(file, line, out line));
           
            return new( shaders.ToArray());
            
        }

    }
}
