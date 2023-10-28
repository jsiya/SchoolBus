using SchoolBusModels.Abstracts;

namespace SchoolBusModels.Concretes;
public class Driver : User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string HomeAddress { get; set; }
    public string License { get; set; }

    //Navigation Property
    public virtual ICollection<Ride>? Rides { get; set; }
}
