using System;

class Person {
    private string name;
    private int age;

    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }

    public void Introduce(){
        Console.WriteLine($"Hi I am {name} and my age is {age} ");
    }
}