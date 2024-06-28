using System.Collections;

namespace OopsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //Student student;
            //student = new Student();
            //Student student = new Student();
            //// new keyword
            //// 1. It allocates memory on heap
            //// 2. it calls constructor (default) to initialize member variables
            //student.GetDetails();
            //student.DisplayDetails();

            //Console.WriteLine("studnet 1");
            //// Take 2 students
            //Student student1 = new Student();
            //student1 .GetDetails();
            //student1.DisplayDetails();

            //Console.WriteLine("student 2");
            //Student student2 = new Student();
            //student2.GetDetails();
            //student2.DisplayDetails();

            ////Take details of 10 Students
            //// array of objects

            //Student[] students = new Student[10];

            //for (int i = 0; i < 3; i++)
            //{
            //    students[i] = new Student();
            //    Console.WriteLine("ENter details of student " + (i+1));
            //    students[i].GetDetails();
            //}
            //Console.WriteLine("Details of Students");
            //foreach (Student temp in students)
            //{
            //    if(temp != null)
            //    temp.DisplayDetails();
            //}

            //Collection

            //ArrayList list = new ArrayList();
            //Student student1 = new Student();
            //student1.GetDetails();
            //list.Add(student1);

            //Student student2 = new Student();
            //student2.GetDetails();
            //list.Add(student2);

            //foreach (Student student in list)
            //{
            //    student.DisplayDetails();
            //}

            //list.Add(1);
            //list.Add("aaa");

            List<Student> students = new List<Student>();
            Student student1 = new Student();
            student1.GetDetails();
            students.Add(student1);

            Student student2 = new Student();
            student2.GetDetails();
            students.Add(student2);

            foreach (Student student in students)
            {
                student.DisplayDetails();
            }
           
        }
    }
}
