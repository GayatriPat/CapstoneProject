using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    public interface Lib{ 
        bool SearchBook(String s);
        void BorrowBook(String bor, DateTime t);
        void ReturnBook(string s);
        void BookDetails();
    }
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "yes";
            Librarian li = new Librarian();
            do
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("--------------WELCOME TO LIBRARY--------------");
                Console.WriteLine("Please Login into your account to proceed!!!");
                Console.WriteLine("1.Librarian");
                Console.WriteLine("2.Faculty");
                Console.WriteLine("3.Student");
                Console.WriteLine("______________________________________________");
                Console.WriteLine("");
                int ch = int.Parse(Console.ReadLine());
                Program p = new Program();
                switch (ch)
                {
                    case 1:
                        p.libr(li);
                        break;
                    case 2:
                        Console.WriteLine("Please Enter Your Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Please Enter Your Password");
                        String pwd = Console.ReadLine();
                        int chk = li.facauth(name, pwd);
                        if (chk == 1)
                            p.fac(li);
                        else if (chk == 2)
                        {
                            Console.WriteLine("New User!");
                            li.add_fac(name, pwd);
                            p.fac(li);
                        }
                        else
                            Console.WriteLine("Wrong username or password!");
                        break;
                    case 3:
                        Console.WriteLine("Please Enter Your Name");
                        string na = Console.ReadLine();
                        Console.WriteLine("Please Enter Your Password");
                        string pw = Console.ReadLine();
                        int chkk = li.studauth(na, pw);
                        if (chkk == 1)
                            p.stu(li);
                        else if (chkk == 2)
                        {
                            Console.WriteLine("New User");
                            li.add_stud(na, pw);
                            p.stu(li);

                        }
                        else
                            Console.WriteLine("Sorry! Wrong Username or Password ");
                        break;

                    default:
                        Console.WriteLine("Please Enter a Valid Choice");
                        break;

                }
                Console.WriteLine("Do you want to continue?");
                ans = Console.ReadLine();
            } while (ans.Equals("yes"));
        }
        public void fac(Librarian li)
        {
            string ans = "yes";
            Faculty f = new Faculty();
            li.faculty_no += 1;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Please select your choice");
                Console.WriteLine("1.Search Book");
                Console.WriteLine("2.Return Book");
                Console.WriteLine("3.Borrow Book");
                Console.WriteLine("4.Renew Book");
                Console.WriteLine("5.View Details of issued book");
                Console.WriteLine("6.Return to main menu");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the name of book");
                        String name = Console.ReadLine();

                        bool p = f.SearchBook(name);
                        if (p == true)
                            Console.WriteLine("Book found"!);
                        else
                            Console.WriteLine("Book not found"!);
                        break;

                    case 2:
                        Console.WriteLine("Enter the book you want to return");
                        String s = Console.ReadLine();

                        f.ReturnBook(s);
                        break;

                    case 3:
                        Console.WriteLine("Enter the name of the book");
                        String s1 = Console.ReadLine();
                        Console.WriteLine("Enter Issue Date");
                        DateTime t = Convert.ToDateTime(Console.ReadLine());
                        f.BorrowBook(s1, t);
                        break;

                    case 4:
                        Console.WriteLine("Enter the book you want to renew");
                        string s3 = Console.ReadLine();

                        f.Renew(s3);
                        break;

                    case 5:
                        f.BookDetails();
                        break;

                    case 6:
                        return;
                }
                Console.WriteLine("Do you want to continue");
                ans = Console.ReadLine();
            } while (ans.Equals("yes"));
        }
        public void stu(Librarian li)
        {
            String ans = "yes";
            li.student_no++;
            Student l = new Student();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Please select your choice");
                Console.WriteLine("1.Search Book");
                Console.WriteLine("2.Return Book");
                Console.WriteLine("3.Borrow Book");
                Console.WriteLine("5.View Details of issued book");
                Console.WriteLine("6.Return to main menu");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the name of book");
                        String name = Console.ReadLine();

                        bool p = l.SearchBook(name);
                        if (p == true)
                            Console.WriteLine("Book found"!);
                        else
                            Console.WriteLine("Book not found"!);
                        break;

                    case 2:
                        Console.WriteLine("Enter the book you want to return");
                        String s = Console.ReadLine();

                        l.ReturnBook(s);
                        break;

                    case 3:
                        Console.WriteLine("Enter the name of the book");
                        String s1 = Console.ReadLine();
                        Console.WriteLine("Enter Issue Date");
                        DateTime t = Convert.ToDateTime(Console.ReadLine());
                        l.BorrowBook(s1, t);
                        break;



                    case 4:
                        l.BookDetails();
                        break;

                    case 6:
                        return;
                }
            } while (ans.Equals("yes"));
        }
        public void libr(Librarian li)
        {
            string ans = "yes";
            do
            {
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("1.Manage Faculty Records");
                Console.WriteLine("2.Manage Student Records");
                Console.WriteLine("3.Manage Book Records");
                Console.WriteLine("4.Return to main menu");
                Console.WriteLine("5.Exit");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        li.displayfac();
                        break;
                    case 2:
                        li.displaystud();
                        break;
                    case 3:
                        li.catalouge();
                        break;
                    case 4:
                        return;
                }
                Console.WriteLine("Do you want to continue?");
                ans = Console.ReadLine();
            } while (ans.Equals("yes"));

        }

    }
}



