using System;
using System.Collections.Generic;
using System.Text;

namespace DevskillExam._2_No
{
    class Two
    {
        public static Tuple<int, float> TextAnalysis(string[] input)
        {
            int maxlength = 0;
            int templength = 0;
            int totalstringlength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                totalstringlength = totalstringlength + input[i].Length;

                if (i == 0)
                {
                    templength = input[i].Length;
                    maxlength = templength;
                }
                if ((i + 1) < input.Length)
                {
                    templength = input[i].Length;

                    if (input[i + 1].Length > templength)
                    {
                        maxlength = input[i + 1].Length;
                    }

                }

            }


            return new Tuple<int, float>(maxlength, totalstringlength / input.Length);
        }
    }
}
    
