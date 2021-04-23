using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace TypingDashboard.Typings.Dto
{
    [AutoMapTo(typeof(Typing))]
    public class CreateTypingDto
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
