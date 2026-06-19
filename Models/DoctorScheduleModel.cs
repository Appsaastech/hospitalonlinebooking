public class DoctorScheduleModel
{
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public string? DoctorName { get; set; }
    public string? ScheduleDate { get; set; }
    public string? StartTime { get; set; }
    public string? EndTime { get; set; }
    public string? TimeSlots { get; set; }
}