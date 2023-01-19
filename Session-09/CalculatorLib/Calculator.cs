using System.Security.Cryptography.X509Certificates;

namespace CalculatorLib
{
    public class Calculator
    {


        public string Parser(string inputExpression)
        {
            string outputExpression = "";
            double inputNumberOne = 0;
            double inputNumberTwo = 0;


            char[] delimiterChars = { '+', ',' ,'/','r','*','^'};
            

            string[] words = inputExpression.Split(delimiterChars);

            inputNumberOne = Double.Parse(words[0]);
            inputNumberTwo = Double.Parse(words[1]);

            if (inputExpression == null)
            {
                return "Invalid Expression";

            } else if (inputExpression.Contains('+')) {

                Add add = new Add();

                outputExpression = add.Calculate(inputNumberOne,inputNumberTwo);

            } else if (inputExpression.Contains("-")) {
            
                Subtract subtract = new Subtract();
                 outputExpression = subtract.Calculate(inputNumberOne, inputNumberTwo);

                } else if (inputExpression.Contains("/"))
            {
                outputExpression = Divide(inputNumberOne, inputNumberTwo);

            }  else if (inputExpression.Contains('*'))
            {
                outputExpression = Multiply(inputNumberOne, inputNumberTwo);

            }  else if (inputExpression.Contains("^")) {

                outputExpression = Power(inputNumberOne, inputNumberTwo);
            } else
            {
                outputExpression = Root(inputNumberOne);
            }

            return outputExpression; 
          
        }



       

    

        public string Divide(double inputOne , double inputTwo)
        {
            return (inputOne / inputTwo).ToString();
        }

        public string Multiply (double inputOne , double  inputTwo) { 
            
            return (inputOne * inputTwo).ToString();
            } 

        public string Power(double inputOne , double inputTwo)
        {
            return (Math.Pow(inputOne, inputTwo)).ToString();
        }

        public string Root(double inputOne)
        {
            return (Math.Sqrt(inputOne).ToString());
        }
    }
}