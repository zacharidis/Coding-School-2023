﻿namespace Session_05
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


            Console.WriteLine();
            Console.WriteLine("Exercise 2");

            bool exitFlag = false;


            do
            {
                Console.WriteLine("Please enter a valid option : ");
                Console.WriteLine("Enter 1 for calculating the sum of numbers 1..n ");
                Console.WriteLine("Enter 2 for calculating the product of numbers 1..n");

                int inputChoice = Convert.ToInt32(Console.ReadLine());

                if (inputChoice == 1 || inputChoice == 2) {

                    exitFlag = true; // to exit the loop 

                    Console.WriteLine("Now please enter a positive integer : ");
                    int inputNumber = Convert.ToInt32(Console.ReadLine());

                    if (inputChoice == 1)
                    {
                        // call sum calculation
                    } else
                    {
                        // call product calculation
                    }
                    


                    
                }




            } while(!exitFlag);
            



        }
    }
}