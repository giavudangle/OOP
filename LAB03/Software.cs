using System;
namespace LAB03{
  class Sofware:Product {
    
    private string version;

    public Sofware(string version,string name,double price):base(name,price)
    {
      this.version = version;
      this.name=name;
      this.price=price;
    }

    public string Version { get => version; set => version = value; }

    public override string ToString()
    {
      return 
      "Software " + "\n" +
      base.ToString() + "\n" +
      Version;
    }
  }
}
