// Encapsulation - hiding of sensitive data from the users
// Achived by making fields private
// and use public properties to access the private field

// More on Encapsulation:
// Expose only the fields that needs to be exposed
// Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)

class Person
{
    private string name; // field
    public string Name   // property
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
    }
}

// Output:
// Liam
