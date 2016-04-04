using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    class CheckObjID
    {
        private bool result;
        public CheckObjID(string value)
        {
            ObjectsId oID = new ObjectsId(value);
            ByteArrayList lID = oID.getID();
            MakeOidStringFromBytes make = new MakeOidStringFromBytes();
            string ID = make.getID(lID);

            switch (value)
            {
                case "Email": if (ID == "1.2.840.113549.1.9.1") result = true; break;
                case "C": if (ID == "2.5.4.6") result = true; break;
                case "ST": if (ID == "2.5.4.8") result = true; break;
                case "L": if (ID == "2.5.4.7") result = true; break;
                case "O": if (ID == "2.5.4.10") result = true; break;
                case "OU": if (ID == "2.5.4.11") result = true; break;
                case "CN": if (ID == "2.5.4.3") result = true; break;

                case "keyusage": if (ID == "2.5.29.15") result = true; break;
                case "subkeyid": if (ID == "2.5.29.14") result = true; break;
                case "basicConstraint": if (ID == "2.5.29.19") result = true; break;
                case "authorkeyid": if (ID == "2.5.29.35") result = true; break;
                case "crlpoint": if (ID == "2.5.29.31") result = true; break;
                case "auinfoaccess": if (ID == "1.3.6.1.5.5.7.1.1") result = true; break;
                case "caissuer": if (ID == "1.3.6.1.5.5.7.48.2") result = true; break;

                case "cakeycertindexpair": if (ID == "1.3.6.1.4.1.311.21.1") result = true; break;
                case "crlnextpublish": if (ID == "1.3.6.1.4.1.311.21.4") result = true; break;
                case "crlnumber": if (ID == "2.5.29.20") result = true; break;

                //  id-tc26-gost-3410-12-512-paramSetA (рабочие параметры алгоритма подписи ГОСТ Р 34.10-2012 с ключом 512 )
                case "gost341012paramseta": if (ID == "1.2.643.7.1.2.1.2.1") result = true; break;

                //  id-tc26-gost-3410-12-512-paramSetB (рабочие параметры алгоритма подписи ГОСТ Р 34.10-2012 с ключом 512)
                case "gost341012paramsetb": if (ID == "1.2.643.7.1.2.1.2.2") result = true; break;

                //  id-tc26-signwithdigest-gost3410-12-512 (алгоритм подписи ГОСТ Р 34.10-2012 с ключом 512 с  хэшированием ГОСТ Р 34.11-2012)
                case "gost341012withgost341112": if (ID == "1.2.643.7.1.1.3.3") result = true; break;

                //  id-tc26-gost3410-12-512 (алгоритм подписи ГОСТ Р 34.10-2012 с ключом 512 )
                case "gost341012": if (ID == "1.2.643.7.1.1.1.2") result = true; break;

                //  id-tc26-gost3411-12-512 (алгоритм хэширования ГОСТ Р 34.11-2012 с длиной 512)
                case "gost341112": if (ID == "1.2.643.7.1.1.2.3") result = true; break;

                //  ГОСТ Р 34.11/34.10-2001
                case "gost341194withgost341001": if (ID == "1.2.643.2.2.3") result = true; break;

                default: result = false; break;

            }
                        
        }

        public bool CheckID()
        {
             return result;
        }

   }
}
