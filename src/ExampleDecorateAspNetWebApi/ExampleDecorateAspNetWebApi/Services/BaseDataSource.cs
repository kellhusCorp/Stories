using ExampleDecorateAspNetWebApi.Entities;

namespace ExampleDecorateAspNetWebApi.Services;

public class BaseDataSource : IDataSource
{
    public IEnumerable<Entry> GetAllEntries()
    {
        return ConcreteDatabase.Entries;
    }

    public Entry? GetById(int id)
    {
        return ConcreteDatabase.Entries.FirstOrDefault(x => x.Id == id);
    }
}