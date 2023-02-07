namespace StenographyMethods.LSB.Files
{
    public struct Paths
    {
        private const string Directory = @"D:\Files\";

        public const string TextFile = $"{Directory}text.txt",
            OriginalPicture = $"{Directory}original.tif",
            EncryptPicture = $"{Directory}encrypt.tif";
    }
}