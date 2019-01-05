using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCs
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab, made by Olesya Pashko, IP-72");
            Student stud = new Student();
            stud.Name = "Olesya";
            stud.SecondName = "Pashko";
            stud.BirthDate = new DateTime(2000, 10, 7);
            stud.StudentEducation = Student.Education.Bachelor;
            stud.Group = "IP-72";
            stud.NumOfRecordBook = 7223;

            Console.WriteLine("Student information");
            Console.WriteLine(stud);
            Console.WriteLine();

            Console.WriteLine("Add exams");
            Examination[] exList = new Examination[4] {
                new Examination(1, "Programming Fundations", "Bell J.S.", 70, true, new DateTime(2018, 1, 18)),
                new Examination(1, "Data Structures", "Abbey M.K.", 78, true, new DateTime(2018, 1, 20)),
                new Examination(2, "Web Programming", "Adin М.О.", 89, false, new DateTime(2018, 6, 18)),
                new Examination(2, "Operating Systems", "Armstead I.N.", 100, false, new DateTime(2018, 6, 22))
            };
            stud.AddExams(exList);

            Console.WriteLine(stud);
            Console.WriteLine();
            stud.PrintFullInfo();
            Console.WriteLine();
            Console.WriteLine("===========================================================");
            Console.WriteLine("Task number 1");
            Console.WriteLine();
            Student stud2 = (Student)stud.Clone();
            stud.BirthYear = 2222;
            stud.Name = "Olya";
            Console.WriteLine();
            Console.WriteLine("First student with changes");
            stud.PrintFullInfo();
            Console.WriteLine();
            Console.WriteLine("Clone of first student");
            stud2.PrintFullInfo();
            Console.WriteLine();

            Console.WriteLine("===========================================================");
            Console.WriteLine("Task number 2");
            Console.WriteLine("Is first student equals to second? ");
            Console.WriteLine(stud.Equals(stud2));
            Student stud3 = (Student)stud.Clone();
            Console.WriteLine("Is first student equals to copy? ");
            Console.WriteLine(stud.Equals(stud3));

            Console.WriteLine("===========================================================");
            Console.WriteLine("Task number 9");
            Console.WriteLine("All test, that isn`t exams:");
            foreach (Examination i in stud.GetTestsWithoutExams())
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("===========================================================");
            Console.WriteLine("Task number 12");
            Examination[] sortedExams = stud.GetSorted();
            Console.WriteLine("Exams, that are sorted by subject:");
            foreach (Examination i in sortedExams)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
