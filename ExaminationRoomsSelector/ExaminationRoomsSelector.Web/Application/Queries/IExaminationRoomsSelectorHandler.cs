namespace ExaminationRoomsSelector.Web.Application.Queries
{
    using ExaminationRoomsSelector.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IExaminationRoomsSelectorHandler
    {
        Task<int> GetExaminationRoomsSelectionAsync();

        Task<int> GetDoctorsSelectionAsync();

        Task<IEnumerable<DoctorRoomDto>> GetDoctorsRooms();
    }
}
