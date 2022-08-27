using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneProject
{
    //A sealed class can't be inherited by any class but can be instantiated.
    sealed class Librarian : LibraryBooks
    {
        public int faculty_no;// represents no of faculties
        public int student_no;//represents no of students
        public Librarian()
        {
            faculty_no = 0;
            student_no = 0;
        }
        string[,] fac_name = new string[5, 2];  // name and password of fac
        string[,] stud_name = new string[5, 2]; // name and password of stud
        public void add_fac(string name, string password) // to register new faculty
        {
            for (int i = 0; i <= this.faculty_no; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    this.fac_name[i, j] = name; //adds name nd pwd of fac into fac_name[i,j]
                }
                for (int j = 1; j < 2; j++)
                {
                    this.fac_name[i, j] = password;
                }
            }
        }
        public void add_stud(string name, string password) // to register new faculty
        {
            for (int i = 0; i <= this.faculty_no; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    this.stud_name[i, j] = name; //adds name nd pwd of student into stud_name[i,j]
                }
                for (int j = 1; j < 2; j++)
                {
                    this.stud_name[i, j] = password;
                }
            }
        }
        public int facauth(string s3, string s4) //authenication
        {
            int flag = 0;
            if (this.faculty_no == 0)
            {
                return 2;
            }
            else
            {
                for (int i = 0; i < this.faculty_no; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        var k = this.fac_name[i, j];
                        //Console.WriteLine("Name of fac"+k);

                        if (k.Equals(s3))
                        {
                            flag = 1;
                            if (this.fac_name[i, j + 1].Equals(s4)) //checks whether 
                            {
                                return 1;
                            } //return true 
                        }
                    }
                }
            }
            if (flag == 1)
                return 2;
            else
                return 0;
        }
        public int studauth(string user_name, string pwd) //authenication
        {
            int flag = 0;
            if (this.student_no == 0)
            {
                return 2;
            }
            else
            {
                for (int i = 0; i < this.student_no; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        var k = this.stud_name[i, j];
                        //Console.WriteLine("Name of fac"+k);

                        if (k.Equals(user_name))  //checks enterd name matches with is registered
                        {
                            flag = 1;
                            if (this.stud_name[i, j + 1].Equals(pwd)) //checks password
                            {
                                return 1;   //if match is found returns true
                            } //return true 
                        }
                    }
                }
            }
            if (flag == 1)

                return 2;   // for new user
            else
                return 0; // if authnication fails
        }
        public void displayfac()
        {
            Console.WriteLine("Name" + "    " + "password");
            for (int i = 0; i < this.faculty_no; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(this.fac_name[i, j] + "    ");
                }
                Console.WriteLine(" ");
            }
        }
        public void displaystud()
        {
            Console.WriteLine("Name" + "    " + "password");
            for (int i = 0; i < this.student_no; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(this.stud_name[i, j] + "    ");
                }
                Console.WriteLine(" ");
            }
        }
        public override void catalouge()
        {
            String ans = "yes";
            do
            {
                Console.WriteLine("______________________________________________");
                Console.WriteLine("");
                Console.WriteLine("1)View Books");
                Console.WriteLine("2)Add Books");
                Console.WriteLine("3)Remove Book");
                Console.WriteLine("4)Return to main menu");
                Console.WriteLine("Please Enter Your Choice!!!");
                Console.WriteLine("");
                Console.WriteLine("______________________________________________");
                Console.WriteLine("");
                int no = int.Parse(Console.ReadLine());

                switch (no)
                {
                    case 1:
                        Console.WriteLine("Book Name" + " " + "No of copies available in library");

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                Console.Write(this.books[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of books");
                        String s = Console.ReadLine();
                        Console.WriteLine("Enter how many copies of book you want to add!");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                String s1 = books[i, j].ToString();
                                if (s1.Equals(s))
                                {
                                    books[i, j + 1] = (int)books[i, j + 1] + n;
                                    break;
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the name of books");
                        String sn = Console.ReadLine();
                        Console.WriteLine("Enter how many copies of book you want to remove!");
                        int n1 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                String s1 = books[i, j].ToString();
                                if (s1.Equals(sn))
                                {
                                    books[i, j + 1] = (int)books[i, j + 1] - n1;
                                    break;
                                }
                            }
                        }
                        break;
                    case 4:
                        return;
                }


            } while (ans.Equals("yes"));
        }
    }
}
