using System;

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





            Console.WriteLine();
            Console.WriteLine("Exercise 2");
            SumProductCalculator calculator = new SumProductCalculator();

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
                        Console.WriteLine($"The sum of numbers 1 to {inputNumber} is : {calculator.CalculateSum(inputNumber)}");
                        
                    } else
                    {
                        Console.WriteLine($"The product of numbers 1 to {inputNumber} is : {calculator.CalculateProduct(inputNumber)}");
                    }
                    


                    
                }




            } while(!exitFlag);




            Console.WriteLine();
            Console.WriteLine("Exercise 3");
            PrimeCalculator primeCalculator = new PrimeCalculator();    

            exitFlag = false;
            do
            {
                Console.WriteLine("Please enter a positive integer to calculate the prime numbers in the range of 1...n");
                int inputPrime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your number is : {inputPrime}");

                if (inputPrime == 1 || inputPrime == 0)
                {
                    Console.WriteLine("Please enter a value of 2 or greater. Try again");
                } else
                {
                    // call the calculator 
                    Console.WriteLine(primeCalculator.Find(inputPrime));
                    exitFlag = true;

                }


            } while(!exitFlag);



            Console.WriteLine();
            Console.WriteLine("Exercise 4 : ");
            Console.WriteLine("Calcuate the cartesian product of  : ");
            Console.WriteLine("[2,4,9,12] and [1,3,7,10]");
            
            
            DescartesCalculator descartesCalculator = new DescartesCalculator();
            

            // send the 2 arrays to the object method
            int[] arrayOne = { 2, 4, 9, 12 };
            int[] arrayTwo = { 1, 3, 7, 10 }; 
            int length = arrayOne.Length * arrayTwo.Length;
            
            int[] localArray = new int[length];

            Console.WriteLine("The Cartesian product of these arrays is : ");

            // createing new local array to hold the returned array vals
            localArray = descartesCalculator.Calculate(arrayOne, arrayTwo, length);

             for (int i = 0; i < localArray.Length; i ++ )
            {
                Console.Write(localArray[i]);
                 Console.Write(',');
            }











            Console.WriteLine();
            Console.WriteLine("Exercise 5 : ");
            Console.WriteLine("Sort the following array: [ 0, -2, 1, 20, -31, 50 , -4, 17, 89, 100 ] from the lowest to the highest value ");

            int[] arrayUnsorted = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

            // call the


    }
    }
}