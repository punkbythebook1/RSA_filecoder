using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_filecoder
{

    public class encrypt: RsaOperations
    {
         long RsaOperations.encrypt(byte B, RsaKeys Keys)
        {
            Modarifm arifm = new Modarifm(Keys.Mod);
            return arifm.FastPowR(B, Keys.PublicKey); 
                     
        }

         byte RsaOperations.decrypt(long block, RsaKeys Keys)
        {
           
            Modarifm arifm = new Modarifm(Keys.Mod);
            return (byte)arifm.FastPow(block, Keys.PrivateKey); 
            
        }

    }
}
