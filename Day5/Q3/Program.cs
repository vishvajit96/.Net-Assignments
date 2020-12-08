using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter how many student want");
            int size = Convert.ToInt32(Console.ReadLine());
            student[] s = new student[size];
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter Student roll no");
                int no = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student name");
                string name = Console.ReadLine();
                ;
                Console.WriteLine("Enter Student mark");
                decimal mark = Convert.ToDecimal(Console.ReadLine());
                student s1 = new student(no, name, mark);
                s[i] = s1;
            }
            foreach (student a in s)
            {
                Console.WriteLine(a.Ino + " " + a.Pname + " " + a.Imark);
            }
        }
    }
    public struct student
    {
        string Name;
        int RollNo;
        decimal Marks;
        public student(int rollno, string name, decimal mark)
        {
            this.Name = name;
            this.RollNo = rollno;
            this.Marks = mark;
        }
        public string Pname
        {
            set
            {

                if (value.Length != 0)
                {
                    this.Name = value;
                }
                else
                {
                    Console.WriteLine("name not be null");
                }
            }
            get
            {
                return Name;
            }
        }
        public int Ino
        {
            set
            {
                if (value > 0)
                {
                    this.RollNo = value;
                }

            }
            get
            {
                return RollNo;
            }
        }
        public decimal Imark
        {
            set
            {
                if (value > 0)
                {
                    this.Marks = value;
                }
            }
            get
            {
                return Marks;
            }
        }

    }
}
