using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class BodyTagHelper : TagHelper
{
    public bool SafeArea { get; set; } = false;
    public string? Style { get; set; }
    public bool Scroll { get; set; } = false;
    public string ScrollOrientation { get; set; } = Orientations.Vertical;
    public bool ShowsScrollIndicator { get; set; } = true;
    public string? Id { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "body";
        output.TagMode = TagMode.StartTagAndEndTag;
        output.Attributes.Add("id", Id);
        output.Attributes.Add("style", Style);
        output.Attributes.Add("safe-area", SafeArea);
        output.Attributes.Add("scroll", Scroll);
        output.Attributes.Add("scroll-orientation", ScrollOrientation);
        output.Attributes.Add("shows-scroll-indicator", ShowsScrollIndicator);
    }
}