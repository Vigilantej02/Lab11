using System;

class Faculty : Person {
 

  public string Id { get; set; }
  public string Title { get; set; }
  public virtual DateTime DateOfEmployement { get; set; }
  public string Employer { get; set; }
  public double YearlySalary { get; set; }
  public bool Tenured { get; set; }

  public Faculty()
  {
    string Title = "Instructor";
  }
  public void Falculty(string fname, string lname)
  {
    FirstName = fname;
    LastName = lname;
    string Title = "Instructor";
  }
  //looks a bit wonky. What are the conventions here for making cleaner code?
  public bool GrantTenure()
  { 
    if (DateTime.Today.Year - DateOfEmployement.Year <= 5)
    {return Tenured;}
    else {return Tenured = true;}
  }
  public string Promote()
  { if (DateTime.Today.Year - DateOfEmployement.Year > 2)
  {
    Title = "Assistant Professor";
    Console.WriteLine("Faculty promoted to Assistant Professor rank");
  }
  else if (DateTime.Today.Year - DateOfEmployement.Year >= 5)
  {
  Title = "Associate Professor";
  Console.WriteLine("Faculty promoted to Associate Professor rank");
  }
  else if (DateTime.Today.Year - DateOfEmployement.Year >= 10)
  {
    Title = "Professor";
    Console.WriteLine("Faculty promoted to Professor rank");
  }
  else if (Title == "Professor")
  {
    Console.WriteLine("No more promotion possible");
  };
    return Title;
  }
  
  //This method is so I can test to see if the informaton is actually being passed to where it's supposed to be
  public void Display()
  {
    Console.WriteLine("Hi my nane is " + FirstName + " " + LastName);
    Console.WriteLine("My ID is: " + Id);
    Console.WriteLine("My Title is: " + Title);
    Console.WriteLine("I began working here on " + DateOfEmployement);
    Console.WriteLine("I work for " + Employer);
    Console.WriteLine("I make $" + YearlySalary + " a year");
    Console.WriteLine("Am I Tenured? " + Tenured);
  }
  //Alright, Everything else works perfectly, but I get an error using DateOfEmployment in my overridden intro method. Weird.
  public override void Intro()
  {
    base.Intro();
    Console.WriteLine("Hi! I work as a(n) " + Title + " at " + Employer + " since " + DateOfEmployment);
  }
  
}