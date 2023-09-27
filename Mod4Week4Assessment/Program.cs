using System;
using System.Collections.Generic;

public class User
{
    public string Name { get; private set; }
    public List<string> Programs { get; private set; }
    public DateTime Birthday { get; private set; }

    public User(string name, List<string> programs, DateTime birthday)
    {
        Name = name;
        Programs = programs;
        Birthday = birthday;
    }

    public string GetGreeting()
    {
        return $"Hello, I'm {Name}, a participate in these programs: {String.Join(", ", Programs)}!";
    }

    public string GetBirthday()
    {
        return $"{Name}'s birthday is on {Birthday:MMMM d, yyyy}";
    }
}

public class Librarian
{
    public string Name { get; private set; }
    public DateTime Birthday { get; private set; }
    public string Subject { get; private set; }

    public Librarian(string name, string subject, DateTime birthday)
    {
        Name = name;
        Birthday = birthday;
        Subject = subject;
    }

    public string GetGreeting()
    {
        return $"Hello, I'm {Name}, a {Subject} librarian!";
    }

    public string GetBirthday()
    {
        return $"{Name}'s birthday is on {Birthday:MMMM d, yyyy}";
    }
}

// Create a library class that uses dependency injection by taking in a list of people.
public class Library { }

public class Program
{
    public static void Main(string[] args)
    {
        //// Your solution should make the following code run without errors!

        //// Step 1:
        //// Creating instances of User and Librarian
        //User userAlice = new User("Alice", new List<string>() {"young adult readers", "mathletes" }, new DateTime(2007, 1, 20));
        //User userEthan = new User("Ethan", new List<string>() {"mathletes"}, new DateTime(2005, 3, 10));
        //Librarian librarianJohnson = new Librarian("Mrs. Johnson", "Math", new DateTime(1980, 12, 10));

        //// Creating a list of people
        //List<Person> people = new List<Person> { userAlice, userEthan, librarianJohnson };

        //// Step 2:
        //// Using dependency injection to create a Library instance
        //Library library = new Library(people);

        //// List all birthdays
        //library.ListBirthdays();
    }
}
