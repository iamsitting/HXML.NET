namespace HXML.NET.Styles.Interfaces;

public interface IViewRules
{
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