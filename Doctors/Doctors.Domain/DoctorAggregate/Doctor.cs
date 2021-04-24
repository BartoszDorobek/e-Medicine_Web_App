namespace Doctors.Domain.DoctorAggregate
{
    using Doctors.Domain.SeedWork;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Doctor : Entity
    {
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public IList<Specialisation> Specialisations { get; private set; } = new List<Specialisation>();

        public Doctor(int id, string firstName, string lastName) : base(id)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public Doctor(int id, string firstName, string lastName, IList<Specialisation> specialisations) : this(id, firstName, lastName)
        {
            Specialisations = specialisations;
        }

        public void AddProfession(Specialisation specialisation)
        {
            Specialisations.Add(specialisation);
        }
    }
}
