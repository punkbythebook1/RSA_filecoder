using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_filecoder
{
    interface RsaOperations
    {
      long encrypt(byte B, RsaKeys Keys);
      byte decrypt(long B, RsaKeys Keys);
    }
}
