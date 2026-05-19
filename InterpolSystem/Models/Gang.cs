using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolSystem.Models
{
    public class Gang
    {
        public string Name { get; set; }

        public string Country { get; set; }

        public int MembersCount { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
