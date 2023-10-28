using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class SectionListTagHelper : AbstractBehaviorTagHelper
{
    public string? Style { get; set; }
    public string? Id { get; set; }
    public bool? Hide { get; set; }
    public string? StickySectionTitles { get; set; }
    public string? KeyboardDismissMode { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.TagName = "section-list";
        output.TagMode = TagMode.StartTagAndEndTag;
        if (!string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }
        
        if (!string.IsNullOrEmpty(Style))
        {
            output.Attributes.Add("style", Style);
        }
        if (!string.IsNullOrEmpty(StickySectionTitles))
        {
            output.Attributes.Add("sticky-section-titles", StickySectionTitles);
        }
        if (!string.IsNullOrEmpty(KeyboardDismissMode))
        {
            output.Attributes.Add("keyboard-dismiss-mode", KeyboardDismissMode);
        }

        if (Hide != null)
        {
            output.Attributes.Add("hide", Hide);
        }
    }
}