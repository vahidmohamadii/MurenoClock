﻿using DataLayer.Entities.common;

namespace DataLayer.Entities;

public class ContactForm: BaseEntity
{
    public string Title { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
}
