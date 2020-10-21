using System;
namespace LAB03{
  class Hardware:Product {
    
    private double weight;

    public Hardware(string name, double price, double weight) : base(name, price)
    {
      this.Weight = weight;
      this.name = name;
      this.price = price;
    }

    public double Weight { get => weight; set => weight = value; }

    public override string ToString()
    {
      return 
      "Hardware " + "\n" +
      base.ToString() + "\n" +
      Weight;
    }
  }
}
