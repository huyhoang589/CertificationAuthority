using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BigIntegerClass;
using ECPointClass;
using ECParamSet;
using DSGOST2012;

namespace Utilities
{
    class GetKeyPairGenerator
    {
        private ByteArrayList pubKey;
        private ByteArrayList privKey;
        private DSGost DS;
    
        public GetKeyPairGenerator(string paramSetID)
        {
            DS = new DSGost(paramSetID);
        }

        public ByteArrayList get_PublicKey()
        {
            pubKey = new ByteArrayList();
            byte[] bytes_privKey = privKey.getArray();
            BigInteger d = new BigInteger(bytes_privKey);
            ECPoint Q = DS.GenPublicKey(d);     // Открытый ключ - точка Q на эллиптической криевой
            pubKey.Add(Q.x.getBytes());
            pubKey.Add(Q.y.getBytes());
            return pubKey;
        }

        public ByteArrayList get_PrivateKey()
        {
            privKey = new ByteArrayList();
            BigInteger d = DS.GenPrivateKey(512); // Секретный ключ длины 512 бит
            privKey.Add(d.getBytes());
            return privKey;
        }

        public void set_privKey(ByteArrayList tmp)
        {
            privKey = new ByteArrayList();
            privKey.Add(tmp.getArray());
        }
    }
}
