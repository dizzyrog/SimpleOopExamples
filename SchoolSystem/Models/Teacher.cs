namespace SchoolSystem.Models;

public class Teacher(string name, int age, string subject) : Person(name, age)
{
    public string Subject { get; set; } = subject;

    public override void DisplayInfo()
    {
        Console.WriteLine($"Teacher: {Name}, Age: {Age}, Subject: {Subject}");
    }
}