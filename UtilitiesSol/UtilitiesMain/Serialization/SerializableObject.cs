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

        /// <summary>First unused index in the fields array (when serializing).</summary>
        protected int firstUnused;

        /// <summary>Index (to the fields array) of the item that is about to be read (when deserializing).</summary>
        protected int currentToRead;



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
                    //streamWriter.WriteLine(fieldValue);
                    String dataType = fieldValue.GetType().Name;
                    streamWriter.WriteLine($"{dataType}:{fieldValue.ToString()}");
                }
            }
        }



        public void DeserializeFromFile(string pathToFile)
        {
            using (StreamReader streamReader = new StreamReader(pathToFile))
            {
                int i = 0;
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();
                    //object fieldValue = line;
                    object fieldValue = ParseAndCast(line);
                    this.fields[i] = fieldValue;
                    i++;
                }
            }
            this.currentToRead = 0;
            LoadFieldsFromArray();
        }



        private string ToString(string fieldValue)
        {
            return fieldValue;
        }

        private decimal ToDecimal(string fieldValue)
        {
            return Convert.ToDecimal(fieldValue);
        }

        private double ToDouble(string fieldValue)
        {
            return Convert.ToDouble(fieldValue);
        }

        private bool ToBoolean(string fieldValue)
        {
            return Convert.ToBoolean(fieldValue);
        }

        private Theme ToTheme(string fieldValue)
        {
            return (Theme)Enum.Parse(typeof(Theme), fieldValue);
        }


        private object ToCorrectType(string dataType, string fieldValue)
        {
            switch (dataType)
            {
                case "String":
                    return ToString(fieldValue);
                case "Decimal":
                    return ToDecimal(fieldValue);
                case "Double":
                    return ToDouble(fieldValue);
                case "Boolean":
                    return ToBoolean(fieldValue);
                case "Theme":
                    return ToTheme(fieldValue);
            }
            throw new ApplicationException($"This data type is not supported here: {dataType}");
        }


        private object ParseAndCast(string line)
        {
            string[] parts = line.Split(':');
            string dataType = parts[0];
            string fieldValue = parts[1];
            return ToCorrectType(dataType, fieldValue);
        }



    }



}
