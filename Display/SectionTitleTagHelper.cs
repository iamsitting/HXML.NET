using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class SectionTitleTagHelper : AbstractBehaviorTagHelper
{
    public string? Style { get; set; }
    public string? Id { get; set; }
    public bool? Hide { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.TagName = "section-title";
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
    }
}