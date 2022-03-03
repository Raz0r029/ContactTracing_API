using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTracing_API.Data.Models
{
    public class UserHealthStatusModel
    {
        public int UserHealthStatusId { get; set; }

        public DateTime DateTime { get; set; }

        public int UserId { get; set; }
    }
}
