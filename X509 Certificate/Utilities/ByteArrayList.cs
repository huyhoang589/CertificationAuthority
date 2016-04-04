using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace Utilities
{
    class ByteArrayList
    {
        private List<byte> bytesList;
        public ByteArrayList()
        {
            bytesList = new List<byte>();
        }

        public void Add(byte[] bytes)
        {
            Add(bytes, 0, bytes.Length);
        }

        public void Add(string hexstring)
        {

            byte[] bytes = HexStringToByteArrayConverter.Convert(hexstring);
            for (int i = 0; i < bytes.Length; i++)
            {
                bytesList.Add(bytes[i]);
            }
        }

        public void Add(int value)
        {
            string strValue = value.ToString("X");
            byte[] bytes = HexStringToByteArrayConverter.Convert(strValue);
            for (int i = 0; i < bytes.Length; i++)
            {
                bytesList.Add(bytes[i]);
            }
        }

        public void Add(byte[] bytes, int offset, int length)
        {
            for (int i = offset; i < (offset + length); i++)
            {
                bytesList.Add(bytes[i]);
            }
        }

        public byte[] getArray()
        {
            byte[] bytes = new byte[bytesList.Count];
            // for (int i = 0; i < bytesList.Count; i++)
            {
                bytesList.CopyTo(bytes, 0);
            }
            return bytes;
        }
        public int getSize()
        {
           
            return bytesList.Count;

        }
    }
}
