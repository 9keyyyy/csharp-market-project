using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Message
    {
        //[MessageID, PostID, SenderID, ReceiverID, 내용, 시간]
        public int ID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public int PID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Time { get; set; }
    }
}
