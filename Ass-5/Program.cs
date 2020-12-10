using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal, decimal, decimal> a2 = (P, N, R) => (P * N * (R / 100));
            Console.WriteLine(a2(1000, 1, 5));

            Func<int, int, bool> a1 = (x, y) => x > y ? true : false;
            Console.WriteLine(a1(10, 20));

            Predicate<int> a3 = (a) => a % 2 == 0 ? true : false;
            Console.WriteLine(a3(20));


            Employee e = new Employee("Xyx", 8000);
            Func<Employee, int> e2 = x => x.Basic;
            Console.WriteLine(e2(e));

            Predicate<Employee> a4 = x => x.Basic > 10000 ? true : false;
            Console.WriteLine(a4(e));
        }
        public class Employee
        {
            private String ename;
            private int basic;
            public Employee(string ename, int basic)
            {
                this.ename = ename;
                this.basic = basic;

            }
            public String Ename
            {
                set
                {
                    ename = value;
                }
                get
                {
                    return ename;
                }
            }
            public int Basic
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


        }
    }
}