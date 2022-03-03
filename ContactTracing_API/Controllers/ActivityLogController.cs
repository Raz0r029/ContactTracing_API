using ContactTracing_API.Data;
using ContactTracing_API.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactTracing_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityLogController : ControllerBase
    {
        private readonly ContactTracingContext _context;
        public ActivityLogController(ContactTracingContext context)
        {
            _context = context;
        }
        public IActionResult AddActivityLog(ActivityLogModel activityLog)
        {
            _context.Add(activityLog);
            return Ok();
        }
    }
}