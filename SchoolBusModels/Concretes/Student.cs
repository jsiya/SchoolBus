using SchoolBusModels.Abstracts;
using System.Security.Claims;

namespace SchoolBusModels.Concretes;

public class Student : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? ClassId { get; set; }
    public string Address1 { get; set; }
    public string? Address2 { get; set; }

    //Navigation Property
    public virtual Class_? Class { get; set; }
    //public virtual ICollection<Ride>? Rides { get; set; } = new List<Ride>();
    public virtual ICollection<StudentRide>? StudentRides { get; set; }

    //public virtual ICollection<Parent>? Parents { get; set; } = new List<Parent>();
    public virtual ICollection<ParentStudent>? ParentStudents { get; set; }
}
