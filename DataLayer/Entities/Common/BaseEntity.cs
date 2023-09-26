namespace DataLayer.Entities.common;

public interface IEntity 
{

}
public abstract class BaseEntity<Tkey>:IEntity
{
    public Tkey Id { get; set; }
    //public DateTime CreateDate { get; set; }
    //public string? CreateBy { get; set; }
    //public DateTime ModifiedDate { get; set; }
    //public string? ModifyBy { get; set; }
}
