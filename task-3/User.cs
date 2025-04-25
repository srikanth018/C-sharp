using System;
using System.Collections.Generic;

class User
{
    private List<string> userList = new List<string>();

    public void AddUser(string name)
    {
        this.userList.Add(name);
        Console.WriteLine("User Added Successfully");
    }
    public void RemoveUser(string name)
    {
        if(userList.Contains(name)){
        this.userList.Remove(name);
        Console.WriteLine("User Removed Successfully");
        }else{
            System.Console.WriteLine("No User Found");
        }

    }

    public int GetUsersCount(){
        return userList.Count();
    }

    public void DisplayUsers()
    {
        if (userList.Count() == 0)
        {
            System.Console.WriteLine("Users list is empty!!");
        }
        else
        {
            Console.WriteLine("User List:");

            foreach (var user in userList)
            {
                Console.WriteLine(user);
            }
        }

    }
}