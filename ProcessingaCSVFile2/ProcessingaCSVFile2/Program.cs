using System;
using System.IO;
namespace ProcessingaCSVFile2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Name = 4
            //Transaction_Date = 0
            //Payment_Type = 3
            //Country = 7
            string filePath = @"C:\Users\abarre05\Downloads\SalesJan2009.csv";
            string[] lines = File.ReadAllLines(filePath);
            string Payment_Type;
            string Country;
            string Name;
            string Transaction_Date;
            if (Payment_Type = "Visa");
               (Country = "United States");

            {
                Console.WriteLine("The name for the transaction is " + Name + " and the Transaction Date is " + Transaction_Date);
            }

            Console.ReadKey();

        }
    }
}
