namespace ExaminationRoomsSelector.Web.Application.Dtos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DoctorRoomDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<string> Specialisations { get; set; }
        public string Number { get; set; }
        public IEnumerable<string> Certifications { get; set; }
    }
}
