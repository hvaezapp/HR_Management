using HR_Management.Application.DTOs;
using HR_Management.Application.Features.LeaveType.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandler :
        IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
