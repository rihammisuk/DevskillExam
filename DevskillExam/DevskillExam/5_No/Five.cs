using System;
using System.Collections.Generic;
using System.Text;

namespace DevskillExam._5_No
{
    class Five
    {
        public static long CalculateAsciiSum(string inputValue)
        {
            long[] ArrayOfSum= new long[inputValue.Length];
            int l = inputValue.Length;
            int pos = 0;
            long sum = 0;
            long bigSum = 0;
            for (int i = 0; i < l; i++)
            {
                if (inputValue[i] == ' ')
                {
                    bigSum += sum;
                    ArrayOfSum[pos++] = sum;
                    sum = 0;
                }
                else

                   
                    sum += inputValue[i];
            }


            ArrayOfSum[pos] = sum;
            bigSum += sum;
            return bigSum;
        }
    }
}
