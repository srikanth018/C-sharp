
# Task 8: Generics and Interfaces with the Repository Pattern in C#


## Requirements:
- Create a **generic interface** with CRUD operations (`Add`, `Get`, `Update`, `Delete`).
- Implement a **generic repository class** using that interface.
- Apply **type constraints** to ensure only valid types (e.g., `Student`) can be used.
- Demonstrate the repository with a simple **console UI** and a sample entity like `Student`.


## Execution:

1. **Student Entity**:  
   A basic class `Student` is defined with properties: `Id`, `Name`, `Age`, and `Grade`.

2. **Generic Repository Interface**:  
   An interface `IRepository<T>` is created with the following methods:
   - `AddStudent(T student)`
   - `GetStudents()`
   - `UpdateStudent(T student)`
   - `DeleteStudent(int Id)`

   It is constrained to types derived from `Student` using `where T : Student`.

3. **In-Memory Repository Implementation**:  
   The `InMemoryRepository<T>` class:
   - Maintains a private list of students.
   - Automatically assigns an incremental `Id` to new entries.
   - Implements all CRUD operations:
     - **Add**: Assigns ID and adds the student to the list.
     - **Get**: Displays all student records.
     - **Update**: Replaces a student entry based on matching ID.
     - **Delete**: Removes a student entry based on ID.

4. **Console Demo**:
   In the `Main` method:
   - Several students are added to the repository.
   - One student is updated.
   - One student is deleted.
   - Remaining students are printed to the console.

## Input:
```shell
studentRepo.AddStudent(new Student{Name = "srikanth",Age = 20,Grade = 95});
studentRepo.AddStudent(new Student{Name = "srikanth",Age = 20,Grade = 95});
studentRepo.AddStudent(new Student{Name = "Praveen",Age = 20,Grade = 95});

studentRepo.UpdateStudent(new Student{Id = 1,Name = "Mouly",Age = 20,Grade = 95});

studentRepo.DeleteStudent(2);

studentRepo.GetStudents();
```
## Output:

```shell
Id : 1, Name : Mouly, Age : 20, Grade : 95
Id : 3, Name : Praveen, Age : 20, Grade : 95
```
