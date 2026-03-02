namespace knightmoves;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }


    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class Party
{
  
    public static Person[] Guests = new Person[]
    {
        new Person("John", "Doe"),    
        new Person("Jane", "Smith"),   
        new Person("Bob", "Johnson")  
    };
}
