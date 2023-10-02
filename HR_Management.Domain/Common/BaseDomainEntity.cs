﻿namespace HR_Management.Domain.Common;

public abstract class BaseDomainEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public string LastModifiedBy { get; set; }


    public BaseDomainEntity()
    {
        CreatedDate = DateTime.Now;
        LastModifiedDate = DateTime.Now;
    }
}
