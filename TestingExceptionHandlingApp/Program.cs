using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestingExceptionHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainResult = ExceptionsInExternalFunctions();

            Console.WriteLine("Process without Exceptions?: " + mainResult);
        }

        private static bool ExceptionsInExternalFunctions()
        {
            bool withoutErrors = true;
            double divisionResult = 9999;
            int arrayElement = -1;

            // Exception executing in a class outside scope
            //  does bubble up to caller class and throws catch block.
            try
            {
                divisionResult = Utility.DivideByZero();

                Console.WriteLine("\n-- [DEBUG] -->\n");
                Console.WriteLine("Division result: " + divisionResult);
                Console.WriteLine("\n<-- [DEBUG] --\n");

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("\n-- [DEBUG] -->\n");
                Console.WriteLine("::My Exception:: " + e);
                Console.WriteLine("\n<-- [DEBUG] --\n");

                withoutErrors = false;
            }

            // Force out of range exception
            try
            {
                arrayElement = Utility.ForcedArrayOutOfRange();

                Console.WriteLine("\n-- [DEBUG] -->\n");
                Console.WriteLine("Value in element: " + arrayElement);
                Console.WriteLine("\n<-- [DEBUG] --\n");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("\n-- [DEBUG] -->\n");
                Console.WriteLine("::My Exception:: " + e);
                Console.WriteLine("\n<-- [DEBUG] --\n");

                withoutErrors = false;
            }

            return withoutErrors;
        }

    }
}
