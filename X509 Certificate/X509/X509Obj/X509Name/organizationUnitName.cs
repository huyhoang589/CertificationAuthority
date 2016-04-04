﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509.X509Name
{
    class organizationUnitName
    {
        private string str_OU;
        private ByteArrayList bOU;

        public organizationUnitName()
        {
            bOU = new ByteArrayList();
        }

        public ByteArrayList get_OU()
        {
            ByteArrayList list = new ByteArrayList();
            byte[] temp = Encoding.UTF8.GetBytes(str_OU);

            ObjectsId oID = new ObjectsId("OU");
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID("OU");

            int len3 = temp.Length; // Длина строки
            int len2 = len3 + 2 + lID.getSize();
            int len1 = len2 + 2;

            list.Add(0x31); // SET
            list.Add(len1);
            list.Add(0x30); // SEQUENCE
            list.Add(len2);
            if (check.CheckID() == true) list.Add(lID.getArray());  // OBJ ID
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x13); // Print String
            list.Add(len3);
            for (int i = 0; i < len3; i++) list.Add(temp[i]);

            return list;
        }

        public void set_OU(string tmp)
        {
            str_OU = string.Copy(tmp);
        }
    }
}
