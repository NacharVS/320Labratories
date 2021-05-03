using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Json
{
    class Mass
    {
        List<Student> stud;
    } 
    class Program
    {
        static void Main(string[] args)
        {
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
                while ((line =  sr.ReadLine()) != null)
                {
                    studentRead.Add(line);
                }
            }

            foreach (var item in studentRead)
            {
                Student s = JsonSerializer.Deserialize<Student>(item);
                if(s.Name == "Alex")
                {
                    Console.WriteLine("Name: "+s.Name);
                    Console.WriteLine("Age: " + s.Age);
                    Console.WriteLine("Group: " + s.Group);
                }
            }



            Console.ReadKey();
        }
            
    }
}
