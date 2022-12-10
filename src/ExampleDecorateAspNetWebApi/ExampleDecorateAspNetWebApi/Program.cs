using ExampleDecorateAspNetWebApi.Decorators;
using ExampleDecorateAspNetWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// manually first variant

# region First Variant

// builder.Services.AddTransient<BaseDataSource>();
//
// builder.Services.AddTransient<IDataSource>(provider => new ConcreteDataSourceDecorator(provider.GetService<BaseDataSource>()));

#endregion

//second variant

#region Second Variant With 2 layers

builder.Services.AddScoped<IDataSource, BaseDataSource>();

builder.Services.Decorate<IDataSource, ConcreteDataSourceDecorator>();

//without other parameter

//builder.Services.Decorate<IDataSource, AnotherConcreteDataSourceDecorator>();

//with other parameter
builder.Services.Decorate(new Func<IDataSource, IServiceProvider, AnotherConcreteDataSourceDecorator>(
    (source, _) => new AnotherConcreteDataSourceDecorator(source, "from decorate")));

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();