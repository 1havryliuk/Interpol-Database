using System.Collections.Generic;

namespace InterpolSystem.Models
{
    public class Organization
    {
        public string Name { get; set; } = "";

        public List<Criminal> Members { get; set; } = new List<Criminal>();
    }
}