using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionUserResistrationUc2
{
   public class RegExWithException
    {
        public string message;  // instance veriable 

        // intialize parameterise constructer and store the user inpute name
        public RegExWithException(string message)
        {
            this.message = message;

        }
        //We are using this method to match pattern of first name
        public string validFirstName()
        {

            string firstname = "^[A-Z]{1}[a-zA-Z]{2}$";  //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(firstname);
            try
            {
                //this is the custom exception that we declared for checking empty messages. exception type is an enum followed by the message.
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }

                if (regex.IsMatch(message))
                {
                    //Console.WriteLine(Name + "-->Valid");
                    return "Valid";
                }
                else
                {
                    // Console.WriteLine(Name + "--->Invalid");
                    return "Invalid";
                }
            }
            catch (ArgumentNullException)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "Invalid");
            }
        }

        // Uc2 Regular Exprection use the exception
        public string validLastName()
        {

            string Lastname = "^[A-Z]{1}[a-zA-Z]{2}$";  //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(Lastname);
            try
            {
                //this is the custom exception that we declared for checking empty messages. exception type is an enum followed by the message.
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }

                if (regex.IsMatch(message))
                {
                    //Console.WriteLine(Name + "-->Valid");
                    return "Valid";
                }
                else
                {
                    // Console.WriteLine(Name + "--->Invalid");
                    return "Invalid";
                }
            }
            catch (ArgumentNullException)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "Invalid");
            }
        }
    }
}
