namespace Session_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Session-05");
            Console.WriteLine("By Georgios Zacharidis");
            Console.WriteLine();


            Console.WriteLine("Exercise 1");
            NameReversal nameReversal = new NameReversal();
            Console.WriteLine("The reverse of my name");
            string myName = "Georgios";
            Console.WriteLine($"My name is {myName}");
            Console.WriteLine("The reverse is " + nameReversal.Reverse(myName));



            



        }
    }
}