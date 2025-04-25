using System;

class Person {
    private string name;
    private int age;
    private int salary;

    public Person(string name, int age, int salary){
        this.name = name;
        this.age = age;
        this.salary = salary;
    }

    public void Introduce(){
        Console.WriteLine($"Hi I am {name} and my age is {age} Salary is {salary}");
    }
}