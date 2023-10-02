﻿using AutoMapper;
using HR_Management.Application.DTOs;
using HR_Management.Application.Features.LeaveType.Requests.Queries;
using HR_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveType.Handlers.Queries;

public class GetLeaveTypeListRequestHandler :
    IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
{


    private readonly ILeaveTypeRepository _leaveTypeRepository;
    private readonly IMapper _mapper;



    public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository , 
        IMapper mapper)
    {

        _leaveTypeRepository = leaveTypeRepository;
        _mapper = mapper;
    }



    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
    {
        var leaveTypeList = await _leaveTypeRepository.GetAll();
        return _mapper.Map<List<LeaveTypeDto>>(leaveTypeList);
    }

}
