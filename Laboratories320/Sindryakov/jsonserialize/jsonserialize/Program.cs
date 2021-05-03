using System;
using System.IO;
using System.Text.Json;

namespace jsonserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"";

            Student[] students =
            {   new Student { Name = "Владимир", Group = 120, Age = 17},
                new Student { Name = "Едгор", Group = 220, Age = 18},
                new Student { Name = "Соня", Group = 320, Age = 19},};
            string jsonStr = "";
            using (FileStream filestr = File.Create(path))
            {
                foreach (var item in students)
                {
                    jsonStr += $"{JsonSerializer.Serialize(item)}";
                }
            };
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(jsonStr);
            streamWriter.Close();
            StreamReader str = new StreamReader(path);
            string line = str.ReadLine();
            Console.WriteLine("Имя студента, ввод - ");
            string name = Console.ReadLine();
            while (line != null)
            {
                Student studentRebuilt = JsonSerializer.Deserialize<Student>(line);
                if (studentRebuilt.Name == name)
                {
                    string jsontwo = JsonSerializer.Serialize<Student>(studentRebuilt);
                    Console.WriteLine(jsontwo);
                    break;
                }
                line = str.ReadLine();
            }
        }
    }
}