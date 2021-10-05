namespace Exempel.Abstract
{
    using System.Collections.Generic;

    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string Customer { get; set; }
        public string Project { get; set; }

        //Browsing property
        public ICollection<Workload> Workloads { get; set; } = new HashSet<Workload>();
    }
}
