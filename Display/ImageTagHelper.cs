using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class ImageTagHelper : AbstractBehaviorTagHelper
{
    public string Source { get; set; } = null!;
    public string Style { get; set; } = null!;
    public string? Id { get; set; }
    public bool? Hide { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.TagName = "image";
        output.TagMode = TagMode.SelfClosing;
        output.Attributes.Add("source", Source);
        output.Attributes.Add("style", Style);
        if (Hide != null)
        {
            output.Attributes.Add("hide", Hide);
        }
        if (!string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }
        
    }
}