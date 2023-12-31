﻿using DataLayer.Entities.common;

namespace DataLayer.Entities;

public class Contact: BaseEntity<int>
{
    public string Title { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string PhoneNumber { get; set; }
    public string Description { get; set; }
}
