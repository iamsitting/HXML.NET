using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Input;

public class SwitchTagHelper : AbstractBehaviorTagHelper
{
    public string Name { get; set; } = null!;
    public string? Value { get; set; }
    public string? Id { get; set; }
    public bool? Hide { get; set; }
    public string? Style { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.TagName = "switch";
        output.TagMode = TagMode.SelfClosing;
        
        output.Attributes.Add("name", Name);

        if (string.IsNullOrEmpty(Value))
        {
            output.Attributes.Add("value", Value);
        }
        
        if (string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }
        
        if (string.IsNullOrEmpty(Style))
        {
            output.Attributes.Add("style", Style);
        }

        if (Hide != null)
        {
            output.Attributes.Add("hide", Hide);
        }
    }
}