using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509
{
    class AlgorithmSignature
    {
        string str_Alg;
        private ByteArrayList Alg;

        public AlgorithmSignature()
        {
            Alg = new ByteArrayList();
        }

        public ByteArrayList get_AlgSign()
        {
            ByteArrayList list = new ByteArrayList();

            ObjectsId oID = new ObjectsId(str_Alg);
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID(str_Alg);

            int len = lID.getSize()+2;

            list.Add(0x30); // SEQUENCE
            list.Add(len);
            if (check.CheckID() == true) list.Add(lID.getArray());// OBJ ID
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x05); // NULL
            list.Add(0x00);

            return list;
        }

        public void set_AlgSign(string tmp)
        {
            str_Alg = string.Copy(tmp);
        }
    }
}
