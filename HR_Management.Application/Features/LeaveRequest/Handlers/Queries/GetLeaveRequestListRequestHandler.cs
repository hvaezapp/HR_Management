using AutoMapper;
using HR_Management.Application.DTOs.LeaveRequest;
using HR_Management.Application.Features.LeaveRequest.Requests.Queries;
using HR_Management.Application.Features.LeaveType.Requests.Queries;
using HR_Management.Application.Persistence.Contracts;
using MediatR;

namespace HR_Management.Application.Features.LeaveRequest.Handlers.Queries;

public class GetLeaveRequestListRequestHandler :
    IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestDto>>
{


    private readonly ILeaveRequestRepository _leaveRequestRepository;
    private readonly IMapper _mapper;



    public GetLeaveRequestListRequestHandler(ILeaveRequestRepository leaveRequestRepository,
        IMapper mapper)
    {

        _leaveRequestRepository = leaveRequestRepository;
        _mapper = mapper;
    }



    public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
    {
        var leaveRequests = await _leaveRequestRepository.GetAll();
        return _mapper.Map<List<LeaveRequestDto>>(leaveRequests);
    }

}
