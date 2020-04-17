using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ApuAnimalsHotel.POCO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace ApuAnimalsHotel.UtilitiesLibrary
{
    public static class SerializerHelper
    {
        public static bool Serialize<T>(T t, SerializeFormat format, string filePath)
        {
            switch(format)
            {
                case SerializeFormat.Bin:
                    return SerializeToBin(t, filePath);
                case SerializeFormat.XML:
                    return SerializeToXml(t, filePath);
                case SerializeFormat.TXT:
                    return SerializeToTxt(t, filePath);
                default:
                    return false;
            }
        }

       

        public static T Deserialize<T>(string data, SerializeFormat format)
        {
            switch(format)
            {
                case SerializeFormat.Bin:
                    return DeserializeBin<T>(data,out string errorMessage);
                case SerializeFormat.XML:
                    return DeserializeXml<T>(data);
                case SerializeFormat.TXT:
                    return DeserializeTXT<T>(data);
                default:
                    return default(T);
            }
        }

        private static T DeserializeTXT<T>(string filePath)
        {
            var definition = new { Name = "" };
            Object obj = null;
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                System.Diagnostics.Debug.WriteLine(json);
                obj = JsonConvert.DeserializeAnonymousType(json, definition);
                //obj = JsonConvert.DeserializeObject(json);
            }

            return (T)obj; 


        }

        /// <summary>
        /// Serialization using Newtonsoft.Json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static bool SerializeToTxt<T>(T t, string filePath)
        {
            new JsonSerializer { TypeNameHandling = TypeNameHandling.Auto };
            string jsonString;
            TextWriter writer = new StreamWriter(filePath); 
            jsonString = JsonConvert.SerializeObject(t,Newtonsoft.Json.Formatting.Indented);
            writer.WriteLine(jsonString);
            writer.Close();

            return true;

        }
        private static bool SerializeToXml<T>(T t, string filePath)
        {
            using (Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(stream, t);
                return true;
            }

        }

        private static bool SerializeToBin<T>(T t, string filePath)
        {
            //add try catch
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(filePath, FileMode.Create); //change this later to get file name from dialog
            binaryFormatter.Serialize(fileStream, t);
            fileStream.Close();
            return true;

        }

        private static T DeserializeXml<T>(string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            TextReader reader = new StreamReader(filePath);

            try
            {
                return (T)xmlSerializer.Deserialize(reader);
            }
            catch
            {
                throw new XmlException("Error reading from file");
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }

        private static T DeserializeBin<T>(string filePath, out string errorMessage)
        {
            FileStream fileStream = null;
            errorMessage = null;
            Object obj = null;

            try
            {
                if(!File.Exists(filePath))
                {
                    errorMessage = $"The file {filePath} was not found.";
                    throw (new FileNotFoundException(errorMessage));
                }
                fileStream = new FileStream(filePath, FileMode.Open);
                BinaryFormatter b = new BinaryFormatter();
                if(new FileInfo(filePath).Length==0)
                {
                    errorMessage = "File is empty";
                }
                else
                {
                    obj = b.Deserialize(fileStream);

                }
            }
            catch(Exception ex)
            {
                if (errorMessage != null)
                    errorMessage = ex.Message;
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
            return (T)obj;
        }
        public static void  SerializeToText(string filePath, AnimalManager manager)
        {
            using (TextWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < manager.Count; i++)
                {
                    Animal animal = manager.GetElementAtPosition(i);

                    string[] foodSchedule=animal.GetFoodSchedule().GetFoodScheduleById(animal.Id);
                    string foodScheduleString = "";
                    foreach(string item in foodSchedule)
                    {
                        foodScheduleString += "["+item+"]";
                    }


                    int char1 = 0;
                    string char2 = "";
                    string char1Name = "";
                    string char2Name = "";
                    string type = "";
                    switch (animal)
                    {
                        case Dog dog:
                            dog = (Dog)animal;
                            char1 = dog.TeethCount;
                            char2 = dog.Breed;
                            char1Name = "Teeth Count";
                            char2Name = "Breed";
                            type = "Dog";
                            break;
                        case Cat cat:
                            cat = (Cat)animal;
                            char1 = cat.TeethCount;
                            char2 = cat.Breed;
                            char1Name = "Teeth Count";
                            char2Name = "Breed";
                            type = "Cat";
                            break;
                        case Bee bee:
                            bee = (Bee)animal;
                            char1 = bee.CountOfLegs;
                            char2 = bee.BeeSpecies;
                            char1Name = "Count of legs";
                            char2Name = "Bee species";
                            type = "Bee";
                            break;
                        case Butterfly butterfly:
                            butterfly = (Butterfly)animal;
                            char1 = butterfly.CountOfLegs;
                            char2 = butterfly.WingColor;
                            char1Name = "Count of legs";
                            char2Name = "Wings Color";
                            type = "Butterfly";
                            break;

                    }
                    writer.WriteLine(string.Format("Type:{0},Name:{1},Age:{2},Gender:{3},{4}:{5},{6}:{7},Food Schedule:{8}",
                        type,
                        animal.Name,
                        animal.Age.ToString(),
                        animal.Gender,
                        char1Name, char1.ToString(),
                        char2Name, char2,
                        foodScheduleString
                        ));
                }
            }

        }

    }

   
    public enum SerializeFormat
    {
        XML = 1,
        Bin = 2,
        TXT=3
    }
}
