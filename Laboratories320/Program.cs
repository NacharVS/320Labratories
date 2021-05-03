using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student
            {
                Name = "Alex",
                Group = 230
            };
            Student s2 = new Student
            {
                Name = "Daniil",
                Group = 322
            };
            Student s3 = new Student
            {
                Name = "Hainz",
                Group = 115
            };
            Student s4 = new Student
            {
                Name = "Potap",
                Group = 205
            };
            Student s5 = new Student
            {
                Name = "Ctepan",
                Group = 410
            };

            List<Student> studentList = new List<Student>
            {
                s1, s2, s3, s4, s5
            };
            List<string> studentListInJson = new List<string>();

            //запись в файл
            using (StreamWriter sw = new StreamWriter("allStudents.txt", false, System.Text.Encoding.Default))
            {
                foreach (var item in studentList)
                {
                    sw.WriteLine(JsonSerializer.Serialize<Student>(item));
                }
            }

            //чтение из файла
            using (StreamReader sr = new StreamReader("allStudents.txt", System.Text.Encoding.Default))
            {
                string student;
                while ((student = sr.ReadLine()) != null)
                {
                    studentListInJson.Add(student);
                }
            }

            studentList.Clear();

            foreach (var item in studentListInJson)
            {
                studentList.Add(JsonSerializer.Deserialize<Student>(item));
            }

            Console.WriteLine($"Данные о студенте с именем {s1.Name}");
            Console.WriteLine(studentList.Where(s => s.Name == s1.Name).First().ToString());
        }
    }
}
