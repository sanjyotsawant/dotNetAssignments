using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAssign
{
    class Program
    {
        static void Main(string[] args)
        {

            //Employee o1 = new Employee("Amol", 123465, 10);
            //Employee o2 = new Employee("Amol", 123465);
            //Employee o3 = new Employee("Amol");
            //Employee o4 = new Employee();

            //Console.WriteLine(o1.EmpNo);
            //Console.WriteLine(o2.EmpNo);
            //Console.WriteLine(o3.EmpNo);
            //Console.WriteLine(o4.EmpNo);

            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);


            Console.ReadLine();
        }

        
    }

    class Employee
    {
        private string name = "";
        private  int empNo;
        private static int E;
        private decimal basic;
        private short deptNo;
        private double salary;
        public Employee()
        {
            E++;
            empNo = E;
        }

        public Employee(string nm)
        {
            E++;
            empNo = E;
            name = nm;
        }

        public Employee(string nm, decimal b)
        {
            E++;
            empNo = E;
            name = nm;
            basic = b;
        }

        public Employee(string nm, decimal b, short depno)
        {
            E++;
            empNo = E;
            name = nm;
            basic = b;
            deptNo = depno;
        }

        public string Name
        {
            set
            {
                if (value == "")
                    Console.WriteLine("Invalid Name");
                else
                    name = value;
            }

            get
            {
                return name;
            }

        }

        public decimal Basic
        {
            set
            {
                basic = value;
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
                deptNo = value;
            }

            get
            {
                return deptNo;
            }

        }

        public double Salary
        {
            set
            {
                if (basic > 15000)
                    salary = (double)basic + 5000;
                else
                    salary = (double)basic + 3000;
            }
            get
            {
                return salary;
            }
        }

        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
    }
}
