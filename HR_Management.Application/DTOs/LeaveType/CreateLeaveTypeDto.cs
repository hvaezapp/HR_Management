﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.DTOs.LeaveType;

public class CreateLeaveTypeDto
{
    public string Name { get; set; }
    public int DefaultDay { get; set; }
}
