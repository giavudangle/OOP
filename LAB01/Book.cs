using System;

namespace LAB01{
  class Book{
    private string bookId;
    private string bookName;
    private double bookPrice;
    private double bookSale;

    public Book(string bookId, string bookName)
    {
      this.bookId = bookId;
      this.bookName = bookName;
    }

    public Book(string bookId, string bookName, double bookPrice, int bookSale)
    {
      this.bookId = bookId;
      this.bookName = bookName;
      this.bookPrice = bookPrice;
      this.bookSale = bookSale;
    }

    public string BookId { get => bookId; set => bookId = value; }
    public string BookName { get => bookName; set => bookName = value; }
    public double BookPrice { get => bookPrice; set => bookPrice = value; }
    public double BookSale { get => bookSale; set => bookSale = value; }
  
    public double MoneyOfBook(){
      return BookPrice - BookSale;
    }

    public override string ToString(){
      return 
      "- Mã số sách : " + BookId + "\n" +
      "- Tên sách : " + BookName + "\n" +
      "- Giá sách " + BookPrice + "\n" +
      "- Giảm giá " + BookSale + "\n";
    }
  


  }
}