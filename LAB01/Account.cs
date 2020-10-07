using System;

namespace LAB01
{
    class Account
    {
      private string accountId;
      private int money;

    public Account(string accountId, int money)
    {
      this.accountId = accountId;
      this.money = money;
    }

    public string AccountId { get => accountId; set => accountId = value; }
    public int Money { get => money; set => money = value; }

    public override string ToString(){
      return 
     
      "- Mã số tài khoản: " + AccountId + "\n" +
      "- Số tiền: " + Money + "\n";
    }
  

  }
}
