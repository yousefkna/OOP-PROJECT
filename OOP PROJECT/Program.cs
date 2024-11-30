using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT
{
    class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }

        static List<Books> CatalogueLibrary = new List<Books>();
        public Books(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void AddBook()
        {
            Console.Write($"\n Enter the author of the book : ");
            string A = Console.ReadLine();
            Console.Write($"\n Enter the book name : ");
            string T = Console.ReadLine();

            Books bookadd = new Books(T, A);
            Books.CatalogueLibrary.Add(bookadd);
            Console.WriteLine($"\n The book added successfully \n Book name: {T} \n Author name: {A}");

        }

        public void searchbyauthor()
        {
            Console.Write("\n enter the author name : ");
            string x = Console.ReadLine();

            foreach (Books book in CatalogueLibrary)
            {
                if (x == book.Author)
                {
                    Console.WriteLine($"\n the book ({book.Title}) of the author ({book.Author}) is found");
                    break;
                }
                else
                    Console.WriteLine($"\n the book of the author ({x}) isn't found");
            }
        }
        public void searchbyTitle()
        {
            Console.WriteLine("\n enter the book name : ");
            string x = Console.ReadLine();

            foreach (Books book in CatalogueLibrary)
            {
                if (x == book.Title)
                {
                    Console.WriteLine($"\n the book ({book.Title}) of the author ({book.Author}) is found");
                    break;
                }
                else
                    Console.WriteLine($"\n the book ({x}) isn't found");
            }


        }

        public void display()
        {
            foreach (Books i in CatalogueLibrary)
            {
                Console.WriteLine($"\n Book name: {i.Title} \n The Author: {i.Author} \n \n------------------");
            }


        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Books catalogue = new Books("Children of Gebelawi ", "Naguib Mahfouz");
                CatalogueLibrary.Add(catalogue);

                Console.WriteLine($"Enter : \n 1 to add a new book \n 2 search by author name \n 3 search by book name \n 4 to display all the books \n 5 to exit ");
                string choice = "";
                while (choice != "5")
                {
                    Console.Write("\n" + "enter from 1 - 5 : ");
                    choice = Console.ReadLine();
                    Console.WriteLine("\n" + "--------------------");

                    switch (choice)
                    {
                        case "1":
                            catalogue.AddBook();
                            Console.WriteLine("--------------------");
                            break;

                        case "2":
                            catalogue.searchbyauthor();
                            Console.WriteLine("--------------------");
                            break;

                        case "3":
                            catalogue.searchbyTitle();
                            Console.WriteLine("--------------------");
                            break;

                        case "4":
                            if (CatalogueLibrary.Count() > 0)
                            {
                                catalogue.display();
                                Console.WriteLine("--------------------");
                            }
                            else
                            {
                                Console.WriteLine("--------------------");
                                Console.WriteLine("\n" + "The labrary has no books" + "\n");
                                Console.WriteLine("--------------------");
                            }
                            break;

                        case "5":
                            Console.WriteLine("\n" + "Exiting...");
                            break;

                        default:
                            Console.WriteLine("please enter a number from 1 - 5 ");
                            Console.WriteLine("--------------------");
                            break;
                    }

                }


                Console.ReadLine();
            }

        }
    }
}

