using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509
{
    class Serial
    {
        private string strSource = "0123456789ABCDEF";
        private string CertNum;
        private string RandomString(int size, string strSource)
        {
            Random rand = new Random();
            char[] charArr = new char[size];
            int lenghtSrc = strSource.Length;
            for (int i = 0; i < size; i++)
            {
                charArr[i] = strSource[(int)(lenghtSrc * rand.NextDouble())];
            }
            return new string(charArr);
        }
        
        public ByteArrayList get_Serial()
        {
            CertNum = RandomString(20, strSource);
            byte[] bytes_CertNum = HexStringToByteArrayConverter.Convert(CertNum);

            ByteArrayList list = new ByteArrayList();
            list.Add(0x02);
            list.Add(0x0A); // 10 байт сериийный номер
            list.Add(bytes_CertNum);

            return list;
        }

        public string get_strSerial()
        {
            return CertNum;
        }
    }
}
