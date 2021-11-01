using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.ViewModel;
using Model;

namespace Backend.Repository.Interface
{
    public interface IInterviewService
    {
        Task<ApiResponse> ProfileSubmission(ProfileModel requestModel);
        ApiResponseObj<List<Profile>> GetAllProfile();
    }
}