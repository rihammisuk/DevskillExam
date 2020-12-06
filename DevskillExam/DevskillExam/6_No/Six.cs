using System;
using System.Collections.Generic;
using System.Text;

namespace DevskillExam._6_No
{
    class Six
    {
   
       public static List<int> OddDigits(int n)
        {
            
            var list = new List<int>();
            while (n > 0)
            {
                int left = (int)(n % 10);
                if (left % 2 != 0)
                {
                    list.Add(left);
                }
                n /= 10;
            }

            return list;
        }
    }
}
