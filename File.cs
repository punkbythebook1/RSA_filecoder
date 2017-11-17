//THISE COMMENT TO TEST REMOTE GITHUB!!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RSA_filecoder
{
    public static class File
    {
		
        public static RsaKeys FileEncrypte(string path, long max)
     {
         FileStream file = new FileStream(path, FileMode.Open);
         FileStream file1 = new FileStream(path+"ENCYPTED", FileMode.Create);
         StreamWriter filetxt = new StreamWriter(file1, Encoding.ASCII);

         encrypt ENC = new encrypt();
         RsaOperations rsa = ENC;
         RsaKeys keys = new RsaKeys(max);
         keys.GeneratePrivateKey();
       
         byte symbol;
         int i = 0;

         while (i < file.Length)
         {
             symbol = (byte)file.ReadByte();
             filetxt.WriteLine(rsa.encrypt(symbol, keys));
             i++;
         }

         filetxt.Close();
         file.Close();
         return keys;
     }

        public static void FileDecrypt(string pathdec, string pathencr, RsaKeys keys)
     {
         long block;
        // char message;
         string line;
         int i = 0;
         encrypt ENC = new encrypt();
         RsaOperations rsa = ENC;
         FileStream fileb = new FileStream(pathencr,FileMode.Open);
         StreamReader filetxtr = new StreamReader(fileb, Encoding.ASCII);
         FileStream filedec = new FileStream(pathdec, FileMode.Create);
       
         while ((line = filetxtr.ReadLine()) != null)
         {
             long.TryParse(line, out block);
             filedec.WriteByte(rsa.decrypt(block, keys));
             i++;
         }
         
         filetxtr.Close();
         filedec.Close();
     }

    }
}
