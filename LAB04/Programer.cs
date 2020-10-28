using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Programer:Employee
    {
        private int bugsPerMonth;
        public int BugsPerMonth { get => bugsPerMonth; set => bugsPerMonth = value; }
        public Programer() { }
        public Programer(string code,string fullName,double salary,int bugsPerMonth):
            base(code,fullName,salary)
        {
            Code = code;
            FullName = fullName;
            Salary = salary;
            BugsPerMonth = bugsPerMonth;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap so loi: ");
            bugsPerMonth = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("Bugs per month: " + BugsPerMonth);
        }
        public override double GetFinalSalary()
        {
            double salary = base.GetFinalSalary();
            if (BugsPerMonth < 20)
                return salary * 1.1;
            return salary;

        }
    }
}
