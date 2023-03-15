using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem.Email;

public class SampleEmails
{
    public static string EmailCheck = "^[a-zA-Z0-9+-.]+@[a-zA-Z0-9]+.+([com|net|com.com|com.au])$";
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
