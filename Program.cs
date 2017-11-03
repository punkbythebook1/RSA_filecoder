using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace RSA_filecoder
{
    class Program
    {
        static void Main(string[] args)
        {

             //RsaKeys keys = File.FileEncrypte("D:/example.txt");
            // Console.WriteLine("Private key: " + keys.PrivateKey);
           // RsaKeys key = new RsaKeys();
           // key.PrivateKey = 331103;
            //key.Mod = 1021 * 929;
           RsaKeys key = File.FileEncrypte("example.txt",4000);
           File.FileDecrypt("myfile.txt", "example.txtENCYPTED", key);
          //  long simpnimb = RsaKeys.GenerateSimpleNumber(2870);
            //Console.WriteLine("sim_numb" + simpnimb);
            Console.WriteLine("FILE ENCRYPTED!");

           Console.ReadKey();
           }
    }
}
/*
  FileStream file = new FileStream("D:/example.txt",FileMode.Open);
            FileStream file1 = new FileStream("D:/exampleENCRYPT", FileMode.Create);
            StreamWriter filetxt = new StreamWriter(file1,Encoding.ASCII);

            encrypt ENC = new encrypt();
            RsaKeys keys = new RsaKeys(1021,929,2207);
            keys.GeneratePrivateKey();

            RsaOperations rsa = ENC;
           
            byte symbol;
            int i = 0;
          
            while(i < file.Length)
            {
                symbol = (byte)file.ReadByte();
                filetxt.WriteLine(rsa.encrypt(symbol,keys) );
                i++;
            }
            
            filetxt.Close();
            file.Close();


            i = 0;
            long block;
            char message;
            string line;
            StreamReader filetxt2 = new StreamReader("D:/exampleENCRYPT", Encoding.ASCII);
            while ((line = filetxt2.ReadLine()) != null )
            {
                long.TryParse(line, out block);
                message = (char)rsa.decrypt(block, keys);
                Console.WriteLine(message);
                i++;
            }
            filetxt2.Close();
 
 */