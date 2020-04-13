using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;using System.Xml.Serialization;using System.Text.Json;
namespace Files
{
    class Program
    {
        public static List<User> JsonDeserialization(string fileName)
        {
            List<User> list = null;
            try
            {
                string json = File.ReadAllText(fileName);
                var options = new JsonSerializerOptions { WriteIndented = true };
                list = JsonSerializer.Deserialize<List<User>>(json, options);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            return list;
        }
        public static void JsonSerialization(string fileName, List<User> list)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(list, options);
                File.WriteAllText(fileName, json);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
        }
        public static List<User> XmlDeserialization(string fileName)
        {
            List<User> list = null;
            using (StreamReader reader = new StreamReader(fileName))
            {
                try
                {
                    XmlSerializer x = new XmlSerializer(typeof(List<User>));
                    list = (List<User>)x.Deserialize(reader);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " +
                    e.Message);
                    throw;
                }
            }
            return list;
        }
        public static void XmlSerialization(string fileName, List<User> list)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                try
                {
                    XmlSerializer x = new XmlSerializer(typeof(List<User>));
                    x.Serialize(writer, list);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to serialize. Reason: " +
                    e.Message);
                    throw;
                }
            }
        }
        public static List<User> BinaryDeserialization(string fileName)
        {
           
            List<User> list = null;
            using (Stream r = File.OpenRead(fileName))
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    list = (List<User>)bf.Deserialize(r);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " +
                    e.Message);
                    throw;
                }
            }
            return list;
        }
        public static void BinarySerialization(string fileName, List<User> list)
        {
           
            using (Stream w = File.Create(fileName))
            {
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(w, list);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to serialize. Reason: " +
                    e.Message);
                    throw;
                }
            }
        }
        public static List<User> ReadFile(string fileName)
        {
            List<User> list = new List<User>();
            string s;
            using (StreamReader r = new StreamReader(
            new FileStream(fileName, FileMode.Open)))
            {
                try
                {
                    while ((s = r.ReadLine()) != null)
                    {
                        User element = new User(s);
                        list.Add(element);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be read.");
                    Console.WriteLine(e.ToString());
                    throw;
                }
            }
            return list;
        }
        public static void WriteFile(string fileName, List<User> list)
        {
            using (StreamWriter w = new StreamWriter(
            new FileStream(fileName, FileMode.Create)))
            {
                try
                {
                    foreach (User element in list)
                        w.WriteLine(element);
                }
                catch (Exception e)
                {
                    Console.WriteLine("The file could not be written.");
                    Console.WriteLine(e.ToString());
                    throw;
                }
            }
        }
        public static void PrintUsers(List<User> list)
        {
            Console.WriteLine(" USERS ");
            Console.WriteLine("--------------------------");
            foreach (User element in list)
                Console.WriteLine(element);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User("Ivan", "Petrov", new DateTime(1995, 5, 10)));
            users.Add(new User("Maria", "Dimova", new DateTime(2000, 12, 30)));
            users.Add(new User("Georgi", "Ivanov", new DateTime(1999, 3, 15)));
            Console.WriteLine("Application Data");
            PrintUsers(users);

            String fileName;
            List<User> list; // result after deserialization
            fileName = "users.txt";
            try
            {
                Console.WriteLine("\nText File");
                WriteFile(fileName, users);
                list = ReadFile(fileName);
                PrintUsers(list);
            }
            catch (Exception e)
            {
                Console.WriteLine("Stack trace:\n" + e.StackTrace);
            }            fileName = "users.dat";
            try
            {
                Console.WriteLine("\nBinary Serialization");
                BinarySerialization(fileName, users);
                list = BinaryDeserialization(fileName);
                PrintUsers(list);
            }
            catch (Exception e)
            {
                Console.WriteLine("Stack trace:\n" + e.StackTrace);
            }
            fileName = "users.xml";
            try
            {
                Console.WriteLine("\nXml Serialization");
                XmlSerialization(fileName, users);
                Console.WriteLine("users.xml");
                string xml = File.ReadAllText(fileName);
                Console.WriteLine(xml);
                list = XmlDeserialization(fileName);
                PrintUsers(list);
            }
            catch (Exception e)
            {
                Console.WriteLine("Stack trace:\n" + e.StackTrace);
            }            fileName = "users.json";
            try
            {
                Console.WriteLine("\nJSON Serialization");
                JsonSerialization(fileName, users);
                Console.WriteLine("users.json");
                string json = File.ReadAllText(fileName);
                Console.WriteLine(json);
                list = JsonDeserialization(fileName);
                PrintUsers(list);
            }
            catch (Exception e)
            {
                Console.WriteLine("Stack trace:\n" + e.StackTrace);
            }
        }
    }
}
