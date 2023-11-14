using SchoolBusModels.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolBusModels.Concretes;

public class StudentRide
{
    public int RideId { get; set; }
    public int StudentId { get; set; }
    public virtual Student Student { get; set; } = null!;
    public virtual Ride Ride { get; set; } = null!;
}
