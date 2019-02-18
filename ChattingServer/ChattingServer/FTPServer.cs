/*File Sharing is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Foobar is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with File Sharing.  If not, see <http://www.gnu.org/licenses/>.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ChattingServer.FTPbase;

namespace ChattingServer
{

    public class FTPServer : System.MarshalByRefObject ,IFTPServer 
    {
        public static System.Windows.Forms.TextBox Logger = null;

        public void AddLog(string text)
        {
            if (Logger.InvokeRequired)
            {
                Action<string> invoker = new Action<string>(AddLog);
                Logger.Invoke(invoker, text);
            }
            else
            {
                Logger.Text +=Environment.NewLine + text;
            }
        }

        public void Connect(string user)
        {
            if (Logger != null)
            {
                if (Logger.InvokeRequired)
                {
                    Action<string> invoker = new Action<string>(Connect);
                    Logger.Invoke(invoker,user);
                }
                else
                {
                    Logger.Text += string.Format("{0}>{1} is connected at [{2}].", Environment.NewLine, user, DateTime.Now.ToShortTimeString());
                }
            }
        }
        public void Disconnect(string user)
        {
            if (Logger != null)
            {
                if (Logger.InvokeRequired)
                {
                    Action<string> invoker = new Action<string>(Disconnect);
                    Logger.Invoke(invoker,user);
                }
                else
                {
                    Logger.Text += string.Format("{0}>{1} is Disconnected at [{2}].", Environment.NewLine, user, DateTime.Now.ToShortTimeString());
                }
            }
        }

        public void PostData(string user, byte[] data)
        {
            if (PostedData != null)
                PostedData(user, data);
        }

        public event PostedDataHandler PostedData;

        public void Upload(string user,List<UploadData> files,string folderName)
        {
            if (!System.IO.Directory.Exists("Share\\"+ folderName))
                System.IO.Directory.CreateDirectory("Share\\"+folderName);

            foreach (UploadData file in files)
            {
                System.IO.File.WriteAllBytes("Share\\"+ folderName+"\\" + file.Filename, file.File);
                AddLog(string.Format("> 파일: {0} 업로드 되었습니다. 업로드폴더 {1}. by {2}",file.Filename,DateTime.Now.ToShortTimeString(),user));
            }

            if (Update != null)
                Update(user);
            System.GC.Collect(0, GCCollectionMode.Forced);
            System.GC.WaitForFullGCComplete();

        }

        public void Download(string user,string filename, out byte[] file,string folderName)
        {
            file = new byte[1];

            if (!System.IO.Directory.Exists("Share\\"+folderName))
                System.IO.Directory.CreateDirectory("Share\\" + folderName);

            foreach (string the in System.IO.Directory.GetFiles("Share\\" + folderName)) 
            {
                if(the.Contains(filename))
                if (System.IO.File.Exists(the))
                {
                    file = System.IO.File.ReadAllBytes(the);
                    AddLog(string.Format("> 파일: {0} 다운로드 중입니다 다운로드폴더: {1}. 다운로드 한유저 {2}",(new System.IO.FileInfo(the)).Name,DateTime.Now.ToShortTimeString(),user));
                    break;
                }
            }
            
            if (file.Length == 1)
                file = null;
            System.GC.Collect(0, GCCollectionMode.Forced);
            System.GC.WaitForFullGCComplete();
        }

        public void GetFiles(out List<FileInfo> files, string folderName)
        {

            if (!System.IO.Directory.Exists("Share\\"+ folderName))
                System.IO.Directory.CreateDirectory("Share\\" + folderName);
            
            List<FileInfo > list = new List<FileInfo>();

            foreach (string file in System.IO.Directory.GetFiles("Share\\" + folderName))
            {
                list.Add(new FileInfo(file, ((new System.IO.FileInfo(file).Length) / 1024)));
            }

            files = list;
            
        }


        public event UpdateHandler Update;

    }
}
