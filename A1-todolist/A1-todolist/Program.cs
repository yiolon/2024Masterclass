// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace TODOManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            //the empty todo list
            List<string> toDoList = new List<string>();

            //main loop
            while (true)
            {
                //menu part
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[S]ee all TODOs");
                Console.WriteLine("[A]dd a TODO");
                Console.WriteLine("[R]emove a TODO");
                Console.WriteLine("[E]xit");



                string userSelect = Console.ReadLine();

                switch (userSelect.ToUpper())
                {
                    case "S":
                        int index = 1;//index start at 1
                        if (toDoList.Count > 0)
                        {
                            foreach (string toDo in toDoList)
                            {
                                Console.WriteLine($"{index} : {toDo} ");
                                index++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("No TODOs have been added yet.");
                        }

                        break;

                    case "A":
                        Console.WriteLine("Enter the TODO description:");
                        string toDoInput = Console.ReadLine();

                        if (toDoInput == null)
                        {
                            Console.WriteLine("The description cannot be empty.");
                        }
                        if (toDoList.Contains(toDoInput))
                        {
                            Console.WriteLine("The description must be unique.");
                        }
                        else
                        {
                            toDoList.Add(toDoInput);
                        }
                        break;

                    case "R":
                        Console.WriteLine("Select the index of the TODO you want to remove:");
                        while (true)
                        {
                            int indexForLookOver = 1;
                            if (toDoList.Count > 0)
                            {
                                foreach (string toDo in toDoList)
                                {
                                    Console.WriteLine($"{indexForLookOver} : {toDo} ");
                                    indexForLookOver++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("No TODOs have been added yet.");
                            }

                            var userRemoveIndex = Console.ReadLine();
                            bool isRemoveSuccessful = int.TryParse(userRemoveIndex, out int indexForRemove);

                            if (isRemoveSuccessful && indexForRemove < toDoList.Count)
                            {
                                toDoList.RemoveAt(indexForRemove - 1);
                                break;
                            }
                            else if (indexForRemove > toDoList.Count)
                            {
                                Console.WriteLine("The given index is not valid.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Selected index cannot be empty.");
                                break;
                            }

                        }
                        break;

                    case "E":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;

                }

                /*            if (userSelect == "S" || userSelect == "s")
                            {
                                int index = 1;
                                foreach (string toDo in toDoList)
                                {
                                    Console.WriteLine($"{index} : {toDo} ");
                                }
                            }
                            else if (userSelect == "A" || userSelect == "a")
                            {
                                Console.WriteLine("Enter the TODO description:");
                                string toDoInput = Console.ReadLine();

                                if (toDoInput == null)
                                {
                                    Console.WriteLine("The description cannot be empty.");
                                }
                                if (toDoList.Contains(toDoInput))
                                {
                                    Console.WriteLine("The description must be unique.");
                                }
                                else
                                {
                                    toDoList.Add(toDoInput);
                                }
                            }
                            else if (userSelect == "R" || userSelect == "r")
                            {

                            }
                            else if (userSelect == "E" || userSelect == "e")
                            {

                            }
                            else
                            {
                                Console.WriteLine("Incorrect input");


            */
            }
        }

    }
}


