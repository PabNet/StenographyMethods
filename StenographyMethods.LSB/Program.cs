using System;
using StenographyMethods.LSB.Files;
using StenographyMethods.LSB.LSB;

namespace StenographyMethods.LSB
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Введите текст: ");     
            FileHandler.WriteToTextFile(Paths.TextFile,Console.ReadLine());
            
            FileHandler.WriteToImageFile(Paths.EncryptPicture, 
                new Encoder(FileHandler.ReadFromTextFile(Paths.TextFile),
                FileHandler.ReadFromImageFile(Paths.OriginalPicture)).ProcessPicture());

            Console.WriteLine("Текст, полученный в результате расшифровки картинки: " + 
                              new Decoder(FileHandler.ReadFromImageFile(Paths.EncryptPicture)).ProcessPicture());

        }
        
    }
}