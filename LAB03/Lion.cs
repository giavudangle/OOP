using System;
namespace LAB03{
  class Lion:Animal {
    private string lionKind;

    public string LionKind { get => lionKind; set => lionKind = value; }

    public Lion(){}
    public Lion(string lionKind,string name,int age,double weight):base(name,age,weight){
      this.name=name;
      this.weight=weight;
      this.age=age;
      this.lionKind=lionKind;
    }

    public override void Input(){
      base.ToString();
      Console.Write("Enter type of lion : ");
      lionKind=Console.ReadLine();
    }

    public override string ToString()
    {
      return 
      base.ToString() + 
      LionKind;
    }

    public string Hunt(){
      return this.Name + " is hunnting\n";
    }
  }
}
