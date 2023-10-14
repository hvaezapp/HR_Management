using AutoMapper;
using HR_Management.Application.Features.LeaveRequest.Requests.Commands;
using HR_Management.Application.Persistence.Contracts;
using MediatR;


namespace HR_Management.Application.Features.LeaveRequest.Handlers.Commands;

public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, int>
{

    private readonly ILeaveRequestRepository _leaveRequestRepository;
    private readonly Mapper _mapper;

    public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository,
                                        Mapper mapper)
    {
        _leaveRequestRepository = leaveRequestRepository;
        _mapper = mapper;
    }


    public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
    {
        var leaveRequest = _mapper.Map<Domain.Entity.LeaveRequest>(request.LeaveRequestDto);
        var newLeaveRequest = await _leaveRequestRepository.Add(leaveRequest);
        return newLeaveRequest.Id;
    }
}
