using System.Collections.Generic;

public class Organization
{
    public string Name { get; set; }
    public List<Criminal> Members { get; set; } = new List<Criminal>();
}