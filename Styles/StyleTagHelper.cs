using HXML.NET.Styles.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Styles;

public class StyleTagHelper : TagHelper, IStyleTextRules
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "style";
        output.TagMode = TagMode.StartTagAndEndTag;
        if (!string.IsNullOrEmpty(Color))
        {
            output.Attributes.Add("color", Color);
        }
        if (!string.IsNullOrEmpty(FontStyle))
        {
            output.Attributes.Add("fontStyle", FontStyle);
        }
        if (!string.IsNullOrEmpty(FontWeight))
        {
            output.Attributes.Add("fontWeight", FontWeight);
        }
        if (!string.IsNullOrEmpty(TextAlign))
        {
            output.Attributes.Add("textAlign", TextAlign);
        }
        if (!string.IsNullOrEmpty(TextShadowColor))
        {
            output.Attributes.Add("textShadowColor", TextShadowColor);
        }
        if (FontSize != null)
        {
            output.Attributes.Add("fontSize", FontSize);
        }
        if (LineHeight != null)
        {
            output.Attributes.Add("lineHeight", LineHeight);
        }
    }

    public string? Color { get; set; }
    public int? FontSize { get; set; }
    public string? FontStyle { get; set; }
    public string? FontWeight { get; set; }
    public int? LineHeight { get; set; }
    public string? TextAlign { get; set; }
    public string? TextShadowColor { get; set; }
    public string? FontFamily { get; set; }
    public int? TextShadowRadius { get; set; }
}