using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> ExamGrades = new List<double>();
            string answer;
            

            do
            {
                Console.WriteLine("Please enter one of your exam grades");
                double ExamGrade = Convert.ToDouble(Console.ReadLine());

                ExamGrades.Add(ExamGrade);

                Console.WriteLine("Do you have any other exam grades to tell me?");
                answer = Console.ReadLine();
            } while (answer.ToLower() == "yes");

            do
            {
                double number;
                double ExamGrade;
               if (number > ExamGrade)
                {
                    max= number
                }

            }while ()
            


        }
    }
}
