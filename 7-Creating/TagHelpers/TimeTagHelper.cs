using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _7_Creating.TagHelpers
{
    public class TimeTagHelper: TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetContent($"Текущее время: {DateTime.Now.ToString("HH:mm:ss")}");
        }
    }
}
