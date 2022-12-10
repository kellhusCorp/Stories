using ExampleDecorateAspNetWebApi.Entities;
using ExampleDecorateAspNetWebApi.Services;

namespace ExampleDecorateAspNetWebApi.Decorators;

public class ConcreteDataSourceDecorator : DataSourceBaseDecorator
{
    public ConcreteDataSourceDecorator(IDataSource dataSource)
        : base(dataSource)
    {
    }

    public override IEnumerable<Entry> GetAllEntries()
    {
        var result = base.GetAllEntries();
        return result.Append(new Entry("fourth", 4));
    }

    public override Entry? GetById(int id)
    {
        var result = base.GetById(id);
        result.Name += " fsadfadsf";
        return result;
    }
}