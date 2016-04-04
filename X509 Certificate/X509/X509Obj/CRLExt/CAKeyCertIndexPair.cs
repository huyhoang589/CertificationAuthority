using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509.CRLExtended
{
    class CAKeyCertIndexPair
    {
        private string Version;

        public ByteArrayList get_CAKeyCertIndexPair()
        {
            ByteArrayList list = new ByteArrayList();

            byte[] tmp = HexStringToByteArrayConverter.Convert(Version);

            ObjectsId oID = new ObjectsId("cakeycertindexpair");
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID("cakeycertindexpair");

            int len = lID.getSize() + tmp.Length + 4;

            list.Add(0x30);             // SEQUENCE
            list.Add(len);
            if (check.CheckID() == true) list.Add(lID.getArray());  //OBJ ID 
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x04);             // OCTET STRING
            list.Add(tmp.Length + 2);
            list.Add(0x02);             // INTEGER
            list.Add(tmp.Length);
            list.Add(tmp);

            return list;
        }

        public void set_VersionCenterCert(string Ver)
        {
            Version = string.Copy(Ver);
        }
    }
}
