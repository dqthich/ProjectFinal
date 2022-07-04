using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFinal.Models
{
    public class ProjectMember
    {
        public Guid ProjectMemberId { get; set; }
        public string MemberRole { get; set; }
        public status AcceptInviation { get; set; }
        public enum status
        {
            Yes, No
        }
        public Guid ProjectId { get; set; }
        public Guid UserId { get; set; }
        public virtual User IsUser { get; set; }
        public virtual Project IsProject { get; set; }
    }
}
