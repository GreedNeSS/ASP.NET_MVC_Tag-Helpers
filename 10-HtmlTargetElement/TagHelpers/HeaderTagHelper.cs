using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _10_HtmlTargetElement.TagHelpers
{
    [HtmlTargetElement("article-header")]
    public class HeaderTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h2";
            output.Attributes.SetAttribute("style", "color:red;font-size=25px;");
            output.Attributes.RemoveAll("article-header");
        }
    }
}
