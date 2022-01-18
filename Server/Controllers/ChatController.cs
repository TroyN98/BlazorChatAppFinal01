using BlazorChatAppFinal01.Server.Data;
using BlazorChatAppFinal01.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatAppFinal01.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private PreviousChatArchive previousChatArchive;

        public ChatController(PreviousChatArchive previousChatArchive)
        { 
            this.previousChatArchive = previousChatArchive; 
        }


        [HttpGet("{roomName}")]
        public IEnumerable<ChatData> Get([FromRoute]string roomName)
        {

            if (previousChatArchive.Chats.ContainsKey(roomName))
            {
                return previousChatArchive.Chats[roomName];

            }
            else
            {
                return new ChatData[0];
            }
            

        }
    }
}
