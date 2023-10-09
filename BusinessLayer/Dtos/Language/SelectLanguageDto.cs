

using BusinessLayer.Dtos.Common;

namespace BusinessLayer.Dtos.Language;

public class SelectLanguageDto: BaseDto<SelectLanguageDto, DataLayer.Entities.Language, int>
{
    public string Title { get; set; }
}
