using System;
namespace LAB03{
  class Student:Person {
    private string studentId;
    public string StudentId { get => studentId; set => studentId = value; }

    public Student(string studentId,string name,string email):base(name,email){
      this.studentId=studentId;
      this.name=name;
      this.email=email;
    }

    public Student(){
    }
    public Student(Student stu){
      this.studentId=stu.studentId;
      this.name=stu.name;
      this.email=stu.email;
    }

   
    public override string ToString()
    {
      return 
        "Student ID : " + studentId + "\n" +
        base.ToString() + "\n";
        
    }
  }
}
