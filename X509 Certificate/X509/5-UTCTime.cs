using System;
using System.Text;
using System.Globalization;
using Utilities;

namespace X509.X509DateTime
{
    class UtcTime
    {
        private string validFrom;
        private string validTo;
        private ByteArrayList time;

        public UtcTime()
        {
            time = new ByteArrayList();
        }

        public ByteArrayList get_UtcTime()
        {
            ByteArrayList list = new ByteArrayList();
           
            byte[] bytes_from = Encoding.ASCII.GetBytes(validFrom);
            byte[] bytes_to = Encoding.ASCII.GetBytes(validTo);

            list.Add(0x30); // SEQUENCE
            list.Add(0x1E); // 30 байт длина
            list.Add(0x17); // Utc Time
            list.Add(0x0D); // 13 байт длина
            list.Add(bytes_from);   // valid From
            list.Add(0x17); // Utc Time
            list.Add(0x0D); // 13 байт длина
            list.Add(bytes_to);   // valid To

            return list;
        }

        public void set_ValidFrom(DateTime tmp)
        {
            validFrom = tmp.ToString("yyMMddHHmmss") + "Z";
        }

        public void set_ValidTo(DateTime tmp)
        {
            validTo = tmp.ToString("yyMMddHHmmss") + "Z";
        }
    }
}
