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

    private readonly HttpClient _httpClient = new HttpClient();

    // GET: api/Gitlab
    [HttpGet]
    [SwaggerOperation(
        Summary = "Get all projects",
        Description = "Requires admin privileges",
        OperationId = "Get all projects",
        Tags = new[] { "Projects" }
    )]
    public async Task<HttpResponseMessage> GetProjects([FromHeader(Name = "PRIVATE-TOKEN")] string token)
    {
        return await _httpClient.GetAsync("");

    }

    // POST: api/Gitlab
    [HttpPost]
    [SwaggerOperation(
        Summary = "Create a new project",
        Description = "Requires admin privileges",
        OperationId = "Create a new project",
        Tags = new[] { "Projects" }

    )]
    public async Task CreateProject([FromHeader(Name = "PRIVATE-TOKEN")] string token, ProjectDto project)
    {
        return await _httpClient.PostAsync("", project);
    }

    [HttpGet("{id}")]
    [SwaggerOperation(
        Summary = "Get a project",
        Description = "Requires admin privileges",
        OperationId = "Get a project",
        Tags = new[] { "Projects" }
    )]
    public void GetProject([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id)
    {
        
    }

    [HttpPut("{id}")]
    [SwaggerOperation(
        Summary = "Update a project",
        Description = "Requires admin privileges",
        OperationId = "Update a project",
        Tags = new[] { "Projects" }
    )]
    public void UpdateProject([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, ProjectDto project)
    {
        
    }

    [HttpDelete("{id}")]
    [SwaggerOperation(
        Summary = "Delete a project",
        Description = "Requires admin privileges",
        OperationId = "Delete a project",
        Tags = new[] { "Projects" }
    )]
    public void DeleteProject([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id)
    {
        
    }

    // issues
    [HttpGet("{id}/issues")]
    [SwaggerOperation(
        Summary = "Get all issues",
        Description = "Requires admin privileges",
        OperationId = "Get all issues",
        Tags = new[] { "Issues" }
    )]
    public void GetIssues([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id)
    {
        
    }

    [HttpGet("{id}/issues/{issue_iid}")]
    [SwaggerOperation(
        Summary = "Get an issue",
        Description = "Requires admin privileges",
        OperationId = "Get an issue",
        Tags = new[] { "Issues" }
    )]
    public void GetIssue([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid)
    {
        
    }

    [HttpPost("{id}/issues")]
    [SwaggerOperation(
        Summary = "Create an issue",
        Description = "Requires admin privileges",
        OperationId = "Create an issue",
        Tags = new[] { "Issues" }
    )]
    public void CreateIssue([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, IssueDto issue)
    {
        
    }

    [HttpPut("{id}/issues/{issue_iid}")]
    [SwaggerOperation(
        Summary = "Update an issue",
        Description = "Requires admin privileges",
        OperationId = "Update an issue",
        Tags = new[] { "Issues" }
    )]
    public void UpdateIssue([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid, IssueDto issue)
    {
        
    }

    [HttpDelete("{id}/issues/{issue_iid}")]
    [SwaggerOperation(
        Summary = "Delete an issue",
        Description = "Requires admin privileges",
        OperationId = "Delete an issue",
        Tags = new[] { "Issues" }
    )]
    public void DeleteIssue([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid)
    {
        
    }

    // comment on an issue
    [HttpPost("{id}/issues/{issue_iid}/notes")]
    [SwaggerOperation(
        Summary = "Create a comment on an issue",
        Description = "Requires admin privileges",
        OperationId = "Create a comment on an issue",
        Tags = new[] { "Issues" }
    )]
    public void CreateComment([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid, CommentDto comment)
    {
        
    }

    [HttpGet("{id}/issues/{issue_iid}/notes")]
    [SwaggerOperation(
        Summary = "Get all comments on an issue",
        Description = "Requires admin privileges",
        OperationId = "Get all comments on an issue",
        Tags = new[] { "Issues" }
    )]
    public void GetComments([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid)
    {
        
    }

    [HttpGet("{id}/issues/{issue_iid}/notes/{note_id}")]
    [SwaggerOperation(
        Summary = "Get a comment on an issue",
        Description = "Requires admin privileges",
        OperationId = "Get a comment on an issue",
        Tags = new[] { "Issues" }
    )]
    public void GetComment([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid, int note_id)
    {
        
    }

    [HttpPut("{id}/issues/{issue_iid}/notes/{note_id}")]
    [SwaggerOperation(
        Summary = "Update a comment on an issue",
        Description = "Requires admin privileges",
        OperationId = "Update a comment on an issue",
        Tags = new[] { "Issues" }
    )]
    public void UpdateComment([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid, int note_id, CommentDto comment)
    {
        
    }

    [HttpDelete("{id}/issues/{issue_iid}/notes/{note_id}")]
    [SwaggerOperation(
        Summary = "Delete a comment on an issue",
        Description = "Requires admin privileges",
        OperationId = "Delete a comment on an issue",
        Tags = new[] { "Issues" }
    )]
    public void DeleteComment([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int issue_iid, int note_id)
    {
        
    }

    // labels
    [HttpGet("{id}/labels")]
    [SwaggerOperation(
        Summary = "Get all labels",
        Description = "Requires admin privileges",
        OperationId = "Get all labels",
        Tags = new[] { "Labels" }
    )]
    public void GetLabels([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id)
    {
        
    }

    [HttpGet("{id}/labels/{label_id}")]
    [SwaggerOperation(
        Summary = "Get a label",
        Description = "Requires admin privileges",
        OperationId = "Get a label",
        Tags = new[] { "Labels" }
    )]
    public void GetLabel([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int label_id)
    {
        
    }

    [HttpPost("{id}/labels")]
    [SwaggerOperation(
        Summary = "Create a label",
        Description = "Requires admin privileges",
        OperationId = "Create a label",
        Tags = new[] { "Labels" }
    )]
    public void CreateLabel([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, LabelDto label)
    {
        
    }

    [HttpPut("{id}/labels/{label_id}")]
    [SwaggerOperation(
        Summary = "Update a label",
        Description = "Requires admin privileges",
        OperationId = "Update a label",
        Tags = new[] { "Labels" }
    )]
    public void UpdateLabel([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int label_id, LabelDto label)
    {
        
    }

    [HttpDelete("{id}/labels/{label_id}")]
    [SwaggerOperation(
        Summary = "Delete a label",
        Description = "Requires admin privileges",
        OperationId = "Delete a label",
        Tags = new[] { "Labels" }
    )]
    public void DeleteLabel([FromHeader(Name = "PRIVATE-TOKEN")] string token, int id, int label_id)
    {
        
    }
}

public class ProjectValidator : AbstractValidator<Gitlab.Dto.ProjectDto>
{
    public ProjectValidator()
    {
        RuleFor(x => x.name).NotEmpty().Length(3, 20).NotNull();
    }
}