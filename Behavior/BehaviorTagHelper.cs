using HXML.NET.Behavior.Abstracts;
using HXML.NET.Behavior.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Behavior;



public class BehaviorTagHelper : AbstractBehaviorTagHelper, IBehaviorAttributes, IBehaviorAlertAttributes, IBehaviorShareAttributes
{
    public string? XmlnsAlert { get; set; }
    public string? AlertTitle { get; set; }
    public string? AlertMessage { get; set; }
    public string? XmlnsShare { get; set; }
    public string? ShareDialogTitle { get; set; }
    public string? ShareSubject { get; set; }
    public string? ShareMessage { get; set; }
    public string? ShareUrl { get; set; }
    public string? ShareTitle { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);

        output.TagName = "behavior";
        output.TagMode = TagMode.StartTagAndEndTag;

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
        
        if (!string.IsNullOrEmpty(XmlnsShare))
        {
            output.Attributes.Add("xmlns:share", XmlnsShare);
            if (!string.IsNullOrEmpty(ShareDialogTitle))
            {
                output.Attributes.Add("share:dialog-title", ShareDialogTitle);
            }
            if (!string.IsNullOrEmpty(ShareSubject))
            {
                output.Attributes.Add("share:subject", ShareSubject);
            }
            if (!string.IsNullOrEmpty(ShareMessage))
            {
                output.Attributes.Add("share:message", ShareMessage);
            }
            if (!string.IsNullOrEmpty(ShareUrl))
            {
                output.Attributes.Add("share:url", ShareUrl);
            }
            if (!string.IsNullOrEmpty(ShareTitle))
            {
                output.Attributes.Add("share:title", ShareTitle);
            }
        }
    }
}