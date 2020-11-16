using System;


class MainClass {
  public static void Main (string[] args) {
   
    //creating a test subject  
    Console.WriteLine("Testing Faculty 1");
    Faculty f1 = new Faculty();
    f1.FirstName = "Joe";
    f1.LastName = "Schmoe";
    f1.Id = "8675309";
    f1.Title = "Instructor";
    f1.DateOfEmployement = Convert.ToDateTime("10/20/2019");
    f1.Employer = "Tri-C";
    f1.YearlySalary = 60000.42;
    f1.Tenured = false;
    
    //Method to see if I can print that info
    f1.Intro();
    f1.Display();
    
    //It works!
    f1.GrantTenure();
    f1.Display();
    
    //GrantTenure() works too!
  //creating test subjects to see if Promote() works
  
  Faculty f2 = new Faculty();
  Console.WriteLine("Testing Faculty 2");
    f2.FirstName = "Joe";
    f2.LastName = "Dirt";
    f2.Id = "90210";
    f2.Title = "Instructor";
    f2.DateOfEmployement = Convert.ToDateTime("10/20/2018");
    f2.Employer = "Tri-C";
    f2.YearlySalary = 40000.42;
    f2.Tenured = false;
    f2.Promote();
    f2.Display();
    
    
  Faculty f3 = new Faculty();
  Console.WriteLine("Testing Faculty 3");
    f3.FirstName = "Joe";
    f3.LastName = "Blow";
    f3.Id = "1800555";
    f3.Title = "Instructor";
    f3.DateOfEmployement = Convert.ToDateTime("10/20/2015");
    f3.Employer = "Tri-C";
    f3.YearlySalary = 80000.42;
    f3.Tenured = false;
    f3.Promote();
    f3.Display();

  Faculty f4 = new Faculty();
  Console.WriteLine("Testing Faculty 4");
    f4.FirstName = "Joe";
    f4.LastName = "Mama";
    f4.Id = "1134";
    f4.Title = "Instructor";
    f4.DateOfEmployement = Convert.ToDateTime("10/20/1990");
    f4.Employer = "Tri-C";
    f4.YearlySalary = 180000.42;
    f4.Tenured = false;
    f4.Promote();
    f4.Display();

    Faculty f5 = new Faculty();
  Console.WriteLine("Testing Faculty 5");
    f5.FirstName = "Joe";
    f5.LastName = "Seff";
    f5.Id = "4200";
    f5.Title = "Instructor";
    f5.DateOfEmployement = Convert.ToDateTime("10/20/1989");
    f5.Employer = "Tri-C";
    f5.YearlySalary = 1180000.42;
    f5.Tenured = false;
    f5.Promote();
    f5.Display();

  }
}
