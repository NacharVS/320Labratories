using System;
using Laboratories320.Shigapov.Practic2;
using Laboratories320.Shigapov.Task3;
using Laboratories320.Shigapov.Task1;
using System.Threading;
using System.Threading.Tasks;
using Laboratories320.Shigapov.ContinuationTasks;
using Laboratories320.Shigapov.GameCreationStart;
using Laboratories320.Shigapov.StrategyGame;
using Laboratories320.Shigapov.Mongo;
using Laboratories320.Shigapov.Json;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here....");
            Console.WriteLine();
            //Continuation
            //int[] array = new int[20];
            //Random rnd = new Random();
            //for (int i = 0; i < 20; i++)
            //{
            //    array[i] = rnd.Next(1, 10);
            //}
            //Console.WriteLine("Generating");
            //Console.WriteLine("[{0}]", string.Join(", ", array));
            //Task task1 = Task.Run(() => Continuation.Сomposition(array));
            //Task task2 = task1.ContinueWith(mul => Continuation.Even());
            //task2.Wait();

            //Practic Json
            Student stud1 = new Student("Alex", 228, 18);
            Student stud2 = new Student("Maria", 229, 18);
            Student stud3 = new Student("Rail", 228, 19);
            List<Student> st = new List<Student> { stud1, stud2, stud3 };

            string path = @"D:\Проекты С#\Json\Json\bin\Debug\note.txt";
            using (StreamWriter streamWriter = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach (var item in st)
                {
                    streamWriter.WriteLine(JsonSerializer.Serialize<Student>(item));
                }
            }

            List<string> studentRead = new List<string>();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    studentRead.Add(line);
                }
            }

            foreach (var item in studentRead)
            {
                Student s = JsonSerializer.Deserialize<Student>(item);
                if (s.Name == "Alex")
                {
                    Console.WriteLine("Name: " + s.Name);
                    Console.WriteLine("Age: " + s.Age);
                    Console.WriteLine("Group: " + s.Group);
                }
            }
        }
    }
}
