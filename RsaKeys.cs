using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_filecoder
{
    public class RsaKeys
    {
        private long N;
        private int[] Keys;
        private int p, q; 
       public long PublicKey {
           get {
               return this.Keys[0];
           }
           set {
               this.Keys[0] = value;
           }
       }
       public long PrivateKey
       {
           get
           {
               return this.Keys[1];
           }
           set {
               this.Keys[1] = value;
           }
       }
        
       public long Mod {
           get 
           {
               return this.N; 
            }
           set {
               this.N = value;
           }
       
       }
        

       public RsaKeys(long max,long PublicKey = 0) {
           Random rand = new Random();
           int value = rand.Next(40,(int)max);
           Keys = new long[2];
           this.p = GenerateSimpleNumber((long)value);
           this.q = GenerateSimpleNumber((long)value - 20);
            this.N = p*q;
            this.Keys[0] = GenerateSimpleNumber((this.p - 1) * (this.q - 1) - rand.Next(2,10));
          
       }
      public void GeneratePrivateKey(){
          Modarifm arifm = new Modarifm((this.p - 1) * (this.q - 1));
      this.Keys[1]= arifm.Reverse(this.Keys[0]);
      }
      public static long GenerateSimpleNumber(long n)
      {
          long[] a =new long[n];
          int k;
          for (int i = 0; i< n; i++)
              a[i] = 0; 
          
          //3 * i + 1 
          for (int i = 1; i < n; i++)
          {
              for (int j = 1; (k = i + j + 2 * i * j) < n && j <= i; j++)
                  a[k] = 1;
          }
          //Выбирает из списка простых чисел ближайшее к заданному.
          for (int i = (int)(n - 1); i >= 1; i--)
              if (a[i] == 0 && ((2*i + 1) < n))   
                  return (2 * i + 1);
         
           
          return 0;
      }


    }
}
