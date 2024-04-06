using Claudia;

namespace AiChatUi.Models;

public class ChatContext
{
    public Guid ChatId { get; set; } = Guid.NewGuid();
    public string ChatTitle { get; set; } = "New Chat";
    public string SystemInput { get; set; } = SystemPrompts.Claude3;
    public double Temperature { get; set; }
    public string TextInput { get; set; } = string.Empty;
    public List<Message> ChatMessages { get; set; } = new();
    public string SelectedModel { get; set; } = string.Empty;
    public DateTimeOffset LastMessageTime { get; set; } = DateTimeOffset.Now;
}