using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class ItemTagHelper : AbstractBehaviorTagHelper
{
    public string Key { get; set; } = null!;
    public string? Sticky { get; set; }
    public string? Style { get; set; }
    public string? Id { get; set; }
    public bool? Hide { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.TagName = "item";
        output.TagMode = TagMode.StartTagAndEndTag;
        output.Attributes.Add("key", Key);
        if (!string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }
        
        if (!string.IsNullOrEmpty(Style))
        {
            output.Attributes.Add("style", Style);
        }
        
        if (!string.IsNullOrEmpty(Sticky))
        {
            output.Attributes.Add("sticky", Sticky);
        }

        if (Hide != null)
        {
            output.Attributes.Add("hide", Hide);
        }
    }
}