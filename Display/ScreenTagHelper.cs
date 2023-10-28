using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.DisplayElements;

public class ScreenTagHelper : TagHelper
{
    public string? Id { get; set; }
    public string? Style { get; set; }
    public bool SafeArea { get; set; } = false;
    public bool Hide { get; set; } = false;

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "screen";
        output.TagMode = TagMode.StartTagAndEndTag;
        output.Attributes.Add("id", Id);
        output.Attributes.Add("style", Style);
        output.Attributes.Add("safe-area", SafeArea);
        output.Attributes.Add("hide", Hide);
    }
}