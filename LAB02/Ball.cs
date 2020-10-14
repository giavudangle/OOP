using System;

namespace LAB02
{
  class Ball{
    private Color color;
    private double size;
    private int timeOfThrown;

    public double Size {
       get => size;
       set {
         if (value >=0) 
          size=value;
         else 
          throw new Exception("Size must be positive");
       }
    }
    public int TimeOfThrown { 
      get => timeOfThrown; 
      set {
        if (value >=0) 
          timeOfThrown=value;
        else 
          throw new Exception("Time of thrown must be positive");
      } 
    }

    internal Color Color { get => color; set => color = value; }

    public Ball(){
      this.color= new Color();
      this.size=0;
      this.timeOfThrown=0;
    }

    public Ball(Color color, double size, int timeOfThrown)
    {
      this.color = color;
      this.size = size;
      this.timeOfThrown = timeOfThrown;
    }

    public void Pop() => Size=0; 
    public bool isPop() => Size == 0 ? true : false;
    public int Throw() => !isPop() ? TimeOfThrown++ : 0;
    public void Input(){
      Console.Write("Enter Ball Size : ");
      Size = double.Parse(Console.ReadLine());
      Console.Write("Enter TimeOfThrown Ball : ");
      TimeOfThrown = int.Parse(Console.ReadLine());
    }

    public void Output(){
     Console.WriteLine("Ball Color : " + Color.ToString());
     Console.WriteLine("Ball Size : " + Size);
     Console.WriteLine("Ball Time Of Thrown : " + TimeOfThrown);
    }

  }
}
