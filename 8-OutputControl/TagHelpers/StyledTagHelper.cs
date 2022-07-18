using Microsoft.AspNetCore.Razor.TagHelpers;
using _8_OutputControl.Models;

namespace _8_OutputControl.TagHelpers
{
    public class StyledTagHelper :TagHelper
    {
        public Styles Style { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            string styles = string.Empty;

            if (Style?.Color != null)
            {
                styles += $"color:{Style.Color};";
            }
            if (Style?.FontSize != null)
            {
                styles += $"font-size:{Style.FontSize};";
            }
            if (Style?.FontFamily != null)
            {
                styles += $"font-family:{Style.FontFamily};";
            }

            output.Attributes.Add("style", styles);
        }
    }
}
