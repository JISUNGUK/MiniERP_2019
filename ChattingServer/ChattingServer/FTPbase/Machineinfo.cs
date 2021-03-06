﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Management;

namespace ChattingServer.FTPbase
{
    public class MachineInfo
    {

        public static string MachineName = Environment.MachineName;
        public static IPEndPoint MachineIP;
        public static List<FileInfo> Files = new List<FileInfo>();
        
        /// <summary>
        /// 해당 이름의 폴더의 파일리스트를 보여줄 리스트에 추가함
        /// </summary>
        /// <param name="folder"></param>
        public static void GetFiles(string folder)
        {
            if (!Directory.Exists(folder))
                return;

            foreach (string file in Directory.GetFiles(folder))
            {
                FileInfo info = new FileInfo(Path.GetFileName(file), (new System.IO.FileInfo(file).Length / 1024));
                Files.Add(info);
            }
        }

        /// <summary>
        /// 현재 작동중인 기기의 ipendpoint를 반환
        /// </summary>
        /// <returns></returns>
        public static IPEndPoint GetMachineIP()
        {
            IPEndPoint result = null;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select IPAddress From Win32_NetworkAdapterConfiguration");

            foreach (ManagementObject obj in searcher.Get())
            {
                if (obj["IPAddress"] != null)
                {
                    string[] ip = (string[])obj["IPAddress"];
                    result = new IPEndPoint(IPAddress.Parse(ip[0]), 9898);
                    break;
                }
            }

            return result;
        }

        public static string GetJustIP()
        {
            string result = null;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select IPAddress From Win32_NetworkAdapterConfiguration");

            foreach (ManagementObject obj in searcher.Get())
            {
                if (obj["IPAddress"] != null)
                {
                    string[] ip = (string[])obj["IPAddress"];
                    result = ip[0];
                    break;
                }
            }

            return result;
        }

    }
}
