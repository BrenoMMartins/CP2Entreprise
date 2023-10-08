using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Fiap.Web.Aula02.TagHelpers
{
    public class AlertTagHelper :TagHelper
    {
        public string? Mensagem { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "alert alert-success");
            output.Content.SetContent(Mensagem);
        }


    }
}
