namespace DataLayer.Entities.BaseEntity;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public string? CreateBy { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string? ModifyBy { get; set; }
}
