using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTracing_API.Data.Models
{
    public class ActivityLogModel
    {
        public int ActivityLogId { get; set; }

        public Status Status { get; set; }

        public int UserId { get; set; }

        public DateTime ActivityDate { get; set; }
    }
}
