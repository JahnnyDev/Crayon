namespace Utilities
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


    }
}