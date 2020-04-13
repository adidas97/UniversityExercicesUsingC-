using System;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Files
{
    [Serializable]
    public class User
    {
       public User()
       {
       
       }
        public User(string fname, string lname, DateTime bd)
        {
            FirstName = fname;
            LastName = lname;
            BirthDate = bd;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public DateTime BirthDate { get; set; }

        public User(string s)
        {
            try
            {
                // Multiple instances of whitespace \t as separator
                Regex o = new Regex("\t+");
                string[] str = o.Split(s);
                FirstName = str[0];
                LastName = str[1];
                CultureInfo culture =
                CultureInfo.CreateSpecificCulture("en-GB");
                BirthDate = DateTime.Parse(str[2], culture);
            }
            catch (Exception e)
            {
                Console.WriteLine("Data ignored!");
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public override string ToString()
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
            return FirstName + "\t" + LastName + "\t" +
            BirthDate.ToString("d", culture);
        }
    }
}
