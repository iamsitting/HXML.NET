using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class ViewTagHelper : AbstractBehaviorTagHelper
{
    public bool? SafeArea { get; set; }
    public string? Style { get; set; }
    public string? ContentContainerStyle { get; set; }
    public bool? Scroll { get; set; }
    public string? ScrollOrientation { get; set; }
    public int? ScrollToInputOffset { get; set; }
    public bool? ShowsScrollIndicator { get; set; }
    public string? Id { get; set; }
    public bool? Hide { get; set; }
    public bool? AvoidKeyboard { get; set; }
    public bool? Sticky { get; set; }
    public string? KeyboardDismissMode { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.TagName = "view";
        output.TagMode = TagMode.StartTagAndEndTag;
        if (!string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }
        
        if (!string.IsNullOrEmpty(Style))
        {
            output.Attributes.Add("style", Style);
        }
        
        if (SafeArea != null)
        {
            output.Attributes.Add("safe-area", SafeArea);
        }
        
        if (Hide != null)
        {
            output.Attributes.Add("hide", Hide);
        }
        if (!string.IsNullOrEmpty(ContentContainerStyle))
        {
            output.Attributes.Add("content-container-style", ContentContainerStyle);
        }
        if (Scroll != null)
        {
            output.Attributes.Add("scroll", Scroll);
        }
        if (!string.IsNullOrEmpty(ScrollOrientation))
        {
            output.Attributes.Add("scroll-orientation", ScrollOrientation);
        }
        if (ScrollToInputOffset != null)
        {
            output.Attributes.Add("scroll-to-input-offset", ScrollToInputOffset);
        }
        if (ShowsScrollIndicator != null)
        {
            output.Attributes.Add("shows-scroll-indicator", ShowsScrollIndicator);
        }
        if (AvoidKeyboard != null)
        {
            output.Attributes.Add("avoid-keyboard", AvoidKeyboard);
        }
        if (Sticky != null)
        {
            output.Attributes.Add("sticky", Sticky);
        }
        if (!string.IsNullOrEmpty(KeyboardDismissMode))
        {
            output.Attributes.Add("keyboard-dismiss-mode", KeyboardDismissMode);
        }
    }
}