using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Utilities
{
    public static class ImageLoader
    {
        public static byte[] loadBMP(string path)
        {
            return File.ReadAllBytes(path);
        }
    }
}
