using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev1
{
    public class HW11
    {
        public static int GetMaxValInIntArr(int[] arr)
        {
            //checking if the array is null or if the arr.length is 0 (empty)
            if (arr == null || arr.Length == 0)
            {
                return int.MinValue;
            }

            int maxVal = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxVal)
                {
                    maxVal = arr[i];
                }
            }
            return maxVal;
        }

    }
}
