using HW7_Notebook.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW7_Notebook.Service
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

        public void Save(List<M_Contact> collection)
        {
            try
            {


                FileStream stream = new FileStream("../../../list.xml", FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(List<M_Contact>));
                serializer.Serialize(stream, collection);
                stream.Close();
            }
            catch { }
        }
        public List<M_Contact> GetCollection()
        {
            try
            {
                FileStream stream = new FileStream("../../../list.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(List<M_Contact>));
                List<M_Contact> collection = (List<M_Contact>)serializer.Deserialize(stream);
                return collection;
            }
            catch { }
            return null;
        }

    }
}
