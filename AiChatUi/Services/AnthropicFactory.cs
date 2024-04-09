using Claudia;

namespace AiChatUi.Services;

public class AnthropicFactory
{
    public static Anthropic Create(string apiKey)
    {
        var anthropic = new Anthropic()
        {
            ApiKey = apiKey
        };
        return anthropic;
    }
}