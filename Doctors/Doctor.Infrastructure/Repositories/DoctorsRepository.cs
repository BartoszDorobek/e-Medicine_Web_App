namespace Doctors.Infrastructure
{
    using Doctors.Domain;
    using Doctors.Domain.DoctorAggregate;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DoctorsRepository : IDoctorsRepository
    {
        private static readonly Doctor[] doctors = new Doctor[]
        {
            new Doctor(1, "John","Smith", new List<Specialisation>{ new Specialisation(1, DateTime.UtcNow, 1)}),
            new Doctor(2, "Jacob","Jones"),
            new Doctor(3, "Lianah","Williams", new List<Specialisation>{new Specialisation(2, DateTime.UtcNow, 5),new Specialisation(3, DateTime.UtcNow, 7)}),
            new Doctor(4, "Michael","Taylor", new List<Specialisation>{ new Specialisation(4, DateTime.UtcNow, 6),new Specialisation(5, DateTime.UtcNow, 3),new Specialisation(6, DateTime.UtcNow, 5)}),
            new Doctor(5, "Robert","Davies", new List<Specialisation>{ new Specialisation(7, DateTime.UtcNow, 3),new Specialisation(8, DateTime.UtcNow, 2)}),
            new Doctor(6, "Artur","Brown", new List<Specialisation>{ new Specialisation(9, DateTime.UtcNow, 2),new Specialisation(10, DateTime.UtcNow, 1),new Specialisation(11, DateTime.UtcNow, 5)}),
            new Doctor(7, "Bob","Wilson", new List<Specialisation>{ new Specialisation(12, DateTime.UtcNow, 5)}),
            new Doctor(8, "Kate","Johnson", new List<Specialisation>{ new Specialisation(13, DateTime.UtcNow, 12)}),
            new Doctor(9, "Barbara","Lewis", new List<Specialisation>{ new Specialisation(14, DateTime.UtcNow, 7),new Specialisation(15, DateTime.UtcNow, 6),new Specialisation(16, DateTime.UtcNow, 5)}),
            new Doctor(10, "Dominic","Green", new List<Specialisation>{ new Specialisation(17, DateTime.UtcNow, 9),new Specialisation(18, DateTime.UtcNow, 7),new Specialisation(19, DateTime.UtcNow, 8)}),
            new Doctor(11, "Sam","Hall", new List<Specialisation>{ new Specialisation(20, DateTime.UtcNow, 10),new Specialisation(21, DateTime.UtcNow, 1)}),
            new Doctor(12, "Samanta","Clarke", new List<Specialisation>{ new Specialisation(22, DateTime.UtcNow, 1)}),
            new Doctor(13, "Brad","Jackson", new List<Specialisation>{ new Specialisation(23, DateTime.UtcNow, 4)}),
            new Doctor(14, "Kurt","Allen", new List<Specialisation>{ new Specialisation(24, DateTime.UtcNow, 7),new Specialisation(25, DateTime.UtcNow, 6)}),
            new Doctor(15, "Victoria","Bennet", new List<Specialisation>{ new Specialisation(26, DateTime.UtcNow, 6),new Specialisation(27, DateTime.UtcNow, 5)}),
            new Doctor(16, "Simon","Cooper", new List<Specialisation>{ new Specialisation(28, DateTime.UtcNow, 5),new Specialisation(29, DateTime.UtcNow, 4)}),
            new Doctor(17, "Bartholomew","Wood", new List<Specialisation>{ new Specialisation(30, DateTime.UtcNow, 5),new Specialisation(31, DateTime.UtcNow, 3)}),
            new Doctor(18, "Mathew","Baker", new List<Specialisation>{ new Specialisation(32, DateTime.UtcNow, 8),new Specialisation(33, DateTime.UtcNow, 1),new Specialisation(34, DateTime.UtcNow, 2)}),
            new Doctor(19, "Marcin","Mehldau"),
            new Doctor(20, "Agata","Elling", new List<Specialisation>{ new Specialisation(35, DateTime.UtcNow, 10)})
        };

        public IEnumerable<Doctor> GetAll()
        {
            return doctors;
        }

        public IEnumerable<Doctor> GetBySpecialisationType(int specialistaionType)
        {
            return doctors?.Where(ld => ld.Specialisations.Any(s => s.Type == specialistaionType));
        }
    }
}
