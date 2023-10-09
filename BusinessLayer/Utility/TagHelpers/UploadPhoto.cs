

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.Utility.TagHelpers;


public class UploadPhoto:TagHelper
{
    [Required(ErrorMessage = "Please select a file.")]
    [DataType(DataType.Upload)]
    public IFormFile ImageFile { get; set; }

    public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "input";
        output.TagMode = TagMode.SelfClosing;
        output.Attributes.RemoveAll("asp-for");
        output.Attributes.SetAttribute("type", "file");
        output.Attributes.SetAttribute("data-val", "true");

        if (ImageFile != null)
        {
            output.Attributes.SetAttribute("name", $"{ImageFile}");
        }

        return base.ProcessAsync(context, output);
    }
}
