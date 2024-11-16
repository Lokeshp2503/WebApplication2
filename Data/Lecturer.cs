using System;
using System.Collections.Generic;

namespace WebApplication1.Data;

public partial class Lecturer
{
    public int Id { get; set; }

    public string Firstname { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
}
