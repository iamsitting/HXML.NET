using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Styles;

public class StylesTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "styles";
        output.TagMode = TagMode.StartTagAndEndTag;
    }
}