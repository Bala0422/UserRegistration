using System.Text.RegularExpressions;

namespace Registration
{


    public class Register
    {
        public string firstName, lastName, email, mobile, password;


        //UC1
        public bool FirstName()
        {

            try
            {
                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();


                string firstNamePattern = "^[A-Z][a-z]{2,}$";

                if (Regex.IsMatch(firstName, firstNamePattern))
                {
                    this.firstName = firstName;
                    return true;
                }
                else
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.EMPTY_MESSAGE, "First Name should contains atleast 3 charactres");

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("First Name should contains atleast 3 charactres");

                FirstName();
                return false;
            }
        }

        //UC2 
        public bool LastName()
        {
            try
            {
                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();

                string lastNamePattern = "^[A-Z][a-z]{2,}$";

                if (Regex.IsMatch(lastName, lastNamePattern))
                {
                    this.lastName = lastName;
                    return true;

                }
                else
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.EMPTY_MESSAGE, "Last Name should contains atleast 3 charactres");

                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Last Name should contains atleast 3 charactres");

                LastName();
                return false;
            }
        }


        //UC3
        public bool Email()
        {
            try
            {

                Console.WriteLine("Enter The email ");
                string email = Console.ReadLine();

                string emailRegex = "([A-za-z0-9]+|[A-za-z0-9]+.{0,1}[A-za-z0-9]*)@[A-Za-z0-9]+[.][A-Za-z0-9].{0,1}[A-za-z0-9]*";

                if (Regex.IsMatch(email, emailRegex))
                {
                    this.email = email;
                    return true;
                }
                else
                {

                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.EMPTY_MESSAGE, "Enter a valid Email id");
                    

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter a valid Email id");
                Email();
                return false;
            }
        }


        //UC4

        public bool Mobile()
        {
            try
            {

                Console.WriteLine("Enter the phone number with the country code {xx xxxxxxxxxx}");
                string mobile = Console.ReadLine();


                string mobileRegx = "^[0-9]{2}\\s[0-9]{10}$";

                if (Regex.IsMatch(mobile, mobileRegx))
                {
                    this.mobile = mobile;
                    return true;
                }
                else
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.EMPTY_MESSAGE, "Enter a valid phone number");
                }


            }
            catch
            {
                Console.WriteLine("Enter a valid phone number");
                Mobile();
                return false;

            }
        }

        // UC5 to UC8

        public bool Password()
        {
            try
            {

                Console.WriteLine("Password : ");
                string password = Console.ReadLine();

                string regex = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";

                if (!Regex.IsMatch(password, regex))
                {
                    throw new RegistrationCustomExceptions(RegistrationCustomExceptions.ExceptionType.EMPTY_MESSAGE, "Give a valid password");
                }
                else
                {
                    this.password = password;
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Give a valid password");
                Password();
                return false;
            }
        }







    }
}
