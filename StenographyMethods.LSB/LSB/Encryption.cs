namespace StenographyMethods.LSB.LSB
{
    public abstract class Encryption
    {
        private protected readonly byte[] Image;

        protected Encryption(byte[] image)
        {
            this.Image = image;
        }

        public abstract dynamic ProcessPicture();

        private protected abstract string GetBits(dynamic value);
        
    }
}