using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Crayon.GL.Flags;
using System.Threading.Tasks;
using static Crayon.Utilities.ShaderPrecompiler;


namespace Crayon.Utilities
{
    public static class ShaderLibraries
    {

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
            boundCode += ImportLib[ReadTokenArg(currentLine, 0)] + "\n";
            return 3;
        }
        public static int EndShader()
        {
            shaderEnd = true;
            return 4;
        }

        private static Dictionary<string, string> ImportLib = new()
        {
            {
                "lerp",
                @"
                float lerp(float a, float b, float t)
                {
                    return a+((b-a)*t);
                }"
            },
        };

    }
}
