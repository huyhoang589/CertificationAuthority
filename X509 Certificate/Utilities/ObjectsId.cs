using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Utilities
{
    class ObjectsId
    {
        private ByteArrayList objID = new ByteArrayList();
                
        public ObjectsId(string value)
        {
            
            objID.Add(0x06);    // OBJECT IDENTIFIER
            switch (value)
            {
                case "Email":   objID.Add(0x09);    // Длина идентификатора 9 байт
                                objID.Add(0x2A); objID.Add(0x86); objID.Add(0x48);  // emailAddress         1.2.840.113549.1.9.1
                                objID.Add(0x86); objID.Add(0xF7); objID.Add(0x0D);
                                objID.Add(0x01); objID.Add(0x09); objID.Add(0x01);
                                break;
                case "C":       objID.Add(0x03);    // Длина идентификатора 3 байт
                                objID.Add(0x55); objID.Add(0x04); objID.Add(0x06);  // countryName             2.5.4.6
                                break;
                case "ST":      objID.Add(0x03);    // Длина идентификатора 3 байт
                                objID.Add(0x55); objID.Add(0x04); objID.Add(0x08);  // stateOrProvinceName      2.5.4.8
                                break;
                case "L":       objID.Add(0x03);    // Длина идентификатора 3 байт
                                objID.Add(0x55); objID.Add(0x04); objID.Add(0x07);  // localityName      2.5.4.7
                                break;
                case "O":       objID.Add(0x03);    // Длина идентификатора 3 байт
                                objID.Add(0x55); objID.Add(0x04); objID.Add(0x0A); // organizationName      2.5.4.10
                                break;
                case "OU":      objID.Add(0x03);    // Длина идентификатора 3 байт
                                objID.Add(0x55); objID.Add(0x04); objID.Add(0x0B); // organizationalUnitName      2.5.4.11
                                break;
                case "CN":      objID.Add(0x03);    // Длина идентификатора 3 байт
                                objID.Add(0x55); objID.Add(0x04); objID.Add(0x03); // commonName      2.5.4.03
                                break;
                              
                case "gost341012paramseta": objID.Add(0x09);    // Длина идентификатора 9 байт
                                objID.Add(0x2A); objID.Add(0x85); objID.Add(0x03);  // id-tc26-gost-3410-12-512-paramSetA
                                objID.Add(0x07); objID.Add(0x01); objID.Add(0x02);  // 1.2.643.7.1.2.1.2.1
                                objID.Add(0x1); objID.Add(0x02); objID.Add(0x01);
                                break;
                case "gost341012paramsetb": objID.Add(0x09);    // Длина идентификатора 9 байт
                                objID.Add(0x2A); objID.Add(0x85); objID.Add(0x03);  // id-tc26-gost-3410-12-512-paramSetB
                                objID.Add(0x07); objID.Add(0x01); objID.Add(0x02);  // 1.2.643.7.1.2.1.2.2
                                objID.Add(0x1); objID.Add(0x02); objID.Add(0x02);
                                break;
                case "gost341012withgost341112": objID.Add(0x08);    // Длина идентификатора 9 байт
                                objID.Add(0x2A); objID.Add(0x85); objID.Add(0x03);  // id-tc26-signwithdigest-gost3410-12-512
                                objID.Add(0x07); objID.Add(0x01); objID.Add(0x01);  // алгоритм подписи ГОСТ Р 34.10-2012 с ключом 512 
                                objID.Add(0x3); objID.Add(0x03);                    //  с  хэшированием ГОСТ Р 34.11-2012
                                break;                                             //  1.2.643.7.1.1.3.3

                case "gost341012": objID.Add(0x08);    // Длина идентификатора 9 байт
                                objID.Add(0x2A); objID.Add(0x85); objID.Add(0x03);  // id-tc26-gost3410-12-512
                                objID.Add(0x07); objID.Add(0x01); objID.Add(0x01);  // алгоритм подписи ГОСТ Р 34.10-2012 с ключом 512 
                                objID.Add(0x1); objID.Add(0x02);                    //  
                                break;                                             //  1.2.643.7.1.1.1.2

                case "gost341112": objID.Add(0x08);    // Длина идентификатора 9 байт
                                objID.Add(0x2A); objID.Add(0x85); objID.Add(0x03);  // id-tc26-gost3411-12-512
                                objID.Add(0x07); objID.Add(0x01); objID.Add(0x01);  // алгоритм хэширования ГОСТ Р 34.11-2012 с длиной 512 
                                objID.Add(0x2); objID.Add(0x03);                    //  
                                break;                                             //  1.2.643.7.1.1.2.3

                case "gost341194withgost341001": objID.Add(0x06);    // Длина идентификатора 9 байт
                                objID.Add(0x2A); objID.Add(0x85); objID.Add(0x03);  // 
                                objID.Add(0x02); objID.Add(0x02); objID.Add(0x03);  // ГОСТ Р 34.11/34.10-2001                
                                break;                                             //  1.2.643.2.2.3

                //----------------OID X509Ext------------------------------------

                case "keyusage": objID.Add(0x03);   // Длина идентификатора 3 байт
                                objID.Add(0x55); objID.Add(0x1D); objID.Add(0x0F);   // Key Usage          2.5.29.15
                                break;

                case "subkeyid": objID.Add(0x03);   // Длина идентификатора 3 байт
                                 objID.Add(0x55);objID.Add(0x1D);objID.Add(0x0E);   // Subject Key Identifier          2.5.29.14
                                break;

                case "basicConstraint": objID.Add(0x03);   // Длина идентификатора 3 байт
                                objID.Add(0x55); objID.Add(0x1D); objID.Add(0x13);   // basicConstraints       2.5.29.19
                                break;

                case "authorkeyid": objID.Add(0x03);   // Длина идентификатора 3 байт
                                objID.Add(0x55); objID.Add(0x1D); objID.Add(0x23);   // basicConstraints       2.5.29.35
                                break;

                case "crlpoint": objID.Add(0x03);   // Длина идентификатора 3 байт
                                objID.Add(0x55); objID.Add(0x1D); objID.Add(0x1F);   // basicConstraints       2.5.29.31
                                break;

                case "auinfoaccess": objID.Add(0x08);    // Длина идентификатора 8 байт
                                objID.Add(0x2B); objID.Add(0x06); objID.Add(0x01);  // authority Info Access 
                                objID.Add(0x05); objID.Add(0x05); objID.Add(0x07);  // 1.3.6.1.5.5.7.1.1
                                objID.Add(0x1); objID.Add(0x01);                    //  
                                break;

                case "caissuer": objID.Add(0x08);    // Длина идентификатора 8 байт
                                objID.Add(0x2B); objID.Add(0x06); objID.Add(0x01);  // authority Info Access 
                                objID.Add(0x05); objID.Add(0x05); objID.Add(0x07);  // 1.3.6.1.5.5.7.48.2
                                objID.Add(0x30); objID.Add(0x02);                    //  
                                break;

                //----------------OID CRLExt------------------------------------
                case "cakeycertindexpair": objID.Add(0x09);    // Длина идентификатора 9 байт
                                objID.Add(0x2B); objID.Add(0x06); objID.Add(0x01);  // cakeycertindexpair
                                objID.Add(0x04); objID.Add(0x01); objID.Add(0x82);  // 1.3.6.1.4.1.311.21.1
                                objID.Add(0x37); objID.Add(0x15); objID.Add(0x01);
                                break;
                case "crlnextpublish": objID.Add(0x09);    // Длина идентификатора 9 байт
                                objID.Add(0x2B); objID.Add(0x06); objID.Add(0x01);  // crlnextpublish
                                objID.Add(0x04); objID.Add(0x01); objID.Add(0x82);  // 1.3.6.1.4.1.311.21.4
                                objID.Add(0x37); objID.Add(0x15); objID.Add(0x04);
                                break;
                case "crlnumber": objID.Add(0x03);    // Длина идентификатора 3 байт
                                objID.Add(0x55); objID.Add(0x1D); objID.Add(0x14); // crlnumber      2.5.29.20
                                break;
                case "crlreason": objID.Add(0x03);    // Длина идентификатора 3 байт
                                objID.Add(0x55); objID.Add(0x1D); objID.Add(0x15); // crlreason      2.5.29.21
                                break;
            }
        }
      
         
        
        public ByteArrayList getID()
        {
           return objID;
        }
        
    }
}
