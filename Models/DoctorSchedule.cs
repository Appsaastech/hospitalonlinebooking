public class DoctorSchedule
{
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public string? DoctorName { get; set; }
    public DateTime ScheduleDate { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public string? TimeSlots { get; set; }
}