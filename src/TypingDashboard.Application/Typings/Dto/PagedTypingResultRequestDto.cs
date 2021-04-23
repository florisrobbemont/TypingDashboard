using Abp.Application.Services.Dto;

namespace TypingDashboard.Typings.Dto
{
    public class PagedTypingResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

