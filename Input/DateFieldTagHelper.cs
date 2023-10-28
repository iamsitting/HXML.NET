using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Input;

public class DateFieldTagHelper : AbstractBehaviorTagHelper
{
    public string Name { get; set; } = null!;
    public string LabelFormat { get; set; } = null!;
    public string? Mode { get; set; }
    public string? Value { get; set; }
    public string? Placeholder { get; set; }
    public string? Min { get; set; }
    public string? Max { get; set; }
    public string? FieldStyle { get; set; }
    public string? FieldTextStyle { get; set; }
    public string? ModalStyle { get; set; }
    public string? ModalTextStyle { get; set; }
    public int? ModalAnimationDuration { get; set; }
    public int? ModalOverlayAnimationDuration { get; set; }
    public int? ModalDismissAnimationDuration { get; set; }
    public int? ModalDismissOverlayAnimationDuration { get; set; }
    public string? Id { get; set; }
    public bool? Hide { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.Attributes.Add("name", Name);
        output.Attributes.Add("label-format", LabelFormat);
        if (!string.IsNullOrEmpty(Mode))
        {
            output.Attributes.Add("mode", Mode);
        }
        if (!string.IsNullOrEmpty(Value))
        {
            output.Attributes.Add("value", Value);
        }
        if (string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }

        if (Hide != null)
        {
            output.Attributes.Add("hide", Hide);
        }
        if (!string.IsNullOrEmpty(Min))
        {
            output.Attributes.Add("min", Min);
        }
        if (!string.IsNullOrEmpty(Placeholder))
        {
            output.Attributes.Add("placeholder", Placeholder);
        }
        if (!string.IsNullOrEmpty(Max))
        {
            output.Attributes.Add("max", Max);
        }
        if (!string.IsNullOrEmpty(Mode))
        {
            output.Attributes.Add("mode", Mode);
        }
        if (string.IsNullOrEmpty(FieldStyle))
        {
            output.Attributes.Add("field-style", FieldStyle);
        }
        
        if (string.IsNullOrEmpty(FieldTextStyle))
        {
            output.Attributes.Add("field-text-style", FieldTextStyle);
        }
        
        if (string.IsNullOrEmpty(ModalStyle))
        {
            output.Attributes.Add("modal-style", ModalStyle);
        }
        
        if (string.IsNullOrEmpty(ModalTextStyle))
        {
            output.Attributes.Add("modal-text-style", ModalTextStyle);
        }

        if (ModalAnimationDuration != null)
        {
            output.Attributes.Add("modal-animation-duration", ModalAnimationDuration);
        }
        
        if (ModalOverlayAnimationDuration != null)
        {
            output.Attributes.Add("modal-overlay-animation-duration", ModalOverlayAnimationDuration);
        }
        
        if (ModalDismissAnimationDuration != null)
        {
            output.Attributes.Add("modal-dismiss-animation-duration", ModalDismissAnimationDuration);
        }
        
        if (ModalDismissOverlayAnimationDuration != null)
        {
            output.Attributes.Add("modal-dismiss-overlay-animation-duration", ModalDismissOverlayAnimationDuration);
        }
    }
}