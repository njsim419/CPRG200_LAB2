using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace CustomerData
{
   public class FileManager
    {

        public static void SerializeObject(object obj, string location)
        {

            try
            {
                string path = Path.GetDirectoryName(location);
                Stream str = File.Open(location, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(str, obj);
                str.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public static T DeserializeObject<T>(string location) where T : class
        {
            try
            {
                Stream str;
                try
                {
                    str = File.Open(location, FileMode.Open);
                }
                catch (FileNotFoundException e)
                {
                    throw e;
                }

                BinaryFormatter bf = new BinaryFormatter();

                T val = (T)bf.Deserialize(str);

                str.Close();
                return val;
            }
            catch (Exception e)
            {
                throw e;
            }


        }

    }
}
