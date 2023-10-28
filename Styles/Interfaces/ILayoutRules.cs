namespace HXML.NET.Styles.Interfaces;

public interface ILayoutRules
{
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
}