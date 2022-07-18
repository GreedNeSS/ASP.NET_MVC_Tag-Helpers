using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _7_Creating.TagHelpers
{
    public class SummaryTagHelper: TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var target = await output.GetChildContentAsync();
            var content = "<h2>Общая информация</h2>" + target.GetContent();
            output.Content.SetHtmlContent(content);
        }
    }
}
