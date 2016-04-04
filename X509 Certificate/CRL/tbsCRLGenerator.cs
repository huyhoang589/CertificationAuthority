using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using X509.CRLExtended;

namespace X509.CRL
{
    class tbsCRLGenerator
    {
        private ByteArrayList bAlgSign;
        private ByteArrayList bIssuer;
        private ByteArrayList bCRL;
        private ByteArrayList bCRLExt;
        private int lenTBS;
        private string validFrom;
        private string validTo;

        public tbsCRLGenerator()
        {
            bAlgSign = new ByteArrayList();
            bIssuer = new ByteArrayList();
            bCRL = new ByteArrayList();
            bCRLExt = new ByteArrayList();
        }

        public ByteArrayList get_tbsCRL()
        {
            ByteArrayList list = new ByteArrayList();

            // UTC Time
            byte[] bytes_from = Encoding.ASCII.GetBytes(validFrom);
            byte[] bytes_to = Encoding.ASCII.GetBytes(validTo);

            AlgorithmSignature Alg = new AlgorithmSignature();
            Alg.set_AlgSign("gost341012withgost341112");
            bAlgSign = Alg.get_AlgSign();

            lenTBS = bAlgSign.getSize() + bIssuer.getSize() + bCRLExt.getSize() + 33;  //33 len_UTCTime = 30 + len_Version = 3;
            

            if (bCRL.getSize() >= 255)
                //lenTBS = bAlgSign.getSize() + bIssuer.getSize() + bCRL.getSize() + bCRLExt.getSize() + 37;
                lenTBS = lenTBS + bCRL.getSize() + 4 ;

            if (bCRL.getSize() >0 && bCRL.getSize() < 255)           
                //lenTBS = bAlgSign.getSize() + bIssuer.getSize() + bCRL.getSize() + bCRLExt.getSize() + 35; 
                lenTBS = lenTBS + bCRL.getSize() + 3 ;
            
            
           
            list.Add(0x30); // SEQUENCE
            if (lenTBS <= 255) list.Add(0x81); else list.Add(0x82);// block TBS
            list.Add(lenTBS);
            list.Add(0x02); // Version CRL
            list.Add(0x01);
            list.Add(0x01); // ver 01
            list.Add(bAlgSign.getArray());  // Алгоритм подписи
            list.Add(bIssuer.getArray());   // Issuer
            list.Add(0x17); // Utc Time
            list.Add(0x0D); // 13 байт длина
            list.Add(bytes_from);   // valid From
            list.Add(0x17); // Utc Time
            list.Add(0x0D); // 13 байт длина
            list.Add(bytes_to);   // valid To

            if (bCRL.getSize() > 0)     // CRL
            {
                list.Add(0x30); // SEQUENCE
                if (bCRL.getSize() >= 255) list.Add(0x82); else list.Add(0x81);
                list.Add(bCRL.getSize());
                list.Add(bCRL.getArray());
            }

            list.Add(bCRLExt.getArray());   // CRL Extended

            return list;
        }

        public void set_UTCTime(DateTime From, DateTime To)
        {
            validFrom = From.ToString("yyMMddHHmmss") + "Z";
            validTo = To.ToString("yyMMddHHmmss") + "Z";
        }

        public void set_Issuer(ByteArrayList tmp)
        {
            bIssuer.Add(tmp.getArray());
        }

        public void set_CRL(ByteArrayList CertsRevocationList)
        {
            bCRL.Add(CertsRevocationList.getArray());
        }

        public void set_CRLExtended(ByteArrayList tmp)
        {
            bCRLExt.Add(tmp.getArray());
        }
    }
}
