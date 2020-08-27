using System.Collections.Generic;
using Abp;
using AspZeroDemo.AbpZeroDemo.Chat.Dto;
using AspZeroDemo.AbpZeroDemo.Dto;

namespace AspZeroDemo.AbpZeroDemo.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
