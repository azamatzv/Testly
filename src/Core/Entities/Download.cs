using Core.Common;

namespace Core.Entities;

public class Download : BaseEntity
{
    public string Path { get; set; } // Yo'li yoki Url
    public IEnumerable<Question>? QuestionData { get; set; } = new List<Question>();
    public IEnumerable<Answer>? AnswerData { get; set; } = new List<Answer>();
}