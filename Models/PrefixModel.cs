namespace hospitalonlinebooking.Models
{
    public class PrefixModel
    {
        public int Id { get; set; }

        public string PatientRegistrationPrefix { get; set; } = string.Empty;

        public string PrescriptionPrefix { get; set; } = string.Empty;

        public string InvoicePrefix { get; set; } = string.Empty;
    }
}