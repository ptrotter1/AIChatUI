using Claudia;
using Markdig;
using Markdig.SyntaxHighlighting;

namespace AiChatUi.Extensions;

public static class ClaudiaMessageExtensions
{
    public static string ToHtml(this Message message)
    {
        var pipeline = new MarkdownPipelineBuilder()
            .UseSyntaxHighlighting()
            .Build();
        return Markdown.ToHtml(message.Content[0].Text ?? string.Empty, pipeline);
    }
    
    public static string ToPlainText(this Message message)
    {
        return (message.Content[0].Text ?? string.Empty).ReplaceLineEndings("<br />");
    }
}