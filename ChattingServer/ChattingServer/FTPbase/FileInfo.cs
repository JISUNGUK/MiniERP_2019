using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChattingServer.FTPbase
{
    [Serializable()]
    public class FileInfo
    {
        /// <summary>
        ///기본 생성자
        /// </summary>
        /// <param name="filename">파일명</param>
        /// <param name="size">파일사이즈</param>
        public FileInfo(string filename, long size)
        {
            this.Filename = filename;
            this.Size = size;
        }

        /// <summary>
        ///파일이름
        /// </summary>
        public string Filename = string.Empty;

        /// <summary>
        /// 파일의 크기를 갖고옴
        /// </summary>
        public long Size = long.MinValue;
    }
}
