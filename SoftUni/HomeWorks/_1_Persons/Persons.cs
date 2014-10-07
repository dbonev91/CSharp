using System;
using System.Linq;

class Persons
{
    private string name;
    private int age;
    private string email;
    public Persons(string name, int age)
    {
        if (age < 0 || age > 100)
        {
            throw new ArgumentOutOfRangeException("Your age must be between 0 and 100!");
        }
        else
        {
            this.age = age;
        }
        this.name = name;
        Console.WriteLine("Name: {0}, Age: {1}", this.name, this.age);
    }
    public Persons(string name, int age, string email="@")
    {
        if(age < 0 || age > 100){
            throw new ArgumentOutOfRangeException("Your age must be between 0 and 100!");
        }
        else
        {
            this.age = age;
        }
        if(email!=null){
            if (email.ToLowerInvariant().Contains('@'))
            {
                this.email = email;
            }
        }
        else
        {
            this.email = email;
        }
        this.email = email;
        this.name=name;
        Console.WriteLine("Name: {0}, Age: {1}, Email: {2}", this.name, this.age, this.email);
    }
    static void Main()
    {
        string getName = Console.ReadLine();
        int getAge = int.Parse(Console.ReadLine());
        string getMail = Console.ReadLine();
        Persons pers;
        pers = new Persons(getName, getAge);
        pers = new Persons(getName, getAge, getMail);
    }
}
