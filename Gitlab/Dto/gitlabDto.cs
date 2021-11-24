using FluentValidation;

namespace Gitlab.Dto
{
    public class ProjectDto {
        
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

