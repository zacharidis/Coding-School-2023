using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    // append error messages received through try-catch and log them with append to a file "exceptions.txt"
    internal class ExceptionLogger
    {
        public DateTime  MessageTime { get; set; }

        public ExceptionLogger(DateTime dateTime) {
          MessageTime= dateTime; 
        }


        public void Log(string message) {


            string logfile = @"exceptions.txt";

            //the file does NOT exist so we create iot
            if(!File.Exists(logfile)) 
            {
                using (StreamWriter streamWriter = new StreamWriter(logfile))
                {
                    streamWriter.WriteLine("Error Logger for Coffee Shop");
                }

            }
            else
            {
                using (StreamWriter streamWriter = File.AppendText(logfile))
                {


                    streamWriter.WriteLine("##### ERROR #####");
                    streamWriter.WriteLine(System.DateTime.Today);

                    streamWriter.WriteLine("Exception : " + message);
                    streamWriter.Close();

                
                
                    
                }
            }



        
        }
    }
}
