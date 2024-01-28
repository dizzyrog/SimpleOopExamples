using SchoolSystem.Models;

Student student1 = new Student("Alice", 16, 5);
Student student2 = new Student("Bob", 15, 5);
Teacher mathTeacher = new Teacher("Mr. Smith", 40, "Math");
Teacher scienceTeacher = new Teacher("Mrs. K", 35, "Science");

Course mathCourse = new Course("Math 101", mathTeacher);
Course scienceCourse = new Course("Science",scienceTeacher );

student1.DisplayInfo();
student2.DisplayInfo();

mathTeacher.DisplayInfo();
scienceTeacher.DisplayInfo();

student1.EnrollInCourse(mathCourse, 'A');
student1.EnrollInCourse(scienceCourse, 'B');

student2.EnrollInCourse(scienceCourse, 'C');

student1.DisplayInfo();
student2.DisplayInfo();