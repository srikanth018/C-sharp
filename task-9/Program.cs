using System;
using System.Reflection;
using System.Linq;

[AttributeUsage(AttributeTargets.Method)]
public class Runnable : Attribute{
    public string? Message {get;}

    public Runnable(string p_message){
        Message = p_message;
    }
}

public class Calculator1{
    [Runnable("Execute Add function")]
    public void Add(){
        System.Console.WriteLine(5+5);
    }

    [Runnable("Execute Sub function")]
    public void Sub(){
        System.Console.WriteLine(10-5);
    }
}

public class Calculator2{
        [Runnable("Execute Multiply function")]
    public void Mul(){
        System.Console.WriteLine(5*5);
    }

    [Runnable("Execute Division function")]
    public void Div(){
        System.Console.WriteLine(10/5);
    }
}

public class Program{
    static void Main(string[] args){
        var assembly = Assembly.GetExecutingAssembly();

        Type[] types = assembly.GetTypes();

        foreach (var type in types){
            var methods = type.GetMethods().Where(m => m.GetCustomAttribute(typeof(Runnable), false) != null);

            if(methods.Any()){
                var createInstance = Activator.CreateInstance(type);

                foreach(var method in methods){
                    var attribute = (Runnable)method.GetCustomAttribute(typeof(Runnable));
                    System.Console.WriteLine($"{attribute?.Message}");
                    System.Console.WriteLine($"Now Executing class => {type.Name} - Method => {method.Name}()");
                    
                    method.Invoke(createInstance, null);
                    System.Console.WriteLine();
                }
            }

        }

        System.Console.WriteLine("All Executed");
    }
}