using System;

namespace LAB01{
  class Circle{
    private double r;
    const double PI = 3.141592654;

    public Circle(double r)
    {
      this.r = r;
    }

     public Circle()
    {
      R = 1;
    }
    public double R { get => r; set => r = value; }

    public void Input(){
      R = double.Parse(Console.ReadLine());
    }

    public void Output(){

    }

    public override string ToString()
    {
      return 
      "Thông tin hình tròn : " + "\n" +
      "Bán kính r: " + R;
    }

    public double CalculateArea(){
      return PI*R*R;
    }

    public double CalculatePerimeter(){
      return 2*PI*R;
    }

    
    
  }
}