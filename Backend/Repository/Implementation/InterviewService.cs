using System.Collections.Generic;
using Backend.Repository.Interface;
using Microsoft.Extensions.Logging;
using Backend.ViewModel;
using System.Threading.Tasks;
using System;
using Models;
using Model;
using System.Linq;

namespace Backend.Repository.Implementation
{
    public class InterviewService : IInterviewService
    {
        private readonly ILogger<InterviewService> _logger;
        private AppDbContext _context;
        //dbcontext later
        public InterviewService(ILogger<InterviewService> logger, AppDbContext context)
        {
            //dbcontext
            _logger = logger;
            _context = context;
        }

        public async Task<ApiResponse> ProfileSubmission(ProfileModel requestModel)
        {
            try
            {
                if (string.IsNullOrEmpty(requestModel.email) || string.IsNullOrEmpty(requestModel.Name))
                {
                    return new ApiResponse() { Status = false, Message = "Invalid parameters" };
                }

                //core implementation to submit profile
                Profile profile = new Profile()
                {
                    Name = requestModel.Name,
                    Age = requestModel.Age,
                    email = requestModel.email,
                    Sex = requestModel.Sex,
                    Bvn = requestModel.Bvn
                };

                var submit = _context.Profiles.Add(profile);
                await _context.SaveChangesAsync();

                return new ApiResponse() { Status = true, Message = "Profile Submission Successfully completed" };
            }
            catch (Exception ex)
            {
                return new ApiResponse() { Status = false, Message = $"An Error Occured. ex: {ex.Message}" };
            }
        }

        public ApiResponseObj<List<Profile>> GetAllProfile()
        {
            try
            {
                var response = _context.Profiles.ToList();
                if (response == null)
                {
                    return new ApiResponseObj<List<Profile>>()
                    {
                        data = null,
                        Status = false,
                        Message = "Unable to get profiles"
                    };
                }

                return new ApiResponseObj<List<Profile>>()
                {
                    data = response,
                    Status = false,
                    Message = "Successfully got data"
                };

            }
            catch (Exception ex)
            {
                return new ApiResponseObj<List<Profile>>() { Status = false, Message = $"An Error Occured. ex: {ex.Message}" };
            }
        }
    }
}