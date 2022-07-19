using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _11_Models.TagHelpers
{
    public class ListTagHelper : TagHelper
    {
        public IEnumerable<string> Elements { get; set; } = new List<string>();

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            output.TagMode = TagMode.StartTagAndEndTag;
            string listContent = string.Empty;

            foreach (string element in Elements)
            {
                listContent += $"<li>{element}</li>";
            }

            output.Content.SetHtmlContent(listContent);
        }
    }
}
