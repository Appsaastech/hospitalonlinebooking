namespace hospitalonlinebooking.Models
{
    public class PatientModel
    {
        public int Id { get; set; }

        public string PatientRegistrationNo { get; set; } = string.Empty;

        public string PatientName { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;
    }
}