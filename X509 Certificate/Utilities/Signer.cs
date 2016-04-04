using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DSGOST2012;
using HGOST2012;
using ECParamSet;
using BigIntegerClass;
using ECPointClass;
using Utilities;

namespace Utilities
{
    class Signer
    {
        private static DSGost DS;

        public Signer(string paramSetID)
        {
            DS = new DSGost(paramSetID);
        }
        
        public ByteArrayList genSign(ByteArrayList TBSblock, ByteArrayList privKey)
        {
            byte[] tmp_M = TBSblock.getArray();
            byte[] tmp_privKey = privKey.getArray();

            GOST hash = new GOST(512);
            byte[] H = hash.GetHash(tmp_M);

            string sign = DS.SignGen(H, tmp_privKey);
            byte[] sign_arr = HexStringToByteArrayConverter.Convert(sign);
            ByteArrayList signOutput = new ByteArrayList();
            signOutput.Add(sign_arr);

            return signOutput;
        }
        
        public bool verifySign(ByteArrayList x509Name, ByteArrayList sign, ByteArrayList pubKey)
        {
            byte[] tmp_M = x509Name.getArray();

            GOST hash = new GOST(512);
            byte[] H = hash.GetHash(tmp_M);

            byte[] sign_arr = sign.getArray();
            string sign_tmp = BitConverter.ToString(sign_arr);
            string sign_str = sign_tmp.Replace("-", "");

            byte[] pubKey_arr = pubKey.getArray();
            byte[] xQ = new byte[64];
            byte[] yQ = new byte[64];
            for (int i = 0; i < 64; i++) xQ[i] = pubKey_arr[i];
            for (int i = 64; i < pubKey_arr.Length; i++) yQ[i-64] = pubKey_arr[i];
            ECPoint Q = new ECPoint();
            Q.x = new BigInteger(xQ);
            Q.y = new BigInteger(yQ);
            Q.a = DS.get_a();
            Q.b = DS.get_b();
            Q.FieldChar = DS.get_FieldChar();

            bool checkSign = DS.SignVer(H, sign_str, Q);

            return checkSign;

        }
        
        
       
        
        
    }
}
