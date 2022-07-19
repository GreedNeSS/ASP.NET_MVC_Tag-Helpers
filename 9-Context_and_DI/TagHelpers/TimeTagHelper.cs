using Microsoft.AspNetCore.Razor.TagHelpers;
using _9_Context_and_DI.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace _9_Context_and_DI.TagHelpers
{
    public class TimeTagHelper : TagHelper
    {
        ITimeService _timeService;

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext? ViewContext { get; set; }

        public TimeTagHelper(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string? font = ViewContext?.HttpContext.Request.Query["font"];

            if (string.IsNullOrEmpty(font))
            {
                font = "Verdana";
            }

            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("style", $"font-family:{font};font-size:20px;");
            output.Content.SetContent("Текущее время: " + _timeService.GetTime());
        }
    }
}
