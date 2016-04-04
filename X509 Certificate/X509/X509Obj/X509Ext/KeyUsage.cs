using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509.X509Extended
{
    class KeyUsage
    {
        private ByteArrayList bkeyUsage;
        private int kU_value;

        public KeyUsage()
        {
            bkeyUsage = new ByteArrayList();
        }

        public ByteArrayList get_keyUsage()
        {
            int count =0;
            int tmp = kU_value;
            for (int j = 0; j < 8; j++)
            {
                if ((tmp & 1) != 0) break;
                count++;
                tmp >>= 1;
            }
            ByteArrayList list = new ByteArrayList();

            ObjectsId oID = new ObjectsId("keyusage");
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID("keyusage");

            list.Add(0x30); //SEQUENCE
            list.Add(0x0E); 
            if (check.CheckID() == true) list.Add(lID.getArray());  // OBJ ID
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x01); // BOOLEAN true
            list.Add(0x01);
            list.Add(0xFF);
            list.Add(0x04); // Octet string
            list.Add(0x04); 
            list.Add(0x03); // Bit string 4 bit : 1111
            list.Add(0x02); 
            list.Add(count); 
            list.Add(kU_value); 

            return list;
        }

        public void set_keyUsageValue(int tmp)
        {
            kU_value = tmp;
        }
    }
}
