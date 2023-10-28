namespace HXML.NET.Styles.Interfaces;

public interface IStyleTextRules
{
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