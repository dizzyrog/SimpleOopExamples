namespace SchoolSystem.Models;

public class Course
{
    public string CourseName { get; set; }
    public Teacher Teacher { get; set; }

    public Course(string name, Teacher teacher)
    {
        CourseName = name;
        Teacher = teacher;
    }
}