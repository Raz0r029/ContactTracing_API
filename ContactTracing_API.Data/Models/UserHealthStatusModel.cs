using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTracing_API.Data.Models
{
    public class UserHealthStatusModel
    {
        [Key]
        public int UserHealthStatusId { get; set; }

        public DateTime DateTime { get; set; }
      

        //Navigation Component
        public int UserId { get; set; }
        public UserModel User { get; set; }

    }
}
