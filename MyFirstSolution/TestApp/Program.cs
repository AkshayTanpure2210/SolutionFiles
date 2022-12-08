
using Manager;
using OrderProcessingLib;
using CRMlib;
using Cataloglib;


Product pd1= new Product();
pd1.ProductId=01;
pd1.Title="Books";
pd1.Description="Gk Book";
pd1.StockAvailable=25;
pd1.UnitPrice= 255.85;




Product pd2= new Product();
pd2.ProductId=01;
pd2.Title="Books";
pd2.Description="Competitive exam book";
pd2.StockAvailable=50;
pd2.UnitPrice= 499;



Order o1= new Order();
o1.OrderNumber=15;
o1.OrderDate= new DateTime(2022,12,9);
o1.Customer="P.D library";
o1.TotalAmount=30000;
o1.Status="approved";


Customer c1=new Customer();
c1.CutomerId=10;
c1.FirstName= "Prasad";
c1.Lastname= "Padwal";
c1.Email="prasadpadwal25.@gmail.com";
c1.ContactDetails="9965745975";


System.Console.WriteLine(pd1.ProductId+"--"+pd1.Title  +"--"+ pd1.Description +"--"+pd1.StockAvailable+"--"+pd1.UnitPrice);
System.Console.WriteLine(pd2.ProductId+"--"+pd2.Title  +"--"+ pd1.Description +"--"+pd2.StockAvailable+"--"+pd2.UnitPrice);
System.Console.WriteLine(o1.OrderNumber+"--"+ o1.OrderDate  +"--"+ o1.Customer +"--"+o1.TotalAmount+"--"+ o1.Status);
System.Console.WriteLine(c1.CutomerId +"--"+ c1.FirstName  +"--"+c1.Lastname  +"--"+c1.Email +"--"+c1.ContactDetails);



//MySQLDBManager.CreateTable();
MySQLDBManager.Insert("Ramesh ","Yadav"," G.K Books","9966548695");
MySQLDBManager.Insert("Rahul","Jain","Stationary","8997869858");
MySQLDBManager.Insert("Yogesh ","Mule","Gk Books","9860245565");
MySQLDBManager.Insert("Ganesh ","Gade","Competitive Exam Book","8974586942");
MySQLDBManager.ShowAllCustomers();
