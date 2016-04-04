using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509.Certificate
{
    class X509V3CertificateGenerator
    {
        private ByteArrayList bTSBCert;
        private ByteArrayList bAlgSignCert;
        private ByteArrayList bSignValue;
        
        public X509V3CertificateGenerator()
        {
            bTSBCert = new ByteArrayList();
            bAlgSignCert = new ByteArrayList();
            bSignValue = new ByteArrayList();
        }

        public ByteArrayList get_V3Certificate()
        {
            ByteArrayList list = new ByteArrayList();

            int lenCert = bTSBCert.getSize() + bAlgSignCert.getSize() + bSignValue.getSize();

            list.Add(0x30); //SEQUENCE
            if (lenCert <= 255) list.Add(0x81); else list.Add(0x82);
            list.Add(lenCert);
            list.Add(bTSBCert.getArray());
            list.Add(bAlgSignCert.getArray());
            list.Add(bSignValue.getArray());

            return list;
        }

        public void set_tsbCert(ByteArrayList tmp)
        {
            bTSBCert.Add(tmp.getArray());
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
