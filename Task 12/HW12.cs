using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev1
{
    public class HW12
    {

        public double calArrAvg(double[] arr)
        {
            double CountSimilar = 0.0;

            if (arr == null) //if the array is null.
                return 0.0;
            if(arr.Length == 0)  //if the arr length value is 0.
                return 0.0;
            if( arr.Length == 1 ) //if the array has a single item.
                return arr[0];
            
            for(int i=0; i < arr.Length; i++)
            {
                for(int j=arr.Length-1; j>arr.Length; j--)
                {
                    if (arr[i] == arr[j])
                        CountSimilar = arr[i];

                }
            }

            return CountSimilar;
        }


    }
}
