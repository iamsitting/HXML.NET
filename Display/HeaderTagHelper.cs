using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class HeaderTagHelper : AbstractBehaviorTagHelper
{
    public string? Id { get; set; }
    public string? Style { get; set; }
    public bool? SafeArea { get; set; } = false;
    public bool? Hide { get; set; } = false;

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.TagName = "header";
        output.TagMode = TagMode.StartTagAndEndTag;
        if (!string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }
        
        if (!string.IsNullOrEmpty(Style))
        {
            output.Attributes.Add("style", Style);
        }
        
        if (SafeArea != null)
        {
            output.Attributes.Add("safe-area", SafeArea);
        }
        
        if (Hide != null)
        {
            output.Attributes.Add("hide", Hide);
        }
    }
}