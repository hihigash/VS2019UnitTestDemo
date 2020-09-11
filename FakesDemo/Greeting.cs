using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakesDemo
{
    public static class CalendarUtilities
    {
        public static bool IsLeapYear(int year)
        {
            bool result;
            if (year % 4 == 0)
            {
                result = true;
                if (year % 100 == 0)
                {
                    result = false;
                    if (year % 400 == 0)
                    {
                        result = true;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
    }

    public class Greeting
    {
        public string Hello(string userName)
        {
            if (CalendarUtilities.IsLeapYear(DateTime.Now.Year))
            {
                return $"HEY, {userName}! THIS YEAR IS A LEAP YEAR! PLEASE CHECK YOUR CODES!";
            }
            else
            {
                return $"HELLO, {userName}! HAVE A NICE DAY~~!";
            }
        }
    }
}
