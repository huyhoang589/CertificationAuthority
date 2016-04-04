using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Utilities;

namespace X509.X509Extended
{
    class cRLPoint
    {
        private string str_cRLPoint;

        public ByteArrayList get_cRLPoint()
        {
            ByteArrayList list = new ByteArrayList();
            byte[] temp = Encoding.UTF8.GetBytes(str_cRLPoint);

            ObjectsId oID = new ObjectsId("crlpoint");
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID("crlpoint");

            int len1 = lID.getSize();
            int len2 = temp.Length;
            int len = len1 + len2 + 12;

            list.Add(0x30); // SEQUENCE
            list.Add(len);
            if (check.CheckID() == true) list.Add(lID.getArray());  //OBJ ID
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x04); // OCTET STRING
            list.Add(len2 + 10);
            list.Add(0x30); // SEQUENCE
            list.Add(len2 + 8);
            list.Add(0x30); // SEQUENCE
            list.Add(len2 + 6);
            list.Add(0xA0); //  [0]
            list.Add(len2 + 4);
            list.Add(0xA0); // [0]
            list.Add(len2 + 2);
            list.Add(0x86); //  [6]
            list.Add(len2);
            for (int i = 0; i < len2; i++) list.Add(temp[i]);

            return list;
        }

        public void set_cRLPoint(string tmp)
        {
            str_cRLPoint = string.Copy(tmp);
        }
    }
}
