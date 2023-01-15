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

            exitFlag = false;
            do
            {
                Console.WriteLine("Please enter a positive integer to calculate the prime numbers in the range of 1...n");
                int inputPrime = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your number is : {inputPrime}");

                if (inputPrime == 1 || inputPrime == 0)
                {
                    Console.WriteLine("Something is wrong  please try again");
                } else
                {
                    // call the calculator 

                }


            } while(!exitFlag);
         








        }
    }
}