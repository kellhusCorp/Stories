using ExampleDecorateAspNetWebApi.Entities;
using ExampleDecorateAspNetWebApi.Services;

namespace ExampleDecorateAspNetWebApi.Decorators;

public class DataSourceBaseDecorator : IDataSource
{
    private readonly IDataSource dataSource;

    public DataSourceBaseDecorator(IDataSource dataSource)
    {
        this.dataSource = dataSource;
    }

    public virtual Entry? GetById(int id)
    {
        return dataSource.GetById(id);
    }

    public virtual IEnumerable<Entry> GetAllEntries()
    {
        return dataSource.GetAllEntries();
    }
}