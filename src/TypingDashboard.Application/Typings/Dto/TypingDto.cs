using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.MultiTenancy;

namespace TypingDashboard.Typings.Dto
{
    [AutoMapFrom(typeof(Typing))]
    public class TypingDto : EntityDto
    {
        public long UserId { get; set; }

        public int? TenantId { get; set; }

        [Required]
        [StringLength(Typing.DefaultMaxLength)]
        public string Person { get; set; }

        [StringLength(Typing.DescriptionMaxLength)]
        public string Description { get; set; }

        [StringLength(Typing.DefaultMaxLength)]
        public string FullType { get; set; }

        [StringLength(Typing.DefaultMaxLength)]
        public string OfficialType { get; set; }
    }
}
