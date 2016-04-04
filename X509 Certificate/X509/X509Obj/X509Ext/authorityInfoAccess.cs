using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509.X509Extended
{
    class authorityInfoAccess
    {
        private string str_auInfoAccess;

        public ByteArrayList get_auInfoAccess()
        {
            ByteArrayList list = new ByteArrayList();
            byte[] temp = Encoding.UTF8.GetBytes(str_auInfoAccess);

            ObjectsId oID1 = new ObjectsId("auinfoaccess");
            ByteArrayList lID1 = oID1.getID();
            CheckObjID check1 = new CheckObjID("auinfoaccess");

            ObjectsId oID2 = new ObjectsId("caissuer");
            ByteArrayList lID2 = oID2.getID();
            CheckObjID check2 = new CheckObjID("caissuer");

            int len1 = lID1.getSize();
            int len3 = lID2.getSize();
            int len4 = temp.Length;
            int len2 = len3 + len4 + 2;
            int len = len1 + len2 + 6;

            list.Add(0x30); // SEQUENCE
            list.Add(len);
            if (check1.CheckID() == true) list.Add(lID1.getArray());  //OBJ ID auinfoaccess
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x04); // OCTET STRING
            list.Add(len2 + 4);
            list.Add(0x30); // SEQUENCE
            list.Add(len2 + 2);
            list.Add(0x30); // SEQUENCE
            list.Add(len2);
            if (check2.CheckID() == true) list.Add(lID2.getArray());  //OBJ ID caissuer
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x86); // [6]
            list.Add(len4);
            for (int i = 0; i < len4; i++) list.Add(temp[i]);

            return list;
        }

        public void set_auInfoAccess(string tmp)
        {
            str_auInfoAccess = string.Copy(tmp);
        }
    }
}
