namespace StudentGradingSystem
{
    internal class Program
    {
        class Student
        {
            public string Name { get; set; }
            public int ID { get; set; }
            public string Course { get; set; }

        }


        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();

            

            

            while (true)
            {
                DisplayMeu();
                string response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        Console.WriteLine("what");
                        break;

                    case "2":
                        Console.WriteLine("what");
                        break;

                    case "3":
                        Console.WriteLine("what");
                        break;

                    case "4":
                        Console.WriteLine("what");
                        break;

                    case "5":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }



        }



        static void DisplayMeu()
        {
            Console.WriteLine("   ▄████████    ▄██████▄  ████████▄ ");
            Console.WriteLine("  ███    ███   ███    ███ ███   ▀███ ");
            Console.WriteLine("  ███    █▀    ███    █▀  ███    ███ ");
            Console.WriteLine("  ███         ▄███        ███    ███ ");
            Console.WriteLine("▀███████████ ▀▀███ ████▄  ███    ███ ");
            Console.WriteLine("        ███   ███     ███ ███    ███ ");
            Console.WriteLine("   ▄█    ███   ███    ███ ███   ▄███ ");
            Console.WriteLine("▄████████▀    ████████▀  ████████▀  ");
             
            Console.WriteLine("Welcome to the student grading system");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Course");
            Console.WriteLine("3. Add Grade");
            Console.WriteLine("4. View student report");
            Console.WriteLine("5. Exit  ");
        }
    }

   


   

}

