using System;
namespace LAB03{
  class Whale:Animal {
    private string whaleKind;

    public string WhaleKind{ get => whaleKind; set => whaleKind = value; }

    public Whale(){}
    public Whale(string whaleKind,string name,int age,double weight):base(name,age,weight){
      this.name=name;
      this.weight=weight;
      this.age=age;
      this.whaleKind=whaleKind;
    }

    public override void Input(){
      base.ToString();
      Console.Write("Enter type of whale : ");
      whaleKind=Console.ReadLine();
    }

    public override string ToString()
    {
      return 
      base.ToString() + 
      WhaleKind;
    }

    public  string Fish(){
      return this.Name + " is fishing\n";
    }
  }
}
