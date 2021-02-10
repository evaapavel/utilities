using System;



namespace UtilitiesMain.CsvProcessing
{



    public class President
    {



        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Born { get; set; }
        public int Died { get; set; }
        public Country Citizenship { get; set; }



        public President()
        {
        }



        public President(string firstName, string lastName, int born, int died, Country citizenship)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Born = born;
            this.Died = died;
            this.Citizenship = citizenship;
        }



    }



}

