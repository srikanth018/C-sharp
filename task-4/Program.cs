using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Student{
        public string? name { get; set; }
        public int? grade { get; set; }
        public int? age { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>{
                new Student {name = "Srikanth", grade = 93, age = 22},
                new Student {name = "Leela", grade = 84, age = 22},
                new Student {name = "Mouly", grade = 89, age = 23},
                new Student {name = "Praveen", grade = 79, age = 21},
                new Student {name = "Sankar", grade = 80, age = 22}
            };

            var names = students.Select(m=>m.name).Where(n=>n.Contains('n'));
            var names1 = students.Where(x=>x.name.Contains('n')).Select(x=>x.name);
            
            foreach(var name in names){
                System.Console.WriteLine($"Name of the stdent is {name}");
            }

            var MaxGrade = students.OrderByDescending(m=>m.grade).First();


            var firstClassGrades = students.Where(member => member.grade >= 80).OrderByDescending(member => member.grade).ToList();

            foreach (var student in firstClassGrades){
                Console.WriteLine($"Name - {student.name}, Age - {student.age}, Grade - {student.grade}");
            }

        }
    }
}