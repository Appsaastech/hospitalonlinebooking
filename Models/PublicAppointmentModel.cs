namespace hospitalonlinebooking.Models
{
    public class PublicAppointmentModel
    {
        public int Id { get; set; }

        public string PatientRegistrationNo { get; set; } = string.Empty;

        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; } = string.Empty;

        public int DoctorId { get; set; }

        public string DoctorName { get; set; } = string.Empty;

        public string ScheduleDate { get; set; } = string.Empty;
        public string Day { get; set; } = string.Empty;

        public string AvailableSlots { get; set; } = string.Empty;

        public int ScheduleId { get; set; }

        public string AppointmentTime { get; set; } = string.Empty;

        public string TimeSlots { get; set; } = string.Empty;
    }
}