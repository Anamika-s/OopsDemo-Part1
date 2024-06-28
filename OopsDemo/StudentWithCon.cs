using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemoWithCon
{
       class Student
    {
        readonly int rn;   // readonly variable
        string name;  // instance variable
        static string batch;  // static variable
        int score;   // instance variable
        public const string company="Wipro"; // constant variable
        // def constructor
        public Student()
        {
            
        }
        // para const
        public Student(string name)
        {
            this.name = name;
            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine());
            //Console.WriteLine("enter batch");
            //batch = Console.ReadLine();
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());

        }
        //para const
        public Student(int rn, string name)
        {
            this.rn = rn;
            this.name = name;
            //Console.WriteLine("enter batch");
            //batch = Console.ReadLine();
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());
             

        }

        // fully para constr
        public Student(int rn, string name, string batch, int score)
        {
            this.name = name;
            this.rn = rn;
            //this.batch = batch;
            this.score = score;

        }

        // static const is used to initialize static variables
        static Student()
        {
            batch = "B001";
        }

        public Student(Student obj)
        {
            
            this.name = obj.name;
            this.score = obj.score;
            Console.WriteLine("enter rn");
            rn = byte.Parse(Console.ReadLine());

        }

        public void GetDetails()
        {
            //Console.WriteLine("enter rn");
            //rn = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            //Console.WriteLine("enter batch");
            //batch = Console.ReadLine();
            Console.WriteLine("enter score");
            score = byte.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Rn is {rn}");
            Console.WriteLine($"Name is {name}");
            //Console.WriteLine($"Batch is {batch}");
            Console.WriteLine($"Score is {score}");
        }

        
        public static void BatchDetails()
        {
            //batch = "B001";
            Console.WriteLine("batch is " + batch);
        }
    }
}
