using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program
    {
        static void Main(string[] args)
           
        
        {
            int number1=1;
            int number2=1;
            do
            {
                Console.WriteLine("Please enter a minimum value");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter a maximum value");
                number2 = Convert.ToInt32(Console.ReadLine());

                Random rnd = new Random();
                int randomnum = rnd.Next(number1 + number2 + 1);
                

            }
            while ( int = 1);
            Console.ReadKey();
            


        }
    }
}
