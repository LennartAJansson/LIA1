namespace Exempel.Abstract
{
    using System;

    public class Workload
    {
        public int WorkloadId { get; set; }
        public string Comment { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset? Stop { get; set; }
        public int PersonId { get; set; }
        public int AssignmentId { get; set; }
        //Browsing property
        public Person Person { get; set; }
        public Assignment Assignment { get; set; }
    }
}
