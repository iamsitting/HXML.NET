using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Styles;

public class ModifierTagHelper : TagHelper
{
    public bool? Focused { get; set; }
    public bool? Pressed { get; set; }
    public bool? Selected { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "modifier";
        output.TagMode = TagMode.StartTagAndEndTag;
        if (Focused != null)
        {
            output.Attributes.Add("focused", Focused);
        }

        if (Pressed != null)
        {
            output.Attributes.Add("pressed", Pressed);
        }

        if (Selected != null)
        {
            output.Attributes.Add("selected", Selected);
        }
    }
}