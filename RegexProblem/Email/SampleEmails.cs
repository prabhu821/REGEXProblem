using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem.Email;

public class SampleEmails
{
    public static string EmailCheck = "^[A-Za-z0-9]+([.-+][a-zA-Z0-9]+)?[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
    public void CheckEmail(string email)
    {
        if (Regex.IsMatch(email, EmailCheck))
        {
            Console.WriteLine("Email Address : " + email);
        }
        else
        {
            Console.WriteLine("Please enter a valid email address");
        }
    }
}


public class ValidateMultipleEmailAddress
{
    public const string EMAIL = "^abc+.+[a-zA-Z0-9]+@+bl.co+.+[in|com]$";
    public string MultipleEmailAddress(string email) => Regex.IsMatch(email, EMAIL) ? "prabhugoyal821@gmail.com" : "Email is not match";
}

