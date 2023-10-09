using BusinessLayer.Dtos.Common;

namespace BusinessLayer.Dtos.Language;

public class LanguageDto: BaseDto<LanguageDto, DataLayer.Entities.Language, int>
{
    public string Title { get; set; }
}
