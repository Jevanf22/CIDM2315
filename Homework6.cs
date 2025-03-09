namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Professor professor1 = new Professor("Alice", "Java", 9000);
            Professor professor2 = new Professor("Bob", "Math", 8000);

            
            Student student1 = new Student("Lisa", "Java", 90);
            Student student2 = new Student("Tom", "Math", 80);

            
            Console.WriteLine("Professor Details:");
            Console.WriteLine($"Name: {professor1.Name}, Class: {professor1.Class}, Salary: {professor1.Salary}");
            Console.WriteLine($"Name: {professor2.Name}, Class: {professor2.Class}, Salary: {professor2.Salary}");
            Console.WriteLine();

            
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Name: {student1.Name}, Class: {student1.Class}, Grade: {student1.Grade}");
            Console.WriteLine($"Name: {student2.Name}, Class: {student2.Class}, Grade: {student2.Grade}");
            Console.WriteLine();

            
            int salaryDifference = professor1.Salary - professor2.Salary;
            Console.WriteLine($"Salary Difference between {professor1.Name} and {professor2.Name}: {salaryDifference}");

            
            int totalGrade = student1.Grade + student2.Grade;
            Console.WriteLine($"Total grade for Lisa’s Java course and Tom’s Math course: {totalGrade}");
        }
    }

    
    class Professor
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Salary { get; set; }

        
        public Professor(string name, string className, int salary)
        {
            Name = name;
            Class = className;
            Salary = salary;
        }
    }

    
    class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Grade { get; set; }

        
        public Student(string name, string className, int grade)
        {
            Name = name;
            Class = className;
            Grade = grade;
        }
    }
}

