using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using Utilities;

namespace X509.X509Extended
{
    class SubjectKeyID
    {
        private ByteArrayList bSubKey;
        private ByteArrayList pubKey;

        public SubjectKeyID()
        {
            bSubKey = new ByteArrayList();
            pubKey = new ByteArrayList();
        }
        
        public ByteArrayList get_subKeyId ()
        {
            byte[] tmp_pubKey = pubKey.getArray();
            byte[] tmp_H;
            SHA1 sha1 = SHA1.Create();
            tmp_H = new SHA1CryptoServiceProvider().ComputeHash(tmp_pubKey);
                        
            ByteArrayList list = new ByteArrayList();

            ObjectsId oID = new ObjectsId("subkeyid");
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID("subkeyid");

            int len3 = tmp_H.Length;
            int len2 = len3 + 2;
            int len1 = len2 + 2 + lID.getSize();

            list.Add(0x30);             //SEQUENCE
            list.Add(len1);             //длина блока идентиф ключа субъекта
            if (check.CheckID() == true) list.Add(lID.getArray());  // OBJ ID Subject Key Identifier 2.5.29.14
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x04);             //OCTET STRING
            list.Add(len2);             // длина
            list.Add(0x04);             //OCTET STRING
            list.Add(len3);             //длина идентиф ключа
            list.Add(tmp_H);            //идентиф ключа

            return list;
        }

        public void set_pubKey(ByteArrayList tmp)
        {
            pubKey.Add(tmp.getArray());
        }
    }
}
