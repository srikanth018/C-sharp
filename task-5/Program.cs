using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task5
{
    public class Program
    {
        static void ReadFile(string path)
        {
            try
            {
                Console.WriteLine(File.ReadAllText(path));
                System.Console.WriteLine();

                string[] lines = File.ReadAllLines(path);
                int count = 0;
                foreach (var line in lines)
                {
                    string[] words = line.Split(',');
                    count = count + words.Length;
                }
                Console.WriteLine("No of Students " + lines.Length);
                Console.WriteLine("No of Words in the file " + count);

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("file not found" + e.Message);
            }
        }

        static void WriteFile(string path, string content)
        {
            try
            {
                File.AppendAllText(path, '\n'+ content);
                System.Console.WriteLine("File Written Succesfully");
                System.Console.WriteLine();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("file not found" + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Main(string[] args)
        {
            string path = @"E:\Presidio Assignments\C#\task-5\students.csv";

            while(true){
                System.Console.WriteLine("Select the Function");
                System.Console.WriteLine("1. Add Student data in the file");
                System.Console.WriteLine("2. Read the data");
                System.Console.WriteLine("3. Exit");

                int userInput = Convert.ToInt32(Console.ReadLine());
                if(userInput == 1){

                    System.Console.WriteLine("Provide the Name of the student");
                    string name = Console.ReadLine() ?? string.Empty;
                    System.Console.WriteLine("Provide the Age of the student");
                    string age = Console.ReadLine() ?? string.Empty;
                    System.Console.WriteLine("Provide the Grade of the student");
                    string grade = Console.ReadLine() ?? string.Empty;

                    string content = $"{name},{age},{grade}";
                    WriteFile(path, content);

                }else if(userInput == 2){
                    ReadFile(path);
                }else if(userInput == 3){
                    break;
                }
            }
        }
    }
}