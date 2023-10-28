using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.DisplayElements;

public class DocTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "doc";
        output.TagMode = TagMode.StartTagAndEndTag;
        output.Attributes.Add("xmlns", "https://hyperview.org/hyperview");
    }
}