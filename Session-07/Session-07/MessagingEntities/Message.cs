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

        public String? MessageBody { get; set; }



        public Message()
        {

        }

        public Message(Guid id , DateTime dateTime , String messageBody)
        {

            ID = id;
            TimeStamp = dateTime;
            MessageBody = messageBody;
        }
    }

  
}
