using Laboratories320.Smirnov.ThreadStart_2_;
using System;
using Laboratories320.Smirnov.Task_4_;
using Laboratories320.Smirnov.ContinuationTask_5_;
using Laboratories320.Smirnov.GameCreationStart_6_;
using Laboratories320.Smirnov.Mongo_7_;
using Laboratories320.Smirnov.StrategyGame_1_.Units.War_units;
using Laboratories320.Smirnov.Json;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Student zhenya = new Student("Zhenya", 320, 20);
            Student igor = new Student("Igor", 220, 18);
            Student alex = new Student("Alexander", 120, 17);
            List<Student> studentList = new List<Student> { zhenya, igor, alex };

            string path = @"C:\Users\alexa\OneDrive\Рабочий стол\TSchool\Программирование\Начаров\Json\Json\bin\Debug\doc.txt";
            using (StreamWriter streamWriter = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach (var item in studentList)
                {
                    streamWriter.WriteLine(JsonSerializer.Serialize<Student>(item));
                }
            }

            List<string> studentForRead = new List<string>();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    studentForRead.Add(line);
                }
            }

            foreach (var item in studentForRead)
            {
                Student s = JsonSerializer.Deserialize<Student>(item);
                if (s.Name == "Igor")
                {
                    Console.WriteLine("Name: " + s.Name);
                    Console.WriteLine("Age: " + s.Age);
                    Console.WriteLine("Group: " + s.Group);
                }
            }
            Console.ReadKey();
        }

    }
}
