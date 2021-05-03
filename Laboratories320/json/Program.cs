using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace TestJson
{
    class Program
    {

        static void Main(string[] args)
        {
            string json = "";


            List<Student> students = new List<Student>()
                { new Student { Name = "Tom", Group = 320 },
            new Student { Name = "Nim", Group = 320 },
            new Student { Name = "Kiko", Group = 320 }};

            // Student tom = new Student { Name = "Tom", Group = 320 };
            foreach (var item in students)
            {
                json = json + JsonSerializer.Serialize<Student>(item) + "\n";
            }

            //Console.WriteLine(json);

            //Console.WriteLine(restoredPerson.Name);


            StreamWriter sw = new StreamWriter("C:\\Test.txt");
            sw.WriteLine(json);
            sw.Close();

            StreamReader sr = new StreamReader("C:\\Test.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                Student restoredStudent = JsonSerializer.Deserialize<Student>(line);
                if (restoredStudent.Name == "Tom")
                {
                    string json2 = JsonSerializer.Serialize<Student>(restoredStudent);
                    Console.WriteLine(json2);
                    break;
                }

                line = sr.ReadLine();
            }

        }
    }
}
