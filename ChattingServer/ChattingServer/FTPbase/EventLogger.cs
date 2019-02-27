using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ChattingServer.FTPbase
{
    public sealed class EventLogger
    {
        /// <summary>
        /// It writes an exception error into the windows event log
        /// </summary>
        /// <param name="ex"></param>
        public static void Logger(Exception ex, string part)
        {
            try
            {
                if (!EventLog.Exists("FTP File Sharing", "."))
                {
                    EventLog.CreateEventSource(new EventSourceCreationData("FTP파일 공유중", "FTP 파일 공유"));
                }

                EventLog.WriteEntry("FTP 파일 공유중", part + " : " + ex.Message, EventLogEntryType.Error);
            }
            catch { }
        }
    }
}
