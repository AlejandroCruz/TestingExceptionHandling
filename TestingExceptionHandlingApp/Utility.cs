using System;

namespace TestingExceptionHandlingApp
{
    internal class Utility
    {
        internal static int DivideByZero()
        {
            int divisor = 1;
            var utilResult = 1 / divisor;
            return utilResult;

            //int[] buggyArray = new int[2];
            //buggyArray[0] = 101;
            //buggyArray[1] = 102;

            //return buggyArray[2];
        }

        internal static int ForcedArrayOutOfRange()
        {
            int[] buggyArray = new int[2];
            buggyArray[0] = 101;
            buggyArray[1] = 102;

            return buggyArray[1];
        }
    }
}