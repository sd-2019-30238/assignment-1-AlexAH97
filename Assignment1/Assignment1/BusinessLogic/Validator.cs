using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.BusinessLogic
{
    class Validator
    {

        //All method will return 0 for a false 
        public static int TextBoxValidator(String txt)
        {
            if (String.IsNullOrEmpty(txt))
                return 0;
            return 1;
        }


        public static int EmailValidator(String txt)
        {
            if (TextBoxValidator(txt) == 1)
                if (txt.Contains("@"))
                    return 1;
            return 0;
        }
        public static int PasswordVerification(String str1,String str2)
        {
            if (String.Equals(str1, str2))
                return 1;
            return 0;
        }
    }

}
