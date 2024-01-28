namespace SchoolSystem.Models;

public class Enrollment
{
    public Course Course { get; }
    public char Grade { get; }

    public Enrollment(Course course, char grade)
    {
        Course = course;
        Grade = grade;
    }
}