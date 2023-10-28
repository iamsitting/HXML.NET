using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Input;

public class SelectSingleTagHelper : TagHelper
{
    public string Name { get; set; } = null!;
    public string? Id { get; set; }
    public string? Style { get; set; }
    public bool? Hide { get; set; }
    public bool? AllowDeselect { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "select-single";
        output.TagMode = TagMode.StartTagAndEndTag;
        output.Attributes.Add("name", Name);

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