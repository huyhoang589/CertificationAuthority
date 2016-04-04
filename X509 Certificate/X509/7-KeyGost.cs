using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509
{
    class KeyGOST
    {
        private ByteArrayList pubKey;
        private int len1, len2, len3, len4, len5;

        public KeyGOST()
        {
            pubKey = new ByteArrayList();
        }

        public ByteArrayList get_KeyGOST()
        {
            ByteArrayList list = new ByteArrayList();

            ObjectsId oID1 = new ObjectsId("gost341012");
            ByteArrayList lID1 = oID1.getID();
            CheckObjID check1 = new CheckObjID("gost341012");

            ObjectsId oID2 = new ObjectsId("gost341012paramseta");
            ByteArrayList lID2 = oID2.getID();
            CheckObjID check2 = new CheckObjID("gost341012paramseta");

            ObjectsId oID3 = new ObjectsId("gost341112");
            ByteArrayList lID3 = oID3.getID();
            CheckObjID check3 = new CheckObjID("gost341112");

            len5 = pubKey.getSize();
            len4 = len5 + 4;
            len3 = lID2.getSize() + lID3.getSize();
            len2 = len3 + 2 + lID1.getSize();
            len1 = len2 + len4 + 5;

            list.Add(0x30); // SEQUENCE
            list.Add(0x81);
            list.Add(len1);
            list.Add(0x30); // SEQUENCE
            list.Add(len2);
            if (check1.CheckID() == true) list.Add(lID1.getArray());  // OBJ ID gost341012
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x30); // SEQUENCE
            list.Add(len3);
            if (check2.CheckID() == true) list.Add(lID2.getArray());  // OBJ ID gost341012paramseta
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            if (check3.CheckID() == true) list.Add(lID3.getArray());  // OBJ ID gost341112
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x03); // BIT STRING
            list.Add(0x81);
            list.Add(len4);
            list.Add(0x00);
            list.Add(0x04); // OCTET STRING
            list.Add(0x81);
            list.Add(len5);
            list.Add(pubKey.getArray());

            return list;
        }

        public void set_keyGOST(ByteArrayList tmp)
        {
            pubKey.Add(tmp.getArray());
        }
    }
}
