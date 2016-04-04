using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using HGOST2012;

namespace X509.Certificate
{
    class SignValue
    {
        private ByteArrayList bSignOut;
        private bool checksign;

        public SignValue()
        {
            bSignOut = new ByteArrayList();
        }

        public ByteArrayList get_Signature()
        {
            GOST hash = new GOST(512);
            byte[] bytes_sign = bSignOut.getArray();
            byte[] H = hash.GetHash(bytes_sign);
            ByteArrayList list = new ByteArrayList();

            int len = H.Length + 1;
                       
            list.Add(0x03); // Bit String
            list.Add(len);
            list.Add(0x00);
            if (checksign == true) list.Add(H);
            
            return list;
        }

        public void set_SignOut(ByteArrayList tmp)
        {
            bSignOut.Add(tmp.getArray());
        }

        public void set_CheckSign(bool tmp)
        {
            checksign = tmp;
        }
    }
}
