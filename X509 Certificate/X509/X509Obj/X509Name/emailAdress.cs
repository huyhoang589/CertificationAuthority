using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509.X509Name
{
    class EmailAdress
    {
        private string str_email;

        public ByteArrayList get_emailAdress()
        {
            ByteArrayList list = new ByteArrayList();
            byte[] temp = Encoding.UTF8.GetBytes(str_email);

            ObjectsId oID = new ObjectsId("Email");
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID("Email");

            int len3 = temp.Length; // Длина строки
            int len2 = len3 + 2 + lID.getSize();
            int len1 = len2 + 2;

            list.Add(0x31); // SET
            list.Add(len1);
            list.Add(0x30); // SEQUENCE
            list.Add(len2);
            if (check.CheckID() == true) list.Add(lID.getArray());  //OBJ ID
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x16); // IA5String 
            list.Add(len3);
            for (int i = 0; i < len3; i++) list.Add(temp[i]);

            return list;
        }

        public void set_emailAdress(string tmp)
        {
            str_email = string.Copy(tmp);
        }
    }
}
