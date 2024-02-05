using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brush2
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }


        public override string ToString()
        {
            return $"{Id} + {Name} + {Salary}";
        }

        public void ValidateName()
        {
            if (Name == null)
                throw new ArgumentNullException("Name is null");

            if (Name.Length < 1)
                throw new ArgumentException("Name must be at least 1 character");
        }

        public void ValidateSalary()
        {
            if (Salary < 0)
                throw new ArgumentOutOfRangeException("Salary must be non-negative.");
        }

        public void Validate()
        {
            ValidateName();
            ValidateSalary();
        }
    }
}
