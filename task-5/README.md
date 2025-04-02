# Task 5: File I/O and Exception Handling

## **File I/O and Exception HandlingObjective:Requirements:**
- Develop an application that reads from and writes to files.
- Read text from a file (e.g., a log file or a simple CSV).
- Process the data (for example, count words or lines).
- Write the result to a new file.
- Implement exception handling to manage file-related errors (such as `FileNotFoundException` or `IOException`).

## **Features**
1. **Write Student Data to a File**  
   - Users can input student details (Name, Age, and Grade), which will be appended to a CSV file.

2. **Read and Display Data from the File**  
   - The program reads the CSV file and displays all student data.
   - It also counts and displays:
     - The total number of students.
     - The total number of words in the file.

3. **Exception Handling**  
   - Handles `FileNotFoundException` to ensure the file exists before reading.
   - Handles `IOException` to manage general input/output errors.

## **Code Explanation**

### **1. Reading Data from the File (`ReadFile` Method)**  
- Uses `File.ReadAllText()` to display the file content.
- Uses `File.ReadAllLines()` to read the file line by line.
- Splits each line by commas to count words and lines.
- Handles `FileNotFoundException` to manage missing files.

### **2. Writing Data to the File (`WriteFile` Method)**  
- Uses `File.AppendAllText()` to add new student data to the file.
- Handles `FileNotFoundException` and `IOException` for safe writing operations.

### **3. User Interaction (`Main` Method)**  
- Provides a menu with options:
  1. Add a new student record.
  2. Read and display student records.
  3. Exit the application.
- Uses a loop to continuously accept user input until they choose to exit.

## **Example Usage**
```
Select the Function
1. Add Student data in the file
2. Read the data
3. Exit
1

Provide the Name of the student
Praveen

Provide the Age of the student
21

Provide the Grade of the student
90

File Written Successfully

Select the Function
1. Add Student data in the file
2. Read the data
3. Exit
2

name,age,grade
Srikanth,22,93
Mouly,22,89
Praveen,21,90

No of Students 4
No of Words in the file 12

Select the Function
1. Add Student data in the file
2. Read the data
3. Exit
3
```