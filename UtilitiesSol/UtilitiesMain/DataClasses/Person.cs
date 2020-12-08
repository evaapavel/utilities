using System;

namespace UtilitiesMain.DataClasses
{
    public class Person
    {

        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private bool isCitizenCZ;

        public Person(
            string firstName, string lastName,
            DateTime dateOfBirth, bool isCitizenCZ
        )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.isCitizenCZ = isCitizenCZ;
        }

    }
}
