using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BigIntegerClass;


namespace ECPointClass
{
    public class ECPoint
    {
        
            
            public BigInteger x;
            public BigInteger y;
            public BigInteger a;      
            public BigInteger b;
            public BigInteger FieldChar;

            public ECPoint(ECPoint p)
            {
                x = p.x;
                y = p.y;
                a = p.a;
                b = p.b;
                FieldChar = p.FieldChar;
            }

            public ECPoint()
            {
                x = new BigInteger();
                y = new BigInteger();
                a = new BigInteger();
                b = new BigInteger();
                FieldChar = new BigInteger();
            }
                 
            // Реализация расширенного алгоритма Евклида
            public static BigInteger modInverse(BigInteger a, BigInteger n)
            {
                BigInteger i = n, v = 0, d = 1;
                while (a > 0)
                {
                    BigInteger t = i / a, x = a;
                    a = i % x;
                    i = x;
                    x = d;
                    d = v - t * x;
                    v = x;
                }
                v %= n;
                if (v < 0) v = (v + n) % n;
                return v;
            } 

            //сложение двух точек P1 и P2
            public static ECPoint operator +(ECPoint p1, ECPoint p2)
            {
                ECPoint p3 = new ECPoint();
                p3.a = p1.a;
                p3.b = p1.b;
                p3.FieldChar = p1.FieldChar;

                BigInteger dy = p2.y - p1.y;
                BigInteger dx = p2.x - p1.x;

                if (dx < 0)
                    dx += p1.FieldChar;
                if (dy < 0)
                    dy += p1.FieldChar;

               // BigInteger m = (dy * dx.modInverse(p1.FieldChar)) % p1.FieldChar;
                BigInteger modInverse_dx = modInverse(dx, p1.FieldChar);
                BigInteger m = (dy * modInverse_dx) % p1.FieldChar;
                if (m < 0)
                    m += p1.FieldChar;
                p3.x = (m * m - p1.x - p2.x) % p1.FieldChar;
                p3.y = (m * (p1.x - p3.x) - p1.y) % p1.FieldChar;
                if (p3.x < 0)
                    p3.x += p1.FieldChar;
                if (p3.y < 0)
                    p3.y += p1.FieldChar;
                return p3;
            }
            //сложение точки P c собой же
            public static ECPoint Double(ECPoint p)
            {
                ECPoint p2 = new ECPoint();
                p2.a = p.a;
                p2.b = p.b;
                p2.FieldChar = p.FieldChar;

                BigInteger dy = 3 * p.x * p.x + p.a;
                BigInteger dx = 2 * p.y;

                if (dx < 0)
                    dx += p.FieldChar;
                if (dy < 0)
                    dy += p.FieldChar;
                
                //BigInteger m = (dy * dx.modInverse(p.FieldChar)) % p.FieldChar;
                BigInteger modInverse_dx = modInverse(dx, p.FieldChar);
                BigInteger m = (dy * modInverse_dx) % p.FieldChar;
                p2.x = (m * m - p.x - p.x) % p.FieldChar;
                p2.y = (m * (p.x - p2.x) - p.y) % p.FieldChar;
                if (p2.x < 0)
                    p2.x += p.FieldChar;
                if (p2.y < 0)
                    p2.y += p.FieldChar;

                return p2;
            }

            //умножение точки на число x, по сути своей представляет x сложений точки самой с собой
            public static ECPoint multiply(BigInteger x, ECPoint p)
            {
                ECPoint temp = p;
                x = x - 1;
                while (x != 0)
                {

                    if ((x % 2) != 0)
                    {
                        if ((temp.x == p.x) || (temp.y == p.y))
                            temp = Double(temp);
                        else
                            temp = temp + p;
                        x = x - 1;
                    }
                    x = x / 2;
                    p = Double(p);
                }
                return temp;
            }

        //-------------------TEST ECPointClass----------------
        /*
            static void Main(string[] args)
            {
                // EC Test : Y2 = X3 + X + 2 ( mod 11 )
                ECPoint P1 = new ECPoint();
                ECPoint P2 = new ECPoint();
                P1.x = 1; P1.y = 2; P1.a = 1; P1.b = 2; P1.FieldChar = 11;
                P2.x = 1; P2.y = 9; P2.a = 1; P2.b = 2; P2.FieldChar = 11;

                //сложение двух точек P1 и P2
                ECPoint P3 = new ECPoint();
                P3 = P1 + P2;
                Console.WriteLine("P3 = P1 + P2 : x = {0} ; y = {1}", P3.x, P3.y);

                //сложение точки P1 c собой же
                ECPoint P1_double = new ECPoint();
                P1_double = ECPoint.Double(P1);
                Console.WriteLine("P1_double : x = {0} ; y = {1}", P1_double.x, P1_double.y);

                //умножение точки на число x
                ECPoint multiply_P1 = new ECPoint();
                multiply_P1 = ECPoint.multiply(3, P1);
                Console.WriteLine("multiply_P1 : x = {0} ; y = {1}", multiply_P1 .x, multiply_P1 .y);
            }
         */
    }
}
