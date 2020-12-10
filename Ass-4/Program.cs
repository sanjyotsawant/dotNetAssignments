using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        //------Q1---------------
        static void Main1(string[] args)
        {
            Employee[] emp = new Employee[3];
            for(int i=0; i<3; i++)
            {
                Console.Write("Enter Name ");
                string n = Convert.ToString(Console.ReadLine());
                Console.Write("Enter Salary ");
                double s = Convert.ToDouble(Console.ReadLine());
                Employee o = new Employee(n,s);
                
                emp[i] = o;
            }

            foreach (Employee o in emp)
            {
                Console.WriteLine(o.Name + " " + o.Salary);
            }
            Console.WriteLine();



            Console.Write("Enter EmpNo: ");
            int en = Convert.ToInt32(Console.ReadLine());
            foreach (Employee o in emp)
            {
                if(Array.Equals(o.EmpNo, en))
                {
                    Console.WriteLine("Present");
                    break;
                }
            }
            Console.WriteLine("NOT PRESENT");

          
            Console.ReadLine();
        }


        //-------------Q2------------------------------------
        static void Main2()
        {
            Console.WriteLine("No Of Batches: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[][][] arr = new int[n][][];

            for(int i = 0; i< n; i++)
            {
                Console.WriteLine("No Of Students for Batch {0} : ",i);
                int s = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[s][];

                for(int j=0; j<s; j++)
                {
                    Console.WriteLine("No Of Sub: ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    arr[i][j] = new int[m];

                    for(int k = 0; k < m; k++)
                    {
                        Console.WriteLine("Enter Markd of student {0} for sub{1} ",j,k);
                        int mark = Convert.ToInt32(Console.ReadLine());
                        arr[i][j][k] = mark;
                    }
                }
            }


            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    for (int k = 0; k < arr[i][j].Length; k++)
                    {
                        Console.WriteLine("marks of student {0} from batch {1} for sub {2} :{3} ", j, i, k,arr[i][j][k]);
                        //Console.WriteLine("batch : {0} student {1} subject {2} : {3} ",i,j,k,arr[i][j][k]);
                    }
                }
            }
            Console.ReadLine();
        }


        //---------Q3-------------------

        static void Main()
        {
            Student s;
            Student[] arr = new Student[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Enter Roll NO ");
                int rn = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name ");
                string nm = Convert.ToString(Console.ReadLine());

                Console.Write("Enter Marks ");
                decimal m = Convert.ToDecimal(Console.ReadLine());

                s = new Student(nm, rn, m);

                arr[i] = s;
            }

        }
    }


    public struct Student
    {
        public string Name;
        public int RollNo;
        public decimal Marks;

        public Student(string Name, int RollNo, decimal Marks)
        {
            this.Name = Name;
            this.RollNo = RollNo;
            this.Marks = Marks;

        }
    }
    public class Employee
    {
        private static int E = 0;
        private int empNo;
        private string name;
        private double salary;

        public Employee(string Name = "abc", double Salary=10000)
        {
            EmpNo = ++E;
            this.Name = Name;
            this.Salary = Salary;

        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int EmpNo
        {
            set
            {
                empNo = value;
            }
            get
            {
                return empNo;
            }
        }

        public double Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }
    }
}
