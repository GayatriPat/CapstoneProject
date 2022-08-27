using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    internal class LibraryBooks
    {
        public int booksBorrowed; //no of books borrowed
        public object[,] books = new object[5, 2];//for details of books
        public object[,] bookIssue = new object[3, 2];// for individual user
       public virtual void catalouge()
        {
            Console.WriteLine("Admin's Catalogue Management");
        }
        public LibraryBooks() //constructor to initialize the book catalougue
        {
            char ch = 'a';
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    books[i, j] = ch;
                    ch++;
                }
                for (int j = 1; j < 2; j++)
                {
                    books[i, j] = 5;
                }
            }
        }
    }
}
