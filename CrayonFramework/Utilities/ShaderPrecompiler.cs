using Crayon.Graphics.Shaders;
using Crayon.Utilities;
using static Crayon.GL.Flags;

namespace Crayon.Utilities
{
    public static class ShaderPrecompiler
    {
        public static string directory;

        private static bool shaderEnd = false;
        private static int boundType;
        private static string boundCode = "";

        public static string currentLine { get; private set; }

        public static readonly Dictionary<string, Func<int>> tokens = new()
        {
            //shader type keys
            { "@VERTEX_SHADER", DefVertexShader },
            { "@GEOMETRY_SHADER", DefGeometryShader},
            { "@FRAGMENT_SHADER", DefFragmentShader },
            { "@IMPORT", Import },
            { "@END", EndShader},
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
           
            ShaderProgram result = new(shaders.ToArray());
         
            return result;
            
        }

        public static int DefVertexShader()
        {
            boundType = GL_VERTEX_SHADER;
            return 0;
        }
        public static int DefFragmentShader()
        {
            boundType = GL_FRAGMENT_SHADER;
            return 1;
        }
        public static int DefGeometryShader()
        {
            boundType = GL_GEOMETRY_SHADER;
            return 2;
        }
        public static int Import()
        {
            boundCode += ShaderLibraries.ImportLib[ReadTokenArg(currentLine, 0)] + "\n";
            return 3;
        }
        public static int EndShader()
        {
            shaderEnd = true;
            return 4;
        }
    }
}
