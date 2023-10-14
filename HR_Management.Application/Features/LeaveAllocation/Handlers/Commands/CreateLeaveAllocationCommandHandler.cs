using AutoMapper;
using HR_Management.Application.Features.LeaveAllocation.Requests.Commands;
using HR_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveAllocation.Handlers.Commands;

public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
{
    private readonly ILeaveAllocationRepository _leaveAllocationRepository;
    private readonly Mapper _mapper;

    public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository,
                                        Mapper mapper)
    {
        _leaveAllocationRepository = leaveAllocationRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        var leaveAllocation = _mapper.Map<Domain.Entity.LeaveAllocation>(request.LeaveAllocationDto);
        var newLeaveAllocation = await _leaveAllocationRepository.Add(leaveAllocation);
        return newLeaveAllocation.Id;
    }
}
