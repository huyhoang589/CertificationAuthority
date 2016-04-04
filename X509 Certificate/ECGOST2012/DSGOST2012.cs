using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BigIntegerClass;
using ECPointClass;
using HGOST2012;
using Utilities;
using ECParamSet;



namespace DSGOST2012
{
    class DSGost
    {
        
        private BigInteger p = new BigInteger();
        private BigInteger a = new BigInteger();
        private BigInteger b = new BigInteger();
        private BigInteger n = new BigInteger();
        private BigInteger xG = new BigInteger();
        private BigInteger yG = new BigInteger();

        private ECPoint G = new ECPoint();

        public BigInteger get_a()
        {
            return this.a;
        }

        public BigInteger get_b()
        {
            return this.b;
        }

        public BigInteger get_FieldChar()
        {
            return this.p;
        }

        public DSGost (string paramSetName)
        {
            ParamSet param = new ParamSet(paramSetName);
            this.a = param.get_a();
            this.b = param.get_b();
            this.n = param.get_n();
            this.p = param.get_p();
            this.xG = param.get_xG();
            this.yG = param.get_yG();
          
        }
        //Генерируем секретный ключ заданной длины
        public BigInteger GenPrivateKey(int BitSize)
        {
            BigInteger d = new BigInteger();
            do
            {
                d.genRandomBits(BitSize, new Random());
            } while ((d < 0) || (d > n));
            return d;
        }

        //С помощью секретного ключа d вычисляем точку Q=d*G, это и будет наш публичный ключ
        public ECPoint GenPublicKey(BigInteger d)
        {
            ECPoint G=GDecompression();
            ECPoint Q = ECPoint.multiply(d, G);
            return Q;
        }

        //Восстанавливаем координату y из координаты x и бита четности y 
        private ECPoint GDecompression()
        {
            ECPoint G = new ECPoint();
            G.a = a;
            G.b = b;
            G.FieldChar = p;
            G.x = xG;
            G.y = yG;
            this.G = G;
            return G;
        }

        //функция вычисления квадратоного корня по модулю простого числа q
        public BigInteger ModSqrt(BigInteger a, BigInteger q)
        {
            BigInteger b = new BigInteger();
            do
            {
                b.genRandomBits(255, new Random());
            } while (Legendre(b, q) == 1);
            BigInteger s = 0;
            BigInteger t = q - 1;
            while ((t & 1) != 1)
            {
                s++;
                t = t >> 1;
            }
            BigInteger InvA = a.modInverse(q);
            BigInteger c = b.modPow(t, q);
            BigInteger r = a.modPow(((t + 1) / 2), q);
            BigInteger d = new BigInteger();
            for (int i = 1; i < s; i++)
            {
                BigInteger temp = 2;
                temp = temp.modPow((s - i - 1), q);
                d = (r.modPow(2, q) * InvA).modPow(temp, q);
                if (d == (q - 1))
                    r = (r * c) % q;
                c = c.modPow(2, q);
            }
            return r;
        }

        //Вычисляем символ Лежандра
        public BigInteger Legendre(BigInteger a, BigInteger q)
        {
            return a.modPow((q - 1) / 2, q);
        }

        //подписываем сообщение
        public string SignGen(byte[] h, byte[] d_arr)
        {
            ECPoint G = GDecompression();
            BigInteger d = new BigInteger(d_arr);
            BigInteger alpha = new BigInteger(h);
            BigInteger e = alpha % n;
            if (e == 0)
                e = 1;
            BigInteger k = new BigInteger();
            ECPoint C=new ECPoint();
            BigInteger r=new BigInteger();
            BigInteger s = new BigInteger();
            do
            {
                do
                {
                    k.genRandomBits(n.bitCount(), new Random());
                } while ((k < 0) || (k > n));
                C = ECPoint.multiply(k, G);
                r = C.x % n;
                s = ((r * d) + (k * e)) % n;
            } while ((r == 0)||(s==0));
            string Rvector = padding(r.ToHexString(),n.bitCount()/4);
            string Svector = padding(s.ToHexString(), n.bitCount() / 4);
            return Rvector + Svector;
        }

        //проверяем подпись 
        public bool SignVer(byte[] H, string sign, ECPoint Q)
        {
            string Rvector = sign.Substring(0, n.bitCount() / 4);
            string Svector = sign.Substring(n.bitCount() / 4, n.bitCount() / 4);
            BigInteger r = new BigInteger(Rvector, 16);
            BigInteger s = new BigInteger(Svector, 16);
            if ((r < 1) || (r > (n - 1)) || (s < 1) || (s > (n - 1)))
                return false;
            BigInteger alpha = new BigInteger(H);
            BigInteger e = alpha % n;
            if (e == 0)
                e = 1;
            BigInteger v = e.modInverse(n);
            BigInteger z1 = (s * v) % n;
            BigInteger z2 = n + ((-(r * v)) % n);
            this.G = GDecompression();
            ECPoint A = ECPoint.multiply(z1, G);
            ECPoint B = ECPoint.multiply(z2, Q);
            ECPoint C = A + B;
            BigInteger R = C.x % n;
            if (R == r)
                return true;
            else
                return false;
        }

        //дополняем подпись нулями слева до длины n, где n - длина модуля в битах
        private string padding(string input, int size)
        {
            if (input.Length < size)
            {
                do
                {
                    input = "0" + input;
                } while (input.Length < size);
            }
            return input;
        }
    //------------------------------------TEST DSGost--------------------------------
       /* 
        static void Main(string[] args)
        {
            
            DSGost DS = new DSGost("paramSetA");

            Console.Write("\n DS_a = {0:X}" , DS.a);
            Console.Write("\n DS_b = {0:X}" , DS.b);
            Console.Write("\n DS_p = {0:X}" , DS.p);
            Console.Write("\n DS_n = {0:X}" , DS.n);
            Console.Write("\n DS_xG = {0:X}" , DS.xG);

            BigInteger d = DS.GenPrivateKey(256);
            Console.WriteLine("\nPrivateKey d : {0}", d);
          //  BigInteger d = new BigInteger("7F2B49E270DB6D90D8595BEC458B50C58585BA1D4E9B788F6689DBD8E56FD80B", 16);
           
            ECPoint Q = DS.GenPublicKey(d);
            Console.WriteLine("\nPublicKey Q : xQ = {0:X} \n yQ = {1:X} \n Q.a = {2:X} \n Q.b ={3:X} \n Q.p = {4:X}", Q.x, Q.y, Q.a, Q.b, Q.FieldChar);
           
            GOST hash = new GOST(512);
            byte[] H = hash.GetHash(Encoding.Default.GetBytes("MessageInForTest"));
            Console.WriteLine("\nHashLength = {0}", H.Length);
            Console.WriteLine("\nHash = ");
            for (int i = 0; i < H.Length; i++)
                Console.Write("{0:X}", H[i]);

            string sign = DS.SignGen(H, d);
            Console.WriteLine("\nSign = {0:X}", sign);
            Console.WriteLine("SignLength = {0}", sign.Length);

            bool checkSign = DS.SignVer(H, sign, Q);
            Console.WriteLine("Check Sign : {0}", checkSign);
            Console.ReadKey(true);
            
        }
       */  
    }
}
