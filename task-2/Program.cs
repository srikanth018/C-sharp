using System;

class Program
{
    static void Main()
    {
        
        Person p1 = new Person("Srikanth", 22, 2000);
        p1.Introduce();

        Person p2 = new Person("Mouly", 23);
        p2.Introduce();

        Person p3 = new Person("Amith", 22);
        p3.Introduce();
        

    }
}