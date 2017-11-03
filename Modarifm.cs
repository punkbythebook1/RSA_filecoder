using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA_filecoder
{
    public class Modarifm
    {
        private long mod;

        public Modarifm(long mod)
        {
            this.mod = mod;
        }
        public long Reverse(long A)
        {

            long Q;
            long R;
            long u1, u2;
            long v1, v2;
            u2 = 1; u1 = 0; v2 = 0; v1 = 1;
            long u, v;
            long B = this.mod;
            while (B != 0)
            {
                Q = A / B;
                R = A - Q * B;
                u = u2 - Q * u1;
                v = v2 - Q * v1;

                A = B; B = R;
                u2 = u1;
                u1 = u;
                v2 = v1;
                v1 = v;

            }
            long d = A;
            if (d != 1)
                throw new Exception("A необратима по данному модулю!");

            long x = u2;
            if (x < 0)
                return this.mod + x;
            else
                return x;

        }

        public long FastPow(long A, long n)
        {
            long Q = n;
            long S = 1;
            long X = A;
            do
            {
                if (Q % 2 != 0)
                {
                    S = (X * S) % this.mod;
                    X = (X * X) % this.mod; 
                }
                else
                {
                    
                    X = (X * X) % this.mod;
                }

                Q = (long)(Q / 2);
            } while (Q != 0);
            return S;
        }

        public long FastPowR(long x, long n)
        {

            if (n == 0) return 1;
            long z = FastPowR(x, n / 2);
            if (n % 2 == 0)
                return (z * z) % this.mod;
            else
                return (x * z * z) % this.mod;
        }

    }
}
