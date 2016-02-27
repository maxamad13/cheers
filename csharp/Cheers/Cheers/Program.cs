using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please inter your birthday. e.x.10/10");
            DateTime BirthDate = DateTime.Parse(Console.ReadLine());

            name = name.ToUpper();
            Console.WriteLine("Your Name is  " + name.Length + " Character Long");
            Char[] Letters = new[] { 'H', 'A', 'L', 'F', 'N', 'O', 'R', 'S', 'S', 'E', 'M', 'I', 'X' };

            Char[] NewNames = name.ToCharArray();


            foreach (var temp in NewNames)
            {
                if (Letters.Contains(temp))
                {
                    Console.WriteLine("Give me an  " + temp);
                }
                else
                {
                    Console.WriteLine("Give me a   " + temp + " ");

                }


            }

            TimeSpan DayLeft = BirthDate.Subtract(DateTime.Now);
            DateTime CurrentDate = DateTime.Now;
            

            if (DayLeft.TotalDays < -1)
            {
                Console.WriteLine("Your Birthay is {0:0} days left", DayLeft.TotalDays+365 );
            }
            else if (DayLeft.TotalDays >= -1 && DayLeft.TotalDays < 0)
            {
                Console.WriteLine("Happy birthday");
            }        
            else
            {
                Console.WriteLine("Yur Birthday is {0:0} Days Left ",DayLeft.TotalDays);
            }
            Console.ReadKey();


        }
    }
}
