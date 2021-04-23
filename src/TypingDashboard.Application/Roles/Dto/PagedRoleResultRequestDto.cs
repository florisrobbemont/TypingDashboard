using Abp.Application.Services.Dto;

namespace TypingDashboard.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

