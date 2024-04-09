using Claudia;

namespace AiChatUi.Models;

public class ChatContext
{
    public Guid ChatId { get; set; } = Guid.NewGuid();
    public string ChatTitle { get; set; } = "New Chat";
    public string SystemInput { get; set; } = SystemPrompts.Claude3;
    public double Temperature { get; set; } = 0.7;
    public string TextInput { get; set; } = string.Empty;
    public List<Message> ChatMessages { get; set; } = new();
    public string SelectedModel { get; set; } = string.Empty;
    public DateTimeOffset LastMessageTime { get; set; } = DateTimeOffset.Now;
    public string TextAreaHeight { get; set; } = "4rem";
    public int MaxMessages { get; set; } = 10;
}