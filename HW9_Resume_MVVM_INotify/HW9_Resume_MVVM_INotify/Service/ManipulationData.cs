using HW9_Resume_MVVM_INotify.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW9_Resume_MVVM_INotify.Service
{
    internal class ManipulationData
    {
        static ManipulationData _instance;
        public static ManipulationData Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ManipulationData();
                return _instance;
            }
        }

        public void Save(List<M_Resume> collection)
        {
            try
            {
                FileStream stream = new FileStream("../../../list.xml", FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(List<M_Resume>));
                serializer.Serialize(stream, collection);
                stream.Close();
            }
            catch { }
        }
        public List<M_Resume> GetCollection()
        {
            try
            {
                FileStream stream = new FileStream("../../../list.xml", FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(List<M_Resume>));
                List<M_Resume> collection = (List<M_Resume>)serializer.Deserialize(stream);
                return collection;
            }
            catch { }
            return null;
        }
    }
}
