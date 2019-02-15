using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MiniERP.VO
{
    [Serializable]

    public class MyPacket

    {

        public byte[] Data

        {

            get;

            private set;

        }

        public string FileName

        {

            get;

            private set;

        }

        public int Size

        {

            get;

            private set;

        }

        public MyPacket(string filename, int filelength, byte[] buf)

        {

            FileName = filename;

            Data = buf;

            Size = filelength;

        }

    }



    
}