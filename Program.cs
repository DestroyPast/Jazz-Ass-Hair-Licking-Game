using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazz_Ass_Hair_Licking_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int Money = 50;
            while (true)
            {
                String Imput = Console.ReadLine();
                if (Imput == "ping")
                {
                    Console.WriteLine("pong");
                }
                else if (Imput == "?Money")
                {
                    Console.WriteLine(Money);
                }
                else if (Imput == "!GetMoney")
                {
                    Money++;
                    Console.WriteLine("Now you have:" + Money);
                }
                else if (Imput == "!GetMoney 2")
                {
                    Money = Money + 2;
                    Console.WriteLine("Now you have:" + Money);

                }
            }

        }
    }
}
