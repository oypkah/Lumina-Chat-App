using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Core.Entity
{
    public class CoreEntity
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIp { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
    }
}
