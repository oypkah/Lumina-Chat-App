using LCA_Common.Client.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LCA_Common.DTOs.Base
{
    public class BaseDto
    {
        public int Id { get; set; }
        public Status Status { get; set; }

        public DateTime? CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIP { get; set; }

        public DateTime? ModifiedDate { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIP { get; set; }
    }
}
