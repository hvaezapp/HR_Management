﻿using HR_Management.Application.DTOs.LeaveAllocation;
using HR_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveAllocation.Requests.Queries;

public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
{
}
