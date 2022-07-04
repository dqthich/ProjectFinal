using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class Task
    {
        public Guid TaskId { get; set; }
        public status Status { get; set; }
        public enum status { 
            New, Inprogress, Finished
        }

        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public virtual User Assignby { get; set; }
        public virtual Project In { get; set; }


    }
}
