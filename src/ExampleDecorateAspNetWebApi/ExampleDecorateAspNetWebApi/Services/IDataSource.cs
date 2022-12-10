using ExampleDecorateAspNetWebApi.Entities;

namespace ExampleDecorateAspNetWebApi.Services;

public interface IDataSource
{
    public IEnumerable<Entry> GetAllEntries();

    public Entry? GetById(int id);
}