namespace SchoolSystem.Models;

public class Student : Person
{
    private readonly Enrollment[] enrollments;
    private int enrollmentCount;

    public Student(string name, int age, int maxCourses) : base(name, age)
    {
        enrollments = new Enrollment[maxCourses];
        enrollmentCount = 0;
    }

    public void EnrollInCourse(Course course, char grade)
    {
        if (enrollmentCount < enrollments.Length)
        {
            enrollments[enrollmentCount++] = new Enrollment(course, grade);
        }
        else
        {
            Console.WriteLine("Maximum number of courses reached.");
        }
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Student: {Name}, Age: {Age}");
        foreach (var enrollment in enrollments)
        {
            if (enrollment != null)
            {
                Console.WriteLine($"  Enrolled in: {enrollment.Course.CourseName}, Grade: {enrollment.Grade}");
            }
        }
    }
}