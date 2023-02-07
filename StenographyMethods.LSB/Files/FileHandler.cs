using System.IO;
using System.Text;

namespace StenographyMethods.LSB.Files
{
    public static class FileHandler
    {

        public static void WriteToTextFile(string fileName, string? text)
        {
            using var writer = new StreamWriter(fileName);
            writer.Write(text!, Encoding.UTF8);
        }

        public static string ReadFromTextFile(string fileName)
        {
            using var reader = new StreamReader(fileName);
            return reader.ReadToEnd();
        }
        
        public static void WriteToImageFile(string fileName, byte[] content)
        {
            File.WriteAllBytes(fileName, content);
        }

        public static byte[] ReadFromImageFile(string fileName)
        {
            return File.ReadAllBytes(fileName);
        }
    }
}