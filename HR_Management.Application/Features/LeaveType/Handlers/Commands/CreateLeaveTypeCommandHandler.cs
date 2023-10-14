using AutoMapper;
using HR_Management.Application.Features.LeaveType.Requests.Commands;
using HR_Management.Application.Persistence.Contracts;
using MediatR;

namespace HR_Management.Application.Features.LeaveType.Handlers.Commands;

public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly Mapper _mapper;


    public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository,
                                        Mapper mapper)
    {
        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var leaveType = _mapper.Map<Domain.Entity.LeaveType>(request.LeaveTypeDto);
        var newLeaveType =  await _leaveTypeRepository.Add(leaveType);
        return newLeaveType.Id;
    }
}
