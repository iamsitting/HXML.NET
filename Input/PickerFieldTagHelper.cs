using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Input;

public class PickerFieldTagHelper : AbstractBehaviorTagHelper
{
    public string Name { get; set; } = null!;
    public string? Value { get; set; }
    public string? Id { get; set; }
    public bool? Hide { get; set; }
    public string? PlaceHolder { get; set; }
    public string? DoneLabel { get; set; }
    public string? CancelLabel { get; set; }
    public string? FieldStyle { get; set; }
    public string? FieldTextStyle { get; set; }
    public string? ModalStyle { get; set; }
    public string? ModalTextStyle { get; set; }
    public int? ModalAnimationDuration { get; set; }
    public int? ModalOverlayAnimationDuration { get; set; }
    public int? ModalDismissAnimationDuration { get; set; }
    public int? ModalDismissOverlayAnimationDuration { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.Attributes.Add("name", Name);

        if (string.IsNullOrEmpty(Value))
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
        
        if (string.IsNullOrEmpty(PlaceHolder))
        {
            output.Attributes.Add("placeholder", PlaceHolder);
        }
        
        if (string.IsNullOrEmpty(DoneLabel))
        {
            output.Attributes.Add("done-label", DoneLabel);
        }
        
        if (string.IsNullOrEmpty(CancelLabel))
        {
            output.Attributes.Add("cancel-label", CancelLabel);
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