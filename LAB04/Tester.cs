using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Tester:Employee
    {
        private double overTime;
        
        public double OverTime { get => overTime; set => overTime = value; }
        public Tester() { }
        public Tester(string code,string fullName,double salary,double overTime)
            : base(code, fullName, salary)
        {
            Code = code;
            FullName = fullName;
            Salary = salary;
            OverTime = overTime;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap so gio OT: ");
            overTime = double.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("So gio OT: "+OverTime);
        }
        public override double GetFinalSalary()
        {
            double salary = base.GetFinalSalary();
            return salary + (OverTime * 20000);
        }
    }
}
