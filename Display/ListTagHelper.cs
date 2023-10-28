using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class ListTagHelper : AbstractBehaviorTagHelper
{
    public string? Style { get; set; }
    public int? ItemHeight { get; set; }
    public string? Id { get; set; }
    public bool? Hide { get; set; }
    public string? ScrollOrientation { get; set; }
    public bool? ShowsScrollIndicator { get; set; }
    public string? KeyboardDismissMode { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.TagName = "list";
        output.TagMode = TagMode.StartTagAndEndTag;
        if (!string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }
        
        if (!string.IsNullOrEmpty(Style))
        {
            output.Attributes.Add("style", Style);
        }
        
        if (!string.IsNullOrEmpty(ScrollOrientation))
        {
            output.Attributes.Add("scroll-orientation", ScrollOrientation);
        }
        
        if (!string.IsNullOrEmpty(KeyboardDismissMode))
        {
            output.Attributes.Add("keyboard-dismiss-mode", KeyboardDismissMode);
        }
        
        if (ShowsScrollIndicator != null)
        {
            output.Attributes.Add("shows-scroll-indicator", ShowsScrollIndicator);
        }
        
        if (ItemHeight != null)
        {
            output.Attributes.Add("itemHeight", ItemHeight);
        }

        if (Hide != null)
        {
            output.Attributes.Add("hide", Hide);
        }
    }
}