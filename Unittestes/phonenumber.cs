using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Unittestes
{
    public static class PhoneNumber
    {
        public const string motif = @"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$";

        public static bool IsPhoneNbr(string number)
        {
            if (number != null) return Regex.IsMatch(number, motif);
            else return false;
        }
    }
    public class Programmm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(PhoneNumber.IsPhoneNbr("+33298765432"));
        }
    }
}
