using ExampleDecorateAspNetWebApi.Entities;
using ExampleDecorateAspNetWebApi.Services;

namespace ExampleDecorateAspNetWebApi.Decorators;

public class AnotherConcreteDataSourceDecorator : DataSourceBaseDecorator
{
    private readonly string message;

    public AnotherConcreteDataSourceDecorator(IDataSource dataSource, string message)
        : base(dataSource)
    {
        this.message = message;
    }

    public override IEnumerable<Entry> GetAllEntries()
    {
        var result = base.GetAllEntries();
        return result.Append(new Entry(message, 6));
    }
}