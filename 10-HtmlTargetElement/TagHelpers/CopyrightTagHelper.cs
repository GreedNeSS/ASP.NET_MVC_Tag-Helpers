using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _10_HtmlTargetElement.TagHelpers
{
    [HtmlTargetElement(ParentTag = "footer", Attributes = "cr")]
    public class CopyrightTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.RemoveAll("cr");
            output.Attributes.SetAttribute("style", "text-align:center;color:grey;");
            var content = await output.GetChildContentAsync();
            output.Content.SetContent($"Copyright © {content.GetContent()}, {DateTime.Now.ToString("yyyy")}. Все права защищены.");
        }
    }
}
