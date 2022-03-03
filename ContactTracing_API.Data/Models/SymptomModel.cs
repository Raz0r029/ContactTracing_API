using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTracing_API.Data.Models
{
    public class SymptomModel
    {
        public int SymptomId { get; set; }

        public string SymptomName { get; set; }

        public int UserHealthStatusId { get; set; }


    }
}
