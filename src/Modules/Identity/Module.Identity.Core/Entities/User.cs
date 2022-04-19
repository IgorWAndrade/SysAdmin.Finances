namespace Module.Identity.Core.Entities;
public class User
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public void GenereNewId() => Id = Guid.NewGuid().ToString();
}
