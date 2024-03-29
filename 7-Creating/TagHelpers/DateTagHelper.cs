﻿using Microsoft.AspNetCore.Razor.TagHelpers;

namespace _7_Creating.TagHelpers
{
    public class DateTagHelper: TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetContent($"Текущая дата: {DateTime.Now.ToString("dd.MM.yyyy")}");
        }
    }
}
