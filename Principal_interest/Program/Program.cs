using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Programg
    {
        static void Main(string[] args)
        {
            int nMaximuminterest = 50;
            decimal mPrincipal;
            
            while (true)
            {
                Console.Write("Enter Principal: ");
                string sPrincipal = Console.ReadLine();
                mPrincipal = Convert.ToDecimal(sPrincipal);
                
                if(mPrincipal >= 0 )
                {
                    break;           
                }
                
                Console.WriteLine("Principal cannot be negatine");
                Console.WriteLine("TryAgain");
                Console.WriteLine();
            }

            decimal minterest;
            while(true)
            {
                Console.Write("Enter interest: ");
                string sinterest = Console.ReadLine();
                minterest = Convert.ToDecimal(sinterest);
                
                if (minterest >= 0 && minterest <= nMaximuminterest )
                {
                    break;
                }

                Console.WriteLine("Interest cannot be negative" + "or greater than " + nMaximuminterest);
                Console.WriteLine("Try again");
                Console.WriteLine();
            }

            Console.Write("Enter number of year: ");
            string sDuration = Console.ReadLine();
            int nDuration = Convert.ToInt32(sDuration);
            Console.WriteLine();
            Console.WriteLine("Principal = " + mPrincipal);

            Console.WriteLine("Interest = " + minterest);
            Console.WriteLine("Duration = " + nDuration + "years");
            Console.WriteLine();
            int nYear = 1;
            while (nYear <= nDuration)
            {
                decimal minterestPaid;
                minterestPaid = mPrincipal * (minterest / 100);
                mPrincipal = mPrincipal + minterestPaid;
                mPrincipal = decimal.Round(mPrincipal, 2);
                Console.WriteLine(nYear + " - " + mPrincipal);
                nYear = nYear + 1;
            }

            Console.WriteLine("Press Enter to end program...");
            Console.Read();
        }
    }
}
