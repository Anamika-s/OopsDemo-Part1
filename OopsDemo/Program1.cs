using System.Collections;

namespace OopsDemoWithCon
{
    internal class Program1
    {
        static void Main(string[] args)
        {

            //Student.batch = "B001";
            //Console.WriteLine(Student.batch);
            Console.WriteLine("Compnay name i s" + Student.company); ;
            Student.BatchDetails();

            Student student = new Student(); // invokes def const
            student.GetDetails();
            student.DisplayDetails();
            Student student1 = new Student("deepak"); // invoke para const
            student1.DisplayDetails();

            Student student2 = new Student(2, "ajay"); // invoke para const
            student2.DisplayDetails();

            Student student3= new Student(3,"ajay", "b001", 90);// invokes para const
            student3.DisplayDetails();

            //this calls copy const
            Student student4 = new Student(student3);
            student4.DisplayDetails();
        }
    }
}
