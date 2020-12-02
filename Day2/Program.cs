using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Manager("abc","sanjyot", 15000, 2);
            Manager e2 = new GeneralManager();
            Employee e3 = new CEO("abc", "sanjyot", 18000, 2);

            Console.WriteLine(e1.calcNetSalary());
            Console.WriteLine(e2.calcNetSalary());
            Console.WriteLine(e3.calcNetSalary());
            Console.ReadLine();

        }
    }

    public abstract class Employee
    {
        private string name = "";
        private int empNo;
        private static int E = 0;
        private decimal basic;
        private short deptNo;

        public Employee(string nm = "name", decimal b = 12000, short depno = 1)
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

        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
        public abstract decimal calcNetSalary();
    }

    public class Manager : Employee
    {
        private string designation;
        decimal salary;

        public Manager(string designation, String name, decimal basic, short deptNo): base(name,basic,deptNo)
        {
            this.designation = designation;
            salary = basic;
        }
        public override decimal calcNetSalary()
        {
            salary = salary * (decimal)2;
            return salary;
        }
    }

    public class GeneralManager : Manager
    {
        string perks;
        decimal salary;
        public GeneralManager(string perks="xyz", string designation="sr mgr", String name="abc", decimal basic=15000, short deptNo=2):base(designation, name, basic, deptNo)
        {
            this.perks = perks;
            salary = basic;
        }

        public override decimal calcNetSalary()
        {
            salary = salary * (decimal)2.2;
            return salary;
        }
    }

    public class CEO : Employee
    {
        decimal salary;
        public CEO(string designation, String name, decimal basic, short deptNo) : base(name, basic, deptNo)
        {
            salary = basic;
        }
        public sealed override decimal calcNetSalary()
        {
            salary = salary * (decimal)2.2;
            return salary;
        }
    }

}
