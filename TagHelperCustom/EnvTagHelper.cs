using System;
using Microsoft.AspNet.Razor.TagHelpers;

namespace TagHelperCustom
{
    [HtmlTargetElement("env", Attributes = Names)]
    public class EnvTagHelper : TagHelper
    {
        private const string Names = "names";

        [HtmlAttributeName(Names)]
        public string NamesValue { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var varVal = Environment.GetEnvironmentVariable("Hosting:Environment");
            if (varVal == NamesValue || (string.IsNullOrEmpty(NamesValue) && string.IsNullOrEmpty(varVal)))
            {
                var childContent = output.GetChildContentAsync().Result;
                output.Content.AppendHtml(childContent.GetContent());
            }
            else
            {
                output.SuppressOutput();
            }
        }
    }
}
