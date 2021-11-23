using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;
using Gitlab.Dto;

namespace gitlab.Controllers;

[Route("projects")]
[Produces("application/json")]
[ApiController]

public class GitlabController : ControllerBase
{
    // GET: api/Gitlab
    [HttpGet]
    public void test([FromHeader(Name = "PRIVATE-TOKEN")] string token)
    {
        Console.WriteLine("test");
    }
}