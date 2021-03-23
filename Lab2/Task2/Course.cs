using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Course
    {
        public static int StudentLimit = 30;
        private Student[] students;

       
        public string Id { set; get; }

        public string Name { set; get; }

        public int StudentCount { set; get; }
        public Course()
        {
            students = new Student[30];
        }

        public Course(string id, string name)
        {
            Id = id;
            Name = name;
            students = new Student[30];
        }


        public void AddStudent(params Student[] students)
        {
            foreach (Student student  in students)
            {
                if (this.StudentCount <30 && student.CourseCount < 30)
                {
                    this.students[this.StudentCount++] = student;
                    if (student.GetCourse(this.Id) == null)
                        student.AddCourse(this);
                }
            }
        }

        public void RemoveStudent(Student s)
        {
            
        }

        public Student GetStudent(string id)
        {
            for (int i = 0; i < this.StudentCount; ++i)
                if (id == this.students[i].Id)
                    return this.students[i];

            return null;
        }

        public void PrintStudent()
        {
            for (int i = 0; i < this.StudentCount; ++i)
            {
                this.students[i].ShowInfo();
            }
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: ", Name);
            Console.WriteLine("Course ID:  ", Id);
        }
    }
}