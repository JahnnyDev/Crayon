using Crayon.Graphics;
using static Crayon.GL.Flags;
using Crayon.Graphics.Buffers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Crayon.Utilities
{
    public static class MeshLoader
    {

        public static Mesh LoadMesh(string fileName) 
        {
            string file = string.Join("\n",AssetManager.ReadFile("Meshes\\" + fileName + ".msh"));
            string[] regions = file.Split("@REGION", StringSplitOptions.RemoveEmptyEntries).Select(l => l.Split("@INDICES")[0]).ToArray();

            BufferTemplate<float>[] templates = new BufferTemplate<float>[regions.Length];
            var data = new List<float[]>(regions.Length);
            uint[] indexData;
            for(int i = 0; i<regions.Length; i++)
            {
                string[] r = regions[i].Split('\n');
                if (r.Length < 2) throw new ArgumentNullException(" Mesh File Region " + i +" in " + fileName + " was improporly declared");

                string[] regionArgs = r[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string[] regionData = r[1..r.Length].SelectMany(l =>l.Split(' ', StringSplitOptions.RemoveEmptyEntries)).ToArray();

                templates[i] = new(GL_STATIC_DRAW, int.Parse(regionArgs[1]));
                data.Add(regionData.Select(float.Parse).ToArray());
                Console.WriteLine("Region args: " + string.Join(", ", regionArgs));
                Console.WriteLine("Region data: " + string.Join(", ", data));
            }
            string indexRegion = file.Split("@INDICES", StringSplitOptions.RemoveEmptyEntries)[1];

            string[] l = indexRegion.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            indexData = l[0..l.Length].SelectMany(s => s.Split(' ', StringSplitOptions.RemoveEmptyEntries)).Select(uint.Parse).ToArray();

            return new Mesh(templates, data.ToArray(), indexData);

        }

    }
}
