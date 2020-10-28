using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n;
            //Console.Write("Nhap n nhan vien: ");
            //n = int.Parse(Console.ReadLine());

            ////Tao mang voi n nhan vien
            //Employee[] listEmployee = new Employee[n];
            //Console.WriteLine();
            ////Nhap thong tin tung nhan vien
            //for(int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Cho biet loai nhan vien, nhap 0 neu la Programer" +
            //        ", nhap 1 neu la Tester");
            //    Console.Write("Nhap loai nhan vien: ");
            //    int type = int.Parse(Console.ReadLine());
            //    if (type == 0)
            //        listEmployee[i] = new Programer();
            //    else if (type == 1)
            //        listEmployee[i] = new Tester();
            //    //Nhap du lieu chi tiet
            //    listEmployee[i].Input();
            //}
            //}
            ////Xuat ra danh sach de kiem tra
            //Console.WriteLine("========================================");
            //Console.WriteLine("Danh sach thong tin nhan vien");
            //for(int i = 0; i < n; i++)
            //{
            //    listEmployee[i].Output();
            //    listEmployee[i].GetFinalSalary();
            //}
            Competitor[] competitors = new Competitor[2];
            competitors[0] = new Super(10, "vudang", "SC001", 10, 2, 5);
            competitors[1] = new Amateur(9, "moi", "CT001", 10, 7, 5);

            foreach(Competitor competitor in competitors)
            {
                Console.WriteLine(competitor.getTotal());
            }

        }
    }
}
