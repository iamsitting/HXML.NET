using HXML.NET.Styles.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Styles;

public class StyleTagHelper : TagHelper, IStyleTextRules, ILayoutRules, IViewRules
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "style";
        output.TagMode = TagMode.SelfClosing;
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
        
        if (!string.IsNullOrEmpty(AspectRatio))
        {
            output.Attributes.Add("aspect-ratio", AspectRatio);
        }
        if (!string.IsNullOrEmpty(AlignContent))
        {
            output.Attributes.Add("align-content", AlignContent);
        }
        if (!string.IsNullOrEmpty(AlignItems))
        {
            output.Attributes.Add("align-items", AlignItems);
        }
        if (!string.IsNullOrEmpty(AlignSelf))
        {
            output.Attributes.Add("align-self", AlignSelf);
        }
        if (BorderWidth != null)
        {
            output.Attributes.Add("border-width", BorderWidth);
        }
        if (BorderBottomWidth != null)
        {
            output.Attributes.Add("border-bottom-width", BorderBottomWidth);
        }
        if (BorderLeftWidth != null)
        {
            output.Attributes.Add("border-left-width", BorderLeftWidth);
        }
        if (BorderRightWidth != null)
        {
            output.Attributes.Add("border-right-width", BorderRightWidth);
        }
        if (BorderTopWidth != null)
        {
            output.Attributes.Add("border-top-width", BorderTopWidth);
        }
        if (!string.IsNullOrEmpty(Display))
        {
            output.Attributes.Add("display", Display);
        }
        if (!string.IsNullOrEmpty(JustifyContent))
        {
            output.Attributes.Add("justify-content", JustifyContent);
        }
        if (!string.IsNullOrEmpty(Overflow))
        {
            output.Attributes.Add("overflow", Overflow);
        }
        if (Flex != null)
        {
            output.Attributes.Add("flex", Flex);
        }
        if (!string.IsNullOrEmpty(FlexBasis))
        {
            output.Attributes.Add("flex-basis", FlexBasis);
        }
        if (!string.IsNullOrEmpty(FlexDirection))
        {
            output.Attributes.Add("flex-direction", FlexDirection);
        }
        if (FlexGrow != null)
        {
            output.Attributes.Add("flex-grow", FlexGrow);
        }
        if (FlexShrink != null)
        {
            output.Attributes.Add("flex-shrink", FlexShrink);
        }
        if (!string.IsNullOrEmpty(FlexWrap))
        {
            output.Attributes.Add("flex-wrap", FlexWrap);
        }
        if (!string.IsNullOrEmpty(Margin))
        {
            output.Attributes.Add("margin", Margin);
        }
        if (!string.IsNullOrEmpty(MarginBottom))
        {
            output.Attributes.Add("margin-bottom", MarginBottom);
        }
        if (!string.IsNullOrEmpty(MarginHorizontal))
        {
            output.Attributes.Add("margin-horizontal", MarginHorizontal);
        }
        if (!string.IsNullOrEmpty(MarginLeft))
        {
            output.Attributes.Add("margin-left", MarginLeft);
        }
        if (!string.IsNullOrEmpty(MarginRight))
        {
            output.Attributes.Add("margin-right", MarginRight);
        }
        if (!string.IsNullOrEmpty(MarginTop))
        {
            output.Attributes.Add("margin-top", MarginTop);
        }
        if (!string.IsNullOrEmpty(MarginVertical))
        {
            output.Attributes.Add("margin-vertical", MarginVertical);
        }
        if (!string.IsNullOrEmpty(Padding))
        {
            output.Attributes.Add("padding", Padding);
        }
        if (!string.IsNullOrEmpty(PaddingBottom))
        {
            output.Attributes.Add("padding-bottom", PaddingBottom);
        }
        if (!string.IsNullOrEmpty(PaddingHorizontal))
        {
            output.Attributes.Add("padding-horizontal", PaddingHorizontal);
        }
        if (!string.IsNullOrEmpty(PaddingLeft))
        {
            output.Attributes.Add("padding-left", PaddingLeft);
        }
        if (!string.IsNullOrEmpty(PaddingRight))
        {
            output.Attributes.Add("padding-right", PaddingRight);
        }
        if (!string.IsNullOrEmpty(PaddingTop))
        {
            output.Attributes.Add("padding-top", PaddingTop);
        }
        if (!string.IsNullOrEmpty(PaddingVertical))
        {
            output.Attributes.Add("padding-vertical", PaddingVertical);
        }
        if (!string.IsNullOrEmpty(Position))
        {
            output.Attributes.Add("position", Position);
        }
        if (!string.IsNullOrEmpty(Left))
        {
            output.Attributes.Add("left", Left);
        }
        if (!string.IsNullOrEmpty(Right))
        {
            output.Attributes.Add("right", Right);
        }
        if (!string.IsNullOrEmpty(Top))
        {
            output.Attributes.Add("top", Top);
        }
        if (!string.IsNullOrEmpty(Bottom))
        {
            output.Attributes.Add("bottom", Bottom);
        }
        if (!string.IsNullOrEmpty(Height))
        {
            output.Attributes.Add("height", Height);
        }
        if (!string.IsNullOrEmpty(MaxHeight))
        {
            output.Attributes.Add("max-height", MaxHeight);
        }
        if (!string.IsNullOrEmpty(MaxWidth))
        {
            output.Attributes.Add("max-width", MaxWidth);
        }
        if (!string.IsNullOrEmpty(MinHeight))
        {
            output.Attributes.Add("min-height", MinHeight);
        }
        if (!string.IsNullOrEmpty(MinWidth))
        {
            output.Attributes.Add("min-width", MinWidth);
        }
        if (!string.IsNullOrEmpty(Width))
        {
            output.Attributes.Add("width", Width);
        }
        if (ZIndex != null)
        {
            output.Attributes.Add("z-index", ZIndex);
        }
        if (!string.IsNullOrEmpty(BorderColor))
        {
            output.Attributes.Add("border-color", BorderColor);
        }
        if (!string.IsNullOrEmpty(BorderLeftColor))
        {
            output.Attributes.Add("border-left-color", BorderLeftColor);
        }
        if (!string.IsNullOrEmpty(BorderRightColor))
        {
            output.Attributes.Add("border-right-color", BorderRightColor);
        }
        if (!string.IsNullOrEmpty(BorderBottomColor))
        {
            output.Attributes.Add("border-bottom-color", BorderBottomColor);
        }
        if (!string.IsNullOrEmpty(BorderTopColor))
        {
            output.Attributes.Add("border-top-color", BorderTopColor);
        }
        if (BorderRadius != null)
        {
            output.Attributes.Add("border-radius", BorderRadius);
        }
        if (BorderBottomLeftRadius != null)
        {
            output.Attributes.Add("border-bottom-left-radius", BorderBottomLeftRadius);
        }
        if (BorderBottomRightRadius != null)
        {
            output.Attributes.Add("border-bottom-right-radius", BorderBottomRightRadius);
        }
        if (BorderTopLeftRadius != null)
        {
            output.Attributes.Add("border-top-left-radius", BorderTopLeftRadius);
        }
        if (BorderTopRightRadius != null)
        {
            output.Attributes.Add("border-top-right-radius", BorderTopRightRadius);
        }
        if (!string.IsNullOrEmpty(BackgroundColor))
        {
            output.Attributes.Add("background-color", BackgroundColor);
        }
        if (!string.IsNullOrEmpty(BorderStyle))
        {
            output.Attributes.Add("border-style", BorderStyle);
        }
        if (!string.IsNullOrEmpty(Elevation))
        {
            output.Attributes.Add("elevation", Elevation);
        }
        if (!string.IsNullOrEmpty(Opacity))
        {
            output.Attributes.Add("opacity", Opacity);
        }
        if (!string.IsNullOrEmpty(ShadowColor))
        {
            output.Attributes.Add("shadow-color", ShadowColor);
        }
        if (ShadowOffsetX != null)
        {
            output.Attributes.Add("shadow-offset-x", ShadowOffsetX);
        }
        if (ShadowOffsetY != null)
        {
            output.Attributes.Add("shadow-offset-y", ShadowOffsetY);
        }
        if (ShadowOpacity != null)
        {
            output.Attributes.Add("shadow-opacity", ShadowOpacity);
        }
        if (ShadowRadius != null)
        {
            output.Attributes.Add("shadow-radius", ShadowRadius);
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
    public string? AspectRatio { get; set; }
    public string? AlignContent { get; set; }
    public string? AlignItems { get; set; }
    public string? AlignSelf { get; set; }
    public int? BorderBottomWidth { get; set; }
    public int? BorderLeftWidth { get; set; }
    public int? BorderRightWidth { get; set; }
    public int? BorderTopWidth { get; set; }
    public int? BorderWidth { get; set; }
    public string? Display { get; set; }
    public string? JustifyContent { get; set; }
    public string? Overflow { get; set; }
    public int? Flex { get; set; }
    public string? FlexBasis { get; set; }
    public string? FlexDirection { get; set; }
    public int? FlexGrow { get; set; }
    public int? FlexShrink { get; set; }
    public string? FlexWrap { get; set; }
    public string? Margin { get; set; }
    public string? MarginBottom { get; set; }
    public string? MarginHorizontal { get; set; }
    public string? MarginLeft { get; set; }
    public string? MarginRight { get; set; }
    public string? MarginTop { get; set; }
    public string? MarginVertical { get; set; }
    public string? Padding { get; set; }
    public string? PaddingBottom { get; set; }
    public string? PaddingHorizontal { get; set; }
    public string? PaddingLeft { get; set; }
    public string? PaddingRight { get; set; }
    public string? PaddingTop { get; set; }
    public string? PaddingVertical { get; set; }
    public string? Position { get; set; }
    public string? Left { get; set; }
    public string? Right { get; set; }
    public string? Top { get; set; }
    public string? Bottom { get; set; }
    public string? Height { get; set; }
    public string? MaxHeight { get; set; }
    public string? MaxWidth { get; set; }
    public string? MinHeight { get; set; }
    public string? MinWidth { get; set; }
    public string? Width { get; set; }
    public int? ZIndex { get; set; }
    public string? BorderColor { get; set; }
    public string? BorderLeftColor { get; set; }
    public string? BorderRightColor { get; set; }
    public string? BorderBottomColor { get; set; }
    public string? BorderTopColor { get; set; }
    public int? BorderRadius { get; set; }
    public int? BorderBottomLeftRadius { get; set; }
    public int? BorderBottomRightRadius { get; set; }
    public int? BorderTopLeftRadius { get; set; }
    public int? BorderTopRightRadius { get; set; }
    public string? BackgroundColor { get; set; }
    public string? BorderStyle { get; set; }
    public string? Elevation { get; set; }
    public string? Opacity { get; set; }
    public string? ShadowColor { get; set; }
    public int? ShadowOffsetX { get; set; }
    public int? ShadowOffsetY { get; set; }
    public float? ShadowOpacity { get; set; }
    public int? ShadowRadius { get; set; }
}
