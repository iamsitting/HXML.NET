using HXML.NET.Behavior.Abstracts;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HXML.NET.Input;

public static class KeyboardTypes
{
    public const string Default = "default";
    public const string NumberPad = "number-pad";
    public const string DecimalPad = "decimal-pad";
    public const string PhonePad = "phone-pad";
    public const string EmailAddress = "email-address";
    public const string Url = "url";
    public const string AsciiCapable = "ascii-capable";
    public const string NumbersAndPunctuation = "numbers-and-punctuation";
    public const string NamePhonePad = "name-phone-pad";
    public const string Twitter = "twitter";
    public const string WebSearch = "web-search";
}

public class TextFieldTagHelper : AbstractBehaviorTagHelper
{
    public string Name { get; set; } = null!;
    public string? Value { get; set; }
    public string? Placeholder { get; set; }
    public bool? Multiline { get; set; }
    public string? KeyboardType { get; set; }
    public string Mask { get; set; }
    public string? Style { get; set; }
    public string? Id { get; set; }
    public bool? Hide { get; set; }
    public bool? AutoFocus { get; set; }
    public bool? SecureText { get; set; }
    public string? TextContentType { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        base.Process(context, output);
        output.TagName = "text-field";
        output.TagMode = TagMode.SelfClosing;
        output.Attributes.Add("name", Name);
        if (!string.IsNullOrEmpty(Value))
        {
            output.Attributes.Add("value", Value);
        }
        if (!string.IsNullOrEmpty(Placeholder))
        {
            output.Attributes.Add("placeholder", Placeholder);
        }
        if (!string.IsNullOrEmpty(KeyboardType))
        {
            output.Attributes.Add("keyboard-type", KeyboardType);
        }
        if (!string.IsNullOrEmpty(Mask))
        {
            output.Attributes.Add("mask", Mask);
        }
        if (!string.IsNullOrEmpty(Style))
        {
            output.Attributes.Add("style", Style);
        }
        if (!string.IsNullOrEmpty(Id))
        {
            output.Attributes.Add("id", Id);
        }
        if (!string.IsNullOrEmpty(TextContentType))
        {
            output.Attributes.Add("text-content-type", TextContentType);
        }
        if (Hide != null)
        {
            output.Attributes.Add("hide", Hide);
        }
        if (Multiline != null)
        {
            output.Attributes.Add("multiline", Multiline);
        }
        if (AutoFocus != null)
        {
            output.Attributes.Add("auto-focus", AutoFocus);
        }
        if (SecureText != null)
        {
            output.Attributes.Add("secure-text", SecureText);
        }
    }
}