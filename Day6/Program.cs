using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    class Program
    {
        static void Main1(string[] args)
        {
            /*1. Declare a dictionary based collection of Employee class objects 
        
                Accept details for Employees  in a loop. Stop accepting based on user input (yes/no)'
                Display the Employee with highest Salary
                Accept EmpNo to be searched. Display all details for that employee. 
                Display details for the Nth Employee where N is a number accepted from the user.*/

            SortedList<int, Employee> sd = new SortedList<int, Employee>();
            while (true)
            {
                Console.WriteLine("enter choice to add Employee details Yes or No");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "yes":
                        Console.WriteLine("enter employee details");
                        Console.WriteLine("enter employee key");
                        int key = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter employee empno");
                        int no = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter emp name");
                        string name = Console.ReadLine();
                        Console.WriteLine("enter emp basic");
                        decimal basic = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("enter emp depNo");
                        int depno = Convert.ToInt32(Console.ReadLine());
                        sd.Add(key, new Employee { PempNo = no, Pname = name, Pbasic = basic, PdeptNo = depno });

                        break;
                    case "no":

                        break;

                    default:
                        Console.WriteLine("no such value");
                        break;
                }
                if (choice.Equals("no"))
                {
                    break;
                }
            }
            //Console.WriteLine(((int)sd.IndexOfValue(0)).Pbasic); 

            for (int i = 2; i < sd.Count; i++)
            {
                if (sd[1].Pbasic < sd[i].Pbasic)
                {
                    sd[1].Pbasic = sd[i].Pbasic;
                }
            }
            Console.WriteLine("The highest salary is = " + sd[1].Pbasic);

            Console.WriteLine("Enter empNo to be serached");
            int empno = Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<int, Employee> k in sd)
            {
                if (k.Value.PempNo == empno)
                {
                    Console.WriteLine("empNo = " + k.Value.PempNo + " Emp name = " + k.Value.Pname + " Emp basic = " + k.Value.Pbasic + " Emp depNo = " + k.Value.PdeptNo);
                }
            }
            Console.WriteLine("Enter key to be serached");
            int keyno = Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<int, Employee> k in sd)
            {
                if (k.Key == keyno)
                {
                    Console.WriteLine("empNo = " + k.Value.PempNo + " Emp name = " + k.Value.Pname + " Emp basic = " + k.Value.Pbasic + " Emp depNo = " + k.Value.PdeptNo);
                }
            }
        }

        static void Main2()
        {
            //2. Create an array of Employee objects. Convert it to a List<Employee>.  Display all the Employees in the list.

            Employee e1 = new Employee { PempNo = 1, Pname = "omi", Pbasic = 30000, PdeptNo = 1 };
            Employee e2 = new Employee { PempNo = 2, Pname = "onkar", Pbasic = 32000.5m, PdeptNo = 1 };
            Employee e3 = new Employee { PempNo = 3, Pname = "vedant", Pbasic = 34000.5m, PdeptNo = 1 };

            Employee[] e = { e1, e2, e3 };
            List<Employee> li = e.ToList<Employee>();
            foreach (Employee emp in li)
            {
                Console.WriteLine("Emp no = " + emp.PempNo + " Emp name = " + emp.Pname + " Emp basic = " + emp.Pbasic + " Emp deptNo = " + emp.PdeptNo);
            }
        }

        static void Main()
        {
            //3. Create a List<Employee>. Convert it to an array. Display all the array elements.

            Employee e1 = new Employee { PempNo = 1, Pname = "omi", Pbasic = 30000, PdeptNo = 1 };
            Employee e2 = new Employee { PempNo = 2, Pname = "onkar", Pbasic = 32000.5m, PdeptNo = 1 };
            Employee e3 = new Employee { PempNo = 3, Pname = "vedant", Pbasic = 34000.5m, PdeptNo = 1 };
            List<Employee> li = new List<Employee>();
            li.Add(e1);
            li.Add(e2);
            li.Add(e3);

            Employee[] e = li.ToArray();
            foreach (Employee emp in e)
            {
                Console.WriteLine("Emp no = " + emp.PempNo + " Emp name = " + emp.Pname + " Emp basic = " + emp.Pbasic + " Emp deptNo = " + emp.PdeptNo);
            }



        }
    }
    public class Employee
    {
        private string name;
        private int empNo;
        private decimal basic;
        private int deptNo;


        #region property
        public string Pname
        {
            set
            {

                if (value.Length != 0)
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("name not be null");
                }
            }
            get
            {
                return name;
            }
        }

        public int PempNo
        {
            set
            {
                this.empNo = value;
            }
            get
            {
                return empNo;
            }
        }

        public decimal Pbasic
        {
            set
            {
                if (value >= 25000 && value <= 100000)
                {
                    this.basic = value;

                }
                else
                {
                    Console.WriteLine("enter basic between 25000 to 35000");
                }
            }
            get
            {
                return basic;
            }
        }

        public int PdeptNo
        {
            set
            {
                if (value > 0)
                {
                    this.deptNo = value;
                }
                else
                {
                    Console.WriteLine("deptno must be above 0");
                }
            }
            get
            {
                return deptNo;
            }
        }
        #endregion

    }
}
