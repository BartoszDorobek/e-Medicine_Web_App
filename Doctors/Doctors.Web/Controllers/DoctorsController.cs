namespace Doctors.Web.Controllers
{
    using Doctors.Domain;
    using Doctors.Domain.DoctorAggregate;
    using Doctors.Web.Application;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly ILogger<DoctorsController> logger;
        private readonly IDoctorQueriesHandler doctorQueriesHandler;

        public DoctorsController(ILogger<DoctorsController> logger, IDoctorQueriesHandler doctorQueriesHandler)
        {
            this.logger = logger;
            this.doctorQueriesHandler = doctorQueriesHandler;
        }

        [HttpGet("doctors")]
        public IEnumerable<DoctorDto> GetAll()
        {
            return doctorQueriesHandler.GetAll();
        }

        [HttpGet("doctor")]
        public IEnumerable<DoctorDto> GetBySpecialisation([FromQuery] int specialisationType)
        {
            return doctorQueriesHandler.GetBySpecialisationType(specialisationType);
        }
    }
}
