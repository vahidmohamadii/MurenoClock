
using BusinessLayer.Repository;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BusinessLayer.Utility.TagHelpers;


public class Paging : TagHelper
{

    public int totalpages { get; set; }
    public int currentpage { get; set; }
    public string linkurl { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {


        output.TagMode = TagMode.StartTagAndEndTag;
        var url = context.AllAttributes["linkurl"].Value;
        output.TagName = "div";
        output.PreContent.SetHtmlContent(@"<ul class=""pagination"">");
        for (var i = 1; i <= totalpages; i++)
        {
            output.Content.AppendHtml($@"<li class=""{(i == currentpage ? "active" : "")}""><a href=""{url}?page={i}""  title=""Click to go to page {i}"">{i}</a></li>");
        }
        output.PostContent.SetHtmlContent("</ul>");
        output.Attributes.Clear();
    }
}

