using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class ScreenTagHelper : TagHelper
{
    public string? Id { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "screen";
        output.TagMode = TagMode.StartTagAndEndTag;
        if (!string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }
    }
}