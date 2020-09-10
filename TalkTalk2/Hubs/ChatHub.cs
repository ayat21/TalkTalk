using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalkTalk2.Models;

namespace TalkTalk2.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessages(Message message)
        {
            await Clients.All.SendAsync("receiveMessage", message);
        }
    }
}
