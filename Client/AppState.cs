using BlazorChatAppFinal01.Client.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChatAppFinal01.Client
{
    public class AppState
    {
        public string UserName {  get; set; }

        public Dictionary<string, int> Rooms = new Dictionary<string, int>();
      //  public List<(string RoomName, int NotificationCount)> Rooms { get; set; } = new List<(string, int)>(); 

        public string RoomsComaSeparated { get; set; }

        public Action AppStateUpdated { get; set; }

        public Room CurrentRoom { get; set; }
    }
}
