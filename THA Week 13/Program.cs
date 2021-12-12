using System;
using System.Collections.Generic;

namespace THA_Week13_AngellieEnnovarynM_0706022110042
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. My scroll list \n2. Add scroll \n3. Search scroll \n4. Remove scroll \nYou can choose what you want to do \nWhat do you want to do? ");
            int menuOptions = Convert.ToInt32(Console.ReadLine());
            List<string> scrolls = new List<string>() { "Book of Peace", "Scroll of Swords", "Silence Guide Book" };
            string bookName = "";
            List<string> newScrolls = new List<string>();
            while (menuOptions == 1 || menuOptions == 2 || menuOptions == 3 || menuOptions == 4)
            {
                if (menuOptions == 1)
                {
                    Console.WriteLine();
                    Console.Write("Scroll to learn list: ");
                    foreach (string scroll in scrolls)
                    {
                        int index = scrolls.IndexOf(scroll);
                        Console.Write("\nScroll " + (index + 1) + ": " + scroll);
                    }
                }
                else if (menuOptions == 2)
                {
                    Console.Clear();
                    Console.WriteLine("How many scroll to add: ");
                    int bookAddition = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("In what number of queue? ");
                    int order = Convert.ToInt32(Console.ReadLine());
                    int last = scrolls.IndexOf(bookName);

                    for (int i = 0; i < bookAddition; i++)
                    {
                        Console.Write("Scroll " + (i + 1) + " name: ");
                        newScrolls.Add(Console.ReadLine());
                    }
                    int counter = -1;
                    foreach (string scroll in newScrolls)
                    {
                        scrolls.Insert(order + counter, scroll);
                        counter++;
                    }
                    newScrolls.Clear();

                }
                else if (menuOptions == 3)
                {
                    Console.WriteLine("Insert scroll name: ");

                    string searchedBook = Console.ReadLine();
                    scrolls = scrolls.ConvertAll(d => d.ToLower());
                    searchedBook = searchedBook.ToLower();
                    if (scrolls.Contains(searchedBook) == true)
                    {
                        int index = scrolls.IndexOf(searchedBook);
                        Console.WriteLine("Book found. The Queue number is: " + (index + 1));
                    }
                    else
                    {
                        Console.WriteLine("Book not found");
                    }
                }
                else if (menuOptions == 4)
                {
                    Console.WriteLine("Remove from list by scroll name? y/n: ");
                    string deleteScrollOption = Console.ReadLine();
                    while (deleteScrollOption != "y" && deleteScrollOption != "n")
                    {
                        Console.WriteLine("Wrong selection. Please choose again: ");
                        deleteScrollOption = Console.ReadLine();
                    }
                    if (deleteScrollOption == "y")
                    {
                        Console.WriteLine("Input scroll name:");
                        string deletedBook = Console.ReadLine();
                        scrolls = scrolls.ConvertAll(d => d.ToLower());
                        deletedBook = deletedBook.ToLower();
                        if (scrolls.Contains(deletedBook) == true)
                        {
                            scrolls.Remove(deletedBook);
                            Console.WriteLine("Book removed!");
                        }
                        else
                        {
                            Console.WriteLine("Book not found!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input scroll queue:");
                        int deletedBookPosition = Convert.ToInt32(Console.ReadLine());

                        while (deletedBookPosition < 1 || deletedBookPosition > scrolls.Count)
                        {
                            Console.WriteLine("Queue not found. Please insert scroll queue: ");
                            deletedBookPosition = Convert.ToInt32(Console.ReadLine());
                        }
                        scrolls.RemoveAt(deletedBookPosition - 1);
                        Console.WriteLine("Book removed!");
                    }
                }
                Console.WriteLine("\n1. My scroll list \n2. Add scroll \n3. Search scroll \n4. Remove scroll \nYou can choose what you want to do \nWhat do you want to do?");
                menuOptions = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
