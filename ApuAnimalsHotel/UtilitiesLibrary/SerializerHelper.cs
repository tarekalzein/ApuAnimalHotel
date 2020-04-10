using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApuAnimalsHotel.UtilitiesLibrary
{
    public static class SerializerHelper
    {
        public static string Serialize<T>(T t, SerializeFormat format)
        {
            switch(format)
            {
                case SerializeFormat.Bin:
                    return SerializeToBin(t);
                case SerializeFormat.XML:
                    return SerializeToXml(t);
                default:
                    return String.Empty;
            }
        }
        
        public static T Deserialize<T>(string data, SerializeFormat format)
        {
            switch(format)
            {
                case SerializeFormat.Bin:
                    return DeserializeBin<T>(data);
                case SerializeFormat.XML:
                    return DeserializeXml<T>(data);
                default:
                    return default(T);
            }
        }

        private static string SerializeToXml<T>(T t)
        {
            throw new NotImplementedException();
        }

        private static string SerializeToBin<T>(T t)
        {
            throw new NotImplementedException();
        }

        private static T DeserializeXml<T>(string data)
        {
            throw new NotImplementedException();
        }

        private static T DeserializeBin<T>(string data)
        {
            throw new NotImplementedException();
        }

        
    }
    public enum SerializeFormat
    {
        XML = 1,
        Bin = 2
    }
}
