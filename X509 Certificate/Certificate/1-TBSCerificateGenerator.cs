using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using X509.X509Name;

namespace X509.Certificate
{
    class TBSCerificateGenerator
    {
        private ByteArrayList bVersion;
        private ByteArrayList bSerial;
        private ByteArrayList bAlgSign;
        private ByteArrayList bIssuer;
        private ByteArrayList bDateTime;
        private ByteArrayList bSubject;
        private ByteArrayList bPubKey;
        private ByteArrayList bExt;
        private int lenTBS;
        private string CertSerial;

        public TBSCerificateGenerator()
        {
            bVersion = new ByteArrayList();  // 1
            bSerial = new ByteArrayList();  // 2
            bAlgSign = new ByteArrayList(); // 3
            bIssuer = new ByteArrayList();  // 4
            bDateTime = new ByteArrayList();// 5    
            bSubject = new ByteArrayList(); // 6
            bPubKey = new ByteArrayList();  // 7
            bExt = new ByteArrayList();     // 8
        }

        public ByteArrayList get_tbsCertificate()
        {
            ByteArrayList list = new ByteArrayList();

            X509Version Ver = new X509Version();
            bVersion = Ver.get_Version();

            Serial Ser = new Serial();
            bSerial = Ser.get_Serial();
            CertSerial = string.Copy(Ser.get_strSerial());
                        
            AlgorithmSignature Alg = new AlgorithmSignature();
            Alg.set_AlgSign("gost341012withgost341112");
            bAlgSign = Alg.get_AlgSign();

            lenTBS = bVersion.getSize() + bSerial.getSize()+ bAlgSign.getSize() + bIssuer.getSize() + bDateTime.getSize() + bSubject.getSize() + bPubKey.getSize() + bExt.getSize();

            list.Add(0x30); // SEQUENCE
            if (lenTBS <= 255) list.Add(0x81); else list.Add(0x82); // block TBS
            list.Add(lenTBS);
            list.Add(bVersion.getArray());  // Version
            list.Add(bSerial.getArray());   // Serial
            list.Add(bAlgSign.getArray());  // Алгоритм подписи
            list.Add(bIssuer.getArray());   // Issuer
            list.Add(bDateTime.getArray()); // date time
            list.Add(bSubject.getArray());  // Subject
            list.Add(bPubKey.getArray());   // Public Key
            list.Add(bExt.getArray());      // block Extended

            return list;
        }

        public string get_Serial()
        {
            return CertSerial;
        }

        public void set_Issuer(ByteArrayList tmp)
        {
            bIssuer.Add(tmp.getArray());
        }

        public void set_DateTime(ByteArrayList tmp)
        {
            bDateTime.Add(tmp.getArray());
        }

        public void set_Subject(ByteArrayList tmp)
        {
            bSubject.Add(tmp.getArray());
        }

        public void set_pubKey(ByteArrayList tmp)
        {
            bPubKey.Add(tmp.getArray());
        }

        public void set_Extended(ByteArrayList tmp)
        {
            bExt.Add(tmp.getArray());
        }
    }
}
