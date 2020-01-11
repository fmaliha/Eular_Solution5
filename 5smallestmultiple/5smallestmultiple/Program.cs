using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5smallestmultiple
{
    class Program
    {

        static int smallestnum = 2520;

        static void Main(string[] args)
        {
             IsDivisible();

             Console.ReadKey();
            
           
          
        }

        private static  int   IsDivisible()
        {
           
         
                 for (int i = 1; i <= 20; i++)  ///checks for 1 to 20 each number
            {
                if (smallestnum % i == 0)
                {
                   // Console.WriteLine("The num {0} is divisible by {1}",smallestnum,i);
                    
                }

                else
                {
                    //Console.WriteLine("The num {0} is not divisible by {1}",smallestnum,i);    the commented lines  makes the code run for 15 mins as extra lines are printed.
                   smallestnum += 20;   // as being divided by 20 can also be devided by 2,5,10
                   //Console.WriteLine("Now The Sm is  {0}", smallestnum);
                    i = 1;
                }

            }

            Console.WriteLine(smallestnum); //printing the final num
                
          
           
            return 1;
        }
    }
}
