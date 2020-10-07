using System;

namespace LAB01{
  class Student{
    private string studentId;
    private string studentName;
    private int studentYear;
    private string studentAddress;

    public Student(string studentId, string studentName)
    {
      this.studentId = studentId;
      this.studentName = studentName;
    }

    public Student(string studentId, string studentName, int studentYear, string studentAddress)
    {
      this.studentId = studentId;
      this.studentName = studentName;
      this.studentYear = studentYear;
      this.studentAddress = studentAddress;
    }

    public string StudentId { get => studentId; set => studentId = value; }
    public string StudentName { get => studentName; set => studentName = value; }
    public int StudentYear { get => studentYear; set => studentYear = value; }
    public string StudentAddress { get => studentAddress; set => studentAddress = value; }


    public int StudentAge(){
      return DateTime.Now.Year - StudentYear;
    }

    public override string ToString(){
      return 
        "- Mã sinh viên: " + StudentId + "\n" +
        "- Họ tên: " + StudentName + "\n" +
        "- Năm sinh: " + StudentYear + "\n" +
        "- Địa chỉ: " + StudentAddress + "\n";
    }

  }
}