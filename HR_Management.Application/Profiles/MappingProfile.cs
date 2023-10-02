using AutoMapper;
using HR_Management.Application.DTOs;
using HR_Management.Domain.Entity;

namespace HR_Management.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<LeaveAllocation,LeaveAllocationDto>().ReverseMap();
        CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
        CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
    }
}
