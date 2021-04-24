namespace Doctors.Web.Application
{
    using Doctors.Domain.DoctorAggregate;
    using Doctors.Web.Application.Mapper;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DoctorQueriesHandler : IDoctorQueriesHandler
    {
        private readonly IDoctorsRepository doctorsRepository;

        public DoctorQueriesHandler(IDoctorsRepository doctorsRepository)
        {
            this.doctorsRepository = doctorsRepository;
        }

       

        IEnumerable<DoctorDto> IDoctorQueriesHandler.GetAll()
        {
            return doctorsRepository.GetAll().Select(r => r.Map());
        }

        IEnumerable<DoctorDto> IDoctorQueriesHandler.GetBySpecialisationType(int specialisationType)
        {
            return doctorsRepository.GetBySpecialisationType(specialisationType)?.Select(ld => ld.Map());
        }
    }
}
