using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Security.Cryptography;

namespace X509.CRLExtended
{
    class CRLauID
    {
        private ByteArrayList CA_key;

        public CRLauID()
        {
            CA_key = new ByteArrayList();
        }

        public ByteArrayList get_CLRauID()
        {
            byte[] tmp_CAkey = CA_key.getArray();
            byte[] tmp_H;
            SHA1 sha1 = SHA1.Create();
            tmp_H = new SHA1CryptoServiceProvider().ComputeHash(tmp_CAkey);

            ByteArrayList list = new ByteArrayList();

            ObjectsId oID = new ObjectsId("authorkeyid");
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID("authorkeyid");

            list.Add(0x30); // SEQUENCE
            list.Add(0x1F); // 31 байт длины
            if (check.CheckID() == true) list.Add(lID.getArray());  // OBJ ID Authority Key Identifier 2.5.29.35
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x04); // OCTET STRING
            list.Add(0x18); // 24 байт длины
            list.Add(0x30); // SEQUENCE
            list.Add(0x16);
            list.Add(0x80); // [0]
            list.Add(0x14);
            list.Add(tmp_H);

            return list;

        }

        public void set_CAkey(ByteArrayList tmp)
        {
            CA_key.Add(tmp.getArray());
        }
    }
}
