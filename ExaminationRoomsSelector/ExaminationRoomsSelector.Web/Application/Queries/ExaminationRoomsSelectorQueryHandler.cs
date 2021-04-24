namespace ExaminationRoomsSelector.Web.Application.Queries
{
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using ExaminationRoomsSelector.Web.Application.DataServiceClients;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ExaminationRoomsSelectorQueryHandler : IExaminationRoomsSelectorHandler
    {
        private readonly IExaminationRoomsServiceClient examinationRoomsServiceClient;
        private readonly IDoctorsServiceClient doctorsServiceClient;

        public ExaminationRoomsSelectorQueryHandler(IExaminationRoomsServiceClient examinationRoomsServiceClient, IDoctorsServiceClient doctorsServiceClient)
        {
            this.examinationRoomsServiceClient = examinationRoomsServiceClient;
            this.doctorsServiceClient = doctorsServiceClient;
        }

        public async Task<int> GetExaminationRoomsSelectionAsync()
        {
            var doctors = doctorsServiceClient.GetAllDoctorsAsync();

            return (await examinationRoomsServiceClient.GetAllExaminationRoomsAsync()).Count();
        }

        public async Task<int> GetDoctorsSelectionAsync()
        {
            var doctors = doctorsServiceClient.GetAllDoctorsAsync();

            return (await doctorsServiceClient.GetAllDoctorsAsync()).Count();
        }
        public async Task<IEnumerable<DoctorRoomDto>> GetDoctorsRooms()
        {
            var AllDoctors = await doctorsServiceClient.GetAllDoctorsAsync();
            var AllRooms = examinationRoomsServiceClient.GetAllExaminationRoomsAsync();

            List<ExaminationRoomDto> room_list = (List<ExaminationRoomDto>)await AllRooms;
            List<DoctorDto> doctors_list = (List<DoctorDto>)AllDoctors;
            List<DoctorRoomDto> result = new List<DoctorRoomDto>();

            foreach (DoctorDto item in doctors_list)
            {
                bool exit = false;
                foreach (ExaminationRoomDto room in room_list)
                {
                    List<String> DoctorSpecialization = (List<String>)item.Specialisations;
                    List<String> Certification = (List<String>)room.Certifications;
                    foreach (String spec in DoctorSpecialization)
                    {
                        if (Certification.Contains(spec))
                        {
                            DoctorRoomDto @object = new DoctorRoomDto();
                            @object.Specialisations = item.Specialisations;
                            @object.FirstName = item.FirstName;
                            @object.LastName = item.LastName;
                            @object.Number = room.Number;
                            @object.Certifications = room.Certifications;
                            result.Add(@object);
                            room_list.Remove(room);
                            exit = true;
                            break;
                        }
                    }
                    if (exit)
                        break;
                }
            }

            IEnumerable<DoctorRoomDto> end = result;
            return end;
        }
    }
}
