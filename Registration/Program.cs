namespace Registration
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration ");
            Register register = new Register();

            register.FirstName();
            Console.WriteLine("First Name Added!");

            register.LastName();
            Console.WriteLine("Last Name added!");

            register.Email();
            Console.WriteLine("Email Added!");

            register.Mobile();
            Console.WriteLine("Mobile Number added!");

            Console.WriteLine("Password must contains special character capital letter and a number and shouls be atleast 8 characters");
            register.Password();
            Console.WriteLine("Passed added!");


            Console.WriteLine("\nThe Details Enterd are : \n");
            Console.WriteLine("First Name: " + register.firstName);
            Console.WriteLine("Last Name:  " + register.lastName);
            Console.WriteLine("Email : " + register.email);
            Console.WriteLine("Mobile : " + register.mobile);
            Console.WriteLine("password : " + register.password);


        }



    }
}