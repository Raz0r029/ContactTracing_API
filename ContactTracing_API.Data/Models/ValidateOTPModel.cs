using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTracing_API.Data.Models
{
    public class ValidateOTPModel
    {
        [Key]
        public int ValidateOtpId { get; set; }

        public string MobileNumber { get; set; }

        public string Otp { get; set; }
    }
}
