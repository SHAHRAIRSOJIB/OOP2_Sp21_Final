using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
 

            Student stu1 = new Student("191", "Akib ", 4.0F);
            Student stu2 = new Student("182", "Sakib", 3.5F);
            Student stu3 = new Student("112", "Rakib", 3.32F);
            Student stu4 = new Student("101", "Naim", 3.33F);
            Student stu5 = new Student("102", "Siam", 3.0F);
            Student stu6 = new Student("110", "Sajid", 3.55F);
            Student stu7 = new Student("122", "Rayhan", 3.55F);
            Student stu8 = new Student("001", "Ruba", 3.97F);
            Student stu9 = new Student("002", "Shahrair", 3.98F);
            Student stu10 = new Student("115", "Samuel", 3.99F);


   

            Course cr1 = new Course("CSE10", "Introduction to programming");
            Course  cr2 = new Course("CSE111", "JAVA");
            Course cr3 = new Course("CSE1001", "DATABASE ");


            

            cr1.AddStudent(stu1, stu2, stu9, stu7, stu10);
            
            cr1.PrintStudent();

            cr1.RemoveStudent(stu6);

            Console.WriteLine(" Remove Student n");

            stu6.PrintCourse();
            cr1.PrintStudent();

       

            stu3.AddCourse(cr1, cr2, cr3);
            stu3.PrintCourse();

            stu3.RemoveCourse(cr2);
            Console.WriteLine("Remove Course");
            stu3.PrintCourse();
            cr2.PrintStudent();
        }
    }
}