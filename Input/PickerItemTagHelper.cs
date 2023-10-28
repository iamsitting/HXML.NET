using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Input;

public class PickerItemTagHelper : TagHelper
{
    public string Label { get; set; } = null!;
    public string? Value { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "picker-item";
        output.TagMode = TagMode.StartTagAndEndTag;
        output.Attributes.Add("label", Label);
        if (!string.IsNullOrEmpty(Value))
        {
            output.Attributes.Add("value", Value);
        }
    }
}