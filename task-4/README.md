# Task 4


## Working with Collections and LINQ
- Create a student management console application.
- Define a `Student` class with properties such as `Name`, `Grade`, and `Age`.
- Populate a collection (e.g., a `List<Student>`) with sample data.
- Use LINQ to:
    - Filter students who have a grade above a certain threshold.
    - Sort the filtered results by name or grade.
- Display the filtered and sorted list.

## **Code Explanation**  

### **1. Student Class (`Student` Class)**  
- Defines three properties:  
  - `name` (string) – Student's name.  
  - `grade` (int) – Student's grade.  
  - `age` (int) – Student's age.  

### **2. Creating a List of Students**  
- A `List<Student>` is created and populated with **five students** and their details.  

### **3. Filtering & Sorting Using LINQ**  
- The program **filters** students with a `grade >= 80` using `Where()`.  
- The **filtered students** are sorted in **descending order** of grades using `OrderByDescending()`.  
- The results are **stored in a list** and displayed.  

### **4. Displaying the Filtered Students**  
- A `foreach` loop iterates over the filtered students and prints their details.  



#### **Output**  
```
Name - Srikanth, Age - 22, Grade - 93  
Name - Mouly, Age - 23, Grade - 89  
Name - Leela, Age - 22, Grade - 84  
Name - Sankar, Age - 22, Grade - 80  
```