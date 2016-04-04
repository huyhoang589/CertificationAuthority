using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace X509.CRLExtended
{
    class CRLNextPublish
    {
        private string data;

        public ByteArrayList get_cRLNextPublish()
        {
            ByteArrayList list = new ByteArrayList();

            byte[] bytes_data = Encoding.ASCII.GetBytes(data);

            ObjectsId oID = new ObjectsId("crlnextpublish");
            ByteArrayList lID = oID.getID();
            CheckObjID check = new CheckObjID("crlnextpublish");

            list.Add(0x30); // SEQUENCE
            list.Add(0x1C); // 28 байт длины
            if (check.CheckID() == true) list.Add(lID.getArray());  //OBJ ID 
            else list.Add("FAFAFAFAFAFAFAFAFAFA");
            list.Add(0x04); // OCTET STRING
            list.Add(0x0F);
            list.Add(0x17); // UTC Time
            list.Add(0x0D); // 13 байт длины
            list.Add(bytes_data);

            return list;
        }

        public void set_dateNextPublish(DateTime dateTime)
        {
            data = dateTime.ToString("yyMMddHHmmss") + "Z";
        }
    }
}
