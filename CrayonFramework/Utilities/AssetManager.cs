using Crayon.Graphics.Shaders;
using Crayon.Graphics.Textures;
using Crayon.Windowing;
using static Crayon.GL.Flags;
using static MathS.Float;
using static System.Net.Mime.MediaTypeNames;

namespace Crayon.Utilities
{
    public static class AssetManager
    {
        public static string directory;
        public static FileStream CreateFile(string name) => File.Create(directory + name);

        public static FileStream OpenFile(string name) => File.Open(directory + name, FileMode.Open);

        public static FileStream GetFile(string name) => File.Open(directory + name, FileMode.OpenOrCreate);

        public static void Clear(string name) => File.WriteAllText(directory + name, string.Empty);

        public static void Overwrite(string name, string value) => File.WriteAllText(directory + name, value);

        public static string[] ReadFile(string name) => File.ReadAllLines(directory + name);


        public static ShaderProgram LoadShader(string name)
        {
            Console.WriteLine(directory);
            if (!Directory.Exists(directory + "Shaders\\"))
                throw new FileNotFoundException("ERROR: the shader directory is not set up correctly");

            List<string> fileLines = ReadFile("Shaders\\" + name + ".txt").ToList();
            List<Shader> shaders = new();

            int shaderType = 0;

            for (int i = 0; i < fileLines.Count; i++)
            {
                if (fileLines[i].Contains('@'))
                {
                    switch (fileLines[i].Trim())
                    {
                        case "@VERTEX_SHADER":
                            shaderType = GL_VERTEX_SHADER;

                            break;
                        case "@GEOMETRY_SHADER":
                            shaderType = GL_GEOMETRY_SHADER;
                            break;
                        case "@FRAGMENT_SHADER":
                            shaderType = GL_FRAGMENT_SHADER;
                            break;

                    }
                    int j = 1;
                    string shaderBlock = "";
                    while (!fileLines[j + i].Contains('@'))
                    {
                        if (fileLines[j + i].Contains('$'))
                        {
                            string[] statement = fileLines[i + j].TrimStart().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            switch (statement[0])
                            {
                                case "$STATIC_REPEAT":

                                    int numLines = int.Parse(statement[1]);
                                    int numTimes = int.Parse(statement[2]);


                                    for (int k = 1; k < numTimes; k++)
                                    {
                                        for (int l = 0; l < numLines; l++)
                                            shaderBlock += fileLines[j + i + l + 1] + "\n";
                                    }
                                    break;
                                case "$DYNAMIC_REPEAT":

                                    numLines = int.Parse(statement[1]);
                                    numTimes = int.Parse(statement[2]);
                                    string paramName = statement[3];

                                    string[] lines = fileLines.GetRange(i + j + 1, numLines).ToArray();
                                    fileLines.RemoveRange(i + j + 1, numLines);

                                    for (int k = 0; k < numTimes; k++)
                                    {
                                        for (int l = 0; l < numLines; l++)
                                        {

                                            string line = lines[l] + "\n";
                                            string[] segments = line.Split(paramName);

                                            shaderBlock += line.Replace(paramName, k.ToString());

                                        }

                                    }
                                    break;
                            }
                        }
                        else shaderBlock += fileLines[j + i] + "\n";
                        j++;
                        if (i + j >= fileLines.Count) break;
                    }

                    shaders.Add(new(shaderType, shaderBlock));
                    Console.WriteLine(shaderBlock);

                }


            }
            return new ShaderProgram(shaders.ToArray());
        }






        public static string Encode(Vec2 v) => Encode(v.x) + " " + Encode(v.y);

        public static string Encode(Vec3 v) => Encode(v.xy) + " " + Encode(v.z);

        public static string Encode(Vec4 v) => Encode(v.xyz) + " " + Encode(v.w);
        public static string Encode(float v)
        {
            string vStr = v.ToString();
            if (!vStr.Contains('.')) return vStr;

            int i = (int)(v * 100);

            string iStr = i.ToString();

            if (vStr.Contains('E')) return "0";

            return iStr.Insert(iStr.Length - 2, ".");




        }



        public static Vec2 ParseVec2(string s, int i) => new Vec2(float.Parse(s.Split(" ")[i]), float.Parse(s.Split(" ")[i + 1]));

        public static Vec3 ParseVec3(string s, int i) => new Vec3(ParseVec2(s, i), float.Parse(s.Split(" ")[i + 2]));

        public static Vec4 ParseVec4(string s, int i) => new Vec4(ParseVec3(s, i), float.Parse(s.Split(" ")[i + 3]));



    }
}