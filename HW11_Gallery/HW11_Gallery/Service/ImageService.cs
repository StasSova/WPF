using HW11_Gallery.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW11_Gallery.Service
{
    public class ImageService
    {
        public string PathDirectory { get; set; } = "../../../Images";
        public static void SerializeToXml(List<M_Images> list, string filePath = "../../../Images")
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<M_Images>));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, list);
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..");
            }
        }

        public static List<M_Images> DeserializeFromXml(string filePath = "../../../Images")
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<M_Images>));
            using (StreamReader reader = new StreamReader(filePath))
            {
                return (List<M_Images>)serializer.Deserialize(reader);
            }
        }
    }
}
