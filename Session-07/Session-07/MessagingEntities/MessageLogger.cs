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
         private int _messageCounter = 0; // pinpoints the array pointer

        // constructor 

        

        public MessageLogger()
        {

           Messages = new Message[1000];
        }

        // methods 


        public void ReadAll()
        {
            foreach (Message message in Messages)
            {
                if(message != null )
                {
                    Console.WriteLine(message.Text);
                }
            }
        }
        
        public void Clear()
        {
            // null the messages array
            Message[] messages = null;
            _messageCounter = 0; // pointer goes to 0
           
        }

        public void Write(Message message)
        {
            Messages[_messageCounter] = message;
            _messageCounter++;
        }

    }
}
