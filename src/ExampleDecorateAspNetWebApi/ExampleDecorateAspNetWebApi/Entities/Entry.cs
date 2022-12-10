namespace ExampleDecorateAspNetWebApi.Entities;

public class Entry
{
    public Entry(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public string Name { get; set; }

    public int Id { get; set; }
}