using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonSerializationCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\PC\Desktop\JsonSerializationCore\Text.txt";

            StudentInfo[] studentInfos = 
            {
                new StudentInfo { Name = "Иван", NumberGroup = 310, Age = 18},
                new StudentInfo { Name = "Игорь", NumberGroup = 322, Age = 19},
                new StudentInfo { Name = "Даниил", NumberGroup = 124, Age = 16},
                new StudentInfo { Name = "Алексей", NumberGroup = 222, Age = 17},
                new StudentInfo { Name = "Эмиль", NumberGroup = 320, Age = 19},
                new StudentInfo { Name = "Роберт", NumberGroup = 120, Age = 17},
                new StudentInfo { Name = "Петр", NumberGroup = 125, Age = 16},
            };

            string stringJson = "";
            using (FileStream fs = File.Create(path))
            {
                foreach (var item in studentInfos)
                {
                    stringJson += $"{JsonSerializer.Serialize(item)} \n";
                }
            };

            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(stringJson);
            streamWriter.Close();

            StreamReader streamreader = new StreamReader(path);
            string line = streamreader.ReadLine();

            Console.WriteLine("Введите имя студента - ");
            string nameStudent = Console.ReadLine();

            while (line != null)
            {
                StudentInfo restoredStudent = JsonSerializer.Deserialize<StudentInfo>(line);
                if (restoredStudent.Name == nameStudent)
                {
                    string json2 = JsonSerializer.Serialize<StudentInfo>(restoredStudent);
                    Console.WriteLine(json2);
                    break;
                }
                line = streamreader.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
