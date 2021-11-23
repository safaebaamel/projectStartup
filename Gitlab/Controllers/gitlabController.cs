using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;
using Gitlab.Dto;
using Swashbuckle.AspNetCore.Annotations;
using FluentValidation;

namespace gitlab.Controllers;

[Route("projects")]
[Produces("application/json")]
[ApiController]

public class GitlabController : ControllerBase
{
    // GET: api/Gitlab
    [HttpGet]
    [SwaggerOperation(
        Summary = "Get all projects",
        Description = "Requires admin privileges",
        OperationId = "Get all projects",
        Tags = new[] { "Projects" }
)]
    public void test([FromHeader(Name = "PRIVATE-TOKEN")] string token)
    {
        Console.WriteLine("test");
    }

    // POST: api/Gitlab
    [HttpPost]
    [SwaggerOperation(
        Summary = "Create a new project",
        Description = "Requires admin privileges",
        OperationId = "Create a new project",
        Tags = new[] { "Projects" }
    )]
    public void Post([FromHeader(Name = "PRIVATE-TOKEN")] string token, [FromBody] ProjectDto project)
    {
        Console.WriteLine("test");
    }
}

public class ProjectValidator : AbstractValidator<Gitlab.Dto.ProjectDto>
{
    public ProjectValidator()
    {
        RuleFor(x => x.name).NotEmpty().Length(3, 20).NotNull();
    }
}