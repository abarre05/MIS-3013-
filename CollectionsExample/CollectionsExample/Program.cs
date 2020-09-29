using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentIDs = new int[3];
            double[] gpas = new double[3];
            studentIDs[0] = 1;
            studentIDs[1] = 2;
            studentIDs[2] = 3;
           
            gpas [0] = 1.75;
            gpas[1] = 2.99;
            gpas [2] = 4.0;
            

            for (int i = 0; i < studentIDs.Length; i++)
            {
                int studentID = studentIDs[i];
                Console.WriteLine(studentID);

            }
            Console.WriteLine("Please pick an ID to display the GPA of");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < studentIDs.Length; i++)
                int studentID = studentIDs[i];
                if (studentID == id)
                {
                double gpa = gpas[i];
                
            }


            Console.ReadKey();
        }
    }
}
