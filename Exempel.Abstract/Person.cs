namespace Exempel.Abstract
{
    using System.Collections.Generic;

    public class Person
    {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        //Browsing property
        public ICollection<Workload> Workloads { get; set; } = new HashSet<Workload>();
    }
}
