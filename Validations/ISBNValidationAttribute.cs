using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace SchoolSolution.Validations
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class ISBNValidationAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        private static readonly string SEP = "(?:\\-|\\s)";
        private static readonly string GROUP = "(\\d{1,5})";
        private static readonly string PUBLISHER = "(\\d{1,7})";
        private static readonly string TITLE = "(\\d{1,6})";

        static readonly string ISBN10_PATTERN = "^(?:(\\d{9}[0-9X])|(?:" + GROUP + SEP + PUBLISHER + SEP + TITLE + SEP + "([0-9X])))$";

        static readonly string ISBN13_PATTERN = "^(978|979)(?:(\\d{10})|(?:" + SEP + GROUP + SEP + PUBLISHER + SEP + TITLE + SEP + "([0-9])))$";

        public ISBNValidationAttribute()
            : base("Invalid ISBN number")
        {

        }

        public override bool IsValid(object value)
        {
            //Convert to string and fix up the ISBN
            string isbn = value.ToString();
            string code = (isbn == null)
                ? null :
                    isbn.Trim().Replace("-", "").Replace(" ", "");

            //Check the length
            if ((code == null) || (code.Length < 10 || code.Length > 13))
            {
                return false;
            }

            //Validate/reformat using regular expression
            Match match;
            string pattern;
            if (code.Length == 10)
            {
                pattern = ISBN10_PATTERN;
            }
            else
            {
                pattern = ISBN13_PATTERN;
            }

            match = Regex.Match(code, pattern);
            return match.Success && match.Index == 0 && match.Length == code.Length;
        }
    }
}