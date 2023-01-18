using Session_07.ActionEntities;
using System.Security.Cryptography.X509Certificates;

namespace Session_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
       



           Console.WriteLine("Welcome to Session-07");

            ActionRequest request = new ActionRequest()
            {
                Input = "ABCDEFGHIJKLM",
                Action = ActionEnum.Reverse
            };

        // bootstraping some objects 

           ActionResponse response = new ActionResponse();
            
            ActionResolver resolver = new ActionResolver();

            resolver.Logger.ReadAll();

            Console.ReadLine();

        }
    }
}