using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.MessagingEntities
{
    internal class MessageLogger
    {

        //properties
        public Message[] Messages { get; set; }

        // constructor 

        public MessageLogger() { }

        public MessageLogger(Message[] messages)
        {

            Messages = messages;
        }

        // methods 


        public Message[] ReadAll()
        {
            return Messages;
        }
        
        public void Clear()
        {
            // null the messages array
            Message[] messages = null;
           
        }

        public void Write(Message message)
        {
           
        }

    }
}
