using ContactTracing_API.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTracing_API.Data
{
    public class ContactTracingContext : DbContext
    {
        public ContactTracingContext(DbContextOptions<ContactTracingContext> options) : base(options)
        {
        }
        public DbSet<ActivityLogModel> ActivityLog { get; set; }
        public DbSet<BuildingLogModel> BuildingLog { get; set; }
        public DbSet<SymptomModel> Symptom { get; set; }
        public DbSet<UserHealthStatusModel> UserHealthStatus { get; set; }
        public DbSet<UserModel> User { get; set; }
        public DbSet<ValidateOTPModel> ValidateOtp { get; set; }
    }
}
