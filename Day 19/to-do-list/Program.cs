using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_do_list
{
    class Program
    {
        static List<string> todolist = new List<string>();
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("\n___ TO-DO LIST ___");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. View all tasks");
                Console.WriteLine("3. Mark a task as complete");
                Console.WriteLine("4. Remove a task");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        ViewTask();
                        break;
                    case 3:
                        CompleteTask();
                        break;
                    case 4:
                        RemoveTask();
                        break;
                    case 5:
                        Console.WriteLine("Exiting the application...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please select again.");
                        break;
                }
            } while (choice != 5);

        }
        static void AddTask()
        {
            Console.Write("Enter the new task :");
            string task = Console.ReadLine();
            todolist.Add(task);
            Console.WriteLine("Task added successfully.");
        }
        static void ViewTask()
        {
            if(todolist.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.WriteLine();
                for (int i = 0; i < todolist.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todolist[i]} ");
                }
            }
        }
        static void CompleteTask()
        {
            ViewTask();
            if (todolist.Count > 0)
            {
                Console.Write("Enter the task number to mark as complete: ");
                int taskNumber = Convert.ToInt32(Console.ReadLine());

                if (taskNumber > 0 && taskNumber <= todolist.Count)
                {
                    todolist[taskNumber - 1] += " (Completed)";
                    Console.WriteLine("Task marked as complete.");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
        }
        static void RemoveTask()
        {
            ViewTask();
            if(todolist.Count > 0)
            {
                Console.Write("Enter the task number to remove: ");
                int task_number = Convert.ToInt32(Console.ReadLine());
                if (task_number > 0 && task_number <= todolist.Count)
                {
                    todolist.RemoveAt(task_number - 1);
                    Console.WriteLine("Task removed successfully.");
                }
                else
                {
                    Console.WriteLine("Enter proper task number");
                }
            }
        }
    }
}
