using ExampleDecorateAspNetWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExampleDecorateAspNetWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ExampleController : ControllerBase
{
    private readonly IDataSource dataSource;

    public ExampleController(IDataSource dataSource)
    {
        this.dataSource = dataSource;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(dataSource.GetAllEntries());
    }

    [HttpGet]
    [Route("/{id:int}")]
    public IActionResult GetById(int id)
    {
        return Ok(dataSource.GetById(id));
    }
}