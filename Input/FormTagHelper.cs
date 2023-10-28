using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Input;

public class FormTagHelper : TagHelper
{
    public string? Id { get; set; }
    public string? Style { get; set; }
    public bool? Hide { get; set; }
    public bool? Scroll { get; set; }
    public string? ScrollOrientation { get; set; }
    public bool? ShowsScrollIndicator { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "form";
        output.TagMode = TagMode.StartTagAndEndTag;
        if (!string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }
        
        if (!string.IsNullOrEmpty(Style))
        {
            output.Attributes.Add("style", Style);
        }

        if (Hide != null)
        {
            output.Attributes.Add("hide", Hide);
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