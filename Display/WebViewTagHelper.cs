using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Display;

public class WebViewTagHelper : TagHelper
{
    public string? Url { get; set; }
    public string? Html { get; set; }
    public string? ActivityIndicatorColor { get; set; }
    public string? InjectedJavaScript { get; set; }
    public string? Id { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "web-view";
        output.TagMode = TagMode.SelfClosing;

        if (!string.IsNullOrEmpty(Url))
        {
            output.Attributes.Add("url", Url);
        }
        
        if (!string.IsNullOrEmpty(Html))
        {
            output.Attributes.Add("html", Html);
        }
        
        if (!string.IsNullOrEmpty(ActivityIndicatorColor))
        {
            output.Attributes.Add("activity-indicator-color", ActivityIndicatorColor);
        }
        if (!string.IsNullOrEmpty(InjectedJavaScript))
        {
            output.Attributes.Add("injected-java-script", InjectedJavaScript);
        }
        if (!string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }
    }
}