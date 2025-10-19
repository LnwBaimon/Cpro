using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of values to avereage: ");
            string sNumElements = Console.ReadLine();
            int numElements = Convert.ToInt32(sNumElements);
            Console.WriteLine();
            double[] dArray = new double[numElements];
            for (int i = 0;i < numElements; i++)
            {
                Console.Write("Enter Integeer #" + (i + 1) + ": ");
                string sVal = Console.ReadLine();
                double dValue = Convert.ToDouble(sVal);
                dArray[i] = dValue;
            }

            double dSum = 0;
            for (int i = 0; i < numElements; i++)
            {
                dSum += dArray[i];
            }

            double dAverage = dSum / numElements;
            Console.WriteLine();
            Console.Write(dAverage + " is the average of (" + dArray[0]);
            for (int i = 1; i < numElements; i++)
            {
                Console.Write(" + " + dArray[i]);
            }
            Console.WriteLine(") / " + numElements);
            Console.WriteLine("Enter to end program");
            Console.Read();

        }
    }
}
