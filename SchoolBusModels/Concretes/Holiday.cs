using SchoolBusModels.Abstracts;

namespace SchoolBusModels.Concretes;

public class Holiday : BaseEntity
{
    public string Name { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndingTime { get; set; }
}
