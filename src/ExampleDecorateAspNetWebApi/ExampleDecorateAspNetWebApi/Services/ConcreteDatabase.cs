using ExampleDecorateAspNetWebApi.Entities;

namespace ExampleDecorateAspNetWebApi.Services;

public static class ConcreteDatabase
{
    private static readonly Lazy<IEnumerable<Entry>> _entries =
        new(() => new Entry[]
        {
            new("first", 1),
            new("second", 2),
            new("third", 3)
        });

    public static IEnumerable<Entry> Entries => _entries.Value;
}