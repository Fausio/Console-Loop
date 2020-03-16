using System;

namespace Console_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            #region For statment 
            //Console.WriteLine("Add number to multiplay with 0 to 9");
            //int number = Int32.Parse(Console.ReadLine());

            //for (int i = 0; i <= 9; i++)
            //{
            //    Console.WriteLine("{0} X {1} = " + (number * i), number, i);
            //}


            //Console.WriteLine("________________________________________");
            //for (int i = 9; i >= 0; i--)
            //{
            //    Console.WriteLine("{0} X {1} = " + (number * i), number, i);
            //}
            #endregion
            #region While statment 
            //int sum = 0;
            //int r = 0;
            //int n = 2367;
            //Console.WriteLine("2367 % 10 is: " + (2367 % 10));
            //Console.WriteLine("sum + r is: " + (0 + (2367 % 10)));
            //Console.WriteLine("n / 10  is: " + (2367/10));
            //while (n != 0)
            //{
            //    r = n % 10;
            //    sum = sum + r;
            //    n = n / 10;
            //}
            //Console.WriteLine("Sum is " + sum);
            #endregion
            #region do - While statment 
            //int i;
            //do
            //{
            //    i = int.Parse(Console.ReadLine());
            //} while (i != 0);
            #endregion
            #region Loop-Statment 
            //while (true)
            //{
            //    Console.WriteLine("♥ infinit love on you RAM on while loop");
            //}

            for( ; ; )
            {
                Console.WriteLine("♥ infinit love on you RAM on while for loop");
            }
            #endregion


            //Console.ReadKey();
        }
    }
}
