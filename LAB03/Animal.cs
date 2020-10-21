using System;
namespace LAB03{
  class Animal {
    
    protected string name;
    protected int age;
    protected double weight;

    public Animal(string name, int age, double weight)
    {
      this.Name = name;
      this.Age = age;
      this.Weight = weight;
    }
    public Animal(){}

    public virtual void Input(){
      Console.Write("Animal name : ");
      Name = Console.ReadLine();
      Console.Write("Animal age : ");
      Age = int.Parse(Console.ReadLine());
      Console.Write("Animal weight : ");
      Weight = double.Parse(Console.ReadLine());
      
    }

    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }
    public double Weight { get => weight; set => weight = value; }

    public override string ToString()
    {
      return 
      "Name: " + Name + "\n" +
      "Age: " + Age + "\n" +
      "Weight: " + Weight + "\n";
    
    }

    public string Eat(){
      return Name + "is eating + \n";
    }



    
  }
}
