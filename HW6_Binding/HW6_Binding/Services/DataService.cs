using HW6_Binding.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW6_Binding.Services
{
    class DataService
    {
        static DataService _instance;
        public static DataService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataService();
                return _instance;
            }
        }

        public void Save(List<M_People> collection)
        {
            try
            {
                FileStream stream = new FileStream("../../../list.xml", FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(List<M_People>));
                serializer.Serialize(stream, collection);
                stream.Close();
            }
            catch{ }
        }
        public List<M_People> GetCollection() 
        {
            try
            {
                FileStream stream = new FileStream("../../../list.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(List<M_People>));
                List<M_People> collection = (List<M_People>)serializer.Deserialize(stream );
                return collection ;
            }
            catch { }
            return null;
        }

    }
}
