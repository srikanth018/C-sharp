using System;
using System.Collections.Generic;


public class Student
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public int? Age { get; set; }
    public int? Grade { get; set; }
}

public interface IRepository<T> where T : Student
{
    void AddStudent(T student);
    void GetStudents();
    void UpdateStudent(T student);
    void DeleteStudent(int Id);
}


public class InMemoryRepository<T> : IRepository<T> where T : Student
{
    List<T> studentsList = new List<T>();
    int newId = 1;
    public void AddStudent(T student){
        student.Id = newId++;
        studentsList.Add(student);
    }

    public void GetStudents(){
        foreach (var studentData in studentsList){
            System.Console.WriteLine($"Id : {studentData.Id}, Name : {studentData.Name}, Age : {studentData.Age}, Grade : {studentData.Grade}");
        }
    }

    public void UpdateStudent(T student){
        int? id = student.Id;
        int index =  studentsList.FindIndex(s=>s.Id == id);
        studentsList.RemoveAll(s=>s.Id == id);
        studentsList.Insert(index, student);
    }

    public void DeleteStudent(int Id){
        studentsList.RemoveAll(s=>s.Id == Id);
    }

}

class Program
{
    static void Main(string[] args)
    {
        var studentRepo = new InMemoryRepository<Student>();

        studentRepo.AddStudent(new Student{Name = "srikanth",Age = 20,Grade = 95});
        studentRepo.AddStudent(new Student{Name = "srikanth",Age = 20,Grade = 95});
        studentRepo.AddStudent(new Student{Name = "Praveen",Age = 20,Grade = 95});

        studentRepo.UpdateStudent(new Student{Id = 1,Name = "Mouly",Age = 20,Grade = 95});
        studentRepo.DeleteStudent(2);
        studentRepo.GetStudents();

    }
}