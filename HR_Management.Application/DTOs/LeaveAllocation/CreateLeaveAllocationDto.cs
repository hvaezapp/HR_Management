﻿using HR_Management.Application.DTOs.LeaveType;

namespace HR_Management.Application.DTOs.LeaveAllocation;

public class CreateLeaveAllocationDto
{
    public int NumberOfDays { get; set; }
    public int Period { get; set; }
    public int LeaveTypeId { get; set; }

}
