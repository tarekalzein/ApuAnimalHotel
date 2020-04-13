﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
                default:
                    return default(T);
            }
        }

        private static bool SerializeToXml<T>(T t, string filePath)
        {
            //XmlSerializer xmlSerializer = new XmlSerializer(t.GetType());
            //TextWriter writer = new StreamWriter(filePath);

            //try
            //{
            //    xmlSerializer.Serialize(writer, t);
            //}
            //catch(Exception)
            //{
            //    throw new Exception("Error serializing data into XML");    
            //}
            //finally
            //{
            //    if (writer != null)
            //        writer.Close();
            //}
            //return true;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            TextWriter writer = new StreamWriter(filePath);
            xmlSerializer.Serialize(writer, t);
            if (writer != null)
                writer.Close();
            return true;
          

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

        private static T DeserializeXml<T>(string data)
        {
            throw new NotImplementedException();
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

        
    }
    public enum SerializeFormat
    {
        XML = 1,
        Bin = 2
    }
}
