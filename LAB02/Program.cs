using System;
using System.Collections.Generic;
namespace LAB02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo và tạo n trái banh có giá trị mặc định (số n được nhập từ bàn phím)
            Console.Write("Enter n balls : ");
            int n = int.Parse(Console.ReadLine());       
            Ball[] arrBall = new Ball[n];
            for(int i = 0 ;i <arrBall.Length ;i++){
                arrBall[i] = new Ball();
            }    
            // • Nhập lại thông tin trái banh thứ 0
            arrBall[0].Input();
            // • Xuất thông tin n trái banh ra màn hình (kiểm tra xem dữ liệu có như mong đợi
            // không)            
            foreach(Ball x in arrBall)
                x.Output();
            // • Ném trái banh thứ 1, 2
            arrBall[1].Throw();
            arrBall[2].Throw();
            // • Cho nổ trái banh thứ 1 và ném trái banh thứ 1. In số lần ném của các trái banh
            arrBall[1].Pop();
            arrBall[1].Throw();
                foreach(Ball x in arrBall)
                    Console.WriteLine(x.TimeOfThrown);      
            // • Hãy đổi màu của trái banh thứ 2 sang màu RGB (220, 220, 220) và độ trong
            // suốt 255.
            Color newColor = new Color(220,220,220,255);
            arrBall[2].Color = newColor;
            arrBall[2].Output();
        }
    }
}
