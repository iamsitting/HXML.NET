namespace HXML.NET.Behavior.Interfaces;

public interface IBehaviorAttributes
{
    public string? Trigger { get; set; }
    public string Href { get; set; }
    public string? Verb { get; set; }
    public string? Action { get; set; }
    public string? Target { get; set; }
    public string? ShowDuringLoad { get; set; }
    public string? HideDuringLoad { get; set; }
    public int? Delay { get; set; }
    public bool? Once { get; set; }
    public string? NewValue { get; set; }
}