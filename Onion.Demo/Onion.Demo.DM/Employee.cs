using System;
using System.Linq;

namespace Onion.Demo.DM
{
    public class Employee
    {
        public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Surname { get; set; }

        public virtual string Patronymic { get; set; }

        public virtual double Salary { get; set; }

        public virtual bool IsInStaff { get; set; }

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
