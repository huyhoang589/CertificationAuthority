using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509
{
    class X509Version
    {
        private ByteArrayList A0;

        public X509Version()
        {
            A0 = new ByteArrayList();
        }
        
        public ByteArrayList get_Version()
        {
            ByteArrayList list = new ByteArrayList();
            list.Add(0xA0); // Основной Блок
            list.Add(0x03);
            list.Add(0x02);
            list.Add(0x01);
            list.Add(0x02); // Version 3
            
            return list;
        }
    }
}
