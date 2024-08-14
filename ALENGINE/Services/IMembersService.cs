

using ALENGINE.Models;

namespace ALENGINE.Services
{
    public interface IMembersService
    {
       
            Task AddMembers(PatientInformation members);
            Task UpdateMembers(PatientInformation members);
            Task<IEnumerable<PatientInformation>> ListPatient();
            Task<PatientInformation> GetMembers(string Id);
            Task DeleteMembers(string Id);
        
    }
}
