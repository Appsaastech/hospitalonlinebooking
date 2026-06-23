namespace hospitalonlinebooking.Models
{
    public class PublicAppointmentModel
    {
        public int Id { get; set; }

        public string PatientRegistrationNo { get; set; } = string.Empty;

        public string DepartmentId { get; set; } = string.Empty;

        public string DepartmentName { get; set; } = string.Empty;

        public string DoctorId { get; set; } = string.Empty;

        public string DoctorName { get; set; } = string.Empty;

        public string ScheduleDate { get; set; } = string.Empty;

        public string AppointmentTime { get; set; } = string.Empty;

        public string TimeSlots { get; set; } = string.Empty;
    }
}