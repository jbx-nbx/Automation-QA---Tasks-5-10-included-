using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev1
{

    public class q7_isValidPhoneNumber
    {
        public static bool PhoneNumber_isValid(string phoneNumber)
        {
            //first three digits check
            if (phoneNumber == null)
            {
                return false;
            }

            if (phoneNumber[0] != '0') 
                return false;
            if (phoneNumber[1] != '5')
                return false;
            if (phoneNumber[2] >= '0' && phoneNumber[2] <= '8')
            {

            }
            else
                {
                        return false;

                }



            //fourth index check

            if (phoneNumber[3] != '-')           
                return false;
            
                
                


            if (phoneNumber.Length != 11)
                return false;
            for (int i = 4; i < phoneNumber.Length; i++)
            {
                if (!char.IsDigit(phoneNumber[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }

}
