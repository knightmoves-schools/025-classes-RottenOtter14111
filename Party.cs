namespace knightmoves;
public class Party
{
    public Person[] Guests = new Person[]
    {
        new Person("John", "Doe"),
        new Person("Jane", "Smith"),
        new Person("Bob", "Johnson")
    };
}

public class Person
{
    public string FirstName { get; }
    public string LastName { get; }

    public Person(string FirstName, string LastName)
    {
        FirstName = firstName;
        LastName = lastName
    }
}


