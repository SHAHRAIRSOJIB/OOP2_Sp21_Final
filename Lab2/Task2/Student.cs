using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {

        public static int CourseLimit = 5;
        private Course[] courses;

       
        public string Id { set; get; }

        public string Name { set; get; }

        public float Cgpa { set; get; }

        public int CourseCount { set; get; }
   
        public Student()
        {
            this.courses = new Course[5];
        }

        public Student(string id, string name, float cgpa)
        {
            this.Id = id;
            this.Name = name;
            this.Cgpa = cgpa;
            this.courses = new Course[5];
        }
        public void AddCourse(params Course[] courses)
        {
            foreach (Course course in courses)
            {
                courses[CourseCount++] = course;
                if (course.GetStudent(Id) == null)
                    course.AddStudent(this);
            }
        }
        public void RemoveCourse(Course c)
        {
          
        }


        public Course GetCourse(string id)
        {
            for (int i = 0; i < this.CourseCount; ++i)
                if (id == this.courses[i].Id)
                    return this.courses[i];

            return null;
        }

        public void PrintCourse()
        {
            for (int i = 0; i < this.CourseCount; ++i)
            {
                this.courses[i].ShowCourseInfo();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name:", Name);
            Console.WriteLine("ID: ", Id);
            Console.WriteLine("CGPA: ", Cgpa);
        }
    }
}