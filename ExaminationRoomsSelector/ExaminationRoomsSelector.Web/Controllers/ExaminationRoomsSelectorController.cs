using ExaminationRoomsSelector.Web.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExaminationRoomsSelector.Web.Application.Dtos;

namespace ExaminationRoomsSelector.Web.Controllers
{
    [ApiController]
    public class ExaminationRoomsSelectorController : ControllerBase
    {
        private readonly ILogger<ExaminationRoomsSelectorController> logger;
        private readonly IExaminationRoomsSelectorHandler examinationRoomsSelectorHandler;

        public ExaminationRoomsSelectorController(ILogger<ExaminationRoomsSelectorController> logger, IExaminationRoomsSelectorHandler examinationRoomsSelectorHandler)
        {
            this.logger = logger;
            this.examinationRoomsSelectorHandler = examinationRoomsSelectorHandler;
        }

        [HttpGet("examination-rooms-selection")]
        public async Task<int> GetLaboratoryDiagnosticiansDetails()
        {
            return await examinationRoomsSelectorHandler.GetExaminationRoomsSelectionAsync();
        }

        [HttpGet("doctors")]
        public async Task<int> GetLaboratoryDoctorsDetails()
        {
            return await examinationRoomsSelectorHandler.GetDoctorsSelectionAsync();
        }

        [HttpGet("doctors_assigned_to_rooms")]
        public async Task<IEnumerable<DoctorRoomDto>> GetLaboratoryDoctorsAssignedDetails()
        {
            return await examinationRoomsSelectorHandler.GetDoctorsRooms();
        }
    }
}