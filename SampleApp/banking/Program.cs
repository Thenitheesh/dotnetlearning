using bankingSystem;
using bankingSystem.Handlers;

Account acct123 = new Account();
acct123.Deposit(15000);
acct123.Withdraw(5000);

Console.WriteLine("Hello, World!");
//Direct Call
AccountListener.BlockAccount();
AccountListener.SendEmail();



//Multicasting
AccountOperation agent = new AccountOperation(AccountListener.BlockAccount);
agent += AccountListener.SendEmail;
agent(); 
//indirect call to all methods which are registered
