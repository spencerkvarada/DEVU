using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */

            List<Course> courses = new List<Course>()
            {
                new Course() {CourseId = 1, Name = "Psychology in Film and Literature", Students = new List<Student>()
                {
                    new Student() {StudentId = 01, Name = "Russell Wilson"},
                    new Student() {StudentId = 02, Name = "Earl Thomas"}}
                },
                new Course() {CourseId = 2, Name = "Writing in Comparative Literature", Students = new List<Student>()
                {
                    new Student() {StudentId = 03, Name = "Bobby Wagner"},
                    new Student() {StudentId = 04, Name = "Doug Baldwin"}}
                },
                new Course() {CourseId = 3, Name = "Manuscript Studies", Students = new List<Student>()
                {
                    new Student() {StudentId = 05, Name = "Kam Chancellor"},
                    new Student() {StudentId = 06, Name = "Shaquill Griffin"}}
                }
            };

            foreach (var course in courses)
            {
                resultLabel.Text += String.Format("<br/><br/>Course: {0} | {1}", course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("<br/><br/> Student: {0} | {1}", student.StudentId, student.Name);
                }
            }


        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */
            Course course1 = new Course() { CourseId = 1, Name = "Psychology in Film and Literature" };
            Course course2 = new Course() { CourseId = 2, Name = "Writing in Comparative Literature" };
            Course course3 = new Course() { CourseId = 3, Name = "Manuscript Studies" };

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {01, new Student { StudentId = 01, Name = "Russell Wilson", Courses = new List<Course> { course1, course2}} },
                {02, new Student { StudentId = 02, Name = "Earl Thomas", Courses = new List<Course> { course1, course2}} },
                {03, new Student { StudentId = 03, Name = "Bobby Wagner", Courses = new List<Course> { course2, course3}} }
            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("<br/><br/>Student: {0} | {1}", student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("<br/><br/>Course: {0} | {1}", course.CourseId, course.Name);
                }
            }


        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */


            Student student = new Student();
            student.StudentId = 06;
            student.Name = "Shaquill Griffin";

            student.Grades = new List<Grade>()
            {
                new Grade { Course = new Course {CourseId=1, Name = "Psychology in Film and Literature"}, Final = 98},
                new Grade {Course = new Course {CourseId=2, Name = "Writing in Comparative Literature"}, Final = 96 }
            };
            resultLabel.Text += String.Format("<br/><br/>Student: {0} | {1}", student.StudentId, student.Name);
            foreach (var grade in student.Grades)
            {
                resultLabel.Text += String.Format("<br/><br/>Grades: {0} | Final Grade: {1}", grade.Course.Name, grade.Final);
            }

        }
    }
}