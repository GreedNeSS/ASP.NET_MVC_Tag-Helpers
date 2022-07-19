using Microsoft.AspNetCore.Razor.TagHelpers;
using _11_Models.Models;

namespace _11_Models.TagHelpers
{
    public class PersonInfoTagHelper : TagHelper
    {
        public Person? Person { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            string content = $"<h2>Информация о пользователе:</h2>\n<p>Id: {Person?.Id.ToString()}" +
                $"</p>\n<p>Name: {Person?.Name}</p>\n<p>Age: {Person?.Age}</p>";
            output.Content.SetHtmlContent(content);
        }
    }
}
