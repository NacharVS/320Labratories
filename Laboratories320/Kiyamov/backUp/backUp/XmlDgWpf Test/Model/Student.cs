using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmlDgWPF.Model
{
    public class Settngs
    {
        public static string Path = "Students.xml";
    }
    [Serializable]
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Last { get; set; }
        public byte Age { get; set; }
        public byte Gender { get; set; }

        public static void Save(string path, Student[] subds)
        {
            XmlSerializer formatter = new XmlSerializer(subds.GetType());

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(fs, subds);
            }

        }
        public static IEnumerable<Student> Load(string path)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Student[]));
            if (File.Exists(path))
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    var subds = formatter.Deserialize(fs) as Student[];
                    if (subds != null)
                        return subds;
                }

            return Enumerable.Empty<Student>();

        }

    }
}
