﻿using System;
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
}
