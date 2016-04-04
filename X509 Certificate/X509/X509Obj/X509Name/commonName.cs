using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509.X509Name
{
    class commonName
    {
        private string str_commonName;
        private ByteArrayList bCN;

        public commonName()
        {
            bCN = new ByteArrayList();
        }

        public ByteArrayList get_commonName()
        {
            ByteArrayList list = new ByteArrayList();
            byte[] temp = Encoding.UTF8.GetBytes(str_commonName);

            ObjectsId oID = new ObjectsId("CN");
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID("CN");

            int len3 = temp.Length; // Длина строки
            int len2 = len3 + 2 + lID.getSize();
            int len1 = len2 + 2;

            list.Add(0x31); // SET
            list.Add(len1);
            list.Add(0x30); // SEQUENCE
            list.Add(len2);
            if (check.CheckID() == true) list.Add(lID.getArray());  //OBJ ID
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x0C); // Print String / UTF8 String
            list.Add(len3);
            for (int i = 0; i < len3; i++) list.Add(temp[i]);

            return list;
        }

        public void set_commonName(string tmp)
        {
            str_commonName = string.Copy(tmp);
        }
    }
}
