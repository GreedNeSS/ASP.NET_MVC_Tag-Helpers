using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _8_OutputControl.TagHelpers
{
    public class HiddenTextTagHelper : TagHelper
    {
        public bool Condition { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!Condition)
            {
                output.SuppressOutput();
            }
            else
            {
                output.TagName = "div";
                output.TagMode = TagMode.StartTagAndEndTag;
            }
        }
    }
}
