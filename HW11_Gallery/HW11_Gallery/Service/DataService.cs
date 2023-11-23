using HW11_Gallery.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HW11_Gallery.Service
{
    public class DataService
    {
        public DataService() { }
        public static void Save(M_User user)
        {
            // Используем полный путь к файлу
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UsersLoginPassword.xml");

            XDocument doc;

            // Проверяем, существует ли файл
            if (File.Exists(path))
            {
                // Если файл существует, загружаем его
                doc = XDocument.Load(path);
            }
            else
            {
                // Если файл не существует, создаем новый XML-документ
                doc = new XDocument(new XElement("Users"));
            }

            // Проверяем, есть ли уже пользователь с таким логином
            if (!IsUserExist(doc, user.Login))
            {
                // Создаем новый элемент для пользователя
                XElement userElement = new XElement("User",
                    new XElement("Login", user.Login),
                    new XElement("Password", user.Password),
                    new XElement("Name", user.Name),
                    new XElement("Surname", user.Surname));

                // Добавляем элемент пользователя в документ
                doc.Element("Users").Add(userElement);

                // Сохраняем изменения в файл
                doc.Save(path);
            }
            else
            {
                throw new Exception("Пользователь с таким логином уже существует.");
            }
        }

        private static bool IsUserExist(XDocument doc, string login)
        {
            // Проверяем, существует ли пользователь с таким логином
            return doc.Descendants("User").Any(u => u.Element("Login").Value == login);
        }

        public static bool UserExistsInFile(string login)
        {
            // Путь к файлу XML
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UsersLoginPassword.xml");

            // Проверяем, существует ли файл
            if (File.Exists(path))
            {
                // Загружаем XML-документ
                XDocument doc = XDocument.Load(path);

                // Проверяем, существует ли пользователь с заданным логином
                return doc.Descendants("User").Any(u => u.Element("Login").Value == login);
            }

            return false;
        }

        public static void AuthenticateUser(string login, string password)
        {
            // Путь к файлу XML
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UsersLoginPassword.xml");

            // Проверяем, существует ли файл
            if (File.Exists(path))
            {
                // Загружаем XML-документ
                XDocument doc = XDocument.Load(path);

                // Пытаемся найти пользователя с заданным логином и паролем
                GetUserByCredentials(doc, login, password);
            }
            else
            {
                throw new Exception("Файл с пользователями не найден.");
            }
        }

        private static void GetUserByCredentials(XDocument doc, string login, string password)
        {
            // Пытаемся найти пользователя с заданным логином и паролем
            var userElement = doc.Descendants("User")
                .FirstOrDefault(u => u.Element("Login").Value == login && u.Element("Password").Value == password);

            if (userElement != null)
            {
                // Если пользователь найден, инициализируем его данные.
                M_User.Instance.Login = userElement.Element("Login").Value;
                M_User.Instance.Password = userElement.Element("Password").Value;
                M_User.Instance.Name = userElement.Element("Name").Value;
                M_User.Instance.Surname = userElement.Element("Surname").Value;
            }
            else
            {
                throw new Exception("Incorrect Login or Password");
            }
        }

    }
}
