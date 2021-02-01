using System;
using System.IO;



namespace UtilitiesMain.Serialization
{



    /// <summary>
    /// Able to serialize and deserialize itself.
    /// </summary>
    public abstract class SerializableObject
    {



        private const int MaxFields = 100;
        


        /// <summary>Values of fields in serializable objects gathered together into a single array.</summary>
        protected object[] fields;

        /// <summary>First unused index in the fields array.</summary>
        protected int firstUnused;
        
        
        
        public SerializableObject()
        {
            this.fields = new object[MaxFields];
            this.firstUnused = 0;
        }
        
        
        
        /// <summary>
        /// To be implemented by derived classes.
        /// Each descendant must override this method by storing its fields in the common array (this.fields).
        /// </summary>
        protected abstract void StoreFieldsIntoArray();



        /// <summary>
        /// To be implemented by derived classes.
        /// Each descendant must override this method by loading information from the common array (this.fields) and storing the data into its fields.
        /// </summary>
        protected abstract void LoadFieldsFromArray();



        /// <summary>
        /// Serialize this object into a given file.
        /// </summary>
        /// <param name="pathToFile">Path to the file that this object should be serialized into.</param>
        public void SerializeToFile(string pathToFile)
        {
            this.firstUnused = 0;
            StoreFieldsIntoArray();

            // Serialize the contents of the array into the given file.
            using (StreamWriter streamWriter = new StreamWriter(pathToFile))
            {
                for (int i = 0; i < this.firstUnused; i++)
                {
                    object fieldValue = this.fields[i];
                    streamWriter.WriteLine(fieldValue);
                    //String dataType = fieldValue.GetType().Name;
                    //streamWriter.WriteLine($"{dataType}:{fieldValue.ToString()}");
                }
            }
        }
        
        
        
        public void DeserializeFromFile(string pathToFile)
        {
            
        }
        
        
        
    }



}
