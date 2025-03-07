using Crayon.Graphics.Shaders;
using Crayon.Graphics.Textures;
using Crayon.Windowing;
using static Crayon.GL.Flags;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.InteropServices;

namespace Crayon.Utilities
{
    public static class AssetManager
    {
        public static string directory;
        public static FileStream CreateFile(string fileName) => File.Create(directory + fileName);

        public static FileStream OpenFile(string fileName) => File.Open(directory + fileName, FileMode.Open);

        public static FileStream GetFile(string fileName) => File.Open(directory + fileName, FileMode.OpenOrCreate);

        public static void ClearFile(string fileName) => File.WriteAllText(directory + fileName, string.Empty);

        public static void OverwriteFile(string fileName, string value) => File.WriteAllText(directory + fileName, value);


        public static string[] ReadFile(string fileName) => File.ReadAllLines(directory + fileName);

        

    }
}