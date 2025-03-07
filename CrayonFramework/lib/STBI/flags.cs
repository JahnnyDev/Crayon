using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crayon.STBI
{
    public static class flags
    {
        public const int STBI_DEFAULT = 0; // only used for desired_channels

        public const int STBI_GRAY = 1;
        public const int STBI_GRAY_ALPHA = 2;
        public const int STBI_RGB = 3;
        public const int STBI_RGBA = 4;
    }
}
