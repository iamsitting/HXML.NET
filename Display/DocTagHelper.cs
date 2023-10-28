using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class DocTagHelper : TagHelper
{
    public string Xmlns { get; set; } = null!;
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "doc";
        output.TagMode = TagMode.StartTagAndEndTag;
        output.Attributes.Add("xmlns", Xmlns);
    }
}