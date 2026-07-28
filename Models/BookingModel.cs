namespace hospitalonlinebooking.Models
{
    public class BookingModel
    {
        public int BookingId { get; set; }

        public string BookingNumber { get; set; } = string.Empty;

        public string PatientName { get; set; } = string.Empty;

        public string RegistrationNo { get; set; } = string.Empty;

        public string DoctorName { get; set; } = string.Empty;

        public string DepartmentName { get; set; } = string.Empty;

        public string AppointmentDate { get; set; } = string.Empty;
    }
}