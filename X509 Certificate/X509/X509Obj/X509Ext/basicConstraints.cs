using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509.X509Extended
{
    class basicConstraints
    {
        public ByteArrayList get_basisConstraints()
        {
            ByteArrayList list = new ByteArrayList();

            ObjectsId oID = new ObjectsId("basicConstraint");
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID("basicConstraint");

            list.Add(0x30); // SEQUENCE
            list.Add(0x0F); // 15 bytes
            if (check.CheckID() == true) list.Add(lID.getArray());  // OBJ ID
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x01); //BOOLEAN true
            list.Add(0x01);
            list.Add(0xFF);
            list.Add(0x04); // OCTET STRING
            list.Add(0x05);
            list.Add(0x30); // SEQUENCE
            list.Add(0x03);
            list.Add(0x01); // BOOLEAN true
            list.Add(0x01);
            list.Add(0xFF);
            //list.Add(0x02); // INTEGER 0
            //list.Add(0x01);
            //list.Add(0x00);

            return list;
        }
    }
}
