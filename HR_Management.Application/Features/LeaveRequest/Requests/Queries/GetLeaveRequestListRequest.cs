using HR_Management.Application.DTOs.LeaveRequest;
using HR_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveRequest.Requests.Queries;

public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestDto>>
{
}
