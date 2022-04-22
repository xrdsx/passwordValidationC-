using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formsAPP
{
    public class PasswordValidation
    {
        public string password { get; set; }

        public bool correctPassword = false;

        public bool validationCorrect = false;

        public void checkValidation(string password)
        {

            if (passLenght(password) == true)
            {

                if (passUpperCase(password) == true)
                {


                    if (passLowerCase(password) == true)
                    {
                        if(passSpecialSign(password)== true)
                        {
                            if (passNumber(password) == true)
                            {
                                completePassword();

                                // tu zwroci correctpassword na true


                                validationCorrect = true;


                            }
                        }
                    }

                }
            }
        }

        





        public bool passLenght(string password)
        {
            if (password.Length >= 8 && password.Length <= 15)
                return true;
            else
                
                return false;
        }
        
        public bool passUpperCase(string password)
        {
            if (password.Any(char.IsUpper))
                return true;
            else
               
            return false;

        }

        public bool passLowerCase(string password)
        {
            if (password.Any(char.IsLower))
                return true;
            else
                
            return false;

        }

        public bool passNumber(string password)
        {
            if (password.Any(char.IsNumber))
                return true;
            else
                
            return false;
        }

        public bool passSpecialSign(string password)
        {
            _ = Char.GetUnicodeCategory('!') == System.Globalization.UnicodeCategory.ModifierSymbol;

            if (password.Any(char.IsSymbol))
                return true;
            else
                
            return false;

        }

    

        public bool completePassword()
        {
            return correctPassword = true;
        }

        public bool refreshCorrectPassword()
        {
            return validationCorrect = false;
        }
    }
}
