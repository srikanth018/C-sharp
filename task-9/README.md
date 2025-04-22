
# Task 9: Reflection and Custom Attributes

### Task:
- Build an application that discovers and executes methods based on custom attributes.
- Define a custom attribute (e.g., `[Runnable]`).
- Create several classes with methods decorated with the `[Runnable]` attribute.
- Use reflection to scan the current assembly for methods marked with `[Runnable]`.
- Invoke the discovered methods dynamically and display their outputs.

## Execution

### Step 1: Define the Custom Attribute

```csharp
[AttributeUsage(AttributeTargets.Method)]
public class Runnable : Attribute {
    public string? Message { get; }

    public Runnable(string p_message) {
        Message = p_message;
    }
}
```

### Step 2: Create Classes with Runnable Methods

```csharp
public class Calculator1 {
    [Runnable("Execute Add function")]
    public void Add() => Console.WriteLine(5 + 5);

    [Runnable("Execute Sub function")]
    public void Sub() => Console.WriteLine(10 - 5);
}

public class Calculator2 {
    [Runnable("Execute Multiply function")]
    public void Mul() => Console.WriteLine(5 * 5);

    [Runnable("Execute Division function")]
    public void Div() => Console.WriteLine(10 / 5);
}
```

### Step 3: Use Reflection to Discover and Run Methods

```csharp
var assembly = Assembly.GetExecutingAssembly();

foreach (var type in assembly.GetTypes()) {
    var methods = type.GetMethods()
                      .Where(m => m.GetCustomAttribute(typeof(Runnable), false) != null);

    if (methods.Any()) {
        var instance = Activator.CreateInstance(type);

        foreach (var method in methods) {
            var attribute = (Runnable)method.GetCustomAttribute(typeof(Runnable));
            Console.WriteLine($"{attribute?.Message}");
            Console.WriteLine($"Now Executing class => {type.Name} - Method => {method.Name}()");
            method.Invoke(instance, null);
            Console.WriteLine();
        }
    }
}
```

---

## Output Example

```
Execute Add function
Now Executing class => Calculator1 - Method => Add()
10

Execute Sub function
Now Executing class => Calculator1 - Method => Sub()
5

Execute Multiply function
Now Executing class => Calculator2 - Method => Mul()
25

Execute Division function
Now Executing class => Calculator2 - Method => Div()
2

All Executed
```