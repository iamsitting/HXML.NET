using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class TextTagHelper : AbstractBehaviorTagHelper
{
    public string? Style { get; set; }
    public string? Id { get; set; }
    public bool? Hide { get; set; }
    public int? NumberOfLines { get; set; }
    public bool? Selectable { get; set; }
    public bool? AdjustsFontSizeToFit { get; set; }
    public bool? Preformatted { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.TagName = "text";
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
        
        if (NumberOfLines != null)
        {
            output.Attributes.Add("numberOfLines", NumberOfLines);
        }
        if (Selectable != null)
        {
            output.Attributes.Add("selectable", Selectable);
        }
        if (AdjustsFontSizeToFit != null)
        {
            output.Attributes.Add("adjustsFontSizeToFit", AdjustsFontSizeToFit);
        }
        if (Preformatted != null)
        {
            output.Attributes.Add("preformatted", Preformatted);
        }
    }
}