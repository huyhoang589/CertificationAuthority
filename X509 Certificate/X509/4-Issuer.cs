using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using X509.X509Name;

namespace X509
{
    class Issuer
    {
        private ByteArrayList C;
        private ByteArrayList ST;
        private ByteArrayList L;
        private ByteArrayList O;
        private ByteArrayList OU;
        private ByteArrayList CN;
        private ByteArrayList Email;

        public Issuer()
        {
            C = new ByteArrayList();
            ST = new ByteArrayList();
            L = new ByteArrayList();
            O = new ByteArrayList();
            OU = new ByteArrayList();
            CN = new ByteArrayList();
            Email = new ByteArrayList();
        }

        public ByteArrayList get_Issuer()
        {
            ByteArrayList list = new ByteArrayList();

            int len = C.getSize() + ST.getSize() + L.getSize() + O.getSize() + OU.getSize() + CN.getSize() + Email.getSize();

            list.Add(0x30); // SEQUENCE
            if (len <= 255) list.Add(0x81); else list.Add(0x82);
            list.Add(len);  // Длина блока
            list.Add(C.getArray());     // SET - countryName
            list.Add(ST.getArray());    // SET - StateOfProvinceName
            list.Add(L.getArray());     // SET - LocalName
            list.Add(O.getArray());     // SET - organizationName
            list.Add(OU.getArray());    // SET - organizationUnitName
            list.Add(CN.getArray());    // SET - commonName
            list.Add(Email.getArray()); // emailAdress

            return list;
        }

        public void set_C(ByteArrayList tmp)
        {
            C.Add(tmp.getArray());
        }

        public void set_ST(ByteArrayList tmp)
        {
            ST.Add(tmp.getArray());
        }

        public void set_L(ByteArrayList tmp)
        {
            L.Add(tmp.getArray());
        }

        public void set_O(ByteArrayList tmp)
        {
            O.Add(tmp.getArray());
        }

        public void set_OU(ByteArrayList tmp)
        {
            OU.Add(tmp.getArray());
        }

        public void set_CN(ByteArrayList tmp)
        {
            CN.Add(tmp.getArray());
        }

        public void set_emailAdress(ByteArrayList tmp)
        {
            Email.Add(tmp.getArray());
        }
    }
}
