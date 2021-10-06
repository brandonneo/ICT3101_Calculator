using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    // Q16b Factorial 1 input only taking the 1st one only 
                    result = Factorial(num1);
                    break;
                case "aot":
                    // Q17a Area of triangle
                    result = AreaOfTriangle(num1, num2);
                    break;
                case "aoc":
                    // Q17b Area of circle
                    result = AreaOfCircle(num1);
                    break;
                case "ufa":
                    // Q18a: Unknown Function A
                    result = UnknownFunctionA(num1, num2);
                    break;
                case "ufb":
                    // Q18b: Unknown Function B
                    result = UnknownFunctionB(num1, num2);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        //q14
        public double Add(double num1, double num2)
        {
            //q11 LAB 2.1
            string stringNum1 = num1.ToString();
            string stringNum2 = num2.ToString();


            stringNum1 = stringNum1 + "00";

            stringNum2.Insert(0, "0");
            double blNum1 = Convert.ToDouble(Convert.ToInt32(stringNum1, 2));
            double blNum2 = Convert.ToDouble(Convert.ToInt32(stringNum2, 2));


            return (blNum1 + blNum2);   
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            //q15a LAB 1
            /*       if (num1 == 0 || num2 == 0)
                   {
                       throw new ArgumentException();
                   }
                   return (num1 / num2);*/
            //q12 LAB 2.1
           
            if (num1 == 0 && num2 == 0)
            {
                return 1;
            }
            else {
                return (num1 / num2);
            }
           

        }
        //q16
        public double Factorial(double num1) {
            double i, fact = 1;
            /*       //Qlab 2.1
                   if (num1 <=0) {
                       return 0;
                   }
                   else {
                       for (i = 1; i <= num1; i++)
                       {
                           fact = fact * i;
                       }

                   }
                   return fact;*/
            //q16 lab2.2
            double result = 1;
            while (num1 != 0)
            {
                result *= num1;
                num1--;
            }
            return result;
        }
        // q17
        public double AreaOfTriangle(double num1, double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException();
            }
            return (0.5 * num1 * num2);
        }
        // q17b
        public double AreaOfCircle(double num1)
        {
            if (num1 <= 0)
            {
                throw new ArgumentException();
            }
            return (Math.PI * num1 * num1);
        }
        // q18a
        public double UnknownFunctionA(double num1, double num2)
        {
            return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
        }
        // q18b
        public double UnknownFunctionB(double num1, double num2)
        {
            return Divide(Factorial(num1), Multiply(Factorial(num2), Factorial(Subtract(num1, num2))));
        }

        // q17 lab 2.2
        public double MTBF(double MTTF, double MTTR)
        {
            return MTTF + MTTR;
        }

        public double Availability(double MTTF, double MTBF)
        {
            return (MTTF / MTBF);
        }
        // q18 lab2.2
        public double CurrentFailureIntensity(double num1, double num2, double num3)
        {
            return (Multiply(num1, 1 - Divide(num2, num3)));
        }
        public double AverageNumberofExpectedFailures(double num1, double num2, double num3)
        {
            return (Multiply(num1, 1 - Math.Pow(Math.E, Divide(Multiply(-num2, num3), num1))));
        }

        // q22 lab 2.3
        public double DefectDensity(double defects, double CSI)
        {
            return (defects / CSI);
        }

        public double SSISecondRelease(double SSIOld, double CSI, double changedCode)
        {
            return (Subtract((SSIOld + CSI), changedCode));
        }

        // Lab 4
        public double GenMagicNum(double input, IFileReader fileReader) // lab4 q7
        {
            double result = 0;
            int choice = Convert.ToInt16(input);

            // Lab 4 Q1
            //Dependency------------------------------
            //FileReader getTheMagic = new FileReader();
            //----------------------------------------
            //string[] magicStrings = getTheMagic.Read(@"Your file name");

            string[] magicStrings = fileReader.Read(@"C:\Users\Brandon\source\repos\ICT3101_Calculator\ICT3101_Calculator\MagicNumbers.txt");
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }
    }
}
