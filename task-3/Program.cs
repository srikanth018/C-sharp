using System;

static class Program
{
    static void Main(string[] args)
    {

        User u = new User();

        while (true)
        {
            Console.WriteLine("Heyy!!, Please select the functionality do you want");
            Console.WriteLine("1. Add new User");
            Console.WriteLine("2. Remove New User");
            Console.WriteLine("3. Display All Users");
            Console.WriteLine("4. Exit");
            int userinput = Convert.ToInt32(Console.ReadLine());

            if (userinput == 1)
            {
                Console.WriteLine("Enter user name");
                string userName = (Console.ReadLine() ?? "").Trim().ToUpper();


                u.AddUser(userName);
            }
            else if (userinput == 2)
            {


                if (u.GetUsersCount() > 0)
                {
                    Console.WriteLine("Enter user name that you want to remove");
                    string userName = (Console.ReadLine() ?? "").Trim().ToUpper();

                    u.RemoveUser(userName);
                }
                else {
                    System.Console.WriteLine("No users Found Till now");
                }



            }
            else if (userinput == 3)
            {
                u.DisplayUsers();
            }
            else if (userinput == 4)
            {
                break;
            }
            else{
                System.Console.WriteLine("Select the Functionality serial number correctly");
            }

        }
    }
}