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
            Console.WriteLine("Exercise 4");
            AgeGenderPrinter ageGenderPrinter = new AgeGenderPrinter();
            Console.WriteLine(ageGenderPrinter.Print());
            
            Console.WriteLine();
            Console.WriteLine("Exercise 5");
            SecConverter secConverter = new SecConverter();
            Console.WriteLine(secConverter.Convert());

            Console.WriteLine();
            Console.WriteLine("Exercise 6");
            SecConverterNet secConverterNet = new SecConverterNet();
            Console.WriteLine(secConverterNet.Convert());
            
            Console.WriteLine();
            Console.WriteLine("Exercise 7");

            TemperatureConverter temperatureConverter = new TemperatureConverter();
            Console.WriteLine("35 degress of celsius are : " + temperatureConverter.ConvertFarenheit() + " Farenheit ");
            Console.WriteLine("35 degrees of celsius are : " + temperatureConverter.ConvertKelvin() + " Kelvin ");

            Console.WriteLine("End of Session-04");

        }
    }
}