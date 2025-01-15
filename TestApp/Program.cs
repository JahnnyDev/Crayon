using GL;
using static GL.Flags;
using Graphics;

namespace TestApp
{

    internal class Program
    {
        static unsafe void Main(string[] args)
        {
            Application application = new(800, 600, "sploingle");
            application.Run();
        }
    }
}