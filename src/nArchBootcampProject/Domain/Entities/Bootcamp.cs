using NArchitecture.Core.Persistence.Repositories;
using static System.Net.Mime.MediaTypeNames;

namespace Domain.Entities;

public class Bootcamp : Entity<int>
{
    public string Name { get; set; }
    public Guid InstructorId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public short BootcampStateId { get; set; }
    public virtual Instructor? Instructor { get; set; }
    public virtual ICollection<ApplicationInformation> ApplicationInformations { get; set; }
    public virtual BootcampState BootcampState { get; set; }
    public virtual ICollection<BootcampImage> BootcampImages { get; set; }

    public Bootcamp()
    {
        BootcampImages = new HashSet<BootcampImage>();
        ApplicationInformations = new HashSet<ApplicationInformation>();
    }

    public Bootcamp(string name, Guid ınstructorId, DateTime startDate, DateTime endDate, short bootcampStateId)
    {
        Name = name;
        InstructorId = ınstructorId;
        StartDate = startDate;
        EndDate = endDate;
        BootcampStateId = bootcampStateId;
    }
}
