using System.Collections.Generic;

namespace StudentGradingSystem
{
    internal class Program
    {
        class Student
        {
            public int ID { get; set; }

            public string Name { get; set; }
            
            public List<String> EnrolledCourses { get; set; } = new List<String>();


            static void AddCourse()
            {

            }

            static void removeCourse()
            {

            }

            static void CalcAveGrade()
            {

            }

        }


        static List<Student> students = new List<Student>();
      

        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();
                string response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        AddNewStudent();
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

            static void AddNewStudent()
            {
                Student student = new Student();

                student.ID = students.Count + 1;
                student.Name = GetInput("Please enter Student Name: ");



                while (true)
                {
                    string course = GetInput("Please enter course (or type done if finished): ");

                    if (course.ToLower() == "done")
                    {
                        break;
                    }

                    student.EnrolledCourses.Add(course);
                }

                students.Add(student);

                Console.WriteLine("Student added successfully ");             
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();


                

            }



            static string GetInput(string prompt, string defualtval = "")
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                return string.IsNullOrEmpty(input) ? defualtval : input;
            }

            static double GetValidDoubleInput(string propmt, double defaultval = -1)
            {
                double val;
                Console.WriteLine(propmt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out val) && val >= 0)
                {
                    return val;
                }

                return defaultval != -1 ? defaultval : GetValidDoubleInput(propmt);

            }

            static void DisplayMenu()
            {
                Console.WriteLine("   ▄████████    ▄██████▄  ████████▄ ");
                Console.WriteLine("  ███    ███   ███    ███ ███   ▀███ ");
                Console.WriteLine("  ███    █▀    ███    █▀  ███    ███ ");
                Console.WriteLine("  ███         ▄███        ███    ███ ");
                Console.WriteLine("▀███████████ ▀▀███ ████▄  ███    ███ ");
                Console.WriteLine("        ███   ███     ███ ███    ███ ");
                Console.WriteLine("   ▄█    ███   ███    ███ ███   ▄███ ");
                Console.WriteLine("▄████████▀    ████████▀  ████████▀  ");

                Console.WriteLine("Welcome to the Student Grading System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Course");
                Console.WriteLine("3. Add Grade");
                Console.WriteLine("4. View student report");
                Console.WriteLine("5. Exit  ");
            }

        }




    }






}

