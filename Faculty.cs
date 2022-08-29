using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    class Faculty : LibraryBooks, Lib //class Faculty inherits class LibaryBooks class and implements Lib interface
    {
        public Faculty() : base()//faculty constructor 1st calls base class constructor and then initializes its own objs
        {
            booksBorrowed = 0;
            for (int i = 0; i < 3; i++) //to initialize bookIssue
            {
                for (int j = 0; j < 2; j++)
                {
                    bookIssue[i, j] = 0;
                }
            }
        }
        public bool SearchBook(string s) //parameter holds name of book
        {
            bool a = true;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    //get book in s1
                    // var is used to declare implicitly typed local variable means it tells the compiler to figure out the type of the variable at compilation time.
                    var s1 = books[i, j].ToString();//book variable holds the record of total no of copys of particular book nd various no of books in library
                    //comparing s with s1
                    if (s1.Equals(s)) //if entered name of book matches with existing name of book it returns true
                    {
                        a = true;
                        return a;
                    }
                    else
                        a = false;
                }
            }
            return a;
        }
        public void BorrowBook(String BookName, DateTime t) //manipulates bookissue variables
        {
//             if (BookName.Equals('b'))
//             {
//                 Console.WriteLine("Sorry! You can't borrow this book ,It is just reference");
//             }
            if (this.booksBorrowed < 4)
            {
                bookIssue[this.booksBorrowed, 0] = BookName;
                bookIssue[this.booksBorrowed, 1] = t;
                this.booksBorrowed++;
            }
            else
                Console.WriteLine("Sorry! You can't borrow more than 3 books at a time.");
        }
        public void ReturnBook(string s)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (books[i, j].Equals(s))
                    {
                        books[i, j + 1] = (int)books[i, j + 1] + 1; //increments no of books in the catalogue
                    }
                }
            }

            //fine calculation

            for (int i = 0; i < this.booksBorrowed; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (this.bookIssue[i, j].Equals(s))
                    {
                        TimeSpan? f;                             // Timespan is difference bet 2 times
                        f = DateTime.Today - (DateTime)this.bookIssue[i, j + 1];

                        if (f?.TotalDays > 30)
                        {
                            Console.WriteLine("Your Fine is: " + f?.TotalDays * 2);
                        }
                    }
                }
            }
            booksBorrowed--;
        }
        public void BookDetails()
        {
            Console.WriteLine("Name" + "  " + "Issue Date");
            for (int i = 0; i < this.booksBorrowed; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(this.bookIssue[i, j] + " " + " ");
                }
                Console.WriteLine();
            }
        }
        public void Renew(string s2)
        {
            //only accessible to admin 
            for (int i = 0; i < this.booksBorrowed; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (bookIssue[i, j].Equals(s2))
                        bookIssue[i, j + 1] = DateTime.Today;

                }

            }
            Console.WriteLine("Book is renewed!");
        }

    }

}
