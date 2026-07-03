namespace hospitalonlinebooking.Models
{
    public class AdminAppointmentModel
    {
        public int Id { get; set; }

        // Patient Details
        public string PatientRegistrationNo { get; set; } = string.Empty;

        public string PatientName { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        // Appointment Details
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; } = string.Empty;

        public int DoctorId { get; set; }

        public string DoctorName { get; set; } = string.Empty;

        public int ScheduleId { get; set; }

        public string ScheduleDate { get; set; } = string.Empty;

        public string DayName { get; set; } = string.Empty;

        public string AppointmentTime { get; set; } = string.Empty;

        public string TimeSlots { get; set; } = string.Empty;
    }
}