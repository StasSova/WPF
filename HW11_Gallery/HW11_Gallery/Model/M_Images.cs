using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW11_Gallery.Model
{
    [Serializable]
    public class SerializableKeyValuePair
    {
        public string Key { get; set; }
        public double Value { get; set; }
        public SerializableKeyValuePair() { }
        public SerializableKeyValuePair(string key, double value) 
        {
            Key = key;
            Value = value;
        }
    }
    [Serializable]
    public class M_Images
    {
        public string? Author;
        public string? Name;
        public string? Date;
        public string? PathToPhoto;
        [XmlElement("Ratings")]
        public List<SerializableKeyValuePair> Ratings;
        public M_Images() 
        { 
            
        }
    }
}
