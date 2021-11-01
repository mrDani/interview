using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Repository.Interface;
using Backend.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InterviewController : ControllerBase
    {
        private readonly ILogger<InterviewController> _logger;
        private IInterviewService _interviewService;

        public InterviewController(ILogger<InterviewController> logger, IInterviewService interviewServicervice)
        {
            _logger = logger;
            _interviewService = interviewServicervice;
        }

        [HttpPost("profilesubmission")]
        public async Task<IActionResult> ProfileSubmission([FromBody] ProfileModel request)
        {
            try
            {
                var response = await _interviewService.ProfileSubmission(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet("getprofiles")]
        public async Task<IActionResult> GetProfiles()
        {
            try
            {
                var response = _interviewService.GetAllProfile();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
