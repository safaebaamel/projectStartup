using System.ComponentModel.DataAnnotations;
using FluentValidation;
using Swashbuckle.AspNetCore.Annotations;

namespace Gitlab.Dto
{
    public class ProjectDto {

        [Required]
        
        public string? name { get; set; }
    }

    public class IssueDto {
        
        public string? title { get; set; }
        public string? description { get; set; }

    }

    public class CommentDto {
        public string? body { get; set; }
    }

    public class LabelDto {
        public string? name { get; set; }

        public string? color { get; set; }
    }

}

