using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain.RegularExpressions
{
    public class RegExTest
    {

        public static void Go()
        {

            // Phone numbers with 6 digits.
            // // Phone numbers: +420123456
            // Try to tell what is a phone number and what not.
            string[] inputs = {
                "245693",
                "1234567",
                "123456654321123456654321",
                "43x907",
                "a245693",
                "245693bcd",
                "+233",
                "094",
                "987654",
                "333444",
                ""
            };

            PhoneNumberChecker checker = new PhoneNumberChecker();

            foreach (string input in inputs)
            {
                bool isPhoneNumber = checker.Check(input);
                if (isPhoneNumber)
                {
                    Console.WriteLine($"The string {input} is a phone number.");
                }
                else
                {
                    Console.WriteLine($"The string {input} is NOT a phone number.");
                }
            }

        }

    }
}
