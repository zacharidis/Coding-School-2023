using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.MessagingEntities
{
    internal class Message
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }

        public String? Text { get; set; }



        public Message()
        {
            ID = Guid.NewGuid();
        }

        public Message(string text)
        {

            ID = Guid.NewGuid();
            TimeStamp = DateTime.Now;
            Text = text;

        }
    }

  
}
