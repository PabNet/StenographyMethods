using System;
using System.Text;

namespace StenographyMethods.LSB.LSB
{
    
    public class Encoder : Encryption
    {
        private readonly string _text;

        public Encoder(string text, byte[] image) : base(image)
        {
            this._text = text;
        }
        
        private byte ChangeBits(byte imageByte, string bits)
        {
            return Convert.ToByte(new StringBuilder(Convert.ToString(imageByte, 2)
                .PadLeft(8, '0'))
            {
                [6] = bits[0], [7] = bits[1]
            }.ToString(), 2);
        }

        public override dynamic ProcessPicture()
        {
            var bits = "";
            Array.ForEach(this._text.ToCharArray(), letter => bits += GetBits(letter));

            for (int i = this.Image.Length - 1, j = 0;
                j < bits.Length;
                i--, j += 2)
            {
                this.Image[i] = ChangeBits(this.Image[i], bits.Substring(j, 2));
            }
            
            return this.Image;
        }

        private protected override string GetBits(dynamic value)
        {
            return Convert.ToString((char)value, 2).PadLeft(16, '0');
        }
    }
}