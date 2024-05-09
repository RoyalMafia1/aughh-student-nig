using ClassLibrarylol;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kapseldamine");

            Student student = new Student();

            student.Id = 101;
            student.Name = "Test";
            student.Email = "arvikadak@gmail.com";

            Console.WriteLine("Id = " + student.Id);
            Console.WriteLine("Name = " + student.Name);
            Console.WriteLine("Email = " + student.Email);


            ProtectedStudent protectedStudent = new ProtectedStudent();
            //protectedStudent.DoSomething();
            Console.WriteLine("---------------------------------");
            Program program = new Program();
            program.DoSometingInProgramClass();

            Console.WriteLine("-----------Private Protected----------");.
            Program pp = new Program();
            Console.WriteLine(pp.privateProtectedInProgramClass =
                "privateProtectedInProgramClassMethod");

            var privateProtectedStudent = new PrivateProtectedStudent();
            //privateProtectedStudent.PrivateProtectedStudent1 = "asdasdasd";
            Console.WriteLine("--------Sealed Class--------");
            var sc = new SealedStudent();
            sc.Id = 123;
            sc.Name = "Test";
            sc.Email = "arvikadak@gmail.com";
            Console.WriteLine($"Id on {sc.Id}, Name on {sc.Name} ja Email on {sc.Email}" );


        }

        protected void DoSometingInProgramClass()
        {
            Console.WriteLine("DoSomethingInProgramClass");
        }

        private protected string privateProtectedInProgramClass =
            "privateProtectedInProgramClass";
    }
}
