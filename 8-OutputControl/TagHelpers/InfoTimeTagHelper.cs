using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _8_OutputControl.TagHelpers
{
    public class InfoTimeTagHelper : TagHelper
    {
        public string? Color { get; set; }
        public bool SecondIncluded { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var content = "Время: ";
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.PreElement.SetHtmlContent("<h2>Дата и время!</h2>");
            output.Attributes.SetAttribute("class", "timer");
            output.PostElement.SetHtmlContent($"<div>Дата: {DateTime.Now.ToString("dd.MM.yyyy")}</div>");

            if (Color is not null) output.Attributes.SetAttribute("style", $"color:{Color}");

            if (SecondIncluded)
            {
                content += $"{DateTime.Now.ToString("HH:mm:ss")}";
            }
            else
            {
                content += $"{DateTime.Now.ToString("HH:mm")}";
            }
            output.Content.SetContent(content);
        }
    }
}
