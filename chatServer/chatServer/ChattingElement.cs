using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chatServer
{
    class ChattingElement
    {
        private string roomName;
        private string messageBody;
        private string roomOwner;
        private string nickNames="";//nickName들

        public string RoomName { get => roomName; set => roomName = value; }
        public string NicNames { get => nickNames; set => nickNames = value; }
        public string MessageBody { get => messageBody; set => messageBody = value; }
        public string RoomOwner { get => roomOwner; set => roomOwner = value; }
    }
}
