using SchoolBusModels.Abstracts;

namespace SchoolBusModels.Concretes;

public class Class_ : BaseEntity
{
    public string Name { get; set; }

    //Navigation Properties
    public virtual ICollection<Student>? Students { get; set; }
}
