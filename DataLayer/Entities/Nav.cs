﻿

namespace DataLayer.Entities;

public class Nav
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ImageFileName { get; set; }
    public string Link { get; set; }
    public int? SubGroupId { get; set; }
}
