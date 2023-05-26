using Microsoft.AspNetCore.SignalR;

namespace SignalRWebpack.Hubs;

public class ChatHub : Hub
{
  public async Task CreditAssessmentUpdate(Object body) => await Clients.All.SendAsync("creditAssessmentUpdate", body);
}

