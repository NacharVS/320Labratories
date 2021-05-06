using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace _4Praktika
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ranis", 18, 320);
            Student student2 = new Student("Airat", 18, 320);
            Student student3 = new Student("Marsel", 18, 320);
            Student student4 = new Student("Imil", 19, 320);
            Student student5 = new Student("Ilham", 18, 320);

            Student[] students = { student1, student2, student3, student4, student5 };
            
            string path = @"C:\Users\zakir\Documents\C#\SystemProgramming\4Praktika\Json\json.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            string json = "";
            using (FileStream fs = File.Create(path))
            {
                foreach (var item in students)
                {
                    json += JsonSerializer.Serialize(item) + "\n";
                }
            }

            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine(json);
            streamWriter.Close();

            Console.WriteLine("Поиск студента..." + "\n" + "Введите имя студента:");
            string name = Console.ReadLine();
            StreamReader streamReader = new StreamReader(path);
            string readInfo = streamReader.ReadLine();

            while (readInfo != null)
            {
                Student student = JsonSerializer.Deserialize<Student>(readInfo);
                if (student.Name == name)
                {
                    string info = JsonSerializer.Serialize<Student>(student);
                    Console.WriteLine(info);
                    break;
                }
                readInfo = streamReader.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
