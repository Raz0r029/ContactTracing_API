using ContactTracing_API.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTracing_API.Data.Models
{
    public class ActivityLogModel
    {
        [Key]
        public int ActivityLogId { get; set; }

        public Status Status { get; set; }

        public int UserId { get; set; }

        public DateTime ActivityDate { get; set; }
    }
}
