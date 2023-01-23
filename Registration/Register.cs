using System.Runtime.InteropServices;

namespace Registration
{


    public class Register
    {
        public string firstName, lastName, email, mobile, password;

        //UC1
        public void FirstName()
        {

            try
            {
                Console.WriteLine("Enter First Name");
                string firstName = Console.ReadLine();
                int temp = Convert.ToInt32(firstName[0]);
                if (firstName.Length < 3)
                {
                    Console.WriteLine("First Name should contains atleast 3 charactres \n");
                    FirstName();
                }
                else if (temp < 65 || temp > 90)
                {
                    Console.WriteLine("First letter of the first name should be capital \n");
                    FirstName();
                }

                this.firstName = firstName;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //UC2 
        public void LastName()
        {

            try
            {
                Console.WriteLine("Enter Last Name");
                string lastName = Console.ReadLine();
                int temp = Convert.ToInt32(lastName[0]);
                if (lastName.Length < 3)
                {
                    Console.WriteLine("Last Name should contains atleast 3 charactres \n");
                    LastName();
                }
                else if (temp < 65 || temp > 90)
                {
                    Console.WriteLine("First letter of the last name should be capital \n");
                    LastName();
                }

                this.lastName = lastName;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //UC3
        public void Email()
        {
            try
            {

                Console.WriteLine("Enter The email ");
                string email = Console.ReadLine();
                int flag = 0;
                if (email.Contains("@"))
                {
                    string[] temp = email.Split("@");
                    string firstPart = temp[0];
                    string secondPart = temp[1];
                    if (firstPart.Length < 0 || secondPart.Length < 0)
                    {
                        flag = 1;

                    }
                    else if (firstPart.Contains(".") && firstPart[0].Equals("."))
                    {
                        flag = 1;
                    }


                    string[] temp2 = secondPart.Split(".");
                    int len = temp2.Length;
                    foreach (string s in temp2)
                    {
                        if (s.Length == 0)
                        {
                            flag = 1;
                        }
                    }
                    if (temp2[len - 1] == ".")
                    {
                        flag = 1;
                    }

                }
                else
                {
                    flag = 1;
                }


                if (flag == 1)
                {
                    Console.WriteLine("Enter a valid Email id");
                    Email();
                }

                this.email = email;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        //UC4

        public void Mobile()
        {
            try
            {

                Console.WriteLine("Enter the phone number with the country code {xx xxxxxxxxxx}");
                string mobile = Console.ReadLine();
                string[] temp = mobile.Split(" ");

                if (temp.Length != 2 || temp[0].Length != 2 || temp[1].Length != 10)
                {
                    Console.WriteLine("Enter a valid phone number");
                    Mobile();
                }

                this.mobile = mobile;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // UC5 to UC8

        public bool Number(int temp)
        {
            
            if (temp >= 48 && temp <= 57)
            {
                return true;
            }

            return false;
            
        }

        public bool Capital(int temp)
        {
            if (temp >= 65 && temp <= 90)
            {
                return true;
                
            }
            return false;
        }

        public void Password()
        {
            try
            {

                Console.WriteLine("Password : ");
                string password = Console.ReadLine();

                bool number = false, caps = false, specialchar = false;
                foreach (char s in password)
                {
                    int temp = Convert.ToInt32(s);
                    if (Number(temp))
                    {
                        number = true;
                        // Console.WriteLine("number");
                    }else if (Capital(temp))
                    {
                        caps = true;
                        // Console.WriteLine("caps");
                    }
                    else if ((!Number(temp) && !Capital(temp)) && (temp < 97 || temp > 122)){
                        specialchar= true;
                        // Console.WriteLine("special");
                    }

                }
                
                if (!number || !caps || !specialchar || password.Length < 8)  {

                    Console.WriteLine("Give a valid password");
                    Password();
                }

                this.password = password;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }







    }
}
