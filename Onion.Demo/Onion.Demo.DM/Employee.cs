using System;
using System.Linq;

namespace Onion.Demo.DM
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public double Salary { get; set; }

        public bool IsInStaff { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Surname) ||
                string.IsNullOrEmpty(Name) ||
                string.IsNullOrEmpty(Patronymic))
            {
                return "No Name";
            }

            return string.Format("{0} {1}.{2}.", Surname, Name.First(), Patronymic.First());
        }
    }
}
