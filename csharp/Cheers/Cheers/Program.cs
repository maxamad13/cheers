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
            name =  name.ToUpper();
            Console.WriteLine("Your Name is  " + name.Length + " Character Long");
            Char [] Letters = new[] { 'H', 'A', 'L', 'F', 'N', 'O', 'R', 'S', 'S', 'E', 'M', 'I', 'X' };
           
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
            Console.WriteLine("Cheers Your Name is  " + name.ToUpper());
        }

        private static char Contains(int v)
        {
            throw new NotImplementedException();
        }
    }
}
