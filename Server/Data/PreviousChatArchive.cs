using BlazorChatAppFinal01.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatAppFinal01.Server.Data
{
    public class PreviousChatArchive
    {

        public Dictionary<string, List<ChatData>> Chats { get; set; } = new Dictionary<string, List<ChatData>>();
    }
}
