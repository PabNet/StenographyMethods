using System;

namespace StenographyMethods.LSB.LSB
{
    public class Decoder : Encryption
    {
        public Decoder(byte[] image) : base(image) {}
        
        public override dynamic ProcessPicture()
        {
            string message = "", decryptMessage = "";
            for (var i = this.Image.Length - 1; 
                i > 0; 
                i--)
            {
                message += GetBits(this.Image[i]);
            }
            
            for (var i = 0;
                i < message.Length;
                 i += 16)
            {
                decryptMessage += (char)Convert.ToInt16(message
                    .Substring(i, 16), 2);
                
                if (decryptMessage[^1] == 0)
                {
                    break;
                }
            }

            return decryptMessage;
        }

        private protected override string GetBits(dynamic value)
        {
            return Convert.ToString((byte)value, 2).PadLeft(8, '0').Substring(6, 2);
        }
    }
}