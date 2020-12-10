using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    class Program 
    { 
   
        static void Main(string[] args)
        {
            Manager m = new Manager();
            Console.WriteLine(m.calcNetSalary());
            
            Console.ReadLine();
        }
    }

    public interface IDbFunction
    {
        void Insert();
        void Delete();
        void Update();
    }
    public abstract class Employee : IDbFunction
    {
        string name;
        private static int E = 0;
        int empNo;
        short deptNo;
        protected decimal basic;
        public abstract decimal Basic
        {
            set;
            get;
        }

        public Employee(string Name = "noname", short DeptNo = 10, decimal Basic = 1000)
        {
            this.Name = Name;
            this.DeptNo = DeptNo;
            this.Basic = Basic;
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

        public void Insert()
        {
            Console.WriteLine("INSERT");
        }

        public void Delete()
        {
            Console.WriteLine("DELETE");
        }

        public void Update()
        {
            Console.WriteLine("UPDATE");
        }
    }

    //-------------------------------------------------------

    public class Manager : Employee
   
    {
        private string designation;

        public Manager(string Name = "noname", short DeptNo = 10,decimal Basic = 1000, string Designation = "GM") : base(Name, DeptNo, Basic)
        {
            this.Designation = Designation;
        }

        public override decimal Basic
        { 
            get {
                return basic;
            }
            set {
                basic = value;
            }
        }

        public string Designation
        {
            set
            {
                designation = value;
            }
            get
            {
                return designation;
            }
        }

        public override decimal calcNetSalary()
        {
            Basic = Basic * (decimal)1.2;
            return Basic;
        }
    }

    //----------------------------------------------------------------

    public class GeneralManager : Manager
    {
        string perks;

        public GeneralManager(string Name = "noname", short DeptNo = 10, decimal Basic = 1000, string Designation = "GM", string Perks = "none") : base(Name, DeptNo, Basic, Designation)
        {
            this.Perks = Perks;
        }

        public string Perks
        {
            set
            {
                perks = value;
            }
            get
            {
                return perks;
            }
        }

        public override decimal Basic
        {
            get
            {
                return Basic;
            }
            set
            {
                Basic = value;
            }
        }

        public override decimal calcNetSalary()
        {
            Basic = Basic * (decimal)1.5;
            return Basic;
        }

    }

    public class CEO : Employee
    {

        public CEO(string Name = "noname", short DeptNo = 10, decimal Basic = 1000): base(Name, DeptNo, Basic)
        {
            
        }

        public override decimal Basic
        {
            get
            {
                return Basic;
            }
            set
            {
                Basic = value;
            }
        }

        public override decimal calcNetSalary()
        {
            Basic = Basic * (decimal)1.7;
            return Basic;
        }
    }


}
