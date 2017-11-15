using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array7
{
    static class Average
    {
        /*Для задания 3*/
        static public double execute(ref ArrayList arr)
        {
            double sum = 0;
            foreach (double item in arr)
            {
                sum += item;
            }

            double average = sum / arr.Count;

            for(int i=0; i<arr.Count; i++)
            {
                if ((double)arr[i] < average)
                {
                    arr[i] = 0;
                }
            }

            return average;
        }


        /*Для задания 4*/

        static public bool StackVerification(string brackets)
        {

            Stack verification = new Stack();
            foreach (char symbol in brackets)
            {
                if (symbol == '(')
                {
                    verification.Push(symbol);
                }
                if (symbol == ')')
                {
                    try
                    {
                        verification.Pop();
                    }
                    catch { }                    
                }                
            }
            return (verification.Count > 0) ? false : true;
        }
    }
}
