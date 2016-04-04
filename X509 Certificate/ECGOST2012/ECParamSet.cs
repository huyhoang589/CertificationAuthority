using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BigIntegerClass;
using Utilities;

namespace ECParamSet
{
    class ParamSet
    {
        private BigInteger p = new BigInteger();    // Модуль
        private BigInteger a = new BigInteger();    // a,b - коэффициенты уравнения эллиптической кривой
        private BigInteger b = new BigInteger();
        private BigInteger n = new BigInteger();    // Порядок гурппы эллиптической кривой
        private BigInteger xG = new BigInteger();   // (xG,yG) - порождающий элемент группы
        private BigInteger yG = new BigInteger();
      
        public ParamSet(ParamSet Param)
        {
            this.a = Param.a;            
            this.b = Param.b;                  
            this.n = Param.n;            
            this.p = Param.p;            
            this.xG = Param.xG;          
            this.yG = Param.yG;
        }

        
        public ParamSet(string paramSetName)
        {
            int Value =0;
            if (paramSetName == "gost341012paramseta") Value = 0;
            if (paramSetName == "gost341012paramsetb") Value = Value + 1;
            switch (Value)
            {
                case 0:
                    this.a = new BigInteger("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFDC4",16);
                    this.b = new BigInteger("E8C2505DEDFC86DDC1BD0B2B6667F1DA34B82574761CB0E879BD081CFD0B6265EE3CB090F30D27614CB4574010DA90DD862EF9D4EBEE4761503190785A71C760",16);
                    this.n = new BigInteger("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF27E69532F48D89116FF22B8D4E0560609B4B38ABFAD2B85DCACDB1411F10B275",16);
                    this.p = new BigInteger("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFDC7", 16);
                    this.xG = new BigInteger("3", 16);
                    this.yG = new BigInteger("7503CFE87A836AE3A61B8816E25450E6CE5E1C93ACF1ABC1778064FDCBEFA921DF1626BE4FD036E93D75E6A50E3A41E98028FE5FC235F5B889A589CB5215F2A4",16);
                    break;
                    
                case 1:
                    this.a = new BigInteger("008000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006C", 16);
                    this.b = new BigInteger("00687D1B459DC841457E3E06CF6F5E2517B97C7D614AF138BCBF85DC806C4B289F3E965D2DB1416D217F8B276FAD1AB69C50F78BEE1FA3106EFB8CCBC7C5140116", 16);
                    this.n = new BigInteger("00800000000000000000000000000000000000000000000000000000000000000149A1EC142565A545ACFDB77BD9D40CFA8B996712101BEA0EC6346C54374F25BD ", 16);
                    this.p = new BigInteger("008000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006F", 16);
                    this.xG = new BigInteger("2",16);
                    this.yG = new BigInteger("001A8F7EDA389B094C2C071E3647A8940F3C123B697578C213BE6DD9E6C8EC7335DCB228FD1EDF4A39152CBCAAF8C0398828041055F94CEEEC7E21340780FE41BD", 16);
                    break;
             }
            //return paramSetName;
        }
        public void set_a(BigInteger set_a)
        {
            a = set_a;
        }

        public void set_b(BigInteger set_b)
        {
            b = set_b;
        }
        public void set_p(BigInteger set_p)
        {
            p = set_p;
        }
        public void set_n(BigInteger set_n)
        {
            n = set_n;
        }
        public void set_xG(BigInteger set_xG)
        {
            xG = set_xG;
        }
        public void set_yG(BigInteger set_yG)
        {
            yG = set_yG;
        }

        public BigInteger get_a()
        {
            return a;
        }

        public BigInteger get_b()
        {
            return b;
        }

        public BigInteger get_p()
        {
            return p;
        }

        public BigInteger get_n()
        {
            return n;
        }

        public BigInteger get_xG()
        {
            return xG;
        }
        public BigInteger get_yG()
        {
            return yG;
        }      
        
       

       
    }
}
