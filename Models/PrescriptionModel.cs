namespace hospitalonlinebooking.Models
{
    public class PrescriptionModel
    {
        public int Id { get; set; }

        public int BookingId { get; set; }

        public int DoctorId { get; set; }

        public int DepartmentId { get; set; }

        public string MedicineName { get; set; } = string.Empty;

        public string Dosage { get; set; } = string.Empty;

        public bool Morning { get; set; }

        public bool Afternoon { get; set; }

        public bool Night { get; set; }

        public int Days { get; set; }

        public string Remarks { get; set; } = string.Empty;
    }
}