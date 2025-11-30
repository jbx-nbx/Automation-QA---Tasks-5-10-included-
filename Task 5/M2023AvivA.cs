using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dev1
{
    public class M2023AvivA
    {

        public static bool q5_Brothers(int num1, int num2)
        {
          string s1 = num1.ToString();
          string s2 = num2.ToString();
            if (s1[0] == s2[0] && s1[s1.Length-1] == s2[s2.Length-1])
            
                return true;
                else
                    return false;
            
        }
    }
}
