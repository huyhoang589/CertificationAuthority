using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509.Certificate
{
    class AlgorithmSignCert
    {
        private string str_algsign;

        public ByteArrayList get_AlgSignCert()
        {
            ByteArrayList list = new ByteArrayList();
            byte[] temp = Encoding.UTF8.GetBytes(str_algsign);

            ObjectsId oID = new ObjectsId(str_algsign);
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID(str_algsign);

            int len = lID.getSize() +2;

            list.Add(0x30); // SEQUENCE
            list.Add(len);
            if (check.CheckID() == true) list.Add(lID.getArray());  //OBJ ID
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x05); // NULL
            list.Add(0x00);

            return list;

        }

        public void set_AlgSignCert(string tmp)
        {
            str_algsign = string.Copy(tmp);
        }
    }
}
