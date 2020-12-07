using System;

namespace UtilitiesMain.DataClasses
{
    public class Person
    {

        public string firstName;
        public string lastName;
        public DateTime dateOfBirth;
        public bool isCitizenCZ;

        public Person(string firstName, string lastName, DateTime dateOfBirth, bool isCitizenCZ)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.isCitizenCZ = isCitizenCZ;
        }

    }
}
