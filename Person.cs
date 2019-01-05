using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCs
{
    class Person
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public DateTime BirthDate { get; set; }
        public int BirthYear { 
            get
            {
                return BirthDate.Year;
            }
            set
            {
                BirthDate = new DateTime(value, BirthDate.Month, BirthDate.Day);
            }
        }

        public Person()
        {
            Name = "John";
            SecondName = "Jons";
            BirthDate = new DateTime(1980, 1, 1);
        }

        public Person(string NewName, string NewSecondName, DateTime NewBirthDate)
        {
            Name = NewName;
            SecondName = NewSecondName;
            BirthDate = NewBirthDate;
        }

        public virtual void PrintFullInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Second name: " + SecondName);
            Console.WriteLine("Date of birth: " + BirthDate.ToShortDateString());
        }

        //task 2
        public override bool Equals(object obj) {
            Person temp = (Person)obj;
            if(this.Name==temp.Name&& this.SecondName == temp.SecondName && this.BirthDate.Equals(temp.BirthDate))
            {
                return true;
            }
            return false;
        }
    }
}
