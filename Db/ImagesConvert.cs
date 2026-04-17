using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Db
{
    public class ImagesConvert
    {
        /// <summary>
        /// Converts a byte array (image data) to a Base64 string for web display.
        /// Usage in Blazor: &lt;img src="data:image/png;base64,@base64String" /&gt;
        /// </summary>
        public string ByteArrayToBase64(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
                return string.Empty;

            return Convert.ToBase64String(byteArrayIn);
        }

        /// <summary>
        /// Converts a Base64 string back to a byte array.
        /// </summary>
        public byte[] Base64ToByteArray(string base64String)
        {
            if (string.IsNullOrWhiteSpace(base64String))
                return Array.Empty<byte>();

            return Convert.FromBase64String(base64String);
        }

        /// <summary>
        /// Reads an image file and returns it as a byte array.
        /// </summary>
        public byte[] FileToByteArray(string filePath)
        {
            if (!File.Exists(filePath))
                return Array.Empty<byte>();

            return File.ReadAllBytes(filePath);
        }

        /// <summary>
        /// Saves a byte array as an image file.
        /// </summary>
        public void ByteArrayToFile(byte[] byteArray, string filePath)
        {
            if (byteArray == null || byteArray.Length == 0)
                return;

            File.WriteAllBytes(filePath, byteArray);
        }

        /// <summary>
        /// Reads a stream (e.g., from file upload) and returns it as a byte array.
        /// </summary>
        public async Task<byte[]> StreamToByteArray(Stream stream)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                await stream.CopyToAsync(ms);
                return ms.ToArray();
            }
        }
    }
}
