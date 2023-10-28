using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class BodyTagHelper : AbstractBehaviorTagHelper
{
    public bool? SafeArea { get; set; } = false;
    public string? Style { get; set; }
    public bool? Scroll { get; set; } = false;
    public string? ScrollOrientation { get; set; } = Orientations.Vertical;
    public bool? ShowsScrollIndicator { get; set; } = true;
    public string? Id { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.TagName = "body";
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

        if (Scroll != null)
        {
            output.Attributes.Add("scroll", Scroll);
        }
        
        if (!string.IsNullOrEmpty(ScrollOrientation))
        {
            output.Attributes.Add("scroll-orientation", ScrollOrientation);
        }
        
        if (ShowsScrollIndicator != null)
        {
            output.Attributes.Add("shows-scroll-indicator", ShowsScrollIndicator);
        }
    }
}