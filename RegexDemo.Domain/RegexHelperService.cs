using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo.Domain
{
    public static class RegexHelperService
    {
        public static bool IsOnlyDigits(string input) => Regex.IsMatch(input, @"^\d+$");

        public static bool IsOnlyLowercaseLetters(string input) => Regex.IsMatch(input, @"^[a-z]+$");

        public static bool StartsWithCapital(string input) => Regex.IsMatch(input, @"^[A-Z]");

        //Made up pattern of abc-def-gh1 or 123-456-789 or abc-123-def, etc
        public static bool IsValidPattern(string input) => Regex.IsMatch(input, @"^.{3}-.{3}-.{3}$");

        public static bool EircodeIsValid(string input) => Regex.IsMatch(input, @"^[A-Za-z]\d{2}\s[A-Za-z0-9]{4}$");

    }
}