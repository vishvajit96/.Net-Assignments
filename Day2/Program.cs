﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {
            Employee o;
            o = new Employee();
            Console.WriteLine(o.EmpNo);
            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");    
            Employee o4 = new Employee();
            
            Console.WriteLine(o1.EmpNo); 
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o4.EmpNo);

        }
    }
    class Employee
    {
        //Members
        private string name;
        private decimal basic;
        private static int auto;
        private int empno;
        short deptno;

        //Properties
        public string Name
        {
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                    Console.WriteLine("Name should not be blank ");
            }
            get
            {
                return name;
            }
        }
        public int EmpNo
        {
            get {
                return empno;
            }
        }
        public decimal Basic
        {
            set
            {
                if(value>10 && value<123450)
                {
                    basic = value;
                }
                else
                    Console.WriteLine("Basic must be in range 10 to 50 ");

            }
            get
            {
                return basic;
            }
        }
        public short DeptNo
        {
            set
            {
                if(value>0 && value <127)
                {
                    deptno = value;
                }
                else
                    Console.WriteLine("Dept No must be grater than 0 and less than 128");
            }
            get
            {
                return deptno;
            }
        }

        //Methods
        public decimal getNetSalary()
        {
            decimal netsal;
            netsal = basic + 4000 + 1000;//BASIC+DA+TA Fixed
            return netsal;
        }

        //Constructors
        public Employee()
        {
            Console.WriteLine("Zero Para Construct");
            auto++;
            this.empno = auto;
        }
        public Employee(string name)
        {
            this.name = name;
            auto++;
            this.empno = auto;
        }
        public Employee(string name,decimal basic)
        {
            this.name = name;
            this.basic = basic;
            auto++;
            this.empno = auto;
        }
        public Employee(string name,decimal basic ,short deptno)
        {
            this.name = name;
            this.basic = basic;
            this.deptno = deptno;
            auto++;
            this.empno = auto;
        }
    }
}
