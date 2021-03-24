using System;
using System.Text.RegularExpressions;

namespace UtilitiesMain.RegularExpressions
{

    public class PhoneNumberChecker
    {

        // // Phone numbers with 6 digits.
        // // Phone numbers: 420123456
        // Phone numbers: +420123456
        public bool Check(string checkForPhoneNumber)
        {

            //Regex r = new Regex(@"[0123456789][012345689][0-9][0-9][0-9][0-9]", RegexOptions.Compiled);
            //Regex r = new Regex(@"^[0123456789][012345689][0-9][0-9][0-9][0-9]$", RegexOptions.Compiled);
            //Regex r = new Regex(@"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$", RegexOptions.Compiled);
            Regex r = new Regex(@"^[\+][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$", RegexOptions.Compiled);

            MatchCollection matches = r.Matches(checkForPhoneNumber);

            return (matches.Count == 1);

        }

    }

}
