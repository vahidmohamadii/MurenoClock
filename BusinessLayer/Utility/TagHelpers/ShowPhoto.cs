

using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BusinessLayer.Utility.TagHelpers;

public class ShowPhoto:TagHelper
{
    public string? ImageFileName { get; set; }
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagMode = TagMode.StartTagAndEndTag;
        output.TagName = "img";
        output.Attributes.RemoveAll("style");
        output.Attributes.SetAttribute("style", "display:block;width:100px;height:100px;border:solid;");
        output.Attributes.SetAttribute("src", $"/Images/About/{ImageFileName}");

       
        base.Process(context, output);
    }
}
