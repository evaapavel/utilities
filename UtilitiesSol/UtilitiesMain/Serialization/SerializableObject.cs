using System;



namespace UtilitiesMain.Serialization
{



    /// <summary>
    /// Able to serialize and deserialize itself.
    /// </summary>
    //public abstract class SerializableObject
    public class SerializableObject
    {



        private const int MaxFields = 100;
        
        
        protected object[] fields;
        protected int firstUnused;
        
        
        
        public SerializableObject()
        {
            this.fields = new object[MaxFields];
            this.firstUnused = 0;
        }
        
        
        
        //protected abstract void StoreFieldsIntoArray();
        
        //protected abstract void LoadFieldsFromArray();
        
        
        
        public void SerializeToFile(string pathToFile)
        {
            this.firstUnused = 0;
            //StoreFieldsIntoArray();
            
            // Serialize the contents of the array into the given file.
            // ...
        }
        
        
        
        public void DeserializeFromFile(string pathToFile)
        {
            
        }
        
        
        
    }



}
