using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class HW13
    {
        public static bool balancedNum(int[] arr)
        {
            int positiveCount = 0, negativeCount =0;
            if (arr == null || arr.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positiveCount++;
                }
                else if (arr[i] < 0)
                {
                    negativeCount++;
                }
            }

            if (positiveCount == negativeCount)
            {
                return true;
            }


            return false;
        }

    }
}
