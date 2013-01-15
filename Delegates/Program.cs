using System;

namespace Delegates
{
    /// <summary>
    /// delegate is a type, a pointer to a function, or a pointer to a set of functions
    /// </summary>
    delegate void Learn();

    /// <summary>
    /// Students that are eager to learn interesting facts.
    /// </summary>
    class Student
    {
        private Learn toStudyDelegate;

        public void AttendToCourse(ProgrammingCourse course)
        {
            /*Instead of just learning and calling: course.StudyFirstChapter()
             * every lazy student will postpone this job and will add it to "toStudyDelegate" */
            toStudyDelegate += course.StudyFirstChapter;
        }

        public void StartLearningBecauseExamIsTomorrow()
        {
            toStudyDelegate();
        }
    }

    /// <summary>
    /// Beginners programming course in C#
    /// </summary>
    class ProgrammingCourse
    {
        public void StudyFirstChapter()
        {
            Console.WriteLine("A delegate is a type that can hold a reference to a set of functions");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type is declared when delegate keyword is used?");
            Console.WriteLine(typeof(Learn).BaseType.ToString());

            Console.WriteLine();

            Student student = new Student();
            ProgrammingCourse course = new ProgrammingCourse();
            student.AttendToCourse(course);
            
            //After a long time student will call
            student.StartLearningBecauseExamIsTomorrow();

            Console.Read();
        }
    }
}
