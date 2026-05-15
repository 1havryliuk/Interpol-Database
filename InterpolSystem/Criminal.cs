using System;

namespace InterpolSystem
{
    public class Criminal
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Nickname { get; set; } = "";

        public int Height { get; set; }

        public string HairColor { get; set; } = "";
        public string EyeColor { get; set; } = "";
        public string SpecialSigns { get; set; } = "";
        public string Citizenship { get; set; } = "";

        public string BirthPlace { get; set; } = "";

        public DateTime BirthDate { get; set; }

        public string LastResidence { get; set; } = "";
        public string Languages { get; set; } = "";

        public string CrimeProfession { get; set; } = "";
        public string LastCase { get; set; } = "";

        public string Gang { get; set; } = "";

        public bool IsArchived { get; set; }
        public bool IsDead { get; set; }
    }
}