using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class SpinnerTagHelper : TagHelper
{
    public string? Color { get; set; }
    public string? Id { get; set; }
    public bool? Hide { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "spinner";
        output.TagMode = TagMode.SelfClosing;
        if (!string.IsNullOrEmpty(Color))
        {
            output.Attributes.Add("color", Color);
        }
        
        if (!string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }
        
        if (Hide != null)
        {
            output.Attributes.Add("hide", Hide);
        }
    }
}