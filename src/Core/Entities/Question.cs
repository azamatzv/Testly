using Core.Common;
using Core.Enums;

namespace Core.Entities;

public class Question : BaseEntity
{
    public string Text { get; set; } // Savol matni
    public Guid SubjectId { get; set; } // Fan ID
    public Subject Subject { get; set; } // Foreign key
    public Guid? ImageId { get; set; } // Rasm ID
    public Download? Image { get; set; } // Foreign key
    public Level QuestionLevel { get; set; } // Savol darajasi
}