using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Utilities;
using X509.X509Extended;

namespace X509
{
    class V3Extended
    {
        private ByteArrayList keyUsage;
        private ByteArrayList authorKeyID;
        private ByteArrayList subjectKeyID;
        private ByteArrayList cRLPoint;
        private ByteArrayList auInfoAccess;
        private int len1,len2;

        public V3Extended()
        {
            keyUsage = new ByteArrayList();
            subjectKeyID = new ByteArrayList();
            authorKeyID = new ByteArrayList();
            cRLPoint = new ByteArrayList();
            auInfoAccess = new ByteArrayList();
        }

        public ByteArrayList get_V3Extended()
        {
            ByteArrayList list = new ByteArrayList();

            basicConstraints bBasicCon = new basicConstraints();
            ByteArrayList basicCon = bBasicCon.get_basisConstraints();
            
            len2 = basicCon.getSize() + keyUsage.getSize() + subjectKeyID.getSize() + authorKeyID.getSize() + cRLPoint.getSize()+ auInfoAccess.getSize();
            
            if (len2 <= 255) len1 = len2 + 3;
            else len1 = len2 + 4;

            list.Add(0xA3);                     // Block Ext
            if (len1 <=255) list.Add(0x81);else  list.Add(0x82);
            list.Add(len1);
            list.Add(0x30);                     // SEQUENCE
            if (len2 <=255) list.Add(0x81);else  list.Add(0x82);
            list.Add(len2);
            list.Add(basicCon.getArray());      //basicConstraint
            list.Add(keyUsage.getArray());      // keyUsage
            list.Add(subjectKeyID.getArray());  // subject Key ID
            list.Add(authorKeyID.getArray());   // authority Key ID
            list.Add(cRLPoint.getArray());      // cRL Distribution Points
            list.Add(auInfoAccess.getArray());  // authority Info Access

            return list;
        }

        public void set_keyUsage(ByteArrayList tmp)
        {
            keyUsage.Add(tmp.getArray());
        }

        public void set_subjectKeyID(ByteArrayList tmp)
        {
            subjectKeyID.Add(tmp.getArray());
        }

        public void set_authorKeyID(ByteArrayList tmp)
        {
            authorKeyID.Add(tmp.getArray());
        }

        public void set_cRLPoint(ByteArrayList tmp)
        {
            cRLPoint.Add(tmp.getArray());
        }

        public void set_auInfoAccess(ByteArrayList tmp)
        {
            auInfoAccess.Add(tmp.getArray());
        }
    }
}
