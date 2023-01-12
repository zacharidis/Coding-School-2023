namespace Session_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Session-04 ");
            Console.WriteLine("Written by Georgios Zacharidis");
            Console.WriteLine();


            Console.WriteLine("Exercise 1");
            HelloPrinter helloPrinter = new HelloPrinter();
            Console.WriteLine(helloPrinter.Print());

            Console.WriteLine();
            Console.WriteLine("Exercise 2");
            SumDiv sumDiv = new SumDiv();
            Console.WriteLine(sumDiv.Sum());
            Console.WriteLine(sumDiv.Div());
            
            Console.WriteLine();
            Console.WriteLine("Exercise 3");
            AdvancedCalculator advancedCalculator = new AdvancedCalculator(); 
            Console.WriteLine(advancedCalculator.CalculationOne());
            Console.WriteLine(advancedCalculator.CalculationTwo());
            Console.WriteLine(advancedCalculator.CalculationThree());
            Console.WriteLine(advancedCalculator.CalculationFour());
            Console.WriteLine(advancedCalculator.CalculationFive());

            Console.WriteLine();


        }
    }
}