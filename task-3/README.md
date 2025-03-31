## Task 5

### Basic Collections and String Manipulation
- Write a program to manage a list of strings (e.g., names or tasks).
- Use a `List<string>` to store items.
- Allow the user to add, remove, and display items.
- Utilize loops and basic string methods (like `Trim()`, `ToUpper()`) to process user input.



## Code Explanation

### 1. Main Program (`Program.cs`)
- Uses an infinite loop (`while(true)`) to continuously present options until the user chooses to exit.
- Reads user input and converts it to an integer.
- Calls different methods based on the selected option:
  - `AddUser()`: Adds a user after converting the input to uppercase.
  - `RemoveUser()`: Removes a user after converting the input to uppercase.
  - `DisplayUsers()`: Shows the current list of users.

### 2. User Class (`User.cs`)
- Maintains a `List<string>` to store usernames.
- Methods:
  - `AddUser(string name)`: Adds the given name to the list.
  - `RemoveUser(string name)`: Removes the name from the list (if it exists).
  - `DisplayUsers()`: Displays all usernames in the list.

### 3. List Methods
- `list.Add(name)`
- `list.Remove(name)`


### 4. String Manipulation
- `Trim()`
- `ToUpper()`




## Execution Steps in console

#### Console
    Heyy!!, Please select the functionality do you want
    1. Add new User
    2. Remove New User
    3. Display All Users
    4. Exit

#### Adding Users

##### Input

    1
    Enter user name
    Srikanth

##### Output:

    User Added Successfully


##### Input:

    1
    Enter user name
    Mouly

##### Output:

    User Added Successfully



#### Displaying Users
##### Input:

    3

##### Output:

    User List:
    SRIKANTH
    MOULY



#### Removing a User
##### Input:

    2
    Enter user name that you want to remove
    mouly

##### Output:

    User Removed Successfully



#### Displaying Users Again
##### Input:

    3

##### Output:
    
    User List:
    SRIKANTH



#### Exiting the Program
##### Input:

    4

##### Output:

    (Program exits)



