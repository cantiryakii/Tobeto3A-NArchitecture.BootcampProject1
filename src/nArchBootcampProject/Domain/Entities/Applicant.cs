﻿namespace Domain.Entities;

public class Applicant : User
{
    public string About { get; set; }
    public virtual Blacklist? Blacklist { get; set; }
    public virtual ICollection<ApplicationInformation> Applications { get; set; }

    public Applicant() { }

    public Applicant(string about)
    {
        About = about;
    }
}
