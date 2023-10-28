using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Input;

public class TextAreaTagHelper : AbstractBehaviorTagHelper
{
    public string Name { get; set; } = null!;
    public string? Value { get; set; }
    public string? Placeholder { get; set; }
    public string? Style { get; set; }
    public string? Id { get; set; }
    public bool? Hide { get; set; }
    public string? TextContentType { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.TagName = "text-area";
        output.TagMode = TagMode.SelfClosing;
        output.Attributes.Add("name", Name);
        if (!string.IsNullOrEmpty(Value))
        {
            output.Attributes.Add("value", Value);
        }
        if (!string.IsNullOrEmpty(Placeholder))
        {
            output.Attributes.Add("placeholder", Placeholder);
        }
        if (!string.IsNullOrEmpty(Style))
        {
            output.Attributes.Add("style", Style);
        }
        if (!string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }
        if (!string.IsNullOrEmpty(TextContentType))
        {
            output.Attributes.Add("text-content-type", TextContentType);
        }

        if (Hide != null)
        {
            output.Attributes.Add("hide", Hide);
        }
            
    }
}