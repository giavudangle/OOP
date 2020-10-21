using System;
namespace LAB03{
  class Product {
    protected string name;
    protected double price;

    public string Name { get => name; set => name = value; }
    public double Price { get => price; set => price = value; }

    public Product(){}

    public Product(string name, double price)
    {
      this.name = name;
      this.price = price;
    }

    public override string ToString()
    {
      return 
      "Name : " + name + "\n" +
      "Price : " + price ;
    }
  }
}
