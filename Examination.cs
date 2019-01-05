using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCs
{
    class Examination
    {
        public int SemesterNum { get; private set; }
        public string Subject { get; private set; }
        public string Teacher { get; private set; }
        public int Mark { get; private set; }
        public bool IsDiff { get; private set; }
        public DateTime ExaminationDate { get; private set; }

        public Examination()
        {
            SemesterNum = 1;
            Subject = "Computer architecture";
            Teacher = "Jons J. J.";
            Mark = 60;
            IsDiff = true;
            ExaminationDate = new DateTime(2000, 1, 9);
        }

        public Examination(int NewNumber, string NewSubj, string NewTeacher, int NewMark, bool NewIsDiff, DateTime newDate)
        {
            SemesterNum = NewNumber;
            Subject = NewSubj;
            Teacher = NewTeacher;
            Mark = NewMark;
            IsDiff = NewIsDiff;
            ExaminationDate = newDate;
        }

        public override string ToString()
        {
            return "Name of subject: " + Subject + "; Teacher: " +Teacher + "; Mark: " + Mark;
        }
    }
}
