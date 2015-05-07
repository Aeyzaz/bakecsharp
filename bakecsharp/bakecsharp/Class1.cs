using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bakecsharp
{
    public class Bake
    {
        static public Int32 LetterCounter(String[] x)
        {
            int count = 0;
            foreach (String s in x)
            {
                int len = 0;
                foreach (Char c in s)
                {
                    if (c != 32 && c != 45) // Not counting Space and Hyphen
                    {
                        len++;
                    }
                }
                count += len;
            }
            return count;
        }

        /// <summary>
        /// Takes an Integer as an argument and returns an Integer array with Splitted number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static public Int32[] SplitNumber(Int32 num)
        {
            String n_org = num.ToString();
            String[] n = new String[n_org.Length];
            int counter = 0;
            foreach (Char c in n_org)
            {
                n[counter++] = c.ToString();
            }
            Int32[] numbers = new Int32[n.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(n[i]);
            }
            return numbers;
        }

    }
}
