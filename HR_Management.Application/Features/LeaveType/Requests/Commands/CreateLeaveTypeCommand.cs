﻿using HR_Management.Application.DTOs.LeaveType;
using MediatR;

namespace HR_Management.Application.Features.LeaveType.Requests.Commands;

public class CreateLeaveTypeCommand : IRequest<int>
{
    public LeaveTypeDto LeaveTypeDto { get; set; }
}
