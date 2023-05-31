namespace IWantApp.Domain;

public abstract class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid(); 
    }
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CreatedBy { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime UpdateDate { get; set; }
}
