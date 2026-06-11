namespace hospitalonlinebooking.Models
{
    public class DoctorModel
    {
        public int Id { get; set; }

        public string DoctorName { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Qualification { get; set; } = string.Empty;

        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; } = string.Empty;
    }
}