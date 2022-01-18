using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPortal.Models
{
    public class Answers
    {
        public int Question { get; set; }
        public int Answer { get; set; }
    }

    public class Submission
    {
        public string UniqueID { get; set; }
        public string StudentID { get; set; }
        public string ModuleCode { get; set; }
        public List<Answers> Answers { get; set; }
    }

    public class Submissions
    {
        public int SubmissionID { get; set; }
        public string UniqueID { get; set; }
        public string StudentID { get; set; }
        public string ModuleCode { get; set; }
        public DateTime SubmitedOn { get; set; } = DateTime.Now;
    }
}
