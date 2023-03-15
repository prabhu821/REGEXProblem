using RegexProblem.UserRegistrationProblem;

namespace RegexProblem;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("REGEX Practice Problem!");
        UserRegistration userRegistration = new UserRegistration();
        Console.WriteLine("WELCOME TO USER REGISTRATION");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nEnter option to choose \n1.First Name \n2.Last Name \n3.Email \n4.Mobile Number \n5.Password Rule 1 " +
                "\n6.Password Rule 2 \n7.Password Rule 3 \n8.Password Rule 4 \n9.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("\nEnter First Name");
                    string fName = Console.ReadLine();
                    userRegistration.validateFirstName(fName);
                    break;
                case 2:
                    Console.WriteLine("\nEnter Last Name");
                    string lName = Console.ReadLine();
                    userRegistration.validateLastName(lName);
                    break;
                case 3:
                    Console.WriteLine("\nEnter Email");
                    string email = Console.ReadLine();
                    userRegistration.validateEmail(email);
                    break;
                case 4:
                    Console.WriteLine("\nEnter Mobile Number");
                    string mobileNumber = Console.ReadLine();
                    userRegistration.validateMobileNumber(mobileNumber);
                    break;
                case 5:
                    Console.WriteLine("\nEnter Password");
                    string password1 = Console.ReadLine();
                    userRegistration.validatePassword1(password1);
                    break;
                case 6:
                    Console.WriteLine("\nEnter Password");
                    string password2 = Console.ReadLine();
                    userRegistration.validatePassword2(password2);
                    break;
                case 7:
                    Console.WriteLine("\nEnter Password");
                    string password3 = Console.ReadLine();
                    userRegistration.validatePassword3(password3);
                    break;
                case 8:
                    Console.WriteLine("\nEnter Password");
                    string password4 = Console.ReadLine();
                    userRegistration.validatePassword4(password4);
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}