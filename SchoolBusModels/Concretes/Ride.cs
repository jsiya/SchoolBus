using SchoolBusModels.Abstracts;

namespace SchoolBusModels.Concretes;

public class Ride : BaseEntity
{
    public bool Rotate { get; set; }
    public int CarId { get; set; }
    public int DriverId { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }

    //Navigation Property
    public virtual Car Car { get; set; }
    public virtual Driver Driver { get; set; }
    public virtual ICollection<Student>? Students { get; set; }
}
