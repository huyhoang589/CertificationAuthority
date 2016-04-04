using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Utilities;
using System.Security.Cryptography;

namespace X509.X509Extended
{
    class AuthorityKeyId
    {
        private ByteArrayList CA_key;
        private ByteArrayList IssuerInfo;
        private ByteArrayList serial_CAcert;
        int len, len2, len21, len212, len2121;
       
        public AuthorityKeyId()
        {
            CA_key = new ByteArrayList();
            IssuerInfo = new ByteArrayList();
            serial_CAcert = new ByteArrayList();
        }

        public ByteArrayList get_AuthorityKeyId()
        {
            byte[] tmp_CAkey = CA_key.getArray();
            byte[] tmp_H;
            SHA1 sha1 = SHA1.Create();
            tmp_H = new SHA1CryptoServiceProvider().ComputeHash(tmp_CAkey);

            ByteArrayList list = new ByteArrayList();

            ObjectsId oID = new ObjectsId("authorkeyid");
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID("authorkeyid");

            int len213 = serial_CAcert.getSize();
            len2121 = IssuerInfo.getSize();
            if (len2121 <= 255) len212 = len2121 + 3; else len212 = len2121 + 4;
            int len211 = tmp_H.Length;
            if (len212 <= 255) len21 = len211 + 2 + len212 + 3 + len213 + 2; else len21 = len211 + 2 + len212 + 4 + len213 + 2;

            if (len21 <= 255) len2 = len21 + 3; else len2 = len21 + 4;
            int len1 = lID.getSize();

            if (len2 <= 255) len = len1 + len2 + 3; else len = len1 + len2 + 4;

            list.Add(0x30); // SEQUENCE
            if (len <= 255) list.Add(0x81); else list.Add(0x82);
            list.Add(len);
            if (check.CheckID() == true) list.Add(lID.getArray());  // OBJ ID Authority Key Identifier 2.5.29.35
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x04); // OCTET STRING
            if (len2 <= 255) list.Add(0x81); else list.Add(0x82);
            list.Add(len2);
            list.Add(0x30); // SEQUENCE
            if (len21 <= 255) list.Add(0x81); else list.Add(0x82);
            list.Add(len21);
            list.Add(0x80); // [0]
            list.Add(len211);
            list.Add(tmp_H);
            if (len2121 != 0)
            list.Add(0xA1); // [1]
            if (len212 <= 255) list.Add(0x81); else list.Add(0x82);
            list.Add(len212);
            list.Add(0xA4); // [4]
            if (len2121 <= 255) list.Add(0x81); else list.Add(0x82);
            list.Add(len2121);
            list.Add(IssuerInfo.getArray());
            list.Add(0x82); // [2]
            list.Add(len213);
            list.Add(serial_CAcert.getArray());
            

            return list;
        }

        public void set_CAkey(ByteArrayList tmp)
        {
            CA_key.Add(tmp.getArray());
        }

        public void set_IssuerInfo(ByteArrayList tmp)
        {
            IssuerInfo.Add(tmp.getArray());
        }

        public void set_seriaCAcert(ByteArrayList tmp)
        {
            serial_CAcert.Add(tmp.getArray());
        }
    }
}
