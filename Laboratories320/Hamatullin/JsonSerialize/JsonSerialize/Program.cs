using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace JsonSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Emil", 18, 221);
            Student student2 = new Student("Ilham", 19, 320);
            Student student3 = new Student("Marsel", 19, 223);
            Student student4 = new Student("Airat", 39, 320);
            Student student5 = new Student("Ranis", 20, 420);
            List<Student> testingStudents = new List<Student>();
            string n = Console.ReadLine();
            Student[] students = { student1, student2, student3, student4, student5 };
            string path = @"D:\JsonTest.txt";
            
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = File.Create(path))
            {
                foreach (var item in students)
                {
                    AddText(fs, JsonSerializer.Serialize(item, typeof(Student)) + "\n");
                }
                
            };
            using (StreamReader fs = new StreamReader(path))
            {
                string jsonStudents;
                while ((jsonStudents = fs.ReadLine()) != null)
                {
                    testingStudents.Add((Student)JsonSerializer.Deserialize(jsonStudents, typeof(Student)));
                }
            }
            var findedStudent = testingStudents.Where(s => s.FullName == n).FirstOrDefault();
            if (findedStudent != null)
            {
                Console.WriteLine($"{findedStudent.FullName} Возраст: {findedStudent.Age} Группа: {findedStudent.Group}");
            }
            else
            {
                Console.WriteLine("Не найден");
            }
            
        }
        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}
