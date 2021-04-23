using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using TypingDashboard.Authorization.Users;

namespace TypingDashboard.Typings
{
    [Table("Typings", Schema = "ops")]
    public class Typing : AuditedEntity, IMayHaveTenant
    {
        public const int DefaultMaxLength = DataConstants.VarCharTitleLength;
        public const int DescriptionMaxLength = DataConstants.VarCharMaxLength;

        // Relations
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        public long UserId { get; set; }

        public int? TenantId { get; set; }

        [Required]
        [StringLength(DefaultMaxLength)]
        public string Person { get; set; }

        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [StringLength(DefaultMaxLength)]
        public string FullType { get; set; }

        [StringLength(DefaultMaxLength)]
        public string OfficialType { get; set; }
    }
}
