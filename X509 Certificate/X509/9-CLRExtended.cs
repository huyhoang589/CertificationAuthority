using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using X509.CRLExtended;

namespace X509
{
    class CRLExtend
    {
        private ByteArrayList CRLauKeyID;
        private ByteArrayList CAKeyCertIndexPair;
        private ByteArrayList CRLNumber;
        private ByteArrayList CRLNextPublish;

        public CRLExtend()
        {
            CRLauKeyID = new ByteArrayList();
            CAKeyCertIndexPair = new ByteArrayList();
            CRLNumber = new ByteArrayList();
            CRLNextPublish = new ByteArrayList();
        }

        public ByteArrayList get_CLRExtended()
        {
            ByteArrayList list = new ByteArrayList();

            CRLNumber crlNum = new CRLNumber();
            CRLNumber = crlNum.get_CRLNumber();

            int len = CRLauKeyID.getSize() + CAKeyCertIndexPair.getSize() + CRLNumber.getSize() + CRLNextPublish.getSize();

            list.Add(0xA0); // [0]
            list.Add(len + 2);
            list.Add(0x30); // SEQUENCE
            list.Add(len);
            list.Add(CRLauKeyID.getArray());        // CRLauKeyID
            list.Add(CAKeyCertIndexPair.getArray());// CAKeyCertIndexPair
            list.Add(CRLNumber.getArray());         // CRLNumber
            list.Add(CRLNextPublish.getArray());    // CRLNextPublish

            return list;
        }

        public void set_CRLauKeyID(ByteArrayList tmp)
        {
            CRLauKeyID.Add(tmp.getArray());
        }

        public void set_CAKeyCertIndexPair(ByteArrayList tmp)
        {
            CAKeyCertIndexPair.Add(tmp.getArray());
        }

        public void set_CRLNextPublish(ByteArrayList tmp)
        {
            CRLNextPublish.Add(tmp.getArray());
        }
    }
}
