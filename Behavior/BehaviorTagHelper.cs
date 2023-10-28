using HXML.NET.Behavior.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Behavior;



public class BehaviorTagHelper : TagHelper, IBehaviorAttributes, IBehaviorAlertAttributes
{
    public string? Trigger { get; set; }
    public string Href { get; set; } = null!;
    public string? Verb { get; set; }
    public string? Action { get; set; }
    public string? Target { get; set; }
    public string? ShowDuringLoad { get; set; }
    public string? HideDuringLoad { get; set; }
    public int? Delay { get; set; }
    public bool? Once { get; set; }
    public string? NewValue { get; set; }
    public string? XmlnsAlert { get; set; }
    public string? AlertTitle { get; set; }
    public string? AlertMessage { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "behavior";
        output.TagMode = TagMode.StartTagAndEndTag;
        
        output.Attributes.Add("href", Href);
        
        if (!string.IsNullOrEmpty(Trigger))
        {
            output.Attributes.Add("trigger", Trigger);
        }
        
        if (!string.IsNullOrEmpty(Verb))
        {
            output.Attributes.Add("verb", Verb);
        }
        
        if (!string.IsNullOrEmpty(Action))
        {
            output.Attributes.Add("action", Action);
            if (Action == Actions.SetValue)
            {
                output.Attributes.Add("new-value", NewValue);
            }
        }
        
        if (!string.IsNullOrEmpty(Target))
        {
            output.Attributes.Add("target", Target);
        }
        
        if (!string.IsNullOrEmpty(ShowDuringLoad))
        {
            output.Attributes.Add("show-during-load", ShowDuringLoad);
        }
        
        if (!string.IsNullOrEmpty(HideDuringLoad))
        {
            output.Attributes.Add("hide-during-load", HideDuringLoad);
        }
        
        if (Delay != null)
        {
            output.Attributes.Add("delay", Delay);
        }
        
        if (Once != null)
        {
            output.Attributes.Add("once", Once);
        }
        
        if (!string.IsNullOrEmpty(XmlnsAlert))
        {
            output.Attributes.Add("xmlns:alert", XmlnsAlert);
            if (!string.IsNullOrEmpty(AlertMessage))
            {
                output.Attributes.Add("alert:message", AlertMessage);
            }
            if (!string.IsNullOrEmpty(AlertTitle))
            {
                output.Attributes.Add("alert:title", AlertTitle);
            }
        }
    }
}