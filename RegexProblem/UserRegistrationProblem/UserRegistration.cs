using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem.UserRegistrationProblem;

public class UserRegistration
{
    public static string FirstName = "^[A-Z]{1}[A-Za-z]{2,}$";

    public void validateFirstName(string fName)
    {
        if (Regex.IsMatch(fName, FirstName))
        {
            Console.WriteLine("First Name : " + fName);
        }
        else 
        {
            Console.WriteLine("First alphabet should be capital and Minimum 3 character should be there");
        }
    }
}
