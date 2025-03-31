using System;
using System.Collections.Generic;

class User {
    private List<string> userList = new List<string>();

    public void AddUser(string name){
        this.userList.Add(name);
        Console.WriteLine("User Added Successfully");
    }
    public void RemoveUser(string name){
        this.userList.Remove(name);
        Console.WriteLine("User Removed Successfully");
    }

    public void DisplayUsers(){
        Console.WriteLine("User List:");

        foreach(var user in userList){
            Console.WriteLine(user);
        }
    }
}