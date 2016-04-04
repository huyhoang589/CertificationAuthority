using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace Utilities
{
    class MakeOidStringFromBytes
    {
        public string getID(ByteArrayList obj)
        {
            byte[] temp = obj.getArray();
            byte[] bytes = new byte[temp.Length - 2];
            for(int i=2;i<temp.Length;i++) bytes[i-2] = temp[i];
                         
            StringBuilder objId = new StringBuilder();
            long value = 0;
            bool first = true; 
            for (int i = 0; i != bytes.Length; i++)
            {
                int b = bytes[i];

                if (value < 0x80000000000000L)
                {
                    value = value * 128 + (b & 0x7f);
                    if ((b & 0x80) == 0)             // end of number reached
                    {
                        if (first)
                        {
                            switch ((int)value / 40)
                            {
                                case 0:
                                    objId.Append('0');
                                    break;
                                case 1:
                                    objId.Append('1');
                                    value -= 40;
                                    break;
                                default:
                                    objId.Append('2');
                                    value -= 80;
                                    break;
                            }
                            first = false;
                        }
                        objId.Append('.');
                        objId.Append(value);
                        value = 0;
                    }
                }
            }

            return objId.ToString(); 
           }
    }
}
