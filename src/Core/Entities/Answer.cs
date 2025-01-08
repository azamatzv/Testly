using Core.Common;

namespace Core.Entities;

public class Answer : BaseEntity
{
    public string Text { get; set; } // Javob matni
    public bool IsCorrect { get; set; } // Tog'ri yoki noto'g'ri
    public Guid? QuestionId { get; set; } // Savolga tegishli ID
    public Question Questions { get; set; } // Foreign key
}