using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCs
{
    class Student : Person, ICloneable
    {
        public enum Education
        {
            Master,
            Bachelor,
            SecondEducation,
            PhD
        }
        public Education StudentEducation { get; set; }
        public string Group { get; set; }
        public int NumOfRecordBook { get; set; }
        public List<Examination> ExamsList = new List<Examination>();
        public double AverageMark
        {
            get
            {
                double sum = 0;
                int num = ExamsList.Count();
                foreach (Examination ex in ExamsList)
                {
                    sum += (double)ex.Mark;
                }
                return sum / num;
            }
        }

        public void AddExams(Examination[] examList)
        {
            ExamsList.AddRange(examList);
        }

        public override string ToString()
        {
            return "Name: " + Name + "; Second name: " + SecondName + "; Group: " + Group;
        }

        public override void PrintFullInfo()
        {
            Console.WriteLine("Name: " + Name + "; ");
            Console.WriteLine("Seconf name: " + SecondName + "; ");
            Console.WriteLine("Date of birth: " + BirthDate.ToShortDateString() + "; ");
            Console.WriteLine("Type of diploma: " + StudentEducation + "; ");
            Console.WriteLine("Group: " + Group + "; ");
            Console.WriteLine("Number of record book: " + NumOfRecordBook + "; ");
            Console.WriteLine("Exams: ");
            if (ExamsList.Count == 0)
            {
                Console.WriteLine("Student didn`t pass exams");
            }
            else
            {
                foreach (Examination i in ExamsList)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Average mark: " + AverageMark);
        }

        //Task 9
        public System.Collections.IEnumerable GetTestsWithoutExams()
        {
            foreach (Examination exam in ExamsList)
            {
                if (!exam.IsDiff)
                {
                    yield return exam;
                }
            }
            yield break;
        }

        //Task 12
        public Examination[] GetSorted()
        {
            IEnumerable< Examination> OrderedList = ExamsList.OrderBy(exam => exam.Subject);
            return OrderedList.ToArray();
        }

        //task 1
        public object Clone()
        {
            Student clone = new Student();
            clone.Name = this.Name;
            clone.SecondName = this.SecondName;
            clone.BirthDate = this.BirthDate;
            clone.StudentEducation = this.StudentEducation;
            clone.Group = this.Group;
            clone.NumOfRecordBook = this.NumOfRecordBook;
            foreach (Examination ex in this.ExamsList)
            {
                clone.ExamsList.Add(ex);
            }
            return clone;
        }
    }   
}
