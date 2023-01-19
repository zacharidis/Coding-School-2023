﻿using System.Security.Cryptography.X509Certificates;

namespace CalculatorLib
{
    public class Class1
    {


        public string Parser(string inputExpression)
        {
            string outputExpression;
            
            if (inputExpression == null)
            {
                return "Invalid Expression";
            } else if (inputExpression.Contains('+')) {
                
                // call the Add function 

            } else if (inputExpression.Contains("-")) {
            
                // call the  Subtract function 
                } else if (!inputExpression.Contains("/"))
            {
                // call the division function
            }  else if (inputExpression.Contains('*'))
            {
                // call the multiplication function 
            }  else if (inputExpression.Contains("^")) {
                // call the power function 
            } else
            {
                // call the root function
            }

            return outputExpression; 
          
        }



         public string Add(decimal inputOne , decimal inputTwo)
        {
            return (inputOne + inputTwo).ToString();
        }

        public string Subtract(decimal inputOne , decimal inputTwo)
        {
            return (inputOne - inputTwo).ToString();
        }

        public string Divide(decimal inputOne , decimal inputTwo)
        {
            return (inputOne / inputTwo).ToString();
        }

        public string Multiply(decimal inputOne , decimal inputTwo) { 
            
            return (inputOne * inputTwo).ToString();
            } 

        public string Power(decimal inputOne , decimal inputTwo)
        {
            return (Math.Pow((double)inputOne, (double)inputTwo).ToString());
        }

        public string Root(decimal inputOne)
        {
            return (Math.Sqrt((double)inputOne).ToString());
        }
    }
}