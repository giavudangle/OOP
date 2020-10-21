using System;
namespace LAB03{
  class Person {
    protected string name;
    protected string email;

    public Person(string name, string email)
    {
      this.name = name;
      this.email = email;
    }
    public Person(){}

    public override string ToString()
    {
      return 
        "Name : " + name + "\n" +
        "Email: " + email;
    }
  }
}
