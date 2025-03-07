using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Crayon.Utilities
{
    public static class Binary
    {

        public static byte[] GetBytes<T>(T val) where T : struct
        {
            int size = Marshal.SizeOf(typeof(T));
            byte[] result = new byte[size];
            var gcHandle = GCHandle.Alloc(val, GCHandleType.Pinned);
            Marshal.Copy(gcHandle.AddrOfPinnedObject(), result, 0, size);
            gcHandle.Free();
            return result;
        }
        
        public static unsafe byte[] ArrayToBytes<T>(T[] array) where T : struct
        {
            byte[] result = new byte[sizeof(T) * array.Length];
            for (int i = 0; i < array.Length; i++) GetBytes(array[i]).CopyTo(result, i * sizeof(float));
            return result;
        }

        public static unsafe T[] BytesToArray<T>(byte[] bytes) where T : struct
        {
            T[] result = new T[bytes.Length / sizeof(T)];
            Func<byte[], int, T> bytesToGeneric =
                typeof(T) == typeof(bool) ? (b,i) => (T)(object)BitConverter.ToBoolean(b, i):
                typeof(T) == typeof(char) ? (b, i) => (T)(object)BitConverter.ToChar(b, i) :
                typeof(T) == typeof(double) ? (b, i) => (T)(object)BitConverter.ToDouble(b, i) :
                typeof(T) == typeof(Half) ? (b, i) => (T)(object)BitConverter.ToHalf(b, i) :
                typeof(T) == typeof(short) ? (b, i) => (T)(object)BitConverter.ToInt16(b, i) :
                typeof(T) == typeof(int) ? (b, i) => (T)(object)BitConverter.ToInt32(b, i) :
                typeof(T) == typeof(long) ? (b, i) => (T)(object)BitConverter.ToInt64(b, i) :
                typeof(T) == typeof(float) ? (b, i) => (T)(object)BitConverter.ToSingle(b, i) :
                typeof(T) == typeof(string) ? (b, i) => (T)(object)BitConverter.ToString(b, i) :
                typeof(T) == typeof(ushort) ? (b, i) => (T)(object)BitConverter.ToUInt16(b, i) :
                typeof(T) == typeof(uint) ? (b, i) => (T)(object)BitConverter.ToUInt32(b, i) :
                typeof(T) == typeof(ulong) ? (b, i) => (T)(object)BitConverter.ToUInt64(b, i): 
                throw new InvalidDataException("The type " + typeof(T) + "is not a supported primitive datatype");

            for (int i = 0; i < result.Length; i++) result[i] = bytesToGeneric.Invoke(bytes, i * sizeof(T));

            return result;
            
        }
        public static byte[] Compress(byte[] data)
        {
            MemoryStream output = new MemoryStream();
            using (DeflateStream dstream = new DeflateStream(output, CompressionLevel.Optimal))
            {
                dstream.Write(data, 0, data.Length);
            }
            return output.ToArray();
        }
        public static byte[] Decompress(byte[] data)
        {
            MemoryStream input = new MemoryStream(data);
            MemoryStream output = new MemoryStream();
            using (DeflateStream dstream = new DeflateStream(input, CompressionMode.Decompress))
            {
                dstream.CopyTo(output);
            }
            return output.ToArray();
        }

        public static string StringEncode(byte[] data) => Convert.ToBase64String(data);
        public static byte[] StringDecode(string data) => Convert.FromBase64String(data);
    }
}
