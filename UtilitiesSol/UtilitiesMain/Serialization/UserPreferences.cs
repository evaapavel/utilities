using System;


namespace UtilitiesMain.Serialization
{



    /// <summary>
    /// Accumulates preferences of the user such as their favourite color, whether they want to be asked before deleting something etc.
    /// </summary>
    public class UserPreferences : SerializableObject
    {



        /// <summary>Application theme.</summary>
        public Theme Theme { get; set; }

        /// <summary>Let the user confirm a deletion of any file.</summary>
        public bool IsConfirmDelete { get; set; }

        /// <summary>Last directory used when downloading stuff.</summary>
        public string CurrentDirectory { get; set; }



        protected override void StoreFieldsIntoArray()
        {
            // We have to store values selected for theme, deletion confirmation and current directory into the "fields" array.
            // The "fields" array has the access level of "protected". Therefore we can access it here (in this derived type).
            // So has the "firstUnused" instance variable.
            this.fields[this.firstUnused] = this.Theme;
            this.firstUnused++;
            this.fields[this.firstUnused] = this.IsConfirmDelete;
            this.firstUnused++;
            this.fields[this.firstUnused] = this.CurrentDirectory;
            this.firstUnused++;
        }



    }



}
