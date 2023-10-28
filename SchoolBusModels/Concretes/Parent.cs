using SchoolBusModels.Abstracts;

namespace SchoolBusModels.Concretes;


public class Parent : User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }

    public virtual ICollection<Student> Students { get; set; }
}

