using HR_Management.Domain.Entity;


namespace HR_Management.Application.Persistence.Contracts;

public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
{
    Task<LeaveAllocation> GetLeaveAllocationDetail(int id);
    Task<List<LeaveAllocation>> GetLeaveAllocationList();
}
