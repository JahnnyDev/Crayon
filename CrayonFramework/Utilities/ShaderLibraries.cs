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
        public static Dictionary<string, string> ImportLib = new()
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
