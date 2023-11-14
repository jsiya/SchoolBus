using SchoolBusModels.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolBusModels.Concretes;

public class ParentStudent
{
    public int ParentId { get; set; }
    public int StudentId { get; set; }
    public virtual Parent Parent { get; } = null!;
    public virtual Student Student { get; } = null!;
}
