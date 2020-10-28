using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Employee
    {
        protected string code;
        protected string fullName;
        protected double salary;

        public string Code { get => code; set => code=value; }
        public string FullName { get => fullName; set => fullName=value; }
        public double Salary { get => salary; set => salary = value; }

        public Employee() { }
        public Employee(string code,string fullName,double salary)
        {
            Code = code;
            FullName = fullName;
            Salary = salary;
        }
        public virtual void Input()
        {
            Console.Write("Nhap ma nhan vien: ");
            code = Console.ReadLine();
            Console.Write("Nhap ho ten nhan vien: ");
            fullName = Console.ReadLine();
            Console.Write("Nhap luong co ban cua nhan vien: ");
            salary = double.Parse(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.WriteLine("Ma nhan vien: " + Code);
            Console.WriteLine("Ho ten nhan vien: " + FullName);
            Console.WriteLine("Luong co ban: " + Salary);
            Console.WriteLine("Luong cuoi cung: " + GetFinalSalary());
        }
        public virtual double GetFinalSalary()
        {
            return this.Salary;
        }
    }
}
