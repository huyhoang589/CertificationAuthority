using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509.CRL
{
    class CertificatesRevocationList
    {
        private ByteArrayList bTSBCRL;
        private ByteArrayList bAlgSignCert;
        private ByteArrayList bSignValue;

        public CertificatesRevocationList()
        {
            bTSBCRL = new ByteArrayList();
            bAlgSignCert = new ByteArrayList();
            bSignValue = new ByteArrayList();
        }

        public ByteArrayList get_CRL()
        {
            ByteArrayList list = new ByteArrayList();

            int lenCert = bTSBCRL.getSize() + bAlgSignCert.getSize() + bSignValue.getSize();

            list.Add(0x30); //SEQUENCE
            if (lenCert <= 255) list.Add(0x81); else list.Add(0x82);
            list.Add(lenCert);
            list.Add(bTSBCRL.getArray());
            list.Add(bAlgSignCert.getArray());
            list.Add(bSignValue.getArray());

            return list;
        }

        public void set_tsbCRL(ByteArrayList tmp)
        {
            bTSBCRL.Add(tmp.getArray());
        }

        public void set_AlgSignCert(ByteArrayList tmp)
        {
            bAlgSignCert.Add(tmp.getArray());
        }

        public void set_Signature(ByteArrayList tmp)
        {
            bSignValue.Add(tmp.getArray());
        }
    }
}
