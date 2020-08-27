using System.Collections.Generic;

namespace AspZeroDemo.AbpZeroDemo.Chat.Dto
{
    public class ChatUserWithMessagesDto : ChatUserDto
    {
        public List<ChatMessageDto> Messages { get; set; }
    }
}