using System;


namespace UtilitiesMain.Serialization
{



    public class UserPreferences : SerializableObject
    {

        /// <summary>Application theme.</summary>
        public Theme Theme { get; set; }

        /// <summary>Let the user confirm a deletion of any file.</summary>
        public bool IsConfirmDelete { get; set; }

        /// <summary>Last directory used when downloading stuff.</summary>
        public string CurrentDirectory { get; set; }

    }



}
