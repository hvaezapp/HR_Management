using AutoMapper;
using HR_Management.Application.DTOs;
using HR_Management.Application.Features.LeaveAllocation.Requests.Queries;
using HR_Management.Application.Persistence.Contracts;
using MediatR;

namespace HR_Management.Application.Features.LeaveAllocation.Handlers.Queries;

public class GetLeaveAllocationListRequestHandler :
    IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
{


    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;



    public GetLeaveAllocationListRequestHandler(ILeaveAllocationRepository leaveAllocationRepository,
        IMapper mapper)
    {

        _leaveAllocationRepository = leaveAllocationRepository;
        _mapper = mapper;
    }



    public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
    {
        var leaveAllocations = await _leaveAllocationRepository.GetLeaveAllocationList();
        return _mapper.Map<List<LeaveAllocationDto>>(leaveAllocations);
    }

}
