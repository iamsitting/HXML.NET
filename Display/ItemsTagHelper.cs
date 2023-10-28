using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class ItemsTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "items";
        output.TagMode = TagMode.StartTagAndEndTag;
    }
}