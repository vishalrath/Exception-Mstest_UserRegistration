using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Uc10_Using_LamdaFun_Exception_Mstesting_UserRegistration
{
   public class UsingLamda_UserRegistration
    {
        public string message;  // instance veriable 

        // intialize parameterise constructer and store the user inpute name
        public UsingLamda_UserRegistration(string message)
        {
            this.message = message;

        }
        //We are using this method to match pattern of first name
        public string validFirstName()
        {

            string firstname = "^[A-Z]{1}[a-zA-Z]{2}$";  //Expression for first letter is capital and maximum charactor is 3
            // Regex regex = new Regex(firstname);
            // validate fist name using lambda function
            bool testFirstName(string firstName) => (Regex.IsMatch(firstName, firstname));
            bool result = testFirstName(message);
            try
            {
                //this is the custom exception that we declared for checking empty messages. exception type is an enum followed by the message.
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }

                if (result)
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
                                                        // Regex regex = new Regex(Lastname);
            bool testLastName(string larstName) => (Regex.IsMatch(larstName, Lastname));
            bool result = testLastName(message);
            try
            {
                //this is the custom exception that we declared for checking empty messages. exception type is an enum followed by the message.
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }

                if (result)
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

        // Uc Regular Exprection use the exception to the valid mail
        public string validMail()
        {
            string emailPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$"; // RegEx Expression for gmail 
                                                                                               //Regex regex = new Regex(emailPattern);
                                                                                               //using lamda function
            bool testEmailId(string emailId) => (Regex.IsMatch(emailId, emailPattern));
            bool result = testEmailId(message);

            try
            {
                //this is the custom exception that we declared for checking empty messages. exception type is an enum followed by the message.
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }

                if (result)
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

        //Uc4 Regex use the Exception
        public string MobileNo()
        {
            string Mobnumber = "^[0-9]{1,2}[ ]{1}[0-9]{10}$";  //Expression for Validating mobileFormating
                                                               // Regex regex = new Regex(Mobnumber);
                                                               //mobile number valaidation using lamda function
            bool testmobilenumber(string Mobile) => (Regex.IsMatch(Mobile, Mobnumber));
            bool result = testmobilenumber(message);
            try
            {
                //this is the custom exception that we declared for checking empty messages. exception type is an enum followed by the message.
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }

                if (result)
                {
                    //Console.WriteLine(number + "-- > Valid");
                    return "Valid";
                }
                else
                {
                    //Console.WriteLine(number + "-- > InValid");
                    return "Invalid";
                }
            }
            catch (ArgumentNullException)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "Invalid");
            }

        }
        //Uc5 Regex use the Exception
        public string Validpassword1()
        {
            string Password = "^[a-z]{8}$";    // Regex exp for smallest 8 letter  password 
                                               // Regex regex = new Regex(Password);        //creating a regex named obj with regular pwd.

            // using  lamda function
            bool testpassword1(string Pass) => (Regex.IsMatch(Pass, Password));
            bool result = testpassword1(message);

            try
            {
                //this is the custom exception that we declared for checking empty messages. exception type is an enum followed by the message.
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }
                if (result)
                {
                    //Console.WriteLine(pass + "-- > Valid");
                    return "Valid";
                }
                else
                    // Console.WriteLine(pass + "-- > InValid");
                    return "InValid";
            }

            catch (ArgumentNullException)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "Invalid");
            }
        }

        // UC6 Password RegEx should have at least one Alphabet char in the password using exception
        public string Validpassword2()
        {
            string Password = "^(?=.*[A-Z])[a-zA-Z]{8}$";    // Regex exp for  8 letter in should have at least one Uppercase  password 
            //Regex regex = new Regex(Password);        //creating a regex named obj with regular pwd.
            //using lamda function 
            bool testpassword2(string Pass2) => (Regex.IsMatch(Pass2, Password));
            bool result = testpassword2(message);
            try
            {
                //this is the custom exception that we declared for checking empty messages. exception type is an enum followed by the message.
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }
                if (result)
                {
                    //Console.WriteLine(pass + "-- > Valid");
                    return "Valid";
                }
                else
                    // Console.WriteLine(pass + "-- > InValid");
                    return "InValid";
            }

            catch (ArgumentNullException)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "Invalid");
            }
        }
        // UC7 Password RegEx should have at least one numaric number in the password
        public string Validpassword3()
        {
            string Password = "^(?=.*[0-9])(?=.*[A-Z])[a-zA-Z0-9]{8}$";    // Regex exp for  8 letter in should have at least one Uppercase  password 
                                                                           // Regex regex = new Regex(Password);        //creating a regex named obj with regular pwd.

            //using Lamda Function
            bool Password3(string Pass3) => (Regex.IsMatch(Pass3, Password));
            bool result = Password3(message);
            try
            {
                //this is the custom exception that we declared for checking empty messages. exception type is an enum followed by the message.
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }
                if (result)
                {
                    //Console.WriteLine(pass + "-- > Valid");
                    return "Valid";
                }
                else
                    // Console.WriteLine(pass + "-- > InValid");
                    return "InValid";
            }

            catch (ArgumentNullException)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "Invalid");
            }
        }

        // UC8 compleate Password RegEx should have at least one numaric number & Capital Alphabet& Speciaal char in the password
        public string Validpassword4()
        {
            // Regex exp  should have at least one Uppercase,number,special char password 
            string Password = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8}$";    // Regex exp for  8 letter in should have at least one Uppercase  password 
                                                                                                   // Regex regex = new Regex(Password);        //creating a regex named obj with regular pwd.

            //using Lamdafunction
            bool TestPassword4(string Pass4) => (Regex.IsMatch(Pass4, Password));
            bool result = TestPassword4(message);
            try
            {
                //this is the custom exception that we declared for checking empty messages. exception type is an enum followed by the message.
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }
                if (result)
                {
                    //Console.WriteLine(pass + "-- > Valid");
                    return "Valid";
                }
                else
                    // Console.WriteLine(pass + "-- > InValid");
                    return "InValid";
            }

            catch (ArgumentNullException)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "Invalid");
            }
        }

        // UC8 compleate Password RegEx should have at least one numaric number & Capital Alphabet& Speciaal char in the password
        public string VlidMailFormat()
        {

            string GEmailPattern = "^[a-zA-Z0-9]+[+-._]{0,1}[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]*[@][a-zA-Z0-9]+[.][a-zA-Z0-9]{2,3}([.]?[a-zA-Z]{2,3}){0,1}$";
            // Regex regex = new Regex(GEmail);        //creating a regex named obj with regular pwd.

            bool testGmail(string Gmail) => (Regex.IsMatch(Gmail, GEmailPattern));
            bool result = testGmail(message);
            try
            {
                //this is the custom exception that we declared for checking empty messages. exception type is an enum followed by the message.
                if (this.message.Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                }
                if (result)
                {
                    //Console.WriteLine(pass + "-- > Valid");
                    return "Valid";
                }
                else
                    // Console.WriteLine(pass + "-- > InValid");
                    return "InValid";
            }

            catch (ArgumentNullException)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "Invalid");
            }
        }
    }
}
