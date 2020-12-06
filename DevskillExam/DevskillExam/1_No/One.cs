using System;
using System.Collections.Generic;
using System.Text;

namespace DevskillExam._1_No
{
    class One
    {


        public static void Sum(params int[] parameters)
        {
            int allSum  = 0;
            foreach(int i in parameters)
            {
                allSum += i;
            }
            Console.WriteLine(allSum);
        }

    }
}
