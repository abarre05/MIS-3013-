using System;

namespace Conditional_CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int number = rnd.Next(1, 3);
            Console.WriteLine("Please pick heads or tails");
            string CoinToss = Convert.ToString(Console.ReadLine());

            
            if (number == 1)
            {
                Console.WriteLine("heads");
            }
            else
            {
                Console.WriteLine("tails");
            }
            
            
       
            


        }
    }
}
