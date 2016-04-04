using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509.CRLExtended
{
    class CRLNumber
    {
        string strSource = "0123456789ABCDEF";
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

        public ByteArrayList get_CRLNumber()
        {
            string Num = RandomString(20, strSource);
            byte[] bytes_CertNum = HexStringToByteArrayConverter.Convert(Num);

            ByteArrayList list = new ByteArrayList();

            ObjectsId oID = new ObjectsId("crlnumber");
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID("crlnumber");

            list.Add(0x30); // SEQUENCE
            list.Add(0x13); // 19 байт длины
            if (check.CheckID() == true) list.Add(lID.getArray());  //OBJ ID 
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x04); // OCTET STRING
            list.Add(0x0C); // 12 байт длины
            list.Add(0x02); // INTEGER
            list.Add(0x0A); // 10 байт длины
            list.Add(bytes_CertNum);

            return list;
        }
    }
}
