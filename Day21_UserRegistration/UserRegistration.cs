using MoodAnalyserAppWithCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyserAppWithCore
{
    public class UserRegister
    {
        public static string pattern = "^[A-Z][a-z]{2,}$";
        public static string Email= "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public static string Mobile= "^[0-9]{2}[ ]?[6-9][0-9]{9}$";
        public static string password= "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$ %^&*-]).{8,}$";

        public bool FirstName(string FirstName)
        {
            try
            {
                Regex name = new Regex(pattern);
                bool validate = name.IsMatch(FirstName);
                return validate;
            }
            catch
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.INVALID_FIRSTNAME, "Enter Valid FirstName");
            }
        }
        public bool LastName(string LastName)
        {
            try
            {
                Regex name = new Regex(pattern);
                bool validate = name.IsMatch(LastName);
                return validate;
            }
            catch
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.INVALID_LASTNAME, "Enter Valid LastName");
            }
            
        }

        public bool email(string email)
        {
            try
            {
                Regex name = new Regex(Email);
                bool validate = name.IsMatch(email);
                return validate;
            }
            catch
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.INVALID_EMAIL, "Enter Valid Email");
            }

        }
        public bool Mobnum(string mobile)
        {
            try
            {
                Regex name = new Regex(Mobile);
                bool validate = name.IsMatch(mobile);
                return validate;
            }
            catch
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.INVALID_MOBILE, "Enter Valid FirstName");
            }
        }
        public bool Password(string Password)
        {
            try
            {
                Regex name = new Regex(password);
                bool validate = name.IsMatch(Password);
                return validate;
            }
            catch
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.INVALID_PASSWORD, "Enter Valid Password ");
            }
        }
    }
}
