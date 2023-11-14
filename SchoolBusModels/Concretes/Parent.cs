using SchoolBusModels.Abstracts;

namespace SchoolBusModels.Concretes;


public class Parent : User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }

    //public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    public virtual ICollection<ParentStudent> ParentStudents { get; set; } = new List<ParentStudent>();

}

