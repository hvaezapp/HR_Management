using HR_Management.Domain.Entity;

namespace HR_Management.Application.Persistence.Contracts;

public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<LeaveRequest> GetLeaveRequestDetail(int id);
    Task<List<LeaveRequest>> GetLeaveRequestList();
}
