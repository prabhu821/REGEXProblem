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
            Console.WriteLine("\nEnter option to choose \n1.First Name \n2.Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("\nEnter First Name");
                    string fName = Console.ReadLine();
                    userRegistration.validateFirstName(fName);
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}