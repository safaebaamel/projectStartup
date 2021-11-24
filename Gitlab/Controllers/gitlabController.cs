using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using FluentValidation;
using Gitlab.Dto;

namespace gitlab.Controllers;

[Route("projects")]
[SwaggerResponse(201, "Request was successfull")]
[SwaggerResponse(400, "Invalid request")]
[Produces("application/json")]
[ApiController]

public class GitlabController : ControllerBase
{
//giorVSnFGKzvPs8QZVsi
    private readonly HttpClient _httpClient = new HttpClient();

    // GET: api/Gitlab
    [HttpGet]
    [SwaggerOperation(
        Summary = "Get all projects",
        Description = "Requires admin privileges",
        OperationId = "Get all projects",
        Tags = new[] { "Projects" }
    )]
    public async Task GetProjects([FromHeader(Name = "PRIVATE-TOKEN")] string token)
    {
        await _httpClient.GetAsync("");
    }

    // POST: api/Gitlab
    [HttpPost]
    [SwaggerOperation(
        Summary = "Create a new project",
        Description = "Requires admin privileges",
        OperationId = "Create a new project",
        Tags = new[] { "Projects" }
    )]
    public async void CreateProject([FromHeader(Name = "PRIVATE-TOKEN")] string token, ProjectDto project)
    {
        await _httpClient.PostAsJsonAsync("", project);
    }

    [HttpGet("{id}")]
    [SwaggerOperation(
        Summary = "Get a project",
        Description = "Requires admin privileges",
        OperationId = "Get a project",
        Tags = new[] { "Projects" }
    )]
    public async void GetProject([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id)
    {
        await _httpClient.GetAsync("");
    }

    [HttpPut("{id}")]
    [SwaggerOperation(
        Summary = "Update a project",
        Description = "Requires admin privileges",
        OperationId = "Update a project",
        Tags = new[] { "Projects" }
    )]
    public async Task UpdateProject([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, ProjectDto project)
    {
        await _httpClient.PutAsJsonAsync("", project);
    }

    [HttpDelete("{id}")]
    [SwaggerOperation(
        Summary = "Delete a project",
        Description = "Requires admin privileges",
        OperationId = "Delete a project",
        Tags = new[] { "Projects" }
    )]
    public async Task DeleteProject([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id)
    {
        await _httpClient.DeleteAsync("");
    }

    // issues
    [HttpGet("{id}/issues")]
    [SwaggerOperation(
        Summary = "Get all issues",
        Description = "Requires admin privileges",
        OperationId = "Get all issues",
        Tags = new[] { "Issues" }
    )]
    public async Task GetIssues([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id)
    {
        await _httpClient.GetAsync("");
    }

    [HttpGet("{id}/issues/{issue_iid}")]
    [SwaggerOperation(
        Summary = "Get an issue",
        Description = "Requires admin privileges",
        OperationId = "Get an issue",
        Tags = new[] { "Issues" }
    )]
    public async Task GetIssue([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid)
    {
        await _httpClient.GetAsync("");
    }

    [HttpPost("{id}/issues")]
    [SwaggerOperation(
        Summary = "Create an issue",
        Description = "Requires admin privileges",
        OperationId = "Create an issue",
        Tags = new[] { "Issues" }
    )]
    public async Task CreateIssue([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, IssueDto issue)
    {
        await _httpClient.PostAsJsonAsync("", issue);
    }

    [HttpPut("{id}/issues/{issue_iid}")]
    [SwaggerOperation(
        Summary = "Update an issue",
        Description = "Requires admin privileges",
        OperationId = "Update an issue",
        Tags = new[] { "Issues" }
    )]
    public async Task UpdateIssue([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid, IssueDto issue)
    {
        await _httpClient.PutAsJsonAsync("", issue);
    }

    [HttpDelete("{id}/issues/{issue_iid}")]
    [SwaggerOperation(
        Summary = "Delete an issue",
        Description = "Requires admin privileges",
        OperationId = "Delete an issue",
        Tags = new[] { "Issues" }
    )]
    public async Task DeleteIssue([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid)
    {
        await _httpClient.DeleteAsync("");
    }

    // comment on an issue
    [HttpPost("{id}/issues/{issue_iid}/notes")]
    [SwaggerOperation(
        Summary = "Create a comment on an issue",
        Description = "Requires admin privileges",
        OperationId = "Create a comment on an issue",
        Tags = new[] { "Issues" }
    )]
    public async Task CreateComment([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid, CommentDto comment)
    {
        await _httpClient.PostAsJsonAsync("", comment);
    }

    [HttpGet("{id}/issues/{issue_iid}/notes")]
    [SwaggerOperation(
        Summary = "Get all comments on an issue",
        Description = "Requires admin privileges",
        OperationId = "Get all comments on an issue",
        Tags = new[] { "Issues" }
    )]
    public async Task GetComments([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid)
    {
        await _httpClient.GetAsync("");
    }

    [HttpGet("{id}/issues/{issue_iid}/notes/{note_id}")]
    [SwaggerOperation(
        Summary = "Get a comment on an issue",
        Description = "Requires admin privileges",
        OperationId = "Get a comment on an issue",
        Tags = new[] { "Issues" }
    )]
    public async Task GetComment([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid, int note_id)
    {
        await _httpClient.GetAsync("");
    }

    [HttpPut("{id}/issues/{issue_iid}/notes/{note_id}")]
    [SwaggerOperation(
        Summary = "Update a comment on an issue",
        Description = "Requires admin privileges",
        OperationId = "Update a comment on an issue",
        Tags = new[] { "Issues" }
    )]
    public async Task UpdateComment([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid, int note_id, CommentDto comment)
    {
        await _httpClient.PutAsJsonAsync("", comment);
    }

    [HttpDelete("{id}/issues/{issue_iid}/notes/{note_id}")]
    [SwaggerOperation(
        Summary = "Delete a comment on an issue",
        Description = "Requires admin privileges",
        OperationId = "Delete a comment on an issue",
        Tags = new[] { "Issues" }
    )]
    public async Task DeleteComment([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid, int note_id)
    {
        await _httpClient.DeleteAsync("");
    }

    // labels
    [HttpGet("{id}/labels")]
    [SwaggerOperation(
        Summary = "Get all labels",
        Description = "Requires admin privileges",
        OperationId = "Get all labels",
        Tags = new[] { "Labels" }
    )]
    public async Task GetLabels([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id)
    {
        await _httpClient.GetAsync("");
    }

    [HttpGet("{id}/labels/{label_id}")]
    [SwaggerOperation(
        Summary = "Get a label",
        Description = "Requires admin privileges",
        OperationId = "Get a label",
        Tags = new[] { "Labels" }
    )]
    public async Task GetLabel([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int label_id)
    {
        await _httpClient.GetAsync("");
    }

    [HttpPost("{id}/labels")]
    [SwaggerOperation(
        Summary = "Create a label",
        Description = "Requires admin privileges",
        OperationId = "Create a label",
        Tags = new[] { "Labels" }
    )]
    public async Task CreateLabel([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, LabelDto label)
    {
        await _httpClient.PostAsJsonAsync("", label);
    }

    [HttpPut("{id}/labels/{label_id}")]
    [SwaggerOperation(
        Summary = "Update a label",
        Description = "Requires admin privileges",
        OperationId = "Update a label",
        Tags = new[] { "Labels" }
    )]
    public async Task UpdateLabel([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int label_id, LabelDto label)
    {
        await _httpClient.PutAsJsonAsync("", label);
    }

    [HttpDelete("{id}/labels/{label_id}")]
    [SwaggerOperation(
        Summary = "Delete a label",
        Description = "Requires admin privileges",
        OperationId = "Delete a label",
        Tags = new[] { "Labels" }
    )]
    public async Task DeleteLabel([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int label_id)
    {
        await _httpClient.DeleteAsync("");
    }
}

public class ProjectValidator : AbstractValidator<Gitlab.Dto.ProjectDto>
{
    public ProjectValidator()
    {
        RuleFor(x => x.name).NotEmpty().Length(3, 20).NotNull();
    }
}