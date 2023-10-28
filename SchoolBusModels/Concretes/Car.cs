using SchoolBusModels.Abstracts;

namespace SchoolBusModels.Concretes;

public class Car : BaseEntity
{
    public string Name { get; set; }
    public string Number { get; set; }
    public int SeatCount { get; set; }

    //Navigation Properties
    public virtual ICollection<Ride>? Rides { get; set; }
}
