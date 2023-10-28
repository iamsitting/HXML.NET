namespace HXML.NET.Behavior.Interfaces;

public interface IBehaviorShareAttributes
{
    public string? XmlnsShare { get; set; }
    public string? ShareDialogTitle { get; set; }
    public string? ShareSubject { get; set; }
    public string? ShareMessage { get; set; }
    public string? ShareUrl { get; set; }
    public string? ShareTitle { get; set; }
}