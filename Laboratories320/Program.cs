using Laboratories320.Volkov.SecondPractice;
using System;
using System.Threading;
using Laboratories320.Volkov.ThreadLocker;
using Laboratories320.Volkov.Tasks;
using Laboratories320.Volkov.TasksPractice2;
using Laboratories320.Json;
using System.IO;
using System.Text.Json;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\evgen\Desktop\Text.txt";

            Student[] studentInfos =
            {
                new Student { Name = "Евгений", NumberGroup = 320, Age = 19},
                new Student { Name = "Раиль", NumberGroup = 320, Age = 19},
                new Student { Name = "Катя", NumberGroup = 124, Age = 16},
                new Student { Name = "Алена", NumberGroup = 124, Age = 16},
                new Student { Name = "Илина", NumberGroup = 320, Age = 19},
                new Student { Name = "Даниил", NumberGroup = 220, Age = 18},
                new Student { Name = "Света", NumberGroup = 323, Age = 18},
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
                Student rStudent = JsonSerializer.Deserialize<Student>(line);
                if (rStudent.Name == nameStudent)
                {
                    string json2 = JsonSerializer.Serialize<Student>(rStudent);
                    Console.WriteLine(json2);
                    break;
                }
                line = streamreader.ReadLine();
            }
            Console.ReadKey();
        }

    }
}
