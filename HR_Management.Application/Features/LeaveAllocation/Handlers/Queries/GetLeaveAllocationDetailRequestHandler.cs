using AutoMapper;
using HR_Management.Application.DTOs.LeaveAllocation;
using HR_Management.Application.Features.LeaveAllocation.Requests.Queries;
using HR_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveAllocation.Handlers.Queries;

public class GetLeaveAllocationDetailRequestHandler :
    IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDto>

{

    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly IMapper _mapper;



    public GetLeaveAllocationDetailRequestHandler(ILeaveAllocationRepository leaveAllocationRepository,
        IMapper mapper)
    {

        _leaveAllocationRepository = leaveAllocationRepository;
        _mapper = mapper;
    }


    public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
    {
        var leaveAllocation = await _leaveAllocationRepository.GetLeaveAllocationDetail(request.Id);
        return _mapper.Map<LeaveAllocationDto>(leaveAllocation);
    }
}
