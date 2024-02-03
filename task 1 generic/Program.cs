using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_generic
{
    internal class Program

    {
        static void Main(string[] args)
        {
            double[] marks = { 83.5, 90.0, 78.5, 92.5, 89.00 };
            CalculateMarks(marks);

         
            double num1 = -4;
            double num2 = 25;

            CalculateSquareRoot(num1, num2);

        }


        static void CalculateMarks<T>(T[] marks) 
        {
            try
            {
                double sum = 0.0;

                foreach (var mark in marks)
                {
                    sum += Convert.ToDouble(mark);
                }

                double average = sum / marks.Length;

                Console.WriteLine("Average: "+ average);

                Console.WriteLine("Marks above average:");
                foreach (var mark in marks)
                {
                    if (Convert.ToDouble(mark) > average)
                    {
                        Console.WriteLine(mark);
                    }
                }

                Console.WriteLine("Marks below average:");
                foreach (var mark in marks)
                {
                    if (Convert.ToDouble(mark) < average)
                    {
                        Console.WriteLine(mark);
                    }
                }
            }
            catch (FormatException )
            {
                Console.WriteLine( "Please ensure all marks are valid numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error"+ex.Message);
            }
        }

        static void CalculateSquareRoot(double num1, double num2)
        {
            try
            {
                if (num1 > 0)
                {

                    double sqrt1 = Math.Sqrt(num1);
                    Console.WriteLine($"Square root of num1 {num1}: {sqrt1}");
                }
                else { Console.WriteLine("number1 is negative"); }

                if (num2 > 0)
                {

                    double sqrt2 = Math.Sqrt(num2);
                    Console.WriteLine($"Square root of num2 {num2}: {sqrt2}");
                }
                else { Console.WriteLine("number2 is negative"); }
            }





            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    }
}