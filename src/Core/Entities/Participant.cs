using Core.Common;
using Core.Enums;

namespace Core.Entities;

public class Participant : BaseEntity, IAuditedEntity
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; } = Role.User;
    public string? CreatedBy { get; set; }
    public DateTime? CreatedOn { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}