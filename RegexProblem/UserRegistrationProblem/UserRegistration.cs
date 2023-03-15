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
    public static string LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
    public static string Email = "^abc+.+[a-zA-Z0-9]+@+bl.co+.+[in|com]$";
    public static string MobileNumber = "^[1-9]{2}[: :][0-9]{10}$";
    public static string Password1 = "^[a-z]{8,}$";
    public static string Password2 = "^[A-Z]{1}[a-zA-Z]{7,}$";


    //UC1-FIRST NAME
    public void validateFirstName(string fName)
    {
        if (Regex.IsMatch(fName, FirstName))
        {
            Console.WriteLine("First Name : " + fName);
        }
        else 
        {
            Console.WriteLine("First alphabet should be capital and Minimum 3 character");
        }
    }

    //UC2-LAST NAME
    public void validateLastName(string lName)
    {
        if (Regex.IsMatch(lName, LastName))
        {
            Console.WriteLine("Last Name : " + lName);
        }
        else
        {
            Console.WriteLine("First alphabet should be capital and Minimum 3 character");
        }
    }

    //UC3-EMAIL
    public void validateEmail(string email)
    {
        if (Regex.IsMatch(email, Email))
        {
            Console.WriteLine("Email Address : " + email);
        }
        else
        {
            Console.WriteLine("Please enter a valid email address ex :- abc.xyz@bl.co.in/.com");
        }
    }

    //UC4-MOBILE NUMBER
    public void validateMobileNumber(string mobileNumber)
    {
        if (Regex.IsMatch(mobileNumber, MobileNumber))
        {
            Console.WriteLine("Mobile Number : " + mobileNumber);
        }
        else
        {
            Console.WriteLine("Please enter a valid 10 digit mobile number with 2 digit country code ex 'xx 9xxxxxxx45'");
        }
    }

    //UC5-PASSWORD RULE 1
    public void validatePassword1(string password)
    {
        if (Regex.IsMatch(password, Password1))
        {
            Console.WriteLine("Password : " + password);
        }
        else
        {
            Console.WriteLine("For password minimum 8 characters required");
        }
    }

    //UC6-PASSWORD RULE 2
    public void validatePassword2(string password)
    {
        if (Regex.IsMatch(password, Password2))
        {
            Console.WriteLine("Password : " + password);
        }
        else
        {
            Console.WriteLine("Minimum 8 characters and Should have at least 1 Upper Case");
        }
    }
}
