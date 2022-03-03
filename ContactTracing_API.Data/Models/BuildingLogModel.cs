using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTracing_API.Data.Models
{
    public class BuildingLogModel
    {
        public int BuildingLogId { get; set; }

        public DateTime TimeIn { get; set; }

        public DateTime TimeOut { get; set; }

        public int ActivityLogId { get; set; }

        public int BuildingId { get; set; }

    }
}
