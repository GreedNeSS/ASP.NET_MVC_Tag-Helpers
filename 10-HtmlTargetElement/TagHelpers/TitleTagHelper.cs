using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _10_HtmlTargetElement.TagHelpers
{
    [HtmlTargetElement(Attributes = "title")]
    public class TitleTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1";
            output.Attributes.RemoveAll("title");
        }
    }
}
