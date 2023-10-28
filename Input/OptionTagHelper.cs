using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Input;

public class OptionTagHelper : TagHelper
{
    public string? Value { get; set; }
    public string? Id { get; set; }
    public string? Style { get; set; }
    public bool? Hide { get; set; }
    public bool? AllowDeselect { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "option";
        output.TagMode = TagMode.StartTagAndEndTag;
        if (!string.IsNullOrEmpty(Value))
        {
            output.Attributes.Add("value", Value);
        }

        if (!string.IsNullOrEmpty(Style))
        {
            output.Attributes.Add("style", Style);
        }

        if (!string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }

        if (Hide != null)
        {
            output.Attributes.Add("hide", Hide);
        }

        if (AllowDeselect != null)
        {
            output.Attributes.Add("allow-deselect", AllowDeselect);
        }
    }
}