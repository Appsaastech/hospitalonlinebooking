namespace hospitalonlinebooking.Models
{
    public class AppointmentModel
    {
        public string PatientRegistrationNo { get; set; } = string.Empty;

        public int DepartmentId { get; set; }

        public int DoctorId { get; set; }

        public int ScheduleId { get; set; }

        public string AppointmentDate { get; set; } = string.Empty;

        public string AppointmentTime { get; set; } = string.Empty;
    }
}